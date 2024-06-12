using BaseApp.Model.Authentication;
using BaseApp.Model.Log;

namespace BaseApp.IService.Authentication
{
    public interface IAuthenticationService
    {
        /// <summary>
        ///<Description>Function to check user exits and create jwt if exits</Description>
        /// </summary>
        Task<string> LogInAsync(string? email, string? password);
        Task<APIResponse> SaveUserInformationAsync(AddUserDetailsModel model);

        Task<string> CheckEmailExistsAsync(string email);

        Task<APIResponse> ResetPasswordAsync(string email, string password);

        //Task<string> CheckEmailExists(string? email);

        //Task<APIResponse> ChangeUserPasswordAsync(int userId , string newPassword );



    }
}
