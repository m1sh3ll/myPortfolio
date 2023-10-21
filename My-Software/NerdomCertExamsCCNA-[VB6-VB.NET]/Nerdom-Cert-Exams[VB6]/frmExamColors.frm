VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "Comdlg32.ocx"
Begin VB.Form frmExamColors 
   BackColor       =   &H00E0E0E0&
   Caption         =   "Practice Exam Colors - Click the Item to Change the Color or Choose Random."
   ClientHeight    =   6120
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9945
   Icon            =   "frmExamColors.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   6120
   ScaleWidth      =   9945
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
      Height          =   330
      Left            =   4740
      MaxLength       =   16
      TabIndex        =   61
      Top             =   5580
      Width           =   2535
   End
   Begin VB.CommandButton cmdFonts 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Fonts..."
      BeginProperty Font 
         Name            =   "MS Sans Serif"
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
      TabIndex        =   60
      Top             =   5100
      Width           =   1245
   End
   Begin VB.CommandButton cmdLabTypeExamColors 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Lab Type Exam Colors >"
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
      Left            =   7200
      Style           =   1  'Graphical
      TabIndex        =   59
      ToolTipText     =   "lick this button to set the original program colors."
      Top             =   300
      Width           =   2565
   End
   Begin VB.CommandButton cmdRColorSchemeOne 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Random All Two Colors"
      Height          =   375
      Left            =   4695
      Style           =   1  'Graphical
      TabIndex        =   54
      Top             =   5115
      Width           =   2565
   End
   Begin VB.CommandButton cmdRColorSchemeAll 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Random All Buttons and Text"
      Height          =   375
      Left            =   4695
      Style           =   1  'Graphical
      TabIndex        =   53
      ToolTipText     =   "Buttons and text will be changed"
      Top             =   4665
      Width           =   2565
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
      Left            =   7350
      Style           =   1  'Graphical
      TabIndex        =   52
      ToolTipText     =   "lick this button to set the original program colors."
      Top             =   5115
      Width           =   2550
   End
   Begin VB.CommandButton cmdSaveChanges 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Save Changes"
      Default         =   -1  'True
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
      Left            =   7350
      Style           =   1  'Graphical
      TabIndex        =   51
      ToolTipText     =   "Click to save the changes made on this form, or click Close to cancel."
      Top             =   4665
      Width           =   2550
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
      Left            =   7350
      Style           =   1  'Graphical
      TabIndex        =   50
      ToolTipText     =   "Click this button to cancel changes and return to the launchpad or Save Changes to save."
      Top             =   5565
      Width           =   2550
   End
   Begin VB.CommandButton cmdRandLabels 
      BackColor       =   &H00C0C0C0&
      Caption         =   " Random Color"
      Height          =   330
      Left            =   1650
      Style           =   1  'Graphical
      TabIndex        =   37
      Top             =   300
      Width           =   1695
   End
   Begin VB.CommandButton cmdMatchQuestextlbl 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Match Ques Text"
      Height          =   330
      Left            =   3375
      Style           =   1  'Graphical
      TabIndex        =   36
      ToolTipText     =   "Make the labels to the left same color as question text color below"
      Top             =   300
      Width           =   1725
   End
   Begin VB.CommandButton cmdChangeButtons 
      BackColor       =   &H00C0C0C0&
      Caption         =   "All Buttons One Color"
      Height          =   375
      Left            =   4695
      Style           =   1  'Graphical
      TabIndex        =   35
      Top             =   3765
      Width           =   2595
   End
   Begin VB.CommandButton cmdRandomAllButtons 
      BackColor       =   &H00C0C0C0&
      Caption         =   "All Buttons Random Color"
      Height          =   375
      Left            =   4695
      Style           =   1  'Graphical
      TabIndex        =   34
      Top             =   4215
      Width           =   2595
   End
   Begin VB.CommandButton cmdRandomBackground 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Random Window Background"
      Height          =   375
      Left            =   7350
      Style           =   1  'Graphical
      TabIndex        =   28
      Top             =   4215
      Width           =   2550
   End
   Begin VB.CommandButton cmdFormBackground 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Window Background"
      Height          =   375
      Left            =   7350
      Style           =   1  'Graphical
      TabIndex        =   27
      Top             =   3765
      Width           =   2550
   End
   Begin VB.CommandButton cmdRandSubmitBut 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Random"
      Height          =   375
      Left            =   1665
      Style           =   1  'Graphical
      TabIndex        =   23
      Top             =   5565
      Width           =   1515
   End
   Begin VB.CommandButton cmdRandomScoreTest 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Random"
      Height          =   375
      Left            =   3240
      Style           =   1  'Graphical
      TabIndex        =   22
      Top             =   4215
      Width           =   1215
   End
   Begin VB.CommandButton cmdRandShowAnswer 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Random"
      Height          =   375
      Left            =   3240
      Style           =   1  'Graphical
      TabIndex        =   21
      Top             =   4665
      Width           =   1215
   End
   Begin VB.CommandButton cmdRandomExplanation 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Random"
      Height          =   375
      Left            =   1665
      Style           =   1  'Graphical
      TabIndex        =   20
      Top             =   5115
      Width           =   1515
   End
   Begin VB.CommandButton cmdRandomNextBut 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Random"
      Height          =   375
      Left            =   3240
      Style           =   1  'Graphical
      TabIndex        =   19
      Top             =   3765
      Width           =   1215
   End
   Begin VB.CommandButton cmdSubmit 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "&Submit"
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
      Left            =   90
      Style           =   1  'Graphical
      TabIndex        =   0
      ToolTipText     =   "Click to Change Color"
      Top             =   5565
      Width           =   1500
   End
   Begin VB.Frame fraQues 
      Appearance      =   0  'Flat
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   0  'None
      Caption         =   "                                                                      "
      ForeColor       =   &H80000008&
      Height          =   3180
      Index           =   0
      Left            =   75
      TabIndex        =   14
      Top             =   525
      Width           =   9780
      Begin VB.CommandButton cmdUseQuesTextBG 
         BackColor       =   &H00C0C0C0&
         Caption         =   "Match Ques. Text"
         Height          =   330
         Left            =   75
         Style           =   1  'Graphical
         TabIndex        =   49
         Top             =   2550
         Width           =   1515
      End
      Begin VB.CommandButton cmdChangeAnsText 
         BackColor       =   &H00C0C0C0&
         Caption         =   "Change Text Color"
         Height          =   330
         Left            =   3225
         Style           =   1  'Graphical
         TabIndex        =   48
         Top             =   1800
         Width           =   1665
      End
      Begin VB.CommandButton cmdChangeAnsBG 
         BackColor       =   &H00C0C0C0&
         Caption         =   "Change Background"
         Height          =   330
         Left            =   3225
         Style           =   1  'Graphical
         TabIndex        =   47
         Top             =   2175
         Width           =   1665
      End
      Begin VB.CommandButton cmdRandomQuesText 
         Appearance      =   0  'Flat
         BackColor       =   &H00C0C0C0&
         Caption         =   "Random Text Color"
         Height          =   345
         Left            =   150
         Style           =   1  'Graphical
         TabIndex        =   44
         Top             =   975
         Width           =   1710
      End
      Begin VB.CommandButton cmdUseExisting 
         BackColor       =   &H00C0C0C0&
         Caption         =   "Use Window Background"
         Height          =   345
         Left            =   7350
         Style           =   1  'Graphical
         TabIndex        =   43
         Top             =   600
         Width           =   2235
      End
      Begin VB.CommandButton cmdChangeQuesBGText 
         Appearance      =   0  'Flat
         BackColor       =   &H00C0C0C0&
         Caption         =   "Choose Background"
         Height          =   345
         Left            =   5025
         Style           =   1  'Graphical
         TabIndex        =   42
         Top             =   975
         Width           =   2310
      End
      Begin VB.CommandButton cmdRandomQuesBGtext 
         Appearance      =   0  'Flat
         BackColor       =   &H00C0C0C0&
         Caption         =   "Random Background"
         Height          =   345
         Left            =   7350
         Style           =   1  'Graphical
         TabIndex        =   41
         Top             =   975
         Width           =   2235
      End
      Begin VB.CommandButton cmdUseAnswerBG 
         BackColor       =   &H00C0C0C0&
         Caption         =   "Use Answer Background"
         Height          =   345
         Left            =   5025
         Style           =   1  'Graphical
         TabIndex        =   40
         Top             =   600
         Width           =   2310
      End
      Begin VB.CommandButton cmdQTextUseAnswerTxt 
         BackColor       =   &H00C0C0C0&
         Caption         =   "Match Answer Text"
         Height          =   345
         Left            =   150
         Style           =   1  'Graphical
         TabIndex        =   39
         Top             =   600
         Width           =   1710
      End
      Begin VB.CommandButton cmdRandomAnswerBG 
         BackColor       =   &H00C0C0C0&
         Caption         =   "Random Background"
         Height          =   330
         Left            =   3225
         Style           =   1  'Graphical
         TabIndex        =   31
         Top             =   2550
         Width           =   1665
      End
      Begin VB.CommandButton cmdUseExistingAnsBG 
         BackColor       =   &H00C0C0C0&
         Caption         =   "Match Window"
         Height          =   330
         Left            =   1650
         Style           =   1  'Graphical
         TabIndex        =   30
         Top             =   2550
         Width           =   1485
      End
      Begin VB.CommandButton cmdRandomAnswerFG 
         BackColor       =   &H00C0C0C0&
         Caption         =   "Random Text"
         Height          =   330
         Left            =   3225
         Style           =   1  'Graphical
         TabIndex        =   29
         Top             =   1425
         Width           =   1665
      End
      Begin VB.CommandButton cmdChangeBGInputBox 
         BackColor       =   &H00C0C0C0&
         Caption         =   "Change Background"
         Height          =   330
         Left            =   7800
         Style           =   1  'Graphical
         TabIndex        =   26
         Top             =   2175
         Width           =   1815
      End
      Begin VB.CommandButton cmdRandomBGInputBox 
         BackColor       =   &H00C0C0C0&
         Caption         =   "Random Background"
         Height          =   330
         Left            =   7800
         Style           =   1  'Graphical
         TabIndex        =   25
         Top             =   2550
         Width           =   1815
      End
      Begin VB.CommandButton cmdRandomFGInputBox 
         BackColor       =   &H00C0C0C0&
         Caption         =   " Random Text"
         Height          =   330
         Left            =   5175
         Style           =   1  'Graphical
         TabIndex        =   24
         Top             =   2475
         Width           =   1815
      End
      Begin VB.OptionButton optFra0 
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         Caption         =   "A    Answer Text Color"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   255
         Index           =   0
         Left            =   75
         TabIndex        =   18
         ToolTipText     =   "Click to Change Color"
         Top             =   1800
         Width           =   3630
      End
      Begin VB.OptionButton optFra0 
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         Caption         =   "B    Answer Background"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   255
         Index           =   1
         Left            =   75
         TabIndex        =   17
         ToolTipText     =   "Click to Change Color"
         Top             =   2175
         Width           =   3780
      End
      Begin VB.Frame fraInput 
         Appearance      =   0  'Flat
         BackColor       =   &H00FFFFFF&
         ForeColor       =   &H80000008&
         Height          =   1290
         Left            =   5025
         TabIndex        =   15
         Top             =   1650
         Width           =   4665
         Begin VB.Label txtInput 
            Appearance      =   0  'Flat
            AutoSize        =   -1  'True
            BackColor       =   &H80000005&
            BorderStyle     =   1  'Fixed Single
            Caption         =   "Click to Change Text"
            BeginProperty Font 
               Name            =   "Courier New"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H80000008&
            Height          =   270
            Left            =   150
            TabIndex        =   33
            Top             =   450
            Width           =   2580
         End
         Begin VB.Label lblInput 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Input answer in the box below."
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   240
            Left            =   150
            TabIndex        =   16
            Top             =   150
            Width           =   2655
         End
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
         Left            =   0
         TabIndex        =   58
         Top             =   2925
         Width           =   2190
      End
      Begin VB.Label Label3 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Input Answer Box:"
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
         Left            =   5025
         TabIndex        =   57
         Top             =   1425
         Width           =   1965
      End
      Begin VB.Label Label2 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Answers:"
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
         Left            =   75
         TabIndex        =   56
         Top             =   1425
         Width           =   1590
      End
      Begin VB.Label lblAnswerText 
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         ForeColor       =   &H80000008&
         Height          =   240
         Left            =   75
         TabIndex        =   45
         Top             =   1800
         Width           =   2415
      End
      Begin VB.Label lblAnswerBackground 
         Caption         =   "Label2"
         Height          =   240
         Left            =   75
         TabIndex        =   46
         Top             =   2175
         Width           =   2640
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
         TabIndex        =   38
         ToolTipText     =   "Click to Change Color"
         Top             =   150
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
         TabIndex        =   32
         Top             =   150
         Width           =   9615
      End
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
      Left            =   8040
      TabIndex        =   9
      ToolTipText     =   "Click to Change Color."
      Top             =   0
      Width           =   1890
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
      Left            =   90
      Style           =   1  'Graphical
      TabIndex        =   7
      ToolTipText     =   "Click to Change Color"
      Top             =   3765
      Width           =   1500
   End
   Begin VB.CommandButton cmdShowExhibit 
      BackColor       =   &H00B05800&
      Caption         =   "&Exhibit"
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
      Left            =   1665
      Style           =   1  'Graphical
      TabIndex        =   6
      ToolTipText     =   "Click to Change Color"
      Top             =   4215
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
      Left            =   90
      Style           =   1  'Graphical
      TabIndex        =   5
      ToolTipText     =   "Click to Change Color"
      Top             =   4215
      Width           =   1500
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
      Left            =   1665
      Style           =   1  'Graphical
      TabIndex        =   4
      ToolTipText     =   "Click to Change Color"
      Top             =   3765
      Width           =   1500
   End
   Begin VB.CommandButton cmdNotes 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "N&otes"
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
      Left            =   90
      Style           =   1  'Graphical
      TabIndex        =   3
      ToolTipText     =   "Click to Change Color"
      Top             =   4665
      Width           =   1500
   End
   Begin VB.CommandButton cmdShowAnswer 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Cancel          =   -1  'True
      Caption         =   "&Answer"
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
      Left            =   1665
      Style           =   1  'Graphical
      TabIndex        =   2
      ToolTipText     =   "Click to Change Color"
      Top             =   4665
      Width           =   1500
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
      Left            =   90
      Style           =   1  'Graphical
      TabIndex        =   1
      ToolTipText     =   "Click to Change Color"
      Top             =   5100
      Width           =   1500
   End
   Begin MSComctlLib.ProgressBar progressBar1 
      Height          =   195
      Left            =   3480
      TabIndex        =   8
      Top             =   15
      Width           =   2355
      _ExtentX        =   4154
      _ExtentY        =   344
      _Version        =   393216
      BorderStyle     =   1
      Appearance      =   0
   End
   Begin MSComDlg.CommonDialog dlg 
      Left            =   4425
      Top             =   300
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin MSComDlg.CommonDialog dlgBcrush 
      Left            =   7245
      Top             =   4125
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Label lblTitleUser 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00FFFFFF&
      Caption         =   "Save for User:"
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
      Height          =   255
      Left            =   3240
      TabIndex        =   62
      Top             =   5640
      Width           =   1455
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
      Height          =   240
      Left            =   75
      TabIndex        =   55
      Top             =   300
      Width           =   9765
   End
   Begin VB.Label lblPercent 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   " Question:                                                        1 of 400"
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
      Left            =   2550
      TabIndex        =   13
      ToolTipText     =   "Click to Change Color."
      Top             =   15
      Width           =   4035
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
      TabIndex        =   12
      ToolTipText     =   "Click to Change Color"
      Top             =   15
      Width           =   930
   End
   Begin VB.Label lblTimeRemainingDesc 
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
      Height          =   195
      Left            =   120
      TabIndex        =   11
      ToolTipText     =   "Click to Change Color."
      Top             =   15
      Width           =   840
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
      Left            =   6840
      TabIndex        =   10
      ToolTipText     =   "Click to Change Color."
      Top             =   15
      Width           =   1020
   End
