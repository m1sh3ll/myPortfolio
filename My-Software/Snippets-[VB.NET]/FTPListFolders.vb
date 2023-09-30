 'This sub lists all the available folders in the default ftp directory
 'It will add the folder names into a listbox
 
 Private Sub FTPFolders(ByVal ftpPort As String)

    Dim requestUriString As String = ("ftp://" & Me.FTPSITE)

    If ((ftpPort <> "21") And (ftpPort <> "")) Then
      requestUriString = ("ftp://" & Me.FTPSITE & ":" & ftpPort)
    End If

    Dim request As FtpWebRequest = DirectCast(WebRequest.Create(requestUriString), 
                                              FtpWebRequest)
    request.Timeout = 20000
    request.Credentials = New NetworkCredential(txtFtpUser.Text, txtFtpPassword.Text)
    request.Method = "NLST"

    Dim response As FtpWebResponse = DirectCast(request.GetResponse, FtpWebResponse)
    Dim reader As New StreamReader(response.GetResponseStream)

    Do While (reader.Peek >= 0)
      Dim str2 As String = reader.ReadLine
      If ((((Strings.InStr(str2, ".", CompareMethod.Binary) = 0) And (str2 <> "")) And (str2 <> ".")) And (str2 <> "..")) Then
        Me.lstFolders.Items.Add(str2)
      End If
    Loop
  End Sub