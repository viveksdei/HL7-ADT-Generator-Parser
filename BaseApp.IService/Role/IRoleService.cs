using BaseApp.Model.Role;


namespace BaseApp.IService.Role
{
    public interface IRoleService
    {
        Task<int> AddRoleAsync(RoleRequestModel model);
        Task<int> UpdateRoleAsync(RoleRequestModel model);
        Task<List<RoleListingModel>> GetAllRoleListAsync();
        Task<RoleListingModel> GetRoleDetailAsync(int roleId);
        Task <int>DeleteRoleAsync(int roleId, long userId);
    }
}
