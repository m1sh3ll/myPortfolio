VERSION 5.00
Begin VB.Form frmAbout 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   3  'Fixed Dialog
   ClientHeight    =   3165
   ClientLeft      =   5385
   ClientTop       =   6930
   ClientWidth     =   6195
   ClipControls    =   0   'False
   Icon            =   "frmAbout.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2184.54
   ScaleMode       =   0  'User
   ScaleWidth      =   5817.425
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox picIcon 
      Appearance      =   0  'Flat
      AutoSize        =   -1  'True
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   0  'None
      ClipControls    =   0   'False
      ForeColor       =   &H80000008&
      Height          =   480
      Left            =   75
      Picture         =   "frmAbout.frx":0442
      ScaleHeight     =   337.12
      ScaleMode       =   0  'User
      ScaleWidth      =   337.12
      TabIndex        =   1
      Top             =   60
      Width           =   480
   End
   Begin VB.CommandButton cmdOK 
      Appearance      =   0  'Flat
      BackColor       =   &H00FF0000&
      Cancel          =   -1  'True
      Caption         =   "&Close"
      Default         =   -1  'True
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   405
      Left            =   2340
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   2700
      Width           =   1560
   End
   Begin VB.Label lblTestQueen 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Web site:  http://www.nerdomcertexams.com"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   -1  'True
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   270
      Left            =   540
      TabIndex        =   6
      Top             =   1020
      Width           =   5160
   End
   Begin VB.Label lblDescription 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Contact email: support@nerdom.net"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   780
      TabIndex        =   2
      Top             =   720
      Width           =   4455
      WordWrap        =   -1  'True
   End
   Begin VB.Label lblTitle 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Application Title"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   750
      TabIndex        =   4
      Top             =   75
      Width           =   1545
   End
   Begin VB.Label lblVersion 
      BackStyle       =   0  'Transparent
      Caption         =   "Version"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   225
      Left            =   750
      TabIndex        =   5
      Top             =   375
      Width           =   3885
   End
   Begin VB.Label lblDisclaimer 
      Alignment       =   2  'Center
      Appearance      =   0  'Flat
      BackColor       =   &H00E0E0E0&
      BorderStyle     =   1  'Fixed Single
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   1245
      Left            =   330
      TabIndex        =   3
      Top             =   1380
      Width           =   5655
      WordWrap        =   -1  'True
   End
End
Attribute VB_Name = "frmAbout"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
     
Option Explicit
Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" _
              (ByVal hwnd As Long, ByVal lpOperation As String, _
               ByVal lpFile As String, ByVal lpParameters As String, _
               ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
Private Const SW_SHOW = 1

Private Sub Navigate(ByVal NavTo As String)
      Dim hBrowse As Long
      hBrowse = ShellExecute(0&, "open", NavTo, "", "", SW_SHOW)
End Sub

Private Sub cmdOK_Click()
Unload Me
End Sub

Private Sub Form_Load()
     Me.Caption = "About " & "Nerdom Cert Exams"
     lblVersion.Caption = "Version " & "6" & "." & "0"
     lblTitle.Caption = "Nerdom Cert Exams"
     lblDisclaimer.Caption = "This product is not sponsored or endorsed by any of the vendor exams in this program. All copyrights are owned by the trademark owners." & vbCrLf & vbCrLf
     lblDisclaimer.Caption = lblDisclaimer.Caption & "© 2005 Nerdom Software"
     
End Sub

Private Sub lblTestQueen_Click()
     Navigate "http://www.nerdomcertexams.com"
End Sub
