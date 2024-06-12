using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.DischargeEndVisit_A03.DischargeEndVisit_Segment_A03
{
    public class NK1Segment_A03
    {
        public string NK1_1_SetIdNk1 { get; set; } // Required
        public List<string>? NK1_2_Name { get; set; } // Optional, Repeatable
        public string? NK1_3_Relationship { get; set; } // Optional
        public List<string>? NK1_4_Address { get; set; } // Optional, Repeatable
        public List<string>? NK1_5_PhoneNumber { get; set; } // Optional, Repeatable
        public List<string>? NK1_6_BusinessPhoneNumber { get; set; } // Optional, Repeatable
        public string? NK1_7_ContactRole { get; set; } // Optional
        public string? NK1_8_StartDate { get; set; } // Optional
        public string? NK1_9_EndDate { get; set; } // Optional
        public string? NK1_10_NextOfKinAssociatedPartiesJobTitle { get; set; } // Optional
        public string? NK1_11_NextOfKinAssociatedPartiesJobCodeClass { get; set; } // Optional
        public string? NK1_12_NextOfKinAssociatedPartiesEmployeeNumber { get; set; } // Optional
        public List<string>? NK1_13_OrganizationNameNk1 { get; set; } // Optional, Repeatable
        public string? NK1_14_MaritalStatus { get; set; } // Optional
        public string? NK1_15_AdministrativeSex { get; set; } // Optional
        public string? NK1_16_DateTimeOfBirth { get; set; } // Optional
        public List<string>? NK1_17_LivingDependency { get; set; } // Optional, Repeatable
        public List<string>? NK1_18_AmbulatoryStatus { get; set; } // Optional, Repeatable
        public List<string>? NK1_19_Citizenship { get; set; } // Optional, Repeatable
        public string? NK1_20_PrimaryLanguage { get; set; } // Optional
        public string? NK1_21_LivingArrangement { get; set; } // Optional
        public string? NK1_22_PublicityCode { get; set; } // Optional
        public string? NK1_23_ProtectionIndicator { get; set; } // Optional
        public string? NK1_24_StudentIndicator { get; set; } // Optional
        public string? NK1_25_Religion { get; set; } // Optional
        public List<string>? NK1_26_MotherMaidenName { get; set; } // Optional, Repeatable
        public string? NK1_27_Nationality { get; set; } // Optional
        public List<string>? NK1_28_EthnicGroup { get; set; } // Optional, Repeatable
        public List<string>? NK1_29_ContactReason { get; set; } // Optional, Repeatable
        public List<string>? NK1_30_ContactPersonsName { get; set; } // Optional, Repeatable
        public List<string>? NK1_31_ContactPersonsTelephoneNumber { get; set; } // Optional, Repeatable
        public List<string>? NK1_32_ContactPersonsAddress { get; set; } // Optional, Repeatable
        public List<string>? NK1_33_NextOfKinAssociatedPartysIdentifiers { get; set; } // Optional, Repeatable
        public string? NK1_34_JobStatus { get; set; } // Optional
        public List<string>? NK1_35_Race { get; set; } // Optional, Repeatable
        public string? NK1_36_Handicap { get; set; } // Optional
        public string? NK1_37_ContactPersonSocialSecurityNumber { get; set; } // Optional
        public string? NK1_38_NextOfKinBirthPlace { get; set; } // Optional
        public string? NK1_39_VipIndicator { get; set; } // Optional
        public string? NK1_40_NextOfKinTelecommunicationInformation { get; set; } // Optional
        public string? NK1_41_ContactPersonsTelecommunicationInformation { get; set; } // Optional

        //public NK1Segment_A01(string nk1_1_SetIdNk1)
        //{
        //    NK1_1_SetIdNk1 = nk1_1_SetIdNk1 ?? throw new ArgumentNullException(nameof(nk1_1_SetIdNk1));
        //    // Initialize lists for repeatable fields
        //    NK1_2_Name = new List<string>();
        //    NK1_4_Address = new List<string>();
        //    NK1_5_PhoneNumber = new List<string>();
        //    NK1_6_BusinessPhoneNumber = new List<string>();
        //    NK1_13_OrganizationNameNk1 = new List<string>();
        //    NK1_17_LivingDependency = new List<string>();
        //    NK1_18_AmbulatoryStatus = new List<string>();
        //    NK1_19_Citizenship = new List<string>();
        //    NK1_26_MotherMaidenName = new List<string>();
        //    NK1_28_EthnicGroup = new List<string>();
        //    NK1_29_ContactReason = new List<string>();
        //    NK1_30_ContactPersonsName = new List<string>();
        //    NK1_31_ContactPersonsTelephoneNumber = new List<string>();
        //    NK1_32_ContactPersonsAddress = new List<string>();
        //    NK1_33_NextOfKinAssociatedPartysIdentifiers = new List<string>();
        //    NK1_35_Race = new List<string>();
        //}
    }
}
