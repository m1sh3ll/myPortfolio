VERSION 5.00
Object = "{F8F9FBF9-12B5-11D4-8ED3-00E07D815373}#1.0#0"; "MBScroll.ocx"
Begin VB.Form frmReview 
   BackColor       =   &H00E0E0E0&
   Caption         =   "Nerdom Cert Exams Review"
   ClientHeight    =   7515
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   10395
   Icon            =   "frmReview.frx":0000
   LinkTopic       =   "Form1"
   MinButton       =   0   'False
   ScaleHeight     =   7515
   ScaleWidth      =   10395
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdNoNotes 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "Items w/ No Notes"
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
      Left            =   6180
      Style           =   1  'Graphical
      TabIndex        =   26
      ToolTipText     =   "Click to end the exam and show your score printout."
      Top             =   7080
      Width           =   1980
   End
   Begin VB.CommandButton cmdNotes 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "Items w/Notes"
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
      Left            =   6180
      Style           =   1  'Graphical
      TabIndex        =   25
      ToolTipText     =   "Click to end the exam and show your score printout."
      Top             =   6660
      Width           =   1980
   End
   Begin VB.CommandButton cmdBack 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "Back"
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
      Left            =   8400
      Style           =   1  'Graphical
      TabIndex        =   6
      ToolTipText     =   "Click to end the exam and show your score printout."
      Top             =   120
      Width           =   1980
   End
   Begin VB.CommandButton cmdReviewUnmarked 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "Review UnMarked"
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
      TabIndex        =   24
      ToolTipText     =   "Click to end the exam and show your score printout."
      Top             =   7080
      Width           =   1980
   End
   Begin VB.Frame Frame1 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      BorderStyle     =   0  'None
      Caption         =   "Frame1"
      ForeColor       =   &H80000008&
      Height          =   915
      Left            =   0
      TabIndex        =   15
      Top             =   0
      Width           =   10400
      Begin VB.Line Line2 
         BorderColor     =   &H00808080&
         BorderWidth     =   3
         X1              =   0
         X2              =   10400
         Y1              =   840
         Y2              =   840
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Click the Question to Review"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   240
         Left            =   3840
         TabIndex        =   23
         Top             =   600
         Width           =   5265
      End
      Begin VB.Label lblMarked 
         BackStyle       =   0  'Transparent
         Caption         =   "Marked"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   240
         Left            =   660
         TabIndex        =   22
         Top             =   600
         Width           =   765
      End
      Begin VB.Label Label3 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Answered"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   1440
         TabIndex        =   21
         Top             =   600
         Width           =   840
      End
      Begin VB.Label lblCorrectTitle 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Correct"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   2340
         TabIndex        =   20
         Top             =   600
         Width           =   630
      End
      Begin VB.Label lblNotesTitle 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Notes"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   3120
         TabIndex        =   19
         Top             =   600
         Width           =   510
      End
      Begin VB.Label Label6 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "QID"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   75
         TabIndex        =   18
         Top             =   600
         Width           =   375
      End
      Begin VB.Label lblYourScore 
         AutoSize        =   -1  'True
         BackColor       =   &H00800000&
         Caption         =   "   Review Exam"
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
         TabIndex        =   16
         Top             =   120
         Width           =   10425
         WordWrap        =   -1  'True
      End
      Begin VB.Line Line1 
         BorderColor     =   &H00808080&
         BorderWidth     =   3
         X1              =   0
         X2              =   10500
         Y1              =   480
         Y2              =   480
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
         TabIndex        =   17
         Top             =   0
         Width           =   10425
         WordWrap        =   -1  'True
      End
   End
   Begin VB.CommandButton cmdReviewAnswered 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "Review Answered"
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
      Left            =   4140
      Style           =   1  'Graphical
      TabIndex        =   14
      ToolTipText     =   "Click to end the exam and show your score printout."
      Top             =   6660
      Width           =   1980
   End
   Begin VB.CommandButton cmdReviewCorrect 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Cancel          =   -1  'True
      Caption         =   "Review Correct"
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
      Left            =   2100
      Style           =   1  'Graphical
      TabIndex        =   13
      ToolTipText     =   "Click to end the exam and show your score printout."
      Top             =   6660
      Width           =   1980
   End
   Begin VB.CommandButton cmdReviewAll 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "Review &All"
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
      Left            =   8400
      Style           =   1  'Graphical
      TabIndex        =   12
      ToolTipText     =   "Click to end the exam and show your score printout."
      Top             =   6660
      Width           =   1920
   End
   Begin VB.CommandButton cmdReviewIncorrect 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "Review Incorrect"
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
      Left            =   2100
      Style           =   1  'Graphical
      TabIndex        =   11
      ToolTipText     =   "Click to end the exam and show your score printout."
      Top             =   7080
      Width           =   1980
   End
   Begin VB.CommandButton cmdReviewUnanswered 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "Review UnAnswered"
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
      Left            =   4140
      Style           =   1  'Graphical
      TabIndex        =   10
      ToolTipText     =   "Click to end the exam and show your score printout."
      Top             =   7080
      Width           =   1980
   End
   Begin VB.CommandButton cmdReviewMarked 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "Review Marked"
      Enabled         =   0   'False
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
      TabIndex        =   9
      ToolTipText     =   "Click to end the exam and show your score printout."
      Top             =   6660
      Width           =   1980
   End
   Begin VB.CommandButton cmdScoreTest 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "Score Test"
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
      Height          =   375
      Left            =   8400
      Style           =   1  'Graphical
      TabIndex        =   4
      ToolTipText     =   "Click to end the exam and show your score printout."
      Top             =   7080
      Width           =   1920
   End
   Begin MBScroller.Scroller Scroller1 
      Height          =   5730
      Left            =   0
      TabIndex        =   0
      Top             =   840
      Width           =   10395
      _ExtentX        =   18336
      _ExtentY        =   10107
      BackColor       =   16777215
      ScrollBars      =   2
      Begin VB.CheckBox chkMarked 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   225
         Index           =   1
         Left            =   780
         TabIndex        =   1
         Top             =   120
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Label lblQuestionNo 
         BackStyle       =   0  'Transparent
         Caption         =   "#"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   240
         Index           =   1
         Left            =   60
         TabIndex        =   8
         Top             =   120
         Width           =   525
      End
      Begin VB.Label lblCorrect 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "No"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   315
         Index           =   1
         Left            =   2280
         TabIndex        =   7
         Top             =   90
         Visible         =   0   'False
         Width           =   735
      End
      Begin VB.Label lblAnswered 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "No"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   315
         Index           =   1
         Left            =   1500
         TabIndex        =   5
         Top             =   90
         Width           =   735
      End
      Begin VB.Label lblNotes 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Notes"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   -1  'True
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00C00000&
         Height          =   225
         Index           =   1
         Left            =   3120
         TabIndex        =   3
         Top             =   90
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.Label lblAnswer 
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         Caption         =   "Correct"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   -1  'True
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   225
         Index           =   1
         Left            =   3840
         TabIndex        =   2
         Top             =   90
         Visible         =   0   'False
         Width           =   6135
         WordWrap        =   -1  'True
      End
   End
