Imports System.Net
Imports System.Text

Public Class FTP
  Public Shared IMAGEURL As String

  Public Shared Function GetFTPFolders(ByVal port As UShort, user As String, pass As String, sitedomain As String) As List(Of String)
    Dim uri As String = $"ftp://ftp.{sitedomain}"
    Dim lst As List(Of String) = New List(Of String)
    If (port <> 21) Then uri = $"{uri}:{port}"
    Dim request As FtpWebRequest = DirectCast(WebRequest.Create(uri), FtpWebRequest)
    request.Timeout = 20000
    request.Credentials = New NetworkCredential(user, pass)
    request.Method = "NLST"
    Dim response As FtpWebResponse = DirectCast(request.GetResponse, FtpWebResponse)
    Dim reader As New IO.StreamReader(response.GetResponseStream)
    Do While (reader.Peek >= 0)
      Dim str As String = reader.ReadLine
      If ((((Strings.InStr(str, ".", CompareMethod.Binary) = 0) And (str <> "")) And (str <> ".")) And (str <> "..")) Then
        lst.Add(str)
      End If
    Loop

    Return lst

  End Function


  Public Shared Sub StartFTP(ByVal sitedomain As String,
                           ByVal user As String,
                           ByVal pass As String,
                           ByVal foldername As String,
                           ByVal fileandpath As String,
                           ByVal safename As String, ByVal subfolder As String)
    IMAGEURL = ""
    Try
      If safename <> "" Then

        Dim fullpath As String = $"{sitedomain}/{foldername}/{safename}"
        Dim request As FtpWebRequest = DirectCast(WebRequest.Create($"ftp://ftp.{fullpath}"), FtpWebRequest)
        request.Timeout = 10000
        request.Credentials = New NetworkCredential(user, pass)
        request.Method = WebRequestMethods.Ftp.UploadFile
        Dim file() As Byte = IO.File.ReadAllBytes(fileandpath)
        Dim s As IO.Stream = request.GetRequestStream()
        s.Write(file, 0, file.Length)
        s.Close()

        IMAGEURL = "https://www." + fullpath
        Debug.WriteLine($"------------ URL:{IMAGEURL}---")
      End If
    Catch
      IMAGEURL = "Not uploaded"
      Debug.WriteLine("File NOT uploaded...")
    End Try
  End Sub

  Public Shared Function base64d_nerdom(s As String) As String
    Dim base64EncodedString As String = s ' example Base64 encoded string
    Dim data As Byte() = Convert.FromBase64String(base64EncodedString)
    Dim decodedString As String = Encoding.UTF8.GetString(data)
    Return decodedString
  End Function
End Class
