VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmNet1 
   BackColor       =   &H00E0E0E0&
   ClientHeight    =   6840
   ClientLeft      =   2835
   ClientTop       =   2880
   ClientWidth     =   9525
   FillStyle       =   0  'Solid
   BeginProperty Font 
      Name            =   "Arial"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmNet1.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   ScaleHeight     =   6840
   ScaleWidth      =   9525
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox Picture1 
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   0  'None
      Height          =   435
      Index           =   0
      Left            =   5340
      Picture         =   "frmNet1.frx":0442
      ScaleHeight     =   435
      ScaleWidth      =   495
      TabIndex        =   69
      Top             =   6000
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   0  'None
      Height          =   435
      Index           =   1
      Left            =   5040
      Picture         =   "frmNet1.frx":0884
      ScaleHeight     =   435
      ScaleWidth      =   495
      TabIndex        =   68
      Top             =   6000
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   0  'None
      Height          =   435
      Index           =   2
      Left            =   5100
      Picture         =   "frmNet1.frx":0CC6
      ScaleHeight     =   435
      ScaleWidth      =   495
      TabIndex        =   67
      Top             =   6000
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   0  'None
      Height          =   435
      Index           =   3
      Left            =   5040
      Picture         =   "frmNet1.frx":1108
      ScaleHeight     =   435
      ScaleWidth      =   495
      TabIndex        =   66
      Top             =   6060
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   0  'None
      Height          =   435
      Index           =   4
      Left            =   5100
      Picture         =   "frmNet1.frx":154A
      ScaleHeight     =   435
      ScaleWidth      =   495
      TabIndex        =   65
      Top             =   6000
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   0  'None
      Height          =   435
      Index           =   5
      Left            =   5100
      Picture         =   "frmNet1.frx":198C
      ScaleHeight     =   435
      ScaleWidth      =   495
      TabIndex        =   64
      Top             =   6000
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   0  'None
      Height          =   435
      Index           =   6
      Left            =   5100
      Picture         =   "frmNet1.frx":1DCE
      ScaleHeight     =   435
      ScaleWidth      =   495
      TabIndex        =   63
      Top             =   6000
      Visible         =   0   'False
      Width           =   495
   End
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
      TabIndex        =   55
      ToolTipText     =   "Click to end the exam and show your score printout."
      Top             =   6360
      Width           =   1680
   End
   Begin VB.Frame fraTheAnswer 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Answer"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1080
      Left            =   360
      TabIndex        =   46
      Top             =   2940
      Visible         =   0   'False
      Width           =   8100
      Begin VB.Label lblTheAnswer 
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         BorderStyle     =   1  'Fixed Single
         DataField       =   "Answer"
         DataSource      =   "Data1"
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
         Height          =   345
         Left            =   420
         TabIndex        =   47
         Top             =   360
         Width           =   7470
      End
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
      Left            =   1680
      Style           =   1  'Graphical
      TabIndex        =   2
      ToolTipText     =   "Click this button to Submit your answer. Or click Next."
      Top             =   5940
      Width           =   1695
   End
   Begin VB.CommandButton cmdShowExplanation 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "E&xplanation"
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
      TabIndex        =   50
      Top             =   6360
      Width           =   1530
   End
   Begin VB.CommandButton cmdShowAnswer 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
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
      Left            =   1680
      Style           =   1  'Graphical
      TabIndex        =   45
      ToolTipText     =   "Click to show the answer for this question."
      Top             =   6360
      Width           =   1665
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
      Left            =   7920
      Style           =   1  'Graphical
      TabIndex        =   44
      ToolTipText     =   "Click to add notes to use during the exam and print later."
      Top             =   6360
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
      Left            =   3420
      Style           =   1  'Graphical
      TabIndex        =   4
      ToolTipText     =   "Click to submit your answer and go to the next question."
      Top             =   5940
      Width           =   1335
   End
   Begin VB.CommandButton cmdReview 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "&Review Items"
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
      TabIndex        =   37
      ToolTipText     =   "Click to end the exam and show your score printout."
      Top             =   5940
      Width           =   1680
   End
   Begin VB.Data Data1 
      Caption         =   "Data1"
      Connect         =   "Access 2000;"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   345
      Left            =   225
      Options         =   0
      ReadOnly        =   -1  'True
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   6435
      Visible         =   0   'False
      Width           =   1095
   End
   Begin VB.Frame frameBackground 
      Appearance      =   0  'Flat
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   5580
      Left            =   60
      TabIndex        =   0
      Top             =   300
      Width           =   9375
      Begin VB.Frame fraQues 
         Appearance      =   0  'Flat
         BackColor       =   &H00FFFFFF&
         BorderStyle     =   0  'None
         Caption         =   "                                                                      "
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   5625
         Index           =   0
         Left            =   0
         TabIndex        =   1
         Top             =   0
         Width           =   9325
         Begin VB.TextBox txtQuesN1 
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
            Height          =   1215
            Left            =   60
            Locked          =   -1  'True
            MultiLine       =   -1  'True
            ScrollBars      =   2  'Vertical
            TabIndex        =   26
            Text            =   "frmNet1.frx":2210
            Top             =   120
            Width           =   9225
         End
         Begin VB.Frame fraInput 
            Appearance      =   0  'Flat
            BackColor       =   &H00FFFFFF&
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H80000008&
            Height          =   1215
            Left            =   300
            TabIndex        =   34
            Top             =   1380
            Visible         =   0   'False
            Width           =   8115
            Begin VB.TextBox txtInput 
               Appearance      =   0  'Flat
               BackColor       =   &H00FFFFFF&
               BeginProperty Font 
                  Name            =   "Courier New"
                  Size            =   9.75
                  Charset         =   0
                  Weight          =   700
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   345
               Left            =   360
               MaxLength       =   254
               TabIndex        =   35
               Top             =   480
               Width           =   7515
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
               Left            =   360
               TabIndex        =   36
               Top             =   120
               Width           =   2655
            End
         End
         Begin VB.Frame fraChks 
            Appearance      =   0  'Flat
            BackColor       =   &H00FFFFFF&
            BorderStyle     =   0  'None
            Caption         =   "Frame1"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H80000008&
            Height          =   4185
            Index           =   0
            Left            =   240
            TabIndex        =   16
            Top             =   1440
            Visible         =   0   'False
            Width           =   645
            Begin VB.CheckBox chkFra0 
               Appearance      =   0  'Flat
               BackColor       =   &H00FFFFFF&
               Caption         =   "A"
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
               Left            =   0
               TabIndex        =   23
               Top             =   0
               Visible         =   0   'False
               Width           =   555
            End
            Begin VB.CheckBox chkFra0 
               Appearance      =   0  'Flat
               BackColor       =   &H00FFFFFF&
               Caption         =   "G"
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
               Index           =   6
               Left            =   0
               TabIndex        =   22
               Top             =   3600
               Visible         =   0   'False
               Width           =   555
            End
            Begin VB.CheckBox chkFra0 
               Appearance      =   0  'Flat
               BackColor       =   &H00FFFFFF&
               Caption         =   "F"
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
               Index           =   5
               Left            =   0
               TabIndex        =   21
               Top             =   3000
               Visible         =   0   'False
               Width           =   555
            End
            Begin VB.CheckBox chkFra0 
               Appearance      =   0  'Flat
               BackColor       =   &H00FFFFFF&
               Caption         =   "E"
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
               Index           =   4
               Left            =   0
               TabIndex        =   20
               Top             =   2400
               Visible         =   0   'False
               Width           =   555
            End
            Begin VB.CheckBox chkFra0 
               Appearance      =   0  'Flat
               BackColor       =   &H00FFFFFF&
               Caption         =   "D"
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
               Index           =   3
               Left            =   0
               TabIndex        =   19
               Top             =   1830
               Visible         =   0   'False
               Width           =   555
            End
            Begin VB.CheckBox chkFra0 
               Appearance      =   0  'Flat
               BackColor       =   &H00FFFFFF&
               Caption         =   "C"
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
               Index           =   2
               Left            =   0
               TabIndex        =   18
               Top             =   1200
               Visible         =   0   'False
               Width           =   555
            End
            Begin VB.CheckBox chkFra0 
               Appearance      =   0  'Flat
               BackColor       =   &H00FFFFFF&
               Caption         =   "B"
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
               Left            =   0
               TabIndex        =   17
               Top             =   600
               Visible         =   0   'False
               Width           =   555
            End
         End
         Begin VB.OptionButton optFra0 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            Caption         =   "C"
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
            Index           =   2
            Left            =   240
            TabIndex        =   24
            Top             =   2640
            Visible         =   0   'False
            Width           =   555
         End
         Begin VB.OptionButton optFra0 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            Caption         =   "A"
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
            Left            =   240
            TabIndex        =   15
            Top             =   1440
            Visible         =   0   'False
            Width           =   555
         End
         Begin VB.OptionButton optFra0 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            Caption         =   "G"
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
            Index           =   6
            Left            =   240
            TabIndex        =   14
            Top             =   5040
            Visible         =   0   'False
            Width           =   555
         End
         Begin VB.OptionButton optFra0 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            Caption         =   "F"
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
            Index           =   5
            Left            =   240
            TabIndex        =   13
            Top             =   4440
            Visible         =   0   'False
            Width           =   555
         End
         Begin VB.OptionButton optFra0 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            Caption         =   "E"
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
            Index           =   4
            Left            =   240
            TabIndex        =   12
            Top             =   3840
            Visible         =   0   'False
            Width           =   555
         End
         Begin VB.OptionButton optFra0 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            Caption         =   "D"
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
            Index           =   3
            Left            =   240
            TabIndex        =   11
            Top             =   3240
            Visible         =   0   'False
            Width           =   555
         End
         Begin VB.OptionButton optFra0 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            Caption         =   "B"
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
            Left            =   240
            TabIndex        =   10
            Top             =   2040
            Visible         =   0   'False
            Width           =   555
         End
         Begin VB.OptionButton optDefault 
            Caption         =   "optDefault"
            Height          =   240
            Left            =   2340
            TabIndex        =   62
            Top             =   360
            Width           =   2235
         End
         Begin VB.Label lblFra0 
            AutoSize        =   -1  'True
            BackColor       =   &H00808080&
            BackStyle       =   0  'Transparent
            Caption         =   "lblN1AnsG"
            DataField       =   "AnsG"
            DataSource      =   "Data1"
            ForeColor       =   &H00000000&
            Height          =   240
            Index           =   6
            Left            =   900
            TabIndex        =   9
            Top             =   5040
            Visible         =   0   'False
            Width           =   8115
            WordWrap        =   -1  'True
         End
         Begin VB.Label lblFra0 
            AutoSize        =   -1  'True
            BackColor       =   &H00808080&
            BackStyle       =   0  'Transparent
            Caption         =   "lblN1AnsC"
            DataField       =   "AnsC"
            DataSource      =   "Data1"
            ForeColor       =   &H00000000&
            Height          =   240
            Index           =   2
            Left            =   900
            TabIndex        =   25
            Top             =   2640
            Width           =   8115
            WordWrap        =   -1  'True
         End
         Begin VB.Label lblFra0 
            AutoSize        =   -1  'True
            BackColor       =   &H00808080&
            BackStyle       =   0  'Transparent
            Caption         =   "lblN1AnsF"
            DataField       =   "AnsF"
            DataSource      =   "Data1"
            ForeColor       =   &H00000000&
            Height          =   240
            Index           =   5
            Left            =   900
            TabIndex        =   8
            Top             =   4440
            Visible         =   0   'False
            Width           =   8115
            WordWrap        =   -1  'True
         End
         Begin VB.Label lblFra0 
            AutoSize        =   -1  'True
            BackColor       =   &H00808080&
            BackStyle       =   0  'Transparent
            Caption         =   "lblN1AnsE"
            DataField       =   "AnsE"
            DataSource      =   "Data1"
            ForeColor       =   &H00000000&
            Height          =   240
            Index           =   4
            Left            =   900
            TabIndex        =   7
            Top             =   3840
            Visible         =   0   'False
            Width           =   8115
            WordWrap        =   -1  'True
         End
         Begin VB.Label lblFra0 
            AutoSize        =   -1  'True
            BackColor       =   &H00808080&
            BackStyle       =   0  'Transparent
            Caption         =   "lblN1AnsD"
            DataField       =   "AnsD"
            DataSource      =   "Data1"
            ForeColor       =   &H00000000&
            Height          =   240
            Index           =   3
            Left            =   900
            TabIndex        =   6
            Top             =   3240
            Width           =   8115
            WordWrap        =   -1  'True
         End
         Begin VB.Label lblFra0 
            AutoSize        =   -1  'True
            BackColor       =   &H00808080&
            BackStyle       =   0  'Transparent
            Caption         =   "lblN1AnsB"
            DataField       =   "AnsB"
            DataSource      =   "Data1"
            ForeColor       =   &H00000000&
            Height          =   240
            Index           =   1
            Left            =   900
            TabIndex        =   5
            Top             =   2040
            Visible         =   0   'False
            Width           =   8115
            WordWrap        =   -1  'True
         End
         Begin VB.Label lblFra0 
            AutoSize        =   -1  'True
            BackColor       =   &H00C0FFFF&
            BackStyle       =   0  'Transparent
            Caption         =   "lblN1AnsA"
            DataField       =   "AnsA"
            DataSource      =   "Data1"
            ForeColor       =   &H00000000&
            Height          =   240
            Index           =   0
            Left            =   900
            TabIndex        =   3
            Top             =   1440
            Visible         =   0   'False
            Width           =   8115
            WordWrap        =   -1  'True
         End
      End
   End
   Begin VB.CommandButton cmdShow 
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
      Left            =   7920
      Style           =   1  'Graphical
      TabIndex        =   41
      ToolTipText     =   "Click to show the exhibit image for this question."
      Top             =   5940
      Width           =   1530
   End
   Begin VB.Timer Timer1 
      Interval        =   60000
      Left            =   1500
      Top             =   6300
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
      Left            =   75
      Style           =   1  'Graphical
      TabIndex        =   48
      ToolTipText     =   "Click to submit your answer and go to the next question."
      Top             =   5940
      Width           =   1530
   End
   Begin MSComctlLib.ProgressBar progressBar1 
      Height          =   195
      Left            =   3180
      TabIndex        =   27
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
      Left            =   7710
      TabIndex        =   49
      Top             =   15
      Width           =   1860
   End
   Begin VB.Line Line4 
      BorderWidth     =   4
      X1              =   60
      X2              =   9420
      Y1              =   5880
      Y2              =   5880
   End
   Begin VB.Line Line2 
      BorderWidth     =   5
      X1              =   60
      X2              =   9420
      Y1              =   300
      Y2              =   300
   End
   Begin VB.Line Line3 
      BorderWidth     =   5
      X1              =   9420
      X2              =   9420
      Y1              =   300
      Y2              =   5870
   End
   Begin VB.Line Line1 
      BorderWidth     =   5
      X1              =   60
      X2              =   60
      Y1              =   300
      Y2              =   5870
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
      Left            =   4800
      TabIndex        =   71
      ToolTipText     =   "Click to pause the time Remaining."
      Top             =   6480
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
      Left            =   3600
      TabIndex        =   70
      ToolTipText     =   "Click to hide the time Remaining."
      Top             =   6480
      Width           =   915
   End
   Begin VB.Label lblAns 
      Caption         =   "0"
      DataField       =   "Ans7"
      DataSource      =   "Data1"
      ForeColor       =   &H00C000C0&
      Height          =   195
      Index           =   6
      Left            =   3180
      TabIndex        =   61
      Top             =   6360
      Visible         =   0   'False
      Width           =   195
   End
   Begin VB.Label lblAns 
      Caption         =   "0"
      DataField       =   "Ans6"
      DataSource      =   "Data1"
      ForeColor       =   &H00C000C0&
      Height          =   195
      Index           =   5
      Left            =   2880
      TabIndex        =   60
      Top             =   6360
      Visible         =   0   'False
      Width           =   195
   End
   Begin VB.Label lblAns 
      Caption         =   "0"
      DataField       =   "Ans5"
      DataSource      =   "Data1"
      ForeColor       =   &H00C000C0&
      Height          =   195
      Index           =   4
      Left            =   2640
      TabIndex        =   59
      Top             =   6360
      Visible         =   0   'False
      Width           =   195
   End
   Begin VB.Label lblAns 
      Caption         =   "0"
      DataField       =   "Ans4"
      DataSource      =   "Data1"
      ForeColor       =   &H00C000C0&
      Height          =   195
      Index           =   3
      Left            =   2400
      TabIndex        =   58
      Top             =   6360
      Visible         =   0   'False
      Width           =   195
   End
   Begin VB.Label lblAns 
      Caption         =   "0"
      DataField       =   "Ans3"
      DataSource      =   "Data1"
      ForeColor       =   &H00C000C0&
      Height          =   195
      Index           =   2
      Left            =   2220
      TabIndex        =   57
      Top             =   6360
      Visible         =   0   'False
      Width           =   195
   End
   Begin VB.Label lblAns 
      Caption         =   "0"
      DataField       =   "Ans2"
      DataSource      =   "Data1"
      ForeColor       =   &H00C000C0&
      Height          =   195
      Index           =   1
      Left            =   1980
      TabIndex        =   56
      Top             =   6360
      Visible         =   0   'False
      Width           =   195
   End
   Begin VB.Label lblQuestionIDNumber 
      Appearance      =   0  'Flat
      BackColor       =   &H00E0E0E0&
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
      ForeColor       =   &H80000008&
      Height          =   300
      Left            =   1080
      TabIndex        =   54
      Top             =   5880
      Visible         =   0   'False
      Width           =   1395
   End
   Begin VB.Label lblCorrectInc 
      BackColor       =   &H00FFFFFF&
      BackStyle       =   0  'Transparent
      Caption         =   "Correct!"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   240
      Left            =   240
      TabIndex        =   53
      Top             =   5880
      Visible         =   0   'False
      Width           =   1365
   End
   Begin VB.Label lblCorrectAnswer 
      Appearance      =   0  'Flat
      BackColor       =   &H00C0FFFF&
      BorderStyle     =   1  'Fixed Single
      DataField       =   "Answer"
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
      Height          =   330
      Left            =   1500
      TabIndex        =   52
      Top             =   5940
      Visible         =   0   'False
      Width           =   930
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
      Height          =   315
      Left            =   1200
      TabIndex        =   51
      Top             =   6060
      Visible         =   0   'False
      Width           =   930
      WordWrap        =   -1  'True
   End
   Begin VB.Label lblChkOrOpt 
      Caption         =   "o"
      DataField       =   "chkoropt"
      DataSource      =   "Data1"
      ForeColor       =   &H000000FF&
      Height          =   195
      Left            =   1740
      TabIndex        =   43
      Top             =   6600
      Visible         =   0   'False
      Width           =   195
   End
   Begin VB.Label lblAns 
      Caption         =   "0"
      DataField       =   "Ans1"
      DataSource      =   "Data1"
      ForeColor       =   &H00C000C0&
      Height          =   195
      Index           =   0
      Left            =   1740
      TabIndex        =   42
      Top             =   6360
      Visible         =   0   'False
      Width           =   195
   End
   Begin VB.Label lblExhibitNum 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Exh nam"
      DataField       =   "ExhibitName"
      DataSource      =   "Data1"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   195
      Left            =   2010
      TabIndex        =   40
      Top             =   6510
      Visible         =   0   'False
      Width           =   615
   End
   Begin VB.Label lblExhibit 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Exhibit"
      DataField       =   "Exhibit"
      DataSource      =   "Data1"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   195
      Left            =   6150
      TabIndex        =   39
      Top             =   6510
      Visible         =   0   'False
      Width           =   465
   End
   Begin VB.Label lblInputB 
      BackColor       =   &H00FFFFFF&
      DataField       =   "InputAnswer2"
      DataSource      =   "Data1"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   1380
      TabIndex        =   33
      Top             =   6000
      Visible         =   0   'False
      Width           =   1815
   End
   Begin VB.Label lblInputA 
      BackColor       =   &H00FFFFFF&
      DataField       =   "InputAnswer"
      DataSource      =   "Data1"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   1260
      TabIndex        =   32
      Top             =   6000
      Visible         =   0   'False
      Width           =   1815
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
      Height          =   195
      Left            =   2340
      TabIndex        =   28
      Top             =   15
      Width           =   795
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
      Left            =   6420
      TabIndex        =   38
      Top             =   15
      Width           =   1020
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
      Height          =   195
      Left            =   60
      TabIndex        =   31
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
      TabIndex        =   30
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
      Height          =   195
      Left            =   5400
      TabIndex        =   29
      Top             =   15
      Width           =   885
   End
