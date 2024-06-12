using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.Admit_Visit_A01.AdmitVisi_Segment_A01
{
    public class UB2Segment_A01
    {
        public string? UB2_1_SetId { get; set; } // Optional
        public string? UB2_2_CoinsuranceDays { get; set; } // Optional
        public List<string>? UB2_3_ConditionCode { get; set; } // Repeatable (7)
        public string? UB2_4_CoveredDays { get; set; } // Optional
        public string? UB2_5_NonCoveredDays { get; set; } // Optional
        public List<string>? UB2_6_ValueAmountAndCode { get; set; } // Optional
        public List<string>? UB2_7_OccurrenceCodeAndDate { get; set; } // Optional
        public List<string>? UB2_8_OccurrenceSpanCodeDates { get; set; } // Optional
        public List<string>? UB2_9_UB92Locator2State { get; set; } // Optional
        public List<string>? UB2_10_UB92Locator11State { get; set; } // Optional
        public string? UB2_11_UB92Locator31National { get; set; } // Optional
        public List<string>? UB2_12_DocumentControlNumber { get; set; } // Optional
        public List<string>? UB2_13_UB92Locator49National { get; set; } // Optional
        public List<string>? UB2_14_UB92Locator56State { get; set; } // Optional
        public string? UB2_15_UB92Locator57National { get; set; } // Optional
        public List<string>? UB2_16_UB92Locator78State { get; set; } // Optional
        public string? UB2_17_SpecialVisitCount { get; set; } // Optional

        //public UB2Segment_A01()
        //{

        //    UB2_3_ConditionCode = new List<string>();
        //    UB2_6_ValueAmountAndCode = new List<string>();
        //    UB2_7_OccurrenceCodeAndDate = new List<string>();
        //    UB2_8_OccurrenceSpanCodeDates = new List<string>();
        //    UB2_9_UB92Locator2State = new List<string>();
        //    UB2_10_UB92Locator11State = new List<string>();
        //    UB2_12_DocumentControlNumber = new List<string>();
        //    UB2_13_UB92Locator49National = new List<string>();
        //    UB2_14_UB92Locator56State = new List<string>();
        //    UB2_16_UB92Locator78State = new List<string>();
        //}
    }
}