End
Attribute VB_Name = "frmReview"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private mMarkedQuesCount As Integer
Private mUnMarkedQuesCount As Integer
Private mCorrect As Integer
Private mInCorrect As Integer
Private mAnswered As Integer
Private mUnAnswered As Integer
Private mNotesCount As Integer
Private mNoNotesCount As Integer

Private Sub chkMarked_Click(Index As Integer)

         If chkMarked(Index).Value = 0 Then
              M_MARKED(Index) = 0
            Else: M_MARKED(Index) = 1
            End If
            
            ReCountMarkedQuestions
End Sub

    Sub ReCountMarkedQuestions()
        Dim intindex As Integer
        On Error Resume Next
        mMarkedQuesCount = 0
        mUnMarkedQuesCount = 0
        
        For intindex = 1 To M_INTNUMOFQUESTIONS
                If M_MARKED(intindex) = 0 Then
                    chkMarked(intindex).Value = 0
                    mUnMarkedQuesCount = mUnMarkedQuesCount + 1
                Else
                    chkMarked(intindex).Value = 1
                    mMarkedQuesCount = mMarkedQuesCount + 1
                End If
        Next
        
        If mMarkedQuesCount > 0 Then
            cmdReviewMarked.Enabled = True
        Else: cmdReviewMarked.Enabled = False
        End If
        
        If mUnMarkedQuesCount > 0 Then
            cmdReviewUnmarked.Enabled = True
        Else: cmdReviewUnmarked.Enabled = False
        End If
        
        'MsgBox ("Marked " & mMarkedQuesCount & " Unmarked: " & mUnMarkedQuesCount)
        
    End Sub
    Private Sub ReCountNotes()
        Dim intindex As Integer
        On Error Resume Next
        mNotesCount = 0
        mNoNotesCount = 0
        
        For intindex = 1 To M_INTNUMOFQUESTIONS
                If M_NOTES(intindex) = "" Then
                    mNoNotesCount = mNoNotesCount + 1
                Else: mNotesCount = mNotesCount + 1
                End If
        Next
        
        If mNotesCount > 0 Then
            cmdNotes.Enabled = True
        Else: cmdNotes.Enabled = False
        End If
        
        If mNoNotesCount > 0 Then
            cmdNoNotes.Enabled = True
        Else: cmdNoNotes.Enabled = False
        End If
        
        'MsgBox ("Notes: " & mNotesCount & " No Notes: " & mNoNotesCount)
    End Sub
    
