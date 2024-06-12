using BaseApp.Model.HL7.ADT.DischargeEndVisit_A03.DischargeEndVisit_Segment_A03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaseApp.Model.HL7.ADT.DischargeEndVisit_A03.DischargeEndVisit_Model_A03
{
    public class DischargeEndVisit_A03_Model
    {
        public MSHSegment_A03 MSH_Message_Header { get; set; } // (Required)
        public List<SFTSegment_A03>? SFT_Software_Segment { get; set; } // (Optional) (Repeatable)
        public List<UACSegment_A03>? UAC_User_Authentication_Creential { get; set; } // (Optional) 
        public EVNSegment_A03 EVN_Event_Type { get; set; } // (Required)
        public PIDSegment_A03 PID_Patient_Identification { get; set; } // (Required)
        public PD1Segment_A03 PD1_Patient_Additional_Demographic { get; set; } //(Optional)
        public List<ARVSegment_A03> ARV_Access_Restriction { get; set; } // A(Optional) (Repeatable)
        public List<ROLSegment_A03> ROL_Role { get; set; } // (Optional) (Repeatable)

        public List<NK1Segment_A03> NK1_Next_Kin { get; set; } //  (Optional) (Repeatable)
        public PV1Segment_A03 PV1_Patient_Visit { get; set; } //  (Required)
        public PV2Segment_A03 PV2_Patient_Visit_Additional { get; set; } //  (Optional)
        public List<ARVSegment_A03> ARV_AccessRestriction_Additional_Patient_Visit { get; set; } //  (Optional) (Repeatable)
        public List<ROLSegment_A03> ROL_Additional_Patient_Visit { get; set; } // (Optional) (Repeatable)
        public List<DB1Segment_A03> DB1_Disability { get; set; } //  (Optional) (Repeatable)
        public List<OBXSegment_A03> OBX_Observation_Result { get; set; } //(Optional) (Repeatable)
        public List<AL1Segment_A03> AL1_Patient_Allergy { get; set; } //  (Optional) (Repeatable)
        public List<DG1Segment_A03> DG1_Diagnosis { get; set; } //  (Optional) (Repeatable)
        public List<DRGSegment_A03> DRG_Diagnosis_Related_Group { get; set; } // (Optional)
        public Procedure Procedure { get; set; } //(Optional)
        public List<GT1Segment_A03> GT1_Gurantor { get; set; } //  (Optional) (Repeatable)
        public Insurance Insurance { get; set; } //(Optional)
        public ACCSegment_A03 ACC_Accident { get; set; } // (Optional)
       
        public PDASegment_A03 PDA_Patient_Death_Autopsy { get; set; } // (Optional)

        //public AdmitVisit_A03_Model(
        //    MSHSegment_A03 msh,
        //    EVNSegment_A03 evn,
        //    PIDSegment_A03 pid,
        //    PV1Segment_A03 pv1,
        //    PR1Segment_A03 pr1,
        //    IN1Segment_A03 in1)
        //{
        //    MSH_Message_Header = msh ?? throw new ArgumentNullException(nameof(msh));
        //    EVN_Event_Type = evn ?? throw new ArgumentNullException(nameof(evn));
        //    PID_Patient_Identification = pid ?? throw new ArgumentNullException(nameof(pid));
        //    PV1_Patient_Visit = pv1 ?? throw new ArgumentNullException(nameof(pv1));

        //    SFT_Software_Segment = new List<SFTSegment_A03>();
        //    UAC_User_Authentication_Creential = new List<UACSegment_A03>();
        //    ARV_Access_Restriction = new List<ARVSegment_A03>();
        //    ROL_Role = new List<ROLSegment_A03>();
        //    NK1_Next_Kin = new List<NK1Segment_A03>();
        //    ARV_AccessRestriction_Additional_Patient_Visit = new List<ARVSegment_A03>();
        //    ROL_Additional_Patient_Visit = new List<ROLSegment_A03>();
        //    DB1_Disability = new List<DB1Segment_A03>();
        //    OBX_Observation_Result = new List<OBXSegment_A03>();
        //    AL1_Patient_Allergy = new List<AL1Segment_A03>();
        //    DG1_Diagnosis = new List<DG1Segment_A03>();
        //    DRG_Diagnosis_Related_Group = new List<DRGSegment_A03>();
        //    GT1_Gurantor = new List<GT1Segment_A03>();

        //}
    }

    public class Procedure
    {
        public PR1Segment_A03 PR1_Procedures { get; set; } //(Required)
        public List<ROLSegment_A03> ROL_Procedure { get; set; } // (Optional) (Repeatable)
        //public Procedure(PR1Segment_A03 pr1)
        //{
        //    PR1_Procedures = pr1 ?? throw new ArgumentNullException(nameof(pr1));
        //    ROL_Procedure = new List<ROLSegment_A03>();
        //}
    }
    public class Insurance
    {
        public IN1Segment_A03 IN1_Insurance { get; set; } // (Required)
        public List<IN2Segment_A03> IN2_Insurance_Additinal_Inforamtion { get; set; } // (Optional)
        public List<IN3Segment_A03> IN3_Insurance_Additinal_Inforamtion_Certification { get; set; } // (Optional) (Repeatable)
        public List<ROLSegment_A03> ROL_Insurance { get; set; } // (Optional) (Repeatable)
        public List<AUTSegment_A03> AUT_Authorization_Information { get; set; } // (Optional) (Repeatable)
        public List<RF1Segment_A03> RF1_Referral_Information { get; set; } // (Optional) (Repeatable)
        //public Insurance(IN1Segment_A03 IN1)
        //{

        //    IN1_Insurance = IN1 ?? throw new ArgumentNullException(nameof(IN1));
        //    IN2_Insurance_Additinal_Inforamtion = new List<IN2Segment_A03>();
        //    IN3_Insurance_Additinal_Inforamtion_Certification = new List<IN3Segment_A03>();
        //    ROL_Insurance = new List<ROLSegment_A03>();
        //    RF1_Referral_Information = new List<RF1Segment_A03>();
        //}
    }
}
