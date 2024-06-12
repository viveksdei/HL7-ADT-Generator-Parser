using BaseApp.Common.Messages;
using BaseApp.IService.HL7.ADT.AdmitVisit;
using BaseApp.IService.Role;
using BaseApp.Model.HL7.ADT.Admit_Visit_A01.HL7_A01_Model;
using BaseApp.Model.HL7.ADT.DischargeEndVisit_A03.DischargeEndVisit_Model_A03;
using BaseApp.Model.Log;
using BaseApp.Model.Role;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace BaseApp.Web.Api.Controllers.HL7.ADT.AdmitVisit
{

    [Route("api/")]
    [ApiController]
    public class AdmitVisitNotificationController : Controller
    {
        protected readonly IAdmitVisitService _admitVisitService;
        protected readonly IConfiguration _configuration;

        public AdmitVisitNotificationController(IAdmitVisitService admitVisitService, IConfiguration configuration)
        {
            _admitVisitService = admitVisitService;
            _configuration = configuration;

        }
        /// <summary>
        /// Method used to create Role
        /// </summary>
        [HttpPost]
        [Route("FromJsonToHL7AdmitVisit")]
        public async Task<IActionResult> FromJsonToHL7AdmitVisit([FromBody]AdmitVisit_A01_Model model)
        {
            var result = "";
            try
            {
                 result = _admitVisitService.FromJsonToHL7AdmitVisit(model);
                // Use your model here
            }
            catch (JsonException ex)
            {
                // Handle JSON parsing error
                Console.WriteLine($"JSON parsing error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle other errors
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
          
         
                
                return Ok(result);
           
        }
        [HttpPost]
        [Route("FromHL7ToJsonAdmitVisit")]
        public async Task<IActionResult> FromHL7ToJsonAdmitVisit(string hl7Message)
        {
            AdmitVisit_A01_Model result = new AdmitVisit_A01_Model();
            try
            {
                result = _admitVisitService.FromHL7ToJsonAdmitVisit(hl7Message);
                // Use your model here
            }
            catch (JsonException ex)
            {
                // Handle JSON parsing error
                Console.WriteLine($"JSON parsing error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle other errors
                Console.WriteLine($"An error occurred: {ex.Message}");
            }



            return Ok(result);

        }

    }
}
