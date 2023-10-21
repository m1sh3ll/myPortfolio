Attribute VB_Name = "modExamSpecific2"
Option Explicit
Public M_INTNUMOFQUESTIONS As Integer
Public M_DATABASEPATH As String        'Database Path Existence - For ReturnPathToDB

Public M_EXAMNAME As String
Public M_USERNAME As String            'Name User Enters in Textbox
Public M_FORMCAPTION As String

Public M_INTANSWERS() As Integer 'holds 0 or 1
Public M_STRQUESTION() As String
Public M_STRANSWER() As String
Public M_MARKED() As Integer                      'Marked Ques.
Public M_QUESID() As Integer                        'Record Number
Public M_UNANSWERED() As Integer

Public M_TIMEDTEST As Boolean
Public M_TIMEALLOWED As Integer             'IN MINUTES
Public M_RANDOMQUESTIONS As Boolean
Public M_RANDOMANSWERS As Boolean
Public M_SHOWEXPLANATIONBUTTON As Boolean
Public M_SHOWPERCENTCORRECT As Boolean
Public M_SHOWANSWERBUTTON As Boolean
Public M_SHOWEXPLANATIONCORRECT As Boolean
Public M_SHOWEXPLANATIONINCORRECT As Boolean
Public M_SHOWPREVIOUSBUTTON As Boolean
Public M_ADDNOTESBUTTON As Boolean
Public M_SCORETESTBUTTON As Boolean
Public M_PROGRESSBAR As Boolean
Public M_CORRECTINREVIEW As Boolean
Public M_MULTCHOICEONLY As Boolean
Public M_MARKFORREVIEW As Boolean
Public M_REVIEWMARKEDITEMS As Boolean
Public M_REVIEWUNMARKEDITEMS As Boolean
Public M_REVIEWCORRECTITEMS As Boolean 'new
Public M_REVIEWINCORRECTITEMS As Boolean 'new
Public M_REVIEWANSWEREDITEMS As Boolean 'new
Public M_REVIEWUNANSWEREDITEMS As Boolean 'new

Public M_ITEMREVIEW As Boolean
Public M_ENDEXAM As Boolean
Public M_HIDETIMER As Boolean
Public M_PAUSETIMER As Boolean

Public M_EXAMTYPE As String            'E (Exam), L (Lab), F (Flash Cards)
Public M_EXAMFOLDER As String          'For Exhibit Start Path
Public M_EXHIBITPATH As String

Public M_NUMBERCORRECT As Integer
Public M_INTSCORE As Integer

'ALL FORMS
Public ANOTHERFORMSHOWN As Boolean          'If Popup Form
Public IN_REVIEW_MODE As Boolean                    'If Review Items
Public REVIEWINGMARKED_MODE As Boolean
Public REVIEWINGunMARKED_MODE As Boolean
Public REVIEWINGCORRECT_MODE As Boolean
Public REVIEWINGinCORRECT_MODE As Boolean
Public REVIEWINGANSWERED_MODE As Boolean
Public REVIEWINGunANSWERED_MODE As Boolean
Public REVIEWINGNOTES_MODE As Boolean
Public REVIEWINGnoNOTES_MODE As Boolean

Public M_CURRENTRECORD As Integer                 'Review Ques.
Public M_CURRENTQUESNO As Integer                 'Global Current Record

'USED FOR NOTES
Public M_CURRENTNOTE As Integer                        'Question Number
Public M_NOTES() As String                              'Notes For Each Ques.

'USED FOR EXHIBIT FORM
Public M_CURRENTEXHIBITQUESNO As Integer    'Question Number

'USED FOR EXPLANATION FORM
Public M_ANSWERSTATUS As String                 'INPUTS - Correct, Incorrect
Public M_QID As String                                          'Question ID Field Text
Public M_EXPLANATION As String                      'Explanation Text
Public M_ANSWER As String                                 'Answer Text
Public M_CURRENTEXPLANATIONNUM As Integer   'Question Number
Public M_INCORRECTANSWER As String
Public M_QUESTYPE As String

Type ExamQuestion
    LabelTop(0 To 6) As Integer
    AnswerTop(0 To 6) As Integer 'opts checks
    AnswerCaptions(0 To 6) As String
    QuesID As Integer   'record number
    Answer(0 To 6) As Integer ' 0 1 0 0 0 0 0 0
    InputAnswer As String
    Arranged As String
End Type

Public QUESTION() As ExamQuestion
