interface Template_Base extends WebEntity {
  body?: string | null;
  componentstate?: componentstate | null;
  createdon?: Date | null;
  description?: string | null;
  entityimageid?: string | null;
  generationtypecode?: number | null;
  importsequencenumber?: number | null;
  introducedversion?: string | null;
  iscustomizable?: any | null;
  ismanaged?: boolean | null;
  ispersonal?: boolean | null;
  isrecommended?: boolean | null;
  languagecode?: number | null;
  mimetype?: string | null;
  modifiedon?: Date | null;
  opencount?: number | null;
  openrate?: number | null;
  overwritetime?: Date | null;
  presentationxml?: string | null;
  replycount?: number | null;
  replyrate?: number | null;
  safehtml?: string | null;
  solutionid?: string | null;
  subject?: string | null;
  subjectpresentationxml?: string | null;
  subjectsafehtml?: string | null;
  supportingsolutionid?: string | null;
  templateid?: string | null;
  templateidunique?: string | null;
  templatetypecode?: string | null;
  title?: string | null;
  usedcount?: number | null;
  versionnumber?: number | null;
}
interface Template_Relationships {
}
interface Template extends Template_Base, Template_Relationships {
  ownerid_bind$systemusers?: string | null;
  ownerid_bind$teams?: string | null;
}
interface Template_Create extends Template {
}
interface Template_Update extends Template {
}
interface Template_Select {
  body: WebAttribute<Template_Select, { body: string | null }, {  }>;
  componentstate: WebAttribute<Template_Select, { componentstate: componentstate | null }, { componentstate_formatted?: string }>;
  createdby_guid: WebAttribute<Template_Select, { createdby_guid: string | null }, { createdby_formatted?: string }>;
  createdon: WebAttribute<Template_Select, { createdon: Date | null }, { createdon_formatted?: string }>;
  createdonbehalfby_guid: WebAttribute<Template_Select, { createdonbehalfby_guid: string | null }, { createdonbehalfby_formatted?: string }>;
  description: WebAttribute<Template_Select, { description: string | null }, {  }>;
  entityimageid: WebAttribute<Template_Select, { entityimageid: string | null }, {  }>;
  generationtypecode: WebAttribute<Template_Select, { generationtypecode: number | null }, {  }>;
  importsequencenumber: WebAttribute<Template_Select, { importsequencenumber: number | null }, {  }>;
  introducedversion: WebAttribute<Template_Select, { introducedversion: string | null }, {  }>;
  iscustomizable: WebAttribute<Template_Select, { iscustomizable: any | null }, {  }>;
  ismanaged: WebAttribute<Template_Select, { ismanaged: boolean | null }, {  }>;
  ispersonal: WebAttribute<Template_Select, { ispersonal: boolean | null }, {  }>;
  isrecommended: WebAttribute<Template_Select, { isrecommended: boolean | null }, {  }>;
  languagecode: WebAttribute<Template_Select, { languagecode: number | null }, {  }>;
  mimetype: WebAttribute<Template_Select, { mimetype: string | null }, {  }>;
  modifiedby_guid: WebAttribute<Template_Select, { modifiedby_guid: string | null }, { modifiedby_formatted?: string }>;
  modifiedon: WebAttribute<Template_Select, { modifiedon: Date | null }, { modifiedon_formatted?: string }>;
  modifiedonbehalfby_guid: WebAttribute<Template_Select, { modifiedonbehalfby_guid: string | null }, { modifiedonbehalfby_formatted?: string }>;
  opencount: WebAttribute<Template_Select, { opencount: number | null }, {  }>;
  openrate: WebAttribute<Template_Select, { openrate: number | null }, {  }>;
  overwritetime: WebAttribute<Template_Select, { overwritetime: Date | null }, { overwritetime_formatted?: string }>;
  ownerid_guid: WebAttribute<Template_Select, { ownerid_guid: string | null }, { ownerid_formatted?: string }>;
  owningbusinessunit_guid: WebAttribute<Template_Select, { owningbusinessunit_guid: string | null }, { owningbusinessunit_formatted?: string }>;
  owningteam_guid: WebAttribute<Template_Select, { owningteam_guid: string | null }, { owningteam_formatted?: string }>;
  owninguser_guid: WebAttribute<Template_Select, { owninguser_guid: string | null }, { owninguser_formatted?: string }>;
  presentationxml: WebAttribute<Template_Select, { presentationxml: string | null }, {  }>;
  replycount: WebAttribute<Template_Select, { replycount: number | null }, {  }>;
  replyrate: WebAttribute<Template_Select, { replyrate: number | null }, {  }>;
  safehtml: WebAttribute<Template_Select, { safehtml: string | null }, {  }>;
  solutionid: WebAttribute<Template_Select, { solutionid: string | null }, {  }>;
  subject: WebAttribute<Template_Select, { subject: string | null }, {  }>;
  subjectpresentationxml: WebAttribute<Template_Select, { subjectpresentationxml: string | null }, {  }>;
  subjectsafehtml: WebAttribute<Template_Select, { subjectsafehtml: string | null }, {  }>;
  supportingsolutionid: WebAttribute<Template_Select, { supportingsolutionid: string | null }, {  }>;
  templateid: WebAttribute<Template_Select, { templateid: string | null }, {  }>;
  templateidunique: WebAttribute<Template_Select, { templateidunique: string | null }, {  }>;
  templatetypecode: WebAttribute<Template_Select, { templatetypecode: string | null }, {  }>;
  title: WebAttribute<Template_Select, { title: string | null }, {  }>;
  usedcount: WebAttribute<Template_Select, { usedcount: number | null }, {  }>;
  versionnumber: WebAttribute<Template_Select, { versionnumber: number | null }, {  }>;
}
interface Template_Filter {
  body: string;
  componentstate: componentstate;
  createdby_guid: XQW.Guid;
  createdon: Date;
  createdonbehalfby_guid: XQW.Guid;
  description: string;
  entityimageid: XQW.Guid;
  generationtypecode: number;
  importsequencenumber: number;
  introducedversion: string;
  iscustomizable: any;
  ismanaged: boolean;
  ispersonal: boolean;
  isrecommended: boolean;
  languagecode: number;
  mimetype: string;
  modifiedby_guid: XQW.Guid;
  modifiedon: Date;
  modifiedonbehalfby_guid: XQW.Guid;
  opencount: number;
  openrate: number;
  overwritetime: Date;
  ownerid_guid: XQW.Guid;
  owningbusinessunit_guid: XQW.Guid;
  owningteam_guid: XQW.Guid;
  owninguser_guid: XQW.Guid;
  presentationxml: string;
  replycount: number;
  replyrate: number;
  safehtml: string;
  solutionid: XQW.Guid;
  subject: string;
  subjectpresentationxml: string;
  subjectsafehtml: string;
  supportingsolutionid: XQW.Guid;
  templateid: XQW.Guid;
  templateidunique: XQW.Guid;
  templatetypecode: string;
  title: string;
  usedcount: number;
  versionnumber: number;
}
interface Template_Expand {
  createdby: WebExpand<Template_Expand, SystemUser_Select, SystemUser_Filter, { createdby: SystemUser_Result }>;
  createdonbehalfby: WebExpand<Template_Expand, SystemUser_Select, SystemUser_Filter, { createdonbehalfby: SystemUser_Result }>;
  modifiedby: WebExpand<Template_Expand, SystemUser_Select, SystemUser_Filter, { modifiedby: SystemUser_Result }>;
  modifiedonbehalfby: WebExpand<Template_Expand, SystemUser_Select, SystemUser_Filter, { modifiedonbehalfby: SystemUser_Result }>;
  ownerid: WebExpand<Template_Expand, SystemUser_Select, SystemUser_Filter, { ownerid: SystemUser_Result }>;
  owninguser: WebExpand<Template_Expand, SystemUser_Select, SystemUser_Filter, { owninguser: SystemUser_Result }>;
}
interface Template_FormattedResult {
  componentstate_formatted?: string;
  createdby_formatted?: string;
  createdon_formatted?: string;
  createdonbehalfby_formatted?: string;
  modifiedby_formatted?: string;
  modifiedon_formatted?: string;
  modifiedonbehalfby_formatted?: string;
  overwritetime_formatted?: string;
  ownerid_formatted?: string;
  owningbusinessunit_formatted?: string;
  owningteam_formatted?: string;
  owninguser_formatted?: string;
}
interface Template_Result extends Template_Base, Template_Relationships {
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
interface Template_RelatedOne {
  createdby: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
  createdonbehalfby: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
  modifiedby: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
  modifiedonbehalfby: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
  ownerid: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
  owninguser: WebMappingRetrieve<SystemUser_Select,SystemUser_Expand,SystemUser_Filter,SystemUser_Fixed,SystemUser_Result,SystemUser_FormattedResult>;
}
interface Template_RelatedMany {
}
interface WebEntitiesRetrieve {
  templates: WebMappingRetrieve<Template_Select,Template_Expand,Template_Filter,Template_Fixed,Template_Result,Template_FormattedResult>;
}
interface WebEntitiesRelated {
  templates: WebMappingRelated<Template_RelatedOne,Template_RelatedMany>;
}
interface WebEntitiesCUDA {
  templates: WebMappingCUDA<Template_Create,Template_Update,Template_Select>;
}