End
Attribute VB_Name = "frmNet1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
    Option Explicit
    
    Private mblnClickedSubmit As Boolean, mblnClickedShowAnswer As Boolean
    Private mblnClickedPrevious As Boolean, mblnClickedHideTime As Boolean
        
    Private mintTotalRecords As Integer, mintCurrentRecord As Integer   'LAST , CURRENT QUES
    Private mintCurrentRandQues As Integer  'CURRENT QUESTION - FOR RANDOMIZING QUES
    Private mintUsedRandQuestions() As Integer  'USED QUESTIONS - FOR RANDOMIZING
    Private mdbDAODB36 As Database  'db - MS ACCESS 2000
    Private mdaoRS As DAO.Recordset  'HOLDS RECORDSET
    Private LabelCaptions(0 To 6) As String 'LABEL CAPTIONS
    Private mintOption(0 To 6) As Integer
    Private M_USER As String
    
    Private m_FormBrdr As String, m_AnswerBG As String, m_AnswerFG As String
    Private m_txtBoxBG As String, m_txtBoxFG As String, m_TimelblsFG As String
    Private m_InputFG As String, m_InputBG As String, m_SubmitBG As String
    Private m_FwdBG As String, m_ScoreBG As String, m_NotesAnswerBG As String
    Private m_ShowHideExp As String
    
