''' <summary>
''' Shows all the information about an individual caribou in one form
''' </summary>
Public Class CaribouDetailsForm

    ''' <summary>
    ''' Initialize the CaribouDetailsForm
    ''' </summary>
    Public Sub New(Optional AnimalID As String = Nothing)

        InitializeComponent()

        'If the form was initiated with an AnimalID then pull its data and set the animal selector combobox to it.
        If Not AnimalID Is Nothing Then
            LoadData(AnimalID.Trim)
            Me.AnimalIDsToolStripComboBox.SelectedText = AnimalID.Trim
        End If

    End Sub

    Private Sub LoadCaribouSelector()
        Me.AnimalIDsToolStripComboBox.Items.Clear()

        Try
            Dim Sql As String = "select distinct animalid from radiotracking union select distinct animalid from GroupMembers order by animalid"
            Dim AnimalIDsDataTable As DataTable = GetDataTableFromSQLServerDatabase(My.Settings.WRST_CaribouConnectionString, Sql)
            For Each Row In AnimalIDsDataTable.Rows
                Me.AnimalIDsToolStripComboBox.Items.Add(Row.item("AnimalID"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub LoadData(AnimalID As String)
        If Not AnimalID Is Nothing Then
            'Get all the data associated with the caribou and load it into the various grids and controls
            Try
                Dim Sql As String = "SELECT * FROM Animals WHERE AnimalID = '" & AnimalID.Trim & "'"
                Dim AnimalDataTable As DataTable = GetDataTableFromSQLServerDatabase(My.Settings.Animal_MovementConnectionString, Sql)
                Me.CaribouVGridControl.DataSource = AnimalDataTable
                SetUpVGridControl(CaribouVGridControl)
                Me.WindowState = FormWindowState.Maximized
            Catch ex As Exception
                MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
            End Try


            'Get the radiotracking data
            Try
                Dim Sql As String = "SELECT * FROM Radiotracking WHERE AnimalID = '" & AnimalID.Trim & "' ORDER BY SurveyName,SightingDate,GroupNumber"
                Dim RTDataTable As DataTable = GetDataTableFromSQLServerDatabase(My.Settings.WRST_CaribouConnectionString, Sql)
                Me.RadiotrackingGridControl.DataSource = RTDataTable
                SetUpGridControl(Me.RadiotrackingGridControl, False)

                Me.WindowState = FormWindowState.Maximized
            Catch ex As Exception
                MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
            End Try


            'Get the caribou groups data
            Dim CaribouGroupsQuery As String = "SELECT        GroupMembers.AnimalID, CaribouGroups.SightingDate, GroupMembers.ActualFrequency, GroupMembers.RecordedFrequency, CaribouGroups.SurveyName, CaribouGroups.SurveyType, 
                         CaribouGroups.SearchArea, CaribouGroups.Year, CaribouGroups.Herd, CaribouGroups.GroupNumber, CaribouGroups.Cow, CaribouGroups.Calf_Male, CaribouGroups.Calf_Female, CaribouGroups.CalfUnclassified, 
                         CaribouGroups.Calf, CaribouGroups.SmallBull, CaribouGroups.MediumBull, CaribouGroups.LargeBull, CaribouGroups.Bull, CaribouGroups.Adult, CaribouGroups.Caribou, CaribouGroups.Unknown, 
                         CaribouGroups.FrequenciesInGroup, CaribouGroups.FrequenciesCount, CaribouGroups.Lat, CaribouGroups.Lon, CaribouGroups.[In], CaribouGroups.Seen, CaribouGroups.Marked, CaribouGroups.WaypointName, 
                         CaribouGroups.SurveyComment, CaribouGroups.CrewNumber, CaribouGroups.Pilot, CaribouGroups.Observer1, CaribouGroups.Observer2, CaribouGroups.AircraftType, CaribouGroups.TailNo, 
                         CaribouGroups.[SurveyLength (hours)], CaribouGroups.IsFollowUpFlight, CaribouGroups.SpotterPlaneTailNo, CaribouGroups.SpotterPlaneType, CaribouGroups.SpotterPlanePilot, CaribouGroups.WeatherConditions, 
                         CaribouGroups.SnowConditions, GroupMembers.Comment, CaribouGroups.FlightComment, CaribouGroups.ReportReferenceCode, CaribouGroups.SourceFilename, CaribouGroups.SourceFileURL, 
                         CaribouGroups.RecordInsertedDate, CaribouGroups.RecordInsertedBy, CaribouGroups.CertificationLevel, CaribouGroups.CertificationDate, CaribouGroups.CertifiedBy, CaribouGroups.DataQualityNotes, CaribouGroups.Notes, 
                         CaribouGroups.Park, GroupMembers.DeploymentID, CaribouGroups.EID, GroupMembers.GroupMemberID
FROM            CaribouGroups INNER JOIN
                         GroupMembers ON CaribouGroups.EID = GroupMembers.EID
WHERE        (GroupMembers.AnimalID = '" & AnimalID & "')
ORDER BY GroupMembers.AnimalID, CaribouGroups.SightingDate, GroupMembers.GroupMemberID"

            Try
                Dim CGDataTable As DataTable = GetDataTableFromSQLServerDatabase(My.Settings.WRST_CaribouConnectionString, CaribouGroupsQuery)
                Me.CaribouGroupsGridControl.DataSource = CGDataTable
                SetUpGridControl(Me.CaribouGroupsGridControl, False)
                Me.WindowState = FormWindowState.Maximized
            Catch ex As Exception
                MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
            End Try

            Dim DeploymentsQuery As String = "SELECT        a.ProjectId, a.AnimalId, a.Species, a.Gender, d.DeploymentDate, a.MortalityDate, d.RetrievalDate, c.DisposalDate, a.GroupName, d.CollarManufacturer, c.CollarModel, c.Manager, c.Owner, c.SerialNumber, c.Frequency, 
                         c.HasGps, c.Notes, a.Description, c.CollarId, d.DeploymentId
FROM            Animals AS a INNER JOIN
                         CollarDeployments AS d ON a.ProjectId = d.ProjectId AND a.AnimalId = d.AnimalId INNER JOIN
                         Collars AS c ON d.CollarManufacturer = c.CollarManufacturer AND d.CollarId = c.CollarId
WHERE        (a.AnimalId = '" & AnimalID & "')"
            Try
                Dim DeploymentsDataTable As DataTable = GetDataTableFromSQLServerDatabase(My.Settings.Animal_MovementConnectionString, DeploymentsQuery)
                Me.CollarDeploymentsGridControl.DataSource = DeploymentsDataTable
                SetUpGridControl(Me.CollarDeploymentsGridControl, False)
                Me.WindowState = FormWindowState.Maximized
            Catch ex As Exception
                MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
            End Try


        Else
            MsgBox("AnimalID cannot be Nothing", MsgBoxStyle.OkOnly, "Error")
        End If

    End Sub

    Private Sub CaribouDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCaribouSelector()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AnimalIDsToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AnimalIDsToolStripComboBox.SelectedIndexChanged
        Dim AnimalID As String = Me.AnimalIDsToolStripComboBox.Text
        'Me.AnimalIDLabel.Text = AnimalID
        LoadData(AnimalID)
    End Sub
End Class