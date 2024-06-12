using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.Admit_Visit_A01.AdmitVisi_Segment_A01
{
    public class PDASegment_A01
    {
        public List<string>? PDA_1_DeathCauseCode { get; set; } // Repeatable
        public string? PDA_2_DeathLocation { get; set; } // Optional
        public string PDA_3_DeathCertifiedIndicator { get; set; } // Required
        public string? PDA_4_DeathCertificateSignedDateTime { get; set; } // Optional
        public string? PDA_5_DeathCertifiedBy { get; set; } // Optional
        public string PDA_6_AutopsyIndicator { get; set; } // Required
        public string? PDA_7_AutopsyStartAndEndDateTime { get; set; } // Optional
        public string? PDA_8_AutopsyPerformedBy { get; set; } // Optional
        public string PDA_9_CoronerIndicator { get; set; } // Required
        //public PDASegment_A01(string pda_3_DeathCertifiedIndicator, string pda_6_AutopsyIndicator, string pda_9_CoronerIndicator)
        //{
        //    PDA_1_DeathCauseCode = new List<string>();

        //    PDA_3_DeathCertifiedIndicator = pda_3_DeathCertifiedIndicator ?? throw new ArgumentNullException(nameof(pda_3_DeathCertifiedIndicator), "PDA_3_DeathCertifiedIndicator cannot be null");
        //    PDA_6_AutopsyIndicator = pda_6_AutopsyIndicator ?? throw new ArgumentNullException(nameof(pda_6_AutopsyIndicator), "PDA_6_AutopsyIndicator cannot be null");
        //    PDA_9_CoronerIndicator = pda_9_CoronerIndicator ?? throw new ArgumentNullException(nameof(pda_9_CoronerIndicator), "PDA_9_CoronerIndicator cannot be null");
        //}
    }
}
