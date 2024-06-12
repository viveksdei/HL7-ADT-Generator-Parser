using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.TransferPatient_A02.TranserPatient_Segment_A02
{
    public class EVNSegment_A02
    {
        public string? EVN1_EventTypeCode { get; set; }
        public string? EVN2_RecordedDateTime { get; set; } // DTM - DateTime

        // Optional fields
        public string? EVN3_DateTimePlannedEvent { get; set; } // DTM - DateTime
        public string? EVN4_EventReasonCode { get; set; } // CWE - Coded With Exceptions
        public List<string>? EVN5_OperatorId { get; set; } // XCN - Extended Composite ID Number and Name for Persons, Repeatable
        public string? EVN6_EventOccurred { get; set; } // DTM - DateTime
        public string? EVN7_EventFacility { get; set; } // HD - Hierarchical Designator
    }
}
