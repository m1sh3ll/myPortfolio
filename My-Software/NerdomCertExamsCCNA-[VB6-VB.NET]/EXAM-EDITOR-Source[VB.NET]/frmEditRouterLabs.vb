Option Strict On
Option Explicit On 
Imports System.IO
Imports System.Convert

Public Class frmEditRouterLabs
    Inherits System.Windows.Forms.Form

    Private mIDNum As String
    Private mblnDirty As Boolean
    Private cblnIsEditing As Boolean
    Private sp As String = Application.StartupPath & "\"
    Private dbTempPath As String = Application.StartupPath & "\dblabs.mdb"
    Private dbBackupPath As String = Application.StartupPath & "\backup\dblabs.mdb"

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.MdiParent = fParent

        Me.odbConLabs.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;" & _
                          "Data Source=" & dbTempPath & ";" & _
                                      "Mode=Share Deny None" & _
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
    Friend WithEvents odbConLabs As System.Data.OleDb.OleDbConnection
    Friend WithEvents odbDaLabs As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsLabs1 As QUEENEDIT2004.dsLabs
    Friend WithEvents txtRouterPrompt As System.Windows.Forms.TextBox
    Friend WithEvents txtRouterOutput As System.Windows.Forms.TextBox
    Friend WithEvents txtQues As System.Windows.Forms.TextBox
    Friend WithEvents txtExplanation As System.Windows.Forms.TextBox
    Friend WithEvents txtExhibit As System.Windows.Forms.TextBox
    Friend WithEvents cboQID As System.Windows.Forms.ComboBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtQID As System.Windows.Forms.TextBox
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblGoTo As System.Windows.Forms.Label
    Friend WithEvents lblIDNumber As System.Windows.Forms.Label
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents txtInputAnswer2 As System.Windows.Forms.TextBox
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblPromptExplanation As System.Windows.Forms.Label
    Friend WithEvents btnChooseImage As System.Windows.Forms.Button
    Friend WithEvents btnViewImage As System.Windows.Forms.Button
    Friend WithEvents gbExhibit As System.Windows.Forms.GroupBox
    Friend WithEvents rbNoImage As System.Windows.Forms.RadioButton
    Friend WithEvents rbYesImage As System.Windows.Forms.RadioButton
    Friend WithEvents txtInputAnswer As System.Windows.Forms.TextBox
    Friend WithEvents txtChkOrOpt As System.Windows.Forms.TextBox
    Friend WithEvents lblRouterPrompt As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnChangeAnswer As System.Windows.Forms.Button
    Friend WithEvents lblPromptPreview As System.Windows.Forms.Label
    Friend WithEvents picExhibit As System.Windows.Forms.PictureBox
    Friend WithEvents txtImageURL As System.Windows.Forms.TextBox
    Friend WithEvents lblInputAnswer As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbType As System.Windows.Forms.GroupBox
    Friend WithEvents rbUserInput As System.Windows.Forms.RadioButton
    Friend WithEvents btnExpandE As System.Windows.Forms.Button
    Friend WithEvents tmrTimer As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEditRouterLabs))
        Me.odbConLabs = New System.Data.OleDb.OleDbConnection()
        Me.odbDaLabs = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.DsLabs1 = New QUEENEDIT2004.dsLabs()
        Me.txtRouterPrompt = New System.Windows.Forms.TextBox()
        Me.txtRouterOutput = New System.Windows.Forms.TextBox()
        Me.txtQues = New System.Windows.Forms.TextBox()
        Me.txtExplanation = New System.Windows.Forms.TextBox()
        Me.txtChkOrOpt = New System.Windows.Forms.TextBox()
        Me.txtExhibit = New System.Windows.Forms.TextBox()
        Me.lblGoTo = New System.Windows.Forms.Label()
        Me.cboQID = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtQID = New System.Windows.Forms.TextBox()
        Me.lblIDNumber = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.txtInputAnswer2 = New System.Windows.Forms.TextBox()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.lblPromptExplanation = New System.Windows.Forms.Label()
        Me.btnChooseImage = New System.Windows.Forms.Button()
        Me.btnViewImage = New System.Windows.Forms.Button()
        Me.gbExhibit = New System.Windows.Forms.GroupBox()
        Me.rbNoImage = New System.Windows.Forms.RadioButton()
        Me.rbYesImage = New System.Windows.Forms.RadioButton()
        Me.txtInputAnswer = New System.Windows.Forms.TextBox()
        Me.lblRouterPrompt = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnChangeAnswer = New System.Windows.Forms.Button()
        Me.lblPromptPreview = New System.Windows.Forms.Label()
        Me.picExhibit = New System.Windows.Forms.PictureBox()
        Me.txtImageURL = New System.Windows.Forms.TextBox()
        Me.lblInputAnswer = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbType = New System.Windows.Forms.GroupBox()
        Me.rbUserInput = New System.Windows.Forms.RadioButton()
        Me.btnExpandE = New System.Windows.Forms.Button()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DsLabs1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbExhibit.SuspendLayout()
        Me.gbType.SuspendLayout()
        Me.SuspendLayout()
        '
        'odbConLabs
        '
        Me.odbConLabs.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=H:\QUEENED" & _
        "IT2004\bin\dblabs.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:Syst" & _
        "em database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLE" & _
        "DB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk" & _
        " Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";J" & _
        "et OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB" & _
        ":Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=Fal" & _
        "se;Jet OLEDB:SFP=False"
        '
        'odbDaLabs
        '
        Me.odbDaLabs.DeleteCommand = Me.OleDbDeleteCommand1
        Me.odbDaLabs.InsertCommand = Me.OleDbInsertCommand1
        Me.odbDaLabs.SelectCommand = Me.OleDbSelectCommand1
        Me.odbDaLabs.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Q1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("QID", "QID"), New System.Data.Common.DataColumnMapping("Ques", "Ques"), New System.Data.Common.DataColumnMapping("chkoropt", "chkoropt"), New System.Data.Common.DataColumnMapping("Exhibit", "Exhibit"), New System.Data.Common.DataColumnMapping("ExhibitName", "ExhibitName"), New System.Data.Common.DataColumnMapping("Explanation", "Explanation"), New System.Data.Common.DataColumnMapping("InputAnswer", "InputAnswer"), New System.Data.Common.DataColumnMapping("InputAnswer2", "InputAnswer2"), New System.Data.Common.DataColumnMapping("RouterOutput", "RouterOutput"), New System.Data.Common.DataColumnMapping("RouterPrompt", "RouterPrompt")})})
        Me.odbDaLabs.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Q1 WHERE (QID = ?) AND (Exhibit = ? OR ? IS NULL AND Exhibit IS NULL)" & _
        " AND (ExhibitName = ? OR ? IS NULL AND ExhibitName IS NULL) AND (Explanation = ?" & _
        " OR ? IS NULL AND Explanation IS NULL) AND (InputAnswer = ? OR ? IS NULL AND Inp" & _
        "utAnswer IS NULL) AND (InputAnswer2 = ? OR ? IS NULL AND InputAnswer2 IS NULL) A" & _
        "ND (Ques = ? OR ? IS NULL AND Ques IS NULL) AND (RouterOutput = ? OR ? IS NULL A" & _
        "ND RouterOutput IS NULL) AND (RouterPrompt = ? OR ? IS NULL AND RouterPrompt IS " & _
        "NULL) AND (chkoropt = ? OR ? IS NULL AND chkoropt IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.odbConLabs
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_QID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "QID", System.Data.DataRowVersion.Original, Nothing))
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
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RouterOutput", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RouterOutput", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RouterOutput1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RouterOutput", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RouterPrompt", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RouterPrompt", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RouterPrompt1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RouterPrompt", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_chkoropt", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "chkoropt", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_chkoropt1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "chkoropt", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Q1(QID, Ques, chkoropt, Exhibit, ExhibitName, Explanation, InputAnswe" & _
        "r, InputAnswer2, RouterOutput, RouterPrompt) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, " & _
        "?)"
        Me.OleDbInsertCommand1.Connection = Me.odbConLabs
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("QID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "QID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ques", System.Data.OleDb.OleDbType.VarWChar, 0, "Ques"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("chkoropt", System.Data.OleDb.OleDbType.VarWChar, 3, "chkoropt"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Exhibit", System.Data.OleDb.OleDbType.VarWChar, 3, "Exhibit"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ExhibitName", System.Data.OleDb.OleDbType.VarWChar, 100, "ExhibitName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Explanation", System.Data.OleDb.OleDbType.VarWChar, 0, "Explanation"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("InputAnswer", System.Data.OleDb.OleDbType.VarWChar, 255, "InputAnswer"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("InputAnswer2", System.Data.OleDb.OleDbType.VarWChar, 255, "InputAnswer2"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RouterOutput", System.Data.OleDb.OleDbType.VarWChar, 0, "RouterOutput"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RouterPrompt", System.Data.OleDb.OleDbType.VarWChar, 150, "RouterPrompt"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT QID, Ques, chkoropt, Exhibit, ExhibitName, Explanation, InputAnswer, Input" & _
        "Answer2, RouterOutput, RouterPrompt FROM Q1"
        Me.OleDbSelectCommand1.Connection = Me.odbConLabs
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Q1 SET QID = ?, Ques = ?, chkoropt = ?, Exhibit = ?, ExhibitName = ?, Expl" & _
        "anation = ?, InputAnswer = ?, InputAnswer2 = ?, RouterOutput = ?, RouterPrompt =" & _
        " ? WHERE (QID = ?) AND (Exhibit = ? OR ? IS NULL AND Exhibit IS NULL) AND (Exhib" & _
        "itName = ? OR ? IS NULL AND ExhibitName IS NULL) AND (Explanation = ? OR ? IS NU" & _
        "LL AND Explanation IS NULL) AND (InputAnswer = ? OR ? IS NULL AND InputAnswer IS" & _
        " NULL) AND (InputAnswer2 = ? OR ? IS NULL AND InputAnswer2 IS NULL) AND (Ques = " & _
        "? OR ? IS NULL AND Ques IS NULL) AND (RouterOutput = ? OR ? IS NULL AND RouterOu" & _
        "tput IS NULL) AND (RouterPrompt = ? OR ? IS NULL AND RouterPrompt IS NULL) AND (" & _
        "chkoropt = ? OR ? IS NULL AND chkoropt IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.odbConLabs
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("QID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "QID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ques", System.Data.OleDb.OleDbType.VarWChar, 0, "Ques"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("chkoropt", System.Data.OleDb.OleDbType.VarWChar, 3, "chkoropt"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Exhibit", System.Data.OleDb.OleDbType.VarWChar, 3, "Exhibit"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ExhibitName", System.Data.OleDb.OleDbType.VarWChar, 100, "ExhibitName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Explanation", System.Data.OleDb.OleDbType.VarWChar, 0, "Explanation"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("InputAnswer", System.Data.OleDb.OleDbType.VarWChar, 255, "InputAnswer"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("InputAnswer2", System.Data.OleDb.OleDbType.VarWChar, 255, "InputAnswer2"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RouterOutput", System.Data.OleDb.OleDbType.VarWChar, 0, "RouterOutput"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RouterPrompt", System.Data.OleDb.OleDbType.VarWChar, 150, "RouterPrompt"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_QID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "QID", System.Data.DataRowVersion.Original, Nothing))
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
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RouterOutput", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RouterOutput", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RouterOutput1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RouterOutput", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RouterPrompt", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RouterPrompt", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RouterPrompt1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RouterPrompt", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_chkoropt", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "chkoropt", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_chkoropt1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "chkoropt", System.Data.DataRowVersion.Original, Nothing))
        '
        'DsLabs1
        '
        Me.DsLabs1.DataSetName = "dsLabs"
        Me.DsLabs1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsLabs1.Namespace = "http://www.tempuri.org/dsLabs.xsd"
        '
        'txtRouterPrompt
        '
        Me.txtRouterPrompt.BackColor = System.Drawing.SystemColors.Window
        Me.txtRouterPrompt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRouterPrompt.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtRouterPrompt.Location = New System.Drawing.Point(100, 150)
        Me.txtRouterPrompt.MaxLength = 150
        Me.txtRouterPrompt.Name = "txtRouterPrompt"
        Me.txtRouterPrompt.Size = New System.Drawing.Size(200, 22)
        Me.txtRouterPrompt.TabIndex = 3
        Me.txtRouterPrompt.Text = ""
        '
        'txtRouterOutput
        '
        Me.txtRouterOutput.BackColor = System.Drawing.Color.White
        Me.txtRouterOutput.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRouterOutput.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtRouterOutput.Location = New System.Drawing.Point(100, 200)
        Me.txtRouterOutput.Multiline = True
        Me.txtRouterOutput.Name = "txtRouterOutput"
        Me.txtRouterOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRouterOutput.Size = New System.Drawing.Size(510, 225)
        Me.txtRouterOutput.TabIndex = 6
        Me.txtRouterOutput.Text = ""
        '
        'txtQues
        '
        Me.txtQues.BackColor = System.Drawing.Color.White
        Me.txtQues.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQues.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtQues.Location = New System.Drawing.Point(100, 65)
        Me.txtQues.Multiline = True
        Me.txtQues.Name = "txtQues"
        Me.txtQues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtQues.Size = New System.Drawing.Size(510, 80)
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
        Me.txtExplanation.TabIndex = 7
        Me.txtExplanation.Text = ""
        '
        'txtChkOrOpt
        '
        Me.txtChkOrOpt.Location = New System.Drawing.Point(25, 25)
        Me.txtChkOrOpt.Name = "txtChkOrOpt"
        Me.txtChkOrOpt.Size = New System.Drawing.Size(50, 20)
        Me.txtChkOrOpt.TabIndex = 35
        Me.txtChkOrOpt.Text = ""
        '
        'txtExhibit
        '
        Me.txtExhibit.BackColor = System.Drawing.SystemColors.Window
        Me.txtExhibit.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExhibit.Location = New System.Drawing.Point(115, 0)
        Me.txtExhibit.MaxLength = 3
        Me.txtExhibit.Name = "txtExhibit"
        Me.txtExhibit.Size = New System.Drawing.Size(65, 23)
        Me.txtExhibit.TabIndex = 28
        Me.txtExhibit.Text = ""
        '
        'lblGoTo
        '
        Me.lblGoTo.BackColor = System.Drawing.Color.Transparent
        Me.lblGoTo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoTo.ForeColor = System.Drawing.Color.Black
        Me.lblGoTo.Name = "lblGoTo"
        Me.lblGoTo.Size = New System.Drawing.Size(95, 25)
        Me.lblGoTo.TabIndex = 23
        Me.lblGoTo.Text = "Go To #:"
        Me.lblGoTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Navy
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(190, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(605, 30)
        Me.lblTitle.TabIndex = 34
        Me.lblTitle.Text = "Exam Editor: Editing dbexam.mdb - Table Q1"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        'lblIDNumber
        '
        Me.lblIDNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblIDNumber.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDNumber.ForeColor = System.Drawing.Color.Black
        Me.lblIDNumber.Location = New System.Drawing.Point(10, 25)
        Me.lblIDNumber.Name = "lblIDNumber"
        Me.lblIDNumber.Size = New System.Drawing.Size(90, 40)
        Me.lblIDNumber.TabIndex = 24
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
        Me.lblQuestion.TabIndex = 25
        Me.lblQuestion.Text = "Question:"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInputAnswer2
        '
        Me.txtInputAnswer2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputAnswer2.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtInputAnswer2.Location = New System.Drawing.Point(400, 175)
        Me.txtInputAnswer2.MaxLength = 255
        Me.txtInputAnswer2.Name = "txtInputAnswer2"
        Me.txtInputAnswer2.Size = New System.Drawing.Size(210, 22)
        Me.txtInputAnswer2.TabIndex = 5
        Me.txtInputAnswer2.Text = ""
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.Location = New System.Drawing.Point(620, 465)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(105, 30)
        Me.btnPreview.TabIndex = 16
        Me.btnPreview.Text = "P&review Exam"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(620, 430)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 30)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "&Save Exam"
        '
        'ofdOpenFile
        '
        '
        'lblPromptExplanation
        '
        Me.lblPromptExplanation.BackColor = System.Drawing.Color.Transparent
        Me.lblPromptExplanation.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptExplanation.ForeColor = System.Drawing.Color.Black
        Me.lblPromptExplanation.Location = New System.Drawing.Point(5, 435)
        Me.lblPromptExplanation.Name = "lblPromptExplanation"
        Me.lblPromptExplanation.Size = New System.Drawing.Size(95, 25)
        Me.lblPromptExplanation.TabIndex = 28
        Me.lblPromptExplanation.Text = "Explanation:"
        Me.lblPromptExplanation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnChooseImage
        '
        Me.btnChooseImage.BackColor = System.Drawing.Color.SteelBlue
        Me.btnChooseImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseImage.Location = New System.Drawing.Point(680, 40)
        Me.btnChooseImage.Name = "btnChooseImage"
        Me.btnChooseImage.Size = New System.Drawing.Size(110, 25)
        Me.btnChooseImage.TabIndex = 9
        Me.btnChooseImage.Text = "Choose &Image .."
        '
        'btnViewImage
        '
        Me.btnViewImage.BackColor = System.Drawing.Color.SteelBlue
        Me.btnViewImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewImage.Location = New System.Drawing.Point(680, 70)
        Me.btnViewImage.Name = "btnViewImage"
        Me.btnViewImage.Size = New System.Drawing.Size(110, 25)
        Me.btnViewImage.TabIndex = 10
        Me.btnViewImage.Text = "Pre&view Image .."
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
        Me.gbExhibit.TabIndex = 8
        Me.gbExhibit.TabStop = False
        Me.gbExhibit.Text = "Exhibit"
        '
        'rbNoImage
        '
        Me.rbNoImage.Checked = True
        Me.rbNoImage.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNoImage.Location = New System.Drawing.Point(10, 40)
        Me.rbNoImage.Name = "rbNoImage"
        Me.rbNoImage.Size = New System.Drawing.Size(45, 20)
        Me.rbNoImage.TabIndex = 28
        Me.rbNoImage.TabStop = True
        Me.rbNoImage.Text = "No"
        '
        'rbYesImage
        '
        Me.rbYesImage.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbYesImage.Location = New System.Drawing.Point(10, 20)
        Me.rbYesImage.Name = "rbYesImage"
        Me.rbYesImage.Size = New System.Drawing.Size(45, 20)
        Me.rbYesImage.TabIndex = 29
        Me.rbYesImage.Text = "Yes"
        '
        'txtInputAnswer
        '
        Me.txtInputAnswer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputAnswer.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtInputAnswer.Location = New System.Drawing.Point(400, 150)
        Me.txtInputAnswer.MaxLength = 255
        Me.txtInputAnswer.Name = "txtInputAnswer"
        Me.txtInputAnswer.Size = New System.Drawing.Size(210, 22)
        Me.txtInputAnswer.TabIndex = 4
        Me.txtInputAnswer.Text = ""
        '
        'lblRouterPrompt
        '
        Me.lblRouterPrompt.BackColor = System.Drawing.Color.Transparent
        Me.lblRouterPrompt.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRouterPrompt.ForeColor = System.Drawing.Color.Black
        Me.lblRouterPrompt.Location = New System.Drawing.Point(10, 150)
        Me.lblRouterPrompt.Name = "lblRouterPrompt"
        Me.lblRouterPrompt.Size = New System.Drawing.Size(90, 30)
        Me.lblRouterPrompt.TabIndex = 26
        Me.lblRouterPrompt.Text = "Prompt:"
        Me.lblRouterPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(730, 430)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(60, 30)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(730, 360)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(60, 30)
        Me.btnNext.TabIndex = 19
        Me.btnNext.Text = "&Next"
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.SteelBlue
        Me.btnLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(730, 395)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(60, 30)
        Me.btnLast.TabIndex = 20
        Me.btnLast.Text = "&Last"
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.SteelBlue
        Me.btnFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.Location = New System.Drawing.Point(730, 290)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(60, 30)
        Me.btnFirst.TabIndex = 17
        Me.btnFirst.Text = "&First"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(730, 325)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(60, 30)
        Me.btnPrevious.TabIndex = 18
        Me.btnPrevious.Text = "&Previous"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(730, 465)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(60, 30)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "&Close"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.OrangeRed
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(620, 325)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 30)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "&Delete Question"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Yellow
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(620, 290)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(105, 30)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "&Add Question"
        '
        'btnChangeAnswer
        '
        Me.btnChangeAnswer.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
        Me.btnChangeAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeAnswer.Location = New System.Drawing.Point(620, 360)
        Me.btnChangeAnswer.Name = "btnChangeAnswer"
        Me.btnChangeAnswer.Size = New System.Drawing.Size(105, 30)
        Me.btnChangeAnswer.TabIndex = 13
        Me.btnChangeAnswer.Text = "C&hange"
        '
        'lblPromptPreview
        '
        Me.lblPromptPreview.BackColor = System.Drawing.Color.Transparent
        Me.lblPromptPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPromptPreview.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptPreview.ForeColor = System.Drawing.Color.Black
        Me.lblPromptPreview.Location = New System.Drawing.Point(615, 100)
        Me.lblPromptPreview.Name = "lblPromptPreview"
        Me.lblPromptPreview.Size = New System.Drawing.Size(175, 25)
        Me.lblPromptPreview.TabIndex = 32
        Me.lblPromptPreview.Text = "Exhibit Preview:"
        Me.lblPromptPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picExhibit
        '
        Me.picExhibit.BackColor = System.Drawing.Color.White
        Me.picExhibit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picExhibit.Location = New System.Drawing.Point(615, 145)
        Me.picExhibit.Name = "picExhibit"
        Me.picExhibit.Size = New System.Drawing.Size(175, 140)
        Me.picExhibit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExhibit.TabIndex = 134
        Me.picExhibit.TabStop = False
        '
        'txtImageURL
        '
        Me.txtImageURL.BackColor = System.Drawing.Color.LightGray
        Me.txtImageURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImageURL.Enabled = False
        Me.txtImageURL.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageURL.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtImageURL.Location = New System.Drawing.Point(615, 125)
        Me.txtImageURL.MaxLength = 100
        Me.txtImageURL.Multiline = True
        Me.txtImageURL.Name = "txtImageURL"
        Me.txtImageURL.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtImageURL.Size = New System.Drawing.Size(175, 20)
        Me.txtImageURL.TabIndex = 33
        Me.txtImageURL.Text = ""
        '
        'lblInputAnswer
        '
        Me.lblInputAnswer.BackColor = System.Drawing.Color.Transparent
        Me.lblInputAnswer.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputAnswer.ForeColor = System.Drawing.Color.Black
        Me.lblInputAnswer.Location = New System.Drawing.Point(280, 150)
        Me.lblInputAnswer.Name = "lblInputAnswer"
        Me.lblInputAnswer.Size = New System.Drawing.Size(120, 25)
        Me.lblInputAnswer.TabIndex = 30
        Me.lblInputAnswer.Text = "Input Answers:"
        Me.lblInputAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 25)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Output:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbType
        '
        Me.gbType.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbType.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbUserInput})
        Me.gbType.Enabled = False
        Me.gbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbType.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbType.Location = New System.Drawing.Point(191, 30)
        Me.gbType.Name = "gbType"
        Me.gbType.Size = New System.Drawing.Size(124, 35)
        Me.gbType.TabIndex = 31
        Me.gbType.TabStop = False
        Me.gbType.Text = "Question Type"
        '
        'rbUserInput
        '
        Me.rbUserInput.Checked = True
        Me.rbUserInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbUserInput.Location = New System.Drawing.Point(10, 15)
        Me.rbUserInput.Name = "rbUserInput"
        Me.rbUserInput.Size = New System.Drawing.Size(60, 15)
        Me.rbUserInput.TabIndex = 0
        Me.rbUserInput.TabStop = True
        Me.rbUserInput.Text = "Input"
        '
        'btnExpandE
        '
        Me.btnExpandE.Location = New System.Drawing.Point(65, 485)
        Me.btnExpandE.Name = "btnExpandE"
        Me.btnExpandE.Size = New System.Drawing.Size(30, 20)
        Me.btnExpandE.TabIndex = 29
        Me.btnExpandE.Text = "+ -"
        Me.ToolTip1.SetToolTip(Me.btnExpandE, "Expand/Shrink Explanation Box")
        '
        'tmrTimer
        '
        Me.tmrTimer.Interval = 2000
        '
        'frmEditRouterLabs
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(792, 512)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtExplanation, Me.btnExpandE, Me.gbType, Me.Label1, Me.lblPromptPreview, Me.picExhibit, Me.txtImageURL, Me.btnDelete, Me.btnAdd, Me.btnChangeAnswer, Me.btnCancel, Me.btnNext, Me.btnLast, Me.btnFirst, Me.btnPrevious, Me.btnClose, Me.lblRouterPrompt, Me.gbExhibit, Me.btnViewImage, Me.btnChooseImage, Me.lblPromptExplanation, Me.btnSave, Me.btnPreview, Me.lblQuestion, Me.lblIDNumber, Me.txtQID, Me.lblTitle, Me.cboQID, Me.lblGoTo, Me.txtExhibit, Me.txtChkOrOpt, Me.txtQues, Me.txtRouterOutput, Me.txtInputAnswer, Me.txtInputAnswer2, Me.txtRouterPrompt, Me.lblInputAnswer})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(790, 537)
        Me.Name = "frmEditRouterLabs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TestQueen Command Line Lab Editor"
        CType(Me.DsLabs1, System.ComponentModel.ISupportInitialize).EndInit()
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
                SaveDataFile()
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
        Dim mr As MsgBoxResult = MsgBox("You may have changed the exam type from 'Practice Exams' or 'Flashcards' to " _
        & "'Labs'. Click OK to overwrite the old exam for this module with a new exam. Click " _
        & "Cancel to go back to the module editor. Navigate to the module folder " _
        & "on your hard drive and copy it to another directory as a backup or change it back to the previous " _
        & "Exam Type: 'Practice Exams' or 'Flashcards'", MsgBoxStyle.OKCancel, "Confirm Exam Overwrite")

        Return mr
    End Function
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

    Friend Sub AddNewQuesID()
        Dim pLast As Integer, pNew As Integer
        Try
            pLast = Me.DsLabs1.Q1.Rows.Count - 1
            If pLast > -1 Then
                pNew = ToInt32(Me.DsLabs1.Q1.Rows(pLast).Item("QID"))
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
        Me.BindingContext(DsLabs1, "Q1").Position = cboQID.SelectedIndex
        fParent.pnlCurrentRecord.Text = "Current = " & Me.BindingContext(DsLabs1, "Q1").Position + 1
    End Sub
    Friend Sub CheckType2() 'Check Exhibit Type
        If txtExhibit.Text = "1" Then
            rbYesImage.Checked = True
        End If
        If txtExhibit.Text = "0" Then
            rbNoImage.Checked = True
        End If
    End Sub
    Friend Sub RefreshCombos2()
        cboQID.Items.Clear()
        odbDaLabs.Fill(DsLabs1)
        AddQuestionsCombo()
    End Sub
    Friend Sub SaveDataFile()
        Dim pintRecords As Integer = Me.DsLabs1.Q1.Rows.Count - 1
        Dim RowNum As Integer

        For RowNum = 0 To pintRecords
            If Me.DsLabs1.Q1.Rows(RowNum).Item("chkoropt").ToString = "" Then
                Me.DsLabs1.Q1.Rows(RowNum).Item("chkoropt") = "i"
            End If
        Next

        For RowNum = 0 To pintRecords
            If Me.DsLabs1.Q1.Rows(RowNum).Item("Exhibit").ToString = "1" Then
                If Me.DsLabs1.Q1.Rows(RowNum).Item("ExhibitName").ToString = "" Then
                    mIDNum = Me.DsLabs1.Q1.Rows(RowNum).Item("QID").ToString
                    MsgBoxJ()
                    Exit Sub
                End If

                If Me.DsLabs1.Q1.Rows(RowNum).Item("ExhibitName").ToString.IndexOf(".") = -1 Then
                    mIDNum = Me.DsLabs1.Q1.Rows(RowNum).Item("QID").ToString
                    MsgBoxK()
                    Exit Sub
                End If
            End If
        Next
        CopyTempFileToSaved()

    End Sub
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
    Sub BindData(ByVal txtBox As TextBox, ByVal strS As String)
        Dim pb As Binding = New Binding("Text", DsLabs1, strS)
        txtBox.DataBindings.Add(pb)
    End Sub
    Sub AddQuestionsCombo()
        Dim count As Integer
        For count = 0 To Me.DsLabs1.Q1.Rows.Count - 1
            cboQID.Items.Add(Me.DsLabs1.Q1.Rows(count).Item("QID"))
        Next
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
                Call SaveDataFile()
            End If
        End If

        odbConLabs.Close()
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
    '    txtExplanation.Enabled = cblnIsEditing
    '    gbExhibit.Enabled = cblnIsEditing
    '    txtInputAnswer.Enabled = cblnIsEditing
    '    txtInputAnswer2.Enabled = cblnIsEditing

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
        txtRouterOutput.Enabled = cblnIsEditing '
        txtRouterPrompt.Enabled = cblnIsEditing '
        txtExplanation.Enabled = cblnIsEditing
        gbExhibit.Enabled = cblnIsEditing
        txtInputAnswer.Enabled = cblnIsEditing
        txtInputAnswer2.Enabled = cblnIsEditing
    End Sub
    Sub ExhibitChanged()
        If txtExhibit.Text = "1" Then SetExhibitControls(True)
        If txtExhibit.Text = "" Or txtExhibit.Text = "0" Then SetExhibitControls(False)
        LoadExhibit(fFULLMODULEPATH & txtImageURL.Text)
    End Sub
    Sub ExpandExplanationBox()
        Dim currentSize As Size = New Size(510, 75)
        Dim currentLocation As Point = New Point(100, 430)
        Dim lgSize As Size = New Size(510, 440)
        Dim lgLocation As Point = New Point(100, 68)

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
    Sub FillAndBindDataSet()
        Try
            odbDaLabs.Fill(DsLabs1)
        Catch
            Dim pmsg As MsgBoxResult = MsgBoxL()
            If pmsg = MsgBoxResult.OK Then
                RepairExamDatabase()
                odbDaLabs.Fill(DsLabs1)
            Else
                mblnDirty = False
                Try
                    Me.Close()
                Catch
                    tmrTimer.Enabled = True
                    Exit Sub
                End Try
            End If
        End Try
        BindData(txtQID, "Q1.QID")
        BindData(txtQues, "Q1.Ques")
        BindData(txtChkOrOpt, "Q1.chkoropt")
        BindData(txtExplanation, "Q1.Explanation")
        BindData(txtInputAnswer, "Q1.InputAnswer")
        BindData(txtInputAnswer2, "Q1.InputAnswer2")
        BindData(txtRouterPrompt, "Q1.RouterPrompt")
        BindData(txtRouterOutput, "Q1.RouterOutput")
        BindData(txtExhibit, "Q1.Exhibit")
        BindData(txtImageURL, "Q1.ExhibitName")
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
            txtExhibit.Text = "0"
            txtImageURL.Text = ""
        End If
    End Sub
    Sub OpenTestQExe()
        Call Navigate(fPARENTPATH & "testq.exe")
    End Sub
    Sub PreviewExam()
        If mblnDirty = True Then MsgBoxB() '? prompt to save
        Dim Count As Integer = Me.DsLabs1.Q1.Rows.Count
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
    Sub RepairExamDatabase()
        If File.Exists(dbTempPath) Then
            File.Delete(dbTempPath)
        End If

        File.Copy(dbBackupPath, dbTempPath)
    End Sub
    Sub SaveFileAndUpdate()
        If ImageUrlOK() = True Then
            Call EditUpdate()
            Call SaveDataFile()
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
        fintCURRENTFORM = 4
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
            txtExhibit.Text = "1"
        End If
    End Sub

