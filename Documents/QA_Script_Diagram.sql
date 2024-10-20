USE [IAMHQA]
GO
/****** Object:  Table [dbo].[IAMHFactoolRequest]    Script Date: 1/10/2024 10:58:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHFactoolRequest](
	[_id] [int] NOT NULL,
	[CreateDate] [varchar](max) NULL,
	[CreateTick] [varchar](max) NULL,
	[ModifiedDate] [varchar](max) NULL,
	[ModifiedTick] [varchar](max) NULL,
	[SamAccount] [varchar](max) NULL,
	[DisplayName] [varchar](max) NULL,
	[ReferenceNumber] [varchar](max) NULL,
	[NewRequest] [varchar](max) NULL,
	[TotalUsers] [varchar](max) NULL,
	[RequestStatus] [varchar](max) NULL,
	[FormType] [varchar](max) NULL,
	[RequestType] [varchar](max) NULL,
	[DefectReason] [varchar](max) NULL,
	[Systems] [varchar](max) NULL,
	[ReplyTypes] [varchar](max) NULL,
	[Comments] [varchar](max) NULL,
	[XREF1] [varchar](max) NULL,
	[XREF2] [varchar](max) NULL,
	[LOB] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHFactoolRequestStatus]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHFactoolRequestStatus](
	[ReqStatusID] [int] NOT NULL,
	[ReferenceNumber] [varchar](max) NULL,
	[SentStatus] [varchar](max) NULL,
	[RequestState] [varchar](max) NULL,
	[TouchPoints] [varchar](max) NULL,
	[TimesReturned] [varchar](max) NULL,
	[SLAStart] [varchar](max) NULL,
	[CompletionDate] [varchar](max) NULL,
	[SLACompletionTime] [varchar](max) NULL,
	[AgentComments] [varchar](max) NULL,
	[AgentsWorked] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHFactoolExpectedNumbers]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHFactoolExpectedNumbers](
	[_iD] [int] NOT NULL,
	[ClassName] [nvarchar](200) NULL,
	[StartDate] [date] NULL,
	[N_Number] [nvarchar](50) NULL,
	[PERSONA] [nvarchar](50) NULL,
	[ExpectedUsers] [int] NULL,
	[ExpectedApps] [int] NULL,
	[ExpectedTouchpoints] [int] NULL,
	[ClassOwner] [nchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[IAMHFactoolExpectedView]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHFactoolExpectedView] AS

Select 
IAMHFactoolRequest.ReferenceNumber,
IAMHFactoolExpectedNumbers.ClassName As [Class Name],
IAMHFactoolExpectedNumbers.PERSONA As [PERSONA],
IAMHFactoolExpectedNumbers.StartDate As [Start Date],
IAMHFactoolExpectedNumbers.ExpectedUsers,
IAMHFactoolRequest.TotalUsers AS ActualUsers,
IAMHFactoolExpectedNumbers.ExpectedApps,
(CASE WHEN TRY_CONVERT(int, IAMHFactoolRequest.TotalUsers) <> 0 
THEN TRY_CONVERT(int, IAMHFactoolRequestStatus.Touchpoints) / TRY_CONVERT(int, IAMHFactoolRequest.TotalUsers)
ELSE 0 
END) AS ActualApplications,
IAMHFactoolExpectedNumbers.ExpectedTouchpoints,
IAMHFactoolRequestStatus.Touchpoints AS ActualTouchpoints,
IAMHFactoolRequestStatus.RequestState,
IAMHFactoolRequestStatus.SLAStart,
IAMHFactoolRequestStatus.CompletionDate,
IAMHFactoolRequestStatus.SLACompletionTime
FROM IAMHFactoolRequest
JOIN IAMHFactoolExpectedNumbers ON IAMHFactoolRequest.ReferenceNumber = IAMHFactoolExpectedNumbers.[N_Number]
JOIN IAMHFactoolRequestStatus ON IAMHFactoolRequest.ReferenceNumber = IAMHFactoolRequestStatus.ReferenceNumber
GO
/****** Object:  View [dbo].[IAMHFactoolExpectedMetricsView]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE View [dbo].[IAMHFactoolExpectedMetricsView] AS 

Select 

subquery.[Class Name] as ClassName,
subquery.[Class Owner] as ClassOwner,
SUM(TRY_CONVERT(int,subquery.ExpectedUsers)) As TotalExpectedUsers,
SUM(TRY_CONVERT(int,subquery.ActualUsers)) As TotalActualUsers,
SUM(TRY_CONVERT(int,subquery.ExpectedTouchpoints)) As TotalExpectedTouchpoints,
SUM(TRY_CONVERT(int,subquery.ActualTouchpoints)) As TotalActualTouchpoints,
(SUM(TRY_CONVERT(decimal,subquery.ExpectedUsers)) / NULLIF(SUM(TRY_CONVERT(decimal,subquery.ActualUsers)),0)
) * 100 AS UsersPercentage,

(SUM(TRY_CONVERT(decimal,subquery.ExpectedTouchpoints)) / NULLIF(SUM(TRY_CONVERT(decimal,subquery.ActualTouchpoints)),0)
) * 100 AS TouchpointsPercentage
FROM (
Select 
IAMHFactoolRequest.ReferenceNumber,
IAMHFactoolExpectedNumbers.ClassName As [Class Name],
IAMHFactoolExpectedNumbers.ClassOwner As [Class Owner],
IAMHFactoolExpectedNumbers.PERSONA As [PERSONA],
IAMHFactoolExpectedNumbers.StartDate As [Start Date],
IAMHFactoolExpectedNumbers.ExpectedUsers,
IAMHFactoolRequest.TotalUsers AS ActualUsers,
IAMHFactoolExpectedNumbers.ExpectedApps,
(CASE WHEN TRY_CONVERT(int, IAMHFactoolRequest.TotalUsers) <> 0 
THEN TRY_CONVERT(int, IAMHFactoolRequestStatus.Touchpoints) / TRY_CONVERT(int, IAMHFactoolRequest.TotalUsers)
ELSE 0 
END) AS ActualApplications,
IAMHFactoolExpectedNumbers.ExpectedTouchpoints,
IAMHFactoolRequestStatus.Touchpoints AS ActualTouchpoints,
IAMHFactoolRequestStatus.RequestState,
IAMHFactoolRequestStatus.SLAStart,
IAMHFactoolRequestStatus.CompletionDate,
IAMHFactoolRequestStatus.SLACompletionTime
FROM IAMHFactoolRequest
JOIN IAMHFactoolExpectedNumbers ON IAMHFactoolRequest.ReferenceNumber = IAMHFactoolExpectedNumbers.[N_Number]
JOIN IAMHFactoolRequestStatus ON IAMHFactoolRequest.ReferenceNumber = IAMHFactoolRequestStatus.ReferenceNumber
) as subquery
GROUP BY subquery.[Class Name], subquery.[Class Owner]

GO
/****** Object:  Table [dbo].[IAMHAccessNowOperations]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHAccessNowOperations](
	[id] [bigint] NULL,
	[externalId] [bigint] NULL,
	[createdOn] [nvarchar](max) NULL,
	[status] [nvarchar](max) NULL,
	[isOpen] [bit] NULL,
	[requestDesc] [nvarchar](max) NULL,
	[requestType] [nvarchar](max) NULL,
	[requestSubmissionId] [nvarchar](max) NULL,
	[entityId] [bigint] NULL,
	[entityName] [nvarchar](max) NULL,
	[entityTypeId] [bigint] NULL,
	[entityPropType] [nvarchar](max) NULL,
	[relatedEntityId] [bigint] NULL,
	[relatedEntityName] [nvarchar](max) NULL,
	[relatedEntityPropType] [nvarchar](max) NULL,
	[closedOn] [datetime2](7) NULL,
	[fulfilledOn] [datetime2](7) NULL,
	[ticketData] [nvarchar](max) NULL,
	[commentTaskData] [nvarchar](max) NULL,
	[additionalData] [nvarchar](max) NULL,
	[requestedOn] [datetime2](7) NULL,
	[requestor_id] [bigint] NULL,
	[requestor_entityTypeId] [bigint] NULL,
	[requestor_entityTypeName] [nvarchar](max) NULL,
	[requestor_type] [nvarchar](max) NULL,
	[requestor_Tag_High_Risk] [bit] NULL,
	[requestor_Tag_Administrator] [bit] NULL,
	[requestor_Tag_Terminated_User] [bit] NULL,
	[requestor_Tag_ToBeTerminated_User] [bit] NULL,
	[requestor_Tag_Privileged_User] [bit] NULL,
	[requestor_Tag_Asset_Administrator] [bit] NULL,
	[requestor_Tag_Admin_Password_Aware] [bit] NULL,
	[requestor_Tag_Derived_Resource_Owner] [bit] NULL,
	[requestor_Tag_Resource_Owner] [bit] NULL,
	[requestor_Short_Name] [nvarchar](max) NULL,
	[requestor_First_Name] [nvarchar](max) NULL,
	[requestor_Last_Name] [nvarchar](max) NULL,
	[requestor_Employee_ID] [nvarchar](max) NULL,
	[requestor_Hire_Date] [datetime2](7) NULL,
	[requestor_Termination_Date] [datetime2](7) NULL,
	[requestor_Start_Date] [datetime2](7) NULL,
	[requestor_Job_Code] [nvarchar](max) NULL,
	[requestor_Job_Title] [nvarchar](max) NULL,
	[requestor_Location] [nvarchar](max) NULL,
	[requestor_Email_Address] [nvarchar](max) NULL,
	[requestor_Department] [nvarchar](max) NULL,
	[requestor_CVS_Employee_ID] [nvarchar](max) NULL,
	[requestor_PBM_ID] [nvarchar](max) NULL,
	[requestor_Is_Terminated] [bit] NULL,
	[requestor_Site_OU] [nvarchar](max) NULL,
	[requestor_Level4_Department_Code] [nvarchar](max) NULL,
	[requestor_Mobile] [nvarchar](max) NULL,
	[requestor_Alternate_Email_Address] [nvarchar](max) NULL,
	[requestor_Middle_Name] [nvarchar](max) NULL,
	[requestor_Status] [nvarchar](max) NULL,
	[requestor_Country] [nvarchar](max) NULL,
	[requestor_Company] [nvarchar](max) NULL,
	[requestor_Application_Name] [nvarchar](max) NULL,
	[requestor_Account_Targets] [nvarchar](max) NULL,
	[requestor_MGRUSER] [nvarchar](max) NULL,
	[requestor_Vendor_ID] [nvarchar](max) NULL,
	[requestor_Location_Name] [nvarchar](max) NULL,
	[requestor_CVS_Location_Name] [nvarchar](max) NULL,
	[requestor_CVS_Location] [nvarchar](max) NULL,
	[requestor_CVS_Department] [nvarchar](max) NULL,
	[requestor_Registration_Mode] [nvarchar](max) NULL,
	[requestor_Department_Entry_Date] [nvarchar](max) NULL,
	[requestor_Benefit_Program] [nvarchar](max) NULL,
	[requestor_Charge_Sys] [nvarchar](max) NULL,
	[requestor_Compensation_Frequency] [nvarchar](max) NULL,
	[requestor_CVS_Department_ID] [nvarchar](max) NULL,
	[requestor_CVS_Job_Code] [nvarchar](max) NULL,
	[requestor_EE_SVCS_USER] [nvarchar](max) NULL,
	[requestor_Is_AuthoriaUser] [nvarchar](max) NULL,
	[requestor_EECHGSYS] [nvarchar](max) NULL,
	[requestor_Is_Employee] [nvarchar](max) NULL,
	[requestor_Level5_Department_Code] [nvarchar](max) NULL,
	[requestor_Emerge_DM] [nvarchar](max) NULL,
	[requestor_Is_HRMS_User] [nvarchar](max) NULL,
	[requestor_Emerge_RM] [nvarchar](max) NULL,
	[requestor_IsEmployeeWithAID] [nvarchar](max) NULL,
	[requestor_Emerge_RxSup] [nvarchar](max) NULL,
	[requestor_UserHasANID] [nvarchar](max) NULL,
	[requestor_FLSA_Status] [nvarchar](max) NULL,
	[requestor_GL_Pay_Type] [nvarchar](max) NULL,
	[requestor_Global_ID] [nvarchar](max) NULL,
	[requestor_Home_City] [nvarchar](max) NULL,
	[requestor_Home_Postal_Code] [nvarchar](max) NULL,
	[requestor_Home_State] [nvarchar](max) NULL,
	[requestor_Home_Street] [nvarchar](max) NULL,
	[requestor_Job_Category_Code] [nvarchar](max) NULL,
	[requestor_Job_Family_Code] [nvarchar](max) NULL,
	[requestor_Job_Function] [nvarchar](max) NULL,
	[requestor_Job_Grade] [nvarchar](max) NULL,
	[requestor_Learnet_Compliance] [nvarchar](max) NULL,
	[requestor_Manager_Level] [nvarchar](max) NULL,
	[requestor_OPR_Class] [nvarchar](max) NULL,
	[requestor_Pay_Group] [nvarchar](max) NULL,
	[requestor_PBM_SOW_Contractor] [nvarchar](max) NULL,
	[requestor_Personal_Phone] [nvarchar](max) NULL,
	[requestor_PharmTech_License_ID] [nvarchar](max) NULL,
	[requestor_PharmTech_License_State] [nvarchar](max) NULL,
	[requestor_Reg_Temp] [nvarchar](max) NULL,
	[requestor_RX_Zone] [nvarchar](max) NULL,
	[requestor_RxNavigator_URL] [nvarchar](max) NULL,
	[requestor_Standard_Hours] [nvarchar](max) NULL,
	[requestor_Union_Code] [nvarchar](max) NULL,
	[requestor_User_Category] [nvarchar](max) NULL,
	[requestor_Vendor_DSD] [nvarchar](max) NULL,
	[requestor_CVS_AD_Account_Name] [nvarchar](max) NULL,
	[requestor_Vendor_DSD_Access] [nvarchar](max) NULL,
	[requestor_Vendor_DSD_Invoice] [nvarchar](max) NULL,
	[requestor_Vendor_Sup_Mail_1] [nvarchar](max) NULL,
	[requestor_Vendor_Sup_Mail_2] [nvarchar](max) NULL,
	[requestor_Work_Area] [nvarchar](max) NULL,
	[requestor_Work_District] [nvarchar](max) NULL,
	[requestor_Work_Region] [nvarchar](max) NULL,
	[requestor_Reference_ID] [nvarchar](max) NULL,
	[requestor_Work_Time] [nvarchar](max) NULL,
	[requestor_CVS_Business_Unit] [nvarchar](max) NULL,
	[requestor_SSN] [nvarchar](max) NULL,
	[requestor_Phone] [nvarchar](max) NULL,
	[requestor_Date_Of_Birth] [nvarchar](max) NULL,
	[requestor_Organization_ID] [nvarchar](max) NULL,
	[requestor_User_Type] [nvarchar](max) NULL,
	[requestor_City] [nvarchar](max) NULL,
	[requestor_Empl_Pay_Type] [nvarchar](max) NULL,
	[requestor_State] [nvarchar](max) NULL,
	[requestor_Emp_Status] [nvarchar](max) NULL,
	[requestor_Postal_Code] [nvarchar](max) NULL,
	[requestor_Country_Code] [nvarchar](max) NULL,
	[requestor_Cost_Center] [nvarchar](max) NULL,
	[requestor_Department_ID] [nvarchar](max) NULL,
	[requestor_Mail_Code] [nvarchar](max) NULL,
	[requestor_Office_phone_Country_Prefix] [nvarchar](max) NULL,
	[requestor_Identity_Type] [nvarchar](max) NULL,
	[requestor_User_Name] [nvarchar](max) NULL,
	[requestor_Pre_Conversion_ID] [nvarchar](max) NULL,
	[requestor_Job_Description] [nvarchar](max) NULL,
	[requestor_Preferred_Name] [nvarchar](max) NULL,
	[requestor_Cost_Center_Name] [nvarchar](max) NULL,
	[requestor_Description] [nvarchar](max) NULL,
	[requestor_Address_Line] [nvarchar](max) NULL,
	[requestor_Office_Name] [nvarchar](max) NULL,
	[requestor_Support_Location] [nvarchar](max) NULL,
	[requestor_Street] [nvarchar](max) NULL,
	[requestor_Added_Date] [nvarchar](max) NULL,
	[requestor_Modified_Date] [nvarchar](max) NULL,
	[requestor_Owner1] [nvarchar](max) NULL,
	[requestor_Owner2] [nvarchar](max) NULL,
	[requestor_Owner3] [nvarchar](max) NULL,
	[requestor_Is_Executive] [nvarchar](max) NULL,
	[requestor_Employee_Type] [nvarchar](max) NULL,
	[requestor_entityOwners] [nvarchar](max) NULL,
	[asset_id] [bigint] NULL,
	[asset_imanagedAssetType] [nvarchar](max) NULL,
	[asset_iisTicketingSystem] [bit] NULL,
	[asset_isanitizedName] [nvarchar](max) NULL,
	[asset_additionalData_restrictedPlanSupportRoleName] [nvarchar](max) NULL,
	[asset_additionalData_verizonGroupId] [nvarchar](max) NULL,
	[asset_additionalData_category] [nvarchar](max) NULL,
	[asset_additionalData_uapconnectorName] [nvarchar](max) NULL,
	[asset_additionalData_accountExtension] [nvarchar](max) NULL,
	[asset_additionalData_deprovisioningProfile] [nvarchar](max) NULL,
	[asset_additionalData_externalRoleName] [nvarchar](max) NULL,
	[asset_additionalData_cecuapconnectorName] [nvarchar](max) NULL,
	[asset_additionalData_managerCreatedRecipientGPS] [nvarchar](max) NULL,
	[asset_additionalData_managerCreatedRecipientPBM] [nvarchar](max) NULL,
	[asset_additionalData_managerCreatedRecipientCEC] [nvarchar](max) NULL,
	[asset_additionalData_managerCreatedRecipientBell] [nvarchar](max) NULL,
	[asset_additionalData_pbmOnshoreGroupId] [nvarchar](max) NULL,
	[asset_additionalData_defaultCallCenterID] [nvarchar](max) NULL,
	[asset_additionalData_callCenterLicense] [nvarchar](max) NULL,
	[asset_additionalData_asset_entityTypeId] [nvarchar](max) NULL,
	[asset_additionalData_asset_entityTypeName] [nvarchar](max) NULL,
	[asset_additionalData_asset_Short_Name] [nvarchar](max) NULL,
	[asset_additionalData_Resource_Type] [nvarchar](max) NULL,
	[asset_additionalData_asset_Name] [nvarchar](max) NULL,
	[asset_additionalData_asset_ITPM_Number] [nvarchar](max) NULL,
	[asset_additionalData_asset_Description] [nvarchar](max) NULL,
	[asset_Owner_Short_Name] [nvarchar](max) NULL,
	[asset_Owner_Email_Address] [nvarchar](max) NULL,
	[asset_Owner_id] [bigint] NULL,
	[asset_Alternate_Name] [nvarchar](max) NULL,
	[asset_Asset_Identifier] [nvarchar](max) NULL,
	[asset_Non_Integrated] [bit] NULL,
	[asset_Manage_Entitlements] [bit] NULL,
	[asset_Is_Enabled] [bit] NULL,
	[asset_Reference_ID] [nvarchar](max) NULL,
	[account_id] [bigint] NULL,
	[account_entityTypeId] [bigint] NULL,
	[account_entityTypeName] [nvarchar](max) NULL,
	[account_assetId] [bigint] NULL,
	[account_Asset] [nvarchar](max) NULL,
	[account_type] [nvarchar](max) NULL,
	[account_Tag_Medium_Risk_Access] [bit] NULL,
	[account_Tag_User_Account] [bit] NULL,
	[account_Tag_Derived_Owner_Access] [bit] NULL,
	[account_Tag_UnApprovedAccess] [bit] NULL,
	[account_Tag_Reviewed_Medium_Risk_Access] [bit] NULL,
	[account_Tag_Cloud_Access] [bit] NULL,
	[account_Tag_Temporary_Account] [bit] NULL,
	[account_Tag_Low_Risk_Access] [bit] NULL,
	[account_Tag_Regular_Access] [bit] NULL,
	[account_Tag_Anomaly_Access] [bit] NULL,
	[account_Tag_Access_Groups] [bit] NULL,
	[account_Tag_Test_Account] [bit] NULL,
	[account_Tag_Risk_Not_Reviewed_Access] [bit] NULL,
	[account_Tag_System_Account] [bit] NULL,
	[account_Tag_Derived_Administrator_Access] [bit] NULL,
	[account_Tag_High_Risk_Access] [bit] NULL,
	[account_Tag_Indefinite_Access] [bit] NULL,
	[account_Tag_Administrator_Access] [bit] NULL,
	[account_Tag_L1_Exclusion_PreAuthorized] [bit] NULL,
	[account_Tag_No_Risk_Access] [bit] NULL,
	[account_Tag_Unauthorized_Access] [bit] NULL,
	[account_Tag_Orphaned_Account] [bit] NULL,
	[account_Tag_Shared_Account] [bit] NULL,
	[account_Tag_Service_Account] [bit] NULL,
	[account_Tag_L2_Exclusion_PreAuthorized] [bit] NULL,
	[account_Tag_Expired_Access] [bit] NULL,
	[account_Tag_Deleted_Account] [bit] NULL,
	[account_Tag_Authorization_Groups] [bit] NULL,
	[account_Tag_Temporary_Access] [bit] NULL,
	[account_Tag_Locked_Account] [bit] NULL,
	[account_Tag_Privileged_Access] [bit] NULL,
	[account_Tag_Disabled_Account] [bit] NULL,
	[account_Tag_RejectedAccess] [bit] NULL,
	[account_Tag_Exceptional_Access] [bit] NULL,
	[account_Tag_Derived_Privileged_Access] [bit] NULL,
	[account_Tag_Unprotected_Resource] [bit] NULL,
	[account_Tag_Derived_Administrative_Access] [bit] NULL,
	[account_Tag_Privileged_Resource] [bit] NULL,
	[account_Tag_Auto_Approval] [bit] NULL,
	[account_Tag_Reviewed_High_Risk_Access] [bit] NULL,
	[account_Tag_Owner_Access] [bit] NULL,
	[account_Tag_Administrative_Access] [bit] NULL,
	[account_Tag_Expired_Account] [bit] NULL,
	[account_Tag_Owner_Approval] [bit] NULL,
	[account_Tag_ViolatingAccess] [bit] NULL,
	[account_Tag_Manager_Approval] [bit] NULL,
	[account_Tag_Reviewed_Low_Risk_Access] [bit] NULL,
	[account_Short_Name] [nvarchar](max) NULL,
	[account_Name] [nvarchar](max) NULL,
	[account_Present_In] [nvarchar](max) NULL,
	[account_Unique_Id] [nvarchar](max) NULL,
	[account_Creation_Date] [datetime2](7) NULL,
	[account_Last_Login_Date] [datetime2](7) NULL,
	[account_Is_Disabled] [bit] NULL,
	[account_Location] [nvarchar](max) NULL,
	[account_Password_Last_Set] [datetime2](7) NULL,
	[account_Console] [nvarchar](max) NULL,
	[account_Line_of_Business] [nvarchar](max) NULL,
	[account_Email_Address] [nvarchar](max) NULL,
	[account_Employee_ID] [nvarchar](max) NULL,
	[account_Alias] [nvarchar](max) NULL,
	[account_Nickname] [nvarchar](max) NULL,
	[account_Time_Zone] [nvarchar](max) NULL,
	[account_Application_Internal_Id] [nvarchar](max) NULL,
	[account_NeverLoggedIn] [bit] NULL,
	[account_Reference_ID] [nvarchar](max) NULL,
	[account_Last_Modified_Date] [datetime2](7) NULL,
	[account_User_Type] [nvarchar](max) NULL,
	[user_id] [bigint] NULL,
	[user_entityTypeId] [bigint] NULL,
	[user_entityTypeName] [nvarchar](max) NULL,
	[user_assetId] [bigint] NULL,
	[user_Asset] [nvarchar](max) NULL,
	[user_type] [nvarchar](max) NULL,
	[user_Tag_High_Risk] [bit] NULL,
	[user_Tag_Administrator] [bit] NULL,
	[user_Tag_Terminated_User] [bit] NULL,
	[user_Tag_ToBeTerminated_User] [bit] NULL,
	[user_Tag_Privileged_User] [bit] NULL,
	[user_Tag_Asset_Administrator] [bit] NULL,
	[user_Tag_Admin_Password_Aware] [bit] NULL,
	[user_Tag_Derived_Resource_Owner] [bit] NULL,
	[user_Tag_Resource_Owner] [bit] NULL,
	[user_Short_Name] [nvarchar](max) NULL,
	[user_First_Name] [nvarchar](max) NULL,
	[user_Last_Name] [nvarchar](max) NULL,
	[user_Employee_ID] [nvarchar](max) NULL,
	[user_Hire_Date] [datetime2](7) NULL,
	[user_Termination_Date] [datetime2](7) NULL,
	[user_Start_Date] [nvarchar](max) NULL,
	[user_Job_Code] [nvarchar](max) NULL,
	[user_Job_Title] [nvarchar](max) NULL,
	[user_Location] [nvarchar](max) NULL,
	[user_Email_Address] [nvarchar](max) NULL,
	[user_Department] [nvarchar](max) NULL,
	[user_CVS_Employee_ID] [nvarchar](max) NULL,
	[user_PBM_ID] [nvarchar](max) NULL,
	[user_Is_Terminated] [bit] NULL,
	[user_Site_OU] [nvarchar](max) NULL,
	[user_Supervisor_Short_Name] [nvarchar](max) NULL,
	[user_Supervisor_Email_Address] [nvarchar](max) NULL,
	[user_Supervisor_id] [bigint] NULL,
	[user_Level4_Department_Code] [nvarchar](max) NULL,
	[user_Mobile] [nvarchar](max) NULL,
	[user_Alternate_Email_Address] [nvarchar](max) NULL,
	[user_Middle_Name] [nvarchar](max) NULL,
	[user_Status] [nvarchar](max) NULL,
	[user_Country] [nvarchar](max) NULL,
	[user_Company] [nvarchar](max) NULL,
	[user_Name] [nvarchar](max) NULL,
	[user_Targets] [nvarchar](max) NULL,
	[user_MGRUSER] [nvarchar](max) NULL,
	[user_Vendor_ID] [nvarchar](max) NULL,
	[user_Location_Name] [nvarchar](max) NULL,
	[user_CVS_Location_Name] [nvarchar](max) NULL,
	[user_CVS_Location] [nvarchar](max) NULL,
	[user_CVS_Department] [nvarchar](max) NULL,
	[user_Registration_Mode] [nvarchar](max) NULL,
	[user_Department_Entry_Date] [nvarchar](max) NULL,
	[user_Benefit_Program] [nvarchar](max) NULL,
	[user_Charge_Sys] [nvarchar](max) NULL,
	[user_Compensation_Frequency] [nvarchar](max) NULL,
	[user_CVS_Department_ID] [nvarchar](max) NULL,
	[user_CVS_Job_Code] [nvarchar](max) NULL,
	[user_EE_SVCS_USER] [nvarchar](max) NULL,
	[user_Is_AuthoriaUser] [nvarchar](max) NULL,
	[user_EECHGSYS] [nvarchar](max) NULL,
	[user_Is_Employee] [nvarchar](max) NULL,
	[user_Level5_Department_Code] [nvarchar](max) NULL,
	[user_Emerge_DM] [nvarchar](max) NULL,
	[user_Is_HRMS_User] [nvarchar](max) NULL,
	[user_Emerge_RM] [nvarchar](max) NULL,
	[user_IsEmployeeWithAID] [bit] NULL,
	[user_Emerge_RxSup] [nvarchar](max) NULL,
	[user_UserHasANID] [bit] NULL,
	[user_FLSA_Status] [nvarchar](max) NULL,
	[user_GL_Pay_Type] [nvarchar](max) NULL,
	[user_Global_ID] [nvarchar](max) NULL,
	[user_Home_City] [nvarchar](max) NULL,
	[user_Home_Postal_Code] [nvarchar](max) NULL,
	[user_Home_State] [nvarchar](max) NULL,
	[user_Home_Street] [nvarchar](max) NULL,
	[user_Job_Category_Code] [nvarchar](max) NULL,
	[user_ob_Family_Code] [nvarchar](max) NULL,
	[user_Job_Function] [nvarchar](max) NULL,
	[user_Job_Grade] [nvarchar](max) NULL,
	[user_Learnet_Compliance] [nvarchar](max) NULL,
	[user_Manager_Level] [nvarchar](max) NULL,
	[user_OPR_Class] [nvarchar](max) NULL,
	[user_Pay_Group] [nvarchar](max) NULL,
	[user_PBM_SOW_Contractor] [nvarchar](max) NULL,
	[user_Personal_Phone] [nvarchar](max) NULL,
	[user_PharmTech_License_ID] [nvarchar](max) NULL,
	[user_PharmTech_License_State] [nvarchar](max) NULL,
	[user_Reg_Temp] [nvarchar](max) NULL,
	[user_RX_Zone] [nvarchar](max) NULL,
	[user_URL] [nvarchar](max) NULL,
	[user_Standard_Hours] [nvarchar](max) NULL,
	[user_Union_Code] [nvarchar](max) NULL,
	[user_User_Category] [nvarchar](max) NULL,
	[user_Vendor_DSD] [nvarchar](max) NULL,
	[user_CVS_AD_Account_Name] [nvarchar](max) NULL,
	[user_Vendor_DSD_Access] [nvarchar](max) NULL,
	[user_Vendor_DSD_Invoice] [nvarchar](max) NULL,
	[user_Vendor_Sup_Mail_1] [nvarchar](max) NULL,
	[user_Vendor_Sup_Mail_2] [nvarchar](max) NULL,
	[user_Work_Area] [nvarchar](max) NULL,
	[user_Work_District] [nvarchar](max) NULL,
	[user_Work_Region] [nvarchar](max) NULL,
	[user_Reference_ID] [nvarchar](max) NULL,
	[user_Work_Time] [nvarchar](max) NULL,
	[user_CVS_Business_Unit] [nvarchar](max) NULL,
	[user_SSN] [nvarchar](max) NULL,
	[user_Phone] [nvarchar](max) NULL,
	[user_Date_Of_Birth] [nvarchar](max) NULL,
	[user_Organization_ID] [nvarchar](max) NULL,
	[user_User_Type] [nvarchar](max) NULL,
	[user_City] [nvarchar](max) NULL,
	[user_Empl_Pay_Type] [nvarchar](max) NULL,
	[user_State] [nvarchar](max) NULL,
	[user_Emp_Status] [nvarchar](max) NULL,
	[user_Postal_Code] [nvarchar](max) NULL,
	[user_Country_Code] [nvarchar](max) NULL,
	[user_Cost_Center] [nvarchar](max) NULL,
	[user_Department_ID] [nvarchar](max) NULL,
	[user_Mail_Code] [nvarchar](max) NULL,
	[user_Office_phone_Country_Prefix] [nvarchar](max) NULL,
	[user_Identity_Type] [nvarchar](max) NULL,
	[user_User_Name] [nvarchar](max) NULL,
	[user_Pre_Conversion_ID] [nvarchar](max) NULL,
	[user_Job_Description] [nvarchar](max) NULL,
	[user_Preferred_Name] [nvarchar](max) NULL,
	[user_Cost_Center_Name] [nvarchar](max) NULL,
	[user_Description] [nvarchar](max) NULL,
	[user_Address_Line] [nvarchar](max) NULL,
	[user_Office_Name] [nvarchar](max) NULL,
	[user_Support_Location] [nvarchar](max) NULL,
	[user_Street] [nvarchar](max) NULL,
	[user_Added_Date] [datetime2](7) NULL,
	[user_Modified_Date] [datetime2](7) NULL,
	[user_Owner1] [nvarchar](max) NULL,
	[user_Owner2] [nvarchar](max) NULL,
	[user_Owner3] [nvarchar](max) NULL,
	[user_Is_Executive] [bit] NULL,
	[user_Employee_Type] [nvarchar](max) NULL,
	[user_Supervisor_entityOwners] [nvarchar](max) NULL,
	[requestData_requestDetails_User_Line_of_Business_Details] [nvarchar](max) NULL,
	[requestData_requestDetails_User_Location] [nvarchar](max) NULL,
	[requestData_requestFormConfig_User_Line_of_Business_Details_label] [nvarchar](max) NULL,
	[requestData_requestFormConfig_User_Line_of_Business_Details_grouping] [nvarchar](max) NULL,
	[requestData_requestFormConfig_User_Line_of_Business_Details_formForEntityId] [nvarchar](max) NULL,
	[requestData_requestFormConfig_User_Line_of_Business_Details_formForEntityType] [nvarchar](max) NULL,
	[requestData_requestFormConfig_User_Location_label] [nvarchar](max) NULL,
	[requestData_requestFormConfig_User_Location_grouping] [nvarchar](max) NULL,
	[requestData_requestFormConfig_User_Location_formForEntityId] [nvarchar](max) NULL,
	[requestData_requestFormConfig_User_Location_formForEntityType] [nvarchar](max) NULL,
	[requestData_requestFormEntityConfig_User_Line_of_Business_Details] [nvarchar](max) NULL,
	[requestData_requestFormEntityConfig_User_Location] [nvarchar](max) NULL,
	[requestData_access_id] [bigint] NULL,
	[requestData_access_entityTypeId] [bigint] NULL,
	[requestData_access_entityTypeName] [nvarchar](max) NULL,
	[requestData_access_assetId] [bigint] NULL,
	[requestData_access_Asset] [nvarchar](max) NULL,
	[requestData_access_type] [nvarchar](max) NULL,
	[requestData_access_Tag_Medium_Risk_Access] [bit] NULL,
	[requestData_access_Tag_User_Account] [bit] NULL,
	[requestData_access_Tag_Derived_Owner_Access] [bit] NULL,
	[requestData_access_Tag_UnApprovedAccess] [bit] NULL,
	[requestData_access_Tag_Reviewed_Medium_Risk_Access] [bit] NULL,
	[requestData_access_Tag_Cloud_Access] [bit] NULL,
	[requestData_access_Tag_Temporary_Account] [bit] NULL,
	[requestData_access_Tag_Low_Risk_Access] [bit] NULL,
	[requestData_access_Tag_Regular_Access] [bit] NULL,
	[requestData_access_Tag_Anomaly_Access] [bit] NULL,
	[requestData_access_Tag_Access_Groups] [bit] NULL,
	[requestData_access_Tag_Test_Account] [bit] NULL,
	[requestData_access_Tag_Risk_Not_Reviewed_Access] [bit] NULL,
	[requestData_access_Tag_System_Account] [bit] NULL,
	[requestData_access_Tag_Derived_Administrator_Access] [bit] NULL,
	[requestData_access_Tag_High_Risk_Access] [bit] NULL,
	[requestData_access_Tag_Indefinite_Access] [bit] NULL,
	[requestData_access_Tag_Administrator_Access] [bit] NULL,
	[requestData_access_Tag_L1_Exclusion_PreAuthorized] [bit] NULL,
	[requestData_access_Tag_No_Risk_Access] [bit] NULL,
	[requestData_access_Tag_Unauthorized_Access] [bit] NULL,
	[requestData_access_Tag_Orphaned_Account] [bit] NULL,
	[requestData_access_Tag_Shared_Account] [bit] NULL,
	[requestData_access_Tag_Service_Account] [bit] NULL,
	[requestData_access_Tag_L2_Exclusion_PreAuthorized] [bit] NULL,
	[requestData_access_Tag_Expired_Access] [bit] NULL,
	[requestData_access_Tag_Deleted_Account] [bit] NULL,
	[requestData_access_Tag_Authorization_Groups] [bit] NULL,
	[requestData_access_Tag_Temporary_Access] [bit] NULL,
	[requestData_access_Tag_Locked_Account] [bit] NULL,
	[requestData_access_Tag_Privileged_Access] [bit] NULL,
	[requestData_access_Tag_Disabled_Account] [bit] NULL,
	[requestData_access_Tag_RejectedAccess] [bit] NULL,
	[requestData_access_Tag_Exceptional_Access] [bit] NULL,
	[requestData_access_Tag_Derived_Privileged_Access] [bit] NULL,
	[requestData_access_Tag_Unprotected_Resource] [bit] NULL,
	[requestData_access_Tag_Derived_Administrative_Access] [bit] NULL,
	[requestData_access_Tag_Privileged_Resource] [bit] NULL,
	[requestData_access_Tag_Auto_Approval] [bit] NULL,
	[requestData_access_Tag_Reviewed_High_Risk_Access] [bit] NULL,
	[requestData_access_Tag_Owner_Access] [bit] NULL,
	[requestData_access_Tag_Administrative_Access] [bit] NULL,
	[requestData_access_Tag_Expired_Account] [bit] NULL,
	[requestData_access_Tag_Owner_Approval] [bit] NULL,
	[requestData_access_Tag_ViolatingAccess] [bit] NULL,
	[requestData_access_Tag_Manager_Approval] [bit] NULL,
	[requestData_access_Tag_Reviewed_Low_Risk_Access] [bit] NULL,
	[requestData_access_Short_Name] [nvarchar](max) NULL,
	[requestData_access_ITPM_Number] [nvarchar](max) NULL,
	[requestData_access_Reference_ID] [nvarchar](max) NULL,
	[requestData_access_Unique_Id] [nvarchar](max) NULL,
	[requestData_access_Name] [nvarchar](max) NULL,
	[requestData_access_Description] [nvarchar](max) NULL,
	[requestData_access_Present_In] [nvarchar](max) NULL,
	[requestData_access_Creation_Date] [datetime2](7) NULL,
	[requestId] [bigint] NULL,
	[additionalInfo] [nvarchar](max) NULL,
	[inProcessApprovalLevel] [bigint] NULL,
	[additionalData_fulfillmentData_Mail_Sent_On] [datetime] NULL,
	[additionalData_fulfillmentData_Mail_Sent_To] [nvarchar](max) NULL,
	[additionalData_fulfillmentData_Mail_Sent_On_Date] [datetime] NULL,
	[ticketData_ticketId] [bigint] NULL,
	[additionalData_fulfillmentData_ZZAccount_Emp_Id] [nvarchar](max) NULL,
	[additionalData_fulfillmentData_ZZAccount_Created] [nvarchar](max) NULL,
	[additionalData_fulfillmentData_ZZAccount_Created_On] [datetime] NULL,
	[additionalData_fulfillmentData_ZZAccount_CVS_Emp_Id] [bigint] NULL,
	[additionalData_fulfillmentData_Fulfilled_For_Account] [nvarchar](max) NULL,
	[additionalData_fulfillmentData_ZZAccount_Created_On_GMT] [datetime] NULL,
	[requestData_subRequestType] [nvarchar](max) NULL,
	[ticketData_externalTicketId] [nvarchar](50) NULL,
	[requestData_requestSummary_requestType] [nvarchar](50) NULL,
	[requestData_User_ShortName] [nvarchar](100) NULL,
	[requestData_User_EmployeeID] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[IAMHAccessNowOperationsRawView]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHAccessNowOperationsRawView]
AS
SELECT        id, externalId, createdOn, status, isOpen, requestDesc, requestType, requestSubmissionId, entityId, entityName, entityTypeId, entityPropType, relatedEntityId, relatedEntityName, relatedEntityPropType, closedOn, fulfilledOn, 
                         ticketData, commentTaskData, additionalData, requestedOn, requestor_id, requestor_entityTypeId, requestor_entityTypeName, requestor_type, requestor_Tag_High_Risk, requestor_Tag_Administrator, 
                         requestor_Tag_Terminated_User, requestor_Tag_ToBeTerminated_User, requestor_Tag_Privileged_User, requestor_Tag_Asset_Administrator, requestor_Tag_Admin_Password_Aware, 
                         requestor_Tag_Derived_Resource_Owner, requestor_Tag_Resource_Owner, requestor_Short_Name, requestor_First_Name, requestor_Last_Name, requestor_Employee_ID, requestor_Hire_Date, requestor_Termination_Date, 
                         requestor_Start_Date, requestor_Job_Code, requestor_Job_Title, requestor_Location, requestor_Email_Address, requestor_Department, requestor_CVS_Employee_ID, requestor_PBM_ID, requestor_Is_Terminated, 
                         requestor_Site_OU, requestor_Level4_Department_Code, requestor_Mobile, requestor_Alternate_Email_Address, requestor_Middle_Name, requestor_Status, requestor_Country, requestor_Company, 
                         requestor_Application_Name, requestor_Account_Targets, requestor_MGRUSER, requestor_Vendor_ID, requestor_Location_Name, requestor_CVS_Location_Name, requestor_CVS_Location, requestor_CVS_Department, 
                         requestor_Registration_Mode, requestor_Department_Entry_Date, requestor_Benefit_Program, requestor_Charge_Sys, requestor_Compensation_Frequency, requestor_CVS_Department_ID, requestor_CVS_Job_Code, 
                         requestor_EE_SVCS_USER, requestor_Is_AuthoriaUser, requestor_EECHGSYS, requestor_Is_Employee, requestor_Level5_Department_Code, requestor_Emerge_DM, requestor_Is_HRMS_User, requestor_Emerge_RM, 
                         requestor_IsEmployeeWithAID, requestor_Emerge_RxSup, requestor_UserHasANID, requestor_FLSA_Status, requestor_GL_Pay_Type, requestor_Global_ID, requestor_Home_City, requestor_Home_Postal_Code, 
                         requestor_Home_State, requestor_Home_Street, requestor_Job_Category_Code, requestor_Job_Family_Code, requestor_Job_Function, requestor_Job_Grade, requestor_Learnet_Compliance, requestor_Manager_Level, 
                         requestor_OPR_Class, requestor_Pay_Group, requestor_PBM_SOW_Contractor, requestor_Personal_Phone, requestor_PharmTech_License_ID, requestor_PharmTech_License_State, requestor_Reg_Temp, 
                         requestor_RX_Zone, requestor_RxNavigator_URL, requestor_Standard_Hours, requestor_Union_Code, requestor_User_Category, requestor_Vendor_DSD, requestor_CVS_AD_Account_Name, requestor_Vendor_DSD_Access, 
                         requestor_Vendor_DSD_Invoice, requestor_Vendor_Sup_Mail_1, requestor_Vendor_Sup_Mail_2, requestor_Work_Area, requestor_Work_District, requestor_Work_Region, requestor_Reference_ID, requestor_Work_Time, 
                         requestor_CVS_Business_Unit, requestor_SSN, requestor_Phone, requestor_Date_Of_Birth, requestor_Organization_ID, requestor_User_Type, requestor_City, requestor_Empl_Pay_Type, requestor_State, 
                         requestor_Emp_Status, requestor_Postal_Code, requestor_Country_Code, requestor_Cost_Center, requestor_Department_ID, requestor_Mail_Code, requestor_Office_phone_Country_Prefix, requestor_Identity_Type, 
                         requestor_User_Name, requestor_Pre_Conversion_ID, requestor_Job_Description, requestor_Preferred_Name, requestor_Cost_Center_Name, requestor_Description, requestor_Address_Line, requestor_Office_Name, 
                         requestor_Support_Location, requestor_Street, requestor_Added_Date, requestor_Modified_Date, requestor_Owner1, requestor_Owner2, requestor_Owner3, requestor_Is_Executive, requestor_Employee_Type, 
                         requestor_entityOwners, asset_id, asset_imanagedAssetType, asset_iisTicketingSystem, asset_isanitizedName, asset_additionalData_restrictedPlanSupportRoleName, asset_additionalData_verizonGroupId, 
                         asset_additionalData_category, asset_additionalData_uapconnectorName, asset_additionalData_accountExtension, asset_additionalData_deprovisioningProfile, asset_additionalData_externalRoleName, 
                         asset_additionalData_cecuapconnectorName, asset_additionalData_managerCreatedRecipientGPS, asset_additionalData_managerCreatedRecipientPBM, asset_additionalData_managerCreatedRecipientCEC, 
                         asset_additionalData_managerCreatedRecipientBell, asset_additionalData_pbmOnshoreGroupId, asset_additionalData_defaultCallCenterID, asset_additionalData_callCenterLicense, asset_additionalData_asset_entityTypeId, 
                         asset_additionalData_asset_entityTypeName, asset_additionalData_asset_Short_Name, asset_additionalData_Resource_Type, asset_additionalData_asset_Name, asset_additionalData_asset_ITPM_Number, 
                         asset_additionalData_asset_Description, asset_Owner_Short_Name, asset_Owner_Email_Address, asset_Owner_id, asset_Alternate_Name, asset_Asset_Identifier, asset_Non_Integrated, asset_Manage_Entitlements, 
                         asset_Is_Enabled, asset_Reference_ID, account_id, account_entityTypeId, account_entityTypeName, account_assetId, account_Asset, account_type, account_Tag_Medium_Risk_Access, account_Tag_User_Account, 
                         account_Tag_Derived_Owner_Access, account_Tag_UnApprovedAccess, account_Tag_Reviewed_Medium_Risk_Access, account_Tag_Cloud_Access, account_Tag_Temporary_Account, account_Tag_Low_Risk_Access, 
                         account_Tag_Regular_Access, account_Tag_Anomaly_Access, account_Tag_Access_Groups, account_Tag_Test_Account, account_Tag_Risk_Not_Reviewed_Access, account_Tag_System_Account, 
                         account_Tag_Derived_Administrator_Access, account_Tag_High_Risk_Access, account_Tag_Indefinite_Access, account_Tag_Administrator_Access, account_Tag_L1_Exclusion_PreAuthorized, account_Tag_No_Risk_Access, 
                         account_Tag_Unauthorized_Access, account_Tag_Orphaned_Account, account_Tag_Shared_Account, account_Tag_Service_Account, account_Tag_L2_Exclusion_PreAuthorized, account_Tag_Expired_Access, 
                         account_Tag_Deleted_Account, account_Tag_Authorization_Groups, account_Tag_Temporary_Access, account_Tag_Locked_Account, account_Tag_Privileged_Access, account_Tag_Disabled_Account, 
                         account_Tag_RejectedAccess, account_Tag_Exceptional_Access, account_Tag_Derived_Privileged_Access, account_Tag_Unprotected_Resource, account_Tag_Derived_Administrative_Access, 
                         account_Tag_Privileged_Resource, account_Tag_Auto_Approval, account_Tag_Reviewed_High_Risk_Access, account_Tag_Owner_Access, account_Tag_Administrative_Access, account_Tag_Expired_Account, 
                         account_Tag_Owner_Approval, account_Tag_ViolatingAccess, account_Tag_Manager_Approval, account_Tag_Reviewed_Low_Risk_Access, account_Short_Name, account_Name, account_Present_In, account_Unique_Id, 
                         account_Creation_Date, account_Last_Login_Date, account_Is_Disabled, account_Location, account_Password_Last_Set, account_Console, account_Line_of_Business, account_Email_Address, account_Employee_ID, 
                         account_Alias, account_Nickname, account_Time_Zone, account_Application_Internal_Id, account_NeverLoggedIn, account_Reference_ID, account_Last_Modified_Date, account_User_Type, user_id, user_entityTypeId, 
                         user_entityTypeName, user_assetId, user_Asset, user_type, user_Tag_High_Risk, user_Tag_Administrator, user_Tag_Terminated_User, user_Tag_ToBeTerminated_User, user_Tag_Privileged_User, 
                         user_Tag_Asset_Administrator, user_Tag_Admin_Password_Aware, user_Tag_Derived_Resource_Owner, user_Tag_Resource_Owner, user_Short_Name, user_First_Name, user_Last_Name, user_Employee_ID, 
                         user_Hire_Date, user_Termination_Date, user_Start_Date, user_Job_Code, user_Job_Title, user_Location, user_Email_Address, user_Department, user_CVS_Employee_ID, user_PBM_ID, user_Is_Terminated, user_Site_OU, 
                         user_Supervisor_Short_Name, user_Supervisor_Email_Address, user_Supervisor_id, user_Level4_Department_Code, user_Mobile, user_Alternate_Email_Address, user_Middle_Name, user_Status, user_Country, 
                         user_Company, user_Name, user_Targets, user_MGRUSER, user_Vendor_ID, user_Location_Name, user_CVS_Location_Name, user_CVS_Location, user_CVS_Department, user_Registration_Mode, 
                         user_Department_Entry_Date, user_Benefit_Program, user_Charge_Sys, user_Compensation_Frequency, user_CVS_Department_ID, user_CVS_Job_Code, user_EE_SVCS_USER, user_Is_AuthoriaUser, user_EECHGSYS, 
                         user_Is_Employee, user_Level5_Department_Code, user_Emerge_DM, user_Is_HRMS_User, user_Emerge_RM, user_IsEmployeeWithAID, user_Emerge_RxSup, user_UserHasANID, user_FLSA_Status, user_GL_Pay_Type, 
                         user_Global_ID, user_Home_City, user_Home_Postal_Code, user_Home_State, user_Home_Street, user_Job_Category_Code, user_ob_Family_Code, user_Job_Function, user_Job_Grade, user_Learnet_Compliance, 
                         user_Manager_Level, user_OPR_Class, user_Pay_Group, user_PBM_SOW_Contractor, user_Personal_Phone, user_PharmTech_License_ID, user_PharmTech_License_State, user_Reg_Temp, user_RX_Zone, user_URL, 
                         user_Standard_Hours, user_Union_Code, user_User_Category, user_Vendor_DSD, user_CVS_AD_Account_Name, user_Vendor_DSD_Access, user_Vendor_DSD_Invoice, user_Vendor_Sup_Mail_1, user_Vendor_Sup_Mail_2, 
                         user_Work_Area, user_Work_District, user_Work_Region, user_Reference_ID, user_Work_Time, user_CVS_Business_Unit, user_SSN, user_Phone, user_Date_Of_Birth, user_Organization_ID, user_User_Type, user_City, 
                         user_Empl_Pay_Type, user_State, user_Emp_Status, user_Postal_Code, user_Country_Code, user_Cost_Center, user_Department_ID, user_Mail_Code, user_Office_phone_Country_Prefix, user_Identity_Type, 
                         user_User_Name, user_Pre_Conversion_ID, user_Job_Description, user_Preferred_Name, user_Cost_Center_Name, user_Description, user_Address_Line, user_Office_Name, user_Support_Location, user_Street, 
                         user_Added_Date, user_Modified_Date, user_Owner1, user_Owner2, user_Owner3, user_Is_Executive, user_Employee_Type, user_Supervisor_entityOwners, requestData_requestDetails_User_Line_of_Business_Details, 
                         requestData_requestDetails_User_Location, requestData_requestFormConfig_User_Line_of_Business_Details_label, requestData_requestFormConfig_User_Line_of_Business_Details_grouping, 
                         requestData_requestFormConfig_User_Line_of_Business_Details_formForEntityId, requestData_requestFormConfig_User_Line_of_Business_Details_formForEntityType, requestData_requestFormConfig_User_Location_label, 
                         requestData_requestFormConfig_User_Location_grouping, requestData_requestFormConfig_User_Location_formForEntityId, requestData_requestFormConfig_User_Location_formForEntityType, 
                         requestData_requestFormEntityConfig_User_Line_of_Business_Details, requestData_requestFormEntityConfig_User_Location, requestData_access_id, requestData_access_entityTypeId, requestData_access_entityTypeName,
                          requestData_access_assetId, requestData_access_Asset, requestData_access_type, requestData_access_Tag_Medium_Risk_Access, requestData_access_Tag_User_Account, 
                         requestData_access_Tag_Derived_Owner_Access, requestData_access_Tag_UnApprovedAccess, requestData_access_Tag_Reviewed_Medium_Risk_Access, requestData_access_Tag_Cloud_Access, 
                         requestData_access_Tag_Temporary_Account, requestData_access_Tag_Low_Risk_Access, requestData_access_Tag_Regular_Access, requestData_access_Tag_Anomaly_Access, requestData_access_Tag_Access_Groups, 
                         requestData_access_Tag_Test_Account, requestData_access_Tag_Risk_Not_Reviewed_Access, requestData_access_Tag_System_Account, requestData_access_Tag_Derived_Administrator_Access, 
                         requestData_access_Tag_High_Risk_Access, requestData_access_Tag_Indefinite_Access, requestData_access_Tag_Administrator_Access, requestData_access_Tag_L1_Exclusion_PreAuthorized, 
                         requestData_access_Tag_No_Risk_Access, requestData_access_Tag_Unauthorized_Access, requestData_access_Tag_Orphaned_Account, requestData_access_Tag_Shared_Account, 
                         requestData_access_Tag_Service_Account, requestData_access_Tag_L2_Exclusion_PreAuthorized, requestData_access_Tag_Expired_Access, requestData_access_Tag_Deleted_Account, 
                         requestData_access_Tag_Authorization_Groups, requestData_access_Tag_Temporary_Access, requestData_access_Tag_Locked_Account, requestData_access_Tag_Privileged_Access, 
                         requestData_access_Tag_Disabled_Account, requestData_access_Tag_RejectedAccess, requestData_access_Tag_Exceptional_Access, requestData_access_Tag_Derived_Privileged_Access, 
                         requestData_access_Tag_Unprotected_Resource, requestData_access_Tag_Derived_Administrative_Access, requestData_access_Tag_Privileged_Resource, requestData_access_Tag_Auto_Approval, 
                         requestData_access_Tag_Reviewed_High_Risk_Access, requestData_access_Tag_Owner_Access, requestData_access_Tag_Administrative_Access, requestData_access_Tag_Expired_Account, 
                         requestData_access_Tag_Owner_Approval, requestData_access_Tag_ViolatingAccess, requestData_access_Tag_Manager_Approval, requestData_access_Tag_Reviewed_Low_Risk_Access, requestData_access_Short_Name, 
                         requestData_access_ITPM_Number, requestData_access_Reference_ID, requestData_access_Unique_Id, requestData_access_Name, requestData_access_Description, requestData_access_Present_In, 
                         requestData_access_Creation_Date, requestId, additionalInfo, inProcessApprovalLevel, additionalData_fulfillmentData_Mail_Sent_On, additionalData_fulfillmentData_Mail_Sent_To, 
                         additionalData_fulfillmentData_Mail_Sent_On_Date, ticketData_ticketId, additionalData_fulfillmentData_ZZAccount_Emp_Id, additionalData_fulfillmentData_ZZAccount_Created, 
                         additionalData_fulfillmentData_ZZAccount_Created_On, additionalData_fulfillmentData_ZZAccount_CVS_Emp_Id, additionalData_fulfillmentData_Fulfilled_For_Account, 
                         additionalData_fulfillmentData_ZZAccount_Created_On_GMT, requestData_subRequestType, ticketData_externalTicketId, requestData_requestSummary_requestType, requestData_User_ShortName, 
                         requestData_User_EmployeeID
FROM            dbo.IAMHAccessNowOperations
GO
/****** Object:  Table [dbo].[IAMHCamsData]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHCamsData](
	[_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[RequestId] [int] NULL,
	[RequestDate] [datetime] NULL,
	[DateComplete] [datetime] NULL,
	[TimeSpan_Minutes] [bigint] NULL,
	[SubRequestId] [int] NULL,
	[AccessName] [nvarchar](100) NULL,
	[Description] [nvarchar](max) NULL,
	[IsWorkQueue] [bit] NULL,
	[AssignedToID] [nvarchar](50) NULL,
	[AssignedTo] [nvarchar](50) NULL,
	[Comments] [nvarchar](max) NULL,
	[CompleteDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_IAMHCamsData] PRIMARY KEY CLUSTERED 
(
	[_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[IAMHCamsItemsCompletedView]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHCamsItemsCompletedView] AS

SELECT
  AccessName,
  COUNT(DISTINCT CASE WHEN IsWorkQueue = 0 THEN SubRequestID END) AS [Work Queue False],
  COUNT(DISTINCT CASE WHEN IsWorkQueue = 1 THEN SubRequestID END) AS [Work Queue True],
  COUNT(DISTINCT SubRequestID) AS Total
FROM IAMHCamsData
GROUP BY AccessName;
GO
/****** Object:  View [dbo].[IAMHCamsDataView]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHCamsDataView] AS

SELECT        
	_ID, 
	RequestId, 
	RequestDate, 
	DateComplete,
	CompleteDate,
	ModifiedDate,
	TimeSpan_Minutes, 
	CASE
    WHEN TimeSpan_Minutes % 1440 >= 720 THEN (TimeSpan_Minutes / 1440) + 1
    ELSE TimeSpan_Minutes / 1440
	END AS SLADays,
	SubRequestId, 
	AccessName, 
	Description, 
	AssignedToID,
	AssignedTo,
	ISNULL(Comments, '  | ') AS Comments,
	CASE
		WHEN IsWorkQueue = 1 THEN 'Provisioned by OPS'
		ELSE 'Not Provisioned by OPS'
	END AS 'IsWorkQueue'
FROM            dbo.IAMHCamsData
GO
/****** Object:  Table [dbo].[IAMHHolidayDates]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHHolidayDates](
	[iD] [bigint] IDENTITY(1,1) NOT NULL,
	[HolidayDate] [datetime] NULL,
 CONSTRAINT [PK_IAMHHolidayDates] PRIMARY KEY CLUSTERED 
(
	[iD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHSNOWProvisioning]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHSNOWProvisioning](
	[number] [nvarchar](255) NOT NULL,
	[request_item.number] [nvarchar](255) NULL,
	[state] [nvarchar](255) NULL,
	[request_item.cat_item] [nvarchar](255) NULL,
	[assigned_to] [nvarchar](255) NULL,
	[assigned_to_BusinessUnit] [nvarchar](255) NULL,
	[assigned_to.manager] [nvarchar](255) NULL,
	[assignment_group] [nvarchar](255) NULL,
	[assignment_group.manager] [nvarchar](255) NULL,
	[Assignment_Group_Timespan] [int] NULL,
	[original_assignment_group] [nvarchar](255) NULL,
	[original_assignment_group_manager] [nvarchar](255) NULL,
	[Original_Assignment_Group_Timespan] [int] NULL,
	[Exported_Outside_IAM] [nvarchar](20) NULL,
	[short_description] [nvarchar](255) NULL,
	[sys_created_on] [datetime] NULL,
	[closed_at] [datetime] NULL,
	[active] [nvarchar](max) NULL,
	[approval] [nvarchar](255) NULL,
	[urgency] [nvarchar](255) NULL,
	[upon_reject] [nvarchar](255) NULL,
	[upon_approval] [nvarchar](255) NULL,
	[sys_updated_by] [nvarchar](255) NULL,
	[priority] [nvarchar](255) NULL,
	[opened_by] [nvarchar](255) NULL,
	[opened_by_department] [nvarchar](255) NULL,
	[opened_at] [datetime] NULL,
	[made_sla] [nvarchar](max) NULL,
	[knowledge] [nvarchar](max) NULL,
	[impact] [nvarchar](255) NULL,
	[u_has_attachment] [nvarchar](max) NULL,
	[follow_up] [nvarchar](255) NULL,
	[expected_start] [datetime] NULL,
	[escalation] [nvarchar](255) NULL,
	[u_escalated] [nvarchar](max) NULL,
	[due_date] [datetime] NULL,
	[sys_created_by] [nvarchar](255) NULL,
	[contact_type] [nvarchar](255) NULL,
	[closed_by] [nvarchar](255) NULL,
	[requested_for] [nvarchar](50) NULL,
	[requested_for_BusinessUnit] [nvarchar](255) NULL,
	[requested_for_department] [nvarchar](100) NULL,
	[assignmentGroup_manager_manager] [nvarchar](50) NULL,
	[updated_on] [datetime] NULL,
	[assigned_to_date] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[IAMHSNOWProvisioningView]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHSNOWProvisioningView]
AS

SELECT        
number, 
[request_item.number], 
state, 
[request_item.cat_item], 
    CASE
        WHEN assigned_to IS NULL AND (state = 'Closed Incomplete' OR state = 'Closed Complete') THEN 'IT Central Failure'
        ELSE COALESCE(assigned_to, 'Unassigned')
    END AS assigned_to,
[assigned_to.manager], 
CASE WHEN assigned_to_BusinessUnit is not null 
     THEN assigned_to_BusinessUnit
     ELSE 'None'
END AS assigned_to_BusinessUnit,
'' AS request_for_cost_center,
'' AS LineOfBusiness,
assignment_group, 
[assignment_group.manager], 
Assigned_To_Date,
Assignment_Group_Timespan, 

CASE WHEN Assignment_Group_Timespan % 1440 >= 720 THEN (Assignment_Group_Timespan / 1440) + 1 
     ELSE Assignment_Group_Timespan / 1440 
END AS Assignment_Group_Days, 

original_assignment_group, 
original_assignment_group_manager, 
Original_Assignment_Group_Timespan, 

CASE WHEN Original_Assignment_Group_Timespan % 1440 >= 720 THEN (Original_Assignment_Group_Timespan / 1440) + 1 
      ELSE Original_Assignment_Group_Timespan / 1440 
END AS Original_Assignment_Group_Days,

CASE WHEN original_assignment_group != assignment_group THEN Assignment_Group_Timespan + Original_Assignment_Group_Timespan 
     ELSE Assignment_Group_Timespan
     END AS Total_Timespan,

CASE WHEN original_assignment_group != assignment_group
     THEN CASE WHEN (Assignment_Group_Timespan + Original_Assignment_Group_Timespan) % 1440 >= 720 
                    THEN ((Assignment_Group_Timespan + Original_Assignment_Group_Timespan) / 1440) + 1
               ELSE (Assignment_Group_Timespan + Original_Assignment_Group_Timespan) / 1440 
          END  
     ELSE
          CASE WHEN Assignment_Group_Timespan % 1440 >= 720 THEN (Assignment_Group_Timespan / 1440) + 1
               ELSE Assignment_Group_Timespan / 1440 
          END  
END AS Total_Timespan_Days,

COALESCE(
    (
        DATEDIFF(d, sys_created_on, 
            CASE
                WHEN closed_at IS NOT NULL THEN closed_at
                ELSE GETUTCDATE()
            END
        )
        + CASE 
            WHEN DATEDIFF(hh, sys_created_on, 
                CASE
                    WHEN closed_at IS NOT NULL THEN closed_at
                    ELSE GETUTCDATE()
                END
            ) % 24 >= 1 THEN 1 
            ELSE 0 
          END 
         - (SELECT COUNT(b.HolidayDate)
            FROM IAMHHolidayDates b
            WHERE b.HolidayDate BETWEEN sys_created_on AND ISNULL(closed_at, GETUTCDATE())
            AND dbo.IAMHSNOWProvisioning.number = number)
    ), 0) AS Old_Timespan_Days,

Exported_Outside_IAM, 
CASE WHEN original_assignment_group != assignment_group THEN 'TRUE'
     ELSE 'FALSE' 
END AS Assignment_Group_Changed,
short_description, 
sys_created_on, 
CASE 
        WHEN [request_item.cat_item] LIKE '%AccessNow%' AND short_description LIKE 'Request Type- %' 
        THEN SUBSTRING(short_description, CHARINDEX('Request Type - ', short_description) + LEN('Request Type - ') + 1, LEN(short_description))
        WHEN short_description LIKE '%\[AccessNow\] Persona Access%' ESCAPE '\'
        THEN 'Persona'
        ELSE 'None'
END AS AccessNow_Category,
closed_at, 
active, 
approval, 
urgency, 
upon_reject, 
upon_approval, 
sys_updated_by, 
priority, 
opened_by, 
opened_by_department, 
opened_at, 
made_sla, 
knowledge, 
impact, 
u_has_attachment, 
follow_up, 
expected_start, 
escalation, 
u_escalated, 
due_date, 
sys_created_by, 
contact_type, 
closed_by, 
requested_for, 
requested_for_department,

CASE WHEN requested_for_BusinessUnit is not null 
     THEN requested_for_BusinessUnit
     ELSE 'None'
END AS requested_for_BusinessUnit,
assignmentGroup_manager_manager,
CASE
     WHEN state IN ('Open','Pending ','Work IN Progress') THEN 'Incomplete'
     ELSE 'Complete'
END AS CompletedState,
CASE
    WHEN (short_description LIKE '%\[AEP/WS\] Persona Access%' ESCAPE '\'  and [request_item.cat_item] = 'Persona Access' )
    THEN 'TRUE'
    ELSE 'FALSE'
END AS WelcomeSeasonFlag,

CASE
    WHEN (short_description LIKE '%CENTRIF%')
    THEN 'Y'
    ELSE 'N'
END AS CentrifyFlag


FROM  dbo.IAMHSNOWProvisioning


where number not in (
    'TASK2539545',
    'TASK2640801',
    'TASK2640802',
    'TASK2642310',
    'TASK2645334',
    'TASK2645390',
    'TASK2648158',
    'TASK2768719',
    'TASK2865227',
    'TASK2865248',
    'TASK2865272',
    'TASK2865274',
    'TASK2865275',
    'TASK2865277',
    'TASK2865279'
)



GROUP BY 
number, 
[request_item.number], 
state, 
[request_item.cat_item], 
assigned_to, 
[assigned_to.manager], 
assigned_to_BusinessUnit,
assignment_group, 
[assignment_group.manager], 
Assignment_Group_Timespan, 
original_assignment_group, 
original_assignment_group_manager, 
Original_Assignment_Group_Timespan, 
Exported_Outside_IAM, 
short_description, 
sys_created_on, 
closed_at, 
active, 
approval, 
urgency, 
upon_reject, 
upon_approval, 
sys_updated_by, 
priority, 
opened_by, 
opened_by_department, 
opened_at, 
made_sla, 
knowledge, 
impact, 
u_has_attachment, 
follow_up, 
expected_start, 
escalation, 
u_escalated, 
due_date, 
sys_created_by, 
contact_type, 
closed_by, 
requested_for, 
requested_for_department,
assignmentGroup_manager_manager,
requested_for_BusinessUnit,
Assigned_To_Date
GO
/****** Object:  View [dbo].[IAMHProvisioningOpenView]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHProvisioningOpenView]
AS

SELECT 
      [number] AS [TASK NUMBER]
      ,[opened_by] AS [CREATED BY]
      ,[state] AS [STATE]
      ,[assigned_to] AS [ASSIGNED TO]
      ,[assigned_to.manager] AS [ASSIGNED TO MANAGER]
      ,[assignment_group] AS [ASSIGNED TO GROUP]
      ,[request_item.cat_item] AS [REQUEST ITEM NAME]
      ,[urgency] AS [URGENCY]
      ,[priority] AS [PRIORITY]
      ,[contact_type] AS [TICKET SOURCE]
      ,[sys_created_on] AS [TICKET CREATED DATE]
      ,[closed_at] AS [TICKET CLOSED DATE]
      ,[escalation] AS [ESCALATION]
      ,[short_description] AS [TICKET DESCRIPTION]
      ,CAST(
        CASE
            WHEN CAST([Assignment_Group_Days] AS INT) > 9 
            THEN '10+'
            ELSE CAST([Assignment_Group_Days] AS VARCHAR(20))
        END
		AS VARCHAR(20)) AS [TICKET AGE]
      ,CASE
            WHEN CAST([Assignment_Group_Days] AS INT) < 6 
            THEN 'IN SLA'
            ELSE 'Out Of SLA'
      END AS [SLA Status]
      ,[impact] AS [IMPACT]
FROM [IAMHSNOWProvisioningView]

WHERE CompletedState = 'Incomplete'

-- Definition of Incomplete
-- Where state in ('Open','Pending','Work In Progress')

AND Exported_Outside_IAM = 'EIS IAM'
AND CAST(sys_created_on as DateTime) > '07-01-2022 00:00:01'
GO
/****** Object:  Table [dbo].[IAMHSNOWIncidents]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHSNOWIncidents](
	[Number] [nvarchar](255) NOT NULL,
	[State] [nvarchar](255) NULL,
	[Configuration item] [nvarchar](255) NULL,
	[Short description] [nvarchar](255) NULL,
	[Assignment group] [nvarchar](255) NULL,
	[Assignment_Group_Manager] [nvarchar](255) NULL,
	[Assignment_Group_Timespan] [int] NULL,
	[OriginalAssignmentGroup] [nvarchar](255) NULL,
	[Original_Assignment_Group_Manager] [nvarchar](255) NULL,
	[Original_Assignment_Group_Timespan] [int] NULL,
	[Exported_Outside_IAM] [nvarchar](30) NULL,
	[Assigned to] [nvarchar](255) NULL,
	[Assigned to Business Unit] [nvarchar](255) NULL,
	[Manager] [nvarchar](255) NULL,
	[Created] [datetime] NULL,
	[Resolved] [datetime] NULL,
	[Escalated] [nvarchar](max) NULL,
	[Actions taken] [nvarchar](255) NULL,
	[Active] [nvarchar](max) NULL,
	[Approval] [nvarchar](255) NULL,
	[Category] [nvarchar](255) NULL,
	[Contact] [nvarchar](255) NULL,
	[Type] [nvarchar](255) NULL,
	[Escalation] [nvarchar](255) NULL,
	[Impact] [nvarchar](255) NULL,
	[Opened by] [nvarchar](255) NULL,
	[Opened by Department] [nvarchar](255) NULL,
	[Opened By Business Unit] [nvarchar](255) NULL,
	[Priority] [nvarchar](255) NULL,
	[Severity] [nvarchar](255) NULL,
	[Urgency] [nvarchar](255) NULL,
	[assigned_to_date] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[IAMHSNOWIncidentsView]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHSNOWIncidentsView]
AS

SELECT        
Number, 
State, 
[Configuration item], 
[Short description], 
[Assignment group], 
Assignment_Group_Manager,
Assigned_To_Date,
Created, 
Resolved, 
Assignment_Group_Timespan, 

CASE WHEN Assignment_Group_Timespan % 1440 >= 720 THEN (Assignment_Group_Timespan / 1440) + 1
     ELSE Assignment_Group_Timespan / 1440 
END AS Assignment_Group_Days, 

OriginalAssignmentGroup, 
Original_Assignment_Group_Manager, 
Original_Assignment_Group_Timespan, 

CASE WHEN Original_Assignment_Group_Timespan % 1440 >= 720 THEN (Original_Assignment_Group_Timespan / 1440) + 1 
ELSE Original_Assignment_Group_Timespan / 1440 
END AS Original_Assignment_Group_Days,

CASE WHEN OriginalAssignmentGroup != [Assignment group] THEN 'TRUE'
     ELSE 'FALSE' 
END AS Assignment_Group_Changed,

Exported_Outside_IAM, Manager, 

CASE WHEN OriginalAssignmentGroup != [Assignment group] THEN Assignment_Group_Timespan + Original_Assignment_Group_Timespan 
     ELSE Assignment_Group_Timespan
END AS Total_Timespan,

CASE WHEN OriginalAssignmentGroup != [Assignment group] 
     THEN CASE WHEN (Assignment_Group_Timespan + Original_Assignment_Group_Timespan) % 1440 >= 720 
                    THEN ((Assignment_Group_Timespan + Original_Assignment_Group_Timespan) / 1440) + 1
               ELSE (Assignment_Group_Timespan + Original_Assignment_Group_Timespan) / 1440 
          END  
     ELSE
          CASE WHEN Assignment_Group_Timespan % 1440 >= 720 THEN (Assignment_Group_Timespan / 1440) + 1
               ELSE Assignment_Group_Timespan / 1440 
          END  
END AS Total_Timespan_Days,

COALESCE(
    (
        DATEDIFF(d, Created, 
            CASE
                WHEN Resolved IS NOT NULL THEN Resolved
                ELSE GETUTCDATE()
            END
        )
    ), 0) AS Old_Timespan_Days,

[Assigned to], 
CASE WHEN [Assigned to Business Unit] is not null 
     THEN [Assigned to Business Unit]
     ELSE 'None'
END AS [Assigned to Business Unit],
Escalated, 
[Actions taken], 
Active, 
Approval, 
Category, 
Contact, 
Type, 
Escalation, 
Impact, 
[Opened by], 
[Opened by Department], 
CASE WHEN [Opened By Business Unit] is not null 
     THEN [Opened By Business Unit]
     ELSE 'None'
END AS [Opened By Business Unit],
Priority, 
Severity, 
Urgency,

CASE
     WHEN State IN ('Active','New ','Awaiting Problem','Awaiting User Info','Awaiting Evidence','Awaiting Modification','Awaiting Vendor') THEN 'Incomplete'
     ELSE 'Complete'
END AS CompletedState


FROM            dbo.IAMHSNOWIncidents

GROUP BY 
Number, 
State, 
[Configuration item], 
[Short description], 
[Assignment group], 
Assignment_Group_Manager,
Assignment_Group_Timespan, 
OriginalAssignmentGroup, 
Original_Assignment_Group_Manager, 
Original_Assignment_Group_Timespan, 
Exported_Outside_IAM, Manager, 
[Assigned to], 
Created, 
Resolved, 
Escalated, 
[Actions taken], 
Active, 
Approval, 
Category, 
Contact, 
Type, 
Escalation, 
Impact, 
[Opened by], 
[Opened by Department], 
Priority, 
Severity, 
Urgency,
[Assigned to Business Unit],
[Opened By Business Unit],
Assigned_To_Date
GO
/****** Object:  View [dbo].[IAMHIncidentsOpenView]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHIncidentsOpenView]
AS

SELECT 
       [Number]
      ,CAST(
        CASE
            WHEN CAST([Assignment_Group_Days] AS INT) > 9 
            THEN '10+'
            ELSE CAST([Assignment_Group_Days] AS VARCHAR(20))
        END
        AS VARCHAR(20)) AS [Age Group]
      ,CASE
            WHEN CAST(Assignment_Group_Days as INT) < 6 
            THEN 'SLA'
            ELSE 'Out Of SLA'
      END AS [SLA Meet]
      ,[State]
      ,[Created]
      ,[Resolved]
      ,[Priority]
      ,[Severity]
      ,[Impact]
      ,[Exported_Outside_IAM] AS [Transferred Out]
      ,[Assignment_Group_Manager] AS [Manager]
      ,[Assigned to]
      ,[Assignment group] AS [Assignment group]
      ,[Category]
      ,[Configuration item]
      ,[Short description]
  FROM [IAMHSNOWIncidentsView]

WHERE CompletedState = 'Incomplete'

-- Definition of Incomplete
--State IN ('Active', 'New ', 'Awaiting Problem', 'Awaiting User Info', 'Awaiting Evidence', 
--                         'Awaiting Modification', 'Awaiting Vendor')

AND Exported_Outside_IAM = 'EIS IAM'
AND CAST(Created as DateTime) > '07-01-2022 00:00:01'
GO
/****** Object:  Table [dbo].[IAMHMORMetricsTable]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHMORMetricsTable](
	[iD] [bigint] IDENTITY(1,1) NOT NULL,
	[DateRange] [datetime] NOT NULL,
	[AccessNowCount] [bigint] NULL,
	[AccessNowManualCount] [bigint] NULL,
	[AccessNowAutomatedCount] [bigint] NULL,
	[AccessNowMixedCount] [bigint] NULL,
	[AccessNowInSLACount] [bigint] NULL,
	[AccessNowSLAEligibleCount] [bigint] NULL,
	[AccessNowSLAPercentage] [float] NULL,
	[ProvisioningCount] [bigint] NULL,
	[ProvisioningSLACount] [bigint] NULL,
	[ProvisioningSLAPercentage] [float] NULL,
	[IncidentsTableCount] [bigint] NULL,
	[IncidentsINSLACount] [bigint] NULL,
	[IncidentsSLAPercentage] [float] NULL,
	[MailboxTableCount] [bigint] NULL,
	[MailboxInSLACount] [bigint] NULL,
	[MailboxSLAPercentage] [float] NULL,
	[RMRTotalCount] [bigint] NULL,
	[RMRManualCount] [bigint] NULL,
	[RMRAutomatedCount] [bigint] NULL,
	[RMRINSLACount] [bigint] NULL,
	[RMRSLAPercentage] [float] NULL,
	[CAMSTotalCount] [bigint] NULL,
 CONSTRAINT [PK_IAMHMORMetricsTable] PRIMARY KEY CLUSTERED 
(
	[iD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[IAMHExecutiveView]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHExecutiveView] AS
SELECT [iD],
      [DateRange],
      [AccessNowCount],
      [AccessNowManualCount],
      [AccessNowAutomatedCount],
      [AccessNowInSLACount],
      [AccessNowSLAEligibleCount],
      [AccessNowSLAPercentage] / 100 AS [AccessNowSLAPercentage],
      [AccessNowMixedCount],
      [ProvisioningCount],
      [ProvisioningSLACount],
      [ProvisioningSLAPercentage] / 100 AS [ProvisioningSLAPercentage],
      [IncidentsTableCount],
      [IncidentsINSLACount],
      [IncidentsSLAPercentage] / 100 AS [IncidentsSLAPercentage],
      [ProvisioningCount] + [IncidentsTableCount] AS ServiceNowCount,
      [ProvisioningSLACount] + [IncidentsINSLACount] AS ServiceNowSLACount,

      STR(
          ROUND(
              (
                CAST([ProvisioningSLACount] + [IncidentsINSLACount] AS decimal )
                / 
                CAST([ProvisioningCount] + [IncidentsTableCount] AS decimal )

              ) * 100, 2, 1
          ), 4, 2
      )  AS ServiceNowSLAPercentage,
      [MailboxTableCount],
      [MailboxInSLACount],
      [MailboxSLAPercentage] / 100 AS [MailboxSLAPercentage],
      CASE WHEN CAST(DateRange as Datetime) < dbo.GetRMRChangeDate() THEN 0 ELSE [RMRTotalCount] END AS [RMRTotalCount],
      CASE WHEN CAST(DateRange as Datetime) < dbo.GetRMRChangeDate() THEN 0 ELSE [RMRManualCount] END AS [RMRManualCount],
      CASE WHEN CAST(DateRange as Datetime) < dbo.GetRMRChangeDate() THEN 0 ELSE [RMRAutomatedCount] END AS [RMRAutomatedCount],
      CASE WHEN CAST(DateRange as Datetime) < dbo.GetRMRChangeDate() THEN 0 ELSE [RMRINSLACount] END AS [RMRINSLACount],
      CASE WHEN CAST(DateRange as Datetime) < dbo.GetRMRChangeDate() THEN 0 ELSE [RMRSLAPercentage] / 100 END AS [RMRSLAPercentage],
      CASE
        WHEN YEAR([DateRange]) = YEAR(GETDATE()) THEN 'CurrentYear'
        WHEN YEAR([DateRange]) = YEAR(GETDATE()) - 1 THEN 'PreviousYear'
        ELSE 'Other'
      END AS [Year]
FROM [dbo].[IAMHMORMetricsTable]
WHERE YEAR([DateRange]) >= YEAR(GETDATE()) - 2 AND YEAR([DateRange]) <= YEAR(GETDATE())
GO
/****** Object:  Table [dbo].[IAMHCARRSMetrics]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHCARRSMetrics](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[timeframe] [datetime] NOT NULL,
	[CARRS: Event-Based Transfer Access Reviews Tasks] [nvarchar](50) NULL,
	[CARRS: % of ETAR tasks with No Response] [nvarchar](50) NULL,
	[CARRS: % of ETAR Tasks with User Access Deprov or Mod] [nvarchar](50) NULL,
	[Percentage Rejected] [float] NULL,
	[Approved Task Count] [bigint] NULL,
	[Rejected Task Count] [bigint] NULL,
	[No Response Task Count] [nchar](10) NULL,
	[Reviewers] [bigint] NULL,
	[Users] [bigint] NULL,
 CONSTRAINT [PK_IAMHCARRSMetrics] PRIMARY KEY CLUSTERED 
(
	[timeframe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[IAMHCARRSMetricsView]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHCARRSMetricsView]
AS
SELECT        id, timeframe, [CARRS: Event-Based Transfer Access Reviews Tasks], [CARRS: % of ETAR tasks with No Response], [CARRS: % of ETAR Tasks with User Access Deprov or Mod], [Percentage Rejected], [Approved Task Count], 
                         [Rejected Task Count], [No Response Task Count], Reviewers, Users
FROM            dbo.IAMHCARRSMetrics
GO
/****** Object:  View [dbo].[IAMHFactoolJoinedView]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHFactoolJoinedView] AS

SELECT        
FactoolRequest._id, 
FactoolRequest.CreateDate, 
FactoolRequest.CreateTick, 
FactoolRequest.ModifiedDate, 
FactoolRequest.ModifiedTick, 
FactoolRequest.SamAccount, 
FactoolRequest.DisplayName, 
FactoolRequest.ReferenceNumber, 
FactoolRequest.NewRequest, 
FactoolRequest.TotalUsers, 
FactoolRequest.RequestStatus, 
FactoolRequest.FormType, 
FactoolRequest.RequestType, 
FactoolRequest.DefectReason, 
FactoolRequest.Systems, 
FactoolRequest.ReplyTypes, 
FactoolRequest.Comments, 
FactoolRequest.XREF1, 
FactoolRequest.XREF2, 
FactoolStatus.ReqStatusID, 
FactoolStatus.ReferenceNumber AS Expr1, 
FactoolStatus.SentStatus, 
FactoolStatus.RequestState, 
FactoolStatus.TouchPoints, 
FactoolStatus.TimesReturned, 
FactoolStatus.SLAStart, 
FactoolStatus.CompletionDate, 
FactoolStatus.SLACompletionTime, 
FactoolStatus.AgentComments, 
FactoolStatus.AgentsWorked,

CAST(
CASE
    WHEN FactoolStatus.RequestState = 'Completed' AND CHARINDEX(';', REVERSE(FactoolStatus.AgentsWorked)) > 0
    THEN SUBSTRING(FactoolStatus.AgentsWorked, LEN(FactoolStatus.AgentsWorked) - CHARINDEX(';', REVERSE(FactoolStatus.AgentsWorked)) + 2, LEN(FactoolStatus.AgentsWorked))
    ELSE ''
    END AS VARCHAR(max)
) AS Closed_By

FROM            dbo.IAMHFactoolRequest AS FactoolRequest INNER JOIN
                         dbo.IAMHFactoolRequestStatus AS FactoolStatus ON FactoolRequest.ReferenceNumber = FactoolStatus.ReferenceNumber


GO
/****** Object:  View [dbo].[IAMHMORMetricsView]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHMORMetricsView] AS 

SELECT
        dt.DateRange,
        CASE
          WHEN subs.Subsystem = 'IAM Mailbox' THEN 'IAM Mailbox Provisioning' 
          ELSE subs.Subsystem
        END AS System,
        CASE 
          WHEN subs.Subsystem = 'AccessNow' THEN dt.AccessNowTableCount
          WHEN subs.Subsystem = 'ServiceNow Provisioning' THEN dt.ProvisioningTableCount
          WHEN subs.Subsystem = 'ServiceNow Incidents' THEN dt.IncidentsTableCount
          WHEN subs.Subsystem = 'IAM Mailbox' THEN dt.MailboxTableCount
          WHEN subs.Subsystem = 'RMR' AND CAST(dt.DateRange as Datetime) > dbo.GetRMRChangeDate() THEN dt.RMRTotalCount
          WHEN subs.Subsystem = 'CAMS' AND CAST(dt.DateRange as Datetime) > dbo.GetRMRChangeDate()  THEN dt.CAMSTotalCount
        END As TotalCount,
        CASE 
          WHEN subs.Subsystem = 'AccessNow' THEN dt.AccessNowManualCount
          WHEN subs.Subsystem = 'ServiceNow Provisioning' THEN dt.ProvisioningTableCount
          WHEN subs.Subsystem = 'ServiceNow Incidents' THEN dt.IncidentsTableCount
          WHEN subs.Subsystem = 'IAM Mailbox' THEN dt.MailboxTableCount
          WHEN subs.Subsystem = 'RMR' AND CAST(dt.DateRange as Datetime) > dbo.GetRMRChangeDate() THEN dt.RMRManualCount
          WHEN subs.Subsystem = 'CAMS' AND CAST(dt.DateRange as Datetime) > dbo.GetRMRChangeDate()  THEN dt.CAMSTotalCount
        END As ManualCount,
        CASE 
          WHEN subs.Subsystem = 'AccessNow' THEN dt.AccessNowAutomatedCount
          WHEN subs.Subsystem = 'RMR' AND CAST(dt.DateRange as Datetime) > dbo.GetRMRChangeDate() THEN dt.RMRAutomatedCount
        END As AutomatedCount,
        CASE 
          WHEN subs.Subsystem = 'AccessNow' THEN dt.AccessNowMixedCount ELSE 0
        END As MixedCount,
        CASE 
          WHEN subs.Subsystem = 'AccessNow' THEN dt.AccessNowSLAEligibleCount
          WHEN subs.Subsystem = 'ServiceNow Provisioning' THEN dt.ProvisioningTableCount
          WHEN subs.Subsystem = 'ServiceNow Incidents' THEN dt.IncidentsTableCount
          WHEN subs.Subsystem = 'IAM Mailbox' THEN dt.MailboxTableCount
          WHEN subs.Subsystem = 'RMR' AND CAST(dt.DateRange as Datetime) > dbo.GetRMRChangeDate() THEN dt.RMRTotalCount
        END As SLAEligibleCount,
        CASE 
          WHEN subs.Subsystem = 'AccessNow' THEN dt.AccessNowSLACount
          WHEN subs.Subsystem = 'ServiceNow Provisioning' THEN dt.ProvisioningSLACount
          WHEN subs.Subsystem = 'ServiceNow Incidents' THEN dt.IncidentsSLACount
          WHEN subs.Subsystem = 'IAM Mailbox' THEN dt.MailboxSLACount
          WHEN subs.Subsystem = 'RMR' AND CAST(dt.DateRange as Datetime) > dbo.GetRMRChangeDate() THEN dt.RMRINSLACount
        END As SLAMetCount,
        CASE 
          WHEN subs.Subsystem = 'AccessNow' THEN dt.AccessNowSLAPercentage
          WHEN subs.Subsystem = 'ServiceNow Provisioning' THEN dt.ProvisioningSLAPercentage
          WHEN subs.Subsystem = 'ServiceNow Incidents' THEN dt.IncidentsSLAPercentage
          WHEN subs.Subsystem = 'IAM Mailbox' THEN dt.MailboxSLAPercentage
          WHEN subs.Subsystem = 'RMR' AND CAST(dt.DateRange as Datetime) > dbo.GetRMRChangeDate() THEN dt.RMRSLAPercentage
        END As SLAPercentage
FROM 
     (
        SELECT DISTINCT
                DateRange, 
                AccessNowCount As AccessNowTableCount, 
                AccessNowManualCount, 
                AccessNowAutomatedCount, 
                AccessNowMixedCount, 
                AccessNowInSLACount As AccessNowSLACount, 
                AccessNowSLAEligibleCount, 
                AccessNowSLAPercentage, 
                ProvisioningCount AS ProvisioningTableCount, 
                ProvisioningSLACount, 
                ProvisioningSLAPercentage, 
                IncidentsTableCount, 
                IncidentsINSLACount As IncidentsSLACount, 
                IncidentsSLAPercentage, 
                MailboxTableCount, 
                MailboxInSLACount AS MailboxSLACount, 
                MailboxSLAPercentage, 
                RMRTotalCount,
                RMRManualCount,
                RMRAutomatedCount,
                RMRINSLACount,
                RMRSLAPercentage,
                CAMSTotalCount,
                IncidentsTableCount + ProvisioningCount AS ITSCSubtotalTableCount, 
                IncidentsTableCount + ProvisioningCount + MailboxTableCount AS Total_Non_AccessNow_Count, 
                 AccessNowAutomatedCount AS AutomatedCount, 
                 AccessNowManualCount + ProvisioningCount + IncidentsTableCount + MailboxTableCount + RMRManualCount + CAMSTotalCount AS ManualCount, 
                (AccessNowSLAPercentage + IncidentsSLAPercentage + ProvisioningSLAPercentage + MailboxSLAPercentage + RMRSLAPercentage) / 5 AS AverageSLAPercentage, 
                AccessNowCount + ProvisioningCount + IncidentsTableCount + MailboxTableCount + RMRTotalCount + CAMSTotalCount  AS TotalTableCount
        FROM(
                SELECT        
                iD, 
                DateRange, 
                AccessNowCount, 
                AccessNowManualCount, 
                AccessNowAutomatedCount, 
                AccessNowMixedCount, 
                AccessNowInSLACount, 
                AccessNowSLAEligibleCount, 
                AccessNowSLAPercentage, 
                ProvisioningCount, 
                ProvisioningSLACount, 
                ProvisioningSLAPercentage, 
                IncidentsTableCount, 
                IncidentsINSLACount, 
                IncidentsSLAPercentage, 
                MailboxTableCount, 
                MailboxInSLACount, 
                MailboxSLAPercentage,
                RMRTotalCount,
                RMRManualCount,
                RMRAutomatedCount,
                [RMRINSLACount],
                [RMRSLAPercentage],
                CAMSTotalCount
                FROM  dbo.IAMHMORMetricsTable
        ) AS subquery
     ) AS dt
CROSS JOIN 
   (
        SELECT 'AccessNow' As SubSystem
        UNION ALL
        SELECT 'ServiceNow Provisioning' As SubSystem
        UNION ALL
        SELECT 'ServiceNow Incidents' As SubSystem
        UNION ALL
        SELECT 'IAM Mailbox' As SubSystem
        UNION ALL
        SELECT 'RMR' As SubSystem
        UNION ALL
        SELECT 'CAMS' As SubSystem
   ) AS subs
WHERE 
(subs.Subsystem <> 'RMR' OR (subs.Subsystem = 'RMR' AND CAST(dt.DateRange as Datetime) > dbo.GetRMRChangeDate() ) )
AND 
(subs.Subsystem <> 'CAMS' OR (subs.Subsystem = 'CAMS' AND CAST(dt.DateRange as Datetime) > dbo.GetRMRChangeDate() ) )
        
GO
/****** Object:  Table [dbo].[IAMHParData]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHParData](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[timeframe] [datetime] NOT NULL,
	[no_response] [bigint] NULL,
	[marked_for_removal] [bigint] NULL,
	[exported] [bigint] NULL,
	[complete] [bigint] NULL,
	[incomplete] [bigint] NULL,
	[total] [bigint] NULL,
	[tasks_1000] [bigint] NULL,
	[tasks_500_to_999] [bigint] NULL,
	[tasks_250_to_499] [bigint] NULL,
	[tasks_100_to_249] [bigint] NULL,
	[tasks_1_to_99] [bigint] NULL,
	[deprov_mod_percentage] [float] NULL,
	[no_response_percentage] [float] NULL,
	[access_reviewer_counts] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[IAMHPARDataView]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHPARDataView]
AS
SELECT        id, timeframe, no_response, marked_for_removal, exported, complete, incomplete, total, tasks_1000, tasks_500_to_999, tasks_250_to_499, tasks_100_to_249, tasks_1_to_99, deprov_mod_percentage, 
                         no_response_percentage, access_reviewer_counts
FROM            dbo.IAMHParData
GO
/****** Object:  Table [dbo].[IAMHRMRCodeTypes]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHRMRCodeTypes](
	[Id] [bigint] NOT NULL,
	[appCode] [nvarchar](100) NULL,
	[appName] [nvarchar](max) NULL,
	[appGroup] [nvarchar](max) NULL,
	[applicationUsed] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHRMRUserTable]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHRMRUserTable](
	[ID] [int] NOT NULL,
	[AetnaID] [nvarchar](255) NULL,
	[CVSID] [float] NULL,
	[FullName] [nvarchar](255) NULL,
	[WorkFocus] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHRMRData]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHRMRData](
	[Id] [bigint] NOT NULL,
	[customer_sequence] [nvarchar](100) NULL,
	[status] [nvarchar](100) NULL,
	[last_update_date] [datetime2](3) NULL,
	[last_updated_by] [nvarchar](100) NULL,
	[creation_date] [datetime2](3) NULL,
	[created_by] [nvarchar](100) NULL,
	[requestor_id] [nvarchar](100) NULL,
	[customer_id] [nvarchar](100) NULL,
	[effective_date] [datetime2](3) NULL,
	[request_type] [nvarchar](100) NULL,
	[business_area] [nvarchar](100) NULL,
	[model] [nvarchar](100) NULL,
	[request_detail] [nvarchar](max) NULL,
	[comments] [nvarchar](max) NULL,
	[page_name] [nvarchar](100) NULL,
	[temp_id] [nvarchar](100) NULL,
	[automation_status] [nvarchar](100) NULL,
	[_id] [bigint] IDENTITY(1,1) NOT NULL,
	[RequestDetailXML] [nvarchar](max) NULL,
	[AppCodeComputed] [nvarchar](100) NULL,
	[AppName] [nvarchar](100) NULL,
	[RequestorName] [nvarchar](100) NULL,
	[RequestorDepartment] [nvarchar](100) NULL,
	[RequestorOrganization] [nvarchar](100) NULL,
	[AdditionalInformation] [nvarchar](100) NULL,
	[TimeSpan_Minutes] [int] NULL,
	[closed_on_date] [datetime] NULL,
	[closed_by] [nvarchar](100) NULL,
	[status_changed_date] [datetime] NULL,
	[last_status] [nvarchar](50) NULL,
 CONSTRAINT [PK_IAMHRMRData] PRIMARY KEY CLUSTERED 
(
	[_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[IAMHRMRDataView]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHRMRDataView]
AS

WITH XMLData AS 
(SELECT        
Id as RequestID, 
customer_sequence, 
status, 
last_update_date, 
last_updated_by, 
creation_date, 
created_by, 
closed_on_date,
closed_by,
status_changed_date,
last_status,
requestor_id,
customer_id, 
effective_date, 
request_type, 
business_area, 
model, 
comments, 
page_name, 
temp_id, 
automation_status, 
_id AS ID,
AppCodeComputed,
AppName,
RequestorName,
RequestorDepartment,
RequestorOrganization,
AdditionalInformation,
TimeSpan_Minutes

FROM            dbo.IAMHRMRData)

SELECT 
xd.ID,       
xd.RequestID , 
xd.customer_sequence, 
xd.status, 
CASE
    WHEN (xd.status = 'CLOSED' OR xd.status = 'REJECTED' OR xd.status = 'DENIED' OR xd.status = 'CANCELLED' OR xd.status = 'REJECTED (NON-RECALLABLE)')
    THEN 'Closed'
    Else 'Open'
END AS Closed_State,  
xd.last_update_date, 
xd.last_updated_by,

CASE
    WHEN last_updated_by = requestor_id THEN RequestorName
    WHEN u.FullName IS NULL THEN 'Unassigned'
    ELSE u.FullName
END AS LastUpdatedByName,

CASE
    WHEN last_updated_by = requestor_id THEN 'Requestor'
    WHEN u.WorkFocus IS NULL THEN 'Unassigned'
    ELSE u.WorkFocus
END AS LastUpdatedByFocusArea,

CASE
    WHEN xd.last_updated_by = 'AUTOCL'
    THEN 'Automated'
    ELSE 'Manual'
END AS Type,
xd.creation_date, 
xd.created_by, 
xd.closed_on_date,
xd.closed_by,
xd.status_changed_date,
xd.last_status,
xd.requestor_id, 
xd.customer_id, 
xd.effective_date, 
xd.request_type, 
xd.business_area, 
xd.model, 
xd.comments, 
xd.page_name, 
xd.temp_id, 
xd.automation_status,
xd.AppCodeComputed AS AppCode ,
xd.AppName,
xd.RequestorName,
xd.RequestorDepartment,
xd.RequestorOrganization,
xd.AdditionalInformation,
xd.TimeSpan_Minutes,

CASE
    WHEN xd.TimeSpan_Minutes % 1440 >= 720 THEN (xd.TimeSpan_Minutes / 1440) + 1
    ELSE xd.TimeSpan_Minutes / 1440
END AS TimeSpan_Days,

ISNULL(ct.appGroup,'Unassigned') AS appGroup,
ct.applicationUsed
FROM XMLData AS xd 
LEFT OUTER JOIN dbo.IAMHRMRCodeTypes AS ct 
    ON (xd.AppCodeComputed = ct.appCode OR 
       xd.AppCodeComputed = CONCAT('APP_', ct.appCode) OR 
       xd.AppCodeComputed = CONCAT('APD_', ct.appCode))
    AND xd.AppCodeComputed = ct.appCode
LEFT OUTER JOIN 
    dbo.IAMHRMRUserTable AS u ON xd.last_updated_by = u.AetnaID;
GO
/****** Object:  Table [dbo].[IAMHSolutionCenterEscalations]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHSolutionCenterEscalations](
	[Id] [int] NOT NULL,
	[Title] [nvarchar](255) NULL,
	[Ticket (INC/TA] [datetime] NULL,
	[Reporting area] [nvarchar](255) NULL,
	[Application(s)] [nvarchar](255) NULL,
	[RequestingExpediteId] [nvarchar](255) NULL,
	[RequestingExpediteStringId] [nvarchar](255) NULL,
	[Escalation explanation] [nvarchar](255) NULL,
	[Approved] [nvarchar](255) NULL,
	[IAM Ops AnalystId] [nvarchar](255) NULL,
	[IAM Ops AnalystStringId] [nvarchar](255) NULL,
	[S.C. analyst] [nvarchar](255) NULL,
	[Analysts Comments] [nvarchar](255) NULL,
	[Exped/Escal] [nvarchar](255) NULL,
	[Req/ticket type] [nvarchar](255) NULL,
	[Escalation Cause] [nvarchar](255) NULL,
	[Contact Resolution Stage] [nvarchar](255) NULL,
	[Pre-ApprovalDate] [datetime] NULL,
	[Project Related?] [nvarchar](255) NULL,
	[ITPR number] [nvarchar](255) NULL,
	[ITPR PM] [nvarchar](255) NULL,
	[Manager Comments] [nvarchar](255) NULL,
	[ID.1] [nvarchar](255) NULL,
	[ContentTypeId] [nvarchar](255) NULL,
	[Modified] [datetime] NULL,
	[Created] [datetime] NULL,
	[AuthorId] [nvarchar](255) NULL,
	[EditorId] [nvarchar](255) NULL,
	[OData_UIVersionString] [nvarchar](255) NULL,
	[Attachments] [nvarchar](255) NULL,
	[GUID] [nvarchar](255) NULL,
	[ComplianceAssetId] [nvarchar](255) NULL,
	[FirstUniqueAncestorSecurableObject] [nvarchar](255) NULL,
	[RoleAssignments] [nvarchar](255) NULL,
	[AttachmentFiles] [nvarchar](255) NULL,
	[ContentType] [nvarchar](255) NULL,
	[GetDlpPolicyTip] [nvarchar](255) NULL,
	[FieldValuesAsHtml] [nvarchar](255) NULL,
	[FieldValuesAsText] [nvarchar](255) NULL,
	[FieldValuesForEdit] [nvarchar](255) NULL,
	[File] [nvarchar](255) NULL,
	[Folder] [nvarchar](255) NULL,
	[LikedByInformation] [nvarchar](255) NULL,
	[ParentList] [nvarchar](255) NULL,
	[Properties] [nvarchar](255) NULL,
	[Versions] [nvarchar](255) NULL,
	[RequestingExpedite] [nvarchar](255) NULL,
	[IAM Ops Analyst] [nvarchar](255) NULL,
	[Author] [nvarchar](255) NULL,
	[Editor] [nvarchar](255) NULL,
	[FileSystemObjectType] [nvarchar](255) NULL,
	[ServerRedirectedEmbedUri] [nvarchar](255) NULL,
	[ServerRedirectedEmbedUrl] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[IAMHSolutionCenterEscalationsView]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHSolutionCenterEscalationsView]
AS
SELECT        Id, Title, [Ticket (INC/TA], [Reporting area], [Application(s)], RequestingExpediteId, RequestingExpediteStringId, [Escalation explanation], Approved, [IAM Ops AnalystId], [IAM Ops AnalystStringId], [S.C. analyst], 
                         [Analysts Comments], [Exped/Escal], [Req/ticket type], [Escalation Cause], [Contact Resolution Stage], [Pre-ApprovalDate], [Project Related?], [ITPR number], [ITPR PM], [Manager Comments], [ID.1], ContentTypeId, Modified, 
                         Created, AuthorId, EditorId, OData_UIVersionString, Attachments, GUID, ComplianceAssetId, FirstUniqueAncestorSecurableObject, RoleAssignments, AttachmentFiles, ContentType, GetDlpPolicyTip, FieldValuesAsHtml, 
                         FieldValuesAsText, FieldValuesForEdit, [File], Folder, LikedByInformation, ParentList, Properties, Versions, RequestingExpedite, [IAM Ops Analyst], Author, Editor, FileSystemObjectType, ServerRedirectedEmbedUri, 
                         ServerRedirectedEmbedUrl, CASE WHEN [Reporting area] IN ('EIS IAM Active Directory', 'EIS IAM Build', 'EIS IAM CVS Apps', 'EIS IAM HCB Apps', 'EIS IAM Infrastructure', 'EIS IAM Simeio') 
                         THEN 'EIS' ELSE 'NOT EIS' END AS EIS_NOT_EIS
FROM            dbo.IAMHSolutionCenterEscalations
GO
/****** Object:  Table [dbo].[IAMHAccessNowAutomationTypes]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHAccessNowAutomationTypes](
	[id] [int] NULL,
	[request_type] [nvarchar](max) NULL,
	[automation_type] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[IAMHAccessNowOperationsView]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHAccessNowOperationsView] AS

With BaseData AS 
(
  SELECT 
	requestId AS request_id,
	externalId AS external_Id, 
	requestedOn AS requested_on,  
	requestType, 
	requestData_subRequestType AS subRequestType, 
	requestData_requestSummary_requestType AS innerRequestType,
	requestDesc , 
	status, 
	closedOn AS closed_on, 
	requestData_access_Asset AS asset, 
	asset_additionalData_asset_Name AS asset_Name,
	{ fn CONCAT({ fn CONCAT(entityPropType, ' ') }, relatedEntityName) } AS access, 
	asset_id as asset_id, 
	relatedEntityName AS access_name,
	user_CVS_AD_Account_Name AS accounts_name, 
	requestor_CVS_AD_Account_Name AS requestor_name, 
	requestor_Employee_ID, 
	CASE 
		WHEN user_Employee_ID IS NULL 
			THEN requestData_User_EmployeeID 
			ELSE user_Employee_ID 
	END AS recipientId,
	CASE 
		WHEN user_Short_Name IS NULL 
			THEN requestData_user_ShortName 
			ELSE user_Short_Name 
	END AS recipientName,
	ticketData_ticketId AS ticket_id, 
	ticketData_externalTicketId AS externalTicketId, 
	additionalData_fulfillmentData_ZZAccount_Created AS ZZAccount_Created,
	requestor_Cost_Center AS CostCenter,
	requestor_Department AS requestorDepartment,
	

-- Conditional Columns ticket_status, mail_sent_to, mail_sent_on, mail_sent_on_date, and TicketCount

        CASE 
	WHEN (status LIKE '%fulfilled%' OR status LIKE '%rejectedduringfulfillment%') THEN 'Closed Complete' 
	ELSE 'Open' END AS ticket_status, 

	additionalData_fulfillmentData_Mail_Sent_To AS mail_sent_to, 

	additionalData_fulfillmentData_Mail_Sent_On AS mail_sent_on, 

        additionalData_fulfillmentData_Mail_Sent_On_Date AS mail_sent_on_date, 

	'1' AS TicketCount,  


--#Region Category Filter Based on Complex Criteria

        CASE 

	-- LIST OF AUTOMATED CATEGORIES

	WHEN status = 'rejected' THEN 'Rejected'

	WHEN (requestType LIKE '%grantaccess%') 
	AND (additionalData_fulfillmentData_ZZAccount_Created is null OR additionalData_fulfillmentData_ZZAccount_Created LIKE '') 
	AND (additionalData_fulfillmentData_Mail_Sent_To NOT LIKE '%ResearchAD@aetna.com%' or additionalData_fulfillmentData_Mail_Sent_To is null)
	AND (ticketData_externalTicketId not like '%TASK%' OR ticketData_externalTicketId IS NULL)
	AND (
	     (requestData_access_Asset NOT LIKE '%Dataset%' AND
       	      requestData_access_Asset NOT LIKE '%IBM Group%' AND
              requestData_access_Asset NOT LIKE '%PowerH%' AND
              requestData_access_Asset NOT LIKE '%PowerR%' AND
              requestData_access_Asset NOT LIKE '%Profiles%' AND
              requestData_access_Asset NOT LIKE '%Tso System Access%'
             ) 
              OR requestData_access_Asset IS NULL)
	AND (requestData_access_Asset LIKE '%AccessNow%' OR
        requestData_access_Asset LIKE '%Meritain DG Prod%' OR
        requestData_access_Asset LIKE '%Meritain%' OR
        requestData_access_Asset LIKE '%Meritain 1mage 1suite%' OR
	requestData_access_Asset LIKE '%AWS%' OR
        requestData_access_Asset LIKE '%Meritain Echo UI Self Funded%' OR
        requestData_access_Asset LIKE '%Meritain Rightfax%' OR
        requestData_access_Asset LIKE '%MERITAIN Active Directory%' OR
        requestData_access_Asset LIKE '%AETH Active Directory%' OR
        requestData_access_Asset LIKE '%AETH%' OR
        requestData_access_Asset LIKE '%AETHQ Active Directory%' OR
        requestData_access_Asset LIKE '%Aett%' OR
        requestData_access_Asset LIKE '%Aett Active Directory%' OR
        requestData_access_Asset LIKE '%Corp Active Directory%' OR
        requestData_access_Asset LIKE '%Minute Clinic Active Directory%' OR
        requestData_access_Asset LIKE '%Payflex Active Directory%' OR
        requestData_access_Asset LIKE '%PBM Active Directory%' OR
        requestData_access_Asset LIKE '%Retail Active Directory%' OR
        requestData_access_Asset LIKE '%eLDAP%' OR
        requestData_access_Asset LIKE '%HealthehostT' OR
        requestData_access_Asset LIKE '%RXConnect' OR
        requestData_access_Asset LIKE '%JAMF%' OR
	requestData_access_Asset LIKE '%ICU GROUP%' OR
        requestData_access_Asset LIKE '%Local Unix%' OR
        requestData_access_Asset LIKE '%Meritain DG Prod%' OR
        requestData_access_Asset LIKE '%Quickbase%' OR
        requestData_access_Asset LIKE '%Salesforce NextGen Service Platform - Training%' OR
        requestData_access_Asset LIKE '%Azure Prod Tenant%' OR
        requestData_access_Asset LIKE '%Azure Non Prod Tenant%' OR
        requestData_access_Asset LIKE '%Salesforce NextGen Service Platform%' OR
        requestData_access_Asset LIKE '%HEH%' OR
        requestData_access_Asset LIKE '%AETDMZ%' OR
        requestData_access_Asset IS NULL
        ) THEN 'Automated Add Access' 

	WHEN (requestType LIKE '%addaccounttolocalunixgroup%') THEN 'Automated Add Account to Local Unix Group' 

	WHEN (requestType LIKE '%replicatelocalgrouponunixserver%') THEN 'Automated Replicate Existing Local Group on Unix Server'

	WHEN (requestType LIKE '%addadgrouptounixserverallowlist%') THEN 'Automated Add Existing Active Directory Group to Allow List for Unix Server' 

	WHEN (requestType LIKE '%modifynonpersonaccount%') AND  (additionalData_fulfillmentData_Mail_Sent_To LIKE '' OR additionalData_fulfillmentData_Mail_Sent_To IS NULL) 
	AND (requestData_subRequestType LIKE '%addworkstation%' OR requestData_subRequestType LIKE '%removeworkstatio%n') 
	AND (ticketData_externalTicketId not like '%TASK%' OR ticketData_externalTicketId IS NULL)
	THEN 'Automated Modify Non Person Account Server/Workstation' 

	WHEN (requestType LIKE '%changegroupowner%')
	AND (additionalData_fulfillmentData_Mail_Sent_To NOT LIKE '%ResearchAD@aetna.com%' or additionalData_fulfillmentData_Mail_Sent_To is null)  
	AND (ticketData_externalTicketId not like '%TASK%' OR ticketData_externalTicketId IS NULL)
	THEN 'Automated Change Entitlement Owner' 

	WHEN (requestType LIKE '%changegroupowner%')
	AND (additionalData_fulfillmentData_Mail_Sent_To NOT LIKE '%ResearchAD@aetna.com%' or additionalData_fulfillmentData_Mail_Sent_To is null)  
	AND (ticketData_externalTicketId like '%TASK%')
	THEN 'Manual AD Automation Failure' 

	WHEN (requestType LIKE '%changegroupowner%') AND (additionalData_fulfillmentData_Mail_Sent_To NOT LIKE '%ResearchAD@aetna.com%' or additionalData_fulfillmentData_Mail_Sent_To is null) THEN 'Automated Change Entitlement Owner' 

	WHEN (requestType LIKE '%changenpidentityowner%') AND  (additionalData_fulfillmentData_Mail_Sent_To LIKE '' OR additionalData_fulfillmentData_Mail_Sent_To IS NULL)  
	AND (ticketData_externalTicketId not like '%TASK%' OR ticketData_externalTicketId IS NULL)
	THEN 'Automated Change Non Person Identity Owner'

        WHEN requestType LIKE '%createnonpersonidentity%' and ( (additionalData_fulfillmentData_Mail_Sent_To LIKE '' OR additionalData_fulfillmentData_Mail_Sent_To IS NULL) AND (ticketData_externalTicketId not like '%TASK%' OR ticketData_externalTicketId IS NULL))  THEN 'Automated Create Non Person Identity' 

	WHEN (requestType LIKE '%createazureserviceprincipal%') THEN 'Automated Create Azure Service Principal'	

	WHEN (requestType LIKE '%creategroup%' AND (additionalData_fulfillmentData_Mail_Sent_To LIKE '' OR additionalData_fulfillmentData_Mail_Sent_To IS NULL)) 
	      AND (ticketData_externalTicketId not like '%TASK%' OR ticketData_externalTicketId IS NULL)
	THEN 'Automated Create Group in Asset' 

	WHEN (requestType LIKE '%createlocalunixaccount%')  THEN 'Automated Create Local Unix Account' 

	WHEN (requestType LIKE '%addcvsassetsbirthrightaccess%') THEN 'Automated CVS Assets Add Birthright Access' 

	WHEN (requestType LIKE '%changedisplayname%') THEN 'Automated Change Display Name' 

	WHEN (requestType LIKE '%syncgroupstocloudtenants%') THEN 'Automated Sync Groups to Cloud Tenants'

	WHEN (requestType LIKE '%changesmtpaddress%') THEN 'Automated Change Primary Email Address'

	WHEN requestType LIKE '%cvsprocessconversions%' THEN 'Automated CVS Contractor to Employee Conversion' 

	WHEN requestType LIKE '%deletesharedmailbox%' and (ticketData_externalTicketId not like '%TASK%' OR ticketData_externalTicketId IS NULL) THEN 'Automated Delete Shared Mailbox' 

	WHEN requestType LIKE '%modifysharedmailbox%' and (ticketData_externalTicketId not like '%TASK%' OR ticketData_externalTicketId IS NULL) THEN 'Automated Modify Shared Mailbox' 

	WHEN (requestType LIKE '%createnewlocalgrouponunixserver%' OR (requestType LIKE '%createlocalgrouponserver%' and requestDesc = 'Create New Local Group on Unix Server') ) THEN 'Automated Create New Local Group on Unix Server' 

        WHEN (requestType LIKE '%removelocalgroupfromunixserver%') THEN 'Automated Remove Local Group on Unix Server' 

        WHEN (requestType LIKE '%removeaccountfromlocalunixgroup%') THEN 'Automated Remove Account From Local Group on Unix Server' 

	WHEN (requestType LIKE '%deleteazureserviceprincipal%') THEN 'Automated Delete Azure Service Principal' 

	WHEN (requestType LIKE '%deletegroup%') AND (additionalData_fulfillmentData_Mail_Sent_To IS NULL) AND (asset_additionalData_asset_Name IS NULL OR (asset_additionalData_asset_Name NOT LIKE '%AETHQ%' and asset_additionalData_asset_Name NOT LIKE '%AETH%')) THEN 'Automated Delete Group' 

	WHEN (requestType LIKE '%deletelocalunixaccount%') THEN 'Automated Delete Local Unix Account' 

	WHEN (requestType LIKE '%disableaccount%') AND (additionalData_fulfillmentData_Mail_Sent_To LIKE '' OR additionalData_fulfillmentData_Mail_Sent_To IS NULL)  THEN 'Automated Disable Account' 

	WHEN (requestType LIKE '%modifyadhoccallcenter%' OR requestType LIKE '%modifyadhoclob%') THEN 'Automated Modify Adhoc Call Center for Existing Active GPS Users' 

	WHEN (requestType LIKE '%modifyazureserviceprincipal%') THEN 'Automated Modify Azure Service Principal' 

	WHEN (requestType LIKE '%modifycontractor%') THEN 'Automated Modify Contractor' 

	WHEN (requestType LIKE '%modifygroup%') THEN 'Automated Modify Group in Asset' 

	WHEN (requestType LIKE '%addlocalunixservertoinventory%') THEN 'Automated Add Local Unix Server to Inventory'

	WHEN (requestType LIKE '%removeexistingactivedirectorygroupfromunixserver%' OR requestType LIKE '%removeadgroupfromunixserverallowlist%')  THEN 'Automated Remove Existing Active Directory Group from Allow List for Unix Server' 

	WHEN (requestType LIKE '%revokeaccess%') AND 
	(
	 requestData_access_Asset LIKE '%AETT Active Directory%' OR 
	 requestData_access_Asset LIKE '%Aeth%' OR 
	 requestData_access_Asset LIKE '%Aethq%' OR 
	 requestData_access_Asset LIKE '%Azure%' OR 
	 requestData_access_Asset LIKE '%AETDMZQ Active Directory%' OR 
	 requestData_access_Asset LIKE '%AETDMZT Active Directory%' OR 
	 requestData_access_Asset LIKE '%AETDMZ Active Directory%' OR 
	 requestData_access_Asset LIKE '%Salesforce NextGen Service Platform%' OR 
	 requestData_access_Asset LIKE '%ICU Group%'
	 ) 
	AND 
            (
	     (requestData_access_Asset NOT LIKE '%Dataset%' AND
       	      requestData_access_Asset NOT LIKE '%IBM Group%' AND
              requestData_access_Asset NOT LIKE '%PowerH%' AND
              requestData_access_Asset NOT LIKE '%PowerR%' AND
              requestData_access_Asset NOT LIKE '%Profiles%' AND
              requestData_access_Asset NOT LIKE '%Tso System Access%'
             ) 
              OR requestData_access_Asset IS NULL
            )
	THEN 'Automated Revoke Access' 

	WHEN (requestType LIKE '%rolebasedauthupdatedeptmodel%') THEN 'Automated Role Based Authority' 

	WHEN (requestType LIKE '%terminatehcbaccountsystemaccess%')  THEN 'Automated Terminate System Access' 

	WHEN (additionalData_fulfillmentData_ZZAccount_Created is not null AND additionalData_fulfillmentData_ZZAccount_Created != '') THEN 'Automated ZZ Account Create' 

	-- LIST OF MANUAL CATEGORIES As of 07/31/2023 Almost all Manual Categories are created in Service Now with TASK External Ticket ID's. 

	-- As Of 07/31/2023 The Following Categories have been Resdesignated as AD Automation Failure

	WHEN (additionalData_fulfillmentData_Mail_Sent_To LIKE '%ResearchAD@aetna.com%' AND requestType LIKE '%grantaccess%' AND CAST(requestedOn AS DATE) <= '07/31/2023') THEN 'Manual RNA Add Access' 

	WHEN (requestType LIKE '%grantaccess%' 
	      AND (requestData_access_Asset NOT LIKE '%RBAC Repository%' OR requestData_access_Asset IS NULL)
	      AND (additionalData_fulfillmentData_Mail_Sent_To NOT LIKE '%SecurityS@aetna.com%' OR additionalData_fulfillmentData_Mail_Sent_To IS NULL)
	      AND (
	      	   (requestData_access_Asset NOT LIKE '%Dataset%' AND
       		    requestData_access_Asset NOT LIKE '%IBM Group%' AND
        	    requestData_access_Asset NOT LIKE '%PowerH%' AND
        	    requestData_access_Asset NOT LIKE '%PowerR%' AND
        	    requestData_access_Asset NOT LIKE '%Profiles%' AND
        	    requestData_access_Asset NOT LIKE '%Tso System Access%'
        	   ) 
        	   OR requestData_access_Asset IS NULL
        	  )
	      AND ticketData_externalTicketId like '%TASK%') THEN 'Manual AD Automation Failure' 

	WHEN (additionalData_fulfillmentData_Mail_Sent_To LIKE '%ResearchAD@aetna.com%') AND (requestType LIKE '%changeentitlementowner%' OR requestType LIKE '%changegroupowner%') 
	AND CAST(requestedOn AS DATE) <= '07/31/2023'  THEN 'Manual RAD Change Entitlement Owner' 

        WHEN (requestType LIKE '%changeentitlementowner%' OR requestType LIKE '%changegroupowner%') AND ticketData_externalTicketId like '%TASK%'  
        THEN 'Manual AD Automation Failure' 

        WHEN (requestType LIKE '%changnonpersonidentityowner%' OR requestType LIKE '%changenpidentityowner%') 
        AND  (additionalData_fulfillmentData_Mail_Sent_To LIKE '%SecurityS@aetna.com%' OR ticketData_externalTicketId like '%TASK%') 
        AND CAST(requestedOn AS DATE) <= '07/31/2023'
        THEN 'Manual Change Non Person Identity Owner' 

       WHEN (requestType LIKE '%changnonpersonidentityowner%' OR requestType LIKE '%changenpidentityowner%'
       	     OR requestType LIKE '%deletesharedmailbox%' OR requestType LIKE '%resetnonpersonaccountpassword%' 
             OR requestType LIKE '%modifyhomedirectoryaccess%' OR requestType LIKE '%modifypersonalmailboxaccess%') 
        AND ticketData_externalTicketId like '%TASK%'
        AND CAST(requestedOn AS DATE) > '07/31/2023'
        THEN 'Manual AD Automation Failure' 

       WHEN requestType LIKE '%createnonpersonidentity%' 
       and (additionalData_fulfillmentData_Mail_Sent_To LIKE '%SecurityS@aetna.com%' OR additionalData_fulfillmentData_Mail_Sent_To IS NOT NULL OR ticketData_externalTicketId like '%TASK%')
       AND CAST(requestedOn AS DATE) <= '07/31/2023'
       THEN 'Manual Create Non Person Identity' 

       WHEN requestType LIKE '%createnonpersonidentity%' 
       and (ticketData_externalTicketId like '%TASK%')
       AND CAST(requestedOn AS DATE) > '07/31/2023'
       THEN 'Manual AD Automation Failure' 
        -- End of AD Automation Failure Categories

	WHEN (additionalData_fulfillmentData_Mail_Sent_To LIKE '%SecurityS@aetna.com%' AND requestType LIKE '%grantaccess%' AND requestData_access_Asset NOT LIKE '%RBAC Repository%')  AND 
	(requestData_access_Asset NOT LIKE '%Dataset%' AND
        requestData_access_Asset NOT LIKE '%IBM Group%' AND
        requestData_access_Asset NOT LIKE '%PowerH%' AND
        requestData_access_Asset NOT LIKE '%PowerR%' AND
        requestData_access_Asset NOT LIKE '%Profiles%' AND
        requestData_access_Asset NOT LIKE '%ICU GROUP%' AND
        requestData_access_Asset NOT LIKE '%TSO System Access%') THEN 'Manual Non Person Add Access' 

	WHEN requestType LIKE '%createdistributionlist%' THEN 'Manual Create Distribution List' 

	WHEN (additionalData_fulfillmentData_Mail_Sent_To LIKE '%SecurityS@aetna.com%' or additionalData_fulfillmentData_Mail_Sent_To is not null OR ticketData_externalTicketId like '%TASK%')  AND (requestType LIKE '%creategroup%') THEN 'Manual Create Group in Asset' 

	

	WHEN requestType LIKE '%createsecuretransportaccount%' THEN 'Manual Create Secure Transport Account'

        WHEN requestType LIKE '%createserviceaccount%' THEN 'Manual Create Service Account' 

	WHEN requestType LIKE '%createsharedmailbox%' THEN 'Manual Create Shared Mailbox' 

	WHEN requestType LIKE '%createtestaccount%' THEN 'Manual Create Test Account' 

	WHEN requestType LIKE '%deleteaccount%' THEN 'Manual Delete Account' 

	WHEN requestType LIKE '%deletecomponent%' THEN 'Manual Delete Component' 

	WHEN requestType LIKE '%deletedistributionlist%' THEN 'Manual Delete Email Distribution List' 

	WHEN (requestType LIKE '%deletegroup%') AND (additionalData_fulfillmentData_Mail_Sent_To IS NOT NULL or asset_additionalData_asset_Name LIKE '%AETHQ%' or asset_additionalData_asset_Name LIKE '%AETH%') THEN 'Manual Delete Group' 

	WHEN requestType LIKE '%modifycomponent%' THEN 'Manual Modify Component' 

	WHEN (requestType LIKE '%modifynonpersonaccount%') AND (requestData_subRequestType LIKE '%removecommandlineshell%' OR requestData_subRequestType LIKE '%addcommandlineshell%') THEN 'Manual Modify Non Person Account Command Shell' 

	WHEN (requestType LIKE '%modifynonpersonaccount%' OR requestType LIKE '%modifynonpersonidentity%') AND
	(
	(requestData_subRequestType NOT LIKE '%addworkstation%' AND 
	requestData_subRequestType NOT LIKE '%removeworkstation%' AND
	requestData_subRequestType NOT LIKE '%disableunixaccount%' AND
	requestData_subRequestType NOT LIKE '%enableunixaccount%'
	) OR 
	(requestData_subRequestType is null) 
	) THEN 'Manual Modify Non Person Identity' 

	WHEN (requestType LIKE '%modifynonpersonaccount%') AND (requestData_subRequestType LIKE '%disableunixaccount%' OR requestData_subRequestType LIKE '%enableunixaccount%') THEN 'Manual Modify Non person Account Unix Enable/Disable' 

	WHEN (requestType LIKE '%modifynonpersonaccount%') AND (additionalData_fulfillmentData_Mail_Sent_To LIKE '%SecurityS@aetna.com%' OR ticketData_externalTicketId like '%TASK%') 
	AND (requestData_subRequestType LIKE '%addworkstation%' OR requestData_subRequestType LIKE '%removeworkstation%') THEN 'Manual Modify Non Person Account Server/Workstation' 

	WHEN requestType LIKE '%newcomponent%' THEN 'Manual New Component'

	WHEN (requestData_access_Asset LIKE '%RBAC Repository%' OR asset_additionalData_asset_Name like '%RBAC Repository%') 
	AND (requestType LIKE '%addrbacmodel%' OR requestType LIKE '%deleterbacmodel%' or requestType LIKE '%modifyaccess%' or requestType LIKE '%revokeaccess%') 
	THEN 'Manual RBAC Optional Role' 

        WHEN requestType LIKE '%retirenonpersonidentity%' THEN 'Manual Retire Non Person Identity' 


	-- These Two Might Be No Longer Tracked


	WHEN (additionalData_fulfillmentData_Mail_Sent_To LIKE '%RequestSecurityServerAccess@aetna.com%') THEN 'Non-IAM Manual Group Create' 

	WHEN (additionalData_fulfillmentData_Mail_Sent_To LIKE '%RequestsS3@AETNA.com%') THEN 'Non-IAM Manual Unix' 


	-- LIST OF MIXED CATEGORIES

	WHEN (requestData_access_Asset LIKE '%RBAC Repository%' AND requestType LIKE '%grantaccess%') THEN 'Mixed RBAC Add/Mod/Del Entitlements' 

	WHEN ( (requestData_access_Asset LIKE '%RBAC Repository%' OR asset_additionalData_asset_Name like '%RBAC Repository%') AND requestType LIKE '%modifyrbacmodel%') THEN 'Mixed RBAC Change Recipient Model' 

	WHEN (requestType LIKE '%grantaccess%' OR requestType LIKE '%revokeaccess%') AND 
	(requestData_access_Asset LIKE '%Dataset%' OR
        requestData_access_Asset LIKE '%IBM Group%' OR
        requestData_access_Asset LIKE '%PowerH%' OR
        requestData_access_Asset LIKE '%PowerR%' OR
        requestData_access_Asset LIKE '%Profiles%' OR
        requestData_access_Asset LIKE '%Tso System Access%' OR
        requestData_access_Asset IS NULL
        ) THEN 'Mixed Mainframe Resource' 

	WHEN (requestData_access_Asset LIKE '%Personas%') 
	THEN 'Mixed Personas' 

	ELSE requestType 
	END AS Category, 

--#EndRegion END OF CATEGORIES FILTER

--SLADays Case based on Timespan Criteria

	CAST(CASE WHEN (closedOn IS NOT NULL) 
            THEN CASE WHEN (additionalData_fulfillmentData_Mail_Sent_On != '' AND additionalData_fulfillmentData_Mail_Sent_On IS NOT NULL) 

            THEN CASE WHEN (closedOn IS NOT NULL AND additionalData_fulfillmentData_Mail_Sent_On_Date IS NOT NULL) 
            THEN 
              	CAST(CAST(DATEDIFF(DAY, additionalData_fulfillmentData_Mail_Sent_On_Date, closedOn) AS INT) - 
            	(2 * (DATEDIFF(WEEK, additionalData_fulfillmentData_Mail_Sent_On_Date, closedON) + 1)) AS VARCHAR(MAX)

            	)

            ELSE '0' END

	    ELSE CASE WHEN (closedOn IS NOT NULL AND additionalData_fulfillmentData_Mail_Sent_On_Date != '' AND additionalData_fulfillmentData_Mail_Sent_On_Date IS NOT NULL AND additionalData_fulfillmentData_Mail_Sent_On_Date != 'Incomplete') 
	    THEN CASE WHEN (closedOn IS NOT NULL AND additionalData_fulfillmentData_Mail_Sent_On_Date != '' AND additionalData_fulfillmentData_Mail_Sent_On_Date IS NOT NULL AND additionalData_fulfillmentData_Mail_Sent_On_Date != 'Incomplete') 
            THEN CAST(DATEDIFF(DAY, additionalData_fulfillmentData_Mail_Sent_On_Date, closedOn) AS varchar(MAX)) ELSE '0' 
	    END ELSE 'No SLA' END END 

	ELSE 'Incomplete' END AS varchar(MAX)) AS SLADays

--#EndRegion END OF SLADays Case based on Timespan Criteria

FROM dbo.IAMHAccessNowOperations 
) ,

AutomationTypes AS (
	SELECT request_type, automation_type
	FROM IAMHAccessNowAutomationTypes
	WHERE automation_type IN ('Automated','Mixed','Manual','Rejected')
)

Select
ano.request_Id AS request_id,
ano.external_Id AS external_Id,
ano.requested_on AS requested_on,  
ano.requestType AS requestType, 
ano.subRequestType AS subRequestType,
ano.innerRequestType AS innerRequestType,
ano.requestDesc AS requestDesc, 
ano.status AS status, 
ano.closed_On AS closed_on, 
ano.CostCenter AS CostCenter,
ano.asset AS asset, 
ano.asset_Name AS assetName,
ano.access AS access, 
ano.access_name AS accessName,
ano.asset_id as assetId,
ano.accounts_name AS accounts_name, 
ano.requestor_name AS requestor_name, 
ano.requestor_Employee_ID AS requestor_Employee_ID, 
ano.recipientName AS recipient_Name, 		
ano.recipientId AS recipient_Employee_Id, 
ano.requestorDepartment AS requestorDepartment,
ano.ticket_id AS ticket_id,
ano.externalTicketId AS externalTicketId,
CASE 
     WHEN ano.externalTicketId LIKE '%TASK%'
	THEN 'SNOW_Task'
     ELSE 
     	'Access Now'
END AS ExternalSystemType,
ano.ticket_status AS ticket_status,
ano.mail_sent_to AS mail_sent_to,
ano.mail_sent_on AS mail_sent_on,
ano.mail_sent_on_date AS mail_sent_on_date,
ano.TicketCount AS TicketCount,
ano.Category AS Category,
ano.SLADays AS SLADays,
ano.ZZAccount_Created AS ZZAccount_Created,
LEN(ano.requestDesc) - LEN(REPLACE(ano.requestDesc, ',', '')) + 1 AS TouchPoints,
COALESCE(at.automation_type, 'Unknown') AS Type,
CASE
    			WHEN ano.Category LIKE '%Automated%' THEN CONCAT(REPLACE(ano.Category, 'Automated', ''), ' Automated')
    			WHEN ano.Category LIKE '%Manual%' THEN CONCAT(REPLACE(ano.Category, 'Manual', ''), ' Manual')
    			WHEN ano.Category LIKE '%Mixed%' THEN CONCAT(REPLACE(ano.Category, 'Mixed', ''), ' Mixed')
    			ELSE 'Automated'
END AS Metric,
'PlaceHolder' AS LineOfBusiness

FROM BaseData ano
LEFT OUTER JOIN AutomationTypes at ON ano.Category = at.request_type
WHERE NOT ( (ano.Category = 'Mixed Personas' OR ano.Category = 'Mixed RBAC Add/Mod/Del Entitlements' OR ano.Category = 'Mixed RBAC Change Recipient Model') 
      AND ano.requested_on > '2023-12-31')
GO
/****** Object:  Table [dbo].[IAMHCostCenter]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHCostCenter](
	[BusinessUnit] [nvarchar](255) NULL,
	[CostCenter] [nvarchar](255) NULL,
	[DepartmentDescription] [nvarchar](255) NULL,
	[Additional_CostCenter] [nvarchar](255) NULL,
	[S4CostCenter] [nvarchar](255) NULL,
	[S4CostCenterDescription] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[IAMHAccessNowOperationsViewOlder]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHAccessNowOperationsViewOlder]
AS
SELECT        ano.request_id, ano.external_Id, ano.requested_on, ano.requestType, ano.subRequestType, ano.innerRequestType, ano.requestDesc, ano.status, ano.closed_on, ano.CostCenter, 
                         dbo.IAMHCostCenter.S4CostCenterDescription AS LineOfBusiness, ano.asset, ano.asset_Name AS assetName, ano.access, ano.access_name AS accessName, ano.asset_id AS assetId, ano.accounts_name, 
                         ano.requestor_name, ano.requestor_Employee_ID, ano.recipientName AS recipient_Name, ano.recipientId AS recipient_Employee_Id, ano.requestorDepartment, ano.ticket_id, ano.externalTicketId, 
                         CASE WHEN ano.externalTicketId LIKE '%TASK%' THEN 'SNOW_Task' ELSE 'Access Now' END AS ExternalSystemType, ano.ticket_status, ano.mail_sent_to, ano.mail_sent_on, ano.mail_sent_on_date, ano.TicketCount, 
                         ano.Category, ano.SLADays, ano.ZZAccount_Created, LEN(ano.requestDesc) - LEN(REPLACE(ano.requestDesc, ',', '')) + 1 AS TouchPoints, CASE WHEN EXISTS
                             (SELECT        *
                               FROM            IAMHAccessNowAutomationTypes B
                               WHERE        B.automation_type = 'Automated' AND B.request_type = ano.Category) THEN 'Automated' ELSE CASE WHEN EXISTS
                             (SELECT        *
                               FROM            IAMHAccessNowAutomationTypes B
                               WHERE        B.automation_type = 'Manual' AND B.request_type = ano.Category) THEN 'Manual' ELSE CASE WHEN EXISTS
                             (SELECT        *
                               FROM            IAMHAccessNowAutomationTypes B
                               WHERE        B.automation_type = 'Mixed' AND B.request_type = ano.Category) THEN 'Mixed' ELSE CASE WHEN EXISTS
                             (SELECT        *
                               FROM            IAMHAccessNowAutomationTypes B
                               WHERE        B.automation_type = 'Rejected' AND B.request_type = ano.Category) THEN 'Rejected' ELSE 'Unknown' END END END END AS Type, 
                         CASE WHEN ano.Category LIKE '%Automated%' THEN CONCAT(REPLACE(ano.Category, 'Automated', ''), ' Automated') WHEN ano.Category LIKE '%Manual%' THEN CONCAT(REPLACE(ano.Category, 'Manual', ''), ' Manual') 
                         WHEN ano.Category LIKE '%Mixed%' THEN CONCAT(REPLACE(ano.Category, 'Mixed', ''), ' Mixed') ELSE ano.Category END AS Metric
FROM            (SELECT        requestId AS request_id, externalId AS external_Id, requestedOn AS requested_on, requestType, requestData_subRequestType AS subRequestType, 
                                                    requestData_requestSummary_requestType AS innerRequestType, requestDesc, status, closedOn AS closed_on, requestData_access_Asset AS asset, asset_additionalData_asset_Name AS asset_Name, 
                                                    { fn CONCAT({ fn CONCAT(entityPropType, ' ') }, relatedEntityName) } AS access, asset_id, relatedEntityName AS access_name, user_CVS_AD_Account_Name AS accounts_name, 
                                                    requestor_CVS_AD_Account_Name AS requestor_name, requestor_Employee_ID, CASE WHEN user_Employee_ID IS NULL THEN requestData_User_EmployeeID ELSE user_Employee_ID END AS recipientId, 
                                                    CASE WHEN user_Short_Name IS NULL THEN requestData_user_ShortName ELSE user_Short_Name END AS recipientName, ticketData_ticketId AS ticket_id, ticketData_externalTicketId AS externalTicketId, 
                                                    additionalData_fulfillmentData_ZZAccount_Created AS ZZAccount_Created, requestor_Cost_Center AS CostCenter, requestor_Department AS requestorDepartment, CASE WHEN (status LIKE '%fulfilled%' OR
                                                    status LIKE '%rejectedduringfulfillment%') THEN 'Closed Complete' ELSE 'Open' END AS ticket_status, additionalData_fulfillmentData_Mail_Sent_To AS mail_sent_to, 
                                                    additionalData_fulfillmentData_Mail_Sent_On AS mail_sent_on, additionalData_fulfillmentData_Mail_Sent_On_Date AS mail_sent_on_date, '1' AS TicketCount, 
                                                    CASE WHEN status = 'rejected' THEN 'Rejected' WHEN (requestType LIKE '%grantaccess%') AND (additionalData_fulfillmentData_ZZAccount_Created IS NULL OR
                                                    additionalData_fulfillmentData_ZZAccount_Created LIKE '') AND (additionalData_fulfillmentData_Mail_Sent_To NOT LIKE '%ResearchAD@aetna.com%' OR
                                                    additionalData_fulfillmentData_Mail_Sent_To IS NULL) AND (ticketData_externalTicketId NOT LIKE '%TASK%' OR
                                                    ticketData_externalTicketId IS NULL) AND ((requestData_access_Asset NOT LIKE '%Dataset%' AND requestData_access_Asset NOT LIKE '%IBM Group%' AND requestData_access_Asset NOT LIKE '%PowerH%' AND 
                                                    requestData_access_Asset NOT LIKE '%PowerR%' AND requestData_access_Asset NOT LIKE '%Profiles%' AND requestData_access_Asset NOT LIKE '%Tso System Access%') OR
                                                    requestData_access_Asset IS NULL) AND (requestData_access_Asset LIKE '%AccessNow%' OR
                                                    requestData_access_Asset LIKE '%Meritain DG Prod%' OR
                                                    requestData_access_Asset LIKE '%Meritain%' OR
                                                    requestData_access_Asset LIKE '%Meritain 1mage 1suite%' OR
                                                    requestData_access_Asset LIKE '%AWS%' OR
                                                    requestData_access_Asset LIKE '%Meritain Echo UI Self Funded%' OR
                                                    requestData_access_Asset LIKE '%Meritain Rightfax%' OR
                                                    requestData_access_Asset LIKE '%MERITAIN Active Directory%' OR
                                                    requestData_access_Asset LIKE '%AETH Active Directory%' OR
                                                    requestData_access_Asset LIKE '%AETH%' OR
                                                    requestData_access_Asset LIKE '%AETHQ Active Directory%' OR
                                                    requestData_access_Asset LIKE '%Aett%' OR
                                                    requestData_access_Asset LIKE '%Aett Active Directory%' OR
                                                    requestData_access_Asset LIKE '%Corp Active Directory%' OR
                                                    requestData_access_Asset LIKE '%Minute Clinic Active Directory%' OR
                                                    requestData_access_Asset LIKE '%Payflex Active Directory%' OR
                                                    requestData_access_Asset LIKE '%PBM Active Directory%' OR
                                                    requestData_access_Asset LIKE '%Retail Active Directory%' OR
                                                    requestData_access_Asset LIKE '%eLDAP%' OR
                                                    requestData_access_Asset LIKE '%HealthehostT' OR
                                                    requestData_access_Asset LIKE '%RXConnect' OR
                                                    requestData_access_Asset LIKE '%JAMF%' OR
                                                    requestData_access_Asset LIKE '%ICU GROUP%' OR
                                                    requestData_access_Asset LIKE '%Local Unix%' OR
                                                    requestData_access_Asset LIKE '%Meritain DG Prod%' OR
                                                    requestData_access_Asset LIKE '%Quickbase%' OR
                                                    requestData_access_Asset LIKE '%Salesforce NextGen Service Platform - Training%' OR
                                                    requestData_access_Asset LIKE '%Azure Prod Tenant%' OR
                                                    requestData_access_Asset LIKE '%Azure Non Prod Tenant%' OR
                                                    requestData_access_Asset LIKE '%Salesforce NextGen Service Platform%' OR
                                                    requestData_access_Asset LIKE '%HEH%' OR
                                                    requestData_access_Asset LIKE '%AETDMZ%' OR
                                                    requestData_access_Asset IS NULL) THEN 'Automated Add Access' WHEN (requestType LIKE '%addaccounttolocalunixgroup%') 
                                                    THEN 'Automated Add Account to Local Unix Group' WHEN (requestType LIKE '%replicatelocalgrouponunixserver%') 
                                                    THEN 'Automated Replicate Existing Local Group on Unix Server' WHEN (requestType LIKE '%addadgrouptounixserverallowlist%') 
                                                    THEN 'Automated Add Existing Active Directory Group to Allow List for Unix Server' WHEN (requestType LIKE '%modifynonpersonaccount%') AND (additionalData_fulfillmentData_Mail_Sent_To LIKE '' OR
                                                    additionalData_fulfillmentData_Mail_Sent_To IS NULL) AND (requestData_subRequestType LIKE '%addworkstation%' OR
                                                    requestData_subRequestType LIKE '%removeworkstatio%n') AND (ticketData_externalTicketId NOT LIKE '%TASK%' OR
                                                    ticketData_externalTicketId IS NULL) THEN 'Automated Modify Non Person Account Server/Workstation' WHEN (requestType LIKE '%changegroupowner%') AND 
                                                    (additionalData_fulfillmentData_Mail_Sent_To NOT LIKE '%ResearchAD@aetna.com%' OR
                                                    additionalData_fulfillmentData_Mail_Sent_To IS NULL) AND (ticketData_externalTicketId NOT LIKE '%TASK%' OR
                                                    ticketData_externalTicketId IS NULL) THEN 'Automated Change Entitlement Owner' WHEN (requestType LIKE '%changegroupowner%') AND 
                                                    (additionalData_fulfillmentData_Mail_Sent_To NOT LIKE '%ResearchAD@aetna.com%' OR
                                                    additionalData_fulfillmentData_Mail_Sent_To IS NULL) AND (ticketData_externalTicketId LIKE '%TASK%') THEN 'Manual AD Automation Failure' WHEN (requestType LIKE '%changegroupowner%') AND 
                                                    (additionalData_fulfillmentData_Mail_Sent_To NOT LIKE '%ResearchAD@aetna.com%' OR
                                                    additionalData_fulfillmentData_Mail_Sent_To IS NULL) THEN 'Automated Change Entitlement Owner' WHEN (requestType LIKE '%changenpidentityowner%') AND 
                                                    (additionalData_fulfillmentData_Mail_Sent_To LIKE '' OR
                                                    additionalData_fulfillmentData_Mail_Sent_To IS NULL) AND (ticketData_externalTicketId NOT LIKE '%TASK%' OR
                                                    ticketData_externalTicketId IS NULL) THEN 'Automated Change Non Person Identity Owner' WHEN requestType LIKE '%createnonpersonidentity%' AND ((additionalData_fulfillmentData_Mail_Sent_To LIKE '' OR
                                                    additionalData_fulfillmentData_Mail_Sent_To IS NULL) AND (ticketData_externalTicketId NOT LIKE '%TASK%' OR
                                                    ticketData_externalTicketId IS NULL)) THEN 'Automated Create Non Person Identity' WHEN (requestType LIKE '%createazureserviceprincipal%') 
                                                    THEN 'Automated Create Azure Service Principal' WHEN (requestType LIKE '%creategroup%' AND (additionalData_fulfillmentData_Mail_Sent_To LIKE '' OR
                                                    additionalData_fulfillmentData_Mail_Sent_To IS NULL)) AND (ticketData_externalTicketId NOT LIKE '%TASK%' OR
                                                    ticketData_externalTicketId IS NULL) THEN 'Automated Create Group in Asset' WHEN (requestType LIKE '%createlocalunixaccount%') 
                                                    THEN 'Automated Create Local Unix Account' WHEN (requestType LIKE '%addcvsassetsbirthrightaccess%') THEN 'Automated CVS Assets Add Birthright Access' WHEN (requestType LIKE '%changedisplayname%') 
                                                    THEN 'Automated Change Display Name' WHEN (requestType LIKE '%syncgroupstocloudtenants%') THEN 'Automated Sync Groups to Cloud Tenants' WHEN (requestType LIKE '%changesmtpaddress%') 
                                                    THEN 'Automated Change Primary Email Address' WHEN requestType LIKE '%cvsprocessconversions%' THEN 'Automated CVS Contractor to Employee Conversion' WHEN (requestType LIKE '%createnewlocalgrouponunixserver%'
                                                     OR
                                                    (requestType LIKE '%createlocalgrouponserver%' AND requestDesc = 'Create New Local Group on Unix Server')) 
                                                    THEN 'Automated Create New Local Group on Unix Server' WHEN (requestType LIKE '%removelocalgroupfromunixserver%') 
                                                    THEN 'Automated Remove Local Group on Unix Server' WHEN (requestType LIKE '%removeaccountfromlocalunixgroup%') 
                                                    THEN 'Automated Remove Account From Local Group on Unix Server' WHEN (requestType LIKE '%deleteazureserviceprincipal%') 
                                                    THEN 'Automated Delete Azure Service Principal' WHEN (requestType LIKE '%deletegroup%') AND (additionalData_fulfillmentData_Mail_Sent_To IS NULL) AND (asset_additionalData_asset_Name IS NULL OR
                                                    (asset_additionalData_asset_Name NOT LIKE '%AETHQ%' AND asset_additionalData_asset_Name NOT LIKE '%AETH%')) THEN 'Automated Delete Group' WHEN (requestType LIKE '%deletelocalunixaccount%') 
                                                    THEN 'Automated Delete Local Unix Account' WHEN (requestType LIKE '%disableaccount%') AND (additionalData_fulfillmentData_Mail_Sent_To LIKE '' OR
                                                    additionalData_fulfillmentData_Mail_Sent_To IS NULL) THEN 'Automated Disable Account' WHEN (requestType LIKE '%modifyadhoccallcenter%' OR
                                                    requestType LIKE '%modifyadhoclob%') THEN 'Automated Modify Adhoc Call Center for Existing Active GPS Users' WHEN (requestType LIKE '%modifyazureserviceprincipal%') 
                                                    THEN 'Automated Modify Azure Service Principal' WHEN (requestType LIKE '%modifycontractor%') THEN 'Automated Modify Contractor' WHEN (requestType LIKE '%modifygroup%') 
                                                    THEN 'Automated Modify Group in Asset' WHEN (requestType LIKE '%removeexistingactivedirectorygroupfromunixserver%' OR
                                                    requestType LIKE '%removeadgroupfromunixserverallowlist%') THEN 'Automated Remove Existing Active Directory Group from Allow List for Unix Server' WHEN (requestType LIKE '%revokeaccess%') AND 
                                                    (requestData_access_Asset LIKE '%AETT Active Directory%' OR
                                                    requestData_access_Asset LIKE '%Aeth%' OR
                                                    requestData_access_Asset LIKE '%Aethq%' OR
                                                    requestData_access_Asset LIKE '%Azure%' OR
                                                    requestData_access_Asset LIKE '%AETDMZQ Active Directory%' OR
                                                    requestData_access_Asset LIKE '%AETDMZT Active Directory%' OR
                                                    requestData_access_Asset LIKE '%AETDMZ Active Directory%' OR
                                                    requestData_access_Asset LIKE '%Salesforce NextGen Service Platform%' OR
                                                    requestData_access_Asset LIKE '%ICU Group%') AND ((requestData_access_Asset NOT LIKE '%Dataset%' AND requestData_access_Asset NOT LIKE '%IBM Group%' AND 
                                                    requestData_access_Asset NOT LIKE '%PowerH%' AND requestData_access_Asset NOT LIKE '%PowerR%' AND requestData_access_Asset NOT LIKE '%Profiles%' AND 
                                                    requestData_access_Asset NOT LIKE '%Tso System Access%') OR
                                                    requestData_access_Asset IS NULL) THEN 'Automated Revoke Access' WHEN (requestType LIKE '%rolebasedauthupdatedeptmodel%') 
                                                    THEN 'Automated Role Based Authority' WHEN (requestType LIKE '%terminatehcbaccountsystemaccess%') 
                                                    THEN 'Automated Terminate System Access' WHEN (additionalData_fulfillmentData_ZZAccount_Created IS NOT NULL AND additionalData_fulfillmentData_ZZAccount_Created != '') 
                                                    THEN 'Automated ZZ Account Create' WHEN (additionalData_fulfillmentData_Mail_Sent_To LIKE '%ResearchAD@aetna.com%' AND requestType LIKE '%grantaccess%' AND CAST(requestedOn AS DATE) 
                                                    <= '07/31/2023') THEN 'Manual RNA Add Access' WHEN (requestType LIKE '%grantaccess%' AND (requestData_access_Asset NOT LIKE '%RBAC Repository%' OR
                                                    requestData_access_Asset IS NULL) AND (additionalData_fulfillmentData_Mail_Sent_To NOT LIKE '%SecurityS@aetna.com%' OR
                                                    additionalData_fulfillmentData_Mail_Sent_To IS NULL) AND ((requestData_access_Asset NOT LIKE '%Dataset%' AND requestData_access_Asset NOT LIKE '%IBM Group%' AND 
                                                    requestData_access_Asset NOT LIKE '%PowerH%' AND requestData_access_Asset NOT LIKE '%PowerR%' AND requestData_access_Asset NOT LIKE '%Profiles%' AND 
                                                    requestData_access_Asset NOT LIKE '%Tso System Access%') OR
                                                    requestData_access_Asset IS NULL) AND ticketData_externalTicketId LIKE '%TASK%') THEN 'Manual AD Automation Failure' WHEN (additionalData_fulfillmentData_Mail_Sent_To LIKE '%ResearchAD@aetna.com%') 
                                                    AND (requestType LIKE '%changeentitlementowner%' OR
                                                    requestType LIKE '%changegroupowner%') AND CAST(requestedOn AS DATE) <= '07/31/2023' THEN 'Manual RAD Change Entitlement Owner' WHEN (requestType LIKE '%changeentitlementowner%' OR
                                                    requestType LIKE '%changegroupowner%') AND ticketData_externalTicketId LIKE '%TASK%' THEN 'Manual AD Automation Failure' WHEN (requestType LIKE '%changnonpersonidentityowner%' OR
                                                    requestType LIKE '%changenpidentityowner%') AND (additionalData_fulfillmentData_Mail_Sent_To LIKE '%SecurityS@aetna.com%' OR
                                                    ticketData_externalTicketId LIKE '%TASK%') AND CAST(requestedOn AS DATE) <= '07/31/2023' THEN 'Manual Change Non Person Identity Owner' WHEN (requestType LIKE '%changnonpersonidentityowner%' OR
                                                    requestType LIKE '%changenpidentityowner%') AND ticketData_externalTicketId LIKE '%TASK%' AND CAST(requestedOn AS DATE) 
                                                    > '07/31/2023' THEN 'Manual AD Automation Failure' WHEN requestType LIKE '%createnonpersonidentity%' AND (additionalData_fulfillmentData_Mail_Sent_To LIKE '%SecurityS@aetna.com%' OR
                                                    additionalData_fulfillmentData_Mail_Sent_To IS NOT NULL OR
                                                    ticketData_externalTicketId LIKE '%TASK%') AND CAST(requestedOn AS DATE) <= '07/31/2023' THEN 'Manual Create Non Person Identity' WHEN requestType LIKE '%createnonpersonidentity%' AND 
                                                    (ticketData_externalTicketId LIKE '%TASK%') AND CAST(requestedOn AS DATE) 
                                                    > '07/31/2023' THEN 'Manual AD Automation Failure' WHEN (additionalData_fulfillmentData_Mail_Sent_To LIKE '%SecurityS@aetna.com%' AND requestType LIKE '%grantaccess%' AND 
                                                    requestData_access_Asset NOT LIKE '%RBAC Repository%') AND (requestData_access_Asset NOT LIKE '%Dataset%' AND requestData_access_Asset NOT LIKE '%IBM Group%' AND 
                                                    requestData_access_Asset NOT LIKE '%PowerH%' AND requestData_access_Asset NOT LIKE '%PowerR%' AND requestData_access_Asset NOT LIKE '%Profiles%' AND 
                                                    requestData_access_Asset NOT LIKE '%ICU GROUP%' AND requestData_access_Asset NOT LIKE '%TSO System Access%') 
                                                    THEN 'Manual Non Person Add Access' WHEN requestType LIKE '%createdistributionlist%' THEN 'Manual Create Distribution List' WHEN (additionalData_fulfillmentData_Mail_Sent_To LIKE '%SecurityS@aetna.com%'
                                                     OR
                                                    additionalData_fulfillmentData_Mail_Sent_To IS NOT NULL OR
                                                    ticketData_externalTicketId LIKE '%TASK%') AND (requestType LIKE '%creategroup%') 
                                                    THEN 'Manual Create Group in Asset' WHEN requestType LIKE '%createsecuretransportaccount%' THEN 'Manual Create Secure Transport Account' WHEN requestType LIKE '%createserviceaccount%' THEN 'Manual Create Service Account'
                                                     WHEN requestType LIKE '%createsharedmailbox%' THEN 'Manual Create Shared Mailbox' WHEN requestType LIKE '%createtestaccount%' THEN 'Manual Create Test Account' WHEN requestType LIKE '%deleteaccount%'
                                                     THEN 'Manual Delete Account' WHEN requestType LIKE '%deletecomponent%' THEN 'Manual Delete Component' WHEN requestType LIKE '%deletedistributionlist%' THEN 'Manual Delete Email Distribution List' WHEN
                                                     (requestType LIKE '%deletegroup%') AND (additionalData_fulfillmentData_Mail_Sent_To IS NOT NULL OR
                                                    asset_additionalData_asset_Name LIKE '%AETHQ%' OR
                                                    asset_additionalData_asset_Name LIKE '%AETH%') 
                                                    THEN 'Manual Delete Group' WHEN requestType LIKE '%modifycomponent%' THEN 'Manual Modify Component' WHEN (requestType LIKE '%modifynonpersonaccount%') AND 
                                                    (requestData_subRequestType LIKE '%removecommandlineshell%' OR
                                                    requestData_subRequestType LIKE '%addcommandlineshell%') THEN 'Manual Modify Non Person Account Command Shell' WHEN (requestType LIKE '%modifynonpersonaccount%' OR
                                                    requestType LIKE '%modifynonpersonidentity%') AND ((requestData_subRequestType NOT LIKE '%addworkstation%' AND requestData_subRequestType NOT LIKE '%removeworkstation%' AND 
                                                    requestData_subRequestType NOT LIKE '%disableunixaccount%' AND requestData_subRequestType NOT LIKE '%enableunixaccount%') OR
                                                    (requestData_subRequestType IS NULL)) THEN 'Manual Modify Non Person Identity' WHEN (requestType LIKE '%modifynonpersonaccount%') AND (requestData_subRequestType LIKE '%disableunixaccount%' OR
                                                    requestData_subRequestType LIKE '%enableunixaccount%') THEN 'Manual Modify Non person Account Unix Enable/Disable' WHEN (requestType LIKE '%modifynonpersonaccount%') AND 
                                                    (additionalData_fulfillmentData_Mail_Sent_To LIKE '%SecurityS@aetna.com%' OR
                                                    ticketData_externalTicketId LIKE '%TASK%') AND (requestData_subRequestType LIKE '%addworkstation%' OR
                                                    requestData_subRequestType LIKE '%removeworkstation%') 
                                                    THEN 'Manual Modify Non Person Account Server/Workstation' WHEN requestType LIKE '%newcomponent%' THEN 'Manual New Component' WHEN (requestData_access_Asset LIKE '%RBAC Repository%' OR
                                                    asset_additionalData_asset_Name LIKE '%RBAC Repository%') AND (requestType LIKE '%addrbacmodel%' OR
                                                    requestType LIKE '%deleterbacmodel%' OR
                                                    requestType LIKE '%modifyaccess%' OR
                                                    requestType LIKE '%revokeaccess%') 
                                                    THEN 'Manual RBAC Optional Role' WHEN requestType LIKE '%retirenonpersonidentity%' THEN 'Manual Retire Non Person Identity' WHEN (additionalData_fulfillmentData_Mail_Sent_To LIKE '%RequestSecurityServerAccess@aetna.com%')
                                                     THEN 'Non-IAM Manual Group Create' WHEN (additionalData_fulfillmentData_Mail_Sent_To LIKE '%RequestsS3@AETNA.com%') 
                                                    THEN 'Non-IAM Manual Unix' WHEN (requestData_access_Asset LIKE '%RBAC Repository%' AND requestType LIKE '%grantaccess%') 
                                                    THEN 'Mixed RBAC Add/Mod/Del Entitlements' WHEN ((requestData_access_Asset LIKE '%RBAC Repository%' OR
                                                    asset_additionalData_asset_Name LIKE '%RBAC Repository%') AND requestType LIKE '%modifyrbacmodel%') THEN 'Mixed RBAC Change Recipient Model' WHEN (requestType LIKE '%grantaccess%' OR
                                                    requestType LIKE '%revokeaccess%') AND (requestData_access_Asset LIKE '%Dataset%' OR
                                                    requestData_access_Asset LIKE '%IBM Group%' OR
                                                    requestData_access_Asset LIKE '%PowerH%' OR
                                                    requestData_access_Asset LIKE '%PowerR%' OR
                                                    requestData_access_Asset LIKE '%Profiles%' OR
                                                    requestData_access_Asset LIKE '%Tso System Access%' OR
                                                    requestData_access_Asset IS NULL) THEN 'Mixed Mainframe Resource' WHEN (requestData_access_Asset LIKE '%Personas%') THEN 'Mixed Personas' ELSE 'Uncategorized' END AS Category, 
                                                    CAST(CASE WHEN (closedOn IS NOT NULL) THEN CASE WHEN (additionalData_fulfillmentData_Mail_Sent_On != '' AND additionalData_fulfillmentData_Mail_Sent_On IS NOT NULL) 
                                                    THEN CASE WHEN (closedOn IS NOT NULL AND additionalData_fulfillmentData_Mail_Sent_On_Date IS NOT NULL) THEN CAST(CAST(DATEDIFF(DAY, additionalData_fulfillmentData_Mail_Sent_On_Date, closedOn) 
                                                    AS INT) - (2 * (DATEDIFF(WEEK, additionalData_fulfillmentData_Mail_Sent_On_Date, closedON) + 1)) AS VARCHAR(MAX)) ELSE '0' END ELSE CASE WHEN (closedOn IS NOT NULL AND 
                                                    additionalData_fulfillmentData_Mail_Sent_On_Date != '' AND additionalData_fulfillmentData_Mail_Sent_On_Date IS NOT NULL AND additionalData_fulfillmentData_Mail_Sent_On_Date != 'Incomplete') 
                                                    THEN CASE WHEN (closedOn IS NOT NULL AND additionalData_fulfillmentData_Mail_Sent_On_Date != '' AND additionalData_fulfillmentData_Mail_Sent_On_Date IS NOT NULL AND 
                                                    additionalData_fulfillmentData_Mail_Sent_On_Date != 'Incomplete') THEN CAST(DATEDIFF(DAY, additionalData_fulfillmentData_Mail_Sent_On_Date, closedOn) AS varchar(MAX)) 
                                                    ELSE '0' END ELSE 'No SLA' END END ELSE 'Incomplete' END AS varchar(MAX)) AS SLADays
                          FROM            dbo.IAMHAccessNowOperations) AS ano LEFT OUTER JOIN
                         dbo.IAMHCostCenter ON ano.CostCenter = dbo.IAMHCostCenter.CostCenter OR ano.CostCenter LIKE '%' + dbo.IAMHCostCenter.S4CostCenter + '%'
GO
/****** Object:  View [dbo].[IAMHFactoolSystemsView]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHFactoolSystemsView] AS

SELECT        
	CreateDate AS DateRange, 
	value AS Application, 
	Sum(CONVERT(INT, TotalUsers)) AS ApplicationCount
FROM            
	IAMHFactoolJoinedView CROSS APPLY(
		SELECT value, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS rn
	FROM            STRING_SPLIT(Systems, ',')
) AS Substrings
WHERE        
	value <> '' 
	AND RequestState <> 'Cancelled'
GROUP BY 
	CreateDate, 
	value
GO
/****** Object:  Table [dbo].[IAMHMORApplicationCount]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHMORApplicationCount](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[SystemId] [varchar](200) NOT NULL,
	[DateRange] [datetime] NULL,
	[SubSystem] [varchar](200) NULL,
	[Application] [varchar](200) NULL,
	[ApplicationCount] [bigint] NULL,
	[AssignmentGroup] [varchar](200) NULL,
	[AssignedTo] [varchar](200) NULL,
	[BusinessUnit] [varchar](200) NULL,
	[WelcomeSeasonCount] [bigint] NULL,
	[MetSLACount] [bigint] NULL,
 CONSTRAINT [PK_IAMHMORApplicationCount] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[IAMHMORApplicationMetricsView]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHMORApplicationMetricsView] AS 

SELECT        
      [DateRange],
      [SubSystem],
      [Application],
      [AssignmentGroup],
      [AssignedTo],
      [BusinessUnit],
      [ApplicationCount],
      [WelcomeSeasonCount],
      [MetSLACount]
  
FROM [dbo].[IAMHMORApplicationCount]
WHERE 
    NOT (
        ([SubSystem] IN ('RMR Manual', 'RMR Automated') AND [DateRange] < dbo.GetRMRExclusionDate())
        OR 
        ([SubSystem] = 'AccessNow Mixed' AND [Application] IN ('Mixed Personas', 'Mixed RBAC Add/Mod/Del Entitlements', 'Mixed RBAC Change Recipient Model') AND [DateRange] > dbo.GetRMRChangeDate())
        OR
        ([SubSystem] = 'CAMS Provisioning' AND [DateRange] < dbo.GetRMRExclusionDate())
        )
GO
/****** Object:  View [dbo].[IAMHMORMetricsViewExperimental]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHMORMetricsViewExperimental] AS 

SELECT
        dt.DateRange,
        CASE
          WHEN subs.Subsystem = 'IAM Mailbox' THEN 'IAM Mailbox Provisioning' 
          ELSE subs.Subsystem
        END AS System,
        CASE 
          WHEN subs.Subsystem = 'AccessNow' THEN dt.AccessNowTableCount
          WHEN subs.Subsystem = 'ServiceNow Provisioning' THEN dt.ProvisioningTableCount
          WHEN subs.Subsystem = 'ServiceNow Incidents' THEN dt.IncidentsTableCount
          WHEN subs.Subsystem = 'IAM Mailbox' THEN dt.MailboxTableCount
          WHEN subs.Subsystem = 'RMR' AND CAST(dt.DateRange as Datetime) > '2023-12-31' THEN dt.RMRTotalCount
          WHEN subs.Subsystem = 'CAMS' AND CAST(dt.DateRange as Datetime) > '2023-12-31'  THEN dt.CAMSTotalCount
        END As TotalCount,
        CASE 
          WHEN subs.Subsystem = 'AccessNow' THEN dt.AccessNowManualCount
          WHEN subs.Subsystem = 'ServiceNow Provisioning' THEN dt.ProvisioningTableCount
          WHEN subs.Subsystem = 'ServiceNow Incidents' THEN dt.IncidentsTableCount
          WHEN subs.Subsystem = 'IAM Mailbox' THEN dt.MailboxTableCount
          WHEN subs.Subsystem = 'RMR' AND CAST(dt.DateRange as Datetime) > '2023-12-31' THEN dt.RMRManualCount
          WHEN subs.Subsystem = 'CAMS' AND CAST(dt.DateRange as Datetime) > '2023-12-31'  THEN dt.CAMSTotalCount
        END As ManualCount,
        CASE 
          WHEN subs.Subsystem = 'AccessNow' THEN dt.AccessNowAutomatedCount
          WHEN subs.Subsystem = 'RMR' AND CAST(dt.DateRange as Datetime) > '2023-12-31' THEN dt.RMRAutomatedCount
        END As AutomatedCount,
        CASE 
          WHEN subs.Subsystem = 'AccessNow' THEN dt.AccessNowMixedCount ELSE 0
        END As MixedCount,
        CASE 
          WHEN subs.Subsystem = 'AccessNow' THEN dt.AccessNowSLAEligibleCount
          WHEN subs.Subsystem = 'ServiceNow Provisioning' THEN dt.ProvisioningTableCount
          WHEN subs.Subsystem = 'ServiceNow Incidents' THEN dt.IncidentsTableCount
          WHEN subs.Subsystem = 'IAM Mailbox' THEN dt.MailboxTableCount
          WHEN subs.Subsystem = 'RMR' AND CAST(dt.DateRange as Datetime) > '2023-12-31' THEN dt.RMRTotalCount
        END As SLAEligibleCount,
        CASE 
          WHEN subs.Subsystem = 'AccessNow' THEN dt.AccessNowSLACount
          WHEN subs.Subsystem = 'ServiceNow Provisioning' THEN dt.ProvisioningSLACount
          WHEN subs.Subsystem = 'ServiceNow Incidents' THEN dt.IncidentsSLACount
          WHEN subs.Subsystem = 'IAM Mailbox' THEN dt.MailboxSLACount
          WHEN subs.Subsystem = 'RMR' AND CAST(dt.DateRange as Datetime) > '2023-12-31' THEN dt.RMRINSLACount
        END As SLAMetCount,
        CASE 
          WHEN subs.Subsystem = 'AccessNow' THEN dt.AccessNowSLAPercentage
          WHEN subs.Subsystem = 'ServiceNow Provisioning' THEN dt.ProvisioningSLAPercentage
          WHEN subs.Subsystem = 'ServiceNow Incidents' THEN dt.IncidentsSLAPercentage
          WHEN subs.Subsystem = 'IAM Mailbox' THEN dt.MailboxSLAPercentage
          WHEN subs.Subsystem = 'RMR' AND CAST(dt.DateRange as Datetime) > '2023-12-31' THEN dt.RMRSLAPercentage
        END As SLAPercentage
FROM 
     (
        SELECT DISTINCT
                DateRange, 
                AccessNowCount As AccessNowTableCount, 
                AccessNowManualCount, 
                AccessNowAutomatedCount, 
                AccessNowMixedCount, 
                AccessNowInSLACount As AccessNowSLACount, 
                AccessNowSLAEligibleCount, 
                AccessNowSLAPercentage, 
                ProvisioningCount AS ProvisioningTableCount, 
                ProvisioningSLACount, 
                ProvisioningSLAPercentage, 
                IncidentsTableCount, 
                IncidentsINSLACount As IncidentsSLACount, 
                IncidentsSLAPercentage, 
                MailboxTableCount, 
                MailboxInSLACount AS MailboxSLACount, 
                MailboxSLAPercentage, 
                RMRTotalCount,
                RMRManualCount,
                RMRAutomatedCount,
                RMRINSLACount,
                RMRSLAPercentage,
                CAMSTotalCount,
                IncidentsTableCount + ProvisioningCount AS ITSCSubtotalTableCount, 
                IncidentsTableCount + ProvisioningCount + MailboxTableCount AS Total_Non_AccessNow_Count, 
                 AccessNowAutomatedCount AS AutomatedCount, 
                 AccessNowManualCount + ProvisioningCount + IncidentsTableCount + MailboxTableCount + RMRManualCount + CAMSTotalCount AS ManualCount, 
                (AccessNowSLAPercentage + IncidentsSLAPercentage + ProvisioningSLAPercentage + MailboxSLAPercentage + RMRSLAPercentage) / 5 AS AverageSLAPercentage, 
                AccessNowCount + ProvisioningCount + IncidentsTableCount + MailboxTableCount + RMRTotalCount + CAMSTotalCount  AS TotalTableCount
        FROM(
                SELECT        
                iD, 
                DateRange, 
                AccessNowCount, 
                AccessNowManualCount, 
                AccessNowAutomatedCount, 
                AccessNowMixedCount, 
                AccessNowInSLACount, 
                AccessNowSLAEligibleCount, 
                AccessNowSLAPercentage, 
                ProvisioningCount, 
                ProvisioningSLACount, 
                ProvisioningSLAPercentage, 
                IncidentsTableCount, 
                IncidentsINSLACount, 
                IncidentsSLAPercentage, 
                MailboxTableCount, 
                MailboxInSLACount, 
                MailboxSLAPercentage,
                RMRTotalCount,
                RMRManualCount,
                RMRAutomatedCount,
                [RMRINSLACount],
                [RMRSLAPercentage],
                CAMSTotalCount
                FROM  dbo.IAMHMORMetricsTable
        ) AS subquery
     ) AS dt
CROSS JOIN 
   (
        SELECT 'AccessNow' As SubSystem
        UNION ALL
        SELECT 'ServiceNow Provisioning' As SubSystem
        UNION ALL
        SELECT 'ServiceNow Incidents' As SubSystem
        UNION ALL
        SELECT 'IAM Mailbox' As SubSystem
        UNION ALL
        SELECT 'RMR' As SubSystem
        UNION ALL
        SELECT 'CAMS' As SubSystem
   ) AS subs
WHERE 
(subs.Subsystem <> 'RMR' OR (subs.Subsystem = 'RMR' AND CAST(dt.DateRange as Datetime) > '2023-12-31' ) )
AND 
(subs.Subsystem <> 'CAMS' OR (subs.Subsystem = 'CAMS' AND CAST(dt.DateRange as Datetime) > '2023-12-31' ) )
        
GO
/****** Object:  View [dbo].[IAMHMORApplicationMetricsViewExperimental]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IAMHMORApplicationMetricsViewExperimental] AS 

SELECT        
      [DateRange],
      [SubSystem],
      [Application],
      [ApplicationCount],
      [AssignmentGroup]
FROM [dbo].[IAMHMORApplicationCount]
WHERE 
    NOT (
        ([SubSystem] IN ('RMR Manual', 'RMR Automated') AND [DateRange] < '2024-01-01')
        OR 
        ([SubSystem] = 'AccessNow Mixed' AND [Application] IN ('Mixed Personas', 'Mixed RBAC Add/Mod/Del Entitlements', 'Mixed RBAC Change Recipient Model') AND [DateRange] > '2023-12-31')
        OR
        ([SubSystem] = 'CAMS Provisioning' AND [DateRange] < '2024-01-01')
        )
GO
/****** Object:  Table [dbo].[IAMHAccessNowClosedTickets]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHAccessNowClosedTickets](
	[Id] [int] NOT NULL,
	[TicketNumber] [nvarchar](max) NULL,
	[FinishedState] [varchar](max) NOT NULL,
	[Comments] [varchar](max) NULL,
	[ClosedBy] [varchar](max) NULL,
	[DateClosed] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHAccessNowHistory]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHAccessNowHistory](
	[HistoryID] [int] NOT NULL,
	[ModifiedBy] [varchar](max) NULL,
	[ModifiedDate] [varchar](max) NULL,
	[Changes] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHAuthorizationSettings]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHAuthorizationSettings](
	[Id] [int] NOT NULL,
	[Type] [nvarchar](max) NULL,
	[Rule] [nvarchar](max) NULL,
	[Value] [nvarchar](max) NULL,
	[ReportsAssignmentGroup] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHClosedApplicationCount]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHClosedApplicationCount](
	[SystemId] [varchar](200) NOT NULL,
	[SubSystem] [nvarchar](200) NULL,
	[TicketNumber] [nvarchar](200) NULL,
	[ClosedDateRange] [datetime] NULL,
	[CreatedDateRange] [datetime] NULL,
	[SLADays] [nvarchar](200) NULL,
	[Application] [nvarchar](200) NULL,
	[AssignmentGroup] [nvarchar](200) NULL,
	[AssignmentGroupManager] [nvarchar](200) NULL,
	[AssignedTo] [nvarchar](200) NULL,
	[AssignedToManager] [nvarchar](200) NULL,
	[BusinessUnit] [nvarchar](200) NULL,
	[WelcomeSeasonFlag] [nvarchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHConfig]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHConfig](
	[Id] [int] NOT NULL,
	[Setting] [nvarchar](max) NULL,
	[Value] [varchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHFactoolConfigDefectReasons]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHFactoolConfigDefectReasons](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Value] [varchar](50) NULL,
	[DisplayOrder] [varchar](50) NULL,
	[ModifiedBy] [varchar](50) NULL,
	[Modified] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHFactoolConfigFormType]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHFactoolConfigFormType](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Value] [varchar](50) NULL,
	[DisplayOrder] [varchar](50) NULL,
	[ModifiedBy] [varchar](50) NULL,
	[Modified] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHFactoolConfigReplyType]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHFactoolConfigReplyType](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Value] [varchar](50) NULL,
	[DisplayOrder] [varchar](50) NULL,
	[ModifiedBy] [varchar](50) NULL,
	[Modified] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHFactoolConfigRequestType]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHFactoolConfigRequestType](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Value] [varchar](50) NULL,
	[DisplayOrder] [varchar](50) NULL,
	[ModifiedBy] [varchar](50) NULL,
	[Modified] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHFactoolConfigSystems]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHFactoolConfigSystems](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Value] [varchar](50) NULL,
	[DisplayOrder] [varchar](50) NULL,
	[ModifiedBy] [varchar](50) NULL,
	[Modified] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHFactoolRequestHistory]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHFactoolRequestHistory](
	[HistoryID] [int] NOT NULL,
	[ReferenceNumber] [varchar](max) NULL,
	[DisplayName] [varchar](max) NULL,
	[ModifiedTick] [varchar](max) NULL,
	[DateModified] [varchar](max) NULL,
	[State] [varchar](max) NULL,
	[Changes] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHFactoolRequestNumber]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHFactoolRequestNumber](
	[Id] [int] NOT NULL,
	[ReferenceDate] [nvarchar](max) NULL,
	[Sequence] [varchar](50) NULL,
	[ReferenceSequence] [varchar](50) NULL,
	[ReferenceNumber] [varchar](50) NULL,
	[PreviousReferenceNumber] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHFactoolRequestSyncHistory]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHFactoolRequestSyncHistory](
	[Id] [int] NOT NULL,
	[SyncTime] [nvarchar](max) NULL,
	[DisplayName] [varchar](max) NULL,
	[Result] [varchar](max) NULL,
	[Subject] [varchar](max) NULL,
	[Message] [varchar](max) NULL,
	[Body] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHFeedback]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHFeedback](
	[iamf_reqid] [float] NOT NULL,
	[iamf_requestType] [nchar](10) NULL,
	[iamf_request] [nvarchar](max) NULL,
	[iamf_requestor] [nvarchar](50) NULL,
	[iamf_requestdate] [nvarchar](50) NULL,
	[iamf_updatedate] [nvarchar](50) NULL,
	[iamf_requeststatus] [nvarchar](50) NULL,
	[iamf_requestupdate] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHGroups]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHGroups](
	[iamhg_id] [int] NOT NULL,
	[iamhg_gid] [nvarchar](max) NULL,
	[iamhg_group] [nvarchar](max) NOT NULL,
	[iamhg_lob] [nvarchar](max) NULL,
	[iamhg_history] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHKGroups]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHKGroups](
	[iamhkg_id] [int] NOT NULL,
	[iamhkg_gid] [float] NULL,
	[iamhkg_group] [varchar](max) NULL,
	[iamhkg_comments] [varchar](max) NULL,
	[iamhkg_servers] [varchar](max) NULL,
	[iamhkg_history] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHKServers]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHKServers](
	[iamhks_id] [int] NOT NULL,
	[iamhks_servername] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHKUsers]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHKUsers](
	[iamhku_id] [int] NOT NULL,
	[iamhku_uid] [float] NULL,
	[iamhku_logid] [varchar](max) NULL,
	[iamhku_empid] [varchar](max) NULL,
	[iamhku_adid] [varchar](max) NULL,
	[iamhku_name] [varchar](max) NULL,
	[iamhku_comments] [varchar](max) NULL,
	[iamhku_servers] [varchar](max) NULL,
	[iamhku_history] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHLog]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHLog](
	[Id] [int] NOT NULL,
	[Message] [nvarchar](max) NULL,
	[TimeStamp] [datetimeoffset](7) NOT NULL,
	[CurrentUser] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHServiceCatalog]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHServiceCatalog](
	[ID] [float] NOT NULL,
	[Services] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[RequestSource] [nvarchar](255) NULL,
	[AssignmentGroup] [nvarchar](255) NULL,
	[ExpediteProcess] [nvarchar](255) NULL,
	[SLA] [nvarchar](255) NULL,
	[ArcherAppID] [nvarchar](255) NULL,
	[ITPMAppID] [nvarchar](255) NULL,
	[Hints] [nvarchar](max) NULL,
	[Tasks] [nvarchar](255) NULL,
	[Domain] [nvarchar](255) NULL,
	[Article] [nvarchar](255) NULL,
	[ProvisioningTeam] [nvarchar](255) NULL,
	[URL] [nvarchar](255) NULL,
	[AutomationStatus] [nvarchar](255) NULL,
	[Environment] [nvarchar](255) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHServiceCatalogAssignmentGroups]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHServiceCatalogAssignmentGroups](
	[Id] [int] NOT NULL,
	[GroupName] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHServiceCatalogBackup]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHServiceCatalogBackup](
	[ID] [int] NOT NULL,
	[Services] [varchar](max) NULL,
	[Description] [varchar](max) NULL,
	[RequestSource] [varchar](max) NULL,
	[AssignmentGroup] [varchar](max) NULL,
	[ExpediteProcess] [varchar](max) NULL,
	[SLA] [varchar](max) NULL,
	[ArcherAppID] [varchar](max) NULL,
	[ITPMAppID] [varchar](max) NULL,
	[Hints] [varchar](max) NULL,
	[Tasks] [varchar](max) NULL,
	[Domain] [varchar](max) NULL,
	[Article] [varchar](max) NULL,
	[ProvisioningTeam] [varchar](max) NULL,
	[URL] [varchar](max) NULL,
	[AutomationStatus] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHServiceCatalogEnvironments]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHServiceCatalogEnvironments](
	[Id] [int] NOT NULL,
	[EnvironmentName] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHServiceCatalogSources]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHServiceCatalogSources](
	[Id] [int] NOT NULL,
	[RequestSource] [nvarchar](max) NULL,
	[URL] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHUserConfiguration]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHUserConfiguration](
	[Id] [int] NOT NULL,
	[Username] [nvarchar](max) NOT NULL,
	[FontScale] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHUserDirectory]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHUserDirectory](
	[sys_id] [varchar](50) NULL,
	[UserName] [varchar](100) NULL,
	[UserId] [varchar](50) NULL,
	[UserEID] [varchar](50) NULL,
	[UserDepartment] [varchar](50) NULL,
	[Manager] [varchar](100) NULL,
	[AssignmentGroup] [varbinary](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IAMHUsers]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IAMHUsers](
	[iamhu_id] [int] NOT NULL,
	[iamhu_uid] [float] NULL,
	[iamhu_logid] [nvarchar](max) NULL,
	[iamhu_lob] [nvarchar](50) NULL,
	[iamhu_name] [nvarchar](max) NULL,
	[iamhu_adid] [nvarchar](50) NULL,
	[iamhu_empid] [nvarchar](max) NULL,
	[iamhu_comments] [nvarchar](max) NULL,
	[iamhu_history] [nvarchar](max) NULL,
	[iamhu_queue] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[CamsCompletedItemsProcedure]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Olson, Christopher>
-- Create date: <11/02/2023>
-- Description:	<RMR MOR Procedure Update>
-- =============================================
CREATE PROCEDURE [dbo].[CamsCompletedItemsProcedure]
	-- Add the parameters for the stored procedure here
		@monthSelection INT  ,
		@yearSelection INT 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		SELECT
		  AccessName,
		  COUNT(DISTINCT CASE WHEN IsWorkQueue = 0 THEN SubRequestID END) AS [Work Queue False],
		  COUNT(DISTINCT CASE WHEN IsWorkQueue = 1 THEN SubRequestID END) AS [Work Queue True],
		  COUNT(DISTINCT SubRequestID) AS Total,
		  SUM(COUNT(DISTINCT SubRequestID)) OVER () AS [Total Sum],
		  SUM(COUNT(DISTINCT CASE WHEN IsWorkQueue = 1 THEN SubRequestID END)) OVER () AS [Total IsWorkQueueSum Sum]
		FROM IAMHCamsData
		WHERE MONTH(RequestDate) = @monthSelection 
			  AND YEAR(RequestDate) = @yearSelection
		GROUP BY AccessName;
END
GO
/****** Object:  StoredProcedure [dbo].[MORAccessNowProcedure]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Olson, Christopher
-- Create date: 09/15/2023
-- Description:	MOR AccessNow Key Metrics Procedure
-- =============================================
CREATE PROCEDURE [dbo].[MORAccessNowProcedure]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SEELECT statements.
	SET NOCOUNT ON;
MERGE INTO IAMHMORMetricsTable AS Target
USING (


SELECT 
	AccessNowDateRange AS DateRange,
	AccessNowCount AS AccessNowCount,
	AccessNowManualCount AS AccessNowManualCount,
	AccessNowAutomatedCount AS AccessNowAutomatedCount,
	AccessNowMixedCount AS AccessNowMixedCount,
	AccessNowInSLACount AS AccessNowInSLACount,
	AccessNowSLAEligibleCount AS AccessNowSLAEligibleCount,
	AccessNowSLAPercentage AS AccessNowSLAPercentage

FROM 
(
	SELECT
	FORMAT(AccessNowTable.requested_on, 'yyyy-MM-01 00:00:00.000') AS AccessNowDateRange,
	COUNT(AccessNowTable.request_id) As AccessNowCount,
	SUM(CASE WHEN AccessNowTable.Type = 'Manual' THEN 1 ELSE 0 END) As AccessNowManualCount,
	SUM(CASE WHEN AccessNowTable.Type = 'Automated' THEN 1 ELSE 0 END) As AccessNowAutomatedCount,
	SUM(CASE WHEN AccessNowTable.Type = 'Mixed' THEN 1 ELSE 0 END) As AccessNowMixedCount,
	SUM(CASE WHEN (AccessNowTable.SLADays != 'No SLA' AND AccessNowTable.SLADays != 'Incomplete') THEN 1 ELSE 0 END) As AccessNowSLAEligibleCount,
	SUM(CASE WHEN (AccessNowTable.SLADays != 'No SLA' AND AccessNowTable.SLADays != 'Incomplete' AND AccessNowTable.SLADays <= 5) THEN 1 ELSE 0 END) As AccessNowInSLACount,
	STR(ROUND((CAST(SUM(CASE WHEN (AccessNowTable.SLADays != 'No SLA' AND AccessNowTable.SLADays != 'Incomplete' AND AccessNowTable.SLADays <= 5) THEN 1 ELSE 0 END) AS decimal) 
	/ NULLIF(CAST(SUM(CASE WHEN (AccessNowTable.SLADays != 'No SLA' AND AccessNowTable.SLADays != 'Incomplete') THEN 1 ELSE 0 END) AS decimal), 0)) * 100, 2, 1), 4, 2)
	As AccessNowSLAPercentage

     FROM
	(
	  --Region AccessNow Selection View
		SELECT
		ano.request_Id AS request_id,
		ano.requested_on AS requested_on,  
		ano.closed_On AS closed_on,
		ano.SLADays AS SLADays,
		ano.Type,
		ano.ExternalSystemType

		--Select Innner ano.Table from dbo.IAMHAccessNowOperations 
		FROM
		( Select 

			request_id,
			requested_on,
			closed_on,
			SLADays,
			Type,
			ExternalSystemType

		FROM dbo.IAMHAccessNowOperationsView
		WHERE CAST(requested_on as DateTime) > '06-30-2022 23:59:59' 
		AND (ExternalSystemType ='Access Now' or ExternalSystemType is null)
		) ano
	) AS AccessNowTable
     
	GROUP BY
		FORMAT(requested_On,'yyyy-MM-01 00:00:00.000')
) AS Subquery

) AS Source on Target.DateRange = Source.DateRange
WHEN MATCHED THEN
    UPDATE SET
        Target.AccessNowCount = Source.AccessNowCount,
        Target.AccessNowManualCount = Source.AccessNowManualCount,
        Target.AccessNowAutomatedCount = Source.AccessNowAutomatedCount,
        Target.AccessNowMixedCount = Source.AccessNowMixedCount,
        Target.AccessNowInSLACount = Source.AccessNowInSLACount,
        Target.AccessNowSLAEligibleCount = Source.AccessNowSLAEligibleCount,
        Target.AccessNowSLAPercentage = Source.AccessNowSLAPercentage
WHEN NOT MATCHED BY TARGET AND NOT EXISTS (
    SELECT 1
    FROM IAMHMORMetricsTable AS Existing
    WHERE Existing.DateRange = Source.DateRange
)
    THEN
    INSERT (DateRange, AccessNowCount, AccessNowManualCount, AccessNowAutomatedCount, AccessNowMixedCount, AccessNowInSLACount, AccessNowSLAEligibleCount, AccessNowSLAPercentage)
    VALUES (Source.DateRange, Source.AccessNowCount, Source.AccessNowManualCount, Source.AccessNowAutomatedCount, Source.AccessNowMixedCount, Source.AccessNowInSLACount, Source.AccessNowSLAEligibleCount, Source.AccessNowSLAPercentage);

END
GO
/****** Object:  StoredProcedure [dbo].[MORApplicationCountProcedure]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      <Olson, Christopher>
-- Create date: <12/15/2023>
-- Description: <MOR Application Count Update Procedure>
CREATE PROCEDURE [dbo].[MORApplicationCountProcedure]
AS
BEGIN

MERGE INTO IAMHMORApplicationCount AS Target
USING (

    SELECT        
    CONCAT(DateRange, '_',  SubSystem, '_',  Application, '_',  AssignmentGroup, '_',  AssignedTo, '_',  BusinessUnit) AS SystemID,
    CAST(DateRange AS DateTime) AS DateRange, 
    SubSystem, 
    Application, 
    AssignmentGroup,
    AssignedTo,
    BusinessUnit,
    SUM(ApplicationCount) AS ApplicationCount,
    SUM(WelcomeSeasonCount) As WelcomeSeasonCount,
    SUM(MetSLACount) AS MetSLACount

    FROM            
        (   
            SELECT        
            FORMAT([sys_created_on], 'yyyy-MM-01') AS DateRange,
            'ServiceNow Provisioning' AS SubSystem, 
            ISNULL([request_item.cat_item], '') AS Application,
            assignment_group AS AssignmentGroup,
            [assigned_to] AS AssignedTo,
            requested_for_BusinessUnit As BusinessUnit,
            SUM(CASE WHEN WelcomeSeasonFlag = 'True' THEN 1 ELSE 0 END) AS WelcomeSeasonCount,
            SUM(CASE WHEN [Assignment_Group_Days] < 6 THEN 1 ELSE 0 END) AS MetSLACount,
            COUNT(ISNULL([request_item.cat_item], '')) AS ApplicationCount
            FROM dbo.IAMHSNOWProvisioningView
            WHERE 
                (Exported_Outside_IAM = 'EIS IAM')
                AND CAST(sys_created_on AS DateTime) > '06-30-2022 23:59:59'
            GROUP BY FORMAT([sys_created_on], 'yyyy-MM-01'), [request_item.cat_item], assignment_group, requested_for_BusinessUnit, [assigned_to]
            
            UNION ALL

            SELECT      
            FORMAT([Created], 'yyyy-MM-01') AS DateRange, 
            'ServiceNow Incidents' AS SubSystem, 
            CASE
                WHEN [Configuration item] = 'Authenticator App'
                THEN 'Authenticator App'
                ELSE  ISNULL([Configuration item], '')
            END AS Application,
            [Assignment group] AS AssignmentGroup,
            [Assigned to] AS AssignedTo, 
            [Opened By Business Unit] AS BusinessUnit,
            0 AS WelcomeSeasonCount,
            SUM(CASE WHEN [Assignment_Group_Days] < 6 THEN 1 ELSE 0 END) AS MetSLACount,
            COUNT(ISNULL([Configuration item], '')) AS ApplicationCount
            FROM dbo.IAMHSNOWIncidentsView
            WHERE 
                (Exported_Outside_IAM = 'EIS IAM')
                AND CAST(Created AS DateTime) > '06-30-2022'
            GROUP BY FORMAT([Created], 'yyyy-MM-01'), [Configuration item], [Assignment group], [Opened By Business Unit], [Assigned to]
     
            UNION ALL
            
            SELECT     
            FORMAT(creation_date, 'yyyy-MM-01') AS DateRange, 
            CASE
                WHEN last_updated_by = 'AUTOCL' THEN 'RMR Automated'
                ELSE 'RMR Manual'
            END AS SubSystem,
            appGroup AS Application, 
            LastUpdatedByFocusArea AS AssignmentGroup,
            LastUpdatedByName AS AssignedTo,
            'None' AS BusinessUnit,
            0 AS WelcomeSeasonCount,
            SUM(CASE WHEN [TimeSpan_Days] < 6 THEN 1 ELSE 0 END) AS MetSLACount,
            COUNT(appGroup) AS ApplicationCount
            FROM dbo.IAMHRMRDataView
            WHERE (appGroup IS NOT NULL) 
            AND CAST(creation_date AS DateTime) > '06-30-2022 23:59:59'
            GROUP BY FORMAT(creation_date, 'yyyy-MM-01'), appGroup, last_updated_by, LastUpdatedByFocusArea, LastUpdatedByName

            UNION ALL
            
             SELECT        
             FORMAT(RequestDate, 'yyyy-MM-01') AS DateRange,
            'CAMS Provisioning' AS SubSystem,
            AccessName AS Application, 
            'None' AS AssignmentGroup,
            'None' AS AssignedTo,
            'None' AS BusinessUnit,
            0 AS WelcomeSeasonCount,
            0 AS MetSLACount,
            COUNT(AccessName) AS ApplicationCount
            FROM dbo.IAMHCamsDataView
            WHERE (AccessName IS NOT NULL) 
            AND CAST(RequestDate AS DateTime) > '06-30-2022 23:59:59'
            AND IsWorkQueue = 'Provisioned by OPS'
            GROUP BY FORMAT(RequestDate, 'yyyy-MM-01'), AccessName

            UNION ALL
            
            SELECT 
            FORMAT( CAST(DateRange AS DateTime), 'yyyy-MM-01') AS DateRange,
            'IAM Mailbox' AS SubSystem, 
            Application, 
            'None' AS AssignmentGroup,
            'None' AS AssignedTo,
            'None' AS BusinessUnit,
            0 AS WelcomeSeasonCount,
            0 AS MetSLACount,
            SUM(CONVERT(INT, ApplicationCount)) AS ApplicationCount
            FROM dbo.IAMHFactoolSystemsView
            Where 
            CAST(DateRange AS DateTime) > '06-30-2022 23:59:59'
            GROUP BY FORMAT(CAST(DateRange AS DateTime), 'yyyy-MM-01'), Application

            UNION ALL
            
            SELECT        
            FORMAT(requested_on, 'yyyy-MM-01') AS DateRange, 
            CASE
                WHEN Type = 'Manual' THEN 'AccessNow Manual'
                WHEN Type = 'Mixed' THEN 'AccessNow Mixed'
                WHEN (Type = 'Automated' OR Type= 'Uncategorized') THEN 'AccessNow Automated'
            END AS SubSystem,
            Category AS Application, 
            'None' AS AssignmentGroup,
            'None' AS AssignedTo,
            'None' AS BusinessUnit,
            0 AS WelcomeSeasonCount,
            0 AS MetSLACount,
            COUNT(Category) AS ApplicationCount
            FROM dbo.IAMHAccessNowOperationsView
            WHERE (Category IS NOT NULL) 
            and Type <> 'Rejected'
            AND (ExternalSystemType <> 'SNOW_Task')
            AND CAST(requested_on AS DateTime) > '06-30-2022 23:59:59'
            GROUP BY FORMAT(requested_on, 'yyyy-MM-01'), Category, Type

         ) AS subquery

    GROUP BY DateRange, SubSystem, Application, AssignmentGroup, BusinessUnit, AssignedTo
) AS Source ON Target.SystemID = Source.SystemID
WHEN MATCHED THEN
    UPDATE SET
        Target.DateRange = Source.DateRange,
        Target.SubSystem = Source.SubSystem,
        Target.Application = Source.Application,
        Target.ApplicationCount = Source.ApplicationCount,
        Target.AssignmentGroup = Source.AssignmentGroup,
        Target.AssignedTo = Source.AssignedTo,
        Target.BusinessUnit = Source.BusinessUnit,
        Target.WelcomeSeasonCount = Source.WelcomeSeasonCount,
        Target.MetSLACount = Source.MetSLACount
WHEN NOT MATCHED BY TARGET THEN
    INSERT (SystemID, DateRange, SubSystem, Application, ApplicationCount, AssignmentGroup, AssignedTo, BusinessUnit, WelcomeSeasonCount, MetSLACount)
    VALUES (Source.SystemID, Source.DateRange, Source.SubSystem, Source.Application, Source.ApplicationCount, 
        Source.AssignmentGroup, Source.AssignedTo, Source.BusinessUnit, Source.WelcomeSeasonCount, Source.MetSLACount)

WHEN NOT MATCHED BY SOURCE THEN
    DELETE;
END
GO
/****** Object:  StoredProcedure [dbo].[MORIncidentsProcedure]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Olson, Christopher
-- Create date: 09/15/2023
-- Description:	MOR Incidents Key Metrics Procedure
-- =============================================
CREATE PROCEDURE [dbo].[MORIncidentsProcedure]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
MERGE INTO IAMHMORMetricsTable AS Target
USING (

SELECT 
	IncidentsDateRange AS DateRange,
	IncidentsTableCount AS IncidentsTableCount,
	IncidentsInSLACount AS IncidentsInSLACount,
	IncidentsSLAPercentage AS IncidentsSLAPercentage

FROM 
(
	SELECT
		FORMAT(Created,'yyyy-MM-01 00:00:00.000') AS IncidentsDateRange,

		COUNT(DISTINCT Number) AS IncidentsTableCount,

		SUM(CASE 
	            WHEN Created >= '2023-06-01' THEN 
	                CASE WHEN Assignment_Group_Days <= 5 THEN 1 ELSE 0 END 
	            ELSE 
	                CASE WHEN Old_Timespan_Days <= 5 THEN 1 ELSE 0 END
	    END) AS IncidentsInSLACount,

		STR(
	        ROUND(
	            (
	                CAST( 
	                		SUM(CASE 
	                            WHEN Created >= '2023-06-01' THEN 
	                                CASE WHEN Assignment_Group_Days <= 5 THEN 1 ELSE 0 END 
	                            ELSE 
	                                CASE WHEN Old_Timespan_Days <= 5 THEN 1 ELSE 0 END
	                        END)
	                    AS decimal
	                )
	                / CAST(COUNT(DISTINCT Number)AS decimal)
	            ) * 100, 2, 1
	        ), 4, 2
	    ) AS IncidentsSLAPercentage

	FROM IAMHSNOWIncidentsView
	WHERE CAST(Created AS DateTime) > '06-30-2022 23:59:59' 
	AND Exported_Outside_IAM = 'EIS IAM'
	GROUP BY
		FORMAT(Created, 'yyyy-MM-01 00:00:00.000')
) AS SubQuery


) AS Source on Target.DateRange = Source.DateRange
WHEN MATCHED THEN
    UPDATE SET
        Target.IncidentsTableCount = Source.IncidentsTableCount,
        Target.IncidentsINSLACount = Source.IncidentsInSLACount,
        Target.IncidentsSLAPercentage = Source.IncidentsSLAPercentage

WHEN NOT MATCHED BY TARGET AND NOT EXISTS (
    SELECT 1
    FROM IAMHMORMetricsTable AS Existing
    WHERE Existing.DateRange = Source.DateRange
)
    THEN
    INSERT (DateRange, IncidentsTableCount, IncidentsINSLACount, IncidentsSLAPercentage)
    VALUES (Source.DateRange, Source.IncidentsTableCount, Source.IncidentsInSLACount, Source.IncidentsSLAPercentage);


END
GO
/****** Object:  StoredProcedure [dbo].[MORMailboxProcedure]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Olson, Christopher
-- Create date: 09/15/2023
-- Description:	MOR Mailbox Key Metrics Procedure
-- =============================================
CREATE PROCEDURE [dbo].[MORMailboxProcedure]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

MERGE INTO IAMHMORMetricsTable AS Target
USING (

SELECT 
	MailboxDateRange AS DateRange,
	CASE WHEN FORMAT(CAST(MailboxDateRange as datetime), 'yyyy-MM') = '2023-11' THEN MailboxTableCount - 1 ELSE MailboxTableCount END AS MailboxTableCount, 
	MailboxInSLACount AS MailboxInSLACount,
	MailboxSLAPercentage AS MailboxSLAPercentage

FROM 
(
	SELECT
		FORMAT(CAST(CreateDate AS DATETIME),'yyyy-MM-01 00:00:00.000') AS MailboxDateRange,
		SUM(CONVERT(INT,TouchPoints)) AS MailboxTableCount,

		SUM(CASE
			WHEN SLACompletionTime IS NULL OR SLACompletionTime = 'Incomplete' THEN 0
			WHEN(
				(CHARINDEX(' Days', SLACompletionTime) > 0 ) 
				AND 
				(LEFT(STUFF(SLACompletionTime, 1, PATINDEX('%[0-9]%', SLACompletionTime + '0') - 1, ''), 2) <= 5 )
				)
				OR 
				(
				(CHARINDEX(' Days', SLACompletionTime) > 0 ) 
				AND 
				(LEFT(STUFF(SLACompletionTime, 1, PATINDEX('%[0-9]%', SLACompletionTime + '0') - 1, ''), 2) <= 10 )
				AND
				(RequestType Like '%PAR%'  OR FormType like '%PAR%')
				)
				THEN 1 * CONVERT(INT,TouchPoints)
			ELSE 0 
		END ) AS MailboxInSLACount,

		STR(ROUND((CAST(SUM
			(CASE
			WHEN SLACompletionTime IS NULL OR SLACompletionTime = 'Incomplete' THEN 0
			WHEN(
				(CHARINDEX(' Days', SLACompletionTime) > 0 ) 
				AND 
				(LEFT(STUFF(SLACompletionTime, 1, PATINDEX('%[0-9]%', SLACompletionTime + '0') - 1, ''), 2) <= 5 )
				)
				OR 
				(
				(CHARINDEX(' Days', SLACompletionTime) > 0 ) 
				AND 
				(LEFT(STUFF(SLACompletionTime, 1, PATINDEX('%[0-9]%', SLACompletionTime + '0') - 1, ''), 2) <= 20 )
				AND
				(RequestType Like '%PAR%'  OR FormType like '%PAR%')
				)
				THEN 1 * CONVERT(INT,TouchPoints)
			ELSE 0 
			END) AS decimal) 
		/ CAST(SUM(CONVERT(INT,TouchPoints))  AS decimal)) * 100, 2, 1), 4, 2) AS MailboxSLAPercentage

	FROM IAMHFactoolJoinedVIew
	WHERE CAST(CreateDate as DateTime) > '06-30-2022 23:59:59' 
	AND RequestState <> 'Cancelled'
	GROUP BY
		FORMAT(CAST(CreateDate AS DATETIME),'yyyy-MM-01 00:00:00.000')
) AS Subquery


) AS Source on Target.DateRange = Source.DateRange
WHEN MATCHED THEN
    UPDATE SET
        Target.MailboxTableCount = Source.MailboxTableCount,
        Target.MailboxInSLACount = Source.MailboxInSLACount,
        Target.MailboxSLAPercentage = Source.MailboxSLAPercentage
WHEN NOT MATCHED BY TARGET AND NOT EXISTS (
    SELECT 1
    FROM IAMHMORMetricsTable AS Existing
    WHERE Existing.DateRange = Source.DateRange
)
    THEN
    INSERT (DateRange, MailboxTableCount, MailboxInSLACount, MailboxSLAPercentage)
    VALUES (Source.DateRange, Source.MailboxTableCount, Source.MailboxInSLACount, Source.MailboxSLAPercentage);

END
GO
/****** Object:  StoredProcedure [dbo].[MORProvisioningProcedure]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Olson, Christopher
-- Create date: 09/15/2023
-- Description:	MOR Provisioning Key Metrics Procedure
-- =============================================
CREATE PROCEDURE [dbo].[MORProvisioningProcedure]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
MERGE INTO IAMHMORMetricsTable AS Target
USING (


SELECT 
	ProvisioningDateRange AS DateRange,
	ProvisioningTableCount AS ProvisioningCount,
	ProvisioningInSLACount AS ProvisioningInSLACount,
	ProvisioningSLAPercentage AS ProvisioningSLAPercentage

	FROM 
	(
	SELECT
	    FORMAT([sys_created_on], 'yyyy-MM-01 00:00:00.000') AS ProvisioningDateRange,

	    COUNT(DISTINCT Number) AS ProvisioningTableCount,
	    
	    SUM(CASE 
	            WHEN CAST(sys_created_on as DateTime) >= '2023-06-01' THEN 
	                CASE WHEN Assignment_Group_Days <= 5 OR (Assignment_Group_Days <= 14 AND CentrifyFlag = 'Y') THEN 1 ELSE 0 END 
	            ELSE 
	                CASE WHEN Old_Timespan_Days <= 5 OR (Old_Timespan_Days <= 14 AND CentrifyFlag = 'Y')  THEN 1 ELSE 0 END
	        END)
	    AS ProvisioningInSLACount,

	    STR(
	        ROUND(
	            (
	                CAST(
	                     SUM(CASE 
	                            WHEN CAST(sys_created_on as DateTime) >= '2023-06-01' THEN 
	                                CASE WHEN Assignment_Group_Days <= 5 OR (Assignment_Group_Days <= 14 AND CentrifyFlag = 'Y')  THEN 1 ELSE 0 END 
	                            ELSE 
	                                CASE WHEN Old_Timespan_Days <= 5 OR (Old_Timespan_Days <= 14 AND CentrifyFlag = 'Y')  THEN 1 ELSE 0 END
	                     END)
	                    AS decimal
	                )
	                / CAST(COUNT(DISTINCT Number)
	                    AS decimal
	                )
	            ) * 100, 2, 1
	        ), 4, 2
	    ) AS ProvisioningSLAPercentage
		FROM
		    IAMHSNOWProvisioningView
		WHERE   CAST(sys_created_on as DateTime) > '06-30-2022 23:59:59' 
		    AND Exported_Outside_IAM = 'EIS IAM'
		GROUP BY
		    FORMAT([sys_created_on], 'yyyy-MM-01 00:00:00.000')
	) AS Subquery

) AS Source on Target.DateRange = Source.DateRange
WHEN MATCHED THEN
    UPDATE SET
        Target.ProvisioningCount = Source.ProvisioningCount,
        Target.ProvisioningSLACount = Source.ProvisioningInSLACount,
        Target.ProvisioningSLAPercentage = Source.ProvisioningSLAPercentage

WHEN NOT MATCHED BY TARGET AND NOT EXISTS (
    SELECT 1
    FROM IAMHMORMetricsTable AS Existing
    WHERE Existing.DateRange = Source.DateRange
)
    THEN
    INSERT (DateRange, ProvisioningCount, ProvisioningSLACount, ProvisioningSLAPercentage)
    VALUES (Source.DateRange, Source.ProvisioningCount, Source.ProvisioningInSLACount, Source.ProvisioningSLAPercentage);

END
GO
/****** Object:  StoredProcedure [dbo].[MORRMRProcedure]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      <Olson, Christopher>
-- Create date: <09/19/2023>
-- Description: <RMR MOR Procedure Update>
-- =============================================
CREATE PROCEDURE  [dbo].[MORRMRProcedure]
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    -- Insert statements for procedure here

WITH CombinedData AS 
(  
    SELECT
        RequestID,
        creation_date,
        closed_on_date,
        last_update_date,
        status,
        customer_sequence,
        last_updated_by,
        Comments,
        TimeSpan_Days,
        'Creation_Date' AS Source
    FROM IAMHRMRDataView
    WHERE creation_date > '06-30-2022 23:59:59'

    UNION ALL

    SELECT
        RequestID,
        creation_date,
        last_update_date,
        closed_on_date,
        status,
        customer_sequence,
        last_updated_by,
        Comments,
        TimeSpan_Days,
        'Closed_On_Date' AS Source
    FROM IAMHRMRDataView
    WHERE Closed_State = 'Closed'
    and closed_on_date > '06-30-2022 23:59:59'
),

MaxSequence AS (
        SELECT
            RequestID,
            MAX(CAST(customer_sequence AS INT)) AS MaxSequence
        FROM CombinedData
        GROUP BY RequestID
),

RMRTable AS (
    SELECT
        FORMAT(cd.creation_date, 'yyyy-MM-01 00:00:00.000') AS DateRange, 

        COUNT(
            DISTINCT CASE 
                    WHEN cd.customer_sequence = ms.MaxSequence 
                    AND cd.Source = 'Closed_On_Date' 
                    THEN cd.RequestID
                    ELSE NULL 
                    END) 
        AS TicketsRecordsClosed,

        COUNT(
                    CASE 
                    WHEN cd.Source = 'Creation_Date' 
                    THEN 1 
                    ELSE NULL 
                    END) 
        AS UsersReceived,
        
        SUM(
                    CASE 
                    WHEN (cd.last_updated_by != 'AUTOCL' OR cd.last_updated_by IS NULL OR cd.last_updated_by = '') 
                    AND cd.Source = 'Creation_Date' 
                    THEN 1 
                    ELSE 0 
                    END) 
        AS UsersManualReceived,
        
        SUM(
                    CASE 
                    WHEN cd.last_updated_by = 'AUTOCL' 
                    AND cd.Source = 'Creation_Date' 
                    THEN 1 
                    ELSE 0 
                    END) 
        AS UsersAutomationReceived,

        SUM(
                    CASE 
                    WHEN cd.status LIKE '%CLOSED%' 
                    AND cd.Source = 'Closed_On_Date' 
                    THEN 1 
                    ELSE 0 
                    END) 
       AS UsersRecordsClosed,

        SUM(
                    CASE 
                    WHEN cd.Source = 'Closed_On_Date' 
                    AND cd.customer_sequence = ms.MaxSequence 
                    AND CAST([TimeSpan_Days] AS INT) BETWEEN 0 and 1 
                    THEN 1 
                    ELSE 0 
                    END) 
        AS [Closed 0-1 Days],
        
        SUM(
                    CASE 
                    WHEN cd.Source = 'Closed_On_Date' 
                    AND cd.customer_sequence = ms.MaxSequence 
                    AND CAST([TimeSpan_Days] AS INT) BETWEEN 2 and 3 
                    THEN 1 
                    ELSE 0 
                    END) 
        AS [Closed 2-3 Days],
        
        SUM(
                    CASE WHEN cd.Source = 'Closed_On_Date' 
                    AND cd.customer_sequence = ms.MaxSequence 
                    AND CAST([TimeSpan_Days] AS INT) BETWEEN 4 and 5 
                    THEN 1 
                    ELSE 0 
                    END) 
        AS [Closed 4-5 Days],
        
        SUM(
                    CASE WHEN cd.Source = 'Closed_On_Date' 
                    AND cd.customer_sequence = ms.MaxSequence 
                    AND CAST([TimeSpan_Days] AS INT) >= 6 
                    THEN 1 
                    ELSE 0 
                    END) 
        AS [Closed 6+ Days]


    FROM CombinedData cd
    INNER JOIN MaxSequence ms ON cd.RequestID = ms.RequestID
    GROUP BY FORMAT(cd.creation_date, 'yyyy-MM-01 00:00:00.000')
),

CAMSTable AS (
            SELECT
            FORMAT([RequestDate], 'yyyy-MM-01 00:00:00.000') AS CAMSDateRange,
            COUNT(*) AS CAMSTableCount

            FROM IAMHCamsData
            WHERE 
            CAST(RequestDate as DateTime) > '06-30-2022 23:59:59'
            AND IsWorkQueue = 1
            GROUP BY
                FORMAT([RequestDate], 'yyyy-MM-01 00:00:00.000')
)

MERGE INTO IAMHMORMetricsTable AS Target

USING (

SELECT
        RMRTable.DateRange AS DateRange,
        RMRTable.UsersReceived AS RMRTotalCount,
        RMRTable.UsersAutomationReceived AS RMRAutomatedCount,
        RMRTable.UsersManualReceived AS RMRManualCount,
        RMRTable.TicketsRecordsClosed AS RMRTicketsClosed,
        RMRTable.UsersRecordsClosed AS RMRUserRecordsClosed,

           ( SUM(RMRTable.[Closed 0-1 Days]) + SUM(RMRTable.[Closed 2-3 Days]) + SUM(RMRTable.[Closed 4-5 Days]) ) AS RMRINSLACount,

           STR(
                ROUND(
                    (
                        ( CAST(SUM(RMRTable.[Closed 0-1 Days]) AS Decimal(18,3)) 
                            + CAST(SUM(RMRTable.[Closed 2-3 Days]) AS Decimal(18,3)) 
                            + CAST(SUM(RMRTable.[Closed 4-5 Days]) AS Decimal(18,3)) )
                        / 
                         CAST(RMRTable.TicketsRecordsClosed AS Decimal(18,3))

                    ) * 100, 3
                ), 5, 3
            ) AS RMRSLAPercentage,

        CAMSTable.CAMSTableCount AS CAMSTotalCount
    FROM RMRTable
    INNER JOIN CAMSTable ON RMRTable.DateRange = CAMSTable.CAMSDateRange
    GROUP BY 
    RMRTable.DateRange,
    RMRTable.UsersReceived,
    RMRTable.UsersAutomationReceived,
    RMRTable.UsersManualReceived, 
    CAMSTable.CAMSTableCount,
    RMRTable.TicketsRecordsClosed,
    RMRTable.UsersRecordsClosed,
    RMRTable.[Closed 0-1 Days],
    RMRTable.[Closed 2-3 Days],
    RMRTable.[Closed 4-5 Days],
    RMRTable.[Closed 6+ Days]

) AS Source on Target.DateRange = Source.DateRange
WHEN MATCHED THEN
    UPDATE SET
        Target.RMRTotalCount = Source.RMRTotalCount,
        Target.RMRManualCount = Source.RMRManualCount,
        Target.RMRAutomatedCount = Source.RMRAutomatedCount,
        Target.RMRINSLACount = Source.RMRINSLACount,
        Target.RMRSLAPercentage = Source.RMRSLAPercentage,
        Target.CAMSTotalCount = Source.CAMSTotalCount
WHEN NOT MATCHED BY TARGET AND NOT EXISTS (
    SELECT 1
    FROM IAMHMORMetricsTable AS Existing
    WHERE Existing.DateRange = Source.DateRange
)
    THEN
    INSERT (DateRange, RMRTotalCount, RMRManualCount, RMRAutomatedCount, RMRINSLACount, RMRSLAPercentage, CAMSTotalCount)
    VALUES (Source.DateRange, Source.RMRTotalCount, Source.RMRManualCount, Source.RMRAutomatedCount, Source.RMRINSLACount, Source.RMRSLAPercentage, Source.CAMSTotalCount);

END
GO
/****** Object:  StoredProcedure [dbo].[RMRUpdateHistoricalData]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      <Olson, Christopher>
-- Create date: <12/15/2023>
-- Description: <RMR Historical Table Update Procedure>
CREATE PROCEDURE [dbo].[RMRUpdateHistoricalData]
AS
BEGIN
    -- Update Existing Records on Historical 
    UPDATE IAMHRMRHistoricalData
    SET
        last_update_date = iamh.last_update_date,
        last_updated_by = iamh.last_updated_by,
        status = iamh.status,

        status_changed_date = CASE
            WHEN IAMHRMRHistoricalData.status_changed_date IS NULL THEN iamh.last_update_date
            WHEN IAMHRMRHistoricalData.status != iamh.status THEN iamh.last_update_date
            ELSE IAMHRMRHistoricalData.status_changed_date
        END,

        last_status = CASE
            WHEN IAMHRMRHistoricalData.last_status IS NULL THEN iamh.status
            WHEN IAMHRMRHistoricalData.status != iamh.status THEN IAMHRMRHistoricalData.status
            ELSE IAMHRMRHistoricalData.last_status
        END,

        status_changed_history = CASE
        WHEN IAMHRMRHistoricalData.last_status IS NULL OR IAMHRMRHistoricalData.status_changed_history IS NULL 
        THEN '<ChangedAt: ' + CONVERT(NVARCHAR(50), iamh.last_update_date) + ' | ChangedBy: ' + iamh.last_updated_by +
             ' | ChangedTo: ' + iamh.status + ' | Comments: ' + iamh.comments +'>'

        WHEN IAMHRMRHistoricalData.last_status != iamh.status 
        THEN IAMHRMRHistoricalData.status_changed_history + ' - ' + '<ChangedAt: ' + CONVERT(NVARCHAR(50), iamh.last_update_date) + ' | ChangedBy: ' + iamh.last_updated_by +
             ' | ChangedFrom: ' + COALESCE(IAMHRMRHistoricalData.last_status, '') + ' | ChangedTo: ' + iamh.status + ' | Comments: ' + iamh.comments +'>'

        ELSE IAMHRMRHistoricalData.status_changed_history
        END

    FROM
        IAMHRMRData AS iamh
    WHERE
        IAMHRMRHistoricalData._id = iamh._id;
        
    -- Insert New Records into Historical
    INSERT INTO IAMHRMRHistoricalData (last_update_date, last_updated_by, _id, status, status_changed_date, last_status, status_changed_history)
    SELECT
        iamh.last_update_date,
        iamh.last_updated_by,
        iamh._id,
        iamh.status,

        CASE
            WHEN iamh.status_changed_date IS NULL THEN iamh.last_update_date
            ELSE iamh.status_changed_date
        END,

        CASE
            WHEN iamh.last_status IS NULL THEN iamh.status
            ELSE iamh.last_status
        END,

        CASE
        WHEN iamh.status IS NULL THEN ''
        ELSE  '<ChangedAt: ' + CONVERT(NVARCHAR(50), iamh.last_update_date) + ' | ChangedBy: ' + iamh.last_updated_by +
              ' | ChangedTo: ' + iamh.status + ' | Comments: ' + iamh.comments +'>'
        END

    FROM
        IAMHRMRData AS iamh
    LEFT JOIN
        IAMHRMRHistoricalData AS historical ON historical._id = iamh._id
    WHERE
        historical._id IS NULL;
        
    -- Update Closed On and Closed By based on Closed Status and if not previously set
    UPDATE IAMHRMRHistoricalData
    SET
        closed_on_date = iamh.last_update_date,
        closed_by = iamh.last_updated_by,

        status_changed_date = CASE
            WHEN IAMHRMRHistoricalData.status_changed_date IS NULL THEN iamh.last_updated_by
            WHEN IAMHRMRHistoricalData.status != iamh.status THEN iamh.last_updated_by
            ELSE IAMHRMRHistoricalData.status_changed_date
        END,

        last_status = CASE
            WHEN IAMHRMRHistoricalData.last_status IS NULL THEN iamh.status
            WHEN IAMHRMRHistoricalData.status != iamh.status THEN IAMHRMRHistoricalData.status
            ELSE IAMHRMRHistoricalData.last_status
        END,

        status_changed_history = CASE
        WHEN IAMHRMRHistoricalData.last_status IS NULL OR IAMHRMRHistoricalData.status_changed_history IS NULL 
        THEN '<ChangedAt: ' + CONVERT(NVARCHAR(50), iamh.last_update_date) + ' | ChangedBy: ' + iamh.last_updated_by +
             ' | ChangedTo: ' + iamh.status + ' | Comments: ' + iamh.comments +'>'

        WHEN IAMHRMRHistoricalData.last_status != iamh.status 
        THEN IAMHRMRHistoricalData.status_changed_history + ' - ' + '<ChangedAt: ' + CONVERT(NVARCHAR(50), iamh.last_update_date) + ' | ChangedBy: ' + iamh.last_updated_by +
             ' | ChangedFrom: ' + COALESCE(IAMHRMRHistoricalData.last_status, '') + ' | ChangedTo: ' + iamh.status + ' | Comments: ' + iamh.comments +'>'

        ELSE IAMHRMRHistoricalData.status_changed_history
        END

    FROM
        IAMHRMRData AS iamh
    WHERE
        IAMHRMRHistoricalData._id = iamh._id
        AND IAMHRMRHistoricalData.closed_on_date IS NULL
        AND (iamh.status = 'CLOSED' OR iamh.status = 'REJECTED' OR iamh.status = 'DENIED' OR iamh.status = 'CANCELLED' OR iamh.status = 'REJECTED (NON-RECALLABLE)');


    UPDATE IAMHRMRData 
        SET 
            closed_on_date = historical.closed_on_date,
            closed_by = historical.closed_by,
            status_changed_date = historical.status_changed_date,
            last_status = historical.last_status

    FROM IAMHRMRHistoricalData AS historical 
    WHERE historical._id = IAMHRMRData._id;

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateAccessNowExtenalTicketIdData]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Olson, Christopher>
-- Create date: <03/26/2023>
-- Description:	<Update the AccessNow Operations Table on External Ticket Id Given Parameters>
-- =============================================
Create PROCEDURE [dbo].[UpdateAccessNowExtenalTicketIdData]
	-- Add the parameters for the stored procedure here
    @externalId nvarchar(max),
    @externalTicketId nvarchar(max)
AS
BEGIN
    UPDATE IAMHAccessNowOperations
    SET ticketData_externalTicketId = @externalTicketId
    WHERE externalId = @externalId

	Select 0 AS QueryValueReturned
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateAccessNowSubRequestData]    Script Date: 1/10/2024 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Olson, Christopher>
-- Create date: <02/15/2023>
-- Description:	<Update the AccessNow Operations Table on SubRequest Given Parameters>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateAccessNowSubRequestData]
    @externalId nvarchar(max),
    @subRequestType nvarchar(max)
AS
BEGIN
    UPDATE IAMHAccessNowOperations
    SET requestData_subRequestType = @subRequestType
    WHERE externalId = @externalId

	Select 0 AS QueryValueReturned
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "IAMHAccessNowOperations"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 267
               Right = 787
            End
            DisplayFlags = 280
            TopColumn = 481
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHAccessNowOperationsRawView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHAccessNowOperationsRawView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[28] 4[22] 2[33] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ano"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "at"
            Begin Extent = 
               Top = 6
               Left = 288
               Bottom = 102
               Right = 467
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 2085
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHAccessNowOperationsView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHAccessNowOperationsView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "IAMHCostCenter"
            Begin Extent = 
               Top = 57
               Left = 565
               Bottom = 187
               Right = 785
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ano"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHAccessNowOperationsViewOlder'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHAccessNowOperationsViewOlder'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "IAMHCamsData"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHCamsDataView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHCamsDataView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "IAMHCamsData"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHCamsItemsCompletedView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHCamsItemsCompletedView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "IAMHCARRSMetrics"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 428
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHCARRSMetricsView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHCARRSMetricsView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "subquery"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 257
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 2475
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHFactoolExpectedMetricsView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHFactoolExpectedMetricsView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "IAMHFactoolRequest"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 223
            End
            DisplayFlags = 280
            TopColumn = 16
         End
         Begin Table = "IAMHFactoolExpectedNumbers"
            Begin Extent = 
               Top = 6
               Left = 261
               Bottom = 288
               Right = 634
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "IAMHFactoolRequestStatus"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHFactoolExpectedView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHFactoolExpectedView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "FactoolRequest"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 223
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "FactoolStatus"
            Begin Extent = 
               Top = 6
               Left = 261
               Bottom = 136
               Right = 459
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHFactoolJoinedView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHFactoolJoinedView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHFactoolSystemsView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHFactoolSystemsView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[28] 4[23] 2[37] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "subquery"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 223
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3480
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHMORApplicationMetricsView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHMORApplicationMetricsView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[28] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "subs"
            Begin Extent = 
               Top = 6
               Left = 319
               Bottom = 85
               Right = 489
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "dt"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 285
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHMORMetricsView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHMORMetricsView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "IAMHParData"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 258
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHPARDataView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHPARDataView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[30] 4[13] 2[38] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "xd"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct"
            Begin Extent = 
               Top = 6
               Left = 286
               Bottom = 136
               Right = 460
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHRMRDataView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHRMRDataView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "IAMHSNOWIncidents"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 319
               Right = 670
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 4260
         Alias = 3720
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHSNOWIncidentsView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHSNOWIncidentsView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "IAMHSNOWProvisioning"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 192
               Right = 507
            End
            DisplayFlags = 280
            TopColumn = 35
         End
         Begin Table = "IAMHCostCenter"
            Begin Extent = 
               Top = 6
               Left = 545
               Bottom = 233
               Right = 874
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 2955
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1365
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHSNOWProvisioningView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHSNOWProvisioningView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "IAMHSolutionCenterEscalations"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 320
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHSolutionCenterEscalationsView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IAMHSolutionCenterEscalationsView'
GO
