Imports TestQueen.QueenLibInstall
Imports System.IO
Imports Microsoft.VisualBasic.ControlChars
Imports System.Convert

Public Class frmSelectTest
    Inherits System.Windows.Forms.Form

    Public Structure TestStruct
        Public ExamName As String
        Public ExamFile As String
    End Structure

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
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
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents LinkLabelDelete As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkNewTests As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelNewExam As System.Windows.Forms.LinkLabel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents LinkLabelRename As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelAddPrevious As System.Windows.Forms.LinkLabel
    Friend WithEvents lstExams As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSelectTest))
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.LinkLabelDelete = New System.Windows.Forms.LinkLabel()
        Me.lnkNewTests = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelNewExam = New System.Windows.Forms.LinkLabel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.LinkLabelRename = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelAddPrevious = New System.Windows.Forms.LinkLabel()
        Me.lstExams = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Bitmap)
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(15, 240)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Close"
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.btnNew.BackgroundImage = CType(resources.GetObject("btnNew.BackgroundImage"), System.Drawing.Bitmap)
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNew.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(165, 240)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(107, 30)
        Me.btnNew.TabIndex = 5
        Me.btnNew.Text = "&New"
        Me.btnNew.Visible = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.btnNext.BackgroundImage = CType(resources.GetObject("btnNext.BackgroundImage"), System.Drawing.Bitmap)
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(165, 240)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(107, 30)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Ne&xt"
        '
        'LinkLabelDelete
        '
        Me.LinkLabelDelete.AutoSize = True
        Me.LinkLabelDelete.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelDelete.Location = New System.Drawing.Point(20, 295)
        Me.LinkLabelDelete.Name = "LinkLabelDelete"
        Me.LinkLabelDelete.Size = New System.Drawing.Size(38, 13)
        Me.LinkLabelDelete.TabIndex = 7
        Me.LinkLabelDelete.TabStop = True
        Me.LinkLabelDelete.Text = "Delete"
        Me.LinkLabelDelete.Visible = False
        '
        'lnkNewTests
        '
        Me.lnkNewTests.AutoSize = True
        Me.lnkNewTests.BackColor = System.Drawing.Color.Transparent
        Me.lnkNewTests.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkNewTests.Location = New System.Drawing.Point(95, 15)
        Me.lnkNewTests.Name = "lnkNewTests"
        Me.lnkNewTests.Size = New System.Drawing.Size(94, 13)
        Me.lnkNewTests.TabIndex = 3
        Me.lnkNewTests.TabStop = True
        Me.lnkNewTests.Text = "Install New Tests"
        Me.lnkNewTests.Visible = False
        '
        'LinkLabelNewExam
        '
        Me.LinkLabelNewExam.AutoSize = True
        Me.LinkLabelNewExam.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelNewExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelNewExam.Location = New System.Drawing.Point(115, 295)
        Me.LinkLabelNewExam.Name = "LinkLabelNewExam"
        Me.LinkLabelNewExam.Size = New System.Drawing.Size(52, 13)
        Me.LinkLabelNewExam.TabIndex = 6
        Me.LinkLabelNewExam.TabStop = True
        Me.LinkLabelNewExam.Text = "Add New"
        '
        'lblTitle
        '
        Me.lblTitle.AccessibleDescription = "Installed Exams"
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(20, 56)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(139, 13)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Saved Exam Collections:"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabelRename
        '
        Me.LinkLabelRename.AutoSize = True
        Me.LinkLabelRename.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelRename.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelRename.Location = New System.Drawing.Point(220, 295)
        Me.LinkLabelRename.Name = "LinkLabelRename"
        Me.LinkLabelRename.Size = New System.Drawing.Size(48, 13)
        Me.LinkLabelRename.TabIndex = 8
        Me.LinkLabelRename.TabStop = True
        Me.LinkLabelRename.Text = "Rename"
        Me.LinkLabelRename.Visible = False
        '
        'LinkLabelAddPrevious
        '
        Me.LinkLabelAddPrevious.AutoSize = True
        Me.LinkLabelAddPrevious.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelAddPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelAddPrevious.Location = New System.Drawing.Point(105, 275)
        Me.LinkLabelAddPrevious.Name = "LinkLabelAddPrevious"
        Me.LinkLabelAddPrevious.Size = New System.Drawing.Size(74, 13)
        Me.LinkLabelAddPrevious.TabIndex = 9
        Me.LinkLabelAddPrevious.TabStop = True
        Me.LinkLabelAddPrevious.Text = "Add Previous"
        '
        'lstExams
        '
        Me.lstExams.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.lstExams.AutoArrange = False
        Me.lstExams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstExams.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstExams.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.lstExams.LabelWrap = False
        Me.lstExams.Location = New System.Drawing.Point(15, 72)
        Me.lstExams.MultiSelect = False
        Me.lstExams.Name = "lstExams"
        Me.lstExams.Size = New System.Drawing.Size(255, 152)
        Me.lstExams.TabIndex = 10
        Me.lstExams.View = System.Windows.Forms.View.List
        '
        'frmSelectTest
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(288, 316)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lstExams, Me.LinkLabelAddPrevious, Me.LinkLabelRename, Me.lblTitle, Me.LinkLabelNewExam, Me.lnkNewTests, Me.LinkLabelDelete, Me.btnNext, Me.btnNew, Me.btnExit})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(296, 343)
        Me.MinimizeBox = False
        Me.Name = "frmSelectTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mInstallClass As ClassInstall
    Private mTestsCount As Integer
    Private mDeletedCount As Integer 'TO TRACK ITEMS DELETED TO APPEND D,SLKDS
    Private rTests() As TestStruct 'FOR RENAMING
    Private SP As String = Application.StartupPath & "\"
    Private dbTempPath As String = Application.StartupPath & "\dbicnse.mdb"
    Private dbBackupPath As String = Application.StartupPath & "\backup\dbicnse.mdb"
    Private minstallFile As String = Application.StartupPath & "\" & "installit.dat"
    Private micnsFile As String = Application.StartupPath & "\" & "icns.dat"
    Private micnsNewFile As String = "icnse.mdb"

