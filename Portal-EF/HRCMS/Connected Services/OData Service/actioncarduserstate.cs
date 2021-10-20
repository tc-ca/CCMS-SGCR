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
        /// There are no comments for actioncarduserstateSingle in the schema.
        /// </summary>
    public partial class actioncarduserstateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<actioncarduserstate>
    {
        /// <summary>
        /// Initialize a new actioncarduserstateSingle object.
        /// </summary>
        public actioncarduserstateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new actioncarduserstateSingle object.
        /// </summary>
        public actioncarduserstateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new actioncarduserstateSingle object.
        /// </summary>
        public actioncarduserstateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<actioncarduserstate> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for actioncardid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.CRM.actioncardSingle actioncardid
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._actioncardid == null))
                {
                    this._actioncardid = new global::Microsoft.Dynamics.CRM.actioncardSingle(this.Context, GetPath("actioncardid"));
                }
                return this._actioncardid;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.CRM.actioncardSingle _actioncardid;
        /// <summary>
        /// There are no comments for transactioncurrencyid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.CRM.transactioncurrencySingle transactioncurrencyid
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._transactioncurrencyid == null))
                {
                    this._transactioncurrencyid = new global::Microsoft.Dynamics.CRM.transactioncurrencySingle(this.Context, GetPath("transactioncurrencyid"));
                }
                return this._transactioncurrencyid;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.CRM.transactioncurrencySingle _transactioncurrencyid;
        /// <summary>
        /// There are no comments for ownerid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.CRM.principalSingle ownerid
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ownerid == null))
                {
                    this._ownerid = new global::Microsoft.Dynamics.CRM.principalSingle(this.Context, GetPath("ownerid"));
                }
                return this._ownerid;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.CRM.principalSingle _ownerid;
    }
        /// <summary>
        /// There are no comments for actioncarduserstate in the schema.
        /// </summary>
    /// <KeyProperties>
    /// actioncarduserstateid
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("actioncarduserstateid")]
    public partial class actioncarduserstate : crmbaseentity
    {
        /// <summary>
        /// Create a new actioncarduserstate object.
        /// </summary>
        /// <param name="actioncardid">Initial value of actioncardid.</param>
        /// <param name="transactioncurrencyid">Initial value of transactioncurrencyid.</param>
        /// <param name="ownerid">Initial value of ownerid.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static actioncarduserstate Createactioncarduserstate(global::Microsoft.Dynamics.CRM.actioncard actioncardid, global::Microsoft.Dynamics.CRM.transactioncurrency transactioncurrencyid, global::Microsoft.Dynamics.CRM.principal ownerid)
        {
            actioncarduserstate actioncarduserstate = new actioncarduserstate();
            if ((actioncardid == null))
            {
                throw new global::System.ArgumentNullException("actioncardid");
            }
            actioncarduserstate.actioncardid = actioncardid;
            if ((transactioncurrencyid == null))
            {
                throw new global::System.ArgumentNullException("transactioncurrencyid");
            }
            actioncarduserstate.transactioncurrencyid = transactioncurrencyid;
            if ((ownerid == null))
            {
                throw new global::System.ArgumentNullException("ownerid");
            }
            actioncarduserstate.ownerid = ownerid;
            return actioncarduserstate;
        }
        /// <summary>
        /// There are no comments for Property _transactioncurrencyid_value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> _transactioncurrencyid_value
        {
            get
            {
                return this.__transactioncurrencyid_value;
            }
            set
            {
                this.On_transactioncurrencyid_valueChanging(value);
                this.__transactioncurrencyid_value = value;
                this.On_transactioncurrencyid_valueChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> __transactioncurrencyid_value;
        partial void On_transactioncurrencyid_valueChanging(global::System.Nullable<global::System.Guid> value);
        partial void On_transactioncurrencyid_valueChanged();
        /// <summary>
        /// There are no comments for Property actioncarduserstateid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> actioncarduserstateid
        {
            get
            {
                return this._actioncarduserstateid;
            }
            set
            {
                this.OnactioncarduserstateidChanging(value);
                this._actioncarduserstateid = value;
                this.OnactioncarduserstateidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> _actioncarduserstateid;
        partial void OnactioncarduserstateidChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnactioncarduserstateidChanged();
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
        /// There are no comments for Property _ownerid_value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> _ownerid_value
        {
            get
            {
                return this.__ownerid_value;
            }
            set
            {
                this.On_ownerid_valueChanging(value);
                this.__ownerid_value = value;
                this.On_ownerid_valueChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> __ownerid_value;
        partial void On_ownerid_valueChanging(global::System.Nullable<global::System.Guid> value);
        partial void On_ownerid_valueChanged();
        /// <summary>
        /// There are no comments for Property exchangerate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<decimal> exchangerate
        {
            get
            {
                return this._exchangerate;
            }
            set
            {
                this.OnexchangerateChanging(value);
                this._exchangerate = value;
                this.OnexchangerateChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<decimal> _exchangerate;
        partial void OnexchangerateChanging(global::System.Nullable<decimal> value);
        partial void OnexchangerateChanged();
        /// <summary>
        /// There are no comments for Property _owningbusinessunit_value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> _owningbusinessunit_value
        {
            get
            {
                return this.__owningbusinessunit_value;
            }
            set
            {
                this.On_owningbusinessunit_valueChanging(value);
                this.__owningbusinessunit_value = value;
                this.On_owningbusinessunit_valueChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> __owningbusinessunit_value;
        partial void On_owningbusinessunit_valueChanging(global::System.Nullable<global::System.Guid> value);
        partial void On_owningbusinessunit_valueChanged();
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
        /// There are no comments for Property startdate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> startdate
        {
            get
            {
                return this._startdate;
            }
            set
            {
                this.OnstartdateChanging(value);
                this._startdate = value;
                this.OnstartdateChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _startdate;
        partial void OnstartdateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnstartdateChanged();
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
        /// There are no comments for Property _actioncardid_value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::System.Guid> _actioncardid_value
        {
            get
            {
                return this.__actioncardid_value;
            }
            set
            {
                this.On_actioncardid_valueChanging(value);
                this.__actioncardid_value = value;
                this.On_actioncardid_valueChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.Guid> __actioncardid_value;
        partial void On_actioncardid_valueChanging(global::System.Nullable<global::System.Guid> value);
        partial void On_actioncardid_valueChanged();
        /// <summary>
        /// There are no comments for Property state in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<int> state
        {
            get
            {
                return this._state;
            }
            set
            {
                this.OnstateChanging(value);
                this._state = value;
                this.OnstateChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _state;
        partial void OnstateChanging(global::System.Nullable<int> value);
        partial void OnstateChanged();
        /// <summary>
        /// There are no comments for Property actioncardid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.CRM.actioncard actioncardid
        {
            get
            {
                return this._actioncardid;
            }
            set
            {
                this.OnactioncardidChanging(value);
                this._actioncardid = value;
                this.OnactioncardidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.CRM.actioncard _actioncardid;
        partial void OnactioncardidChanging(global::Microsoft.Dynamics.CRM.actioncard value);
        partial void OnactioncardidChanged();
        /// <summary>
        /// There are no comments for Property transactioncurrencyid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.CRM.transactioncurrency transactioncurrencyid
        {
            get
            {
                return this._transactioncurrencyid;
            }
            set
            {
                this.OntransactioncurrencyidChanging(value);
                this._transactioncurrencyid = value;
                this.OntransactioncurrencyidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.CRM.transactioncurrency _transactioncurrencyid;
        partial void OntransactioncurrencyidChanging(global::Microsoft.Dynamics.CRM.transactioncurrency value);
        partial void OntransactioncurrencyidChanged();
        /// <summary>
        /// There are no comments for Property ownerid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.CRM.principal ownerid
        {
            get
            {
                return this._ownerid;
            }
            set
            {
                this.OnowneridChanging(value);
                this._ownerid = value;
                this.OnowneridChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.CRM.principal _ownerid;
        partial void OnowneridChanging(global::Microsoft.Dynamics.CRM.principal value);
        partial void OnowneridChanged();
    }
}
