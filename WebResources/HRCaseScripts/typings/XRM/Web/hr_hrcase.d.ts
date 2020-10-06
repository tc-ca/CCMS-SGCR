interface hr_HRCase_Base extends WebEntity {
  createdon?: Date | null;
  hr_casenumber?: string | null;
  hr_casestatus?: hr_casestatus | null;
  hr_closedon?: Date | null;
  hr_datereceived?: Date | null;
  hr_description?: string | null;
  hr_email?: string | null;
  hr_firstname?: string | null;
  hr_hrcaseid?: string | null;
  hr_lastname?: string | null;
  hr_name?: string | null;
  hr_pri?: string | null;
  hr_priority?: boolean | null;
  hr_questionsequencenumber?: number | null;
  hr_resolution?: string | null;
  hr_showbpf?: boolean | null;
  importsequencenumber?: number | null;
  modifiedon?: Date | null;
  overriddencreatedon?: Date | null;
  processid?: string | null;
  stageid?: string | null;
  statecode?: hr_hrcase_statecode | null;
  statuscode?: hr_hrcase_statuscode | null;
  timezoneruleversionnumber?: number | null;
  traversedpath?: string | null;
  utcconversiontimezonecode?: number | null;
  versionnumber?: number | null;
}
interface hr_HRCase_Relationships {
  hr_CaseSubType?: hr_CaseSubType_Result | null;
  hr_CaseType?: hr_CaseType_Result | null;
  hr_HRCase_hr_HRCase_hr_QuestionandAnswers?: hr_QuestionandAnswers_Result[] | null;
}
interface hr_HRCase extends hr_HRCase_Base, hr_HRCase_Relationships {
  createdby_bind$systemusers?: string | null;
  createdonbehalfby_bind$systemusers?: string | null;
  hr_CaseSubType_bind$hr_casesubtypes?: string | null;
  hr_CaseType_bind$hr_casetypes?: string | null;
  modifiedby_bind$systemusers?: string | null;
  modifiedonbehalfby_bind$systemusers?: string | null;
  ownerid_bind$systemusers?: string | null;
  ownerid_bind$teams?: string | null;
  stageid_bind$processstages?: string | null;
}
interface hr_HRCase_Create extends hr_HRCase {
}
interface hr_HRCase_Update extends hr_HRCase {
}
interface hr_HRCase_Select {
  createdby_guid: WebAttribute<hr_HRCase_Select, { createdby_guid: string | null }, { createdby_formatted?: string }>;
  createdon: WebAttribute<hr_HRCase_Select, { createdon: Date | null }, { createdon_formatted?: string }>;
  createdonbehalfby_guid: WebAttribute<hr_HRCase_Select, { createdonbehalfby_guid: string | null }, { createdonbehalfby_formatted?: string }>;
  hr_casenumber: WebAttribute<hr_HRCase_Select, { hr_casenumber: string | null }, {  }>;
  hr_casestatus: WebAttribute<hr_HRCase_Select, { hr_casestatus: hr_casestatus | null }, { hr_casestatus_formatted?: string }>;
  hr_casesubtype_guid: WebAttribute<hr_HRCase_Select, { hr_casesubtype_guid: string | null }, { hr_casesubtype_formatted?: string }>;
  hr_casetype_guid: WebAttribute<hr_HRCase_Select, { hr_casetype_guid: string | null }, { hr_casetype_formatted?: string }>;
  hr_closedon: WebAttribute<hr_HRCase_Select, { hr_closedon: Date | null }, { hr_closedon_formatted?: string }>;
  hr_datereceived: WebAttribute<hr_HRCase_Select, { hr_datereceived: Date | null }, { hr_datereceived_formatted?: string }>;
  hr_description: WebAttribute<hr_HRCase_Select, { hr_description: string | null }, {  }>;
  hr_email: WebAttribute<hr_HRCase_Select, { hr_email: string | null }, {  }>;
  hr_firstname: WebAttribute<hr_HRCase_Select, { hr_firstname: string | null }, {  }>;
  hr_hrcaseid: WebAttribute<hr_HRCase_Select, { hr_hrcaseid: string | null }, {  }>;
  hr_lastname: WebAttribute<hr_HRCase_Select, { hr_lastname: string | null }, {  }>;
  hr_name: WebAttribute<hr_HRCase_Select, { hr_name: string | null }, {  }>;
  hr_pri: WebAttribute<hr_HRCase_Select, { hr_pri: string | null }, {  }>;
  hr_priority: WebAttribute<hr_HRCase_Select, { hr_priority: boolean | null }, {  }>;
  hr_questionsequencenumber: WebAttribute<hr_HRCase_Select, { hr_questionsequencenumber: number | null }, {  }>;
  hr_resolution: WebAttribute<hr_HRCase_Select, { hr_resolution: string | null }, {  }>;
  hr_showbpf: WebAttribute<hr_HRCase_Select, { hr_showbpf: boolean | null }, {  }>;
  importsequencenumber: WebAttribute<hr_HRCase_Select, { importsequencenumber: number | null }, {  }>;
  modifiedby_guid: WebAttribute<hr_HRCase_Select, { modifiedby_guid: string | null }, { modifiedby_formatted?: string }>;
  modifiedon: WebAttribute<hr_HRCase_Select, { modifiedon: Date | null }, { modifiedon_formatted?: string }>;
  modifiedonbehalfby_guid: WebAttribute<hr_HRCase_Select, { modifiedonbehalfby_guid: string | null }, { modifiedonbehalfby_formatted?: string }>;
  overriddencreatedon: WebAttribute<hr_HRCase_Select, { overriddencreatedon: Date | null }, { overriddencreatedon_formatted?: string }>;
  ownerid_guid: WebAttribute<hr_HRCase_Select, { ownerid_guid: string | null }, { ownerid_formatted?: string }>;
  owningbusinessunit_guid: WebAttribute<hr_HRCase_Select, { owningbusinessunit_guid: string | null }, { owningbusinessunit_formatted?: string }>;
  owningteam_guid: WebAttribute<hr_HRCase_Select, { owningteam_guid: string | null }, { owningteam_formatted?: string }>;
  owninguser_guid: WebAttribute<hr_HRCase_Select, { owninguser_guid: string | null }, { owninguser_formatted?: string }>;
  processid: WebAttribute<hr_HRCase_Select, { processid: string | null }, {  }>;
  stageid: WebAttribute<hr_HRCase_Select, { stageid: string | null }, {  }>;
  statecode: WebAttribute<hr_HRCase_Select, { statecode: hr_hrcase_statecode | null }, { statecode_formatted?: string }>;
  statuscode: WebAttribute<hr_HRCase_Select, { statuscode: hr_hrcase_statuscode | null }, { statuscode_formatted?: string }>;
  timezoneruleversionnumber: WebAttribute<hr_HRCase_Select, { timezoneruleversionnumber: number | null }, {  }>;
  traversedpath: WebAttribute<hr_HRCase_Select, { traversedpath: string | null }, {  }>;
  utcconversiontimezonecode: WebAttribute<hr_HRCase_Select, { utcconversiontimezonecode: number | null }, {  }>;
  versionnumber: WebAttribute<hr_HRCase_Select, { versionnumber: number | null }, {  }>;
}
interface hr_HRCase_Filter {
  createdby_guid: XQW.Guid;
  createdon: Date;
  createdonbehalfby_guid: XQW.Guid;
  hr_casenumber: string;
  hr_casestatus: hr_casestatus;
  hr_casesubtype_guid: XQW.Guid;
  hr_casetype_guid: XQW.Guid;
  hr_closedon: Date;
  hr_datereceived: Date;
  hr_description: string;
  hr_email: string;
  hr_firstname: string;
  hr_hrcaseid: XQW.Guid;
  hr_lastname: string;
  hr_name: string;
  hr_pri: string;
  hr_priority: boolean;
  hr_questionsequencenumber: number;
  hr_resolution: string;
  hr_showbpf: boolean;
  importsequencenumber: number;
  modifiedby_guid: XQW.Guid;
  modifiedon: Date;
  modifiedonbehalfby_guid: XQW.Guid;
  overriddencreatedon: Date;
  ownerid_guid: XQW.Guid;
  owningbusinessunit_guid: XQW.Guid;
  owningteam_guid: XQW.Guid;
  owninguser_guid: XQW.Guid;
  processid: XQW.Guid;
  stageid: XQW.Guid;
  statecode: hr_hrcase_statecode;
  statuscode: hr_hrcase_statuscode;
  timezoneruleversionnumber: number;
  traversedpath: string;
  utcconversiontimezonecode: number;
  versionnumber: number;
}
interface hr_HRCase_Expand {
  createdby: WebExpand<hr_HRCase_Expand, SystemUser_Select, SystemUser_Filter, { createdby: SystemUser_Result }>;
  createdonbehalfby: WebExpand<hr_HRCase_Expand, SystemUser_Select, SystemUser_Filter, { createdonbehalfby: SystemUser_Result }>;
  hr_CaseSubType: WebExpand<hr_HRCase_Expand, hr_CaseSubType_Select, hr_CaseSubType_Filter, { hr_CaseSubType: hr_CaseSubType_Result }>;
  hr_CaseType: WebExpand<hr_HRCase_Expand, hr_CaseType_Select, hr_CaseType_Filter, { hr_CaseType: hr_CaseType_Result }>;
  hr_HRCase_hr_HRCase_hr_QuestionandAnswers: WebExpand<hr_HRCase_Expand, hr_QuestionandAnswers_Select, hr_QuestionandAnswers_Filter, { hr_HRCase_hr_HRCase_hr_QuestionandAnswers: hr_QuestionandAnswers_Result[] }>;
  modifiedby: WebExpand<hr_HRCase_Expand, SystemUser_Select, SystemUser_Filter, { modifiedby: SystemUser_Result }>;
  modifiedonbehalfby: WebExpand<hr_HRCase_Expand, SystemUser_Select, SystemUser_Filter, { modifiedonbehalfby: SystemUser_Result }>;
  ownerid: WebExpand<hr_HRCase_Expand, SystemUser_Select, SystemUser_Filter, { ownerid: SystemUser_Result }>;
  owninguser: WebExpand<hr_HRCase_Expand, SystemUser_Select, SystemUser_Filter, { owninguser: SystemUser_Result }>;
}
interface hr_HRCase_FormattedResult {
  createdby_formatted?: string;
  createdon_formatted?: string;
  createdonbehalfby_formatted?: string;
  hr_casestatus_formatted?: string;
  hr_casesubtype_formatted?: string;
  hr_casetype_formatted?: string;
  hr_closedon_formatted?: string;
  hr_datereceived_formatted?: string;
  modifiedby_formatted?: string;
  modifiedon_formatted?: string;
  modifiedonbehalfby_formatted?: string;
  overriddencreatedon_formatted?: string;
  ownerid_formatted?: string;
  owningbusinessunit_formatted?: string;
  owningteam_formatted?: string;
  owninguser_formatted?: string;
  statecode_formatted?: string;
  statuscode_formatted?: string;
}
interface hr_HRCase_Result extends hr_HRCase_Base, hr_HRCase_Relationships {
  "@odata.etag": string;
  createdby_guid: string | null;
  createdonbehalfby_guid: string | null;
  hr_casesubtype_guid: string | null;
  hr_casetype_guid: string | null;
  modifiedby_guid: string | null;
  modifiedonbehalfby_guid: string | null;
  ownerid_guid: string | null;
  owningbusinessunit_guid: string | null;
  owningteam_guid: string | null;
  owninguser_guid: string | null;
}
interface hr_HRCase_RelatedOne {
  createdby: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
  createdonbehalfby: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
  hr_CaseSubType: WebMappingRetrieve<hr_CaseSubType_Select,hr_CaseSubType_Expand,hr_CaseSubType_Filter,hr_CaseSubType_Fixed,hr_CaseSubType_Result,hr_CaseSubType_FormattedResult>;
  hr_CaseType: WebMappingRetrieve<hr_CaseType_Select,hr_CaseType_Expand,hr_CaseType_Filter,hr_CaseType_Fixed,hr_CaseType_Result,hr_CaseType_FormattedResult>;
  modifiedby: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
  modifiedonbehalfby: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
  ownerid: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
  owninguser: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
}
interface hr_HRCase_RelatedMany {
  hr_HRCase_hr_HRCase_hr_QuestionandAnswers: WebMappingRetrieve<hr_QuestionandAnswers_Select,hr_QuestionandAnswers_Expand,hr_QuestionandAnswers_Filter,hr_QuestionandAnswers_Fixed,hr_QuestionandAnswers_Result,hr_QuestionandAnswers_FormattedResult>;
}
interface WebEntitiesRetrieve {
  hr_hrcases: WebMappingRetrieve<hr_HRCase_Select,hr_HRCase_Expand,hr_HRCase_Filter,hr_HRCase_Fixed,hr_HRCase_Result,hr_HRCase_FormattedResult>;
}
interface WebEntitiesRelated {
  hr_hrcases: WebMappingRelated<hr_HRCase_RelatedOne,hr_HRCase_RelatedMany>;
}
interface WebEntitiesCUDA {
  hr_hrcases: WebMappingCUDA<hr_HRCase_Create,hr_HRCase_Update,hr_HRCase_Select>;
}
