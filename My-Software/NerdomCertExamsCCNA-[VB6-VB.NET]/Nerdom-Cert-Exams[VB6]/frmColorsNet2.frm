VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "Comdlg32.ocx"
Begin VB.Form frmColorsNet2 
   BackColor       =   &H00E0E0E0&
   BorderStyle     =   1  'Fixed Single
   Caption         =   " Change Color Schemes"
   ClientHeight    =   6210
   ClientLeft      =   45
   ClientTop       =   300
   ClientWidth     =   9975
   Icon            =   "frmColorsNet2.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6210
   ScaleWidth      =   9975
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtUserName 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   345
      Left            =   7500
      MaxLength       =   16
      TabIndex        =   40
      Top             =   4620
      Width           =   2415
   End
   Begin VB.CommandButton cmdShowExplanation 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "Explanation"
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
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   36
      Top             =   3720
      Width           =   1500
   End
   Begin VB.CommandButton cmdRandomExplanation 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Random"
      Height          =   375
      Left            =   1680
      Style           =   1  'Graphical
      TabIndex        =   39
      Top             =   3720
      Width           =   1500
   End
   Begin VB.CommandButton cmdRandSubmitBut 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Random"
      Height          =   375
      Left            =   1680
      Style           =   1  'Graphical
      TabIndex        =   38
      Top             =   4200
      Width           =   1500
   End
   Begin VB.CommandButton cmdSubmit 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "Submit"
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
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   37
      Top             =   4200
      Width           =   1500
   End
   Begin VB.CommandButton cmdRColorSchemeOne 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Random All Two Colors"
      Height          =   375
      Left            =   4860
      Style           =   1  'Graphical
      TabIndex        =   35
      Top             =   3720
      Width           =   2565
   End
   Begin VB.CommandButton cmdRColorSchemeAll 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Random All Buttons and Text"
      Height          =   375
      Left            =   4860
      Style           =   1  'Graphical
      TabIndex        =   34
      Top             =   3240
      Width           =   2565
   End
   Begin VB.CommandButton cmdChangeButtons2 
      BackColor       =   &H00C0C0C0&
      Caption         =   "All Buttons One Color"
      Height          =   375
      Left            =   4860
      Style           =   1  'Graphical
      TabIndex        =   33
      Top             =   2280
      Width           =   2565
   End
   Begin VB.CommandButton cmdRandomAllButtons 
      BackColor       =   &H00C0C0C0&
      Caption         =   "All Buttons Random Color"
      Height          =   375
      Left            =   4860
      Style           =   1  'Graphical
      TabIndex        =   32
      Top             =   2760
      Width           =   2565
   End
   Begin VB.CommandButton cmdRandShowAnswer2 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Random"
      Height          =   375
      Left            =   3240
      Style           =   1  'Graphical
      TabIndex        =   31
      Top             =   3240
      Width           =   1300
   End
   Begin VB.CommandButton cmdNotes 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "Notes"
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
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   30
      Top             =   3240
      Width           =   1500
   End
   Begin VB.CommandButton cmdShowAnswer 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "Answer"
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
      Left            =   1680
      Style           =   1  'Graphical
      TabIndex        =   29
      Top             =   3240
      Width           =   1500
   End
   Begin VB.CommandButton cmdShow 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "Exhibit"
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
      Left            =   1680
      Style           =   1  'Graphical
      TabIndex        =   28
      Top             =   2760
      Width           =   1500
   End
   Begin VB.CommandButton cmdScoreTest 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "Review / Score"
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
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   27
      Top             =   2760
      Width           =   1500
   End
   Begin VB.CommandButton cmdRandomScoreTest 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Random"
      Height          =   375
      Left            =   3240
      Style           =   1  'Graphical
      TabIndex        =   26
      Top             =   2760
      Width           =   1300
   End
   Begin VB.CommandButton cmdRandomNextBut 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Random"
      Height          =   375
      Left            =   3240
      Style           =   1  'Graphical
      TabIndex        =   25
      Top             =   2280
      Width           =   1300
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
      Left            =   1680
      Style           =   1  'Graphical
      TabIndex        =   24
      ToolTipText     =   "Click to Change Color"
      Top             =   2280
      Width           =   1500
   End
   Begin VB.CommandButton cmdPrevious 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "<< &Previous"
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
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   23
      ToolTipText     =   "Click to Change Color"
      Top             =   2280
      Width           =   1500
   End
   Begin VB.CommandButton cmdRandomBackground 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Random Window Background"
      Height          =   375
      Left            =   7500
      Style           =   1  'Graphical
      TabIndex        =   22
      Top             =   2760
      Width           =   2415
   End
   Begin VB.CommandButton cmdFormBackground 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Window Background"
      Height          =   375
      Left            =   7485
      Style           =   1  'Graphical
      TabIndex        =   21
      Top             =   2280
      Width           =   2415
   End
   Begin VB.CommandButton cmdResetDefault 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Reset Defaults"
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7485
      Style           =   1  'Graphical
      TabIndex        =   20
      ToolTipText     =   "Click this button to set the original program colors."
      Top             =   3720
      Width           =   2415
   End
   Begin VB.CommandButton cmdSaveChanges 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Save Changes"
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7500
      Style           =   1  'Graphical
      TabIndex        =   19
      ToolTipText     =   "Click to save the changes made on this form, or click Close to cancel."
      Top             =   3240
      Width           =   2415
   End
   Begin VB.CommandButton cmdClose 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Close"
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7500
      Style           =   1  'Graphical
      TabIndex        =   18
      ToolTipText     =   "Click this button to cancel changes and return to the launchpad or Save Changes to save."
      Top             =   4200
      Width           =   2415
   End
   Begin VB.Frame fraQues 
      BackColor       =   &H00E0E0E0&
      BorderStyle     =   0  'None
      Caption         =   "Frame1"
      Height          =   1920
      Left            =   0
      TabIndex        =   0
      ToolTipText     =   "Click the gray buttons on this form to change the color settings for each element in the exam. "
      Top             =   300
      Width           =   9795
      Begin VB.CommandButton cmdLabTypeExamColors 
         BackColor       =   &H00C0C0C0&
         Caption         =   "<< Back"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   7320
         Style           =   1  'Graphical
         TabIndex        =   7
         ToolTipText     =   "lick this button to set the original program colors."
         Top             =   0
         Width           =   2415
      End
      Begin VB.CommandButton cmdChangeQuesBGText 
         Appearance      =   0  'Flat
         BackColor       =   &H00C0C0C0&
         Caption         =   "Choose Background"
         Height          =   345
         Left            =   4950
         Style           =   1  'Graphical
         TabIndex        =   6
         Top             =   1200
         Width           =   2310
      End
      Begin VB.CommandButton cmdRandomQuesBGtext 
         Appearance      =   0  'Flat
         BackColor       =   &H00C0C0C0&
         Caption         =   "Random Background"
         Height          =   345
         Left            =   7275
         Style           =   1  'Graphical
         TabIndex        =   5
         Top             =   1200
         Width           =   2310
      End
      Begin VB.CommandButton cmdRandomQuesText 
         Appearance      =   0  'Flat
         BackColor       =   &H00C0C0C0&
         Caption         =   "Random Text Color"
         Height          =   345
         Left            =   150
         Style           =   1  'Graphical
         TabIndex        =   4
         Top             =   1200
         Width           =   1710
      End
      Begin VB.CommandButton cmdUseExisting 
         BackColor       =   &H00C0C0C0&
         Caption         =   "Use Window Background"
         Height          =   345
         Left            =   7275
         Style           =   1  'Graphical
         TabIndex        =   3
         Top             =   825
         Width           =   2310
      End
      Begin VB.CommandButton cmdMatchQuestextlbl 
         BackColor       =   &H00C0C0C0&
         Caption         =   "Match Ques Text"
         Height          =   345
         Left            =   3150
         Style           =   1  'Graphical
         TabIndex        =   2
         Top             =   0
         Width           =   1545
      End
      Begin VB.CommandButton cmdRandLabels 
         BackColor       =   &H00C0C0C0&
         Caption         =   "Random Color"
         Height          =   345
         Left            =   1650
         Style           =   1  'Graphical
         TabIndex        =   1
         Top             =   0
         Width           =   1470
      End
      Begin VB.Label Label4 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Navigation Buttons:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   240
         Left            =   60
         TabIndex        =   17
         Top             =   1620
         Width           =   2190
      End
      Begin VB.Label lbltxtQuesN1 
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Question Text - Click to Change"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00B05800&
         Height          =   315
         Left            =   75
         TabIndex        =   16
         ToolTipText     =   "Click to Change Color"
         Top             =   375
         Width           =   3915
      End
      Begin VB.Label txtQuesN1 
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Question Text"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00B05800&
         Height          =   1215
         Left            =   75
         TabIndex        =   15
         Top             =   375
         Width           =   9675
      End
      Begin VB.Label Label1 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Status Labels:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   75
         TabIndex        =   14
         Top             =   0
         Width           =   9630
      End
   End
   Begin MSComctlLib.ProgressBar progressBar1 
      Height          =   195
      Left            =   3240
      TabIndex        =   9
      Top             =   15
      Width           =   2355
      _ExtentX        =   4154
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
      Left            =   7950
      TabIndex        =   8
      ToolTipText     =   "Click to Change Color."
      Top             =   0
      Width           =   1950
   End
   Begin MSComDlg.CommonDialog dlg 
      Left            =   6885
      Top             =   2580
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Label Label2 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      BackColor       =   &H00FFFFFF&
      Caption         =   "Save For User:"
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
      Height          =   240
      Left            =   5760
      TabIndex        =   41
      Top             =   4680
      Width           =   1590
   End
   Begin VB.Label lblPercentCorrect 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF8080&
      BackStyle       =   0  'Transparent
      Caption         =   "Correct: 0%"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   6780
      TabIndex        =   13
      ToolTipText     =   "Click to Change Color."
      Top             =   15
      Width           =   1020
   End
   Begin VB.Label lblTimeRemainingDesc 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Time Left: "
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   120
      TabIndex        =   12
      ToolTipText     =   "Click to Change Color."
      Top             =   15
      Width           =   885
   End
   Begin VB.Label lblTimeDiff 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "50 Minutes"
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
      Left            =   1020
      TabIndex        =   11
      ToolTipText     =   "Click to Change Color"
      Top             =   15
      Width           =   930
   End
   Begin VB.Label lblPercent 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   " Question:                                                       1 of 2554"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   2340
      TabIndex        =   10
      ToolTipText     =   "Click to Change Color."
      Top             =   15
      Width           =   4095
   End
