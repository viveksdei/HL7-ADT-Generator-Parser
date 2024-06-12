using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.DischargeEndVisit_A03.DischargeEndVisit_Segment_A03
{
    public class AUTSegment_A03
    {
        public string? AUT_1_AuthorizingPayorPlanId { get; set; } // Optional
        public string AUT_2_AuthorizingPayorCompanyId { get; set; } // Required
        public string? AUT_3_AuthorizingPayorCompanyName { get; set; } // Optional
        public string? AUT_4_AuthorizationEffectiveDate { get; set; } // Optional
        public string? AUT_5_AuthorizationExpirationDate { get; set; } // Optional
        public string? AUT_6_AuthorizationIdentifier { get; set; } // Conditional
        public string? AUT_7_ReimbursementLimit { get; set; } // Optional
        public string? AUT_8_RequestedNumberOfTreatments { get; set; } // Optional
        public string? AUT_9_AuthorizedNumberOfTreatments { get; set; } // Optional
        public string? AUT_10_ProcessDate { get; set; } // Optional
        public List<string>? AUT_11_RequestedDisciplines { get; set; } // Optional, Repeatable
        public List<string>? AUT_12_AuthorizedDisciplines { get; set; } // Optional, Repeatable
        public string AUT_13_AuthorizationReferralType { get; set; } // Required
        public string? AUT_14_ApprovalStatus { get; set; } // Optional
        public string? AUT_15_PlannedTreatmentStopDate { get; set; } // Optional
        public string? AUT_16_ClinicalService { get; set; } // Optional
        public string? AUT_17_ReasonText { get; set; } // Optional
        public string? AUT_18_NumberOfAuthorizedTreatmentsUnits { get; set; } // Optional
        public string? AUT_19_NumberOfUsedTreatmentsUnits { get; set; } // Optional
        public string? AUT_20_NumberOfScheduleTreatmentsUnits { get; set; } // Optional
        public string? AUT_21_EncounterType { get; set; } // Optional
        public string? AUT_22_RemainingBenefitAmount { get; set; } // Optional
        public string? AUT_23_AuthorizedProvider { get; set; } // Optional
        public string? AUT_24_AuthorizedHealthProfessional { get; set; } // Optional
        public string? AUT_25_SourceText { get; set; } // Optional
        public string? AUT_26_SourceDate { get; set; } // Optional
        public string? AUT_27_SourcePhone { get; set; } // Optional
        public string? AUT_28_Comment { get; set; } // Optional
        public string? AUT_29_ActionCode { get; set; } // Optional

        public AUTSegment_A03(string aut_2_AuthorizingPayorCompanyId, string aut_13_AuthorizationReferralType)
        {
            AUT_2_AuthorizingPayorCompanyId = aut_2_AuthorizingPayorCompanyId ?? throw new ArgumentNullException(nameof(aut_2_AuthorizingPayorCompanyId), "AUT_2_AuthorizingPayorCompanyId cannot be null");
            AUT_13_AuthorizationReferralType = aut_13_AuthorizationReferralType ?? throw new ArgumentNullException(nameof(aut_13_AuthorizationReferralType), "AUT_13_AuthorizationReferralType cannot be null");

            // Initialize lists for repeatable fields
            AUT_11_RequestedDisciplines = new List<string>();
            AUT_12_AuthorizedDisciplines = new List<string>();
        }
    }
}
