using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.DischargeEndVisit_A03.DischargeEndVisit_Segment_A03
{
    public class PV1Segment_A03
    {
        public string? PV1_1_SetIdPv1 { get; set; } // Optional
        public string PV1_2_PatientClass { get; set; } // Required
        public string? PV1_3_AssignedPatientLocation { get; set; } // Optional
        public string? PV1_4_AdmissionType { get; set; } // Optional
        public string? PV1_5_PreadmitNumber { get; set; } // Optional
        public string? PV1_6_PriorPatientLocation { get; set; } // Optional
        public List<string>? PV1_7_AttendingDoctor { get; set; } // Optional, Repeatable
        public List<string>? PV1_8_ReferringDoctor { get; set; } // Optional, Repeatable
        public List<string>? PV1_9_ConsultingDoctor { get; set; } // Optional, Repeatable
        public string? PV1_10_HospitalService { get; set; } // Optional
        public string? PV1_11_TemporaryLocation { get; set; } // Optional
        public string? PV1_12_PreadmitTestIndicator { get; set; } // Optional
        public string? PV1_13_ReAdmissionIndicator { get; set; } // Optional
        public string? PV1_14_AdmitSource { get; set; } // Optional
        public List<string>? PV1_15_AmbulatoryStatus { get; set; } // Optional, Repeatable
        public string? PV1_16_VipIndicator { get; set; } // Optional
        public List<string>? PV1_17_AdmittingDoctor { get; set; } // Optional, Repeatable
        public string? PV1_18_PatientType { get; set; } // Optional
        public string? PV1_19_VisitNumber { get; set; } // Optional
        public List<string>? PV1_20_FinancialClass { get; set; } // Optional, Repeatable
        public List<string>? PV1_21_ChargePriceIndicator { get; set; } // Optional
        public string? PV1_22_CourtesyCode { get; set; } // Optional
        public string? PV1_23_CreditRating { get; set; } // Optional
        public List<string>? PV1_24_ContractCode { get; set; } // Optional, Repeatable
        public List<string>? PV1_25_ContractEffectiveDate { get; set; } // Optional, Repeatable
        public List<decimal>? PV1_26_ContractAmount { get; set; } // Optional, Repeatable
        public List<int>? PV1_27_ContractPeriod { get; set; } // Optional, Repeatable
        public string? PV1_28_InterestCode { get; set; } // Optional
        public string? PV1_29_TransferToBadDebtCode { get; set; } // Optional
        public string? PV1_30_TransferToBadDebtDate { get; set; } // Optional
        public string? PV1_31_BadDebtAgencyCode { get; set; } // Optional
        public decimal? PV1_32_BadDebtTransferAmount { get; set; } // Optional
        public decimal? PV1_33_BadDebtRecoveryAmount { get; set; } // Optional
        public string? PV1_34_DeleteAccountIndicator { get; set; } // Optional
        public string? PV1_35_DeleteAccountDate { get; set; } // Optional
        public string? PV1_36_DischargeDisposition { get; set; } // Optional
        public string? PV1_37_DischargedToLocation { get; set; } // Optional
        public string? PV1_38_DietType { get; set; } // Optional
        public string? PV1_39_ServicingFacility { get; set; } // Optional
        public string? PV1_40_BedStatus { get; set; } // Withdrawn
        public string? PV1_41_AccountStatus { get; set; } // Optional
        public string? PV1_42_PendingLocation { get; set; } // Optional
        public string? PV1_43_PriorTemporaryLocation { get; set; } // Optional
        public string? PV1_44_AdmitDateTime { get; set; } // Optional
        public string? PV1_45_DischargeDateTime { get; set; } // Optional
        public decimal? PV1_46_CurrentPatientBalance { get; set; } // Optional
        public decimal? PV1_47_TotalCharges { get; set; } // Optional
        public decimal? PV1_48_TotalAdjustments { get; set; } // Optional
        public decimal? PV1_49_TotalPayments { get; set; } // Optional
        public string? PV1_50_AlternateVisitID { get; set; } // Optional
        public string? PV1_51_VisitIndicator { get; set; } // Optional
        public string? PV1_52_OtherHealthcareProvider { get; set; } // Withdrawn
        public string? PV1_53_ServiceEpisodeDescription { get; set; } // Optional
        public string? PV1_54_ServiceEpisodeIdentifier { get; set; } // Optional
        //public PV1Segment_A01(string pv1_2_PatientClass)
        //{
        //    PV1_2_PatientClass = pv1_2_PatientClass ?? throw new ArgumentNullException(nameof(pv1_2_PatientClass));
        //    // Initialize lists for repeatable fields
        //    PV1_7_AttendingDoctor = new List<string>();
        //    PV1_8_ReferringDoctor = new List<string>();
        //    PV1_9_ConsultingDoctor = new List<string>();
        //    PV1_15_AmbulatoryStatus = new List<string>();
        //    PV1_17_AdmittingDoctor = new List<string>();
        //    PV1_20_FinancialClass = new List<string>();
        //    PV1_24_ContractCode = new List<string>();
        //    PV1_25_ContractEffectiveDate = new List<DateTime>();
        //    PV1_26_ContractAmount = new List<decimal>();
        //    PV1_27_ContractPeriod = new List<int>();
        //}
    }
}
