VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "Comdlg32.ocx"
Begin VB.Form frmMainE 
   BackColor       =   &H00400000&
   ClientHeight    =   5595
   ClientLeft      =   2730
   ClientTop       =   2790
   ClientWidth     =   8940
   ForeColor       =   &H00000000&
   Icon            =   "frmMainE.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   ScaleHeight     =   373
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   596
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdSaveOptions 
      BackColor       =   &H00E0E0E0&
      Caption         =   "&Save Settings"
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7080
      Style           =   1  'Graphical
      TabIndex        =   68
      ToolTipText     =   "Saves settings for the current user."
      Top             =   4320
      Width           =   1695
   End
   Begin VB.CommandButton cmdChangeUser 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Change User"
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7080
      Style           =   1  'Graphical
      TabIndex        =   67
      ToolTipText     =   "Get User Settings for User Specified in UserName box:"
      Top             =   4740
      Width           =   1695
   End
   Begin VB.CommandButton cmdColors 
      BackColor       =   &H00E0E0E0&
      Caption         =   "F&onts / Colors..."
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7080
      Style           =   1  'Graphical
      TabIndex        =   19
      ToolTipText     =   "Change Colors of buttons, text and window in exam and labs."
      Top             =   5160
      Width           =   1695
   End
   Begin VB.CommandButton cmdMoreOptions 
      BackColor       =   &H00E0E0E0&
      Caption         =   "<< &More Options"
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   5100
      Style           =   1  'Graphical
      TabIndex        =   18
      ToolTipText     =   "Show More Options to Select From."
      Top             =   5160
      Width           =   1815
   End
   Begin VB.Frame fraMoreOptions 
      BackColor       =   &H00400000&
      BorderStyle     =   0  'None
      Height          =   4200
      Left            =   60
      TabIndex        =   65
      Top             =   1380
      Visible         =   0   'False
      Width           =   4995
      Begin VB.CheckBox chkReviewIncorrect 
         BackColor       =   &H00400000&
         Caption         =   "Review Incorrect"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   2820
         TabIndex        =   40
         ToolTipText     =   "Mark this option to enable Reviewing of Incorrect Items in Item Review."
         Top             =   2280
         Value           =   1  'Checked
         Width           =   1845
      End
      Begin VB.CheckBox chkReviewUnanswered 
         BackColor       =   &H00400000&
         Caption         =   "Enable Review Unanswered"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   0
         TabIndex        =   31
         ToolTipText     =   "Mark this option to enable Reviewing of Unanswered Items in Item Review."
         Top             =   2280
         Value           =   1  'Checked
         Width           =   2685
      End
      Begin VB.CheckBox chkReviewAnswered 
         BackColor       =   &H00400000&
         Caption         =   "Enable Review Answered"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   0
         TabIndex        =   30
         ToolTipText     =   "Mark this option to enable Reviewing of Answered Items in Item Review."
         Top             =   2040
         Value           =   1  'Checked
         Width           =   2565
      End
      Begin VB.CheckBox chkReviewCorrect 
         BackColor       =   &H00400000&
         Caption         =   "Review Correct"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   2820
         TabIndex        =   39
         ToolTipText     =   "Mark this option to enable Reviewing of Correct Items in Item Review."
         Top             =   2040
         Value           =   1  'Checked
         Width           =   1905
      End
      Begin VB.CheckBox chkPauseTimer 
         BackColor       =   &H00400000&
         Caption         =   "Pause Timer Feature"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   2820
         TabIndex        =   38
         ToolTipText     =   "Mark this option to be able to Pause the Time Remaining"
         Top             =   1800
         Value           =   1  'Checked
         Width           =   2160
      End
      Begin VB.CheckBox chkHideTimer 
         BackColor       =   &H00400000&
         Caption         =   "Hide Timer Feature"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   2820
         TabIndex        =   37
         ToolTipText     =   "Mark this option to be able to Hide the Time Remaining"
         Top             =   1560
         Value           =   1  'Checked
         Width           =   1980
      End
      Begin VB.CheckBox chkReviewUnMarked 
         BackColor       =   &H00400000&
         Caption         =   "Enable Review Unmarked"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   0
         TabIndex        =   29
         ToolTipText     =   "Mark this option to enable Reviewing of UnMarked Items in Item Review."
         Top             =   1800
         Value           =   1  'Checked
         Width           =   2565
      End
      Begin VB.CheckBox chkEndExam 
         BackColor       =   &H00400000&
         Caption         =   "End Exam After Score Test"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   0
         TabIndex        =   44
         ToolTipText     =   "Mark this option to be able to End the Exam After Scoring."
         Top             =   3360
         Width           =   2640
      End
      Begin VB.CheckBox chkItemReview 
         BackColor       =   &H00400000&
         Caption         =   "Enable Item Review Button"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   0
         TabIndex        =   26
         ToolTipText     =   "Check this Item to disable Item Review. At end of exam, you can only score the test."
         Top             =   1080
         Value           =   1  'Checked
         Width           =   2685
      End
      Begin VB.CheckBox chkReviewMarked 
         BackColor       =   &H00400000&
         Caption         =   "Enable Review Marked"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   0
         TabIndex        =   28
         ToolTipText     =   "Mark this option to enable Reviewing of Marked Items in Item Review."
         Top             =   1560
         Value           =   1  'Checked
         Width           =   2565
      End
      Begin VB.CommandButton cmdStudyMode 
         BackColor       =   &H00E0E0E0&
         Caption         =   "S&tudy Mode"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   1500
         Style           =   1  'Graphical
         TabIndex        =   21
         ToolTipText     =   "Click to set Exam Options to Study Mode. Enables Most Options. Untimed."
         Top             =   3780
         Width           =   1515
      End
      Begin VB.CommandButton cmdExamMode 
         BackColor       =   &H00E0E0E0&
         Caption         =   "Ex&am Mode"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   0
         Style           =   1  'Graphical
         TabIndex        =   22
         ToolTipText     =   "Click this to Set Options to that of a real exam. All Options Disabled, Random Exam and Timed."
         Top             =   3780
         Width           =   1455
      End
      Begin VB.CheckBox chkMarkForReview 
         BackColor       =   &H00400000&
         Caption         =   "Enable Mark For Review"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   0
         TabIndex        =   27
         ToolTipText     =   "Mark this option to be able to Bookmark Items to go back to during Exam."
         Top             =   1320
         Value           =   1  'Checked
         Width           =   2400
      End
      Begin VB.CommandButton cmdResetOptions 
         BackColor       =   &H00FF0000&
         Caption         =   "&Reset Options"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   3300
         Style           =   1  'Graphical
         TabIndex        =   20
         ToolTipText     =   "Reset All Exam Options to defaults."
         Top             =   3780
         Width           =   1575
      End
      Begin VB.CheckBox chkAddNotes 
         BackColor       =   &H00400000&
         Caption         =   "Add Notes Feature"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   2820
         TabIndex        =   34
         ToolTipText     =   "Enable Note taking during exam."
         Top             =   840
         Value           =   1  'Checked
         Width           =   1965
      End
      Begin VB.CheckBox chkProgressBar 
         BackColor       =   &H00400000&
         Caption         =   "Graphical Progress Bar"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   0
         TabIndex        =   25
         ToolTipText     =   "Mark this option to Show a Graphical Progress Bar. Otherwise the status will read Question: 1 of #"
         Top             =   840
         Value           =   1  'Checked
         Width           =   2400
      End
      Begin VB.CheckBox chkShowPercentCorrect 
         BackColor       =   &H00400000&
         Caption         =   "Show Percent Correct"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   0
         TabIndex        =   24
         ToolTipText     =   "Show the Percentage of Questions answered correctly."
         Top             =   600
         Value           =   1  'Checked
         Width           =   2235
      End
      Begin VB.CheckBox chkShowAnswer 
         BackColor       =   &H00400000&
         Caption         =   "'Show Answer' Button"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   0
         TabIndex        =   23
         ToolTipText     =   "Mark this option to show the correct answers."
         Top             =   360
         Value           =   1  'Checked
         Width           =   2235
      End
      Begin VB.CheckBox chkShowExplanationButton 
         BackColor       =   &H00400000&
         Caption         =   "Explanation Button"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   2820
         TabIndex        =   32
         ToolTipText     =   $"frmMainE.frx":0442
         Top             =   360
         Value           =   1  'Checked
         Width           =   1995
      End
      Begin VB.CheckBox chkScoreTest 
         BackColor       =   &H00400000&
         Caption         =   "Score Test Button"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   2820
         TabIndex        =   36
         ToolTipText     =   "Mark this option to be able to Score the Test immediately."
         Top             =   1320
         Value           =   1  'Checked
         Width           =   2100
      End
      Begin VB.CheckBox chkPreviousButton 
         BackColor       =   &H00400000&
         Caption         =   "Previous Button"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   2820
         TabIndex        =   33
         ToolTipText     =   "Mark this option to Show a Previous button to go back to the previous question asked."
         Top             =   600
         Value           =   1  'Checked
         Width           =   1800
      End
      Begin VB.CheckBox chkShowExplanationIncorrect 
         BackColor       =   &H00400000&
         Caption         =   "Explanation When Incorrect"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   0
         TabIndex        =   43
         ToolTipText     =   "Show popup explanation, correct/incorrect status and correct answer for each question you answer incorrect."
         Top             =   3120
         Width           =   2760
      End
      Begin VB.CheckBox chkShowExplanationCorrect 
         BackColor       =   &H00400000&
         Caption         =   "Explanation When Correct"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   0
         TabIndex        =   42
         ToolTipText     =   "Show popup explanation, correct/incorrect status and correct answer for each question you answer correct."
         Top             =   2880
         Width           =   2805
      End
      Begin VB.CheckBox chkCorrectReview 
         BackColor       =   &H00400000&
         Caption         =   "Correct/Incorrect Column in Review"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   0
         TabIndex        =   41
         ToolTipText     =   "Mark this option to Show Correct Column in Item Review. E.g. Correct: Yes beside each question."
         Top             =   2640
         Value           =   1  'Checked
         Width           =   3465
      End
      Begin VB.CheckBox chkMultChoice 
         BackColor       =   &H00400000&
         Caption         =   "Multiple Choice Only"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00F3C69C&
         Height          =   315
         Left            =   2820
         TabIndex        =   35
         ToolTipText     =   "Only select Multiple Choice Type Questions. This includes True/False, Multiple Answer but will not show Input type Questions."
         Top             =   1080
         Width           =   2115
      End
      Begin VB.Label Label5 
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H00400000&
         BackStyle       =   0  'Transparent
         Caption         =   "More Exam Options:"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   11.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   270
         Left            =   60
         TabIndex        =   66
         ToolTipText     =   "Listed below are the exam options. These options are not available for flashcards exams."
         Top             =   60
         Width           =   2325
      End
   End
   Begin VB.PictureBox Picture1 
      Appearance      =   0  'Flat
      AutoSize        =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   930
      Left            =   60
      Picture         =   "frmMainE.frx":04CD
      ScaleHeight     =   900
      ScaleWidth      =   8790
      TabIndex        =   63
      Top             =   60
      Width           =   8820
   End
   Begin MSComctlLib.ImageList imlSmallIcons 
      Left            =   1200
      Top             =   4920
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   14
      ImageHeight     =   14
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   12
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMainE.frx":3AB1
            Key             =   "icon1"
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMainE.frx":3F03
            Key             =   "icon2"
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMainE.frx":4355
            Key             =   "icon3"
         EndProperty
         BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMainE.frx":47A7
            Key             =   "icon4"
         EndProperty
         BeginProperty ListImage5 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMainE.frx":4BF9
            Key             =   "icon5"
         EndProperty
         BeginProperty ListImage6 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMainE.frx":504B
            Key             =   "icon6"
         EndProperty
         BeginProperty ListImage7 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMainE.frx":549D
            Key             =   "icon7"
         EndProperty
         BeginProperty ListImage8 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMainE.frx":58EF
            Key             =   "icon8"
         EndProperty
         BeginProperty ListImage9 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMainE.frx":5D41
            Key             =   "icon9"
         EndProperty
         BeginProperty ListImage10 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMainE.frx":6193
            Key             =   "icon10"
         EndProperty
         BeginProperty ListImage11 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMainE.frx":65E5
            Key             =   "icon11"
         EndProperty
         BeginProperty ListImage12 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMainE.frx":6A37
            Key             =   "icon12"
         EndProperty
      EndProperty
   End
   Begin VB.ComboBox cmbMaxQuestions 
      BackColor       =   &H00FFFFFF&
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   315
      Left            =   6360
      Style           =   2  'Dropdown List
      TabIndex        =   13
      ToolTipText     =   "If Select All is marked, this number of questions will be asked."
      Top             =   3180
      Width           =   1215
   End
   Begin VB.Data Data1 
      Caption         =   "Data1"
      Connect         =   "Access 2000;"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   2640
      Options         =   0
      ReadOnly        =   -1  'True
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "Q1"
      Top             =   4980
      Visible         =   0   'False
      Width           =   2040
   End
   Begin VB.CommandButton cmdLaunchExam 
      BackColor       =   &H0080FF80&
      Caption         =   "Launch Exam &1"
      Default         =   -1  'True
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   7200
      Style           =   1  'Graphical
      TabIndex        =   7
      ToolTipText     =   "Click to Launch the Selected Exam."
      Top             =   1500
      Width           =   1635
   End
   Begin MSComctlLib.ListView lvwItems 
      CausesValidation=   0   'False
      Height          =   2565
      Left            =   120
      TabIndex        =   0
      ToolTipText     =   "Click an icon to select an exam."
      Top             =   1500
      Width           =   3330
      _ExtentX        =   5874
      _ExtentY        =   4524
      View            =   2
      Arrange         =   1
      LabelEdit       =   1
      LabelWrap       =   -1  'True
      HideSelection   =   0   'False
      FlatScrollBar   =   -1  'True
      _Version        =   393217
      SmallIcons      =   "imlSmallIcons"
      ForeColor       =   0
      BackColor       =   16777215
      BorderStyle     =   1
      Appearance      =   0
      MousePointer    =   4
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      NumItems        =   0
   End
   Begin VB.ComboBox cmbMinutes 
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Left            =   6360
      Style           =   2  'Dropdown List
      TabIndex        =   16
      ToolTipText     =   "Select the number of Minutes. Mark Timed exam for this feature."
      Top             =   3900
      Width           =   1215
   End
   Begin VB.CheckBox chkTimedTest 
      BackColor       =   &H00400000&
      Caption         =   "Timed Exam:"
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00F3C69C&
      Height          =   375
      Left            =   5130
      TabIndex        =   14
      ToolTipText     =   "Enable a time limit for the exam in Minutes."
      Top             =   3600
      Width           =   1575
   End
   Begin VB.ComboBox cmbNumberQues 
      BackColor       =   &H00FFFFFF&
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   315
      Left            =   6360
      Style           =   2  'Dropdown List
      TabIndex        =   11
      ToolTipText     =   "If Select # is marked, this number of questions will be asked."
      Top             =   2820
      Width           =   1215
   End
   Begin VB.TextBox txtUserName 
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   345
      Left            =   5100
      MaxLength       =   16
      TabIndex        =   17
      Text            =   "Nerdom"
      ToolTipText     =   "Enter your name for exam customization."
      Top             =   4740
      Width           =   1815
   End
   Begin VB.CheckBox chkRandomQuestions 
      BackColor       =   &H00400000&
      Caption         =   "Random Questions"
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00F3C69C&
      Height          =   255
      Left            =   5130
      TabIndex        =   8
      ToolTipText     =   "Change order of the Questions."
      Top             =   1770
      Value           =   1  'Checked
      Width           =   2415
   End
   Begin VB.CheckBox chkRandomAnswer 
      BackColor       =   &H00400000&
      Caption         =   "Random Answers"
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00F3C69C&
      Height          =   255
      Left            =   5130
      TabIndex        =   9
      ToolTipText     =   "Change order of the answers (multiple choice). True/False, All of Above Remain the same."
      Top             =   2025
      Value           =   1  'Checked
      Width           =   2175
   End
   Begin VB.Data Data2 
      Caption         =   "Data2"
      Connect         =   "Access 2000;"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   1200
      Options         =   0
      ReadOnly        =   -1  'True
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "t1"
      Top             =   3180
      Visible         =   0   'False
      Width           =   1380
   End
   Begin MSComDlg.CommonDialog dlg 
      Left            =   2040
      Top             =   4920
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Frame fraExam 
      Appearance      =   0  'Flat
      BackColor       =   &H00804000&
      BorderStyle     =   0  'None
      ForeColor       =   &H80000008&
      Height          =   2745
      Left            =   3540
      TabIndex        =   52
      Top             =   1395
      Width           =   1425
      Begin VB.CommandButton cmdExam 
         Appearance      =   0  'Flat
         BackColor       =   &H00E0E0E0&
         Caption         =   "Exam 6 - All"
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
         Index           =   6
         Left            =   120
         Style           =   1  'Graphical
         TabIndex        =   6
         ToolTipText     =   "Click to Select Topic"
         Top             =   2340
         Width           =   1200
      End
      Begin VB.CommandButton cmdExam 
         Appearance      =   0  'Flat
         BackColor       =   &H00E0E0E0&
         Caption         =   "Exam 5"
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
         Index           =   5
         Left            =   120
         Style           =   1  'Graphical
         TabIndex        =   5
         ToolTipText     =   "Click to Select Topic"
         Top             =   1800
         Width           =   1200
      End
      Begin VB.CommandButton cmdExam 
         Appearance      =   0  'Flat
         BackColor       =   &H00E0E0E0&
         Caption         =   "Exam 4"
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
         Index           =   4
         Left            =   120
         Style           =   1  'Graphical
         TabIndex        =   4
         ToolTipText     =   "Click to Select Topic"
         Top             =   1380
         Width           =   1200
      End
      Begin VB.CommandButton cmdExam 
         Appearance      =   0  'Flat
         BackColor       =   &H00E0E0E0&
         Caption         =   "Exam 3"
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
         Index           =   3
         Left            =   120
         Style           =   1  'Graphical
         TabIndex        =   3
         ToolTipText     =   "Click to Select Topic"
         Top             =   960
         Width           =   1200
      End
      Begin VB.CommandButton cmdExam 
         Appearance      =   0  'Flat
         BackColor       =   &H00E0E0E0&
         Caption         =   "Exam 2"
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
         Index           =   2
         Left            =   120
         Style           =   1  'Graphical
         TabIndex        =   2
         ToolTipText     =   "Click to Select Topic"
         Top             =   540
         Width           =   1200
      End
      Begin VB.CommandButton cmdExam 
         Appearance      =   0  'Flat
         BackColor       =   &H00E0E0E0&
         Caption         =   "Exam 1"
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
         Index           =   1
         Left            =   120
         Style           =   1  'Graphical
         TabIndex        =   1
         ToolTipText     =   "Click to Select Topic"
         Top             =   120
         Width           =   1200
      End
   End
   Begin VB.OptionButton optNumberQues 
      BackColor       =   &H00400000&
      Caption         =   "Select #:"
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00F3C69C&
      Height          =   255
      Left            =   5100
      TabIndex        =   10
      ToolTipText     =   "Select Number of Questions from the List."
      Top             =   2880
      Width           =   1275
   End
   Begin VB.OptionButton optMaxQues 
      BackColor       =   &H00400000&
      Caption         =   "Select All:"
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00F3C69C&
      Height          =   255
      Left            =   5100
      TabIndex        =   12
      ToolTipText     =   "Select All Available Questions"
      Top             =   3240
      Value           =   -1  'True
      Width           =   1275
   End
   Begin VB.Label lblMinutes 
      Appearance      =   0  'Flat
      AutoSize        =   -1  'True
      BackColor       =   &H00400000&
      BackStyle       =   0  'Transparent
      Caption         =   "Minutes:"
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00F3C69C&
      Height          =   195
      Left            =   5400
      TabIndex        =   15
      ToolTipText     =   "Select the Number of Minutes for the Time limit. Mark Timed Exam to Enable this."
      Top             =   3960
      Width           =   720
   End
   Begin VB.Label lblPromptNumQues 
      Appearance      =   0  'Flat
      AutoSize        =   -1  'True
      BackColor       =   &H00400000&
      BackStyle       =   0  'Transparent
      Caption         =   "Number of Questions:"
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   270
      Left            =   5100
      TabIndex        =   56
      Top             =   2460
      Width           =   2490
   End
   Begin VB.Label Label3 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      BorderStyle     =   1  'Fixed Single
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   2775
      Left            =   60
      TabIndex        =   51
      Top             =   1380
      Width           =   3495
   End
   Begin VB.Label lblDef 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      BackStyle       =   0  'Transparent
      Caption         =   "Practice Exams - Select an Exam Below"
      DataField       =   "IconMouse"
      DataSource      =   "Data2"
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   270
      Left            =   180
      TabIndex        =   45
      Top             =   1020
      Width           =   8595
      WordWrap        =   -1  'True
   End
   Begin VB.Label lblExamTopic 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      Caption         =   "Topic 1"
      DataField       =   "TopicBut3"
      DataSource      =   "Data2"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   1200
      Index           =   3
      Left            =   135
      TabIndex        =   59
      Top             =   4245
      Width           =   4740
      WordWrap        =   -1  'True
   End
   Begin VB.Label lblExamTopic 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      DataField       =   "TopicBut2"
      DataSource      =   "Data2"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   1200
      Index           =   2
      Left            =   135
      TabIndex        =   58
      Top             =   4245
      Width           =   4740
      WordWrap        =   -1  'True
   End
   Begin VB.Label lblExamTopic 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      Caption         =   "Select an Exam to Begin"
      DataField       =   "TopicBut1"
      DataSource      =   "Data2"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   1200
      Index           =   1
      Left            =   135
      TabIndex        =   57
      Top             =   4245
      Width           =   4740
      WordWrap        =   -1  'True
   End
   Begin VB.Label lblExamTopic 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      Caption         =   "Topic 1"
      DataField       =   "TopicButAll"
      DataSource      =   "Data2"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   1200
      Index           =   6
      Left            =   135
      TabIndex        =   62
      Top             =   4245
      Width           =   4740
      WordWrap        =   -1  'True
   End
   Begin VB.Label lblExamTopic 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      Caption         =   "Topic 1"
      DataField       =   "TopicBut5"
      DataSource      =   "Data2"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   1200
      Index           =   5
      Left            =   135
      TabIndex        =   61
      Top             =   4245
      Width           =   4740
      WordWrap        =   -1  'True
   End
   Begin VB.Label lblExamTopic 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      Caption         =   "Topic 1"
      DataField       =   "TopicBut4"
      DataSource      =   "Data2"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   1200
      Index           =   4
      Left            =   135
      TabIndex        =   60
      Top             =   4245
      Width           =   4740
      WordWrap        =   -1  'True
   End
   Begin VB.Label lblYourName 
      Appearance      =   0  'Flat
      AutoSize        =   -1  'True
      BackColor       =   &H00400000&
      BackStyle       =   0  'Transparent
      Caption         =   "User Name:"
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   270
      Left            =   5100
      TabIndex        =   55
      Top             =   4380
      Width           =   1350
   End
   Begin VB.Label lblIcons 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "icons"
      DataField       =   "ICTITLE"
      DataSource      =   "Data2"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   375
      Left            =   2040
      TabIndex        =   50
      Top             =   3420
      Visible         =   0   'False
      Width           =   615
   End
   Begin VB.Label lblMouseclick 
      Caption         =   "mouseclick"
      DataField       =   "IconMouse"
      DataSource      =   "Data2"
      Height          =   255
      Left            =   1440
      TabIndex        =   49
      Top             =   3360
      Width           =   855
   End
   Begin VB.Label lblLbox 
      Caption         =   "Lbox"
      DataField       =   "MaxLbox"
      DataSource      =   "Data2"
      Height          =   255
      Left            =   1260
      TabIndex        =   48
      Top             =   3720
      Visible         =   0   'False
      Width           =   615
   End
   Begin VB.Label lblTypeOfExam 
      Caption         =   "TYPE"
      DataField       =   "MTYPE"
      DataSource      =   "Data2"
      Height          =   255
      Left            =   1440
      TabIndex        =   47
      Top             =   3540
      Width           =   615
   End
   Begin VB.Label Label6 
      Appearance      =   0  'Flat
      AutoSize        =   -1  'True
      BackColor       =   &H00400000&
      BackStyle       =   0  'Transparent
      Caption         =   "Exam Options:"
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   270
      Left            =   5100
      TabIndex        =   54
      ToolTipText     =   "Listed below are the exam options. These options are not available for flashcards exams."
      Top             =   1440
      Width           =   1665
   End
   Begin VB.Label lblFolder 
      Caption         =   "Folder"
      DataField       =   "fldSubFolder"
      DataSource      =   "Data2"
      Height          =   255
      Left            =   2100
      TabIndex        =   46
      Top             =   2280
      Width           =   1035
   End
   Begin VB.Label Label4 
      Appearance      =   0  'Flat
      BackColor       =   &H00804000&
      BorderStyle     =   1  'Fixed Single
      ForeColor       =   &H80000008&
      Height          =   1455
      Left            =   60
      TabIndex        =   53
      ToolTipText     =   "After selecting an exam from the list above, click these buttons to start the exam."
      Top             =   4140
      Width           =   4905
   End
   Begin VB.Label Label2 
      Appearance      =   0  'Flat
      BackColor       =   &H00F3C69C&
      BorderStyle     =   1  'Fixed Single
      ForeColor       =   &H80000008&
      Height          =   435
      Left            =   60
      TabIndex        =   64
      ToolTipText     =   "After selecting an exam from the list above, click these buttons to start the exam."
      Top             =   960
      Width           =   8805
   End
   Begin VB.Menu mnuProgram 
      Caption         =   "&File"
      Begin VB.Menu mnuDash4 
         Caption         =   "-"
      End
      Begin VB.Menu mnuProgExit 
         Caption         =   "Exit"
         Shortcut        =   ^X
      End
   End
   Begin VB.Menu mnuExam 
      Caption         =   "E&xam"
      Begin VB.Menu mnuExamColors 
         Caption         =   "Colors and Fonts"
      End
   End
   Begin VB.Menu mnuView 
      Caption         =   "&View"
      Begin VB.Menu mnuColors 
         Caption         =   "Icon Menu Colors          "
         Begin VB.Menu mnuColorsCustom 
            Caption         =   "View Custom..."
            Shortcut        =   ^W
         End
         Begin VB.Menu mnuColorsDefault 
            Caption         =   "View Default"
            Shortcut        =   ^D
         End
      End
   End
   Begin VB.Menu mnuHelp 
      Caption         =   "&Help"
      Begin VB.Menu mmuHelpOrder 
         Caption         =   "Order Questions"
      End
      Begin VB.Menu mnuHelpSponsors 
         Caption         =   "Sponsors"
         Begin VB.Menu mnuHelpSponsorsUltraspec 
            Caption         =   "UltraSpec Cables, LLC"
         End
         Begin VB.Menu mnuUltraSpecUS 
            Caption         =   "UltraSpec US"
         End
         Begin VB.Menu mnuMonoPrice 
            Caption         =   "Special Thanks to Monoprice"
         End
         Begin VB.Menu mnuPracticeExamsNet 
            Caption         =   "All New PracticeExams.net"
         End
      End
      Begin VB.Menu mnuHelpAbout 
         Caption         =   "About"
      End
   End
