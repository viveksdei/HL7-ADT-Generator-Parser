using BaseApp.IService.HL7.ADT.AdmitVisit;
using BaseApp.IService.HL7.ADT.TransferPatient;
using BaseApp.Model.HL7.ADT.Admit_Visit_A01.HL7_A01_Model;
using BaseApp.Model.HL7.ADT.TransferPatient_A02.TransferPatient_Model_A02;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BaseApp.Web.Api.Controllers.HL7.ADT.TransferPatient
{
   
    [Route("api/")]
    [ApiController]
    public class TransferPatientController : Controller
    {
        protected readonly ITransferPatientService _transferPatientService;
        protected readonly IConfiguration _configuration;

        public TransferPatientController(ITransferPatientService transferPatientService, IConfiguration configuration)
        {
            _transferPatientService = transferPatientService;
            _configuration = configuration;

        }
        /// <summary>
        /// Method used to create Role
        /// </summary>
        [HttpPost]
        [Route("FromJsonToHL7TransferPatient")]
        public async Task<IActionResult> FromJsonToHL7TransferPatient([FromBody] TransferPatient_A02_Model model)
        {
            var result = "";
            try
            {
                result = _transferPatientService.FromJsonToHL7TransferPatient(model);
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
        [Route("FromHL7ToJsonTransferPatient")]
        public async Task<IActionResult> FromHL7ToJsonTransferPatient(string hl7Message)
        {
            TransferPatient_A02_Model result = new TransferPatient_A02_Model();
            try
            {
                result = _transferPatientService.FromHL7ToJsonTransferPatient(hl7Message);
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
