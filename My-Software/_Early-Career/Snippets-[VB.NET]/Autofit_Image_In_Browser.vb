'This code displays an image autofit into a small web browser control.



Public Function VerifyPageIsAnImage(eEvent As WebBrowserNavigatingEventArgs) As String
    Dim str As String = eEvent.Url.ToString
    If ((str.ToLower.EndsWith(".jpg") OrElse str.ToLower.EndsWith(".png")) OrElse (str.ToLower.EndsWith(".bmp") OrElse str.ToLower.EndsWith(".gif"))) Then
      Return "IMAGE"
    End If
    Return "PAGE"
  End Function

  Public Function CalculateDisplaySize(ByVal browserWidth As Integer,
       ByVal browserHeight As Integer,
       ByVal w As Integer,
       ByVal h As Integer) As Integer()
    'Default our return parameters to the image size.
    Dim ImageSize() As Integer = {w, h}
    Dim nh As Integer = h
    Dim nw As Integer = w
    Dim r As Double = 0

    Try
      If w >= h Then
        'Width >= height so first re-size image based on image wdith...
        nw = browserWidth
        r = CDbl(h / w)
        nh = CInt(Math.Floor(CDbl(browserWidth * r)))

        'If the height of the image is still larger than the browser height
        'then re-calculate image size based on the browser height.
        If nh > browserHeight Then
          nh = browserHeight
          nw = CInt(Math.Floor(CDbl(browserHeight / r)))
        End If
      Else
        'Height > width so first re-size image based on image width...
        nh = browserHeight
        r = CDbl(w / h)
        nw = CInt(Math.Floor(CDbl(browserHeight * r)))

        'If the width of the image is still larger than the browser width
        'then re-calculate image size based on the browser width.
        If nw > browserWidth Then
          nw = browserWidth
          nh = CInt(Math.Floor(CDbl(browserWidth / r)))
        End If
      End If

      'Save the new height & width as the resized dimensions.
      ImageSize(0) = nw
      ImageSize(1) = nh

    Catch ex As Exception
      MsgBox("Error in CalculateDisplaySize: " & ex.ToString)
    End Try

    Return ImageSize

  End Function

  Public Sub AutoFitImageInBrowser(ByVal Browser As WebBrowser, meheight As Integer)
    Try
      Dim browserWidth As Integer = (Browser.Width - 10)
      Dim browserHeight As Integer = (Browser.Height - 10)
      Dim element As HtmlElement = Browser.Document.Images.Item(0)
      Dim w As Integer = CInt(element.GetAttribute("WIDTH"))
      Dim h As Integer = CInt(element.GetAttribute("HEIGHT"))
      If ((meheight > browserHeight) OrElse (w > browserWidth)) Then
        Dim numArray As Integer() = CalculateDisplaySize(browserWidth, browserHeight, w, h)
        Dim num6 As Integer = numArray(0)
        Dim num5 As Integer = numArray(1)
        Browser.Document.Body.SetAttribute("SCROLL", "NO")
        Browser.Document.Body.SetAttribute("LEFTMARGIN", "5")
        Browser.Document.Body.SetAttribute("RIGHTMARGIN", "5")
        Browser.Document.Body.SetAttribute("TOPMARGIN", "5")
        Browser.Document.Body.SetAttribute("BOTTOMMARGIN", "5")
        element.SetAttribute("WIDTH", CStr(num6))
        element.SetAttribute("HEIGHT", CStr(num5))
      End If
    Catch exception1 As Exception

    End Try

  End Sub



  Private Sub WebBrowser1i_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1_Image.DocumentCompleted
    If strURLtype = "IMAGE" Then AutoFitImageInBrowser(WebBrowser1_Image, Me.Height)
  End Sub

  Private Sub WebBrowser1i_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1_Image.Navigating
    Me.strURLtype = VerifyPageIsAnImage(e)
  End Sub



