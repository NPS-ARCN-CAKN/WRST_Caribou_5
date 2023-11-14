Imports System.Data.SqlClient
Imports System.IO
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
    ''' 'Returns the equivalent ProjectID from the Animal_Movement database for the submitted WRST_Caribou Herd attribute.
    ''' </summary>
    ''' <param name="Herd">Caribou herd (Chisana, Mentasta, Denali) in the WRST_Caribou database.</param>
    ''' <returns>ProjectID (ChisanaCH, WRST_Caribou, DENA_Caribou. See Animal_Movement.Projects table).</returns>
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

    ''' <summary>
    ''' Runs SQL queries within a database transaction and reports the results.
    ''' </summary>
    ''' <param name="Sql">SQL script to run. String.</param>
    ''' <param name="DatabaseConnectionString">Database ConnectionString. String.</param>
    Public Sub ExecuteNonQuery(Sql As String, DatabaseConnectionString As String)

        'Create database connection and command objects for the database and SQL
        Dim MySqlTransaction As SqlTransaction
        Dim MySqlConnection As New SqlConnection(DatabaseConnectionString)
        Dim MySqlCommand As New SqlCommand(Sql, MySqlConnection)

        Try
            'Open a database connection
            MySqlConnection.Open()

            'Build a transaction
            MySqlTransaction = MySqlConnection.BeginTransaction()

            Try
                'Run the SQL script
                MySqlCommand.Transaction = MySqlTransaction
                Dim RowsAffected As Integer = MySqlCommand.ExecuteNonQuery()
                MySqlTransaction.Commit()
                MsgBox("Database edits succeeeded. " & RowsAffected & " rows were affected.")
            Catch ex As Exception

                'The transaction failed. Roll back the changes and report.
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
            Dim ProjectID As String = GetProjectIDFromHerd(Herd)

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


    ''' <summary>
    ''' Converts a DataTable to a delimiter separated values text block.
    ''' </summary>
    ''' <param name="DT">DataTable to convert. DataTable</param>
    ''' <param name="Delimiter">Values separator. String.</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function DataTableToCSV(DT As DataTable, Optional Delimiter As String = "|") As String
        Dim CSV As String = "" 'Return string

        Try

            'Make sure the delimiter is clean
            Delimiter = Delimiter.Trim

            'If we have a DataTable
            If Not DT Is Nothing Then

                'Output the column names as a header
                For Each Column As DataColumn In DT.Columns
                    CSV = CSV & Column.ColumnName & Delimiter
                Next

                'Trim the trailing delimiter
                If CSV.Length > 0 Then
                    CSV = CSV.Substring(0, CSV.Trim.Length - Delimiter.Length) & vbNewLine
                End If

                'Output the contents of each DataRow
                If DT.Rows.Count > 0 Then
                    For Each Row As DataRow In DT.Rows
                        For Each Column As DataColumn In DT.Columns
                            CSV = CSV & Row.Item(Column.ColumnName) & Delimiter
                        Next
                        CSV = CSV.Substring(0, CSV.Trim.Length - 1) & vbNewLine
                    Next
                End If
            Else
                CSV = "Submitted DataTable is nothing."
            End If
        Catch ex As Exception
            CSV = ex.Message
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try
        Return CSV
    End Function

    ''' <summary>
    ''' Converts the submitted CSV text file to a DataTable using a .NET custom function. This overload may give different results from the OLEDB method.
    ''' </summary>
    ''' <param name="CSVFileInfo"></param>
    ''' <returns></returns>
    Public Function GetDataTableFromCSV(CSVFileInfo As FileInfo) As DataTable
        Dim ReturnDataTable As New DataTable
        Dim CSVStringDataTable = New DataTable
        Try

            'Read the CSV file into a String
            Dim CSVStreamReader As New StreamReader(CSVFileInfo.FullName)
            If Not CSVStreamReader Is Nothing Then
                Dim CSV As String = CSVStreamReader.ReadToEnd
                CSVStreamReader.Close()
                CSVStreamReader.Dispose()

                'Read the CSV into lines and then an array
                Dim CSVLines As String() = CSV.Split(ControlChars.Lf)
                Dim ColumnsArray As String() = CSVLines(0).Split(","c)

                'The first thing we need to do is read all the CSV data into a DataTable.
                'Treat all data as String until we can figure out what data type each column actually is
                'Add columns to the data table based on the first row of the csv file
                For Each ColumnName As String In ColumnsArray
                    CSVStringDataTable.Columns.Add(New DataColumn(ColumnName))
                Next

                'Add the CSV data to new data rows and add them to the CSV string data table
                Dim RowIndex As Integer = 0
                For Each CSVLine As String In CSVLines

                    'Don't add any blank rows to the data table
                    If CSVLine.Trim <> "" Then

                        'Avoid duplicating the first row containing the column names
                        If RowIndex > 0 Then

                            'Create a new data row 
                            Dim NewRow As DataRow = CSVStringDataTable.NewRow

                            Dim CSVFinalLine As String = CSVLine.Replace(Convert.ToString(ControlChars.Cr), "")
                            NewRow.ItemArray = CSVFinalLine.Split(","c)
                            CSVStringDataTable.Rows.Add(NewRow)
                        End If

                    End If
                    RowIndex = RowIndex + 1
                Next

                'Loop through each column in the CSV string data table
                For Each Col As DataColumn In CSVStringDataTable.Columns
                    Dim NullCounter As Integer = 0
                    'Dim BlankCounter As Integer = 0

                    Dim DateCounter As Integer = 0
                    Dim IntegerCounter As Integer = 0
                    Dim BooleanCounter As Integer = 0
                    Dim BitCounter As Integer = 0
                    'Dim DecimalCounter As Integer = 0
                    Dim DoubleCounter As Integer = 0
                    'Dim SingleCounter As Integer = 0
                    Dim TextCounter As Integer = 0

                    'Loop through the columns
                    If Not Col Is Nothing Then


                        'And then loop through each row
                        'Dim i As Integer = 0
                        For Each Row As DataRow In CSVStringDataTable.Rows
                            If Not Row Is Nothing Then

                                'Determine if the row is null
                                If Not IsDBNull(Row.Item(Col.ColumnName)) Then

                                    'Get the cell value
                                    Dim CellValue As String = Row.Item(Col.ColumnName).ToString.Trim

                                    'Determine if the cell is blank
                                    If CellValue.Length > 0 Then

                                        'Determine what data type CellValue is
                                        If ValueIsDate(CellValue) = True Then
                                            'It's a Date. Increment the DateCounter
                                            DateCounter = DateCounter + 1

                                        ElseIf IsNumeric(CellValue) = True Then
                                            'It's a number

                                            'Determine if the value is an integer.
                                            If ValueIsInteger(CellValue) Then
                                                IntegerCounter = IntegerCounter + 1

                                                'Determine if the value is Bit (boolean).
                                                If CellValue = 0 Or CellValue = 1 Then BitCounter = BitCounter + 1
                                            Else
                                                'It must be a Double or similar (Decimal,Single, etc.). Treat as Double.
                                                DoubleCounter = DoubleCounter + 1
                                            End If
                                        Else

                                            'It's a String. See if it's boolean.
                                            If CellValue.ToLower = "True" Or CellValue.ToLower = "False" Or CellValue.ToLower = "t" Or CellValue.ToLower = "f" Or CellValue.ToLower = "y" Or CellValue.ToLower = "n" Or CellValue.ToLower = "yes" Or CellValue.ToLower = "no" Then
                                                'Value is boolean text.
                                                BooleanCounter = BooleanCounter + 1
                                            Else
                                                'Value is non-boolean text
                                                TextCounter = TextCounter + 1
                                            End If

                                        End If
                                    Else

                                        'Cell is Blank
                                        NullCounter = NullCounter + 1

                                    End If
                                Else
                                    'Cell is DBNull
                                    NullCounter = NullCounter + 1

                                End If

                            End If
                        Next
                    End If


                    'Add Columns to ReturnDataTable based on what kind of rows we have, as determined above
                    If TextCounter > 0 And CSVStringDataTable.Rows.Count - NullCounter = TextCounter Then

                        'The row has at least one text entry, make the added DataColumn text
                        ReturnDataTable.Columns.Add(Col.ColumnName, GetType(String))

                    ElseIf DateCounter > 0 And CSVStringDataTable.Rows.Count - NullCounter = DateCounter Then

                        'All the rows are Dates. 
                        ReturnDataTable.Columns.Add(Col.ColumnName, GetType(Date))

                    ElseIf IntegerCounter > 0 And CSVStringDataTable.Rows.Count - NullCounter = IntegerCounter And BitCounter <> IntegerCounter Then

                        'All the rows are integers, but not completely Bit
                        ReturnDataTable.Columns.Add(Col.ColumnName, GetType(Integer))

                    ElseIf IntegerCounter > 0 And DoubleCounter = 0 And CSVStringDataTable.Rows.Count - NullCounter = IntegerCounter And BitCounter = IntegerCounter Then

                        'All the rows are Integers and Bit
                        ReturnDataTable.Columns.Add(Col.ColumnName, GetType(Integer))

                    ElseIf DoubleCounter > 0 And CSVStringDataTable.Rows.Count - NullCounter - IntegerCounter = DoubleCounter Then

                        'All the rows are Double
                        ReturnDataTable.Columns.Add(Col.ColumnName, GetType(Double))

                    ElseIf BooleanCounter > 0 And CSVStringDataTable.Rows.Count - NullCounter = BooleanCounter Then

                        'All the rows were boolean.
                        ReturnDataTable.Columns.Add(Col.ColumnName, GetType(Boolean))

                    Else

                        'All other possibilities eliminated, data type will be String.
                        ReturnDataTable.Columns.Add(Col.ColumnName, GetType(String))
                    End If

                Next

                'Fix all the text booleans
                'Convert all the text booleans to True/False
                For Each Col As DataColumn In CSVStringDataTable.Columns
                    For Each CSVRow As DataRow In CSVStringDataTable.Rows
                        If CSVRow.Item(Col.ColumnName).ToString.Trim.ToLower = "True" Or CSVRow.Item(Col.ColumnName).ToString.Trim.ToLower = "t" Or CSVRow.Item(Col.ColumnName).ToString.Trim.ToLower = "y" Or CSVRow.Item(Col.ColumnName).ToString.Trim.ToLower = "yes" Then
                            CSVRow.Item(Col.ColumnName) = True
                        ElseIf CSVRow.Item(Col.ColumnName).ToString.Trim.ToLower = "False" Or CSVRow.Item(Col.ColumnName).ToString.Trim.ToLower = "f" Or CSVRow.Item(Col.ColumnName).ToString.Trim.ToLower = "n" Or CSVRow.Item(Col.ColumnName).ToString.Trim.ToLower = "no" Then
                            CSVRow.Item(Col.ColumnName) = False
                        End If
                    Next
                Next



                'Now load the data from the all String DataTable into ReturnDataTable with the corrected data types
                Dim i As Integer = 0
                For Each Row As DataRow In CSVStringDataTable.Rows
                    Dim NewRow As DataRow = ReturnDataTable.NewRow
                    For Each Col As DataColumn In CSVStringDataTable.Columns
                        If IsDBNull(Row.Item(Col.ColumnName)) = False Then
                            If Row.Item(Col.ColumnName).ToString.Trim.Length > 0 Then
                                NewRow.Item(Col.ColumnName) = Row.Item(Col.ColumnName)
                            End If
                        End If
                    Next
                    i = i + 1
                    ReturnDataTable.Rows.Add(NewRow)
                Next
            Else
                MsgBox("There was a problem opening the CSV file. Canceled.")
            End If

        Catch SAEx As ArgumentException
            MsgBox(SAEx.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")" & vbNewLine & vbNewLine & "The most common cause of this error is a datum containing one or more commas. The comma separated values parser cannot parse data containing commas. Remove any commas from the data And Try again.")
        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")", MsgBoxStyle.OkOnly, "Exception")
        End Try

        Return ReturnDataTable ' ReturnDataTable
    End Function


    ''' <summary>
    ''' Returns true if String Value is a Date, otherwise False.
    ''' </summary>
    ''' <param name="Value">Value to evaluate. String.</param>
    ''' <returns></returns>
    Public Function ValueIsDate(Value As String) As Boolean
        If Not Value Is Nothing Then
            If IsNumeric(Value) = False And IsDate(Value) = True Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Returns true if String Value is Bit (0/1), otherwise False.
    ''' </summary>
    ''' <param name="Value">Value to evaluate. String.</param>
    ''' <returns></returns>
    Public Function ValueIsBit(Value As String) As Boolean
        If Not Value Is Nothing Then
            'Test for integer, and then for integer variant of boolean (1 or 0)
            If IsNumeric(Value) Then
                If Value = 0 Or Value = 1 Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Returns true if String Value is an Integer, otherwise False.
    ''' </summary>
    ''' <param name="Value">Value to evaluate. String.</param>
    ''' <returns></returns>
    Public Function ValueIsInteger(Value As String) As Boolean
        If Not Value Is Nothing Then
            'Test for integer, and then for integer variant of boolean (1 or 0)
            If Int16.TryParse(Value, New Integer) = True Or Int32.TryParse(Value, New Integer) = True Or Int64.TryParse(Value, New Integer) = True Or UInt16.TryParse(Value, New Integer) = True Or UInt32.TryParse(Value, New Integer) = True Or UInt64.TryParse(Value, New Integer) = True Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function



    ''' <summary>
    ''' Returns true if String Value is a Double, otherwise False.
    ''' </summary>
    ''' <param name="Value">Value to evaluate. String.</param>
    ''' <returns></returns>
    Public Function ValueIsDouble(Value As String) As Boolean
        If Not Value Is Nothing Then
            'Test for Double
            If Double.TryParse(Value, New Double) = True Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

End Module
