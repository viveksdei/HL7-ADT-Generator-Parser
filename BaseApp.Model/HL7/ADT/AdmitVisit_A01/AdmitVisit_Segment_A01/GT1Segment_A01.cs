using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.Admit_Visit_A01.AdmitVisi_Segment_A01
{
    public class GT1Segment_A01
    {
        public string GT1_1_SetIdGt1 { get; set; } // Required
        public List<string>? GT1_2_GuarantorNumber { get; set; } // Optional, Repeatable
        public List<string> GT1_3_GuarantorName { get; set; } // Required, Repeatable
        public List<string>? GT1_4_GuarantorSpouseName { get; set; } // Optional, Repeatable
        public List<string>? GT1_5_GuarantorAddress { get; set; } // Optional, Repeatable
        public List<string>? GT1_6_GuarantorPhNumHome { get; set; } // Optional, Repeatable
        public List<string>? GT1_7_GuarantorPhNumBusiness { get; set; } // Optional, Repeatable
        public string? GT1_8_GuarantorDateTimeOfBirth { get; set; } // Optional
        public string? GT1_9_GuarantorAdministrativeSex { get; set; } // Optional
        public string? GT1_10_GuarantorType { get; set; } // Optional
        public string? GT1_11_GuarantorRelationship { get; set; } // Optional
        public string? GT1_12_GuarantorSsn { get; set; } // Optional
        public string? GT1_13_GuarantorDateBegin { get; set; } // Optional
        public string? GT1_14_GuarantorDateEnd { get; set; } // Optional
        public string? GT1_15_GuarantorPriority { get; set; } // Optional
        public List<string>? GT1_16_GuarantorEmployerName { get; set; } // Optional, Repeatable
        public List<string>? GT1_17_GuarantorEmployerAddress { get; set; } // Optional, Repeatable
        public List<string>? GT1_18_GuarantorEmployerPhoneNumber { get; set; } // Optional, Repeatable
        public List<string>? GT1_19_GuarantorEmployeeIdNumber { get; set; } // Optional, Repeatable
        public string? GT1_20_GuarantorEmploymentStatus { get; set; } // Optional
        public List<string>? GT1_21_GuarantorOrganizationName { get; set; } // Optional, Repeatable
        public string? GT1_22_GuarantorBillingHoldFlag { get; set; } // Optional
        public string? GT1_23_GuarantorCreditRatingCode { get; set; } // Optional
        public string? GT1_24_GuarantorDeathDateTime { get; set; } // Optional
        public string? GT1_25_GuarantorDeathFlag { get; set; } // Optional
        public string? GT1_26_GuarantorChargeAdjustmentCode { get; set; } // Optional
        public string? GT1_27_GuarantorHouseholdAnnualIncome { get; set; } // Optional
        public string? GT1_28_GuarantorHouseholdSize { get; set; } // Optional
        public List<string>? GT1_29_GuarantorEmployerIdNumber { get; set; } // Optional, Repeatable
        public string? GT1_30_GuarantorMaritalStatusCode { get; set; } // Optional
        public string? GT1_31_GuarantorHireEffectiveDate { get; set; } // Optional
        public string? GT1_32_EmploymentStopDate { get; set; } // Optional
        public string? GT1_33_LivingDependency { get; set; } // Optional
        public List<string>? GT1_34_AmbulatoryStatus { get; set; } // Optional, Repeatable
        public List<string>? GT1_35_Citizenship { get; set; } // Optional, Repeatable
        public string? GT1_36_PrimaryLanguage { get; set; } // Optional
        public string? GT1_37_LivingArrangement { get; set; } // Optional
        public string? GT1_38_PublicityCode { get; set; } // Optional
        public string? GT1_39_ProtectionIndicator { get; set; } // Optional
        public string? GT1_40_StudentIndicator { get; set; } // Optional
        public string? GT1_41_Religion { get; set; } // Optional
        public List<string>? GT1_42_MotherMaidenName { get; set; } // Optional, Repeatable
        public string? GT1_43_Nationality { get; set; } // Optional
        public List<string>? GT1_44_EthnicGroup { get; set; } // Optional, Repeatable
        public List<string>? GT1_45_ContactPersonsName { get; set; } // Optional, Repeatable
        public List<string>? GT1_46_ContactPersonsTelephoneNumber { get; set; } // Optional, Repeatable
        public string? GT1_47_ContactReason { get; set; } // Optional
        public string? GT1_48_ContactRelationship { get; set; } // Optional
        public string? GT1_49_JobTitle { get; set; } // Optional
        public string? GT1_50_JobCodeClass { get; set; } // Optional
        public List<string>? GT1_51_GuarantorEmployersOrganizationName { get; set; } // Optional, Repeatable
        public string? GT1_52_Handicap { get; set; } // Optional
        public string? GT1_53_JobStatus { get; set; } // Optional
        public string? GT1_54_GuarantorFinancialClass { get; set; } // Optional
        public List<string>? GT1_55_GuarantorRace { get; set; } // Optional, Repeatable
        public string? GT1_56_GuarantorBirthPlace { get; set; } // Optional
        public string? GT1_57_VipIndicator { get; set; } // Optional

        //public GT1Segment_A01(string gt1_1_SetIdGt1, List<string> gt1_3_GuarantorName)
        //{
        //    GT1_1_SetIdGt1 = gt1_1_SetIdGt1 ?? throw new ArgumentNullException(nameof(gt1_1_SetIdGt1));
        //    GT1_3_GuarantorName = gt1_3_GuarantorName ?? throw new ArgumentNullException(nameof(gt1_3_GuarantorName));
        //    // Initialize lists for repeatable fields
        //    GT1_2_GuarantorNumber = new List<string>();
        //    GT1_4_GuarantorSpouseName = new List<string>();
        //    GT1_5_GuarantorAddress = new List<string>();
        //    GT1_6_GuarantorPhNumHome = new List<string>();
        //    GT1_7_GuarantorPhNumBusiness = new List<string>();
        //    GT1_16_GuarantorEmployerName = new List<string>();
        //    GT1_17_GuarantorEmployerAddress = new List<string>();
        //    GT1_18_GuarantorEmployerPhoneNumber = new List<string>();
        //    GT1_19_GuarantorEmployeeIdNumber = new List<string>();
        //    GT1_21_GuarantorOrganizationName = new List<string>();
        //    GT1_29_GuarantorEmployerIdNumber = new List<string>();
        //    GT1_34_AmbulatoryStatus = new List<string>();
        //    GT1_35_Citizenship = new List<string>();
        //    GT1_42_MotherMaidenName = new List<string>();
        //    GT1_44_EthnicGroup = new List<string>();
        //    GT1_45_ContactPersonsName = new List<string>();
        //    GT1_46_ContactPersonsTelephoneNumber = new List<string>();
        //    GT1_51_GuarantorEmployersOrganizationName = new List<string>();
        //    GT1_55_GuarantorRace = new List<string>();
        //}
    }
}
