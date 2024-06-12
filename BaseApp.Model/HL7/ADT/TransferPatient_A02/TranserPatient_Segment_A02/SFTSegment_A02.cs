using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.TransferPatient_A02.TranserPatient_Segment_A02
{

    public class SFTSegment_A02
    {
        /*Software Segment*/
        public string? SFT1_SoftwareVendorOrganization { get; set; }// Required
        public string? SFT2_SoftwareCertifiedVersionOrReleaseNumber { get; set; }// Required
        public string? SFT3_SoftwareProductName { get; set; }// Required
        public string? SFT4_SoftwareBinaryId { get; set; }// Required
        public string? SFT5_SoftwareProductInformation { get; set; } // Optional
        public string? SFT6_SoftwareInstallDate { get; set; } // Optional

    }

}
