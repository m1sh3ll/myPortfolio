Option Strict On
Option Explicit On 
Imports System.IO
Imports System.Convert

Public Class frmEditExam
    Inherits System.Windows.Forms.Form

    Private mIDNum As String
    Private mblnDirty As Boolean
    Private cblnIsEditing As Boolean
    Private cIsHidden As Boolean = True
    Private sp As String = Application.StartupPath & "\"
    Private dbTempPath As String = Application.StartupPath & "\dbexam.mdb" 'ConString - Working Ver
    Private dbBackupPath As String = Application.StartupPath & "\backup\dbexam.mdb"

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.MdiParent = fParent
        Me.odbConExam.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;" & _
                          "Data Source=" & dbTempPath & ";" & "Mode=Share Deny None" & _
                                                  ";Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";" & _
                          "Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Lockin" & _
                          "g Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=" & _
                          "1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet " & _
                          "OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OL" & _
                          "EDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False"

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
    Friend WithEvents txtChkOrOpt As System.Windows.Forms.TextBox
    Friend WithEvents lblchkoropt As System.Windows.Forms.Label
    Friend WithEvents txtImageURL As System.Windows.Forms.TextBox
    Friend WithEvents txtInputAnswer As System.Windows.Forms.TextBox
    Friend WithEvents gbType As System.Windows.Forms.GroupBox
    Friend WithEvents rbTrueFalse As System.Windows.Forms.RadioButton
    Friend WithEvents rbOneAnswer As System.Windows.Forms.RadioButton
    Friend WithEvents rbMultiAnswer As System.Windows.Forms.RadioButton
    Friend WithEvents rbUserInput As System.Windows.Forms.RadioButton
    Friend WithEvents rbAllNoneOfAbove As System.Windows.Forms.RadioButton
    Friend WithEvents txtAnsA As System.Windows.Forms.TextBox
    Friend WithEvents txtAnsB As System.Windows.Forms.TextBox
    Friend WithEvents txtAnsC As System.Windows.Forms.TextBox
    Friend WithEvents txtAnsD As System.Windows.Forms.TextBox
    Friend WithEvents txtAnsE As System.Windows.Forms.TextBox
    Friend WithEvents txtAnsF As System.Windows.Forms.TextBox
    Friend WithEvents txtAnsG As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents txtInputAnswer2 As System.Windows.Forms.TextBox
    Friend WithEvents gbExhibit As System.Windows.Forms.GroupBox
    Friend WithEvents rbYesImage As System.Windows.Forms.RadioButton
    Friend WithEvents picExhibit As System.Windows.Forms.PictureBox
    Friend WithEvents txtQID As System.Windows.Forms.TextBox
    Friend WithEvents cboQID As System.Windows.Forms.ComboBox
    Friend WithEvents btnChooseImage As System.Windows.Forms.Button
    Friend WithEvents btnViewImage As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblPromptExplanation As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtQues As System.Windows.Forms.TextBox
    Friend WithEvents txtExplanation As System.Windows.Forms.TextBox
    Friend WithEvents rbNoImage As System.Windows.Forms.RadioButton
    Friend WithEvents odbConExam As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents odbDaExam As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DsExam1 As QUEENEDIT2004.dsExam
    Friend WithEvents txtExhibit As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtG As System.Windows.Forms.TextBox
    Friend WithEvents txtF As System.Windows.Forms.TextBox
    Friend WithEvents txtE As System.Windows.Forms.TextBox
    Friend WithEvents txtD As System.Windows.Forms.TextBox
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents rbHidden As System.Windows.Forms.RadioButton
    Friend WithEvents btnChangeAnswer As System.Windows.Forms.Button
    Friend WithEvents chk1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk4 As System.Windows.Forms.CheckBox
    Friend WithEvents chk5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk6 As System.Windows.Forms.CheckBox
    Friend WithEvents chk7 As System.Windows.Forms.CheckBox
    Friend WithEvents lblPromptPreview As System.Windows.Forms.Label
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents picCheck1 As System.Windows.Forms.PictureBox
    Friend WithEvents picX1 As System.Windows.Forms.PictureBox
    Friend WithEvents picX2 As System.Windows.Forms.PictureBox
    Friend WithEvents picX3 As System.Windows.Forms.PictureBox
    Friend WithEvents picX4 As System.Windows.Forms.PictureBox
    Friend WithEvents picX5 As System.Windows.Forms.PictureBox
    Friend WithEvents picX6 As System.Windows.Forms.PictureBox
    Friend WithEvents picX7 As System.Windows.Forms.PictureBox
    Friend WithEvents picCheck3 As System.Windows.Forms.PictureBox
    Friend WithEvents picCheck4 As System.Windows.Forms.PictureBox
    Friend WithEvents picCheck2 As System.Windows.Forms.PictureBox
    Friend WithEvents picCheck5 As System.Windows.Forms.PictureBox
    Friend WithEvents picCheck6 As System.Windows.Forms.PictureBox
    Friend WithEvents picCheck7 As System.Windows.Forms.PictureBox
    Friend WithEvents picCheck8 As System.Windows.Forms.PictureBox
    Friend WithEvents picCheck9 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPromptInputAnswer As System.Windows.Forms.Label
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnShowHide As System.Windows.Forms.Button
    Friend WithEvents btnExpandE As System.Windows.Forms.Button
    Friend WithEvents lblGoTo As System.Windows.Forms.Label
    Friend WithEvents lblIDNumber As System.Windows.Forms.Label
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents btnExpandQues As System.Windows.Forms.Button
    Friend WithEvents tmrTimer As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEditExam))
        Me.txtChkOrOpt = New System.Windows.Forms.TextBox()
        Me.lblchkoropt = New System.Windows.Forms.Label()
        Me.txtImageURL = New System.Windows.Forms.TextBox()
        Me.gbType = New System.Windows.Forms.GroupBox()
        Me.rbAllNoneOfAbove = New System.Windows.Forms.RadioButton()
        Me.rbTrueFalse = New System.Windows.Forms.RadioButton()
        Me.rbMultiAnswer = New System.Windows.Forms.RadioButton()
        Me.rbOneAnswer = New System.Windows.Forms.RadioButton()
        Me.rbUserInput = New System.Windows.Forms.RadioButton()
        Me.txtInputAnswer = New System.Windows.Forms.TextBox()
        Me.txtAnsA = New System.Windows.Forms.TextBox()
        Me.txtAnsB = New System.Windows.Forms.TextBox()
        Me.txtAnsC = New System.Windows.Forms.TextBox()
        Me.txtAnsD = New System.Windows.Forms.TextBox()
        Me.txtAnsE = New System.Windows.Forms.TextBox()
        Me.txtAnsF = New System.Windows.Forms.TextBox()
        Me.txtAnsG = New System.Windows.Forms.TextBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.txtInputAnswer2 = New System.Windows.Forms.TextBox()
        Me.lblGoTo = New System.Windows.Forms.Label()
        Me.txtQues = New System.Windows.Forms.TextBox()
        Me.txtExplanation = New System.Windows.Forms.TextBox()
        Me.gbExhibit = New System.Windows.Forms.GroupBox()
        Me.rbNoImage = New System.Windows.Forms.RadioButton()
        Me.rbYesImage = New System.Windows.Forms.RadioButton()
        Me.picExhibit = New System.Windows.Forms.PictureBox()
        Me.txtQID = New System.Windows.Forms.TextBox()
        Me.cboQID = New System.Windows.Forms.ComboBox()
        Me.btnChooseImage = New System.Windows.Forms.Button()
        Me.btnViewImage = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnShowHide = New System.Windows.Forms.Button()
        Me.btnExpandE = New System.Windows.Forms.Button()
        Me.btnExpandQues = New System.Windows.Forms.Button()
        Me.lblIDNumber = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblPromptExplanation = New System.Windows.Forms.Label()
        Me.lblPromptPreview = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.odbConExam = New System.Data.OleDb.OleDbConnection()
        Me.odbDaExam = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.DsExam1 = New QUEENEDIT2004.dsExam()
        Me.txtExhibit = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtG = New System.Windows.Forms.TextBox()
        Me.txtF = New System.Windows.Forms.TextBox()
        Me.txtE = New System.Windows.Forms.TextBox()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.btnChangeAnswer = New System.Windows.Forms.Button()
        Me.rbHidden = New System.Windows.Forms.RadioButton()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me.chk3 = New System.Windows.Forms.CheckBox()
        Me.chk4 = New System.Windows.Forms.CheckBox()
        Me.chk5 = New System.Windows.Forms.CheckBox()
        Me.chk6 = New System.Windows.Forms.CheckBox()
        Me.chk7 = New System.Windows.Forms.CheckBox()
        Me.picCheck1 = New System.Windows.Forms.PictureBox()
        Me.picX1 = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.picX2 = New System.Windows.Forms.PictureBox()
        Me.picX3 = New System.Windows.Forms.PictureBox()
        Me.picX4 = New System.Windows.Forms.PictureBox()
        Me.picX5 = New System.Windows.Forms.PictureBox()
        Me.picX6 = New System.Windows.Forms.PictureBox()
        Me.picX7 = New System.Windows.Forms.PictureBox()
        Me.picCheck3 = New System.Windows.Forms.PictureBox()
        Me.picCheck4 = New System.Windows.Forms.PictureBox()
        Me.picCheck2 = New System.Windows.Forms.PictureBox()
        Me.picCheck5 = New System.Windows.Forms.PictureBox()
        Me.picCheck6 = New System.Windows.Forms.PictureBox()
        Me.picCheck7 = New System.Windows.Forms.PictureBox()
        Me.picCheck8 = New System.Windows.Forms.PictureBox()
        Me.picCheck9 = New System.Windows.Forms.PictureBox()
        Me.lblPromptInputAnswer = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.gbType.SuspendLayout()
        Me.gbExhibit.SuspendLayout()
        CType(Me.DsExam1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtChkOrOpt
        '
        Me.txtChkOrOpt.Location = New System.Drawing.Point(25, 25)
        Me.txtChkOrOpt.Name = "txtChkOrOpt"
        Me.txtChkOrOpt.Size = New System.Drawing.Size(50, 20)
        Me.txtChkOrOpt.TabIndex = 39
        Me.txtChkOrOpt.Text = ""
        '
        'lblchkoropt
        '
        Me.lblchkoropt.BackColor = System.Drawing.Color.White
        Me.lblchkoropt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblchkoropt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchkoropt.ForeColor = System.Drawing.Color.Black
        Me.lblchkoropt.Location = New System.Drawing.Point(100, 30)
        Me.lblchkoropt.Name = "lblchkoropt"
        Me.lblchkoropt.Size = New System.Drawing.Size(45, 30)
        Me.lblchkoropt.TabIndex = 44
        Me.lblchkoropt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtImageURL
        '
        Me.txtImageURL.BackColor = System.Drawing.Color.LightGray
        Me.txtImageURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImageURL.Enabled = False
        Me.txtImageURL.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageURL.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtImageURL.Location = New System.Drawing.Point(620, 125)
        Me.txtImageURL.MaxLength = 100
        Me.txtImageURL.Multiline = True
        Me.txtImageURL.Name = "txtImageURL"
        Me.txtImageURL.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtImageURL.Size = New System.Drawing.Size(170, 20)
        Me.txtImageURL.TabIndex = 21
        Me.txtImageURL.Text = ""
        '
        'gbType
        '
        Me.gbType.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbType.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbAllNoneOfAbove, Me.rbTrueFalse, Me.rbMultiAnswer, Me.rbOneAnswer, Me.rbUserInput})
        Me.gbType.Enabled = False
        Me.gbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbType.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbType.Location = New System.Drawing.Point(195, 30)
        Me.gbType.Name = "gbType"
        Me.gbType.Size = New System.Drawing.Size(415, 35)
        Me.gbType.TabIndex = 32
        Me.gbType.TabStop = False
        Me.gbType.Text = "Question Type"
        '
        'rbAllNoneOfAbove
        '
        Me.rbAllNoneOfAbove.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAllNoneOfAbove.Location = New System.Drawing.Point(325, 15)
        Me.rbAllNoneOfAbove.Name = "rbAllNoneOfAbove"
        Me.rbAllNoneOfAbove.Size = New System.Drawing.Size(89, 15)
        Me.rbAllNoneOfAbove.TabIndex = 4
        Me.rbAllNoneOfAbove.Text = "All of Above"
        '
        'rbTrueFalse
        '
        Me.rbTrueFalse.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTrueFalse.Location = New System.Drawing.Point(185, 15)
        Me.rbTrueFalse.Name = "rbTrueFalse"
        Me.rbTrueFalse.Size = New System.Drawing.Size(85, 15)
        Me.rbTrueFalse.TabIndex = 2
        Me.rbTrueFalse.Text = "True/False"
        '
        'rbMultiAnswer
        '
        Me.rbMultiAnswer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMultiAnswer.Location = New System.Drawing.Point(90, 15)
        Me.rbMultiAnswer.Name = "rbMultiAnswer"
        Me.rbMultiAnswer.Size = New System.Drawing.Size(90, 15)
        Me.rbMultiAnswer.TabIndex = 1
        Me.rbMultiAnswer.Text = "Multi Answer"
        '
        'rbOneAnswer
        '
        Me.rbOneAnswer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOneAnswer.Location = New System.Drawing.Point(5, 15)
        Me.rbOneAnswer.Name = "rbOneAnswer"
        Me.rbOneAnswer.Size = New System.Drawing.Size(95, 15)
        Me.rbOneAnswer.TabIndex = 0
        Me.rbOneAnswer.Text = "One Answer"
        '
        'rbUserInput
        '
        Me.rbUserInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbUserInput.Location = New System.Drawing.Point(270, 15)
        Me.rbUserInput.Name = "rbUserInput"
        Me.rbUserInput.Size = New System.Drawing.Size(60, 15)
        Me.rbUserInput.TabIndex = 3
        Me.rbUserInput.Text = "Input"
        '
        'txtInputAnswer
        '
        Me.txtInputAnswer.AutoSize = False
        Me.txtInputAnswer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputAnswer.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtInputAnswer.Location = New System.Drawing.Point(130, 180)
        Me.txtInputAnswer.MaxLength = 255
        Me.txtInputAnswer.Multiline = True
        Me.txtInputAnswer.Name = "txtInputAnswer"
        Me.txtInputAnswer.Size = New System.Drawing.Size(435, 35)
        Me.txtInputAnswer.TabIndex = 12
        Me.txtInputAnswer.Text = ""
        '
        'txtAnsA
        '
        Me.txtAnsA.AutoSize = False
        Me.txtAnsA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnsA.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtAnsA.Location = New System.Drawing.Point(100, 145)
        Me.txtAnsA.Multiline = True
        Me.txtAnsA.Name = "txtAnsA"
        Me.txtAnsA.Size = New System.Drawing.Size(510, 35)
        Me.txtAnsA.TabIndex = 3
        Me.txtAnsA.Text = ""
        '
        'txtAnsB
        '
        Me.txtAnsB.AutoSize = False
        Me.txtAnsB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnsB.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtAnsB.Location = New System.Drawing.Point(100, 180)
        Me.txtAnsB.Multiline = True
        Me.txtAnsB.Name = "txtAnsB"
        Me.txtAnsB.Size = New System.Drawing.Size(510, 35)
        Me.txtAnsB.TabIndex = 4
        Me.txtAnsB.Text = ""
        '
        'txtAnsC
        '
        Me.txtAnsC.AutoSize = False
        Me.txtAnsC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnsC.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtAnsC.Location = New System.Drawing.Point(100, 215)
        Me.txtAnsC.Multiline = True
        Me.txtAnsC.Name = "txtAnsC"
        Me.txtAnsC.Size = New System.Drawing.Size(510, 35)
        Me.txtAnsC.TabIndex = 5
        Me.txtAnsC.Text = ""
        '
        'txtAnsD
        '
        Me.txtAnsD.AutoSize = False
        Me.txtAnsD.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnsD.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtAnsD.Location = New System.Drawing.Point(100, 250)
        Me.txtAnsD.Multiline = True
        Me.txtAnsD.Name = "txtAnsD"
        Me.txtAnsD.Size = New System.Drawing.Size(510, 35)
        Me.txtAnsD.TabIndex = 6
        Me.txtAnsD.Text = ""
        '
        'txtAnsE
        '
        Me.txtAnsE.AutoSize = False
        Me.txtAnsE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnsE.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtAnsE.Location = New System.Drawing.Point(100, 285)
        Me.txtAnsE.Multiline = True
        Me.txtAnsE.Name = "txtAnsE"
        Me.txtAnsE.Size = New System.Drawing.Size(510, 35)
        Me.txtAnsE.TabIndex = 7
        Me.txtAnsE.Text = ""
        '
        'txtAnsF
        '
        Me.txtAnsF.AutoSize = False
        Me.txtAnsF.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnsF.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtAnsF.Location = New System.Drawing.Point(100, 320)
        Me.txtAnsF.Multiline = True
        Me.txtAnsF.Name = "txtAnsF"
        Me.txtAnsF.Size = New System.Drawing.Size(510, 35)
        Me.txtAnsF.TabIndex = 8
        Me.txtAnsF.Text = ""
        '
        'txtAnsG
        '
        Me.txtAnsG.AutoSize = False
        Me.txtAnsG.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnsG.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtAnsG.Location = New System.Drawing.Point(100, 355)
        Me.txtAnsG.Multiline = True
        Me.txtAnsG.Name = "txtAnsG"
        Me.txtAnsG.Size = New System.Drawing.Size(510, 35)
        Me.txtAnsG.TabIndex = 9
        Me.txtAnsG.Text = ""
        '
        'txtAnswer
        '
        Me.txtAnswer.AutoSize = False
        Me.txtAnswer.BackColor = System.Drawing.Color.White
        Me.txtAnswer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtAnswer.Location = New System.Drawing.Point(100, 390)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAnswer.Size = New System.Drawing.Size(445, 40)
        Me.txtAnswer.TabIndex = 10
        Me.txtAnswer.Text = ""
        '
        'txtInputAnswer2
        '
        Me.txtInputAnswer2.AutoSize = False
        Me.txtInputAnswer2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputAnswer2.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtInputAnswer2.Location = New System.Drawing.Point(130, 250)
        Me.txtInputAnswer2.MaxLength = 255
        Me.txtInputAnswer2.Multiline = True
        Me.txtInputAnswer2.Name = "txtInputAnswer2"
        Me.txtInputAnswer2.Size = New System.Drawing.Size(435, 35)
        Me.txtInputAnswer2.TabIndex = 13
        Me.txtInputAnswer2.Text = ""
        '
        'lblGoTo
        '
        Me.lblGoTo.BackColor = System.Drawing.Color.Transparent
        Me.lblGoTo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoTo.ForeColor = System.Drawing.Color.Black
        Me.lblGoTo.Location = New System.Drawing.Point(5, 0)
        Me.lblGoTo.Name = "lblGoTo"
        Me.lblGoTo.Size = New System.Drawing.Size(95, 25)
        Me.lblGoTo.TabIndex = 36
        Me.lblGoTo.Text = "Go To #:"
        Me.lblGoTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQues
        '
        Me.txtQues.AutoSize = False
        Me.txtQues.BackColor = System.Drawing.Color.White
        Me.txtQues.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQues.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtQues.Location = New System.Drawing.Point(100, 65)
        Me.txtQues.Multiline = True
        Me.txtQues.Name = "txtQues"
        Me.txtQues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtQues.Size = New System.Drawing.Size(510, 75)
        Me.txtQues.TabIndex = 2
        Me.txtQues.Text = ""
        '
        'txtExplanation
        '
        Me.txtExplanation.AutoSize = False
        Me.txtExplanation.BackColor = System.Drawing.Color.White
        Me.txtExplanation.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExplanation.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtExplanation.Location = New System.Drawing.Point(100, 430)
        Me.txtExplanation.Multiline = True
        Me.txtExplanation.Name = "txtExplanation"
        Me.txtExplanation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtExplanation.Size = New System.Drawing.Size(510, 75)
        Me.txtExplanation.TabIndex = 11
        Me.txtExplanation.Text = ""
        '
        'gbExhibit
        '
        Me.gbExhibit.BackColor = System.Drawing.Color.White
        Me.gbExhibit.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbNoImage, Me.rbYesImage})
        Me.gbExhibit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbExhibit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbExhibit.Location = New System.Drawing.Point(615, 35)
        Me.gbExhibit.Name = "gbExhibit"
        Me.gbExhibit.Size = New System.Drawing.Size(60, 60)
        Me.gbExhibit.TabIndex = 33
        Me.gbExhibit.TabStop = False
        Me.gbExhibit.Text = "Exhibit"
        '
        'rbNoImage
        '
        Me.rbNoImage.Checked = True
        Me.rbNoImage.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNoImage.Location = New System.Drawing.Point(10, 40)
        Me.rbNoImage.Name = "rbNoImage"
        Me.rbNoImage.Size = New System.Drawing.Size(50, 20)
        Me.rbNoImage.TabIndex = 2
        Me.rbNoImage.TabStop = True
        Me.rbNoImage.Text = "No"
        '
        'rbYesImage
        '
        Me.rbYesImage.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbYesImage.Location = New System.Drawing.Point(10, 15)
        Me.rbYesImage.Name = "rbYesImage"
        Me.rbYesImage.Size = New System.Drawing.Size(50, 25)
        Me.rbYesImage.TabIndex = 0
        Me.rbYesImage.Text = "Yes"
        '
        'picExhibit
        '
        Me.picExhibit.BackColor = System.Drawing.Color.White
        Me.picExhibit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picExhibit.Location = New System.Drawing.Point(620, 145)
        Me.picExhibit.Name = "picExhibit"
        Me.picExhibit.Size = New System.Drawing.Size(170, 140)
        Me.picExhibit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExhibit.TabIndex = 91
        Me.picExhibit.TabStop = False
        '
        'txtQID
        '
        Me.txtQID.BackColor = System.Drawing.Color.White
        Me.txtQID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQID.Location = New System.Drawing.Point(100, 25)
        Me.txtQID.MaxLength = 5
        Me.txtQID.Multiline = True
        Me.txtQID.Name = "txtQID"
        Me.txtQID.Size = New System.Drawing.Size(90, 40)
        Me.txtQID.TabIndex = 1
        Me.txtQID.Text = ""
        Me.txtQID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboQID
        '
        Me.cboQID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQID.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQID.Location = New System.Drawing.Point(100, 0)
        Me.cboQID.Name = "cboQID"
        Me.cboQID.Size = New System.Drawing.Size(90, 24)
        Me.cboQID.TabIndex = 0
        '
        'btnChooseImage
        '
        Me.btnChooseImage.BackColor = System.Drawing.Color.SteelBlue
        Me.btnChooseImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseImage.Location = New System.Drawing.Point(680, 40)
        Me.btnChooseImage.Name = "btnChooseImage"
        Me.btnChooseImage.Size = New System.Drawing.Size(110, 25)
        Me.btnChooseImage.TabIndex = 12
        Me.btnChooseImage.Text = "Choose &Image .."
        '
        'btnViewImage
        '
        Me.btnViewImage.BackColor = System.Drawing.Color.SteelBlue
        Me.btnViewImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewImage.Location = New System.Drawing.Point(680, 70)
        Me.btnViewImage.Name = "btnViewImage"
        Me.btnViewImage.Size = New System.Drawing.Size(110, 25)
        Me.btnViewImage.TabIndex = 13
        Me.btnViewImage.Text = "Pre&view Image .."
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(620, 430)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 30)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "&Save Exam"
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.Location = New System.Drawing.Point(620, 465)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(105, 30)
        Me.btnPreview.TabIndex = 19
        Me.btnPreview.Text = "P&review Exam"
        '
        'ofdOpenFile
        '
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.SteelBlue
        Me.btnLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(730, 395)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(60, 30)
        Me.btnLast.TabIndex = 24
        Me.btnLast.Text = "&Last"
        Me.ToolTip1.SetToolTip(Me.btnLast, "Go to the Last FlashCard in the set")
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.SteelBlue
        Me.btnFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.Location = New System.Drawing.Point(730, 290)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(60, 30)
        Me.btnFirst.TabIndex = 21
        Me.btnFirst.Text = "&First"
        Me.ToolTip1.SetToolTip(Me.btnFirst, "Go to the First FlashCard")
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(730, 325)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(60, 30)
        Me.btnPrevious.TabIndex = 22
        Me.btnPrevious.Text = "&Previous"
        Me.ToolTip1.SetToolTip(Me.btnPrevious, "Go to the Previous FlashCard")
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(730, 360)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(60, 30)
        Me.btnNext.TabIndex = 23
        Me.btnNext.Text = "&Next"
        Me.ToolTip1.SetToolTip(Me.btnNext, "Go to the Previous FlashCard")
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.OrangeRed
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(620, 325)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 30)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "&Delete Question"
        Me.ToolTip1.SetToolTip(Me.btnDelete, "Delete FlashCard")
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Yellow
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(620, 290)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(105, 30)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "&Add Question"
        Me.ToolTip1.SetToolTip(Me.btnAdd, "Add FlashCard")
        '
        'btnShowHide
        '
        Me.btnShowHide.Location = New System.Drawing.Point(30, 120)
        Me.btnShowHide.Name = "btnShowHide"
        Me.btnShowHide.Size = New System.Drawing.Size(30, 20)
        Me.btnShowHide.TabIndex = 27
        Me.btnShowHide.Text = "+ -"
        Me.ToolTip1.SetToolTip(Me.btnShowHide, "Show/Hide Answers")
        '
        'btnExpandE
        '
        Me.btnExpandE.Location = New System.Drawing.Point(65, 480)
        Me.btnExpandE.Name = "btnExpandE"
        Me.btnExpandE.Size = New System.Drawing.Size(30, 20)
        Me.btnExpandE.TabIndex = 35
        Me.btnExpandE.Text = "+ -"
        Me.ToolTip1.SetToolTip(Me.btnExpandE, "Expand/Shrink Explanation Box")
        '
        'btnExpandQues
        '
        Me.btnExpandQues.Location = New System.Drawing.Point(65, 120)
        Me.btnExpandQues.Name = "btnExpandQues"
        Me.btnExpandQues.Size = New System.Drawing.Size(30, 20)
        Me.btnExpandQues.TabIndex = 28
        Me.btnExpandQues.Text = "+ -"
        Me.ToolTip1.SetToolTip(Me.btnExpandQues, "Expand/Shrink Question Box")
        '
        'lblIDNumber
        '
        Me.lblIDNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblIDNumber.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDNumber.ForeColor = System.Drawing.Color.Black
        Me.lblIDNumber.Location = New System.Drawing.Point(10, 25)
        Me.lblIDNumber.Name = "lblIDNumber"
        Me.lblIDNumber.Size = New System.Drawing.Size(90, 40)
        Me.lblIDNumber.TabIndex = 37
        Me.lblIDNumber.Text = "Question ID:"
        Me.lblIDNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQuestion
        '
        Me.lblQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.ForeColor = System.Drawing.Color.Black
        Me.lblQuestion.Location = New System.Drawing.Point(10, 65)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(90, 30)
        Me.lblQuestion.TabIndex = 38
        Me.lblQuestion.Text = "Question:"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPromptExplanation
        '
        Me.lblPromptExplanation.BackColor = System.Drawing.Color.Transparent
        Me.lblPromptExplanation.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptExplanation.ForeColor = System.Drawing.Color.Black
        Me.lblPromptExplanation.Location = New System.Drawing.Point(5, 435)
        Me.lblPromptExplanation.Name = "lblPromptExplanation"
        Me.lblPromptExplanation.Size = New System.Drawing.Size(95, 25)
        Me.lblPromptExplanation.TabIndex = 22
        Me.lblPromptExplanation.Text = "Explanation:"
        Me.lblPromptExplanation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPromptPreview
        '
        Me.lblPromptPreview.BackColor = System.Drawing.Color.Transparent
        Me.lblPromptPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPromptPreview.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptPreview.ForeColor = System.Drawing.Color.Black
        Me.lblPromptPreview.Location = New System.Drawing.Point(620, 100)
        Me.lblPromptPreview.Name = "lblPromptPreview"
        Me.lblPromptPreview.Size = New System.Drawing.Size(170, 25)
        Me.lblPromptPreview.TabIndex = 20
        Me.lblPromptPreview.Text = "Exhibit Preview:"
        Me.lblPromptPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(100, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 35)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Answer 2:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.lblTitle.BackColor = System.Drawing.Color.Navy
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(195, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(595, 30)
        Me.lblTitle.TabIndex = 41
        Me.lblTitle.Text = "Exam Editor: Editing dbexam.mdb - Table Q1"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'odbConExam
        '
        Me.odbConExam.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\STUFF\Q" & _
        "UEENEDIT2004.2002\bin\dbexam.mdb;Mode=Share Deny None;Extended Properties="""";Jet" & _
        " OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password" & _
        "="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global P" & _
        "artial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Pa" & _
        "ssword="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=Fals" & _
        "e;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica" & _
        " Repair=False;Jet OLEDB:SFP=False"
        '
        'odbDaExam
        '
        Me.odbDaExam.DeleteCommand = Me.OleDbDeleteCommand1
        Me.odbDaExam.InsertCommand = Me.OleDbInsertCommand1
        Me.odbDaExam.SelectCommand = Me.OleDbSelectCommand1
        Me.odbDaExam.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Q1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("QID", "QID"), New System.Data.Common.DataColumnMapping("Ques", "Ques"), New System.Data.Common.DataColumnMapping("Ans2", "Ans2"), New System.Data.Common.DataColumnMapping("Ans1", "Ans1"), New System.Data.Common.DataColumnMapping("Ans3", "Ans3"), New System.Data.Common.DataColumnMapping("Ans4", "Ans4"), New System.Data.Common.DataColumnMapping("Ans5", "Ans5"), New System.Data.Common.DataColumnMapping("Ans6", "Ans6"), New System.Data.Common.DataColumnMapping("Ans7", "Ans7"), New System.Data.Common.DataColumnMapping("AnsA", "AnsA"), New System.Data.Common.DataColumnMapping("AnsB", "AnsB"), New System.Data.Common.DataColumnMapping("AnsC", "AnsC"), New System.Data.Common.DataColumnMapping("AnsD", "AnsD"), New System.Data.Common.DataColumnMapping("AnsE", "AnsE"), New System.Data.Common.DataColumnMapping("AnsF", "AnsF"), New System.Data.Common.DataColumnMapping("AnsG", "AnsG"), New System.Data.Common.DataColumnMapping("Answer", "Answer"), New System.Data.Common.DataColumnMapping("chkoropt", "chkoropt"), New System.Data.Common.DataColumnMapping("Exhibit", "Exhibit"), New System.Data.Common.DataColumnMapping("ExhibitName", "ExhibitName"), New System.Data.Common.DataColumnMapping("Explanation", "Explanation"), New System.Data.Common.DataColumnMapping("InputAnswer", "InputAnswer"), New System.Data.Common.DataColumnMapping("InputAnswer2", "InputAnswer2")})})
        Me.odbDaExam.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Q1 WHERE (QID = ?) AND (Ans1 = ? OR ? IS NULL AND Ans1 IS NULL) AND (" & _
        "Ans2 = ? OR ? IS NULL AND Ans2 IS NULL) AND (Ans3 = ? OR ? IS NULL AND Ans3 IS N" & _
        "ULL) AND (Ans4 = ? OR ? IS NULL AND Ans4 IS NULL) AND (Ans5 = ? OR ? IS NULL AND" & _
        " Ans5 IS NULL) AND (Ans6 = ? OR ? IS NULL AND Ans6 IS NULL) AND (Ans7 = ? OR ? I" & _
        "S NULL AND Ans7 IS NULL) AND (AnsA = ? OR ? IS NULL AND AnsA IS NULL) AND (AnsB " & _
        "= ? OR ? IS NULL AND AnsB IS NULL) AND (AnsC = ? OR ? IS NULL AND AnsC IS NULL) " & _
        "AND (AnsD = ? OR ? IS NULL AND AnsD IS NULL) AND (AnsE = ? OR ? IS NULL AND AnsE" & _
        " IS NULL) AND (AnsF = ? OR ? IS NULL AND AnsF IS NULL) AND (AnsG = ? OR ? IS NUL" & _
        "L AND AnsG IS NULL) AND (Answer = ? OR ? IS NULL AND Answer IS NULL) AND (Exhibi" & _
        "t = ? OR ? IS NULL AND Exhibit IS NULL) AND (ExhibitName = ? OR ? IS NULL AND Ex" & _
        "hibitName IS NULL) AND (Explanation = ? OR ? IS NULL AND Explanation IS NULL) AN" & _
        "D (InputAnswer = ? OR ? IS NULL AND InputAnswer IS NULL) AND (InputAnswer2 = ? O" & _
        "R ? IS NULL AND InputAnswer2 IS NULL) AND (Ques = ? OR ? IS NULL AND Ques IS NUL" & _
        "L) AND (chkoropt = ? OR ? IS NULL AND chkoropt IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.odbConExam
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_QID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "QID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans11", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans2", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans21", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans3", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans31", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans4", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans41", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans5", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans5", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans51", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans5", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans6", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans6", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans61", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans6", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans7", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans7", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans71", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans7", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsA", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsA1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsB", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsB", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsB1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsB", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsC", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsC1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsD", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsD", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsD1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsD", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsE", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsE1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsF", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsF1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsG", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsG", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsG1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsG", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Answer", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Answer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Answer1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Answer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Exhibit", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exhibit", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Exhibit1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exhibit", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExhibitName", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExhibitName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExhibitName1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExhibitName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Explanation", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Explanation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Explanation1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Explanation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InputAnswer", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InputAnswer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InputAnswer1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InputAnswer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InputAnswer2", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InputAnswer2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InputAnswer21", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InputAnswer2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ques", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ques", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ques1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ques", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_chkoropt", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "chkoropt", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_chkoropt1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "chkoropt", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Q1(QID, Ques, Ans2, Ans1, Ans3, Ans4, Ans5, Ans6, Ans7, AnsA, AnsB, A" & _
        "nsC, AnsD, AnsE, AnsF, AnsG, Answer, chkoropt, Exhibit, ExhibitName, Explanation" & _
        ", InputAnswer, InputAnswer2) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?" & _
        ", ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.odbConExam
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("QID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "QID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ques", System.Data.OleDb.OleDbType.VarWChar, 0, "Ques"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ans2", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans2", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ans1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans1", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ans3", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans3", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ans4", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans4", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ans5", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans5", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ans6", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans6", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ans7", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans7", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnsA", System.Data.OleDb.OleDbType.VarWChar, 0, "AnsA"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnsB", System.Data.OleDb.OleDbType.VarWChar, 0, "AnsB"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnsC", System.Data.OleDb.OleDbType.VarWChar, 0, "AnsC"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnsD", System.Data.OleDb.OleDbType.VarWChar, 0, "AnsD"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnsE", System.Data.OleDb.OleDbType.VarWChar, 0, "AnsE"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnsF", System.Data.OleDb.OleDbType.VarWChar, 0, "AnsF"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnsG", System.Data.OleDb.OleDbType.VarWChar, 0, "AnsG"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Answer", System.Data.OleDb.OleDbType.VarWChar, 0, "Answer"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("chkoropt", System.Data.OleDb.OleDbType.VarWChar, 3, "chkoropt"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Exhibit", System.Data.OleDb.OleDbType.VarWChar, 3, "Exhibit"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ExhibitName", System.Data.OleDb.OleDbType.VarWChar, 100, "ExhibitName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Explanation", System.Data.OleDb.OleDbType.VarWChar, 0, "Explanation"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("InputAnswer", System.Data.OleDb.OleDbType.VarWChar, 255, "InputAnswer"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("InputAnswer2", System.Data.OleDb.OleDbType.VarWChar, 255, "InputAnswer2"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT QID, Ques, Ans2, Ans1, Ans3, Ans4, Ans5, Ans6, Ans7, AnsA, AnsB, AnsC, Ans" & _
        "D, AnsE, AnsF, AnsG, Answer, chkoropt, Exhibit, ExhibitName, Explanation, InputA" & _
        "nswer, InputAnswer2 FROM Q1"
        Me.OleDbSelectCommand1.Connection = Me.odbConExam
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Q1 SET QID = ?, Ques = ?, Ans2 = ?, Ans1 = ?, Ans3 = ?, Ans4 = ?, Ans5 = ?" & _
        ", Ans6 = ?, Ans7 = ?, AnsA = ?, AnsB = ?, AnsC = ?, AnsD = ?, AnsE = ?, AnsF = ?" & _
        ", AnsG = ?, Answer = ?, chkoropt = ?, Exhibit = ?, ExhibitName = ?, Explanation " & _
        "= ?, InputAnswer = ?, InputAnswer2 = ? WHERE (QID = ?) AND (Ans1 = ? OR ? IS NUL" & _
        "L AND Ans1 IS NULL) AND (Ans2 = ? OR ? IS NULL AND Ans2 IS NULL) AND (Ans3 = ? O" & _
        "R ? IS NULL AND Ans3 IS NULL) AND (Ans4 = ? OR ? IS NULL AND Ans4 IS NULL) AND (" & _
        "Ans5 = ? OR ? IS NULL AND Ans5 IS NULL) AND (Ans6 = ? OR ? IS NULL AND Ans6 IS N" & _
        "ULL) AND (Ans7 = ? OR ? IS NULL AND Ans7 IS NULL) AND (AnsA = ? OR ? IS NULL AND" & _
        " AnsA IS NULL) AND (AnsB = ? OR ? IS NULL AND AnsB IS NULL) AND (AnsC = ? OR ? I" & _
        "S NULL AND AnsC IS NULL) AND (AnsD = ? OR ? IS NULL AND AnsD IS NULL) AND (AnsE " & _
        "= ? OR ? IS NULL AND AnsE IS NULL) AND (AnsF = ? OR ? IS NULL AND AnsF IS NULL) " & _
        "AND (AnsG = ? OR ? IS NULL AND AnsG IS NULL) AND (Answer = ? OR ? IS NULL AND An" & _
        "swer IS NULL) AND (Exhibit = ? OR ? IS NULL AND Exhibit IS NULL) AND (ExhibitNam" & _
        "e = ? OR ? IS NULL AND ExhibitName IS NULL) AND (Explanation = ? OR ? IS NULL AN" & _
        "D Explanation IS NULL) AND (InputAnswer = ? OR ? IS NULL AND InputAnswer IS NULL" & _
        ") AND (InputAnswer2 = ? OR ? IS NULL AND InputAnswer2 IS NULL) AND (Ques = ? OR " & _
        "? IS NULL AND Ques IS NULL) AND (chkoropt = ? OR ? IS NULL AND chkoropt IS NULL)" & _
        ""
        Me.OleDbUpdateCommand1.Connection = Me.odbConExam
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("QID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "QID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ques", System.Data.OleDb.OleDbType.VarWChar, 0, "Ques"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ans2", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans2", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ans1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans1", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ans3", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans3", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ans4", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans4", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ans5", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans5", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ans6", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans6", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ans7", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans7", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnsA", System.Data.OleDb.OleDbType.VarWChar, 0, "AnsA"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnsB", System.Data.OleDb.OleDbType.VarWChar, 0, "AnsB"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnsC", System.Data.OleDb.OleDbType.VarWChar, 0, "AnsC"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnsD", System.Data.OleDb.OleDbType.VarWChar, 0, "AnsD"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnsE", System.Data.OleDb.OleDbType.VarWChar, 0, "AnsE"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnsF", System.Data.OleDb.OleDbType.VarWChar, 0, "AnsF"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnsG", System.Data.OleDb.OleDbType.VarWChar, 0, "AnsG"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Answer", System.Data.OleDb.OleDbType.VarWChar, 0, "Answer"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("chkoropt", System.Data.OleDb.OleDbType.VarWChar, 3, "chkoropt"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Exhibit", System.Data.OleDb.OleDbType.VarWChar, 3, "Exhibit"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ExhibitName", System.Data.OleDb.OleDbType.VarWChar, 100, "ExhibitName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Explanation", System.Data.OleDb.OleDbType.VarWChar, 0, "Explanation"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("InputAnswer", System.Data.OleDb.OleDbType.VarWChar, 255, "InputAnswer"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("InputAnswer2", System.Data.OleDb.OleDbType.VarWChar, 255, "InputAnswer2"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_QID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "QID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans11", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans2", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans21", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans3", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans31", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans4", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans41", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans5", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans5", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans51", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans5", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans6", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans6", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans61", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans6", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans7", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans7", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ans71", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Ans7", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsA", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsA1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsB", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsB", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsB1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsB", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsC", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsC1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsD", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsD", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsD1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsD", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsE", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsE1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsF", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsF1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsG", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsG", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnsG1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnsG", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Answer", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Answer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Answer1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Answer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Exhibit", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exhibit", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Exhibit1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exhibit", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExhibitName", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExhibitName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExhibitName1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExhibitName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Explanation", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Explanation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Explanation1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Explanation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InputAnswer", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InputAnswer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InputAnswer1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InputAnswer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InputAnswer2", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InputAnswer2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InputAnswer21", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InputAnswer2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ques", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ques", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ques1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ques", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_chkoropt", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "chkoropt", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_chkoropt1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "chkoropt", System.Data.DataRowVersion.Original, Nothing))
        '
        'DsExam1
        '
        Me.DsExam1.DataSetName = "dsExam"
        Me.DsExam1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsExam1.Namespace = "http://www.tempuri.org/dsExam.xsd"
        '
        'txtExhibit
        '
        Me.txtExhibit.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtExhibit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExhibit.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txtExhibit.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtExhibit.Location = New System.Drawing.Point(625, 465)
        Me.txtExhibit.MaxLength = 3
        Me.txtExhibit.Name = "txtExhibit"
        Me.txtExhibit.Size = New System.Drawing.Size(95, 20)
        Me.txtExhibit.TabIndex = 96
        Me.txtExhibit.Text = ""
        Me.txtExhibit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(730, 465)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(60, 30)
        Me.btnClose.TabIndex = 26
        Me.btnClose.Text = "&Close"
        '
        'txtG
        '
        Me.txtG.BackColor = System.Drawing.Color.LightGray
        Me.txtG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtG.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtG.Location = New System.Drawing.Point(310, 110)
        Me.txtG.MaxLength = 1
        Me.txtG.Multiline = True
        Me.txtG.Name = "txtG"
        Me.txtG.Size = New System.Drawing.Size(25, 25)
        Me.txtG.TabIndex = 42
        Me.txtG.Text = ""
        '
        'txtF
        '
        Me.txtF.BackColor = System.Drawing.Color.LightGray
        Me.txtF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF.Location = New System.Drawing.Point(275, 110)
        Me.txtF.MaxLength = 1
        Me.txtF.Multiline = True
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(25, 25)
        Me.txtF.TabIndex = 41
        Me.txtF.Text = ""
        '
        'txtE
        '
        Me.txtE.BackColor = System.Drawing.Color.LightGray
        Me.txtE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtE.Location = New System.Drawing.Point(235, 110)
        Me.txtE.MaxLength = 1
        Me.txtE.Multiline = True
        Me.txtE.Name = "txtE"
        Me.txtE.Size = New System.Drawing.Size(25, 25)
        Me.txtE.TabIndex = 40
        Me.txtE.Text = ""
        '
        'txtD
        '
        Me.txtD.BackColor = System.Drawing.Color.LightGray
        Me.txtD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtD.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtD.Location = New System.Drawing.Point(200, 110)
        Me.txtD.MaxLength = 1
        Me.txtD.Multiline = True
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(25, 25)
        Me.txtD.TabIndex = 39
        Me.txtD.Text = ""
        '
        'txtC
        '
        Me.txtC.BackColor = System.Drawing.Color.LightGray
        Me.txtC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC.Location = New System.Drawing.Point(165, 110)
        Me.txtC.MaxLength = 1
        Me.txtC.Multiline = True
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(25, 25)
        Me.txtC.TabIndex = 38
        Me.txtC.Text = ""
        '
        'txtB
        '
        Me.txtB.BackColor = System.Drawing.Color.LightGray
        Me.txtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtB.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.Location = New System.Drawing.Point(135, 110)
        Me.txtB.MaxLength = 1
        Me.txtB.Multiline = True
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(25, 25)
        Me.txtB.TabIndex = 37
        Me.txtB.Text = ""
        '
        'txtA
        '
        Me.txtA.BackColor = System.Drawing.Color.LightGray
        Me.txtA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(100, 110)
        Me.txtA.MaxLength = 1
        Me.txtA.Multiline = True
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(25, 25)
        Me.txtA.TabIndex = 36
        Me.txtA.Text = ""
        '
        'btnChangeAnswer
        '
        Me.btnChangeAnswer.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
        Me.btnChangeAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeAnswer.Location = New System.Drawing.Point(620, 360)
        Me.btnChangeAnswer.Name = "btnChangeAnswer"
        Me.btnChangeAnswer.Size = New System.Drawing.Size(105, 30)
        Me.btnChangeAnswer.TabIndex = 16
        Me.btnChangeAnswer.Text = "C&hange"
        '
        'rbHidden
        '
        Me.rbHidden.BackColor = System.Drawing.Color.Transparent
        Me.rbHidden.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbHidden.Checked = True
        Me.rbHidden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbHidden.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHidden.Location = New System.Drawing.Point(25, 395)
        Me.rbHidden.Name = "rbHidden"
        Me.rbHidden.Size = New System.Drawing.Size(65, 20)
        Me.rbHidden.TabIndex = 43
        Me.rbHidden.TabStop = True
        Me.rbHidden.Text = "Hidden"
        Me.rbHidden.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk1
        '
        Me.chk1.BackColor = System.Drawing.Color.Transparent
        Me.chk1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk1.Location = New System.Drawing.Point(65, 150)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(25, 24)
        Me.chk1.TabIndex = 28
        Me.chk1.Visible = False
        '
        'chk2
        '
        Me.chk2.BackColor = System.Drawing.Color.Transparent
        Me.chk2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk2.Location = New System.Drawing.Point(65, 185)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(25, 24)
        Me.chk2.TabIndex = 29
        Me.chk2.Visible = False
        '
        'chk3
        '
        Me.chk3.BackColor = System.Drawing.Color.Transparent
        Me.chk3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk3.Location = New System.Drawing.Point(65, 220)
        Me.chk3.Name = "chk3"
        Me.chk3.Size = New System.Drawing.Size(25, 24)
        Me.chk3.TabIndex = 30
        Me.chk3.Visible = False
        '
        'chk4
        '
        Me.chk4.BackColor = System.Drawing.Color.Transparent
        Me.chk4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk4.Location = New System.Drawing.Point(65, 255)
        Me.chk4.Name = "chk4"
        Me.chk4.Size = New System.Drawing.Size(25, 24)
        Me.chk4.TabIndex = 31
        Me.chk4.Visible = False
        '
        'chk5
        '
        Me.chk5.BackColor = System.Drawing.Color.Transparent
        Me.chk5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk5.Location = New System.Drawing.Point(65, 290)
        Me.chk5.Name = "chk5"
        Me.chk5.Size = New System.Drawing.Size(25, 24)
        Me.chk5.TabIndex = 32
        Me.chk5.Visible = False
        '
        'chk6
        '
        Me.chk6.BackColor = System.Drawing.Color.Transparent
        Me.chk6.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk6.Location = New System.Drawing.Point(65, 325)
        Me.chk6.Name = "chk6"
        Me.chk6.Size = New System.Drawing.Size(25, 24)
        Me.chk6.TabIndex = 33
        Me.chk6.Visible = False
        '
        'chk7
        '
        Me.chk7.BackColor = System.Drawing.Color.Transparent
        Me.chk7.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk7.Location = New System.Drawing.Point(65, 360)
        Me.chk7.Name = "chk7"
        Me.chk7.Size = New System.Drawing.Size(25, 24)
        Me.chk7.TabIndex = 34
        Me.chk7.Visible = False
        '
        'picCheck1
        '
        Me.picCheck1.BackColor = System.Drawing.Color.White
        Me.picCheck1.Image = CType(resources.GetObject("picCheck1.Image"), System.Drawing.Bitmap)
        Me.picCheck1.Location = New System.Drawing.Point(30, 150)
        Me.picCheck1.Name = "picCheck1"
        Me.picCheck1.Size = New System.Drawing.Size(25, 25)
        Me.picCheck1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picCheck1.TabIndex = 120
        Me.picCheck1.TabStop = False
        '
        'picX1
        '
        Me.picX1.BackColor = System.Drawing.Color.White
        Me.picX1.Image = CType(resources.GetObject("picX1.Image"), System.Drawing.Bitmap)
        Me.picX1.Location = New System.Drawing.Point(30, 150)
        Me.picX1.Name = "picX1"
        Me.picX1.Size = New System.Drawing.Size(25, 25)
        Me.picX1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picX1.TabIndex = 121
        Me.picX1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(730, 430)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(60, 30)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "Cancel"
        '
        'picX2
        '
        Me.picX2.BackColor = System.Drawing.Color.White
        Me.picX2.Image = CType(resources.GetObject("picX2.Image"), System.Drawing.Bitmap)
        Me.picX2.Location = New System.Drawing.Point(30, 185)
        Me.picX2.Name = "picX2"
        Me.picX2.Size = New System.Drawing.Size(25, 25)
        Me.picX2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picX2.TabIndex = 123
        Me.picX2.TabStop = False
        '
        'picX3
        '
        Me.picX3.BackColor = System.Drawing.Color.White
        Me.picX3.Image = CType(resources.GetObject("picX3.Image"), System.Drawing.Bitmap)
        Me.picX3.Location = New System.Drawing.Point(30, 220)
        Me.picX3.Name = "picX3"
        Me.picX3.Size = New System.Drawing.Size(25, 25)
        Me.picX3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picX3.TabIndex = 124
        Me.picX3.TabStop = False
        '
        'picX4
        '
        Me.picX4.BackColor = System.Drawing.Color.White
        Me.picX4.Image = CType(resources.GetObject("picX4.Image"), System.Drawing.Bitmap)
        Me.picX4.Location = New System.Drawing.Point(30, 255)
        Me.picX4.Name = "picX4"
        Me.picX4.Size = New System.Drawing.Size(25, 25)
        Me.picX4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picX4.TabIndex = 125
        Me.picX4.TabStop = False
        '
        'picX5
        '
        Me.picX5.BackColor = System.Drawing.Color.White
        Me.picX5.Image = CType(resources.GetObject("picX5.Image"), System.Drawing.Bitmap)
        Me.picX5.Location = New System.Drawing.Point(30, 290)
        Me.picX5.Name = "picX5"
        Me.picX5.Size = New System.Drawing.Size(25, 25)
        Me.picX5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picX5.TabIndex = 126
        Me.picX5.TabStop = False
        '
        'picX6
        '
        Me.picX6.BackColor = System.Drawing.Color.White
        Me.picX6.Image = CType(resources.GetObject("picX6.Image"), System.Drawing.Bitmap)
        Me.picX6.Location = New System.Drawing.Point(30, 325)
        Me.picX6.Name = "picX6"
        Me.picX6.Size = New System.Drawing.Size(25, 25)
        Me.picX6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picX6.TabIndex = 127
        Me.picX6.TabStop = False
        '
        'picX7
        '
        Me.picX7.BackColor = System.Drawing.Color.White
        Me.picX7.Image = CType(resources.GetObject("picX7.Image"), System.Drawing.Bitmap)
        Me.picX7.Location = New System.Drawing.Point(30, 360)
        Me.picX7.Name = "picX7"
        Me.picX7.Size = New System.Drawing.Size(25, 25)
        Me.picX7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picX7.TabIndex = 128
        Me.picX7.TabStop = False
        '
        'picCheck3
        '
        Me.picCheck3.BackColor = System.Drawing.Color.White
        Me.picCheck3.Image = CType(resources.GetObject("picCheck3.Image"), System.Drawing.Bitmap)
        Me.picCheck3.Location = New System.Drawing.Point(30, 220)
        Me.picCheck3.Name = "picCheck3"
        Me.picCheck3.Size = New System.Drawing.Size(25, 25)
        Me.picCheck3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picCheck3.TabIndex = 129
        Me.picCheck3.TabStop = False
        '
        'picCheck4
        '
        Me.picCheck4.BackColor = System.Drawing.Color.White
        Me.picCheck4.Image = CType(resources.GetObject("picCheck4.Image"), System.Drawing.Bitmap)
        Me.picCheck4.Location = New System.Drawing.Point(30, 255)
        Me.picCheck4.Name = "picCheck4"
        Me.picCheck4.Size = New System.Drawing.Size(25, 25)
        Me.picCheck4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picCheck4.TabIndex = 130
        Me.picCheck4.TabStop = False
        '
        'picCheck2
        '
        Me.picCheck2.BackColor = System.Drawing.Color.White
        Me.picCheck2.Image = CType(resources.GetObject("picCheck2.Image"), System.Drawing.Bitmap)
        Me.picCheck2.Location = New System.Drawing.Point(30, 185)
        Me.picCheck2.Name = "picCheck2"
        Me.picCheck2.Size = New System.Drawing.Size(25, 25)
        Me.picCheck2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picCheck2.TabIndex = 131
        Me.picCheck2.TabStop = False
        '
        'picCheck5
        '
        Me.picCheck5.BackColor = System.Drawing.Color.White
        Me.picCheck5.Image = CType(resources.GetObject("picCheck5.Image"), System.Drawing.Bitmap)
        Me.picCheck5.Location = New System.Drawing.Point(30, 290)
        Me.picCheck5.Name = "picCheck5"
        Me.picCheck5.Size = New System.Drawing.Size(25, 25)
        Me.picCheck5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picCheck5.TabIndex = 132
        Me.picCheck5.TabStop = False
        '
        'picCheck6
        '
        Me.picCheck6.BackColor = System.Drawing.Color.White
        Me.picCheck6.Image = CType(resources.GetObject("picCheck6.Image"), System.Drawing.Bitmap)
        Me.picCheck6.Location = New System.Drawing.Point(30, 325)
        Me.picCheck6.Name = "picCheck6"
        Me.picCheck6.Size = New System.Drawing.Size(25, 25)
        Me.picCheck6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picCheck6.TabIndex = 133
        Me.picCheck6.TabStop = False
        '
        'picCheck7
        '
        Me.picCheck7.BackColor = System.Drawing.Color.White
        Me.picCheck7.Image = CType(resources.GetObject("picCheck7.Image"), System.Drawing.Bitmap)
        Me.picCheck7.Location = New System.Drawing.Point(30, 360)
        Me.picCheck7.Name = "picCheck7"
        Me.picCheck7.Size = New System.Drawing.Size(25, 25)
        Me.picCheck7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picCheck7.TabIndex = 134
        Me.picCheck7.TabStop = False
        '
        'picCheck8
        '
        Me.picCheck8.BackColor = System.Drawing.Color.White
        Me.picCheck8.Image = CType(resources.GetObject("picCheck8.Image"), System.Drawing.Bitmap)
        Me.picCheck8.Location = New System.Drawing.Point(100, 185)
        Me.picCheck8.Name = "picCheck8"
        Me.picCheck8.Size = New System.Drawing.Size(25, 25)
        Me.picCheck8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picCheck8.TabIndex = 135
        Me.picCheck8.TabStop = False
        '
        'picCheck9
        '
        Me.picCheck9.BackColor = System.Drawing.Color.White
        Me.picCheck9.Image = CType(resources.GetObject("picCheck9.Image"), System.Drawing.Bitmap)
        Me.picCheck9.Location = New System.Drawing.Point(100, 255)
        Me.picCheck9.Name = "picCheck9"
        Me.picCheck9.Size = New System.Drawing.Size(25, 25)
        Me.picCheck9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picCheck9.TabIndex = 136
        Me.picCheck9.TabStop = False
        '
        'lblPromptInputAnswer
        '
        Me.lblPromptInputAnswer.BackColor = System.Drawing.Color.White
        Me.lblPromptInputAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPromptInputAnswer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptInputAnswer.ForeColor = System.Drawing.Color.Black
        Me.lblPromptInputAnswer.Location = New System.Drawing.Point(100, 145)
        Me.lblPromptInputAnswer.Name = "lblPromptInputAnswer"
        Me.lblPromptInputAnswer.Size = New System.Drawing.Size(75, 35)
        Me.lblPromptInputAnswer.TabIndex = 137
        Me.lblPromptInputAnswer.Text = "Answer 1:"
        Me.lblPromptInputAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Location = New System.Drawing.Point(550, 395)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(60, 30)
        Me.btnSend.TabIndex = 20
        Me.btnSend.Text = "Quick Add"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 395)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 25)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Answer:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tmrTimer
        '
        Me.tmrTimer.Interval = 2000
        '
        'frmEditExam
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(792, 510)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtQues, Me.txtExplanation, Me.txtAnsA, Me.txtAnsE, Me.txtAnsD, Me.txtAnsC, Me.txtAnsB, Me.txtAnswer, Me.txtAnsG, Me.txtAnsF, Me.lblIDNumber, Me.btnExpandQues, Me.picCheck2, Me.picCheck1, Me.btnExpandE, Me.btnShowHide, Me.Label2, Me.lblPromptInputAnswer, Me.picCheck7, Me.picCheck6, Me.picCheck5, Me.picCheck4, Me.picCheck3, Me.picX7, Me.picX6, Me.picX5, Me.picX4, Me.picX3, Me.picX2, Me.btnCancel, Me.btnDelete, Me.btnAdd, Me.btnNext, Me.btnLast, Me.btnFirst, Me.btnPrevious, Me.chk7, Me.chk6, Me.chk5, Me.chk4, Me.chk3, Me.chk2, Me.chk1, Me.btnChangeAnswer, Me.btnClose, Me.lblTitle, Me.Label4, Me.lblPromptPreview, Me.lblPromptExplanation, Me.lblQuestion, Me.btnPreview, Me.btnSave, Me.btnViewImage, Me.btnChooseImage, Me.cboQID, Me.txtQID, Me.picExhibit, Me.lblGoTo, Me.txtInputAnswer2, Me.txtInputAnswer, Me.gbType, Me.txtImageURL, Me.lblchkoropt, Me.txtChkOrOpt, Me.txtExhibit, Me.rbHidden, Me.txtG, Me.txtF, Me.txtE, Me.txtD, Me.txtC, Me.gbExhibit, Me.picX1, Me.picCheck8, Me.picCheck9, Me.btnSend, Me.txtA, Me.txtB})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditExam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TestQueen Exam Editor"
        Me.gbType.ResumeLayout(False)
        Me.gbExhibit.ResumeLayout(False)
        CType(Me.DsExam1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Messageboxes"
    Sub MsgBoxA()
        MsgBox("You must add at least " & fintMaxQuestions & " questions to preview this exam." & vbCrLf _
            & "To preview current questions, change the max questions value in the Icon Editor " & _
            "for this specific exam")
    End Sub
    Sub MsgBoxAA()
        MsgBox("You must add at least 5 questions to preview this exam." & vbCrLf _
                    & "Please add at least 5 questions.")
    End Sub
    Sub MsgBoxB()
        Dim Msg As MsgBoxResult
        If mblnDirty Then
            Msg = MsgBox("Save Changes?", MsgBoxStyle.YesNo, "Confirm Changes")
            If Msg = MsgBoxResult.Yes Then
                EditUpdate()
                SaveDatabaseFile()
            End If
        End If
    End Sub
    Sub MsgBoxC()
        MsgBox("You selected question type: 'Multiple Answer'. Please select two or more correct answers " _
        & "or select another question type.")
    End Sub
    Sub MsgBoxD()
        MsgBox("Only one correct answer is allowed. " _
        & "Please select question type: 'Multiple Answer', or choose only one correct answer.")
    End Sub
    Sub MsgBoxF()
        MsgBox("Please click 'Choose Image' to select an Exhibit or choose 'No' for 'Exhibit'.")
    End Sub
    Sub MsgBoxG()
        MsgBox("Please select a 'Question Type' above.")
    End Sub
    Sub MsgBoxH()
        MsgBox("Please select a correct answer by clicking the checkboxes.")
    End Sub
    Sub MsgBoxI()
        MsgBox("Please select a 'Question Type' for Question ID number " & mIDNum & ".")
    End Sub
    Sub MsgBoxJ()
        MsgBox("Please select an image to use for 'Exhibit': Question ID number " & mIDNum & ".")
    End Sub
    Sub MsgBoxK()
        MsgBox("Please select a valid image to use for Exhibit: Question ID number " & mIDNum & ".")
    End Sub
    Function MsgBoxL() As MsgBoxResult
        Dim mr As MsgBoxResult = MsgBox("You may have changed the exam type from 'Flashcards' or 'Labs' to " _
        & "'Practice Exams'. Click OK to overwrite the old exam for this module with a new exam. Click " _
        & "Cancel to go back to the module editor. Navigate to the module folder " _
        & "on your hard drive and copy it to another directory as a backup or change it back to the previous " _
        & "Exam Type: 'Flashcards' or 'Labs'", MsgBoxStyle.OKCancel, "Confirm Exam Overwrite")

        Return mr
    End Function
#End Region

    Private Overloads Sub BindData(ByVal lblLabel As Label, ByVal strS As String)
        Dim pb As Binding = New Binding("Text", DsExam1, strS)
        lblLabel.DataBindings.Add(pb)
    End Sub
    Private Overloads Sub BindData(ByVal txtBox As TextBox, ByVal strS As String)
        Dim pb As Binding = New Binding("Text", DsExam1, strS)
        txtBox.DataBindings.Add(pb)
    End Sub
    Private Function GetCheckState(ByVal check As CheckBox) As String
        If check.CheckState = CheckState.Checked Then
            Return "1"
        Else : Return "0"
        End If
    End Function
    Private Function GetCheckSum() As Integer
        Dim intSum As Integer
        intSum = ToInt32(txtA.Text) + ToInt32(txtB.Text) + ToInt32(txtC.Text) + ToInt32(txtD.Text) _
            + ToInt32(txtE.Text) + ToInt32(txtF.Text) + ToInt32(txtG.Text)
        Return intSum
    End Function
    Private Function ImageUrlOK() As Boolean

        If rbYesImage.Checked = True Then
            If txtImageURL.Text = "" Then
                MsgBoxF()
                Return False
            End If
            txtExhibit.Text = "1"
        Else
            txtExhibit.Text = "0"
            txtImageURL.Text = ""
        End If

        Return True

    End Function
    Private Function ValidateFields() As Boolean
        Dim blnVal As Boolean = True
        If rbOneAnswer.Checked = False And rbMultiAnswer.Checked = False And _
                    rbAllNoneOfAbove.Checked = False And rbTrueFalse.Checked = False And _
                    rbUserInput.Checked = False Then
            MsgBoxG()
            blnVal = False
            Return blnVal 'will exit the sub
        End If

        'If user clicks "Finished" and no check boxes are checked, 
        'there will be no answer - Ensure user selects a correct answer -
        If rbUserInput.Checked = False Then
            If chk1.CheckState = CheckState.Unchecked And chk2.CheckState = CheckState.Unchecked And _
            chk3.CheckState = CheckState.Unchecked And chk4.CheckState = CheckState.Unchecked And _
            chk5.CheckState = CheckState.Unchecked And chk6.CheckState = CheckState.Unchecked And _
            chk7.CheckState = CheckState.Unchecked Then
                MsgBoxH()
                blnVal = False
            End If
        End If
        Return blnVal
    End Function
    Friend Sub AddNewQID()
        Dim pLast As Integer, pNew As Integer
        Try
            pLast = Me.DsExam1.Q1.Rows.Count - 1
            If pLast > -1 Then
                pNew = ToInt32(Me.DsExam1.Q1.Rows(pLast).Item("QID"))
                pNew += 1
                txtQID.Text = pNew.ToString
            Else
                Exit Sub
            End If
            rbOneAnswer.Checked = True
            rbHidden.Checked = True
        Catch
            txtQID.Text = "2001"
        End Try
        mblnDirty = True
    End Sub
    Friend Sub BeginSetChecked()
        Select Case txtChkOrOpt.Text
            Case "o"
                Call SetTextBoxesVisible(True)
                ShowCheckBoxes()
                rbOneAnswer.Checked = True
                Exit Sub
            Case "c"
                Call SetTextBoxesVisible(True)
                ShowCheckBoxes()
                rbMultiAnswer.Checked = True
                Exit Sub
            Case "tf"
                Call SetTextBoxesVisible(True)
                ShowCheckBoxes()
                rbTrueFalse.Checked = True
                Exit Sub
            Case "ab"
                Call SetTextBoxesVisible(True)
                ShowCheckBoxes()
                rbAllNoneOfAbove.Checked = True
                Exit Sub
            Case "i"
                Call SetTextBoxesVisible(False)
                rbUserInput.Checked = True
                'txtAnsA.Text = ""
                'txtAnsB.Text = ""
                'txtAnsC.Text = ""
                'txtAnsD.Text = ""
                'txtAnsE.Text = ""
                'txtAnsF.Text = ""
                'txtAnsG.Text = ""
        End Select
    End Sub
    Friend Sub CheckExhibitType()
        If txtExhibit.Text = "1" Then
            rbYesImage.Checked = True
        End If
        If txtExhibit.Text = "0" Then
            rbNoImage.Checked = True
        End If
    End Sub
    Friend Sub RefreshCombos()
        cboQID.Items.Clear()
        odbDaExam.Fill(DsExam1)
        AddQuestionsToCombo()
    End Sub
    Friend Sub SaveDatabaseFile()
        Dim pintRecords As Integer = Me.DsExam1.Q1.Rows.Count - 1
        Dim RowNum As Integer

        For RowNum = 0 To pintRecords
            If Me.DsExam1.Q1.Rows(RowNum).Item("chkoropt").ToString = "" Then
                mIDNum = Me.DsExam1.Q1.Rows(RowNum).Item("QID").ToString
                MsgBoxI()
                Exit Sub
            End If
        Next
        For RowNum = 0 To pintRecords
            If Me.DsExam1.Q1.Rows(RowNum).Item("Exhibit").ToString = "1" Then
                If Me.DsExam1.Q1.Rows(RowNum).Item("ExhibitName").ToString = "" Then
                    mIDNum = Me.DsExam1.Q1.Rows(RowNum).Item("QID").ToString
                    MsgBoxJ()
                    Exit Sub
                End If
                If Me.DsExam1.Q1.Rows(RowNum).Item("ExhibitName").ToString.IndexOf(".") = -1 Then
                    mIDNum = Me.DsExam1.Q1.Rows(RowNum).Item("QID").ToString
                    MsgBoxK()
                    Exit Sub
                End If
            End If
        Next
        CopyTempFileToSaved()
    End Sub
    Friend Sub UncheckAllRadios()
        rbOneAnswer.Checked = False
        rbMultiAnswer.Checked = False
        rbTrueFalse.Checked = False
        rbUserInput.Checked = False
        rbAllNoneOfAbove.Checked = False
        rbHidden.Checked = True 'unchcecks all radios
    End Sub
    Sub AddAnswersToAnswer()
        If txtChkOrOpt.Text = "i" Or rbUserInput.Checked = True Then
            txtAnswer.Text &= txtInputAnswer.Text & " "
        Else
            If chk1.Checked = True Then txtAnswer.Text &= txtAnsA.Text & " "
            If chk2.Checked = True Then txtAnswer.Text &= txtAnsB.Text & " "
            If chk3.Checked = True Then txtAnswer.Text &= txtAnsC.Text & " "
            If chk4.Checked = True Then txtAnswer.Text &= txtAnsD.Text & " "
            If chk5.Checked = True Then txtAnswer.Text &= txtAnsE.Text & " "
            If chk6.Checked = True Then txtAnswer.Text &= txtAnsF.Text & " "
            If chk7.Checked = True Then txtAnswer.Text &= txtAnsG.Text & " "
        End If
    End Sub
    Sub AddQuestionsToCombo()
        Dim count As Integer
        For count = 0 To Me.DsExam1.Q1.Rows.Count - 1
            cboQID.Items.Add(Me.DsExam1.Q1.Rows(count).Item("QID"))
        Next
    End Sub
    Sub AllOfAboveCheck()
        If rbAllNoneOfAbove.Checked = True Then
            txtChkOrOpt.Text = "ab"
            Me.BeginSetChecked()
        End If
    End Sub
    Sub AddNewQuestion()
        Dim intsum As Integer
        If btnAdd.Text = "&Add Question" Then 'ADD QUESTION
            cblnIsEditing = True
            btnAdd.Text = "Fi&nished"
        Else 'FINISHED
            If ValidateFields() = False Then Exit Sub
            cblnIsEditing = False
        End If

        If cblnIsEditing = True Then 'ADD QUESTION
            EditAdd()
            SetBackground(Color.White)
            SetTxtTextZero()    'Set Answer boxes to 0 instead of blank
        Else 'FINISHED
            GetAllCheckStates()
            intsum = GetCheckSum()
            If txtChkOrOpt.Text = "c" Then
                If intsum < 2 Then
                    MsgBoxC()
                    cblnIsEditing = True
                    Exit Sub
                End If
                'ElseIf txtChkOrOpt.Text = "i" Then
                '    If intsum > 0 Then
                '        MsgBoxE()
                '        cblnIsEditing = True 'mc??
                '        Exit Sub
                '    End If
            Else
                If intsum > 1 Then
                    MsgBoxD()
                    cblnIsEditing = True 'snesbitt
                    Exit Sub
                End If
            End If
            btnAdd.Text = "&Add Question"
            UncheckCheckboxes()
            SetBackground(Color.LightGray)
            EditUpdate()
        End If

        ShowCheckBoxes()
        EnableDisableButtons()
        btnChangeAnswer.Enabled = Not (cblnIsEditing)

    End Sub
    Sub CancelEditing()
        EditCancel()
        btnAdd.Text = "&Add Question"
        btnChangeAnswer.Text = "C&hange"
        cblnIsEditing = False
        btnAdd.Enabled = True
        btnChangeAnswer.Enabled = True
        EnableDisableButtons()
        UncheckCheckboxes()
        SetBackground(Color.LightGray)
        ShowCheckBoxes()
    End Sub
    Sub ChangeAnswer()
        Dim intsum As Integer
        If btnChangeAnswer.Text = "C&hange" Then 'CHANGE ANSWER
            cblnIsEditing = True
            btnChangeAnswer.Text = "Fi&nished"
        Else 'FINISHED
            If ValidateFields() = False Then Exit Sub
            cblnIsEditing = False
        End If

        If cblnIsEditing = True Then 'CHANGE ANSWER
            SetBackground(Color.White)
            CheckTheBoxes() 'Check the boxes to show correct answers
        Else 'FINISHED CLICKED
            GetAllCheckStates()
            intsum = GetCheckSum()
            If txtChkOrOpt.Text = "c" Then
                If intsum < 2 Then
                    MsgBoxC()
                    cblnIsEditing = True 'mc??
                    Exit Sub
                End If
                'ElseIf txtChkOrOpt.Text = "i" Then
                '    If intsum > 0 Then
                'MsgBoxE() 'You cannot have correct answers for an input answer.
                '        cblnIsEditing = True 'mc??
                '        Exit Sub
                '    End If
            Else
                If intsum > 1 Then
                    MsgBoxD()
                    cblnIsEditing = True 'snesbitt
                    Exit Sub
                End If
            End If
            btnChangeAnswer.Text = "C&hange"
            UncheckCheckboxes()
            SetBackground(Color.LightGray)
            EditUpdate()
        End If
        ShowCheckBoxes()
        EnableDisableButtons()
        btnAdd.Enabled = Not (cblnIsEditing)
    End Sub
    Sub ChangeSelectedPosition()
        Me.BindingContext(DsExam1, "Q1").Position = cboQID.SelectedIndex
        fParent.pnlCurrentRecord.Text = "Current = " & Me.BindingContext(DsExam1, "Q1").Position + 1
    End Sub
    Sub CheckTheBoxes()
        If txtA.Text = "1" Then chk1.CheckState = CheckState.Checked
        If txtB.Text = "1" Then chk2.CheckState = CheckState.Checked
        If txtC.Text = "1" Then chk3.CheckState = CheckState.Checked
        If txtD.Text = "1" Then chk4.CheckState = CheckState.Checked
        If txtE.Text = "1" Then chk5.CheckState = CheckState.Checked
        If txtF.Text = "1" Then chk6.CheckState = CheckState.Checked
        If txtG.Text = "1" Then chk7.CheckState = CheckState.Checked
    End Sub
    Sub CloseForm()
        Dim pmsg As DialogResult
        If mblnDirty = True Then
            pmsg = MessageBox.Show("Save Changes?", "Confirm changes", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Question)
            If pmsg = DialogResult.Yes Then
                If rbYesImage.Checked = True Then
                    txtExhibit.Text = "1"
                Else
                    txtExhibit.Text = "0"
                    txtImageURL.Text = ""
                End If

                Call EditUpdate()
                Call SaveDatabaseFile()
            End If
        End If

        odbConExam.Close()
        fParent.pnlCurrentRecord.Text = ""
        fParent.pnlRecordCount.Text = ""
    End Sub
    Sub CopyTempFileToSaved()
        'IF THE FILE EXISTS DELETE IT AND COPY WORKING TO SAVED
        ' CHECK IF C:\QUEENEDIT  \MYEXAM\  EXAMS\ICON2   \  DB002.MDB
        'WHEN COPIED NAME IT WITH THE FCURRENTMODULEDB WHICH IS DB002.MDB ETC
        If File.Exists(fFULLMODULEPATH & fCurrentModuleDB) Then
            File.Delete(fFULLMODULEPATH & fCurrentModuleDB)
            CopyWorkingToSaved()
        Else : CopyWorkingToSaved()
        End If
    End Sub
    Sub CopyWorkingToSaved()
        File.Copy(dbTempPath, fFULLMODULEPATH & fCurrentModuleDB)
    End Sub
    Sub RepairExamDatabase()
        If File.Exists(dbTempPath) Then
            File.Delete(dbTempPath)
        End If
        File.Copy(dbBackupPath, dbTempPath)
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
    '    btnClose.Enabled = False
    '    btnSave.Enabled = False
    '    btnUpdate.Enabled = False
    '    btnPreview.Enabled = False
    '    cboQID.Enabled = False
    '    btnChangeAnswer.Enabled = False
    '    btnAdd.Enabled = False
    '    gbType.Enabled = cblnIsEditing
    '    txtQues.Enabled = cblnIsEditing
    '    txtAnsA.Enabled = cblnIsEditing
    '    txtAnsB.Enabled = cblnIsEditing
    '    txtAnsC.Enabled = cblnIsEditing
    '    txtAnsD.Enabled = cblnIsEditing
    '    txtAnsE.Enabled = cblnIsEditing
    '    txtAnsF.Enabled = cblnIsEditing
    '    txtAnsG.Enabled = cblnIsEditing
    '    txtAnswer.Enabled = cblnIsEditing
    '    txtExplanation.Enabled = cblnIsEditing
    '    gbExhibit.Enabled = cblnIsEditing
    '    txtInputAnswer.Enabled = cblnIsEditing
    '    txtInputAnswer2.Enabled = cblnIsEditing
    '    btnSend.Enabled = cblnIsEditing

    'End Sub
    Sub EnableDisableButtons()
        btnCancel.Enabled = cblnIsEditing
        btnDelete.Enabled = Not (cblnIsEditing)
        btnClose.Enabled = Not (cblnIsEditing)
        btnFirst.Enabled = Not (cblnIsEditing)
        btnNext.Enabled = Not (cblnIsEditing)
        btnPrevious.Enabled = Not (cblnIsEditing)
        btnLast.Enabled = Not (cblnIsEditing)
        btnClose.Enabled = Not (cblnIsEditing)
        btnSave.Enabled = Not (cblnIsEditing)
        btnPreview.Enabled = Not (cblnIsEditing)
        cboQID.Enabled = Not (cblnIsEditing)

        gbType.Enabled = cblnIsEditing
        txtQues.Enabled = cblnIsEditing
        txtAnsA.Enabled = cblnIsEditing
        txtAnsB.Enabled = cblnIsEditing
        txtAnsC.Enabled = cblnIsEditing
        txtAnsD.Enabled = cblnIsEditing
        txtAnsE.Enabled = cblnIsEditing
        txtAnsF.Enabled = cblnIsEditing
        txtAnsG.Enabled = cblnIsEditing
        txtAnswer.Enabled = cblnIsEditing
        txtExplanation.Enabled = cblnIsEditing
        gbExhibit.Enabled = cblnIsEditing
        txtInputAnswer.Enabled = cblnIsEditing
        txtInputAnswer2.Enabled = cblnIsEditing
        btnSend.Enabled = cblnIsEditing
    End Sub
    Sub ExhibitChanged()
        If txtExhibit.Text = "1" Then SetExhibitControls(True)
        If txtExhibit.Text = "" Or txtExhibit.Text = "0" Then SetExhibitControls(False)
        LoadExhibit(fFULLMODULEPATH & txtImageURL.Text)
    End Sub
    Sub ExpandExplanationBox()
        Dim currentSize As Size = New Size(510, 75)
        Dim currentLocation As Point = New Point(100, 430)
        Dim lgSize As Size = New Size(510, 360)
        Dim lgLocation As Point = New Point(100, 145)

        If txtExplanation.Size.Equals(currentSize) Then
            txtExplanation.Size = lgSize
            txtExplanation.Location = lgLocation
            btnExpandE.BackColor = Color.Red
        Else
            txtExplanation.Size = currentSize
            txtExplanation.Location = currentLocation
            btnExpandE.BackColor = Color.LightSteelBlue
        End If
    End Sub
    Sub ExpandQuestionBox()
        Dim currentSize As Size = New Size(510, 75)
        Dim currentLocation As Point = New Point(100, 65)
        Dim lgSize As Size = New Size(510, 325)
        Dim lgLocation As Point = New Point(100, 65)

        If txtQues.Size.Equals(currentSize) Then
            txtQues.Size = lgSize
            txtQues.Location = lgLocation
            btnExpandQues.BackColor = Color.Red
        Else
            txtQues.Size = currentSize
            txtQues.Location = currentLocation
            btnExpandQues.BackColor = Color.LightSteelBlue
        End If
    End Sub
    Sub FillAndBindDataSet()
        Try
            odbDaExam.Fill(DsExam1)
        Catch
            Dim pmsg As MsgBoxResult = MsgBoxL()
            If pmsg = MsgBoxResult.OK Then
                RepairExamDatabase()
                odbDaExam.Fill(DsExam1)
            Else
                mblnDirty = False
                Try
                    Me.Close()
                Catch
                    tmrTimer.Enabled = True 'to close form
                    Exit Sub
                End Try
            End If
        End Try
        BindData(txtChkOrOpt, "Q1.chkoropt")
        BindData(txtQID, "Q1.QID")
        BindData(lblchkoropt, "Q1.chkoropt")
        BindData(txtQues, "Q1.Ques")
        BindData(txtAnsA, "Q1.AnsA")
        BindData(txtAnsB, "Q1.AnsB")
        BindData(txtAnsC, "Q1.AnsC")
        BindData(txtAnsD, "Q1.AnsD")
        BindData(txtAnsE, "Q1.AnsE")
        BindData(txtAnsF, "Q1.AnsF")
        BindData(txtAnsG, "Q1.AnsG")
        BindData(txtExplanation, "Q1.Explanation")
        BindData(txtInputAnswer, "Q1.InputAnswer")
        BindData(txtInputAnswer2, "Q1.InputAnswer2")
        BindData(txtAnswer, "Q1.Answer")
        BindData(txtExhibit, "Q1.Exhibit")
        BindData(txtImageURL, "Q1.ExhibitName")
        BindData(txtA, "Q1.Ans1")
        BindData(txtB, "Q1.Ans2")
        BindData(txtC, "Q1.Ans3")
        BindData(txtD, "Q1.Ans4")
        BindData(txtE, "Q1.Ans5")
        BindData(txtF, "Q1.Ans6")
        BindData(txtG, "Q1.Ans7")
    End Sub
    Sub GetAllCheckStates()
        txtA.Text = GetCheckState(chk1)
        txtB.Text = GetCheckState(chk2)
        txtC.Text = GetCheckState(chk3)
        txtD.Text = GetCheckState(chk4)
        txtE.Text = GetCheckState(chk5)
        txtF.Text = GetCheckState(chk6)
        txtG.Text = GetCheckState(chk7)
    End Sub
    Sub HideCheckBoxes(ByVal pbl As Boolean)
        UncheckCheckboxes()

        chk1.Visible = Not (pbl)
        chk2.Visible = Not (pbl)
        chk3.Visible = Not (pbl)
        chk4.Visible = Not (pbl)
        chk5.Visible = Not (pbl)
        chk6.Visible = Not (pbl)
        chk7.Visible = Not (pbl)
    End Sub
    Sub HidePicImages(ByVal pbl As Boolean)
        Dim imgHidden As Point = New Point(10, 25) 'Hidden
        Dim imgShown1 As Point = New Point(30, 150) 'The 7 Points
        Dim imgShown2 As Point = New Point(30, 185) 'left aligned
        Dim imgShown3 As Point = New Point(30, 220)
        Dim imgShown4 As Point = New Point(30, 255)
        Dim imgShown5 As Point = New Point(30, 290)
        Dim imgShown6 As Point = New Point(30, 325)
        Dim imgShown7 As Point = New Point(30, 360)

        Select Case pbl
            Case True 'if hidden
                picCheck1.Location = imgHidden
                picCheck2.Location = imgHidden
                picCheck3.Location = imgHidden
                picCheck4.Location = imgHidden
                picCheck5.Location = imgHidden
                picCheck6.Location = imgHidden
                picCheck7.Location = imgHidden
                picX1.Location = imgHidden
                picX2.Location = imgHidden
                picX3.Location = imgHidden
                picX4.Location = imgHidden
                picX5.Location = imgHidden
                picX6.Location = imgHidden
                picX7.Location = imgHidden
            Case False 'if not hidden
                picCheck1.Location = imgShown1
                picCheck2.Location = imgShown2
                picCheck3.Location = imgShown3
                picCheck4.Location = imgShown4
                picCheck5.Location = imgShown5
                picCheck6.Location = imgShown6
                picCheck7.Location = imgShown7
                picX1.Location = imgShown1
                picX2.Location = imgShown2
                picX3.Location = imgShown3
                picX4.Location = imgShown4
                picX5.Location = imgShown5
                picX6.Location = imgShown6
                picX7.Location = imgShown7

        End Select
    End Sub
    Sub HighlightBox(ByVal txtBox As TextBox, ByVal txtBox2 As TextBox, ByVal picC As PictureBox, ByVal picX As PictureBox)
        If txtBox.Text = "1" Then
            txtBox2.BackColor = Color.Lavender
            picC.Visible = True
            picX.Visible = False
        Else
            txtBox2.BackColor = Color.White
            picC.Visible = False
            picX.Visible = True
        End If
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
    Sub MultiAnswerCheck()
        If rbMultiAnswer.Checked = True Then
            txtChkOrOpt.Text = "c"
            Me.BeginSetChecked()
        End If
    End Sub
    Sub NoImageCheck()
        If rbNoImage.Checked = True Then
            btnChooseImage.Enabled = False
            btnViewImage.Enabled = False
            picExhibit.Enabled = False
            picExhibit.Image = Nothing
            txtExhibit.Text = "0"
            txtImageURL.Text = ""
        End If
    End Sub
    Sub OneAnswerCheck()
        If rbOneAnswer.Checked = True Then
            txtChkOrOpt.Text = "o"
            Me.BeginSetChecked()
        End If
    End Sub
    Sub OpenTestQExe()
        Call Navigate(fPARENTPATH & "testq.exe")
    End Sub
    Sub PreviewExam()
        If mblnDirty = True Then MsgBoxB() '? prompt to save
        Dim Count As Integer = Me.DsExam1.Q1.Rows.Count
        Select Case Count
            Case Is < 5
                MsgBoxAA()
                Exit Sub
            Case Is >= fintMaxQuestions
                OpenTestQExe()
            Case Else
                MsgBoxA()
        End Select
    End Sub
    Sub SaveFileAndUpdate()
        If ImageUrlOK() = True Then
            Call EditUpdate()
            Call SaveDatabaseFile()
            mblnDirty = False
        End If
    End Sub
    Sub SetBackground(ByVal clrCol As Color)
        txtA.BackColor = clrCol
        txtB.BackColor = clrCol
        txtC.BackColor = clrCol
        txtD.BackColor = clrCol
        txtE.BackColor = clrCol
        txtF.BackColor = clrCol
        txtG.BackColor = clrCol
    End Sub
    Sub SetExhibitControls(ByVal pBool As Boolean)
        rbYesImage.Checked = pBool
        rbNoImage.Checked = Not (pBool)
        btnChooseImage.Enabled = pBool
        btnViewImage.Enabled = pBool
    End Sub
    Sub SetTextBoxesVisible(ByVal pEdit As Boolean)
        Dim x As Integer = 100 '*Left value
        If pEdit = True Then
            txtAnsA.Location = New Point(x, 145)
            txtAnsB.Location = New Point(x, 180)
            txtAnsC.Location = New Point(x, 215)
            txtAnsD.Location = New Point(x, 250)
            txtAnsE.Location = New Point(x, 285)
            txtAnsF.Location = New Point(x, 320)
            txtAnsG.Location = New Point(x, 355)
        End If
        If pEdit = False Then 'hide textboxes to show input answer
            txtAnsA.Location = New Point(x, 65)
            txtAnsB.Location = New Point(x, 65)
            txtAnsC.Location = New Point(x, 65)
            txtAnsD.Location = New Point(x, 65)
            txtAnsE.Location = New Point(x, 65)
            txtAnsF.Location = New Point(x, 65)
            txtAnsG.Location = New Point(x, 65)
        End If
    End Sub
    Sub SetFormNumber()
        fintCURRENTFORM = 1
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
    Sub SetTxtTextZero()
        txtA.Text = "0"
        txtB.Text = "0"
        txtC.Text = "0"
        txtD.Text = "0"
        txtE.Text = "0"
        txtF.Text = "0"
        txtG.Text = "0"
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
    Sub ShowCheckBoxes()
        'just added if cblnEditing true
        If rbUserInput.Checked = False Then
            chk1.Visible = cblnIsEditing
            chk2.Visible = cblnIsEditing
            chk3.Visible = cblnIsEditing
            chk4.Visible = cblnIsEditing
            chk5.Visible = cblnIsEditing
            chk6.Visible = cblnIsEditing
            chk7.Visible = cblnIsEditing
        End If
    End Sub
    Sub ShowHideBox()
        If cIsHidden = True Then
            SetTextBoxesVisible(True)
            cIsHidden = False
            btnShowHide.BackColor = Color.Red
        Else
            SetTextBoxesVisible(False)
            cIsHidden = True
            btnShowHide.BackColor = Color.LightSteelBlue
        End If
    End Sub
    Sub TrueFalseCheck()
        If rbTrueFalse.Checked = True Then
            txtChkOrOpt.Text = "tf"
            Me.BeginSetChecked()

            If txtAnsA.Text = "" Then
                txtAnsA.Text = "True" 'because true false can also be another two choice answer
                txtAnsB.Text = "False"
                txtAnsC.Text = ""
                txtAnsD.Text = ""
                txtAnsE.Text = ""
                txtAnsF.Text = ""
                txtAnsG.Text = ""
            End If
            'if cbln isediting then  show checkboxes
        End If
    End Sub
    Sub UncheckCheckboxes()
        chk1.CheckState = CheckState.Unchecked
        chk2.CheckState = CheckState.Unchecked
        chk3.CheckState = CheckState.Unchecked
        chk4.CheckState = CheckState.Unchecked
        chk5.CheckState = CheckState.Unchecked
        chk6.CheckState = CheckState.Unchecked
        chk7.CheckState = CheckState.Unchecked
    End Sub
    
    Sub UserInputCheck()
        'Dim ans1 As String = txtInputAnswer.Text
        'Dim ans2 As String = txtInputAnswer2.Text
        If rbUserInput.Checked = True Then
            txtChkOrOpt.Text = "i"
            Me.BeginSetChecked()
            HideCheckBoxes(True)
            HidePicImages(True)
        Else
            HidePicImages(False)
        End If
    End Sub
    Sub YesImageCheck()
        If rbYesImage.Checked = True Then
            btnChooseImage.Enabled = True
            btnViewImage.Enabled = True
            picExhibit.Enabled = True
            txtExhibit.Text = "1"
        End If
    End Sub


#Region "Form Controls"
    Private Sub frmEditExam_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.SetFormNumber()

    End Sub
    Private Sub frmEditExam_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        Me.SetFormNumber()
        SetPanelBarText("" & DsExam1.Q1.Rows.Count, "" & Me.BindingContext(DsExam1, "Q1").Position + 1)


    End Sub
    Private Sub frmEditExam_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SetFormNumber()
        Me.SetTitle()
        Me.FillAndBindDataSet()
        Me.AddQuestionsToCombo()
        Me.BeginSetChecked()
        Me.EnableDisableButtons()
    End Sub
    Private Sub frmEditExam_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        CloseForm()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        CancelEditing()
    End Sub
    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        AddAnswersToAnswer()
    End Sub
    Private Sub btnShowHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowHide.Click
        ShowHideBox()
    End Sub
    Private Sub btnExpandE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpandE.Click
        ExpandExplanationBox()
    End Sub
    Private Sub btnChooseImage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChooseImage.Click
        SetAndOpenFileDialog()
    End Sub
    Private Sub btnViewImage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnViewImage.Click
        SetImageForm()
    End Sub
    Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        PreviewExam()
    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveFileAndUpdate()
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub btnChangeAnswer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChangeAnswer.Click
        ChangeAnswer()
    End Sub
    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        Call NavigateFirst()
    End Sub
    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Call NavigateLast()
    End Sub
    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Call NavigatePrevious()
    End Sub
    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Call NavigateNext()
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        AddNewQuestion()
    End Sub
    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Call EditDelete()
    End Sub
    Private Sub cboQID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboQID.SelectedIndexChanged
        ChangeSelectedPosition()
    End Sub
    Private Sub ofdOpenFile_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ofdOpenFile.FileOk
        SetUpImageFile()
    End Sub
    Private Sub rbNoImage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoImage.CheckedChanged
        NoImageCheck()
    End Sub
    Private Sub rbOneAnswer_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbOneAnswer.CheckedChanged
        OneAnswerCheck()
    End Sub
    Private Sub rbMultiAnswer_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbMultiAnswer.CheckedChanged
        MultiAnswerCheck()
    End Sub
    Private Sub rbAllNoneOfAbove_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbAllNoneOfAbove.CheckedChanged
        AllOfAboveCheck()
    End Sub
    Private Sub rbTrueFalse_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbTrueFalse.CheckedChanged
        TrueFalseCheck()
    End Sub
    Private Sub rbUserInput_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbUserInput.CheckedChanged
        UserInputCheck()
    End Sub
    Private Sub rbYesImage_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbYesImage.CheckedChanged
        YesImageCheck()
    End Sub
    'DO NOT PUT TEXTBOXES IN A GROUPBOX, TEXTCHANGED WILL NOT WORK
    Private Sub txtExhibit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtExhibit.TextChanged
        ExhibitChanged()
    End Sub
    Private Sub txtImageURL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImageURL.TextChanged
        ImageURLChanged()
    End Sub
    Private Sub txtA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtA.TextChanged
        HighlightBox(txtA, txtAnsA, picCheck1, picX1)
    End Sub
    Private Sub txtB_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtB.TextChanged
        HighlightBox(txtB, txtAnsB, picCheck2, picX2)
    End Sub
    Private Sub txtC_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtC.TextChanged
        HighlightBox(txtC, txtAnsC, picCheck3, picX3)
    End Sub
    Private Sub txtD_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtD.TextChanged
        HighlightBox(txtD, txtAnsD, picCheck4, picX4)
    End Sub
    Private Sub txtE_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtE.TextChanged
        HighlightBox(txtE, txtAnsE, picCheck5, picX5)
    End Sub
    Private Sub txtF_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtF.TextChanged
        HighlightBox(txtF, txtAnsF, picCheck6, picX6)
    End Sub
    Private Sub txtG_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtG.TextChanged
        HighlightBox(txtG, txtAnsG, picCheck7, picX7)
    End Sub
    Private Sub txtChkOrOpt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtChkOrOpt.TextChanged
        Me.BeginSetChecked()
    End Sub

    Private Sub btnExpandQues_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpandQues.Click
        ExpandQuestionBox()
    End Sub
#End Region

    Private Sub tmrTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrTimer.Tick
        Me.Close()
    End Sub
End Class

