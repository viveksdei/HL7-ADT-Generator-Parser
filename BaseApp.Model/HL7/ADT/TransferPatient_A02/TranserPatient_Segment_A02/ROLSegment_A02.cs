using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.TransferPatient_A02.TranserPatient_Segment_A02
{
    public class ROLSegment_A02
    {
        public string? ROL1_RoleInstanceId { get; set; } // Conditional
        public string ROL2_ActionCode { get; set; } // Required
        public string ROL3_RoleRol { get; set; } // Required
        public List<string> ROL4_RolePerson { get; set; } // Required, Repeatable
        public string? ROL5_RoleBeginDateTime { get; set; } // Optional
        public string? ROL6_RoleEndDateTime { get; set; } // Optional
        public string? ROL7_RoleDuration { get; set; } // Optional
        public string? ROL8_RoleActionReason { get; set; } // Optional
        public List<string>? ROL9_ProviderType { get; set; } // Optional, Repeatable
        public string? ROL10_OrganizationUnitType { get; set; } // Optional
        public List<string>? ROL11_OfficeHomeAddressBirthplace { get; set; } // Optional, Repeatable
        public List<string>? ROL12_Phone { get; set; } // Optional, Repeatable
        public string? ROL13_PersonsLocation { get; set; } // Optional
        public string? ROL14_Organization { get; set; } // Optional


    }
}
