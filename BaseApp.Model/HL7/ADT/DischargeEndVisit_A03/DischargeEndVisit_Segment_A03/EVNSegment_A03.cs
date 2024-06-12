using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.DischargeEndVisit_A03.DischargeEndVisit_Segment_A03
{
    public class EVNSegment_A03
    {
        /*Event Segment*/
        // Required fields
        public string? EVN1_EventTypeCode { get; set; }
        public string? EVN2_RecordedDateTime { get; set; } // DTM - DateTime

        // Optional fields
        public string? EVN3_DateTimePlannedEvent { get; set; } // DTM - DateTime
        public string? EVN4_EventReasonCode { get; set; } // CWE - Coded With Exceptions
        public List<string>? EVN5_OperatorId { get; set; } // XCN - Extended Composite ID Number and Name for Persons, Repeatable
        public string? EVN6_EventOccurred { get; set; } // DTM - DateTime
        public string? EVN7_EventFacility { get; set; } // HD - Hierarchical Designator

        //public EVNSegment_A01(string evn2_RecordedDateTime)
        //{
        //    EVN2_RecordedDateTime = evn2_RecordedDateTime ?? throw new ArgumentNullException(nameof(evn2_RecordedDateTime));

        //    // Initialize lists for repeatable fields
        //    EVN5_OperatorId = new List<string>();
        //}
    }
}