Private Sub cmdNoNotes_Click()
Dim i As Integer
        REVIEWINGnoNOTES_MODE = True
        For i = 1 To M_INTNUMOFQUESTIONS
            If M_NOTES(i) = "" Then 'find first ques without notes
                M_CURRENTRECORD = i
                Exit For
            End If
        Next
        
        Call lblAnswer_Click(M_CURRENTRECORD)
End Sub

Private Sub cmdNotes_Click()
        Dim i As Integer
        REVIEWINGNOTES_MODE = True
        For i = 1 To M_INTNUMOFQUESTIONS
            If M_NOTES(i) <> "" Then 'find first ques with containing notes.
                M_CURRENTRECORD = i
                Exit For
            End If
        Next
        
        Call lblAnswer_Click(M_CURRENTRECORD)
End Sub

Private Sub cmdReviewAll_Click()
           
        M_CURRENTRECORD = 1 'set to form mintcurrentrecord
        ANOTHERFORMSHOWN = False
        Unload frmPrintPreview
        Me.Hide
End Sub

Private Sub cmdReviewAnswered_Click()
    Dim i As Integer
    REVIEWINGANSWERED_MODE = True
    For i = 1 To M_INTNUMOFQUESTIONS
        If M_UNANSWERED(i) = 0 Then         'Find the First Answered Ques.
            M_CURRENTRECORD = i
            Exit For
        End If
    Next
    
    Call lblAnswer_Click(M_CURRENTRECORD)   'Go to that Question
End Sub

Private Sub cmdReviewCorrect_Click()

    Dim i As Integer
    REVIEWINGCORRECT_MODE = True
    For i = 1 To M_INTNUMOFQUESTIONS
        If M_INTANSWERS(i) = 1 Then          'Find the First Correctly Answered Ques.
            M_CURRENTRECORD = i
            Exit For
        End If
    Next
    
    Call lblAnswer_Click(M_CURRENTRECORD)   'Go to that Question

End Sub

Private Sub cmdReviewIncorrect_Click()

        Dim i As Integer
        REVIEWINGinCORRECT_MODE = True
        For i = 1 To M_INTNUMOFQUESTIONS
            If M_INTANSWERS(i) = 0 Then             'Find the First Incorrectly Ans. Ques.
                M_CURRENTRECORD = i
                Exit For
            End If
        Next
    
        Call lblAnswer_Click(M_CURRENTRECORD)   'Go to that Question
End Sub

Private Sub cmdReviewMarked_Click()
    
    Dim i As Integer
    REVIEWINGMARKED_MODE = True
    For i = 1 To M_INTNUMOFQUESTIONS
        If M_MARKED(i) = 1 Then             'Find the First Marked Question
            M_CURRENTRECORD = i
            Exit For
        End If
    Next
    
    Call lblAnswer_Click(M_CURRENTRECORD)   'Go to That Question

End Sub

Private Sub cmdReviewUnanswered_Click()

    Dim i As Integer
    REVIEWINGunANSWERED_MODE = True
    For i = 1 To M_INTNUMOFQUESTIONS
        If M_UNANSWERED(i) = 1 Then         'Find the First UnAnswered Ques.
            M_CURRENTRECORD = i
            Exit For
        End If
    Next
    
    Call lblAnswer_Click(M_CURRENTRECORD)   'Go to that Question
End Sub

Private Sub cmdReviewUnmarked_Click()

        Dim i As Integer
        REVIEWINGunMARKED_MODE = True
        For i = 1 To M_INTNUMOFQUESTIONS
            If M_MARKED(i) = 0 Then             'FInd the First UnMarked Ques.
                M_CURRENTRECORD = i
                Exit For
            End If
        Next
    
        Call lblAnswer_Click(M_CURRENTRECORD)   'Go to That Question
