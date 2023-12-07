Attribute VB_Name = "modFileExists"

Public Const OF_EXIST = &H4000

Type OFSTRUCT
  cBytes As Byte
  fFixedDisk As Byte
  nErrCode As Integer
  Reserved1 As Integer
  Reserved2 As Integer
  szPathName As String * 128
End Type

Declare Function OpenFile Lib "Kernel32" (ByVal lpFileName As String, _
                              lpReOpenBuff As OFSTRUCT, _
                              ByVal wStyle As Long) As Long

Function FileExistsAPI(strPath As String) As Boolean
  Dim structFileInfo As OFSTRUCT

  On Error Resume Next

  If OpenFile(strPath, structFileInfo, OF_EXIST) <> -1 Then
    FileExistsAPI = True
  ElseIf structFileInfo.nErrCode = 32 Then
    ' File Lock Violation
    FileExistsAPI = True
  Else
    FileExistsAPI = False
  End If

  If Err.Number <> 0 Then FileExistsAPI = False

End Function

