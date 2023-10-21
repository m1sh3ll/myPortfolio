Attribute VB_Name = "modGlobal"
Option Explicit

'ALL FORMS
Public M_BACKCOLOR As String
Public M_BUTTONCOLOR As String
Public M_FONTDISPLAY As String 'all forms
Public M_FONTBOLD As Boolean
Public M_FONTITALIC As Boolean 'all forms
Public M_FONTSIZE As String

Public Function Random(Lowest As Integer, Highest As Integer) As Integer

    Randomize 'reshuffles the numbers
    Random = Int((Highest - Lowest + 1) * Rnd + Lowest) 'returns a random number

End Function


      









