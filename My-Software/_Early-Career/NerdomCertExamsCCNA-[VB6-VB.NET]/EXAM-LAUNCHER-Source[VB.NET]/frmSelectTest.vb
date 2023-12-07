
Imports TestQueen.QueenLibInstall

Public Class frmSelectTest
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents lstExams As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lnkNewTests As System.Windows.Forms.LinkLabel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSelectTest))
        Me.lstExams = New System.Windows.Forms.ListBox
        Me.btnNext = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lnkNewTests = New System.Windows.Forms.LinkLabel
        Me.btnExit = New System.Windows.Forms.Button
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'lstExams
        '
        Me.lstExams.BackColor = System.Drawing.Color.White
        Me.lstExams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstExams.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstExams.ForeColor = System.Drawing.Color.Navy
        Me.lstExams.ItemHeight = 16
        Me.lstExams.Location = New System.Drawing.Point(17, 80)
        Me.lstExams.Name = "lstExams"
        Me.lstExams.Size = New System.Drawing.Size(256, 146)
        Me.lstExams.TabIndex = 0
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.btnNext.BackgroundImage = CType(resources.GetObject("btnNext.BackgroundImage"), System.Drawing.Image)
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(16, 256)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(107, 30)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "&Next"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = "Installed Exams"
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Installed Exams:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lnkNewTests
        '
        Me.lnkNewTests.AutoSize = True
        Me.lnkNewTests.BackColor = System.Drawing.Color.Transparent
        Me.lnkNewTests.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkNewTests.Location = New System.Drawing.Point(102, 296)
        Me.lnkNewTests.Name = "lnkNewTests"
        Me.lnkNewTests.Size = New System.Drawing.Size(94, 16)
        Me.lnkNewTests.TabIndex = 3
        Me.lnkNewTests.TabStop = True
        Me.lnkNewTests.Text = "Install New Tests"
        Me.lnkNewTests.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(168, 256)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        '
        'ofdOpenFile
        '
        '
        'frmSelectTest
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(290, 321)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lnkNewTests)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lstExams)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSelectTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mInstallClass As ClassInstall
    Private mTestsCount As Integer

#Region "FormPaint"

    Private Sub frmSelectTest_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim intLineHeight As Integer = Me.Height, intXPos As Integer
        Dim intBlue As Integer = 52, intgreen As Integer, intRed As Integer = 51
        Dim penGreentoBlue As New Pen(Color.Black, 3)
        Dim colPenColor As Color
        Dim fntDrawstring As New Font("Arial", 14)
        Dim sbBrushWhite As New SolidBrush(Color.White)

        'DRAW BLUE BACKGROUND ON FORM
        For intXPos = 0 To Me.Width
            colPenColor = Color.FromArgb(intRed, intgreen, intBlue + 50)
            penGreentoBlue.Color = colPenColor
            e.Graphics.DrawLine(penGreentoBlue, intXPos, 0, intXPos, intLineHeight)
            intBlue += 1
            If intBlue > 255 Then intBlue = 255
            intXPos += 2
        Next
        e.Graphics.DrawString("Select An Exam", fntDrawstring, sbBrushWhite, 75, 15)
        'Draw box around listbox as a border
        e.Graphics.DrawRectangle(Pens.White, 8, 56, 272, 180)
        e.Graphics.FillRectangle(Brushes.White, 8, 56, 272, 180)
    End Sub
