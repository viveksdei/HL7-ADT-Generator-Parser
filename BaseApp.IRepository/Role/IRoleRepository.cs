using BaseApp.Model.Role;


namespace BaseApp.IRepository.Role
{
    public interface IRoleRepository
    {
        Task<int> AddRoleAsync(RoleRequestModel model);
        Task<int> UpdateRoleAsync(RoleRequestModel model);
        Task<IEnumerable<RoleListingModel>> GetAllRoleListAsync();
        Task<RoleListingModel> GetRoleDetailAsync(int roleId);
        Task<int> DeleteRoleAsync(int roleId, long userId);
    }
}
