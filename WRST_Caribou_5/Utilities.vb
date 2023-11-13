Imports System.Data.SqlClient
Imports DevExpress.DataProcessing.InMemoryDataProcessor
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows

Module Utilities

    ''' <summary>
    ''' Queries the database specified by ConnectionString using the supplied Sql and returns a DataTable.
    ''' </summary>
    ''' <param name="ConnectionString">ConnectionString to the desired database. String.</param>
    ''' <param name="Sql">SQL query to submit to the database. String.</param>
    ''' <returns>DataTable.</returns>
    Public Function GetDataTableFromSQLServerDatabase(ConnectionString As String, Sql As String) As DataTable
        Dim MyDataTable As New DataTable
        Try
            'make a SqlConnection using the supplied ConnectionString 
            Dim MySqlConnection As New SqlConnection(ConnectionString)
            Using MySqlConnection
                'make a query using the supplied Sql
                Dim MySqlCommand As SqlCommand = New SqlCommand(Sql, MySqlConnection)

                'open the connection
                MySqlConnection.Open()
                Using MySqlDataAdapter As New SqlDataAdapter(Sql, MySqlConnection)
                    MySqlDataAdapter.Fill(MyDataTable)
                End Using
                'create a DataReader and execute the SqlCommand
                'Dim MyDataReader As SqlDataReader = MySqlCommand.ExecuteReader()

                'load the reader into the datatable
                'MyDataTable.Load(MyDataReader)

                'clean up
                'MyDataReader.Close()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & "). Sql = " & Sql)
        End Try
        Return MyDataTable
    End Function

    ''' <summary>
    ''' Sets up a GridControl the way I like it
    ''' </summary>
    ''' <param name="GC">GridControl to configure. DevExpress GridControl.</param>
    Public Sub SetUpGridControl(GC As GridControl, AllowEdits As Boolean)
        Try
            GC.UseEmbeddedNavigator = True
            Dim GV As GridView = TryCast(GC.MainView, GridView)
            If Not GV Is Nothing Then
                GV.OptionsBehavior.AllowAddRows = IIf(AllowEdits = True, True, False)
                GV.OptionsBehavior.AllowDeleteRows = IIf(AllowEdits = True, True, False)
                GV.OptionsBehavior.ReadOnly = IIf(AllowEdits = True, False, True)
                GV.BestFitColumns(False) 'Important: GridControl will try to pack columns in the view if set to True 
                'GV.OptionsView.BestFitMode = GridBestFitMode.Fast
                GV.OptionsView.ColumnAutoWidth = False
                GV.OptionsView.ShowFooter = True
                GV.OptionsDetail.EnableMasterViewMode = False 'True to show sub-tables
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ").")
        End Try
    End Sub

    ''' <summary>
    ''' Sets up a VGridControl the way I like it.
    ''' </summary>
    ''' <param name="VGC">VGridControl to set up.</param>
    Public Sub SetUpVGridControl(VGC As VGridControl)
        Try
            'Format each row of the control
            For Each VGridBaseRow As BaseRow In VGC.Rows
                With VGridBaseRow.AppearanceCell.TextOptions
                    .HAlignment = DevExpress.Utils.HorzAlignment.Near
                    .VAlignment = DevExpress.Utils.VertAlignment.Top
                    .WordWrap = True
                End With
            Next
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    ''' <summary>
    ''' Sets up a PivotGridControl
    ''' </summary>
    ''' <param name="PGC">PivotGridControl to set up.</param>
    Public Sub SetUpPivotGridControl(PGC As PivotGridControl)
        Try
            With PGC
                .BestFit()
                .BestFitColumnArea()
                .BestFitDataHeaders(True)
                .BestFitRowArea()
                .OptionsBehavior.BestFitMode = PivotGridBestFitMode.FieldValue
                .OptionsMenu.EnableFieldValueMenu = True
                .OptionsMenu.EnableFormatRulesMenu = True
                .OptionsMenu.EnableHeaderAreaMenu = True
                .Text = "Pivot grid text"

            End With
            'Allow the user to change the summary they get; sum, avg, etc.
            For Each PGField As PivotGridField In PGC.Fields
                With PGField
                    .Options.AllowRunTimeSummaryChange = True
                    .BestFit()
                End With
            Next
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    ''' <summary>
    ''' GridControl data export formats.
    ''' </summary>
    Public Enum ExportType
        Excel
        CSV
    End Enum

    ''' <summary>
    ''' Exports the data from GridControl to a file of type ExportType.
    ''' </summary>
    ''' <param name="GridControl"></param>
    ''' <param name="ExportType"></param>
    Public Sub ExportDataFromGridControl(GridControl As GridControl, ExportType As ExportType)
        'Export the contents of the GridControl
        Try
            If ExportType = ExportType.Excel Then
                Dim FileFilter As String = "Excel (*.xlsx)|*.xlsx"

                'Open a save file dialog to allow the user to save the file someplace
                Dim SFD As New SaveFileDialog
                With SFD
                    .AddExtension = True
                    .DefaultExt = "xlsx"
                    .Filter = FileFilter
                    .AddExtension = True
                End With

                'Show the dialog
                If SFD.ShowDialog = DialogResult.OK Then

                    GridControl.ExportToXlsx(SFD.FileName)
                    If MsgBox("Open the file?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Process.Start(SFD.FileName)
                    End If
                End If

            ElseIf ExportType = ExportType.CSV Then
                Dim FileFilter As String = "Comma Separated Values text files (*.csv)|*.csv"

                'Open a save file dialog to allow the user to save the file someplace
                Dim SFD As New SaveFileDialog
                With SFD
                    .AddExtension = True
                    .DefaultExt = ".csv"
                    .Filter = FileFilter
                    .AddExtension = True
                End With

                'Show the dialog
                If SFD.ShowDialog = DialogResult.OK Then

                    GridControl.ExportToCsv(SFD.FileName)
                    If MsgBox("Open the file?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Process.Start(SFD.FileName)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    ''' <summary>
    ''' Exports the data from PivotGridControl to a file of type ExportType.
    ''' </summary>
    ''' <param name="PivotGridControl"></param>
    ''' <param name="ExportType"></param>
    Public Sub ExportDataFromPivotGridControl(PivotGridControl As PivotGridControl, ExportType As ExportType)
        'Export the contents of the PivotGridControl
        Try
            If ExportType = ExportType.Excel Then
                Dim FileFilter As String = "Excel (*.xlsx)|*.xlsx"

                'Open a save file dialog to allow the user to save the file someplace
                Dim SFD As New SaveFileDialog
                With SFD
                    .AddExtension = True
                    .DefaultExt = "xlsx"
                    .Filter = FileFilter
                    .AddExtension = True
                End With

                'Show the dialog
                If SFD.ShowDialog = DialogResult.OK Then

                    PivotGridControl.ExportToXlsx(SFD.FileName)
                    If MsgBox("Open the file?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Process.Start(SFD.FileName)
                    End If
                End If

            ElseIf ExportType = ExportType.CSV Then
                Dim FileFilter As String = "Comma Separated Values text files (*.csv)|*.csv"

                'Open a save file dialog to allow the user to save the file someplace
                Dim SFD As New SaveFileDialog
                With SFD
                    .AddExtension = True
                    .DefaultExt = ".csv"
                    .Filter = FileFilter
                    .AddExtension = True
                End With

                'Show the dialog
                If SFD.ShowDialog = DialogResult.OK Then

                    PivotGridControl.ExportToCsv(SFD.FileName)
                    If MsgBox("Open the file?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Process.Start(SFD.FileName)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    ''' <summary>
    ''' Returns the value of the current row of BS with the column name ColumnName.
    ''' </summary>
    ''' <param name="BS">BindingSource to interrogate. BindingSource.</param>
    ''' <param name="ColumnName">Name of the column to return the value of.</param>
    ''' <returns></returns>
    Public Function GetCurrentValue(BS As BindingSource, ColumnName As String) As String
        Dim CurrentValue As String = ""
        Try
            If BS IsNot Nothing Then
                If BS.Current IsNot Nothing Then
                    Dim DR As DataRowView = BS.Current
                    If Not DR Is Nothing Then
                        If Not IsDBNull(DR.Item(ColumnName)) Then
                            CurrentValue = DR.Item(ColumnName).ToString.Trim
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
        Return CurrentValue
    End Function

    ''' <summary>
    ''' 'The WRST_Caribou database uses Herd where Animal_Movement database uses ProjectID so we need to translate one to the other
    ''' </summary>
    ''' <param name="Herd"></param>
    ''' <returns></returns>
    Public Function GetProjectIDFromHerd(Herd As String) As String
        Dim ProjectID As String = ""
        Try
            If Herd = "Chisana" Then ProjectID = "ChisanaCH"
            If Herd = "Mentasta" Then ProjectID = "WRST_Caribou"
            If Herd = "Denali" Then ProjectID = "DENA_Caribou"
        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try
        Return ProjectID
    End Function

    Public Sub ExecuteNonQuery(Sql As String, DatabaseConnectionString As String)
        Dim MySqlTransaction As SqlTransaction
        Dim MySqlConnection As New SqlConnection(DatabaseConnectionString)
        Dim MySqlCommand As New SqlCommand(Sql, MySqlConnection)

        Try
            MySqlConnection.Open()
            MySqlTransaction = MySqlConnection.BeginTransaction()
            Try
                MySqlCommand.Transaction = MySqlTransaction
                Dim RowsAffected As Integer = MySqlCommand.ExecuteNonQuery()
                MySqlTransaction.Commit()
                MsgBox("Database edits succeeeded. " & RowsAffected & " rows were affected.")
            Catch ex As Exception
                MySqlTransaction.Rollback()
                MsgBox("Error: Database edits failed. The database transaction has been rolled back. " & ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
            End Try
        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try
    End Sub

    ''' <summary>
    ''' Returns a DataTable of Animal_Movement GPS collar deployments for a given Herd, Frequency and SightingDate
    ''' </summary>
    ''' <param name="Herd">Caribou herd. String.</param>
    ''' <param name="Frequency">Frequency. Double.</param>
    ''' <param name="SightingDate">Sighting date. Date.</param>
    ''' <returns></returns>
    Public Function GetDataTableOfCollarDeploymentsForAHerdFrequencyAndSightingDate(Herd As String, Frequency As Double, SightingDate As Date) As DataTable
        Dim CollarDeploymentsDatatable As New DataTable
        Try
            Dim ProjectID As String = GetProjectIDFromHerd(herd)

            'Get the details of the collar deployment for use below from the Animal_Movement database based on the frequency, herd and sighting date
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

            'Get a DataTable containing the collar deployment for the frequency above from Animal_Movement
            CollarDeploymentsDatatable = GetDataTableFromSQLServerDatabase(My.Settings.Animal_MovementConnectionString, Sql)

        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try
        Return CollarDeploymentsDatatable
    End Function

End Module