End
Attribute VB_Name = "frmExamColors"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Private intRed As Integer
Private intGreen As Integer
Private intBlue As Integer
Private m_FormBrdr As String
Private m_AnswerBG As String
Private m_AnswerFG As String
Private m_txtBoxBG As String
Private m_txtBoxFG As String
Private m_TimelblsFG As String
Private m_InputFG As String
Private m_InputBG As String
Private m_SubmitBG As String
Private m_FwdBG As String
Private m_ScoreBG As String
Private m_NotesAnswerBG As String
Private m_ShowHideExp As String
Private M_USER As String

Private Function Random(Lowest As Integer, Highest As Integer) As Integer
    Randomize 'reshuffles the numbers
            Random = Int((Highest - Lowest + 1) * Rnd + Lowest) 'returns a random number
End Function

Private Sub GetRandomRGBs() 'GET RANDOM RGB NUMBER BETWEEN 0 AND 255
    intRed = Random(0, 255)
    intGreen = Random(0, 255)
    intBlue = Random(0, 255)
End Sub

Private Sub ShowColorDialogBox()
    dlg.CancelError = False 'Dont cause error if user hits Cancel
    dlg.Flags = cdlCCFullOpen 'Show full dialog with options
    dlg.ShowColor
End Sub

Private Sub cmdFonts_Click()
    SetFonts
