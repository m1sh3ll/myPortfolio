VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmNet2 
   BackColor       =   &H00E0E0E0&
   ClientHeight    =   7035
   ClientLeft      =   4800
   ClientTop       =   5505
   ClientWidth     =   9465
   Icon            =   "frmNet2.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   ScaleHeight     =   7035
   ScaleWidth      =   9465
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdScoreTest 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "S&core Test"
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
      TabIndex        =   33
      ToolTipText     =   "Click to end the exam and show your score printout."
      Top             =   6540
      Width           =   1650
   End
   Begin VB.Frame fraAnswer 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Answer "
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   660
      Left            =   60
      TabIndex        =   21
      Top             =   5400
      Visible         =   0   'False
      Width           =   9285
      Begin VB.Label lblInputA 
         Appearance      =   0  'Flat
         BackColor       =   &H00FFFFFF&
         BackStyle       =   0  'Transparent
         DataField       =   "InputAnswer"
         DataSource      =   "Data1"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   345
         Left            =   150
         TabIndex        =   22
         Top             =   225
         Width           =   9000
      End
   End
   Begin VB.CommandButton cmdNotes 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "Add N&otes"
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
      Left            =   7860
      Style           =   1  'Graphical
      TabIndex        =   23
      ToolTipText     =   "Click to add notes to use during the exam and print later."
      Top             =   6540
      Width           =   1530
   End
   Begin VB.CommandButton cmdShowAnswer 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Cancel          =   -1  'True
      Caption         =   "Show &Answer"
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
      Left            =   1620
      Style           =   1  'Graphical
      TabIndex        =   24
      ToolTipText     =   "Click to show the answer for this question."
      Top             =   6540
      Width           =   1545
   End
   Begin VB.CommandButton cmdSubmit 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "&Save Answer"
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
      Left            =   1620
      Style           =   1  'Graphical
      TabIndex        =   3
      ToolTipText     =   "Click this button to Submit your answer. Or click Next."
      Top             =   6120
      Width           =   1575
   End
   Begin VB.CommandButton cmdShowExplanation 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "&Explanation"
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
      TabIndex        =   4
      Top             =   6540
      Width           =   1515
   End
   Begin VB.CommandButton cmdShow 
      BackColor       =   &H00B05800&
      Caption         =   "E&xhibit"
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
      Left            =   7860
      Style           =   1  'Graphical
      TabIndex        =   5
      ToolTipText     =   "Click to show the exhibit image for this question."
      Top             =   6120
      Width           =   1530
   End
   Begin VB.CommandButton cmdForward 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "&Next >>"
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
      Left            =   3240
      Style           =   1  'Graphical
      TabIndex        =   2
      ToolTipText     =   "Click to submit your answer and go to the next question."
      Top             =   6120
      Width           =   1365
   End
   Begin VB.CommandButton cmdReview 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "Re&view Items"
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
      TabIndex        =   8
      ToolTipText     =   "Click to end the exam and show your score printout."
      Top             =   6135
      Width           =   1650
   End
   Begin VB.Data Data1 
      Caption         =   "Data1"
      Connect         =   "Access 2000;"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   4200
      Options         =   0
      ReadOnly        =   -1  'True
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   5580
      Visible         =   0   'False
      Width           =   1290
   End
   Begin VB.Frame frameBackground 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   5715
      Left            =   120
      TabIndex        =   9
      Top             =   300
      Width           =   9285
      Begin VB.Frame fraQues 
         Appearance      =   0  'Flat
         BackColor       =   &H00000000&
         BorderStyle     =   0  'None
         Caption         =   "                                                                      "
         ForeColor       =   &H80000008&
         Height          =   6015
         Index           =   0
         Left            =   0
         TabIndex        =   10
         Top             =   0
         Width           =   10095
         Begin VB.TextBox txtRouterOutput 
            BackColor       =   &H00000000&
            BorderStyle     =   0  'None
            DataField       =   "RouterOutput"
            DataSource      =   "Data1"
            BeginProperty Font 
               Name            =   "Lucida Console"
               Size            =   9
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00C0C0C0&
            Height          =   3400
            Left            =   150
            Locked          =   -1  'True
            MaxLength       =   25500
            MultiLine       =   -1  'True
            ScrollBars      =   2  'Vertical
            TabIndex        =   17
            Top             =   2160
            Visible         =   0   'False
            Width           =   9150
         End
         Begin VB.TextBox txtInput 
            Appearance      =   0  'Flat
            BackColor       =   &H00000000&
            BorderStyle     =   0  'None
            CausesValidation=   0   'False
            BeginProperty Font 
               Name            =   "Lucida Console"
               Size            =   9
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00C0C0C0&
            Height          =   300
            Left            =   2250
            MaxLength       =   254
            TabIndex        =   1
            ToolTipText     =   "Input your answer here and Click Submit Answer or press Enter."
            Top             =   1800
            Width           =   6500
         End
         Begin VB.TextBox txtQuesN1 
            Appearance      =   0  'Flat
            BackColor       =   &H00FFFFFF&
            BorderStyle     =   0  'None
            DataField       =   "Ques"
            DataSource      =   "Data1"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   12
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   1305
            Left            =   75
            Locked          =   -1  'True
            MultiLine       =   -1  'True
            ScrollBars      =   2  'Vertical
            TabIndex        =   0
            Text            =   "frmNet2.frx":0442
            Top             =   75
            Width           =   9090
         End
         Begin VB.Frame Frame1 
            BackColor       =   &H00000000&
            BorderStyle     =   0  'None
            Caption         =   "Frame1"
            Height          =   3735
            Left            =   150
            TabIndex        =   18
            Top             =   1800
            Width           =   8845
            Begin VB.Label lblRouter 
               AutoSize        =   -1  'True
               BackColor       =   &H00000000&
               DataField       =   "RouterPrompt"
               DataSource      =   "Data1"
               BeginProperty Font 
                  Name            =   "Lucida Console"
                  Size            =   9
                  Charset         =   0
                  Weight          =   700
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               ForeColor       =   &H00C0C0C0&
               Height          =   180
               Left            =   10
               TabIndex        =   19
               Top             =   0
               Width           =   120
            End
         End
         Begin VB.PictureBox Image1 
            BackColor       =   &H00000000&
            Height          =   4350
            Left            =   0
            Picture         =   "frmNet2.frx":044A
            ScaleHeight     =   4290
            ScaleWidth      =   9240
            TabIndex        =   29
            Top             =   1425
            Width           =   9300
         End
      End
   End
   Begin VB.Timer Timer1 
      Interval        =   60000
      Left            =   9000
      Top             =   1500
   End
   Begin VB.CommandButton cmdPrevious 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "<< &Previous"
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
      TabIndex        =   26
      ToolTipText     =   "Click to submit your answer and go to the next question."
      Top             =   6120
      Width           =   1485
   End
   Begin MSComctlLib.ProgressBar progressBar1 
      Height          =   195
      Left            =   3180
      TabIndex        =   6
      Top             =   15
      Width           =   2175
      _ExtentX        =   3836
      _ExtentY        =   344
      _Version        =   393216
      BorderStyle     =   1
      Appearance      =   0
   End
   Begin VB.CheckBox chkMarkForReview 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Mark for Review"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   7680
      TabIndex        =   27
      Top             =   15
      Width           =   1800
   End
   Begin VB.Label lblPauseTimer 
      AutoSize        =   -1  'True
      BackColor       =   &H00FFFFFF&
      BackStyle       =   0  'Transparent
      Caption         =   "Pause Timer"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   -1  'True
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   195
      Left            =   4680
      TabIndex        =   35
      ToolTipText     =   "Click to pause the time Remaining."
      Top             =   6660
      Width           =   1050
   End
   Begin VB.Label lblHIDETIME 
      AutoSize        =   -1  'True
      BackColor       =   &H00FFFFFF&
      BackStyle       =   0  'Transparent
      Caption         =   "Hide Timer"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   -1  'True
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   195
      Left            =   3420
      TabIndex        =   34
      ToolTipText     =   "Click to hide the time Remaining."
      Top             =   6660
      Width           =   915
   End
   Begin VB.Label lblQuestionIDNumber 
      DataField       =   "QID"
      DataSource      =   "Data1"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   240
      Left            =   7020
      TabIndex        =   32
      Top             =   6480
      Visible         =   0   'False
      Width           =   1230
   End
   Begin VB.Label lblCorrectAnswer 
      Appearance      =   0  'Flat
      BackColor       =   &H00C0FFFF&
      BorderStyle     =   1  'Fixed Single
      DataField       =   "InputAnswer"
      DataSource      =   "Data1"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   450
      Left            =   6060
      TabIndex        =   31
      Top             =   6060
      Visible         =   0   'False
      Width           =   750
   End
   Begin VB.Label lblExplanation 
      Appearance      =   0  'Flat
      BackColor       =   &H00FFC5A2&
      BorderStyle     =   1  'Fixed Single
      DataField       =   "Explanation"
      DataSource      =   "Data1"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   495
      Left            =   2280
      TabIndex        =   30
      Top             =   6360
      Visible         =   0   'False
      Width           =   630
      WordWrap        =   -1  'True
   End
   Begin VB.Label lblCorrectInc 
      Alignment       =   2  'Center
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   270
      Left            =   240
      TabIndex        =   28
      Top             =   6480
      Visible         =   0   'False
      Width           =   1665
   End
   Begin VB.Label lblRouterOutput 
      BackColor       =   &H00FFFFFF&
      DataField       =   "RouterOutput"
      DataSource      =   "Data1"
      Height          =   435
      Left            =   5940
      TabIndex        =   25
      Top             =   6060
      Visible         =   0   'False
      Width           =   3075
   End
   Begin VB.Label lblExhibit 
      AutoSize        =   -1  'True
      Caption         =   "Exhibit"
      DataField       =   "Exhibit"
      DataSource      =   "Data1"
      ForeColor       =   &H00000000&
      Height          =   195
      Left            =   6480
      TabIndex        =   20
      Top             =   6060
      Visible         =   0   'False
      Width           =   465
   End
   Begin VB.Label lblExhibitNum 
      AutoSize        =   -1  'True
      Caption         =   "Exh nam"
      DataField       =   "ExhibitName"
      DataSource      =   "Data1"
      ForeColor       =   &H00000000&
      Height          =   195
      Left            =   6120
      TabIndex        =   16
      Top             =   6060
      Visible         =   0   'False
      Width           =   615
   End
   Begin VB.Label lblInputB 
      BackColor       =   &H00C0C0FF&
      DataField       =   "InputAnswer2"
      DataSource      =   "Data1"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   6180
      TabIndex        =   15
      Top             =   6180
      Visible         =   0   'False
      Width           =   2535
   End
   Begin VB.Label lblPercentCorrect 
      AutoSize        =   -1  'True
      BackColor       =   &H0000FFFF&
      BackStyle       =   0  'Transparent
      Caption         =   "Correct:  0%"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   195
      Left            =   6420
      TabIndex        =   7
      Top             =   15
      Width           =   1065
   End
   Begin VB.Label lblTimeRemainingDesc 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Time Left:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   195
      Left            =   60
      TabIndex        =   14
      ToolTipText     =   "Time Remaining"
      Top             =   15
      Width           =   840
   End
   Begin VB.Label lblTimeDiff 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "10000 Minutes"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   195
      Left            =   960
      TabIndex        =   13
      Top             =   15
      Width           =   1245
   End
   Begin VB.Label lblPercent 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "400 of 400"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   195
      Left            =   5400
      TabIndex        =   12
      Top             =   15
      Width           =   885
   End
   Begin VB.Label lblQuestionsSeen 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Question:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   195
      Left            =   2340
      TabIndex        =   11
      Top             =   15
      Width           =   795
   End
