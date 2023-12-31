﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.0.3705.288
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class dsIconsE
    Inherits DataSet
    
    Private tablet1 As t1DataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("t1")) Is Nothing) Then
                Me.Tables.Add(New t1DataTable(ds.Tables("t1")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property t1 As t1DataTable
        Get
            Return Me.tablet1
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsIconsE = CType(MyBase.Clone,dsIconsE)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("t1")) Is Nothing) Then
            Me.Tables.Add(New t1DataTable(ds.Tables("t1")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tablet1 = CType(Me.Tables("t1"),t1DataTable)
        If (Not (Me.tablet1) Is Nothing) Then
            Me.tablet1.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsIconsE"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dsIconsE.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablet1 = New t1DataTable
        Me.Tables.Add(Me.tablet1)
    End Sub
    
    Private Function ShouldSerializet1() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub t1RowChangeEventHandler(ByVal sender As Object, ByVal e As t1RowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class t1DataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnID As DataColumn
        
        Private columnICTITLE As DataColumn
        
        Private columnIconMouse As DataColumn
        
        Private columnfldSubFolder As DataColumn
        
        Private columnMaxLbox As DataColumn
        
        Private columnMTYPE As DataColumn
        
        Private columnTopicBut1 As DataColumn
        
        Private columnTopicBut2 As DataColumn
        
        Private columnTopicBut3 As DataColumn
        
        Private columnTopicBut4 As DataColumn
        
        Private columnTopicBut5 As DataColumn
        
        Private columnTopicButAll As DataColumn
        
        Friend Sub New()
            MyBase.New("t1")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property IDColumn As DataColumn
            Get
                Return Me.columnID
            End Get
        End Property
        
        Friend ReadOnly Property ICTITLEColumn As DataColumn
            Get
                Return Me.columnICTITLE
            End Get
        End Property
        
        Friend ReadOnly Property IconMouseColumn As DataColumn
            Get
                Return Me.columnIconMouse
            End Get
        End Property
        
        Friend ReadOnly Property fldSubFolderColumn As DataColumn
            Get
                Return Me.columnfldSubFolder
            End Get
        End Property
        
        Friend ReadOnly Property MaxLboxColumn As DataColumn
            Get
                Return Me.columnMaxLbox
            End Get
        End Property
        
        Friend ReadOnly Property MTYPEColumn As DataColumn
            Get
                Return Me.columnMTYPE
            End Get
        End Property
        
        Friend ReadOnly Property TopicBut1Column As DataColumn
            Get
                Return Me.columnTopicBut1
            End Get
        End Property
        
        Friend ReadOnly Property TopicBut2Column As DataColumn
            Get
                Return Me.columnTopicBut2
            End Get
        End Property
        
        Friend ReadOnly Property TopicBut3Column As DataColumn
            Get
                Return Me.columnTopicBut3
            End Get
        End Property
        
        Friend ReadOnly Property TopicBut4Column As DataColumn
            Get
                Return Me.columnTopicBut4
            End Get
        End Property
        
        Friend ReadOnly Property TopicBut5Column As DataColumn
            Get
                Return Me.columnTopicBut5
            End Get
        End Property
        
        Friend ReadOnly Property TopicButAllColumn As DataColumn
            Get
                Return Me.columnTopicButAll
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As t1Row
            Get
                Return CType(Me.Rows(index),t1Row)
            End Get
        End Property
        
        Public Event t1RowChanged As t1RowChangeEventHandler
        
        Public Event t1RowChanging As t1RowChangeEventHandler
        
        Public Event t1RowDeleted As t1RowChangeEventHandler
        
        Public Event t1RowDeleting As t1RowChangeEventHandler
        
        Public Overloads Sub Addt1Row(ByVal row As t1Row)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Addt1Row(ByVal ID As Short, ByVal ICTITLE As String, ByVal IconMouse As String, ByVal fldSubFolder As String, ByVal MaxLbox As String, ByVal MTYPE As String, ByVal TopicBut1 As String, ByVal TopicBut2 As String, ByVal TopicBut3 As String, ByVal TopicBut4 As String, ByVal TopicBut5 As String, ByVal TopicButAll As String) As t1Row
            Dim rowt1Row As t1Row = CType(Me.NewRow,t1Row)
            rowt1Row.ItemArray = New Object() {ID, ICTITLE, IconMouse, fldSubFolder, MaxLbox, MTYPE, TopicBut1, TopicBut2, TopicBut3, TopicBut4, TopicBut5, TopicButAll}
            Me.Rows.Add(rowt1Row)
            Return rowt1Row
        End Function
        
        Public Function FindByID(ByVal ID As Short) As t1Row
            Return CType(Me.Rows.Find(New Object() {ID}),t1Row)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As t1DataTable = CType(MyBase.Clone,t1DataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New t1DataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnID = Me.Columns("ID")
            Me.columnICTITLE = Me.Columns("ICTITLE")
            Me.columnIconMouse = Me.Columns("IconMouse")
            Me.columnfldSubFolder = Me.Columns("fldSubFolder")
            Me.columnMaxLbox = Me.Columns("MaxLbox")
            Me.columnMTYPE = Me.Columns("MTYPE")
            Me.columnTopicBut1 = Me.Columns("TopicBut1")
            Me.columnTopicBut2 = Me.Columns("TopicBut2")
            Me.columnTopicBut3 = Me.Columns("TopicBut3")
            Me.columnTopicBut4 = Me.Columns("TopicBut4")
            Me.columnTopicBut5 = Me.Columns("TopicBut5")
            Me.columnTopicButAll = Me.Columns("TopicButAll")
        End Sub
        
        Private Sub InitClass()
            Me.columnID = New DataColumn("ID", GetType(System.Int16), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnID)
            Me.columnICTITLE = New DataColumn("ICTITLE", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnICTITLE)
            Me.columnIconMouse = New DataColumn("IconMouse", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnIconMouse)
            Me.columnfldSubFolder = New DataColumn("fldSubFolder", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnfldSubFolder)
            Me.columnMaxLbox = New DataColumn("MaxLbox", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnMaxLbox)
            Me.columnMTYPE = New DataColumn("MTYPE", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnMTYPE)
            Me.columnTopicBut1 = New DataColumn("TopicBut1", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTopicBut1)
            Me.columnTopicBut2 = New DataColumn("TopicBut2", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTopicBut2)
            Me.columnTopicBut3 = New DataColumn("TopicBut3", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTopicBut3)
            Me.columnTopicBut4 = New DataColumn("TopicBut4", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTopicBut4)
            Me.columnTopicBut5 = New DataColumn("TopicBut5", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTopicBut5)
            Me.columnTopicButAll = New DataColumn("TopicButAll", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTopicButAll)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnID}, true))
            Me.columnID.AllowDBNull = false
            Me.columnID.Unique = true
        End Sub
        
        Public Function Newt1Row() As t1Row
            Return CType(Me.NewRow,t1Row)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New t1Row(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(t1Row)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.t1RowChangedEvent) Is Nothing) Then
                RaiseEvent t1RowChanged(Me, New t1RowChangeEvent(CType(e.Row,t1Row), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.t1RowChangingEvent) Is Nothing) Then
                RaiseEvent t1RowChanging(Me, New t1RowChangeEvent(CType(e.Row,t1Row), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.t1RowDeletedEvent) Is Nothing) Then
                RaiseEvent t1RowDeleted(Me, New t1RowChangeEvent(CType(e.Row,t1Row), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.t1RowDeletingEvent) Is Nothing) Then
                RaiseEvent t1RowDeleting(Me, New t1RowChangeEvent(CType(e.Row,t1Row), e.Action))
            End If
        End Sub
        
        Public Sub Removet1Row(ByVal row As t1Row)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class t1Row
        Inherits DataRow
        
        Private tablet1 As t1DataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablet1 = CType(Me.Table,t1DataTable)
        End Sub
        
        Public Property ID As Short
            Get
                Return CType(Me(Me.tablet1.IDColumn),Short)
            End Get
            Set
                Me(Me.tablet1.IDColumn) = value
            End Set
        End Property
        
        Public Property ICTITLE As String
            Get
                Try 
                    Return CType(Me(Me.tablet1.ICTITLEColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablet1.ICTITLEColumn) = value
            End Set
        End Property
        
        Public Property IconMouse As String
            Get
                Try 
                    Return CType(Me(Me.tablet1.IconMouseColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablet1.IconMouseColumn) = value
            End Set
        End Property
        
        Public Property fldSubFolder As String
            Get
                Try 
                    Return CType(Me(Me.tablet1.fldSubFolderColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablet1.fldSubFolderColumn) = value
            End Set
        End Property
        
        Public Property MaxLbox As String
            Get
                Try 
                    Return CType(Me(Me.tablet1.MaxLboxColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablet1.MaxLboxColumn) = value
            End Set
        End Property
        
        Public Property MTYPE As String
            Get
                Try 
                    Return CType(Me(Me.tablet1.MTYPEColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablet1.MTYPEColumn) = value
            End Set
        End Property
        
        Public Property TopicBut1 As String
            Get
                Try 
                    Return CType(Me(Me.tablet1.TopicBut1Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablet1.TopicBut1Column) = value
            End Set
        End Property
        
        Public Property TopicBut2 As String
            Get
                Try 
                    Return CType(Me(Me.tablet1.TopicBut2Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablet1.TopicBut2Column) = value
            End Set
        End Property
        
        Public Property TopicBut3 As String
            Get
                Try 
                    Return CType(Me(Me.tablet1.TopicBut3Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablet1.TopicBut3Column) = value
            End Set
        End Property
        
        Public Property TopicBut4 As String
            Get
                Try 
                    Return CType(Me(Me.tablet1.TopicBut4Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablet1.TopicBut4Column) = value
            End Set
        End Property
        
        Public Property TopicBut5 As String
            Get
                Try 
                    Return CType(Me(Me.tablet1.TopicBut5Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablet1.TopicBut5Column) = value
            End Set
        End Property
        
        Public Property TopicButAll As String
            Get
                Try 
                    Return CType(Me(Me.tablet1.TopicButAllColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablet1.TopicButAllColumn) = value
            End Set
        End Property
        
        Public Function IsICTITLENull() As Boolean
            Return Me.IsNull(Me.tablet1.ICTITLEColumn)
        End Function
        
        Public Sub SetICTITLENull()
            Me(Me.tablet1.ICTITLEColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsIconMouseNull() As Boolean
            Return Me.IsNull(Me.tablet1.IconMouseColumn)
        End Function
        
        Public Sub SetIconMouseNull()
            Me(Me.tablet1.IconMouseColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsfldSubFolderNull() As Boolean
            Return Me.IsNull(Me.tablet1.fldSubFolderColumn)
        End Function
        
        Public Sub SetfldSubFolderNull()
            Me(Me.tablet1.fldSubFolderColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsMaxLboxNull() As Boolean
            Return Me.IsNull(Me.tablet1.MaxLboxColumn)
        End Function
        
        Public Sub SetMaxLboxNull()
            Me(Me.tablet1.MaxLboxColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsMTYPENull() As Boolean
            Return Me.IsNull(Me.tablet1.MTYPEColumn)
        End Function
        
        Public Sub SetMTYPENull()
            Me(Me.tablet1.MTYPEColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTopicBut1Null() As Boolean
            Return Me.IsNull(Me.tablet1.TopicBut1Column)
        End Function
        
        Public Sub SetTopicBut1Null()
            Me(Me.tablet1.TopicBut1Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsTopicBut2Null() As Boolean
            Return Me.IsNull(Me.tablet1.TopicBut2Column)
        End Function
        
        Public Sub SetTopicBut2Null()
            Me(Me.tablet1.TopicBut2Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsTopicBut3Null() As Boolean
            Return Me.IsNull(Me.tablet1.TopicBut3Column)
        End Function
        
        Public Sub SetTopicBut3Null()
            Me(Me.tablet1.TopicBut3Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsTopicBut4Null() As Boolean
            Return Me.IsNull(Me.tablet1.TopicBut4Column)
        End Function
        
        Public Sub SetTopicBut4Null()
            Me(Me.tablet1.TopicBut4Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsTopicBut5Null() As Boolean
            Return Me.IsNull(Me.tablet1.TopicBut5Column)
        End Function
        
        Public Sub SetTopicBut5Null()
            Me(Me.tablet1.TopicBut5Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsTopicButAllNull() As Boolean
            Return Me.IsNull(Me.tablet1.TopicButAllColumn)
        End Function
        
        Public Sub SetTopicButAllNull()
            Me(Me.tablet1.TopicButAllColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class t1RowChangeEvent
        Inherits EventArgs
        
        Private eventRow As t1Row
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As t1Row, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As t1Row
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
