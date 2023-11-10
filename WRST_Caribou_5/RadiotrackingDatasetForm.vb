Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid

Public Class RadiotrackingDatasetForm
    Private Sub RadiotrackingDatasetForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Sql As String = "SELECT TOP 100 Percent * FROM Dataset_Radiotracking order by AnimalID,Year,SightingDate"
            Dim RadiotrackingDataTable As DataTable = GetDataTableFromSQLServerDatabase(My.Settings.WRST_CaribouConnectionString, Sql)
            Me.RadiotrackingGridControl.DataSource = RadiotrackingDataTable
            SetUpGridControl(Me.RadiotrackingGridControl, False)
            Me.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub
End Class