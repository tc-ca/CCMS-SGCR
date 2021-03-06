interface hr_CaseType_Base extends WebEntity {
  createdon?: Date | null;
  hr_casetypeid?: string | null;
  hr_name?: string | null;
  hr_nameen?: string | null;
  hr_namefr?: string | null;
  hr_sortorder?: number | null;
  importsequencenumber?: number | null;
  modifiedon?: Date | null;
  overriddencreatedon?: Date | null;
  statecode?: hr_casetype_statecode | null;
  statuscode?: hr_casetype_statuscode | null;
  timezoneruleversionnumber?: number | null;
  utcconversiontimezonecode?: number | null;
  versionnumber?: number | null;
}
interface hr_CaseType_Relationships {
  hr_CaseType_hr_CaseSubType_hr_CaseSubType?: hr_CaseSubType_Result[] | null;
  hr_HRCase_hr_CaseType_hr_CaseType?: hr_HRCase_Result[] | null;
}
interface hr_CaseType extends hr_CaseType_Base, hr_CaseType_Relationships {
  ownerid_bind$systemusers?: string | null;
  ownerid_bind$teams?: string | null;
}
interface hr_CaseType_Create extends hr_CaseType {
}
interface hr_CaseType_Update extends hr_CaseType {
}
interface hr_CaseType_Select {
  createdby_guid: WebAttribute<hr_CaseType_Select, { createdby_guid: string | null }, { createdby_formatted?: string }>;
  createdon: WebAttribute<hr_CaseType_Select, { createdon: Date | null }, { createdon_formatted?: string }>;
  createdonbehalfby_guid: WebAttribute<hr_CaseType_Select, { createdonbehalfby_guid: string | null }, { createdonbehalfby_formatted?: string }>;
  hr_casetypeid: WebAttribute<hr_CaseType_Select, { hr_casetypeid: string | null }, {  }>;
  hr_name: WebAttribute<hr_CaseType_Select, { hr_name: string | null }, {  }>;
  hr_nameen: WebAttribute<hr_CaseType_Select, { hr_nameen: string | null }, {  }>;
  hr_namefr: WebAttribute<hr_CaseType_Select, { hr_namefr: string | null }, {  }>;
  hr_sortorder: WebAttribute<hr_CaseType_Select, { hr_sortorder: number | null }, {  }>;
  importsequencenumber: WebAttribute<hr_CaseType_Select, { importsequencenumber: number | null }, {  }>;
  modifiedby_guid: WebAttribute<hr_CaseType_Select, { modifiedby_guid: string | null }, { modifiedby_formatted?: string }>;
  modifiedon: WebAttribute<hr_CaseType_Select, { modifiedon: Date | null }, { modifiedon_formatted?: string }>;
  modifiedonbehalfby_guid: WebAttribute<hr_CaseType_Select, { modifiedonbehalfby_guid: string | null }, { modifiedonbehalfby_formatted?: string }>;
  overriddencreatedon: WebAttribute<hr_CaseType_Select, { overriddencreatedon: Date | null }, { overriddencreatedon_formatted?: string }>;
  ownerid_guid: WebAttribute<hr_CaseType_Select, { ownerid_guid: string | null }, { ownerid_formatted?: string }>;
  owningbusinessunit_guid: WebAttribute<hr_CaseType_Select, { owningbusinessunit_guid: string | null }, { owningbusinessunit_formatted?: string }>;
  owningteam_guid: WebAttribute<hr_CaseType_Select, { owningteam_guid: string | null }, { owningteam_formatted?: string }>;
  owninguser_guid: WebAttribute<hr_CaseType_Select, { owninguser_guid: string | null }, { owninguser_formatted?: string }>;
  statecode: WebAttribute<hr_CaseType_Select, { statecode: hr_casetype_statecode | null }, { statecode_formatted?: string }>;
  statuscode: WebAttribute<hr_CaseType_Select, { statuscode: hr_casetype_statuscode | null }, { statuscode_formatted?: string }>;
  timezoneruleversionnumber: WebAttribute<hr_CaseType_Select, { timezoneruleversionnumber: number | null }, {  }>;
  utcconversiontimezonecode: WebAttribute<hr_CaseType_Select, { utcconversiontimezonecode: number | null }, {  }>;
  versionnumber: WebAttribute<hr_CaseType_Select, { versionnumber: number | null }, {  }>;
}
interface hr_CaseType_Filter {
  createdby_guid: XQW.Guid;
  createdon: Date;
  createdonbehalfby_guid: XQW.Guid;
  hr_casetypeid: XQW.Guid;
  hr_name: string;
  hr_nameen: string;
  hr_namefr: string;
  hr_sortorder: number;
  importsequencenumber: number;
  modifiedby_guid: XQW.Guid;
  modifiedon: Date;
  modifiedonbehalfby_guid: XQW.Guid;
  overriddencreatedon: Date;
  ownerid_guid: XQW.Guid;
  owningbusinessunit_guid: XQW.Guid;
  owningteam_guid: XQW.Guid;
  owninguser_guid: XQW.Guid;
  statecode: hr_casetype_statecode;
  statuscode: hr_casetype_statuscode;
  timezoneruleversionnumber: number;
  utcconversiontimezonecode: number;
  versionnumber: number;
}
interface hr_CaseType_Expand {
  createdby: WebExpand<hr_CaseType_Expand, SystemUser_Select, SystemUser_Filter, { createdby: SystemUser_Result }>;
  createdonbehalfby: WebExpand<hr_CaseType_Expand, SystemUser_Select, SystemUser_Filter, { createdonbehalfby: SystemUser_Result }>;
  hr_CaseType_hr_CaseSubType_hr_CaseSubType: WebExpand<hr_CaseType_Expand, hr_CaseSubType_Select, hr_CaseSubType_Filter, { hr_CaseType_hr_CaseSubType_hr_CaseSubType: hr_CaseSubType_Result[] }>;
  hr_HRCase_hr_CaseType_hr_CaseType: WebExpand<hr_CaseType_Expand, hr_HRCase_Select, hr_HRCase_Filter, { hr_HRCase_hr_CaseType_hr_CaseType: hr_HRCase_Result[] }>;
  modifiedby: WebExpand<hr_CaseType_Expand, SystemUser_Select, SystemUser_Filter, { modifiedby: SystemUser_Result }>;
  modifiedonbehalfby: WebExpand<hr_CaseType_Expand, SystemUser_Select, SystemUser_Filter, { modifiedonbehalfby: SystemUser_Result }>;
  ownerid: WebExpand<hr_CaseType_Expand, SystemUser_Select, SystemUser_Filter, { ownerid: SystemUser_Result }>;
  owninguser: WebExpand<hr_CaseType_Expand, SystemUser_Select, SystemUser_Filter, { owninguser: SystemUser_Result }>;
}
interface hr_CaseType_FormattedResult {
  createdby_formatted?: string;
  createdon_formatted?: string;
  createdonbehalfby_formatted?: string;
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
interface hr_CaseType_Result extends hr_CaseType_Base, hr_CaseType_Relationships {
  "@odata.etag": string;
  createdby_guid: string | null;
  createdonbehalfby_guid: string | null;
  modifiedby_guid: string | null;
  modifiedonbehalfby_guid: string | null;
  ownerid_guid: string | null;
  owningbusinessunit_guid: string | null;
  owningteam_guid: string | null;
  owninguser_guid: string | null;
}
interface hr_CaseType_RelatedOne {
  createdby: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
  createdonbehalfby: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
  modifiedby: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
  modifiedonbehalfby: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
  ownerid: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
  owninguser: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
}
interface hr_CaseType_RelatedMany {
  hr_CaseType_hr_CaseSubType_hr_CaseSubType: WebMappingRetrieve<hr_CaseSubType_Select,hr_CaseSubType_Expand,hr_CaseSubType_Filter,hr_CaseSubType_Fixed,hr_CaseSubType_Result,hr_CaseSubType_FormattedResult>;
  hr_HRCase_hr_CaseType_hr_CaseType: WebMappingRetrieve<hr_HRCase_Select,hr_HRCase_Expand,hr_HRCase_Filter,hr_HRCase_Fixed,hr_HRCase_Result,hr_HRCase_FormattedResult>;
}
interface WebEntitiesRetrieve {
  hr_casetypes: WebMappingRetrieve<hr_CaseType_Select,hr_CaseType_Expand,hr_CaseType_Filter,hr_CaseType_Fixed,hr_CaseType_Result,hr_CaseType_FormattedResult>;
}
interface WebEntitiesRelated {
  hr_casetypes: WebMappingRelated<hr_CaseType_RelatedOne,hr_CaseType_RelatedMany>;
}
interface WebEntitiesCUDA {
  hr_casetypes: WebMappingCUDA<hr_CaseType_Create,hr_CaseType_Update,hr_CaseType_Select>;
}
