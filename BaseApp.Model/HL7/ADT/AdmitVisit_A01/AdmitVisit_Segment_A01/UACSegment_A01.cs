using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.Admit_Visit_A01.AdmitVisi_Segment_A01
{
    public class UACSegment_A01
    {
        /*User Authentication Credential Segment*/
        public string UAC1_UserAuthenticationCredentialTypeCode { get; set; } // Required
                                                                         // ED - Encapsulated Data
        public string UAC2_UserAuthenticationCredential { get; set; } // Required

        //public UACSegment_A01(string uac1_UserAuthenticationCredentialTypeCode, string uac2_UserAuthenticationCredential)
        //{
        //    UAC1_UserAuthenticationCredentialTypeCode = uac1_UserAuthenticationCredentialTypeCode ?? throw new ArgumentNullException(nameof(uac1_UserAuthenticationCredentialTypeCode));
        //    UAC2_UserAuthenticationCredential = uac2_UserAuthenticationCredential ?? throw new ArgumentNullException(nameof(uac2_UserAuthenticationCredential));

        //}
    }
}
