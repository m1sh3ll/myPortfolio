VERSION 5.00
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "Comdlg32.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{F8F9FBF9-12B5-11D4-8ED3-00E07D815373}#1.0#0"; "MBScroll.ocx"
Begin VB.Form frmMain 
   BackColor       =   &H00C0FFFF&
   Caption         =   "This is a test for Jet 4 and VB Runtime"
   ClientHeight    =   2190
   ClientLeft      =   60
   ClientTop       =   315
   ClientWidth     =   2955
   LinkTopic       =   "Form1"
   ScaleHeight     =   2190
   ScaleWidth      =   2955
   StartUpPosition =   3  'Windows Default
   Begin VB.CheckBox Check1 
      Caption         =   "Check1"
      Height          =   315
      Left            =   2520
      TabIndex        =   12
      Top             =   60
      Width           =   195
   End
   Begin VB.OptionButton Option1 
      Caption         =   "Option1"
      Height          =   375
      Left            =   2160
      TabIndex        =   11
      Top             =   420
      Width           =   255
   End
   Begin MBScroller.Scroller Scroller1 
      Height          =   675
      Left            =   2280
      TabIndex        =   10
      Top             =   1380
      Width           =   555
      _ExtentX        =   979
      _ExtentY        =   1191
      ScrollBars      =   2
   End
   Begin VB.Frame Frame1 
      Caption         =   "Frame1"
      Height          =   375
      Left            =   1680
      TabIndex        =   9
      Top             =   1800
      Width           =   375
   End
   Begin VB.PictureBox Picture1 
      Height          =   255
      Left            =   1020
      ScaleHeight     =   195
      ScaleWidth      =   555
      TabIndex        =   8
      Top             =   1740
      Width           =   615
   End
   Begin VB.ListBox List1 
      Height          =   255
      Left            =   1800
      TabIndex        =   7
      Top             =   60
      Width           =   615
   End
   Begin VB.ComboBox Combo1 
      Height          =   315
      Left            =   2160
      TabIndex        =   6
      Text            =   "Combo1"
      Top             =   900
      Width           =   555
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Command1"
      Height          =   315
      Left            =   240
      TabIndex        =   5
      Top             =   1740
      Width           =   675
   End
   Begin VB.TextBox Text1 
      Height          =   315
      Left            =   1860
      TabIndex        =   4
      Text            =   "Text1"
      Top             =   1620
      Width           =   615
   End
   Begin VB.Timer Timer1 
      Left            =   2340
      Top             =   420
   End
   Begin MSComDlg.CommonDialog CommonDialog2 
      Left            =   1200
      Top             =   120
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin MSComctlLib.ProgressBar ProgressBar1 
      Height          =   375
      Left            =   1080
      TabIndex        =   3
      Top             =   1320
      Width           =   855
      _ExtentX        =   1508
      _ExtentY        =   661
      _Version        =   393216
      Appearance      =   1
   End
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   480
      Top             =   480
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      MaskColor       =   12632256
      _Version        =   393216
   End
   Begin MSComctlLib.ListView ListView1 
      Height          =   375
      Left            =   240
      TabIndex        =   2
      Top             =   1320
      Width           =   855
      _ExtentX        =   1508
      _ExtentY        =   661
      LabelWrap       =   -1  'True
      HideSelection   =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      NumItems        =   0
   End
   Begin RichTextLib.RichTextBox RichTextBox1 
      Height          =   255
      Left            =   120
      TabIndex        =   1
      Top             =   120
      Width           =   855
      _ExtentX        =   1508
      _ExtentY        =   450
      _Version        =   393217
      TextRTF         =   $"frmMain.frx":0000
   End
   Begin VB.Data Data1 
      Caption         =   "Click these arrows to test Jet 4"
      Connect         =   "Access 2000;"
      DatabaseName    =   "db001.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   0
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "Q1"
      Top             =   1050
      Width           =   2115
   End
   Begin VB.Image Image1 
      Height          =   555
      Left            =   2280
      Top             =   1200
      Width           =   435
   End
   Begin VB.Label lblQuestion 
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   1  'Fixed Single
      DataField       =   "Ques"
      DataSource      =   "Data1"
      Height          =   615
      Left            =   0
      TabIndex        =   0
      Top             =   450
      Width           =   2115
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit


Private Sub Form_Unload(Cancel As Integer)
End
End Sub