End
Attribute VB_Name = "frmColorsNet2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim intRed As Integer
Dim intGreen As Integer
Dim intBlue As Integer
Private M_USER As String
Private m_FrmBG As String
Private m_txtBG As String, m_txtFG As String
Private m_lblsTime As String
Private m_Fwd As String
Private m_ShowHideExhib As String
Private m_ShowHideExp2 As String
Private m_ScoreT As String
Private m_Submit As String
Private m_Notes2AnswerBG As String

Private Function Random(Lowest As Integer, Highest As Integer) As Integer
    Randomize 'reshuffles the numbers
            Random = Int((Highest - Lowest + 1) * Rnd + Lowest) 'returns a random number
End Function

Public Sub GetRandomRGBs()
  intRed = Random(0, 255)
  intGreen = Random(0, 255)
  intBlue = Random(0, 255)
End Sub
Public Sub ShowColorDialogBox()
  dlg.CancelError = False
  dlg.Flags = cdlCCFullOpen
  dlg.ShowColor
End Sub

Private Sub chkMarkForReview_Click()
    TimeLabelsClick
End Sub

Private Sub cmdChangeButtons2_Click()
ShowColorDialogBox
If dlg.Color <> vbBlack Then
cmdSubmit.BackColor = dlg.Color 'now cmdSubmit not cmdExit
Call SetEqualCmdExit 'setEqual to Submit
End If
End Sub

