Imports System.IO
Public Module modCSV

  Public c_SKU As String
  Public c_Title As String
  Public c_Price As String
  Public c_Quantity As String
  Public c_Description As String
  Public c_UPC As String
  Public c_Brand As String
  Public c_ImageLink As String
  Public c_zCondition As String
  Public c_ConditionNote As String
  Public c_EbayCondition As String
  Public c_ebayCategory As String
  Public c_neweggCategory As String
  Public c_PartNumber As String
  Public c_Bullet1 As String
  Public c_Bullet2 As String
  Public c_Bullet3 As String
  Public c_Bullet4 As String
  Public c_Bullet5 As String
  Public c_zItemType As String
  Public c_zFeedProductType As String


  Public Sub CreateBlankEbayFile(ByVal QuickEbayFilename As String)

    Dim fieldsCSV() As String = New String() {
                        "SKU",
                        "Title",
                        "Price",
                        "Quantity",
                        "Description",
                        "UPC",
                        "Brand",
                        "ImageLink",
                        "zCondition",
                        "ConditionNote",
                        "EbayCondition",
                        "ebayCategory",
                        "neweggCategory",
                        "PartNumber",
                        "Bullet1",
                        "Bullet2",
                        "Bullet3",
                        "Bullet4",
                        "Bullet5",
                        "zItemType",
                        "zFeedProductType"}

    Dim outfileLine As String = String.Join(vbTab, fieldsCSV)

    Try
      Dim writer As New StreamWriter(QuickEbayFilename, False)
      writer.WriteLine(outfileLine)
      writer.Close()
    Catch
      Debug.WriteLine("Ebay file is open")

    End Try
  End Sub

  Public Sub PostEbayRecordCSV(ByVal QuickEbayFilename As String)

    If c_Title = "" Then Return

    Dim COMMANDTEXT2 As String = ""

    Dim outFile As StreamWriter

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
      outFile = New StreamWriter(QuickEbayFilename, True)
      outFile.WriteLine(COMMANDTEXT2)
      outFile.Close()
    Catch
      Debug.WriteLine("Please close the quick ebay file")
    End Try
  End Sub


End Module

