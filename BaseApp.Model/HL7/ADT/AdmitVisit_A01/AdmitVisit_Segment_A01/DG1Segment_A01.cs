using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.Admit_Visit_A01.AdmitVisi_Segment_A01
{
    public class DG1Segment_A01
    {
        public string DG1_1_SetIdDg1 { get; set; } // Required
        public string? DG1_2_DiagnosisCodingMethod { get; set; } // Withdrawn
        public string DG1_3_DiagnosisCodeDg1 { get; set; } // Required
        public string? DG1_4_DiagnosisDescription { get; set; } // Withdrawn
        public string? DG1_5_DiagnosisDateTime { get; set; } // Optional
        public string DG1_6_DiagnosisType { get; set; } // Required
        public string? DG1_7_MajorDiagnosticCategory { get; set; } // Withdrawn
        public string? DG1_8_DiagnosticRelatedGroup { get; set; } // Withdrawn
        public string? DG1_9_DrgApprovalIndicator { get; set; } // Withdrawn
        public string? DG1_10_DrgGrouperReviewCode { get; set; } // Withdrawn
        public string? DG1_11_OutlierType { get; set; } // Withdrawn
        public string? DG1_12_OutlierDays { get; set; } // Withdrawn
        public string? DG1_13_OutlierCost { get; set; } // Withdrawn
        public string? DG1_14_GrouperVersionAndType { get; set; } // Withdrawn
        public string? DG1_15_DiagnosisPriority { get; set; } // Optional
        public List<string>? DG1_16_DiagnosingClinician { get; set; } // Optional, Repeatable
        public string? DG1_17_DiagnosisClassification { get; set; } // Optional
        public string? DG1_18_ConfidentialIndicator { get; set; } // Optional
        public string? DG1_19_AttestationDateTime { get; set; } // Optional
        public string? DG1_20_DiagnosisIdentifier { get; set; } // Conditional
        public string? DG1_21_DiagnosisActionCode { get; set; } // Conditional
        public string? DG1_22_ParentDiagnosis { get; set; } // Conditional
        public string? DG1_23_DrgCclValueCode { get; set; } // Optional
        public string? DG1_24_DrgGroupingUsage { get; set; } // Optional
        public string? DG1_25_DrgDiagnosisDeterminationStatus { get; set; } // Optional
        public string? DG1_26_PresentOnAdmissionIndicator { get; set; } // Optional

        //public DG1Segment_A01(string dg1_1_SetIdDg1, string dg1_3_DiagnosisCodeDg1, string dg1_6_DiagnosisType)
        //{
        //    DG1_1_SetIdDg1 = dg1_1_SetIdDg1 ?? throw new ArgumentNullException(nameof(dg1_1_SetIdDg1), "DG1.1 - Set Id - Dg1 is required.");
        //    DG1_3_DiagnosisCodeDg1 = dg1_3_DiagnosisCodeDg1 ?? throw new ArgumentNullException(nameof(dg1_3_DiagnosisCodeDg1), "DG1.3 - Diagnosis Code - Dg1 is required.");
        //    DG1_6_DiagnosisType = dg1_6_DiagnosisType ?? throw new ArgumentNullException(nameof(dg1_6_DiagnosisType), "DG1.6 - Diagnosis Type is required.");


        //    DG1_1_SetIdDg1 = dg1_1_SetIdDg1;
        //    DG1_3_DiagnosisCodeDg1 = dg1_3_DiagnosisCodeDg1;
        //    DG1_6_DiagnosisType = dg1_6_DiagnosisType;
        //    DG1_16_DiagnosingClinician = new List<string>();
        //}
    }
}