Private Sub TimeLabelsClick()
    On Error GoTo errhandler
    ShowColorDialogBox
    If dlg.Color <> fraQues.BackColor Then
    lblPercent.ForeColor = dlg.Color
    Call SetEqualToQSeen
    End If
errhandler:
    lblPercent.ForeColor = lblPercent.ForeColor
End Sub



Private Sub cmdClose_Click()
cmdSaveChanges_Click
    Unload Me
End Sub

Private Sub cmdFormBackground_Click()
    On Error GoTo errhandler
    ShowColorDialogBox
    If dlg.Color <> lblPercent.ForeColor Then
        Me.BackColor = dlg.Color
        fraQues.BackColor = Me.BackColor
        chkMarkForReview.BackColor = dlg.Color
    End If
errhandler:
    Me.BackColor = Me.BackColor
    chkMarkForReview.BackColor = chkMarkForReview.BackColor
End Sub

Private Sub cmdForward_Click()
ChangePreviousNext
End Sub

Private Sub cmdLabTypeExamColors_Click()

Call cmdSaveChanges_Click

frmExamColors.Show
Me.Hide
End Sub

Private Sub cmdNotes_Click()
cmdShowAnswer_Click
End Sub

Private Sub cmdPrevious_Click()
ChangePreviousNext
End Sub
Sub ChangePreviousNext()

