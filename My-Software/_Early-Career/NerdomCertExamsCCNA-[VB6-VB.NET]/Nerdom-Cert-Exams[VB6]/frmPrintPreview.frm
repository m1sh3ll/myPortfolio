VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "Comdlg32.ocx"
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Begin VB.Form frmPrintPreview 
   BackColor       =   &H00C0C0C0&
   Caption         =   "Print Preview - Your Score Report"
   ClientHeight    =   7185
   ClientLeft      =   60
   ClientTop       =   315
   ClientWidth     =   9555
   Icon            =   "frmPrintPreview.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   7185
   ScaleWidth      =   9555
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdFont 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "&Font"
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
      Left            =   0
      Style           =   1  'Graphical
      TabIndex        =   5
      ToolTipText     =   "If score report doesn't print correctly click Edit Text to edit the text directly"
      Top             =   6675
      Width           =   1325
   End
   Begin RichTextLib.RichTextBox txtPrintPreview 
      Height          =   6150
      Left            =   0
      TabIndex        =   4
      Top             =   435
      Width           =   9550
      _ExtentX        =   16854
      _ExtentY        =   10848
      _Version        =   393217
      Enabled         =   -1  'True
      ScrollBars      =   2
      Appearance      =   0
      TextRTF         =   $"frmPrintPreview.frx":0442
   End
   Begin VB.CommandButton cmdViewScoreReport 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "Score &Report"
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
      Left            =   2850
      Style           =   1  'Graphical
      TabIndex        =   3
      ToolTipText     =   "View your detailed score report"
      Top             =   6675
      Width           =   1325
   End
   Begin VB.CommandButton cmdViewNotes 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "&Notes"
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
      Left            =   4275
      Style           =   1  'Graphical
      TabIndex        =   2
      ToolTipText     =   "View the notes you took during the exam"
      Top             =   6675
      Width           =   1325
   End
   Begin VB.CommandButton cmdExit 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Cancel          =   -1  'True
      Caption         =   "C&lose"
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
      Left            =   8280
      Style           =   1  'Graphical
      TabIndex        =   1
      ToolTipText     =   "Back to Main Menu"
      Top             =   6660
      Width           =   1260
   End
   Begin VB.CommandButton cmdPrint 
      Appearance      =   0  'Flat
      BackColor       =   &H00B05800&
      Caption         =   "&Print"
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
      Left            =   5700
      Style           =   1  'Graphical
      TabIndex        =   0
      ToolTipText     =   "Print this document"
      Top             =   6675
      Width           =   1325
   End
   Begin MSComDlg.CommonDialog cdlgPrint 
      Left            =   6750
      Top             =   3975
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
      Flags           =   1
      FontBold        =   -1  'True
   End
   Begin VB.Label lblTitle 
      AutoSize        =   -1  'True
      BackColor       =   &H00800000&
      Caption         =   "  Score Report"
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
      TabIndex        =   6
      Top             =   60
      Width           =   9555
      WordWrap        =   -1  'True
   End
   Begin VB.Line Line1 
      BorderColor     =   &H00808080&
      BorderWidth     =   3
      X1              =   0
      X2              =   9540
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
      TabIndex        =   7
      Top             =   0
      Width           =   9555
      WordWrap        =   -1  'True
   End
