using BaseApp.Model.Authentication;


namespace BaseApp.IRepository.Authentication
{
    public interface IAuthenticationRepository
    {
        Task<int> Login(string email, string password);
        Task<int> SaveUserInformationAsync(AddUserDetailsModel model);
        Task<int> EmailCheck(string email);
        Task UpdatePasswordAsync(string passwordHash, string passwordSalt, string email);

    }
}
