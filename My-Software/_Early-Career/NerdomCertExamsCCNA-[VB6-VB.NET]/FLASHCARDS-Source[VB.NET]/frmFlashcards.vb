Imports System.Convert
Imports System.IO

Public Class frmFlashcards
    Inherits System.Windows.Forms.Form
    Private M_DATABASETOOPEN As String
    Private mblnAnswerVisible As Boolean

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        M_DATABASETOOPEN = GETDATABASE6()

        Me.odbConFlash2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;" & _
                   "Data Source=" & Application.StartupPath & M_DATABASETOOPEN & _
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

    Friend WithEvents btnViewImage As System.Windows.Forms.Button
    Friend WithEvents cboQID As System.Windows.Forms.ComboBox
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents txtYourAnswer As System.Windows.Forms.TextBox
    Friend WithEvents btnGradeMe As System.Windows.Forms.Button
    Friend WithEvents chkStrictAnswers As System.Windows.Forms.CheckBox
    Friend WithEvents lblCorrectIncorrect As System.Windows.Forms.Label
    Friend WithEvents btnShowAnswer As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblSkipToQuestion As System.Windows.Forms.Label
    Friend WithEvents pnlQuestion As System.Windows.Forms.Panel
    Friend WithEvents pnlAnswer As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFlashCardNum As System.Windows.Forms.Label
    Friend WithEvents lblQuesBG As System.Windows.Forms.Label
    Friend WithEvents lblYourAnswerBG As System.Windows.Forms.Label
    Friend WithEvents lblAnswerBG As System.Windows.Forms.Label
    Friend WithEvents lblAnswerPrompt As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents tmrCorrectInc As System.Windows.Forms.Timer
    Friend WithEvents txtImageURL As System.Windows.Forms.TextBox
    Friend WithEvents lblQuestion As System.Windows.Forms.TextBox
    Friend WithEvents odbConFlash2 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents odbDaFlash2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DsFlash21 As QUEENFLASH2004.dsFlash2
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFlashcards))
        Me.btnViewImage = New System.Windows.Forms.Button()
        Me.cboQID = New System.Windows.Forms.ComboBox()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.txtYourAnswer = New System.Windows.Forms.TextBox()
        Me.btnGradeMe = New System.Windows.Forms.Button()
        Me.chkStrictAnswers = New System.Windows.Forms.CheckBox()
        Me.lblCorrectIncorrect = New System.Windows.Forms.Label()
        Me.btnShowAnswer = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblSkipToQuestion = New System.Windows.Forms.Label()
        Me.pnlQuestion = New System.Windows.Forms.Panel()
        Me.lblQuestion = New System.Windows.Forms.TextBox()
        Me.pnlAnswer = New System.Windows.Forms.Panel()
        Me.lblAnswer = New System.Windows.Forms.TextBox()
        Me.lblAnswerBG = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFlashCardNum = New System.Windows.Forms.Label()
        Me.lblQuesBG = New System.Windows.Forms.Label()
        Me.lblYourAnswerBG = New System.Windows.Forms.Label()
        Me.lblAnswerPrompt = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tmrCorrectInc = New System.Windows.Forms.Timer(Me.components)
        Me.txtImageURL = New System.Windows.Forms.TextBox()
        Me.odbConFlash2 = New System.Data.OleDb.OleDbConnection()
        Me.odbDaFlash2 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.DsFlash21 = New QUEENFLASH2004.dsFlash2()
        Me.pnlAnswer.SuspendLayout()
        CType(Me.DsFlash21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnViewImage
        '
        Me.btnViewImage.BackColor = System.Drawing.Color.OrangeRed
        Me.btnViewImage.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewImage.Location = New System.Drawing.Point(110, 266)
        Me.btnViewImage.Name = "btnViewImage"
        Me.btnViewImage.Size = New System.Drawing.Size(100, 30)
        Me.btnViewImage.TabIndex = 46
        Me.btnViewImage.Text = "Exhibit"
        Me.btnViewImage.UseVisualStyleBackColor = False
        Me.btnViewImage.Visible = False
        '
        'cboQID
        '
        Me.cboQID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboQID.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQID.Location = New System.Drawing.Point(490, 5)
        Me.cboQID.Name = "cboQID"
        Me.cboQID.Size = New System.Drawing.Size(130, 24)
        Me.cboQID.TabIndex = 39
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.SteelBlue
        Me.btnLast.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(530, 232)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(90, 30)
        Me.btnLast.TabIndex = 33
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPrevious.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(5, 232)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(101, 30)
        Me.btnPrevious.TabIndex = 29
        Me.btnPrevious.Text = "&Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNext.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(110, 232)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(100, 30)
        Me.btnNext.TabIndex = 32
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.SteelBlue
        Me.btnFirst.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.Location = New System.Drawing.Point(434, 232)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(90, 30)
        Me.btnFirst.TabIndex = 28
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = False
        '
        'txtYourAnswer
        '
        Me.txtYourAnswer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtYourAnswer.BackColor = System.Drawing.Color.White
        Me.txtYourAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYourAnswer.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYourAnswer.Location = New System.Drawing.Point(10, 184)
        Me.txtYourAnswer.Name = "txtYourAnswer"
        Me.txtYourAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtYourAnswer.Size = New System.Drawing.Size(605, 25)
        Me.txtYourAnswer.TabIndex = 27
        '
        'btnGradeMe
        '
        Me.btnGradeMe.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnGradeMe.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGradeMe.Location = New System.Drawing.Point(238, 232)
        Me.btnGradeMe.Name = "btnGradeMe"
        Me.btnGradeMe.Size = New System.Drawing.Size(156, 30)
        Me.btnGradeMe.TabIndex = 55
        Me.btnGradeMe.Text = "Submit"
        Me.btnGradeMe.UseVisualStyleBackColor = False
        '
        'chkStrictAnswers
        '
        Me.chkStrictAnswers.BackColor = System.Drawing.Color.Transparent
        Me.chkStrictAnswers.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkStrictAnswers.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkStrictAnswers.Location = New System.Drawing.Point(250, 276)
        Me.chkStrictAnswers.Name = "chkStrictAnswers"
        Me.chkStrictAnswers.Size = New System.Drawing.Size(125, 25)
        Me.chkStrictAnswers.TabIndex = 58
        Me.chkStrictAnswers.Text = "Novice Level"
        Me.ToolTip1.SetToolTip(Me.chkStrictAnswers, "User must type whole answer word for word")
        Me.chkStrictAnswers.UseVisualStyleBackColor = False
        '
        'lblCorrectIncorrect
        '
        Me.lblCorrectIncorrect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCorrectIncorrect.BackColor = System.Drawing.Color.White
        Me.lblCorrectIncorrect.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectIncorrect.ForeColor = System.Drawing.Color.Red
        Me.lblCorrectIncorrect.Location = New System.Drawing.Point(225, 5)
        Me.lblCorrectIncorrect.Name = "lblCorrectIncorrect"
        Me.lblCorrectIncorrect.Size = New System.Drawing.Size(180, 22)
        Me.lblCorrectIncorrect.TabIndex = 59
        Me.lblCorrectIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCorrectIncorrect.Visible = False
        '
        'btnShowAnswer
        '
        Me.btnShowAnswer.BackColor = System.Drawing.Color.Yellow
        Me.btnShowAnswer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAnswer.Location = New System.Drawing.Point(5, 266)
        Me.btnShowAnswer.Name = "btnShowAnswer"
        Me.btnShowAnswer.Size = New System.Drawing.Size(101, 30)
        Me.btnShowAnswer.TabIndex = 62
        Me.btnShowAnswer.Text = "Answer"
        Me.btnShowAnswer.UseVisualStyleBackColor = False
        '
        'lblSkipToQuestion
        '
        Me.lblSkipToQuestion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSkipToQuestion.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSkipToQuestion.Location = New System.Drawing.Point(415, 10)
        Me.lblSkipToQuestion.Name = "lblSkipToQuestion"
        Me.lblSkipToQuestion.Size = New System.Drawing.Size(75, 17)
        Me.lblSkipToQuestion.TabIndex = 38
        Me.lblSkipToQuestion.Text = "Go to #:"
        Me.lblSkipToQuestion.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'pnlQuestion
        '
        Me.pnlQuestion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlQuestion.Location = New System.Drawing.Point(10, 40)
        Me.pnlQuestion.Name = "pnlQuestion"
        Me.pnlQuestion.Size = New System.Drawing.Size(605, 80)
        Me.pnlQuestion.TabIndex = 52
        '
        'lblQuestion
        '
        Me.lblQuestion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuestion.BackColor = System.Drawing.Color.White
        Me.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuestion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(10, 40)
        Me.lblQuestion.Multiline = True
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.ReadOnly = True
        Me.lblQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.lblQuestion.Size = New System.Drawing.Size(604, 108)
        Me.lblQuestion.TabIndex = 28
        '
        'pnlAnswer
        '
        Me.pnlAnswer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAnswer.Controls.Add(Me.lblAnswer)
        Me.pnlAnswer.Controls.Add(Me.lblAnswerBG)
        Me.pnlAnswer.Location = New System.Drawing.Point(5, 335)
        Me.pnlAnswer.Name = "pnlAnswer"
        Me.pnlAnswer.Size = New System.Drawing.Size(615, 90)
        Me.pnlAnswer.TabIndex = 56
        Me.pnlAnswer.Visible = False
        '
        'lblAnswer
        '
        Me.lblAnswer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAnswer.BackColor = System.Drawing.Color.White
        Me.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblAnswer.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(5, 5)
        Me.lblAnswer.Multiline = True
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.ReadOnly = True
        Me.lblAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.lblAnswer.Size = New System.Drawing.Size(604, 80)
        Me.lblAnswer.TabIndex = 73
        '
        'lblAnswerBG
        '
        Me.lblAnswerBG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAnswerBG.BackColor = System.Drawing.Color.SteelBlue
        Me.lblAnswerBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnswerBG.Location = New System.Drawing.Point(-10, 0)
        Me.lblAnswerBG.Name = "lblAnswerBG"
        Me.lblAnswerBG.Size = New System.Drawing.Size(625, 90)
        Me.lblAnswerBG.TabIndex = 69
        Me.lblAnswerBG.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(369, 20)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Type your response in the box below and press Enter:"
        '
        'lblFlashCardNum
        '
        Me.lblFlashCardNum.AutoSize = True
        Me.lblFlashCardNum.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblFlashCardNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlashCardNum.Location = New System.Drawing.Point(10, 10)
        Me.lblFlashCardNum.Name = "lblFlashCardNum"
        Me.lblFlashCardNum.Size = New System.Drawing.Size(62, 13)
        Me.lblFlashCardNum.TabIndex = 65
        Me.lblFlashCardNum.Text = "Flashcard"
        '
        'lblQuesBG
        '
        Me.lblQuesBG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuesBG.BackColor = System.Drawing.Color.SteelBlue
        Me.lblQuesBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuesBG.Location = New System.Drawing.Point(5, 35)
        Me.lblQuesBG.Name = "lblQuesBG"
        Me.lblQuesBG.Size = New System.Drawing.Size(615, 117)
        Me.lblQuesBG.TabIndex = 67
        '
        'lblYourAnswerBG
        '
        Me.lblYourAnswerBG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblYourAnswerBG.BackColor = System.Drawing.Color.SteelBlue
        Me.lblYourAnswerBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYourAnswerBG.Location = New System.Drawing.Point(5, 178)
        Me.lblYourAnswerBG.Name = "lblYourAnswerBG"
        Me.lblYourAnswerBG.Size = New System.Drawing.Size(615, 36)
        Me.lblYourAnswerBG.TabIndex = 68
        '
        'lblAnswerPrompt
        '
        Me.lblAnswerPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswerPrompt.Location = New System.Drawing.Point(5, 315)
        Me.lblAnswerPrompt.Name = "lblAnswerPrompt"
        Me.lblAnswerPrompt.Size = New System.Drawing.Size(65, 16)
        Me.lblAnswerPrompt.TabIndex = 70
        Me.lblAnswerPrompt.Text = "Answer:"
        Me.lblAnswerPrompt.Visible = False
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.Wheat
        Me.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswer.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.ForeColor = System.Drawing.Color.Black
        Me.txtAnswer.Location = New System.Drawing.Point(72, 182)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(405, 24)
        Me.txtAnswer.TabIndex = 71
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Blue
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(530, 270)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 74
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'tmrCorrectInc
        '
        Me.tmrCorrectInc.Interval = 3000
        '
        'txtImageURL
        '
        Me.txtImageURL.BackColor = System.Drawing.Color.Wheat
        Me.txtImageURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImageURL.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageURL.ForeColor = System.Drawing.Color.Black
        Me.txtImageURL.Location = New System.Drawing.Point(186, 88)
        Me.txtImageURL.Name = "txtImageURL"
        Me.txtImageURL.Size = New System.Drawing.Size(250, 24)
        Me.txtImageURL.TabIndex = 75
        '
        'odbConFlash2
        '
        Me.odbConFlash2.ConnectionString = resources.GetString("odbConFlash2.ConnectionString")
        '
        'odbDaFlash2
        '
        Me.odbDaFlash2.DeleteCommand = Me.OleDbDeleteCommand1
        Me.odbDaFlash2.InsertCommand = Me.OleDbInsertCommand1
        Me.odbDaFlash2.SelectCommand = Me.OleDbSelectCommand1
        Me.odbDaFlash2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Q1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("fldQID", "fldQID"), New System.Data.Common.DataColumnMapping("fldImageURL", "fldImageURL"), New System.Data.Common.DataColumnMapping("fldAnswer", "fldAnswer"), New System.Data.Common.DataColumnMapping("fldQuestion", "fldQuestion"), New System.Data.Common.DataColumnMapping("fldType", "fldType")})})
        Me.odbDaFlash2.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.odbConFlash2
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_fldQID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "fldQID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_fldAnswer", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldAnswer", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_fldAnswer1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldAnswer", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_fldImageURL", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldImageURL", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_fldImageURL1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldImageURL", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_fldQuestion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldQuestion", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_fldQuestion1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldQuestion", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_fldType", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldType", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_fldType1", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldType", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Q1(fldQID, fldImageURL, fldAnswer, fldQuestion, fldType) VALUES (?, ?" &
    ", ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.odbConFlash2
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("fldQID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "fldQID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("fldImageURL", System.Data.OleDb.OleDbType.VarWChar, 0, "fldImageURL"), New System.Data.OleDb.OleDbParameter("fldAnswer", System.Data.OleDb.OleDbType.VarWChar, 0, "fldAnswer"), New System.Data.OleDb.OleDbParameter("fldQuestion", System.Data.OleDb.OleDbType.VarWChar, 0, "fldQuestion"), New System.Data.OleDb.OleDbParameter("fldType", System.Data.OleDb.OleDbType.VarWChar, 4, "fldType")})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT fldQID, fldImageURL, fldAnswer, fldQuestion, fldType FROM Q1"
        Me.OleDbSelectCommand1.Connection = Me.odbConFlash2
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.odbConFlash2
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("fldQID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "fldQID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("fldImageURL", System.Data.OleDb.OleDbType.VarWChar, 0, "fldImageURL"), New System.Data.OleDb.OleDbParameter("fldAnswer", System.Data.OleDb.OleDbType.VarWChar, 0, "fldAnswer"), New System.Data.OleDb.OleDbParameter("fldQuestion", System.Data.OleDb.OleDbType.VarWChar, 0, "fldQuestion"), New System.Data.OleDb.OleDbParameter("fldType", System.Data.OleDb.OleDbType.VarWChar, 4, "fldType"), New System.Data.OleDb.OleDbParameter("Original_fldQID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "fldQID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_fldAnswer", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldAnswer", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_fldAnswer1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldAnswer", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_fldImageURL", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldImageURL", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_fldImageURL1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldImageURL", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_fldQuestion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldQuestion", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_fldQuestion1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldQuestion", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_fldType", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldType", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_fldType1", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fldType", System.Data.DataRowVersion.Original, Nothing)})
        '
        'DsFlash21
        '
        Me.DsFlash21.DataSetName = "dsFlash2"
        Me.DsFlash21.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsFlash21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmFlashcards
        '
        Me.AcceptButton = Me.btnGradeMe
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(632, 433)
        Me.Controls.Add(Me.txtYourAnswer)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblAnswerPrompt)
        Me.Controls.Add(Me.lblYourAnswerBG)
        Me.Controls.Add(Me.lblQuesBG)
        Me.Controls.Add(Me.lblFlashCardNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlAnswer)
        Me.Controls.Add(Me.pnlQuestion)
        Me.Controls.Add(Me.lblSkipToQuestion)
        Me.Controls.Add(Me.btnShowAnswer)
        Me.Controls.Add(Me.lblCorrectIncorrect)
        Me.Controls.Add(Me.chkStrictAnswers)
        Me.Controls.Add(Me.btnGradeMe)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.cboQID)
        Me.Controls.Add(Me.btnViewImage)
        Me.Controls.Add(Me.txtImageURL)
        Me.Controls.Add(Me.txtAnswer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmFlashcards"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nerdom Cert Exams 6.0 - Flashcards"
        Me.pnlAnswer.ResumeLayout(False)
        Me.pnlAnswer.PerformLayout()
        CType(Me.DsFlash21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmFlashcards_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pbnd As Binding
        Dim pintCount As Integer

        odbDaFlash2.Fill(DsFlash21)

        pbnd = New Binding("Text", DsFlash21, "Q1.fldQuestion")
        lblQuestion.DataBindings.Add(pbnd)

        pbnd = New Binding("Text", DsFlash21, "Q1.fldAnswer")
        lblAnswer.DataBindings.Add(pbnd)

        'these two are hidden behind other controls. Must be visible to grade
        pbnd = New Binding("Text", DsFlash21, "Q1.fldImageURL")
        txtImageURL.DataBindings.Add(pbnd)

        pbnd = New Binding("Text", DsFlash21, "Q1.fldAnswer")
        txtAnswer.DataBindings.Add(pbnd)

        For pintCount = 0 To Me.DsFlash21.Q1.Rows.Count - 1
            cboQID.Items.Add(pintCount + 1)
        Next

        cboQID.SelectedIndex = 0

        lblFlashCardNum.Text = "Flashcard # " & Me.BindingContext(DsFlash21, "Q1").Position + 1
        lblFlashCardNum.Text &= " of " & Me.DsFlash21.Q1.Rows.Count

        CheckIfImage()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnShowAnswer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShowAnswer.Click
        If mblnAnswerVisible = False Then
            pnlAnswer.Visible = True
            btnShowAnswer.Text = "Hide Answer"
            mblnAnswerVisible = True
            lblAnswerPrompt.Visible = True
            lblAnswerBG.Visible = True
        Else
            pnlAnswer.Visible = False
            btnShowAnswer.Text = "Answer"
            mblnAnswerVisible = False
            lblAnswerPrompt.Visible = False
            lblAnswerBG.Visible = False
        End If
    End Sub
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Me.BindingContext(DsFlash21, "Q1").Position += 1
        CheckIfImage()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Me.BindingContext(DsFlash21, "Q1").Position -= 1
        CheckIfImage()
    End Sub

    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        Me.BindingContext(DsFlash21, "Q1").Position = 0
        CheckIfImage()
    End Sub

    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(DsFlash21, "Q1").Position = Me.DsFlash21.Q1.Rows.Count - 1
        CheckIfImage()
    End Sub
    Private Sub cboQID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboQID.SelectedIndexChanged
        Me.BindingContext(DsFlash21, "Q1").Position = cboQID.SelectedIndex
        CheckIfImage()
    End Sub

    Private Sub CheckIfImage()
        txtYourAnswer.Text = ""

        If txtImageURL.Text <> "" Then
            btnViewImage.Visible = True
        Else
            btnViewImage.Visible = False
        End If

        lblFlashCardNum.Text = "Flashcard # " & Me.BindingContext(DsFlash21, "Q1").Position + 1
        lblFlashCardNum.Text &= " of " & Me.DsFlash21.Q1.Rows.Count
    End Sub
    Private Sub btnGradeMe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGradeMe.Click
        Dim pstrFields() As String
        Dim pintCount As Integer
        Dim pchrDelimiter() As Char = {ToChar(" ")}

        'User must type exact answer

        If chkStrictAnswers.CheckState = CheckState.Unchecked Then
            If LCase(txtYourAnswer.Text) = LCase(txtAnswer.Text) Then
                lblCorrectIncorrect.Text = "Correct"
                lblCorrectIncorrect.Visible = True
                tmrCorrectInc.Enabled = True
            Else
                lblCorrectIncorrect.Text = "Incorrect"
                lblCorrectIncorrect.Visible = True
                tmrCorrectInc.Enabled = True
            End If
        End If

        'user only needs to enter a word

        If chkStrictAnswers.CheckState = CheckState.Checked Then

            pstrFields = txtYourAnswer.Text.Split(pchrDelimiter)

            For pintCount = 0 To pstrFields.GetUpperBound(0)

                If LCase(txtAnswer.Text).IndexOf(LCase(pstrFields(pintCount))) > -1 Then
                    lblCorrectIncorrect.Text = "Correct"
                    lblCorrectIncorrect.Visible = True
                    tmrCorrectInc.Enabled = True
                    Exit Sub
                Else
                    lblCorrectIncorrect.Text = "Incorrect"
                    lblCorrectIncorrect.Visible = True
                    tmrCorrectInc.Enabled = True
                    Exit Sub
                End If
            Next
        End If

    End Sub

    Private Sub btnViewImage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnViewImage.Click
        Dim imagePath As String

        If Application.StartupPath = "\" Then
            imagePath = Application.StartupPath & txtImageURL.Text
        Else
            imagePath = Application.StartupPath & "\" & txtImageURL.Text
        End If

        Dim frm1 As New frmImage(imagePath)
        frm1.ShowDialog()
    End Sub

    Private Sub frmFlashcards_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        odbConFlash2.Close()
    End Sub

    Private Sub frmFlashcards_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        odbDaFlash2.Fill(DsFlash21)
    End Sub

    Private Sub tmrCorrectInc_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrCorrectInc.Tick
        'will make the label stating Correct/Incorrect invisible and disable timer
        'timer is enabled only when user hit submit

        lblCorrectIncorrect.Visible = False
        tmrCorrectInc.Enabled = False
    End Sub


End Class


