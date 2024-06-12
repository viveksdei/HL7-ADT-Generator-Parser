using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.TransferPatient_A02.TranserPatient_Segment_A02
{
    public class UACSegment_A02
    {
        /*User Authentication Credential Segment*/
        public string UAC1_UserAuthenticationCredentialTypeCode { get; set; } // Required
                                                                              // ED - Encapsulated Data
        public string UAC2_UserAuthenticationCredential { get; set; } // Required

    }
}
