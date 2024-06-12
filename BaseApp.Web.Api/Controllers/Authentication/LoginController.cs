using BaseApp.Common.Messages;
using BaseApp.IService.Authentication;
using BaseApp.IService.Log;
using BaseApp.Model.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace BaseApp.Web.Api.Controllers.Authentication
{
  
  
    [ApiController]
    [Route("api/Login")]
    public class LoginController : ControllerBase
    {
        protected readonly IAuthenticationService _authenticationService;
        protected readonly IConfiguration _configuration;

        public LoginController(IAuthenticationService authentication,IConfiguration configuration)
        {
            _authenticationService = authentication;
            _configuration = configuration;

        }
     //   /// <summary>
     //   ///<Description>Method to check the user credentials</Description>
     //   /// </summary>
     //   [HttpPost]
     //   [Route("LoginDetailAsync")]
     ////   [FILTER]
     //   public async Task<IActionResult> LoginDetailAsync([FromBody] LoginInputApiModel model)
     //   {
     //       ResponseStatus<dynamic> response = new();

     //       var data = await _authenticationService.LogInAsync(model.Email, model.Password);
     //       return new JsonResult(data);

     //   }

     //   #region Save User Details
     //   /// <summary>
     //   ///<Description>Function to save user details.</Description>
     //   /// </summary>
     //   [HttpPost]
     //   [Authorize]
     //   [Route("SaveUserInformationAsync")]
     //   public async Task<IActionResult> SaveUserInformationAsync([FromBody] AddUserDetailsModel objModel)
     //   {
     //       return Ok(await _authenticationService.SaveUserInformationAsync(objModel));
     //   }
     //   #endregion

     //   #region ForgotPassword
     //   [HttpPost]
     //   [Route("ForgotPassword")]
     //   public IActionResult ForgotPassword(string email)
     //   {
     //       var data = _authenticationService.CheckEmailExistsAsync(email);                 
     //       return Ok("");
     //   }

     //   #endregion

     //   /// <Summary>
     //   ///<Descripton>It will Update User Password</Descripton>
     //   ///<Description>Existing Plain password will also be saved as Encrypted</Description>
     //   /// </Summary>
     //   [HttpPost]
     //   [Route("reset/password")]
     //   public async Task<IActionResult> ResetPassword([FromBody] PasswordModel model)
     //   {
     //       return Ok(await _authenticationService.ResetPasswordAsync(model.Email, model.Newpassword));
     //   }

    }
}
