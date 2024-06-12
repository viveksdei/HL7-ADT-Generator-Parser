using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.TransferPatient_A02.TranserPatient_Segment_A02
{
    public class MSHSegment_A02
    {

        public string? MSH1_FieldSeparator { get; set; } // Required
        public string? MSH2_EncodingCharacters { get; set; } // Required
        public string? MSH3_SendingApplication { get; set; } // Optional
        public string? MSH4_SendingFacility { get; set; } // Optional
        public string? MSH5_ReceivingApplication { get; set; } // Optional
        public string? MSH6_ReceivingFacility { get; set; } // Optional
        public string? MSH7_DateTimeOfMessage { get; set; } // Required
        public string? MSH8_Security { get; set; } // Optional
        public string? MSH9_MessageType { get; set; } // Required
        public string? MSH10_MessageControlId { get; set; } // Required
        public string MSH11_ProcessingId { get; set; } // Required
        public string MSH12_VersionId { get; set; } // Required
        public string? MSH13_SequenceNumber { get; set; } // Optional
        public string? MSH14_ContinuationPointer { get; set; } // Optional
        public string? MSH15_AcceptAcknowledgmentType { get; set; } // Optional
        public string? MSH16_ApplicationAcknowledgmentType { get; set; } // Optional
        public string? MSH17_CountryCode { get; set; } // Optional
        public List<string>? MSH18_CharacterSet { get; set; } // Optional, Repeatable
        public string? MSH19_PrincipalLanguageOfMessage { get; set; } // Optional
        public string? MSH20_AlternateCharacterSetHandlingScheme { get; set; } // Optional
        public List<string>? MSH21_MessageProfileIdentifier { get; set; } // Optional, Repeatable
        public string? MSH22_SendingResponsibleOrganization { get; set; } // Optional
        public string? MSH23_ReceivingResponsibleOrganization { get; set; } // Optional
        public string? MSH24_SendingNetworkAddress { get; set; } // Optional
        public string? MSH25_ReceivingNetworkAddress { get; set; } // Optional


    }
}