End Sub

Private Sub cmdLabTypeExamColors_Click()

Call cmdSaveChanges_Click
   frmColorsNet2.Show
   Me.Hide
  
End Sub

Private Sub cmdResetDefault_Click()
 Me.BackColor = &HE0E0E0 'NEW LT GRAY
 txtQuesN1.BackColor = vbWhite
chkMarkForReview.BackColor = Me.BackColor

    txtQuesN1.ForeColor = &HB05800
    lbltxtQuesN1.ForeColor = txtQuesN1.ForeColor

    cmdSubmit.BackColor = &HB05800
    Call SetEqualCmdExit
    lblPercent.ForeColor = vbBlack
    Call SetEqualToQSeen
    
    'Controls specific to practice test forms
    fraQues(0).BackColor = vbWhite
    fraQues(0).ForeColor = vbBlack
    fraInput.BackColor = vbWhite
    lblInput.ForeColor = vbBlack
    optFra0(0).BackColor = vbWhite
    optFra0(0).ForeColor = vbBlack
    optFra0(1).ForeColor = vbBlack
    optFra0(1).BackColor = vbWhite
    txtInput.BackColor = vbWhite
    txtInput.ForeColor = vbBlack
End Sub
Private Sub TimeLabelsClick()
   On Error GoTo errhandler
    Call ShowColorDialogBox
    If dlg.Color <> Me.BackColor Then 'WHOLE FORM BACKGCOLOR
        lblPercent.ForeColor = dlg.Color
        Call SetEqualToQSeen 'SET ALL TOP LEFT LABELS TEXT COLOR EQUAL
    End If
