using BaseApp.IRepository.Authentication;
using BaseApp.Model.Authentication;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace BaseApp.Repository.Authentication
{
    public class AuthenticationRepository : BaseRepository, IAuthenticationRepository
    {
        private readonly IConfiguration _configuration;

        public AuthenticationRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }      

        public async Task<int> Login(string email, string password)
        {
            string query = "SP_UserAuthentication";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Email", email, DbType.String, ParameterDirection.Input);
            parameters.Add("@Password", password, DbType.String, ParameterDirection.Input);
            return await GetAsync<int>(query, parameters, CommandType.StoredProcedure);
        }


        public async Task<int> SaveUserInformationAsync(AddUserDetailsModel model)
        {
            string query = "USP_SaveUserInfo";

            //DynamicParameters parameter = new DynamicParameters();
            var parameters = new DynamicParameters();
            //parameters.Add("@p_userid", model.UserId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@FirstName", model.FirstName, DbType.String, ParameterDirection.Input, 50);
            parameters.Add("@MiddleName", model.MiddleName, DbType.String, ParameterDirection.Input, 50);
            parameters.Add("@LastName", model.LastName, DbType.String, ParameterDirection.Input, 50);
            parameters.Add("@Email", model.Email, DbType.String, ParameterDirection.Input, 100);
            parameters.Add("@Phone", model.Phone, DbType.String, ParameterDirection.Input, 20);
            parameters.Add("@UserName", model.UserName, DbType.String, ParameterDirection.Input, 50);
            parameters.Add("@Password", model.Password, DbType.String, ParameterDirection.Input, 255);
            parameters.Add("@RoleId", model.RoleId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@IsVerified", model.IsVerified, DbType.Boolean, ParameterDirection.Input);
            parameters.Add("@IsLoggedIn", model.IsLoggedIn, DbType.Boolean, ParameterDirection.Input);
            parameters.Add("@IsActive", model.IsActive, DbType.Boolean, ParameterDirection.Input);
            parameters.Add("@CreatedBy", model.CreatedBy, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@CreatedDate", model.CreatedDate, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("@IsDeleted", model.IsDeleted, DbType.Boolean, ParameterDirection.Input);
            parameters.Add("@DeletedBy", model.DeletedBy, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@DeletedDate", model.DeletedDate, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("@PasswordSalt", model.PasswordSalt, DbType.String, ParameterDirection.Input, 255);

            return await GetFirstOrDefaultAsync<int>(query, parameters, CommandType.StoredProcedure);

        }

        public async Task<int> SaveUserPasswordAsync(int userId, string newPassword)
        {
            string query = "USP_ChangePassword";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@UserId", userId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@NewPassword", newPassword, DbType.String, ParameterDirection.Input);
            return await GetAsync<int>(query, parameters, CommandType.StoredProcedure);
        }

        public async Task<int> EmailCheck(string email)
        {
            string query = "USP_UserAuthenticationEmail";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Email", email, DbType.String, ParameterDirection.Input);           
            return await GetAsync<int>(query, parameters, CommandType.StoredProcedure);
        }


        public async Task UpdatePasswordAsync(string passwordHash, string passwordSalt, string email)
        {
            string query = "USP_ForgotPassword";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Email", email, DbType.String, ParameterDirection.Input);
            parameters.Add("@Password", passwordHash, DbType.String, ParameterDirection.Input);
            parameters.Add("@PasswordSalt", passwordSalt, DbType.String, ParameterDirection.Input);

            await AddAsync(query, parameters, CommandType.StoredProcedure);
        }


    }
}
