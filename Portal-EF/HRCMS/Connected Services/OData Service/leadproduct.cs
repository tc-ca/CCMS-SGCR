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
        /// There are no comments for leadproductSingle in the schema.
        /// </summary>
    public partial class leadproductSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<leadproduct>
    {
        /// <summary>
        /// Initialize a new leadproductSingle object.
        /// </summary>
        public leadproductSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new leadproductSingle object.
        /// </summary>
        public leadproductSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new leadproductSingle object.
        /// </summary>
        public leadproductSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<leadproduct> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for leadproduct_AsyncOperations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.CRM.asyncoperation> leadproduct_AsyncOperations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._leadproduct_AsyncOperations == null))
                {
                    this._leadproduct_AsyncOperations = Context.CreateQuery<global::Microsoft.Dynamics.CRM.asyncoperation>(GetPath("leadproduct_AsyncOperations"));
                }
                return this._leadproduct_AsyncOperations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.CRM.asyncoperation> _leadproduct_AsyncOperations;
        /// <summary>
        /// There are no comments for leadproduct_MailboxTrackingFolders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.CRM.mailboxtrackingfolder> leadproduct_MailboxTrackingFolders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._leadproduct_MailboxTrackingFolders == null))
                {
                    this._leadproduct_MailboxTrackingFolders = Context.CreateQuery<global::Microsoft.Dynamics.CRM.mailboxtrackingfolder>(GetPath("leadproduct_MailboxTrackingFolders"));
                }
                return this._leadproduct_MailboxTrackingFolders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.CRM.mailboxtrackingfolder> _leadproduct_MailboxTrackingFolders;
        /// <summary>
        /// There are no comments for leadproduct_BulkDeleteFailures in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.CRM.bulkdeletefailure> leadproduct_BulkDeleteFailures
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._leadproduct_BulkDeleteFailures == null))
                {
                    this._leadproduct_BulkDeleteFailures = Context.CreateQuery<global::Microsoft.Dynamics.CRM.bulkdeletefailure>(GetPath("leadproduct_BulkDeleteFailures"));
                }
                return this._leadproduct_BulkDeleteFailures;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.CRM.bulkdeletefailure> _leadproduct_BulkDeleteFailures;
        /// <summary>
        /// There are no comments for leadproduct_PrincipalObjectAttributeAccesses in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.CRM.principalobjectattributeaccess> leadproduct_PrincipalObjectAttributeAccesses
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._leadproduct_PrincipalObjectAttributeAccesses == null))
                {
                    this._leadproduct_PrincipalObjectAttributeAccesses = Context.CreateQuery<global::Microsoft.Dynamics.CRM.principalobjectattributeaccess>(GetPath("leadproduct_PrincipalObjectAttributeAccesses"));
                }
                return this._leadproduct_PrincipalObjectAttributeAccesses;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.CRM.principalobjectattributeaccess> _leadproduct_PrincipalObjectAttributeAccesses;
    }
        /// <summary>
        /// There are no comments for leadproduct in the schema.
        /// </summary>
    /// <KeyProperties>
    /// leadproductid
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("leadproductid")]
    public partial class leadproduct : crmbaseentity
    {
        /// <summary>
        /// There are no comments for Property leadproductid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> leadproductid
        {
            get
            {
                return this._leadproductid;
            }
            set
            {
                this.OnleadproductidChanging(value);
                this._leadproductid = value;
                this.OnleadproductidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _leadproductid;
        partial void OnleadproductidChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnleadproductidChanged();
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
        /// There are no comments for Property leadid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> leadid
        {
            get
            {
                return this._leadid;
            }
            set
            {
                this.OnleadidChanging(value);
                this._leadid = value;
                this.OnleadidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _leadid;
        partial void OnleadidChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnleadidChanged();
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
        /// There are no comments for Property productid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> productid
        {
            get
            {
                return this._productid;
            }
            set
            {
                this.OnproductidChanging(value);
                this._productid = value;
                this.OnproductidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _productid;
        partial void OnproductidChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnproductidChanged();
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
        /// There are no comments for Property leadproduct_AsyncOperations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.asyncoperation> leadproduct_AsyncOperations
        {
            get
            {
                return this._leadproduct_AsyncOperations;
            }
            set
            {
                this.Onleadproduct_AsyncOperationsChanging(value);
                this._leadproduct_AsyncOperations = value;
                this.Onleadproduct_AsyncOperationsChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.asyncoperation> _leadproduct_AsyncOperations = new global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.asyncoperation>();
        partial void Onleadproduct_AsyncOperationsChanging(global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.asyncoperation> value);
        partial void Onleadproduct_AsyncOperationsChanged();
        /// <summary>
        /// There are no comments for Property leadproduct_MailboxTrackingFolders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.mailboxtrackingfolder> leadproduct_MailboxTrackingFolders
        {
            get
            {
                return this._leadproduct_MailboxTrackingFolders;
            }
            set
            {
                this.Onleadproduct_MailboxTrackingFoldersChanging(value);
                this._leadproduct_MailboxTrackingFolders = value;
                this.Onleadproduct_MailboxTrackingFoldersChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.mailboxtrackingfolder> _leadproduct_MailboxTrackingFolders = new global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.mailboxtrackingfolder>();
        partial void Onleadproduct_MailboxTrackingFoldersChanging(global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.mailboxtrackingfolder> value);
        partial void Onleadproduct_MailboxTrackingFoldersChanged();
        /// <summary>
        /// There are no comments for Property leadproduct_BulkDeleteFailures in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.bulkdeletefailure> leadproduct_BulkDeleteFailures
        {
            get
            {
                return this._leadproduct_BulkDeleteFailures;
            }
            set
            {
                this.Onleadproduct_BulkDeleteFailuresChanging(value);
                this._leadproduct_BulkDeleteFailures = value;
                this.Onleadproduct_BulkDeleteFailuresChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.bulkdeletefailure> _leadproduct_BulkDeleteFailures = new global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.bulkdeletefailure>();
        partial void Onleadproduct_BulkDeleteFailuresChanging(global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.bulkdeletefailure> value);
        partial void Onleadproduct_BulkDeleteFailuresChanged();
        /// <summary>
        /// There are no comments for Property leadproduct_PrincipalObjectAttributeAccesses in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.principalobjectattributeaccess> leadproduct_PrincipalObjectAttributeAccesses
        {
            get
            {
                return this._leadproduct_PrincipalObjectAttributeAccesses;
            }
            set
            {
                this.Onleadproduct_PrincipalObjectAttributeAccessesChanging(value);
                this._leadproduct_PrincipalObjectAttributeAccesses = value;
                this.Onleadproduct_PrincipalObjectAttributeAccessesChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.principalobjectattributeaccess> _leadproduct_PrincipalObjectAttributeAccesses = new global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.principalobjectattributeaccess>();
        partial void Onleadproduct_PrincipalObjectAttributeAccessesChanging(global::System.Collections.ObjectModel.Collection<global::Microsoft.Dynamics.CRM.principalobjectattributeaccess> value);
        partial void Onleadproduct_PrincipalObjectAttributeAccessesChanged();
    }
}