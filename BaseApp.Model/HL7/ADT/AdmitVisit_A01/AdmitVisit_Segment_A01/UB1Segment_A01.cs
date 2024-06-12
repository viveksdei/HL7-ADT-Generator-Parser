using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.Admit_Visit_A01.AdmitVisi_Segment_A01
{
    public class UB1Segment_A01
    {
        public string? UB1_1_SetId { get; set; } // Optional
        public string? UB1_2_BloodDeductible { get; set; } // Optional
        public string? UB1_3_BloodFurnishedPints { get; set; } // Optional
        public string? UB1_4_BloodReplacedPints { get; set; } // Optional
        public string? UB1_5_BloodNotReplacedPints { get; set; } // Optional
        public string? UB1_6_CoinsuranceDays { get; set; } // Optional
        public List<string>? UB1_7_ConditionCode { get; set; } // Repeatable(5)
        public string? UB1_8_CoveredDays { get; set; } // Optional
        public string? UB1_9_NonCoveredDays { get; set; } // Optional
        public List<string>? UB1_10_ValueAmountAndCode { get; set; } // Repeatable(8)
        public string? UB1_11_NumberOfGraceDays { get; set; } // Optional
        public string? UB1_12_SpecialProgramIndicator { get; set; } // Optional
        public string? UB1_13_PsroUrApprovalIndicator { get; set; } // Optional
        public string? UB1_14_PsroUrApprovedStayFm { get; set; } // Optional
        public string? UB1_15_PsroUrApprovedStayTo { get; set; } // Optional
        public List<string>? UB1_16_Occurrence { get; set; } // Repeatable(5)
        public string? UB1_17_OccurrenceSpan { get; set; } // Optional
        public string? UB1_18_OccurSpanStartDate { get; set; } // Optional
        public string? UB1_19_OccurSpanEndDate { get; set; } // Optional
        public string? UB1_20_Ub82Locator2 { get; set; } // Optional
        public string? UB1_21_Ub82Locator9 { get; set; } // Optional
        public string? UB1_22_Ub82Locator27 { get; set; } // Optional
        public string? UB1_23_Ub82Locator45 { get; set; } // Optional

        //public UB1Segment_A01()
        //{
        //    UB1_7_ConditionCode = new List<string>();
        //    UB1_10_ValueAmountAndCode = new List<string>();
        //    UB1_16_Occurrence = new List<string>();
        //}
    }
}