errhandler:
    lblPercent.ForeColor = lblPercent.ForeColor
End Sub

Private Sub chkMarkForReview_Click()
    Call TimeLabelsClick
End Sub

Private Sub cmdChangeAnsBG_Click()
ChangeAnswerBackground
End Sub

Private Sub cmdChangeAnsText_Click()
ChangeAnswerForeground
End Sub

Private Sub cmdChangeBGInputBox_Click()
 On Error GoTo errhandler
    Call ShowColorDialogBox
    If dlg.Color <> txtInput.ForeColor Then txtInput.BackColor = dlg.Color
errhandler:
    txtInput.BackColor = txtInput.BackColor
End Sub

Private Sub cmdChangeButtons_Click()
 On Error GoTo errhandler
    Call ShowColorDialogBox
    If dlg.Color <> vbBlack Then
        cmdSubmit.BackColor = dlg.Color
        Call SetEqualCmdExit 'SET ALL BUTTONS EQUAL TO SAME COLOR
    End If
errhandler:
    Exit Sub
End Sub

Private Sub cmdChangeFGInputBox_Click()
   On Error GoTo errhandler
    Call ShowColorDialogBox
    If dlg.Color <> txtInput.BackColor Then txtInput.ForeColor = dlg.Color
errhandler:
    txtInput.ForeColor = txtInput.ForeColor
End Sub

Private Sub cmdChangeQuesBGText_Click()
   On Error GoTo errhandler
    Call ShowColorDialogBox
    If dlg.Color <> txtQuesN1.ForeColor Then
        txtQuesN1.BackColor = dlg.Color
    End If
errhandler:
    txtQuesN1.BackColor = txtQuesN1.BackColor
End Sub

Private Sub cmdFormBackground_Click()
   On Error GoTo errhandler 'FRAME1 REPRESENTS FORM
    Call ShowColorDialogBox
    If dlg.Color <> lblPercent.ForeColor Then
        Me.BackColor = dlg.Color
        chkMarkForReview.BackColor = Me.BackColor
    End If
errhandler:
    Me.BackColor = Me.BackColor
    chkMarkForReview.BackColor = chkMarkForReview.BackColor
End Sub

