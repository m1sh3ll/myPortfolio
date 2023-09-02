'User chooses an image for their product
'The Webbrowser control displays the image
'The label displays the image's dimensions
'This is good if you are uploading an ebay image and it needs a minimum height
'You can then fix the image first and it will show the dimensions
Private Sub ButtonChooseImage2_Click()
    OpenFileDialog2_Image.ShowDialog()
    If (OpenFileDialog2_Image.FileName <> "") Then
      WebBrowser2_Image.Navigate(("file:///" & OpenFileDialog2_Image.FileName))
      Try
        Dim fName As String = Me.OpenFileDialog2_Image.FileName
        Dim img As Image = Image.FromFile(fName)
        Dim pixelHeight As Integer = img.Size.Height
        Dim pixelWidth As Integer = img.Size.Width
        'System.Diagnostics.Debugger.Break()
        img.Dispose()
        lblDimensionsImage2.Text = "W: " & pixelWidth & " x H: " & pixelHeight
        If pixelHeight < 500 And pixelWidth < 500 Then
          lblDimensionsImage2.ForeColor = Color.Red
        Else
          lblDimensionsImage2.ForeColor = Color.Black
        End If
      Catch
      End Try
    End If
  End Sub