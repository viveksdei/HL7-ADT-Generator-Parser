using BaseApp.Model.HL7.ADT.Admit_Visit_A01.AdmitVisi_Segment_A01;
using BaseApp.Model.HL7.ADT.TransferPatient_A02.TranserPatient_Segment_A02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.TransferPatient_A02.TransferPatient_Model_A02
{
    public class TransferPatient_A02_Model
    {

        public MSHSegment_A02? MSH_Message_Header { get; set; } // (Required)
        public List<SFTSegment_A02>? SFT_Software_Segment { get; set; } // (Optional) (Repeatable)
        public List<UACSegment_A02>? UAC_User_Authentication_Creential { get; set; } // (Optional) 
        public EVNSegment_A02 EVN_Event_Type { get; set; } // (Required)
        public PIDSegment_A02? PID_Patient_Identification { get; set; } // (Required)
        public PD1Segment_A02? PD1_Patient_Additional_Demographic { get; set; } //(Optional)
        public List<ARVSegment_A02>? ARV_Access_Restriction { get; set; } // A(Optional) (Repeatable)
        public List<ROLSegment_A02>? ROL_Role { get; set; } // (Optional) (Repeatable)

        public PV1Segment_A02? PV1_Patient_Visit { get; set; } //  (Required)
        public PV2Segment_A02? PV2_Patient_Visit_Additional { get; set; } //  (Optional)
        public List<ARVSegment_A02>? ARV_AccessRestriction_Additional_Patient_Visit { get; set; } //  (Optional) (Repeatable)
        public List<ROLSegment_A02>? ROL_Additional_Patient_Visit { get; set; } // (Optional) (Repeatable)
        public List<DB1Segment_A02>? DB1_Disability { get; set; } //  (Optional) (Repeatable)
        public List<OBXSegment_A02>? OBX_Observation_Result { get; set; } //(Optional) (Repeatable)
        public PDASegment_A02? PDA_Patient_Death_Autopsy { get; set; } // (Optional)
    }
}
