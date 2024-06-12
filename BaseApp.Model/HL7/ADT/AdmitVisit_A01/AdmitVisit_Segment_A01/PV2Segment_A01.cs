using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.Admit_Visit_A01.AdmitVisi_Segment_A01
{
    public class PV2Segment_A01
    {
        public string? PV2_1_PriorPendingLocation { get; set; } // Conditional
        public string? PV2_2_AccommodationCode { get; set; } // Optional
        public string? PV2_3_AdmitReason { get; set; } // Optional
        public string? PV2_4_TransferReason { get; set; } // Optional
        public List<string>? PV2_5_PatientValuables { get; set; } // Optional, Repeatable
        public string? PV2_6_PatientValuablesLocation { get; set; } // Optional
        public List<string>? PV2_7_VisitUserCode { get; set; } // Optional, Repeatable
        public string? PV2_8_ExpectedAdmitDateTime { get; set; } // Optional
        public string? PV2_9_ExpectedDischargeDateTime { get; set; } // Optional
        public string? PV2_10_EstimatedLengthOfInpatientStay { get; set; } // Optional
        public string? PV2_11_ActualLengthOfInpatientStay { get; set; } // Optional
        public string? PV2_12_VisitDescription { get; set; } // Optional
        public List<string>? PV2_13_ReferralSourceCode { get; set; } // Optional, Repeatable
        public string? PV2_14_PreviousServiceDate { get; set; } // Optional
        public string? PV2_15_EmploymentIllnessRelatedIndicator { get; set; } // Optional
        public string? PV2_16_PurgeStatusCode { get; set; } // Optional
        public string? PV2_17_PurgeStatusDate { get; set; } // Optional
        public string? PV2_18_SpecialProgramCode { get; set; } // Optional
        public string? PV2_19_RetentionIndicator { get; set; } // Optional
        public string? PV2_20_ExpectedNumberOfInsurancePlans { get; set; } // Optional
        public string? PV2_21_VisitPublicityCode { get; set; } // Optional
        public string? PV2_22_VisitProtectionIndicator { get; set; } // Optional
        public List<string>? PV2_23_ClinicOrganizationName { get; set; } // Optional, Repeatable
        public string? PV2_24_PatientStatusCode { get; set; } // Optional
        public string? PV2_25_VisitPriorityCode { get; set; } // Optional
        public string? PV2_26_PreviousTreatmentDate { get; set; } // Optional
        public string? PV2_27_ExpectedDischargeDisposition { get; set; } // Optional
        public string? PV2_28_SignatureOnFileDate { get; set; } // Optional
        public string? PV2_29_FirstSimilarIllnessDate { get; set; } // Optional
        public string? PV2_30_PatientChargeAdjustmentCode { get; set; } // Optional
        public string? PV2_31_RecurringServiceCode { get; set; } // Optional
        public string? PV2_32_BillingMediaCode { get; set; } // Optional
        public string? PV2_33_ExpectedSurgeryDateAndTime { get; set; } // Optional
        public string? PV2_34_MilitaryPartnershipCode { get; set; } // Optional
        public string? PV2_35_MilitaryNonAvailabilityCode { get; set; } // Optional
        public string? PV2_36_NewbornBabyIndicator { get; set; } // Optional
        public string? PV2_37_BabyDetainedIndicator { get; set; } // Optional
        public string? PV2_38_ModeOfArrivalCode { get; set; } // Optional
        public List<string>? PV2_39_RecreationalDrugUseCode { get; set; } // Optional, Repeatable
        public string? PV2_40_AdmissionLevelOfCareCode { get; set; } // Optional
        public List<string>? PV2_41_PrecautionCode { get; set; } // Optional, Repeatable
        public string? PV2_42_PatientConditionCode { get; set; } // Optional
        public string? PV2_43_LivingWillCode { get; set; } // Optional
        public string? PV2_44_OrganDonorCode { get; set; } // Optional
        public List<string>? PV2_45_AdvanceDirectiveCode { get; set; } // Conditional, Repeatable
        public string? PV2_46_PatientStatusEffectiveDate { get; set; } // Optional
        public string? PV2_47_ExpectedLoaReturnDateTime { get; set; } // Conditional
        public string? PV2_48_ExpectedPreAdmissionTestingDateTime { get; set; } // Optional
        public List<string>? PV2_49_NotifyClergyCode { get; set; } // Optional, Repeatable
        public string? PV2_50_AdvanceDirectiveLastVerifiedDate { get; set; } // Optional
        //public PV2Segment_A01()
        //{
        //    // Initialize lists for repeatable fields
        //    PV2_5_PatientValuables = new List<string>();
        //    PV2_7_VisitUserCode = new List<string>();
        //    PV2_13_ReferralSourceCode = new List<string>();
        //    PV2_23_ClinicOrganizationName = new List<string>();
        //    PV2_39_RecreationalDrugUseCode = new List<string>();
        //    PV2_41_PrecautionCode = new List<string>();
        //    PV2_45_AdvanceDirectiveCode = new List<string>();
        //    PV2_49_NotifyClergyCode = new List<string>();
        //}
    }
}
