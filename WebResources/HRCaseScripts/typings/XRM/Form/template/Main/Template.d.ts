declare namespace Form.template.Main {
  namespace Template {
    namespace Tabs {
      interface Template extends Xrm.SectionCollectionBase {
        get(name: "Details"): Xrm.PageSection;
        get(name: "Template editor"): Xrm.PageSection;
        get(name: string): undefined;
        get(): Xrm.PageSection[];
        get(index: number): Xrm.PageSection;
        get(chooser: (item: Xrm.PageSection, index: number) => boolean): Xrm.PageSection[];
      }
    }
    interface Attributes extends Xrm.AttributeCollectionBase {
      get(name: "description"): Xrm.Attribute<string>;
      get(name: "ispersonal"): Xrm.OptionSetAttribute<boolean>;
      get(name: "languagecode"): Xrm.Attribute<any>;
      get(name: "ownerid"): Xrm.LookupAttribute<"systemuser" | "team">;
      get(name: "safehtml"): Xrm.Attribute<string>;
      get(name: "subjectsafehtml"): Xrm.Attribute<any>;
      get(name: "templatetypecode"): Xrm.Attribute<any>;
      get(name: "title"): Xrm.Attribute<string>;
      get(name: string): undefined;
      get(): Xrm.Attribute<any>[];
      get(index: number): Xrm.Attribute<any>;
      get(chooser: (item: Xrm.Attribute<any>, index: number) => boolean): Xrm.Attribute<any>[];
    }
    interface Controls extends Xrm.ControlCollectionBase {
      get(name: "attachmentsGrid"): Xrm.BaseControl;
      get(name: "category"): Xrm.Control<Xrm.Attribute<any>>;
      get(name: "description"): Xrm.StringControl;
      get(name: "header_ownerid"): Xrm.LookupControl<"systemuser" | "team">;
      get(name: "language"): Xrm.Control<Xrm.Attribute<any>>;
      get(name: "permissionLevelId"): Xrm.OptionSetControl<boolean>;
      get(name: "safehtml"): Xrm.StringControl;
      get(name: "subjectsafehtml"): Xrm.Control<Xrm.Attribute<any>>;
      get(name: "title"): Xrm.StringControl;
      get(name: string): undefined;
      get(): Xrm.BaseControl[];
      get(index: number): Xrm.BaseControl;
      get(chooser: (item: Xrm.BaseControl, index: number) => boolean): Xrm.BaseControl[];
    }
    interface Tabs extends Xrm.TabCollectionBase {
      get(name: "Template"): Xrm.PageTab<Tabs.Template>;
      get(name: string): undefined;
      get(): Xrm.PageTab<Xrm.Collection<Xrm.PageSection>>[];
      get(index: number): Xrm.PageTab<Xrm.Collection<Xrm.PageSection>>;
      get(chooser: (item: Xrm.PageTab<Xrm.Collection<Xrm.PageSection>>, index: number) => boolean): Xrm.PageTab<Xrm.Collection<Xrm.PageSection>>[];
    }
  }
  interface Template extends Xrm.PageBase<Template.Attributes,Template.Tabs,Template.Controls> {
    getAttribute(attributeName: "description"): Xrm.Attribute<string>;
    getAttribute(attributeName: "ispersonal"): Xrm.OptionSetAttribute<boolean>;
    getAttribute(attributeName: "languagecode"): Xrm.Attribute<any>;
    getAttribute(attributeName: "ownerid"): Xrm.LookupAttribute<"systemuser" | "team">;
    getAttribute(attributeName: "safehtml"): Xrm.Attribute<string>;
    getAttribute(attributeName: "subjectsafehtml"): Xrm.Attribute<any>;
    getAttribute(attributeName: "templatetypecode"): Xrm.Attribute<any>;
    getAttribute(attributeName: "title"): Xrm.Attribute<string>;
    getAttribute(attributeName: string): undefined;
    getControl(controlName: "attachmentsGrid"): Xrm.BaseControl;
    getControl(controlName: "category"): Xrm.Control<Xrm.Attribute<any>>;
    getControl(controlName: "description"): Xrm.StringControl;
    getControl(controlName: "header_ownerid"): Xrm.LookupControl<"systemuser" | "team">;
    getControl(controlName: "language"): Xrm.Control<Xrm.Attribute<any>>;
    getControl(controlName: "permissionLevelId"): Xrm.OptionSetControl<boolean>;
    getControl(controlName: "safehtml"): Xrm.StringControl;
    getControl(controlName: "subjectsafehtml"): Xrm.Control<Xrm.Attribute<any>>;
    getControl(controlName: "title"): Xrm.StringControl;
    getControl(controlName: string): undefined;
  }
}
