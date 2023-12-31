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
Public Class dsLabs
    Inherits DataSet
    
    Private tableQ1 As Q1DataTable
    
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
            If (Not (ds.Tables("Q1")) Is Nothing) Then
                Me.Tables.Add(New Q1DataTable(ds.Tables("Q1")))
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
    Public ReadOnly Property Q1 As Q1DataTable
        Get
            Return Me.tableQ1
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsLabs = CType(MyBase.Clone,dsLabs)
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
        If (Not (ds.Tables("Q1")) Is Nothing) Then
            Me.Tables.Add(New Q1DataTable(ds.Tables("Q1")))
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
        Me.tableQ1 = CType(Me.Tables("Q1"),Q1DataTable)
        If (Not (Me.tableQ1) Is Nothing) Then
            Me.tableQ1.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsLabs"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dsLabs.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableQ1 = New Q1DataTable
        Me.Tables.Add(Me.tableQ1)
    End Sub
    
    Private Function ShouldSerializeQ1() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub Q1RowChangeEventHandler(ByVal sender As Object, ByVal e As Q1RowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Q1DataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnQID As DataColumn
        
        Private columnQues As DataColumn
        
        Private columnchkoropt As DataColumn
        
        Private columnExhibit As DataColumn
        
        Private columnExhibitName As DataColumn
        
        Private columnExplanation As DataColumn
        
        Private columnInputAnswer As DataColumn
        
        Private columnInputAnswer2 As DataColumn
        
        Private columnRouterOutput As DataColumn
        
        Private columnRouterPrompt As DataColumn
        
        Friend Sub New()
            MyBase.New("Q1")
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
        
        Friend ReadOnly Property QIDColumn As DataColumn
            Get
                Return Me.columnQID
            End Get
        End Property
        
        Friend ReadOnly Property QuesColumn As DataColumn
            Get
                Return Me.columnQues
            End Get
        End Property
        
        Friend ReadOnly Property chkoroptColumn As DataColumn
            Get
                Return Me.columnchkoropt
            End Get
        End Property
        
        Friend ReadOnly Property ExhibitColumn As DataColumn
            Get
                Return Me.columnExhibit
            End Get
        End Property
        
        Friend ReadOnly Property ExhibitNameColumn As DataColumn
            Get
                Return Me.columnExhibitName
            End Get
        End Property
        
        Friend ReadOnly Property ExplanationColumn As DataColumn
            Get
                Return Me.columnExplanation
            End Get
        End Property
        
        Friend ReadOnly Property InputAnswerColumn As DataColumn
            Get
                Return Me.columnInputAnswer
            End Get
        End Property
        
        Friend ReadOnly Property InputAnswer2Column As DataColumn
            Get
                Return Me.columnInputAnswer2
            End Get
        End Property
        
        Friend ReadOnly Property RouterOutputColumn As DataColumn
            Get
                Return Me.columnRouterOutput
            End Get
        End Property
        
        Friend ReadOnly Property RouterPromptColumn As DataColumn
            Get
                Return Me.columnRouterPrompt
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As Q1Row
            Get
                Return CType(Me.Rows(index),Q1Row)
            End Get
        End Property
        
        Public Event Q1RowChanged As Q1RowChangeEventHandler
        
        Public Event Q1RowChanging As Q1RowChangeEventHandler
        
        Public Event Q1RowDeleted As Q1RowChangeEventHandler
        
        Public Event Q1RowDeleting As Q1RowChangeEventHandler
        
        Public Overloads Sub AddQ1Row(ByVal row As Q1Row)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddQ1Row(ByVal QID As Short, ByVal Ques As String, ByVal chkoropt As String, ByVal Exhibit As String, ByVal ExhibitName As String, ByVal Explanation As String, ByVal InputAnswer As String, ByVal InputAnswer2 As String, ByVal RouterOutput As String, ByVal RouterPrompt As String) As Q1Row
            Dim rowQ1Row As Q1Row = CType(Me.NewRow,Q1Row)
            rowQ1Row.ItemArray = New Object() {QID, Ques, chkoropt, Exhibit, ExhibitName, Explanation, InputAnswer, InputAnswer2, RouterOutput, RouterPrompt}
            Me.Rows.Add(rowQ1Row)
            Return rowQ1Row
        End Function
        
        Public Function FindByQID(ByVal QID As Short) As Q1Row
            Return CType(Me.Rows.Find(New Object() {QID}),Q1Row)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As Q1DataTable = CType(MyBase.Clone,Q1DataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New Q1DataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnQID = Me.Columns("QID")
            Me.columnQues = Me.Columns("Ques")
            Me.columnchkoropt = Me.Columns("chkoropt")
            Me.columnExhibit = Me.Columns("Exhibit")
            Me.columnExhibitName = Me.Columns("ExhibitName")
            Me.columnExplanation = Me.Columns("Explanation")
            Me.columnInputAnswer = Me.Columns("InputAnswer")
            Me.columnInputAnswer2 = Me.Columns("InputAnswer2")
            Me.columnRouterOutput = Me.Columns("RouterOutput")
            Me.columnRouterPrompt = Me.Columns("RouterPrompt")
        End Sub
        
        Private Sub InitClass()
            Me.columnQID = New DataColumn("QID", GetType(System.Int16), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnQID)
            Me.columnQues = New DataColumn("Ques", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnQues)
            Me.columnchkoropt = New DataColumn("chkoropt", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnchkoropt)
            Me.columnExhibit = New DataColumn("Exhibit", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnExhibit)
            Me.columnExhibitName = New DataColumn("ExhibitName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnExhibitName)
            Me.columnExplanation = New DataColumn("Explanation", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnExplanation)
            Me.columnInputAnswer = New DataColumn("InputAnswer", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnInputAnswer)
            Me.columnInputAnswer2 = New DataColumn("InputAnswer2", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnInputAnswer2)
            Me.columnRouterOutput = New DataColumn("RouterOutput", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRouterOutput)
            Me.columnRouterPrompt = New DataColumn("RouterPrompt", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRouterPrompt)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnQID}, true))
            Me.columnQID.AllowDBNull = false
            Me.columnQID.Unique = true
        End Sub
        
        Public Function NewQ1Row() As Q1Row
            Return CType(Me.NewRow,Q1Row)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New Q1Row(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(Q1Row)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.Q1RowChangedEvent) Is Nothing) Then
                RaiseEvent Q1RowChanged(Me, New Q1RowChangeEvent(CType(e.Row,Q1Row), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.Q1RowChangingEvent) Is Nothing) Then
                RaiseEvent Q1RowChanging(Me, New Q1RowChangeEvent(CType(e.Row,Q1Row), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.Q1RowDeletedEvent) Is Nothing) Then
                RaiseEvent Q1RowDeleted(Me, New Q1RowChangeEvent(CType(e.Row,Q1Row), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.Q1RowDeletingEvent) Is Nothing) Then
                RaiseEvent Q1RowDeleting(Me, New Q1RowChangeEvent(CType(e.Row,Q1Row), e.Action))
            End If
        End Sub
        
        Public Sub RemoveQ1Row(ByVal row As Q1Row)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Q1Row
        Inherits DataRow
        
        Private tableQ1 As Q1DataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableQ1 = CType(Me.Table,Q1DataTable)
        End Sub
        
        Public Property QID As Short
            Get
                Return CType(Me(Me.tableQ1.QIDColumn),Short)
            End Get
            Set
                Me(Me.tableQ1.QIDColumn) = value
            End Set
        End Property
        
        Public Property Ques As String
            Get
                Try 
                    Return CType(Me(Me.tableQ1.QuesColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableQ1.QuesColumn) = value
            End Set
        End Property
        
        Public Property chkoropt As String
            Get
                Try 
                    Return CType(Me(Me.tableQ1.chkoroptColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableQ1.chkoroptColumn) = value
            End Set
        End Property
        
        Public Property Exhibit As String
            Get
                Try 
                    Return CType(Me(Me.tableQ1.ExhibitColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableQ1.ExhibitColumn) = value
            End Set
        End Property
        
        Public Property ExhibitName As String
            Get
                Try 
                    Return CType(Me(Me.tableQ1.ExhibitNameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableQ1.ExhibitNameColumn) = value
            End Set
        End Property
        
        Public Property Explanation As String
            Get
                Try 
                    Return CType(Me(Me.tableQ1.ExplanationColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableQ1.ExplanationColumn) = value
            End Set
        End Property
        
        Public Property InputAnswer As String
            Get
                Try 
                    Return CType(Me(Me.tableQ1.InputAnswerColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableQ1.InputAnswerColumn) = value
            End Set
        End Property
        
        Public Property InputAnswer2 As String
            Get
                Try 
                    Return CType(Me(Me.tableQ1.InputAnswer2Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableQ1.InputAnswer2Column) = value
            End Set
        End Property
        
        Public Property RouterOutput As String
            Get
                Try 
                    Return CType(Me(Me.tableQ1.RouterOutputColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableQ1.RouterOutputColumn) = value
            End Set
        End Property
        
        Public Property RouterPrompt As String
            Get
                Try 
                    Return CType(Me(Me.tableQ1.RouterPromptColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableQ1.RouterPromptColumn) = value
            End Set
        End Property
        
        Public Function IsQuesNull() As Boolean
            Return Me.IsNull(Me.tableQ1.QuesColumn)
        End Function
        
        Public Sub SetQuesNull()
            Me(Me.tableQ1.QuesColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IschkoroptNull() As Boolean
            Return Me.IsNull(Me.tableQ1.chkoroptColumn)
        End Function
        
        Public Sub SetchkoroptNull()
            Me(Me.tableQ1.chkoroptColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsExhibitNull() As Boolean
            Return Me.IsNull(Me.tableQ1.ExhibitColumn)
        End Function
        
        Public Sub SetExhibitNull()
            Me(Me.tableQ1.ExhibitColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsExhibitNameNull() As Boolean
            Return Me.IsNull(Me.tableQ1.ExhibitNameColumn)
        End Function
        
        Public Sub SetExhibitNameNull()
            Me(Me.tableQ1.ExhibitNameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsExplanationNull() As Boolean
            Return Me.IsNull(Me.tableQ1.ExplanationColumn)
        End Function
        
        Public Sub SetExplanationNull()
            Me(Me.tableQ1.ExplanationColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsInputAnswerNull() As Boolean
            Return Me.IsNull(Me.tableQ1.InputAnswerColumn)
        End Function
        
        Public Sub SetInputAnswerNull()
            Me(Me.tableQ1.InputAnswerColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsInputAnswer2Null() As Boolean
            Return Me.IsNull(Me.tableQ1.InputAnswer2Column)
        End Function
        
        Public Sub SetInputAnswer2Null()
            Me(Me.tableQ1.InputAnswer2Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsRouterOutputNull() As Boolean
            Return Me.IsNull(Me.tableQ1.RouterOutputColumn)
        End Function
        
        Public Sub SetRouterOutputNull()
            Me(Me.tableQ1.RouterOutputColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRouterPromptNull() As Boolean
            Return Me.IsNull(Me.tableQ1.RouterPromptColumn)
        End Function
        
        Public Sub SetRouterPromptNull()
            Me(Me.tableQ1.RouterPromptColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Q1RowChangeEvent
        Inherits EventArgs
        
        Private eventRow As Q1Row
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As Q1Row, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As Q1Row
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