On Error GoTo errhandler
Call ShowColorDialogBox
    If dlg.Color <> vbBlack Then
        cmdForward.BackColor = dlg.Color
        cmdPrevious.BackColor = dlg.Color
    End If
errhandler:
    cmdForward.BackColor = cmdForward.BackColor
    cmdPrevious.BackColor = cmdPrevious.BackColor

End Sub
Private Sub cmdRandomAllButtons_Click()
  GetRandomRGBs
  cmdSubmit.BackColor = RGB(intRed, intGreen, intBlue)
  Call SetEqualCmdExit
End Sub

Private Sub cmdRandomBackground_Click()
    GetRandomRGBs
    fraQues.BackColor = RGB(intRed, intGreen, intBlue)
    Me.BackColor = fraQues.BackColor
    chkMarkForReview.BackColor = fraQues.BackColor
End Sub


Private Sub cmdRandShowAnswer2_Click()
        GetRandomRGBs
        cmdShowAnswer.BackColor = RGB(intRed, intGreen, intBlue)
        cmdNotes.BackColor = cmdShowAnswer.BackColor
End Sub

Private Sub cmdRColorSchemeAll_Click()

GetRandomRGBs
fraQues.BackColor = RGB(intRed, intGreen, intBlue)
txtQuesN1.BackColor = fraQues.BackColor
Me.BackColor = fraQues.BackColor
chkMarkForReview.BackColor = Me.BackColor
lblPercent.ForeColor = RGB((255 - intRed), (255 - intGreen), (255 - intBlue))
Call SetEqualToQSeen
txtQuesN1.ForeColor = lblPercent.ForeColor
lbltxtQuesN1.ForeColor = lblPercent.ForeColor
GetRandomRGBs
cmdSubmit.BackColor = RGB(intRed, intGreen, intBlue)
GetRandomRGBs
cmdForward.BackColor = RGB(intRed, intGreen, intBlue)
cmdPrevious.BackColor = cmdForward.BackColor
GetRandomRGBs
cmdShowExplanation.BackColor = RGB(intRed, intGreen, intBlue)
GetRandomRGBs
cmdScoreTest.BackColor = RGB(intRed, intGreen, intBlue)
GetRandomRGBs
cmdShow.BackColor = RGB(intRed, intGreen, intBlue)
GetRandomRGBs
cmdShowAnswer.BackColor = RGB(intRed, intGreen, intBlue)
cmdNotes.BackColor = cmdShowAnswer.BackColor

End Sub

Private Sub cmdRColorSchemeOne_Click()
    GetRandomRGBs     'all buttons red, all labels red, bgcolor opposite
    
    fraQues.BackColor = RGB(intRed, intGreen, intBlue)
    txtQuesN1.BackColor = fraQues.BackColor
    Me.BackColor = fraQues.BackColor
    chkMarkForReview.BackColor = Me.BackColor
    cmdSubmit.BackColor = RGB((255 - intRed), (255 - intGreen), (255 - intBlue))
    Call SetEqualCmdExit
    
    txtQuesN1.ForeColor = cmdSubmit.BackColor
    lbltxtQuesN1.ForeColor = txtQuesN1.ForeColor
  
End Sub

Private Sub cmdResetDefault_Click()
    Me.BackColor = &HE0E0E0     'NEW - FORM BACKGROUND
    chkMarkForReview.BackColor = Me.BackColor
    fraQues.BackColor = Me.BackColor
    txtQuesN1.BackColor = vbWhite
    txtQuesN1.ForeColor = &HB05800
    
    lbltxtQuesN1.ForeColor = &HB05800
    cmdSubmit.BackColor = &HB05800    'new now cmdSubmit not cmdExit
    Call SetEqualCmdExit 'will actually now set equal to Submit
    lblPercent.ForeColor = vbBlack
    Call SetEqualToQSeen

