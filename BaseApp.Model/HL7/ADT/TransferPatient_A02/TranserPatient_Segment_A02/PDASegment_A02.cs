using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.TransferPatient_A02.TranserPatient_Segment_A02
{
    public class PDASegment_A02
    {
        public List<string>? PDA_1_DeathCauseCode { get; set; } // Repeatable
        public string? PDA_2_DeathLocation { get; set; } // Optional
        public string? PDA_3_DeathCertifiedIndicator { get; set; } // Required
        public string? PDA_4_DeathCertificateSignedDateTime { get; set; } // Optional
        public string? PDA_5_DeathCertifiedBy { get; set; } // Optional
        public string? PDA_6_AutopsyIndicator { get; set; } // Required
        public string? PDA_7_AutopsyStartAndEndDateTime { get; set; } // Optional
        public string? PDA_8_AutopsyPerformedBy { get; set; } // Optional
        public string? PDA_9_CoronerIndicator { get; set; } // Required

    }
}
