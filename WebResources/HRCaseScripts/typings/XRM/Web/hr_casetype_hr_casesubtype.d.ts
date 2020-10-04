interface hr_CaseType_hr_CaseSubType_Base extends WebEntity {
  hr_casesubtypeid?: string | null;
  hr_casetype_hr_casesubtypeid?: string | null;
  hr_casetypeid?: string | null;
  versionnumber?: number | null;
}
interface hr_CaseType_hr_CaseSubType_Relationships {
  hr_CaseType_hr_CaseSubType_hr_CaseSubType?: hr_CaseType_Result[] | null;
}
interface hr_CaseType_hr_CaseSubType extends hr_CaseType_hr_CaseSubType_Base, hr_CaseType_hr_CaseSubType_Relationships {
}
interface hr_CaseType_hr_CaseSubType_Create extends hr_CaseType_hr_CaseSubType {
}
interface hr_CaseType_hr_CaseSubType_Update extends hr_CaseType_hr_CaseSubType {
}
interface hr_CaseType_hr_CaseSubType_Select {
  hr_casesubtypeid: WebAttribute<hr_CaseType_hr_CaseSubType_Select, { hr_casesubtypeid: string | null }, {  }>;
  hr_casetype_hr_casesubtypeid: WebAttribute<hr_CaseType_hr_CaseSubType_Select, { hr_casetype_hr_casesubtypeid: string | null }, {  }>;
  hr_casetypeid: WebAttribute<hr_CaseType_hr_CaseSubType_Select, { hr_casetypeid: string | null }, {  }>;
  versionnumber: WebAttribute<hr_CaseType_hr_CaseSubType_Select, { versionnumber: number | null }, {  }>;
}
interface hr_CaseType_hr_CaseSubType_Filter {
  hr_casesubtypeid: XQW.Guid;
  hr_casetype_hr_casesubtypeid: XQW.Guid;
  hr_casetypeid: XQW.Guid;
  versionnumber: number;
}
interface hr_CaseType_hr_CaseSubType_Expand {
  hr_CaseType_hr_CaseSubType_hr_CaseSubType: WebExpand<hr_CaseType_hr_CaseSubType_Expand, hr_CaseType_Select, hr_CaseType_Filter, { hr_CaseType_hr_CaseSubType_hr_CaseSubType: hr_CaseType_Result[] }>;
}
interface hr_CaseType_hr_CaseSubType_FormattedResult {
}
interface hr_CaseType_hr_CaseSubType_Result extends hr_CaseType_hr_CaseSubType_Base, hr_CaseType_hr_CaseSubType_Relationships {
  "@odata.etag": string;
}
interface hr_CaseType_hr_CaseSubType_RelatedOne {
}
interface hr_CaseType_hr_CaseSubType_RelatedMany {
  hr_CaseType_hr_CaseSubType_hr_CaseSubType: WebMappingRetrieve<hr_CaseType_Select,hr_CaseType_Expand,hr_CaseType_Filter,hr_CaseType_Fixed,hr_CaseType_Result,hr_CaseType_FormattedResult>;
}
interface WebEntitiesRetrieve {
  hr_casetype_hr_casesubtypeset: WebMappingRetrieve<hr_CaseType_hr_CaseSubType_Select,hr_CaseType_hr_CaseSubType_Expand,hr_CaseType_hr_CaseSubType_Filter,hr_CaseType_hr_CaseSubType_Fixed,hr_CaseType_hr_CaseSubType_Result,hr_CaseType_hr_CaseSubType_FormattedResult>;
}
interface WebEntitiesRelated {
  hr_casetype_hr_casesubtypeset: WebMappingRelated<hr_CaseType_hr_CaseSubType_RelatedOne,hr_CaseType_hr_CaseSubType_RelatedMany>;
}
interface WebEntitiesCUDA {
  hr_casetype_hr_casesubtypeset: WebMappingCUDA<hr_CaseType_hr_CaseSubType_Create,hr_CaseType_hr_CaseSubType_Update,hr_CaseType_hr_CaseSubType_Select>;
}