End
Attribute VB_Name = "frmMainE"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
   Option Explicit
    
    Private mdbDAODB36 As Database          'data2 ICNSE'ACCESS 2000
    Private mdaoRS As DAO.Recordset         'data2 ICNSE 'ACCESS 2000
    Private mdaoRS2 As DAO.Recordset        'data1'ACCESS 2000
    Private mdb As Database                             'data1 db0xxx.mdb'ACCESS 2000
    Private mButton As Integer                          'Exam x Button
    Private mDBSoFar As String                          'Associated Database for Exam
    Private M_EXAMMOUSE(12) As String
    Private M_EXAM(0 To 12) As String               'ICON NAMES 0 to 11
    Private M_USER As String
    
    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" _
                  (ByVal hwnd As Long, ByVal lpOperation As String, _
                   ByVal lpFile As String, ByVal lpParameters As String, _
                   ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
    Private Const SW_SHOW = 1
     
    Private Sub Navigate(ByVal NavTo As String)
    
          Dim hBrowse As Long
          hBrowse = ShellExecute(0&, "open", NavTo, "", "", SW_SHOW)
    End Sub
    
    Private Sub SetAppTitle(ByVal s As String)
    
        Me.Caption = App.Title & " - Version " & App.Major & "." & App.Minor & s
    End Sub
    
Private Sub chkItemReview_Click()
    'disable items that have to do with review items
    If chkItemReview.Value = 0 Then
        chkMarkForReview.Enabled = False
        chkReviewMarked.Enabled = False
        chkReviewUnMarked.Enabled = False
        chkReviewCorrect.Enabled = False
        chkReviewIncorrect.Enabled = False
        chkReviewAnswered.Enabled = False
        chkReviewUnanswered.Enabled = False
        'if disabling other review functions
        chkCorrectReview.Enabled = False '
    Else
        chkMarkForReview.Enabled = True
        If chkMarkForReview.Value = 1 Then
            chkReviewMarked.Enabled = True
            chkReviewUnMarked.Enabled = True
        End If
        chkReviewCorrect.Enabled = True
        chkReviewIncorrect.Enabled = True
           chkReviewAnswered.Enabled = True
        chkReviewUnanswered.Enabled = True
        chkCorrectReview.Enabled = True
    End If
End Sub

Private Sub chkMarkForReview_Click() 'Items that have to do with Marking
    If chkMarkForReview.Value = 0 Then
        chkReviewMarked.Enabled = False
        chkReviewUnMarked.Enabled = False
    Else
        'only enable these if item review is enabled
        If chkItemReview.Value = 1 Then
            chkReviewMarked.Enabled = True
            chkReviewUnMarked.Enabled = True
        End If
    End If
End Sub

Private Sub chkMultChoice_Click()
    cmdExam_Click (mButton) 'To update Question boxes
End Sub

Private Sub chkTimedTest_Click()
    If chkTimedTest.Value = 0 Then
        chkHideTimer.Enabled = False
        chkPauseTimer.Enabled = False
   Else
        chkHideTimer.Enabled = True
        chkPauseTimer.Enabled = True
    End If
End Sub


Private Sub cmdColors_Click()

    mnuExamColors_Click
End Sub

    Private Sub cmdExam_Click(Index As Integer)
    Dim temp As String
    cmdLaunchExam.BackColor = &H80FF80
        mButton = Index
        
        cmdLaunchExam.Caption = "Launch Exam &" & Index

        HideTopicsBoxes
        If Index <> 0 Then lblExamTopic(Index).Visible = True
        HighlightButton
        
        If mButton <> 1 Then    'FOR INDEXES 2 through 6
            If App.Path = "\" Then
                         temp = App.Path & lblFolder.Caption & mDBSoFar & mButton & ".mdb"
                         Else: temp = App.Path & "\" & lblFolder.Caption & mDBSoFar & mButton & ".mdb"
            End If
        Else                                   'FOR INDEX 1
            If App.Path = "\" Then
                         temp = App.Path & lblFolder.Caption & mDBSoFar & ".mdb"
                         Else: temp = App.Path & "\" & lblFolder.Caption & mDBSoFar & ".mdb"
            End If
        End If
         M_DATABASEPATH = temp
        OpenDAODataBase_2
    End Sub
    
Private Sub cmdExamMode_Click()
      
        optNumberQues.Value = True
        chkTimedTest.Value = 1
        cmbMinutes.ListIndex = 39
        chkMultChoice.Value = 1
        chkCorrectReview.Value = 0
        chkShowExplanationCorrect = 0
        chkShowExplanationIncorrect = 0
        chkProgressBar.Value = 0
        chkShowExplanationButton.Value = 0
        chkScoreTest.Value = 0
        chkShowAnswer.Value = 0
        chkShowPercentCorrect.Value = 0
        chkAddNotes.Value = 0
        chkPreviousButton.Value = 0
        chkMarkForReview.Value = 1
        chkReviewMarked.Value = 1
        chkItemReview.Value = 0
        chkEndExam.Value = 0
        chkReviewUnMarked.Value = 0
        chkReviewCorrect.Value = 0
        chkReviewIncorrect.Value = 0
        chkHideTimer.Value = 1
        chkPauseTimer.Value = 1
        chkReviewAnswered.Value = 0
        chkReviewUnanswered.Value = 1
        Save_User_Settings
        cmdExamMode.BackColor = vbBlue
        cmdStudyMode.BackColor = &HE0E0E0
        cmdResetOptions.BackColor = &HE0E0E0
End Sub

Private Sub cmdChangeUser_Click()
   
    txtUserName.Text = InputBox("Enter a new or existing user name to load settings", "Enter a user name", txtUserName.Text)
    If txtUserName.Text <> "" Then
        M_USERNAME = txtUserName.Text
        Call Get_Registry_Settings
    End If
End Sub

    Private Sub cmdLaunchExam_Click()         '*******LAUNCH EXAM *****
        Dim temp As String
        
        If mButton <> 1 Then 'FOR INDEXES 2 through 6
            If App.Path = "\" Then
                         temp = App.Path & lblFolder.Caption & mDBSoFar & mButton & ".mdb"
                         Else: temp = App.Path & "\" & lblFolder.Caption & mDBSoFar & mButton & ".mdb"
            End If
        Else 'FOR INDEX 1
            If App.Path = "\" Then
                         temp = App.Path & lblFolder.Caption & mDBSoFar & ".mdb"
                         Else: temp = App.Path & "\" & lblFolder.Caption & mDBSoFar & ".mdb"
            End If
        End If
         M_DATABASEPATH = temp
         M_EXAMFOLDER = lblFolder.Caption 'THE FOLDER THAT IS BOUND TO SUBFOLDER FIELD IN ICNSE.MDB.
         Save_User_Settings
         Call SetUpExam
         Call SetFormCaption(lblExamTopic(mButton).Caption) 'SET CAPTION IN EXAM FORM TO TOPIC CHOSEN
         Call LoadAppropriateExamForm   'LOAD EXAM, FLASHCARD OR LAB
    End Sub
    
Private Sub cmdMoreOptions_Click()

        If fraMoreOptions.Visible = False Then
            fraMoreOptions.Visible = True
            cmdMoreOptions.Caption = "&Hide Options"
            cmdMoreOptions.BackColor = vbBlue
        Else
            fraMoreOptions.Visible = False
            cmdMoreOptions.Caption = "&More Options..."
            cmdMoreOptions.BackColor = &HE0E0E0
        End If
        If lblTypeOfExam.Caption <> "F" Then
        chkMarkForReview_Click
        chkItemReview_Click
        chkTimedTest_Click
        End If
End Sub

Private Sub cmdResetOptions_Click()
    chkMultChoice.Value = 0
    chkAddNotes.Value = 1
    chkCorrectReview.Value = 1
    chkPreviousButton.Value = 1
    chkProgressBar.Value = 1
    chkRandomAnswer.Value = 1
    chkRandomQuestions.Value = 1
    chkScoreTest.Value = 1
    chkShowAnswer.Value = 1
    chkShowExplanationButton.Value = 1
    chkShowExplanationCorrect.Value = 0
    chkShowExplanationIncorrect.Value = 0
    chkShowPercentCorrect.Value = 1
    chkTimedTest.Value = 0
    cmbMinutes.ListIndex = 59
    optNumberQues.Value = True
    chkMarkForReview.Value = 1
    chkReviewMarked.Value = 1
    chkItemReview.Value = 1
    chkEndExam.Value = 0
    chkReviewUnMarked.Value = 1
    chkHideTimer.Value = 1
    chkPauseTimer.Value = 1
     chkReviewCorrect.Value = 1
      chkReviewIncorrect.Value = 1
    Save_User_Settings
   cmdExamMode.BackColor = &HE0E0E0
   cmdStudyMode.BackColor = &HE0E0E0
   cmdResetOptions.BackColor = vbBlue
End Sub

Private Sub cmdSaveOptions_Click()
    Save_User_Settings
End Sub

Private Sub cmdStudyMode_Click()
        
        optNumberQues.Value = True
        chkTimedTest.Value = 0
        cmbMinutes.ListIndex = 59
        chkMultChoice.Value = 0
        chkCorrectReview.Value = 1
        chkShowExplanationCorrect = 0
        chkShowExplanationIncorrect = 0
        chkProgressBar.Value = 1
        chkShowExplanationButton.Value = 1
        chkScoreTest.Value = 1
        chkShowAnswer.Value = 1
        chkShowPercentCorrect.Value = 1
        chkAddNotes.Value = 1
        chkPreviousButton.Value = 1
        chkMarkForReview.Value = 1
        chkReviewMarked.Value = 1
        chkItemReview.Value = 1
        chkEndExam.Value = 0
        chkReviewUnMarked.Value = 1
        chkHideTimer.Value = 1
        chkPauseTimer.Value = 1
        chkReviewCorrect.Value = 1
        chkReviewIncorrect.Value = 1
        chkReviewAnswered.Value = 1
        chkReviewUnanswered.Value = 1
        Save_User_Settings
        cmdExamMode.BackColor = &HE0E0E0
        cmdStudyMode.BackColor = vbBlue
        cmdResetOptions.BackColor = &HE0E0E0
End Sub

    Private Sub Form_Load()
    On Error Resume Next
    mButton = 1
    'On Error Resume Next
    'IF THE APPLICATION IS RUNNING, NOTIFY USER
         If App.PrevInstance = True Then
              MsgBox "This program is already running."
              End
         End If
       SetAppTitle ("")
         'READ THE REGISTRY VALUES, SET DEFAULT LISTBOX VALUES FOR QUESTIONS -HOURS, MINUTES
         Call SetMaxTime(10000)
         
         txtUserName.Text = GetSetting("Nerdom6", "User", "studentName", "Nerdom")
         Call Get_Registry_Settings
         
         Call SetListBoxMaxQuestions(15)
         cmbMaxQuestions.Clear
         cmbMaxQuestions.AddItem ("15")
         cmbMaxQuestions.ListIndex = 0
        Call SetupFlashCardClick
         
         
    End Sub
    
    Public Sub Get_Registry_Settings()              'TIP: CONVERT LAST ARG TO STRING FOR MOST
    
        Dim p As String, ptemp As String
        'put registry values into form
        
        M_USER = "U" & txtUserName.Text
        
        'GETS SETTINGS FOR THE ICON LIST BACKCOLOR AND FONTS USED FOR EXAMS
        M_FONTDISPLAY = GetSetting("Nerdom6", M_USER, "ExamFont", "Arial")
        M_FONTSIZE = GetSetting("Nerdom6", M_USER, "ExamFontS", "10")
        M_FONTBOLD = GetSetting("Nerdom6", M_USER, "fontBold", False)
        M_FONTITALIC = GetSetting("Nerdom6", M_USER, "fontItalic", False)
        'Get all settings for this user
        'if no name is specified, default is used for each key
        lvwItems.BackColor = GetSetting("Nerdom6", M_USER, "IconBackColor", vbWhite)
        
        p = GetSetting("Nerdom6", M_USER, "RandQues", "1")
        chkRandomQuestions.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "RandAns", "1")
        chkRandomAnswer.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "ShowExpBut", "1")
        chkShowExplanationButton.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "ShowPctCorr", "1")
        chkShowPercentCorrect.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "ShowAnsBut", "1")
        chkShowAnswer.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "ShowExpCorr", "0")
        chkShowExplanationCorrect.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "ShowExpInc", "0")
        chkShowExplanationIncorrect.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "PrevBut", "1")
        chkPreviousButton.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "NotesBut", "1")
        chkAddNotes.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "ScoreTAny", "1")
        chkScoreTest.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "ProgBar", "1")
        chkProgressBar.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "RevCorrect", "1")
        chkCorrectReview.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "TimedExam", "1")  'bools
        chkTimedTest.Value = CInt(p)
        ptemp = GetSetting("Nerdom6", M_USER, "NumMinutes", CStr(cmbMinutes.ListIndex))
        cmbMinutes.ListIndex = CInt(ptemp)
        p = GetSetting("Nerdom6", M_USER, "MultOnly", "0")
        chkMultChoice.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "MarkRev", "1")
        chkMarkForReview.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "RevMarked", "1")
        chkReviewMarked.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "ItemReview", "1")
        chkItemReview.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "EndExam", "0")
        chkEndExam.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "RevUnMarked", "1")
        chkReviewUnMarked.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "HideTimer", "1")
        chkHideTimer.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "PauseTimer", "1")
        chkPauseTimer.Value = CInt(p)
        
        p = GetSetting("Nerdom6", M_USER, "RevCorrect", "1")
        chkReviewCorrect.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "RevIncorrect", "1")
        chkReviewIncorrect.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "RevAnswered", "1")
        chkReviewAnswered.Value = CInt(p)
        p = GetSetting("Nerdom6", M_USER, "RevUnanswered", "1")
        chkReviewUnanswered.Value = CInt(p)
        
    End Sub
    
    Private Sub SetListBoxMaxQuestions(ByVal iMaxQues As Integer)
    
         'ADDS VALUES TO THE QUESTIONS LISTBOX. MAXIMUM QUESTIONS 250 DUE TO SCORE REPORT.
         Dim iCounter As Integer
         cmbNumberQues.Clear
         For iCounter = 5 To iMaxQues ' Step 5
              cmbNumberQues.AddItem iCounter
         Next
         'SETS DEFAULT QUESTION AMOUNT SHOWN IN LISTBOX
         cmbNumberQues.ListIndex = 0
        End Sub
        
    Sub SetupFlashCardClick()
    
        Dim iNotFlashCard As Boolean
        iNotFlashCard = True
        
        If lblTypeOfExam.Caption = "F" Then
            iNotFlashCard = False
        End If
        
        chkRandomQuestions.Enabled = iNotFlashCard
        chkRandomAnswer.Enabled = iNotFlashCard
        chkShowExplanationButton.Enabled = iNotFlashCard
        chkShowPercentCorrect.Enabled = iNotFlashCard
        chkShowAnswer.Enabled = iNotFlashCard
        chkTimedTest.Enabled = iNotFlashCard
        cmbMinutes.Enabled = iNotFlashCard
        chkCorrectReview.Enabled = iNotFlashCard
        chkAddNotes.Enabled = iNotFlashCard
        chkPreviousButton.Enabled = iNotFlashCard
        chkProgressBar.Enabled = iNotFlashCard
        chkScoreTest.Enabled = iNotFlashCard

        txtUserName.Enabled = iNotFlashCard
        cmbNumberQues.Enabled = iNotFlashCard
        lblPromptNumQues.Enabled = iNotFlashCard
        cmbMaxQuestions.Enabled = iNotFlashCard
        chkShowExplanationCorrect.Enabled = iNotFlashCard
        chkShowExplanationIncorrect.Enabled = iNotFlashCard
        optMaxQues.Enabled = iNotFlashCard
        optNumberQues.Enabled = iNotFlashCard
        chkMultChoice.Enabled = iNotFlashCard
        chkCorrectReview.Enabled = iNotFlashCard
        chkMarkForReview.Enabled = iNotFlashCard
        chkReviewMarked.Enabled = iNotFlashCard
        chkItemReview.Enabled = iNotFlashCard
        chkReviewUnMarked.Enabled = iNotFlashCard
        chkReviewCorrect.Enabled = iNotFlashCard
        chkReviewIncorrect.Enabled = iNotFlashCard
           chkReviewAnswered.Enabled = iNotFlashCard
        chkReviewUnanswered.Enabled = iNotFlashCard
        lblMinutes.Enabled = iNotFlashCard
        If lblTypeOfExam = "L" Then
                chkRandomAnswer.Enabled = False
                chkMultChoice.Enabled = False
        End If
        chkHideTimer.Enabled = chkTimedTest.Enabled
        chkPauseTimer.Enabled = chkTimedTest.Enabled
                
    End Sub
            
    Private Sub SetMaxTime(iMinutes As Integer)
    
    'ADDS VALUES TO THE HOURS AND MINUTES LISTBOX.
         Dim iCounter As Integer
         For iCounter = 5 To iMinutes Step 5
              cmbMinutes.AddItem iCounter
         Next
         cmbMinutes.ListIndex = 59
    End Sub
    
    Private Sub Form_Activate()
        mButton = 1
        fraMoreOptions.Visible = False
        IN_REVIEW_MODE = False
        ANOTHERFORMSHOWN = False
        mDBSoFar = "db001"
        Call OpenDAODataBase
        Call Get_Registry_Settings
        Call ListExplorer
        cmdExam_Click (1)
        cmdMoreOptions.Caption = "&More Options..."
        cmdLaunchExam.BackColor = &HE0E0E0
        chkMarkForReview_Click
        chkItemReview_Click
        chkTimedTest_Click
   lblDef.Caption = "Practice Exams - Select an Exam Below."
   lblExamTopic(1).Caption = "Select an Exam and Exam Number to Begin."
   DisableExamButtons
   
    End Sub
    
    Sub HighlightButton()
    
        Dim i As Integer
        For i = 1 To 6
            cmdExam(i).BackColor = &HE0E0E0
        Next
            cmdExam(mButton).BackColor = vbBlue
    End Sub
    
    Sub OpenDAODataBase()
    
        'OPEN ICNSE.MDB
        Dim IconDatabasePath As String
        
        If App.Path = "\" Then
            IconDatabasePath = App.Path & "icnse.mdb"
        Else: IconDatabasePath = App.Path & "\icnse.mdb"
        End If
        
        Set mdbDAODB36 = DBEngine(0).OpenDatabase(IconDatabasePath)
        Set mdaoRS = mdbDAODB36.OpenRecordset("t1")   'TABLE T1
        Set Data2.Recordset = mdaoRS
    End Sub
    
    Sub OpenDAODataBase_2()
        On Error Resume Next
        'DATA1 binds to DB00x.mdb v     'DATA2 binds to ICNSE.mdb ^ cmdExamclick
        'opens the recordset to get the Number of Questions in that Database
        Dim TotalRecords As Integer, LeftRecords As Integer 'move to record
        Dim temp As String
        
        M_MULTCHOICEONLY = False
        
        If lblTypeOfExam = "E" Then
             If chkMultChoice.Value = 1 Then            'put in before recordset is generated
                  M_MULTCHOICEONLY = True
                  Else: M_MULTCHOICEONLY = False
            End If
        End If
        'set multchoiceonlly = false for commands, labs, flashcards
        
        Set mdb = DBEngine(0).OpenDatabase(M_DATABASEPATH)
        
        Select Case M_MULTCHOICEONLY
            Case False
                Set mdaoRS2 = mdb.OpenRecordset("Q1")
                Set Data1.Recordset = mdaoRS2
                Data1.Recordset.MoveLast
                TotalRecords = Data1.Recordset.RecordCount
            Case True
                Set mdaoRS2 = mdb.OpenRecordset("SELECT chkoropt From Q1 WHERE chkoropt<>'i'")
                Set Data1.Recordset = mdaoRS2
                Data1.Recordset.MoveLast
                TotalRecords = Data1.Recordset.RecordCount
        End Select
        
        cmbMaxQuestions.Clear
        cmbMaxQuestions.AddItem TotalRecords
        cmbMaxQuestions.ListIndex = 0
        mdaoRS2.Close
        
        LeftRecords = TotalRecords Mod 5
        TotalRecords = TotalRecords - LeftRecords
        SetListBoxMaxQuestions (TotalRecords)
    End Sub
    
    Sub HideTopicsBoxes()
    
    Dim i As Integer
        For i = 1 To 6
            lblExamTopic(i).Visible = False
        Next
    End Sub
    Sub Move_First()
    
        Data2.Recordset.MoveFirst
    End Sub
    
    Private Sub ListExplorer()
    
    'On Error Resume Next
        Dim i As Integer, j As Integer
        Dim listIcon As ListItem   'Represents an Icon in the ListView Control
        lvwItems.ListItems.Clear
        HideTopicsBoxes
        lblExamTopic(1).Visible = True
        lblDef.Visible = True
        i = 0
        Move_First
         Do While lblIcons.Caption <> ""
                M_EXAM(i) = lblIcons.Caption
                M_EXAMMOUSE(i) = lblMouseclick.Caption 'when item is clicked this is shown in label
                Select Case lblTypeOfExam.Caption
                    Case "F"
                        j = 1 'icon picture 1
                    Case "E"
                        j = 2 'icon picture 2
                    Case "L"
                        j = 3 'icon  picture 3
                End Select
                Set listIcon = lvwItems.ListItems.Add(, "icon" & i, M_EXAM(i), , j)
                'make sure icons dont have same name!!!
                Data2.Recordset.MoveNext
                i = i + 1
         Loop
        Move_First
       'lvwItems_ItemClick
       
    End Sub
    
    Private Sub fraOptions_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    
         'SHOW A POPUP MENU ON A RIGHTCLICK OF MOUSE
         If Button = vbRightButton Then PopupMenu mnuView
    End Sub
       
    Private Sub lvwItems_ItemClick(ByVal Item As MSComctlLib.ListItem)
    
            'THE CLICKED ICON
            Dim i As Integer, temp As String, j As Integer
           
            HideTopicsBoxes
            lblExamTopic(1).Visible = True
            Move_First
            mButton = 1
            HighlightButton
            
            For i = 0 To 11                                                                'LOOP THROUGH UP TO 12 LISTITEMS
                    Select Case Item
                            Case Is = M_EXAM(i)                                     'IF ITEM CLICKED IS THE EXAM SELECTED
                            Data2.Recordset.Move (i)                            'MOVE TO THE APPROPRIATE RECORD TO GET EXAM INFO
                            lblDef.Visible = True                                      'SHOW DESCRIPTION FOR THE ICON ON TOP OF ICON EXPLORER
                            lblDef.Caption = M_EXAMMOUSE(i)             'SHOW DESCRIPTION FOR THAT ICON
                            If i < 9 Then
                                    mDBSoFar = "db00" & i + 1                   'WILL CONCAT A STRING DB001 to DB009
                            Else
                                    mDBSoFar = "db0" & i + 1                      'WILL CONCAT A STRING DB010 to DB012
                            End If
                            SetAppTitle (" - " & M_EXAM(i))                     'WHEN ICON IS CLICKED UPDATE FORM CAPTION WITH ICON NAME
                            
                            DisableExamButtons
                            'CHECK IF DB FOR THAT BUTTON EXISTS TO ENABLE EACH BUTTON. IE. DB001
                            If App.Path = "\" Then
                                    temp = App.Path & lblFolder.Caption & mDBSoFar & ".mdb"
                            Else
                                    temp = App.Path & "\" & lblFolder.Caption & mDBSoFar & ".mdb"
                            End If
                            
                            M_DATABASEPATH = temp
                            'IF FIRST DB EXISTS FOR THIS ICON enable 1st button for the icon
                            If FileExistsAPI(temp) Then
                                    cmdExam(1).Enabled = True
                                    For j = 2 To 6
                                            If App.Path = "\" Then
                                                    temp = App.Path & lblFolder.Caption & mDBSoFar & j & ".mdb"
                                            Else
                                                    temp = App.Path & "\" & lblFolder.Caption & mDBSoFar & j & ".mdb"
                                            End If
                                            
                                            If FileExistsAPI(temp) Then
                                                    cmdExam(j).Enabled = True
                                            Else
                                                    cmdExam(j).Enabled = False                  'IF Each database exists enable the button
                                            End If
                                    Next
                            Else
                                    cmdExam(1).Enabled = False
                            End If
                            
                            OpenDAODataBase_2                                                   'To get # questions
                            SetupFlashCardClick
                            cmdLaunchExam.BackColor = &HE0E0E0
                            Exit Sub                                                                            'EXIT THE LOOP SINCE THE ICON IS FOUND
                    End Select
            Next
            'NO CODE GOES UNDER HERE, SINCE EXIT SUB IS ^
    
    End Sub
    
    Sub DisableExamButtons()
    
        Dim i As Integer
        For i = 1 To 6
            cmdExam(i).Enabled = False
        Next
    End Sub
    
    Private Sub mmuHelpOrder_Click()
    
         Navigate "http://www.nerdom.net/downloads.html"
    End Sub
    
    'FILE MENU
    Private Sub mnuProgExit_Click()
    
         End
    End Sub
    
    '************************************************'EXAM MENU
    Private Sub mnuExamColors_Click()
        M_USERNAME = txtUserName.Text
        frmExamColors.Show
    End Sub
    
    '************************************************'HELP MENU
    Private Sub mnuHelpSponsorsUltraspec_Click()
    
         Navigate "http://www.ultraspec.com"
    End Sub
    
    Private Sub mnuUltraSpecUS_Click()
    
         Navigate "http://www.ultraspec.us"
    End Sub
    
    Private Sub mnuMonoPrice_Click()
    
         Navigate "http://www.monoprice.com"
    End Sub
    
    Private Sub mnuPracticeExamsNet_Click()
    
         Navigate "http://www.practiceexams.net"
    End Sub
    
    Private Sub mnuHelpAbout_Click()
            frmAbout.Show vbModal
    End Sub
    '************************************************'END OF HELP->ABOUT MENU
    
    Private Sub mnuColorsCustom_Click()
    M_USER = "U" & txtUserName.Text
          'CHANGES ICON MENU'S BACK COLOR
         With dlg
            .Flags = cdlCCFullOpen
            .ShowColor
         End With
         If dlg.Color <> vbBlack Then
            lvwItems.BackColor = dlg.Color
            dlg.Color = lvwItems.BackColor
            SaveSetting "Nerdom6", M_USER, "IconBackColor", CStr(lvwItems.BackColor)
         End If
    End Sub
    
    Private Sub mnuColorsDefault_Click()
    M_USER = "U" & txtUserName.Text
         lvwItems.BackColor = vbWhite    'SETS ICON MENU'S BACK COLOR TO WHITE
         SaveSetting "Nerdom6", M_USER, "IconBackColor", CStr(lvwItems.BackColor)
    End Sub
    '***********************************************************************'END OF VIEW MENU
      
    Public Sub SetUpExam()
       Dim vbmsg As VbMsgBoxResult
         'THERE ARE 3 POSSIBLE VALUES  E FOR EXAM, F FOR FLASHCARDS, L FOR ROUTER LAB
         'THERE ARE 3 DIFFERENT FORMS THAT WILL OPEN FOR THE PARTICULAR TYPE OF EXAM M_EXAMTYPE
         M_EXAMTYPE = lblTypeOfExam.Caption 'E F or L
         IN_REVIEW_MODE = False    'RESET REVIEW MODE WHEN STARTING THE EXAMS/LABS
         
         'THE FLASHCARDS PROGRAM IS A SEPARATE PROGRAM USING .NET AND DOES NOT USE VB6 GLOBAL VARIABLES
         If M_EXAMTYPE <> "F" Then
         
            M_TIMEALLOWED = CInt(cmbMinutes.Text)
            If optNumberQues.Value = True Then                      'IF SELECTING A NUMBER- SELECT:
                M_INTNUMOFQUESTIONS = CInt(cmbNumberQues.Text)
                If M_INTNUMOFQUESTIONS > 400 Then
                    vbmsg = MsgBox("Maximum allowed questions is 400. " & vbCrLf & _
                    "If Random Questions are enabled, the pool of questions will be " & vbCrLf & _
                    "400 out of " & CInt(cmbNumberQues.Text) & " Questions." & vbCrLf & _
                    "Otherwise only the first 400 Questions will be asked.", vbOKOnly, "Confirm Launch Exam")
                M_INTNUMOFQUESTIONS = 400
                End If
            Else                                            'IF SELECTING A NUMBER FROM -ALL - LISTBOX
                M_INTNUMOFQUESTIONS = CInt(cmbMaxQuestions.Text)
                If M_INTNUMOFQUESTIONS > 400 Then
                    vbmsg = MsgBox("Maximum allowed questions is 400. " & vbCrLf & _
                    "If Random Questions are enabled, the pool of questions will be " & vbCrLf & _
                    "400 out of " & CInt(cmbMaxQuestions.Text) & " Questions." & vbCrLf & _
                    "Otherwise only the first 400 Questions will be asked.", vbOKOnly, "Confirm Launch Exam")
                M_INTNUMOFQUESTIONS = 400
                End If
            End If
        
              M_USERNAME = txtUserName.Text
              ReDim mintUsedRandQuestions(1 To M_INTNUMOFQUESTIONS)
              ReDim M_INTANSWERS(1 To M_INTNUMOFQUESTIONS)
              ReDim M_STRQUESTION(1 To M_INTNUMOFQUESTIONS)
              ReDim M_STRANSWER(1 To M_INTNUMOFQUESTIONS)
              ReDim M_NOTES(1 To M_INTNUMOFQUESTIONS)
              ReDim M_MARKED(1 To M_INTNUMOFQUESTIONS)
              ReDim M_QUESID(1 To M_INTNUMOFQUESTIONS)
              ReDim QUESTION(1 To M_INTNUMOFQUESTIONS) 'My Type Question
              ReDim M_UNANSWERED(1 To M_INTNUMOFQUESTIONS)
              M_CURRENTRECORD = 1
              
              If chkTimedTest.Value = 1 Then
              M_TIMEDTEST = True
              Else: M_TIMEDTEST = False
              End If
              
              If chkRandomQuestions.Value = 1 Then
                   M_RANDOMQUESTIONS = True
                   Else: M_RANDOMQUESTIONS = False
              End If
              
              If chkRandomAnswer.Value = 1 Then
                   M_RANDOMANSWERS = True
                   Else: M_RANDOMANSWERS = False
              End If
              
               If chkShowExplanationButton.Value = 1 Then
                   M_SHOWEXPLANATIONBUTTON = True
                   Else: M_SHOWEXPLANATIONBUTTON = False
              End If
              
               If chkShowPercentCorrect.Value = 1 Then
                   M_SHOWPERCENTCORRECT = True
                   Else: M_SHOWPERCENTCORRECT = False
              End If
              
               If chkShowAnswer.Value = 1 Then
                   M_SHOWANSWERBUTTON = True
                   Else: M_SHOWANSWERBUTTON = False
              End If
              
              If chkShowExplanationCorrect.Value = 1 Then 'need work
                M_SHOWEXPLANATIONCORRECT = True
                Else: M_SHOWEXPLANATIONCORRECT = False
              End If
              
              If chkShowExplanationIncorrect.Value = 1 Then
              M_SHOWEXPLANATIONINCORRECT = True
            Else: M_SHOWEXPLANATIONINCORRECT = False
              End If
              
              If chkPreviousButton.Value = 1 Then
              M_SHOWPREVIOUSBUTTON = True
              Else: M_SHOWPREVIOUSBUTTON = False
              End If
              
              If chkAddNotes.Value = 1 Then
              M_ADDNOTESBUTTON = True
              Else: M_ADDNOTESBUTTON = False
              End If
              
              If chkScoreTest.Value = 1 Then
              M_SCORETESTBUTTON = True
              Else: M_SCORETESTBUTTON = False
              End If
              
              If chkProgressBar.Value = 1 Then
              M_PROGRESSBAR = True
              Else: M_PROGRESSBAR = False
              End If
              
              If chkCorrectReview.Value = 1 Then
              M_CORRECTINREVIEW = True
              Else: M_CORRECTINREVIEW = False
              End If
              
              If chkMultChoice.Value = 1 Then
              M_MULTCHOICEONLY = True
              Else: M_MULTCHOICEONLY = False
              End If
              
              If chkMarkForReview.Value = 1 Then
              M_MARKFORREVIEW = True
              Else: M_MARKFORREVIEW = False
              End If
              
              If chkReviewMarked.Value = 1 Then
              M_REVIEWMARKEDITEMS = True
              Else: M_REVIEWMARKEDITEMS = False
              End If
              
              If chkItemReview.Value = 1 Then
              M_ITEMREVIEW = True
              Else: M_ITEMREVIEW = False
              End If
              
              If chkEndExam.Value = 1 Then
              M_ENDEXAM = True
              Else: M_ENDEXAM = False
              End If
              
              If chkReviewUnMarked.Value = 1 Then
              M_REVIEWUNMARKEDITEMS = True
              Else: M_REVIEWUNMARKEDITEMS = False
              End If
              
              If chkHideTimer.Value = 1 Then
              M_HIDETIMER = True
              Else: M_HIDETIMER = False
              End If
              
              If chkPauseTimer.Value = 1 Then
              M_PAUSETIMER = True
              Else: M_PAUSETIMER = False
              End If
              
               If chkReviewCorrect.Value = 1 Then
               M_REVIEWCORRECTITEMS = True
               Else: M_REVIEWCORRECTITEMS = False
               End If
               
               If chkReviewIncorrect.Value = 1 Then
               M_REVIEWINCORRECTITEMS = True
               Else: M_REVIEWINCORRECTITEMS = False
               End If
               
                 If chkReviewAnswered.Value = 1 Then
               M_REVIEWANSWEREDITEMS = True
               Else: M_REVIEWANSWEREDITEMS = False
               End If
               
                If chkReviewUnanswered.Value = 1 Then
               M_REVIEWUNANSWEREDITEMS = True
               Else: M_REVIEWUNANSWEREDITEMS = False
               End If
               
         End If
    End Sub
    
    Private Sub SetFormCaption(ByVal sCaption As String)
    
         'EACH FORM CAPTION IS SET FROM INFORMATION IN THE DATABASE. THE APPROPRIATE EXAM NAME
         'WILL BE SET UP BY THE TIME THE FORM LOADS.
         M_FORMCAPTION = sCaption
         M_EXAMNAME = M_FORMCAPTION
    End Sub
    
    Private Sub LoadAppropriateExamForm()
    
        Dim strPathStart As String    'APPLICATION ROOT OF EXAM FOLDER
                                       'APP PATH & '\' & exams\exam01\
        'LOAD EITHER THE PRACTICE EXAM FRMNET1, THE ROUTER LAB FRMNET2, OR THE EXTERNAL FLASHCARDS PROG.
         'BASED ON WHETHER THE FIELD IN THE DATABASE CONTAINS AN E, F OR L
             'IF IT IS A FLASHCARD, F
         'THE FLASHCARDS PROGRAM USES ONE OF 6 POSSIBLE FLASH.EXE FILES
        'IF THE BUTTON CLICKED IS EXAM1, THE FLASH.EXE WILL LOAD, ETC.
        'EXAM 1 Flash.exe         'EXAM 2 Flash2.exe          'EXAM 3 Flash3.exe
        'EXAM 4 Flash4.exe       'EXAM 5 Flash5.exe          'EXAM 6 Flash6.exe - All Ques.
         '  Flash.exe will load db001,   db002,    db003,   ETC.
         'Flash2.exe will load db0012, db0022, db0032
         'Flash3.exe will load db0013, db0023, db0033
          
         If M_EXAMTYPE = "E" Then
              frmNet1.Show 'vbModal 'test test test
              Exit Sub
         ElseIf M_EXAMTYPE = "L" Then
              frmNet2.Show 'vbModal
              Exit Sub
         ElseIf M_EXAMTYPE = "F" Then
              If App.Path = "\" Then
                   strPathStart = App.Path & lblFolder.Caption
              Else
                   strPathStart = App.Path & "\" & lblFolder.Caption
              End If
               
              Select Case mButton
                   Case 1
                        M_DATABASEPATH = strPathStart & "flash.exe"
                   Case 2
                        M_DATABASEPATH = strPathStart & "flash2.exe"
                   Case 3
                        M_DATABASEPATH = strPathStart & "flash3.exe"
                   Case 4
                        M_DATABASEPATH = strPathStart & "flash4.exe"
                   Case 5
                        M_DATABASEPATH = strPathStart & "flash5.exe"
                   Case 6
                        M_DATABASEPATH = strPathStart & "flash6.exe"
              End Select
              Call Navigate(M_DATABASEPATH) 'the appropriate flashcard program pops up
        End If
    End Sub
    
    Public Sub ReturnPathToDB(ByVal dbase As String, ByVal intRecord As Integer)
    
         'SETS DATABASE PATH FOR USE IN LISTEXPLORER
         Move_First
         Data2.Recordset.Move (intRecord)
         If App.Path = "\" Then
              M_DATABASEPATH = App.Path & lblFolder.Caption & dbase & ".mdb"
         Else: M_DATABASEPATH = App.Path & "\" & lblFolder.Caption & dbase & ".mdb"
         End If
    End Sub
    
    Private Sub Form_Unload(Cancel As Integer)
    
        Call Save_User_Settings
        End
    End Sub
    
         Sub Save_User_Settings()
         M_USER = "U" & txtUserName.Text 'holds the curent user
            SaveSetting "Nerdom6", "User", "studentName", txtUserName.Text
            SaveSetting "Nerdom6", M_USER, "RandQues", CStr(chkRandomQuestions.Value)
            SaveSetting "Nerdom6", M_USER, "RandAns", CStr(chkRandomAnswer.Value)
            SaveSetting "Nerdom6", M_USER, "ShowExpBut", CStr(chkShowExplanationButton.Value)
            SaveSetting "Nerdom6", M_USER, "ShowPctCorr", CStr(chkShowPercentCorrect.Value)
            SaveSetting "Nerdom6", M_USER, "ShowAnsBut", CStr(chkShowAnswer.Value)
            SaveSetting "Nerdom6", M_USER, "ShowExpCorr", CStr(chkShowExplanationCorrect.Value)
            SaveSetting "Nerdom6", M_USER, "ShowExpInc", CStr(chkShowExplanationIncorrect.Value)
            SaveSetting "Nerdom6", M_USER, "TimedExam", CStr(chkTimedTest.Value)
            SaveSetting "Nerdom6", M_USER, "NumMinutes", CStr(cmbMinutes.ListIndex)
            SaveSetting "Nerdom6", M_USER, "PrevBut", CStr(chkPreviousButton.Value)
            SaveSetting "Nerdom6", M_USER, "NotesBut", CStr(chkAddNotes.Value)
            SaveSetting "Nerdom6", M_USER, "ScoreTAny", CStr(chkScoreTest.Value)
            SaveSetting "Nerdom6", M_USER, "ProgBar", CStr(chkProgressBar.Value)
            SaveSetting "Nerdom6", M_USER, "RevCorrect", CStr(chkCorrectReview.Value)
            SaveSetting "Nerdom6", M_USER, "MultOnly", CStr(chkMultChoice.Value)
            SaveSetting "Nerdom6", M_USER, "MarkRev", CStr(chkMarkForReview.Value)
            SaveSetting "Nerdom6", M_USER, "RevMarked", CStr(chkReviewMarked.Value)
            SaveSetting "Nerdom6", M_USER, "ItemReview", CStr(chkItemReview.Value)
            SaveSetting "Nerdom6", M_USER, "EndExam", CStr(chkEndExam.Value)
            SaveSetting "Nerdom6", M_USER, "RevUnMarked", CStr(chkReviewUnMarked.Value)
            SaveSetting "Nerdom6", M_USER, "HideTimer", CStr(chkHideTimer.Value)
            SaveSetting "Nerdom6", M_USER, "PauseTimer", CStr(chkPauseTimer.Value)
            SaveSetting "Nerdom6", M_USER, "RevCorrect", CStr(chkReviewCorrect.Value)
            SaveSetting "Nerdom6", M_USER, "RevIncorrect", CStr(chkReviewIncorrect.Value)
            SaveSetting "Nerdom6", M_USER, "RevAnswered", CStr(chkReviewAnswered.Value)
            SaveSetting "Nerdom6", M_USER, "RevUnanswered", CStr(chkReviewUnanswered.Value)
         End Sub
         
    
