using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.Admit_Visit_A01.AdmitVisi_Segment_A01
{
    public class DB1Segment_A01
    {
        public string DB1_1_SetIdDb1 { get; set; } // Required
        public string? DB1_2_DisabledPersonCode { get; set; } // Optional
        public List<string>? DB1_3_DisabledPersonIdentifier { get; set; } // Optional, Repeatable
        public string? DB1_4_DisabilityIndicator { get; set; } // Optional
        public string? DB1_5_DisabilityStartDate { get; set; } // Optional
        public string? DB1_6_DisabilityEndDate { get; set; } // Optional
        public string? DB1_7_DisabilityReturnToWorkDate { get; set; } // Optional
        public string? DB1_8_DisabilityUnableToWorkDate { get; set; } // Optional

        //public DB1Segment_A01(string db1_1_SetIdDb1)
        //{
        //    DB1_1_SetIdDb1 = db1_1_SetIdDb1 ?? throw new ArgumentNullException(nameof(db1_1_SetIdDb1));
        //    DB1_3_DisabledPersonIdentifier = new List<string>();
        //}
    }
}
