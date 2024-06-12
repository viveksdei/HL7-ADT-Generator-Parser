using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.DischargeEndVisit_A03.DischargeEndVisit_Segment_A03
{
    public class PR1Segment_A03
    {
        public string PR1_1_SetIdPr1 { get; set; } // Required
        public string? PR1_2_ProcedureCodingMethod { get; set; } // Withdrawn
        public string PR1_3_ProcedureCode { get; set; } // Required
        public string? PR1_4_ProcedureDescription { get; set; } // Withdrawn
        public string PR1_5_ProcedureDateTime { get; set; } // Required
        public string? PR1_6_ProcedureFunctionalType { get; set; } // Optional
        public string? PR1_7_ProcedureMinutes { get; set; } // Optional
        public string? PR1_8_Anesthesiologist { get; set; } // Withdrawn
        public string? PR1_9_AnesthesiaCode { get; set; } // Optional
        public string? PR1_10_AnesthesiaMinutes { get; set; } // Optional
        public string? PR1_11_Surgeon { get; set; } // Withdrawn
        public string? PR1_12_ProcedurePractitioner { get; set; } // Withdrawn
        public string? PR1_13_ConsentCode { get; set; } // Optional
        public string? PR1_14_ProcedurePriority { get; set; } // Optional
        public string? PR1_15_AssociatedDiagnosisCode { get; set; } // Optional
        public List<string>? PR1_16_ProcedureCodeModifier { get; set; } // Optional, Repeatable
        public string? PR1_17_ProcedureDrgType { get; set; } // Optional
        public List<string>? PR1_18_TissueTypeCode { get; set; } // Optional, Repeatable
        public string? PR1_19_ProcedureIdentifier { get; set; } // Conditional
        public string? PR1_20_ProcedureActionCode { get; set; } // Conditional
        public string? PR1_21_DrgProcedureDeterminationStatus { get; set; } // Optional
        public string? PR1_22_DrgProcedureRelevance { get; set; } // Optional
        public List<string>? PR1_23_TreatingOrganizationalUnit { get; set; } // Optional, Repeatable
        public string? PR1_24_RespiratoryWithinSurgery { get; set; } // Optional
        public string? PR1_25_ParentProcedureId { get; set; } // Optional

        public PR1Segment_A03(string pr1_1_SetIdPr1, string pr1_3_ProcedureCode, string pr1_5_ProcedureDateTime)
        {
            PR1_1_SetIdPr1 = pr1_1_SetIdPr1 ?? throw new ArgumentNullException(nameof(pr1_1_SetIdPr1));
            PR1_3_ProcedureCode = pr1_3_ProcedureCode ?? throw new ArgumentNullException(nameof(pr1_3_ProcedureCode));
            PR1_5_ProcedureDateTime = pr1_5_ProcedureDateTime ?? throw new ArgumentNullException(nameof(pr1_5_ProcedureDateTime));
            PR1_16_ProcedureCodeModifier = new List<string>();
            PR1_18_TissueTypeCode = new List<string>();
            PR1_23_TreatingOrganizationalUnit = new List<string>();
        }
    }
}
