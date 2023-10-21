Public Sub PostEbayRecordCSV()

    Dim COMMANDTEXT2 As String = ""

    Dim outFile As IO.StreamWriter

    COMMANDTEXT2 = c_SKU & vbTab &
            c_Title & vbTab &
            c_Price & vbTab &
            c_Quantity & vbTab &
            c_Description & vbTab &
            c_UPC & vbTab &
            c_Brand & vbTab &
            c_ImageLink & vbTab &
            c_zCondition & vbTab &
            c_ConditionNote & vbTab &
            c_EbayCondition & vbTab &
            c_ebayCategory & vbTab &
            c_neweggCategory & vbTab &
            c_PartNumber & vbTab &
            c_Bullet1 & vbTab &
            c_Bullet2 & vbTab &
            c_Bullet3 & vbTab &
            c_Bullet4 & vbTab &
            c_Bullet5 & vbTab &
            c_zItemType & vbTab &
            c_zFeedProductType

    COMMANDTEXT2 = COMMANDTEXT2.Replace(vbCr, "").Replace(vbLf, "")

    Try
      outFile = My.Computer.FileSystem.OpenTextFileWriter(QUICKEBAYFILENAME, True)
      outFile.WriteLine(COMMANDTEXT2)
      outFile.Close()
    Catch
      Debug.WriteLine("Please close the quick ebay file")
    End Try
  End Sub


End Module