End Sub

Private Sub cmdSaveChanges_Click()
M_USER = "U" & txtUserName.Text

SaveSetting "Nerdom6", M_USER, "FrmBG", fraQues.BackColor
SaveSetting "Nerdom6", M_USER, "txtBG", txtQuesN1.BackColor
SaveSetting "Nerdom6", M_USER, "txtFG", txtQuesN1.ForeColor
SaveSetting "Nerdom6", M_USER, "lblsTime", lblPercent.ForeColor
SaveSetting "Nerdom6", M_USER, "cFwd", cmdForward.BackColor
SaveSetting "Nerdom6", M_USER, "cScoreT", cmdScoreTest.BackColor
SaveSetting "Nerdom6", M_USER, "cShowHideExhib", cmdShow.BackColor
SaveSetting "Nerdom6", M_USER, "cSubmit", cmdSubmit.BackColor
SaveSetting "Nerdom6", M_USER, "Notes2AnswerBG", cmdNotes.BackColor
SaveSetting "Nerdom6", M_USER, "cShowHideExp2", cmdShowExplanation.BackColor

End Sub

Private Sub cmdScoreTest_Click()

    On Error GoTo errhandler
    ShowColorDialogBox
    If dlg.Color <> vbBlack Then
    cmdScoreTest.BackColor = dlg.Color
    cmdShow.BackColor = dlg.Color
    End If
errhandler:
    cmdScoreTest.BackColor = cmdScoreTest.BackColor
    cmdShow.BackColor = dlg.Color
End Sub

Private Sub cmdShow_Click()
    cmdScoreTest_Click
End Sub

Private Sub cmdShowAnswer_Click()
     
  On Error GoTo errhandler
  
  ShowColorDialogBox
  
      If dlg.Color <> vbBlack Then
          cmdShowAnswer.BackColor = dlg.Color
          cmdNotes.BackColor = cmdShowAnswer.BackColor
      End If
  
errhandler:
      cmdShowAnswer.BackColor = cmdShowAnswer.BackColor
        cmdNotes.BackColor = cmdNotes.BackColor
End Sub

Private Sub cmdShowExplanation_Click()
On Error GoTo errhandler

ShowColorDialogBox

If dlg.Color <> vbBlack Then
cmdShowExplanation.BackColor = dlg.Color
End If
errhandler:
cmdShowExplanation.BackColor = cmdShowExplanation.BackColor
End Sub

Private Sub cmdSubmit_Click()
On Error GoTo errhandler
Call ShowColorDialogBox
If dlg.Color <> vbBlack Then cmdSubmit.BackColor = dlg.Color
errhandler:
cmdSubmit.BackColor = cmdSubmit.BackColor
End Sub

Private Sub cmdUseExisting_Click()
    txtQuesN1.BackColor = Me.BackColor
End Sub
Private Sub cmdChangeQuesBGText_Click()
    On Error GoTo errhandler
    ShowColorDialogBox
    If dlg.Color <> txtQuesN1.ForeColor Then
        txtQuesN1.BackColor = dlg.Color
    End If
errhandler:
    txtQuesN1.BackColor = txtQuesN1.BackColor

End Sub
Private Sub cmdMatchQuestextlbl_Click()
        lblPercent.ForeColor = txtQuesN1.ForeColor
        Call SetEqualToQSeen
        End Sub
Private Sub cmdRandLabels_Click()
    GetRandomRGBs
    lblPercent.ForeColor = RGB(intRed, intGreen, intBlue)
    Call SetEqualToQSeen
End Sub

Private Sub cmdRandomExplanation_Click()
     GetRandomRGBs
     cmdShowExplanation.BackColor = RGB(intRed, intGreen, intBlue)
   End Sub
        
Private Sub cmdRandomNextBut_Click()
    GetRandomRGBs
    cmdForward.BackColor = RGB(intRed, intGreen, intBlue)
    cmdPrevious.BackColor = cmdForward.BackColor
End Sub

Private Sub cmdRandomQuesBGtext_Click()
              GetRandomRGBs
              txtQuesN1.BackColor = RGB(intRed, intGreen, intBlue)
        End Sub

Private Sub cmdRandomQuesText_Click()
    GetRandomRGBs
    txtQuesN1.ForeColor = RGB(intRed, intGreen, intBlue)
    lbltxtQuesN1.ForeColor = txtQuesN1.ForeColor