Private Sub cmdForward_Click()
    Call ChangePreviousNext
End Sub

Private Sub cmdMatchQuestextlbl_Click()
    lblPercent.ForeColor = txtQuesN1.ForeColor 'MATCH THESE LABELS WITH QUES. TEXT COLOR
    Call SetEqualToQSeen 'SET ALL LABELS TO SAME COLOR
End Sub

Private Sub cmdNotes_Click()
cmdShowAnswer_Click
End Sub

Private Sub cmdPrevious_Click()
ChangePreviousNext
End Sub

Private Sub cmdQTextUseAnswerTxt_Click()
txtQuesN1.ForeColor = optFra0(0).ForeColor
lbltxtQuesN1.ForeColor = txtQuesN1.ForeColor
End Sub

Private Sub cmdRandLabels_Click()
    Call GetRandomRGBs 'GET RANDOM COLOR RGB
    lblPercent.ForeColor = RGB(intRed, intGreen, intBlue) 'SET LABEL TO THE RANDOM COLOR
    Call SetEqualToQSeen 'SET REST OF THOSE LABELS TO SAME COLOR
End Sub

Private Sub cmdRandomAllButtons_Click()
  Call GetRandomRGBs 'GET RANDOM RGB COLOR
    cmdSubmit.BackColor = RGB(intRed, intGreen, intBlue) 'SET ONE BUTTON TO THAT COLOR
    Call SetEqualCmdExit 'SET ALL BUTTONS ABOVE TO SAME COLOR
End Sub

Private Sub cmdRandomAnswerBG_Click()
 Call GetRandomRGBs 'GET RANDOM RGB COLOR
    fraQues(0).BackColor = RGB(intRed, intGreen, intBlue)
    optFra0(0).BackColor = fraQues(0).BackColor 'SET OPTION A BACKCOLOR THE RANDOM COLOR
    optFra0(1).BackColor = fraQues(0).BackColor 'SET RANDOM 'ANSWER BACKROUND'
fraInput.BackColor = fraQues(0).BackColor
End Sub

Private Sub cmdRandomAnswerFG_Click()
 Call GetRandomRGBs 'GET RANDOM RGB COLOR
    optFra0(0).ForeColor = RGB(intRed, intGreen, intBlue) 'SET OPTION A FORECOLOR
    optFra0(1).ForeColor = optFra0(0).ForeColor
    lblInput.ForeColor = optFra0(0).ForeColor

End Sub

Private Sub cmdRandomBackground_Click()
   Call GetRandomRGBs 'GET RANDOM RGB COLOR
    Me.BackColor = RGB(intRed, intGreen, intBlue) 'REPRESENTS RANDOM FORM BACKCOLOR
    chkMarkForReview.BackColor = Me.BackColor
End Sub

Private Sub cmdRandomBGInputBox_Click()
   Call GetRandomRGBs 'GET RANDOM RGB COLOR
    txtInput.BackColor = RGB(intRed, intGreen, intBlue)
End Sub

Private Sub cmdRandomExplanation_Click()
    GetRandomRGBs
    cmdShowExplanation.BackColor = RGB(intRed, intGreen, intBlue)
 End Sub

Private Sub cmdRandomFGInputBox_Click()
   Call GetRandomRGBs
    txtInput.ForeColor = RGB(intRed, intGreen, intBlue)
End Sub

Private Sub cmdRandomNextBut_Click()
    Call GetRandomRGBs
    cmdForward.BackColor = RGB(intRed, intGreen, intBlue)
    cmdPrevious.BackColor = cmdForward.BackColor
End Sub

Private Sub cmdRandomQuesBGtext_Click()
   Call GetRandomRGBs
    txtQuesN1.BackColor = RGB(intRed, intGreen, intBlue)
End Sub

Private Sub cmdRandomQuesText_Click()
    Call GetRandomRGBs
    txtQuesN1.ForeColor = RGB(intRed, intGreen, intBlue)
    lbltxtQuesN1.ForeColor = txtQuesN1.ForeColor
End Sub

Private Sub cmdRandomScoreTest_Click()
 Call GetRandomRGBs
    cmdScoreTest.BackColor = RGB(intRed, intGreen, intBlue)
    cmdShowExhibit.BackColor = cmdScoreTest.BackColor
End Sub

Private Sub cmdRandShowAnswer_Click()
    Call GetRandomRGBs
    cmdShowAnswer.BackColor = RGB(intRed, intGreen, intBlue)
    cmdNotes.BackColor = cmdShowAnswer.BackColor
End Sub

Private Sub cmdRandSubmitBut_Click()
 Call GetRandomRGBs
    cmdSubmit.BackColor = RGB(intRed, intGreen, intBlue)
End Sub
Sub ChangePreviousNext()
On Error GoTo errhandler
Call ShowColorDialogBox
    If dlg.Color <> vbBlack Then
        cmdForward.BackColor = dlg.Color
         cmdPrevious.BackColor = cmdForward.BackColor
    End If
errhandler:
    cmdForward.BackColor = cmdForward.BackColor
    cmdPrevious.BackColor = cmdPrevious.BackColor
End Sub