#End Region

    Private Sub frmSelectTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim pblnNewTests As Boolean
        'Dim pblnExistingTests As Boolean
        'Dim pintCount As Integer
        'INSTANTIATE THE INSTALL CLASS TO INSTALL THE NEW AND/or EXISTING EXAMS
        mInstallClass = New ClassInstall

        Me.Text = Application.CompanyName & " " & Application.ProductName

        Call SetUpExamsListbox()

        Try
            lstExams.SelectedIndex = 0
        Catch
            lstExams.BackColor = Color.DimGray
            MsgBox("You have no installed tests.")
            btnNext.Visible = False
        End Try

        'CHECK IF ANY NEW TESTS NEED TO BE INSTALLED (FROM INSTALLIT.DAT)
        'pblnNewTests = mInstallClass.DoAnyNewTestsExist()

        'SHOW THE LINK TO INSTALL THE NEW TESTS
        'If pblnNewTests = True Then
        'lnkNewTests.Visible = True
        ' End If

        'ALSO CHECK IF THERE ARE ANY EXISTING EXAMS IN ICNS.DAT
        ' pblnExistingTests = mInstallClass.DoAnyExistingTestsExist()

        ' If pblnExistingTests = True Then
        'LOAD EXISTING TESTS IN ICNS.DAT
        '  mTestsCount = mInstallClass.LoadExistingTest()
        '  End If

        'ADD THE EXISTING TESTS TO THE LISTBOX
        'THE INDEX OF THE LISTBOX IS PASSED TO THE PROPERTY
        'OF THE CLASS'S EXAMNAME TO ACCESS ELEMENT OF STRUCTURE
        'PROPERTY SEARCHES THE ARRAY OF STRUCT IN THE CLASSINSTALL
        'For pintCount = 0 To mTestsCount - 1
        ' lstExams.Items.Add(mInstallClass.ExamName(pintCount))
        ' Next

        'SELECT DEFAULT EXAM -one must be selected to continue
        'IF THERE ARE NO EXISTING TESTS TO SELECT
        'PROMPT TO INSTALL NEW TESTS
        ' Try
        ' lstExams.SelectedIndex = 0
        ' Catch
        '     MsgBox("You have no exams installed. Click on Install New Tests.")
        ' End Try

    End Sub
    Private Sub SetUpExamsListBox()
        Dim pblnNewTests As Boolean, pblnExistingTests As Boolean
        Dim pblnDeletedTests As Boolean, pintDeletedTests As Integer
        Dim pintCount As Integer

        pblnExistingTests = mInstallClass.DoAnyExistingTestsExist()

        If pblnExistingTests = True Then
            mTestsCount = mInstallClass.LoadExistingTest()
            'LinkLabelDelete.Visible = True
        End If

        pblnNewTests = mInstallClass.DoAnyNewTestsExist()

        If pblnNewTests = True Then
            mInstallClass.LoadNewTests()
            mTestsCount = mInstallClass.SyncAllTests()
            'lnkNewTests.Visible = False
        End If

        pblnDeletedTests = mInstallClass.DoAnyDeletedTestsExist

        If pblnDeletedTests = True Then
            mTestsCount = mTestsCount - mInstallClass.LoadDeletedTests()
            mInstallClass.WriteDeletedTest()
        End If

        For pintCount = 0 To mTestsCount - 1
            lstExams.Items.Add(mInstallClass.ExamName(pintCount))
        Next
        
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click
        'NEXT BUTTON VISIBLE MEANS THIS IS NOT A NEW TEST
        'SEARCH EXAMFILE PROPERTY FOR THE SELECTED INDEX
        'WHICH REPRESENTS EACH EXAM ELEMENT
        'WILL RETURN THE ASSOCIATED TEST FILENAME .exe FOR THE TEST
        Dim SP As String = Application.StartupPath
        Dim pblnDeletedTests As Boolean

        pblnDeletedTests = mInstallClass.DoAnyDeletedTestsExist

        If pblnDeletedTests = True Then
            MsgBox("Processing deleted tests... This form will be reloaded")
            Dim frmSelect As New frmSelectTest
            frmSelect.Show()
            Me.Close()
            Exit Sub
        End If

        'SET THE CURRENT FOLDER TO THE ONE YOU SELECTED
        fPARENTFOLDER = mInstallClass.ExamFile(lstExams.SelectedIndex)
        '             C:\testqueen\bin'  % \ myexam1
        fPARENTPATH = SP & "\" & fPARENTFOLDER & "\testq.exe"

        Call Navigate(fPARENTPATH)

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub frmSelectTest_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        End
    End Sub

End Class
