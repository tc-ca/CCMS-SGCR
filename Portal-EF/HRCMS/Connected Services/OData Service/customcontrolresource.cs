﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2021-02-15 3:55:30 PM
namespace Microsoft.Dynamics.CRM
{
        /// <summary>
        /// There are no comments for customcontrolresourceSingle in the schema.
        /// </summary>
    public partial class customcontrolresourceSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<customcontrolresource>
    {
        /// <summary>
        /// Initialize a new customcontrolresourceSingle object.
        /// </summary>
        public customcontrolresourceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new customcontrolresourceSingle object.
        /// </summary>
        public customcontrolresourceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new customcontrolresourceSingle object.
        /// </summary>
        public customcontrolresourceSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<customcontrolresource> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for customcontrolid_customcontrol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.CRM.customcontrolSingle customcontrolid_customcontrol
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._customcontrolid_customcontrol == null))
                {
                    this._customcontrolid_customcontrol = new global::Microsoft.Dynamics.CRM.customcontrolSingle(this.Context, GetPath("customcontrolid_customcontrol"));
                }
                return this._customcontrolid_customcontrol;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.CRM.customcontrolSingle _customcontrolid_customcontrol;
        /// <summary>
        /// There are no comments for createdby in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.CRM.systemuserSingle createdby
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._createdby == null))
                {
                    this._createdby = new global::Microsoft.Dynamics.CRM.systemuserSingle(this.Context, GetPath("createdby"));
                }
                return this._createdby;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.CRM.systemuserSingle _createdby;
        /// <summary>
        /// There are no comments for modifiedby in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.CRM.systemuserSingle modifiedby
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._modifiedby == null))
                {
                    this._modifiedby = new global::Microsoft.Dynamics.CRM.systemuserSingle(this.Context, GetPath("modifiedby"));
                }
                return this._modifiedby;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.CRM.systemuserSingle _modifiedby;
        /// <summary>
        /// There are no comments for createdonbehalfby in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.CRM.systemuserSingle createdonbehalfby
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._createdonbehalfby == null))
                {
                    this._createdonbehalfby = new global::Microsoft.Dynamics.CRM.systemuserSingle(this.Context, GetPath("createdonbehalfby"));
                }
                return this._createdonbehalfby;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.CRM.systemuserSingle _createdonbehalfby;
        /// <summary>
        /// There are no comments for modifiedonbehalfby in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.CRM.systemuserSingle modifiedonbehalfby
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._modifiedonbehalfby == null))
                {
                    this._modifiedonbehalfby = new global::Microsoft.Dynamics.CRM.systemuserSingle(this.Context, GetPath("modifiedonbehalfby"));
                }
                return this._modifiedonbehalfby;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.CRM.systemuserSingle _modifiedonbehalfby;
        /// <summary>
        /// There are no comments for organizationid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.CRM.organizationSingle organizationid
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._organizationid == null))
                {
                    this._organizationid = new global::Microsoft.Dynamics.CRM.organizationSingle(this.Context, GetPath("organizationid"));
                }
                return this._organizationid;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.CRM.organizationSingle _organizationid;
    }
        /// <summary>
        /// There are no comments for customcontrolresource in the schema.
        /// </summary>
    /// <KeyProperties>
    /// customcontrolresourceid
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("customcontrolresourceid")]
    public partial class customcontrolresource : crmbaseentity
    {
        /// <summary>
        /// Create a new customcontrolresource object.
        /// </summary>
        /// <param name="customcontrolid_customcontrol">Initial value of customcontrolid_customcontrol.</param>
        /// <param name="createdby">Initial value of createdby.</param>
        /// <param name="modifiedby">Initial value of modifiedby.</param>
        /// <param name="createdonbehalfby">Initial value of createdonbehalfby.</param>
        /// <param name="modifiedonbehalfby">Initial value of modifiedonbehalfby.</param>
        /// <param name="organizationid">Initial value of organizationid.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static customcontrolresource Createcustomcontrolresource(global::Microsoft.Dynamics.CRM.customcontrol customcontrolid_customcontrol, 
                    global::Microsoft.Dynamics.CRM.systemuser createdby, 
                    global::Microsoft.Dynamics.CRM.systemuser modifiedby, 
                    global::Microsoft.Dynamics.CRM.systemuser createdonbehalfby, 
                    global::Microsoft.Dynamics.CRM.systemuser modifiedonbehalfby, 
                    global::Microsoft.Dynamics.CRM.organization organizationid)
        {
            customcontrolresource customcontrolresource = new customcontrolresource();
            if ((customcontrolid_customcontrol == null))
            {
                throw new global::System.ArgumentNullException("customcontrolid_customcontrol");
            }
            customcontrolresource.customcontrolid_customcontrol = customcontrolid_customcontrol;
            if ((createdby == null))
            {
                throw new global::System.ArgumentNullException("createdby");
            }
            customcontrolresource.createdby = createdby;
            if ((modifiedby == null))
            {
                throw new global::System.ArgumentNullException("modifiedby");
            }
            customcontrolresource.modifiedby = modifiedby;
            if ((createdonbehalfby == null))
            {
                throw new global::System.ArgumentNullException("createdonbehalfby");
            }
            customcontrolresource.createdonbehalfby = createdonbehalfby;
            if ((modifiedonbehalfby == null))
            {
                throw new global::System.ArgumentNullException("modifiedonbehalfby");
            }
            customcontrolresource.modifiedonbehalfby = modifiedonbehalfby;
            if ((organizationid == null))
            {
                throw new global::System.ArgumentNullException("organizationid");
            }
            customcontrolresource.organizationid = organizationid;
            return customcontrolresource;
        }
        /// <summary>
        /// There are no comments for Property versionrequirement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string versionrequirement
        {
            get
            {
                return this._versionrequirement;
            }
            set
            {
                this.OnversionrequirementChanging(value);
                this._versionrequirement = value;
                this.OnversionrequirementChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _versionrequirement;
        partial void OnversionrequirementChanging(string value);
        partial void OnversionrequirementChanged();
        /// <summary>
        /// There are no comments for Property _organizationid_value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> _organizationid_value
        {
            get
            {
                return this.__organizationid_value;
            }
            set
            {
                this.On_organizationid_valueChanging(value);
                this.__organizationid_value = value;
                this.On_organizationid_valueChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> __organizationid_value;
        partial void On_organizationid_valueChanging(global::System.Nullable<global::System.Guid> value);
        partial void On_organizationid_valueChanged();
        /// <summary>
        /// There are no comments for Property version in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string version
        {
            get
            {
                return this._version;
            }
            set
            {
                this.OnversionChanging(value);
                this._version = value;
                this.OnversionChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _version;
        partial void OnversionChanging(string value);
        partial void OnversionChanged();
        /// <summary>
        /// There are no comments for Property componentstate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<int> componentstate
        {
            get
            {
                return this._componentstate;
            }
            set
            {
                this.OncomponentstateChanging(value);
                this._componentstate = value;
                this.OncomponentstateChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _componentstate;
        partial void OncomponentstateChanging(global::System.Nullable<int> value);
        partial void OncomponentstateChanged();
        /// <summary>
        /// There are no comments for Property customcontrolresourceid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> customcontrolresourceid
        {
            get
            {
                return this._customcontrolresourceid;
            }
            set
            {
                this.OncustomcontrolresourceidChanging(value);
                this._customcontrolresourceid = value;
                this.OncustomcontrolresourceidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _customcontrolresourceid;
        partial void OncustomcontrolresourceidChanging(global::System.Nullable<global::System.Guid> value);
        partial void OncustomcontrolresourceidChanged();
        /// <summary>
        /// There are no comments for Property versionnumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<long> versionnumber
        {
            get
            {
                return this._versionnumber;
            }
            set
            {
                this.OnversionnumberChanging(value);
                this._versionnumber = value;
                this.OnversionnumberChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<long> _versionnumber;
        partial void OnversionnumberChanging(global::System.Nullable<long> value);
        partial void OnversionnumberChanged();
        /// <summary>
        /// There are no comments for Property _modifiedonbehalfby_value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> _modifiedonbehalfby_value
        {
            get
            {
                return this.__modifiedonbehalfby_value;
            }
            set
            {
                this.On_modifiedonbehalfby_valueChanging(value);
                this.__modifiedonbehalfby_value = value;
                this.On_modifiedonbehalfby_valueChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> __modifiedonbehalfby_value;
        partial void On_modifiedonbehalfby_valueChanging(global::System.Nullable<global::System.Guid> value);
        partial void On_modifiedonbehalfby_valueChanged();
        /// <summary>
        /// There are no comments for Property solutionid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> solutionid
        {
            get
            {
                return this._solutionid;
            }
            set
            {
                this.OnsolutionidChanging(value);
                this._solutionid = value;
                this.OnsolutionidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _solutionid;
        partial void OnsolutionidChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnsolutionidChanged();
        /// <summary>
        /// There are no comments for Property overwritetime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> overwritetime
        {
            get
            {
                return this._overwritetime;
            }
            set
            {
                this.OnoverwritetimeChanging(value);
                this._overwritetime = value;
                this.OnoverwritetimeChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _overwritetime;
        partial void OnoverwritetimeChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnoverwritetimeChanged();
        /// <summary>
        /// There are no comments for Property modifiedon in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> modifiedon
        {
            get
            {
                return this._modifiedon;
            }
            set
            {
                this.OnmodifiedonChanging(value);
                this._modifiedon = value;
                this.OnmodifiedonChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _modifiedon;
        partial void OnmodifiedonChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnmodifiedonChanged();
        /// <summary>
        /// There are no comments for Property _createdby_value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> _createdby_value
        {
            get
            {
                return this.__createdby_value;
            }
            set
            {
                this.On_createdby_valueChanging(value);
                this.__createdby_value = value;
                this.On_createdby_valueChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> __createdby_value;
        partial void On_createdby_valueChanging(global::System.Nullable<global::System.Guid> value);
        partial void On_createdby_valueChanged();
        /// <summary>
        /// There are no comments for Property introducedversion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string introducedversion
        {
            get
            {
                return this._introducedversion;
            }
            set
            {
                this.OnintroducedversionChanging(value);
                this._introducedversion = value;
                this.OnintroducedversionChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _introducedversion;
        partial void OnintroducedversionChanging(string value);
        partial void OnintroducedversionChanged();
        /// <summary>
        /// There are no comments for Property customcontrolresourceidunique in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> customcontrolresourceidunique
        {
            get
            {
                return this._customcontrolresourceidunique;
            }
            set
            {
                this.OncustomcontrolresourceiduniqueChanging(value);
                this._customcontrolresourceidunique = value;
                this.OncustomcontrolresourceiduniqueChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _customcontrolresourceidunique;
        partial void OncustomcontrolresourceiduniqueChanging(global::System.Nullable<global::System.Guid> value);
        partial void OncustomcontrolresourceiduniqueChanged();
        /// <summary>
        /// There are no comments for Property createdon in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> createdon
        {
            get
            {
                return this._createdon;
            }
            set
            {
                this.OncreatedonChanging(value);
                this._createdon = value;
                this.OncreatedonChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _createdon;
        partial void OncreatedonChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OncreatedonChanged();
        /// <summary>
        /// There are no comments for Property name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this.OnnameChanging(value);
                this._name = value;
                this.OnnameChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _name;
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        /// <summary>
        /// There are no comments for Property webresourceid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> webresourceid
        {
            get
            {
                return this._webresourceid;
            }
            set
            {
                this.OnwebresourceidChanging(value);
                this._webresourceid = value;
                this.OnwebresourceidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _webresourceid;
        partial void OnwebresourceidChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnwebresourceidChanged();
        /// <summary>
        /// There are no comments for Property ismanaged in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<bool> ismanaged
        {
            get
            {
                return this._ismanaged;
            }
            set
            {
                this.OnismanagedChanging(value);
                this._ismanaged = value;
                this.OnismanagedChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _ismanaged;
        partial void OnismanagedChanging(global::System.Nullable<bool> value);
        partial void OnismanagedChanged();
        /// <summary>
        /// There are no comments for Property _createdonbehalfby_value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> _createdonbehalfby_value
        {
            get
            {
                return this.__createdonbehalfby_value;
            }
            set
            {
                this.On_createdonbehalfby_valueChanging(value);
                this.__createdonbehalfby_value = value;
                this.On_createdonbehalfby_valueChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> __createdonbehalfby_value;
        partial void On_createdonbehalfby_valueChanging(global::System.Nullable<global::System.Guid> value);
        partial void On_createdonbehalfby_valueChanged();
        /// <summary>
        /// There are no comments for Property _modifiedby_value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> _modifiedby_value
        {
            get
            {
                return this.__modifiedby_value;
            }
            set
            {
                this.On_modifiedby_valueChanging(value);
                this.__modifiedby_value = value;
                this.On_modifiedby_valueChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> __modifiedby_value;
        partial void On_modifiedby_valueChanging(global::System.Nullable<global::System.Guid> value);
        partial void On_modifiedby_valueChanged();
        /// <summary>
        /// There are no comments for Property customcontrolid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> customcontrolid
        {
            get
            {
                return this._customcontrolid;
            }
            set
            {
                this.OncustomcontrolidChanging(value);
                this._customcontrolid = value;
                this.OncustomcontrolidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _customcontrolid;
        partial void OncustomcontrolidChanging(global::System.Nullable<global::System.Guid> value);
        partial void OncustomcontrolidChanged();
        /// <summary>
        /// There are no comments for Property customcontrolid_customcontrol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.CRM.customcontrol customcontrolid_customcontrol
        {
            get
            {
                return this._customcontrolid_customcontrol;
            }
            set
            {
                this.Oncustomcontrolid_customcontrolChanging(value);
                this._customcontrolid_customcontrol = value;
                this.Oncustomcontrolid_customcontrolChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.CRM.customcontrol _customcontrolid_customcontrol;
        partial void Oncustomcontrolid_customcontrolChanging(global::Microsoft.Dynamics.CRM.customcontrol value);
        partial void Oncustomcontrolid_customcontrolChanged();
        /// <summary>
        /// There are no comments for Property createdby in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.CRM.systemuser createdby
        {
            get
            {
                return this._createdby;
            }
            set
            {
                this.OncreatedbyChanging(value);
                this._createdby = value;
                this.OncreatedbyChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.CRM.systemuser _createdby;
        partial void OncreatedbyChanging(global::Microsoft.Dynamics.CRM.systemuser value);
        partial void OncreatedbyChanged();
        /// <summary>
        /// There are no comments for Property modifiedby in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.CRM.systemuser modifiedby
        {
            get
            {
                return this._modifiedby;
            }
            set
            {
                this.OnmodifiedbyChanging(value);
                this._modifiedby = value;
                this.OnmodifiedbyChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.CRM.systemuser _modifiedby;
        partial void OnmodifiedbyChanging(global::Microsoft.Dynamics.CRM.systemuser value);
        partial void OnmodifiedbyChanged();
        /// <summary>
        /// There are no comments for Property createdonbehalfby in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.CRM.systemuser createdonbehalfby
        {
            get
            {
                return this._createdonbehalfby;
            }
            set
            {
                this.OncreatedonbehalfbyChanging(value);
                this._createdonbehalfby = value;
                this.OncreatedonbehalfbyChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.CRM.systemuser _createdonbehalfby;
        partial void OncreatedonbehalfbyChanging(global::Microsoft.Dynamics.CRM.systemuser value);
        partial void OncreatedonbehalfbyChanged();
        /// <summary>
        /// There are no comments for Property modifiedonbehalfby in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.CRM.systemuser modifiedonbehalfby
        {
            get
            {
                return this._modifiedonbehalfby;
            }
            set
            {
                this.OnmodifiedonbehalfbyChanging(value);
                this._modifiedonbehalfby = value;
                this.OnmodifiedonbehalfbyChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.CRM.systemuser _modifiedonbehalfby;
        partial void OnmodifiedonbehalfbyChanging(global::Microsoft.Dynamics.CRM.systemuser value);
        partial void OnmodifiedonbehalfbyChanged();
        /// <summary>
        /// There are no comments for Property organizationid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.CRM.organization organizationid
        {
            get
            {
                return this._organizationid;
            }
            set
            {
                this.OnorganizationidChanging(value);
                this._organizationid = value;
                this.OnorganizationidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.CRM.organization _organizationid;
        partial void OnorganizationidChanging(global::Microsoft.Dynamics.CRM.organization value);
        partial void OnorganizationidChanged();
    }
}
