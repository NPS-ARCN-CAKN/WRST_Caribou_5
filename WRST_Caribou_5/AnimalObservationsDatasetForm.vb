Public Class AnimalObservationsDatasetForm
    Private Sub AnimalObservationsDataset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Sql As String = "SELECT TOP 100 Percent * FROM Dataset_AnimalObservations order by AnimalID,Year,SightingDate"
            Dim AnimalObservationsDataTable As DataTable = GetDataTableFromSQLServerDatabase(My.Settings.WRST_CaribouConnectionString, Sql)
            Me.AnimalObservationsGridControl.DataSource = AnimalObservationsDataTable
            SetUpGridControl(Me.AnimalObservationsGridControl, False)
            Me.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub
End Class