Public Class CaribouGroupsForm
    Private Sub CaribouGroupsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            'Query the database for the caribou census data stored in the CaribouGroups/GroupMembers tables 
            'and made available through the flattened Dataset_Census view.
            Dim Sql As String = "SELECT TOP 100 Percent * FROM Dataset_Census order by SurveyName,SightingDate,GroupNumber"
            Dim CaribouGroupsDataTable As DataTable = GetDataTableFromSQLServerDatabase(My.Settings.WRST_CaribouConnectionString, Sql)

            'Load the DataTable into the GridControl, PivotGridControl
            Me.CaribouGroupsGridControl.DataSource = CaribouGroupsDataTable
            Me.CaribouGroupsPivotGridControl.DataSource = CaribouGroupsDataTable
            Me.CaribouGroupsPivotGridControl.RetrieveFields()

            'Set up the grid controls in a standard way
            SetUpGridControl(Me.CaribouGroupsGridControl, False)
            SetUpPivotGridControl(Me.CaribouGroupsPivotGridControl)

            'Maximize the form
            Me.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub ExportGridContentsToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ExportGridContentsToolStripComboBox.SelectedIndexChanged
        'Allow user to exort the data from the grid control to a file
        Select Case Me.ExportGridContentsToolStripComboBox.Text
            Case "Excel"
                ExportDataFromGridControl(Me.CaribouGroupsGridControl, ExportType.Excel)
            Case "CSV"
                ExportDataFromGridControl(Me.CaribouGroupsGridControl, ExportType.CSV)
        End Select
    End Sub

    Private Sub ExportPivotGridToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ExportPivotGridToolStripComboBox.SelectedIndexChanged
        'Allow user to exort the data from the pivot grid control to a file
        Select Case Me.ExportPivotGridToolStripComboBox.Text
            Case "Excel"
                ExportDataFromPivotGridControl(Me.CaribouGroupsPivotGridControl, ExportType.Excel)
            Case "CSV"
                ExportDataFromPivotGridControl(Me.CaribouGroupsPivotGridControl, ExportType.CSV)
        End Select
    End Sub
End Class