declare namespace Form.hr_casetype.Main {
  namespace Information {
    namespace Tabs {
    }
    interface Attributes extends Xrm.AttributeCollectionBase {
      get(name: "hr_name"): Xrm.Attribute<string>;
      get(name: "hr_nameen"): Xrm.Attribute<string>;
      get(name: "hr_namefr"): Xrm.Attribute<string>;
      get(name: "hr_sortorder"): Xrm.NumberAttribute;
      get(name: "ownerid"): Xrm.LookupAttribute<"systemuser" | "team">;
      get(name: string): undefined;
      get(): Xrm.Attribute<any>[];
      get(index: number): Xrm.Attribute<any>;
      get(chooser: (item: Xrm.Attribute<any>, index: number) => boolean): Xrm.Attribute<any>[];
    }
    interface Controls extends Xrm.ControlCollectionBase {
      get(name: "Subgrid_1"): Xrm.SubGridControl<"hr_casesubtype">;
      get(name: "hr_name"): Xrm.StringControl;
      get(name: "hr_nameen"): Xrm.StringControl;
      get(name: "hr_namefr"): Xrm.StringControl;
      get(name: "hr_sortorder"): Xrm.NumberControl;
      get(name: "ownerid"): Xrm.LookupControl<"systemuser" | "team">;
      get(name: string): undefined;
      get(): Xrm.BaseControl[];
      get(index: number): Xrm.BaseControl;
      get(chooser: (item: Xrm.BaseControl, index: number) => boolean): Xrm.BaseControl[];
    }
    interface Tabs extends Xrm.TabCollectionBase {
      get(name: string): undefined;
      get(): Xrm.PageTab<Xrm.Collection<Xrm.PageSection>>[];
      get(index: number): Xrm.PageTab<Xrm.Collection<Xrm.PageSection>>;
      get(chooser: (item: Xrm.PageTab<Xrm.Collection<Xrm.PageSection>>, index: number) => boolean): Xrm.PageTab<Xrm.Collection<Xrm.PageSection>>[];
    }
  }
  interface Information extends Xrm.PageBase<Information.Attributes,Information.Tabs,Information.Controls> {
    getAttribute(attributeName: "hr_name"): Xrm.Attribute<string>;
    getAttribute(attributeName: "hr_nameen"): Xrm.Attribute<string>;
    getAttribute(attributeName: "hr_namefr"): Xrm.Attribute<string>;
    getAttribute(attributeName: "hr_sortorder"): Xrm.NumberAttribute;
    getAttribute(attributeName: "ownerid"): Xrm.LookupAttribute<"systemuser" | "team">;
    getAttribute(attributeName: string): undefined;
    getControl(controlName: "Subgrid_1"): Xrm.SubGridControl<"hr_casesubtype">;
    getControl(controlName: "hr_name"): Xrm.StringControl;
    getControl(controlName: "hr_nameen"): Xrm.StringControl;
    getControl(controlName: "hr_namefr"): Xrm.StringControl;
    getControl(controlName: "hr_sortorder"): Xrm.NumberControl;
    getControl(controlName: "ownerid"): Xrm.LookupControl<"systemuser" | "team">;
    getControl(controlName: string): undefined;
  }
}