End Sub

    Private Sub cmdScoreTest_Click()

                M_INTSCORE = 0
                M_INTSCORE = (M_NUMBERCORRECT / M_INTNUMOFQUESTIONS) * 100
                frmPrintPreview.Show 'vbModal
    End Sub

    Private Sub Form_Activate()
    
        Dim intindex As Integer
        
        ANOTHERFORMSHOWN = True
        
        'Display Correct, Notes, Answered Status
        For intindex = 1 To M_INTNUMOFQUESTIONS
                             
                If M_UNANSWERED(intindex) = 0 Then          'If answered True
                        lblAnswered(intindex).Caption = "Yes"
                Else
                        lblAnswered(intindex).Caption = "No"        'if Unanswered
                End If
                
                If M_INTANSWERS(intindex) = 0 Then
                    lblCorrect(intindex).Caption = "No"
                Else
                    lblCorrect(intindex).Caption = "Yes"
                End If
                
                If M_NOTES(intindex) <> "" Then
                    lblNotes(intindex).Visible = True
                Else
                    lblNotes(intindex).Visible = False
                End If
                
        Next
        
        ReCountMarkedQuestions
        ReCountCorrect
        ReCountAnswered
        ReCountNotes
    End Sub

    Sub ReCountCorrect()
     Dim intindex As Integer
        On Error Resume Next
        mCorrect = 0
        mInCorrect = 0
        
        For intindex = 1 To M_INTNUMOFQUESTIONS
                If M_INTANSWERS(intindex) = 0 Then
                    mInCorrect = mInCorrect + 1
                Else
                    mCorrect = mCorrect + 1
                End If
        Next
        
        If mCorrect > 0 Then
            cmdReviewCorrect.Enabled = True
        Else
            cmdReviewCorrect.Enabled = False
        End If
        
        If mInCorrect > 0 Then
            cmdReviewIncorrect.Enabled = True
        Else
            cmdReviewIncorrect.Enabled = False
        End If
        
        'MsgBox ("correct " & mCorrect & " Incorrect: " & mInCorrect)
    End Sub
    Sub ReCountAnswered()
        Dim intindex As Integer
        On Error Resume Next
        mAnswered = 0
        mUnAnswered = 0
        
        For intindex = 1 To M_INTNUMOFQUESTIONS
                If M_UNANSWERED(intindex) = 1 Then
                    mUnAnswered = mUnAnswered + 1
                Else
                    mAnswered = mAnswered + 1
                End If
        Next
        
        If mAnswered > 0 Then
            cmdReviewAnswered.Enabled = True
        Else
            cmdReviewAnswered.Enabled = False
        End If
        
        If mUnAnswered > 0 Then
            cmdReviewUnanswered.Enabled = True
        Else
            cmdReviewUnanswered.Enabled = False
        End If
        
       'MsgBox ("Answered: " & mAnswered & " Unanswered: " & mUnAnswered)
    
    End Sub
    
    Private Sub Form_Load()
        Dim intindex As Integer
        M_FORMCAPTION = "REVIEW MODE"
        ANOTHERFORMSHOWN = True
        Me.BackColor = M_BACKCOLOR
        cmdScoreTest.BackColor = M_BUTTONCOLOR
        cmdBack.BackColor = M_BUTTONCOLOR
        cmdReviewAll.BackColor = M_BUTTONCOLOR
        cmdReviewAnswered.BackColor = M_BUTTONCOLOR
        cmdReviewCorrect.BackColor = M_BUTTONCOLOR
        cmdReviewIncorrect.BackColor = M_BUTTONCOLOR
        cmdReviewMarked.BackColor = M_BUTTONCOLOR
        cmdReviewUnanswered.BackColor = M_BUTTONCOLOR
        cmdReviewUnmarked.BackColor = M_BUTTONCOLOR
        cmdNotes.BackColor = M_BUTTONCOLOR
        cmdNoNotes.BackColor = M_BUTTONCOLOR
        
        'The following code will dynamically create an array of labels,
        'one for each question asked
       
        intindex = 1
    
    Do While intindex <= M_INTNUMOFQUESTIONS 'for each question
    
        If intindex <> 1 Then Load lblAnswer(intindex)  'first label is on form already, so every
        If intindex <> 1 Then Load chkMarked(intindex) 'control after the first gets generated
        If intindex <> 1 Then Load lblNotes(intindex)
        If intindex <> 1 Then Load lblAnswered(intindex)
        If intindex <> 1 Then Load lblCorrect(intindex)
        If intindex <> 1 Then Load lblQuestionNo(intindex)
                
        If intindex > 1 Then 'move generated controls underneath the previous ones
            lblAnswer(intindex).Left = lblAnswer(intindex - 1).Left
            lblAnswer(intindex).Top = lblAnswer(intindex - 1).Top + (lblAnswer(intindex - 1).Height + 75)
            chkMarked(intindex).Left = chkMarked(intindex - 1).Left
            chkMarked(intindex).Top = lblAnswer(intindex).Top
            lblNotes(intindex).Left = lblNotes(intindex - 1).Left
            lblNotes(intindex).Top = lblAnswer(intindex).Top
            lblAnswered(intindex).Left = lblAnswered(intindex - 1).Left
            lblAnswered(intindex).Top = lblAnswer(intindex).Top
            lblCorrect(intindex).Left = lblCorrect(intindex - 1).Left
            lblCorrect(intindex).Top = lblAnswer(intindex).Top
            lblQuestionNo(intindex).Left = lblQuestionNo(intindex - 1).Left
            lblQuestionNo(intindex).Top = lblAnswer(intindex).Top
        End If
        
            lblQuestionNo(intindex).Caption = CStr(intindex) & ")"
            
            If M_MARKED(intindex) = 0 Then
                    chkMarked(intindex).Value = 0
            Else: chkMarked(intindex).Value = 1
            End If
            
            If M_UNANSWERED(intindex) = 0 Then          'If answered True
                    lblAnswered(intindex).Caption = "Yes"
            Else: lblAnswered(intindex).Caption = "No"        'if Unanswered
            End If
            
            If M_INTANSWERS(intindex) = 0 Then
                lblCorrect(intindex).Caption = "No"
            Else: lblCorrect(intindex).Caption = "Yes"
            End If
            
            lblAnswer(intindex).Caption = M_STRQUESTION(intindex)
            
            'Color Even Numbered Labels
            If intindex Mod 2 = 0 Then lblAnswer(intindex).BackColor = &HE0E0E0
               
            'Make the controls visible depending on Start Options
            lblQuestionNo(intindex).Visible = True
            If M_MARKFORREVIEW = True Then chkMarked(intindex).Visible = True
            lblAnswered(intindex).Visible = True
            
            If M_CORRECTINREVIEW = True Then
                lblCorrect(intindex).Visible = True
            Else: lblNotes(intindex).Left = lblNotesTitle.Left
            End If
            
            If M_ADDNOTESBUTTON = True Then
                If M_NOTES(intindex) <> "" Then lblNotes(intindex).Visible = True
            End If
            
            lblAnswer(intindex).Visible = True
            intindex = intindex + 1
    Loop
    
        If M_MARKFORREVIEW = False Then
            lblMarked.Visible = False
            cmdReviewMarked.Visible = False
            cmdReviewUnmarked.Visible = False
        End If
        If M_ADDNOTESBUTTON = False Then
            lblNotesTitle.Visible = False
            cmdNotes.Visible = False
            cmdNoNotes.Visible = False
        End If
        
        If M_CORRECTINREVIEW = False Then
                lblCorrectTitle.Visible = False
                lblNotesTitle.Left = lblCorrectTitle.Left
        End If
        
        If M_REVIEWMARKEDITEMS = False Then cmdReviewMarked.Visible = False
        If M_REVIEWUNMARKEDITEMS = False Then cmdReviewUnmarked.Visible = False
        If M_REVIEWCORRECTITEMS = False Then cmdReviewCorrect.Visible = False
        If M_REVIEWINCORRECTITEMS = False Then cmdReviewIncorrect.Visible = False
        If M_REVIEWANSWEREDITEMS = False Then cmdReviewAnswered.Visible = False
        If M_REVIEWUNANSWEREDITEMS = False Then cmdReviewUnanswered.Visible = False
        
    End Sub
    
    Private Sub lblAnswer_Click(Index As Integer)
            
        M_CURRENTRECORD = Index 'set to form mintcurrentrecord
        ANOTHERFORMSHOWN = False
        Unload frmPrintPreview
        Me.Hide
 
    End Sub
    
    Private Sub lblNotes_Click(Index As Integer)
        M_CURRENTNOTE = Index
        frmNotes.Show vbModal
    End Sub
    
    Private Sub cmdBack_Click()
    
            Unload Me
    End Sub
    
    Private Sub Form_Unload(Cancel As Integer)
            
        ANOTHERFORMSHOWN = False
        Unload frmPrintPreview

    End Sub
