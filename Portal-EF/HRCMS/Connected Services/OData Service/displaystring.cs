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
        /// There are no comments for displaystringSingle in the schema.
        /// </summary>
    public partial class displaystringSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<displaystring>
    {
        /// <summary>
        /// Initialize a new displaystringSingle object.
        /// </summary>
        public displaystringSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new displaystringSingle object.
        /// </summary>
        public displaystringSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new displaystringSingle object.
        /// </summary>
        public displaystringSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<displaystring> query)
            : base(query) {}

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
        /// <summary>
        /// There are no comments for DisplayString_AsyncOperations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.CRM.asyncoperation> DisplayString_AsyncOperations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DisplayString_AsyncOperations == null))
                {
                    this._DisplayString_AsyncOperations = Context.CreateQuery<global::Microsoft.Dynamics.CRM.asyncoperation>(GetPath("DisplayString_AsyncOperations"));
                }
                return this._DisplayString_AsyncOperations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.CRM.asyncoperation> _DisplayString_AsyncOperations;
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
        /// There are no comments for DisplayString_BulkDeleteFailures in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.CRM.bulkdeletefailure> DisplayString_BulkDeleteFailures
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DisplayString_BulkDeleteFailures == null))
                {
                    this._DisplayString_BulkDeleteFailures = Context.CreateQuery<global::Microsoft.Dynamics.CRM.bulkdeletefailure>(GetPath("DisplayString_BulkDeleteFailures"));
                }
                return this._DisplayString_BulkDeleteFailures;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.CRM.bulkdeletefailure> _DisplayString_BulkDeleteFailures;
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
    }
        /// <summary>
        /// There are no comments for displaystring in the schema.
        /// </summary>
    /// <KeyProperties>
    /// displaystringid
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("displaystringid")]
    public partial class displaystring : crmbaseentity
    {
        /// <summary>
        /// Create a new displaystring object.
        /// </summary>
        /// <param name="modifiedonbehalfby">Initial value of modifiedonbehalfby.</param>
        /// <param name="createdby">Initial value of createdby.</param>
        /// <param name="organizationid">Initial value of organizationid.</param>
        /// <param name="createdonbehalfby">Initial value of createdonbehalfby.</param>
        /// <param name="modifiedby">Initial value of modifiedby.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static displaystring Createdisplaystring(global::Microsoft.Dynamics.CRM.systemuser modifiedonbehalfby, global::Microsoft.Dynamics.CRM.systemuser createdby, global::Microsoft.Dynamics.CRM.organization organizationid, global::Microsoft.Dynamics.CRM.systemuser createdonbehalfby, global::Microsoft.Dynamics.CRM.systemuser modifiedby)
        {
            displaystring displaystring = new displaystring();
            if ((modifiedonbehalfby == null))
            {
                throw new global::System.ArgumentNullException("modifiedonbehalfby");
            }
            displaystring.modifiedonbehalfby = modifiedonbehalfby;
            if ((createdby == null))
            {
                throw new global::System.ArgumentNullException("createdby");
            }
            displaystring.createdby = createdby;
            if ((organizationid == null))
            {
                throw new global::System.ArgumentNullException("organizationid");
            }
            displaystring.organizationid = organizationid;
            if ((createdonbehalfby == null))
            {
                throw new global::System.ArgumentNullException("createdonbehalfby");
            }
            displaystring.createdonbehalfby = createdonbehalfby;
            if ((modifiedby == null))
            {
                throw new global::System.ArgumentNullException("modifiedby");
            }
            displaystring.modifiedby = modifiedby;
            return displaystring;
        }
        /// <summary>
        /// There are no comments for Property customdisplaystring in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string customdisplaystring
        {
            get
            {
                return this._customdisplaystring;
            }
            set
            {
                this.OncustomdisplaystringChanging(value);
                this._customdisplaystring = value;
                this.OncustomdisplaystringChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _customdisplaystring;
        partial void OncustomdisplaystringChanging(string value);
        partial void OncustomdisplaystringChanged();
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
        /// There are no comments for Property languagecode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<int> languagecode
        {
            get
            {
                return this._languagecode;
            }
            set
            {
                this.OnlanguagecodeChanging(value);
                this._languagecode = value;
                this.OnlanguagecodeChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _languagecode;
        partial void OnlanguagecodeChanging(global::System.Nullable<int> value);
        partial void OnlanguagecodeChanged();
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
        /// There are no comments for Property displaystringid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> displaystringid
        {
            get
            {
                return this._displaystringid;
            }
            set
            {
                this.OndisplaystringidChanging(value);
                this._displaystringid = value;
                this.OndisplaystringidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _displaystringid;
        partial void OndisplaystringidChanging(global::System.Nullable<global::System.Guid> value);
        partial void OndisplaystringidChanged();
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
        /// There are no comments for Property customcomment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string customcomment
        {
            get
            {
                return this._customcomment;
            }
            set
            {
                this.OncustomcommentChanging(value);
                this._customcomment = value;
                this.OncustomcommentChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _customcomment;
        partial void OncustomcommentChanging(string value);
        partial void OncustomcommentChanged();
        /// <summary>
        /// There are no comments for Property displaystringidunique in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> displaystringidunique
        {
            get
            {
                return this._displaystringidunique;
            }
            set
            {
                this.OndisplaystringiduniqueChanging(value);
                this._displaystringidunique = value;
                this.OndisplaystringiduniqueChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _displaystringidunique;
        partial void OndisplaystringiduniqueChanging(global::System.Nullable<global::System.Guid> value);
        partial void OndisplaystringiduniqueChanged();
        /// <summary>
        /// There are no comments for Property formatparameters in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<int> formatparameters
        {
            get
            {
                return this._formatparameters;
            }
            set
            {
                this.OnformatparametersChanging(value);
                this._formatparameters = value;
                this.OnformatparametersChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _formatparameters;
        partial void OnformatparametersChanging(global::System.Nullable<int> value);
        partial void OnformatparametersChanged();
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
        /// There are no comments for Property publisheddisplaystring in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string publisheddisplaystring
        {
            get
            {
                return this._publisheddisplaystring;
            }
            set
            {
                this.OnpublisheddisplaystringChanging(value);
                this._publisheddisplaystring = value;
                this.OnpublisheddisplaystringChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _publisheddisplaystring;
        partial void OnpublisheddisplaystringChanging(string value);
        partial void OnpublisheddisplaystringChanged();
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
        /// There are no comments for Property displaystringkey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string displaystringkey
        {
            get
            {
                return this._displaystringkey;
            }
            set
            {
                this.OndisplaystringkeyChanging(value);
                this._displaystringkey = value;
                this.OndisplaystringkeyChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _displaystringkey;
        partial void OndisplaystringkeyChanging(string value);
        partial void OndisplaystringkeyChanged();
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
        /// <summary>
        /// There are no comments for Property DisplayString_AsyncOperations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.asyncoperation> DisplayString_AsyncOperations
        {
            get
            {
                return this._DisplayString_AsyncOperations;
            }
            set
            {
                this.OnDisplayString_AsyncOperationsChanging(value);
                this._DisplayString_AsyncOperations = value;
                this.OnDisplayString_AsyncOperationsChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.asyncoperation> _DisplayString_AsyncOperations = new global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.asyncoperation>();
        partial void OnDisplayString_AsyncOperationsChanging(global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.asyncoperation> value);
        partial void OnDisplayString_AsyncOperationsChanged();
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
        /// There are no comments for Property DisplayString_BulkDeleteFailures in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.bulkdeletefailure> DisplayString_BulkDeleteFailures
        {
            get
            {
                return this._DisplayString_BulkDeleteFailures;
            }
            set
            {
                this.OnDisplayString_BulkDeleteFailuresChanging(value);
                this._DisplayString_BulkDeleteFailures = value;
                this.OnDisplayString_BulkDeleteFailuresChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.bulkdeletefailure> _DisplayString_BulkDeleteFailures = new global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.bulkdeletefailure>();
        partial void OnDisplayString_BulkDeleteFailuresChanging(global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.bulkdeletefailure> value);
        partial void OnDisplayString_BulkDeleteFailuresChanged();
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
    }
}