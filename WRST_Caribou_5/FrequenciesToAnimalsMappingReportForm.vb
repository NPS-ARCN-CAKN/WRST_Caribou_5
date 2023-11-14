''' <summary>
''' The FrequenciesToAnimalsMappingReportForm shows the user information about each frequency detected in a caribou group and allows the user 
''' to translate each frequency to an AnimalID from the Animal_Movements database and then associate that animal with the group as defined by
''' the WRST_Caribou database's data model between the CaribouGroups table and its child GroupMembers table.
''' </summary>
Public Class FrequenciesToAnimalsMappingReportForm

    ''' <summary>
    ''' DataTable of frequencies and associated information such as whether the frequency corresponds to an Animal_Movement database's collar deployment or not.
    ''' </summary>
    Private FrequenciesDataTableValue As DataTable
    Public Property FrequenciesDataTable() As DataTable
        Get
            Return FrequenciesDataTableValue
        End Get
        Set(ByVal value As DataTable)
            FrequenciesDataTableValue = value
        End Set
    End Property

    ''' <summary>
    ''' Creates a new FrequenciesToAnimalsMappingReportForm and accepts a FrequenciesToAnimalIDsDataTable which contains information about each frequency
    ''' detected in a caribou group as defined by the Animal_Movement database.
    ''' </summary>
    ''' <param name="FrequenciesToAnimalIDsDataTable"></param>
    Public Sub New(FrequenciesToAnimalIDsDataTable As DataTable)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.FrequenciesDataTable = FrequenciesToAnimalIDsDataTable
        Me.ReportDataGridView.DataSource = Me.FrequenciesDataTable

        'Color problematic rows -- NOTE I can't get this to work don't know why yet.
        For Each DGVRow As DataGridViewRow In Me.ReportDataGridView.Rows
            If DGVRow.Cells("Deployments").Value = 0 Then
                DGVRow.DefaultCellStyle.BackColor = Color.Red
            End If
        Next

        Try
            'Start by making sure we have a valid row.
            If Me.FrequenciesDataTable.Rows.Count > 0 Then
                If Not FrequenciesDataTable.Rows(0).Item("EID") Is Nothing Then
                    If Not IsDBNull(FrequenciesDataTable.Rows(0).Item("EID")) Then
                        If FrequenciesDataTable.Rows(0).Item("EID").trim.ToString.Length > 0 Then

                            'Get attributes about the CaribouGroup row based on the FrequenciesDataTable
                            'EID,Herd,SightingDate,SurveyName should all come from the parent CaribouGroup row so we can just get it 
                            'from the first row
                            Dim EID As String = FrequenciesDataTable.Rows(0).Item("EID").ToString.Trim

                            Dim Herd As String = FrequenciesDataTable.Rows(0).Item("Herd").ToString.Trim
                            Dim SightingDate As String = FrequenciesDataTable.Rows(0).Item("SightingDate").ToString.Trim
                            Dim SurveyName As String = FrequenciesDataTable.Rows(0).Item("SurveyName").ToString.Trim
                            Dim WhereClause As String = "WHERE EID = '" & EID & "'"

                            'Start to build an SQL script to delete existing GroupMember rows if they exist, and then
                            'insert the revised frequencies/AnimalIDs.
                            Dim SQLScript As String = "/* " & vbNewLine & My.User.Name & " " & Now & vbNewLine & "SQL script to translate the frequencies associated with the caribou group with EID = " & EID & " to AnimalIDs as stored in Animal_Movement for the " & SurveyName & " survey." & vbNewLine & "*/" & vbNewLine

                            'This transaction line is not technically needed but if the user copies the sql script to execute manually it is handy to 
                            'have it written out. User can uncomment.
                            SQLScript = SQLScript & "-- BEGIN TRANSACTION -- COMMIT ROLLBACK" & vbNewLine

                            'Build the delete query to delete GroupMember rows for the CaribouGroup based on its unique EID
                            'Add it to the script
                            SQLScript = SQLScript & "DELETE FROM GroupMembers " & WhereClause & vbNewLine

                            'Now loop through each frequency row and generate an insert query to add to the script
                            For Each Row As DataRow In Me.FrequenciesDataTable.Rows
                                If Not IsDBNull(Row.Item("InsertQuery")) Then

                                    'Add the insert query from the frequency row to the sql script
                                    Dim InsertQuery As String = Row.Item("InsertQuery")
                                    SQLScript = SQLScript & InsertQuery & vbNewLine

                                Else

                                    'The collar deployment for the frequency herd and date was not found in Animal_Movement. Write
                                    'a reminder into the sql script
                                    SQLScript = SQLScript & vbNewLine & "-- WARNING: Frequency " & Row.Item("Frequency") & " did not correspond to a collar deployment in Animal_Movement for the " & Herd & " herd on " & SightingDate & vbNewLine & vbNewLine

                                End If
                            Next

                            'The CaribouGroups table has a FrequenciesCount attribute - update it with the new count of frequencies
                            Dim UpdateFrequenciesCountQuery As String = "UPDATE [CaribouGroups] SET FrequenciesCount = " & FrequenciesDataTable.Rows.Count & WhereClause & vbNewLine
                            SQLScript = SQLScript & UpdateFrequenciesCountQuery & vbNewLine

                            'Write the sql script to the SqlTextBox so the user can access it if they want to
                            Me.SqlTextBox.Text = SQLScript
                        End If

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try


    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        'Close the from
        Me.Close()
    End Sub

    Private Sub InsertTheGroupsButton_Click(sender As Object, e As EventArgs) Handles InsertTheGroupsButton.Click

        'User clicked the button to execute the sql script to modify the GroupMembers table. Run the script with confirm.
        If MsgBox("Modify the caribou associated with this group?", MsgBoxStyle.YesNo, "Confirm changes") = MsgBoxResult.Yes Then
            Try
                MsgBox("temporarily disabled" & vbNewLine & Me.SqlTextBox.Text)
                'ExecuteNonQuery(Me.SqlTextBox.Text, My.Settings.WRST_CaribouConnectionString)
            Catch ex As Exception
                MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
            End Try
        End If
    End Sub



End Class