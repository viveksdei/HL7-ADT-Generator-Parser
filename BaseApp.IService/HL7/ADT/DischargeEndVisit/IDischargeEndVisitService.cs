using BaseApp.Model.HL7.ADT.DischargeEndVisit_A03.DischargeEndVisit_Model_A03;
using BaseApp.Model.HL7.ADT.TransferPatient_A02.TransferPatient_Model_A02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.IService.HL7.ADT.DischargeEndVisit
{
    public interface IDischargeEndVisitService
    {
        string FromJsonToHL7DischargeEndVisit(DischargeEndVisit_A03_Model dischargeEndVisit);
        DischargeEndVisit_A03_Model FromHL7ToJsonDischargeEndVisit(string dischargeEndVisitHL7);

    
        
    }
}
