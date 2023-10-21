Imports System.Convert
Imports System.IO
Imports System.Windows.Forms

Namespace QueenLibInstall

    Public Class ClassInstall
        'WINDOWS.FORMS IS IMPORTED ONLY TO ACCESS THE APPLICATION CLASS
        'ANY EXISTING TESTS INSTALLED ALREADY
        Public Structure TestsStruct
            Public ExamNo As Integer
            Public ExamName As String
            Public ExamFile As String '.exe of nerdom
        End Structure

        'ANY NEW TESTS TO BE INSTALLED
        Public Structure NewTestsStruct
            Public ExamName As String
            Public ExamFile As String '.exe nerdom to install
        End Structure

        'Friend WithEvents sfdCommon As System.Windows.Forms.SaveFileDialog
        Public mTests() As TestsStruct 'EXISTING TESTS
        Public mNewTests() As NewTestsStruct 'NEW TESTS TO BE INSTALLED
        Public mDeletedTests() As NewTestsStruct
        Public mKeptExams() As TestsStruct

        Public mTestCount As Integer 'COUNT EXISTING TESTS
        Public mNewTestCount As Integer 'COUNT NEW TESTS
        Public mDeletedTestCount As Integer

        Private Const pCExamDir As String = "\" 'DIRECTORY FOR CONFIG FILES AND EXAMS
        Private Const pCInstallFile As String = "installit.dat"
        Private Const pCTestsFile As String = "icns.dat"

        Public Function DoAnyExistingTestsExist() As Boolean

            'CHECK ICNS.DAT TO SEE THE EXISTING TESTS INSTALLED
            Dim psrdCurrent As StreamReader
            Dim pstrInstallFile As String
            Dim pstrLine As String
            Dim pstrFields() As String
            Dim pchrDelimiter() As Char = {ToChar(",")}

            Try
                'CHECK ICNS.DAT
                pstrInstallFile = Application.StartupPath & pCExamDir & pCTestsFile 'icns.dat
                psrdCurrent = New StreamReader(pstrInstallFile)
                pstrLine = psrdCurrent.ReadLine() 'READ FIRST LINE

                'IF FIRST LINE OF FILE READS "INSTALLED TESTS:" 
                If pstrLine = "Installed Tests:" Then

                    'THEN READ THE NEXT LINE
                    pstrLine = psrdCurrent.ReadLine()
                    pstrFields = pstrLine.Split(pchrDelimiter)
                    psrdCurrent.Close()
                    'IF THERE ARE 3 FIELDS IN THE NEXT LINE
                    'EG.      CISCO CCNA 640-801,TQAPC\testq.exe
                    'THEN EXISTING TESTS DO EXIST - RETURN TRUE

                    If pstrFields.GetUpperBound(0) = 1 Then
                        Return True

                    Else 'If pstrFields.GetUpperbound(0) <> 1
                        Return False
                    End If
                Else 'If first line does not read "Installed Tests:"
                    psrdCurrent.Close()
                    Return False
                End If
            Catch 'if no file exists or file doesnt open
                Return False
            End Try
        End Function

        Public Function DoAnyNewTestsExist() As Boolean
            'CHECK INSTALLIT.DAT FILE
            '  IF FIRST LINE CHARACTER OF INSTALLIT.DAT STARTS WITH "N,"
            '  THIS INDICATES A NEW TEST SHOULD BE INSTALLED
            '   IF THE FIRST LINE READS "DONE,0,0,0" THEN NO NEW TESTS NEED BE INSTALLED
            '  THERE MUST BE 2 CSV FIELDS ON THE FIRST LINE OF INSTALLIT.DAT
            Dim psrdCurrent As StreamReader
            Dim pstrInstallFile As String
            Dim pstrLine As String
            Dim pstrFields() As String
            Dim pchrDelimiter() As Char = {ToChar(",")}

            Try
                'CHECK INSTALL FILE C:\PROGRAMFILES\TESTQEEN\INSTALLIT.DAT
                ' OPEN AND READ THIS FILE
                pstrInstallFile = Application.StartupPath & pCExamDir & pCInstallFile
                psrdCurrent = New StreamReader(pstrInstallFile)
                pstrLine = psrdCurrent.ReadLine()

                'UNTIL THE END OF THE FILE
                Do Until pstrLine = Nothing

                    'SPLIT EACH LINE UP INTO PSTRFIELDS() ARRAY
                    pstrFields = pstrLine.Split(pchrDelimiter)

                    'CHECK IF THERE 3 FIELDS IN A LINE OF INSTALLIT.DAT  'DONE,0,0
                    If pstrFields.GetUpperBound(0) = 2 Then

                        'DONE,0,0 IF NO NEW TESTS
                        If pstrFields(0) = "Done" Then
                            psrdCurrent.Close()
                            Return False
                        End If

                        'N,EXAMNAME,FILENAME  IF NEW TESTS TO INSTALL
                        If pstrFields(0) = "N" Then
                            psrdCurrent.Close()
                            Return True
                        End If

                        'READ THE NEXT LINE - LOOP CHECKS IF NOTHING
                        pstrLine = psrdCurrent.ReadLine()

                    Else 'If pstrFields.GetUpperbound(0) <> 3
                        psrdCurrent.Close()
                        Return False
                    End If
                Loop
                psrdCurrent.Close()
            Catch 'if no file exists or file doesnt open
                Return False
            End Try

        End Function

        Public Function DoAnyDeletedTestsExist() As Boolean
            'CHECK INSTALLIT.DAT FILE
            '  IF FIRST LINE CHARACTER OF INSTALLIT.DAT STARTS WITH "D,"
            '  THIS INDICATES AN Existing TEST SHOULD BE Deleted
            '   IF THE FIRST LINE READS "DONE,0,0,0" THEN NO NEW TESTS NEED BE INSTALLED
            '  THERE MUST BE 2 CSV FIELDS ON THE FIRST LINE OF INSTALLIT.DAT
            Dim psrdCurrent As StreamReader
            Dim pstrInstallFile As String
            Dim pstrLine As String
            Dim pstrFields() As String
            Dim pchrDelimiter() As Char = {ToChar(",")}

            Try
                'CHECK INSTALL FILE C:\PROGRAMFILES\TESTQEEN\INSTALLIT.DAT
                ' OPEN AND READ THIS FILE
                pstrInstallFile = Application.StartupPath & pCExamDir & pCInstallFile
                psrdCurrent = New StreamReader(pstrInstallFile)
                pstrLine = psrdCurrent.ReadLine()

                'UNTIL THE END OF THE FILE
                Do Until pstrLine = Nothing

                    'SPLIT EACH LINE UP INTO PSTRFIELDS() ARRAY
                    pstrFields = pstrLine.Split(pchrDelimiter)

                    'CHECK IF THERE 3 FIELDS IN A LINE OF INSTALLIT.DAT  'D,X,Y
                    If pstrFields.GetUpperBound(0) = 2 Then

                        '/****************** Code written by Tanveer *************************************/
                        'D,X,Y IF TESTS to delete
                        If pstrFields(0) = "D" Then
                            psrdCurrent.Close()
                            Return True
                        End If
                        '/*******************************************************/
                        'READ THE NEXT LINE - LOOP CHECKS IF NOTHING
                        pstrLine = psrdCurrent.ReadLine()

                    Else 'If pstrFields.GetUpperbound(0) <> 3
                        psrdCurrent.Close()
                        Return False
                    End If
                Loop
                psrdCurrent.Close()
            Catch 'if no file exists or file doesnt open
                Return False
            End Try

        End Function

        Public Function LoadExistingTest() As Integer
            'RETURNS NUMBER OF EXISTING TESTS
            'THIS WILL ALSO LOAD EXISTING TESTS INTO THE ARRAY
            Dim psrdCurrent As StreamReader
            Dim pstrInstallFile As String
            Dim pstrLine As String
            Dim pstrFields() As String
            Dim pchrDelimiter() As Char = {ToChar(",")}

            'Installed Tests:
            'CHECK ICNS.DAT
            Try
                pstrInstallFile = Application.StartupPath & pCExamDir & pCTestsFile 'icns.dat
                psrdCurrent = New StreamReader(pstrInstallFile)
                pstrLine = psrdCurrent.ReadLine() 'READ 1st LINE

                If pstrLine = "Installed Tests:" Then
                    pstrLine = psrdCurrent.ReadLine()  'read 2nd line

                    Do Until pstrLine = Nothing
                        pstrFields = pstrLine.Split(pchrDelimiter)

                        'Installed Tests:
                        'Cisco CCNA,   exe file name
                        'Cisco CCNP,   exe file name
                        If pstrFields.GetUpperBound(0) = 1 Then      'If there are 3 fields in second line
                            ReDim Preserve mTests(mTestCount)
                            'set name and file and test number (store for mTestCount)
                            mTests(mTestCount).ExamNo = mTestCount      '0
                            mTests(mTestCount).ExamName = pstrFields(0)
                            mTests(mTestCount).ExamFile = pstrFields(1) '***
                            mTestCount += 1
                            pstrLine = psrdCurrent.ReadLine()
                        End If
                    Loop
                End If
                psrdCurrent.Close()
            Catch 'IF no file exists or file doesnt open
                MsgBox("Error in LoadExistingTest")
            End Try

            psrdCurrent.Close()

            Return mTestCount

        End Function

        Public Sub LoadNewTests()
            '       YES - ADD TO STRUCT NEWTESTS        'add NEWTESTS TO MTESTS()
            '       WRITE DONE, 0, 0 IN INSTALLIT.DAT        'LOAD ALL OF THE NEW TEST
            '   CHECK INSTALLIT.DAT
            '       YES NEW TEST EXIST --"N" PSTRFIELDS(0) OR  NO NEW TEST EXIST "DONE,0,0"
            'CHECK NEW TESTS IN INSTALLIT.DAT
            Dim psrdCurrent As StreamReader
            Dim pstrInstallFile As String
            Dim pstrLine As String
            Dim pstrFields() As String
            Dim pchrDelimiter() As Char = {ToChar(",")}

            Try
                'check Installit.dat
                pstrInstallFile = Application.StartupPath & pCExamDir & pCInstallFile
                psrdCurrent = New StreamReader(pstrInstallFile)
                pstrLine = psrdCurrent.ReadLine()

                Do Until pstrLine = Nothing
                    pstrFields = pstrLine.Split(pchrDelimiter)
                    '0      1                                  2
                    'N,Cisco CCNA (640-801),filename
                    If pstrFields.GetUpperBound(0) = 2 Then
                        If pstrFields(0) = "N" Then
                            ReDim Preserve mNewTests(mNewTestCount)
                            mNewTests(mNewTestCount).ExamName = pstrFields(1)
                            mNewTests(mNewTestCount).ExamFile = pstrFields(2)
                            mNewTestCount += 1
                            pstrLine = psrdCurrent.ReadLine()
                        End If
                    End If
                Loop
                psrdCurrent.Close()
            Catch 'if no file exists or file doesnt open
                MsgBox("Error in LoadNewTest")
            End Try

            psrdCurrent.Close()

        End Sub

        Public Function SyncAllTests() As Integer
            'APPEND NEW TESTS [MNEWTESTS() ] 
            'TO EXISTING TESTS [MTESTS()] 
            'MTESTCOUNT STARTS IN LOADNEWTEST()
            'BY NOW MTESTCOUNT IS EQUAL TO THE NUMBER OF EXISTING TESTS INSTALLED
            Dim pintcount As Integer
            Dim pintCountDel As Integer
            Dim pintCountDelete As Integer

            For pintcount = 0 To mNewTestCount - 1
                ReDim Preserve mTests(mTestCount)
                mTests(mTestCount).ExamNo = mTestCount
                mTests(mTestCount).ExamName = mNewTests(pintcount).ExamName
                mTests(mTestCount).ExamFile = mNewTests(pintcount).ExamFile
                mTestCount += 1
            Next

            '/*****************************************************************/
            'WRITE DONE IN INSTALLIT.DAT 
            WriteNewTestsFile()

            'WRITE EVERY EXISTING TEST TO ICNS.DAT
            WriteExistingTestsFile()

            Return mTestCount
        End Function


        Public Function LoadDeletedTests() As Integer
            '       YES - ADD TO STRUCT NEWTESTS        'add NEWTESTS TO MTESTS()
            '       WRITE DONE, 0, 0 IN INSTALLIT.DAT        'LOAD ALL OF THE NEW TEST
            '   CHECK INSTALLIT.DAT
            '       YES NEW TEST EXIST --"N" PSTRFIELDS(0) OR  NO NEW TEST EXIST "DONE,0,0"
            'CHECK NEW TESTS IN INSTALLIT.DAT
            Dim psrdCurrent As StreamReader
            Dim pstrInstallFile As String
            Dim pstrLine As String
            Dim pstrFields() As String
            Dim pchrDelimiter() As Char = {ToChar(",")}

            Try
                'check Installit.dat
                pstrInstallFile = Application.StartupPath & pCExamDir & pCInstallFile
                psrdCurrent = New StreamReader(pstrInstallFile)
                pstrLine = psrdCurrent.ReadLine()

                Do Until pstrLine = Nothing
                    pstrFields = pstrLine.Split(pchrDelimiter)
                    '0      1                                  2
                    'N,Cisco CCNA (640-801),filename
                    If pstrFields.GetUpperBound(0) = 2 Then
                        If pstrFields(0) = "D" Then
                            ReDim Preserve mDeletedTests(mDeletedTestCount)
                            mDeletedTests(mDeletedTestCount).ExamName = pstrFields(1)
                            mDeletedTests(mDeletedTestCount).ExamFile = pstrFields(2)
                            mDeletedTestCount += 1
                            pstrLine = psrdCurrent.ReadLine()
                        End If
                    End If
                Loop
                psrdCurrent.Close()
            Catch 'if no file exists or file doesnt open
                MsgBox("Error in LoadDeletedTest")
            End Try

            psrdCurrent.Close()

            Return mDeletedTestCount
        End Function

        Public Property ExamName(ByVal ppintIndex As Integer) As String
            'THIS PROPERTY IS USED AFTER ARRAYS ARE FILLED
            'WILL SEARCH BY INDEX NUMBER OF THE ARRAY ELEMENT
            'GET CLASS.EXAMNAME(4) WILL RETURN THE 5TH EXAM'S EXAM NAME (STRING)
            Get
                Dim i As Integer
                For i = 0 To mTests.GetUpperBound(0)
                    If ppintIndex = mTests(i).ExamNo Then
                        Return mTests(i).ExamName
                    End If
                Next
            End Get
            Set(ByVal Value As String)
                Dim i As Integer
                For i = 0 To mTests.GetUpperBound(0)
                    If ppintIndex = mTests(i).ExamNo Then
                        mTests(i).ExamName = Value
                    End If
                Next
            End Set
        End Property
        Public ReadOnly Property ExamNo(ByVal ppstrExamName As String) As Integer
            'THIS PROPERTY IS USED AFTER ARRAYS ARE FILLED
            'WILL SEARCH BY EXAM NAME OF THE ARRAY ELEMENT
            'GET CLASS.EXAMNO("EXAM 1") WILL RETURN THE 5TH EXAM'S EXAM NAME (STRING)
            Get
                Dim i As Integer
                For i = 0 To mTests.GetUpperBound(0)
                    If ppstrExamName = mTests(i).ExamName Then
                        Return mTests(i).ExamNo
                    End If
                Next
            End Get

        End Property
        Public Property ExamFile(ByVal ppintIndex As Integer) As String
            'THIS PROPERTY IS USED AFTER ARRAYS ARE FILLED
            'WILL SEARCH BY INDEX NUMBER OF THE ARRAY ELEMENT
            'GET CLASS.EXAMFILE(4) WILL RETURN THE 5TH EXAM'S FILENAME (STRING)
            Get
                Dim i As Integer
                For i = 0 To mTests.GetUpperBound(0)
                    If ppintIndex = mTests(i).ExamNo Then
                        Return mTests(i).ExamFile
                    End If
                Next
            End Get
            Set(ByVal Value As String)
                Dim i As Integer
                For i = 0 To mTests.GetUpperBound(0)
                    If ppintIndex = mTests(i).ExamNo Then
                        mTests(i).ExamFile = Value
                    End If
                Next
            End Set
        End Property

        Public Sub WriteNewTestsFile()
            'WRITE THE FOLLOWING LINE in INSTALLIT.DAT
            'DONE,0,0
            'IF DONE,0,0 IS DETECTED IN THIS FILE ON THE FIRST LINE, 
            'THERE ARE NO NEW TESTS TO BE INSTALLED
            Dim pswriCurrent As StreamWriter
            Dim pfilename As String

            pfilename = Application.StartupPath & pCExamDir & pCInstallFile
            '\installit.dat

            Try
                pswriCurrent = New StreamWriter(pfilename)
                pswriCurrent.Write("DONE,0,0")
                pswriCurrent.WriteLine()
                pswriCurrent.Flush()
                pswriCurrent.Close()
            Catch
                MsgBox("Error Writing Newtestsfile")
            End Try

        End Sub

        Public Sub WriteExistingTestsFile()
            'WRITE EXISTING TESTS TESTNAME, FILENAME,TABLE NAME INTO ICNS.DAT 
            'THIS INCLUDES THE NEW TESTS APPENDED TO EXISTING TESTS IF ANY
            Dim pintCount As Integer
            Dim pWriter As StreamWriter
            Dim pfilename As String

            pfilename = Application.StartupPath & pCExamDir & pCTestsFile
            'exams\icns.dat

            'WRITE ICNS.DAT FILE
            'WRITE 1 LINE FOR EACH EXAM NAME
            '           FORMAT- COMMA SEPARATED VALUES
            '           Installed Tests:
            '           EXAMNAME, FILENAME
            Try
                pWriter = New StreamWriter(pfilename)
                '/****************** Code written by Tanveer *************************************/
                If mTestCount > 0 Then
                    '/********************************************************************************/
                    pWriter.WriteLine("Installed Tests:")

                    For pintCount = 0 To mTestCount - 1
                        pWriter.Write(mTests(pintCount).ExamName)
                        pWriter.Write(",")
                        pWriter.Write(mTests(pintCount).ExamFile)
                        pWriter.Write(vbCrLf)
                    Next
                End If
                pWriter.Flush()
                pWriter.Close()
            Catch
                MsgBox("Error Writing ExistingTestsFile")
            End Try

        End Sub

        '/*************************Added by tanveer *****************************/
        ' I have copied the code from syncAlltest to here so that it can detect deleted
        'exam in installit.dat file and update the icn.dat file
        Public Sub WriteDeletedTest()
            Dim pintcount As Integer
            Dim pintCountDel As Integer
            Dim pintCountDelete As Integer

            'WRITE Deleted TESTS TESTNAME, FILENAME,INTO ICNS.DAT 
            For pintcount = 0 To mTestCount - 1
                For pintCountDelete = 0 To mDeletedTestCount - 1
                    If mTests(pintcount).ExamName = mDeletedTests(pintCountDelete).ExamName Then
                        mTests(pintcount).ExamName = "deletedline"
                    End If
                Next
            Next

            pintCountDelete = 0

            For pintcount = 0 To mTestCount - 1
                If mTests(pintcount).ExamName <> "deletedline" Then
                    ReDim Preserve mKeptExams(pintCountDelete)
                    mKeptExams(pintCountDelete).ExamNo = pintCountDelete
                    mKeptExams(pintCountDelete).ExamName = mTests(pintcount).ExamName
                    mKeptExams(pintCountDelete).ExamFile = mTests(pintcount).ExamFile
                    pintCountDelete += 1
                End If
            Next

            ReDim mTests(pintCountDelete)

            For pintcount = 0 To pintCountDelete - 1
                ReDim Preserve mTests(pintcount)
                mTests(pintcount).ExamNo = pintcount 'mKeptExams(pintcount).ExamNo
                mTests(pintcount).ExamName = mKeptExams(pintcount).ExamName
                mTests(pintcount).ExamFile = mKeptExams(pintcount).ExamFile
            Next

            mTestCount = pintCountDelete 'pintCountDelete - 1
            '**** commented by Tanveer
            'previously it was mTestCount = pintCountDelete 'pintCountDelete - 1

            'WRITE DONE IN INSTALLIT.DAT 
            WriteNewTestsFile()

            'WRITE EVERY EXISTING TEST TO ICNS.DAT
            WriteExistingTestsFile()

        End Sub
        '/******************************************************/


    End Class
End Namespace


