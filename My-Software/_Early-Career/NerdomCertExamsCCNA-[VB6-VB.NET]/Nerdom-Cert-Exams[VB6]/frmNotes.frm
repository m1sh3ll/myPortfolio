VERSION 5.00
Begin VB.Form frmNotes 
   BackColor       =   &H00E0E0E0&
   ClientHeight    =   5220
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6030
   Icon            =   "frmNotes.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   5220
   ScaleWidth      =   6030
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdClear 
      BackColor       =   &H00B05800&
      Caption         =   "&Erase Notes"
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
      Left            =   1980
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   4740
      Width           =   1335
   End
   Begin VB.TextBox txtNotes 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   4215
      Left            =   60
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   2
      Top             =   420
      Width           =   5895
   End
   Begin VB.CommandButton cmdCancel 
      BackColor       =   &H00B05800&
      Cancel          =   -1  'True
      Caption         =   "&Cancel"
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
      Left            =   4620
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   4740
      Width           =   1335
   End
   Begin VB.CommandButton cmdSave 
      BackColor       =   &H00B05800&
      Caption         =   "&Save / Hide"
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
      Left            =   60
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   4740
      Width           =   1755
   End
   Begin VB.Label lblNotes 
      AutoSize        =   -1  'True
      BackColor       =   &H00800000&
      Caption         =   "  Exam Notes"
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
      TabIndex        =   4
      Top             =   60
      Width           =   8355
      WordWrap        =   -1  'True
   End
   Begin VB.Line Line1 
      BorderColor     =   &H00808080&
      BorderWidth     =   3
      X1              =   0
      X2              =   8400
      Y1              =   420
      Y2              =   420
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
      TabIndex        =   5
      Top             =   0
      Width           =   8355
      WordWrap        =   -1  'True
   End
End
Attribute VB_Name = "frmNotes"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
    Option Explicit
    
    Private Sub cmdCancel_Click()
        Unload Me
    End Sub
    
    Private Sub cmdClose_Click()
    Unload Me
    End Sub
    
Private Sub cmdClear_Click()
txtNotes.Text = ""
End Sub

    Private Sub cmdSave_Click()
        M_NOTES(M_CURRENTNOTE) = txtNotes.Text 'NOTES FOR QUESTION (NUMBER)
        Unload Me
    End Sub
    
    
    Private Sub Form_Load()
        Me.Caption = "Notes For Question " & M_CURRENTNOTE & " of " & M_INTNUMOFQUESTIONS
        txtNotes.Text = M_NOTES(M_CURRENTNOTE)
        With txtNotes
              .Font = M_FONTDISPLAY
              .FontSize = M_FONTSIZE
              .FontBold = M_FONTBOLD
              .FontItalic = M_FONTITALIC
        End With
        cmdCancel.BackColor = M_BUTTONCOLOR
        cmdSave.BackColor = M_BUTTONCOLOR
        cmdClear.BackColor = M_BUTTONCOLOR
        
        Me.BackColor = M_BACKCOLOR
    End Sub
