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
        /// There are no comments for importentitymappingSingle in the schema.
        /// </summary>
    public partial class importentitymappingSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<importentitymapping>
    {
        /// <summary>
        /// Initialize a new importentitymappingSingle object.
        /// </summary>
        public importentitymappingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new importentitymappingSingle object.
        /// </summary>
        public importentitymappingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new importentitymappingSingle object.
        /// </summary>
        public importentitymappingSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<importentitymapping> query)
            : base(query) {}

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
        /// There are no comments for importmapid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.CRM.importmapSingle importmapid
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._importmapid == null))
                {
                    this._importmapid = new global::Microsoft.Dynamics.CRM.importmapSingle(this.Context, GetPath("importmapid"));
                }
                return this._importmapid;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.CRM.importmapSingle _importmapid;
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
    }
        /// <summary>
        /// There are no comments for importentitymapping in the schema.
        /// </summary>
    /// <KeyProperties>
    /// importentitymappingid
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("importentitymappingid")]
    public partial class importentitymapping : crmbaseentity
    {
        /// <summary>
        /// Create a new importentitymapping object.
        /// </summary>
        /// <param name="modifiedby">Initial value of modifiedby.</param>
        /// <param name="createdby">Initial value of createdby.</param>
        /// <param name="importmapid">Initial value of importmapid.</param>
        /// <param name="createdonbehalfby">Initial value of createdonbehalfby.</param>
        /// <param name="modifiedonbehalfby">Initial value of modifiedonbehalfby.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static importentitymapping Createimportentitymapping(global::Microsoft.Dynamics.CRM.systemuser modifiedby, global::Microsoft.Dynamics.CRM.systemuser createdby, global::Microsoft.Dynamics.CRM.importmap importmapid, global::Microsoft.Dynamics.CRM.systemuser createdonbehalfby, global::Microsoft.Dynamics.CRM.systemuser modifiedonbehalfby)
        {
            importentitymapping importentitymapping = new importentitymapping();
            if ((modifiedby == null))
            {
                throw new global::System.ArgumentNullException("modifiedby");
            }
            importentitymapping.modifiedby = modifiedby;
            if ((createdby == null))
            {
                throw new global::System.ArgumentNullException("createdby");
            }
            importentitymapping.createdby = createdby;
            if ((importmapid == null))
            {
                throw new global::System.ArgumentNullException("importmapid");
            }
            importentitymapping.importmapid = importmapid;
            if ((createdonbehalfby == null))
            {
                throw new global::System.ArgumentNullException("createdonbehalfby");
            }
            importentitymapping.createdonbehalfby = createdonbehalfby;
            if ((modifiedonbehalfby == null))
            {
                throw new global::System.ArgumentNullException("modifiedonbehalfby");
            }
            importentitymapping.modifiedonbehalfby = modifiedonbehalfby;
            return importentitymapping;
        }
        /// <summary>
        /// There are no comments for Property statuscode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<int> statuscode
        {
            get
            {
                return this._statuscode;
            }
            set
            {
                this.OnstatuscodeChanging(value);
                this._statuscode = value;
                this.OnstatuscodeChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _statuscode;
        partial void OnstatuscodeChanging(global::System.Nullable<int> value);
        partial void OnstatuscodeChanged();
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
        /// There are no comments for Property processcode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<int> processcode
        {
            get
            {
                return this._processcode;
            }
            set
            {
                this.OnprocesscodeChanging(value);
                this._processcode = value;
                this.OnprocesscodeChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _processcode;
        partial void OnprocesscodeChanging(global::System.Nullable<int> value);
        partial void OnprocesscodeChanged();
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
        /// There are no comments for Property dedupe in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<int> dedupe
        {
            get
            {
                return this._dedupe;
            }
            set
            {
                this.OndedupeChanging(value);
                this._dedupe = value;
                this.OndedupeChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _dedupe;
        partial void OndedupeChanging(global::System.Nullable<int> value);
        partial void OndedupeChanged();
        /// <summary>
        /// There are no comments for Property importentitymappingidunique in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> importentitymappingidunique
        {
            get
            {
                return this._importentitymappingidunique;
            }
            set
            {
                this.OnimportentitymappingiduniqueChanging(value);
                this._importentitymappingidunique = value;
                this.OnimportentitymappingiduniqueChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _importentitymappingidunique;
        partial void OnimportentitymappingiduniqueChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnimportentitymappingiduniqueChanged();
        /// <summary>
        /// There are no comments for Property importentitymappingid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> importentitymappingid
        {
            get
            {
                return this._importentitymappingid;
            }
            set
            {
                this.OnimportentitymappingidChanging(value);
                this._importentitymappingid = value;
                this.OnimportentitymappingidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _importentitymappingid;
        partial void OnimportentitymappingidChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnimportentitymappingidChanged();
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
        /// There are no comments for Property sourceentityname in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string sourceentityname
        {
            get
            {
                return this._sourceentityname;
            }
            set
            {
                this.OnsourceentitynameChanging(value);
                this._sourceentityname = value;
                this.OnsourceentitynameChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _sourceentityname;
        partial void OnsourceentitynameChanging(string value);
        partial void OnsourceentitynameChanged();
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
        /// There are no comments for Property targetentityname in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string targetentityname
        {
            get
            {
                return this._targetentityname;
            }
            set
            {
                this.OntargetentitynameChanging(value);
                this._targetentityname = value;
                this.OntargetentitynameChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _targetentityname;
        partial void OntargetentitynameChanging(string value);
        partial void OntargetentitynameChanged();
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
        /// There are no comments for Property _importmapid_value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> _importmapid_value
        {
            get
            {
                return this.__importmapid_value;
            }
            set
            {
                this.On_importmapid_valueChanging(value);
                this.__importmapid_value = value;
                this.On_importmapid_valueChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> __importmapid_value;
        partial void On_importmapid_valueChanging(global::System.Nullable<global::System.Guid> value);
        partial void On_importmapid_valueChanged();
        /// <summary>
        /// There are no comments for Property statecode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<int> statecode
        {
            get
            {
                return this._statecode;
            }
            set
            {
                this.OnstatecodeChanging(value);
                this._statecode = value;
                this.OnstatecodeChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _statecode;
        partial void OnstatecodeChanging(global::System.Nullable<int> value);
        partial void OnstatecodeChanged();
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
        /// There are no comments for Property importmapid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.CRM.importmap importmapid
        {
            get
            {
                return this._importmapid;
            }
            set
            {
                this.OnimportmapidChanging(value);
                this._importmapid = value;
                this.OnimportmapidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.CRM.importmap _importmapid;
        partial void OnimportmapidChanging(global::Microsoft.Dynamics.CRM.importmap value);
        partial void OnimportmapidChanged();
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
    }
}
