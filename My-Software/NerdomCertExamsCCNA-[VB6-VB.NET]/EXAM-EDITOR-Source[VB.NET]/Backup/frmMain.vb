Imports System.IO

Public Class frmMain
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabelFiles As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelExit As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelOpenModule As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelAddNew As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabelFiles = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelExit = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelOpenModule = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelAddNew = New System.Windows.Forms.LinkLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Menu"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabelFiles
        '
        Me.LinkLabelFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabelFiles.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelFiles.ForeColor = System.Drawing.Color.Blue
        Me.LinkLabelFiles.LinkColor = System.Drawing.Color.Blue
        Me.LinkLabelFiles.Location = New System.Drawing.Point(10, 86)
        Me.LinkLabelFiles.Name = "LinkLabelFiles"
        Me.LinkLabelFiles.Size = New System.Drawing.Size(165, 24)
        Me.LinkLabelFiles.TabIndex = 13
        Me.LinkLabelFiles.TabStop = True
        Me.LinkLabelFiles.Text = "Preview Files"
        Me.LinkLabelFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabelExit
        '
        Me.LinkLabelExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabelExit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelExit.ForeColor = System.Drawing.Color.Blue
        Me.LinkLabelExit.LinkColor = System.Drawing.Color.Blue
        Me.LinkLabelExit.Location = New System.Drawing.Point(10, 114)
        Me.LinkLabelExit.Name = "LinkLabelExit"
        Me.LinkLabelExit.Size = New System.Drawing.Size(165, 24)
        Me.LinkLabelExit.TabIndex = 15
        Me.LinkLabelExit.TabStop = True
        Me.LinkLabelExit.Text = "Exit Program"
        Me.LinkLabelExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabelOpenModule
        '
        Me.LinkLabelOpenModule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabelOpenModule.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelOpenModule.ForeColor = System.Drawing.Color.Blue
        Me.LinkLabelOpenModule.LinkColor = System.Drawing.Color.Blue
        Me.LinkLabelOpenModule.Location = New System.Drawing.Point(10, 58)
        Me.LinkLabelOpenModule.Name = "LinkLabelOpenModule"
        Me.LinkLabelOpenModule.Size = New System.Drawing.Size(165, 24)
        Me.LinkLabelOpenModule.TabIndex = 17
        Me.LinkLabelOpenModule.TabStop = True
        Me.LinkLabelOpenModule.Text = "Open Saved Collection"
        Me.LinkLabelOpenModule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabelAddNew
        '
        Me.LinkLabelAddNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabelAddNew.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelAddNew.ForeColor = System.Drawing.Color.Blue
        Me.LinkLabelAddNew.LinkColor = System.Drawing.Color.Blue
        Me.LinkLabelAddNew.Location = New System.Drawing.Point(10, 30)
        Me.LinkLabelAddNew.Name = "LinkLabelAddNew"
        Me.LinkLabelAddNew.Size = New System.Drawing.Size(165, 24)
        Me.LinkLabelAddNew.TabIndex = 19
        Me.LinkLabelAddNew.TabStop = True
        Me.LinkLabelAddNew.Text = "Main Menu"
        Me.LinkLabelAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(184, 145)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.LinkLabelAddNew, Me.LinkLabelOpenModule, Me.LinkLabelExit, Me.LinkLabelFiles, Me.Label1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Exam Edit 1.0"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private SP As String = Application.StartupPath & "\"
    Private minstallFile As String = Application.StartupPath & "\" & "installit.dat"

    Sub ShowSelectTestForm()
        Dim FS As New frmSelectTest()
        FS.Show()
    End Sub

    Private Sub LinkLabelFiles_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelFiles.LinkClicked
        Navigate(Application.StartupPath)
    End Sub

    Private Sub LinkLabelExit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelExit.LinkClicked
        End
    End Sub

    Private Sub LinkLabelOpenModule_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelOpenModule.LinkClicked
        ShowSelectTestForm()
    End Sub

    Private Sub LinkLabelAddNew_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelAddNew.LinkClicked
        ShowSelectTestForm()
    End Sub

    Private Sub LinkLabelAddPrevious_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub
End Class