#Region "Form Controls"


    Private Sub frmEditRouterLabs_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        CloseForm()
    End Sub
    Private Sub frmEditRouterLabs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SetFormNumber()
        Me.SetTitle()
        Me.FillAndBindDataSet()
        Me.AddQuestionsCombo()
        Me.EnableDisableButtons()
    End Sub
    Private Sub frmEditRouterLabs_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        SetFormNumber()
    End Sub
    Private Sub frmEditRouterLabs_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        SetFormNumber()
        SetPanelBarText("" & (DsLabs1.Q1.Rows.Count), "" & Me.BindingContext(DsLabs1, "Q1").Position + 1)
    End Sub
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        AddNewQuestion()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        CancelEditing()
    End Sub
    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Call EditDelete()
    End Sub
    Private Sub btnChangeAnswer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChangeAnswer.Click
        ChangeAnswer()
    End Sub
    Private Sub btnChooseImage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChooseImage.Click
        SetAndOpenFileDialog()
    End Sub
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        NavigateFirst()
    End Sub
    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLast.Click
        NavigateLast()
    End Sub
    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click
        NavigateNext()
    End Sub
    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        NavigatePrevious()
    End Sub
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        PreviewExam()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveFileAndUpdate()
    End Sub

    Private Sub btnViewImage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnViewImage.Click
        SetImageForm()
    End Sub
    Private Sub ofdOpenFile_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ofdOpenFile.FileOk
        SetUpImageFile()
    End Sub
    Private Sub rbYesImage_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbYesImage.CheckedChanged
        YesImageCheck()
    End Sub
    Private Sub rbNoImage_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbNoImage.CheckedChanged
        NoImageCheck()
    End Sub
    Private Sub cboQID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboQID.SelectedIndexChanged
        ChangeSelectedPosition()
    End Sub
    Private Sub txtExhibit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtExhibit.TextChanged
        ExhibitChanged()
    End Sub

    Private Sub txtQID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQID.TextChanged
        CheckType2()
    End Sub

    Private Sub txtImageURL_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImageURL.TextChanged
        ImageURLChanged()
    End Sub


#End Region



    Private Sub tmrTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimer.Tick
        Me.Close()
    End Sub

    Private Sub btnExpandE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpandE.Click
        ExpandExplanationBox()
    End Sub
End Class
