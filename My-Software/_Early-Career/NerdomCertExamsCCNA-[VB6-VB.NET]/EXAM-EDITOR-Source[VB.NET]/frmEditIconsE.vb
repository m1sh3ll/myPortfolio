Option Strict On
Option Explicit On 

Imports System.IO
Imports System.Convert
Imports Microsoft.VisualBasic.ControlChars

Public Class frmEditIconsE
    Inherits System.Windows.Forms.Form
    Private mblnDirty As Boolean = True
    Private cblnIsEditing As Boolean
    Private isBuilding As String
    Private SP As String = Application.StartupPath & "\"
    Private dbTempPath As String = Application.StartupPath & "\dbicnse.mdb"
    Private dbBackupPath As String = Application.StartupPath & "\backup\dbicnse.mdb"
    Private minstallFile As String = Application.StartupPath & "\" & "installit.dat" '?
    Private mbackupFolder As String = Application.StartupPath & "\backup" & "\"
    Private dbIconsTempPath As String = Application.StartupPath & "\dbicnse.mdb"
    Private dbExamTempPath As String = Application.StartupPath & "\dbexam.mdb"
    Private dbFlashTempPath As String = Application.StartupPath & "\dbflashcards.mdb"
    Private dbLabsTempPath As String = Application.StartupPath & "\dblabs.mdb"
    Private dbExamBackup As String = Application.StartupPath & "\backup\dbexam.mdb"
    Private dbFlashBackup As String = Application.StartupPath & "\backup\dbflashcards.mdb"
    Private dbLabsBackup As String = Application.StartupPath & "\backup\dblabs.mdb"

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.MdiParent = fParent
        Me.odbConIconsE.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;" & _
                          "Data Source=" & dbIconsTempPath & ";" & "Mode=Share Deny None" & _
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
    Friend WithEvents txtMaxLbox As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnExam1 As System.Windows.Forms.Button
    Friend WithEvents btnExam2 As System.Windows.Forms.Button
    Friend WithEvents btnExam3 As System.Windows.Forms.Button
    Friend WithEvents btnExam4 As System.Windows.Forms.Button
    Friend WithEvents btnExam5 As System.Windows.Forms.Button
    Friend WithEvents btnAll As System.Windows.Forms.Button
    Friend WithEvents txtButton1 As System.Windows.Forms.TextBox
    Friend WithEvents txtButton2 As System.Windows.Forms.TextBox
    Friend WithEvents txtButton3 As System.Windows.Forms.TextBox
    Friend WithEvents txtButton4 As System.Windows.Forms.TextBox
    Friend WithEvents txtButton5 As System.Windows.Forms.TextBox
    Friend WithEvents txtbtnAll As System.Windows.Forms.TextBox
    Friend WithEvents gbType As System.Windows.Forms.GroupBox
    Friend WithEvents rbExam As System.Windows.Forms.RadioButton
    Friend WithEvents rbLab As System.Windows.Forms.RadioButton
    Friend WithEvents rbFlashCards As System.Windows.Forms.RadioButton
    Friend WithEvents txtMTYPE As System.Windows.Forms.TextBox
    Friend WithEvents lblPromptCurrentFormat As System.Windows.Forms.Label
    Friend WithEvents mmuMain As System.Windows.Forms.MainMenu
    Friend WithEvents mmuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mmuFileExit As System.Windows.Forms.MenuItem
    Friend WithEvents odbConIconsE As System.Data.OleDb.OleDbConnection
    Friend WithEvents odbDaIconsE As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsIconsE1 As QUEENEDIT2004.dsIconsE
    Friend WithEvents lblIcon As System.Windows.Forms.Label
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents txtParentFolder As System.Windows.Forms.TextBox
    Friend WithEvents picIcon As System.Windows.Forms.PictureBox
    Friend WithEvents txtICTITLE2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubFolder1 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubFolder2 As System.Windows.Forms.TextBox
    Friend WithEvents txtICTITLE As System.Windows.Forms.TextBox
    Friend WithEvents txtExamName As System.Windows.Forms.TextBox
    Friend WithEvents txtIconMouse As System.Windows.Forms.TextBox
    Friend WithEvents txtfldSubFolder As System.Windows.Forms.TextBox
    Friend WithEvents cboMaxQuestions As System.Windows.Forms.ComboBox
    Friend WithEvents mmuFileSave As System.Windows.Forms.MenuItem
    Friend WithEvents lblPromptMaxQues As System.Windows.Forms.Label
    Friend WithEvents mmuBuild As System.Windows.Forms.MenuItem
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents gbIconPreview As System.Windows.Forms.GroupBox
    Friend WithEvents lblTopFolder As System.Windows.Forms.Label
    Friend WithEvents lblMiddleFolder As System.Windows.Forms.Label
    Friend WithEvents lblBottomFolder As System.Windows.Forms.Label
    Friend WithEvents lblPromptModuleDesc As System.Windows.Forms.Label
    Friend WithEvents lblPromptCollectionName As System.Windows.Forms.Label
    Friend WithEvents lblPromptModuleName As System.Windows.Forms.Label
    Friend WithEvents lblPromptModuleTopics As System.Windows.Forms.Label
    Friend WithEvents lblPromptModuleEditor As System.Windows.Forms.Label
    Friend WithEvents lblPromptCollectionFileLocation As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents LinkLabel12 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel11 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel10 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel9 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel8 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel7 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel6 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblIDNumber As System.Windows.Forms.Label
    Friend WithEvents pnlModuleList As System.Windows.Forms.Panel
    Friend WithEvents btn3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEditIconsE))
        Me.txtMaxLbox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtbtnAll = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.lblPromptModuleDesc = New System.Windows.Forms.Label()
        Me.lblPromptCollectionName = New System.Windows.Forms.Label()
        Me.lblPromptModuleName = New System.Windows.Forms.Label()
        Me.lblPromptModuleTopics = New System.Windows.Forms.Label()
        Me.lblPromptModuleEditor = New System.Windows.Forms.Label()
        Me.lblPromptCollectionFileLocation = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIDNumber = New System.Windows.Forms.Label()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.lblPromptMaxQues = New System.Windows.Forms.Label()
        Me.gbIconPreview = New System.Windows.Forms.GroupBox()
        Me.txtICTITLE2 = New System.Windows.Forms.TextBox()
        Me.btnExam1 = New System.Windows.Forms.Button()
        Me.btnExam2 = New System.Windows.Forms.Button()
        Me.btnExam3 = New System.Windows.Forms.Button()
        Me.btnExam4 = New System.Windows.Forms.Button()
        Me.btnExam5 = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.txtButton2 = New System.Windows.Forms.TextBox()
        Me.txtButton3 = New System.Windows.Forms.TextBox()
        Me.txtExamName = New System.Windows.Forms.TextBox()
        Me.txtIconMouse = New System.Windows.Forms.TextBox()
        Me.txtButton1 = New System.Windows.Forms.TextBox()
        Me.txtICTITLE = New System.Windows.Forms.TextBox()
        Me.txtButton4 = New System.Windows.Forms.TextBox()
        Me.txtButton5 = New System.Windows.Forms.TextBox()
        Me.gbType = New System.Windows.Forms.GroupBox()
        Me.rbLab = New System.Windows.Forms.RadioButton()
        Me.rbExam = New System.Windows.Forms.RadioButton()
        Me.rbFlashCards = New System.Windows.Forms.RadioButton()
        Me.lblPromptCurrentFormat = New System.Windows.Forms.Label()
        Me.txtMTYPE = New System.Windows.Forms.TextBox()
        Me.mmuMain = New System.Windows.Forms.MainMenu()
        Me.mmuFile = New System.Windows.Forms.MenuItem()
        Me.mmuBuild = New System.Windows.Forms.MenuItem()
        Me.mmuFileSave = New System.Windows.Forms.MenuItem()
        Me.mmuFileExit = New System.Windows.Forms.MenuItem()
        Me.odbConIconsE = New System.Data.OleDb.OleDbConnection()
        Me.odbDaIconsE = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.DsIconsE1 = New QUEENEDIT2004.dsIconsE()
        Me.lblIcon = New System.Windows.Forms.Label()
        Me.txtParentFolder = New System.Windows.Forms.TextBox()
        Me.txtSubFolder1 = New System.Windows.Forms.TextBox()
        Me.txtSubFolder2 = New System.Windows.Forms.TextBox()
        Me.txtfldSubFolder = New System.Windows.Forms.TextBox()
        Me.cboMaxQuestions = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTopFolder = New System.Windows.Forms.Label()
        Me.lblMiddleFolder = New System.Windows.Forms.Label()
        Me.lblBottomFolder = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.LinkLabel12 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel11 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel10 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel9 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.pnlModuleList = New System.Windows.Forms.Panel()
        Me.gbIconPreview.SuspendLayout()
        Me.gbType.SuspendLayout()
        CType(Me.DsIconsE1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlModuleList.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMaxLbox
        '
        Me.txtMaxLbox.BackColor = System.Drawing.Color.Red
        Me.txtMaxLbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaxLbox.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtMaxLbox.Location = New System.Drawing.Point(-10, 55)
        Me.txtMaxLbox.MaxLength = 4
        Me.txtMaxLbox.Name = "txtMaxLbox"
        Me.txtMaxLbox.Size = New System.Drawing.Size(105, 20)
        Me.txtMaxLbox.TabIndex = 0
        Me.txtMaxLbox.Text = ""
        Me.ToolTip1.SetToolTip(Me.txtMaxLbox, "Change to max number questions for each")
        '
        'txtbtnAll
        '
        Me.txtbtnAll.BackColor = System.Drawing.SystemColors.Window
        Me.txtbtnAll.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtbtnAll.ForeColor = System.Drawing.Color.Black
        Me.txtbtnAll.Location = New System.Drawing.Point(120, 265)
        Me.txtbtnAll.MaxLength = 150
        Me.txtbtnAll.Multiline = True
        Me.txtbtnAll.Name = "txtbtnAll"
        Me.txtbtnAll.Size = New System.Drawing.Size(360, 70)
        Me.txtbtnAll.TabIndex = 8
        Me.txtbtnAll.Text = "btnAll"
        Me.ToolTip1.SetToolTip(Me.txtbtnAll, "Routers, Switches and Commands")
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.Gainsboro
        Me.btn1.Enabled = False
        Me.btn1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(185, 340)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(65, 26)
        Me.btn1.TabIndex = 12
        Me.btn1.Text = "Exam &1"
        Me.ToolTip1.SetToolTip(Me.btn1, "Click to edit your exam - Exam 1")
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Gainsboro
        Me.btn2.Enabled = False
        Me.btn2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(250, 340)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(50, 26)
        Me.btn2.TabIndex = 13
        Me.btn2.Text = "&2"
        Me.ToolTip1.SetToolTip(Me.btn2, "Click to edit your exam - Exam 2")
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.Gainsboro
        Me.btn4.Enabled = False
        Me.btn4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(345, 340)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(45, 26)
        Me.btn4.TabIndex = 15
        Me.btn4.Text = "&4"
        Me.ToolTip1.SetToolTip(Me.btn4, "Click to edit your exam - Exam 4")
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.Gainsboro
        Me.btn5.Enabled = False
        Me.btn5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(390, 340)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(45, 26)
        Me.btn5.TabIndex = 16
        Me.btn5.Text = "&5"
        Me.ToolTip1.SetToolTip(Me.btn5, "Click to edit your exam - Exam 5")
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.Gainsboro
        Me.btn6.Enabled = False
        Me.btn6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(435, 340)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(45, 26)
        Me.btn6.TabIndex = 17
        Me.btn6.Text = "&All"
        Me.ToolTip1.SetToolTip(Me.btn6, "Click to edit your exam - Exam All")
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCreate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(490, 340)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(105, 25)
        Me.btnCreate.TabIndex = 18
        Me.btnCreate.Text = "&Create"
        Me.ToolTip1.SetToolTip(Me.btnCreate, "Click this button after filling in the information above for each icon module.")
        '
        'picIcon
        '
        Me.picIcon.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Bitmap)
        Me.picIcon.Location = New System.Drawing.Point(30, 15)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(40, 35)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIcon.TabIndex = 25
        Me.picIcon.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picIcon, "Preview of the module. Each module will have an icon to open it in the actual exa" & _
        "m.")
        '
        'lblPromptModuleDesc
        '
        Me.lblPromptModuleDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblPromptModuleDesc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptModuleDesc.ForeColor = System.Drawing.Color.Black
        Me.lblPromptModuleDesc.Location = New System.Drawing.Point(105, 130)
        Me.lblPromptModuleDesc.Name = "lblPromptModuleDesc"
        Me.lblPromptModuleDesc.Size = New System.Drawing.Size(85, 25)
        Me.lblPromptModuleDesc.TabIndex = 41
        Me.lblPromptModuleDesc.Text = "Description:"
        Me.lblPromptModuleDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lblPromptModuleDesc, "The description for this module (icon). When the user mouses over the icon, the d" & _
        "escription will appear. This will describe all 6 Exams.")
        '
        'lblPromptCollectionName
        '
        Me.lblPromptCollectionName.BackColor = System.Drawing.Color.Transparent
        Me.lblPromptCollectionName.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblPromptCollectionName.ForeColor = System.Drawing.Color.Black
        Me.lblPromptCollectionName.Location = New System.Drawing.Point(115, 30)
        Me.lblPromptCollectionName.Name = "lblPromptCollectionName"
        Me.lblPromptCollectionName.Size = New System.Drawing.Size(75, 25)
        Me.lblPromptCollectionName.TabIndex = 42
        Me.lblPromptCollectionName.Text = "Set Name:"
        Me.lblPromptCollectionName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lblPromptCollectionName, "This will be the title for all 12 modules. It will appear as a title for the whol" & _
        "e exam collection.")
        '
        'lblPromptModuleName
        '
        Me.lblPromptModuleName.BackColor = System.Drawing.Color.Transparent
        Me.lblPromptModuleName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptModuleName.ForeColor = System.Drawing.Color.Black
        Me.lblPromptModuleName.Location = New System.Drawing.Point(120, 55)
        Me.lblPromptModuleName.Name = "lblPromptModuleName"
        Me.lblPromptModuleName.Size = New System.Drawing.Size(70, 25)
        Me.lblPromptModuleName.TabIndex = 43
        Me.lblPromptModuleName.Text = "Icon Name:"
        Me.lblPromptModuleName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lblPromptModuleName, "You will have up to 12 icons (modules) for each Collection. This text will appear" & _
        " under each icon.")
        '
        'lblPromptModuleTopics
        '
        Me.lblPromptModuleTopics.BackColor = System.Drawing.Color.Transparent
        Me.lblPromptModuleTopics.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptModuleTopics.ForeColor = System.Drawing.Color.Black
        Me.lblPromptModuleTopics.Location = New System.Drawing.Point(125, 235)
        Me.lblPromptModuleTopics.Name = "lblPromptModuleTopics"
        Me.lblPromptModuleTopics.Size = New System.Drawing.Size(55, 25)
        Me.lblPromptModuleTopics.TabIndex = 44
        Me.lblPromptModuleTopics.Text = "Topics:"
        Me.lblPromptModuleTopics.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lblPromptModuleTopics, "When the user puts their mouse over each exam button, this description will displ" & _
        "ay. Click each button to change the text for the mouse overs.")
        '
        'lblPromptModuleEditor
        '
        Me.lblPromptModuleEditor.BackColor = System.Drawing.Color.Transparent
        Me.lblPromptModuleEditor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptModuleEditor.ForeColor = System.Drawing.Color.Black
        Me.lblPromptModuleEditor.Location = New System.Drawing.Point(135, 340)
        Me.lblPromptModuleEditor.Name = "lblPromptModuleEditor"
        Me.lblPromptModuleEditor.Size = New System.Drawing.Size(50, 20)
        Me.lblPromptModuleEditor.TabIndex = 14
        Me.lblPromptModuleEditor.Text = "Editor:"
        Me.lblPromptModuleEditor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lblPromptModuleEditor, "After filling in all the fields above, click to edit an exam by clicking the exam" & _
        " buttons below.")
        '
        'lblPromptCollectionFileLocation
        '
        Me.lblPromptCollectionFileLocation.AutoSize = True
        Me.lblPromptCollectionFileLocation.BackColor = System.Drawing.Color.Transparent
        Me.lblPromptCollectionFileLocation.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptCollectionFileLocation.Location = New System.Drawing.Point(495, 30)
        Me.lblPromptCollectionFileLocation.Name = "lblPromptCollectionFileLocation"
        Me.lblPromptCollectionFileLocation.Size = New System.Drawing.Size(96, 14)
        Me.lblPromptCollectionFileLocation.TabIndex = 46
        Me.lblPromptCollectionFileLocation.Text = "Folder Location:"
        Me.lblPromptCollectionFileLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.lblPromptCollectionFileLocation, "The parent folder name. A default of examset may be used and can only be changed " & _
        "if it is a new exam. One parent folder will hold the data files for all 6 exams " & _
        "in this module.")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(110, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Exam Type:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Label1, "Select Practice Exams, Flashcards or Lab")
        '
        'lblIDNumber
        '
        Me.lblIDNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblIDNumber.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDNumber.ForeColor = System.Drawing.Color.Black
        Me.lblIDNumber.Location = New System.Drawing.Point(5, 0)
        Me.lblIDNumber.Name = "lblIDNumber"
        Me.lblIDNumber.Size = New System.Drawing.Size(50, 50)
        Me.lblIDNumber.TabIndex = 36
        Me.lblIDNumber.Text = "Module:"
        Me.lblIDNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lblIDNumber, "The currently selected icon module.")
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.Gainsboro
        Me.btn3.Enabled = False
        Me.btn3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(300, 340)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(45, 26)
        Me.btn3.TabIndex = 14
        Me.btn3.Text = "&3"
        Me.ToolTip1.SetToolTip(Me.btn3, "Click to edit your exam - Exam 3")
        '
        'lblPromptMaxQues
        '
        Me.lblPromptMaxQues.BackColor = System.Drawing.Color.Transparent
        Me.lblPromptMaxQues.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptMaxQues.Location = New System.Drawing.Point(490, 165)
        Me.lblPromptMaxQues.Name = "lblPromptMaxQues"
        Me.lblPromptMaxQues.TabIndex = 30
        Me.lblPromptMaxQues.Text = "Max. Questions:"
        Me.lblPromptMaxQues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.lblPromptMaxQues, "The maximum allowed questions.")
        '
        'gbIconPreview
        '
        Me.gbIconPreview.BackColor = System.Drawing.Color.White
        Me.gbIconPreview.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtICTITLE2, Me.picIcon})
        Me.gbIconPreview.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gbIconPreview.Location = New System.Drawing.Point(490, 235)
        Me.gbIconPreview.Name = "gbIconPreview"
        Me.gbIconPreview.Size = New System.Drawing.Size(105, 100)
        Me.gbIconPreview.TabIndex = 11
        Me.gbIconPreview.TabStop = False
        Me.gbIconPreview.Text = "Icon Preview"
        Me.ToolTip1.SetToolTip(Me.gbIconPreview, "There is one icon per module. One icon is used to access one of the six exams.")
        '
        'txtICTITLE2
        '
        Me.txtICTITLE2.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtICTITLE2.BackColor = System.Drawing.Color.White
        Me.txtICTITLE2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtICTITLE2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtICTITLE2.Location = New System.Drawing.Point(15, 55)
        Me.txtICTITLE2.MaxLength = 50
        Me.txtICTITLE2.Multiline = True
        Me.txtICTITLE2.Name = "txtICTITLE2"
        Me.txtICTITLE2.Size = New System.Drawing.Size(75, 40)
        Me.txtICTITLE2.TabIndex = 0
        Me.txtICTITLE2.Text = ""
        Me.txtICTITLE2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnExam1
        '
        Me.btnExam1.BackColor = System.Drawing.Color.Blue
        Me.btnExam1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExam1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExam1.Location = New System.Drawing.Point(185, 235)
        Me.btnExam1.Name = "btnExam1"
        Me.btnExam1.Size = New System.Drawing.Size(65, 26)
        Me.btnExam1.TabIndex = 6
        Me.btnExam1.Text = "Exam 1"
        '
        'btnExam2
        '
        Me.btnExam2.BackColor = System.Drawing.Color.Gainsboro
        Me.btnExam2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExam2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExam2.Location = New System.Drawing.Point(250, 235)
        Me.btnExam2.Name = "btnExam2"
        Me.btnExam2.Size = New System.Drawing.Size(50, 26)
        Me.btnExam2.TabIndex = 7
        Me.btnExam2.Text = "2"
        '
        'btnExam3
        '
        Me.btnExam3.BackColor = System.Drawing.Color.Gainsboro
        Me.btnExam3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExam3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExam3.Location = New System.Drawing.Point(300, 235)
        Me.btnExam3.Name = "btnExam3"
        Me.btnExam3.Size = New System.Drawing.Size(45, 26)
        Me.btnExam3.TabIndex = 8
        Me.btnExam3.Text = "3"
        '
        'btnExam4
        '
        Me.btnExam4.BackColor = System.Drawing.Color.Gainsboro
        Me.btnExam4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExam4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExam4.Location = New System.Drawing.Point(345, 235)
        Me.btnExam4.Name = "btnExam4"
        Me.btnExam4.Size = New System.Drawing.Size(45, 26)
        Me.btnExam4.TabIndex = 9
        Me.btnExam4.Text = "4"
        '
        'btnExam5
        '
        Me.btnExam5.BackColor = System.Drawing.Color.Gainsboro
        Me.btnExam5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExam5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExam5.Location = New System.Drawing.Point(390, 235)
        Me.btnExam5.Name = "btnExam5"
        Me.btnExam5.Size = New System.Drawing.Size(45, 26)
        Me.btnExam5.TabIndex = 10
        Me.btnExam5.Text = "5"
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAll.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAll.Location = New System.Drawing.Point(435, 235)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(45, 26)
        Me.btnAll.TabIndex = 11
        Me.btnAll.Text = "All"
        '
        'txtButton2
        '
        Me.txtButton2.BackColor = System.Drawing.SystemColors.Window
        Me.txtButton2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtButton2.ForeColor = System.Drawing.Color.Black
        Me.txtButton2.Location = New System.Drawing.Point(120, 265)
        Me.txtButton2.MaxLength = 150
        Me.txtButton2.Multiline = True
        Me.txtButton2.Name = "txtButton2"
        Me.txtButton2.Size = New System.Drawing.Size(360, 70)
        Me.txtButton2.TabIndex = 4
        Me.txtButton2.Text = "Button2"
        '
        'txtButton3
        '
        Me.txtButton3.BackColor = System.Drawing.SystemColors.Window
        Me.txtButton3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtButton3.ForeColor = System.Drawing.Color.Black
        Me.txtButton3.Location = New System.Drawing.Point(120, 265)
        Me.txtButton3.MaxLength = 150
        Me.txtButton3.Multiline = True
        Me.txtButton3.Name = "txtButton3"
        Me.txtButton3.Size = New System.Drawing.Size(360, 70)
        Me.txtButton3.TabIndex = 5
        Me.txtButton3.Text = "Button3"
        '
        'txtExamName
        '
        Me.txtExamName.BackColor = System.Drawing.Color.White
        Me.txtExamName.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtExamName.Location = New System.Drawing.Point(190, 30)
        Me.txtExamName.MaxLength = 27
        Me.txtExamName.Name = "txtExamName"
        Me.txtExamName.Size = New System.Drawing.Size(280, 22)
        Me.txtExamName.TabIndex = 0
        Me.txtExamName.Text = ""
        Me.txtExamName.WordWrap = False
        '
        'txtIconMouse
        '
        Me.txtIconMouse.BackColor = System.Drawing.Color.White
        Me.txtIconMouse.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtIconMouse.Location = New System.Drawing.Point(120, 155)
        Me.txtIconMouse.MaxLength = 150
        Me.txtIconMouse.Multiline = True
        Me.txtIconMouse.Name = "txtIconMouse"
        Me.txtIconMouse.Size = New System.Drawing.Size(360, 70)
        Me.txtIconMouse.TabIndex = 2
        Me.txtIconMouse.Text = ""
        '
        'txtButton1
        '
        Me.txtButton1.BackColor = System.Drawing.SystemColors.Window
        Me.txtButton1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtButton1.ForeColor = System.Drawing.Color.Black
        Me.txtButton1.Location = New System.Drawing.Point(120, 265)
        Me.txtButton1.MaxLength = 150
        Me.txtButton1.Multiline = True
        Me.txtButton1.Name = "txtButton1"
        Me.txtButton1.Size = New System.Drawing.Size(360, 70)
        Me.txtButton1.TabIndex = 3
        Me.txtButton1.Text = "Button1"
        '
        'txtICTITLE
        '
        Me.txtICTITLE.BackColor = System.Drawing.Color.White
        Me.txtICTITLE.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtICTITLE.Location = New System.Drawing.Point(190, 55)
        Me.txtICTITLE.MaxLength = 50
        Me.txtICTITLE.Name = "txtICTITLE"
        Me.txtICTITLE.Size = New System.Drawing.Size(280, 22)
        Me.txtICTITLE.TabIndex = 1
        Me.txtICTITLE.Text = ""
        Me.txtICTITLE.WordWrap = False
        '
        'txtButton4
        '
        Me.txtButton4.BackColor = System.Drawing.SystemColors.Window
        Me.txtButton4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtButton4.ForeColor = System.Drawing.Color.Black
        Me.txtButton4.Location = New System.Drawing.Point(120, 265)
        Me.txtButton4.MaxLength = 150
        Me.txtButton4.Multiline = True
        Me.txtButton4.Name = "txtButton4"
        Me.txtButton4.Size = New System.Drawing.Size(360, 70)
        Me.txtButton4.TabIndex = 6
        Me.txtButton4.Text = "Routers, Switches and Commands"
        '
        'txtButton5
        '
        Me.txtButton5.BackColor = System.Drawing.SystemColors.Window
        Me.txtButton5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtButton5.ForeColor = System.Drawing.Color.Black
        Me.txtButton5.Location = New System.Drawing.Point(120, 265)
        Me.txtButton5.MaxLength = 150
        Me.txtButton5.Multiline = True
        Me.txtButton5.Name = "txtButton5"
        Me.txtButton5.Size = New System.Drawing.Size(360, 70)
        Me.txtButton5.TabIndex = 7
        Me.txtButton5.Text = "Routers, Switches and Commands"
        '
        'gbType
        '
        Me.gbType.BackColor = System.Drawing.Color.White
        Me.gbType.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbLab, Me.rbExam, Me.rbFlashCards, Me.lblPromptCurrentFormat, Me.txtMTYPE})
        Me.gbType.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.gbType.Location = New System.Drawing.Point(190, 85)
        Me.gbType.Name = "gbType"
        Me.gbType.Size = New System.Drawing.Size(285, 40)
        Me.gbType.TabIndex = 20
        Me.gbType.TabStop = False
        '
        'rbLab
        '
        Me.rbLab.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbLab.BackColor = System.Drawing.Color.Transparent
        Me.rbLab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLab.Location = New System.Drawing.Point(212, 7)
        Me.rbLab.Name = "rbLab"
        Me.rbLab.Size = New System.Drawing.Size(75, 28)
        Me.rbLab.TabIndex = 1
        Me.rbLab.Text = "&Lab"
        '
        'rbExam
        '
        Me.rbExam.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbExam.BackColor = System.Drawing.Color.Transparent
        Me.rbExam.Checked = True
        Me.rbExam.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbExam.Location = New System.Drawing.Point(12, 7)
        Me.rbExam.Name = "rbExam"
        Me.rbExam.Size = New System.Drawing.Size(105, 28)
        Me.rbExam.TabIndex = 0
        Me.rbExam.TabStop = True
        Me.rbExam.Text = "Practice &Exams"
        '
        'rbFlashCards
        '
        Me.rbFlashCards.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbFlashCards.BackColor = System.Drawing.Color.Transparent
        Me.rbFlashCards.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFlashCards.Location = New System.Drawing.Point(122, 7)
        Me.rbFlashCards.Name = "rbFlashCards"
        Me.rbFlashCards.Size = New System.Drawing.Size(90, 28)
        Me.rbFlashCards.TabIndex = 1
        Me.rbFlashCards.Text = "&Flashcards"
        '
        'lblPromptCurrentFormat
        '
        Me.lblPromptCurrentFormat.BackColor = System.Drawing.Color.Transparent
        Me.lblPromptCurrentFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPromptCurrentFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptCurrentFormat.ForeColor = System.Drawing.Color.Black
        Me.lblPromptCurrentFormat.Location = New System.Drawing.Point(170, 10)
        Me.lblPromptCurrentFormat.Name = "lblPromptCurrentFormat"
        Me.lblPromptCurrentFormat.Size = New System.Drawing.Size(95, 20)
        Me.lblPromptCurrentFormat.TabIndex = 4
        Me.lblPromptCurrentFormat.Text = "Current Format:"
        Me.lblPromptCurrentFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMTYPE
        '
        Me.txtMTYPE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMTYPE.Enabled = False
        Me.txtMTYPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMTYPE.Location = New System.Drawing.Point(175, 15)
        Me.txtMTYPE.MaxLength = 1
        Me.txtMTYPE.Name = "txtMTYPE"
        Me.txtMTYPE.Size = New System.Drawing.Size(95, 20)
        Me.txtMTYPE.TabIndex = 3
        Me.txtMTYPE.Text = ""
        Me.txtMTYPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mmuMain
        '
        Me.mmuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mmuFile})
        '
        'mmuFile
        '
        Me.mmuFile.Index = 0
        Me.mmuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mmuBuild, Me.mmuFileSave, Me.mmuFileExit})
        Me.mmuFile.Text = "File"
        '
        'mmuBuild
        '
        Me.mmuBuild.Index = 0
        Me.mmuBuild.Text = "Build Exam Set"
        '
        'mmuFileSave
        '
        Me.mmuFileSave.Index = 1
        Me.mmuFileSave.Text = "Save Exam Set"
        '
        'mmuFileExit
        '
        Me.mmuFileExit.Index = 2
        Me.mmuFileExit.Text = "Exit"
        '
        'odbConIconsE
        '
        Me.odbConIconsE.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=H:\QUEENED" & _
        "IT2004\bin\dbicnse.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:Sys" & _
        "tem database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OL" & _
        "EDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bul" & _
        "k Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";" & _
        "Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLED" & _
        "B:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=Fa" & _
        "lse;Jet OLEDB:SFP=False"
        '
        'odbDaIconsE
        '
        Me.odbDaIconsE.DeleteCommand = Me.OleDbDeleteCommand1
        Me.odbDaIconsE.InsertCommand = Me.OleDbInsertCommand1
        Me.odbDaIconsE.SelectCommand = Me.OleDbSelectCommand1
        Me.odbDaIconsE.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "t1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("ICTITLE", "ICTITLE"), New System.Data.Common.DataColumnMapping("IconMouse", "IconMouse"), New System.Data.Common.DataColumnMapping("fldSubFolder", "fldSubFolder"), New System.Data.Common.DataColumnMapping("MaxLbox", "MaxLbox"), New System.Data.Common.DataColumnMapping("MTYPE", "MTYPE"), New System.Data.Common.DataColumnMapping("TopicBut1", "TopicBut1"), New System.Data.Common.DataColumnMapping("TopicBut2", "TopicBut2"), New System.Data.Common.DataColumnMapping("TopicBut3", "TopicBut3"), New System.Data.Common.DataColumnMapping("TopicBut4", "TopicBut4"), New System.Data.Common.DataColumnMapping("TopicBut5", "TopicBut5"), New System.Data.Common.DataColumnMapping("TopicButAll", "TopicButAll")})})
        Me.odbDaIconsE.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM t1 WHERE (ID = ?) AND (ICTITLE = ? OR ? IS NULL AND ICTITLE IS NULL) " & _
        "AND (IconMouse = ? OR ? IS NULL AND IconMouse IS NULL) AND (MTYPE = ? OR ? IS NU" & _
        "LL AND MTYPE IS NULL) AND (MaxLbox = ? OR ? IS NULL AND MaxLbox IS NULL) AND (To" & _
        "picBut1 = ? OR ? IS NULL AND TopicBut1 IS NULL) AND (TopicBut2 = ? OR ? IS NULL " & _
        "AND TopicBut2 IS NULL) AND (TopicBut3 = ? OR ? IS NULL AND TopicBut3 IS NULL) AN" & _
        "D (TopicBut4 = ? OR ? IS NULL AND TopicBut4 IS NULL) AND (TopicBut5 = ? OR ? IS " & _
        "NULL AND TopicBut5 IS NULL) AND (TopicButAll = ? OR ? IS NULL AND TopicButAll IS" & _
        " NULL) AND (fldSubFolder = ? OR ? IS NULL AND fldSubFolder IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.odbConIconsE
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ICTITLE", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ICTITLE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ICTITLE1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ICTITLE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IconMouse", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IconMouse", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IconMouse1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IconMouse", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MTYPE", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MTYPE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MTYPE1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MTYPE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MaxLbox", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaxLbox", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MaxLbox1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaxLbox", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicBut1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicBut1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicBut11", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicBut1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicBut2", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicBut2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicBut21", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicBut2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicBut3", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicBut3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicBut31", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicBut3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicBut4", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicBut4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicBut41", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicBut4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicBut5", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicBut5", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicBut51", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicBut5", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicButAll", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicButAll", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicButAll1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicButAll", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldSubFolder", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldSubFolder", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldSubFolder1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldSubFolder", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO t1(ID, ICTITLE, IconMouse, fldSubFolder, MaxLbox, MTYPE, TopicBut1, T" & _
        "opicBut2, TopicBut3, TopicBut4, TopicBut5, TopicButAll) VALUES (?, ?, ?, ?, ?, ?" & _
        ", ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.odbConIconsE
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ICTITLE", System.Data.OleDb.OleDbType.VarWChar, 50, "ICTITLE"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("IconMouse", System.Data.OleDb.OleDbType.VarWChar, 150, "IconMouse"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("fldSubFolder", System.Data.OleDb.OleDbType.VarWChar, 150, "fldSubFolder"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MaxLbox", System.Data.OleDb.OleDbType.VarWChar, 5, "MaxLbox"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MTYPE", System.Data.OleDb.OleDbType.VarWChar, 3, "MTYPE"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TopicBut1", System.Data.OleDb.OleDbType.VarWChar, 150, "TopicBut1"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TopicBut2", System.Data.OleDb.OleDbType.VarWChar, 150, "TopicBut2"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TopicBut3", System.Data.OleDb.OleDbType.VarWChar, 150, "TopicBut3"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TopicBut4", System.Data.OleDb.OleDbType.VarWChar, 150, "TopicBut4"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TopicBut5", System.Data.OleDb.OleDbType.VarWChar, 150, "TopicBut5"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TopicButAll", System.Data.OleDb.OleDbType.VarWChar, 150, "TopicButAll"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT ID, ICTITLE, IconMouse, fldSubFolder, MaxLbox, MTYPE, TopicBut1, TopicBut2" & _
        ", TopicBut3, TopicBut4, TopicBut5, TopicButAll FROM t1"
        Me.OleDbSelectCommand1.Connection = Me.odbConIconsE
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE t1 SET ID = ?, ICTITLE = ?, IconMouse = ?, fldSubFolder = ?, MaxLbox = ?, " & _
        "MTYPE = ?, TopicBut1 = ?, TopicBut2 = ?, TopicBut3 = ?, TopicBut4 = ?, TopicBut5" & _
        " = ?, TopicButAll = ? WHERE (ID = ?) AND (ICTITLE = ? OR ? IS NULL AND ICTITLE I" & _
        "S NULL) AND (IconMouse = ? OR ? IS NULL AND IconMouse IS NULL) AND (MTYPE = ? OR" & _
        " ? IS NULL AND MTYPE IS NULL) AND (MaxLbox = ? OR ? IS NULL AND MaxLbox IS NULL)" & _
        " AND (TopicBut1 = ? OR ? IS NULL AND TopicBut1 IS NULL) AND (TopicBut2 = ? OR ? " & _
        "IS NULL AND TopicBut2 IS NULL) AND (TopicBut3 = ? OR ? IS NULL AND TopicBut3 IS " & _
        "NULL) AND (TopicBut4 = ? OR ? IS NULL AND TopicBut4 IS NULL) AND (TopicBut5 = ? " & _
        "OR ? IS NULL AND TopicBut5 IS NULL) AND (TopicButAll = ? OR ? IS NULL AND TopicB" & _
        "utAll IS NULL) AND (fldSubFolder = ? OR ? IS NULL AND fldSubFolder IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.odbConIconsE
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ICTITLE", System.Data.OleDb.OleDbType.VarWChar, 50, "ICTITLE"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("IconMouse", System.Data.OleDb.OleDbType.VarWChar, 150, "IconMouse"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("fldSubFolder", System.Data.OleDb.OleDbType.VarWChar, 150, "fldSubFolder"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MaxLbox", System.Data.OleDb.OleDbType.VarWChar, 5, "MaxLbox"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MTYPE", System.Data.OleDb.OleDbType.VarWChar, 3, "MTYPE"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TopicBut1", System.Data.OleDb.OleDbType.VarWChar, 150, "TopicBut1"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TopicBut2", System.Data.OleDb.OleDbType.VarWChar, 150, "TopicBut2"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TopicBut3", System.Data.OleDb.OleDbType.VarWChar, 150, "TopicBut3"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TopicBut4", System.Data.OleDb.OleDbType.VarWChar, 150, "TopicBut4"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TopicBut5", System.Data.OleDb.OleDbType.VarWChar, 150, "TopicBut5"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TopicButAll", System.Data.OleDb.OleDbType.VarWChar, 150, "TopicButAll"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ICTITLE", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ICTITLE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ICTITLE1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ICTITLE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IconMouse", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IconMouse", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IconMouse1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IconMouse", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MTYPE", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MTYPE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MTYPE1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MTYPE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MaxLbox", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaxLbox", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MaxLbox1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaxLbox", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicBut1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicBut1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicBut11", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicBut1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicBut2", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicBut2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicBut21", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicBut2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicBut3", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicBut3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicBut31", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicBut3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicBut4", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicBut4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicBut41", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicBut4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicBut5", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicBut5", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicBut51", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicBut5", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicButAll", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicButAll", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TopicButAll1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopicButAll", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldSubFolder", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldSubFolder", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fldSubFolder1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldSubFolder", System.Data.DataRowVersion.Original, Nothing))
        '
        'DsIconsE1
        '
        Me.DsIconsE1.DataSetName = "dsIconsE"
        Me.DsIconsE1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsIconsE1.Namespace = "http://www.tempuri.org/dsIconsE.xsd"
        '
        'lblIcon
        '
        Me.lblIcon.Location = New System.Drawing.Point(10, 305)
        Me.lblIcon.Name = "lblIcon"
        Me.lblIcon.Size = New System.Drawing.Size(95, 23)
        Me.lblIcon.TabIndex = 29
        Me.lblIcon.Text = "Icon Title"
        Me.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtParentFolder
        '
        Me.txtParentFolder.BackColor = System.Drawing.Color.White
        Me.txtParentFolder.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParentFolder.Location = New System.Drawing.Point(510, 50)
        Me.txtParentFolder.MaxLength = 10
        Me.txtParentFolder.Name = "txtParentFolder"
        Me.txtParentFolder.Size = New System.Drawing.Size(85, 20)
        Me.txtParentFolder.TabIndex = 4
        Me.txtParentFolder.Text = ""
        '
        'txtSubFolder1
        '
        Me.txtSubFolder1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtSubFolder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubFolder1.Enabled = False
        Me.txtSubFolder1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubFolder1.Location = New System.Drawing.Point(510, 75)
        Me.txtSubFolder1.MaxLength = 40
        Me.txtSubFolder1.Name = "txtSubFolder1"
        Me.txtSubFolder1.Size = New System.Drawing.Size(85, 20)
        Me.txtSubFolder1.TabIndex = 5
        Me.txtSubFolder1.Text = ""
        '
        'txtSubFolder2
        '
        Me.txtSubFolder2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtSubFolder2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubFolder2.Enabled = False
        Me.txtSubFolder2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubFolder2.Location = New System.Drawing.Point(510, 100)
        Me.txtSubFolder2.MaxLength = 40
        Me.txtSubFolder2.Name = "txtSubFolder2"
        Me.txtSubFolder2.Size = New System.Drawing.Size(85, 20)
        Me.txtSubFolder2.TabIndex = 6
        Me.txtSubFolder2.Text = ""
        '
        'txtfldSubFolder
        '
        Me.txtfldSubFolder.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtfldSubFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfldSubFolder.Enabled = False
        Me.txtfldSubFolder.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfldSubFolder.Location = New System.Drawing.Point(480, 125)
        Me.txtfldSubFolder.MaxLength = 150
        Me.txtfldSubFolder.Name = "txtfldSubFolder"
        Me.txtfldSubFolder.ReadOnly = True
        Me.txtfldSubFolder.Size = New System.Drawing.Size(115, 20)
        Me.txtfldSubFolder.TabIndex = 7
        Me.txtfldSubFolder.Text = ""
        '
        'cboMaxQuestions
        '
        Me.cboMaxQuestions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaxQuestions.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMaxQuestions.Location = New System.Drawing.Point(490, 190)
        Me.cboMaxQuestions.Name = "cboMaxQuestions"
        Me.cboMaxQuestions.Size = New System.Drawing.Size(105, 24)
        Me.cboMaxQuestions.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Navy
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(600, 25)
        Me.lblTitle.TabIndex = 35
        Me.lblTitle.Text = "TestQueen Practice Exams Editor"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTopFolder
        '
        Me.lblTopFolder.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopFolder.Image = CType(resources.GetObject("lblTopFolder.Image"), System.Drawing.Bitmap)
        Me.lblTopFolder.Location = New System.Drawing.Point(485, 50)
        Me.lblTopFolder.Name = "lblTopFolder"
        Me.lblTopFolder.Size = New System.Drawing.Size(25, 25)
        Me.lblTopFolder.TabIndex = 38
        '
        'lblMiddleFolder
        '
        Me.lblMiddleFolder.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleFolder.Image = CType(resources.GetObject("lblMiddleFolder.Image"), System.Drawing.Bitmap)
        Me.lblMiddleFolder.Location = New System.Drawing.Point(485, 75)
        Me.lblMiddleFolder.Name = "lblMiddleFolder"
        Me.lblMiddleFolder.Size = New System.Drawing.Size(25, 25)
        Me.lblMiddleFolder.TabIndex = 39
        '
        'lblBottomFolder
        '
        Me.lblBottomFolder.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBottomFolder.Image = CType(resources.GetObject("lblBottomFolder.Image"), System.Drawing.Bitmap)
        Me.lblBottomFolder.Location = New System.Drawing.Point(485, 100)
        Me.lblBottomFolder.Name = "lblBottomFolder"
        Me.lblBottomFolder.Size = New System.Drawing.Size(25, 25)
        Me.lblBottomFolder.TabIndex = 40
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Black
        Me.lblID.Location = New System.Drawing.Point(55, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(60, 50)
        Me.lblID.TabIndex = 23
        Me.lblID.Text = "1"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel12
        '
        Me.LinkLabel12.AutoSize = True
        Me.LinkLabel12.BackColor = System.Drawing.Color.White
        Me.LinkLabel12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel12.Location = New System.Drawing.Point(5, 285)
        Me.LinkLabel12.Name = "LinkLabel12"
        Me.LinkLabel12.Size = New System.Drawing.Size(61, 15)
        Me.LinkLabel12.TabIndex = 12
        Me.LinkLabel12.TabStop = True
        Me.LinkLabel12.Text = "Module 12"
        Me.LinkLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel11
        '
        Me.LinkLabel11.AutoSize = True
        Me.LinkLabel11.BackColor = System.Drawing.Color.White
        Me.LinkLabel11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel11.Location = New System.Drawing.Point(5, 265)
        Me.LinkLabel11.Name = "LinkLabel11"
        Me.LinkLabel11.Size = New System.Drawing.Size(61, 15)
        Me.LinkLabel11.TabIndex = 11
        Me.LinkLabel11.TabStop = True
        Me.LinkLabel11.Text = "Module 11"
        Me.LinkLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel10
        '
        Me.LinkLabel10.AutoSize = True
        Me.LinkLabel10.BackColor = System.Drawing.Color.White
        Me.LinkLabel10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel10.Location = New System.Drawing.Point(5, 245)
        Me.LinkLabel10.Name = "LinkLabel10"
        Me.LinkLabel10.Size = New System.Drawing.Size(61, 15)
        Me.LinkLabel10.TabIndex = 10
        Me.LinkLabel10.TabStop = True
        Me.LinkLabel10.Text = "Module 10"
        Me.LinkLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel9
        '
        Me.LinkLabel9.AutoSize = True
        Me.LinkLabel9.BackColor = System.Drawing.Color.White
        Me.LinkLabel9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel9.Location = New System.Drawing.Point(5, 225)
        Me.LinkLabel9.Name = "LinkLabel9"
        Me.LinkLabel9.Size = New System.Drawing.Size(54, 15)
        Me.LinkLabel9.TabIndex = 9
        Me.LinkLabel9.TabStop = True
        Me.LinkLabel9.Text = "Module 9"
        Me.LinkLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel8
        '
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.BackColor = System.Drawing.Color.White
        Me.LinkLabel8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel8.Location = New System.Drawing.Point(5, 205)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(54, 15)
        Me.LinkLabel8.TabIndex = 8
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "Module 8"
        Me.LinkLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel7
        '
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.BackColor = System.Drawing.Color.White
        Me.LinkLabel7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel7.Location = New System.Drawing.Point(5, 185)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(54, 15)
        Me.LinkLabel7.TabIndex = 7
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "Module 7"
        Me.LinkLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.BackColor = System.Drawing.Color.White
        Me.LinkLabel6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel6.Location = New System.Drawing.Point(5, 165)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(54, 15)
        Me.LinkLabel6.TabIndex = 6
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "Module 6"
        Me.LinkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.BackColor = System.Drawing.Color.White
        Me.LinkLabel5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel5.Location = New System.Drawing.Point(5, 145)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(54, 15)
        Me.LinkLabel5.TabIndex = 5
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Module 5"
        Me.LinkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.BackColor = System.Drawing.Color.White
        Me.LinkLabel4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.Location = New System.Drawing.Point(5, 125)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(54, 15)
        Me.LinkLabel4.TabIndex = 4
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Module 4"
        Me.LinkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = System.Drawing.Color.White
        Me.LinkLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(5, 105)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(54, 15)
        Me.LinkLabel3.TabIndex = 2
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Module 3"
        Me.LinkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.White
        Me.LinkLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(5, 85)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(54, 15)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Module 2"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Navy
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LinkLabel1.Location = New System.Drawing.Point(5, 65)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(54, 15)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Module 1"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlModuleList
        '
        Me.pnlModuleList.AutoScroll = True
        Me.pnlModuleList.BackColor = System.Drawing.Color.White
        Me.pnlModuleList.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblID, Me.LinkLabel12, Me.LinkLabel11, Me.LinkLabel10, Me.LinkLabel9, Me.LinkLabel8, Me.LinkLabel7, Me.LinkLabel6, Me.LinkLabel5, Me.LinkLabel4, Me.LinkLabel3, Me.LinkLabel2, Me.LinkLabel1, Me.lblIDNumber})
        Me.pnlModuleList.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlModuleList.Location = New System.Drawing.Point(0, 25)
        Me.pnlModuleList.Name = "pnlModuleList"
        Me.pnlModuleList.Size = New System.Drawing.Size(115, 357)
        Me.pnlModuleList.TabIndex = 19
        '
        'frmEditIconsE
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(600, 382)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtIconMouse, Me.pnlModuleList, Me.gbType, Me.btn6, Me.btn5, Me.btn4, Me.btn3, Me.btn2, Me.btn1, Me.lblPromptCollectionFileLocation, Me.lblPromptModuleEditor, Me.lblPromptModuleTopics, Me.lblPromptModuleName, Me.lblPromptCollectionName, Me.lblPromptModuleDesc, Me.gbIconPreview, Me.lblTitle, Me.lblPromptMaxQues, Me.cboMaxQuestions, Me.txtfldSubFolder, Me.txtExamName, Me.txtICTITLE, Me.txtSubFolder2, Me.txtSubFolder1, Me.txtParentFolder, Me.btnCreate, Me.txtButton1, Me.txtbtnAll, Me.txtButton5, Me.txtButton4, Me.txtButton3, Me.txtButton2, Me.btnAll, Me.btnExam5, Me.btnExam4, Me.btnExam3, Me.btnExam2, Me.btnExam1, Me.txtMaxLbox, Me.lblBottomFolder, Me.lblMiddleFolder, Me.lblTopFolder, Me.Label1})
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.mmuMain
        Me.MinimizeBox = False
        Me.Name = "frmEditIconsE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QueenEdit 2004 - TestQueen Practice Exams Editor"
        Me.gbIconPreview.ResumeLayout(False)
        Me.gbType.ResumeLayout(False)
        CType(Me.DsIconsE1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlModuleList.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Overloads Sub BindData(ByVal txtBox As TextBox, ByVal strS As String)
        Dim pb As Binding = New Binding("Text", DsIconsE1, strS)
        txtBox.DataBindings.Add(pb)
    End Sub
    Private Overloads Sub BindData(ByVal lblLabel As Label, ByVal strS As String)
        Dim pb As Binding = New Binding("Text", DsIconsE1, strS)
        lblLabel.DataBindings.Add(pb)
    End Sub
    Private Function ValidateData(ByVal txtbox As TextBox) As Boolean
        If txtbox.Text = "" Then
            MsgBox("You have left some required fields blank")
            Return False
        End If

        If txtbox.Text.IndexOf("\") > -1 Then
            MsgBox("Please remove the backslash from the name")
            Return False
        End If

        Return True
    End Function
    Sub MsgBoxB()
        If mblnDirty = True Then
            Dim mr As MsgBoxResult = MsgBox("Save Changes?", MsgBoxStyle.YesNo, "Confirm Changes")
            If mr = MsgBoxResult.Yes Then SaveAllData()
        End If
    End Sub
    Sub MsgBoxC()
        MsgBox("Please remove the comma from the exam name.")
    End Sub
    Function MsgBoxD() As MsgBoxResult
        Dim mr As MsgBoxResult = MsgBox("Would you like to keep the default 'Set Name': " _
        & txtExamName.Text & "? Clicking 'No' will let you rename the collection.", _
        MsgBoxStyle.YesNo, "Confirm Changes")
        Return mr '? changed text
    End Function
    Function MsgBoxE() As MsgBoxResult
        Dim mr As MsgBoxResult = MsgBox("Would you like to keep the default 'Folder Location': " _
        & txtParentFolder.Text & "? Clicking 'No' will allow you to go back and rename the folder.", _
           MsgBoxStyle.YesNo, "Confirm Changes")
        Return mr
    End Function
    Sub MsgBoxF()
        MsgBox("Please select an 'Exam Type': Practice Exams, Flashcards or Labs")
    End Sub
    Function MsgBoxG() As MsgBoxResult
        Dim mr As MsgBoxResult = MsgBoxResult.Cancel
        If isBuilding = "" Then
            mr = MsgBox("Are you sure you want to delete the entire exam collection? " _
            & "Clicking 'Yes' will delete all exam modules in this collection. " _
            & "It will not delete any others.", MsgBoxStyle.YesNo, "Confirm Exam Collection Deletion")
        End If
        Return mr '? Added
    End Function
    Function MsgBoxL(ByVal sFrom As String, ByVal sTo As String, ByVal sType As String) As MsgBoxResult
        Dim mr As MsgBoxResult = MsgBox("You may have changed the exam type from " & sFrom & " to " _
        & sTo & ". Click OK to overwrite the old exam for this module with a new exam. Click " _
        & "Cancel to go back to the module editor. Navigate to the module folder " _
        & "on your hard drive and copy it to another directory as a backup or change it back to the previous " _
        & "Exam Type: " & sType, MsgBoxStyle.OKCancel, "Confirm Exam Overwrite")
        Return mr
    End Function

    Sub LookForSavedExams(ByVal iMod As Integer)
        'THIS WILL LOOK FOR THE SAVED EXAMS FOR THE CURRENT MODULE
        'IF AN EXAM WAS SAVED THEN ITS EDIT BUTTON IS HIGHLIGHTED
        Dim Count As Integer, pdb As String, pPath As String
        If txtParentFolder.Text <> "" Then
            pPath = SP & txtParentFolder.Text & "\" & txtfldSubFolder.Text

            For Count = 1 To 6
                If iMod < 10 Then
                    pdb = "db00" & iMod & Count & ".mdb"
                ElseIf iMod > 9 Then
                    pdb = "db0" & iMod & Count & ".mdb"
                End If
                '"db0" & lblID.Text & fButtonClicked & ".mdb"
                If Count = 1 And iMod < 10 Then pdb = "db00" & iMod & ".mdb"
                If Count = 1 And iMod > 9 Then pdb = "db0" & iMod & ".mdb" ' db010, db 011 db 012 ?


                If File.Exists(pPath & "\" & pdb) Then
                    Select Case Count
                        Case 1
                            HighlightEditButton(btn1)
                        Case 2
                            HighlightEditButton(btn2)
                        Case 3
                            HighlightEditButton(btn3)
                        Case 4
                            HighlightEditButton(btn4)
                        Case 5
                            HighlightEditButton(btn5)
                        Case 6
                            HighlightEditButton(btn6)
                    End Select
                End If
            Next
        End If
    End Sub 'Highlights buttons if file exists

    Sub AddQuestionsToCombo()
        Dim count As Integer
        For count = 5 To 250 Step 5
            cboMaxQuestions.Items.Add(count.ToString)
        Next
    End Sub
    Sub BuildExam()
        Dim pBuildDir As String, pBuildSubDir As String
        isBuilding = "BuildingExam" 'so it bypasses the messagebox in DeleteExam() sub
        mblnDirty = False
        pBuildDir = mbackupFolder & fCollectionName
        pBuildSubDir = txtParentFolder.Text

        'DELETE THE DIRECTORY, TRUE FOR RECURSIVE- ALL FILES IN IT
        If Directory.Exists(pBuildDir) Then Directory.Delete(pBuildDir, True)

        'CREATE A DIRECTORY IN THE BUILD DIRECTORY
        Directory.CreateDirectory(pBuildDir)

        'IF THE COLLECTION'S DIRECTORY EXIST,  'MOVE THE COLLECTION DIRECTORY TO THE BUILT DIRECTORY
        If Directory.Exists(SP & pBuildSubDir) Then
            Directory.Move(SP & pBuildSubDir, pBuildDir & "\" & pBuildSubDir)
            File.Copy(mbackupFolder & "installit.dat", pBuildDir & "\" & "installit.dat")
            File.Copy(mbackupFolder & "icns.dat", pBuildDir & "\" & "icns.dat")
            File.Copy(mbackupFolder & "TestQueen.exe", pBuildDir & "\" & "TestQueen.exe")
            File.Copy(SP & "QueenLib.dll", pBuildDir & "\" & "QueenLib.dll")
        End If

        WriteNewTests()
        DeleteExam()
    End Sub
    Sub CheckIfPurple(ByVal btnB As Button)
        If btnB Is btn1 Then
            btn1.Enabled = True
        End If
        If btnB Is btn1 Then
            btn2.Enabled = True
        End If
        If btnB Is btn2 Then
            btn3.Enabled = True
        End If
        If btnB Is btn3 Then
            btn4.Enabled = True
        End If
        If btnB Is btn4 Then
            btn5.Enabled = True
        End If
        If btnB Is btn5 Then
            btn6.Enabled = True
        End If
    End Sub
    Sub CloseForm()
        MsgBoxB()
        odbConIconsE.Close()
        fParent.pnlCurrentRecord.Text = ""
        fParent.pnlRecordCount.Text = ""
    End Sub
    Sub CreateExam()
        'ASK IF USER WILL KEEP DEFAULT COLLECTION NAME AND EXAM SET FOLDER NAME
        'WHEREEVER SAVEALLDATA IS CALLED ADD THIS
        If txtExamName.Text.IndexOf(",") > -1 Then
            MsgBoxC()
            Exit Sub
        End If

        If fISNEWTEST = True Then 'if this a new test
            Dim DefaultExamName As String = "New Collection", DefaultFolder As String = "examset"

            If txtExamName.Text.IndexOf(DefaultExamName) > -1 Then 'if name in textbox consists of New Collection
                Dim pmsg As MsgBoxResult = MsgBoxD()
                If pmsg = MsgBoxResult.No Then Exit Sub
            End If

            If txtParentFolder.Text.IndexOf(DefaultFolder) > -1 Then 'EXAM PARENT FOLDER
                Dim pmsg As MsgBoxResult = MsgBoxE()
                If pmsg = MsgBoxResult.No Then Exit Sub
            End If 'if it is not a new test, dont prompt to keep folder name, since box is disabled
        End If '? moved end if down a block 'was asking to keep default folder name if not new test

        Call SaveAllData() 'SAVE IF THEY WILL KEEP DEFAULT NAMES

    End Sub
    Sub DeleteExam() 'used for BUILD EXAM only
        If MsgBoxG() = MsgBoxResult.Yes Then
            Dim FS As New FileStream(minstallFile, FileMode.Open, FileAccess.Write)
            Dim m_Writer As New StreamWriter(FS)
            m_Writer.Flush()
            m_Writer.BaseStream.Seek(0, SeekOrigin.Begin)
            m_Writer.Write("D," & txtExamName.Text & "," & fPARENTFOLDER)
            m_Writer.Write(vbCrLf)
            m_Writer.Flush()
            m_Writer.Close()
            FS.Close() '???
            Me.Close()
        End If
    End Sub
    Sub DetermineDatabase()
        'DETERMINE THE DATABASE FILE NAME TO OPEN AND BE SAVED AS
        'BASED ON SET NAMING CONVENTION USED IN TESTQUEEN PRACTICE EXAMS PROGRAM
        fFULLMODULEPATH = SP & fPARENTFOLDER & "\" & txtfldSubFolder.Text
        If ToInt32(lblID.Text) < 10 Then
            fCurrentModuleDB = "db00" & lblID.Text & fButtonClicked & ".mdb"
        ElseIf ToInt32(lblID.Text) > 9 Then
            fCurrentModuleDB = "db0" & lblID.Text & fButtonClicked & ".mdb"
        End If

    End Sub
    Sub DisableButtons2to6()
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
    End Sub
    Sub FillAndBindDataSet()
        Try
            odbDaIconsE.Fill(DsIconsE1)
        Catch
            RepairIconsDatabase()
            odbDaIconsE.Fill(DsIconsE1)
        End Try
        BindData(lblID, "t1.ID")
        BindData(txtICTITLE, "t1.ICTITLE")
        BindData(txtIconMouse, "t1.IconMouse")
        BindData(txtButton1, "t1.TopicBut1")
        BindData(txtButton2, "t1.TopicBut2")
        BindData(txtButton3, "t1.TopicBut3")
        BindData(txtButton4, "t1.TopicBut4")
        BindData(txtButton5, "t1.TopicBut5")
        BindData(txtbtnAll, "t1.TopicButAll")
        BindData(txtMaxLbox, "t1.MaxLbox")
        BindData(txtMTYPE, "t1.MTYPE")
        BindData(txtfldSubFolder, "t1.fldSubFolder")
    End Sub
    Sub GoToIconModule(ByVal iMod As Integer)
        'THIS WILL NAVIGATE TO THE MODULE
        SetButtonsGray()
        DisableButtons2to6()
        GoToRecord(iMod - 1)
        txtSubFolder2.Text = "module" & Me.BindingContext(DsIconsE1, "t1").Position + 1
        txtfldSubFolder.Text = txtSubFolder1.Text & "\" & txtSubFolder2.Text & "\"
        'RESET THE ICON TEXT AND TOPICBUTTONS SELECTED AND RESET THE LISTBOX
        txtICTITLE2.Text = txtICTITLE.Text
        HideAllTextBoxes()
        txtButton1.Location = New Point(120, 265)
        HighLightTopicButton(btnExam1)
        UpdateListBoxQuestions()
        LookForSavedExams(iMod)
        MapMtypeToCheckState()
        UpdateTxtMTYPE()
    End Sub
    Sub GoToRecord(ByVal rec As Integer)
        Me.BindingContext(DsIconsE1, "t1").Position = rec
    End Sub
    Sub HideAllTextBoxes() 'ByVal pEdit As Boolean, ByVal pNum As String, ByVal txt As TextBox)
        'hide all boxes except one at top
        'txtButton1.Visible = False
        'txtButton2.Visible = False
        'txtButton3.Visible = False
        'txtButton4.Visible = False
        'txtButton5.Visible = False
        'txtbtnAll.Visible = False
        Dim VisibleLoc As Point = New Point(120, 265)
        Dim NotVisibleLoc As Point = New Point(120, 155)
        txtButton1.Location = NotVisibleLoc
        txtButton2.Location = NotVisibleLoc
        txtButton3.Location = NotVisibleLoc
        txtButton4.Location = NotVisibleLoc
        txtButton5.Location = NotVisibleLoc
        txtbtnAll.Location = NotVisibleLoc
    End Sub
    Sub HighlightLinkLabel(ByVal linklbl As LinkLabel)
        'WILL HIGHLIGHT THE APPROPRIATE LINK
        'AND UNHIGHLIGHT THE OTHER LINKS
        Dim Clr As System.Drawing.Color = Color.White
        LinkLabel1.BackColor = Clr
        LinkLabel2.BackColor = Clr
        LinkLabel3.BackColor = Clr
        LinkLabel4.BackColor = Clr
        LinkLabel5.BackColor = Clr
        LinkLabel6.BackColor = Clr
        LinkLabel7.BackColor = Clr
        LinkLabel8.BackColor = Clr
        LinkLabel9.BackColor = Clr
        LinkLabel10.BackColor = Clr
        LinkLabel11.BackColor = Clr
        LinkLabel12.BackColor = Clr
        linklbl.BackColor = System.Drawing.Color.Navy
    End Sub
    Sub HighlightLinks()
        'THIS WILL HIGHLIGHT THE APPROPRIATE LINK
        'WHEN THE CURRENT RECORD (MODULE) CHANGES
        'IT WILL DISPLAY THE CURRENT MODULE
        Select Case lblID.Text
            Case "1"
                HighlightLinkLabel(LinkLabel1)
                GoToIconModule(1)
            Case "2"
                HighlightLinkLabel(LinkLabel2)
                GoToIconModule(2)
            Case "3"
                HighlightLinkLabel(LinkLabel3)
                GoToIconModule(3)
            Case "4"
                HighlightLinkLabel(LinkLabel4)
                GoToIconModule(4)
            Case "5"
                HighlightLinkLabel(LinkLabel5)
                GoToIconModule(5)
            Case "6"
                HighlightLinkLabel(LinkLabel6)
                GoToIconModule(6)
            Case "7"
                HighlightLinkLabel(LinkLabel7)
                GoToIconModule(7)
            Case "8"
                HighlightLinkLabel(LinkLabel8)
                GoToIconModule(8)
            Case "9"
                HighlightLinkLabel(LinkLabel9)
                GoToIconModule(9)
            Case "10"
                HighlightLinkLabel(LinkLabel10)
                GoToIconModule(10)
            Case "11"
                HighlightLinkLabel(LinkLabel11)
                GoToIconModule(11)
            Case "12"
                HighlightLinkLabel(LinkLabel12)
                GoToIconModule(12)
        End Select
    End Sub
    Sub HighLightTopicButton(ByVal btnExam As Button)
        'THIS WILL HIGHLIGHT THE CURRENT TOPIC BUTTON
        'WHEN THE USER CLICKS EACH TOPIC BUTTON 
        'FOR THE TOPIC THAT IS BEING EDITED
        Dim clr As System.Drawing.Color = Color.Gainsboro
        btnExam1.BackColor = clr
        btnExam2.BackColor = clr
        btnExam3.BackColor = clr
        btnExam4.BackColor = clr
        btnExam5.BackColor = clr
        btnAll.BackColor = clr

        btnExam.BackColor = System.Drawing.Color.Blue
    End Sub
    Sub HighlightEditButton(ByVal btnButton As Button)
        btnButton.BackColor = Color.MediumPurple
        CheckIfPurple(btnButton)
    End Sub
    Sub MapMtypeToCheckState()
        If txtMTYPE.Text = "F" Then
            rbFlashCards.Checked = True
        ElseIf txtMTYPE.Text = "L" Then
            rbLab.Checked = True
        ElseIf txtMTYPE.Text = "E" Then
            rbExam.Checked = True
        Else
            rbExam.Checked = True
        End If
    End Sub
    Sub OpenExamToEdit()
        Dim IsExamNow As Boolean = False, IsLabNow As Boolean = False
        Dim IsFlashCardNow As Boolean = False, IsExamAfter As Boolean = False
        Dim IsLabAfter As Boolean = False, IsFlashCardAfter As Boolean = False

        Dim ChangedExamToLab As Boolean = False, ChangedLabToExam As Boolean = False
        Dim ChangedLabToFlashCard As Boolean = False, ChangedFlashCardToLab As Boolean = False
        Dim ChangedExamToFlashCard As Boolean = False, ChangedFlashCardToExam As Boolean = False

        If fISNEWTEST = True Then
            If ValidateData(txtParentFolder) = False Then Exit Sub
            If ValidateData(txtExamName) = False Then Exit Sub
        End If
        If ValidateData(txtICTITLE) = False Then Exit Sub
        If ValidateData(txtIconMouse) = False Then Exit Sub
        If ValidateData(txtSubFolder1) = False Then Exit Sub
        If ValidateData(txtSubFolder2) = False Then Exit Sub

        If txtMTYPE.Text = "" Then
            MsgBoxF()
            Exit Sub
        End If

        'NEW CODE ADDED******
        IsExamNow = (Me.DsIconsE1.t1.Rows(ToInt32(lblID.Text) - 1).Item("MTYPE").ToString = "E")
        IsLabNow = (Me.DsIconsE1.t1.Rows(ToInt32(lblID.Text) - 1).Item("MTYPE").ToString = "L")
        IsFlashCardNow = (Me.DsIconsE1.t1.Rows(ToInt32(lblID.Text) - 1).Item("MTYPE").ToString = "F")

        Call SaveAllData()

        IsExamAfter = Me.DsIconsE1.t1.Rows(ToInt32(lblID.Text) - 1).Item("MTYPE").ToString = "E"
        IsLabAfter = Me.DsIconsE1.t1.Rows(ToInt32(lblID.Text) - 1).Item("MTYPE").ToString = "L"
        IsFlashCardAfter = Me.DsIconsE1.t1.Rows(ToInt32(lblID.Text) - 1).Item("MTYPE").ToString = "F"
        If IsExamNow = True And IsLabAfter = True Then ChangedExamToLab = True
        If IsLabNow = True And IsExamAfter = True Then ChangedLabToExam = True
        If IsFlashCardNow = True And IsLabAfter = True Then ChangedFlashCardToLab = True
        If IsLabNow = True And IsFlashCardAfter = True Then ChangedLabToFlashCard = True
        If IsExamNow = True And IsFlashCardAfter = True Then ChangedExamToFlashCard = True
        If IsFlashCardNow = True And IsExamAfter = True Then ChangedFlashCardToExam = True

        DetermineDatabase()

        'SHOW THE APPROPRIATE FORM TO EDIT THE SELECTED EXAM TYPE
        If rbExam.Checked = True Then
            fintMaxQuestions = ToInt32(cboMaxQuestions.SelectedItem) 'SET MAX QUESTIONS
            If ChangedLabToExam = True And ChangedExamToLab = False Then RepairDatabase("E")
            If ChangedFlashCardToExam = True And ChangedExamToFlashCard = False Then RepairDatabase("E")
            If ChangedExamToLab = False And ChangedLabToExam = False And _
  ChangedFlashCardToExam = False And ChangedExamToFlashCard = False Then ReplaceDatabase("E")
            ShowExamForm()
            Exit Sub
        End If

        If rbLab.Checked = True Then
            fintMaxQuestions = ToInt32(cboMaxQuestions.SelectedItem)
            'IF USER CHANGED EXAM  TO LAB, FLASH TO LAB 
            If ChangedExamToLab = True And ChangedLabToExam = False Then RepairDatabase("L")
            If ChangedFlashCardToLab = True And ChangedLabToFlashCard = False Then RepairDatabase("L")
            If ChangedExamToLab = False And ChangedLabToExam = False And _
            ChangedLabToFlashCard = False And ChangedFlashCardToLab = False Then ReplaceDatabase("L")
            ShowLabsForm()
            Exit Sub
        End If

        'FLASHCARDS DATABASE
        If rbFlashCards.Checked = True Then
            If ChangedExamToFlashCard = True And ChangedFlashCardToExam = False Then RepairDatabase("F")
            If ChangedLabToFlashCard = True And ChangedFlashCardToLab = False Then RepairDatabase("F")
            If ChangedFlashCardToExam = False And ChangedExamToFlashCard = False And _
            ChangedLabToFlashCard = False And ChangedFlashCardToLab = False Then ReplaceDatabase("F")
            ShowFlashForm()
        End If
    End Sub
    Sub RbExamCheck()
        If rbExam.Checked = True Then
            lblPromptMaxQues.Enabled = True
            cboMaxQuestions.Enabled = True
        End If
    End Sub
    Sub RbFlashCardCheck()
        If rbFlashCards.Checked = True Then
            lblPromptMaxQues.Enabled = False
            cboMaxQuestions.Enabled = False
        End If
    End Sub
    Sub RbLabCheck()
        If rbLab.Checked = True Then
            lblPromptMaxQues.Enabled = True
            cboMaxQuestions.Enabled = True
        End If
    End Sub
    Sub RepairDatabase(ByVal typeOfExam As String)
        If File.Exists(fFULLMODULEPATH & fCurrentModuleDB) Then
            Select Case typeOfExam
                Case "E"
                    File.Delete(dbExamTempPath)
                    File.Copy(dbExamBackup, dbExamTempPath)
                Case "F"
                    File.Delete(dbFlashTempPath)
                    File.Copy(dbFlashBackup, dbFlashTempPath)
                Case "L"
                    File.Delete(dbLabsTempPath)
                    File.Copy(dbLabsBackup, dbLabsTempPath)
            End Select
        End If
    End Sub
    Sub RepairIconsDatabase()
        If File.Exists(dbTempPath) Then
            File.Delete(dbTempPath)
        End If
        File.Copy(dbBackupPath, dbTempPath)
    End Sub
    Sub ReplaceDatabase(ByVal typeOfExam As String)
        Select Case typeOfExam
            Case "E"
                If File.Exists(fFULLMODULEPATH & fCurrentModuleDB) Then
                    File.Delete(dbExamTempPath)
                    File.Copy(fFULLMODULEPATH & fCurrentModuleDB, dbExamTempPath)
                Else
                    File.Delete(dbExamTempPath)
                    File.Copy(dbExamBackup, dbExamTempPath) 'create new
                End If
                Exit Sub
            Case "F"
                If File.Exists(fFULLMODULEPATH & fCurrentModuleDB) Then
                    File.Delete(dbFlashTempPath)
                    File.Copy(fFULLMODULEPATH & fCurrentModuleDB, dbFlashTempPath)
                Else
                    File.Delete(dbFlashTempPath)
                    File.Copy(dbFlashBackup, dbFlashTempPath) 'create new
                End If
                Exit Sub
            Case "L"
                If File.Exists(fFULLMODULEPATH & fCurrentModuleDB) Then
                    File.Delete(dbLabsTempPath)
                    File.Copy(fFULLMODULEPATH & fCurrentModuleDB, dbLabsTempPath)
                Else
                    File.Delete(dbLabsTempPath)
                    File.Copy(dbLabsBackup, dbLabsTempPath) 'create new
                End If
        End Select
    End Sub

    Sub SaveExam()
        'SAVES THE DATA ENTERED IF THE DATA IS VALID
        fPARENTFOLDER = txtParentFolder.Text

        'CREATE THE ICON SUBFOLDER UNDER THE PARENT FOLDER  'COPY TESTQ.EXE TO THE PARENT FOLDER
        If Not Directory.Exists(SP & fPARENTFOLDER & "\" & txtfldSubFolder.Text) Then
            Directory.CreateDirectory(SP & fPARENTFOLDER & "\" & txtfldSubFolder.Text)
        End If

        If Not File.Exists(SP & fPARENTFOLDER & "\" & "testq.exe") Then
            File.Copy(mbackupFolder & "testq.exe", SP & fPARENTFOLDER & "\testq.exe")
        End If

        txtParentFolder.Enabled = False
        txtExamName.Enabled = False

        If fISNEWTEST = True Then
            WriteExamSaveFile()
            fISNEWTEST = False '? 10/09
        End If

        'IF THE PREVIOUSLY SAVED ICON DATABASE IS FOUND FOR THE MODULE DELETE IT
        If File.Exists(SP & fPARENTFOLDER & "\icnse.mdb") Then
            File.Delete(SP & fPARENTFOLDER & "\icnse.mdb")
        End If
        'SAVE THE CURRENT MODULE DBICNSE.MDB AS ICNSE.MDB IN THE MODULE'S PARENT FOLDER
        File.Copy(dbIconsTempPath, SP & fPARENTFOLDER & "\icnse.mdb")

        mblnDirty = False
    End Sub
    Sub SaveAllData()
        'ALSO HANDLES MMUFILESAVE CLICK IF THE DATA IS VALID THE DATA IS SAVED
        txtICTITLE2.Text = txtICTITLE.Text
        txtfldSubFolder.Text = txtSubFolder1.Text & "\" & txtSubFolder2.Text & "\"
        If ValidateData(txtExamName) = False Then Exit Sub
        If ValidateData(txtICTITLE) = False Then Exit Sub
        If ValidateData(txtIconMouse) = False Then Exit Sub
        If ValidateData(txtParentFolder) = False Then Exit Sub
        If ValidateData(txtSubFolder1) = False Then Exit Sub
        If ValidateData(txtSubFolder2) = False Then Exit Sub
        If cboMaxQuestions.SelectedIndex < 0 Then cboMaxQuestions.SelectedIndex = 0
        'UPDATES THE MAXIMUM QUESTIONS IN DATABASE TO THE NUMBER OF QUESTIONS THE USER SELECTS
        txtMaxLbox.Text = ((cboMaxQuestions.SelectedIndex + 1) * 5).ToString
        UpdateTxtMTYPE()
        EditUpdate() 'UPDATE/SAVE THIS MODULE COLLECTION DATABASE
        SaveExam()
        mblnDirty = False
        SetLinkLabelText()
        If lblID.Text = "1" Then GoToIconModule(1)
        If btnCreate.Text = "Create" Then
            btnCreate.Text = "Save"
            fPARENTPATH = SP & txtParentFolder.Text
        End If
        btn1.Enabled = True '? Enable the exam 1 button after click create
    End Sub
    Sub SetButtonsGray()
        btn1.BackColor = Color.Gainsboro
        btn2.BackColor = Color.Gainsboro
        btn3.BackColor = Color.Gainsboro
        btn4.BackColor = Color.Gainsboro
        btn5.BackColor = Color.Gainsboro
        btn6.BackColor = Color.Gainsboro
    End Sub
    Sub SetLinkLabelText()
        Dim count As Integer, pField As String
        'SET THE LINKLABEL TEXT TO THE MODULENAME
        For count = 0 To 11
            pField = Me.DsIconsE1.t1.Rows(count).Item("ICTITLE").ToString
            If pField <> "" And pField.IndexOf("icon title") = -1 _
            And pField.IndexOf("Icon title") = -1 Then
                Select Case count
                    Case 0 : SetLinkLabelText(LinkLabel1, pField)
                    Case 1 : SetLinkLabelText(LinkLabel2, pField)
                    Case 2 : SetLinkLabelText(LinkLabel3, pField)
                    Case 3 : SetLinkLabelText(LinkLabel4, pField)
                    Case 4 : SetLinkLabelText(LinkLabel5, pField)
                    Case 5 : SetLinkLabelText(LinkLabel6, pField)
                    Case 6 : SetLinkLabelText(LinkLabel7, pField)
                    Case 7 : SetLinkLabelText(LinkLabel8, pField)
                    Case 8 : SetLinkLabelText(LinkLabel9, pField)
                    Case 9 : SetLinkLabelText(LinkLabel10, pField)
                    Case 10 : SetLinkLabelText(LinkLabel11, pField)
                    Case 11 : SetLinkLabelText(LinkLabel12, pField)
                End Select
            End If
        Next

    End Sub
    Sub SetFormNumber()
        fintCURRENTFORM = 5
    End Sub
    Sub SetLinkLabelText(ByVal linkl As LinkLabel, ByVal pstr As String)
        linkl.Text = pstr
    End Sub
    Sub SetTitle()
        Me.Text = Application.ProductName
    End Sub
    Sub SetTitleForNextForm()
        fIconName = txtICTITLE.Text
        Select Case fButtonClicked
            Case ""
                fTopicName = txtButton1.Text
            Case "2"
                fTopicName = txtButton2.Text
            Case "3"
                fTopicName = txtButton3.Text
            Case "4"
                fTopicName = txtButton4.Text
            Case "5"
                fTopicName = txtButton5.Text
            Case "6"
                fTopicName = txtbtnAll.Text
        End Select

        fSubFolders = "\" & fPARENTFOLDER & "\" & txtfldSubFolder.Text

    End Sub
    Sub SetUpForm()
        txtSubFolder1.Text = "exams"
        fintModule = 1
        If fISNEWTEST = False Then
            txtExamName.Text = fCollectionName
            txtExamName.Enabled = False
            txtParentFolder.Text = fPARENTFOLDER
            txtParentFolder.Enabled = False
            txtSubFolder1.Enabled = False
            mblnDirty = False
            btnCreate.Text = "Save"
        Else
            'Set default collection
            txtExamName.Text = "New Collection " & fintEXAMSELECTED
            If txtParentFolder.Text = "" Then txtParentFolder.Text = "examset" & fintEXAMSELECTED
            btnCreate.Text = "Create"
        End If
    End Sub
    Sub ShowExamForm()
        Dim FE As New frmEditExam()
        FE.Show()
    End Sub
    Sub ShowFlashForm()
        Dim FF As New frmEditor()
        FF.Show()
    End Sub
    Sub ShowLabsForm()
        Dim FL As New frmEditRouterLabs()
        FL.Show()
    End Sub
    Sub UpdateListBoxQuestions()
        'THIS WILL SET THE LISTBOX TO DISPLAY THE APPROPRIATE
        'AMOUNT OF QUESTIONS FOR THE CURRENT MODULE
        'WHEN THE CURRENT RECORD CHANGES
        Try
            If txtMaxLbox.Text <> "" And IsNumeric(txtMaxLbox.Text) Then
                cboMaxQuestions.SelectedIndex = (ToInt32(txtMaxLbox.Text) \ 5) - 1
            Else
                txtMaxLbox.Text = "5"
                cboMaxQuestions.SelectedIndex = 0
            End If
        Catch
            Exit Sub
        End Try
    End Sub
    Sub UpdateTxtMTYPE()
        If rbExam.Checked = True Then
            txtMTYPE.Text = "E"
        ElseIf rbFlashCards.Checked = True Then
            txtMTYPE.Text = "F"
        ElseIf rbLab.Checked = True Then
            txtMTYPE.Text = "L"
        End If
    End Sub
    Sub WriteExamSaveFile()
        Dim FSR As New FileStream(minstallFile, FileMode.Open, FileAccess.Read)
        Dim FSW As FileStream
        Dim m_Reader As New StreamReader(FSR)
        Dim m_Writer As StreamWriter
        Dim pLine As String
        'IF IT IS A NEW TEST SAVE IT AND IT WILL BE SAVED INTO THE SELECT A TEST
        'FORM VIA INSTALLIT.DAT WHEN THIS APPLICATION IS OPENED
        'IN ORDER TO ACCESS THIS SAVED COLLECTION IN THE FUTURE

        Try
            pLine = m_Reader.ReadLine
            m_Reader.Close()
            pLine = LCase(pLine)

            If pLine = "done,0,0" Then
                FSW = New FileStream(minstallFile, FileMode.Open, FileAccess.Write)
                m_Writer = New StreamWriter(FSW)
                m_Writer.Flush()
                m_Writer.BaseStream.Seek(0, SeekOrigin.Begin)
                m_Writer.Write("")
            Else
                FSW = New FileStream(minstallFile, FileMode.Append, FileAccess.Write)
                m_Writer = New StreamWriter(FSW)
                m_Writer.Flush()
                m_Writer.BaseStream.Seek(0, SeekOrigin.End)
            End If
            m_Writer.Write("N," & txtExamName.Text & "," & fPARENTFOLDER)
            m_Writer.Write(vbCrLf)
            m_Writer.Flush()
            m_Writer.Close()
            FSW.Close()
        Catch ex As System.IO.IOException
            MsgBox(ex.Source)
        End Try

    End Sub
    Sub WriteNewTests()
        Dim pBuildDirectory As String = mbackupFolder & fCollectionName
        Dim SW As StreamWriter = New StreamWriter(pBuildDirectory & "\" & "installit.dat")
        SW.Write("N" & "," & txtExamName.Text & "," & txtParentFolder.Text)
        SW.Write(vbCrLf)
        SW.Close()
    End Sub

#Region "Form Controls"
    Private Sub frmEditIconsE_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        CloseForm()
    End Sub
    Private Sub frmEditIconsE_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFormNumber()
        SetTitle()
        FillAndBindDataSet()
        AddQuestionsToCombo()
        SetUpForm()
        GoToIconModule(1)
    End Sub
    Private Sub frmEditIconsE_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        SetFormNumber()
        MapMtypeToCheckState()
        SetLinkLabelText()
        LookForSavedExams(fintModule)
    End Sub
    Private Sub frmEditIconsE_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        SetFormNumber()
        SetPanelBarText("" & (DsIconsE1.t1.Rows.Count), "" & Me.BindingContext(DsIconsE1, "t1").Position + 1)
        SetLinkLabelText()
    End Sub
    Private Sub mmuFileExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mmuFileExit.Click
        Me.Close()
    End Sub
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click, mmuFileSave.Click
        CreateExam()
    End Sub
    'TOPIC BUTTON CLICKS
    Private Sub btnExam1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExam1.Click
        HideAllTextBoxes()
        txtButton1.Location = New Point(120, 265)
        HighLightTopicButton(btnExam1)
    End Sub
    Private Sub btnExam2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExam2.Click
        Call HideAllTextBoxes()
        txtButton2.Location = New Point(120, 265)
        Call HighLightTopicButton(btnExam2)
    End Sub
    Private Sub btnExam3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExam3.Click
        Call HideAllTextBoxes()
        txtButton3.Location = New Point(120, 265)
        Call HighLightTopicButton(btnExam3)
    End Sub
    Private Sub btnExam4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExam4.Click
        Call HideAllTextBoxes()
        txtButton4.Location = New Point(120, 265)
        Call HighLightTopicButton(btnExam4)
    End Sub
    Private Sub btnExam5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExam5.Click
        Call HideAllTextBoxes()
        txtButton5.Location = New Point(120, 265)
        Call HighLightTopicButton(btnExam5)
    End Sub
    Private Sub btnAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAll.Click
        Call HideAllTextBoxes()
        txtbtnAll.Location = New Point(120, 265)
        Call HighLightTopicButton(btnAll)
    End Sub
    'LAUNCH EDIT BUTTON CLICKS"
    Private Sub btn1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn1.Click
        fButtonClicked = ""
        SetTitleForNextForm()
        OpenExamToEdit()
    End Sub
    Private Sub btn2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn2.Click
        fButtonClicked = "2"
        SetTitleForNextForm()
        OpenExamToEdit()
    End Sub
    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        fButtonClicked = "3"
        SetTitleForNextForm()
        OpenExamToEdit()
    End Sub
    Private Sub btn4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn4.Click
        fButtonClicked = "4"
        SetTitleForNextForm()
        OpenExamToEdit()
    End Sub
    Private Sub btn5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn5.Click
        fButtonClicked = "5"
        SetTitleForNextForm()
        OpenExamToEdit()
    End Sub
    Private Sub btn6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn6.Click
        fButtonClicked = "6"
        SetTitleForNextForm()
        OpenExamToEdit()
    End Sub
    'RADIOBUTTON EXAMTYPE CHECKEDCHANGED"
    Private Sub rbExam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbExam.CheckedChanged
        RbExamCheck()
    End Sub
    Private Sub rbFlashCards_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbFlashCards.CheckedChanged
        RbFlashCardCheck()
    End Sub
    Private Sub rbLab_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbLab.CheckedChanged
        RbLabCheck()
    End Sub
    'LINKLABEL CLICKS"
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        SaveAllData()
        HighlightLinkLabel(LinkLabel1)
        GoToIconModule(1)
        fintModule = 1
    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        SaveAllData()
        HighlightLinkLabel(LinkLabel2)
        GoToIconModule(2)
        fintModule = 2
    End Sub
    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        SaveAllData()
        HighlightLinkLabel(LinkLabel3)
        GoToIconModule(3)
        fintModule = 3
    End Sub
    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        SaveAllData()
        HighlightLinkLabel(LinkLabel4)
        GoToIconModule(4)
        fintModule = 4
    End Sub
    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        SaveAllData()
        HighlightLinkLabel(LinkLabel5)
        GoToIconModule(5)
        fintModule = 5
    End Sub
    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        SaveAllData()
        HighlightLinkLabel(LinkLabel6)
        GoToIconModule(6)
        fintModule = 6
    End Sub
    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        SaveAllData()
        HighlightLinkLabel(LinkLabel7)
        GoToIconModule(7)
        fintModule = 7
    End Sub
    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        SaveAllData()
        HighlightLinkLabel(LinkLabel8)
        GoToIconModule(8)
        fintModule = 8
    End Sub
    Private Sub LinkLabel9_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        SaveAllData()
        HighlightLinkLabel(LinkLabel9)
        GoToIconModule(9)
        fintModule = 9
    End Sub
    Private Sub LinkLabel10_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        SaveAllData()
        HighlightLinkLabel(LinkLabel10)
        GoToIconModule(10)
        fintModule = 10
    End Sub
    Private Sub LinkLabel11_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        SaveAllData()
        HighlightLinkLabel(LinkLabel11)
        GoToIconModule(11)
        fintModule = 11
    End Sub
    Private Sub LinkLabel12_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        SaveAllData()
        HighlightLinkLabel(LinkLabel12)
        GoToIconModule(12)
        fintModule = 12
    End Sub
    Private Sub txtICTITLE_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtICTITLE.Validated
        txtICTITLE2.Text = txtICTITLE.Text
        mblnDirty = True
    End Sub
    Private Sub txtICTITLE2_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtICTITLE2.Validated
        txtICTITLE.Text = txtICTITLE2.Text
        mblnDirty = True
    End Sub
    Private Sub txtButton1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtButton1.Validated
        mblnDirty = True
    End Sub
    Private Sub txtButton2_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtButton1.Validated
        mblnDirty = True
    End Sub
    Private Sub txtButton3_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtButton1.Validated
        mblnDirty = True
    End Sub
    Private Sub txtButton4_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtButton1.Validated
        mblnDirty = True
    End Sub
    Private Sub txtButton5_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtButton1.Validated
        mblnDirty = True
    End Sub
    Private Sub txtbtnAll_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtButton1.Validated
        mblnDirty = True
    End Sub
    Private Sub txtExamName_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtExamName.Validated
        mblnDirty = True
    End Sub
    Private Sub txtIconMouse_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIconMouse.Validated
        mblnDirty = True
    End Sub
    Private Sub cboMaxQuestions_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMaxQuestions.Enter
        mblnDirty = True
    End Sub
    Private Sub lblID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblID.TextChanged
        HighlightLinks()
    End Sub
    Private Sub mmuBuild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmuBuild.Click
        BuildExam()
    End Sub

#End Region

    'Private Sub frmEditIconsE_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MdiChildActivate
    '    LookForSavedExams(fintModule)
    'End Sub
End Class
