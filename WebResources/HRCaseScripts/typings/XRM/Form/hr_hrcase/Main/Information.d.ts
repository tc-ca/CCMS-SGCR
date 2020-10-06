declare namespace Form.hr_hrcase.Main {
  namespace Information {
    namespace Tabs {
      interface tab_2 extends Xrm.SectionCollectionBase {
        get(name: "tab_2_section_1"): Xrm.PageSection;
        get(name: string): undefined;
        get(): Xrm.PageSection[];
        get(index: number): Xrm.PageSection;
        get(chooser: (item: Xrm.PageSection, index: number) => boolean): Xrm.PageSection[];
      }
      interface tab_general extends Xrm.SectionCollectionBase {
        get(name: "null_section_3"): Xrm.PageSection;
        get(name: "null_section_4"): Xrm.PageSection;
        get(name: "{14ce5bae-9b40-4cd0-88ee-a315c445572a}"): Xrm.PageSection;
        get(name: string): undefined;
        get(): Xrm.PageSection[];
        get(index: number): Xrm.PageSection;
        get(chooser: (item: Xrm.PageSection, index: number) => boolean): Xrm.PageSection[];
      }
    }
    interface Attributes extends Xrm.AttributeCollectionBase {
      get(name: "createdby"): Xrm.LookupAttribute<"systemuser">;
      get(name: "createdon"): Xrm.DateAttribute;
      get(name: "hr_casestatus"): Xrm.OptionSetAttribute<hr_casestatus>;
      get(name: "hr_casesubtype"): Xrm.LookupAttribute<"hr_casesubtype">;
      get(name: "hr_casetype"): Xrm.LookupAttribute<"hr_casetype">;
      get(name: "hr_closedon"): Xrm.DateAttribute;
      get(name: "hr_datereceived"): Xrm.DateAttribute;
      get(name: "hr_description"): Xrm.Attribute<string>;
      get(name: "hr_email"): Xrm.Attribute<string>;
      get(name: "hr_firstname"): Xrm.Attribute<string>;
      get(name: "hr_lastname"): Xrm.Attribute<string>;
      get(name: "hr_name"): Xrm.Attribute<string>;
      get(name: "hr_pri"): Xrm.Attribute<string>;
      get(name: "hr_priority"): Xrm.OptionSetAttribute<boolean>;
      get(name: "hr_resolution"): Xrm.Attribute<any>;
      get(name: "modifiedby"): Xrm.LookupAttribute<"systemuser">;
      get(name: "modifiedon"): Xrm.DateAttribute;
      get(name: "ownerid"): Xrm.LookupAttribute<"systemuser" | "team">;
      get(name: "statecode"): Xrm.OptionSetAttribute<hr_hrcase_statecode>;
      get(name: string): undefined;
      get(): Xrm.Attribute<any>[];
      get(index: number): Xrm.Attribute<any>;
      get(chooser: (item: Xrm.Attribute<any>, index: number) => boolean): Xrm.Attribute<any>[];
    }
    interface Controls extends Xrm.ControlCollectionBase {
      get(name: "QASubgrid"): Xrm.SubGridControl<"hr_questionandanswers">;
      get(name: "createdby"): Xrm.LookupControl<"systemuser">;
      get(name: "createdon"): Xrm.DateControl;
      get(name: "header_hr_casestatus"): Xrm.OptionSetControl<hr_casestatus>;
      get(name: "header_hr_priority"): Xrm.OptionSetControl<boolean>;
      get(name: "header_ownerid"): Xrm.LookupControl<"systemuser" | "team">;
      get(name: "header_statecode"): Xrm.OptionSetControl<hr_hrcase_statecode>;
      get(name: "hr_casestatus"): Xrm.OptionSetControl<hr_casestatus>;
      get(name: "hr_casesubtype"): Xrm.LookupControl<"hr_casesubtype">;
      get(name: "hr_casetype"): Xrm.LookupControl<"hr_casetype">;
      get(name: "hr_closedon"): Xrm.DateControl;
      get(name: "hr_datereceived"): Xrm.DateControl;
      get(name: "hr_datereceived1"): Xrm.DateControl;
      get(name: "hr_description"): Xrm.StringControl;
      get(name: "hr_email"): Xrm.StringControl;
      get(name: "hr_firstname"): Xrm.StringControl;
      get(name: "hr_lastname"): Xrm.StringControl;
      get(name: "hr_name"): Xrm.StringControl;
      get(name: "hr_pri"): Xrm.StringControl;
      get(name: "hr_priority"): Xrm.OptionSetControl<boolean>;
      get(name: "hr_resolution"): Xrm.Control<Xrm.Attribute<any>>;
      get(name: "modifiedby"): Xrm.LookupControl<"systemuser">;
      get(name: "modifiedon"): Xrm.DateControl;
      get(name: "notescontrol"): Xrm.BaseControl;
      get(name: string): undefined;
      get(): Xrm.BaseControl[];
      get(index: number): Xrm.BaseControl;
      get(chooser: (item: Xrm.BaseControl, index: number) => boolean): Xrm.BaseControl[];
    }
    interface Tabs extends Xrm.TabCollectionBase {
      get(name: "tab_2"): Xrm.PageTab<Tabs.tab_2>;
      get(name: "tab_general"): Xrm.PageTab<Tabs.tab_general>;
      get(name: string): undefined;
      get(): Xrm.PageTab<Xrm.Collection<Xrm.PageSection>>[];
      get(index: number): Xrm.PageTab<Xrm.Collection<Xrm.PageSection>>;
      get(chooser: (item: Xrm.PageTab<Xrm.Collection<Xrm.PageSection>>, index: number) => boolean): Xrm.PageTab<Xrm.Collection<Xrm.PageSection>>[];
    }
  }
  interface Information extends Xrm.PageBase<Information.Attributes,Information.Tabs,Information.Controls> {
    getAttribute(attributeName: "createdby"): Xrm.LookupAttribute<"systemuser">;
    getAttribute(attributeName: "createdon"): Xrm.DateAttribute;
    getAttribute(attributeName: "hr_casestatus"): Xrm.OptionSetAttribute<hr_casestatus>;
    getAttribute(attributeName: "hr_casesubtype"): Xrm.LookupAttribute<"hr_casesubtype">;
    getAttribute(attributeName: "hr_casetype"): Xrm.LookupAttribute<"hr_casetype">;
    getAttribute(attributeName: "hr_closedon"): Xrm.DateAttribute;
    getAttribute(attributeName: "hr_datereceived"): Xrm.DateAttribute;
    getAttribute(attributeName: "hr_description"): Xrm.Attribute<string>;
    getAttribute(attributeName: "hr_email"): Xrm.Attribute<string>;
    getAttribute(attributeName: "hr_firstname"): Xrm.Attribute<string>;
    getAttribute(attributeName: "hr_lastname"): Xrm.Attribute<string>;
    getAttribute(attributeName: "hr_name"): Xrm.Attribute<string>;
    getAttribute(attributeName: "hr_pri"): Xrm.Attribute<string>;
    getAttribute(attributeName: "hr_priority"): Xrm.OptionSetAttribute<boolean>;
    getAttribute(attributeName: "hr_resolution"): Xrm.Attribute<any>;
    getAttribute(attributeName: "modifiedby"): Xrm.LookupAttribute<"systemuser">;
    getAttribute(attributeName: "modifiedon"): Xrm.DateAttribute;
    getAttribute(attributeName: "ownerid"): Xrm.LookupAttribute<"systemuser" | "team">;
    getAttribute(attributeName: "statecode"): Xrm.OptionSetAttribute<hr_hrcase_statecode>;
    getAttribute(attributeName: string): undefined;
    getControl(controlName: "QASubgrid"): Xrm.SubGridControl<"hr_questionandanswers">;
    getControl(controlName: "createdby"): Xrm.LookupControl<"systemuser">;
    getControl(controlName: "createdon"): Xrm.DateControl;
    getControl(controlName: "header_hr_casestatus"): Xrm.OptionSetControl<hr_casestatus>;
    getControl(controlName: "header_hr_priority"): Xrm.OptionSetControl<boolean>;
    getControl(controlName: "header_ownerid"): Xrm.LookupControl<"systemuser" | "team">;
    getControl(controlName: "header_statecode"): Xrm.OptionSetControl<hr_hrcase_statecode>;
    getControl(controlName: "hr_casestatus"): Xrm.OptionSetControl<hr_casestatus>;
    getControl(controlName: "hr_casesubtype"): Xrm.LookupControl<"hr_casesubtype">;
    getControl(controlName: "hr_casetype"): Xrm.LookupControl<"hr_casetype">;
    getControl(controlName: "hr_closedon"): Xrm.DateControl;
    getControl(controlName: "hr_datereceived"): Xrm.DateControl;
    getControl(controlName: "hr_datereceived1"): Xrm.DateControl;
    getControl(controlName: "hr_description"): Xrm.StringControl;
    getControl(controlName: "hr_email"): Xrm.StringControl;
    getControl(controlName: "hr_firstname"): Xrm.StringControl;
    getControl(controlName: "hr_lastname"): Xrm.StringControl;
    getControl(controlName: "hr_name"): Xrm.StringControl;
    getControl(controlName: "hr_pri"): Xrm.StringControl;
    getControl(controlName: "hr_priority"): Xrm.OptionSetControl<boolean>;
    getControl(controlName: "hr_resolution"): Xrm.Control<Xrm.Attribute<any>>;
    getControl(controlName: "modifiedby"): Xrm.LookupControl<"systemuser">;
    getControl(controlName: "modifiedon"): Xrm.DateControl;
    getControl(controlName: "notescontrol"): Xrm.BaseControl;
    getControl(controlName: string): undefined;
  }
}
