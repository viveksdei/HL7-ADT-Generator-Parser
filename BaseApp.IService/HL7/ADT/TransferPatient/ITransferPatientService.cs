using BaseApp.Model.HL7.ADT.TransferPatient_A02.TransferPatient_Model_A02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.IService.HL7.ADT.TransferPatient
{
    public interface ITransferPatientService
    {
        string FromJsonToHL7TransferPatient(TransferPatient_A02_Model transferPatient);
        TransferPatient_A02_Model FromHL7ToJsonTransferPatient(string transferPatientHL7);
    }
}
