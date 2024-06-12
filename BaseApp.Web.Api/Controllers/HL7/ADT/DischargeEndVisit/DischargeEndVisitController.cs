using BaseApp.IService.HL7.ADT.AdmitVisit;
using BaseApp.IService.HL7.ADT.DischargeEndVisit;
using BaseApp.IService.HL7.ADT.TransferPatient;
using BaseApp.Model.HL7.ADT.Admit_Visit_A01.HL7_A01_Model;
using BaseApp.Model.HL7.ADT.DischargeEndVisit_A03.DischargeEndVisit_Model_A03;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BaseApp.Web.Api.Controllers.HL7.ADT.DischargeEndVisit
{
    


    [Route("api/")]
    [ApiController]
    public class DischargeEndVisitController : Controller
    {
        protected readonly IDischargeEndVisitService _dischargeEndVisitService;
        protected readonly IConfiguration _configuration;

        public DischargeEndVisitController(IDischargeEndVisitService dischargeEndVisitService, IConfiguration configuration)
        {
            _dischargeEndVisitService = dischargeEndVisitService;
            _configuration = configuration;

        }
        /// <summary>
        /// Method used to create Role
        /// </summary>
        [HttpPost]
        [Route("FromJsonToHL7DischargeEndVisit")]
        public async Task<IActionResult> FromJsonToHL7DischargeEndVisit([FromBody] DischargeEndVisit_A03_Model model)
        {
            var result = "";
            try
            {
                result = _dischargeEndVisitService.FromJsonToHL7DischargeEndVisit(model);
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
        [Route("FromHL7ToJsonDischargeEndVisit")]
        public async Task<IActionResult> FromHL7ToJsonDischargeEndVisit(string hl7Message)
        {
            DischargeEndVisit_A03_Model result = new DischargeEndVisit_A03_Model();
            try
            {
                result = _dischargeEndVisitService.FromHL7ToJsonDischargeEndVisit(hl7Message);
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
