using BaseApp.Common;
using BaseApp.IRepository.Role;
using BaseApp.IService.Role;
using BaseApp.Model.Role;

namespace BaseApp.Service.Role
{
    public class RoleService:IRoleService
    {
        private readonly IRoleRepository _roleRepository;


        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<int> AddRoleAsync(RoleRequestModel model)
        {
            return await _roleRepository.AddRoleAsync(model);

        }

        /// <summary>
        /// Update the Role details in DB
        /// </summary>
        public async Task<int> UpdateRoleAsync(RoleRequestModel model)
        {
            return await _roleRepository.UpdateRoleAsync(model);
        }

        /// <summary>
        /// Method used to Get All Role List
        /// </summary>
        public async Task<List<RoleListingModel>> GetAllRoleListAsync()
        {
            List<RoleListingModel> facilities = (List<RoleListingModel>) await _roleRepository.GetAllRoleListAsync();

            return facilities;

        }

        /// <summary>
        /// Get the Role details by id from DB
        /// </summary>
        public async Task<RoleListingModel> GetRoleDetailAsync(int roleId)
        {
            return await _roleRepository.GetRoleDetailAsync(roleId);

        }

        /// <summary>
        /// delete the Role details fundId id from DB
        /// </summary>
        public async Task<int> DeleteRoleAsync(int roleId, long userId)
        {
            await _roleRepository.DeleteRoleAsync(roleId, userId);
            return 0;
        }
    }
}