Private Sub chkMarkForReview_Click()
    If chkMarkForReview.Value = 1 Then
              M_MARKED(mintCurrentRecord) = 1
            Else
                M_MARKED(mintCurrentRecord) = 0
            End If
End Sub

        Private Sub Form_Load() 'only loads once
            M_USER = "U" & M_USERNAME
          Dim i As Integer
          LabelCaptions(0) = "A"
          LabelCaptions(1) = "B"
          LabelCaptions(2) = "C"
          LabelCaptions(3) = "D"
          LabelCaptions(4) = "E"
          LabelCaptions(5) = "F"
          LabelCaptions(6) = "G"
          
          For i = 0 To 6
                mintOption(i) = 0
          Next
          
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
          
          If M_TIMEDTEST = False Then    '***** NO TIMED TEST *******
                    Timer1.Enabled = False
                    lblTimeDiff.Visible = False
                    lblTimeRemainingDesc.Visible = False
                    lblHIDETIME.Visible = False
                    lblPauseTimer.Visible = False
           Else                                                   '****** TIMED TEST *******
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
     
      Private Sub Form_Activate() 'WHEN FORM RECEIVES FOCUS
            M_BUTTONCOLOR = cmdSubmit.BackColor
            M_BACKCOLOR = Me.BackColor
            mblnClickedSubmit = False
            lblCorrectInc.Caption = ""

        If ANOTHERFORMSHOWN = False Then
            If IN_REVIEW_MODE = False Then  'Do Everytime Form Is Activated
                    OpenDAODataBase
                    FirstQuestion
                    cmdReview.Enabled = False
            End If
    
            If IN_REVIEW_MODE = True Then
                    Me.Caption = "REVIEW MODE"
                      'If in a specific Review Mode set the Form Caption 0402
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
            CheckBoxQuestion    'NOT IN LABS
            OptionQuestion
            InputQuestion
            TrueFalse_AllOfAboveQuestion
        End If
        
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
        'Case False - in labs
         Select Case M_MULTCHOICEONLY
            Case False
                Set mdaoRS = mdbDAODB36.OpenRecordset("Q1")
                Set Data1.Recordset = mdaoRS
                Data1.Recordset.MoveLast
                mintTotalRecords = Data1.Recordset.RecordCount
            Case True
                Set mdaoRS = mdbDAODB36.OpenRecordset("SELECT * From Q1 WHERE chkoropt<>'i'")
                Set Data1.Recordset = mdaoRS
                Data1.Recordset.MoveLast
                mintTotalRecords = Data1.Recordset.RecordCount
        End Select
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
            '************put into array ***
           M_STRQUESTION(mintCurrentRecord) = txtQuesN1.Text
           M_STRANSWER(mintCurrentRecord) = lblTheAnswer.Caption
             '************put into array ***
            '**********Review button *****
            If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
                    cmdReview.Enabled = True
                    cmdForward.Enabled = False 'new
            'Else: cmdReview.Enabled = False
            End If '*************Review button*******
            
            If IN_REVIEW_MODE = True Then '*'IF IN REVIEW MODE
                    M_NUMBERCORRECT = M_NUMBERCORRECT - 1   'SET NUMBER CORRECT - 1 to RE-MARK IT
            End If
            ScoreQuestion
   
            cmdSubmit.Enabled = False
            ShowPercentCorrect
            SaveAnswer  'works
    End Sub
    
    Sub SaveAnswer()            'getAnswers after current record is incremented in Next. or Dec. in Prev.
    
    Dim i As Integer, iSum As Integer
        'save your answer
        'loop through opts
        'or mark unanswered
        'new- will be all 0's for inputanswer or unans.
     If lblChkOrOpt.Caption = "o" Or lblChkOrOpt.Caption = "O" Or _
     lblChkOrOpt.Caption = "tf" Or lblChkOrOpt.Caption = "Tf" Or _
     lblChkOrOpt.Caption = "ab" Then
            For i = 0 To 6
                    If optFra0(i).Value = True Then
                            QUESTION(mintCurrentRecord).Answer(i) = 1
                    Else
                            QUESTION(mintCurrentRecord).Answer(i) = 0
                    End If
                    QUESTION(mintCurrentRecord).LabelTop(i) = lblFra0(i).Top
                    QUESTION(mintCurrentRecord).AnswerTop(i) = optFra0(i).Top
                    QUESTION(mintCurrentRecord).AnswerCaptions(i) = optFra0(i).Caption
            Next
            If optDefault.Value = True Then
                    M_UNANSWERED(mintCurrentRecord) = 1 'UNANSWERED
            Else
                    M_UNANSWERED(mintCurrentRecord) = 0 'ANSWERED
            End If
    End If
    
    If lblChkOrOpt.Caption = "i" Or lblChkOrOpt.Caption = "I" Then
                If txtInput.Text <> "" Then
                        QUESTION(mintCurrentRecord).InputAnswer = txtInput.Text
                        M_UNANSWERED(mintCurrentRecord) = 0
                Else
                        M_UNANSWERED(mintCurrentRecord) = 1 'UNANSWERED if ""
                End If
    End If
    
    If lblChkOrOpt.Caption = "c" Or lblChkOrOpt.Caption = "C" Then
            For i = 0 To 6
                    QUESTION(mintCurrentRecord).Answer(i) = chkFra0(i).Value
                    QUESTION(mintCurrentRecord).LabelTop(i) = lblFra0(i).Top
                    QUESTION(mintCurrentRecord).AnswerTop(i) = chkFra0(i).Top
                    QUESTION(mintCurrentRecord).AnswerCaptions(i) = chkFra0(i).Caption
            Next
            
            For i = 0 To 6                          'sum up all the values
                    iSum = iSum + chkFra0(i).Value
            Next
            
            If iSum = 0 Then
                    M_UNANSWERED(mintCurrentRecord) = 1
            Else
                    M_UNANSWERED(mintCurrentRecord) = 0 'UNANSWERED IF Not Checked
            End If
    End If
    
   ' MsgBox ("mintcurrentrecord: " & mintCurrentRecord & " unanswered: " & M_UNANSWERED(mintCurrentRecord))
    
    End Sub
    
      
    Sub GetAnswer()            'getAnswers after current record is incremented in Next. or Dec. in Prev.
    
    Dim i As Integer, iSum As Integer
        'save your answer
        'loop through opts
        
        'new- will be all 0's for inputanswer or unans.
     If lblChkOrOpt.Caption = "o" Or lblChkOrOpt.Caption = "O" Or _
     lblChkOrOpt.Caption = "tf" Or lblChkOrOpt.Caption = "Tf" Or _
     lblChkOrOpt.Caption = "ab" Then
            For i = 0 To 6
                    If QUESTION(mintCurrentRecord).Answer(i) = 0 Then
                            optFra0(i).Value = False
                    Else
                            optFra0(i).Value = True
                    End If
            Next
            'put back in
            If M_UNANSWERED(mintCurrentRecord) = 1 Then
                optDefault.Value = True
           End If
    End If
    
    If lblChkOrOpt.Caption = "i" Or lblChkOrOpt.Caption = "I" Then
                    txtInput.Text = QUESTION(mintCurrentRecord).InputAnswer
    End If
    
    If lblChkOrOpt.Caption = "c" Or lblChkOrOpt.Caption = "C" Then
                    For i = 0 To 6
                        chkFra0(i).Value = QUESTION(mintCurrentRecord).Answer(i)
                    Next
    End If
    End Sub
    
    Sub ScoreQuestion() 'SCORE QUESTION AS RIGHT OR WRONG
    
            Dim i As Integer
            
            If lblChkOrOpt.Caption = "o" Or lblChkOrOpt.Caption = "O" Or _
            lblChkOrOpt.Caption = "tf" Or lblChkOrOpt.Caption = "Tf" Or _
                                       lblChkOrOpt.Caption = "ab" Then
                                       
            For i = 0 To 6
                If optFra0(i).Value = True Then
                    mintOption(i) = 1
                Else: mintOption(i) = 0
                End If
            Next
            
              If mintOption(0) = lblAns(0).Caption And mintOption(1) = lblAns(1).Caption _
              And mintOption(2) = lblAns(2).Caption And mintOption(3) = lblAns(3).Caption _
              And mintOption(4) = lblAns(4).Caption And mintOption(5) = lblAns(5).Caption _
                                                  And mintOption(6) = lblAns(6).Caption Then
                                                  M_INTANSWERS(mintCurrentRecord) = 1       'Correct
                Else: M_INTANSWERS(mintCurrentRecord) = 0
              End If
         End If
         
         If lblChkOrOpt.Caption = "c" Or lblChkOrOpt.Caption = "C" Then
              If chkFra0(0).Value = CInt(lblAns(0).Caption) And chkFra0(1).Value = CInt(lblAns(1).Caption) _
              And chkFra0(2).Value = CInt(lblAns(2).Caption) And chkFra0(3).Value = CInt(lblAns(3).Caption) _
              And chkFra0(4).Value = CInt(lblAns(4).Caption) And chkFra0(5).Value = CInt(lblAns(5).Caption) _
                                                             And chkFra0(6).Value = CInt(lblAns(6).Caption) Then
                   M_INTANSWERS(mintCurrentRecord) = 1 'mark Answer as Correct
              Else: M_INTANSWERS(mintCurrentRecord) = 0
              End If
         End If
         
         If lblChkOrOpt.Caption = "i" Or lblChkOrOpt = "I" Then
              If (txtInput.Text = lblInputA.Caption) Or (txtInput.Text = lblInputB.Caption) Or _
              (LCase(txtInput.Text) = LCase(lblInputA.Caption)) Or (LCase(txtInput.Text) = LCase(lblInputB.Caption)) Then
                   M_INTANSWERS(mintCurrentRecord) = 1 'marks the answer as right
              Else: M_INTANSWERS(mintCurrentRecord) = 0 'marks the answer as wrong
              End If
         End If
         
                If M_INTANSWERS(mintCurrentRecord) = 1 Then
                    lblCorrectInc.Caption = "Correct!"
                    'If M_SHOWEXPLANATIONCORRECT = True And IN_REVIEW_MODE = False And mblnClickedPrevious = False Then cmdShowExplanation_Click
                    M_NUMBERCORRECT = M_NUMBERCORRECT + 1
                Else
                    lblCorrectInc.Caption = "Incorrect!"
                   ' If M_SHOWEXPLANATIONINCORRECT = True And IN_REVIEW_MODE = False And mblnClickedPrevious = False Then cmdShowExplanation_Click
                End If
    End Sub
    
    Private Sub cmdForward_Click()
        FORWARD
    End Sub
    
    Private Sub FORWARD()                               'put in code to handle if in review mode
        Dim currec As Integer
         Dim iIndex As Integer, i As Integer
         
         If mblnClickedSubmit = False Then Call cmdSubmit_Click 'SUMBIT
        ShowExplanation
         For i = 0 To 6
            mintOption(i) = 0
        Next
         If mblnClickedShowAnswer = True Then cmdShowAnswer_Click
         lblCorrectInc.Caption = ""
         txtInput.Text = ""
         cmdSubmit.Enabled = True
         'Prepares to score the quiz if the Next Question is the Last Record
         If (mintCurrentRecord = (M_INTNUMOFQUESTIONS - 1)) Then
                cmdForward.Enabled = False
                cmdPrevious.Enabled = True
         Else: cmdPrevious.Enabled = True
         End If
        If mintCurrentRecord >= 1 And mintCurrentRecord < mintTotalRecords Then
                cmdPrevious.Enabled = True
        End If
        
        mintCurrentRecord = mintCurrentRecord + 1 'must be before nextq.
        NextQuestion
         'checkmarkforreview called from NextQ
        
        'BEGIN NEW CODE FOR REVIEW MARKED ITEMS. THE FOLLOWING CODE WILL SEARCH
        'FOR THE MARKED ITEM TO GO TO STARTING ON CURRENT REC.
        'iF NO MORE ITEMS ARE MARKED, FRMREVIEW WILL LAUNCH
        'AND CODE UNDER THIS BLOCK WILL NOT EXECUTE.
        If REVIEWINGMARKED_MODE = True Then
        
        currec = mintCurrentRecord
                If M_RANDOMQUESTIONS = True Then 'IF RANDOMQUES
                        For i = currec To M_INTNUMOFQUESTIONS
                                If M_MARKED(i) = 0 Then
                                        If mintCurrentRecord = M_INTNUMOFQUESTIONS Then
                                                'Call cmdReview_Click
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
                                If M_MARKED(i) = 0 Then
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
        Call CheckBoxQuestion
        Call OptionQuestion
        Call InputQuestion
        Call TrueFalse_AllOfAboveQuestion
         
         If lblExhibit.Caption = "1" Then   'If Exhibit Field is equal to 1 in the database
              cmdShow.Enabled = True             'Show Exhibit Button
         Else: cmdShow.Enabled = False
         End If
        GetAnswer
        mblnClickedSubmit = False
        
    End Sub
    
    Private Sub cmdPrevious_Click()
    
        PREVIOUS
    End Sub
    
 Private Sub PREVIOUS()
    Dim i As Integer
    Dim currec As Integer
    
    mblnClickedPrevious = True '0331
    If mblnClickedSubmit = False Then Call cmdSubmit_Click
    mblnClickedPrevious = False '0331
     If mblnClickedShowAnswer = True Then cmdShowAnswer_Click
     
     'If mintCurrentRecord = 2 Then cmdPrevious.Enabled = False
     
      mintCurrentRecord = mintCurrentRecord - 1
        
        'PREV QUESTION*******************************
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
        'END PREV QUESTION***********************
        
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
                                        M_CURRENTRECORD = mintCurrentRecord
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
                                        M_CURRENTRECORD = mintCurrentRecord
                                        Exit For
                                End If
                        Next
                End If
        End If 'end if reviewing marked mode = true
        '************************************************************************************
        
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
        
        
        If lblExhibit.Caption = "1" Then   'If Exhibit Field is equal to 1 in the database
              cmdShow.Enabled = True             'Show Exhibit Button
         Else: cmdShow.Enabled = False
         End If
         
     
        Call CheckBoxQuestion   'need to rig for Previous - Random Answer
        Call OptionQuestion
        Call InputQuestion
        Call TrueFalse_AllOfAboveQuestion
        
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
     
      Sub NextQuestion() 'only pick a new random question to go to if the question wasnt seen
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
    
            Dim intX As Integer
            On Error Resume Next
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
    
    Private Sub ArrangeAnswersRandom()
    
            Dim iIndex As Integer, iActualPos As Integer, iTempTopPos As Integer
            Dim iSearchCounter As Integer
            Dim iArrayUsedPos() As Integer
            Dim iOptTop(0 To 6) As Integer, iChkTop(0 To 6) As Integer
            'Basically, this selects first answer, assigns it a random index (iTempTopPos), checks
            'iArrayUsedPos array to see if been used already.  Then moves answer label's - option's
            'Top property to value found in iOptTop(iTempTopPos).  Then fixes Caption of option/ checkbox,
            'so its (A, B, C, etc). Then adds the iTempTopPos index to the array of "used values" - iArrayUsedPos.
            
            fraInput.Visible = False
            iOptTop(0) = 1440
            iOptTop(1) = 2040
            iOptTop(2) = 2640
            iOptTop(3) = 3240
            iOptTop(4) = 3840
            iOptTop(5) = 4440
            iOptTop(6) = 5040
            
            iChkTop(0) = 0
            iChkTop(1) = 600
            iChkTop(2) = 1200
            iChkTop(3) = 1800
            iChkTop(4) = 2400
            iChkTop(5) = 3000
            iChkTop(6) = 3600
            
            iIndex = 0
            iActualPos = 0
            iTempTopPos = 0
                 
            If lblChkOrOpt.Caption = "o" Or lblChkOrOpt.Caption = "O" Then
            
                fraChks(0).Visible = False
                
                Do Until (lblFra0(iIndex).Caption = "")
                     lblFra0(iIndex).Visible = True
                     optFra0(iIndex).Visible = True
                     iIndex = iIndex + 1
                     If iIndex > 6 Then Exit Do         'Safeguard Against Array Subscript Errors
                Loop
                
                Do While (iActualPos <= iIndex - 1)
                     iSearchCounter = 0
                     iTempTopPos = Random(0, iIndex - 1)
                     If iActualPos <> 0 Then
                          Do While iSearchCounter <= UBound(iArrayUsedPos)   'Gets Random number, 'Sees if used
                               If iArrayUsedPos(iSearchCounter) <> iTempTopPos Then
                                    iSearchCounter = iSearchCounter + 1    'Check the Next Entry in UsedPos
                               Else
                                    iTempTopPos = Random(0, iIndex - 1)    'Since it's used, Choose a new number
                                    iSearchCounter = 0                     'Start the search over again
                               End If
                          Loop
                     End If
                     lblFra0(iActualPos).Top = iOptTop(iTempTopPos)
                     optFra0(iActualPos).Top = iOptTop(iTempTopPos)
                     optFra0(iActualPos).Caption = LabelCaptions(iTempTopPos)
                     ReDim Preserve iArrayUsedPos(0 To iActualPos) As Integer
                     iArrayUsedPos(iActualPos) = iTempTopPos
                     iActualPos = iActualPos + 1
                Loop
            
                Do Until iIndex > 6                    'Turn All Other Labels/Options Invisible
                     lblFra0(iIndex).Visible = False
                     optFra0(iIndex).Visible = False
                     iIndex = iIndex + 1
                Loop
            End If
            
            If lblChkOrOpt.Caption = "c" Or lblChkOrOpt.Caption = "C" Then '***IF A CHECK BOX
                fraChks(0).Visible = True
                Do Until (lblFra0(iIndex).Caption = "")
                     lblFra0(iIndex).Visible = True
                     chkFra0(iIndex).Visible = True
                     iIndex = iIndex + 1
                     If iIndex > 6 Then Exit Do
                Loop
                
                Do While (iActualPos <= iIndex - 1)
                     iSearchCounter = 0
                     iTempTopPos = Random(0, iIndex - 1)
                     
                     If iActualPos <> 0 Then
                          Do While iSearchCounter <= UBound(iArrayUsedPos)
                               If iArrayUsedPos(iSearchCounter) <> iTempTopPos Then
                                    iSearchCounter = iSearchCounter + 1
                                Else
                                    iTempTopPos = Random(0, iIndex - 1)
                                    iSearchCounter = 0
                               End If
                          Loop
                     End If
                     
                     lblFra0(iActualPos).Top = iChkTop(iTempTopPos) + 1440
                     chkFra0(iActualPos).Top = iChkTop(iTempTopPos)
                     chkFra0(iActualPos).Caption = LabelCaptions(iTempTopPos)
                     
                     ReDim Preserve iArrayUsedPos(0 To iActualPos) As Integer
                     iArrayUsedPos(iActualPos) = iTempTopPos
                     iActualPos = iActualPos + 1
                Loop
                
                Do Until iIndex > 6
                        lblFra0(iIndex).Visible = False
                        chkFra0(iIndex).Visible = False
                        iIndex = iIndex + 1
                Loop
            End If
    End Sub
    
    
    
    Public Sub ReadRegistryForColorsNet1()
    
            m_FormBrdr = GetSetting("Nerdom6", M_USER, "FormBrdr", &HE0E0E0)
            m_AnswerBG = GetSetting("Nerdom6", M_USER, "AnswerBG", vbWhite)
            m_AnswerFG = GetSetting("Nerdom6", M_USER, "AnswerFG", vbBlack)
            m_txtBoxBG = GetSetting("Nerdom6", M_USER, "txtBoxBG", vbWhite)
            m_txtBoxFG = GetSetting("Nerdom6", M_USER, "txtBoxFG", &HB05800)
            m_TimelblsFG = GetSetting("Nerdom6", M_USER, "TimelblsFG", vbBlack)
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
            m_ShowHideExp = GetSetting("Nerdom6", M_USER, "cShowHideExp", &HB05800)
    End Sub
    
     Private Sub SetFormControlColors()
    
        Dim i As Integer
        'THIS SUB ALSO SETS ALL CONTROLS' COLORS BASED ON REGISTRY
       ' SEE READREGISTRYFORCOLORSNET1
        ' THESE COLORS CAN BE CHANGED BY USER IN FRMCOLORS.
        'MENU EXAM->COLORS->PRACTICE EXAMS
        Call ReadRegistryForColorsNet1
        Me.BackColor = m_FormBrdr
        
        chkMarkForReview.BackColor = m_FormBrdr 'new
        With txtQuesN1
              .Font = M_FONTDISPLAY
              .FontSize = M_FONTSIZE
              .FontBold = M_FONTBOLD
              .FontItalic = M_FONTITALIC
              .BackColor = m_txtBoxBG 'Question textbox
              .ForeColor = m_txtBoxFG 'ques text
        End With
        For i = 0 To 6                        '----Not in Labs-----
              lblFra0(i).Font = M_FONTDISPLAY
              chkFra0(i).Font = M_FONTDISPLAY
              optFra0(i).Font = M_FONTDISPLAY
              lblFra0(i).FontSize = M_FONTSIZE
              chkFra0(i).FontSize = M_FONTSIZE
              optFra0(i).FontSize = M_FONTSIZE
              optFra0(i).BackColor = m_AnswerBG
              chkFra0(i).BackColor = m_AnswerBG
              optFra0(i).ForeColor = m_AnswerFG    'Option buttons
              chkFra0(i).ForeColor = m_AnswerFG    'Checkboxes
              lblFra0(i).ForeColor = m_AnswerFG    'Answers
        Next
         fraQues(0).BackColor = m_AnswerBG
         frameBackground.BackColor = m_AnswerBG 'new
         chkMarkForReview.ForeColor = m_TimelblsFG 'new
         cmdSubmit.BackColor = m_SubmitBG
         cmdForward.BackColor = m_FwdBG
         cmdPrevious.BackColor = m_FwdBG 'new
         cmdNotes.BackColor = m_NotesAnswerBG
         cmdShowAnswer.BackColor = m_NotesAnswerBG
         cmdShow.BackColor = m_ScoreBG 'Show/hide exhibit
         cmdScoreTest.BackColor = m_ScoreBG 'Score test
         cmdReview.BackColor = cmdScoreTest.BackColor
         cmdShowExplanation.BackColor = m_ShowHideExp 'new
         lblExplanation.Font = M_FONTDISPLAY
         lblExplanation.FontSize = M_FONTSIZE
         lblQuestionsSeen.ForeColor = m_TimelblsFG
         lblPercent.ForeColor = m_TimelblsFG
         lblTimeRemainingDesc.ForeColor = m_TimelblsFG
         lblTimeDiff.ForeColor = m_TimelblsFG
         lblPercentCorrect.ForeColor = m_TimelblsFG
         lblHIDETIME.ForeColor = m_TimelblsFG
        lblPauseTimer.ForeColor = m_TimelblsFG
         txtInput.ForeColor = m_InputFG 'v These controls specific to this Form
         txtInput.BackColor = m_InputBG
         fraInput.BackColor = m_AnswerBG
         lblInput.ForeColor = m_AnswerFG
         lblInput.Font = M_FONTDISPLAY
         fraChks(0).BackColor = m_AnswerBG '-----End '----Not in Labs-----

     End Sub
     
     Private Sub SetUpTrueFalseAllOfAboveOpt()
    
        Dim i As Integer
        fraInput.Visible = False
        fraChks(0).Visible = False
        
        optFra0(0).Visible = True 'SET OPT A. visible
        optFra0(1).Visible = True 'SET OPT B. visible
        lblFra0(0).Visible = True 'SET lbl Answer A. visible
        lblFra0(1).Visible = True 'SET lbl Answer B. visible
        
        optFra0(0).Top = 1440 'opt A
        lblFra0(0).Top = 1440 'lbl answer A
        optFra0(1).Top = 2040 'opt B
        lblFra0(1).Top = 2040 'lbl answer B
        
        optFra0(0).Caption = "A"
        optFra0(1).Caption = "B"
        
        optDefault.Value = True 'unchecks all opts
        
        For i = 2 To 6 'make labels opts C-G invisible -last 4 opts for true false
              lblFra0(i).Visible = False
              optFra0(i).Visible = False
        Next
    End Sub
    
    Private Sub SetUpAllofAboveOpt()
    
        Dim t As Integer, i As Integer  ' For AB type questions 4 possible answers.
        t = 2640
        For i = 2 To 3
                optFra0(i).Visible = True
                optFra0(i).Caption = LabelCaptions(i)
                optFra0(i).Top = t
                lblFra0(i).Top = t
                lblFra0(i).Visible = True
                t = t + 600
        Next
        optDefault.Value = True
    End Sub
    
    Private Sub SetUpEFGOpt()
    
       Dim t As Integer, i As Integer
       t = 3840 'start Top Position for Letter "E"
        For i = 4 To 6
                optFra0(i).Visible = True
                optFra0(i).Caption = LabelCaptions(i) 'E, F, G
                optFra0(i).Top = t
                lblFra0(i).Top = t
                lblFra0(i).Visible = True
                t = t + 600
        Next
        MakeLblsChkOptsInvisible
        optDefault.Value = True
        
    End Sub
    
    Private Sub SetUpABCDEFGchk() '1st question is a checkbox, or non random ans. checkbox
    
        Dim i As Integer
        fraInput.Visible = False
        fraChks(0).Visible = True
        For i = 0 To 6
                chkFra0(i).Caption = LabelCaptions(i)
                chkFra0(i).Value = 0
                chkFra0(i).Top = i * 600
                lblFra0(i).Top = chkFra0(i).Top + 1440
        Next
        Call MakeLblsChkOptsInvisible
        optDefault.Value = True
    End Sub
    
    Private Sub MakeLblsChkOptsInvisible()
    
        Dim i As Integer, intindex As Integer
        i = 0
        For intindex = 2 To 6 'make labels opts C-G invisible -last 4 opts for true false
                lblFra0(intindex).Visible = False
                optFra0(intindex).Visible = False
                chkFra0(intindex).Visible = False
        Next
        
        If lblChkOrOpt.Caption = "c" Or lblChkOrOpt.Caption = "C" Or lblChkOrOpt.Caption = "o" _
        Or lblChkOrOpt.Caption = "O" Then
                Do Until (lblFra0(i).Caption = "")
                        lblFra0(i).Visible = True
                        If lblChkOrOpt.Caption = "c" Or lblChkOrOpt.Caption = "C" Then chkFra0(i).Visible = True
                        If lblChkOrOpt.Caption = "o" Or lblChkOrOpt.Caption = "O" Then optFra0(i).Visible = True
                        i = i + 1
                        If i > 6 Then Exit Do 'safeguards against array subscript errors
                Loop
                Exit Sub
        End If
    End Sub
    
    
    Sub CheckBoxQuestion()
    
            Dim i As Integer
            If lblChkOrOpt.Caption = "c" Or lblChkOrOpt.Caption = "C" Then
                    If M_RANDOMANSWERS = True Then
                    fraChks(0).Visible = True 'test
                    fraInput.Visible = False
                            If QUESTION(mintCurrentRecord).Arranged = "" Then 'test
                                    Call ArrangeAnswersRandom 'RANDOMANSWERS
                                    QUESTION(mintCurrentRecord).Arranged = "Yes" 'test
                                    For i = 0 To 6
                                        chkFra0(i).Value = 0
                                    Next
                             Else    'test
                                'arrange them how they were arranged 'test
     
                                    For i = 0 To 6 'test----------------------------------------------------------------------------
                                            lblFra0(i).Left = 900
                                            lblFra0(i).Top = QUESTION(mintCurrentRecord).LabelTop(i)
                                            chkFra0(i).Left = 0
                                            chkFra0(i).Top = QUESTION(mintCurrentRecord).AnswerTop(i)
                                            chkFra0(i).Caption = QUESTION(mintCurrentRecord).AnswerCaptions(i)
                                             If lblFra0(i).Caption <> "" Then
                                                    lblFra0(i).Visible = True
                                                    chkFra0(i).Visible = True
                                            Else
                                                    lblFra0(i).Visible = False
                                                    chkFra0(i).Visible = False
                                            End If
                                    Next 'test
                            End If 'test
                    Else
                            Call SetUpABCDEFGchk 'NON-RANDOM ANSWERS
                    End If
            End If
    End Sub
    
    Sub OptionQuestion()
    
            Dim i As Integer
            If lblChkOrOpt.Caption = "o" Or lblChkOrOpt.Caption = "O" Then
           
                    If M_RANDOMANSWERS = True Then
                             fraInput.Visible = False
                             fraChks(0).Visible = False
                            If QUESTION(mintCurrentRecord).Arranged = "" Then 'test
                                    Call ArrangeAnswersRandom  'RANDOMANSWERS
                                    QUESTION(mintCurrentRecord).Arranged = "Yes" 'test
                                    optDefault.Value = True
                            Else
                                    'arrange them how they were arranged
                                    For i = 0 To 6
                                        lblFra0(i).Left = 900
                                         lblFra0(i).Top = QUESTION(mintCurrentRecord).LabelTop(i)
                                         optFra0(i).Left = 240
                                         optFra0(i).Top = QUESTION(mintCurrentRecord).AnswerTop(i)
                                         optFra0(i).Caption = QUESTION(mintCurrentRecord).AnswerCaptions(i)
                                         If lblFra0(i).Caption <> "" Then
                                                lblFra0(i).Visible = True
                                                optFra0(i).Visible = True
                                        Else
                                                lblFra0(i).Visible = False
                                                optFra0(i).Visible = False
                                        End If
                                     Next
                            End If
                    Else
                            Call SetUpTrueFalseAllOfAboveOpt
                            Call SetUpAllofAboveOpt
                            Call SetUpEFGOpt
                    End If
            End If
    End Sub
    
    Sub InputQuestion()
    
            Dim i As Integer
            If lblChkOrOpt.Caption = "i" Or lblChkOrOpt = "I" Then
                    fraChks(0).Visible = False
                    fraInput.Visible = True
                    txtInput.Text = ""
                    For i = 0 To 6                      'MAKE LABELS,OPTS INVISIBLE
                        lblFra0(i).Visible = False
                        optFra0(i).Visible = False
                    Next
                    optDefault.Value = True
            End If
    End Sub
    
    Sub TrueFalse_AllOfAboveQuestion()
    
            If lblChkOrOpt.Caption = "tf" Or lblChkOrOpt.Caption = "Tf" Or _
            lblChkOrOpt.Caption = "ab" Then
                    Call SetUpTrueFalseAllOfAboveOpt
                    If lblChkOrOpt.Caption = "ab" Then SetUpAllofAboveOpt
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
       
        If 0 >= M_TIMEALLOWED Then 'if 0 > end time
            Call TimeIsUp
        End If
        M_TIMEALLOWED = M_TIMEALLOWED - 1
        Call ShowTimeDiff
    End Sub
    
    Private Sub ShowTimeDiff()
   
        lblTimeDiff.Caption = CStr(M_TIMEALLOWED) & " Minutes"
    End Sub
    
    Private Sub TimeIsUp()
    
            Timer1.Enabled = False
            MsgBox ("Nerdom Cert Exams - Your Time Has Expired. ")
            Call cmdScoreTest_Click
    End Sub
    
    Private Sub cmdShowAnswer_Click()
        Dim i As Integer, temptop As Integer
        'loop through lblans(0).caption - which is a 0 or 1
        'if an opt, tf, ab, 'find the answer, load pic next to answer
         If mblnClickedShowAnswer = False Then
            Select Case lblChkOrOpt.Caption
                    Case Is = "o", "O", "tf", "Tf", "ab", "Ab"
                            For i = 0 To 6
                                  If lblAns(i).Caption = "1" Then
                                          Picture1(0).Top = lblFra0(i).Top + 200
                                          Picture1(0).Left = 60
                                          Picture1(0).Visible = True
                                  End If
                            Next
                    Case Is = "i", "I"
                            fraTheAnswer.Visible = True
                    Case Is = "c", "C"
                            For i = 0 To 6
                                If lblAns(i).Caption = "1" Then
                                    Picture1(i).Top = lblFra0(i).Top + 200
                                    Picture1(i).Left = 60
                                    Picture1(i).Visible = True
                                End If
                            Next
              End Select
              mblnClickedShowAnswer = True
              cmdShowAnswer.Caption = "Hide &Answer"
         Exit Sub
         End If
         
         If mblnClickedShowAnswer = True Then
         Select Case lblChkOrOpt.Caption
                    Case Is = "o", "O", "tf", "Tf", "ab", "Ab"
                            For i = 0 To 6
                                  If lblAns(i).Caption = "1" Then
                                          Picture1(0).Visible = False
                                  End If
                            Next
                    Case Is = "i", "I"
                             fraTheAnswer.Visible = False
                    Case Is = "c", "C"
                            For i = 0 To 6
                                    If lblAns(i).Caption = "1" Then
                                            Picture1(i).Visible = False
                                    End If
                            Next
              End Select
              mblnClickedShowAnswer = False
              cmdShowAnswer.Caption = "Show &Answer"
         End If
    End Sub
    
    Private Sub cmdShow_Click()     'SHOW EXHIBIT
    
            Dim sExhibit As String
            If mblnClickedSubmit = False Then cmdSubmit_Click
            
            ANOTHERFORMSHOWN = True
            M_CURRENTEXHIBITQUESNO = mintCurrentRecord
            If lblExhibitNum.Caption <> "" Then
                    sExhibit = lblExhibitNum.Caption
                    If App.Path = "\" Then
                            M_EXHIBITPATH = App.Path & M_EXAMFOLDER & sExhibit
                    Else
                            M_EXHIBITPATH = App.Path & "\" & M_EXAMFOLDER & sExhibit
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
        Dim i As Integer
    
            If mblnClickedSubmit = False Then cmdSubmit_Click
             M_QUESTYPE = lblChkOrOpt.Caption
            M_EXPLANATION = lblExplanation.Caption
            M_ANSWERSTATUS = lblCorrectInc.Caption
            M_QID = lblQuestionIDNumber.Caption
            M_CURRENTEXPLANATIONNUM = mintCurrentRecord
                        
            M_INCORRECTANSWER = ""
            M_ANSWER = ""
            
            Select Case lblChkOrOpt.Caption
                Case Is = "o", "O", "Tf", "tf", "ab", "A"
                        For i = 0 To 6
                            If lblAns(i).Caption = "1" Then
                                M_ANSWER = M_ANSWER & optFra0(i).Caption & ". " & lblFra0(i).Caption & vbCrLf
                            Else
                                If lblFra0(i).Visible = True Then
                                M_INCORRECTANSWER = M_INCORRECTANSWER & optFra0(i).Caption & ". " & lblFra0(i).Caption & vbCrLf
                                End If
                            End If
                        Next
                Case Is = "c"
                    For i = 0 To 6
                            If lblAns(i).Caption = "1" Then
                                M_ANSWER = M_ANSWER & chkFra0(i).Caption & ". " & lblFra0(i).Caption & vbCrLf
                            Else
                                If lblFra0(i).Visible = True Then
                                M_INCORRECTANSWER = M_INCORRECTANSWER & chkFra0(i).Caption & ". " & lblFra0(i).Caption & vbCrLf
                                End If
                            End If
                        Next
                Case Is = "i"
                    M_ANSWER = lblCorrectAnswer.Caption
            End Select
            
            ANOTHERFORMSHOWN = True
            frmExplanation.Show vbModal
    End Sub
    
    Sub ShowExplanation()
    'calls cmdshowexplanation_click
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
    
    Sub ReviewClick() 'same as cmdReview Click only dont set m_currentrec
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
        frmReview.Show 'vbModal
    End Sub
    
      Private Sub cmdScoreTest_Click()
            M_BUTTONCOLOR = cmdSubmit.BackColor
            M_BACKCOLOR = Me.BackColor
            If mblnClickedSubmit = False Then Call cmdSubmit_Click
            ANOTHERFORMSHOWN = True
            IN_REVIEW_MODE = True
            MarkForReview
            M_CURRENTRECORD = mintCurrentRecord
            'Me.Hide
            frmPrintPreview.Show ' vbModal
    End Sub
    
    Private Sub lblFra0_Click(Index As Integer)
        'WHEN THE ANSWER IS CLICKED, FILL IN THE RADIO BUTTON
        'OR CHECKBOX
        If lblChkOrOpt.Caption <> "i" Then
            If lblChkOrOpt.Caption = "c" Then
                If chkFra0(Index).Value = 0 Then 'if it is unchecked
                        chkFra0(Index).Value = 1    'check it
                Else: chkFra0(Index).Value = 0      'uncheck it if it is checked
                End If
            Else 'tf 'ab 'o
                optFra0(Index).Value = True 'this doesnt need to set optdefault.
            End If
        End If
End Sub

    
        Private Sub optFra0_Click(Index As Integer)
    
        cmdSubmit.Enabled = True
    End Sub
    
    Private Sub chkFra0_Click(Index As Integer)
        
                cmdSubmit.Enabled = True
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
