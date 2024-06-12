using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.Admit_Visit_A01.AdmitVisi_Segment_A01
{
    public class IN3Segment_A01
    {
        public string IN3_1_SetId { get; set; } // Required
        public string? IN3_2_CertificationNumber { get; set; } // Optional
        public List<string>? IN3_3_CertifiedBy { get; set; } // Optional, Repeatable
        public string? IN3_4_CertificationRequired { get; set; } // Optional
        public string? IN3_5_Penalty { get; set; } // Optional
        public string? IN3_6_CertificationDateTime { get; set; } // Optional
        public string? IN3_7_CertificationModifyDateTime { get; set; } // Optional
        public List<string>? IN3_8_Operator { get; set; } // Optional, Repeatable
        public string? IN3_9_CertificationBeginDate { get; set; } // Optional
        public string? IN3_10_CertificationEndDate { get; set; } // Optional
        public string? IN3_11_Days { get; set; } // Optional
        public string? IN3_12_NonConcurCodeDescription { get; set; } // Optional
        public string? IN3_13_NonConcurEffectiveDateTime { get; set; } // Optional
        public List<string>? IN3_14_PhysicianReviewer { get; set; } // Optional, Repeatable
        public string? IN3_15_CertificationContact { get; set; } // Optional
        public List<string>? IN3_16_CertificationContactPhoneNumber { get; set; } // Optional, Repeatable
        public string? IN3_17_AppealReason { get; set; } // Optional
        public string? IN3_18_CertificationAgency { get; set; } // Optional
        public List<string>? IN3_19_CertificationAgencyPhoneNumber { get; set; } // Optional, Repeatable
        public List<string>? IN3_20_PreCertificationRequirement { get; set; } // Optional, Repeatable
        public string? IN3_21_CaseManager { get; set; } // Optional
        public string? IN3_22_SecondOpinionDate { get; set; } // Optional
        public string? IN3_23_SecondOpinionStatus { get; set; } // Optional
        public List<string>? IN3_24_SecondOpinionDocumentationReceived { get; set; } // Optional, Repeatable
        public List<string>? IN3_25_SecondOpinionPhysician { get; set; } // Optional, Repeatable
        public string? IN3_26_CertificationType { get; set; } // Optional
        public string? IN3_27_CertificationCategory { get; set; } // Optional

        public IN3Segment_A01(string in3_1_SetId)
        {
            IN3_1_SetId = in3_1_SetId ?? throw new ArgumentNullException(nameof(in3_1_SetId), "IN3_1_SetId cannot be null");
            // Initialize lists for repeatable fields
            IN3_3_CertifiedBy = new List<string>();
            IN3_8_Operator = new List<string>();
            IN3_14_PhysicianReviewer = new List<string>();
            IN3_16_CertificationContactPhoneNumber = new List<string>();
            IN3_19_CertificationAgencyPhoneNumber = new List<string>();
            IN3_20_PreCertificationRequirement = new List<string>();
            IN3_24_SecondOpinionDocumentationReceived = new List<string>();
            IN3_25_SecondOpinionPhysician = new List<string>();
        }
    }
}
