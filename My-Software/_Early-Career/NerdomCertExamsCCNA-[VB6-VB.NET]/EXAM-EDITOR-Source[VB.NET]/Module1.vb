Module Module1
    Friend fParent As frmParent
    Friend fintCURRENTFORM As Integer 'Declares the Active Child Form in each form Enter Event.
    Friend fPARENTPATH As String, fPARENTFOLDER As String
    Friend fCollectionName As String, fIconName As String, fTopicName As String
    Friend fSubFolders As String

    Friend fISNEWTEST As Boolean, fblnDirty As Boolean
    Friend fFULLMODULEPATH As String, fCurrentModuleDB As String

    Friend fintEXAMSELECTED As Integer, fintMaxQuestions As Integer
    Friend fButtonClicked As String
    Friend fSelectedFolder As String, fSelectedPrevName As String 'Add Previous Exam
    Friend fintModule As Integer

    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
    Private Const SW_SHOW As Short = 1
    Public Sub Navigate(ByVal NavTo As String)
        Dim hBrowse As Integer
        hBrowse = ShellExecute(0, "open", NavTo, "", "", SW_SHOW)
    End Sub
    'frmEditExam 1      'Edits Exams
    'frmEditRouterLabs 4 'Edits Router Labs
    'frmEditor 3        'Edits flashcards
    'frmEditIcons 5     'Edits the Icons
    Sub MsgBox1()
        MsgBox("Data Updated")
    End Sub

    Friend Sub SetPanelBarText(ByVal stra As String, ByVal strb As String)
        fParent.pnlRecordCount.Text = "Count = " & stra
        fParent.pnlCurrentRecord.Text = "Current = " & strb
    End Sub

    Friend Sub NavigateFirst()

        Select Case fintCURRENTFORM
            Case 1 'frmEditExam
                Dim fEditExam As frmEditExam = CType(fParent.ActiveMdiChild, frmEditExam)
                With fEditExam
                    .BindingContext(.DsExam1, "Q1").Position = 0
                    .CheckExhibitType()
                    .BeginSetChecked()
                End With

            Case 3 'frmEditor Flashcards
                Dim fEditFlash As frmEditor = CType(fParent.ActiveMdiChild, frmEditor)
                With fEditFlash
                    .BindingContext(.DsFlash1, "Q1").Position = 0
                    .CheckType()
                End With

            Case 4 'frmEditRouterLabs
                Dim fEditRouterLabs As frmEditRouterLabs = CType(fParent.ActiveMdiChild, frmEditRouterLabs)
                With fEditRouterLabs
                    .BindingContext(.DsLabs1, "Q1").Position = 0
                    .CheckType2()
                End With

            Case 5 'frmEditIconsE
                Dim fEditIconsE As frmEditIconsE = CType(fParent.ActiveMdiChild, frmEditIconsE)
                With fEditIconsE
                    .BindingContext(.DsIconsE1, "t1").Position = 0
                End With
        End Select

        UpdateStatusBar()
    End Sub
    Friend Sub NavigateLast()

        Select Case fintCURRENTFORM
            Case 1 'frmEditExam
                Dim fEditExam As frmEditExam = CType(fParent.ActiveMdiChild, frmEditExam)
                With fEditExam
                    .BindingContext(.DsExam1, "Q1").Position = .DsExam1.Q1.Rows.Count - 1
                    .CheckExhibitType()
                    .BeginSetChecked()
                End With

            Case 3
                Dim fEditFlash As frmEditor = CType(fParent.ActiveMdiChild, frmEditor)
                With fEditFlash
                    .BindingContext(.DsFlash1, "Q1").Position = .DsFlash1.Q1.Rows.Count - 1
                    .CheckType()
                End With

            Case 4 'frmEditRouterLabs
                Dim fEditRouterLabs As frmEditRouterLabs = CType(fParent.ActiveMdiChild, frmEditRouterLabs)
                With fEditRouterLabs
                    .BindingContext(.DsLabs1, "Q1").Position = .DsLabs1.Q1.Rows.Count - 1
                    .CheckType2()
                End With

            Case 5 'frmEditIconsE
                Dim fEditIconsE As frmEditIconsE = CType(fParent.ActiveMdiChild, frmEditIconsE)
                With fEditIconsE
                    .BindingContext(.DsIconsE1, "t1").Position = .DsIconsE1.t1.Rows.Count - 1
                End With


        End Select

        UpdateStatusBar()
    End Sub
    Friend Sub NavigateNext()
        Select Case fintCURRENTFORM

            Case 1 'frmEditExam
                Dim fEditExam As frmEditExam = CType(fParent.ActiveMdiChild, frmEditExam)
                With fEditExam
                    .BindingContext(.DsExam1, "Q1").Position += 1
                    .CheckExhibitType()
                    .BeginSetChecked()
                End With
            Case 3
                Dim fEditFlash As frmEditor = CType(fParent.ActiveMdiChild, frmEditor)
                With fEditFlash
                    .BindingContext(.DsFlash1, "Q1").Position += 1
                    .CheckType()
                End With

            Case 4 'frmEditRouterLabs
                Dim fEditRouterLabs As frmEditRouterLabs = CType(fParent.ActiveMdiChild, frmEditRouterLabs)
                With fEditRouterLabs
                    .BindingContext(.DsLabs1, "Q1").Position += 1
                    .CheckType2()
                End With

            Case 5 'frmEditIconsE
                Dim fEditIconsE As frmEditIconsE = CType(fParent.ActiveMdiChild, frmEditIconsE)
                With fEditIconsE
                    .BindingContext(.DsIconsE1, "t1").Position += 1
                End With
        End Select
        UpdateStatusBar()
    End Sub
    Friend Sub NavigatePrevious()
        Select Case fintCURRENTFORM
            Case 1 'frmEditExam
                Dim fEditExam As frmEditExam = CType(fParent.ActiveMdiChild, frmEditExam)
                With fEditExam
                    .BindingContext(.DsExam1, "Q1").Position -= 1
                    .CheckExhibitType()
                    .BeginSetChecked()
                End With

            Case 3
                Dim fEditFlash As frmEditor = CType(fParent.ActiveMdiChild, frmEditor)
                With fEditFlash
                    .BindingContext(.DsFlash1, "Q1").Position -= 1
                    .CheckType()
                End With

            Case 4 'frmEditRouterLabs
                Dim fEditRouterLabs As frmEditRouterLabs = CType(fParent.ActiveMdiChild, frmEditRouterLabs)
                With fEditRouterLabs
                    .BindingContext(.DsLabs1, "Q1").Position -= 1
                    .CheckType2()
                End With

            Case 5 'frmEditIconsE
                Dim fEditIconsE As frmEditIconsE = CType(fParent.ActiveMdiChild, frmEditIconsE)
                With fEditIconsE
                    .BindingContext(.DsIconsE1, "t1").Position -= 1
                End With
        End Select

        UpdateStatusBar()
    End Sub
    Friend Sub EditAdd()

        Select Case fintCURRENTFORM
            Case 1 'frmEditExam
                Dim fEditExam As frmEditExam = CType(fParent.ActiveMdiChild, frmEditExam)
                With fEditExam

                    .BindingContext(.DsExam1, "Q1").AddNew()
                    .AddNewQID()
                    .UncheckAllRadios()
                End With

            Case 3
                Dim fEditFlash As frmEditor = CType(fParent.ActiveMdiChild, frmEditor)
                With fEditFlash

                    .BindingContext(.DsFlash1, "Q1").AddNew()
                    .GenerateNewQID()
                End With

            Case 4 'frmEditRouterLabs
                Dim fEditRouterLabs As frmEditRouterLabs = CType(fParent.ActiveMdiChild, frmEditRouterLabs)
                With fEditRouterLabs

                    .BindingContext(.DsLabs1, "Q1").AddNew()
                    .AddNewQuesID()
                End With

            Case 5 'frmEditIconsE
                Dim fEditIconsE As frmEditIconsE = CType(fParent.ActiveMdiChild, frmEditIconsE)
                With fEditIconsE
                    .BindingContext(.DsIconsE1, "t1").AddNew()
                End With
        End Select
    End Sub
    Friend Sub EditCancel()
        Select Case fintCURRENTFORM
            Case 1 'frmEditExam
                Dim fEditExam As frmEditExam = CType(fParent.ActiveMdiChild, frmEditExam)
                With fEditExam
                    .BindingContext(.DsExam1, "Q1").CancelCurrentEdit()
                End With

            Case 3
                Dim fEditFlash As frmEditor = CType(fParent.ActiveMdiChild, frmEditor)
                With fEditFlash
                    .BindingContext(.DsFlash1, "Q1").CancelCurrentEdit()
                End With

            Case 4 'frmEditRouterLabs
                Dim fEditRouterLabs As frmEditRouterLabs = CType(fParent.ActiveMdiChild, frmEditRouterLabs)
                With fEditRouterLabs
                    .BindingContext(.DsLabs1, "Q1").CancelCurrentEdit()
                End With

            Case 5 'frmEditIconsE
                Dim fEditIconsE As frmEditIconsE = CType(fParent.ActiveMdiChild, frmEditIconsE)
                With fEditIconsE
                    .BindingContext(.DsIconsE1, "t1").CancelCurrentEdit()
                End With
        End Select


    End Sub
    Friend Sub EditDelete()
        Dim pdsDeleted As DataSet
        Dim pmsgResult As MsgBoxResult
        Dim pDS As DataSet
        Dim pTBL As String
        Dim intNumRecords As Integer

        pmsgResult = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo, "Confirm Record Deletion")
        If pmsgResult = MsgBoxResult.Yes Then

            Select Case fintCURRENTFORM
                Case 1 'frmEditExam
                    Dim fEditExam As frmEditExam = CType(fParent.ActiveMdiChild, frmEditExam)
                    With fEditExam
                        intNumRecords = .DsExam1.Q1.Rows.Count
                        If intNumRecords <= 1 Then
                            MsgBox("You cannot delete the first question, only edit it")
                            Exit Sub
                        End If
                        pDS = .DsExam1
                        pTBL = "Q1"
                        .BindingContext(pDS, pTBL).RemoveAt(.BindingContext(pDS, pTBL).Position)
                        pdsDeleted = pDS.GetChanges(DataRowState.Deleted)
                        .odbDaExam.Update(pdsDeleted) 'Data Adapter - Diff. For each case
                        pDS.AcceptChanges()

                        .RefreshCombos()
                    End With

                Case 3
                    Dim fEditFlash As frmEditor = CType(fParent.ActiveMdiChild, frmEditor)
                    With fEditFlash
                        intNumRecords = .DsFlash1.Q1.Rows.Count
                        If intNumRecords <= 1 Then
                            MsgBox("There is only 1 flashcard in this set. You can only edit this flashcard, or add a new flashcard")
                            Exit Sub
                        End If
                        pDS = .DsFlash1
                        pTBL = "Q1"
                        .BindingContext(pDS, pTBL).RemoveAt(.BindingContext(pDS, pTBL).Position)
                        pdsDeleted = pDS.GetChanges(DataRowState.Deleted)
                        .odbDaFlash.Update(pdsDeleted) 'Data Adapter - Diff. For each case
                        pDS.AcceptChanges()

                        .RefreshCombo()
                    End With

                Case 4 'frmEditRouterLabs
                    Dim fEditRouterLabs As frmEditRouterLabs = CType(fParent.ActiveMdiChild, frmEditRouterLabs)
                    With fEditRouterLabs
                        intNumRecords = .DsLabs1.Q1.Rows.Count
                        If intNumRecords <= 1 Then
                            MsgBox("You cannot delete the first question. Click change to change the fields.")
                            Exit Sub
                        End If
                        pDS = .DsLabs1
                        pTBL = "Q1"
                        .BindingContext(pDS, pTBL).RemoveAt(.BindingContext(pDS, pTBL).Position)
                        pdsDeleted = pDS.GetChanges(DataRowState.Deleted)
                        .odbDaLabs.Update(pdsDeleted) 'Data Adapter - Diff. For each case
                        pDS.AcceptChanges()

                        .RefreshCombos2()
                    End With
            End Select
            UpdateStatusBar()
        End If

    End Sub
    Friend Sub EditUpdate()
        Dim pdsInsertedRows As DataSet
        Dim pdsModifiedRows As DataSet

        Select Case fintCURRENTFORM
            Case 1 'frmEditExam
                Dim fEditExam As frmEditExam = CType(fParent.ActiveMdiChild, frmEditExam)
                With fEditExam
                    .BindingContext(.DsExam1, "Q1").EndCurrentEdit()
                    pdsInsertedRows = .DsExam1.GetChanges(DataRowState.Added)
                    pdsModifiedRows = .DsExam1.GetChanges(DataRowState.Modified)
                    Try
                        If Not pdsInsertedRows Is Nothing Then .odbDaExam.Update(pdsInsertedRows)
                        If Not pdsModifiedRows Is Nothing Then .odbDaExam.Update(pdsModifiedRows)
                        .DsExam1.AcceptChanges()
                    Catch
                        MsgBox1()
                    Finally
                        .RefreshCombos()

                    End Try
                End With

            Case 3
                Dim fEditFlash As frmEditor = CType(fParent.ActiveMdiChild, frmEditor)
                With fEditFlash
                    .BindingContext(.DsFlash1, "Q1").EndCurrentEdit()
                    pdsInsertedRows = .DsFlash1.GetChanges(DataRowState.Added)
                    pdsModifiedRows = .DsFlash1.GetChanges(DataRowState.Modified)
                    Try
                        If Not pdsInsertedRows Is Nothing Then .odbDaFlash.Update(pdsInsertedRows)
                        If Not pdsModifiedRows Is Nothing Then .odbDaFlash.Update(pdsModifiedRows)
                        .DsFlash1.AcceptChanges()
                    Catch
                        MsgBox1()
                    Finally
                        .RefreshCombo()
                    End Try
                End With

            Case 4 'frmEditRouterLabs
                Dim fEditR As frmEditRouterLabs = CType(fParent.ActiveMdiChild, frmEditRouterLabs)
                With fEditR
                    .BindingContext(.DsLabs1, "Q1").EndCurrentEdit()

                    pdsInsertedRows = .DsLabs1.GetChanges(DataRowState.Added)
                    pdsModifiedRows = .DsLabs1.GetChanges(DataRowState.Modified)
                    Try
                        If Not pdsInsertedRows Is Nothing Then .odbDaLabs.Update(pdsInsertedRows)
                        If Not pdsModifiedRows Is Nothing Then .odbDaLabs.Update(pdsModifiedRows)
                        .DsLabs1.AcceptChanges()
                    Catch
                        MsgBox1()
                    Finally
                        .RefreshCombos2()
                    End Try
                End With

            Case 5 'frmEditIconsE
                Dim fEditIco As frmEditIconsE = CType(fParent.ActiveMdiChild, frmEditIconsE)
                With fEditIco
                    .BindingContext(.DsIconsE1, "t1").EndCurrentEdit()
                    pdsInsertedRows = .DsIconsE1.GetChanges(DataRowState.Added)
                    pdsModifiedRows = .DsIconsE1.GetChanges(DataRowState.Modified)
                    Try
                        If Not pdsInsertedRows Is Nothing Then .odbDaIconsE.Update(pdsInsertedRows)
                        If Not pdsModifiedRows Is Nothing Then .odbDaIconsE.Update(pdsModifiedRows)
                        .DsIconsE1.AcceptChanges()
                    Catch
                        MsgBox1()
                    End Try
                End With
        End Select
        UpdateStatusBar()
    End Sub
    Friend Sub UpdateStatusBar()
        Select Case fintCURRENTFORM
            Case 1 'frmEditExam
                Dim fEditExam As frmEditExam = CType(fParent.ActiveMdiChild, frmEditExam)
                With fEditExam
                    SetPanelBarText("" & .DsExam1.Q1.Rows.Count, "" & .BindingContext(.DsExam1, "Q1").Position + 1)
                End With

            Case 3 'frmEditor
                Dim fEditFlash As frmEditor = CType(fParent.ActiveMdiChild, frmEditor)
                With fEditFlash
                    SetPanelBarText("" & .DsFlash1.Q1.Rows.Count, "" & .BindingContext(.DsFlash1, "Q1").Position + 1)
                End With

            Case 4 'frmEditRouterLabs
                Dim fEditRouterLabs As frmEditRouterLabs = CType(fParent.ActiveMdiChild, frmEditRouterLabs)
                With fEditRouterLabs
                    SetPanelBarText("" & .DsLabs1.Q1.Rows.Count, "" & .BindingContext(.DsLabs1, "Q1").Position + 1)
                End With

            Case 5 'frmEditIconsE
                Dim fEditIconsE As frmEditIconsE = CType(fParent.ActiveMdiChild, frmEditIconsE)
                With fEditIconsE
                    SetPanelBarText("" & .DsIconsE1.t1.Rows.Count, "" & .BindingContext(.DsIconsE1, "t1").Position + 1)
                End With
        End Select
    End Sub



End Module


