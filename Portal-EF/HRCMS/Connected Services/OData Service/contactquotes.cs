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
        /// There are no comments for contactquotesSingle in the schema.
        /// </summary>
    public partial class contactquotesSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<contactquotes>
    {
        /// <summary>
        /// Initialize a new contactquotesSingle object.
        /// </summary>
        public contactquotesSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new contactquotesSingle object.
        /// </summary>
        public contactquotesSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new contactquotesSingle object.
        /// </summary>
        public contactquotesSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<contactquotes> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for contactquotes_AsyncOperations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.CRM.asyncoperation> contactquotes_AsyncOperations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._contactquotes_AsyncOperations == null))
                {
                    this._contactquotes_AsyncOperations = Context.CreateQuery<global::Microsoft.Dynamics.CRM.asyncoperation>(GetPath("contactquotes_AsyncOperations"));
                }
                return this._contactquotes_AsyncOperations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.CRM.asyncoperation> _contactquotes_AsyncOperations;
        /// <summary>
        /// There are no comments for contactquotes_MailboxTrackingFolders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.CRM.mailboxtrackingfolder> contactquotes_MailboxTrackingFolders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._contactquotes_MailboxTrackingFolders == null))
                {
                    this._contactquotes_MailboxTrackingFolders = Context.CreateQuery<global::Microsoft.Dynamics.CRM.mailboxtrackingfolder>(GetPath("contactquotes_MailboxTrackingFolders"));
                }
                return this._contactquotes_MailboxTrackingFolders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.CRM.mailboxtrackingfolder> _contactquotes_MailboxTrackingFolders;
        /// <summary>
        /// There are no comments for contactquotes_BulkDeleteFailures in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.CRM.bulkdeletefailure> contactquotes_BulkDeleteFailures
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._contactquotes_BulkDeleteFailures == null))
                {
                    this._contactquotes_BulkDeleteFailures = Context.CreateQuery<global::Microsoft.Dynamics.CRM.bulkdeletefailure>(GetPath("contactquotes_BulkDeleteFailures"));
                }
                return this._contactquotes_BulkDeleteFailures;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.CRM.bulkdeletefailure> _contactquotes_BulkDeleteFailures;
        /// <summary>
        /// There are no comments for contactquotes_PrincipalObjectAttributeAccesses in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.CRM.principalobjectattributeaccess> contactquotes_PrincipalObjectAttributeAccesses
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._contactquotes_PrincipalObjectAttributeAccesses == null))
                {
                    this._contactquotes_PrincipalObjectAttributeAccesses = Context.CreateQuery<global::Microsoft.Dynamics.CRM.principalobjectattributeaccess>(GetPath("contactquotes_PrincipalObjectAttributeAccesses"));
                }
                return this._contactquotes_PrincipalObjectAttributeAccesses;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.CRM.principalobjectattributeaccess> _contactquotes_PrincipalObjectAttributeAccesses;
    }
        /// <summary>
        /// There are no comments for contactquotes in the schema.
        /// </summary>
    /// <KeyProperties>
    /// contactquoteid
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("contactquoteid")]
    public partial class contactquotes : crmbaseentity
    {
        /// <summary>
        /// There are no comments for Property importsequencenumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<int> importsequencenumber
        {
            get
            {
                return this._importsequencenumber;
            }
            set
            {
                this.OnimportsequencenumberChanging(value);
                this._importsequencenumber = value;
                this.OnimportsequencenumberChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _importsequencenumber;
        partial void OnimportsequencenumberChanging(global::System.Nullable<int> value);
        partial void OnimportsequencenumberChanged();
        /// <summary>
        /// There are no comments for Property quoteid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> quoteid
        {
            get
            {
                return this._quoteid;
            }
            set
            {
                this.OnquoteidChanging(value);
                this._quoteid = value;
                this.OnquoteidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _quoteid;
        partial void OnquoteidChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnquoteidChanged();
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
        /// There are no comments for Property overriddencreatedon in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> overriddencreatedon
        {
            get
            {
                return this._overriddencreatedon;
            }
            set
            {
                this.OnoverriddencreatedonChanging(value);
                this._overriddencreatedon = value;
                this.OnoverriddencreatedonChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _overriddencreatedon;
        partial void OnoverriddencreatedonChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnoverriddencreatedonChanged();
        /// <summary>
        /// There are no comments for Property utcconversiontimezonecode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<int> utcconversiontimezonecode
        {
            get
            {
                return this._utcconversiontimezonecode;
            }
            set
            {
                this.OnutcconversiontimezonecodeChanging(value);
                this._utcconversiontimezonecode = value;
                this.OnutcconversiontimezonecodeChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _utcconversiontimezonecode;
        partial void OnutcconversiontimezonecodeChanging(global::System.Nullable<int> value);
        partial void OnutcconversiontimezonecodeChanged();
        /// <summary>
        /// There are no comments for Property contactquoteid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> contactquoteid
        {
            get
            {
                return this._contactquoteid;
            }
            set
            {
                this.OncontactquoteidChanging(value);
                this._contactquoteid = value;
                this.OncontactquoteidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _contactquoteid;
        partial void OncontactquoteidChanging(global::System.Nullable<global::System.Guid> value);
        partial void OncontactquoteidChanged();
        /// <summary>
        /// There are no comments for Property contactid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> contactid
        {
            get
            {
                return this._contactid;
            }
            set
            {
                this.OncontactidChanging(value);
                this._contactid = value;
                this.OncontactidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _contactid;
        partial void OncontactidChanging(global::System.Nullable<global::System.Guid> value);
        partial void OncontactidChanged();
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
        /// There are no comments for Property timezoneruleversionnumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<int> timezoneruleversionnumber
        {
            get
            {
                return this._timezoneruleversionnumber;
            }
            set
            {
                this.OntimezoneruleversionnumberChanging(value);
                this._timezoneruleversionnumber = value;
                this.OntimezoneruleversionnumberChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _timezoneruleversionnumber;
        partial void OntimezoneruleversionnumberChanging(global::System.Nullable<int> value);
        partial void OntimezoneruleversionnumberChanged();
        /// <summary>
        /// There are no comments for Property contactquotes_AsyncOperations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.asyncoperation> contactquotes_AsyncOperations
        {
            get
            {
                return this._contactquotes_AsyncOperations;
            }
            set
            {
                this.Oncontactquotes_AsyncOperationsChanging(value);
                this._contactquotes_AsyncOperations = value;
                this.Oncontactquotes_AsyncOperationsChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.asyncoperation> _contactquotes_AsyncOperations = new global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.asyncoperation>();
        partial void Oncontactquotes_AsyncOperationsChanging(global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.asyncoperation> value);
        partial void Oncontactquotes_AsyncOperationsChanged();
        /// <summary>
        /// There are no comments for Property contactquotes_MailboxTrackingFolders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.mailboxtrackingfolder> contactquotes_MailboxTrackingFolders
        {
            get
            {
                return this._contactquotes_MailboxTrackingFolders;
            }
            set
            {
                this.Oncontactquotes_MailboxTrackingFoldersChanging(value);
                this._contactquotes_MailboxTrackingFolders = value;
                this.Oncontactquotes_MailboxTrackingFoldersChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.mailboxtrackingfolder> _contactquotes_MailboxTrackingFolders = new global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.mailboxtrackingfolder>();
        partial void Oncontactquotes_MailboxTrackingFoldersChanging(global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.mailboxtrackingfolder> value);
        partial void Oncontactquotes_MailboxTrackingFoldersChanged();
        /// <summary>
        /// There are no comments for Property contactquotes_BulkDeleteFailures in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.bulkdeletefailure> contactquotes_BulkDeleteFailures
        {
            get
            {
                return this._contactquotes_BulkDeleteFailures;
            }
            set
            {
                this.Oncontactquotes_BulkDeleteFailuresChanging(value);
                this._contactquotes_BulkDeleteFailures = value;
                this.Oncontactquotes_BulkDeleteFailuresChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.bulkdeletefailure> _contactquotes_BulkDeleteFailures = new global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.bulkdeletefailure>();
        partial void Oncontactquotes_BulkDeleteFailuresChanging(global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.bulkdeletefailure> value);
        partial void Oncontactquotes_BulkDeleteFailuresChanged();
        /// <summary>
        /// There are no comments for Property contactquotes_PrincipalObjectAttributeAccesses in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.principalobjectattributeaccess> contactquotes_PrincipalObjectAttributeAccesses
        {
            get
            {
                return this._contactquotes_PrincipalObjectAttributeAccesses;
            }
            set
            {
                this.Oncontactquotes_PrincipalObjectAttributeAccessesChanging(value);
                this._contactquotes_PrincipalObjectAttributeAccesses = value;
                this.Oncontactquotes_PrincipalObjectAttributeAccessesChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.principalobjectattributeaccess> _contactquotes_PrincipalObjectAttributeAccesses = new global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.principalobjectattributeaccess>();
        partial void Oncontactquotes_PrincipalObjectAttributeAccessesChanging(global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.principalobjectattributeaccess> value);
        partial void Oncontactquotes_PrincipalObjectAttributeAccessesChanged();
    }
}