Attribute VB_Name = "Module1"
Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" _
              (ByVal hwnd As Long, ByVal lpOperation As String, _
               ByVal lpFile As String, ByVal lpParameters As String, _
               ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
Private Const SW_SHOW = 1
 

Public Sub Navigate(ByVal NavTo As String)
      Dim hBrowse As Long
      hBrowse = ShellExecute(0&, "open", NavTo, "", "", SW_SHOW)
End Sub
Sub Main()
Navigate "http://www.nerdomsoftware.com"
End Sub
