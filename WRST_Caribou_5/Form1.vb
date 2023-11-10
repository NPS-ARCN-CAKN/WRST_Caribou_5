Public Class Form1
    Private Sub AccessRadiotrackingDatasetButton_Click(sender As Object, e As EventArgs) Handles AccessRadiotrackingDatasetButton.Click
        Dim RadiotrackingDatasetForm As New RadiotrackingDatasetForm
        RadiotrackingDatasetForm.Show()

    End Sub

    Private Sub OpenAnimalObservationsFormButton_Click(sender As Object, e As EventArgs) Handles OpenAnimalObservationsFormButton.Click
        Dim AnimalObservationsForm As New AnimalObservationsDatasetForm
        AnimalObservationsForm.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UserToolStripLabel.Text = My.User.Name
        Me.ConnectionStringToolStripLabel.Text = My.Settings.WRST_CaribouConnectionString

        Dim EditCaribouGroupsForm As New EditCaribouGroupsForm
        EditCaribouGroupsForm.Show()


    End Sub

    Private Sub OpenCensusDatasetFormButton_Click(sender As Object, e As EventArgs) Handles OpenCensusDatasetFormButton.Click
        Dim CensusForm As New CaribouGroupsForm
        CensusForm.Show()
    End Sub

    Private Sub OpenCaribouDetailsFormButton_Click(sender As Object, e As EventArgs) Handles OpenCaribouDetailsFormButton.Click
        Dim CaribouDetailsForm As New CaribouDetailsForm()
        CaribouDetailsForm.Show()
    End Sub

    Private Sub ImportDataButton_Click(sender As Object, e As EventArgs) Handles ImportDataButton.Click

    End Sub
End Class