End
Attribute VB_Name = "frmNet2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
    Option Explicit
    
    Private mblnClickedSubmit As Boolean, mblnClickedShowAnswer As Boolean
    Private mblnClickedPrevious As Boolean, mblnClickedHideTime As Boolean
    Private mintTotalRecords As Integer, mintCurrentRecord As Integer
    Private mintCurrentRandQues As Integer
    Private mintUsedRandQuestions() As Integer
    Private mdbDAODB36 As Database
    Private mdaoRS As DAO.Recordset
    Private M_USER As String
    
    'FORM SPECIFIC
    Private m_FrmBG As String, m_txtBG As String, m_txtFG As String
    Private m_lblsTime As String, m_Fwd As String
    Private m_ShowHideExhib As String, m_ShowHideExp2 As String
    Private m_ScoreT As String, m_Submit As String
    Private m_Notes2AnswerBG As String
    
Private Sub chkMarkForReview_Click()
    If chkMarkForReview.Value = 1 Then
              M_MARKED(mintCurrentRecord) = 1
            Else
                M_MARKED(mintCurrentRecord) = 0
            End If
End Sub

    Private Sub Form_Load()
            M_USER = "U" & M_USERNAME
            
            ANOTHERFORMSHOWN = False
            M_INTSCORE = 0
            M_NUMBERCORRECT = 0
            
            mblnClickedSubmit = False
            mblnClickedShowAnswer = False
            mintCurrentRecord = 1
            ReDim mintUsedRandQuestions(1 To M_INTNUMOFQUESTIONS)  'Redim Array of "Used Questions"
            Me.Caption = M_FORMCAPTION
            progressBar1.Max = M_INTNUMOFQUESTIONS
            Call SetFormControlColors
            If M_SHOWEXPLANATIONBUTTON = False Then cmdShowExplanation.Visible = False
            If M_SHOWANSWERBUTTON = False Then cmdShowAnswer.Visible = False
            If M_SHOWPERCENTCORRECT = False Then lblPercentCorrect.Visible = False
            If M_SHOWPREVIOUSBUTTON = False Then cmdPrevious.Visible = False
            If M_ADDNOTESBUTTON = False Then cmdNotes.Visible = False
            If M_SCORETESTBUTTON = False Then cmdScoreTest.Visible = False
            If M_MARKFORREVIEW = False Then chkMarkForReview.Visible = False
            If M_PROGRESSBAR = False Then
                progressBar1.Visible = False
                lblQuestionsSeen.Left = 3180
                lblPercent.Left = lblQuestionsSeen.Left + lblQuestionsSeen.Width + 25
            Else
                progressBar1.Visible = True
                lblQuestionsSeen.Left = 2340
                lblPercent.Left = 5400
            End If
            
            If M_TIMEDTEST = False Then           '***** NO TIMED TEST *******
                Timer1.Enabled = False
                lblTimeDiff.Visible = False
                lblTimeRemainingDesc.Visible = False
                lblHIDETIME.Visible = False
                lblPauseTimer.Visible = False
            Else                               '****** TIMED TEST *******
                Timer1.Interval = 60000
                Timer1.Enabled = True
                 Call ShowTimeDiff
                 If M_HIDETIMER = True Then      'HIDE TIMER FEATURE
                     lblHIDETIME.Visible = True
                 Else: lblHIDETIME.Visible = False
                 End If
                 If M_PAUSETIMER = True Then
                     lblPauseTimer.Visible = True
                 Else: lblPauseTimer.Visible = False
                 End If
            End If
            
            If M_ITEMREVIEW = False Then cmdReview.Visible = False
            If M_ITEMREVIEW = False Then chkMarkForReview.Visible = False
    End Sub
    
    Public Sub Form_Activate() 'WHEN FORM RECEIVES FOCUS
        M_BUTTONCOLOR = cmdSubmit.BackColor
        M_BACKCOLOR = Me.BackColor 'NEW
        mblnClickedSubmit = False
        lblCorrectInc.Caption = ""
        
        If ANOTHERFORMSHOWN = False Then
            If IN_REVIEW_MODE = False Then
                OpenDAODataBase
                FirstQuestion
                cmdReview.Enabled = False
              
            End If
                
            If IN_REVIEW_MODE = True Then
                    Me.Caption = "REVIEW MODE"
                    'If in a specific Review Mode set the Form Caption
                     If REVIEWINGMARKED_MODE = True Then Me.Caption = Me.Caption & " - REVIEWING MARKED ITEMS"
                     If REVIEWINGunMARKED_MODE = True Then Me.Caption = Me.Caption & " - REVIEWING UNMARKED ITEMS"
                     If REVIEWINGCORRECT_MODE = True Then Me.Caption = Me.Caption & " - REVIEWING CORRECT ITEMS"
                     If REVIEWINGinCORRECT_MODE = True Then Me.Caption = Me.Caption & " - REVIEWING INCORRECT ITEMS"
                     If REVIEWINGANSWERED_MODE = True Then Me.Caption = Me.Caption & " - REVIEWING ANSWERED ITEMS"
                     If REVIEWINGunANSWERED_MODE = True Then Me.Caption = Me.Caption & " - REVIEWING UNANSWERED ITEMS"
                    If REVIEWINGNOTES_MODE = True Then Me.Caption = Me.Caption & " - REVIEWING ITEMS W/NOTES"
                    If REVIEWINGnoNOTES_MODE = True Then Me.Caption = Me.Caption & " - REVIEWING ITEMS W/OUT NOTES"
                   
                    cmdSubmit.Enabled = True
                    Data1.Recordset.MoveFirst
                    
                    If M_RANDOMQUESTIONS = True Then
                        Data1.Recordset.Move (M_QUESID(M_CURRENTRECORD))
                    Else
                        Data1.Recordset.Move (M_CURRENTRECORD - 1) 'added -1
                    End If
                    
                    mintCurrentRecord = M_CURRENTRECORD
                    'Call Data1_Reposition
                    
                    If mintCurrentRecord >= 1 And mintCurrentRecord < M_INTNUMOFQUESTIONS Then
                        cmdForward.Enabled = True
                        Else
                        cmdForward.Enabled = False
                    End If
                    
                     If mintCurrentRecord = 1 Then
                        cmdPrevious.Enabled = False
                    End If
            End If
            
            txtInput.Visible = True     'NOT IN PRACTICE EXAMS
            txtInput.Text = ""
    
        End If                                    'END IN REVIEW MODE = FALSE
        
        txtRouterOutput.Visible = False '0405
        Call Data1_Reposition
        
        If lblExhibit.Caption = "1" Then    'SHOW EXHIBIT BUTTON
            cmdShow.Enabled = True
            Else: cmdShow.Enabled = False
            End If
            
        If M_MARKED(mintCurrentRecord) = 0 Then
                chkMarkForReview.Value = 0
        Else
                chkMarkForReview.Value = 1
        End If
           If mblnClickedShowAnswer = True Then cmdShowAnswer_Click
        GetAnswer
 End Sub
 
 Sub OpenDAODataBase()
    
         Set mdbDAODB36 = DBEngine(0).OpenDatabase(M_DATABASEPATH)
         Set mdaoRS = mdbDAODB36.OpenRecordset("Q1")
         Set Data1.Recordset = mdaoRS
        Data1.Recordset.MoveLast                    'GET TOTAL # OF RECORDS
        mintTotalRecords = Data1.Recordset.RecordCount
        Call Data1_Reposition
    End Sub
    
    Private Sub Data1_Reposition()
                                                                                                   
            On Error Resume Next
            If mintCurrentRecord >= 1 Then
                progressBar1.Value = CInt(mintCurrentRecord)
                lblPercent.Caption = mintCurrentRecord & " of " & M_INTNUMOFQUESTIONS
                
                If M_MARKED(mintCurrentRecord) = 0 Then
                       chkMarkForReview.Value = 0
                Else
                       chkMarkForReview.Value = 1
                End If
                
                If mintCurrentRecord = 1 Then
                    cmdPrevious.Enabled = False
                Else
                    cmdPrevious.Enabled = True
                End If
                
                If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
                    cmdForward.Enabled = False
                Else
                    cmdForward.Enabled = True
                End If
            End If
            
         If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
            If M_ITEMREVIEW = False Then cmdScoreTest.Visible = True
         End If
    End Sub
    
    Private Sub cmdSubmit_Click()
        
        ANOTHERFORMSHOWN = False
        mblnClickedSubmit = True
        MarkForReview
        '************put into array ***********
         M_STRQUESTION(mintCurrentRecord) = txtQuesN1.Text
         M_STRANSWER(mintCurrentRecord) = lblInputA.Caption
         '************put into array ***********
        '************Review button********
        If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
            cmdReview.Enabled = True
            cmdForward.Enabled = False
        End If    '**************Review button*********
        If IN_REVIEW_MODE = True Then '*'IF IN REVIEW MODE
            M_NUMBERCORRECT = M_NUMBERCORRECT - 1   'SET NUMBER CORRECT - 1 to RE-MARK IT
        End If
        ScoreQuestion
       
        cmdSubmit.Enabled = False
        ShowPercentCorrect
        txtRouterOutput.Visible = True 'this form
        SaveAnswer
      End Sub
      
      Sub SaveAnswer() 'this form diff.
    
         If txtInput.Text <> "" Then
                            QUESTION(mintCurrentRecord).InputAnswer = txtInput.Text
                            M_UNANSWERED(mintCurrentRecord) = 0
                    Else
                            M_UNANSWERED(mintCurrentRecord) = 1 'UNANSWERED if ""
         End If
    End Sub
    
    Sub GetAnswer()
            txtInput.Text = QUESTION(mintCurrentRecord).InputAnswer
    End Sub
    
    Private Sub ScoreQuestion() '***********SCORE QUESTION AS RIGHT OR WRONG
      
        If (txtInput.Text = lblInputA.Caption) Or (txtInput.Text = lblInputB.Caption) Or _
              (LCase(txtInput.Text) = LCase(lblInputA.Caption)) Or (LCase(txtInput.Text) = LCase(lblInputB.Caption)) Then
                   M_INTANSWERS(mintCurrentRecord) = 1 'marks the answer as right
              Else: M_INTANSWERS(mintCurrentRecord) = 0 'marks the answer as wrong
              End If
              
              If M_INTANSWERS(mintCurrentRecord) = 1 Then
                    lblCorrectInc.Caption = "Correct!"
                    M_NUMBERCORRECT = M_NUMBERCORRECT + 1
               Else
              lblCorrectInc.Caption = "Incorrect!"
              End If
    End Sub
    
    Private Sub cmdForward_Click()
    
    FORWARD
    End Sub
    
  Private Sub FORWARD()
        Dim currec As Integer
        Dim i As Integer
        
        If mblnClickedSubmit = False Then Call cmdSubmit_Click
       ShowExplanation
 
        If mblnClickedShowAnswer = True Then cmdShowAnswer_Click
        lblCorrectInc.Caption = ""
        txtInput.Text = ""
        cmdSubmit.Enabled = True
        
        txtRouterOutput.Visible = False
        
         'Prepares to score the quiz if the Next Question is the Last Record
        If (mintCurrentRecord = (M_INTNUMOFQUESTIONS - 1)) Then
               cmdForward.Enabled = False
               cmdPrevious.Enabled = True
        Else: cmdPrevious.Enabled = True
        End If
        If mintCurrentRecord >= 1 And mintCurrentRecord < mintTotalRecords Then
           cmdPrevious.Enabled = True
        End If
        
        mintCurrentRecord = mintCurrentRecord + 1
        NextQuestion
        'checkmarkforreview - called from NextQ
        
        ''BEGIN NEW CODE FOR REVIEW MARKED ITEMS. THE FOLLOWING CODE WILL SEARCH
        'FOR THE MARKED ITEM TO GO TO STARTING ON CURRENT REC.
        'iF NO MORE ITEMS ARE MARKED, FRMREVIEW WILL LAUNCH
        'AND CODE UNDER THIS BLOCK WILL NOT EXECUTE.
        If REVIEWINGMARKED_MODE = True Then
       
        currec = mintCurrentRecord
                If M_RANDOMQUESTIONS = True Then 'IF RANDOMQUES
                        For i = currec To M_INTNUMOFQUESTIONS
                                If M_MARKED(i) = 0 Then
                                        If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
                                                Call ReviewClick '0402
                                                Exit For 'and execute code at the end of cmdforwardclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord + 1
                                        Data1.Recordset.MoveFirst
                                        Data1.Recordset.Move (M_QUESID(mintCurrentRecord))
                                Else    'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord '0402
                                        Exit For
                                End If
                        Next
                Else 'if NON RANDOM QUES
                        For i = currec To M_INTNUMOFQUESTIONS
                                If M_MARKED(i) = 0 Then
                                        If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
                                                Call ReviewClick '0402
                                                Exit For 'and execute code at the end of cmdforwardclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord + 1
                                        Data1.Recordset.MoveNext
                                Else        'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord
                                        Exit For
                                End If
                        Next
                End If
        End If 'end if reviewing marked mode = true
        '************************************************************************************************
         'NET1, NET2  FORWARD -UNMARKED

 'BEGIN NEW CODE FOR REVIEW unMARKED ITEMS. THE FOLLOWING CODE WILL SEARCH
        'FOR THE unMARKED ITEM TO GO TO STARTING ON CURRENT REC.
        'iF NO MORE ITEMS ARE unMARKED, FRMREVIEW WILL LAUNCH
        'AND CODE UNDER THIS BLOCK WILL NOT EXECUTE.

 If REVIEWINGunMARKED_MODE = True Then
        
        currec = mintCurrentRecord
                If M_RANDOMQUESTIONS = True Then 'IF RANDOMQUES
                        For i = currec To M_INTNUMOFQUESTIONS
                                If M_MARKED(i) = 1 Then 'if cur. item is marked for review, find next unmarked
                                        If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdforwardclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord + 1
                                        Data1.Recordset.MoveFirst
                                        Data1.Recordset.Move (M_QUESID(mintCurrentRecord))
                                Else    'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord '0402
                                        Exit For
                                End If
                        Next
                Else 'if NON RANDOM QUES
                        For i = currec To M_INTNUMOFQUESTIONS
                                If M_MARKED(i) = 1 Then 'if cur. item is marked for review, find next unmarked
                                        If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdforwardclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord + 1
                                        Data1.Recordset.MoveNext
                                Else        'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord '0402
                                        Exit For
                                End If
                        Next
                End If
        End If 'end if reviewing unmarked mode = true
        '*******************************************************************************


