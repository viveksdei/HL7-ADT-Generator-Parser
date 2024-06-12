using Microsoft.AspNetCore.Mvc;
using System.Net;
using BaseApp.IService.Role;
using BaseApp.Model.Role;
using BaseApp.Model.Log;
using BaseApp.Common.Messages;

namespace BaseApp.Web.Api.Controllers.Role
{
    [Route("api/")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        protected readonly IRoleService _roleService;
        protected readonly IConfiguration _configuration;

        public RoleController(IRoleService roleService, IConfiguration configuration)
        {
            _roleService = roleService;
            _configuration = configuration;

        }
        /// <summary>
        /// Method used to create Role
        ///// </summary>
        //[HttpPost]
        //[Route("role/create")]
        //public async Task<IActionResult> CreateRoleAsync([FromBody] RoleRequestModel model)
        //{
        //    ResponseStatus<APIResponse> response = new();
        //    var result = await _roleService.AddRoleAsync(model);
        //    if (result>0)
        //    {
        //        response.Data = result;
        //        response.Messages = SuccessMessages.Success;
        //        response.StatusCode = HttpStatusCode.OK;
        //        return Ok(response);
        //    }
         
        //    else
        //    {
        //        response.Messages = SuccessMessages.Error;
        //        response.StatusCode = HttpStatusCode.NoContent;
        //        return NoContent();
        //    }
        //}

        ///// <summary>
        ///// Method used to update Role
        ///// </summary>
        //[HttpPut]
        //[Route("role/update")]
        //public async Task<IActionResult> UpdateRoleAsync([FromBody] RoleRequestModel model)
        //{
        //    ResponseStatus<dynamic> response = new();
        //    var result = await _roleService.UpdateRoleAsync(model);
        //    if (result != null)
        //    {
        //        response.Data = result;
        //        response.Messages = SuccessMessages.Success;
        //        response.StatusCode = HttpStatusCode.OK;
        //        return Ok(response);
        //    }
        //    else
        //    {
        //        response.Messages = SuccessMessages.Error;
        //        response.StatusCode = HttpStatusCode.NoContent;
        //        return NoContent();
        //    }
        //}

        ///// <summary>
        ///// Method used to get Role List
        ///// </summary>
        //[HttpGet]
        //[Route("role/list")]
        //public async Task<IActionResult> GetAllRoleListAsync()
        //{
        //    ResponseStatus<dynamic> response = new();
        //    var result = await _roleService.GetAllRoleListAsync();
        //    if (result != null)
        //    {
        //        response.Data = result;
        //        response.Messages = SuccessMessages.Success;
        //        response.StatusCode = HttpStatusCode.OK;
        //        return Ok(response);
        //    }
        //    else
        //    {
        //        response.Messages = SuccessMessages.Error;
        //        response.StatusCode = HttpStatusCode.NoContent;
        //        return NoContent();
        //    }
        //}

        ///// <summary>
        ///// Method used to get Role detail
        ///// </summary>
        //[HttpGet]
        //[Route("role/detail")]
        //public async Task<IActionResult> GetRoleDetailAsync(int roleId)
        //{
        //    ResponseStatus<dynamic> response = new();
        //    var result = await _roleService.GetRoleDetailAsync(roleId);
        //    if (result != null)
        //    {
        //        response.Data = result;
        //        response.Messages = SuccessMessages.Success;
        //        response.StatusCode = HttpStatusCode.OK;
        //        return Ok(response);
        //    }
        //    else
        //    {
        //        response.Messages = SuccessMessages.Error;
        //        response.StatusCode = HttpStatusCode.NoContent;
        //        return NoContent();
        //    }
        //}

        ///// <summary>
        ///// Method used to delete Role
        ///// </summary>
        //[HttpDelete]
        //[Route("role/delete")]
        //public async Task<IActionResult> DeleteRole(int roleId, long userId)
        //{
        //    ResponseStatus<dynamic> response = new();
        //    var result = await _roleService.DeleteRoleAsync(roleId, userId);
        //    if (result != null)
        //    {
        //        response.Data = result;
        //        response.Messages = SuccessMessages.Success;
        //        response.StatusCode = HttpStatusCode.OK;
        //        return Ok(response);
        //    }
        //    else
        //    {
        //        response.Messages = SuccessMessages.Error;
        //        response.StatusCode = HttpStatusCode.NoContent;
        //        return NoContent();
        //    }

        //}

    }
}
