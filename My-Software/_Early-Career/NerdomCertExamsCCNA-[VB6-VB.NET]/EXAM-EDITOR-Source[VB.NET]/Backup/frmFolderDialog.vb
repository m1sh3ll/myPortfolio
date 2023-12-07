Imports System.IO
Imports System.Convert

Public Class frmFolderDialog
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents lstFolders As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFolderDialog))
        Me.lstFolders = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstFolders
        '
        Me.lstFolders.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFolders.Location = New System.Drawing.Point(5, 30)
        Me.lstFolders.Name = "lstFolders"
        Me.lstFolders.Size = New System.Drawing.Size(275, 121)
        Me.lstFolders.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select an exam folder to add."
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(190, 220)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(85, 25)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "OK"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(5, 195)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(275, 20)
        Me.txtName.TabIndex = 3
        Me.txtName.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter a name in the box below for this collection. This name will be displayed in" & _
        " the exam list."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(15, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 25)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Refresh Folders"
        '
        'frmFolderDialog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(282, 250)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.Label2, Me.txtName, Me.btnSelect, Me.lstFolders, Me.Label1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmFolderDialog"
        Me.Text = "Select Folder"
        Me.ResumeLayout(False)

    End Sub

#End Region

   
    Sub MsgBoxC() '? Enhanced msgbox
        MsgBox("You have no previous collections. If you saved a previous exam folder " & vbCrLf _
        & "in a directory other than the program path " & Application.StartupPath & ", " & vbCrLf _
        & "this feature will not work. If you have saved examsets, copy those directories to " & vbCrLf _
        & "the path " & Application.StartupPath, MsgBoxStyle.OKOnly, "No Exam Folders Detected")
    End Sub
    Sub MsgBoxD()
        MsgBox("Please enter a name.")
    End Sub

    Sub GetFolders()
        Dim dirArray() As String, pFields() As String
        Dim pNumDirs As Integer, pCount As Integer
        Dim pFile As String
        Dim pDelimiter() As Char = {ToChar("\")}
        Dim iIndex As Integer

        dirArray = Directory.GetDirectories(Application.StartupPath)  'GET ALL DIRECTORY NAMES IN FOLDER
        pNumDirs = dirArray.GetUpperBound(0) 'GET NUMBER OF EXAM DIRECTORIES IN THE APP FOLDER

        For pCount = 0 To pNumDirs
            'extract just folder name from path, not full path
            pFile = dirArray(pCount)

            pFields = pFile.Split(pDelimiter)
            If pFields(pCount) <> "" Then '?
                iIndex = pFields.GetUpperBound(0)
                pFile = pFields(iIndex)
                If pFile <> "backup" Then lstFolders.Items.Add(pFile)
            End If
        Next
        If lstFolders.Items.Count = 0 Then '? new block
            MsgBoxC()
            btnSelect.Enabled = False
        Else
            lstFolders.SelectedIndex = 0
        End If

    End Sub
    Sub SelectFolder()
        If lstFolders.Items.Count = 0 Then '? new block
            MsgBoxC()
            Exit Sub
        End If

        If txtName.Text = "" Then
            MsgBoxD()
            Exit Sub
        End If

        fSelectedPrevName = txtName.Text

        Try
            fSelectedFolder = lstFolders.SelectedItem.ToString
        Catch
            MsgBoxC()
        Finally
            Me.Close()
        End Try

    End Sub
    Sub SetTxtNameText()
        Try
            txtName.Text = lstFolders.SelectedItem.ToString
        Catch
            txtName.Text = ""
        End Try
    End Sub
 

    Private Sub btnSelect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        SelectFolder()
    End Sub

    Private Sub lstFolders_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFolders.SelectedIndexChanged
        SetTxtNameText()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        GetFolders()
    End Sub

    Private Sub frmFolderDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
