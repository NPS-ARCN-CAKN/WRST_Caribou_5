Public Class EditCaribouGroupsForm

    Private Sub LoadCaribouGroupsDataset()
        Try
            Me.GroupMembersTableAdapter.Fill(Me.WRST_CaribouDataSet.GroupMembers)
            Me.CaribouGroupsTableAdapter.Fill(Me.WRST_CaribouDataSet.CaribouGroups)
            Me.FilterToolStripTextBox.Text = "SurveyName = '2021 Fall Chisana Caribou Composition Survey'"
            Dim Sort As String = "SurveyName DESC,SearchArea,GroupNumber"
            Me.CaribouGroupsBindingSource.Sort = Sort
            Me.GroupMembersBindingSource.Sort = "ActualFrequency"
            Me.SortToolStripTextBox.Text = Sort
        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try
    End Sub

    Private Sub SaveCaribouGroupsDataset()
        Try
            Me.Validate()
            Me.GroupMembersBindingSource.EndEdit()
            Me.CaribouGroupsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.WRST_CaribouDataSet)
        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Private Sub EditGroupMembers()

        Try
            'Get the current row's primary key value
            Dim EID As String = GetCurrentValue(CaribouGroupsBindingSource, "EID") 'Primary key of the CaribouGroups table

            'Need to save pending edits before we do anything since we offer the user the opportunity to change records later
            If WRST_CaribouDataSet.HasChanges = True Then
                If MsgBox("You have pending edits that must be saved before you can run this tool. Save?", MsgBoxStyle.YesNo, "Save?") = MsgBoxResult.Yes Then

                    'Save the dataset
                    SaveCaribouGroupsDataset()

                    'Move back to the place we were at before the save
                    Me.CaribouGroupsBindingSource.Position = Me.CaribouGroupsBindingSource.Find("EID", EID)
                End If
            End If

            'Create a DataTable to hold information about each frequency in the FrequenciesInGroup attribute of the current CaribouGroup row
            Dim FrequenciesDataTable As New DataTable("Frequencies")
            FrequenciesDataTable.Columns.Add("Frequency", GetType(Double))
            FrequenciesDataTable.Columns.Add("AnimalID", GetType(String))
            FrequenciesDataTable.Columns.Add("DeploymentExists", GetType(Boolean))
            FrequenciesDataTable.Columns.Add("Deployments", GetType(Integer))
            FrequenciesDataTable.Columns.Add("Herd", GetType(String))
            FrequenciesDataTable.Columns.Add("SightingDate", GetType(Date))
            FrequenciesDataTable.Columns.Add("SurveyName", GetType(String))
            FrequenciesDataTable.Columns.Add("InsertQuery", GetType(String))
            FrequenciesDataTable.Columns.Add("EID", GetType(String))

            'Start by getting attributes of the current CaribouGroup record
            Dim SurveyName As String = GetCurrentValue(CaribouGroupsBindingSource, "SurveyName")
            Dim Herd As String = GetCurrentValue(CaribouGroupsBindingSource, "Herd")
            Dim GroupNumber As String = GetCurrentValue(CaribouGroupsBindingSource, "GroupNumber")
            Dim SightingDate As String = GetCurrentValue(CaribouGroupsBindingSource, "SightingDate")
            Dim FrequenciesInGroup As String = GetCurrentValue(CaribouGroupsBindingSource, "FrequenciesInGroup")

            'WRST_Caribou uses Herd where Animal_Movement database uses ProjectID to identify herd names, so we need to translate one to the other
            Dim ProjectID As String = GetProjectIDFromHerd(Herd)

            'Survey observers record any GPS collared caribou frequencies they see in the FrequenciesInGroup attribute.
            'These are separated by commas.
            'Loop through the frequencies in the caribou group and look up which collar deployment and AnimalID animal belonged to the frequency
            'for the herd and sightingdate
            If IsDBNull(FrequenciesInGroup) = False Then

                'Ensure we have frequencies before doing anything
                If Len(FrequenciesInGroup.Trim) = 0 Then
                    MsgBox("There are no frequencies associated with this group.")
                Else

                    'There are frequencies associated with the group, assume separated by commas and process one by one
                    Dim Frequencies As String() = FrequenciesInGroup.Split(",")

                    'Get counts of the frequencies and frequency to AnimalIDs found
                    Dim FrequenciesCount As Integer = 0
                    Dim FrequenciesFound As Integer = 0

                    'Loop through the comma separated frequencies and process one by one
                    For Each Frequency As String In Frequencies

                        'Create a new row in the FrequenciesDataTable to store info about the frequency
                        Dim NewFrequencyRow As DataRow = FrequenciesDataTable.NewRow
                        NewFrequencyRow.Item("Frequency") = Frequency
                        NewFrequencyRow.Item("Herd") = Herd
                        NewFrequencyRow.Item("SightingDate") = SightingDate
                        NewFrequencyRow.Item("SurveyName") = SurveyName
                        NewFrequencyRow.Item("EID") = EID

                        'Get a DataTable of the collar deployment (should only be one for the herd, frequency and sightingdate)
                        'from Animal_Movement for the frequency.
                        Dim CollarDeploymentsDataTable As DataTable = GetDataTableOfCollarDeploymentsForAHerdFrequencyAndSightingDate(Herd, Frequency, SightingDate)

                        'Analyze the collar deployment
                        If Not CollarDeploymentsDataTable Is Nothing Then

                            'Set attributes for the new frequency row
                            NewFrequencyRow.Item("Deployments") = CollarDeploymentsDataTable.Rows.Count

                            'See if any deployments exist
                            If CollarDeploymentsDataTable.Rows.Count = 0 Then
                                NewFrequencyRow.Item("DeploymentExists") = False 'The collar deployment was not found
                            ElseIf CollarDeploymentsDataTable.Rows.Count = 1 Then

                                'A collar deployment for the frequency, herd and sightingdate was found in Animal_Movement
                                'Getattributes of the deployment
                                Dim AnimalID As String = CollarDeploymentsDataTable.Rows(0).Item("AnimalID")
                                Dim AMFrequency As Double = CollarDeploymentsDataTable.Rows(0).Item("Frequency")
                                Dim DeploymentID As Integer = CollarDeploymentsDataTable.Rows(0).Item("DeploymentID")

                                'Set attributes of the new frequency row
                                NewFrequencyRow.Item("DeploymentExists") = True
                                NewFrequencyRow.Item("AnimalID") = AnimalID
                                Dim InsertQuery As String = "INSERT INTO [dbo].[GroupMembers] ([ActualFrequency],[AnimalID],[EID],[DeploymentID],[GroupMemberID],RecordedFrequency) VALUES(" & AMFrequency & ",'" & AnimalID & "','" & EID & "'," & DeploymentID & ",'" & Guid.NewGuid.ToString & "'," & Frequency & ")"
                                NewFrequencyRow.Item("InsertQuery") = InsertQuery

                            ElseIf CollarDeploymentsDataTable.Rows.Count > 1 Then
                                'This is a big problem because we don't know which animal it was. I know at least one overlapping collar deployment exists in AM
                                NewFrequencyRow.Item("DeploymentExists") = True
                                'The deployments count is set above so user knows multiple deployments were found
                            End If
                            FrequenciesCount = FrequenciesCount + 1
                            FrequenciesFound = FrequenciesFound + CollarDeploymentsDataTable.Rows.Count
                        End If
                        FrequenciesDataTable.Rows.Add(NewFrequencyRow)
                    Next

                    'At this point we have a DataTable of information about each frequency in the current row's FrequenciesInGroup attribute
                    'Open a form to show the table so the user can see which frequencies are OK and which might have problems or are not found
                    Dim FrequenciesToAnimalsForm As New FrequenciesToAnimalsMappingReportForm(FrequenciesDataTable)
                    FrequenciesToAnimalsForm.Show()

                    'At this point changes may have been made to the database from th e FrequenciesToAnimalsForm so refresh the dataset
                    LoadCaribouGroupsDataset()

                    'Move back to the record we were on
                    Me.CaribouGroupsBindingSource.Position = Me.CaribouGroupsBindingSource.Find("EID", EID)

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try
    End Sub


    Private Sub EditCaribouGroupsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        LoadCaribouGroupsDataset()
    End Sub



    Private Sub GroupMembersDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles GroupMembersDataGridView.DataError
        MsgBox(e.Exception.Message)
    End Sub

    Private Sub ReconcileFrequenciesForThisGroupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReconcileFrequenciesForThisGroupToolStripMenuItem.Click
        EditGroupMembers()
    End Sub



    'Private Sub InsertGroupMembers()
    '    'The purpose of this sub is to look up the collar frequencies in the caribou group in the Animal_Movement 
    '    'database in order to determine which AnimalID they belong to.
    '    'Then offer to associate the animals with the group by inserting a record in the related GroupMembers data table.

    '    Try
    '        'Start by getting attributes of the selected group
    '        Dim SurveyName As String = GetCurrentValue(CaribouGroupsBindingSource, "SurveyName")
    '        Dim Herd As String = GetCurrentValue(CaribouGroupsBindingSource, "Herd")
    '        Dim GroupNumber As String = GetCurrentValue(CaribouGroupsBindingSource, "GroupNumber")
    '        Dim EID As String = GetCurrentValue(CaribouGroupsBindingSource, "EID") 'Primary key of the CaribouGroups table
    '        Dim SightingDate As String = GetCurrentValue(CaribouGroupsBindingSource, "SightingDate")
    '        Dim FrequenciesInGroup As String = GetCurrentValue(CaribouGroupsBindingSource, "FrequenciesInGroup")
    '        'WRST_Caribou uses Herd, Animal_Movement database uses ProjectID so we need to translate one to the other
    '        Dim ProjectID As String = GetProjectIDFromHerd(Herd)

    '        ' Loop through the frequencies in the caribou group and figure out which animal belonged to the frequency for the herd and sightingdate
    '        If IsDBNull(FrequenciesInGroup) = False Then
    '            If Len(FrequenciesInGroup.Trim) = 0 Then
    '                MsgBox("There are no frequencies associated with this group.")
    '            Else



    '                'Make a variable to hold an SQL script to wrap in a transaction later
    '                Dim SQLScript As String = "/* " & vbNewLine & My.User.Name & " " & Now & vbNewLine & "SQL script to associate the frequencies " & FrequenciesInGroup & " with the caribou group " & SurveyName & vbTab & Herd & vbTab & GroupNumber & vbTab & SightingDate & vbTab & "EID: " & EID & vbNewLine & "*/" & vbNewLine
    '                SQLScript = SQLScript & "-- BEGIN TRANSACTION -- COMMIT ROLLBACK" & vbNewLine
    '                'Now see if the GroupMembers data table already has records for the associated frequency/AnimalID
    '                Dim CaribouGroupFilter As String = "EID='" & EID & "'"

    '                'Get a DataView of GroupMembers for the current CaribouGroup's EID
    '                Dim GMDV As DataView = New DataView(WRST_CaribouDataSet.Tables("GroupMembers"), CaribouGroupFilter, "", DataViewRowState.CurrentRows)

    '                'If group members already exist then ask user what to do
    '                If GMDV.Count > 0 Then

    '                    'Group members exist already, ask to delete and regenerate them
    '                    Dim DeleteQuery As String = "DELETE FROM GroupMembers WHERE " & CaribouGroupFilter

    '                    'Add the delete query to the list of SQL statements
    '                    SQLScript = SQLScript & DeleteQuery & vbNewLine

    '                End If

    '                'There are frequencies associated with the group, assume separated by commas and process one by one
    '                Dim Frequencies As String() = FrequenciesInGroup.Split(",")

    '                'Loop through the comma separated frequencies and process one by one
    '                Dim FrequenciesCount As Integer = 0
    '                For Each Frequency As String In Frequencies

    '                    Dim CollarDeploymentsDataTable As DataTable = GetDataTableOfCollarDeploymentsForAHerdFrequencyAndSightingDate(Herd, Frequency, SightingDate)
    '                    If Not CollarDeploymentsDataTable Is Nothing Then
    '                        'See if any deployments exist
    '                        If CollarDeploymentsDataTable.Rows.Count = 0 Then
    '                            If MsgBox("Warning: No deployment found for frequency " & Frequency & " in the " & Herd & " herd on  " & SightingDate & ". Continue? ", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.No Then
    '                                MsgBox("Edits canceled.")
    '                                Exit Sub
    '                            End If
    '                        ElseIf CollarDeploymentsDataTable.Rows.Count = 1 Then

    '                            'Collar deployments for the frequency, herd and sightingdate were found in Animal_Movement, process them
    '                            Dim AnimalID As String = CollarDeploymentsDataTable.Rows(0).Item("AnimalID")
    '                            Dim DeploymentID As Integer = CollarDeploymentsDataTable.Rows(0).Item("DeploymentID")
    '                            Dim AMFrequency As Double = CollarDeploymentsDataTable.Rows(0).Item("Frequency")
    '                            Dim InsertQuery As String = "INSERT INTO [dbo].[GroupMembers] ([ActualFrequency],[AnimalID],[EID],[DeploymentID],[GroupMemberID],RecordedFrequency) VALUES(" & AMFrequency & ",'" & AnimalID & "','" & EID & "'," & DeploymentID & ",'" & Guid.NewGuid.ToString & "'," & Frequency & ")"

    '                            'Add the insert query to the list of SQL statements
    '                            SQLScript = SQLScript & InsertQuery & vbNewLine

    '                        ElseIf CollarDeploymentsDataTable.Rows.Count > 1 Then
    '                            'This is a big problem because we don't know which animal it was. I know at least one overlapping collar deployment exists in AM
    '                            MsgBox("Warning: There appear to be multiple collar deployments for the frequency " & Frequency & " in the " & Herd & " herd on " & SightingDate & ". It is not possible to determine which animal was wearing the collar on this date. This problem must be resolved before animals can be associated with this caribou group.", MsgBoxStyle.Critical, "WARNING")
    '                        End If
    '                        FrequenciesCount = FrequenciesCount + 1
    '                    End If

    '                Next
    '                Dim UpdateFrequenciesCountQuery As String = "UPDATE [CaribouGroups] SET FrequenciesCount = " & FrequenciesCount & " WHERE " & CaribouGroupFilter
    '                SQLScript = SQLScript & UpdateFrequenciesCountQuery & vbNewLine
    '                Debug.Print(SQLScript)

    '                'Ask to execute the sql script
    '                If MsgBox(SQLScript, MsgBoxStyle.YesNo, "Execute the changes below?") = MsgBoxResult.Yes Then

    '                    ExecuteNonQuery(SQLScript, My.Settings.WRST_CaribouConnectionString)
    '                    LoadCaribouGroupsDataset()
    '                    Me.CaribouGroupsBindingSource.Position = Me.CaribouGroupsBindingSource.Find("EID", EID)
    '                End If

    '            End If
    '            End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
    '    End Try
    'End Sub

    Private Sub ConvertFrequenciesToAnimalIDsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'InsertGroupMembers()
    End Sub

    Private Sub ApplyFilterToolStripButton_Click_1(sender As Object, e As EventArgs) Handles ApplyFilterToolStripButton.Click
        'Filter the caribou groups dataset based on the filter textbox contents
        Try
            Me.CaribouGroupsBindingSource.Filter = Me.FilterToolStripTextBox.Text.Trim
        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try
    End Sub

    Private Sub ApplySortToolStripButton_Click_1(sender As Object, e As EventArgs) Handles ApplySortToolStripButton.Click
        'Sort the caribou groups dataset based on the sort textbox contents
        Try
            Me.CaribouGroupsBindingSource.Sort = Me.SortToolStripTextBox.Text.Trim
        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        If MsgBox("Save edits?", MsgBoxStyle.YesNo, "Save?") = MsgBoxResult.Yes Then
            SaveCaribouGroupsDataset()
        End If
    End Sub

    Private Sub EditCaribouGroupsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If WRST_CaribouDataSet.HasChanges = True Then
            If MsgBox("You have unsaved changes. Save?", MsgBoxStyle.YesNo, "Save?") = MsgBoxResult.Yes Then
                SaveCaribouGroupsDataset()
            End If
        End If
    End Sub
End Class