Private Sub cmdRColorSchemeAll_Click()
'COLOR BUTTONS ONE RANDOM COLOR EACH
    'LABELS ONE COLOR - BACKGROUND OPPOSITE
    GetRandomRGBs
    Me.BackColor = RGB(intRed, intGreen, intBlue)
    chkMarkForReview.BackColor = Me.BackColor
    txtQuesN1.BackColor = Me.BackColor
    lblPercent.ForeColor = RGB((255 - intRed), (255 - intGreen), (255 - intBlue))
    Call SetEqualToQSeen 'SET ALL LABELS-E.G. TIME REMAINING -SAME FORE TEXT COLOR
    txtQuesN1.ForeColor = lblPercent.ForeColor 'QUESTION TEXT
    lbltxtQuesN1.ForeColor = txtQuesN1.ForeColor
    'RANDOM ALL BUTTONS BACKCOLORS
    GetRandomRGBs
    cmdSubmit.BackColor = RGB(intRed, intGreen, intBlue)
    GetRandomRGBs 'new
    cmdShowExplanation.BackColor = RGB(intRed, intGreen, intBlue) 'new
    GetRandomRGBs
    cmdForward.BackColor = RGB(intRed, intGreen, intBlue)
    cmdPrevious.BackColor = cmdForward.BackColor
    GetRandomRGBs
    cmdScoreTest.BackColor = RGB(intRed, intGreen, intBlue)
    cmdShowExhibit.BackColor = cmdScoreTest.BackColor
    GetRandomRGBs
    cmdShowAnswer.BackColor = RGB(intRed, intGreen, intBlue)
    cmdNotes.BackColor = cmdShowAnswer.BackColor

End Sub

Private Sub cmdRColorSchemeOne_Click()
    GetRandomRGBs 'all buttons red, all labels red, bgcolor opposite
    
   Me.BackColor = RGB(intRed, intGreen, intBlue)
   chkMarkForReview.BackColor = Me.BackColor
    txtQuesN1.BackColor = Me.BackColor
    cmdSubmit.BackColor = RGB((255 - intRed), (255 - intGreen), (255 - intBlue))
    Call SetEqualCmdExit 'to cmdSubmit
    txtQuesN1.ForeColor = cmdSubmit.BackColor
    lbltxtQuesN1.ForeColor = cmdSubmit.BackColor
    lblPercent.ForeColor = cmdSubmit.BackColor
    Call SetEqualToQSeen
End Sub

Private Sub cmdSaveChanges_Click()
    M_USER = "U" & txtUserName.Text
    SaveSetting "Nerdom6", M_USER, "FormBrdr", Me.BackColor 'FORM BORDER BACKCOLOR *******
    SaveSetting "Nerdom6", M_USER, "AnswerBG", fraQues(0).BackColor
    SaveSetting "Nerdom6", M_USER, "AnswerFG", optFra0(0).ForeColor
    SaveSetting "Nerdom6", M_USER, "txtBoxBG", txtQuesN1.BackColor   'QUESTION TEXT BOX ***********
    SaveSetting "Nerdom6", M_USER, "txtBoxFG", txtQuesN1.ForeColor
    SaveSetting "Nerdom6", M_USER, "TimelblsFG", lblPercent.ForeColor 'TIME LABELS AND MARK *********
    SaveSetting "Nerdom6", M_USER, "InputFG", txtInput.ForeColor    'INPUT BOX *******
    SaveSetting "Nerdom6", M_USER, "InputBG", txtInput.BackColor
    SaveSetting "Nerdom6", M_USER, "SubmitBG", cmdSubmit.BackColor    'SUBMIT *********
    SaveSetting "Nerdom6", M_USER, "FwdBG", cmdForward.BackColor 'NEX PREVE BUTTON ******************
    SaveSetting "Nerdom6", M_USER, "ScoreBG", cmdShowExhibit.BackColor
    SaveSetting "Nerdom6", M_USER, "NotesAnswerBG", cmdNotes.BackColor 'ADD NOTES / SHOW ANSWER BUTTONS ************
    SaveSetting "Nerdom6", M_USER, "cShowHideExp", cmdShowExplanation.BackColor 'EXPLANATION BUTTON ******
End Sub

Private Sub cmdScoreTest_Click()
'CHANGE BACKCOLOR OF SCORE TEST BUTTON
    On Error GoTo errhandler
    Call ShowColorDialogBox
    If dlg.Color <> vbBlack Then
        cmdScoreTest.BackColor = dlg.Color
        cmdShowExhibit.BackColor = dlg.Color
    End If
errhandler:
    cmdScoreTest.BackColor = cmdScoreTest.BackColor
    cmdShowExhibit.BackColor = cmdShowExhibit.BackColor
End Sub

Private Sub cmdShow_Click()

End Sub

Private Sub cmdShowAnswer_Click()
'CHANGE BACKCOLOR OF SHOW ANSWER BUTTON
    On Error GoTo errhandler
    Call ShowColorDialogBox
    If dlg.Color <> vbBlack Then
        cmdShowAnswer.BackColor = dlg.Color
        cmdNotes.BackColor = dlg.Color
    End If
errhandler:
    cmdShowAnswer.BackColor = cmdShowAnswer.BackColor
    cmdNotes.BackColor = cmdNotes.BackColor
End Sub

Private Sub cmdShowExhibit_Click()
cmdScoreTest_Click
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
 'CHANGE BACKCOLOR SUBMIT ANSWER BUTTON
    On Error GoTo errhandler
    Call ShowColorDialogBox
    If dlg.Color <> vbBlack Then cmdSubmit.BackColor = dlg.Color
errhandler:
    cmdSubmit.BackColor = cmdSubmit.BackColor