'NET1, NET2  FORWARD - CORRECT

 'BEGIN NEW CODE FOR REVIEW CORRECT ITEMS. THE FOLLOWING CODE WILL SEARCH
        'FOR THE CORRECT ITEM TO GO TO STARTING ON CURRENT REC.
        'iF NO MORE ITEMS ARE CORRECT, FRMREVIEW WILL LAUNCH
        'AND CODE UNDER THIS BLOCK WILL NOT EXECUTE.

 If REVIEWINGCORRECT_MODE = True Then
        
        currec = mintCurrentRecord
                If M_RANDOMQUESTIONS = True Then 'IF RANDOMQUES
                        For i = currec To M_INTNUMOFQUESTIONS
                                If M_INTANSWERS(i) = 0 Then 'if cur. item is graded incorrect, find next correct.
                                        If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdforwardclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord + 1
                                        Data1.Recordset.MoveFirst
                                        Data1.Recordset.Move (M_QUESID(mintCurrentRecord))
                                Else    'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord '0402
                                        Exit For
                                End If
                        Next
                Else 'if NON RANDOM QUES
                        For i = currec To M_INTNUMOFQUESTIONS
                                If M_INTANSWERS(i) = 0 Then 'if cur. item is graded incorrect find next correct.
                                        If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
                                                'Call cmdReview_Click
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdforwardclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord + 1
                                        Data1.Recordset.MoveNext
                                Else        'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord '0402
                                        Exit For
                                End If
                        Next
                End If
        End If 'end if reviewing correct mode = true
        '*******************************************************************************

