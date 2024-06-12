{
 "MSH_Message_Header": {
    "MSH1_FieldSeparator": "|",
    "MSH2_EncodingCharacters": "^~\\&",
    "MSH3_SendingApplication": "EHR_System",
    "MSH4_SendingFacility": "GeneralHospital",
    "MSH5_ReceivingApplication": "LabSystem",
    "MSH6_ReceivingFacility": "CentralLab",
    "MSH7_DateTimeOfMessage": "20240317143227",
    "MSH8_Security": "password123",
    "MSH9_MessageType": "ADT^A01",
    "MSH10_MessageControlId": "1234567890",
    "MSH11_ProcessingId": "P",
    "MSH12_VersionId": "2.5",
    "MSH13_SequenceNumber": null,
    "MSH14_ContinuationPointer": null,
    "MSH15_AcceptAcknowledgmentType": "AL",
    "MSH16_ApplicationAcknowledgmentType": "AL",
    "MSH17_CountryCode": "840",
    "MSH18_CharacterSet": ["ASCII"],
    "MSH19_PrincipalLanguageOfMessage": "ENG",
    "MSH20_AlternateCharacterSetHandlingScheme": "NONE",
    "MSH21_MessageProfileIdentifier": ["LabResultsProfile"],
    "MSH22_SendingResponsibleOrganization": "GeneralHospitalDept",
    "MSH23_ReceivingResponsibleOrganization": "CentralLabDept",
    "MSH24_SendingNetworkAddress": "10.0.0.1",
    "MSH25_ReceivingNetworkAddress": "10.0.1.1"
  },
  "sfT_Software_Segment": [
    {
      "sfT1_SoftwareVendorOrganization": "string",
      "sfT2_SoftwareCertifiedVersionOrReleaseNumber": "string",
      "sfT3_SoftwareProductName": "string",
      "sfT4_SoftwareBinaryId": "string",
      "sfT5_SoftwareProductInformation": "string",
      "sfT6_SoftwareInstallDate": "string"
    }
  ],
  "uaC_User_Authentication_Creential": [
    {
      "uaC1_UserAuthenticationCredentialTypeCode": "string",
      "uaC2_UserAuthenticationCredential": "string"
    }
  ],
  "EVN_Event_Type": {
    "EVN1_EventTypeCode": null,
    "EVN2_RecordedDateTime": "20240317150000",
    "EVN3_DateTimePlannedEvent": "20240318080000",
    "EVN4_EventReasonCode": "ROUTINE",
    "EVN5_OperatorId": ["op123"],
    "EVN6_EventOccurred": "20240317140000",
    "EVN7_EventFacility": "GeneralHospital"
  },
  "PID_Patient_Identification": {
    "PID1_SetIDPid": "1",
    "PID2_PatientID": "987654321",
    "PID3_PatientIdentifierList": ["MRN987654321"],
    "PID4_AlternatePatientIDPid": "A987654321",
    "PID5_PatientName": ["Doe^John^"],
    "PID6_MotherMaidenName": ["Smith^Jane^"],
    "PID7_DateTimeOfBirth": "19800101000000",
    "PID8_AdministrativeSex": "M",
    "PID9_PatientAlias": null,
    "PID10_Race": ["2106-3"],
    "PID11_PatientAddress": ["123 Main St^Apt 1^Anytown^CA^12345^USA"],
    "PID12_CountyCode": "123",
    "PID13_PhoneNumberHome": ["(555)555-1234"],
    "PID14_PhoneNumberBusiness": ["(555)555-5678"],
    "PID15_PrimaryLanguage": "ENG",
    "PID16_MaritalStatus": "S",
    "PID17_Religion": "101",
    "PID18_PatientAccountNumber": "ACC123456789",
    "PID19_SsnNumberPatient": "123-45-6789",
    "PID20_DriverLicenseNumberPatient": "D1234567",
    "PID21_MotherIdentifier": ["M987654321"],
    "PID22_EthnicGroup": ["HISPANIC"],
    "PID23_BirthPlace": "Anytown, CA",
    "PID24_MultipleBirthIndicator": "N",
    "PID25_BirthOrder": null,
    "PID26_Citizenship": ["USA"],
    "PID27_VeteransMilitaryStatus": null,
    "PID28_Nationality": "USA",
    "PID29_PatientDeathDateAndTime": null,
    "PID30_PatientDeathIndicator": "N",
    "PID31_IdentityUnknownIndicator": "N",
    "PID32_IdentityReliabilityCode": ["US"],
    "PID33_LastUpdateDateTime": "20240317000000",
    "PID34_LastUpdateFacility": "GeneralHospital",
    "PID35_TaxonomicClassificationCode": null,
    "PID36_BreedCode": null,
    "PID37_Strain": null,
    "PID38_ProductionClassCode": [],
    "PID39_TribalCitizenship": [],
    "PID40_PatientTelecommunicationInformation": ["tel:(555)555-1234"]
  },
  "pD1_Patient_Additional_Demographic": {
    "pD1_1_LivingDependency": [
      "string"
    ],
    "pD1_2_LivingArrangement": "string",
    "pD1_3_PatientPrimaryFacility": [
      "string"
    ],
    "pD1_4_PatientPrimaryCareProviderNameIdNo": "string",
    "pD1_5_StudentIndicator": "string",
    "pD1_6_Handicap": "string",
    "pD1_7_LivingWillCode": "string",
    "pD1_8_OrganDonorCode": "string",
    "pD1_9_SeparateBill": "string",
    "pD1_10_DuplicatePatient": [
      "string"
    ],
    "pD1_11_PublicityCode": "string",
    "pD1_12_ProtectionIndicator": "string",
    "pD1_13_ProtectionIndicatorEffectiveDate": "string",
    "pD1_14_PlaceOfWorship": [
      "string"
    ],
    "pD1_15_AdvanceDirectiveCode": [
      "string"
    ],
    "pD1_16_ImmunizationRegistryStatus": "string",
    "pD1_17_ImmunizationRegistryStatusEffectiveDate": "string",
    "pD1_18_PublicityCodeEffectiveDate": "string",
    "pD1_19_MilitaryBranch": "string",
    "pD1_20_MilitaryRankGrade": "string",
    "pD1_21_MilitaryStatus": "string",
    "pD1_22_AdvanceDirectiveLastVerifiedDate": "string"
  },
  "arV_Access_Restriction": [
    {
      "arV1_SetId": "string",
      "arV2_AccessRestrictionActionCode": "string",
      "arV3_AccessRestrictionValue": "string",
      "arV4_AccessRestrictionReason": [
        "string"
      ],
      "arV5_SpecialAccessRestrictionInstructions": [
        "string"
      ],
      "arV6_AccessRestrictionDateRange": "string"
    }
  ],
  "roL_Role": [
    {
      "roL1_RoleInstanceId": "string",
      "roL2_ActionCode": "string",
      "roL3_RoleRol": "string",
      "roL4_RolePerson": [
        "string"
      ],
      "roL5_RoleBeginDateTime": "string",
      "roL6_RoleEndDateTime": "string",
      "roL7_RoleDuration": "string",
      "roL8_RoleActionReason": "string",
      "roL9_ProviderType": [
        "string"
      ],
      "roL10_OrganizationUnitType": "string",
      "roL11_OfficeHomeAddressBirthplace": [
        "string"
      ],
      "roL12_Phone": [
        "string"
      ],
      "roL13_PersonsLocation": "string",
      "roL14_Organization": "string"
    }
  ],
  "nK1_Next_Kin": [
    {
      "nK1_1_SetIdNk1": "string",
      "nK1_2_Name": [
        "string"
      ],
      "nK1_3_Relationship": "string",
      "nK1_4_Address": [
        "string"
      ],
      "nK1_5_PhoneNumber": [
        "string"
      ],
      "nK1_6_BusinessPhoneNumber": [
        "string"
      ],
      "nK1_7_ContactRole": "string",
      "nK1_8_StartDate": "string",
      "nK1_9_EndDate": "string",
      "nK1_10_NextOfKinAssociatedPartiesJobTitle": "string",
      "nK1_11_NextOfKinAssociatedPartiesJobCodeClass": "string",
      "nK1_12_NextOfKinAssociatedPartiesEmployeeNumber": "string",
      "nK1_13_OrganizationNameNk1": [
        "string"
      ],
      "nK1_14_MaritalStatus": "string",
      "nK1_15_AdministrativeSex": "string",
      "nK1_16_DateTimeOfBirth": "string",
      "nK1_17_LivingDependency": [
        "string"
      ],
      "nK1_18_AmbulatoryStatus": [
        "string"
      ],
      "nK1_19_Citizenship": [
        "string"
      ],
      "nK1_20_PrimaryLanguage": "string",
      "nK1_21_LivingArrangement": "string",
      "nK1_22_PublicityCode": "string",
      "nK1_23_ProtectionIndicator": "string",
      "nK1_24_StudentIndicator": "string",
      "nK1_25_Religion": "string",
      "nK1_26_MotherMaidenName": [
        "string"
      ],
      "nK1_27_Nationality": "string",
      "nK1_28_EthnicGroup": [
        "string"
      ],
      "nK1_29_ContactReason": [
        "string"
      ],
      "nK1_30_ContactPersonsName": [
        "string"
      ],
      "nK1_31_ContactPersonsTelephoneNumber": [
        "string"
      ],
      "nK1_32_ContactPersonsAddress": [
        "string"
      ],
      "nK1_33_NextOfKinAssociatedPartysIdentifiers": [
        "string"
      ],
      "nK1_34_JobStatus": "string",
      "nK1_35_Race": [
        "string"
      ],
      "nK1_36_Handicap": "string",
      "nK1_37_ContactPersonSocialSecurityNumber": "string",
      "nK1_38_NextOfKinBirthPlace": "string",
      "nK1_39_VipIndicator": "string",
      "nK1_40_NextOfKinTelecommunicationInformation": "string",
      "nK1_41_ContactPersonsTelecommunicationInformation": "string"
    }
  ],
  "PV1_Patient_Visit": {
    "PV1_1_SetIdPv1": "1",
    "PV1_2_PatientClass": "O",
    "PV1_3_AssignedPatientLocation": "OutpatientClinic",
    "PV1_4_AdmissionType": "Routine",
    "PV1_5_PreadmitNumber": "PAD123456789",
    "PV1_6_PriorPatientLocation": null,
    "PV1_7_AttendingDoctor": ["DrJones^Mary^"],
    "PV1_8_ReferringDoctor": ["DrSmith^John^"],
    "PV1_9_ConsultingDoctor": ["DrDoe^Jane^"],
    "PV1_10_HospitalService": "MED",
    "PV1_11_TemporaryLocation": null,
    "PV1_12_PreadmitTestIndicator": "N",
    "PV1_13_ReAdmissionIndicator": "N",
    "PV1_14_AdmitSource": "Physician Referral",
    "PV1_15_AmbulatoryStatus": ["A0"],
    "PV1_16_VipIndicator": "N",
    "PV1_17_AdmittingDoctor": ["DrDoe^Jane^"],
    "PV1_18_PatientType": "Regular",
    "PV1_19_VisitNumber": "V123456789",
    "PV1_20_FinancialClass": ["Self Pay"],
    "PV1_21_ChargePriceIndicator": ["Standard"],
    "PV1_22_CourtesyCode": "Standard",
    "PV1_23_CreditRating": "Good",
    "PV1_24_ContractCode": ["None"],
    "PV1_25_ContractEffectiveDate": ["202403171432"],
    "PV1_26_ContractAmount": [0],
    "PV1_27_ContractPeriod": [0],
    "PV1_28_InterestCode": "None",
    "PV1_29_TransferToBadDebtCode": "N",
    "PV1_30_TransferToBadDebtDate": "202403171432",
    "PV1_31_BadDebtAgencyCode": "",
    "PV1_32_BadDebtTransferAmount": 0,
    "PV1_33_BadDebtRecoveryAmount": 0,
    "PV1_34_DeleteAccountIndicator": "N",
    "PV1_35_DeleteAccountDate": "202403171432",
    "PV1_36_DischargeDisposition": "",
    "PV1_37_DischargedToLocation": "",
    "PV1_38_DietType": "Standard",
    "PV1_39_ServicingFacility": "Main Campus",
    "PV1_40_BedStatus": "Available",
    "PV1_41_AccountStatus": "Active",
    "PV1_42_PendingLocation": "",
    "PV1_43_PriorTemporaryLocation": "",
    "PV1_44_AdmitDateTime": "202403171432",
    "PV1_45_DischargeDateTime": "202403170000",
    "PV1_46_CurrentPatientBalance": 0,
    "PV1_47_TotalCharges": 0,
    "PV1_48_TotalAdjustments": 0,
    "PV1_49_TotalPayments": 0,
    "PV1_50_AlternateVisitID": "",
    "PV1_51_VisitIndicator": "A",
    "PV1_52_OtherHealthcareProvider": ""
	
  },
  "pV2_Patient_Visit_Additional": {
    "pV2_1_PriorPendingLocation": "string",
    "pV2_2_AccommodationCode": "string",
    "pV2_3_AdmitReason": "string",
    "pV2_4_TransferReason": "string",
    "pV2_5_PatientValuables": [
      "string"
    ],
    "pV2_6_PatientValuablesLocation": "string",
    "pV2_7_VisitUserCode": [
      "string"
    ],
    "pV2_8_ExpectedAdmitDateTime": "string",
    "pV2_9_ExpectedDischargeDateTime": "string",
    "pV2_10_EstimatedLengthOfInpatientStay": "string",
    "pV2_11_ActualLengthOfInpatientStay": "string",
    "pV2_12_VisitDescription": "string",
    "pV2_13_ReferralSourceCode": [
      "string"
    ],
    "pV2_14_PreviousServiceDate": "string",
    "pV2_15_EmploymentIllnessRelatedIndicator": "string",
    "pV2_16_PurgeStatusCode": "string",
    "pV2_17_PurgeStatusDate": "string",
    "pV2_18_SpecialProgramCode": "string",
    "pV2_19_RetentionIndicator": "string",
    "pV2_20_ExpectedNumberOfInsurancePlans": "string",
    "pV2_21_VisitPublicityCode": "string",
    "pV2_22_VisitProtectionIndicator": "string",
    "pV2_23_ClinicOrganizationName": [
      "string"
    ],
    "pV2_24_PatientStatusCode": "string",
    "pV2_25_VisitPriorityCode": "string",
    "pV2_26_PreviousTreatmentDate": "string",
    "pV2_27_ExpectedDischargeDisposition": "string",
    "pV2_28_SignatureOnFileDate": "string",
    "pV2_29_FirstSimilarIllnessDate": "string",
    "pV2_30_PatientChargeAdjustmentCode": "string",
    "pV2_31_RecurringServiceCode": "string",
    "pV2_32_BillingMediaCode": "string",
    "pV2_33_ExpectedSurgeryDateAndTime": "string",
    "pV2_34_MilitaryPartnershipCode": "string",
    "pV2_35_MilitaryNonAvailabilityCode": "string",
    "pV2_36_NewbornBabyIndicator": "string",
    "pV2_37_BabyDetainedIndicator": "string",
    "pV2_38_ModeOfArrivalCode": "string",
    "pV2_39_RecreationalDrugUseCode": [
      "string"
    ],
    "pV2_40_AdmissionLevelOfCareCode": "string",
    "pV2_41_PrecautionCode": [
      "string"
    ],
    "pV2_42_PatientConditionCode": "string",
    "pV2_43_LivingWillCode": "string",
    "pV2_44_OrganDonorCode": "string",
    "pV2_45_AdvanceDirectiveCode": [
      "string"
    ],
    "pV2_46_PatientStatusEffectiveDate": "string",
    "pV2_47_ExpectedLoaReturnDateTime": "string",
    "pV2_48_ExpectedPreAdmissionTestingDateTime": "string",
    "pV2_49_NotifyClergyCode": [
      "string"
    ],
    "pV2_50_AdvanceDirectiveLastVerifiedDate": "string"
  },
  "arV_AccessRestriction_Additional_Patient_Visit": [
    {
      "arV1_SetId": "string",
      "arV2_AccessRestrictionActionCode": "string",
      "arV3_AccessRestrictionValue": "string",
      "arV4_AccessRestrictionReason": [
        "string"
      ],
      "arV5_SpecialAccessRestrictionInstructions": [
        "string"
      ],
      "arV6_AccessRestrictionDateRange": "string"
    }
  ],
  "roL_Additional_Patient_Visit": [
    {
      "roL1_RoleInstanceId": "string",
      "roL2_ActionCode": "string",
      "roL3_RoleRol": "string",
      "roL4_RolePerson": [
        "string"
      ],
      "roL5_RoleBeginDateTime": "string",
      "roL6_RoleEndDateTime": "string",
      "roL7_RoleDuration": "string",
      "roL8_RoleActionReason": "string",
      "roL9_ProviderType": [
        "string"
      ],
      "roL10_OrganizationUnitType": "string",
      "roL11_OfficeHomeAddressBirthplace": [
        "string"
      ],
      "roL12_Phone": [
        "string"
      ],
      "roL13_PersonsLocation": "string",
      "roL14_Organization": "string"
    }
  ],
  "dB1_Disability": [
    {
      "dB1_1_SetIdDb1": "string",
      "dB1_2_DisabledPersonCode": "string",
      "dB1_3_DisabledPersonIdentifier": [
        "string"
      ],
      "dB1_4_DisabilityIndicator": "string",
      "dB1_5_DisabilityStartDate": "string",
      "dB1_6_DisabilityEndDate": "string",
      "dB1_7_DisabilityReturnToWorkDate": "string",
      "dB1_8_DisabilityUnableToWorkDate": "string"
    }
  ],
  "obX_Observation_Result": [
    {
      "obX1_SetIdObx": "string",
      "obX2_ValueType": "string",
      "obX3_ObservationIdentifier": "string",
      "obX4_ObservationSubId": "string",
      "obX5_ObservationValue": [
        "string"
      ],
      "obX6_Units": "string",
      "obX7_ReferencesRange": "string",
      "obX8_InterpretationCodes": [
        "string"
      ],
      "obX9_Probability": "string",
      "obX10_NatureOfAbnormalTest": [
        "string"
      ],
      "obX11_ObservationResultStatus": "string",
      "obX12_EffectiveDateOfReferenceRange": "string",
      "obX13_UserDefinedAccessChecks": "string",
      "obX14_DateTimeOfTheObservation": "string",
      "obX15_ProducersId": "string",
      "obX16_ResponsibleObserver": [
        "string"
      ],
      "obX17_ObservationMethod": [
        "string"
      ],
      "obX18_EquipmentInstanceIdentifier": [
        "string"
      ],
      "obX19_DateTimeOfTheAnalysis": "string",
      "obX20_ObservationSite": [
        "string"
      ],
      "obX21_ObservationInstanceIdentifier": "string",
      "obX22_MoodCode": "string",
      "obX23_PerformingOrganizationName": "string",
      "obX24_PerformingOrganizationAddress": "string",
      "obX25_PerformingOrganizationMedicalDirector": "string",
      "obX26_PatientResultsReleaseCategory": "string",
      "obX27_RootCause": "string",
      "obX28_LocalProcessControl": [
        "string"
      ]
    }
  ],
  "aL1_Patient_Allergy": [
    {
      "aL1_1_SetIdAl1": "string",
      "aL1_2_AllergenTypeCode": "string",
      "aL1_3_AllergenCodeMnemonicDescription": "string",
      "aL1_4_AllergySeverityCode": "string",
      "aL1_5_AllergyReactionCode": [
        "string"
      ],
      "aL1_6_IdentificationDate": "string"
    }
  ],
  "dG1_Diagnosis": [
    {
      "dG1_1_SetIdDg1": "string",
      "dG1_2_DiagnosisCodingMethod": "string",
      "dG1_3_DiagnosisCodeDg1": "string",
      "dG1_4_DiagnosisDescription": "string",
      "dG1_5_DiagnosisDateTime": "string",
      "dG1_6_DiagnosisType": "string",
      "dG1_7_MajorDiagnosticCategory": "string",
      "dG1_8_DiagnosticRelatedGroup": "string",
      "dG1_9_DrgApprovalIndicator": "string",
      "dG1_10_DrgGrouperReviewCode": "string",
      "dG1_11_OutlierType": "string",
      "dG1_12_OutlierDays": "string",
      "dG1_13_OutlierCost": "string",
      "dG1_14_GrouperVersionAndType": "string",
      "dG1_15_DiagnosisPriority": "string",
      "dG1_16_DiagnosingClinician": [
        "string"
      ],
      "dG1_17_DiagnosisClassification": "string",
      "dG1_18_ConfidentialIndicator": "string",
      "dG1_19_AttestationDateTime": "string",
      "dG1_20_DiagnosisIdentifier": "string",
      "dG1_21_DiagnosisActionCode": "string",
      "dG1_22_ParentDiagnosis": "string",
      "dG1_23_DrgCclValueCode": "string",
      "dG1_24_DrgGroupingUsage": "string",
      "dG1_25_DrgDiagnosisDeterminationStatus": "string",
      "dG1_26_PresentOnAdmissionIndicator": "string"
    }
  ],
  "drG_Diagnosis_Related_Group": [
    {
      "drG1_DiagnosticRelatedGroup": "string",
      "drG2_DrgAssignedDateTime": "string",
      "drG3_DrgApprovalIndicator": "string",
      "drG4_DrgGrouperReviewCode": "string",
      "drG5_OutlierType": "string",
      "drG6_OutlierDays": "string",
      "drG7_OutlierCost": "string",
      "drG8_DrgPayor": "string",
      "drG9_OutlierReimbursement": "string",
      "drG10_ConfidentialIndicator": "string",
      "drG11_DrgTransferType": "string",
      "drG12_NameOfCoder": "string",
      "drG13_GrouperStatus": "string",
      "drG14_PcclValueCode": "string",
      "drG15_EffectiveWeight": "string",
      "drG16_MonetaryAmount": "string",
      "drG17_StatusPatient": "string",
      "drG18_GrouperSoftwareName": "string",
      "drG19_GrouperSoftwareVersion": "string",
      "drG20_StatusFinancialCalculation": "string",
      "drG21_RelativeDiscountSurcharge": "string",
      "drG22_BasicCharge": "string",
      "drG23_TotalCharge": "string",
      "drG24_DiscountSurcharge": "string",
      "drG25_CalculatedDays": "string",
      "drG26_StatusGender": "string",
      "drG27_StatusAge": "string",
      "drG28_StatusLengthOfStay": "string",
      "drG29_StatusSameDayFlag": "string",
      "drG30_StatusSeparationMode": "string",
      "drG31_StatusWeightAtBirth": "string",
      "drG32_StatusRespirationMinutes": "string",
      "drG33_StatusAdmission": "string"
    }
  ],
  "procedure": {
    "pR1_Procedures": {
      "pR1_1_SetIdPr1": "string",
      "pR1_2_ProcedureCodingMethod": "string",
      "pR1_3_ProcedureCode": "string",
      "pR1_4_ProcedureDescription": "string",
      "pR1_5_ProcedureDateTime": "string",
      "pR1_6_ProcedureFunctionalType": "string",
      "pR1_7_ProcedureMinutes": "string",
      "pR1_8_Anesthesiologist": "string",
      "pR1_9_AnesthesiaCode": "string",
      "pR1_10_AnesthesiaMinutes": "string",
      "pR1_11_Surgeon": "string",
      "pR1_12_ProcedurePractitioner": "string",
      "pR1_13_ConsentCode": "string",
      "pR1_14_ProcedurePriority": "string",
      "pR1_15_AssociatedDiagnosisCode": "string",
      "pR1_16_ProcedureCodeModifier": [
        "string"
      ],
      "pR1_17_ProcedureDrgType": "string",
      "pR1_18_TissueTypeCode": [
        "string"
      ],
      "pR1_19_ProcedureIdentifier": "string",
      "pR1_20_ProcedureActionCode": "string",
      "pR1_21_DrgProcedureDeterminationStatus": "string",
      "pR1_22_DrgProcedureRelevance": "string",
      "pR1_23_TreatingOrganizationalUnit": [
        "string"
      ],
      "pR1_24_RespiratoryWithinSurgery": "string",
      "pR1_25_ParentProcedureId": "string"
    },
    "roL_Procedure": [
      {
        "roL1_RoleInstanceId": "string",
        "roL2_ActionCode": "string",
        "roL3_RoleRol": "string",
        "roL4_RolePerson": [
          "string"
        ],
        "roL5_RoleBeginDateTime": "string",
        "roL6_RoleEndDateTime": "string",
        "roL7_RoleDuration": "string",
        "roL8_RoleActionReason": "string",
        "roL9_ProviderType": [
          "string"
        ],
        "roL10_OrganizationUnitType": "string",
        "roL11_OfficeHomeAddressBirthplace": [
          "string"
        ],
        "roL12_Phone": [
          "string"
        ],
        "roL13_PersonsLocation": "string",
        "roL14_Organization": "string"
      }
    ]
  },
  "gT1_Gurantor": [
    {
      "gT1_1_SetIdGt1": "string",
      "gT1_2_GuarantorNumber": [
        "string"
      ],
      "gT1_3_GuarantorName": [
        "string"
      ],
      "gT1_4_GuarantorSpouseName": [
        "string"
      ],
      "gT1_5_GuarantorAddress": [
        "string"
      ],
      "gT1_6_GuarantorPhNumHome": [
        "string"
      ],
      "gT1_7_GuarantorPhNumBusiness": [
        "string"
      ],
      "gT1_8_GuarantorDateTimeOfBirth": "string",
      "gT1_9_GuarantorAdministrativeSex": "string",
      "gT1_10_GuarantorType": "string",
      "gT1_11_GuarantorRelationship": "string",
      "gT1_12_GuarantorSsn": "string",
      "gT1_13_GuarantorDateBegin": "string",
      "gT1_14_GuarantorDateEnd": "string",
      "gT1_15_GuarantorPriority": "string",
      "gT1_16_GuarantorEmployerName": [
        "string"
      ],
      "gT1_17_GuarantorEmployerAddress": [
        "string"
      ],
      "gT1_18_GuarantorEmployerPhoneNumber": [
        "string"
      ],
      "gT1_19_GuarantorEmployeeIdNumber": [
        "string"
      ],
      "gT1_20_GuarantorEmploymentStatus": "string",
      "gT1_21_GuarantorOrganizationName": [
        "string"
      ],
      "gT1_22_GuarantorBillingHoldFlag": "string",
      "gT1_23_GuarantorCreditRatingCode": "string",
      "gT1_24_GuarantorDeathDateTime": "string",
      "gT1_25_GuarantorDeathFlag": "string",
      "gT1_26_GuarantorChargeAdjustmentCode": "string",
      "gT1_27_GuarantorHouseholdAnnualIncome": "string",
      "gT1_28_GuarantorHouseholdSize": "string",
      "gT1_29_GuarantorEmployerIdNumber": [
        "string"
      ],
      "gT1_30_GuarantorMaritalStatusCode": "string",
      "gT1_31_GuarantorHireEffectiveDate": "string",
      "gT1_32_EmploymentStopDate": "string",
      "gT1_33_LivingDependency": "string",
      "gT1_34_AmbulatoryStatus": [
        "string"
      ],
      "gT1_35_Citizenship": [
        "string"
      ],
      "gT1_36_PrimaryLanguage": "string",
      "gT1_37_LivingArrangement": "string",
      "gT1_38_PublicityCode": "string",
      "gT1_39_ProtectionIndicator": "string",
      "gT1_40_StudentIndicator": "string",
      "gT1_41_Religion": "string",
      "gT1_42_MotherMaidenName": [
        "string"
      ],
      "gT1_43_Nationality": "string",
      "gT1_44_EthnicGroup": [
        "string"
      ],
      "gT1_45_ContactPersonsName": [
        "string"
      ],
      "gT1_46_ContactPersonsTelephoneNumber": [
        "string"
      ],
      "gT1_47_ContactReason": "string",
      "gT1_48_ContactRelationship": "string",
      "gT1_49_JobTitle": "string",
      "gT1_50_JobCodeClass": "string",
      "gT1_51_GuarantorEmployersOrganizationName": [
        "string"
      ],
      "gT1_52_Handicap": "string",
      "gT1_53_JobStatus": "string",
      "gT1_54_GuarantorFinancialClass": "string",
      "gT1_55_GuarantorRace": [
        "string"
      ],
      "gT1_56_GuarantorBirthPlace": "string",
      "gT1_57_VipIndicator": "string"
    }
  ],
  "insurance": {
    "iN1_Insurance": {
      "iN1_1_SetIdIn1": "string",
      "iN1_2_HealthPlanId": "string",
      "iN1_3_InsuranceCompanyId": [
        "string"
      ],
      "iN1_4_InsuranceCompanyName": [
        "string"
      ],
      "iN1_5_InsuranceCompanyAddress": [
        "string"
      ],
      "iN1_6_InsuranceCoContactPerson": [
        "string"
      ],
      "iN1_7_InsuranceCoPhoneNumber": [
        "string"
      ],
      "iN1_8_GroupNumber": "string",
      "iN1_9_GroupName": [
        "string"
      ],
      "iN1_10_InsuredsGroupEmpId": [
        "string"
      ],
      "iN1_11_InsuredsGroupEmpName": [
        "string"
      ],
      "iN1_12_PlanEffectiveDate": "string",
      "iN1_13_PlanExpirationDate": "string",
      "iN1_14_AuthorizationInformation": "string",
      "iN1_15_PlanType": "string",
      "iN1_16_NameOfInsured": [
        "string"
      ],
      "iN1_17_InsuredsRelationshipToPatient": "string",
      "iN1_18_InsuredsDateOfBirth": "string",
      "iN1_19_InsuredsAddress": [
        "string"
      ],
      "iN1_20_AssignmentOfBenefits": "string",
      "iN1_21_CoordinationOfBenefits": "string",
      "iN1_22_CoordOfBenPriority": "string",
      "iN1_23_NoticeOfAdmissionFlag": "string",
      "iN1_24_NoticeOfAdmissionDate": "string",
      "iN1_25_ReportOfEligibilityFlag": "string",
      "iN1_26_ReportOfEligibilityDate": "string",
      "iN1_27_ReleaseInformationCode": "string",
      "iN1_28_PreAdmitCert": "string",
      "iN1_29_VerificationDateTime": "string",
      "iN1_30_VerificationBy": [
        "string"
      ],
      "iN1_31_TypeOfAgreementCode": "string",
      "iN1_32_BillingStatus": "string",
      "iN1_33_LifetimeReserveDays": "string",
      "iN1_34_DelayBeforeLRDay": "string",
      "iN1_35_CompanyPlanCode": "string",
      "iN1_36_PolicyNumber": "string",
      "iN1_37_PolicyDeductible": "string",
      "iN1_38_PolicyLimitAmount": "string",
      "iN1_39_PolicyLimitDays": "string",
      "iN1_40_RoomRateSemiPrivate": "string",
      "iN1_41_RoomRatePrivate": "string",
      "iN1_42_InsuredsEmploymentStatus": "string",
      "iN1_43_InsuredsAdministrativeSex": "string",
      "iN1_44_InsuredsEmployersAddress": [
        "string"
      ],
      "iN1_45_VerificationStatus": "string",
      "iN1_46_PriorInsurancePlanId": "string",
      "iN1_47_CoverageType": "string",
      "iN1_48_Handicap": "string",
      "iN1_49_InsuredsIdNumber": [
        "string"
      ],
      "iN1_50_SignatureCode": "string",
      "iN1_51_SignatureCodeDate": "string",
      "iN1_52_InsuredsBirthPlace": "string",
      "iN1_53_VipIndicator": "string",
      "iN1_54_ExternalHealthPlanIdentifiers": [
        "string"
      ],
      "iN1_55_InsuranceActionCode": "string"
    },
    "iN2_Insurance_Additinal_Inforamtion": [
      {
        "iN2_1_InsuredsEmployeeId": "string",
        "iN2_2_InsuredsSocialSecurityNumber": "string",
        "iN2_3_InsuredsEmployersNameAndId": [
          "string"
        ],
        "iN2_4_EmployerInformationData": "string",
        "iN2_5_MailClaimParty": [
          "string"
        ],
        "iN2_6_MedicareHealthInsCardNumber": "string",
        "iN2_7_MedicaidCaseName": [
          "string"
        ],
        "iN2_8_MedicaidCaseNumber": "string",
        "iN2_9_MilitarySponsorName": [
          "string"
        ],
        "iN2_10_MilitaryIdNumber": "string",
        "iN2_11_DependentOfMilitaryRecipient": "string",
        "iN2_12_MilitaryOrganization": "string",
        "iN2_13_MilitaryStation": "string",
        "iN2_14_MilitaryService": "string",
        "iN2_15_MilitaryRankGrade": "string",
        "iN2_16_MilitaryStatus": "string",
        "iN2_17_MilitaryRetireDate": "string",
        "iN2_18_MilitaryNonAvailCertOnFile": "string",
        "iN2_19_BabyCoverage": "string",
        "iN2_20_CombineBabyBill": "string",
        "iN2_21_BloodDeductible": "string",
        "iN2_22_SpecialCoverageApprovalName": [
          "string"
        ],
        "iN2_23_SpecialCoverageApprovalTitle": "string",
        "iN2_24_NonCoveredInsuranceCode": [
          "string"
        ],
        "iN2_25_PayorId": [
          "string"
        ],
        "iN2_26_PayorSubscriberId": [
          "string"
        ],
        "iN2_27_EligibilitySource": "string",
        "iN2_28_RoomCoverageTypeAmount": [
          "string"
        ],
        "iN2_29_PolicyTypeAmount": [
          "string"
        ],
        "iN2_30_DailyDeductible": "string",
        "iN2_31_LivingDependency": "string",
        "iN2_32_AmbulatoryStatus": [
          "string"
        ],
        "iN2_33_Citizenship": [
          "string"
        ],
        "iN2_34_PrimaryLanguage": "string",
        "iN2_35_LivingArrangement": "string",
        "iN2_36_PublicityCode": "string",
        "iN2_37_ProtectionIndicator": "string",
        "iN2_38_StudentIndicator": "string",
        "iN2_39_Religion": "string",
        "iN2_40_MothersMaidenName": [
          "string"
        ],
        "iN2_41_Nationality": "string",
        "iN2_42_EthnicGroup": [
          "string"
        ],
        "iN2_43_MaritalStatus": [
          "string"
        ],
        "iN2_44_InsuredsEmploymentStartDate": "string",
        "iN2_45_EmploymentStopDate": "string",
        "iN2_46_JobTitle": "string",
        "iN2_47_JobCodeClass": "string",
        "iN2_48_JobStatus": "string",
        "iN2_49_EmployerContactPersonName": [
          "string"
        ],
        "iN2_50_EmployerContactPersonPhoneNumber": [
          "string"
        ],
        "iN2_51_EmployerContactReason": "string",
        "iN2_52_InsuredsContactPersonsName": [
          "string"
        ],
        "iN2_53_InsuredsContactPersonPhoneNumber": [
          "string"
        ],
        "iN2_54_InsuredsContactPersonReason": [
          "string"
        ],
        "iN2_55_RelationshipToThePatientStartDate": "string",
        "iN2_56_RelationshipToThePatientStopDate": [
          "string"
        ],
        "iN2_57_InsuranceCoContactReason": "string",
        "iN2_58_InsuranceCoContactPhoneNumber": [
          "string"
        ],
        "iN2_59_PolicyScope": "string",
        "iN2_60_PolicySource": "string",
        "iN2_61_PatientMemberNumber": "string",
        "iN2_62_GuarantorsRelationshipToInsured": "string",
        "iN2_63_InsuredsPhoneNumberHome": [
          "string"
        ],
        "iN2_64_InsuredsEmployerPhoneNumber": [
          "string"
        ],
        "iN2_65_MilitaryHandicappedProgram": "string",
        "iN2_66_SuspendFlag": "string",
        "iN2_67_CopayLimitFlag": "string",
        "iN2_68_StoplossLimitFlag": "string",
        "iN2_69_InsuredOrganizationNameAndId": [
          "string"
        ],
        "iN2_70_InsuredEmployerOrganizationNameAndId": [
          "string"
        ],
        "iN2_71_Race": [
          "string"
        ],
        "iN2_72_PatientsRelationshipToInsured": "string"
      }
    ],
    "iN3_Insurance_Additinal_Inforamtion_Certification": [
      {
        "iN3_1_SetId": "string",
        "iN3_2_CertificationNumber": "string",
        "iN3_3_CertifiedBy": [
          "string"
        ],
        "iN3_4_CertificationRequired": "string",
        "iN3_5_Penalty": "string",
        "iN3_6_CertificationDateTime": "string",
        "iN3_7_CertificationModifyDateTime": "string",
        "iN3_8_Operator": [
          "string"
        ],
        "iN3_9_CertificationBeginDate": "string",
        "iN3_10_CertificationEndDate": "string",
        "iN3_11_Days": "string",
        "iN3_12_NonConcurCodeDescription": "string",
        "iN3_13_NonConcurEffectiveDateTime": "string",
        "iN3_14_PhysicianReviewer": [
          "string"
        ],
        "iN3_15_CertificationContact": "string",
        "iN3_16_CertificationContactPhoneNumber": [
          "string"
        ],
        "iN3_17_AppealReason": "string",
        "iN3_18_CertificationAgency": "string",
        "iN3_19_CertificationAgencyPhoneNumber": [
          "string"
        ],
        "iN3_20_PreCertificationRequirement": [
          "string"
        ],
        "iN3_21_CaseManager": "string",
        "iN3_22_SecondOpinionDate": "string",
        "iN3_23_SecondOpinionStatus": "string",
        "iN3_24_SecondOpinionDocumentationReceived": [
          "string"
        ],
        "iN3_25_SecondOpinionPhysician": [
          "string"
        ],
        "iN3_26_CertificationType": "string",
        "iN3_27_CertificationCategory": "string"
      }
    ],
    "roL_Insurance": [
      {
        "roL1_RoleInstanceId": "string",
        "roL2_ActionCode": "string",
        "roL3_RoleRol": "string",
        "roL4_RolePerson": [
          "string"
        ],
        "roL5_RoleBeginDateTime": "string",
        "roL6_RoleEndDateTime": "string",
        "roL7_RoleDuration": "string",
        "roL8_RoleActionReason": "string",
        "roL9_ProviderType": [
          "string"
        ],
        "roL10_OrganizationUnitType": "string",
        "roL11_OfficeHomeAddressBirthplace": [
          "string"
        ],
        "roL12_Phone": [
          "string"
        ],
        "roL13_PersonsLocation": "string",
        "roL14_Organization": "string"
      }
    ],
    "auT_Authorization_Information": [
      {
        "auT_1_AuthorizingPayorPlanId": "string",
        "auT_2_AuthorizingPayorCompanyId": "string",
        "auT_3_AuthorizingPayorCompanyName": "string",
        "auT_4_AuthorizationEffectiveDate": "string",
        "auT_5_AuthorizationExpirationDate": "string",
        "auT_6_AuthorizationIdentifier": "string",
        "auT_7_ReimbursementLimit": "string",
        "auT_8_RequestedNumberOfTreatments": "string",
        "auT_9_AuthorizedNumberOfTreatments": "string",
        "auT_10_ProcessDate": "string",
        "auT_11_RequestedDisciplines": [
          "string"
        ],
        "auT_12_AuthorizedDisciplines": [
          "string"
        ],
        "auT_13_AuthorizationReferralType": "string",
        "auT_14_ApprovalStatus": "string",
        "auT_15_PlannedTreatmentStopDate": "string",
        "auT_16_ClinicalService": "string",
        "auT_17_ReasonText": "string",
        "auT_18_NumberOfAuthorizedTreatmentsUnits": "string",
        "auT_19_NumberOfUsedTreatmentsUnits": "string",
        "auT_20_NumberOfScheduleTreatmentsUnits": "string",
        "auT_21_EncounterType": "string",
        "auT_22_RemainingBenefitAmount": "string",
        "auT_23_AuthorizedProvider": "string",
        "auT_24_AuthorizedHealthProfessional": "string",
        "auT_25_SourceText": "string",
        "auT_26_SourceDate": "string",
        "auT_27_SourcePhone": "string",
        "auT_28_Comment": "string",
        "auT_29_ActionCode": "string"
      }
    ],
    "rF1_Referral_Information": [
      {
        "rF1_1_ReferralStatus": "string",
        "rF1_2_ReferralPriority": "string",
        "rF1_3_ReferralType": "string",
        "rF1_4_ReferralDisposition": [
          "string"
        ],
        "rF1_5_ReferralCategory": "string",
        "rF1_6_OriginatingReferralIdentifier": "string",
        "rF1_7_EffectiveDate": "string",
        "rF1_8_ExpirationDate": "string",
        "rF1_9_ProcessDate": "string",
        "rF1_10_ReferralReason": [
          "string"
        ],
        "rF1_11_ExternalReferralIdentifier": [
          "string"
        ],
        "rF1_12_ReferralDocumentationCompletionStatus": "string",
        "rF1_13_PlannedTreatmentStopDate": "string",
        "rF1_14_ReferralReasonText": "string",
        "rF1_15_NumberOfAuthorizedTreatmentsUnits": "string",
        "rF1_16_NumberOfUsedTreatmentsUnits": "string",
        "rF1_17_NumberOfScheduleTreatmentsUnits": "string",
        "rF1_18_RemainingBenefitAmount": "string",
        "rF1_19_AuthorizedProvider": "string",
        "rF1_20_AuthorizedHealthProfessional": "string",
        "rF1_21_SourceText": "string",
        "rF1_22_SourceDate": "string",
        "rF1_23_SourcePhone": "string",
        "rF1_24_Comment": "string",
        "rF1_25_ActionCode": "string"
      }
    ]
  },
  "acC_Accident": {
    "acC_1_AccidentDateTime": "string",
    "acC_2_AccidentCode": "string",
    "acC_3_AccidentLocation": "string",
    "acC_4_AutoAccidentState": "string",
    "acC_5_AccidentJobRelatedIndicator": "string",
    "acC_6_AccidentDeathIndicator": "string",
    "acC_7_EnteredBy": "string",
    "acC_8_AccidentDescription": "string",
    "acC_9_BroughtInBy": "string",
    "acC_10_PoliceNotifiedIndicator": "string",
    "acC_11_AccidentAddress": "string",
    "acC_12_DegreeOfPatientLiability": "string",
    "acC_13_AccidentIdentifier": [
      "string"
    ]
  },
  "uB1_Ub82": {
    "uB1_1_SetId": "string",
    "uB1_2_BloodDeductible": "string",
    "uB1_3_BloodFurnishedPints": "string",
    "uB1_4_BloodReplacedPints": "string",
    "uB1_5_BloodNotReplacedPints": "string",
    "uB1_6_CoinsuranceDays": "string",
    "uB1_7_ConditionCode": [
      "string"
    ],
    "uB1_8_CoveredDays": "string",
    "uB1_9_NonCoveredDays": "string",
    "uB1_10_ValueAmountAndCode": [
      "string"
    ],
    "uB1_11_NumberOfGraceDays": "string",
    "uB1_12_SpecialProgramIndicator": "string",
    "uB1_13_PsroUrApprovalIndicator": "string",
    "uB1_14_PsroUrApprovedStayFm": "string",
    "uB1_15_PsroUrApprovedStayTo": "string",
    "uB1_16_Occurrence": [
      "string"
    ],
    "uB1_17_OccurrenceSpan": "string",
    "uB1_18_OccurSpanStartDate": "string",
    "uB1_19_OccurSpanEndDate": "string",
    "uB1_20_Ub82Locator2": "string",
    "uB1_21_Ub82Locator9": "string",
    "uB1_22_Ub82Locator27": "string",
    "uB1_23_Ub82Locator45": "string"
  },
  "uB2_Uniform_Billing_Data": {
    "uB2_1_SetId": "string",
    "uB2_2_CoinsuranceDays": "string",
    "uB2_3_ConditionCode": [
      "string"
    ],
    "uB2_4_CoveredDays": "string",
    "uB2_5_NonCoveredDays": "string",
    "uB2_6_ValueAmountAndCode": [
      "string"
    ],
    "uB2_7_OccurrenceCodeAndDate": [
      "string"
    ],
    "uB2_8_OccurrenceSpanCodeDates": [
      "string"
    ],
    "uB2_9_UB92Locator2State": [
      "string"
    ],
    "uB2_10_UB92Locator11State": [
      "string"
    ],
    "uB2_11_UB92Locator31National": "string",
    "uB2_12_DocumentControlNumber": [
      "string"
    ],
    "uB2_13_UB92Locator49National": [
      "string"
    ],
    "uB2_14_UB92Locator56State": [
      "string"
    ],
    "uB2_15_UB92Locator57National": "string",
    "uB2_16_UB92Locator78State": [
      "string"
    ],
    "uB2_17_SpecialVisitCount": "string"
  },
  "pdA_Patient_Death_Autopsy": {
    "pdA_1_DeathCauseCode": [
      "string"
    ],
    "pdA_2_DeathLocation": "string",
    "pdA_3_DeathCertifiedIndicator": "string",
    "pdA_4_DeathCertificateSignedDateTime": "string",
    "pdA_5_DeathCertifiedBy": "string",
    "pdA_6_AutopsyIndicator": "string",
    "pdA_7_AutopsyStartAndEndDateTime": "string",
    "pdA_8_AutopsyPerformedBy": "string",
    "pdA_9_CoronerIndicator": "string"
  }
}