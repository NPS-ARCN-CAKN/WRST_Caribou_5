Public Class EditCaribouGroupsForm
    Private Sub CaribouGroupsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CaribouGroupsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GroupMembersBindingSource.EndEdit()
        Me.CaribouGroupsBindingSource.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.WRST_CaribouDataSet)

    End Sub

    Private Sub EditCaribouGroupsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WRST_CaribouDataSet.GroupMembers' table. You can move, or remove it, as needed.
        Me.GroupMembersTableAdapter.Fill(Me.WRST_CaribouDataSet.GroupMembers)
        'TODO: This line of code loads data into the 'WRST_CaribouDataSet.CaribouGroups' table. You can move, or remove it, as needed.
        Me.CaribouGroupsTableAdapter.Fill(Me.WRST_CaribouDataSet.CaribouGroups)
        Me.FilterToolStripTextBox.Text = "SurveyName = '2021 Fall Chisana Caribou Composition Survey'"
        Me.SortToolStripTextBox.Text = "SurveyName,SearchArea,GroupNumber"
    End Sub

    Private Sub GroupMembersDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles GroupMembersDataGridView.CellEnter

    End Sub

    Private Sub GroupMembersDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles GroupMembersDataGridView.DataError
        Debug.Print(e.Exception.Message)
    End Sub

    Private Sub ApplyFilterSortToolStripButton_Click(sender As Object, e As EventArgs) Handles ApplyFilterSortToolStripButton.Click
        Me.CaribouGroupsBindingSource.Filter = Me.FilterToolStripTextBox.Text.Trim

        Me.CaribouGroupsBindingSource.Sort = Me.SortToolStripTextBox.Text.Trim

    End Sub

    Private Sub CurrentRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CurrentRowToolStripMenuItem.Click
        Debug.Print("------------------------------------------------------------" & vbNewLine)
        Dim SurveyName As String = GetCurrentValue(CaribouGroupsBindingSource, "SurveyName")
        Dim Herd As String = GetCurrentValue(CaribouGroupsBindingSource, "Herd")
        Dim EID As String = GetCurrentValue(CaribouGroupsBindingSource, "EID")

        ' Animal_Movement database uses ProjectID rather than Herd so convert
        Dim ProjectID As String = ""
        If Herd = "Chisana" Then ProjectID = "ChisanaCH"
        If Herd = "Mentasta" Then ProjectID = "WRST_Caribou"

        Dim SightingDate As String = GetCurrentValue(CaribouGroupsBindingSource, "SightingDate")
        Dim FrequenciesInGroup As String = GetCurrentValue(CaribouGroupsBindingSource, "FrequenciesInGroup")

        ' Loop through the frequencies
        Dim Frequencies As String() = FrequenciesInGroup.Split(",")

        For Each Frequency As String In Frequencies
            Debug.Print("==================================" & vbNewLine)
            Debug.Print(Herd & vbTab & ProjectID & vbTab & Frequency)
            Dim Sql As String = "SELECT Animals.ProjectId, Animals.AnimalId, CollarDeployments.DeploymentDate, Collars.Frequency, Animals.Species, Animals.Gender, Collars.DisposalDate, Animals.MortalityDate, CollarDeployments.RetrievalDate, 
 Animals.GroupName, CollarDeployments.CollarManufacturer, CollarDeployments.CollarId, Collars.CollarModel, Collars.Manager, Collars.Owner, Collars.SerialNumber, Collars.HasGps, Animals.Description AS AnimalDescription, 
 Collars.Notes AS CollarNotes, CollarDeployments.DeploymentId
FROM Collars INNER JOIN
 CollarDeployments ON Collars.CollarManufacturer = CollarDeployments.CollarManufacturer AND Collars.CollarId = CollarDeployments.CollarId INNER JOIN
 Animals ON CollarDeployments.ProjectId = Animals.ProjectId AND CollarDeployments.AnimalId = Animals.AnimalId
WHERE  (Collars.Frequency = " & Frequency & ") And (Animals.ProjectId = '" & ProjectID & "')
And   ( Convert(Date,'" & SightingDate & "') >= isnull(collardeployments.DeploymentDate, Convert(Date,'" & SightingDate & "'))) 
And   ( Convert(Date,'" & SightingDate & "') <= isnull(collardeployments.RetrievalDate, Convert(Date,'" & SightingDate & "'))) 
And ( Convert(Date,'" & SightingDate & "') <= isnull(animals.mortalitydate, Convert(Date,'" & SightingDate & "'))) 
And ( Convert(Date,'" & SightingDate & "') <= isnull(collars.DisposalDate, Convert(Date,'" & SightingDate & "'))) 
ORDER BY Animals.ProjectId, Animals.AnimalId, CollarDeployments.DeploymentDate"
            Debug.Print(vbNewLine & Sql & vbNewLine)

            Dim DT As DataTable = GetDataTableFromSQLServerDatabase(My.Settings.Animal_MovementConnectionString, Sql)
            Debug.Print("Rows " & DT.Rows.Count)
            If DT.Rows.Count = 1 Then
                Dim AnimalID As String = DT.Rows(0).Item("AnimalID")
                Dim DeploymentID As Integer = DT.Rows(0).Item("DeploymentID")
                Dim InsertQuery As String = "INSERT INTO [dbo].[GroupMembers]
           ([ActualFrequency]
           ,[AnimalID]
           ,[EID]
           ,[DeploymentID]
           ,[GroupMemberID])
     VALUES
           (" & Frequency & "
           ,'" & AnimalID & "'
           ,'" & EID & "'
           ," & DeploymentID & "
           ,'" & Guid.NewGuid.ToString & "')"
                Debug.Print(vbNewLine & InsertQuery & vbNewLine)
            End If
        Next

    End Sub



End Class