End Sub

Private Sub cmdRandomScoreTest_Click()
     GetRandomRGBs
     cmdScoreTest.BackColor = RGB(intRed, intGreen, intBlue)
     cmdShow.BackColor = cmdScoreTest.BackColor
 End Sub
 
 Private Sub cmdRandSubmitBut_Click()
       GetRandomRGBs
       cmdSubmit.BackColor = RGB(intRed, intGreen, intBlue)
 End Sub
Private Sub cmdRandomShowExhibit_Click()
       GetRandomRGBs
       cmdShow.BackColor = RGB(intRed, intGreen, intBlue)
 End Sub
        
Private Sub Form_Load()
txtUserName.Text = M_USERNAME
M_USER = "U" & txtUserName.Text

Me.Caption = "Color Scheme for Interactive Labs"
Call ReadRegistryForColorsNet2
txtQuesN1.Font = M_FONTDISPLAY
txtQuesN1.FontSize = M_FONTSIZE
txtQuesN1.FontBold = M_FONTBOLD
txtQuesN1.FontItalic = M_FONTITALIC
lbltxtQuesN1.Font = M_FONTDISPLAY
lbltxtQuesN1.FontSize = M_FONTSIZE
lbltxtQuesN1.FontBold = M_FONTBOLD
lbltxtQuesN1.FontItalic = M_FONTITALIC
Me.BackColor = m_FrmBG
fraQues.BackColor = m_FrmBG
chkMarkForReview.BackColor = m_FrmBG
txtQuesN1.BackColor = m_txtBG
txtQuesN1.ForeColor = m_txtFG
lbltxtQuesN1.ForeColor = m_txtFG
lblPercent.ForeColor = m_lblsTime
Call SetEqualToQSeen
cmdForward.BackColor = m_Fwd
cmdPrevious.BackColor = m_Fwd
cmdShow.BackColor = m_ShowHideExhib
cmdShowExplanation.BackColor = m_ShowHideExp2
cmdScoreTest.BackColor = m_ScoreT
cmdSubmit.BackColor = m_Submit
cmdShowAnswer.BackColor = m_Notes2AnswerBG
cmdNotes.BackColor = m_Notes2AnswerBG
End Sub

Private Sub SetEqualToQSeen()
lblPercent.ForeColor = lblPercent.ForeColor
lblTimeRemainingDesc.ForeColor = lblPercent.ForeColor
lblTimeDiff.ForeColor = lblPercent.ForeColor
lblPercentCorrect.ForeColor = lblPercent.ForeColor
chkMarkForReview.ForeColor = lblPercent.ForeColor
End Sub

Private Sub SetEqualCmdExit()
cmdForward.BackColor = cmdSubmit.BackColor 'new now all = cmdSubmit.Back
cmdPrevious.BackColor = cmdForward.BackColor
cmdShowExplanation.BackColor = cmdSubmit.BackColor
cmdScoreTest.BackColor = cmdSubmit.BackColor
cmdShow.BackColor = cmdSubmit.BackColor
cmdShowAnswer.BackColor = cmdSubmit.BackColor
cmdNotes.BackColor = cmdSubmit.BackColor
End Sub

Private Sub Form_Unload(Cancel As Integer)
    Unload frmExamColors
End Sub

Private Sub lblPercent_Click()
    TimeLabelsClick
End Sub

Private Sub lblPercentCorrect_Click()
    TimeLabelsClick
End Sub

Private Sub lblTimeDiff_Click()
    TimeLabelsClick
End Sub

Private Sub lblTimeRemainingDesc_Click()
    TimeLabelsClick
End Sub

Private Sub lbltxtQuesN1_Click()
    On Error GoTo errhandler
    Call ShowColorDialogBox
    If dlg.Color <> txtQuesN1.BackColor Then
        lbltxtQuesN1.ForeColor = dlg.Color
        txtQuesN1.ForeColor = dlg.Color
    End If
errhandler:
    txtQuesN1.ForeColor = txtQuesN1.ForeColor
    lbltxtQuesN1.ForeColor = lbltxtQuesN1.ForeColor
End Sub

Private Sub ReadRegistryForColorsNet2() 'CCNA COMMANDS FORM NET2
    
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