#Region "FormPaint"
    Private Sub frmSelectTest_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim fntDrawstring As New Font("Arial", 14)
        Dim sbBrushWhite As New SolidBrush(Color.White)
        e.Graphics.DrawString("Select An Exam", fntDrawstring, sbBrushWhite, 75, 15)
        e.Graphics.DrawRectangle(Pens.White, 8, 56, 272, 180) 'Draw box around listbox
        e.Graphics.FillRectangle(Brushes.White, 8, 56, 272, 180)
    End Sub
#End Region

    Sub MsgBoxA()
        MsgBox("You have previously deleted an exam from the 'Select An Exam' list. " _
        & "The list of exams will automatically reload to refresh the list.", MsgBoxStyle.OKOnly, "General Information")
    End Sub
    Sub MsgBoxB()
        MsgBox("You have previously added a previous exam to the 'Select An Exam' list. " _
                & "The list of exams will automatically reload to refresh the list.", MsgBoxStyle.OKOnly, "General Information")

    End Sub
    Sub CopySavedToWorking()
        'C:\PROGRAM FILES\QUEENEDIT\ TQCCNA \
        'REPLACE THE SAVED ICONS FILE FOR THIS EXAM TO THE WORKING DIRECTORY
        If File.Exists(dbTempPath) Then File.Delete(dbTempPath)
        If File.Exists(fPARENTPATH & micnsNewFile) Then
            File.Copy(fPARENTPATH & micnsNewFile, dbTempPath)
        Else : File.Copy(dbBackupPath, dbTempPath)
        End If
    End Sub
    Sub DeleteExam()
        Dim FSR As New FileStream(minstallFile, FileMode.Open, FileAccess.Read)
        Dim FSW As FileStream

        Dim m_Reader As New StreamReader(FSR)
        Dim m_Writer As StreamWriter

        Dim pLine As String
        Dim pExamNo As Integer

        'READ - FIRST LINE OF INSTALLIT.DAT AND CLOSE FILESTREAM
        'CONVERT THE FIRST LINE OF INSTALLIT.DAT TO LOWERCASE AND GET EXAM ID
        pLine = m_Reader.ReadLine
        m_Reader.Close()
        pLine = LCase(pLine)

        pExamNo = mInstallClass.ExamNo(lstExams.SelectedIndices(0).ToString) '12/13/04
        'pExamNo = mInstallClass.ExamNo(lstExams.SelectedItem.ToString)

        'BEFORE WRITING A LINE TO DELETE
        'IF INSTALLIT.DAT READS DONE,0,0[NO EXAMS TO INSTALL] THEN ERASE IT
        If pLine = "done,0,0" Then
            FSW = New FileStream(minstallFile, FileMode.Open, FileAccess.Write)
            m_Writer = New StreamWriter(FSW)
            m_Writer.Flush()
            m_Writer.BaseStream.Seek(0, SeekOrigin.Begin)
            m_Writer.Write("")
        Else
            'IF INSTALLIT.DAT IS BLANK, OR CONTAINS AN EXAM TO INSTALL, SET TO APPEND MODE
            FSW = New FileStream(minstallFile, FileMode.Append, FileAccess.Write)
            m_Writer = New StreamWriter(FSW)
            m_Writer.Flush()
            m_Writer.BaseStream.Seek(0, SeekOrigin.End)
        End If

        'WRITE THE COMMAND ON ONE LINE OF INSTALL FILE
        'TO DELETE THAT EXAM, EXAM NAME [TITLE], AND FOLDER[FILE]NAME
        m_Writer.Write("D,")
        m_Writer.Write(mInstallClass.ExamName(pExamNo))
        m_Writer.Write("," & mInstallClass.ExamFile(pExamNo))
        m_Writer.Write(vbCrLf)
        m_Writer.Flush()
        m_Writer.Close()
        FSW.Close()

        lstExams.Items.RemoveAt(lstExams.SelectedIndices(0)) '12/13/04
        SetUpListBox()

        ShowSelectTestForm()
        Me.Close()
    End Sub
    Sub DoNextButton()
        Dim pblnDeletedTests As Boolean = mInstallClass.DoAnyDeletedTestsExist
        Dim pblnNewTests As Boolean = mInstallClass.DoAnyNewTestsExist
        'DELETED TESTS MUST BE PROCESSED FIRST - RELOAD THE FORM
        If pblnDeletedTests = True Then
            MsgBoxA()
            ShowSelectTestForm()
            Me.Close()
            Exit Sub
        End If
        If pblnNewTests = True Then 'or take out this block and use rename code
            MsgBoxB()
            ShowSelectTestForm()
            Me.Close()
            Exit Sub
        End If
        SetGlobalVariables()
        CopySavedToWorking()
        ShowIconEditorForm()
        Me.Close()
    End Sub
    Sub NewExam()
        Dim pDirArray() As String
        Dim pblnDeletedTests As Boolean = mInstallClass.DoAnyDeletedTestsExist

        If pblnDeletedTests = True Then
            MsgBoxA()
            ShowSelectTestForm()
            Me.Close()
            Exit Sub
        End If

        fISNEWTEST = True
        pDirArray = Directory.GetDirectories(Application.StartupPath)
        fintEXAMSELECTED = pDirArray.GetUpperBound(0)

        RepairExamDatabase()
        ShowIconEditorForm()
        Me.Close()
    End Sub
    Sub RenameExam()
        Dim m_Reader As StreamReader
        Dim m_Writer As StreamWriter
        Dim pLine As String, pFields() As String
        Dim pDelimiter() As Char = {System.Convert.ToChar(",")}
        Dim pCount As Integer, pSelectedIndex As Integer
        Dim pNewName As String = InputBox("Enter a new name for this collection")

        If pNewName <> "" And pNewName.IndexOf(",") = -1 Then
            pSelectedIndex = lstExams.SelectedIndices(0) '12/13/04
            Try
                m_Reader = New StreamReader(micnsFile)
                pLine = m_Reader.ReadLine() 'READ 1st LINE

                If pLine = "Installed Tests:" Then
                    pLine = m_Reader.ReadLine()  'read 2nd line

                    Do Until pLine = Nothing
                        pFields = pLine.Split(pDelimiter)
                        If pFields.GetUpperBound(0) = 1 Then
                            ReDim Preserve rTests(pCount)
                            rTests(pCount).ExamName = pFields(0)
                            rTests(pCount).ExamFile = pFields(1) '***
                            pCount += 1
                            pLine = m_Reader.ReadLine()
                        End If
                    Loop

                End If
                m_Reader.Close()
            Catch
                MsgBox("Error in Loading Array:Rename")
            End Try
            m_Reader.Close()

            '12/13/04 added indices(0) not index - 2 lines below
            mInstallClass.ExamName(lstExams.SelectedIndices(0)) = pNewName 'GLOBAL WHILE RUNNING
            rTests(lstExams.SelectedIndices(0)).ExamName = pNewName                 'TEMP FOR FILE WRITE
            lstExams.Items.Clear()

            For pCount = 0 To mTestsCount - 1
                lstExams.Items.Add(mInstallClass.ExamName(pCount))
            Next '? remove duplicates


            Try
                m_Writer = New StreamWriter(micnsFile)   'WRITE ICNS.DAT FILE
                If pCount > 0 Then
                    m_Writer.WriteLine("Installed Tests:")

                    For pCount = 0 To pCount - 1
                        m_Writer.Write(rTests(pCount).ExamName)
                        m_Writer.Write(",")
                        m_Writer.Write(rTests(pCount).ExamFile)
                        m_Writer.Write(vbCrLf)
                    Next
                End If
                m_Writer.Flush()
                m_Writer.Close()
            Catch
                MsgBox("Error Writing Existing Tests File")
            End Try

            'lstExams.SelectedIndices(0) = pSelectedIndex '12/13/04

        Else 'if null or contains a comma
            MsgBox("Invalid Exam Name: Exam name cannot be blank or contain a comma.")
            Exit Sub
        End If
    End Sub
    Sub RepairExamDatabase()
        File.Delete(dbTempPath)
        File.Copy(dbBackupPath, dbTempPath) 'create new
    End Sub
    Sub SetGlobalVariables()
        'SET THE CURRENT FOLDER TO THE ONE YOU SELECTED EG. TQCCNA
        fPARENTFOLDER = mInstallClass.ExamFile(lstExams.SelectedIndices(0)) '12/13/04
        fPARENTPATH = SP & fPARENTFOLDER & "\"
        fintEXAMSELECTED = lstExams.SelectedIndices(0) + 1 'USED FOR NAMING DIRECTORIES'12/13/04
        fCollectionName = mInstallClass.ExamName(lstExams.SelectedIndices(0)) '12/13/04
    End Sub
    Sub SetUpExams()
        Dim pblnNewTests As Boolean, pblnExistingTests As Boolean
        Dim pblnDeletedTests As Boolean, pintDeletedTests As Integer
        Dim pintCount As Integer
        Dim pouterCount As Integer, iTestCount As Integer

        pblnExistingTests = mInstallClass.DoAnyExistingTestsExist()

        If pblnExistingTests = True Then
            mTestsCount = mInstallClass.LoadExistingTest()
            LinkLabelDelete.Visible = True
            LinkLabelRename.Visible = True
        End If

        pblnNewTests = mInstallClass.DoAnyNewTestsExist()

        If pblnNewTests = True Then
            mInstallClass.LoadNewTests()
            mTestsCount = mInstallClass.SyncAllTests()
            lnkNewTests.Visible = False
            LinkLabelDelete.Visible = True
            LinkLabelRename.Visible = True
        End If

        pblnDeletedTests = mInstallClass.DoAnyDeletedTestsExist

        If pblnDeletedTests = True Then
            mTestsCount = mTestsCount - mInstallClass.LoadDeletedTests()
            mInstallClass.WriteDeletedTest()
        End If

        'add if mtestcount > 0 to this for next
        For pintCount = 0 To mTestsCount - 1
            'If mInstallClass.ExamName(pintCount) <> "" Then '? New code 10-11
            lstExams.Items.Add(mInstallClass.ExamName(pintCount))
        Next

        ''remove duplicates and update mtestcount
        'For pouterCount = 0 To mTestsCount - 1
        '    For pintCount = 0 To pouterCount
        '        If mInstallClass.ExamFile(pintCount + 1) = mInstallClass.ExamFile(pouterCount) Then
        '            Try
        '                lstExams.Items.RemoveAt((pouterCount))
        '                iTestCount -= 1 'or replace with mtestscount -=1
        '            Catch
        '                Exit For
        '            End Try
        '        End If
        '    Next
        'Next

        'mTestsCount = iTestCount

        'For pintCount = cboItems.Count - 1 To 1 Step -1
        '    If cbo.Items(pintCount - 1).ToString = cbo.Items(pintCount).ToString Then
        '        cbo.Items.RemoveAt(pintCount)
        '    End If
        'Next


        If pblnNewTests = False And pblnExistingTests = False Then
            fISNEWTEST = True
            btnNew.Visible = True
            btnNext.Visible = False
        Else
            fISNEWTEST = False
            btnNew.Visible = False
            btnNext.Visible = True
        End If
    End Sub
    Sub ShowIconEditorForm()
        Dim FI As New frmEditIconsE()
        FI.Show()
    End Sub
    Sub ShowSelectTestForm()
        Dim FS As New frmSelectTest()
        FS.Show()
    End Sub
    Function selectedFolderOK() As Boolean
        Dim m_Reader As StreamReader, pLine As String, pFields() As String
        Dim pDelimiter() As Char = {System.Convert.ToChar(",")}
        Dim pCount As Integer

        If fSelectedPrevName <> "" And fSelectedFolder.IndexOf(",") = -1 And fSelectedPrevName.IndexOf(",") = -1 Then
            Try
                m_Reader = New StreamReader(micnsFile)
                pLine = m_Reader.ReadLine() 'READ 1st LINE

                If pLine = "Installed Tests:" Then
                    pLine = m_Reader.ReadLine()  'read 2nd line

                    Do Until pLine = Nothing
                        pFields = pLine.Split(pDelimiter)
                        If pFields.GetUpperBound(0) = 1 Then
                            If pFields(1) = fSelectedFolder Then
                                Return False
                            End If
                            pCount += 1
                            pLine = m_Reader.ReadLine()
                        End If
                    Loop
                End If
                m_Reader.Close()
            Catch
                MsgBox("Error in Adding Previous Folder")
            End Try
            m_Reader.Close()
            Return True
        End If
    End Function
    Sub SetUpListBox()
        Try
            lstExams.Select()
            'lstExams.SelectedIndex = 0
        Catch
            lblTitle.Text = "No Saved Exam Collections"
            lstExams.BackColor = Color.DimGray
            LinkLabelDelete.Visible = False
            LinkLabelRename.Visible = False
            btnNew.Visible = True
            btnNext.Visible = False
        End Try
    End Sub
    'Sub ShowFolderDialogForm()
    '    Dim FF As New frmFolderDialog()
    '    FF.ShowDialog()

    '    If fSelectedFolder <> "" Then
    '        'Check if the folder isnt added to icns.dat Examfile(0)
    '        'count list items
    '        'add the new item to listbox if it doesnt exist or close form to install and reload
    '        'eg this form will be reloaded - all in SelectedFolderOK
    '        If selectedFolderOK() = True Then
    '            If Directory.Exists(SP & fSelectedFolder) Then
    '                WriteNewTests(fSelectedPrevName, fSelectedFolder)
    '            End If
    '        End If
    '    End If
    '    ShowSelectTestForm()
    '    Me.Close()

    'End Sub

    Sub WriteNewTests(ByVal pColName As String, ByVal pFolder As String)

        Dim FSR As New FileStream(minstallFile, FileMode.Open, FileAccess.Read)
        Dim FSW As FileStream

        Dim m_Reader As New StreamReader(FSR)
        Dim m_Writer As StreamWriter
        Dim pLine As String = m_Reader.ReadLine

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

        'WRITE N, FOLDER, FOLDER
        m_Writer.Write("N,")
        m_Writer.Write(pColName)
        m_Writer.Write("," & pFolder)
        m_Writer.Write(vbCrLf)
        m_Writer.Flush()
        m_Writer.Close()
        FSW.Close()

    End Sub

    Private Sub frmSelectTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mInstallClass = New ClassInstall() 'INSTANTIATE THE INSTALL CLASS
        Me.Text = Application.ProductName & " - Main Menu" 'SET FORM TITLE BAR
        SetUpExams()
        SetUpListBox()
    End Sub
    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click
        DoNextButton()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub frmSelectTest_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        mInstallClass = Nothing
        Me.Dispose()
    End Sub
    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNew.Click
        NewExam()
    End Sub
    Private Sub LinkLabelNewExam_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelNewExam.LinkClicked
        NewExam()
    End Sub
    Private Sub LinkLabelDelete_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelDelete.LinkClicked
        DeleteExam()
    End Sub
    Private Sub LinkLabelRename_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelRename.LinkClicked
        RenameExam()
    End Sub

    Private Sub LinkLabelAddPrevious_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelAddPrevious.LinkClicked
        'ShowFolderDialogForm()
    End Sub

   
    
End Class
