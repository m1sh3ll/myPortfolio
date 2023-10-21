VERSION 5.00
Object = "{F8F9FBF9-12B5-11D4-8ED3-00E07D815373}#1.0#0"; "MBScroll.ocx"
Begin VB.Form frmExplanation 
   BackColor       =   &H00E0E0E0&
   Caption         =   "Explanation"
   ClientHeight    =   6540
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9510
   Icon            =   "frmExplanation.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   6540
   ScaleWidth      =   9510
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdClose 
      BackColor       =   &H00B05800&
      Cancel          =   -1  'True
      Caption         =   "&Continue >"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   435
      Left            =   3960
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   6000
      Width           =   1575
   End
   Begin VB.Frame frameCorrectInc 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   5865
      Left            =   60
      TabIndex        =   0
      Top             =   60
      Width           =   9400
      Begin MBScroller.Scroller Scroller1 
         Height          =   5655
         Left            =   120
         TabIndex        =   2
         Top             =   120
         Width           =   9195
         _ExtentX        =   16219
         _ExtentY        =   9975
         BorderStyle     =   0
         BackColor       =   16777215
         ScrollBars      =   2
         Begin VB.Label lblCorrectInc 
            Alignment       =   2  'Center
            AutoSize        =   -1  'True
            BackColor       =   &H00FFFFFF&
            BackStyle       =   0  'Transparent
            Caption         =   "Incorrect!"
            BeginProperty Font 
               Name            =   "Microsoft Sans Serif"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H000000C0&
            Height          =   240
            Left            =   840
            TabIndex        =   14
            Top             =   60
            Width           =   975
         End
         Begin VB.Label lblStatusCorrect 
            AutoSize        =   -1  'True
            BackColor       =   &H00FFFFFF&
            BackStyle       =   0  'Transparent
            Caption         =   "Status:"
            BeginProperty Font 
               Name            =   "Microsoft Sans Serif"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00800000&
            Height          =   240
            Left            =   60
            TabIndex        =   13
            Top             =   60
            Width           =   705
         End
         Begin VB.Label lblQuestion 
            Appearance      =   0  'Flat
            AutoSize        =   -1  'True
            BackColor       =   &H00FFFFFF&
            BeginProperty Font 
               Name            =   "Microsoft Sans Serif"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H80000008&
            Height          =   240
            Left            =   60
            TabIndex        =   12
            Top             =   900
            Width           =   8685
            WordWrap        =   -1  'True
         End
         Begin VB.Label lblTitleQuestion 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Question..."
            BeginProperty Font 
               Name            =   "Microsoft Sans Serif"
               Size            =   11.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00800000&
            Height          =   270
            Left            =   60
            TabIndex        =   11
            Top             =   480
            Width           =   1245
         End
         Begin VB.Label lblIncorrectAnswer 
            Appearance      =   0  'Flat
            AutoSize        =   -1  'True
            BackColor       =   &H00FFFFFF&
            BeginProperty Font 
               Name            =   "Microsoft Sans Serif"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H80000008&
            Height          =   240
            Left            =   60
            TabIndex        =   10
            Top             =   3180
            Width           =   8685
            WordWrap        =   -1  'True
         End
         Begin VB.Label lblTitleIncorrectAnswer 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Incorrect Answer(s)..."
            BeginProperty Font 
               Name            =   "Microsoft Sans Serif"
               Size            =   11.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00800000&
            Height          =   270
            Left            =   60
            TabIndex        =   9
            Top             =   2700
            Width           =   2445
         End
         Begin VB.Label lblCorrectAnswer 
            Appearance      =   0  'Flat
            AutoSize        =   -1  'True
            BackColor       =   &H00FFFFFF&
            BeginProperty Font 
               Name            =   "Microsoft Sans Serif"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H80000008&
            Height          =   240
            Left            =   60
            TabIndex        =   8
            Top             =   1680
            Width           =   8670
            WordWrap        =   -1  'True
         End
         Begin VB.Label lblTitleCorrectAnswer 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Correct Answer..."
            BeginProperty Font 
               Name            =   "Microsoft Sans Serif"
               Size            =   11.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00800000&
            Height          =   270
            Left            =   60
            TabIndex        =   7
            Top             =   1260
            Width           =   1980
         End
         Begin VB.Label lblQuestionIDNumber 
            Appearance      =   0  'Flat
            BackColor       =   &H00E0E0E0&
            DataField       =   "QID"
            DataSource      =   "Data1"
            BeginProperty Font 
               Name            =   "Microsoft Sans Serif"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H80000008&
            Height          =   300
            Left            =   7380
            TabIndex        =   6
            Top             =   60
            Width           =   1395
         End
         Begin VB.Label lblQuestionID 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Question ID..."
            BeginProperty Font 
               Name            =   "Microsoft Sans Serif"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00800000&
            Height          =   240
            Left            =   5925
            TabIndex        =   5
            Top             =   120
            Width           =   1380
         End
         Begin VB.Label lblExplanationTitle 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Explanation..."
            BeginProperty Font 
               Name            =   "Microsoft Sans Serif"
               Size            =   11.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00800000&
            Height          =   270
            Left            =   60
            TabIndex        =   4
            Top             =   1980
            Width           =   1530
         End
         Begin VB.Label lblExplanation 
            Appearance      =   0  'Flat
            AutoSize        =   -1  'True
            BackColor       =   &H00FFFFFF&
            BeginProperty Font 
               Name            =   "Microsoft Sans Serif"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H80000008&
            Height          =   240
            Left            =   60
            TabIndex        =   3
            Top             =   2400
            Width           =   8685
            WordWrap        =   -1  'True
         End
      End
   End
