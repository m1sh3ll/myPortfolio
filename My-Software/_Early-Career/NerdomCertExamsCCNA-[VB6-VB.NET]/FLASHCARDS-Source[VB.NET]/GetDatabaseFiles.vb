Imports System.IO

Module GetDatabaseFiles
    Public Function GETDATABASE1() As String
        Dim pstrDB As String
        Dim SP As String
        SP = Application.StartupPath
        '\db001.mdb;  'flash.exe
        If File.Exists(SP & "\db001.mdb") Then pstrDB = "\db001.mdb;"
        If File.Exists(SP & "\db002.mdb") Then pstrDB = "\db002.mdb;"
        If File.Exists(SP & "\db003.mdb") Then pstrDB = "\db003.mdb;"
        If File.Exists(SP & "\db004.mdb") Then pstrDB = "\db004.mdb;"
        If File.Exists(SP & "\db005.mdb") Then pstrDB = "\db005.mdb;"
        If File.Exists(SP & "\db006.mdb") Then pstrDB = "\db006.mdb;"
        If File.Exists(SP & "\db007.mdb") Then pstrDB = "\db007.mdb;"
        If File.Exists(SP & "\db008.mdb") Then pstrDB = "\db008.mdb;"
        If File.Exists(SP & "\db009.mdb") Then pstrDB = "\db009.mdb;"
        If File.Exists(SP & "\db010.mdb") Then pstrDB = "\db010.mdb;"
        If File.Exists(SP & "\db011.mdb") Then pstrDB = "\db011.mdb;"
        If File.Exists(SP & "\db012.mdb") Then pstrDB = "\db012.mdb;"
        Return pstrDB
    End Function

    Public Function GETDATABASE2() As String
        Dim pstrDB As String
        Dim SP As String
        SP = Application.StartupPath
        '\db002.mdb;
        If File.Exists(SP & "\db0012.mdb") Then pstrDB = "\db0012.mdb;"
        If File.Exists(SP & "\db0022.mdb") Then pstrDB = "\db0022.mdb;"
        If File.Exists(SP & "\db0032.mdb") Then pstrDB = "\db0032.mdb;"
        If File.Exists(SP & "\db0042.mdb") Then pstrDB = "\db0042.mdb;"
        If File.Exists(SP & "\db0052.mdb") Then pstrDB = "\db0052.mdb;"
        If File.Exists(SP & "\db0062.mdb") Then pstrDB = "\db0062.mdb;"
        If File.Exists(SP & "\db0072.mdb") Then pstrDB = "\db0072.mdb;"
        If File.Exists(SP & "\db0082.mdb") Then pstrDB = "\db0082.mdb;"
        If File.Exists(SP & "\db0092.mdb") Then pstrDB = "\db0092.mdb;"
        If File.Exists(SP & "\db0102.mdb") Then pstrDB = "\db0102.mdb;"
        If File.Exists(SP & "\db0112.mdb") Then pstrDB = "\db0112.mdb;"
        If File.Exists(SP & "\db0122.mdb") Then pstrDB = "\db0122.mdb;"
        Return pstrDB
    End Function
    Public Function GETDATABASE3() As String
        Dim pstrDB As String
        Dim SP As String
        SP = Application.StartupPath
        '\db003.mdb;
        If File.Exists(SP & "\db0013.mdb") Then pstrDB = "\db0013.mdb;"
        If File.Exists(SP & "\db0023.mdb") Then pstrDB = "\db0023.mdb;"
        If File.Exists(SP & "\db0033.mdb") Then pstrDB = "\db0033.mdb;"
        If File.Exists(SP & "\db0043.mdb") Then pstrDB = "\db0043.mdb;"
        If File.Exists(SP & "\db0053.mdb") Then pstrDB = "\db0053.mdb;"
        If File.Exists(SP & "\db0063.mdb") Then pstrDB = "\db0063.mdb;"
        If File.Exists(SP & "\db0073.mdb") Then pstrDB = "\db0073.mdb;"
        If File.Exists(SP & "\db0083.mdb") Then pstrDB = "\db0083.mdb;"
        If File.Exists(SP & "\db0093.mdb") Then pstrDB = "\db0093.mdb;"
        If File.Exists(SP & "\db0103.mdb") Then pstrDB = "\db0103.mdb;"
        If File.Exists(SP & "\db0113.mdb") Then pstrDB = "\db0113.mdb;"
        If File.Exists(SP & "\db0123.mdb") Then pstrDB = "\db0123.mdb;"
        Return pstrDB
    End Function

    Public Function GETDATABASE4() As String
        Dim pstrDB As String
        Dim SP As String
        SP = Application.StartupPath
        '\db004.mdb;
        If File.Exists(SP & "\db0014.mdb") Then pstrDB = "\db0014.mdb;"
        If File.Exists(SP & "\db0024.mdb") Then pstrDB = "\db0024.mdb;"
        If File.Exists(SP & "\db0034.mdb") Then pstrDB = "\db0034.mdb;"
        If File.Exists(SP & "\db0044.mdb") Then pstrDB = "\db0044.mdb;"
        If File.Exists(SP & "\db0054.mdb") Then pstrDB = "\db0054.mdb;"
        If File.Exists(SP & "\db0064.mdb") Then pstrDB = "\db0064.mdb;"
        If File.Exists(SP & "\db0074.mdb") Then pstrDB = "\db0074.mdb;"
        If File.Exists(SP & "\db0084.mdb") Then pstrDB = "\db0084.mdb;"
        If File.Exists(SP & "\db0094.mdb") Then pstrDB = "\db0094.mdb;"
        If File.Exists(SP & "\db0104.mdb") Then pstrDB = "\db0104.mdb;"
        If File.Exists(SP & "\db0114.mdb") Then pstrDB = "\db0114.mdb;"
        If File.Exists(SP & "\db0124.mdb") Then pstrDB = "\db0124.mdb;"
        Return pstrDB
    End Function
    Public Function GETDATABASE5() As String
        Dim pstrDB As String
        Dim SP As String
        SP = Application.StartupPath
        '\db005.mdb;
        If File.Exists(SP & "\db0015.mdb") Then pstrDB = "\db0015.mdb;"
        If File.Exists(SP & "\db0025.mdb") Then pstrDB = "\db0025.mdb;"
        If File.Exists(SP & "\db0035.mdb") Then pstrDB = "\db0035.mdb;"
        If File.Exists(SP & "\db0045.mdb") Then pstrDB = "\db0045.mdb;"
        If File.Exists(SP & "\db0055.mdb") Then pstrDB = "\db0055.mdb;"
        If File.Exists(SP & "\db0065.mdb") Then pstrDB = "\db0065.mdb;"
        If File.Exists(SP & "\db0075.mdb") Then pstrDB = "\db0075.mdb;"
        If File.Exists(SP & "\db0085.mdb") Then pstrDB = "\db0085.mdb;"
        If File.Exists(SP & "\db0095.mdb") Then pstrDB = "\db0095.mdb;"
        If File.Exists(SP & "\db0105.mdb") Then pstrDB = "\db0105.mdb;"
        If File.Exists(SP & "\db0115.mdb") Then pstrDB = "\db0115.mdb;"
        If File.Exists(SP & "\db0125.mdb") Then pstrDB = "\db0125.mdb;"
        Return pstrDB
    End Function

    Public Function GETDATABASE6() As String
        Dim pstrDB As String
        Dim SP As String
        SP = Application.StartupPath
        '\db006.mdb;
        If File.Exists(SP & "\db0016.mdb") Then pstrDB = "\db0016.mdb;"
        If File.Exists(SP & "\db0026.mdb") Then pstrDB = "\db0026.mdb;"
        If File.Exists(SP & "\db0036.mdb") Then pstrDB = "\db0036.mdb;"
        If File.Exists(SP & "\db0046.mdb") Then pstrDB = "\db0046.mdb;"
        If File.Exists(SP & "\db0056.mdb") Then pstrDB = "\db0056.mdb;"
        If File.Exists(SP & "\db0066.mdb") Then pstrDB = "\db0066.mdb;"
        If File.Exists(SP & "\db0076.mdb") Then pstrDB = "\db0076.mdb;"
        If File.Exists(SP & "\db0086.mdb") Then pstrDB = "\db0086.mdb;"
        If File.Exists(SP & "\db0096.mdb") Then pstrDB = "\db0096.mdb;"
        If File.Exists(SP & "\db0106.mdb") Then pstrDB = "\db0106.mdb;"
        If File.Exists(SP & "\db0116.mdb") Then pstrDB = "\db0116.mdb;"
        If File.Exists(SP & "\db0126.mdb") Then pstrDB = "\db0126.mdb;"
        Return pstrDB
    End Function


End Module
