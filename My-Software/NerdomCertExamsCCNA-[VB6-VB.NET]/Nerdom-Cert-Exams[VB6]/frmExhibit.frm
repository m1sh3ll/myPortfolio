VERSION 5.00
Object = "{F8F9FBF9-12B5-11D4-8ED3-00E07D815373}#1.0#0"; "MBScroll.ocx"
Begin VB.Form frmExhibit 
   BackColor       =   &H00E0E0E0&
   ClientHeight    =   6045
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8355
   Icon            =   "frmExhibit.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   6045
   ScaleWidth      =   8355
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdClose 
      BackColor       =   &H00B05800&
      Cancel          =   -1  'True
      Caption         =   "&Hide Exhibit"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   6840
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   5580
      Width           =   1395
   End
   Begin MBScroller.Scroller Scroller1 
      Height          =   5055
      Left            =   60
      TabIndex        =   0
      Top             =   480
      Width           =   8235
      _ExtentX        =   14526
      _ExtentY        =   8916
      BackColor       =   16777215
      ScrollBarsColor =   14737632
      Begin VB.PictureBox Picture1 
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H00FFFFFF&
         BorderStyle     =   0  'None
         ForeColor       =   &H80000008&
         Height          =   4560
         Left            =   120
         ScaleHeight     =   4560
         ScaleWidth      =   6825
         TabIndex        =   1
         Top             =   120
         Width           =   6825
      End
   End
   Begin VB.Line Line1 
      BorderColor     =   &H00808080&
      BorderWidth     =   3
      X1              =   0
      X2              =   8400
      Y1              =   420
      Y2              =   420
   End
   Begin VB.Label lblNotes 
      AutoSize        =   -1  'True
      BackColor       =   &H00800000&
      Caption         =   "   Exhibit"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   15.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   360
      Left            =   0
      TabIndex        =   3
      Top             =   60
      Width           =   8355
      WordWrap        =   -1  'True
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      BackColor       =   &H00404040&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   15.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   360
      Left            =   0
      TabIndex        =   4
      Top             =   0
      Width           =   8355
      WordWrap        =   -1  'True
   End
End
Attribute VB_Name = "frmExhibit"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
    Option Explicit
    
    Private Sub cmdClose_Click()
    
        Unload Me
    End Sub
    
    Private Sub Form_Activate()
    
     Picture1.Picture = LoadPicture(M_EXHIBITPATH)
    End Sub
    
    Private Sub Form_Load()
    
        Me.Caption = "Question " & M_CURRENTEXHIBITQUESNO & " - Exhibit"
      cmdClose.BackColor = M_BUTTONCOLOR
      Me.BackColor = M_BACKCOLOR
       
    End Sub
