using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseApp.Model.HL7.ADT.Admit_Visit_A01.AdmitVisi_Segment_A01;
using BaseApp.Model.HL7.ADT.DischargeEndVisit_A03.DischargeEndVisit_Segment_A03;
using BaseApp.Model.HL7.ADT.TransferPatient_A02.TranserPatient_Segment_A02;

namespace BaseApp.Model.HL7.ADT.Admit_Visit_A01.HL7_A01_Model
{
    public class AdmitVisit_A01_Model
    {
        public MSHSegment_A01 MSH_Message_Header { get; set; } // (Required)
        public List<SFTSegment_A01>? SFT_Software_Segment { get; set; } // (Optional) (Repeatable)
        public List<UACSegment_A01>? UAC_User_Authentication_Creential { get; set; } // (Optional) 
        public EVNSegment_A01 EVN_Event_Type { get; set; } // (Required)
        public PIDSegment_A01 PID_Patient_Identification { get; set; } // (Required)
        public PD1Segment_A01 PD1_Patient_Additional_Demographic { get; set; } //(Optional)
        public List<ARVSegment_A01> ARV_Access_Restriction { get; set; } // A(Optional) (Repeatable)
        public List<ROLSegment_A01> ROL_Role { get; set; } // (Optional) (Repeatable)

        public List<NK1Segment_A01> NK1_Next_Kin { get; set; } //  (Optional) (Repeatable)
        public PV1Segment_A01 PV1_Patient_Visit { get; set; } //  (Required)
        public PV2Segment_A01 PV2_Patient_Visit_Additional { get; set; } //  (Optional)
        public List<ARVSegment_A01> ARV_AccessRestriction_Additional_Patient_Visit { get; set; } //  (Optional) (Repeatable)
        public List<ROLSegment_A01> ROL_Additional_Patient_Visit { get; set; } // (Optional) (Repeatable)
        public List<DB1Segment_A01> DB1_Disability { get; set; } //  (Optional) (Repeatable)
        public List<OBXSegment_A01> OBX_Observation_Result { get; set; } //(Optional) (Repeatable)
        public List<AL1Segment_A01> AL1_Patient_Allergy { get; set; } //  (Optional) (Repeatable)
        public List<DG1Segment_A01> DG1_Diagnosis { get; set; } //  (Optional) (Repeatable)
        public List<DRGSegment_A01> DRG_Diagnosis_Related_Group { get; set; } // (Optional)
        public Procedure Procedure { get; set; } //(Optional)
        public List<GT1Segment_A01> GT1_Gurantor { get; set; } //  (Optional) (Repeatable)
        public Insurance Insurance { get; set; } //(Optional)
        public ACCSegment_A01 ACC_Accident { get; set; } // (Optional)
        public UB1Segment_A01 UB1_Ub82 { get; set; } //(Optional)
        public UB2Segment_A01 UB2_Uniform_Billing_Data { get; set; } // (Optional)
        public PDASegment_A01 PDA_Patient_Death_Autopsy { get; set; } // (Optional)

        //public AdmitVisit_A01_Model(
        //    MSHSegment_A01 msh,
        //    EVNSegment_A01 evn,
        //    PIDSegment_A01 pid,
        //    PV1Segment_A01 pv1,
        //    PR1Segment_A01 pr1,
        //    IN1Segment_A01 in1)
        //{
        //    MSH_Message_Header = msh ?? throw new ArgumentNullException(nameof(msh));
        //    EVN_Event_Type = evn ?? throw new ArgumentNullException(nameof(evn));
        //    PID_Patient_Identification = pid ?? throw new ArgumentNullException(nameof(pid));
        //    PV1_Patient_Visit = pv1 ?? throw new ArgumentNullException(nameof(pv1));

        //    SFT_Software_Segment = new List<SFTSegment_A01>();
        //    UAC_User_Authentication_Creential = new List<UACSegment_A01>();
        //    ARV_Access_Restriction = new List<ARVSegment_A01>();
        //    ROL_Role = new List<ROLSegment_A01>();
        //    NK1_Next_Kin = new List<NK1Segment_A01>();
        //    ARV_AccessRestriction_Additional_Patient_Visit = new List<ARVSegment_A01>();
        //    ROL_Additional_Patient_Visit = new List<ROLSegment_A01>();
        //    DB1_Disability = new List<DB1Segment_A01>();
        //    OBX_Observation_Result = new List<OBXSegment_A01>();
        //    AL1_Patient_Allergy = new List<AL1Segment_A01>();
        //    DG1_Diagnosis = new List<DG1Segment_A01>();
        //    DRG_Diagnosis_Related_Group = new List<DRGSegment_A01>();
        //    GT1_Gurantor = new List<GT1Segment_A01>();

        //}
    }

    public class Procedure
    {
        public PR1Segment_A01 PR1_Procedures { get; set; } //(Required)
        public List<ROLSegment_A01> ROL_Procedure { get; set; } // (Optional) (Repeatable)
        //public Procedure(PR1Segment_A01 pr1)
        //{
        //    PR1_Procedures = pr1 ?? throw new ArgumentNullException(nameof(pr1));
        //    ROL_Procedure = new List<ROLSegment_A01>();
        //}
    }
    public class Insurance
    {
        public IN1Segment_A01 IN1_Insurance { get; set; } // (Required)
        public List<IN2Segment_A01> IN2_Insurance_Additinal_Inforamtion { get; set; } // (Optional)
        public List<IN3Segment_A01> IN3_Insurance_Additinal_Inforamtion_Certification { get; set; } // (Optional) (Repeatable)
        public List<ROLSegment_A01> ROL_Insurance { get; set; } // (Optional) (Repeatable)
        public List<AUTSegment_A01> AUT_Authorization_Information { get; set; } // (Optional) (Repeatable)
        public List<RF1Segment_A01> RF1_Referral_Information { get; set; } // (Optional) (Repeatable)
        //public Insurance(IN1Segment_A01 IN1)
        //{

        //    IN1_Insurance = IN1 ?? throw new ArgumentNullException(nameof(IN1));
        //    IN2_Insurance_Additinal_Inforamtion = new List<IN2Segment_A01>();
        //    IN3_Insurance_Additinal_Inforamtion_Certification = new List<IN3Segment_A01>();
        //    ROL_Insurance = new List<ROLSegment_A01>();
        //    RF1_Referral_Information = new List<RF1Segment_A01>();
        //}
    }
}
