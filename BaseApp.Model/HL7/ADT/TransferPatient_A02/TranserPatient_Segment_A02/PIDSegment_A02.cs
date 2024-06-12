using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.TransferPatient_A02.TranserPatient_Segment_A02
{
    public class PIDSegment_A02
    {
        public string? PID1_SetIDPid { get; set; } // Optional
        public string? PID2_PatientID { get; set; } // Withdrawn
        public List<string> PID3_PatientIdentifierList { get; set; } // Required, Repeatable
        public string? PID4_AlternatePatientIDPid { get; set; } // Withdrawn
        public List<string>? PID5_PatientName { get; set; } // Required, Repeatable
        public List<string>? PID6_MotherMaidenName { get; set; } // Optional, Repeatable
        public string? PID7_DateTimeOfBirth { get; set; } // Optional
        public string? PID8_AdministrativeSex { get; set; } // Optional
        public string? PID9_PatientAlias { get; set; } // Withdrawn
        public List<string>? PID10_Race { get; set; } // Optional, Repeatable
        public List<string>? PID11_PatientAddress { get; set; } // Optional, Repeatable
        public string? PID12_CountyCode { get; set; } // Withdrawn
        public List<string>? PID13_PhoneNumberHome { get; set; } // Optional, Repeatable
        public List<string>? PID14_PhoneNumberBusiness { get; set; } // Optional, Repeatable
        public string? PID15_PrimaryLanguage { get; set; } // Optional
        public string? PID16_MaritalStatus { get; set; } // Optional
        public string? PID17_Religion { get; set; } // Optional
        public string? PID18_PatientAccountNumber { get; set; } // Optional
        public string? PID19_SsnNumberPatient { get; set; } // Withdrawn
        public string? PID20_DriverLicenseNumberPatient { get; set; } // Withdrawn
        public List<string>? PID21_MotherIdentifier { get; set; } // Optional, Repeatable
        public List<string>? PID22_EthnicGroup { get; set; } // Optional, Repeatable
        public string? PID23_BirthPlace { get; set; } // Optional
        public string? PID24_MultipleBirthIndicator { get; set; } // Optional
        public string? PID25_BirthOrder { get; set; } // Optional
        public List<string>? PID26_Citizenship { get; set; } // Optional, Repeatable
        public string? PID27_VeteransMilitaryStatus { get; set; } // Optional
        public string? PID28_Nationality { get; set; } // Withdrawn
        public string? PID29_PatientDeathDateAndTime { get; set; } // Optional
        public string? PID30_PatientDeathIndicator { get; set; } // Optional
        public string? PID31_IdentityUnknownIndicator { get; set; } // Optional
        public List<string>? PID32_IdentityReliabilityCode { get; set; } // Optional, Repeatable
        public string? PID33_LastUpdateDateTime { get; set; } // Optional
        public string? PID34_LastUpdateFacility { get; set; } // Optional
                                                              // Conditional and complex fields are represented as strings for simplicity
        public string? PID35_TaxonomicClassificationCode { get; set; } // Conditional
        public string? PID36_BreedCode { get; set; } // Conditional
        public string? PID37_Strain { get; set; } // Optional
        public List<string>? PID38_ProductionClassCode { get; set; } // Optional, Repeatable (limited to 2)
        public List<string>? PID39_TribalCitizenship { get; set; } // Optional, Repeatable
        public List<string>? PID40_PatientTelecommunicationInformation { get; set; } // Optional, Repeatable

    }
}