End
Attribute VB_Name = "frmPrintPreview"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
    Option Explicit
    Private mStrYourScore As String
    Private mScoreReportText As String
    Private mNotesText As String
    Private mStrNotes As String
    Private mMsgResult As VbMsgBoxResult
    
      
    Private Sub cmdExit_Click()
        Unload Me
    End Sub
    
    Private Sub cmdFont_Click()
    
        On Error Resume Next
        cdlgPrint.CancelError = False
        cdlgPrint.Flags = cdlCFScreenFonts
        cdlgPrint.ShowFont
        txtPrintPreview.Font.Name = cdlgPrint.FontName
        txtPrintPreview.Font.Size = cdlgPrint.FontSize
        
        If cdlgPrint.FontBold = True Then
            txtPrintPreview.Font.Bold = True
        Else
            txtPrintPreview.Font.Bold = False
        End If
        
        If cdlgPrint.FontItalic = True Then
            txtPrintPreview.Font.Italic = True
        Else
            txtPrintPreview.Font.Italic = False
        End If
    End Sub
    
    Private Sub cmdPrint_Click()
    
    On Error Resume Next
    
    With Printer
          Printer.Font.Name = txtPrintPreview.Font.Name
          Printer.Font.Size = txtPrintPreview.Font.Size
          If txtPrintPreview.Font.Bold = True Then
          Printer.FontBold = True ' OR FONT.BOLD
          Else
          Printer.FontBold = False
          End If
          
          If txtPrintPreview.Font.Italic = True Then
          Printer.FontItalic = True ' OR FONT.ITALIC
          Else
          Printer.FontItalic = False
          End If
          Printer.Print txtPrintPreview.Text
          Printer.EndDoc
    End With
    End Sub
    
    Private Sub cmdViewNotes_Click()
    
        txtPrintPreview.Text = mStrNotes
        lblTitle.Caption = "Exam Notes"
    End Sub
    
    Private Sub cmdViewScoreReport_Click()
    
        Dim i As Integer
        Dim TodayDateTime As String
       
        lblTitle.Caption = M_USERNAME & "'s Score Report"
        
        Me.BackColor = M_BACKCOLOR
        cmdExit.BackColor = M_BUTTONCOLOR
        cmdPrint.BackColor = cmdExit.BackColor
        cmdViewNotes.BackColor = cmdExit.BackColor
        cmdViewScoreReport.BackColor = cmdExit.BackColor
        cmdFont.BackColor = cmdExit.BackColor
           
        TodayDateTime = Format(Now, "long date") & " " & Format(Now, "long time")
        
        txtPrintPreview.Text = "Nerdom Cert Exams " & App.Major & "." & App.Minor & " Score Report" & vbCrLf _
            & M_EXAMNAME & vbCrLf _
            & "-------------------------------------------------------" & vbCrLf _
            & M_USERNAME & vbCrLf _
            & TodayDateTime & vbCrLf _
            & "-------------------------------------------------------" & vbCrLf _
            & mStrYourScore & vbCrLf
        
        For i = 1 To M_INTNUMOFQUESTIONS
        
        If M_INTANSWERS(i) = 1 Then
              txtPrintPreview.Text = txtPrintPreview.Text & vbCrLf _
              & "Question # " & i & ". Correct. " & vbCrLf _
              & M_STRQUESTION(i) & vbCrLf _
              & "Correct Answer:  " & M_STRANSWER(i) & vbCrLf
        Else
                If M_STRQUESTION(i) <> "" Then
                    txtPrintPreview.Text = txtPrintPreview.Text & vbCrLf _
                    & "Question # " & i & ". Incorrect. " & vbCrLf _
                    & M_STRQUESTION(i) & vbCrLf _
                    & "Correct Answer:  " & M_STRANSWER(i) & vbCrLf
                Else
                    txtPrintPreview.Text = txtPrintPreview.Text & vbCrLf _
                    & "Question # " & i & ". Incomplete." & vbCrLf
                End If
        End If
    Next i
    End Sub
    
    Private Sub Form_Activate()
        ANOTHERFORMSHOWN = True
        cmdViewScoreReport_Click
    End Sub
    
    Private Sub Form_Load()
        GetScore
        ANOTHERFORMSHOWN = True
        lblTitle.Caption = M_USERNAME & "'s Score Report"
        Me.BackColor = M_BACKCOLOR
        cmdExit.BackColor = M_BUTTONCOLOR ' New added this and following
        cmdFont.BackColor = M_BUTTONCOLOR
        cmdPrint.BackColor = M_BUTTONCOLOR
        cmdViewNotes.BackColor = M_BUTTONCOLOR
        cmdViewScoreReport.BackColor = M_BUTTONCOLOR
        
        If M_ADDNOTESBUTTON = False Then cmdViewNotes.Visible = False
    End Sub
    
    Private Sub GetScore()
        Dim i As Integer
        Dim string100 As String
        Dim string90 As String
        Dim string80 As String
        Dim string65 As String
        Dim string50 As String
        Dim stringScore As String
        
          mStrNotes = ""
          
          M_NUMBERCORRECT = 0
          
          For i = 1 To M_INTNUMOFQUESTIONS
            If M_INTANSWERS(i) = 1 Then
                M_NUMBERCORRECT = M_NUMBERCORRECT + 1
            End If
          Next
          
          M_INTSCORE = (M_NUMBERCORRECT / M_INTNUMOFQUESTIONS) * 100
          
          
        stringScore = "Your Score Report: " & vbCrLf _
              & M_NUMBERCORRECT & " correct out of " & M_INTNUMOFQUESTIONS & vbCrLf _
              & "Your score for this exam was " & M_INTSCORE & " %." & vbCrLf
        
        Select Case M_INTSCORE
        Case Is = 100
              string100 = "Results: Pass :) Perfect Score!!!"
              mStrYourScore = stringScore & string100
        Case Is >= 90 And (M_INTSCORE < 100)
              string90 = "Results: Pass :) Excellent! Almost perfect!"
              mStrYourScore = stringScore & string90
        Case Is >= 80 And (M_INTSCORE < 90)
              string80 = "Results: Pass :) Good work!"
              mStrYourScore = stringScore & string80
        Case Is >= 65 And (M_INTSCORE < 80)
              string65 = "Results: Pass :) Needs some work."
              mStrYourScore = stringScore & string65
        Case Is < 65
              string50 = "Results: Fail :( Needs some work. Study study."
              mStrYourScore = stringScore & string50
        End Select
        
        
        mStrNotes = "Exam Notes:" & vbCrLf
        
        mStrNotes = mStrNotes & "----------------------------------------------------------------------------------------------" & vbCrLf
        
         'Exam Notes:
        '--------------------------------------------------
        'Question # 1. slkdfsldkf
        'Question # 5. slkdfjaskldfjas
        'etc.
        For i = 1 To M_INTNUMOFQUESTIONS
            If M_NOTES(i) <> "" Then
                    mStrNotes = mStrNotes & "Question # " & i & "." & M_NOTES(i) & vbCrLf
            End If
        Next
    End Sub

Private Sub Form_Unload(Cancel As Integer)
    ANOTHERFORMSHOWN = False
    If M_ENDEXAM = True Then
        mMsgResult = MsgBox("Once you exit, you will not be able to print your score report (or your notes if notes are enabled). " _
        & " Are you sure you want to exit?", vbYesNoCancel, "Exit Exam?")
            If mMsgResult = vbYes Then
                Unload frmReview
                If M_EXAMTYPE = "E" Then Unload frmNet1
                If M_EXAMTYPE = "L" Then Unload frmNet2
            Else
                Cancel = 1      'Dont close the Score report
            End If
    'Else
               ' If M_EXAMTYPE = "E" Then
                 '   Me.Hide
                 '  frmNet1.Show vbModal 'this else block is new
                'End If
               ' If M_EXAMTYPE = "L" Then
                  '  Me.Hide
                 '   frmNet2.Show vbModal
              '  End If
    End If
End Sub