'NET1, NET2  FORWARD - inCORRECT

 'BEGIN NEW CODE FOR REVIEW inCORRECT ITEMS. THE FOLLOWING CODE WILL SEARCH
        'FOR THE inCORRECT ITEM TO GO TO STARTING ON CURRENT REC.
        'iF NO MORE ITEMS ARE inCORRECT, FRMREVIEW WILL LAUNCH
        'AND CODE UNDER THIS BLOCK WILL NOT EXECUTE.

 If REVIEWINGinCORRECT_MODE = True Then
        
        currec = mintCurrentRecord
                If M_RANDOMQUESTIONS = True Then 'IF RANDOMQUES
                        For i = currec To M_INTNUMOFQUESTIONS
                                If M_INTANSWERS(i) = 1 Then 'if cur. item is graded correct, find next incorrect.
                                        If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdforwardclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord + 1
                                        Data1.Recordset.MoveFirst
                                        Data1.Recordset.Move (M_QUESID(mintCurrentRecord))
                                Else    'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord '0402
                                        Exit For
                                End If
                        Next
                Else 'if NON RANDOM QUES
                        For i = currec To M_INTNUMOFQUESTIONS
                                If M_INTANSWERS(i) = 1 Then 'if cur. item is graded correct find next incorrect.
                                        If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
                                                'Call cmdReview_Click
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdforwardclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord + 1
                                        Data1.Recordset.MoveNext
                                Else        'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord '0402
                                        Exit For
                                End If
                        Next
                End If
        End If 'end if reviewing incorrect mode = true
        '*******************************************************************************

'NET1, NET2  FORWARD - ANSWERED

 'BEGIN NEW CODE FOR REVIEW ANSWERED ITEMS. THE FOLLOWING CODE WILL SEARCH
        'FOR THE ANSWERED ITEM TO GO TO STARTING ON CURRENT REC.
        'iF NO MORE ITEMS ARE ANSWERED, FRMREVIEW WILL LAUNCH
        'AND CODE UNDER THIS BLOCK WILL NOT EXECUTE.

 If REVIEWINGANSWERED_MODE = True Then
        
        currec = mintCurrentRecord
                If M_RANDOMQUESTIONS = True Then 'IF RANDOMQUES
                        For i = currec To M_INTNUMOFQUESTIONS
                                If M_UNANSWERED(i) = 1 Then 'if cur. item is unanswered, find next answered.
                                        If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdforwardclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord + 1
                                        Data1.Recordset.MoveFirst
                                        Data1.Recordset.Move (M_QUESID(mintCurrentRecord))
                                Else    'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord '0402
                                        Exit For
                                End If
                        Next
                Else 'if NON RANDOM QUES
                        For i = currec To M_INTNUMOFQUESTIONS
                                If M_UNANSWERED(i) = 1 Then 'if cur. item is unanswered, find next answered.
                                        If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
                                                'Call cmdReview_Click
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdforwardclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord + 1
                                        Data1.Recordset.MoveNext
                                Else        'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord '0402
                                        Exit For
                                End If
                        Next
                End If
        End If 'end if reviewing Answered mode = true
        '*******************************************************************************
'NET1, NET2  FORWARD - UNANSWERED

 'BEGIN NEW CODE FOR REVIEW unANSWERED ITEMS. THE FOLLOWING CODE WILL SEARCH
        'FOR THE unANSWERED ITEM TO GO TO STARTING ON CURRENT REC.
        'iF NO MORE ITEMS ARE unANSWERED, FRMREVIEW WILL LAUNCH
        'AND CODE UNDER THIS BLOCK WILL NOT EXECUTE.

 If REVIEWINGunANSWERED_MODE = True Then
        
        currec = mintCurrentRecord
                If M_RANDOMQUESTIONS = True Then 'IF RANDOMQUES
                        For i = currec To M_INTNUMOFQUESTIONS
                                If M_UNANSWERED(i) = 0 Then 'if cur. item is answered, find next unanswered.
                                        If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdforwardclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord + 1
                                        Data1.Recordset.MoveFirst
                                        Data1.Recordset.Move (M_QUESID(mintCurrentRecord))
                                Else    'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord '0402
                                        Exit For
                                End If
                        Next
                Else 'if NON RANDOM QUES
                        For i = currec To M_INTNUMOFQUESTIONS
                                If M_UNANSWERED(i) = 0 Then 'if cur. item is answered, find next unanswered.
                                        If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
                                                'Call cmdReview_Click
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdforwardclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord + 1
                                        Data1.Recordset.MoveNext
                                Else        'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord '0402
                                        Exit For
                                End If
                        Next
                End If
        End If 'end if reviewing unanswered mode = true
        '*******************************************************************************
        'FORWARD - 'REVIEWING W/NOTES FRMNET1, NET2

