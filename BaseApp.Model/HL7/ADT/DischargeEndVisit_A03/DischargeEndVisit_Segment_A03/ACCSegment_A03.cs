using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.DischargeEndVisit_A03.DischargeEndVisit_Segment_A03
{
    public class ACCSegment_A03
    {
        public string? ACC_1_AccidentDateTime { get; set; } // Optional
        public string? ACC_2_AccidentCode { get; set; } // Optional
        public string? ACC_3_AccidentLocation { get; set; } // Optional
        public string? ACC_4_AutoAccidentState { get; set; } // Optional
        public string? ACC_5_AccidentJobRelatedIndicator { get; set; } // Optional
        public string? ACC_6_AccidentDeathIndicator { get; set; } // Optional
        public string? ACC_7_EnteredBy { get; set; } // Optional
        public string? ACC_8_AccidentDescription { get; set; } // Optional
        public string? ACC_9_BroughtInBy { get; set; } // Optional
        public string? ACC_10_PoliceNotifiedIndicator { get; set; } // Optional
        public string? ACC_11_AccidentAddress { get; set; } // Optional
        public string? ACC_12_DegreeOfPatientLiability { get; set; } // Optional
        public List<string>? ACC_13_AccidentIdentifier { get; set; } // Optional

        //public ACCSegment_A01()
        //{
        //    ACC_13_AccidentIdentifier = new List<string>();
        //}
    }
}
