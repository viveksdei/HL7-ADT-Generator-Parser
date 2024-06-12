using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.Admit_Visit_A01.AdmitVisi_Segment_A01
{
    public class ARVSegment_A01
    {
        public string? ARV1_SetId { get; set; } // Optional
        public string ARV2_AccessRestrictionActionCode { get; set; } // Required
        public string ARV3_AccessRestrictionValue { get; set; } // Required
        public List<string>? ARV4_AccessRestrictionReason { get; set; } // Optional, Repeatable
        public List<string>? ARV5_SpecialAccessRestrictionInstructions { get; set; } // Optional, Repeatable
        public string? ARV6_AccessRestrictionDateRange { get; set; } // Optional

        //public ARVSegment_A01(string arv2_AccessRestrictionActionCode, string arv3_AccessRestrictionValue)
        //{
        //    ARV2_AccessRestrictionActionCode = arv2_AccessRestrictionActionCode ?? throw new ArgumentNullException(nameof(arv2_AccessRestrictionActionCode));
        //    ARV3_AccessRestrictionValue = arv3_AccessRestrictionValue ?? throw new ArgumentNullException(nameof(arv3_AccessRestrictionValue));
        //    ARV4_AccessRestrictionReason = new List<string>();
        //    ARV5_SpecialAccessRestrictionInstructions = new List<string>();
        //}
    }
}
