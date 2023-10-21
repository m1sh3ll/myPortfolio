Imports System.IO

Public Class frmParent
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        fParent = Me
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
    Friend WithEvents sbMain As System.Windows.Forms.StatusBar
    Friend WithEvents mmuMain As System.Windows.Forms.MainMenu
    Friend WithEvents mmuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mmuOpenSaved As System.Windows.Forms.MenuItem
    Friend WithEvents mmuFileExit As System.Windows.Forms.MenuItem
    Friend WithEvents mmuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents mmuHelpAbout As System.Windows.Forms.MenuItem
    Friend WithEvents ilsImages As System.Windows.Forms.ImageList
    Friend WithEvents tmrTimer As System.Windows.Forms.Timer
    Friend WithEvents pnl1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents pnlCurrentRecord As System.Windows.Forms.StatusBarPanel
    Friend WithEvents pnlRecordCount As System.Windows.Forms.StatusBarPanel
    Friend WithEvents pnlDate As System.Windows.Forms.StatusBarPanel
    Friend WithEvents pnlTime As System.Windows.Forms.StatusBarPanel
    Friend WithEvents mmuOpenMain As System.Windows.Forms.MenuItem
    Friend WithEvents mnuUserGuide As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmParent))
        Me.ilsImages = New System.Windows.Forms.ImageList(Me.components)
        Me.sbMain = New System.Windows.Forms.StatusBar()
        Me.pnl1 = New System.Windows.Forms.StatusBarPanel()
        Me.pnlCurrentRecord = New System.Windows.Forms.StatusBarPanel()
        Me.pnlRecordCount = New System.Windows.Forms.StatusBarPanel()
        Me.pnlDate = New System.Windows.Forms.StatusBarPanel()
        Me.pnlTime = New System.Windows.Forms.StatusBarPanel()
        Me.mmuMain = New System.Windows.Forms.MainMenu()
        Me.mmuFile = New System.Windows.Forms.MenuItem()
        Me.mmuOpenMain = New System.Windows.Forms.MenuItem()
        Me.mmuOpenSaved = New System.Windows.Forms.MenuItem()
        Me.mmuFileExit = New System.Windows.Forms.MenuItem()
        Me.mmuHelp = New System.Windows.Forms.MenuItem()
        Me.mmuHelpAbout = New System.Windows.Forms.MenuItem()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.mnuUserGuide = New System.Windows.Forms.MenuItem()
        CType(Me.pnl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlCurrentRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlRecordCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ilsImages
        '
        Me.ilsImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ilsImages.ImageSize = New System.Drawing.Size(16, 16)
        Me.ilsImages.ImageStream = CType(resources.GetObject("ilsImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilsImages.TransparentColor = System.Drawing.Color.Transparent
        '
        'sbMain
        '
        Me.sbMain.Location = New System.Drawing.Point(0, 535)
        Me.sbMain.Name = "sbMain"
        Me.sbMain.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.pnl1, Me.pnlCurrentRecord, Me.pnlRecordCount, Me.pnlDate, Me.pnlTime})
        Me.sbMain.ShowPanels = True
        Me.sbMain.Size = New System.Drawing.Size(792, 22)
        Me.sbMain.TabIndex = 2
        Me.sbMain.Text = "StatusBar1"
        '
        'pnl1
        '
        Me.pnl1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.pnl1.Width = 411
        '
        'pnlDate
        '
        Me.pnlDate.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlTime
        '
        Me.pnlTime.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.pnlTime.Width = 65
        '
        'mmuMain
        '
        Me.mmuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mmuFile, Me.mmuHelp})
        '
        'mmuFile
        '
        Me.mmuFile.Index = 0
        Me.mmuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mmuOpenMain, Me.mmuOpenSaved, Me.mmuFileExit})
        Me.mmuFile.MergeOrder = 1
        Me.mmuFile.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mmuFile.Text = "File"
        '
        'mmuOpenMain
        '
        Me.mmuOpenMain.Index = 0
        Me.mmuOpenMain.Text = "Show Background Menu"
        '
        'mmuOpenSaved
        '
        Me.mmuOpenSaved.Index = 1
        Me.mmuOpenSaved.Text = "Show Main Menu"
        '
        'mmuFileExit
        '
        Me.mmuFileExit.Index = 2
        Me.mmuFileExit.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mmuFileExit.Text = "Exit"
        '
        'mmuHelp
        '
        Me.mmuHelp.Index = 1
        Me.mmuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuUserGuide, Me.mmuHelpAbout})
        Me.mmuHelp.MergeOrder = 3
        Me.mmuHelp.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mmuHelp.Text = "Help"
        '
        'mmuHelpAbout
        '
        Me.mmuHelpAbout.Index = 1
        Me.mmuHelpAbout.Text = "About"
        '
        'tmrTimer
        '
        Me.tmrTimer.Enabled = True
        Me.tmrTimer.Interval = 60000
        '
        'mnuUserGuide
        '
        Me.mnuUserGuide.Index = 0
        Me.mnuUserGuide.Text = "User Guide (.pdf)"
        '
        'frmParent
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 557)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.sbMain})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.mmuMain
        Me.Name = "frmParent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QueenEdit 2004"
        CType(Me.pnl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlCurrentRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlRecordCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Sub LoadStartupForms()
        Me.Text = Application.ProductName

        pnlDate.Text = System.DateTime.Today.ToShortDateString
        pnlTime.Text = System.DateTime.Now.ToShortTimeString

        Dim FM As New frmMain(), FS As New frmSelectTest()
        FM.Show()
        FS.Show()
    End Sub
    Sub ShowAboutForm()
        Dim FA As New frmAbout()
        FA.Show()
    End Sub
    Sub ShowMainForm()
        Dim fM As New frmMain()
        fM.Show()
    End Sub
    Sub UpdateDateTimeBar()
        pnlDate.Text = System.DateTime.Today.ToShortDateString
        pnlTime.Text = System.DateTime.Now.ToShortTimeString
    End Sub
    Sub ShowSelectTestForm()
        Dim FL As New frmSelectTest()
        FL.Show()
    End Sub

    Private Sub frmParent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LoadStartupForms()
    End Sub
    Private Sub mmuHelpAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mmuHelpAbout.Click
        Me.ShowAboutForm()
    End Sub
    Private Sub mmuFileExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mmuFileExit.Click
        End
    End Sub
    Private Sub tmrTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrTimer.Tick
        Me.UpdateDateTimeBar()
    End Sub
    Private Sub mmuOpenSaved_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mmuOpenSaved.Click
        Me.ShowSelectTestForm()
    End Sub

    Private Sub mmuOpenMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmuOpenMain.Click
        ShowMainForm()
    End Sub

    Private Sub mnuUserGuide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUserGuide.Click
        Call Navigate(Application.StartupPath & "\" & "FunctionalUser.pdf")
    End Sub
End Class
