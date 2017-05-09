﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace 医院管理系统 {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class sda3 : DataSet {
        
        private _TableDataTable table_Table;
        
        public sda3() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected sda3(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Table"] != null)) {
                    this.Tables.Add(new _TableDataTable(ds.Tables["Table"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public _TableDataTable _Table {
            get {
                return this.table_Table;
            }
        }
        
        public override DataSet Clone() {
            sda3 cln = ((sda3)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["Table"] != null)) {
                this.Tables.Add(new _TableDataTable(ds.Tables["Table"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.table_Table = ((_TableDataTable)(this.Tables["Table"]));
            if ((this.table_Table != null)) {
                this.table_Table.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "sda3";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/sda3.xsd";
            this.Locale = new System.Globalization.CultureInfo("zh-CN");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.table_Table = new _TableDataTable();
            this.Tables.Add(this.table_Table);
        }
        
        private bool ShouldSerialize_Table() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void _TableRowChangeEventHandler(object sender, _TableRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class _TableDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn column挂号号码;
            
            private DataColumn column床号;
            
            private DataColumn column姓名;
            
            private DataColumn column性别;
            
            private DataColumn column年龄;
            
            private DataColumn column级别;
            
            private DataColumn column负责人;
            
            private DataColumn column进出实况;
            
            internal _TableDataTable() : 
                    base("Table") {
                this.InitClass();
            }
            
            internal _TableDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn 挂号号码Column {
                get {
                    return this.column挂号号码;
                }
            }
            
            internal DataColumn 床号Column {
                get {
                    return this.column床号;
                }
            }
            
            internal DataColumn 姓名Column {
                get {
                    return this.column姓名;
                }
            }
            
            internal DataColumn 性别Column {
                get {
                    return this.column性别;
                }
            }
            
            internal DataColumn 年龄Column {
                get {
                    return this.column年龄;
                }
            }
            
            internal DataColumn 级别Column {
                get {
                    return this.column级别;
                }
            }
            
            internal DataColumn 负责人Column {
                get {
                    return this.column负责人;
                }
            }
            
            internal DataColumn 进出实况Column {
                get {
                    return this.column进出实况;
                }
            }
            
            public _TableRow this[int index] {
                get {
                    return ((_TableRow)(this.Rows[index]));
                }
            }
            
            public event _TableRowChangeEventHandler _TableRowChanged;
            
            public event _TableRowChangeEventHandler _TableRowChanging;
            
            public event _TableRowChangeEventHandler _TableRowDeleted;
            
            public event _TableRowChangeEventHandler _TableRowDeleting;
            
            public void Add_TableRow(_TableRow row) {
                this.Rows.Add(row);
            }
            
            public _TableRow Add_TableRow(string 挂号号码, string 床号, string 姓名, string 性别, string 年龄, string 级别, string 负责人, string 进出实况) {
                _TableRow row_TableRow = ((_TableRow)(this.NewRow()));
                row_TableRow.ItemArray = new object[] {
                        挂号号码,
                        床号,
                        姓名,
                        性别,
                        年龄,
                        级别,
                        负责人,
                        进出实况};
                this.Rows.Add(row_TableRow);
                return row_TableRow;
            }
            
            public _TableRow FindBy挂号号码床号(string 挂号号码, string 床号) {
                return ((_TableRow)(this.Rows.Find(new object[] {
                            挂号号码,
                            床号})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                _TableDataTable cln = ((_TableDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new _TableDataTable();
            }
            
            internal void InitVars() {
                this.column挂号号码 = this.Columns["挂号号码"];
                this.column床号 = this.Columns["床号"];
                this.column姓名 = this.Columns["姓名"];
                this.column性别 = this.Columns["性别"];
                this.column年龄 = this.Columns["年龄"];
                this.column级别 = this.Columns["级别"];
                this.column负责人 = this.Columns["负责人"];
                this.column进出实况 = this.Columns["进出实况"];
            }
            
            private void InitClass() {
                this.column挂号号码 = new DataColumn("挂号号码", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.column挂号号码);
                this.column床号 = new DataColumn("床号", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.column床号);
                this.column姓名 = new DataColumn("姓名", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.column姓名);
                this.column性别 = new DataColumn("性别", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.column性别);
                this.column年龄 = new DataColumn("年龄", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.column年龄);
                this.column级别 = new DataColumn("级别", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.column级别);
                this.column负责人 = new DataColumn("负责人", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.column负责人);
                this.column进出实况 = new DataColumn("进出实况", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.column进出实况);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.column挂号号码,
                                this.column床号}, true));
                this.column挂号号码.AllowDBNull = false;
                this.column床号.AllowDBNull = false;
            }
            
            public _TableRow New_TableRow() {
                return ((_TableRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new _TableRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(_TableRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this._TableRowChanged != null)) {
                    this._TableRowChanged(this, new _TableRowChangeEvent(((_TableRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this._TableRowChanging != null)) {
                    this._TableRowChanging(this, new _TableRowChangeEvent(((_TableRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this._TableRowDeleted != null)) {
                    this._TableRowDeleted(this, new _TableRowChangeEvent(((_TableRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this._TableRowDeleting != null)) {
                    this._TableRowDeleting(this, new _TableRowChangeEvent(((_TableRow)(e.Row)), e.Action));
                }
            }
            
            public void Remove_TableRow(_TableRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class _TableRow : DataRow {
            
            private _TableDataTable table_Table;
            
            internal _TableRow(DataRowBuilder rb) : 
                    base(rb) {
                this.table_Table = ((_TableDataTable)(this.Table));
            }
            
            public string 挂号号码 {
                get {
                    return ((string)(this[this.table_Table.挂号号码Column]));
                }
                set {
                    this[this.table_Table.挂号号码Column] = value;
                }
            }
            
            public string 床号 {
                get {
                    return ((string)(this[this.table_Table.床号Column]));
                }
                set {
                    this[this.table_Table.床号Column] = value;
                }
            }
            
            public string 姓名 {
                get {
                    try {
                        return ((string)(this[this.table_Table.姓名Column]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    }
                }
                set {
                    this[this.table_Table.姓名Column] = value;
                }
            }
            
            public string 性别 {
                get {
                    try {
                        return ((string)(this[this.table_Table.性别Column]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    }
                }
                set {
                    this[this.table_Table.性别Column] = value;
                }
            }
            
            public string 年龄 {
                get {
                    try {
                        return ((string)(this[this.table_Table.年龄Column]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    }
                }
                set {
                    this[this.table_Table.年龄Column] = value;
                }
            }
            
            public string 级别 {
                get {
                    try {
                        return ((string)(this[this.table_Table.级别Column]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    }
                }
                set {
                    this[this.table_Table.级别Column] = value;
                }
            }
            
            public string 负责人 {
                get {
                    try {
                        return ((string)(this[this.table_Table.负责人Column]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    }
                }
                set {
                    this[this.table_Table.负责人Column] = value;
                }
            }
            
            public string 进出实况 {
                get {
                    try {
                        return ((string)(this[this.table_Table.进出实况Column]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    }
                }
                set {
                    this[this.table_Table.进出实况Column] = value;
                }
            }
            
            public bool Is姓名Null() {
                return this.IsNull(this.table_Table.姓名Column);
            }
            
            public void Set姓名Null() {
                this[this.table_Table.姓名Column] = System.Convert.DBNull;
            }
            
            public bool Is性别Null() {
                return this.IsNull(this.table_Table.性别Column);
            }
            
            public void Set性别Null() {
                this[this.table_Table.性别Column] = System.Convert.DBNull;
            }
            
            public bool Is年龄Null() {
                return this.IsNull(this.table_Table.年龄Column);
            }
            
            public void Set年龄Null() {
                this[this.table_Table.年龄Column] = System.Convert.DBNull;
            }
            
            public bool Is级别Null() {
                return this.IsNull(this.table_Table.级别Column);
            }
            
            public void Set级别Null() {
                this[this.table_Table.级别Column] = System.Convert.DBNull;
            }
            
            public bool Is负责人Null() {
                return this.IsNull(this.table_Table.负责人Column);
            }
            
            public void Set负责人Null() {
                this[this.table_Table.负责人Column] = System.Convert.DBNull;
            }
            
            public bool Is进出实况Null() {
                return this.IsNull(this.table_Table.进出实况Column);
            }
            
            public void Set进出实况Null() {
                this[this.table_Table.进出实况Column] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class _TableRowChangeEvent : EventArgs {
            
            private _TableRow eventRow;
            
            private DataRowAction eventAction;
            
            public _TableRowChangeEvent(_TableRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public _TableRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
