Public Class frmImage
    Inherits System.Windows.Forms.Form
    Private mImageFile As String

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pImage As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        mImageFile = pImage
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents picImageBox As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmImage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.picImageBox = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnClose, Me.picImageBox})
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 455)
        Me.Panel1.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.LightGray
        Me.btnClose.Location = New System.Drawing.Point(565, 425)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(60, 25)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        '
        'picImageBox
        '
        Me.picImageBox.BackColor = System.Drawing.Color.Transparent
        Me.picImageBox.Location = New System.Drawing.Point(5, 5)
        Me.picImageBox.Name = "picImageBox"
        Me.picImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picImageBox.TabIndex = 1
        Me.picImageBox.TabStop = False
        '
        'frmImage
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(632, 455)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Panel1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmImage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Image Preview - QueenEdit 2004"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmImage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mImageFile <> "" Then
            picImageBox.Image = System.Drawing.Image.FromFile(fFULLMODULEPATH & mImageFile)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
