using BaseApp.IService.HL7.ADT.AdmitVisit;
using BaseApp.IService.HL7.ADT.TransferPatient;
using BaseApp.Model.HL7.ADT.Admit_Visit_A01.AdmitVisi_Segment_A01;
using BaseApp.Model.HL7.ADT.TransferPatient_A02.TranserPatient_Segment_A02;
using BaseApp.Model.HL7.ADT.TransferPatient_A02.TransferPatient_Model_A02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Service.HL7.ADT.TransferPatient
{
   
    public class TransferPatientService : ITransferPatientService
    {
        private const char FIELD_DELIMITER = '|';
        private const char SEGMENT_TERMINATOR = '\r';
        private const char REPEAT_DELIMITER = '^';
        private const char COMPONENT_DELIMITER = '~';
        private const char SUBCOMPONENT_DELIMITER = '&';
        private const char ESCAPE_CHARACTER = '\\';
        public string FromJsonToHL7TransferPatient(TransferPatient_A02_Model admitVisit)
        {
            var sb = new StringBuilder();

            AppendMSHSegment(sb, admitVisit.MSH_Message_Header);
            AppendEVNSegment(sb, admitVisit.EVN_Event_Type);
            AppendPIDSegment(sb, admitVisit.PID_Patient_Identification);
            return sb.ToString();
        }

        public static string AppendMSHSegment(StringBuilder sb, MSHSegment_A02 msh)
        {
            sb.Append("MSH").Append(FIELD_DELIMITER);
            //sb.Append(msh.MSH1_FieldSeparator);

            sb.Append(msh.MSH2_EncodingCharacters).Append(FIELD_DELIMITER)
              .Append(msh.MSH3_SendingApplication ?? "").Append(FIELD_DELIMITER)
              .Append(msh.MSH4_SendingFacility ?? "").Append(FIELD_DELIMITER)
              .Append(msh.MSH5_ReceivingApplication ?? "").Append(FIELD_DELIMITER)
              .Append(msh.MSH6_ReceivingFacility ?? "").Append(FIELD_DELIMITER)
              .Append(msh.MSH7_DateTimeOfMessage).Append(FIELD_DELIMITER)
              .Append(msh.MSH8_Security ?? "").Append(FIELD_DELIMITER)
              .Append(msh.MSH9_MessageType).Append(FIELD_DELIMITER)
              .Append(msh.MSH10_MessageControlId).Append(FIELD_DELIMITER)
              .Append(msh.MSH11_ProcessingId).Append(FIELD_DELIMITER)
              .Append(msh.MSH12_VersionId).Append(FIELD_DELIMITER)
              .Append(msh.MSH13_SequenceNumber ?? "").Append(FIELD_DELIMITER)
              .Append(msh.MSH14_ContinuationPointer ?? "").Append(FIELD_DELIMITER)
              .Append(msh.MSH15_AcceptAcknowledgmentType ?? "").Append(FIELD_DELIMITER)
              .Append(msh.MSH16_ApplicationAcknowledgmentType ?? "").Append(FIELD_DELIMITER)
              .Append(msh.MSH17_CountryCode ?? "").Append(FIELD_DELIMITER);
            sb.Append(string.Join(REPEAT_DELIMITER, msh.MSH18_CharacterSet)).Append(FIELD_DELIMITER);

            sb.Append(msh.MSH19_PrincipalLanguageOfMessage ?? "").Append(FIELD_DELIMITER)
              .Append(msh.MSH20_AlternateCharacterSetHandlingScheme ?? "").Append(FIELD_DELIMITER);
            sb.Append(string.Join(REPEAT_DELIMITER, msh.MSH21_MessageProfileIdentifier)).Append(FIELD_DELIMITER)
              .Append(msh.MSH22_SendingResponsibleOrganization ?? "").Append(FIELD_DELIMITER)
              .Append(msh.MSH23_ReceivingResponsibleOrganization ?? "").Append(FIELD_DELIMITER)
              .Append(msh.MSH24_SendingNetworkAddress ?? "").Append(FIELD_DELIMITER)
              .Append(msh.MSH25_ReceivingNetworkAddress ?? "");
            sb.Append(SEGMENT_TERMINATOR);

            return sb.ToString();
        }
        public string AppendEVNSegment(StringBuilder sb, EVNSegment_A02 evn)
        {

            sb.Append("EVN").Append(FIELD_DELIMITER);
            sb.Append(evn.EVN1_EventTypeCode).Append(FIELD_DELIMITER);
            sb.Append(evn.EVN2_RecordedDateTime).Append(FIELD_DELIMITER);
            sb.Append(evn.EVN3_DateTimePlannedEvent ?? "").Append(FIELD_DELIMITER)
              .Append(evn.EVN4_EventReasonCode ?? "").Append(FIELD_DELIMITER);
            if (evn.EVN5_OperatorId != null && evn.EVN5_OperatorId.Any())
            {
                sb.Append(string.Join(REPEAT_DELIMITER, evn.EVN5_OperatorId)).Append(FIELD_DELIMITER);
            }
            else
            {
                sb.Append(FIELD_DELIMITER);
            }

            sb.Append(evn.EVN6_EventOccurred ?? "").Append(FIELD_DELIMITER)
              .Append(evn.EVN7_EventFacility ?? "");

            sb.Append(SEGMENT_TERMINATOR);

            return sb.ToString();
        }
        public string AppendPIDSegment(StringBuilder sb, PIDSegment_A02 pid)
        {

            // Start with the segment type

            sb.Append("PID").Append(FIELD_DELIMITER);

            // Append optional and required fields according to their presence and repetition
            sb.Append(pid.PID1_SetIDPid ?? "").Append(FIELD_DELIMITER)
              .Append(pid.PID2_PatientID ?? "").Append(FIELD_DELIMITER);

            // PID-3 (Patient Identifier List) is required and repeatable
            if (pid.PID3_PatientIdentifierList.Any())
            {
                sb.Append(string.Join(REPEAT_DELIMITER, pid.PID3_PatientIdentifierList)).Append(FIELD_DELIMITER);
            }
            else
            {
                sb.Append(FIELD_DELIMITER);
            }

            sb.Append(pid.PID4_AlternatePatientIDPid ?? "").Append(FIELD_DELIMITER);

            // PID-5 (Patient Name) is required and repeatable
            if (pid.PID5_PatientName.Any())
            {
                sb.Append(string.Join(REPEAT_DELIMITER, pid.PID5_PatientName)).Append(FIELD_DELIMITER);
            }
            else
            {
                sb.Append(FIELD_DELIMITER);
            }

            // Handling optional and repeatable fields similarly
            AppendOptionalRepeatableField(sb, pid.PID6_MotherMaidenName);
            sb.Append(FIELD_DELIMITER);
            sb.Append(pid.PID7_DateTimeOfBirth ?? "").Append(FIELD_DELIMITER)
              .Append(pid.PID8_AdministrativeSex ?? "").Append(FIELD_DELIMITER);
            AppendOptionalRepeatableField(sb, pid.PID10_Race);
            sb.Append(FIELD_DELIMITER);
            AppendOptionalRepeatableField(sb, pid.PID11_PatientAddress);
            sb.Append(FIELD_DELIMITER);
            AppendOptionalRepeatableField(sb, pid.PID13_PhoneNumberHome);
            sb.Append(FIELD_DELIMITER);
            AppendOptionalRepeatableField(sb, pid.PID14_PhoneNumberBusiness);
            sb.Append(FIELD_DELIMITER);
            sb.Append(pid.PID15_PrimaryLanguage ?? "").Append(FIELD_DELIMITER)
              .Append(pid.PID16_MaritalStatus ?? "").Append(FIELD_DELIMITER)
              .Append(pid.PID17_Religion ?? "").Append(FIELD_DELIMITER)
              .Append(pid.PID18_PatientAccountNumber ?? "").Append(FIELD_DELIMITER);
            sb.Append(pid.PID19_SsnNumberPatient ?? "").Append(FIELD_DELIMITER)
            .Append(pid.PID20_DriverLicenseNumberPatient ?? "").Append(FIELD_DELIMITER);
            AppendOptionalRepeatableField(sb, pid.PID21_MotherIdentifier);
            sb.Append(FIELD_DELIMITER);
            AppendOptionalRepeatableField(sb, pid.PID22_EthnicGroup);
            sb.Append(FIELD_DELIMITER);
            sb.Append(pid.PID23_BirthPlace ?? "").Append(FIELD_DELIMITER)
              .Append(pid.PID24_MultipleBirthIndicator ?? "").Append(FIELD_DELIMITER)
              .Append(pid.PID25_BirthOrder ?? "").Append(FIELD_DELIMITER);
            AppendOptionalRepeatableField(sb, pid.PID26_Citizenship);
            sb.Append(FIELD_DELIMITER);
            sb.Append(pid.PID27_VeteransMilitaryStatus ?? "").Append(FIELD_DELIMITER)
              .Append(pid.PID28_Nationality ?? "").Append(FIELD_DELIMITER)
              .Append(pid.PID29_PatientDeathDateAndTime ?? "").Append(FIELD_DELIMITER)
              .Append(pid.PID30_PatientDeathIndicator ?? "").Append(FIELD_DELIMITER)
              .Append(pid.PID31_IdentityUnknownIndicator ?? "").Append(FIELD_DELIMITER);
            AppendOptionalRepeatableField(sb, pid.PID32_IdentityReliabilityCode);
            sb.Append(FIELD_DELIMITER);
            sb.Append(pid.PID33_LastUpdateDateTime ?? "").Append(FIELD_DELIMITER)
              .Append(pid.PID34_LastUpdateFacility ?? "").Append(FIELD_DELIMITER)
              .Append(pid.PID35_TaxonomicClassificationCode ?? "").Append(FIELD_DELIMITER)
              .Append(pid.PID36_BreedCode ?? "").Append(FIELD_DELIMITER)
              .Append(pid.PID37_Strain ?? "").Append(FIELD_DELIMITER);
            AppendOptionalRepeatableField(sb, pid.PID38_ProductionClassCode);
            sb.Append(FIELD_DELIMITER);
            AppendOptionalRepeatableField(sb, pid.PID39_TribalCitizenship);
            sb.Append(FIELD_DELIMITER);
            AppendOptionalRepeatableField(sb, pid.PID40_PatientTelecommunicationInformation);
            sb.Append(SEGMENT_TERMINATOR);

            return sb.ToString();
        }
        private void AppendOptionalRepeatableField(StringBuilder sb, List<string>? fieldValues)
        {
            if (fieldValues != null && fieldValues.Any())
            {
                sb.Append(string.Join(REPEAT_DELIMITER, fieldValues)).Append(FIELD_DELIMITER);
            }
            else
            {
                sb.Append(FIELD_DELIMITER); // Maintain the correct field order
            }
        }

        public static string AppendPV1Segment(StringBuilder sb, PV1Segment_A02 pv1)
        {
            sb.Append("PV1").Append(FIELD_DELIMITER);
            sb.Append(pv1.PV1_1_SetIdPv1 ?? "").Append(FIELD_DELIMITER)
              .Append(pv1.PV1_2_PatientClass).Append(FIELD_DELIMITER) // PV1_2 is required
              .Append(pv1.PV1_3_AssignedPatientLocation ?? "").Append(FIELD_DELIMITER)
              .Append(pv1.PV1_4_AdmissionType ?? "").Append(FIELD_DELIMITER)
              .Append(pv1.PV1_5_PreadmitNumber ?? "").Append(FIELD_DELIMITER)
              .Append(pv1.PV1_6_PriorPatientLocation ?? "").Append(FIELD_DELIMITER)
              .Append(string.Join(REPEAT_DELIMITER, pv1.PV1_7_AttendingDoctor ?? new List<string>())).Append(FIELD_DELIMITER)
              .Append(string.Join(REPEAT_DELIMITER, pv1.PV1_8_ReferringDoctor ?? new List<string>())).Append(FIELD_DELIMITER)
              .Append(string.Join(REPEAT_DELIMITER, pv1.PV1_9_ConsultingDoctor ?? new List<string>())).Append(FIELD_DELIMITER)
              .Append(pv1.PV1_10_HospitalService ?? "").Append(FIELD_DELIMITER)
              .Append(pv1.PV1_11_TemporaryLocation ?? "").Append(FIELD_DELIMITER)
              .Append(pv1.PV1_12_PreadmitTestIndicator ?? "").Append(FIELD_DELIMITER)
              .Append(pv1.PV1_13_ReAdmissionIndicator ?? "").Append(FIELD_DELIMITER)
              .Append(pv1.PV1_14_AdmitSource ?? "").Append(FIELD_DELIMITER)
              .Append(string.Join(REPEAT_DELIMITER, pv1.PV1_15_AmbulatoryStatus ?? new List<string>())).Append(FIELD_DELIMITER)
              .Append(pv1.PV1_16_VipIndicator ?? "").Append(FIELD_DELIMITER)
              .Append(string.Join(REPEAT_DELIMITER, pv1.PV1_17_AdmittingDoctor ?? new List<string>())).Append(FIELD_DELIMITER)
              .Append(pv1.PV1_18_PatientType ?? "").Append(FIELD_DELIMITER)
              .Append(pv1.PV1_19_VisitNumber ?? "").Append(FIELD_DELIMITER)
              .Append(string.Join(REPEAT_DELIMITER, pv1.PV1_20_FinancialClass ?? new List<string>())).Append(FIELD_DELIMITER)
             .Append(string.Join(REPEAT_DELIMITER, pv1.PV1_21_ChargePriceIndicator ?? new List<string>())).Append(FIELD_DELIMITER)
      .Append(pv1.PV1_22_CourtesyCode ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_23_CreditRating ?? "").Append(FIELD_DELIMITER)
      .Append(string.Join(REPEAT_DELIMITER, pv1.PV1_24_ContractCode ?? new List<string>())).Append(FIELD_DELIMITER)
      .Append(string.Join(REPEAT_DELIMITER, pv1.PV1_25_ContractEffectiveDate?? new List<string>())).Append(FIELD_DELIMITER)
      .Append(string.Join(REPEAT_DELIMITER, pv1.PV1_26_ContractAmount?.Select(amount => amount.ToString()) ?? new List<string>())).Append(FIELD_DELIMITER)
      .Append(string.Join(REPEAT_DELIMITER, pv1.PV1_27_ContractPeriod?.Select(period => period.ToString()) ?? new List<string>())).Append(FIELD_DELIMITER)
      .Append(pv1.PV1_28_InterestCode ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_29_TransferToBadDebtCode ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_30_TransferToBadDebtDate ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_31_BadDebtAgencyCode ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_32_BadDebtTransferAmount?.ToString() ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_33_BadDebtRecoveryAmount?.ToString() ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_34_DeleteAccountIndicator ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_35_DeleteAccountDate ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_36_DischargeDisposition ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_37_DischargedToLocation ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_38_DietType ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_39_ServicingFacility ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_40_BedStatus ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_41_AccountStatus ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_42_PendingLocation ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_43_PriorTemporaryLocation ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_44_AdmitDateTime ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_45_DischargeDateTime ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_46_CurrentPatientBalance?.ToString() ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_47_TotalCharges?.ToString() ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_48_TotalAdjustments?.ToString() ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_49_TotalPayments?.ToString() ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_50_AlternateVisitID ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_51_VisitIndicator ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_52_OtherHealthcareProvider ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_53_ServiceEpisodeDescription ?? "").Append(FIELD_DELIMITER)
      .Append(pv1.PV1_54_ServiceEpisodeIdentifier ?? "");
            sb.Append(SEGMENT_TERMINATOR);


            return sb.ToString();
        }
        #region HL7ToJson
        public TransferPatient_A02_Model FromHL7ToJsonTransferPatient(string hl7Message)
        {
            var messageModel = new TransferPatient_A02_Model();

            var segments = GetSegmentsFromString(hl7Message);

            foreach (var segment in segments)
            {
                var fields = segment.Split('|');
                switch (fields[0])
                {
                    case "MSH":
                        messageModel.MSH_Message_Header = ParseMSHSegment(fields);
                        break;
                    case "EVN":
                        messageModel.EVN_Event_Type = ParseEVNSegment(fields);
                        break;
                    case "PID":
                        messageModel.PID_Patient_Identification = ParsePIDSegment(fields);
                        break;
                    case "PV1":
                        messageModel.PV1_Patient_Visit = ParsePV1Segment(fields);
                        break;
                }
            }

            return messageModel;
        }
        private MSHSegment_A02 ParseMSHSegment(string[] fields)
        {
            var mshSegment = new MSHSegment_A02
            {
                MSH1_FieldSeparator = "|", // Adjust based on actual index after splitting
                MSH2_EncodingCharacters = fields.Length > 1 ? fields[1] : null,
                MSH3_SendingApplication = fields.Length > 2 ? fields[2] : null,
                MSH4_SendingFacility = fields.Length > 3 ? fields[3] : null,
                MSH5_ReceivingApplication = fields.Length > 4 ? fields[4] : null,
                MSH6_ReceivingFacility = fields.Length > 5 ? fields[5] : null,
                MSH7_DateTimeOfMessage = fields.Length > 6 ? fields[6] : null,
                MSH8_Security= fields.Length > 7 ? fields[7] : null,
                MSH9_MessageType = fields.Length > 8 ? fields[8] : null,
                MSH10_MessageControlId = fields.Length > 9 ? fields[9] : null,
                MSH11_ProcessingId = fields.Length > 10 ? fields[10] : null,
                MSH12_VersionId = fields.Length > 11 ? fields[11] : null,
                MSH13_SequenceNumber = fields.Length > 12 ? fields[12] : null,
                MSH14_ContinuationPointer = fields.Length > 13 ? fields[13] : null,
                MSH15_AcceptAcknowledgmentType = fields.Length > 14 ? fields[14] : null,
                MSH16_ApplicationAcknowledgmentType = fields.Length > 15 ? fields[15] : null,
                MSH17_CountryCode = fields.Length > 16 ? fields[16] : null,
                MSH18_CharacterSet = fields.Length > 17 && !string.IsNullOrEmpty(fields[17]) ? fields[17].Split('^').ToList() : new List<string>(),
                MSH19_PrincipalLanguageOfMessage = fields.Length > 18 ? fields[18] : null,
                MSH20_AlternateCharacterSetHandlingScheme = fields.Length > 19 ? fields[19] : null,
                MSH21_MessageProfileIdentifier = fields.Length > 20 && !string.IsNullOrEmpty(fields[20]) ? fields[20].Split('^').ToList() : new List<string>(),
                MSH22_SendingResponsibleOrganization = fields.Length > 21 ? fields[21] : null,
                MSH23_ReceivingResponsibleOrganization = fields.Length > 22 ? fields[22] : null,
                MSH24_SendingNetworkAddress = fields.Length > 23 ? fields[23] : null,
                MSH25_ReceivingNetworkAddress = fields.Length > 24 ? fields[24] : null,
            };

            return mshSegment;
        }

        private EVNSegment_A02 ParseEVNSegment(string[] fields)
        {
            var evnSegment = new EVNSegment_A02
            {
                EVN1_EventTypeCode = fields.Length > 1 ? fields[1] : null,
                EVN2_RecordedDateTime = fields.Length > 2 ? fields[2] : null,
                EVN3_DateTimePlannedEvent = fields.Length > 3 ? fields[3] : null,
                EVN5_OperatorId = fields.Length > 5 && !string.IsNullOrEmpty(fields[5]) ? fields[5].Split('^').ToList() : null,
                EVN4_EventReasonCode = fields.Length > 4 ? fields[4] : null,
                EVN6_EventOccurred = fields.Length > 6 ? fields[6] : null,
                EVN7_EventFacility = fields.Length > 7 ? fields[7] : null,
            };

            return evnSegment;
        }

        private PIDSegment_A02 ParsePIDSegment(string[] fields)
        {
            var pidSegment = new PIDSegment_A02
            {
                PID1_SetIDPid = fields.Length > 1 ? fields[1] : null,
                PID2_PatientID = fields.Length > 2 ? fields[2] : null,
                PID3_PatientIdentifierList = fields.Length > 3 ? fields[3].Split("^").ToList() : new List<string>(),
                PID4_AlternatePatientIDPid = fields.Length > 4 ? fields[4] : null,
                PID5_PatientName = fields.Length > 5 ? fields[5].Split("^").ToList() : new List<string>(),
                PID6_MotherMaidenName = fields.Length > 6 ? fields[6].Split("^").ToList() : null,
                PID7_DateTimeOfBirth = fields.Length > 7 ? fields[7] : null,
                PID8_AdministrativeSex = fields.Length > 8 ? fields[8] : null,
                PID9_PatientAlias = fields.Length > 9 ? fields[9] : null,
                PID10_Race = fields.Length > 10 ? fields[10].Split("^").ToList() : null,
                PID11_PatientAddress = fields.Length > 11 ? fields[11].Split("^").ToList() : null,
                PID12_CountyCode = fields.Length > 12 ? fields[12] : null,
                PID13_PhoneNumberHome = fields.Length > 13 ? fields[13].Split("^").ToList() : null,
                PID14_PhoneNumberBusiness = fields.Length > 14 ? fields[14].Split("^").ToList() : null,
                PID15_PrimaryLanguage = fields.Length > 15 ? fields[15] : null,
                PID16_MaritalStatus = fields.Length > 16 ? fields[16] : null,
                PID17_Religion = fields.Length > 17 ? fields[17] : null,
                PID18_PatientAccountNumber = fields.Length > 18 ? fields[18] : null,
                PID19_SsnNumberPatient = fields.Length > 19 ? fields[19] : null,
                PID20_DriverLicenseNumberPatient = fields.Length > 20 ? fields[20] : null,
                PID21_MotherIdentifier = fields.Length > 21 ? fields[21].Split("^").ToList() : null,
                PID22_EthnicGroup = fields.Length > 22 ? fields[22].Split("^").ToList() : null,
                PID23_BirthPlace = fields.Length > 23 ? fields[23] : null,
                PID24_MultipleBirthIndicator = fields.Length > 24 ? fields[24] : null,
                PID25_BirthOrder = fields.Length > 25 ? fields[25] : null,
                PID26_Citizenship = fields.Length > 26 ? fields[26].Split("^").ToList() : null,
                PID27_VeteransMilitaryStatus = fields.Length > 27 ? fields[27] : null,
                PID28_Nationality = fields.Length > 28 ? fields[28] : null,
                PID29_PatientDeathDateAndTime = fields.Length > 29 ? fields[29] : null,
                PID30_PatientDeathIndicator = fields.Length > 30 ? fields[30] : null,
                PID31_IdentityUnknownIndicator = fields.Length > 31 ? fields[31] : null,
                PID32_IdentityReliabilityCode = fields.Length > 32 ? fields[32].Split("^").ToList() : null,
                PID33_LastUpdateDateTime = fields.Length > 33 ? fields[33] : null,
                PID34_LastUpdateFacility = fields.Length > 34 ? fields[34] : null,
                PID35_TaxonomicClassificationCode = fields.Length > 35 ? fields[35] : null,
                PID36_BreedCode = fields.Length > 36 ? fields[36] : null,
                PID37_Strain = fields.Length > 37 ? fields[37] : null,
                PID38_ProductionClassCode = fields.Length > 38 ? fields[38].Split("^").ToList() : null,
                PID39_TribalCitizenship = fields.Length > 39 ? fields[39].Split("^").ToList() : null,
                PID40_PatientTelecommunicationInformation = fields.Length > 40 ? fields[40].Split("^").ToList() : null,
            };

            return pidSegment;
        }
        private PV1Segment_A02 ParsePV1Segment(string[] fields)
        {
            var pv1Segment = new PV1Segment_A02
            {
                PV1_1_SetIdPv1 = fields.Length > 1 ? fields[1] : null,
                PV1_2_PatientClass = fields.Length > 2 ? fields[2] : null,
                PV1_3_AssignedPatientLocation = fields.Length > 3 ? fields[3] : null,
                PV1_4_AdmissionType = fields.Length > 4 ? fields[4] : null,
                PV1_5_PreadmitNumber = fields.Length > 5 ? fields[5] : null,
                PV1_6_PriorPatientLocation = fields.Length > 6 ? fields[6] : null,
                PV1_7_AttendingDoctor = fields.Length > 7 ? fields[7].Split('~').ToList() : null,
                PV1_8_ReferringDoctor = fields.Length > 8 ? fields[8].Split('~').ToList() : null,
                PV1_9_ConsultingDoctor = fields.Length > 9 ? fields[9].Split('~').ToList() : null,
                PV1_10_HospitalService = fields.Length > 10 ? fields[10] : null,
                PV1_11_TemporaryLocation = fields.Length > 11 ? fields[11] : null,
                PV1_12_PreadmitTestIndicator = fields.Length > 12 ? fields[12] : null,
                PV1_13_ReAdmissionIndicator = fields.Length > 13 ? fields[13] : null,
                PV1_14_AdmitSource = fields.Length > 14 ? fields[14] : null,
                PV1_15_AmbulatoryStatus = fields.Length > 15 ? fields[15].Split('~').ToList() : null,
                PV1_16_VipIndicator = fields.Length > 16 ? fields[16] : null,
                PV1_17_AdmittingDoctor = fields.Length > 17 ? fields[17].Split('~').ToList() : null,
                PV1_18_PatientType = fields.Length > 18 ? fields[18] : null,
                PV1_19_VisitNumber = fields.Length > 19 ? fields[19] : null,
                PV1_20_FinancialClass = fields.Length > 20 ? fields[20].Split('~').ToList() : null,
                PV1_21_ChargePriceIndicator = fields.Length > 21 ? fields[21].Split('~').ToList() : null,
                PV1_22_CourtesyCode = fields.Length > 22 ? fields[22] : null,
                PV1_23_CreditRating = fields.Length > 23 ? fields[23] : null,
                PV1_24_ContractCode = fields.Length > 24 ? fields[24].Split('~').ToList() : null,
                PV1_25_ContractEffectiveDate = fields.Length > 25 ? fields[25].Split('~').ToList() : null,
                PV1_26_ContractAmount = fields.Length > 26 ? fields[26].Split('~').Select(decimal.Parse).ToList() : null,
                PV1_27_ContractPeriod = fields.Length > 27 ? fields[27].Split('~').Select(int.Parse).ToList() : null,
                PV1_28_InterestCode = fields.Length > 28 ? fields[28] : null,
                PV1_29_TransferToBadDebtCode = fields.Length > 29 ? fields[29] : null,
                PV1_30_TransferToBadDebtDate = fields.Length > 30 ? fields[30] : null,
                PV1_31_BadDebtAgencyCode = fields.Length > 31 ? fields[31] : null,
                PV1_32_BadDebtTransferAmount = fields.Length > 32 ? decimal.Parse(fields[32]) : null,
                PV1_33_BadDebtRecoveryAmount = fields.Length > 33 ? decimal.Parse(fields[33]) : null,
                PV1_34_DeleteAccountIndicator = fields.Length > 34 ? fields[34] : null,
                PV1_35_DeleteAccountDate = fields.Length > 35 ? fields[35] : null,
                PV1_36_DischargeDisposition = fields.Length > 36 ? fields[36] : null,
                PV1_37_DischargedToLocation = fields.Length > 37 ? fields[37] : null,
                PV1_38_DietType = fields.Length > 38 ? fields[38] : null,
                PV1_39_ServicingFacility = fields.Length > 39 ? fields[39] : null,
                PV1_40_BedStatus = fields.Length > 40 ? fields[40] : null,
                PV1_41_AccountStatus = fields.Length > 41 ? fields[41] : null,
                PV1_42_PendingLocation = fields.Length > 42 ? fields[42] : null,
                PV1_43_PriorTemporaryLocation = fields.Length > 43 ? fields[43] : null,
                PV1_44_AdmitDateTime = fields.Length > 44 ? fields[44] : null,
                PV1_45_DischargeDateTime = fields.Length > 45 ? fields[45] : null,
                PV1_46_CurrentPatientBalance = fields.Length > 46 ? decimal.TryParse(fields[46], out var currentPatientBalance) ? currentPatientBalance : null : null,
                PV1_47_TotalCharges = fields.Length > 47 ? decimal.TryParse(fields[47], out var totalCharges) ? totalCharges : null : null,
                PV1_48_TotalAdjustments = fields.Length > 48 ? decimal.TryParse(fields[48], out var totalAdjustments) ? totalAdjustments : null : null,
                PV1_49_TotalPayments = fields.Length > 49 ? decimal.TryParse(fields[49], out var totalPayments) ? totalPayments : null : null,
                PV1_50_AlternateVisitID = fields.Length > 50 ? fields[50] : null,
                PV1_51_VisitIndicator = fields.Length > 51 ? fields[51] : null,
                PV1_52_OtherHealthcareProvider = fields.Length > 52 ? fields[52] : null,
                PV1_53_ServiceEpisodeDescription = fields.Length > 53 ? fields[53] : null,
                PV1_54_ServiceEpisodeIdentifier = fields.Length > 54 ? fields[54] : null,
            };
            return pv1Segment;
        }
        private static List<string> GetSegmentsFromString(string message)
        {
            var segmentIdentifiers = new List<string> { "MSH", "SFT", "UAC", "EVN", "PID", "PD1", "ARV", "ROL", "NK1", "PV1", "PV2", "DB1", "OBX", "AL1", "DG1", "DRG", "PR1", "GT1", "IN1", "IN2", "IN3", "AUT", "RF1", "ACC", "UB1", "UB2" };
            var segments = new List<string>();
            var segmentStartIndexes = new List<int>();

            // Find start indexes of all segments
            foreach (var id in segmentIdentifiers)
            {
                int currentIndex = 0;
                while ((currentIndex = message.IndexOf(id + "|", currentIndex)) != -1)
                {
                    if (!segmentStartIndexes.Contains(currentIndex))
                    {
                        segmentStartIndexes.Add(currentIndex);
                        currentIndex++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            segmentStartIndexes.Sort();

            // Extract segments based on the start indexes
            for (int i = 0; i < segmentStartIndexes.Count; i++)
            {
                int start = segmentStartIndexes[i];
                int length = (i < segmentStartIndexes.Count - 1) ? segmentStartIndexes[i + 1] - start : message.Length - start;
                segments.Add(message.Substring(start, length).Trim());
            }

            return segments;
        }


        #endregion HL7ToJson
    }
}
