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
    public class DataSet1 : DataSet {
        
        private _TableDataTable table_Table;
        
        public DataSet1() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected DataSet1(SerializationInfo info, StreamingContext context) {
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
            DataSet1 cln = ((DataSet1)(base.Clone()));
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
            this.DataSetName = "DataSet1";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/DataSet1.xsd";
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
            
            private DataColumn column姓名;
            
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
            
            internal DataColumn 姓名Column {
                get {
                    return this.column姓名;
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
            
            public _TableRow Add_TableRow(string 姓名) {
                _TableRow row_TableRow = ((_TableRow)(this.NewRow()));
                row_TableRow.ItemArray = new object[] {
                        姓名};
                this.Rows.Add(row_TableRow);
                return row_TableRow;
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
                this.column姓名 = this.Columns["姓名"];
            }
            
            private void InitClass() {
                this.column姓名 = new DataColumn("姓名", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.column姓名);
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
            
            public bool Is姓名Null() {
                return this.IsNull(this.table_Table.姓名Column);
            }
            
            public void Set姓名Null() {
                this[this.table_Table.姓名Column] = System.Convert.DBNull;
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
