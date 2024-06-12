using BaseApp.Model.HL7.ADT.Admit_Visit_A01.HL7_A01_Model;
using BaseApp.Model.HL7.ADT.DischargeEndVisit_A03.DischargeEndVisit_Model_A03;
using BaseApp.Model.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.IService.HL7.ADT.AdmitVisit
{

    public interface IAdmitVisitService
    {
        string FromJsonToHL7AdmitVisit(AdmitVisit_A01_Model admitVisit);
        AdmitVisit_A01_Model FromHL7ToJsonAdmitVisit(string admitVisit);
    }
}
