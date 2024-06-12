using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.DischargeEndVisit_A03.DischargeEndVisit_Segment_A03
{

    public class SFTSegment_A03
    {
        /*Software Segment*/
        public string? SFT1_SoftwareVendorOrganization { get; set; }// Required
        public string? SFT2_SoftwareCertifiedVersionOrReleaseNumber { get; set; }// Required
        public string? SFT3_SoftwareProductName { get; set; }// Required
        public string? SFT4_SoftwareBinaryId { get; set; }// Required
        public string? SFT5_SoftwareProductInformation { get; set; } // Optional
        public string? SFT6_SoftwareInstallDate { get; set; } // Optional

        //public SFTSegment_A01(
        //    string? sft1_SoftwareVendorOrganization,
        //    string? sft2_SoftwareCertifiedVersionOrReleaseNumber,
        //    string? sft3_SoftwareProductName,
        //    string? sft4_SoftwareBinaryId)
        //{
        //    SFT1_SoftwareVendorOrganization = sft1_SoftwareVendorOrganization ?? throw new ArgumentNullException(nameof(sft1_SoftwareVendorOrganization));
        //    SFT2_SoftwareCertifiedVersionOrReleaseNumber = sft2_SoftwareCertifiedVersionOrReleaseNumber ?? throw new ArgumentNullException(nameof(sft2_SoftwareCertifiedVersionOrReleaseNumber));
        //    SFT3_SoftwareProductName = sft3_SoftwareProductName ?? throw new ArgumentNullException(nameof(sft3_SoftwareProductName));
        //    SFT4_SoftwareBinaryId = sft4_SoftwareBinaryId ?? throw new ArgumentNullException(nameof(sft4_SoftwareBinaryId));
        //}
    }

}