''BEGIN NEW CODE FOR REVIEW ITEMS w/notes. THE FOLLOWING CODE WILL SEARCH
        'FOR THE ITEM w/notes TO GO TO STARTING ON CURRENT REC.
        'iF NO MORE ITEMS have notes, FRMREVIEW WILL LAUNCH
        'AND CODE UNDER THIS BLOCK WILL NOT EXECUTE.

        If REVIEWINGNOTES_MODE = True Then
       
        currec = mintCurrentRecord
                If M_RANDOMQUESTIONS = True Then 'IF RANDOMQUES
                        For i = currec To M_INTNUMOFQUESTIONS
                                If M_NOTES(i) = "" Then
                                        If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
                                                Call ReviewClick '0402
                                                Exit For 'and execute code at the end of cmdforwardclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord + 1
                                        Data1.Recordset.MoveFirst
                                        Data1.Recordset.Move (M_QUESID(mintCurrentRecord))
                                Else    'IF NOTES FOUND STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord '0402
                                        Exit For
                                End If
                        Next
                Else 'if NON RANDOM QUES
                        For i = currec To M_INTNUMOFQUESTIONS
                                If M_NOTES(i) = "" Then
                                        If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
                                                Call ReviewClick '0402
                                                Exit For 'and execute code at the end of cmdforwardclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord + 1
                                        Data1.Recordset.MoveNext
                                Else        'IF NOTES FOUND STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord
                                        Exit For
                                End If
                        Next
                End If
        End If 'end if reviewing NOTES mode = true
        '*************************************************************************************
        
        'FORWARD - 'REVIEWING W/OUT NOTES FRMNET1, NET2

