using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.TransferPatient_A02.TranserPatient_Segment_A02
{
    public class PD1Segment_A02
    {
        public List<string>? PD1_1_LivingDependency { get; set; } // Optional, Repeatable
        public string? PD1_2_LivingArrangement { get; set; } // Optional
        public List<string>? PD1_3_PatientPrimaryFacility { get; set; } // Optional, Repeatable
        public string? PD1_4_PatientPrimaryCareProviderNameIdNo { get; set; } // Withdrawn
        public string? PD1_5_StudentIndicator { get; set; } // Optional
        public string? PD1_6_Handicap { get; set; } // Optional
        public string? PD1_7_LivingWillCode { get; set; } // Optional
        public string? PD1_8_OrganDonorCode { get; set; } // Optional
        public string? PD1_9_SeparateBill { get; set; } // Optional
        public List<string>? PD1_10_DuplicatePatient { get; set; } // Optional, Repeatable
        public string? PD1_11_PublicityCode { get; set; } // Optional
        public string? PD1_12_ProtectionIndicator { get; set; } // Optional
        public string? PD1_13_ProtectionIndicatorEffectiveDate { get; set; } // Optional
        public List<string>? PD1_14_PlaceOfWorship { get; set; } // Optional, Repeatable
        public List<string>? PD1_15_AdvanceDirectiveCode { get; set; } // Conditional, Repeatable
        public string? PD1_16_ImmunizationRegistryStatus { get; set; } // Optional
        public string? PD1_17_ImmunizationRegistryStatusEffectiveDate { get; set; } // Optional
        public string? PD1_18_PublicityCodeEffectiveDate { get; set; } // Optional
        public string? PD1_19_MilitaryBranch { get; set; } // Optional
        public string? PD1_20_MilitaryRankGrade { get; set; } // Optional
        public string? PD1_21_MilitaryStatus { get; set; } // Optional
        public string? PD1_22_AdvanceDirectiveLastVerifiedDate { get; set; } // Optional

        // Constructor can be added if there are required fields or initializations needed
        //public PD1Segment_A01()
        //{
        //    // Initialize lists for repeatable fields
        //    PD1_1_LivingDependency = new List<string>();
        //    PD1_3_PatientPrimaryFacility = new List<string>();
        //    PD1_10_DuplicatePatient = new List<string>();
        //    PD1_14_PlaceOfWorship = new List<string>();
        //    PD1_15_AdvanceDirectiveCode = new List<string>();
        //}
    }
}
