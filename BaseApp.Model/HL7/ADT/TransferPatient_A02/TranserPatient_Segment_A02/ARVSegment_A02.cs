using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.TransferPatient_A02.TranserPatient_Segment_A02
{
    public class ARVSegment_A02
    {
        public string? ARV1_SetId { get; set; } // Optional
        public string? ARV2_AccessRestrictionActionCode { get; set; } // Required
        public string ARV3_AccessRestrictionValue { get; set; } // Required
        public List<string>? ARV4_AccessRestrictionReason { get; set; } // Optional, Repeatable
        public List<string>? ARV5_SpecialAccessRestrictionInstructions { get; set; } // Optional, Repeatable
        public string? ARV6_AccessRestrictionDateRange { get; set; } // Optional
    }
}
