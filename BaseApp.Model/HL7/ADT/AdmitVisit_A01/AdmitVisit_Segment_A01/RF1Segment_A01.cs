using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.Admit_Visit_A01.AdmitVisi_Segment_A01
{
    public class RF1Segment_A01
    {
        public string? RF1_1_ReferralStatus { get; set; } // Optional
        public string? RF1_2_ReferralPriority { get; set; } // Optional
        public string? RF1_3_ReferralType { get; set; } // Optional
        public List<string>? RF1_4_ReferralDisposition { get; set; } // Optional, Repeatable
        public string? RF1_5_ReferralCategory { get; set; } // Optional
        public string RF1_6_OriginatingReferralIdentifier { get; set; } // Required
        public string? RF1_7_EffectiveDate { get; set; } // Optional
        public string? RF1_8_ExpirationDate { get; set; } // Optional
        public string? RF1_9_ProcessDate { get; set; } // Optional
        public List<string>? RF1_10_ReferralReason { get; set; } // Optional, Repeatable
        public List<string>? RF1_11_ExternalReferralIdentifier { get; set; } // Optional, Repeatable
        public string? RF1_12_ReferralDocumentationCompletionStatus { get; set; } // Optional
        public string? RF1_13_PlannedTreatmentStopDate { get; set; } // Optional
        public string? RF1_14_ReferralReasonText { get; set; } // Optional
        public string? RF1_15_NumberOfAuthorizedTreatmentsUnits { get; set; } // Optional
        public string? RF1_16_NumberOfUsedTreatmentsUnits { get; set; } // Optional
        public string? RF1_17_NumberOfScheduleTreatmentsUnits { get; set; } // Optional
        public string? RF1_18_RemainingBenefitAmount { get; set; } // Optional
        public string? RF1_19_AuthorizedProvider { get; set; } // Optional
        public string? RF1_20_AuthorizedHealthProfessional { get; set; } // Optional
        public string? RF1_21_SourceText { get; set; } // Optional
        public string? RF1_22_SourceDate { get; set; } // Optional
        public string? RF1_23_SourcePhone { get; set; } // Optional
        public string? RF1_24_Comment { get; set; } // Optional
        public string? RF1_25_ActionCode { get; set; } // Optional

        public RF1Segment_A01(string rf1_6_OriginatingReferralIdentifier)
        {
            RF1_6_OriginatingReferralIdentifier = rf1_6_OriginatingReferralIdentifier ?? throw new ArgumentNullException(nameof(rf1_6_OriginatingReferralIdentifier), "RF1_6_OriginatingReferralIdentifier cannot be null");

            // Initialize lists for repeatable fields
            RF1_4_ReferralDisposition = new List<string>();
            RF1_10_ReferralReason = new List<string>();
            RF1_11_ExternalReferralIdentifier = new List<string>();
        }
    }
}
