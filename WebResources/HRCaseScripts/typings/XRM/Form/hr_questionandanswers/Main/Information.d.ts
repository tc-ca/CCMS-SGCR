declare namespace Form.hr_questionandanswers.Main {
  namespace Information {
    namespace Tabs {
    }
    interface Attributes extends Xrm.AttributeCollectionBase {
      get(name: "createdby"): Xrm.LookupAttribute<"systemuser">;
      get(name: "hr_answer"): Xrm.Attribute<string>;
      get(name: "hr_answeredon"): Xrm.DateAttribute;
      get(name: "hr_askedon"): Xrm.DateAttribute;
      get(name: "hr_question"): Xrm.Attribute<string>;
      get(name: "hr_read"): Xrm.Attribute<any>;
      get(name: string): undefined;
      get(): Xrm.Attribute<any>[];
      get(index: number): Xrm.Attribute<any>;
      get(chooser: (item: Xrm.Attribute<any>, index: number) => boolean): Xrm.Attribute<any>[];
    }
    interface Controls extends Xrm.ControlCollectionBase {
      get(name: "createdby"): Xrm.LookupControl<"systemuser">;
      get(name: "hr_answer"): Xrm.StringControl;
      get(name: "hr_answeredon"): Xrm.DateControl;
      get(name: "hr_askedon"): Xrm.DateControl;
      get(name: "hr_question"): Xrm.StringControl;
      get(name: "hr_read"): Xrm.Control<Xrm.Attribute<any>>;
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
    getAttribute(attributeName: "createdby"): Xrm.LookupAttribute<"systemuser">;
    getAttribute(attributeName: "hr_answer"): Xrm.Attribute<string>;
    getAttribute(attributeName: "hr_answeredon"): Xrm.DateAttribute;
    getAttribute(attributeName: "hr_askedon"): Xrm.DateAttribute;
    getAttribute(attributeName: "hr_question"): Xrm.Attribute<string>;
    getAttribute(attributeName: "hr_read"): Xrm.Attribute<any>;
    getAttribute(attributeName: string): undefined;
    getControl(controlName: "createdby"): Xrm.LookupControl<"systemuser">;
    getControl(controlName: "hr_answer"): Xrm.StringControl;
    getControl(controlName: "hr_answeredon"): Xrm.DateControl;
    getControl(controlName: "hr_askedon"): Xrm.DateControl;
    getControl(controlName: "hr_question"): Xrm.StringControl;
    getControl(controlName: "hr_read"): Xrm.Control<Xrm.Attribute<any>>;
    getControl(controlName: string): undefined;
  }
}
