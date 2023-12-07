Module modExamOptions
    Friend fSTRFILENAME As String '.mdb now the testq.exe.
    Friend fPARENTFOLDER As String
    Friend fPARENTPATH As String

    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
    Private Const SW_SHOW As Short = 1

    Public Sub Navigate(ByVal NavTo As String)
        Dim hBrowse As Integer
        hBrowse = ShellExecute(0, "open", NavTo, "", "", SW_SHOW)
    End Sub
End Module

