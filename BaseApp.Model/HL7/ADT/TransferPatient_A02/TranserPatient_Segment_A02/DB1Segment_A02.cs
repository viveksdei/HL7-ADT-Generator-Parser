using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.TransferPatient_A02.TranserPatient_Segment_A02
{
    public class DB1Segment_A02
    {
        public string? DB1_1_SetIdDb1 { get; set; } // Required
        public string? DB1_2_DisabledPersonCode { get; set; } // Optional
        public List<string>? DB1_3_DisabledPersonIdentifier { get; set; } // Optional, Repeatable
        public string? DB1_4_DisabilityIndicator { get; set; } // Optional
        public string? DB1_5_DisabilityStartDate { get; set; } // Optional
        public string? DB1_6_DisabilityEndDate { get; set; } // Optional
        public string? DB1_7_DisabilityReturnToWorkDate { get; set; } // Optional
        public string? DB1_8_DisabilityUnableToWorkDate { get; set; } // Optional


    }
}
