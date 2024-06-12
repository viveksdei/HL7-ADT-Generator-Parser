using BaseApp.Common;
using BaseApp.Common.Enum;
using BaseApp.IRepository.Authentication;
using BaseApp.IService.Authentication;
using BaseApp.Model.Authentication;
using BaseApp.Model.Log;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;


namespace BaseApp.Service.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {       
        private readonly IAuthenticationRepository _authenticationRepository;
        private readonly IConfiguration _configuration;
        private readonly string _tokenURL;

        public AuthenticationService(IAuthenticationRepository authenticationRepository, IConfiguration configuration)
        {           
            _authenticationRepository = authenticationRepository;
            _configuration = configuration;
        }

        public async Task<string> LogInAsync(string email, string password)
        {
            APIResponse response = null;
            
            var isUserValid = await _authenticationRepository.Login(email, password);

              if (isUserValid == 1)  //(int)StatusCodesEnum.LoginSucess)
              {            
                return  await GenerateJWTToken(email, password);
              }
            return "User not exists";

        }

        public async Task<string> GenerateJWTToken(string username, string password)
        {
                    //create claims details based on the user information
                    var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),                                           
                        new Claim("UserName", username),
                        new Claim("Password", password)

                    };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        _configuration["Jwt:Issuer"],
                        _configuration["Jwt:Audience"],
                        claims,
                        expires: DateTime.UtcNow.AddMinutes(2),
                        signingCredentials: signIn);

                    return new JwtSecurityTokenHandler().WriteToken(token);
        }

        #region Save User Details
        // <summary>
        // This method is used for saving user details,
        // </summary>
        public async Task<APIResponse> SaveUserInformationAsync(AddUserDetailsModel model)
        {
            // Encryption Logic for Password
            model.PasswordSalt = PasswordSHA512CryptoProvider.CreateSalt();
            model.Password = PasswordSHA512CryptoProvider.CreateHash(model.Password, model.PasswordSalt);
            var isUserValid = await _authenticationRepository.Login(model.Email, model.Password);
            
            if (isUserValid ==0)
            {
                int userId = await _authenticationRepository.SaveUserInformationAsync(model);

                return new APIResponse(StatusCodesEnum.Success, userId);
            }

            return new APIResponse(StatusCodesEnum.Success, model.Password);
          
        }
        #endregion


        public async Task<string> CheckEmailExistsAsync(string email)
        {
            APIResponse response = null;
            var isUserValid = await _authenticationRepository.EmailCheck(email);

            if (isUserValid == 1)  //(int)StatusCodesEnum.LoginSucess)
            {
                var token = GenerateToken();
                // Get the current time
                //DateTime currentTime = DateTime.UtcNow;
                //TimeSpan expirationDuration = TimeSpan.FromSeconds(30);               
                //DateTime expirationTime = currentTime.Add(expirationDuration);
                //long expirationTimestamp = ((DateTimeOffset)expirationTime).ToUnixTimeSeconds();
                // Generate the URL
                //string urlWithExpiration = originalUrl + "?expires=" + expirationTimestamp;
                //string resetLink = $"https://example.com/reset-password?token={HttpUtility.UrlEncode(token)}";
                string originalUrl = "http://localhost:4200/auth/change_password";                               
                string resetLink = originalUrl;
                string fromEmail = "navjot.sodhi567@gmail.com";
                string fromPassword = "nevlmqfzszycwdoz";
            
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(fromEmail);
                mailMessage.To.Add("navjot.sodhi567@gmail.com");
                mailMessage.Subject = "Password Reset Request";
                mailMessage.Body = $"Click the following link to reset your password: {resetLink}";
               // mailMessage.Body = "$\"Dear user,\\n\\nYou have requested to reset your password. Please click the following link to reset your password:\\n\\n{resetUrl}\\n\\nThis link is valid for 5 days.\\n\\nIf you did not request this password reset, please ignore this email.\\n\\nBest regards,\\BaseApp\";";
                mailMessage.IsBodyHtml = true;
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromEmail, fromPassword),
                    EnableSsl = true,
                };

                smtpClient.Send(mailMessage);
            }
            else
            {
                return "User not exists";
            }

            return "Email Sent Successfully";
        }


        private string GenerateToken()
        {
            // Generate a unique token for the password reset link
            var tokenBytes = new byte[32];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(tokenBytes);
            }

            return Convert.ToBase64String(tokenBytes);

        }

        /// <summary>
        ///<Description>Method to reset password with user id and new password.</Description>
        /// </summary>
        public async Task<APIResponse> ResetPasswordAsync(string email, string password)
        {
            StatusCodesEnum statusCode;
            {
                string passwordSalt = PasswordSHA512CryptoProvider.CreateSalt();
                string passwordHash = PasswordSHA512CryptoProvider.CreateHash(password, passwordSalt);
                await _authenticationRepository.UpdatePasswordAsync(passwordHash, passwordSalt, email);
                statusCode = StatusCodesEnum.PasswordUpdatedSuccessFully;               
            }
            return new APIResponse(statusCode,"");

        }




        //#region Change UserPassword 
        //// <summary>
        //// This method is used for changing user password,
        //// </summary>
        //public async Task<APIResponse> ChangeUserPasswordAsync(int userId, string newPassword )
        //{
        //    // Encryption Logic for Password
        //    string PasswordSalt = PasswordSHA512CryptoProvider.CreateSalt();
        //    newPassword = PasswordSHA512CryptoProvider.CreateHash(newPassword, PasswordSalt);
        //    var isUserValid = await _authenticationRepository.Login(model.Email, model.Password);

        //    if (isUserValid == 0)
        //    {
        //        int userId = await _authenticationRepository.SaveUserPasswordAsync(model);

        //        return new APIResponse(StatusCodesEnum.Success, userId);
        //    }

        //    return new APIResponse(StatusCodesEnum.Success, model.Password);

        //}
        //#endregion




    }
}
