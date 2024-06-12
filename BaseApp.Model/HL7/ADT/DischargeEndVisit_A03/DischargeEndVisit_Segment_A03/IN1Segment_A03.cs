using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.DischargeEndVisit_A03.DischargeEndVisit_Segment_A03
{
    public class IN1Segment_A03
    {
        public string IN1_1_SetIdIn1 { get; set; } // Required
        public string IN1_2_HealthPlanId { get; set; } // Required
        public List<string> IN1_3_InsuranceCompanyId { get; set; } // Required, Repeatable
        public List<string>? IN1_4_InsuranceCompanyName { get; set; } // Optional, Repeatable
        public List<string>? IN1_5_InsuranceCompanyAddress { get; set; } // Optional, Repeatable
        public List<string>? IN1_6_InsuranceCoContactPerson { get; set; } // Optional, Repeatable
        public List<string>? IN1_7_InsuranceCoPhoneNumber { get; set; } // Optional, Repeatable
        public string? IN1_8_GroupNumber { get; set; } // Optional
        public List<string>? IN1_9_GroupName { get; set; } // Optional, Repeatable
        public List<string>? IN1_10_InsuredsGroupEmpId { get; set; } // Optional, Repeatable
        public List<string>? IN1_11_InsuredsGroupEmpName { get; set; } // Optional, Repeatable
        public string? IN1_12_PlanEffectiveDate { get; set; } // Optional
        public string? IN1_13_PlanExpirationDate { get; set; } // Optional
        public string? IN1_14_AuthorizationInformation { get; set; } // Optional
        public string? IN1_15_PlanType { get; set; } // Optional
        public List<string>? IN1_16_NameOfInsured { get; set; } // Optional, Repeatable
        public string? IN1_17_InsuredsRelationshipToPatient { get; set; } // Optional
        public string? IN1_18_InsuredsDateOfBirth { get; set; } // Optional
        public List<string>? IN1_19_InsuredsAddress { get; set; } // Optional, Repeatable
        public string? IN1_20_AssignmentOfBenefits { get; set; } // Optional
        public string? IN1_21_CoordinationOfBenefits { get; set; } // Optional
        public string? IN1_22_CoordOfBenPriority { get; set; } // Optional
        public string? IN1_23_NoticeOfAdmissionFlag { get; set; } // Optional
        public string? IN1_24_NoticeOfAdmissionDate { get; set; } // Optional
        public string? IN1_25_ReportOfEligibilityFlag { get; set; } // Optional
        public string? IN1_26_ReportOfEligibilityDate { get; set; } // Optional
        public string? IN1_27_ReleaseInformationCode { get; set; } // Optional
        public string? IN1_28_PreAdmitCert { get; set; } // Optional
        public string? IN1_29_VerificationDateTime { get; set; } // Optional
        public List<string>? IN1_30_VerificationBy { get; set; } // Optional, Repeatable
        public string? IN1_31_TypeOfAgreementCode { get; set; } // Optional
        public string? IN1_32_BillingStatus { get; set; } // Optional
        public string? IN1_33_LifetimeReserveDays { get; set; } // Optional
        public string? IN1_34_DelayBeforeLRDay { get; set; } // Optional
        public string? IN1_35_CompanyPlanCode { get; set; } // Optional
        public string? IN1_36_PolicyNumber { get; set; } // Optional
        public string? IN1_37_PolicyDeductible { get; set; } // Optional
                                                             // Withdrawn Fields
        public string? IN1_38_PolicyLimitAmount { get; set; } // Withdrawn
        public string? IN1_39_PolicyLimitDays { get; set; } // Optional
        public string? IN1_40_RoomRateSemiPrivate { get; set; } // Withdrawn
        public string? IN1_41_RoomRatePrivate { get; set; } // Withdrawn
        public string? IN1_42_InsuredsEmploymentStatus { get; set; } // Optional
        public string? IN1_43_InsuredsAdministrativeSex { get; set; } // Optional
        public List<string>? IN1_44_InsuredsEmployersAddress { get; set; } // Optional, Repeatable
        public string? IN1_45_VerificationStatus { get; set; } // Optional
        public string? IN1_46_PriorInsurancePlanId { get; set; } // Optional
        public string? IN1_47_CoverageType { get; set; } // Optional
        public string? IN1_48_Handicap { get; set; } // Optional
        public List<string>? IN1_49_InsuredsIdNumber { get; set; } // Optional, Repeatable
        public string? IN1_50_SignatureCode { get; set; } // Optional
        public string? IN1_51_SignatureCodeDate { get; set; } // Optional
        public string? IN1_52_InsuredsBirthPlace { get; set; } // Optional
        public string? IN1_53_VipIndicator { get; set; } // Optional
        public List<string>? IN1_54_ExternalHealthPlanIdentifiers { get; set; } // Optional, Repeatable
        public string? IN1_55_InsuranceActionCode { get; set; } // Optional

        public IN1Segment_A03(string in1_1_SetIdIn1, string in1_2_HealthPlanId, List<string> in1_3_InsuranceCompanyId)
        {
            IN1_1_SetIdIn1 = in1_1_SetIdIn1 ?? throw new ArgumentNullException(nameof(in1_1_SetIdIn1));
            IN1_2_HealthPlanId = in1_2_HealthPlanId ?? throw new ArgumentNullException(nameof(in1_2_HealthPlanId));
            IN1_3_InsuranceCompanyId = in1_3_InsuranceCompanyId ?? throw new ArgumentNullException(nameof(in1_3_InsuranceCompanyId));
            // Initialize lists for repeatable fields
            IN1_4_InsuranceCompanyName = new List<string>();
            IN1_5_InsuranceCompanyAddress = new List<string>();
            IN1_6_InsuranceCoContactPerson = new List<string>();
            IN1_7_InsuranceCoPhoneNumber = new List<string>();
            IN1_9_GroupName = new List<string>();
            IN1_10_InsuredsGroupEmpId = new List<string>();
            IN1_11_InsuredsGroupEmpName = new List<string>();
            IN1_16_NameOfInsured = new List<string>();
            IN1_19_InsuredsAddress = new List<string>();
            IN1_30_VerificationBy = new List<string>();
            IN1_44_InsuredsEmployersAddress = new List<string>();
            IN1_49_InsuredsIdNumber = new List<string>();
            IN1_54_ExternalHealthPlanIdentifiers = new List<string>();
        }
    }
}