End Sub

Private Sub cmdUseAnswerBG_Click()
txtQuesN1.BackColor = fraQues(0).BackColor
End Sub

Private Sub cmdUseExisting_Click()
txtQuesN1.BackColor = Me.BackColor
End Sub

Private Sub cmdUseExistingAnsBG_Click()
 fraQues(0).BackColor = Me.BackColor
    optFra0(0).BackColor = Me.BackColor 'SET OPTION A BACKCOLOR THE RANDOM COLOR
    optFra0(1).BackColor = Me.BackColor 'SET RANDOM 'ANSWER BACKROUND'
fraInput.BackColor = Me.BackColor
End Sub

Private Sub cmdUseQuesTextBG_Click()
 fraQues(0).BackColor = txtQuesN1.BackColor
    optFra0(0).BackColor = txtQuesN1.BackColor 'SET OPTION A BACKCOLOR THE RANDOM COLOR
    optFra0(1).BackColor = txtQuesN1.BackColor 'SET RANDOM 'ANSWER BACKROUND'
fraInput.BackColor = txtQuesN1.BackColor
End Sub

Private Sub Form_Load()
txtUserName.Text = M_USERNAME
M_USER = "U" & M_USERNAME

Call ReadRegistryForColorsNet1 'READ SET VARIABLES FROM REGISTRY AND ASSIGN COLOR TO CONTROLS **

txtQuesN1.Font = M_FONTDISPLAY
txtQuesN1.FontSize = M_FONTSIZE
txtQuesN1.FontBold = M_FONTBOLD
txtQuesN1.FontItalic = M_FONTITALIC

lbltxtQuesN1.Font = M_FONTDISPLAY
lbltxtQuesN1.FontSize = M_FONTSIZE
lbltxtQuesN1.FontBold = M_FONTBOLD
lbltxtQuesN1.FontItalic = M_FONTITALIC

optFra0(0).Font = M_FONTDISPLAY
optFra0(1).FontSize = M_FONTSIZE
optFra0(1).Font = M_FONTDISPLAY
optFra0(1).FontSize = M_FONTSIZE

Me.BackColor = m_FormBrdr 'form Border
chkMarkForReview.BackColor = m_FormBrdr

optFra0(0).BackColor = m_AnswerBG
optFra0(1).BackColor = m_AnswerBG
fraQues(0).BackColor = m_AnswerBG 'ans BG fraQues bg
fraInput.BackColor = m_AnswerBG

optFra0(0).ForeColor = m_AnswerFG 'ans fG lbls
optFra0(1).ForeColor = m_AnswerFG 'ans fg optA
fraQues(0).ForeColor = m_AnswerFG

txtQuesN1.BackColor = m_txtBoxBG 'ques text BG

txtQuesN1.ForeColor = m_txtBoxFG 'ques text FG
lbltxtQuesN1.ForeColor = m_txtBoxFG

lblPercent.ForeColor = m_TimelblsFG
Call SetEqualToQSeen

txtInput.ForeColor = m_InputFG 'READ COLORS FOR THIS FORM
txtInput.BackColor = m_InputBG

cmdSubmit.BackColor = m_SubmitBG
cmdForward.BackColor = m_FwdBG
cmdPrevious.BackColor = m_FwdBG
cmdScoreTest.BackColor = m_ScoreBG
cmdShowExhibit.BackColor = m_ScoreBG
cmdShowAnswer.BackColor = m_NotesAnswerBG
cmdNotes.BackColor = m_NotesAnswerBG
cmdShowExplanation.BackColor = m_ShowHideExp
lblInput.ForeColor = m_AnswerFG
End Sub

Private Sub Form_Unload(Cancel As Integer)
Unload frmColorsNet2
End Sub

Private Sub lblAnswerBackground_Click()
ChangeAnswerBackground
End Sub

Private Sub lblAnswerText_Click()
ChangeAnswerForeground
End Sub

Private Sub lblPercent_Click()
    Call TimeLabelsClick
End Sub

Private Sub lblPercentCorrect_Click()
    Call TimeLabelsClick
End Sub

Private Sub lblTimeDiff_Click()
    Call TimeLabelsClick
End Sub

Private Sub lblTimeRemainingDesc_Click()
    Call TimeLabelsClick
End Sub

Private Sub SetEqualToQSeen() 'SET STATUS TEXT TO SAME COLOR
    lblTimeRemainingDesc.ForeColor = lblPercent.ForeColor
    lblTimeDiff.ForeColor = lblPercent.ForeColor
    lblPercentCorrect.ForeColor = lblPercent.ForeColor
    chkMarkForReview.ForeColor = lblPercent.ForeColor
End Sub

Private Sub SetEqualCmdExit()
'SET COLORS OF BUTTONS ON THIS FORM TO THE SAME COLOR
    cmdForward.BackColor = cmdSubmit.BackColor
    cmdPrevious.BackColor = cmdSubmit.BackColor
    cmdScoreTest.BackColor = cmdSubmit.BackColor
    cmdShowExhibit.BackColor = cmdSubmit.BackColor
    cmdShowAnswer.BackColor = cmdSubmit.BackColor
    cmdNotes.BackColor = cmdSubmit.BackColor
    cmdShowExplanation.BackColor = cmdSubmit.BackColor
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

Private Sub optFra0_Click(Index As Integer) 'change answer BG

      If Index = 0 Then     'IF answer Text
        ChangeAnswerForeground
        End If
    
    If Index = 1 Then 'if answer background
    Call ChangeAnswerBackground
     End If
    
