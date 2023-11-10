Imports System.Data.SqlClient
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
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
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

            ElseIf exporttype = ExportType.CSV Then
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

End Module
