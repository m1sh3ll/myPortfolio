Option Explicit On 
Option Strict On
Imports System.Convert
Imports System.IO

Public Class frmEditor
    Inherits System.Windows.Forms.Form
    Private mIDNum As String
    Private mblnDirty As Boolean
    Private cblnIsEditing As Boolean
    Private sp As String = Application.StartupPath & "\"
    Private dbTempPath As String = Application.StartupPath & "\dbflashcards.mdb"
    Private dbBackupPath As String = Application.StartupPath & "\backup\dbflashcards.mdb"
    'see copyTempFile to saved to change backup and flashfile etc.

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.odbConFlash.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;" & _
                    "Data Source=" & dbTempPath & ";" & _
                                "Mode=Share Deny None" & _
                                            ";Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";" & _
                    "Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Lockin" & _
                    "g Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=" & _
                    "1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet " & _
                    "OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OL" & _
                    "EDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False"

        Me.MdiParent = fParent
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents odbConFlash As System.Data.OleDb.OleDbConnection
    Friend WithEvents odbDaFlash As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsFlash1 As QUEENEDIT2004.dsFlash
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cboQID As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents txtQuestion As System.Windows.Forms.TextBox
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnViewImage As System.Windows.Forms.Button
    Friend WithEvents btnPreviewFlashcards As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnChooseImage As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblPromptPreview As System.Windows.Forms.Label
    Friend WithEvents picExhibit As System.Windows.Forms.PictureBox
    Friend WithEvents gbExhibit As System.Windows.Forms.GroupBox
    Friend WithEvents rbNoImage As System.Windows.Forms.RadioButton
    Friend WithEvents rbYesImage As System.Windows.Forms.RadioButton
    Friend WithEvents txtImageURL As System.Windows.Forms.TextBox
    Friend WithEvents btnChangeAnswer As System.Windows.Forms.Button
    Friend WithEvents lblIDNumber As System.Windows.Forms.Label
    Friend WithEvents lblGoTo As System.Windows.Forms.Label
    Friend WithEvents txtExhibit As System.Windows.Forms.TextBox
    Friend WithEvents txtQID As System.Windows.Forms.TextBox
    Friend WithEvents gbType As System.Windows.Forms.GroupBox
    Friend WithEvents rbFlashCards As System.Windows.Forms.RadioButton
    Friend WithEvents tmrTimer As System.Windows.Forms.Timer
    Friend WithEvents btnSave As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEditor))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.odbConFlash = New System.Data.OleDb.OleDbConnection()
        Me.odbDaFlash = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.DsFlash1 = New QUEENEDIT2004.dsFlash()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cboQID = New System.Windows.Forms.ComboBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.txtExhibit = New System.Windows.Forms.TextBox()
        Me.txtQID = New System.Windows.Forms.TextBox()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnViewImage = New System.Windows.Forms.Button()
        Me.btnPreviewFlashcards = New System.Windows.Forms.Button()
        Me.btnChooseImage = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPromptPreview = New System.Windows.Forms.Label()
        Me.picExhibit = New System.Windows.Forms.PictureBox()
        Me.txtImageURL = New System.Windows.Forms.TextBox()
        Me.gbExhibit = New System.Windows.Forms.GroupBox()
        Me.rbYesImage = New System.Windows.Forms.RadioButton()
        Me.rbNoImage = New System.Windows.Forms.RadioButton()
        Me.btnChangeAnswer = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblIDNumber = New System.Windows.Forms.Label()
        Me.lblGoTo = New System.Windows.Forms.Label()
        Me.gbType = New System.Windows.Forms.GroupBox()
        Me.rbFlashCards = New System.Windows.Forms.RadioButton()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DsFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbExhibit.SuspendLayout()
        Me.gbType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Navy
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(185, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(515, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Exam Editor: Editing dbexam.mdb - Table Q1"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'odbConFlash
        '
        Me.odbConFlash.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=H:\QUEENED" & _
        "IT2004\bin\dbflashcards.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLED" & _
        "B:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";J" & _
        "et OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partia" & _
        "l Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Passwor" & _
        "d="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet" & _
        " OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repa" & _
        "ir=False;Jet OLEDB:SFP=False"
        '
        'odbDaFlash
        '
        Me.odbDaFlash.DeleteCommand = Me.OleDbDeleteCommand1
        Me.odbDaFlash.InsertCommand = Me.OleDbInsertCommand1
        Me.odbDaFlash.SelectCommand = Me.OleDbSelectCommand1
        Me.odbDaFlash.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Q1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("fldQID", "fldQID"), New System.Data.Common.DataColumnMapping("fldImageURL", "fldImageURL"), New System.Data.Common.DataColumnMapping("fldQuestion", "fldQuestion"), New System.Data.Common.DataColumnMapping("fldType", "fldType"), New System.Data.Common.DataColumnMapping("fldAnswer", "fldAnswer")})})
        Me.odbDaFlash.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Q1 WHERE (fldQID = ?) AND (fldAnswer = ? OR ? IS NULL AND fldAnswer I" & _
        "S NULL) AND (fldImageURL = ? OR ? IS NULL AND fldImageURL IS NULL) AND (fldQuest" & _
        "ion = ? OR ? IS NULL AND fldQuestion IS NULL) AND (fldType = ? OR ? IS NULL AND " & _
        "fldType IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.odbConFlash
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldQID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "fldQID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldAnswer", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldAnswer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldAnswer1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldAnswer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldImageURL", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldImageURL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldImageURL1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldImageURL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldQuestion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldQuestion", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldQuestion1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldQuestion", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldType", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldType", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldType1", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldType", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Q1(fldQID, fldImageURL, fldQuestion, fldType, fldAnswer) VALUES (?, ?" & _
        ", ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.odbConFlash
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("fldQID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "fldQID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("fldImageURL", System.Data.OleDb.OleDbType.VarWChar, 0, "fldImageURL"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("fldQuestion", System.Data.OleDb.OleDbType.VarWChar, 0, "fldQuestion"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("fldType", System.Data.OleDb.OleDbType.VarWChar, 4, "fldType"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("fldAnswer", System.Data.OleDb.OleDbType.VarWChar, 0, "fldAnswer"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT fldQID, fldImageURL, fldQuestion, fldType, fldAnswer FROM Q1"
        Me.OleDbSelectCommand1.Connection = Me.odbConFlash
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Q1 SET fldQID = ?, fldImageURL = ?, fldQuestion = ?, fldType = ?, fldAnswe" & _
        "r = ? WHERE (fldQID = ?) AND (fldAnswer = ? OR ? IS NULL AND fldAnswer IS NULL) " & _
        "AND (fldImageURL = ? OR ? IS NULL AND fldImageURL IS NULL) AND (fldQuestion = ? " & _
        "OR ? IS NULL AND fldQuestion IS NULL) AND (fldType = ? OR ? IS NULL AND fldType " & _
        "IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.odbConFlash
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("fldQID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "fldQID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("fldImageURL", System.Data.OleDb.OleDbType.VarWChar, 0, "fldImageURL"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("fldQuestion", System.Data.OleDb.OleDbType.VarWChar, 0, "fldQuestion"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("fldType", System.Data.OleDb.OleDbType.VarWChar, 4, "fldType"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("fldAnswer", System.Data.OleDb.OleDbType.VarWChar, 0, "fldAnswer"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldQID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "fldQID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldAnswer", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldAnswer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldAnswer1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldAnswer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldImageURL", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldImageURL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldImageURL1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldImageURL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldQuestion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldQuestion", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldQuestion1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldQuestion", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldType", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldType", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldType1", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldType", System.Data.DataRowVersion.Original, Nothing))
        '
        'DsFlash1
        '
        Me.DsFlash1.DataSetName = "dsFlash"
        Me.DsFlash1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsFlash1.Namespace = "http://www.tempuri.org/dsFlash.xsd"
        '
        'cboQID
        '
        Me.cboQID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQID.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQID.Location = New System.Drawing.Point(95, 0)
        Me.cboQID.Name = "cboQID"
        Me.cboQID.Size = New System.Drawing.Size(90, 24)
        Me.cboQID.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cboQID, "Select a Question Number to Edit")
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(625, 320)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(60, 30)
        Me.btnPrevious.TabIndex = 2
        Me.btnPrevious.Text = "Previous"
        Me.ToolTip1.SetToolTip(Me.btnPrevious, "Go to the Previous FlashCard")
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(625, 355)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(60, 30)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next"
        Me.ToolTip1.SetToolTip(Me.btnNext, "Go to the Next FlashCard")
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.White
        Me.txtAnswer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtAnswer.Location = New System.Drawing.Point(65, 285)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAnswer.Size = New System.Drawing.Size(440, 210)
        Me.txtAnswer.TabIndex = 5
        Me.txtAnswer.Text = ""
        Me.ToolTip1.SetToolTip(Me.txtAnswer, "Enter an answer for this FlashCard")
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.SteelBlue
        Me.btnFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.Location = New System.Drawing.Point(625, 285)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(60, 30)
        Me.btnFirst.TabIndex = 16
        Me.btnFirst.Text = "First"
        Me.ToolTip1.SetToolTip(Me.btnFirst, "Go to the First FlashCard")
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.SteelBlue
        Me.btnLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(625, 390)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(60, 30)
        Me.btnLast.TabIndex = 17
        Me.btnLast.Text = "Last"
        Me.ToolTip1.SetToolTip(Me.btnLast, "Go to the Last FlashCard in the set")
        '
        'txtExhibit
        '
        Me.txtExhibit.BackColor = System.Drawing.Color.Gainsboro
        Me.txtExhibit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExhibit.Enabled = False
        Me.txtExhibit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExhibit.Location = New System.Drawing.Point(380, 185)
        Me.txtExhibit.Name = "txtExhibit"
        Me.txtExhibit.Size = New System.Drawing.Size(45, 20)
        Me.txtExhibit.TabIndex = 8
        Me.txtExhibit.Text = ""
        Me.ToolTip1.SetToolTip(Me.txtExhibit, "Type of FlashCard. Y indicates an image is associated with FlashCard")
        '
        'txtQID
        '
        Me.txtQID.BackColor = System.Drawing.Color.Beige
        Me.txtQID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQID.Enabled = False
        Me.txtQID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQID.ForeColor = System.Drawing.Color.Black
        Me.txtQID.Location = New System.Drawing.Point(95, 25)
        Me.txtQID.Multiline = True
        Me.txtQID.Name = "txtQID"
        Me.txtQID.Size = New System.Drawing.Size(90, 40)
        Me.txtQID.TabIndex = 11
        Me.txtQID.Text = ""
        Me.ToolTip1.SetToolTip(Me.txtQID, "The Question Number")
        '
        'txtQuestion
        '
        Me.txtQuestion.BackColor = System.Drawing.Color.White
        Me.txtQuestion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtQuestion.Location = New System.Drawing.Point(65, 70)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtQuestion.Size = New System.Drawing.Size(440, 210)
        Me.txtQuestion.TabIndex = 12
        Me.txtQuestion.Text = ""
        Me.ToolTip1.SetToolTip(Me.txtQuestion, "Enter a Question for this FlashCard")
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Yellow
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(515, 285)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(105, 30)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "&Add Question"
        Me.ToolTip1.SetToolTip(Me.btnAdd, "Add FlashCard")
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.OrangeRed
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(515, 320)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 30)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete Question"
        Me.ToolTip1.SetToolTip(Me.btnDelete, "Delete FlashCard")
        '
        'btnViewImage
        '
        Me.btnViewImage.BackColor = System.Drawing.Color.SteelBlue
        Me.btnViewImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewImage.Location = New System.Drawing.Point(575, 35)
        Me.btnViewImage.Name = "btnViewImage"
        Me.btnViewImage.Size = New System.Drawing.Size(110, 25)
        Me.btnViewImage.TabIndex = 19
        Me.btnViewImage.Text = "Preview Image.."
        Me.ToolTip1.SetToolTip(Me.btnViewImage, "Preview Image for this FlashCard")
        '
        'btnPreviewFlashcards
        '
        Me.btnPreviewFlashcards.BackColor = System.Drawing.Color.LimeGreen
        Me.btnPreviewFlashcards.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviewFlashcards.Location = New System.Drawing.Point(515, 460)
        Me.btnPreviewFlashcards.Name = "btnPreviewFlashcards"
        Me.btnPreviewFlashcards.Size = New System.Drawing.Size(105, 30)
        Me.btnPreviewFlashcards.TabIndex = 20
        Me.btnPreviewFlashcards.Text = "Preview Exam"
        Me.ToolTip1.SetToolTip(Me.btnPreviewFlashcards, "Preview All FlashCards")
        '
        'btnChooseImage
        '
        Me.btnChooseImage.BackColor = System.Drawing.Color.SteelBlue
        Me.btnChooseImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseImage.Location = New System.Drawing.Point(575, 65)
        Me.btnChooseImage.Name = "btnChooseImage"
        Me.btnChooseImage.Size = New System.Drawing.Size(110, 25)
        Me.btnChooseImage.TabIndex = 22
        Me.btnChooseImage.Text = "Choose Image.."
        Me.ToolTip1.SetToolTip(Me.btnChooseImage, "Preview Image for this FlashCard")
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(625, 425)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(60, 30)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "Cancel"
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Delete FlashCard")
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(15, 295)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(47, 13)
        Me.lblAnswer.TabIndex = 4
        Me.lblAnswer.Text = "Answer:"
        Me.ToolTip1.SetToolTip(Me.lblAnswer, "Enter the answer to the question above")
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(5, 75)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(55, 13)
        Me.lblQuestion.TabIndex = 13
        Me.lblQuestion.Text = "Question:"
        Me.ToolTip1.SetToolTip(Me.lblQuestion, "Enter the question")
        '
        'ofdOpenFile
        '
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(625, 460)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(60, 30)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "Close"
        '
        'lblPromptPreview
        '
        Me.lblPromptPreview.BackColor = System.Drawing.Color.Transparent
        Me.lblPromptPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPromptPreview.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptPreview.ForeColor = System.Drawing.Color.Black
        Me.lblPromptPreview.Location = New System.Drawing.Point(510, 95)
        Me.lblPromptPreview.Name = "lblPromptPreview"
        Me.lblPromptPreview.Size = New System.Drawing.Size(175, 25)
        Me.lblPromptPreview.TabIndex = 135
        Me.lblPromptPreview.Text = "Exhibit Preview:"
        Me.lblPromptPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picExhibit
        '
        Me.picExhibit.BackColor = System.Drawing.Color.White
        Me.picExhibit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picExhibit.Location = New System.Drawing.Point(510, 140)
        Me.picExhibit.Name = "picExhibit"
        Me.picExhibit.Size = New System.Drawing.Size(175, 140)
        Me.picExhibit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExhibit.TabIndex = 137
        Me.picExhibit.TabStop = False
        '
        'txtImageURL
        '
        Me.txtImageURL.BackColor = System.Drawing.Color.LightGray
        Me.txtImageURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImageURL.Enabled = False
        Me.txtImageURL.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageURL.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtImageURL.Location = New System.Drawing.Point(510, 120)
        Me.txtImageURL.MaxLength = 100
        Me.txtImageURL.Multiline = True
        Me.txtImageURL.Name = "txtImageURL"
        Me.txtImageURL.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtImageURL.Size = New System.Drawing.Size(175, 20)
        Me.txtImageURL.TabIndex = 136
        Me.txtImageURL.Text = ""
        '
        'gbExhibit
        '
        Me.gbExhibit.BackColor = System.Drawing.Color.White
        Me.gbExhibit.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbYesImage, Me.rbNoImage})
        Me.gbExhibit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbExhibit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbExhibit.Location = New System.Drawing.Point(510, 30)
        Me.gbExhibit.Name = "gbExhibit"
        Me.gbExhibit.Size = New System.Drawing.Size(60, 60)
        Me.gbExhibit.TabIndex = 138
        Me.gbExhibit.TabStop = False
        Me.gbExhibit.Text = "Exhibit"
        '
        'rbYesImage
        '
        Me.rbYesImage.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbYesImage.Location = New System.Drawing.Point(5, 15)
        Me.rbYesImage.Name = "rbYesImage"
        Me.rbYesImage.Size = New System.Drawing.Size(50, 25)
        Me.rbYesImage.TabIndex = 0
        Me.rbYesImage.Text = "Yes"
        '
        'rbNoImage
        '
        Me.rbNoImage.Checked = True
        Me.rbNoImage.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNoImage.Location = New System.Drawing.Point(5, 40)
        Me.rbNoImage.Name = "rbNoImage"
        Me.rbNoImage.Size = New System.Drawing.Size(50, 20)
        Me.rbNoImage.TabIndex = 2
        Me.rbNoImage.TabStop = True
        Me.rbNoImage.Text = "No"
        '
        'btnChangeAnswer
        '
        Me.btnChangeAnswer.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
        Me.btnChangeAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeAnswer.Location = New System.Drawing.Point(515, 355)
        Me.btnChangeAnswer.Name = "btnChangeAnswer"
        Me.btnChangeAnswer.Size = New System.Drawing.Size(105, 30)
        Me.btnChangeAnswer.TabIndex = 140
        Me.btnChangeAnswer.Text = "C&hange"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(515, 425)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 30)
        Me.btnSave.TabIndex = 139
        Me.btnSave.Text = "&Save Exam"
        '
        'lblIDNumber
        '
        Me.lblIDNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblIDNumber.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDNumber.ForeColor = System.Drawing.Color.Black
        Me.lblIDNumber.Location = New System.Drawing.Point(5, 25)
        Me.lblIDNumber.Name = "lblIDNumber"
        Me.lblIDNumber.Size = New System.Drawing.Size(90, 40)
        Me.lblIDNumber.TabIndex = 141
        Me.lblIDNumber.Text = "Question ID:"
        Me.lblIDNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGoTo
        '
        Me.lblGoTo.BackColor = System.Drawing.Color.Transparent
        Me.lblGoTo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoTo.ForeColor = System.Drawing.Color.Black
        Me.lblGoTo.Location = New System.Drawing.Point(0, 5)
        Me.lblGoTo.Name = "lblGoTo"
        Me.lblGoTo.Size = New System.Drawing.Size(95, 25)
        Me.lblGoTo.TabIndex = 142
        Me.lblGoTo.Text = "Go To #:"
        Me.lblGoTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbType
        '
        Me.gbType.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbType.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbFlashCards})
        Me.gbType.Enabled = False
        Me.gbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbType.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbType.Location = New System.Drawing.Point(190, 30)
        Me.gbType.Name = "gbType"
        Me.gbType.Size = New System.Drawing.Size(124, 35)
        Me.gbType.TabIndex = 143
        Me.gbType.TabStop = False
        Me.gbType.Text = "Question Type"
        '
        'rbFlashCards
        '
        Me.rbFlashCards.Checked = True
        Me.rbFlashCards.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFlashCards.Location = New System.Drawing.Point(10, 15)
        Me.rbFlashCards.Name = "rbFlashCards"
        Me.rbFlashCards.Size = New System.Drawing.Size(95, 15)
        Me.rbFlashCards.TabIndex = 0
        Me.rbFlashCards.TabStop = True
        Me.rbFlashCards.Text = "Flashcards"
        '
        'tmrTimer
        '
        Me.tmrTimer.Interval = 2000
        '
        'frmEditor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(702, 500)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.gbType, Me.lblGoTo, Me.lblIDNumber, Me.btnChangeAnswer, Me.btnSave, Me.gbExhibit, Me.lblPromptPreview, Me.picExhibit, Me.txtImageURL, Me.lblAnswer, Me.lblQuestion, Me.btnCancel, Me.btnChooseImage, Me.btnExit, Me.btnPreviewFlashcards, Me.btnViewImage, Me.btnDelete, Me.btnLast, Me.btnFirst, Me.btnAdd, Me.txtQuestion, Me.txtQID, Me.txtExhibit, Me.txtAnswer, Me.btnNext, Me.btnPrevious, Me.cboQID, Me.lblTitle})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flashcards Editor"
        CType(Me.DsFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbExhibit.ResumeLayout(False)
        Me.gbType.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region
    Sub MsgBoxA()
        MsgBox("You must add at least " & fintMaxQuestions & " questions to preview this exam." & vbCrLf _
            & "To preview current questions, change the max questions value in the Icon Editor " & _
            "for this specific exam")
    End Sub
    Sub MsgBoxB()
        Dim Msg As MsgBoxResult
        If mblnDirty Then
            Msg = MsgBox("Save Changes?", MsgBoxStyle.YesNo, "Confirm Changes")
            If Msg = MsgBoxResult.Yes Then
                EditUpdate()
                SaveFlashCard()
            End If
        End If
    End Sub
    Sub MsgBoxF()
        MsgBox("Please select a 'Question type' for Question ID number " & mIDNum & ".")
    End Sub
    Sub MsgBoxJ()
        MsgBox("Please select an image to use for Exhibit: Question ID number " & mIDNum & ".")
    End Sub
    Sub MsgBoxK()
        MsgBox("Please select a valid image to use for Exhibit: Question ID number " & mIDNum & ".")
    End Sub
    Function MsgBoxL() As MsgBoxResult
        Dim mr As MsgBoxResult = MsgBox("You may have changed the exam type from 'Practice Exams' or 'Labs' to " _
        & "'Flashcards'. Click OK to overwrite the old exam for this module with a new exam. Click " _
        & "Cancel to go back to the module editor. Navigate to the module folder " _
        & "on your hard drive and copy it to another directory as a backup or change it back to the previous " _
        & "Exam Type: 'Practice Exams' or 'Labs'", MsgBoxStyle.OKCancel, "Confirm Exam Overwrite")

        Return mr
    End Function
    'txtexhibit.text= Y or N, not 1 or 0
    'fldQID not QID, fldType not MTYPE
    'fldQuestion, fldAnswer, fldImageURL
    Friend Sub CheckType()
        If txtExhibit.Text = "Y" Then
            rbYesImage.Checked = True
        End If
        If txtExhibit.Text = "N" Then
            rbNoImage.Checked = True
        End If
    End Sub
    Friend Sub RefreshCombo()
        cboQID.Items.Clear()
        odbDaFlash.Fill(DsFlash1)
        AddQuestionsCombo()
    End Sub
    Friend Sub SaveFlashCard()
        Dim pintRecords As Integer = Me.DsFlash1.Q1.Rows.Count - 1
        Dim RowNum As Integer

        For RowNum = 0 To pintRecords
            If Me.DsFlash1.Q1.Rows(RowNum).Item("fldType").ToString = "Y" Then
                If Me.DsFlash1.Q1.Rows(RowNum).Item("fldImageURL").ToString = "" Then
                    mIDNum = Me.DsFlash1.Q1.Rows(RowNum).Item("fldQID").ToString
                    MsgBoxJ()
                    Exit Sub
                End If

                If Me.DsFlash1.Q1.Rows(RowNum).Item("fldImageURL").ToString.IndexOf(".") = -1 Then
                    mIDNum = Me.DsFlash1.Q1.Rows(RowNum).Item("fldQID").ToString
                    MsgBoxK()
                    Exit Sub
                End If
            End If
        Next
        CopyTempFileToSaved()

    End Sub
    Friend Sub GenerateNewQID()
        Dim pLast As Integer, pNew As Integer
        Try
            pLast = Me.DsFlash1.Q1.Rows.Count - 1
            If pLast > -1 Then
                pNew = ToInt32(Me.DsFlash1.Q1.Rows(pLast).Item("fldQID"))
                pNew += 1
                txtQID.Text = pNew.ToString
            Else
                Exit Sub
            End If

        Catch
            txtQID.Text = "2001"
        End Try
        mblnDirty = True
    End Sub

    Private Function ImageUrlOK() As Boolean

        If rbYesImage.Checked = True Then
            If txtImageURL.Text = "" Then
                MsgBoxF()
                Return False
            End If
            txtExhibit.Text = "Y"
        Else
            txtExhibit.Text = "N"
            txtImageURL.Text = ""
        End If

        Return True

    End Function
    Sub AddQuestionsCombo()
        Dim count As Integer
        For count = 0 To Me.DsFlash1.Q1.Rows.Count - 1
            cboQID.Items.Add(Me.DsFlash1.Q1.Rows(count).Item("fldQID"))
        Next

    End Sub
    Sub BindData(ByVal txtBox As TextBox, ByVal strS As String)
        Dim pb As Binding = New Binding("Text", DsFlash1, strS)
        txtBox.DataBindings.Add(pb)
    End Sub
    Sub CloseForm()
        Dim pmsg As DialogResult
        If mblnDirty = True Then
            pmsg = MessageBox.Show("Save Changes?", "Confirm changes", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Question)
            If pmsg = DialogResult.Yes Then
                If rbYesImage.Checked = True Then
                    txtExhibit.Text = "Y"
                Else
                    txtExhibit.Text = "N"
                    txtImageURL.Text = ""
                End If

                Call EditUpdate()
                Call SaveFlashCard()
            End If
        End If

        odbConFlash.Close()
        fParent.pnlCurrentRecord.Text = ""
        fParent.pnlRecordCount.Text = ""
    End Sub
    Sub CancelEditing()
        EditCancel()
        btnAdd.Text = "&Add Question"
        btnChangeAnswer.Text = "C&hange"
        cblnIsEditing = False
        btnAdd.Enabled = True
        btnChangeAnswer.Enabled = True
        EnableDisableButtons()
    End Sub
    Sub ChangeAnswer()
        If btnChangeAnswer.Text = "C&hange" Then 'CHANGE ANSWER
            cblnIsEditing = True
            btnChangeAnswer.Text = "Fi&nished"
        Else 'FINISHED
            cblnIsEditing = False
        End If

        If cblnIsEditing = False Then 'FINISHED CLICKED
            btnChangeAnswer.Text = "C&hange" 'diff in add question
            EditUpdate()
        End If
        EnableDisableButtons()
        btnAdd.Enabled = Not (cblnIsEditing)
    End Sub
    Sub ChangeSelectedPosition()
        Me.BindingContext(DsFlash1, "Q1").Position = cboQID.SelectedIndex
        fParent.pnlCurrentRecord.Text = "Current = " & Me.BindingContext(DsFlash1, "Q1").Position + 1
    End Sub
    Sub CopyTempFileToSaved()
        Dim pFlashFile As String

        'if the file exists delete it and copy working to saved
        ' check if C:\QUEENEDIT  \myexam\  exams\icon2   \  db002.mdb
        If File.Exists(fFULLMODULEPATH & fCurrentModuleDB) Then
            File.Delete(fFULLMODULEPATH & fCurrentModuleDB)
            'when copied name it with the fCurrentModuleDB which is db002.mdb etc
            File.Copy(dbTempPath, fFULLMODULEPATH & fCurrentModuleDB)
        Else
            File.Copy(dbTempPath, fFULLMODULEPATH & fCurrentModuleDB)
        End If

        pFlashFile = "flash" & fButtonClicked & ".exe" 'flash.exe, flash2.exe etc.

        'If appropriate flash.exe does not exist then copy it to module directory
        If Not (File.Exists(fFULLMODULEPATH & pFlashFile)) Then
            File.Copy(sp & "backup\" & pFlashFile, fFULLMODULEPATH & pFlashFile)
        End If

    End Sub
    'Sub DisableAllButtons()
    '    cblnIsEditing = False
    '    btnCancel.Enabled = False
    '    btnDelete.Enabled = False
    '    ' btnClose.Enabled = False
    '    btnFirst.Enabled = False
    '    btnNext.Enabled = False
    '    btnPrevious.Enabled = False
    '    btnLast.Enabled = False
    '    'btnExit.Enabled = False
    '    btnSave.Enabled = False
    '    btnUpdate.Enabled = False
    '    btnPreviewFlashcards.Enabled = False
    '    cboQID.Enabled = False
    '    btnChangeAnswer.Enabled = False
    '    btnAdd.Enabled = False
    '    gbType.Enabled = cblnIsEditing
    '    txtAnswer.Enabled = cblnIsEditing
    '    gbExhibit.Enabled = cblnIsEditing
    'End Sub

    Sub EnableDisableButtons()
        btnCancel.Enabled = cblnIsEditing
        btnDelete.Enabled = Not (cblnIsEditing)
        btnExit.Enabled = Not (cblnIsEditing)
        btnFirst.Enabled = Not (cblnIsEditing)
        btnNext.Enabled = Not (cblnIsEditing)
        btnPrevious.Enabled = Not (cblnIsEditing)
        btnLast.Enabled = Not (cblnIsEditing)
        btnSave.Enabled = Not (cblnIsEditing)
        btnPreviewFlashcards.Enabled = Not (cblnIsEditing) 'preview button
        cboQID.Enabled = Not (cblnIsEditing)
        txtQuestion.Enabled = cblnIsEditing
        gbExhibit.Enabled = cblnIsEditing
        txtAnswer.Enabled = cblnIsEditing
    End Sub

    Sub AddNewQuestion()
        If btnAdd.Text = "&Add Question" Then 'ADD QUESTION
            cblnIsEditing = True
            btnAdd.Text = "Fi&nished"
        Else 'FINISHED
            cblnIsEditing = False
        End If

        If cblnIsEditing = True Then 'ADD QUESTION
            EditAdd() 'not in change Answer
        Else 'FINISHED
            btnAdd.Text = "&Add Question"
            EditUpdate()
        End If
        EnableDisableButtons()
        btnChangeAnswer.Enabled = Not (cblnIsEditing)
    End Sub
    Private Sub FillAndBindDataSet()
        Try
            odbDaFlash.Fill(DsFlash1)
        Catch
            Dim pmsg As MsgBoxResult = MsgBoxL()
            If pmsg = MsgBoxResult.OK Then
                RepairExamDatabase()
                odbDaFlash.Fill(DsFlash1)
            Else 'if cancel
                mblnDirty = False
                Try
                    Me.Close()
                Catch
                    tmrTimer.Enabled = True
                    Exit Sub
                End Try
            End If
        End Try

        BindData(txtQID, "Q1.fldQID")
        BindData(txtExhibit, "Q1.fldType")
        BindData(txtQuestion, "Q1.fldQuestion")
        BindData(txtAnswer, "Q1.fldAnswer")
        BindData(txtImageURL, "Q1.fldImageURL")

    End Sub
    Sub ExhibitChanged()
        If txtExhibit.Text = "Y" Then SetExhibitControls(True)
        If txtExhibit.Text = "" Or txtExhibit.Text = "N" Then SetExhibitControls(False)
        LoadExhibit(fFULLMODULEPATH & txtImageURL.Text)
    End Sub
    Sub ImageURLChanged()
        LoadExhibit(fFULLMODULEPATH & txtImageURL.Text)
    End Sub
    Sub LoadExhibit(ByVal pPath As String)
        If txtImageURL.Text <> "" Then
            Try : If File.Exists(pPath) Then picExhibit.Image = System.Drawing.Image.FromFile(pPath)
            Catch : picExhibit.Image = Nothing
            End Try
        Else : picExhibit.Image = Nothing
        End If
    End Sub
    Sub NoImageCheck()
        If rbNoImage.Checked = True Then
            btnChooseImage.Enabled = False
            btnViewImage.Enabled = False
            picExhibit.Enabled = False
            picExhibit.Image = Nothing
            txtExhibit.Text = "N"
            txtImageURL.Text = ""
        End If
    End Sub
    Sub OpenTestQExe()
        Call Navigate(fPARENTPATH & "testq.exe")
    End Sub
    Sub PreviewExam() '? < >=
        If mblnDirty = True Then MsgBoxB() '? prompt to save
        OpenTestQExe() ' doesnt have to check the max questions
    End Sub
    Sub RepairExamDatabase()
        If File.Exists(dbTempPath) Then
            File.Delete(dbTempPath)
        End If
        File.Copy(dbBackupPath, dbTempPath)
    End Sub
    Sub SaveFileAndUpdate()
        If ImageUrlOK() = True Then
            Call EditUpdate()
            Call SaveFlashCard()
            mblnDirty = False
        End If
    End Sub
    Sub SetExhibitControls(ByVal pBool As Boolean)
        rbYesImage.Checked = pBool
        rbNoImage.Checked = Not (pBool)
        btnChooseImage.Enabled = pBool
        btnViewImage.Enabled = pBool
    End Sub
    Sub SetFormNumber()
        fintCURRENTFORM = 3
    End Sub
    Sub SetTitle()
        Dim pTemp As String = fButtonClicked.ToString
        If fButtonClicked = "" Then pTemp = "1"
        If fButtonClicked = "6" Then pTemp = "All Topics"
        Me.Text = fCollectionName & " - " & fIconName
        lblTitle.Text = "Editing " & fSubFolders & fCurrentModuleDB & " - Exam " & pTemp & " - " & fTopicName
    End Sub
    Sub SetAndOpenFileDialog()
        ofdOpenFile.Filter = "JPEG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|BMP Files (*.bmp)|*.bmp|Icon Files (*.ico)|*.ico"
        ofdOpenFile.FilterIndex = 1
        ofdOpenFile.Title = "Choose Image File"
        ofdOpenFile.ShowDialog()
    End Sub
    Sub SetImageForm()
        Dim frmImageView As New frmImage(txtImageURL.Text)
        frmImageView.Show()
    End Sub
    Sub SetUpImageFile()
        Dim pstrFileName As String, pstrFields() As String
        Dim pchrDelimiter() As Char = {System.Convert.ToChar("\")}
        Dim iTopIndex As Integer
        'extract just filename from textbox, not full path
        'selects the file and copies it to working directory

        pstrFileName = ofdOpenFile.FileName
        pstrFields = pstrFileName.Split(pchrDelimiter)
        iTopIndex = pstrFields.GetUpperBound(0)
        pstrFileName = pstrFields(iTopIndex)
        txtImageURL.Text = pstrFileName

        If Not File.Exists(fFULLMODULEPATH & txtImageURL.Text) Then
            File.Copy(ofdOpenFile.FileName, fFULLMODULEPATH & txtImageURL.Text)
        End If

        'If pstrFileName <> "" Then
        LoadExhibit(fFULLMODULEPATH & txtImageURL.Text)
        'End If 'END NEW CODE

        btnSave.Enabled = True
        mblnDirty = True
    End Sub
    Sub YesImageCheck()
        If rbYesImage.Checked = True Then
            btnChooseImage.Enabled = True
            btnViewImage.Enabled = True
            picExhibit.Enabled = True
            txtExhibit.Text = "Y"
        End If
    End Sub

#Region "Form Controls"
    Private Sub frmEditor_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        CloseForm()
    End Sub
    Private Sub frmEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SetFormNumber()
        Me.SetTitle()
        Me.FillAndBindDataSet()
        Me.AddQuestionsCombo()
        Me.EnableDisableButtons()
    End Sub
    Private Sub frmEditor_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        SetFormNumber()
    End Sub
    Private Sub frmEditor_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        SetFormNumber()
        SetPanelBarText("" & (DsFlash1.Q1.Rows.Count), "" & (Me.BindingContext(DsFlash1, "Q1").Position + 1))
    End Sub
    'Preview Exam
    Private Sub btnPreviewFlashcards_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPreviewFlashcards.Click
        PreviewExam()
    End Sub
    Private Sub cboQID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboQID.SelectedIndexChanged
        ChangeSelectedPosition()
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        AddNewQuestion()
    End Sub
    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        Call NavigateFirst()
    End Sub
    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Call NavigateNext()
    End Sub
    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Call NavigatePrevious()
    End Sub
    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Call NavigateLast()
    End Sub
    Private Sub btnChooseImage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChooseImage.Click
        SetAndOpenFileDialog()
    End Sub
    Private Sub btnViewImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewImage.Click
        SetImageForm()
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Call EditDelete()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveFileAndUpdate()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        CancelEditing()
    End Sub
    Private Sub btnChangeAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeAnswer.Click
        ChangeAnswer()
    End Sub
    Private Sub ofdOpenFile_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ofdOpenFile.FileOk
        SetUpImageFile()
    End Sub
    Private Sub txtQuestion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuestion.TextChanged
        btnSave.Enabled = True
    End Sub
    Private Sub txtAnswer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAnswer.TextChanged
        btnSave.Enabled = True
    End Sub
    Private Sub txtExhibit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtExhibit.TextChanged
        ExhibitChanged()

    End Sub
    Private Sub txtQID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQID.TextChanged
        CheckType()
    End Sub
    Private Sub txtImageURL_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImageURL.TextChanged
        ImageURLChanged()
    End Sub
    Private Sub rbYesImage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbYesImage.CheckedChanged
        YesImageCheck()
    End Sub
    Private Sub rbNoImage_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbNoImage.CheckedChanged
        NoImageCheck()
    End Sub
    Private Sub tmrTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimer.Tick
        Me.Close()
    End Sub
#End Region
End Class