End Sub

Sub ChangeAnswerForeground()
On Error GoTo errhandler
        Call ShowColorDialogBox
        'CHANGE FORECOLOR TO COLOR CHOSEN IN DIALOG
        'MAKE SURE OPTION BUTTON BACKCOLOR IS NOT EQUAL TO TEXT COLOR
        If dlg.Color <> optFra0(0).BackColor Then
        optFra0(0).ForeColor = dlg.Color
        optFra0(1).ForeColor = dlg.Color
        fraQues(0).ForeColor = dlg.Color
        lblInput.ForeColor = dlg.Color
        End If
errhandler:
        optFra0(0).ForeColor = optFra0(0).ForeColor
        'IF USER HITS CANCEL IN DIALOG, USE EXISTING BACKCOLOR
End Sub
Sub ChangeAnswerBackground()
On Error GoTo errhandler:
       Call ShowColorDialogBox
        'CHANGE BACKCOLOR OF ANSWERS ONLY IF A COLOR CHOSEN IS NOT
        'THE SAME AS THE FORECOLOR (E.G. BLACK BG, BLACK TEXT)
        If dlg.Color <> fraQues(0).ForeColor Then
        fraQues(0).BackColor = dlg.Color
        optFra0(0).BackColor = dlg.Color
        optFra0(1).BackColor = dlg.Color
        fraInput.BackColor = dlg.Color
        End If
errhandler:
    fraQues(0).BackColor = fraQues(0).BackColor
    'IF USER HITS CANCEL IN DIALOG, USE EXISTING BACKCOLOR
End Sub

Private Sub progressBar1_Click()
    Call TimeLabelsClick
End Sub


Private Sub cmdClose_Click()
cmdSaveChanges_Click
Unload Me
End Sub

Private Sub txtInput_Click()
cmdChangeFGInputBox_Click
End Sub

Private Sub txtQuesN1_Click()
    cmdChangeQuesBGText_Click
End Sub

Private Sub SetFonts()
M_USER = "U" & txtUserName.Text
     Dim intCounter As Integer
     'IF THE USER CLICKS THE FONTS MENU, THE FONTS DIALOG IS SHOWN'THE VALUES ARE THEN SAVED
     dlgBcrush.Flags = cdlCFScreenFonts
     dlgBcrush.ShowFont
        
     If dlgBcrush.FontBold = True Then  'IF THE FONT TYPE BOLD IS SELECTED
         M_FONTBOLD = True
     Else: M_FONTBOLD = False
     End If
     
     'IF THE FONT TYPE ITALIC IS SELECTED
     If dlgBcrush.FontItalic = True Then
          M_FONTITALIC = True
     Else: M_FONTITALIC = False
     End If

     M_FONTDISPLAY = dlgBcrush.FontName
     M_FONTSIZE = dlgBcrush.FontSize
     SaveSetting "Nerdom6", M_USER, "ExamFont", M_FONTDISPLAY
     SaveSetting "Nerdom6", M_USER, "ExamFontS", M_FONTSIZE
     SaveSetting "Nerdom6", M_USER, "fontBold", M_FONTBOLD
     SaveSetting "Nerdom6", M_USER, "fontItalic", M_FONTITALIC
End Sub

Private Sub ReadRegistryForColorsNet1()
   'FORM NET1

    m_FormBrdr = GetSetting("Nerdom6", M_USER, "FormBrdr", &HE0E0E0) 'lt gray form Border
    m_AnswerBG = GetSetting("Nerdom6", M_USER, "AnswerBG", vbWhite) 'answerbg? transparent?
    m_AnswerFG = GetSetting("Nerdom6", M_USER, "AnswerFG", vbBlack) 'chk, lbl, opt
    m_txtBoxBG = GetSetting("Nerdom6", M_USER, "txtBoxBG", vbWhite) 'txtQuesN1.backcolor
    m_txtBoxFG = GetSetting("Nerdom6", M_USER, "txtBoxFG", &HB05800)    'txtquesN1.forecolor
    m_TimelblsFG = GetSetting("Nerdom6", M_USER, "TimelblsFG", vbBlack) '8 labels time
    m_InputFG = GetSetting("Nerdom6", M_USER, "InputFG", vbBlack)
    m_InputBG = GetSetting("Nerdom6", M_USER, "InputBG", vbWhite)
    m_SubmitBG = GetSetting("Nerdom6", M_USER, "SubmitBG", &HB05800)
    m_FwdBG = GetSetting("Nerdom6", M_USER, "FwdBG", &HB05800)
    m_ScoreBG = GetSetting("Nerdom6", M_USER, "ScoreBG", &HB05800)
    m_NotesAnswerBG = GetSetting("Nerdom6", M_USER, "NotesAnswerBG", &HB05800)
    M_FONTDISPLAY = GetSetting("Nerdom6", M_USER, "ExamFont", "Arial")
    M_FONTBOLD = GetSetting("Nerdom6", M_USER, "fontBold", True)
    M_FONTITALIC = GetSetting("Nerdom6", M_USER, "fontItalic", False)
    M_FONTSIZE = GetSetting("Nerdom6", M_USER, "ExamFontS", "10")
    m_ShowHideExp = GetSetting("Nerdom6", M_USER, "cShowHideExp", &HB05800) 'steel blue
End Sub
