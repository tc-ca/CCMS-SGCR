interface hr_QuestionandAnswers_Base extends WebEntity {
  createdon?: Date | null;
  hr_answer?: string | null;
  hr_answeredon?: Date | null;
  hr_askedon?: Date | null;
  hr_question?: string | null;
  hr_questionandanswersid?: string | null;
  hr_questionnumber?: string | null;
  hr_questionsequencenumber?: number | null;
  hr_read?: boolean | null;
  importsequencenumber?: number | null;
  modifiedon?: Date | null;
  overriddencreatedon?: Date | null;
  statecode?: hr_questionandanswers_statecode | null;
  statuscode?: hr_questionandanswers_statuscode | null;
  timezoneruleversionnumber?: number | null;
  utcconversiontimezonecode?: number | null;
  versionnumber?: number | null;
}
interface hr_QuestionandAnswers_Relationships {
  hr_HRCase?: hr_HRCase_Result | null;
}
interface hr_QuestionandAnswers extends hr_QuestionandAnswers_Base, hr_QuestionandAnswers_Relationships {
  hr_HRCase_bind$hr_hrcases?: string | null;
  ownerid_bind$systemusers?: string | null;
  ownerid_bind$teams?: string | null;
}
interface hr_QuestionandAnswers_Create extends hr_QuestionandAnswers {
}
interface hr_QuestionandAnswers_Update extends hr_QuestionandAnswers {
}
interface hr_QuestionandAnswers_Select {
  createdby_guid: WebAttribute<hr_QuestionandAnswers_Select, { createdby_guid: string | null }, { createdby_formatted?: string }>;
  createdon: WebAttribute<hr_QuestionandAnswers_Select, { createdon: Date | null }, { createdon_formatted?: string }>;
  createdonbehalfby_guid: WebAttribute<hr_QuestionandAnswers_Select, { createdonbehalfby_guid: string | null }, { createdonbehalfby_formatted?: string }>;
  hr_answer: WebAttribute<hr_QuestionandAnswers_Select, { hr_answer: string | null }, {  }>;
  hr_answeredon: WebAttribute<hr_QuestionandAnswers_Select, { hr_answeredon: Date | null }, { hr_answeredon_formatted?: string }>;
  hr_askedon: WebAttribute<hr_QuestionandAnswers_Select, { hr_askedon: Date | null }, { hr_askedon_formatted?: string }>;
  hr_hrcase_guid: WebAttribute<hr_QuestionandAnswers_Select, { hr_hrcase_guid: string | null }, { hr_hrcase_formatted?: string }>;
  hr_question: WebAttribute<hr_QuestionandAnswers_Select, { hr_question: string | null }, {  }>;
  hr_questionandanswersid: WebAttribute<hr_QuestionandAnswers_Select, { hr_questionandanswersid: string | null }, {  }>;
  hr_questionnumber: WebAttribute<hr_QuestionandAnswers_Select, { hr_questionnumber: string | null }, {  }>;
  hr_questionsequencenumber: WebAttribute<hr_QuestionandAnswers_Select, { hr_questionsequencenumber: number | null }, {  }>;
  hr_read: WebAttribute<hr_QuestionandAnswers_Select, { hr_read: boolean | null }, {  }>;
  importsequencenumber: WebAttribute<hr_QuestionandAnswers_Select, { importsequencenumber: number | null }, {  }>;
  modifiedby_guid: WebAttribute<hr_QuestionandAnswers_Select, { modifiedby_guid: string | null }, { modifiedby_formatted?: string }>;
  modifiedon: WebAttribute<hr_QuestionandAnswers_Select, { modifiedon: Date | null }, { modifiedon_formatted?: string }>;
  modifiedonbehalfby_guid: WebAttribute<hr_QuestionandAnswers_Select, { modifiedonbehalfby_guid: string | null }, { modifiedonbehalfby_formatted?: string }>;
  overriddencreatedon: WebAttribute<hr_QuestionandAnswers_Select, { overriddencreatedon: Date | null }, { overriddencreatedon_formatted?: string }>;
  ownerid_guid: WebAttribute<hr_QuestionandAnswers_Select, { ownerid_guid: string | null }, { ownerid_formatted?: string }>;
  owningbusinessunit_guid: WebAttribute<hr_QuestionandAnswers_Select, { owningbusinessunit_guid: string | null }, { owningbusinessunit_formatted?: string }>;
  owningteam_guid: WebAttribute<hr_QuestionandAnswers_Select, { owningteam_guid: string | null }, { owningteam_formatted?: string }>;
  owninguser_guid: WebAttribute<hr_QuestionandAnswers_Select, { owninguser_guid: string | null }, { owninguser_formatted?: string }>;
  statecode: WebAttribute<hr_QuestionandAnswers_Select, { statecode: hr_questionandanswers_statecode | null }, { statecode_formatted?: string }>;
  statuscode: WebAttribute<hr_QuestionandAnswers_Select, { statuscode: hr_questionandanswers_statuscode | null }, { statuscode_formatted?: string }>;
  timezoneruleversionnumber: WebAttribute<hr_QuestionandAnswers_Select, { timezoneruleversionnumber: number | null }, {  }>;
  utcconversiontimezonecode: WebAttribute<hr_QuestionandAnswers_Select, { utcconversiontimezonecode: number | null }, {  }>;
  versionnumber: WebAttribute<hr_QuestionandAnswers_Select, { versionnumber: number | null }, {  }>;
}
interface hr_QuestionandAnswers_Filter {
  createdby_guid: XQW.Guid;
  createdon: Date;
  createdonbehalfby_guid: XQW.Guid;
  hr_answer: string;
  hr_answeredon: Date;
  hr_askedon: Date;
  hr_hrcase_guid: XQW.Guid;
  hr_question: string;
  hr_questionandanswersid: XQW.Guid;
  hr_questionnumber: string;
  hr_questionsequencenumber: number;
  hr_read: boolean;
  importsequencenumber: number;
  modifiedby_guid: XQW.Guid;
  modifiedon: Date;
  modifiedonbehalfby_guid: XQW.Guid;
  overriddencreatedon: Date;
  ownerid_guid: XQW.Guid;
  owningbusinessunit_guid: XQW.Guid;
  owningteam_guid: XQW.Guid;
  owninguser_guid: XQW.Guid;
  statecode: hr_questionandanswers_statecode;
  statuscode: hr_questionandanswers_statuscode;
  timezoneruleversionnumber: number;
  utcconversiontimezonecode: number;
  versionnumber: number;
}
interface hr_QuestionandAnswers_Expand {
  createdby: WebExpand<hr_QuestionandAnswers_Expand, SystemUser_Select, SystemUser_Filter, { createdby: SystemUser_Result }>;
  createdonbehalfby: WebExpand<hr_QuestionandAnswers_Expand, SystemUser_Select, SystemUser_Filter, { createdonbehalfby: SystemUser_Result }>;
  hr_HRCase: WebExpand<hr_QuestionandAnswers_Expand, hr_HRCase_Select, hr_HRCase_Filter, { hr_HRCase: hr_HRCase_Result }>;
  modifiedby: WebExpand<hr_QuestionandAnswers_Expand, SystemUser_Select, SystemUser_Filter, { modifiedby: SystemUser_Result }>;
  modifiedonbehalfby: WebExpand<hr_QuestionandAnswers_Expand, SystemUser_Select, SystemUser_Filter, { modifiedonbehalfby: SystemUser_Result }>;
  ownerid: WebExpand<hr_QuestionandAnswers_Expand, SystemUser_Select, SystemUser_Filter, { ownerid: SystemUser_Result }>;
  owninguser: WebExpand<hr_QuestionandAnswers_Expand, SystemUser_Select, SystemUser_Filter, { owninguser: SystemUser_Result }>;
}
interface hr_QuestionandAnswers_FormattedResult {
  createdby_formatted?: string;
  createdon_formatted?: string;
  createdonbehalfby_formatted?: string;
  hr_answeredon_formatted?: string;
  hr_askedon_formatted?: string;
  hr_hrcase_formatted?: string;
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
interface hr_QuestionandAnswers_Result extends hr_QuestionandAnswers_Base, hr_QuestionandAnswers_Relationships {
  "@odata.etag": string;
  createdby_guid: string | null;
  createdonbehalfby_guid: string | null;
  hr_hrcase_guid: string | null;
  modifiedby_guid: string | null;
  modifiedonbehalfby_guid: string | null;
  ownerid_guid: string | null;
  owningbusinessunit_guid: string | null;
  owningteam_guid: string | null;
  owninguser_guid: string | null;
}
interface hr_QuestionandAnswers_RelatedOne {
  createdby: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
  createdonbehalfby: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
  hr_HRCase: WebMappingRetrieve<hr_HRCase_Select,hr_HRCase_Expand,hr_HRCase_Filter,hr_HRCase_Fixed,hr_HRCase_Result,hr_HRCase_FormattedResult>;
  modifiedby: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
  modifiedonbehalfby: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
  ownerid: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
  owninguser: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
}
interface hr_QuestionandAnswers_RelatedMany {
}
interface WebEntitiesRetrieve {
  hr_questionandanswerses: WebMappingRetrieve<hr_QuestionandAnswers_Select,hr_QuestionandAnswers_Expand,hr_QuestionandAnswers_Filter,hr_QuestionandAnswers_Fixed,hr_QuestionandAnswers_Result,hr_QuestionandAnswers_FormattedResult>;
}
interface WebEntitiesRelated {
  hr_questionandanswerses: WebMappingRelated<hr_QuestionandAnswers_RelatedOne,hr_QuestionandAnswers_RelatedMany>;
}
interface WebEntitiesCUDA {
  hr_questionandanswerses: WebMappingCUDA<hr_QuestionandAnswers_Create,hr_QuestionandAnswers_Update,hr_QuestionandAnswers_Select>;
}
