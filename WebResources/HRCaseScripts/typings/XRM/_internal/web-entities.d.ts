interface WebMappingRetrieve<ISelect, IExpand, IFilter, IFixed, Result, FormattedResult> {
}
interface WebMappingCUDA<ICreate, IUpdate, ISelect> {
}
interface WebMappingRelated<ISingle, IMultiple> {
}
interface WebEntity {
}
interface WebEntity_Fixed {
  "@odata.etag": string;
}
interface hr_CaseSubType_Base extends WebEntity {
}
interface hr_CaseSubType_Fixed extends WebEntity_Fixed {
  hr_casesubtypeid: string;
}
interface hr_CaseSubType extends hr_CaseSubType_Base, hr_CaseSubType_Relationships {
}
interface hr_CaseSubType_Relationships {
}
interface hr_CaseSubType_Result extends hr_CaseSubType_Base, hr_CaseSubType_Relationships {
}
interface hr_CaseSubType_FormattedResult {
}
interface hr_CaseSubType_Select {
}
interface hr_CaseSubType_Expand {
}
interface hr_CaseSubType_Filter {
}
interface hr_CaseSubType_Create extends hr_CaseSubType {
}
interface hr_CaseSubType_Update extends hr_CaseSubType {
}
interface hr_CaseType_Base extends WebEntity {
}
interface hr_CaseType_Fixed extends WebEntity_Fixed {
  hr_casetypeid: string;
}
interface hr_CaseType extends hr_CaseType_Base, hr_CaseType_Relationships {
}
interface hr_CaseType_Relationships {
}
interface hr_CaseType_Result extends hr_CaseType_Base, hr_CaseType_Relationships {
}
interface hr_CaseType_FormattedResult {
}
interface hr_CaseType_Select {
}
interface hr_CaseType_Expand {
}
interface hr_CaseType_Filter {
}
interface hr_CaseType_Create extends hr_CaseType {
}
interface hr_CaseType_Update extends hr_CaseType {
}
interface hr_CaseType_hr_CaseSubType_Base extends WebEntity {
}
interface hr_CaseType_hr_CaseSubType_Fixed extends WebEntity_Fixed {
  hr_casetype_hr_casesubtypeid: string;
}
interface hr_CaseType_hr_CaseSubType extends hr_CaseType_hr_CaseSubType_Base, hr_CaseType_hr_CaseSubType_Relationships {
}
interface hr_CaseType_hr_CaseSubType_Relationships {
}
interface hr_CaseType_hr_CaseSubType_Result extends hr_CaseType_hr_CaseSubType_Base, hr_CaseType_hr_CaseSubType_Relationships {
}
interface hr_CaseType_hr_CaseSubType_FormattedResult {
}
interface hr_CaseType_hr_CaseSubType_Select {
}
interface hr_CaseType_hr_CaseSubType_Expand {
}
interface hr_CaseType_hr_CaseSubType_Filter {
}
interface hr_CaseType_hr_CaseSubType_Create extends hr_CaseType_hr_CaseSubType {
}
interface hr_CaseType_hr_CaseSubType_Update extends hr_CaseType_hr_CaseSubType {
}
interface hr_HRCase_Base extends WebEntity {
}
interface hr_HRCase_Fixed extends WebEntity_Fixed {
  hr_hrcaseid: string;
}
interface hr_HRCase extends hr_HRCase_Base, hr_HRCase_Relationships {
}
interface hr_HRCase_Relationships {
}
interface hr_HRCase_Result extends hr_HRCase_Base, hr_HRCase_Relationships {
}
interface hr_HRCase_FormattedResult {
}
interface hr_HRCase_Select {
}
interface hr_HRCase_Expand {
}
interface hr_HRCase_Filter {
}
interface hr_HRCase_Create extends hr_HRCase {
}
interface hr_HRCase_Update extends hr_HRCase {
}
interface hr_QuestionandAnswers_Base extends WebEntity {
}
interface hr_QuestionandAnswers_Fixed extends WebEntity_Fixed {
  hr_questionandanswersid: string;
}
interface hr_QuestionandAnswers extends hr_QuestionandAnswers_Base, hr_QuestionandAnswers_Relationships {
}
interface hr_QuestionandAnswers_Relationships {
}
interface hr_QuestionandAnswers_Result extends hr_QuestionandAnswers_Base, hr_QuestionandAnswers_Relationships {
}
interface hr_QuestionandAnswers_FormattedResult {
}
interface hr_QuestionandAnswers_Select {
}
interface hr_QuestionandAnswers_Expand {
}
interface hr_QuestionandAnswers_Filter {
}
interface hr_QuestionandAnswers_Create extends hr_QuestionandAnswers {
}
interface hr_QuestionandAnswers_Update extends hr_QuestionandAnswers {
}
interface SystemUser_Base extends WebEntity {
}
interface SystemUser_Fixed extends WebEntity_Fixed {
  systemuserid: string;
}
interface SystemUser extends SystemUser_Base, SystemUser_Relationships {
}
interface SystemUser_Relationships {
}
interface SystemUser_Result extends SystemUser_Base, SystemUser_Relationships {
}
interface SystemUser_FormattedResult {
}
interface SystemUser_Select {
}
interface SystemUser_Expand {
}
interface SystemUser_Filter {
}
interface SystemUser_Create extends SystemUser {
}
interface SystemUser_Update extends SystemUser {
}
interface Template_Base extends WebEntity {
}
interface Template_Fixed extends WebEntity_Fixed {
  templateid: string;
}
interface Template extends Template_Base, Template_Relationships {
}
interface Template_Relationships {
}
interface Template_Result extends Template_Base, Template_Relationships {
}
interface Template_FormattedResult {
}
interface Template_Select {
}
interface Template_Expand {
}
interface Template_Filter {
}
interface Template_Create extends Template {
}
interface Template_Update extends Template {
}
interface Post_Base extends WebEntity {
}
interface Post_Fixed extends WebEntity_Fixed {
  postid: string;
}
interface Post extends Post_Base, Post_Relationships {
}
interface Post_Relationships {
}
interface Post_Result extends Post_Base, Post_Relationships {
}
interface Post_FormattedResult {
}
interface Post_Select {
}
interface Post_Expand {
}
interface Post_Filter {
}
interface Post_Create extends Post {
}
interface Post_Update extends Post {
}
interface Connection_Base extends WebEntity {
}
interface Connection_Fixed extends WebEntity_Fixed {
  connectionid: string;
}
interface Connection extends Connection_Base, Connection_Relationships {
}
interface Connection_Relationships {
}
interface Connection_Result extends Connection_Base, Connection_Relationships {
}
interface Connection_FormattedResult {
}
interface Connection_Select {
}
interface Connection_Expand {
}
interface Connection_Filter {
}
interface Connection_Create extends Connection {
}
interface Connection_Update extends Connection {
}
interface PostFollow_Base extends WebEntity {
}
interface PostFollow_Fixed extends WebEntity_Fixed {
  postfollowid: string;
}
interface PostFollow extends PostFollow_Base, PostFollow_Relationships {
}
interface PostFollow_Relationships {
}
interface PostFollow_Result extends PostFollow_Base, PostFollow_Relationships {
}
interface PostFollow_FormattedResult {
}
interface PostFollow_Select {
}
interface PostFollow_Expand {
}
interface PostFollow_Filter {
}
interface PostFollow_Create extends PostFollow {
}
interface PostFollow_Update extends PostFollow {
}
