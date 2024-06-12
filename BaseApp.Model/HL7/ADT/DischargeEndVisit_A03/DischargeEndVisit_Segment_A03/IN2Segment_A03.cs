using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.DischargeEndVisit_A03.DischargeEndVisit_Segment_A03
{
    public class IN2Segment_A03
    {
        public string IN2_1_InsuredsEmployeeId { get; set; } // Optional, Repeatable
        public string? IN2_2_InsuredsSocialSecurityNumber { get; set; } // Optional
        public List<string>? IN2_3_InsuredsEmployersNameAndId { get; set; } // Optional, Repeatable
        public string? IN2_4_EmployerInformationData { get; set; } // Optional
        public List<string>? IN2_5_MailClaimParty { get; set; } // Optional, Repeatable
        public string? IN2_6_MedicareHealthInsCardNumber { get; set; } // Optional
        public List<string>? IN2_7_MedicaidCaseName { get; set; } // Optional, Repeatable
        public string? IN2_8_MedicaidCaseNumber { get; set; } // Optional
        public List<string>? IN2_9_MilitarySponsorName { get; set; } // Optional, Repeatable
        public string? IN2_10_MilitaryIdNumber { get; set; } // Optional
        public string? IN2_11_DependentOfMilitaryRecipient { get; set; } // Optional
        public string? IN2_12_MilitaryOrganization { get; set; } // Optional
        public string? IN2_13_MilitaryStation { get; set; } // Optional
        public string? IN2_14_MilitaryService { get; set; } // Optional
        public string? IN2_15_MilitaryRankGrade { get; set; } // Optional
        public string? IN2_16_MilitaryStatus { get; set; } // Optional
        public string? IN2_17_MilitaryRetireDate { get; set; } // Optional
        public string? IN2_18_MilitaryNonAvailCertOnFile { get; set; } // Optional
        public string? IN2_19_BabyCoverage { get; set; } // Optional
        public string? IN2_20_CombineBabyBill { get; set; } // Optional
        public string? IN2_21_BloodDeductible { get; set; } // Optional
        public List<string>? IN2_22_SpecialCoverageApprovalName { get; set; } // Optional, Repeatable
        public string? IN2_23_SpecialCoverageApprovalTitle { get; set; } // Optional
        public List<string>? IN2_24_NonCoveredInsuranceCode { get; set; } // Optional, Repeatable
        public List<string>? IN2_25_PayorId { get; set; } // Optional, Repeatable
        public List<string>? IN2_26_PayorSubscriberId { get; set; } // Optional, Repeatable
        public string? IN2_27_EligibilitySource { get; set; } // Optional
        public List<string>? IN2_28_RoomCoverageTypeAmount { get; set; } // Optional, Repeatable
        public List<string>? IN2_29_PolicyTypeAmount { get; set; } // Optional, Repeatable
        public string? IN2_30_DailyDeductible { get; set; } // Optional
        public string? IN2_31_LivingDependency { get; set; } // Optional
        public List<string>? IN2_32_AmbulatoryStatus { get; set; } // Optional, Repeatable
        public List<string>? IN2_33_Citizenship { get; set; } // Optional, Repeatable
        public string? IN2_34_PrimaryLanguage { get; set; } // Optional
        public string? IN2_35_LivingArrangement { get; set; } // Optional
        public string? IN2_36_PublicityCode { get; set; } // Optional
        public string? IN2_37_ProtectionIndicator { get; set; } // Optional
        public string? IN2_38_StudentIndicator { get; set; } // Optional
        public string? IN2_39_Religion { get; set; } // Optional
        public List<string>? IN2_40_MothersMaidenName { get; set; } // Optional, Repeatable
        public string? IN2_41_Nationality { get; set; } // Optional
        public List<string>? IN2_42_EthnicGroup { get; set; } // Optional, Repeatable
        public List<string>? IN2_43_MaritalStatus { get; set; } // Optional, Repeatable
        public string? IN2_44_InsuredsEmploymentStartDate { get; set; } // Optional
        public string? IN2_45_EmploymentStopDate { get; set; } // Optional
        public string? IN2_46_JobTitle { get; set; } // Optional
        public string? IN2_47_JobCodeClass { get; set; } // Optional
        public string? IN2_48_JobStatus { get; set; } // Optional
        public List<string>? IN2_49_EmployerContactPersonName { get; set; } // Optional, Repeatable
        public List<string>? IN2_50_EmployerContactPersonPhoneNumber { get; set; } // Optional, Repeatable
        public string? IN2_51_EmployerContactReason { get; set; } // Optional
        public List<string>? IN2_52_InsuredsContactPersonsName { get; set; } // Optional, Repeatable
        public List<string>? IN2_53_InsuredsContactPersonPhoneNumber { get; set; } // Optional, Repeatable
        public List<string>? IN2_54_InsuredsContactPersonReason { get; set; } // Optional, Repeatable
        public string? IN2_55_RelationshipToThePatientStartDate { get; set; } // Optional
        public List<string>? IN2_56_RelationshipToThePatientStopDate { get; set; } // Optional, Repeatable
        public string? IN2_57_InsuranceCoContactReason { get; set; } // Optional
        public List<string>? IN2_58_InsuranceCoContactPhoneNumber { get; set; } // Optional, Repeatable
        public string? IN2_59_PolicyScope { get; set; } // Optional
        public string? IN2_60_PolicySource { get; set; } // Optional
        public string? IN2_61_PatientMemberNumber { get; set; } // Optional
        public string? IN2_62_GuarantorsRelationshipToInsured { get; set; } // Optional
        public List<string>? IN2_63_InsuredsPhoneNumberHome { get; set; } // Optional, Repeatable
        public List<string>? IN2_64_InsuredsEmployerPhoneNumber { get; set; } // Optional, Repeatable
        public string? IN2_65_MilitaryHandicappedProgram { get; set; } // Optional
        public string? IN2_66_SuspendFlag { get; set; } // Optional
        public string? IN2_67_CopayLimitFlag { get; set; } // Optional
        public string? IN2_68_StoplossLimitFlag { get; set; } // Optional
        public List<string>? IN2_69_InsuredOrganizationNameAndId { get; set; } // Optional, Repeatable
        public List<string>? IN2_70_InsuredEmployerOrganizationNameAndId { get; set; } // Optional, Repeatable
        public List<string>? IN2_71_Race { get; set; } // Optional, Repeatable
        public string? IN2_72_PatientsRelationshipToInsured { get; set; } // Optional
        public IN2Segment_A03()
        {

            IN2_3_InsuredsEmployersNameAndId = new List<string>();
            IN2_5_MailClaimParty = new List<string>();
            IN2_7_MedicaidCaseName = new List<string>();
            IN2_9_MilitarySponsorName = new List<string>();
            IN2_22_SpecialCoverageApprovalName = new List<string>();
            IN2_24_NonCoveredInsuranceCode = new List<string>();
            IN2_25_PayorId = new List<string>();
            IN2_26_PayorSubscriberId = new List<string>();
            IN2_28_RoomCoverageTypeAmount = new List<string>();
            IN2_29_PolicyTypeAmount = new List<string>();
            IN2_32_AmbulatoryStatus = new List<string>();
            IN2_33_Citizenship = new List<string>();
            IN2_40_MothersMaidenName = new List<string>();
            IN2_42_EthnicGroup = new List<string>();
            IN2_43_MaritalStatus = new List<string>();
            IN2_49_EmployerContactPersonName = new List<string>();
            IN2_50_EmployerContactPersonPhoneNumber = new List<string>();
            IN2_52_InsuredsContactPersonsName = new List<string>();
            IN2_53_InsuredsContactPersonPhoneNumber = new List<string>();
            IN2_54_InsuredsContactPersonReason = new List<string>();
            IN2_56_RelationshipToThePatientStopDate = new List<string>();
            IN2_58_InsuranceCoContactPhoneNumber = new List<string>();
            IN2_63_InsuredsPhoneNumberHome = new List<string>();
            IN2_64_InsuredsEmployerPhoneNumber = new List<string>();
            IN2_69_InsuredOrganizationNameAndId = new List<string>();
            IN2_70_InsuredEmployerOrganizationNameAndId = new List<string>();
            IN2_71_Race = new List<string>();
        }
    }
}