End
Attribute VB_Name = "frmExplanation"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
    Option Explicit
    
    Private Sub cmdClose_Click()
        Unload Me
    End Sub
    
    Private Sub Form_Load()
    
        Me.Caption = "Question " & M_CURRENTEXPLANATIONNUM & " - Explanation"
        lblCorrectInc.Caption = M_ANSWERSTATUS
        
        'QUESTION...
        lblQuestion.Caption = M_STRQUESTION(M_CURRENTEXPLANATIONNUM)
        lblQuestion.Top = lblTitleQuestion.Top + lblTitleQuestion.Height + 75
        lblQuestion.Width = 8685
        'CORRECT ANSWER....
        lblTitleCorrectAnswer.Top = lblQuestion.Top + lblQuestion.Height + 120
        lblTitleCorrectAnswer.Width = lblQuestion.Width
        lblCorrectAnswer.Caption = M_ANSWER
        lblCorrectAnswer.Top = lblTitleCorrectAnswer.Top + lblTitleCorrectAnswer.Height + 75
        lblCorrectAnswer.Width = lblQuestion.Width
        'EXPLANATION....
        lblExplanationTitle.Top = lblCorrectAnswer.Top + lblCorrectAnswer.Height + 120
        lblExplanation.Caption = M_EXPLANATION
        lblExplanation.Top = lblExplanationTitle.Top + lblExplanationTitle.Height + 75
        lblExplanation.Width = lblQuestion.Width
        'INCORRECT ANSWER(S).... not in labs
        lblTitleIncorrectAnswer.Top = lblExplanation.Top + lblExplanation.Height + 120
        lblTitleIncorrectAnswer.Width = lblExplanation.Width
        lblIncorrectAnswer.Caption = M_INCORRECTANSWER
        lblIncorrectAnswer.Top = lblTitleIncorrectAnswer.Top + lblTitleIncorrectAnswer.Height + 75
        lblIncorrectAnswer.Width = lblExplanation.Width
        
        lblQuestionIDNumber = M_QID
        Me.BackColor = M_BACKCOLOR
        cmdClose.BackColor = M_BUTTONCOLOR
        
        If M_EXAMTYPE = "L" Or M_QUESTYPE = "i" Then
            lblIncorrectAnswer.Visible = False
            lblTitleIncorrectAnswer.Visible = False
        End If
    End Sub
    
    Private Sub lblQuestionIDNumber_Click()
    
    MsgBox "Please send comments on any question id to michelle@nerdom.net " & vbCrLf _
    & "include the question id number if applicable."
    
    End Sub
