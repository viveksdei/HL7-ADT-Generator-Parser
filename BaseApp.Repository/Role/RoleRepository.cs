using BaseApp.IRepository.Role;
using BaseApp.Model.Role;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace BaseApp.Repository.Role
{
    public class RoleRepository: BaseRepository,IRoleRepository
    {
        private readonly IConfiguration _configuration;
        public RoleRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Method used to Get All Role List
        /// </summary>
        public async Task<IEnumerable<RoleListingModel>> GetAllRoleListAsync()
        {
            string query = "SP_ViewRoleList";

            //DynamicParameters parameter = new();
            //parameter.Add("@UserId", request.UserId, DbType.Int32, ParameterDirection.Input);
            //parameter.Add("@InActive", request.InActive, DbType.Boolean, ParameterDirection.Input);
            //parameter.Add("@FacilityAccessType", request.FacilityAccessType, DbType.Int32, ParameterDirection.Input);

            return await QueryAsync<RoleListingModel>(query, null, null, CommandType.StoredProcedure);
        }
        public async Task<int> AddRoleAsync(RoleRequestModel model)
        {
            string query = "SP_AddEditRole";

            DynamicParameters parameter = new();
            parameter.Add("@RoleName", model.RoleName, DbType.String, ParameterDirection.Input);
            parameter.Add("@IsActive", model.IsActive, DbType.Boolean, ParameterDirection.Input);

            return await ExecuteAsync(query, parameter, null, null, CommandType.StoredProcedure);

        }

        /// <summary>
        /// Update the Role details in DB
        /// </summary>
        public async Task<int> UpdateRoleAsync(RoleRequestModel model)
        {
            string query = "SP_AddEditRole";

            DynamicParameters parameter = new();
            parameter.Add("@RoleName", model.RoleName, DbType.String, ParameterDirection.Input);
            parameter.Add("@IsActive", model.IsActive, DbType.Boolean, ParameterDirection.Input);

            return await ExecuteAsync(query, parameter, null, null, CommandType.StoredProcedure);
        }

        /// <summary>
        /// Get the Role details by id from DB
        /// </summary>
        public async Task<RoleListingModel> GetRoleDetailAsync(int roleId)
        {
            string query = "SP_ViewRole";

            DynamicParameters parameter = new();
            parameter.Add("@roleId", roleId, DbType.Int32, ParameterDirection.Input);

            return await GetAsync<RoleListingModel>(query, parameter, CommandType.StoredProcedure);
        }

        /// <summary>
        /// delete the Role details fundId id from DB
        /// </summary>
        public async Task<int> DeleteRoleAsync(int roleId, long userId)
        {
            string query = "SP_DeleteRole";

            DynamicParameters parameter = new();
            parameter.Add("@roleId", roleId, DbType.Int32, ParameterDirection.Input);

            await ExecuteAsync(query, parameter, null, null, CommandType.StoredProcedure);
            return 0;
        }

    }
}
