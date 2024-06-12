using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.Admit_Visit_A01.AdmitVisi_Segment_A01
{
    public class DRGSegment_A01
    {
        public string? DRG1_DiagnosticRelatedGroup { get; set; } // Optional
        public string? DRG2_DrgAssignedDateTime { get; set; } // Optional
        public string? DRG3_DrgApprovalIndicator { get; set; } // Optional
        public string? DRG4_DrgGrouperReviewCode { get; set; } // Optional
        public string? DRG5_OutlierType { get; set; } // Optional
        public string? DRG6_OutlierDays { get; set; } // Optional
        public string? DRG7_OutlierCost { get; set; } // Optional
        public string? DRG8_DrgPayor { get; set; } // Optional
        public string? DRG9_OutlierReimbursement { get; set; } // Optional
        public string? DRG10_ConfidentialIndicator { get; set; } // Optional
        public string? DRG11_DrgTransferType { get; set; } // Optional
        public string? DRG12_NameOfCoder { get; set; } // Optional
        public string? DRG13_GrouperStatus { get; set; } // Optional
        public string? DRG14_PcclValueCode { get; set; } // Optional
        public string? DRG15_EffectiveWeight { get; set; } // Optional
        public string? DRG16_MonetaryAmount { get; set; } // Optional
        public string? DRG17_StatusPatient { get; set; } // Optional
        public string? DRG18_GrouperSoftwareName { get; set; } // Optional
        public string? DRG19_GrouperSoftwareVersion { get; set; } // Optional
        public string? DRG20_StatusFinancialCalculation { get; set; } // Optional
        public string? DRG21_RelativeDiscountSurcharge { get; set; } // Optional
        public string? DRG22_BasicCharge { get; set; } // Optional
        public string? DRG23_TotalCharge { get; set; } // Optional
        public string? DRG24_DiscountSurcharge { get; set; } // Optional
        public string? DRG25_CalculatedDays { get; set; } // Optional
        public string? DRG26_StatusGender { get; set; } // Optional
        public string? DRG27_StatusAge { get; set; } // Optional
        public string? DRG28_StatusLengthOfStay { get; set; } // Optional
        public string? DRG29_StatusSameDayFlag { get; set; } // Optional
        public string? DRG30_StatusSeparationMode { get; set; } // Optional
        public string? DRG31_StatusWeightAtBirth { get; set; } // Optional
        public string? DRG32_StatusRespirationMinutes { get; set; } // Optional
        public string? DRG33_StatusAdmission { get; set; } // Optional
    }
}
