using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.DischargeEndVisit_A03.DischargeEndVisit_Segment_A03
{
    public class MSHSegment_A03
    {
        /*MessageHeader*/
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

        //public MSHSegment_A01(
        //    string msh1_FieldSeparator,
        //    string msh2_EncodingCharacters,
        //    string msh7_DateTimeOfMessage,
        //    string msh9_MessageType,
        //    string msh10_MessageControlId,
        //    string msh11_ProcessingId,
        //    string msh12_VersionId)
        //{
        //    MSH1_FieldSeparator = msh1_FieldSeparator ?? throw new ArgumentNullException(nameof(msh1_FieldSeparator));
        //    MSH2_EncodingCharacters = msh2_EncodingCharacters ?? throw new ArgumentNullException(nameof(msh2_EncodingCharacters));
        //    MSH7_DateTimeOfMessage = msh7_DateTimeOfMessage ?? throw new ArgumentNullException(nameof(msh7_DateTimeOfMessage));
        //    MSH9_MessageType = msh9_MessageType ?? throw new ArgumentNullException(nameof(msh9_MessageType));
        //    MSH10_MessageControlId = msh10_MessageControlId ?? throw new ArgumentNullException(nameof(msh10_MessageControlId));
        //    MSH11_ProcessingId = msh11_ProcessingId ?? throw new ArgumentNullException(nameof(msh11_ProcessingId));
        //    MSH12_VersionId = msh12_VersionId ?? throw new ArgumentNullException(nameof(msh12_VersionId));

        //    // Initialize lists for repeatable fields
        //    MSH18_CharacterSet = new List<string>();
        //    MSH21_MessageProfileIdentifier = new List<string>();
        //}
    }
}
