using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.DischargeEndVisit_A03.DischargeEndVisit_Segment_A03
{
    public class AL1Segment_A03
    {
        public string AL1_1_SetIdAl1 { get; set; } // Required
        public string? AL1_2_AllergenTypeCode { get; set; } // Optional
        public string AL1_3_AllergenCodeMnemonicDescription { get; set; } // Required
        public string? AL1_4_AllergySeverityCode { get; set; } // Optional
        public List<string>? AL1_5_AllergyReactionCode { get; set; } // Optional, Repeatable
        public string? AL1_6_IdentificationDate { get; set; } // Withdrawn

        //    public AL1Segment_A01(string al1_1_SetIdAl1, string al1_3_AllergenCodeMnemonicDescription)
        //    {
        //        if (string.IsNullOrEmpty(al1_1_SetIdAl1))
        //        {
        //            throw new ArgumentNullException(nameof(al1_1_SetIdAl1), "Set ID - AL1 is required.");
        //        }

        //        if (string.IsNullOrEmpty(al1_3_AllergenCodeMnemonicDescription))
        //        {
        //            throw new ArgumentNullException(nameof(al1_3_AllergenCodeMnemonicDescription), "Allergen Code/Mnemonic/Description is required.");
        //        }

        //        AL1_1_SetIdAl1 = al1_1_SetIdAl1;
        //        AL1_3_AllergenCodeMnemonicDescription = al1_3_AllergenCodeMnemonicDescription;
        //        AL1_5_AllergyReactionCode = new List<string>();
        //    }
    }
}
