Public Class FrequenciesToAnimalsMappingReportForm

    Private FrequenciesDataTableValue As DataTable
    Public Property FrequenciesDataTable() As DataTable
        Get
            Return FrequenciesDataTableValue
        End Get
        Set(ByVal value As DataTable)
            FrequenciesDataTableValue = value
        End Set
    End Property

    Public Sub New(FrequenciesToAnimalIDsDataTable As DataTable)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.FrequenciesDataTable = FrequenciesToAnimalIDsDataTable
        Me.ReportDataGridView.DataSource = Me.FrequenciesDataTable


        For Each DGVRow As DataGridViewRow In Me.ReportDataGridView.Rows
            If DGVRow.Cells("Deployments").Value = 0 Then
                DGVRow.DefaultCellStyle.BackColor = Color.Red
            End If
        Next

        Try
            If Me.FrequenciesDataTable.Rows.Count > 0 Then
                If Not FrequenciesDataTable.Rows(0).Item("EID") Is Nothing Then
                    If Not IsDBNull(FrequenciesDataTable.Rows(0).Item("EID")) Then
                        If FrequenciesDataTable.Rows(0).Item("EID").trim.ToString.Length > 0 Then
                            Dim EID As String = FrequenciesDataTable.Rows(0).Item("EID").ToString.Trim
                            Dim WhereClause As String = "WHERE EID = '" & EID & "'"
                            Dim Herd As String = FrequenciesDataTable.Rows(0).Item("Herd").ToString.Trim
                            Dim SightingDate As String = FrequenciesDataTable.Rows(0).Item("SightingDate").ToString.Trim
                            Dim SurveyName As String = FrequenciesDataTable.Rows(0).Item("SurveyName").ToString.Trim

                            Dim SQLScript As String = "/* " & vbNewLine & My.User.Name & " " & Now & vbNewLine & "SQL script to translate the frequencies associated with the caribou group with EID = " & EID & " to AnimalIDs as stored in Animal_Movement for the " & SurveyName & " survey." & vbNewLine & "*/" & vbNewLine
                            SQLScript = SQLScript & "-- BEGIN TRANSACTION -- COMMIT ROLLBACK" & vbNewLine

                            SQLScript = SQLScript & "DELETE FROM GroupMembers " & WhereClause & vbNewLine
                            For Each Row As DataRow In Me.FrequenciesDataTable.Rows
                                If Not IsDBNull(Row.Item("InsertQuery")) Then
                                    Dim InsertQuery As String = Row.Item("InsertQuery")
                                    SqlScript = SqlScript & InsertQuery & vbNewLine
                                Else
                                    SQLScript = SQLScript & vbNewLine & "-- WARNING: Frequency " & Row.Item("Frequency") & " did not correspond to a collar deployment in Animal_Movement for the " & Herd & " herd on " & SightingDate & vbNewLine & vbNewLine
                                End If
                            Next
                            Dim UpdateFrequenciesCountQuery As String = "UPDATE [CaribouGroups] SET FrequenciesCount = " & FrequenciesDataTable.Rows.Count & WhereClause & vbNewLine
                            SQLScript = SQLScript & UpdateFrequenciesCountQuery & vbNewLine
                            Me.SqlTextBox.Text = SqlScript
                        End If

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try


    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub InsertTheGroupsButton_Click(sender As Object, e As EventArgs) Handles InsertTheGroupsButton.Click
        If MsgBox("Modify the caribou associated with this group?", MsgBoxStyle.YesNo, "Confirm changes") = MsgBoxResult.Yes Then
            Try
                ExecuteNonQuery(Me.SqlTextBox.Text, My.Settings.WRST_CaribouConnectionString)
            Catch ex As Exception
                MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
            End Try
        End If
    End Sub



End Class