''BEGIN NEW CODE FOR REVIEW ITEMS w/OUT notes. THE FOLLOWING CODE WILL SEARCH
        'FOR THE ITEM w/OUT notes TO GO TO STARTING ON CURRENT REC.
        'iF NO MORE ITEMS have NO notes, FRMREVIEW WILL LAUNCH
        'AND CODE UNDER THIS BLOCK WILL NOT EXECUTE.

        If REVIEWINGnoNOTES_MODE = True Then
       
        currec = mintCurrentRecord
                If M_RANDOMQUESTIONS = True Then 'IF RANDOMQUES
                        For i = currec To M_INTNUMOFQUESTIONS
                                If M_NOTES(i) <> "" Then
                                        If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
                                                Call ReviewClick '0402
                                                Exit For 'and execute code at the end of cmdforwardclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord + 1
                                        Data1.Recordset.MoveFirst
                                        Data1.Recordset.Move (M_QUESID(mintCurrentRecord))
                                Else    'IF NO NOTES FOUND STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord '0402
                                        Exit For
                                End If
                        Next
                Else 'if NON RANDOM QUES
                        For i = currec To M_INTNUMOFQUESTIONS
                                If M_NOTES(i) <> "" Then
                                        If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
                                                Call ReviewClick '0402
                                                Exit For 'and execute code at the end of cmdforwardclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord + 1
                                        Data1.Recordset.MoveNext
                                Else        'IF NO NOTES FOUND STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord
                                        Exit For
                                End If
                        Next
                End If
        End If 'end if reviewing NO NOTES mode = true
        '*************************************************************************************
        
        
        If lblExhibit.Caption = "1" Then
              cmdShow.Enabled = True
        Else: cmdShow.Enabled = False
        End If
        
        GetAnswer
        mblnClickedSubmit = False
        
        txtInput.Visible = True
        
  End Sub
        
        Private Sub cmdPrevious_Click()
    
        PREVIOUS
    End Sub
    
 Private Sub PREVIOUS()
    Dim i As Integer
    Dim currec As Integer
    
    mblnClickedPrevious = True
     If mblnClickedSubmit = False Then Call cmdSubmit_Click
     mblnClickedPrevious = False
     If mblnClickedShowAnswer = True Then cmdShowAnswer_Click
        
        'If mintCurrentRecord = 2 Then cmdPrevious.Enabled = False
     
        mintCurrentRecord = mintCurrentRecord - 1
        
        
        'PREV QUESTION***************************************
        If mintCurrentRecord = 1 Then
         cmdPrevious.Enabled = False
                If M_RANDOMQUESTIONS = True Then
                    Data1.Recordset.MoveFirst
                    Data1.Recordset.Move (M_QUESID(mintCurrentRecord))
                Else
                    Data1.Recordset.MoveFirst
                End If
        Else
            If M_RANDOMQUESTIONS = True Then
                Data1.Recordset.MoveFirst
                Data1.Recordset.Move (M_QUESID(mintCurrentRecord))
            Else
                Data1.Recordset.MovePrevious
            End If
        End If
        'END PREV QUESTION***********************************
        
        
        If M_MARKED(mintCurrentRecord) = 0 Then
                chkMarkForReview.Value = 0
        Else
                chkMarkForReview.Value = 1
        End If
        cmdSubmit.Enabled = True
        cmdForward.Enabled = True 'if you can go back you can go Fwd
        'Data1_Reposition
        
        ''[PREVIOUS BUTT. BEGIN NEW CODE FOR REVIEW MARKED ITEMS. THE FOLLOWING CODE WILL SEARCH
        'FOR THE MARKED ITEM TO GO TO STARTING ON CURRENT REC.
        'iF NO MORE ITEMS ARE MARKED, FRMREVIEW WILL LAUNCH
        'AND CODE UNDER THIS BLOCK WILL NOT EXECUTE.
        If REVIEWINGMARKED_MODE = True Then
        
        currec = mintCurrentRecord
                If M_RANDOMQUESTIONS = True Then 'IF RANDOMQUES
                        For i = currec To 1 Step -1
                                If M_MARKED(i) = 0 Then
                                        If mintCurrentRecord = 1 Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdforwardclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord - 1
                                        Data1.Recordset.MoveFirst
                                        Data1.Recordset.Move (M_QUESID(mintCurrentRecord))
                                Else    'IF IT IS MARKED STOP ON THIS QUESTION
                                          M_CURRENTRECORD = mintCurrentRecord '0402
                                        Exit For
                                End If
                        Next
                Else 'if NON RANDOM QUES
                       For i = currec To 1 Step -1
                                If M_MARKED(i) = 0 Then
                                        If mintCurrentRecord = 1 Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdforwardclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord - 1
                                        Data1.Recordset.MovePrevious
                                Else        'IF IT IS MARKED STOP ON THIS QUESTION
                                          M_CURRENTRECORD = mintCurrentRecord '0402
                                        Exit For
                                End If
                        Next
                End If
        End If 'end if reviewing marked mode = true
        '************************************************************************************************
        
'----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
'NET1, NET2  PREVIOUS -UNMARKED

 ''[PREVIOUS BUTT. BEGIN NEW CODE FOR REVIEW unMARKED ITEMS. THE FOLLOWING CODE WILL SEARCH
        'FOR THE unMARKED ITEM TO GO TO STARTING ON CURRENT REC.
        'iF NO MORE ITEMS ARE unMARKED, FRMREVIEW WILL LAUNCH
        'AND CODE UNDER THIS BLOCK WILL NOT EXECUTE.

        If REVIEWINGunMARKED_MODE = True Then
        
        currec = mintCurrentRecord
                If M_RANDOMQUESTIONS = True Then 'IF RANDOMQUES
                        For i = currec To 1 Step -1
                                If M_MARKED(i) = 1 Then 'if cur. item is marked for review, find the prev.  unmarked
                                        If mintCurrentRecord = 1 Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdpreviousclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord - 1
                                        Data1.Recordset.MoveFirst
                                        Data1.Recordset.Move (M_QUESID(mintCurrentRecord))
                                Else    'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord
                                        Exit For
                                End If
                        Next
                Else    'if NON RANDOM QUES
                       For i = currec To 1 Step -1
                                If M_MARKED(i) = 1 Then 'if cur. item is marked for review, find the prev.  unmarked
                                        If mintCurrentRecord = 1 Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdpreviousclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord - 1
                                        Data1.Recordset.MovePrevious
                                Else        'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord
                                        Exit For
                                End If
                        Next
                End If
        End If                  'end if reviewing unmarked mode = true
        '**************************************************************************
'NET1, NET2  PREVIOUS -CORRECT

 ''[PREVIOUS BUTT. BEGIN NEW CODE FOR REVIEW CORRECT ITEMS. THE FOLLOWING CODE WILL SEARCH
        'FOR THE CORRECT ITEM TO GO TO STARTING ON CURRENT REC.
        'iF NO MORE ITEMS ARE CORRECT, FRMREVIEW WILL LAUNCH
        'AND CODE UNDER THIS BLOCK WILL NOT EXECUTE.

        If REVIEWINGCORRECT_MODE = True Then
        
        currec = mintCurrentRecord
                If M_RANDOMQUESTIONS = True Then 'IF RANDOMQUES
                        For i = currec To 1 Step -1
                                If M_INTANSWERS(i) = 0 Then 'if cur. item is graded incorrect, find prev. correct.
                                        If mintCurrentRecord = 1 Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdpreviousclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord - 1
                                        Data1.Recordset.MoveFirst
                                        Data1.Recordset.Move (M_QUESID(mintCurrentRecord))
                                Else    'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord
                                        Exit For
                                End If
                        Next
                Else 'if NON RANDOM QUES
                       For i = currec To 1 Step -1
                                If M_INTANSWERS(i) = 0 Then 'if cur. item is graded incorrect, find prev. correct.
                                        If mintCurrentRecord = 1 Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdpreviousclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord - 1
                                        Data1.Recordset.MovePrevious
                                Else        'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord
                                        Exit For
                                End If
                        Next
                End If
        End If                  'end if reviewing correct mode = true
        '**************************************************************************

'NET1, NET2  PREVIOUS -inCORRECT

 ''[PREVIOUS BUTT. BEGIN NEW CODE FOR REVIEW inCORRECT ITEMS. THE FOLLOWING CODE WILL SEARCH
        'FOR THE inCORRECT ITEM TO GO TO STARTING ON CURRENT REC.
        'iF NO MORE ITEMS ARE inCORRECT, FRMREVIEW WILL LAUNCH
        'AND CODE UNDER THIS BLOCK WILL NOT EXECUTE.

        If REVIEWINGinCORRECT_MODE = True Then
        
        currec = mintCurrentRecord
                If M_RANDOMQUESTIONS = True Then 'IF RANDOMQUES
                        For i = currec To 1 Step -1
                                If M_INTANSWERS(i) = 1 Then 'if cur. item is graded correct, find prev. incorrect.
                                        If mintCurrentRecord = 1 Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdpreviousclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord - 1
                                        Data1.Recordset.MoveFirst
                                        Data1.Recordset.Move (M_QUESID(mintCurrentRecord))
                                Else    'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord
                                        Exit For
                                End If
                        Next
                Else 'if NON RANDOM QUES
                       For i = currec To 1 Step -1
                                If M_INTANSWERS(i) = 1 Then 'if cur. item is graded correct, find prev. incorrect.
                                        If mintCurrentRecord = 1 Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdpreviousclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord - 1
                                        Data1.Recordset.MovePrevious
                                Else        'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord
                                        Exit For
                                End If
                        Next
                End If
        End If                  'end if reviewing incorrect mode = true
        '**************************************************************************

'NET1, NET2  PREVIOUS -ANSWERED

 ''[PREVIOUS BUTT. BEGIN NEW CODE FOR REVIEW ANSWERED ITEMS. THE FOLLOWING CODE WILL SEARCH
        'FOR THE ANSWERED ITEM TO GO TO STARTING ON CURRENT REC.
        'iF NO MORE ITEMS ARE ANSWERED, FRMREVIEW WILL LAUNCH
        'AND CODE UNDER THIS BLOCK WILL NOT EXECUTE.

        If REVIEWINGANSWERED_MODE = True Then
        
        currec = mintCurrentRecord
                If M_RANDOMQUESTIONS = True Then 'IF RANDOMQUES
                        For i = currec To 1 Step -1
                                If M_UNANSWERED(i) = 1 Then 'if cur. item is unanswered, find prev. answered.
                                        If mintCurrentRecord = 1 Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdpreviousclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord - 1
                                        Data1.Recordset.MoveFirst
                                        Data1.Recordset.Move (M_QUESID(mintCurrentRecord))
                                Else    'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord
                                        Exit For
                                End If
                        Next
                Else 'if NON RANDOM QUES
                       For i = currec To 1 Step -1
                                If M_UNANSWERED(i) = 1 Then 'if cur. item is unanswered, find prev. answered.
                                        If mintCurrentRecord = 1 Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdpreviousclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord - 1
                                        Data1.Recordset.MovePrevious
                                Else        'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord
                                        Exit For
                                End If
                        Next
                End If
        End If                  'end if reviewing answered mode = true
        '**************************************************************************
'NET1, NET2  PREVIOUS -unANSWERED

 ''[PREVIOUS BUTT. BEGIN NEW CODE FOR REVIEW unANSWERED ITEMS. THE FOLLOWING CODE WILL SEARCH
        'FOR THE unANSWERED ITEM TO GO TO STARTING ON CURRENT REC.
        'iF NO MORE ITEMS ARE unANSWERED, FRMREVIEW WILL LAUNCH
        'AND CODE UNDER THIS BLOCK WILL NOT EXECUTE.

        If REVIEWINGunANSWERED_MODE = True Then
        
        currec = mintCurrentRecord
                If M_RANDOMQUESTIONS = True Then 'IF RANDOMQUES
                        For i = currec To 1 Step -1
                                If M_UNANSWERED(i) = 0 Then 'if cur. item is answered, find prev. unanswered.
                                        If mintCurrentRecord = 1 Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdpreviousclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord - 1
                                        Data1.Recordset.MoveFirst
                                        Data1.Recordset.Move (M_QUESID(mintCurrentRecord))
                                Else    'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord
                                        Exit For
                                End If
                        Next
                Else 'if NON RANDOM QUES
                       For i = currec To 1 Step -1
                                If M_UNANSWERED(i) = 0 Then 'if cur. item is answered, find prev. unanswered.
                                        If mintCurrentRecord = 1 Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdpreviousclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord - 1
                                        Data1.Recordset.MovePrevious
                                Else        'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord
                                        Exit For
                                End If
                        Next
                End If
        End If                  'end if reviewing unanswered mode = true
        '**************************************************************************

          ''[PREVIOUS BUTT. BEGIN NEW CODE FOR REVIEW ITEMS WITH NOTES. THE FOLLOWING CODE WILL SEARCH
        'FOR THE ITEM WITH NOTES TO GO BACK TO STARTING ON CURRENT REC.
        'iF NO MORE ITEMS HAVE NOTES, FRMREVIEW WILL LAUNCH
        'AND CODE UNDER THIS BLOCK WILL NOT EXECUTE.

        If REVIEWINGNOTES_MODE = True Then
    
        currec = mintCurrentRecord
                If M_RANDOMQUESTIONS = True Then 'IF RANDOMQUES
                        For i = currec To 1 Step -1
                                If M_NOTES(i) = "" Then 'IF NO NOTES, THEN FIND QUES W NOTES
                                        If mintCurrentRecord = 1 Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdPREVclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord - 1
                                        Data1.Recordset.MoveFirst
                                        Data1.Recordset.Move (M_QUESID(mintCurrentRecord))
                                Else    'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord
                                        Exit For
                                End If
                        Next
                Else 'if NON RANDOM QUES
                       For i = currec To 1 Step -1
                                If M_NOTES(i) = "" Then
                                        If mintCurrentRecord = 1 Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdPREVclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord - 1
                                        Data1.Recordset.MovePrevious
                                Else        'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord
                                        Exit For
                                End If
                        Next
                End If
        End If 'end if reviewing ITEMS W NOTES mode = true
        '************************************************************************************
          ''[PREVIOUS BUTT. BEGIN NEW CODE FOR REVIEW ITEMS WITHOUT NOTES. THE FOLLOWING CODE WILL SEARCH
        'FOR THE ITEM WITH NOTES TO GO BACK TO STARTING ON CURRENT REC.
        'iF NO MORE ITEMS HAVE NO NOTES, FRMREVIEW WILL LAUNCH
        'AND CODE UNDER THIS BLOCK WILL NOT EXECUTE.

        If REVIEWINGnoNOTES_MODE = True Then
    
        currec = mintCurrentRecord
                If M_RANDOMQUESTIONS = True Then 'IF RANDOMQUES
                        For i = currec To 1 Step -1
                                If M_NOTES(i) <> "" Then 'IF NOTES, THEN FIND QUES WOUT NOTES
                                        If mintCurrentRecord = 1 Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdPREVclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord - 1
                                        Data1.Recordset.MoveFirst
                                        Data1.Recordset.Move (M_QUESID(mintCurrentRecord))
                                Else    'IF IT IS MARKED STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord
                                        Exit For
                                End If
                        Next
                Else 'if NON RANDOM QUES
                       For i = currec To 1 Step -1
                                If M_NOTES(i) <> "" Then
                                        If mintCurrentRecord = 1 Then
                                                Call ReviewClick
                                                Exit For 'and execute code at the end of cmdPREVclick
                                        End If
                                        mintCurrentRecord = mintCurrentRecord - 1
                                        Data1.Recordset.MovePrevious
                                Else        'IF NO NOTES THEN STOP ON THIS QUESTION
                                        M_CURRENTRECORD = mintCurrentRecord
                                        Exit For
                                End If
                        Next
                End If
        End If 'end if reviewing ITEMS WOUT NOTES mode = true
        '************************************************************************************
        If M_MARKED(mintCurrentRecord) = 0 Then
                chkMarkForReview.Value = 0
        Else
                chkMarkForReview.Value = 1
        End If
        
        If lblExhibit.Caption = "1" Then    'SHOW EXHIBIT BUTTON
            cmdShow.Enabled = True
            Else: cmdShow.Enabled = False
            End If
       
        txtInput.Visible = True 'CODE FOR THIS FORM ONLY
        txtRouterOutput.Visible = False
        GetAnswer
        mblnClickedSubmit = False
    End Sub
    
     Sub FirstQuestion()
     
        If M_RANDOMQUESTIONS = True Then
                Call NextQuestionRandom
                M_QUESID(mintCurrentRecord) = mintUsedRandQuestions(mintCurrentRecord)
         Else
                Data1.Recordset.MoveFirst
                M_QUESID(mintCurrentRecord) = mintCurrentRecord
        End If
    End Sub
    
Private Sub NextQuestion() 'only pick a new random question to go to if the question wasnt seen
'starts on  record 2      'otherwise go to previous question > forward

        If M_RANDOMQUESTIONS = True Then
                        If M_QUESID(mintCurrentRecord) = 0 Then
                            Call NextQuestionRandom     'RANDOM 'mblnclickedprevious
                            M_QUESID(mintCurrentRecord) = mintUsedRandQuestions(mintCurrentRecord)
                        Else
                            Data1.Recordset.MoveFirst
                            Data1.Recordset.Move (M_QUESID(mintCurrentRecord))
                        End If
            Else
                        Data1.Recordset.MoveNext 'NON RANDOM
                        M_QUESID(mintCurrentRecord) = mintCurrentRecord
            End If
            
            If M_MARKED(mintCurrentRecord) = 0 Then
                chkMarkForReview.Value = 0
        Else
                chkMarkForReview.Value = 1
        End If

End Sub
    
     Private Sub NextQuestionRandom() 'RANDOMIZES QUESTIONS
    
        On Error Resume Next
        Dim intX As Integer
            
        mintCurrentRandQues = Random(0, mintTotalRecords - 1)
        intX = 1
        
        Do Until intX = UBound(mintUsedRandQuestions)
            If mintUsedRandQuestions(intX) <> mintCurrentRandQues Then
              intX = intX + 1
            Else
              mintCurrentRandQues = Random(0, mintTotalRecords - 1)
              intX = 1
            End If
        Loop
        
        Data1.Recordset.MoveFirst
        Data1.Recordset.Move (mintCurrentRandQues)
        mintUsedRandQuestions(mintCurrentRecord) = mintCurrentRandQues
           
    End Sub
    
    Public Sub ReadRegistryForColorsNet2() 'CCNA COMMANDS FORM NET2
    
        m_FrmBG = GetSetting("Nerdom6", M_USER, "FrmBG", &HE0E0E0) 'whole form
        m_txtBG = GetSetting("Nerdom6", M_USER, "txtBG", vbWhite) 'txtQuesN1 bg
        m_txtFG = GetSetting("Nerdom6", M_USER, "txtFG", &HB05800)    'txtQuesN1 fg
        m_lblsTime = GetSetting("Nerdom6", M_USER, "lblsTime", vbBlack) 'labelstime
        m_Fwd = GetSetting("Nerdom6", M_USER, "cFwd", &HB05800)    'next
        m_ShowHideExhib = GetSetting("Nerdom6", M_USER, "cShowHideExhib", &HB05800)
        m_ScoreT = GetSetting("Nerdom6", M_USER, "cScoreT", &HB05800)
        m_Submit = GetSetting("Nerdom6", M_USER, "cSubmit", &HB05800)
        m_Notes2AnswerBG = GetSetting("Nerdom6", M_USER, "Notes2AnswerBG", &HB05800)
        M_FONTDISPLAY = GetSetting("Nerdom6", M_USER, "ExamFont", "Arial")
        M_FONTBOLD = GetSetting("Nerdom6", M_USER, "fontBold", True)
        M_FONTITALIC = GetSetting("Nerdom6", M_USER, "fontItalic", False)
        M_FONTSIZE = GetSetting("Nerdom6", M_USER, "ExamFontS", "10")
        m_ShowHideExp2 = GetSetting("Nerdom6", M_USER, "cShowHideExp2", &HB05800)
    End Sub
    
    Private Sub SetFormControlColors()
    
        'THIS SUB ALSO SETS ALL CONTROLS' COLORS BASED ON REGISTRY
       ' SEE READREGISTRYFORCOLORSNET1
        ' THESE COLORS CAN BE CHANGED BY USER IN FRMCOLORS.
        'MENU EXAM->COLORS->PRACTICE EXAMS
        Call ReadRegistryForColorsNet2
        Me.BackColor = m_FrmBG
        chkMarkForReview.BackColor = m_FrmBG 'NEW
        
         With txtQuesN1
              .Font = M_FONTDISPLAY
              .FontSize = M_FONTSIZE
              .FontBold = M_FONTBOLD
              .FontItalic = M_FONTITALIC
              .BackColor = m_txtBG
              .ForeColor = m_txtFG
         End With
         
        fraQues(0).BackColor = m_FrmBG
        frameBackground.BackColor = m_FrmBG 'new
         chkMarkForReview.ForeColor = m_lblsTime
         cmdSubmit.BackColor = m_Submit
         cmdForward.BackColor = m_Fwd
         cmdPrevious.BackColor = m_Fwd
         cmdNotes.BackColor = m_Notes2AnswerBG
         cmdShowAnswer.BackColor = m_Notes2AnswerBG
         cmdShow.BackColor = m_ShowHideExhib 'Show/hide exhibit
         cmdScoreTest.BackColor = m_ScoreT
         cmdReview.BackColor = cmdScoreTest.BackColor
         cmdShowExplanation.BackColor = m_ShowHideExp2
         lblExplanation.Font = M_FONTDISPLAY
         lblExplanation.Font.Size = M_FONTSIZE
         lblQuestionsSeen.ForeColor = m_lblsTime
         lblPercent.ForeColor = m_lblsTime
         lblTimeRemainingDesc.ForeColor = m_lblsTime
         lblTimeDiff.ForeColor = m_lblsTime
         lblPercentCorrect.ForeColor = m_lblsTime
         lblHIDETIME.ForeColor = m_lblsTime
        lblPauseTimer.ForeColor = m_lblsTime
     End Sub
     


         Private Sub lblRouter_Change() 'LABS ONLY
    
         txtInput.Width = (Image1.Width - 100 - lblRouter.Width - 100)
         txtInput.Left = lblRouter.Left + (lblRouter.Width + 200) 'was + 125
    End Sub
    
    Private Sub txtInput_Click()
        cmdSubmit.Enabled = True
    End Sub

    Private Sub txtRouterOutput_Change() 'LABS ONLY
    
         Dim tempText As String
         If (InStr(txtRouterOutput.Text, "<br>")) > 0 Then 'if string exists
                     tempText = Replace(txtRouterOutput.Text, "<br>", vbCrLf)
                     txtRouterOutput.Text = tempText
         End If
    End Sub
    Sub MarkForReview()
    
     If chkMarkForReview.Value = 1 Then
            M_MARKED(mintCurrentRecord) = 1
        Else: M_MARKED(mintCurrentRecord) = 0
        End If
    End Sub
    
    Sub ShowPercentCorrect()
    
     Dim intPercentCorrect As Integer
      If M_SHOWPERCENTCORRECT = True Then
                    M_NUMBERCORRECT = 0
                    Dim i As Integer
                    For i = 1 To M_INTNUMOFQUESTIONS
                            If M_INTANSWERS(i) = 1 Then
                                M_NUMBERCORRECT = M_NUMBERCORRECT + 1
                            End If
                    Next
                    intPercentCorrect = (M_NUMBERCORRECT / M_INTNUMOFQUESTIONS) * 100
                    lblPercentCorrect.Visible = True
                    lblPercentCorrect.Caption = "Correct:  " & intPercentCorrect & "%"
            Else: lblPercentCorrect.Visible = False
            End If
    End Sub
    
   Private Sub lblHIDETIME_Click()
    
         If lblTimeDiff.Visible = False Then
               lblTimeDiff.Visible = True
                lblTimeRemainingDesc.Visible = True
                lblHIDETIME.Caption = "Hide &Timer"
            Exit Sub
            End If
            
            If lblTimeDiff.Visible = True Then
                lblTimeDiff.Visible = False
                lblTimeRemainingDesc.Visible = False
                lblHIDETIME.Caption = "Show &Timer"
            End If
    End Sub
    
Private Sub lblPauseTimer_Click()

        If Timer1.Enabled = True Then
               Timer1.Enabled = False
               lblTimeRemainingDesc.Caption = "PAUSED:"
                lblPauseTimer.Caption = "UnPause &Timer"
            Exit Sub
            End If
            
            If Timer1.Enabled = False Then
                Timer1.Interval = 60000
                Timer1.Enabled = True
                ShowTimeDiff
                lblTimeRemainingDesc.Caption = "Time Left:"
                 lblPauseTimer.Caption = "Pause &Timer"
            End If

End Sub
    
    Private Sub Timer1_Timer()
        
           If 0 >= M_TIMEALLOWED Then   'if now > end time
             Call TimeIsUp
         End If
         M_TIMEALLOWED = M_TIMEALLOWED - 1
         Call ShowTimeDiff
    End Sub
    
    Private Sub ShowTimeDiff()
    
        lblTimeDiff.Caption = CStr(M_TIMEALLOWED) & " Minutes"
    End Sub
    
    Public Sub TimeIsUp()
    
        Timer1.Enabled = False
        MsgBox ("Nerdom Cert Exams - Your Time Has Expired. You will now be taken to review.")
        Call cmdScoreTest_Click
    End Sub
    
    Private Sub cmdShowAnswer_Click()
    
            If mblnClickedShowAnswer = False Then
                fraAnswer.Visible = True
                mblnClickedShowAnswer = True
                cmdShowAnswer.Caption = "Hide &Answer"
                lblInputA.Visible = True 'new comment
            Exit Sub
            End If
            
            If mblnClickedShowAnswer = True Then
                fraAnswer.Visible = False
                mblnClickedShowAnswer = False
                cmdShowAnswer.Caption = "Show &Answer"
            End If
    End Sub
    
    Private Sub cmdShow_Click()
        If mblnClickedSubmit = False Then cmdSubmit_Click
        Dim strExhibitToUse As String
        ANOTHERFORMSHOWN = True
        M_CURRENTEXHIBITQUESNO = mintCurrentRecord
        If lblExhibitNum.Caption <> "" Then
            strExhibitToUse = lblExhibitNum.Caption
            If App.Path = "\" Then
                M_EXHIBITPATH = App.Path & M_EXAMFOLDER & strExhibitToUse
            Else
                M_EXHIBITPATH = App.Path & "\" & M_EXAMFOLDER & strExhibitToUse
            End If
            frmExhibit.Show vbModal
        End If
    End Sub
    
    Private Sub cmdNotes_Click()
        If mblnClickedSubmit = False Then cmdSubmit_Click
        M_CURRENTNOTE = mintCurrentRecord
        ANOTHERFORMSHOWN = True
        frmNotes.Show vbModal
    End Sub
    
    Private Sub cmdShowExplanation_Click()

         If mblnClickedSubmit = False Then cmdSubmit_Click
            M_QUESTYPE = "i"
            M_EXPLANATION = lblExplanation.Caption
            M_ANSWERSTATUS = lblCorrectInc.Caption
            M_QID = lblQuestionIDNumber.Caption
            M_ANSWER = lblCorrectAnswer.Caption
            M_CURRENTEXPLANATIONNUM = mintCurrentRecord
            ANOTHERFORMSHOWN = True
            frmExplanation.Show vbModal
    End Sub
        Sub ShowExplanation()

        If M_INTANSWERS(mintCurrentRecord) = 1 Then
                    lblCorrectInc.Caption = "Correct!"
                    If M_SHOWEXPLANATIONCORRECT = True And IN_REVIEW_MODE = False And mblnClickedPrevious = False Then cmdShowExplanation_Click
                Else
                    lblCorrectInc.Caption = "Incorrect!"
                    If M_SHOWEXPLANATIONINCORRECT = True And IN_REVIEW_MODE = False And mblnClickedPrevious = False Then cmdShowExplanation_Click
       End If

End Sub
    Private Sub cmdReview_Click()
    'If Item Review is Clicked, must capture current record
        M_CURRENTRECORD = mintCurrentRecord 'must be here
       ReviewClick
    End Sub
    
   Private Sub ReviewClick() 'same as cmdReview Click only dont set m_currentrec
                                'so you can go back to currec in review xxx mode
    If mblnClickedSubmit = False Then Call cmdSubmit_Click
       ShowExplanation
        ANOTHERFORMSHOWN = True
        MarkForReview
        IN_REVIEW_MODE = True
        REVIEWINGMARKED_MODE = False
        REVIEWINGunMARKED_MODE = False
        REVIEWINGCORRECT_MODE = False
        REVIEWINGinCORRECT_MODE = False
        REVIEWINGANSWERED_MODE = False
        REVIEWINGunANSWERED_MODE = False
        REVIEWINGNOTES_MODE = False
        REVIEWINGnoNOTES_MODE = False
        'M_CURRENTRECORD = mintCurrentRecord
        frmReview.Show ' vbModal
    End Sub
    
    Private Sub cmdScoreTest_Click()
            M_BUTTONCOLOR = cmdSubmit.BackColor
            M_BACKCOLOR = Me.BackColor
            If mblnClickedSubmit = False Then cmdSubmit_Click
            ANOTHERFORMSHOWN = True
            IN_REVIEW_MODE = True
            MarkForReview
            'Timer1.Enabled = False
            'M_INTSCORE = (M_NUMBERCORRECT / M_INTNUMOFQUESTIONS) * 100
            M_CURRENTRECORD = mintCurrentRecord
            'Me.Hide 'testing
            frmPrintPreview.Show 'vbModal
    End Sub
    
    Private Sub Form_Unload(Cancel As Integer)
    
           Unload frmReview
           Unload frmPrintPreview
            IN_REVIEW_MODE = False
            REVIEWINGMARKED_MODE = False
            REVIEWINGunMARKED_MODE = False
            REVIEWINGCORRECT_MODE = False
            REVIEWINGinCORRECT_MODE = False
            REVIEWINGANSWERED_MODE = False
            REVIEWINGunANSWERED_MODE = False
            REVIEWINGNOTES_MODE = False
            REVIEWINGnoNOTES_MODE = False
            Timer1.Enabled = False
            ANOTHERFORMSHOWN = False
    End Sub
