﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCaribouGroupsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditCaribouGroupsForm))
        Me.WRST_CaribouDataSet = New WRST_Caribou_5.WRST_CaribouDataSet()
        Me.CaribouGroupsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CaribouGroupsTableAdapter = New WRST_Caribou_5.WRST_CaribouDataSetTableAdapters.CaribouGroupsTableAdapter()
        Me.TableAdapterManager = New WRST_Caribou_5.WRST_CaribouDataSetTableAdapters.TableAdapterManager()
        Me.GroupMembersTableAdapter = New WRST_Caribou_5.WRST_CaribouDataSetTableAdapters.GroupMembersTableAdapter()
        Me.CaribouGroupsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupMembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupMembersDataGridView = New System.Windows.Forms.DataGridView()
        Me.AnimalIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MainSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.CaribouGroupsDataGridView = New System.Windows.Forms.DataGridView()
        Me.SurveyNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HerdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurveyTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SearchAreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SightingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CowDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalfMaleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalfFemaleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalfUnclassifiedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmallBullDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MediumBullDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LargeBullDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BullDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdultDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaribouDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnknownDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FrequenciesInGroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FrequenciesCountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SeenDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MarkedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WaypointNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurveyCommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrewNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PilotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observer1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observer2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AircraftTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TailNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurveyLengthhoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsFollowUpFlightDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SpotterPlaneTailNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpotterPlaneTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpotterPlanePilotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeatherConditionsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SnowConditionsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlightCommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportReferenceCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SourceFilenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SourceFileURLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecordInsertedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecordInsertedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CertificationLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CertificationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CertifiedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataQualityNotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaribouGroupContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReconcileFrequenciesForThisGroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaribouGroupsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.FilterToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.FilterToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ApplyFilterToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SortToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SortToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ApplySortToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupMembersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.WRST_CaribouDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaribouGroupsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaribouGroupsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CaribouGroupsBindingNavigator.SuspendLayout()
        CType(Me.GroupMembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupMembersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplitContainer.Panel1.SuspendLayout()
        Me.MainSplitContainer.Panel2.SuspendLayout()
        Me.MainSplitContainer.SuspendLayout()
        CType(Me.CaribouGroupsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CaribouGroupContextMenuStrip.SuspendLayout()
        Me.CaribouGroupsToolStrip.SuspendLayout()
        CType(Me.GroupMembersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupMembersBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'WRST_CaribouDataSet
        '
        Me.WRST_CaribouDataSet.DataSetName = "WRST_CaribouDataSet"
        Me.WRST_CaribouDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CaribouGroupsBindingSource
        '
        Me.CaribouGroupsBindingSource.DataMember = "CaribouGroups"
        Me.CaribouGroupsBindingSource.DataSource = Me.WRST_CaribouDataSet
        '
        'CaribouGroupsTableAdapter
        '
        Me.CaribouGroupsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CaribouGroupsTableAdapter = Me.CaribouGroupsTableAdapter
        Me.TableAdapterManager.GroupMembersTableAdapter = Me.GroupMembersTableAdapter
        Me.TableAdapterManager.RadiotrackingTableAdapter = Nothing
        Me.TableAdapterManager.SurveysTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WRST_Caribou_5.WRST_CaribouDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupMembersTableAdapter
        '
        Me.GroupMembersTableAdapter.ClearBeforeFill = True
        '
        'CaribouGroupsBindingNavigator
        '
        Me.CaribouGroupsBindingNavigator.AddNewItem = Nothing
        Me.CaribouGroupsBindingNavigator.BindingSource = Me.CaribouGroupsBindingSource
        Me.CaribouGroupsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CaribouGroupsBindingNavigator.DeleteItem = Nothing
        Me.CaribouGroupsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CaribouGroupsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.CaribouGroupsBindingNavigator.Location = New System.Drawing.Point(0, 446)
        Me.CaribouGroupsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CaribouGroupsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CaribouGroupsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CaribouGroupsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CaribouGroupsBindingNavigator.Name = "CaribouGroupsBindingNavigator"
        Me.CaribouGroupsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CaribouGroupsBindingNavigator.Size = New System.Drawing.Size(1181, 25)
        Me.CaribouGroupsBindingNavigator.TabIndex = 0
        Me.CaribouGroupsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'GroupMembersBindingSource
        '
        Me.GroupMembersBindingSource.DataMember = "FK_GroupMembers_CaribouGroups"
        Me.GroupMembersBindingSource.DataSource = Me.CaribouGroupsBindingSource
        '
        'GroupMembersDataGridView
        '
        Me.GroupMembersDataGridView.AutoGenerateColumns = False
        Me.GroupMembersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GroupMembersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnimalIDDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn59})
        Me.GroupMembersDataGridView.DataSource = Me.GroupMembersBindingSource
        Me.GroupMembersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupMembersDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.GroupMembersDataGridView.Name = "GroupMembersDataGridView"
        Me.GroupMembersDataGridView.Size = New System.Drawing.Size(1181, 86)
        Me.GroupMembersDataGridView.TabIndex = 2
        '
        'AnimalIDDataGridViewTextBoxColumn
        '
        Me.AnimalIDDataGridViewTextBoxColumn.DataPropertyName = "AnimalID"
        Me.AnimalIDDataGridViewTextBoxColumn.HeaderText = "AnimalID"
        Me.AnimalIDDataGridViewTextBoxColumn.Name = "AnimalIDDataGridViewTextBoxColumn"
        Me.AnimalIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "RecordedFrequency"
        Me.DataGridViewTextBoxColumn51.HeaderText = "RecordedFrequency"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "ActualFrequency"
        Me.DataGridViewTextBoxColumn52.HeaderText = "ActualFrequency"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "Comment"
        Me.DataGridViewTextBoxColumn54.HeaderText = "Comment"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "RecordInsertedDate"
        Me.DataGridViewTextBoxColumn55.HeaderText = "RecordInsertedDate"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "RecordInsertedBy"
        Me.DataGridViewTextBoxColumn56.HeaderText = "RecordInsertedBy"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "EID"
        Me.DataGridViewTextBoxColumn57.HeaderText = "EID"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "DeploymentID"
        Me.DataGridViewTextBoxColumn58.HeaderText = "DeploymentID"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "GroupMemberID"
        Me.DataGridViewTextBoxColumn59.HeaderText = "GroupMemberID"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        '
        'MainSplitContainer
        '
        Me.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.MainSplitContainer.Name = "MainSplitContainer"
        Me.MainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'MainSplitContainer.Panel1
        '
        Me.MainSplitContainer.Panel1.Controls.Add(Me.CaribouGroupsDataGridView)
        Me.MainSplitContainer.Panel1.Controls.Add(Me.CaribouGroupsBindingNavigator)
        Me.MainSplitContainer.Panel1.Controls.Add(Me.CaribouGroupsToolStrip)
        '
        'MainSplitContainer.Panel2
        '
        Me.MainSplitContainer.Panel2.Controls.Add(Me.GroupMembersDataGridView)
        Me.MainSplitContainer.Panel2.Controls.Add(Me.GroupMembersBindingNavigator)
        Me.MainSplitContainer.Size = New System.Drawing.Size(1181, 586)
        Me.MainSplitContainer.SplitterDistance = 471
        Me.MainSplitContainer.TabIndex = 3
        '
        'CaribouGroupsDataGridView
        '
        Me.CaribouGroupsDataGridView.AllowUserToOrderColumns = True
        Me.CaribouGroupsDataGridView.AutoGenerateColumns = False
        Me.CaribouGroupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CaribouGroupsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SurveyNameDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.HerdDataGridViewTextBoxColumn, Me.SurveyTypeDataGridViewTextBoxColumn, Me.SearchAreaDataGridViewTextBoxColumn, Me.GroupNumberDataGridViewTextBoxColumn, Me.SightingDateDataGridViewTextBoxColumn, Me.CowDataGridViewTextBoxColumn, Me.CalfMaleDataGridViewTextBoxColumn, Me.CalfFemaleDataGridViewTextBoxColumn, Me.CalfUnclassifiedDataGridViewTextBoxColumn, Me.CalfDataGridViewTextBoxColumn, Me.SmallBullDataGridViewTextBoxColumn, Me.MediumBullDataGridViewTextBoxColumn, Me.LargeBullDataGridViewTextBoxColumn, Me.BullDataGridViewTextBoxColumn, Me.AdultDataGridViewTextBoxColumn, Me.CaribouDataGridViewTextBoxColumn, Me.UnknownDataGridViewTextBoxColumn, Me.FrequenciesInGroupDataGridViewTextBoxColumn, Me.FrequenciesCountDataGridViewTextBoxColumn, Me.LatDataGridViewTextBoxColumn, Me.LonDataGridViewTextBoxColumn, Me.InDataGridViewCheckBoxColumn, Me.SeenDataGridViewCheckBoxColumn, Me.MarkedDataGridViewCheckBoxColumn, Me.WaypointNameDataGridViewTextBoxColumn, Me.SurveyCommentDataGridViewTextBoxColumn, Me.CrewNumberDataGridViewTextBoxColumn, Me.PilotDataGridViewTextBoxColumn, Me.Observer1DataGridViewTextBoxColumn, Me.Observer2DataGridViewTextBoxColumn, Me.AircraftTypeDataGridViewTextBoxColumn, Me.TailNoDataGridViewTextBoxColumn, Me.SurveyLengthhoursDataGridViewTextBoxColumn, Me.IsFollowUpFlightDataGridViewCheckBoxColumn, Me.SpotterPlaneTailNoDataGridViewTextBoxColumn, Me.SpotterPlaneTypeDataGridViewTextBoxColumn, Me.SpotterPlanePilotDataGridViewTextBoxColumn, Me.WeatherConditionsDataGridViewTextBoxColumn, Me.SnowConditionsDataGridViewTextBoxColumn, Me.FlightCommentDataGridViewTextBoxColumn, Me.ReportReferenceCodeDataGridViewTextBoxColumn, Me.SourceFilenameDataGridViewTextBoxColumn, Me.SourceFileURLDataGridViewTextBoxColumn, Me.RecordInsertedDateDataGridViewTextBoxColumn, Me.RecordInsertedByDataGridViewTextBoxColumn, Me.CertificationLevelDataGridViewTextBoxColumn, Me.CertificationDateDataGridViewTextBoxColumn, Me.CertifiedByDataGridViewTextBoxColumn, Me.DataQualityNotesDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn, Me.ParkDataGridViewTextBoxColumn, Me.EIDDataGridViewTextBoxColumn})
        Me.CaribouGroupsDataGridView.ContextMenuStrip = Me.CaribouGroupContextMenuStrip
        Me.CaribouGroupsDataGridView.DataSource = Me.CaribouGroupsBindingSource
        Me.CaribouGroupsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CaribouGroupsDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.CaribouGroupsDataGridView.Name = "CaribouGroupsDataGridView"
        Me.CaribouGroupsDataGridView.Size = New System.Drawing.Size(1181, 421)
        Me.CaribouGroupsDataGridView.TabIndex = 0
        '
        'SurveyNameDataGridViewTextBoxColumn
        '
        Me.SurveyNameDataGridViewTextBoxColumn.DataPropertyName = "SurveyName"
        Me.SurveyNameDataGridViewTextBoxColumn.HeaderText = "SurveyName"
        Me.SurveyNameDataGridViewTextBoxColumn.Name = "SurveyNameDataGridViewTextBoxColumn"
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        '
        'HerdDataGridViewTextBoxColumn
        '
        Me.HerdDataGridViewTextBoxColumn.DataPropertyName = "Herd"
        Me.HerdDataGridViewTextBoxColumn.HeaderText = "Herd"
        Me.HerdDataGridViewTextBoxColumn.Name = "HerdDataGridViewTextBoxColumn"
        '
        'SurveyTypeDataGridViewTextBoxColumn
        '
        Me.SurveyTypeDataGridViewTextBoxColumn.DataPropertyName = "SurveyType"
        Me.SurveyTypeDataGridViewTextBoxColumn.HeaderText = "SurveyType"
        Me.SurveyTypeDataGridViewTextBoxColumn.Name = "SurveyTypeDataGridViewTextBoxColumn"
        '
        'SearchAreaDataGridViewTextBoxColumn
        '
        Me.SearchAreaDataGridViewTextBoxColumn.DataPropertyName = "SearchArea"
        Me.SearchAreaDataGridViewTextBoxColumn.HeaderText = "SearchArea"
        Me.SearchAreaDataGridViewTextBoxColumn.Name = "SearchAreaDataGridViewTextBoxColumn"
        '
        'GroupNumberDataGridViewTextBoxColumn
        '
        Me.GroupNumberDataGridViewTextBoxColumn.DataPropertyName = "GroupNumber"
        Me.GroupNumberDataGridViewTextBoxColumn.HeaderText = "GroupNumber"
        Me.GroupNumberDataGridViewTextBoxColumn.Name = "GroupNumberDataGridViewTextBoxColumn"
        '
        'SightingDateDataGridViewTextBoxColumn
        '
        Me.SightingDateDataGridViewTextBoxColumn.DataPropertyName = "SightingDate"
        Me.SightingDateDataGridViewTextBoxColumn.HeaderText = "SightingDate"
        Me.SightingDateDataGridViewTextBoxColumn.Name = "SightingDateDataGridViewTextBoxColumn"
        '
        'CowDataGridViewTextBoxColumn
        '
        Me.CowDataGridViewTextBoxColumn.DataPropertyName = "Cow"
        Me.CowDataGridViewTextBoxColumn.HeaderText = "Cow"
        Me.CowDataGridViewTextBoxColumn.Name = "CowDataGridViewTextBoxColumn"
        '
        'CalfMaleDataGridViewTextBoxColumn
        '
        Me.CalfMaleDataGridViewTextBoxColumn.DataPropertyName = "Calf_Male"
        Me.CalfMaleDataGridViewTextBoxColumn.HeaderText = "Calf_Male"
        Me.CalfMaleDataGridViewTextBoxColumn.Name = "CalfMaleDataGridViewTextBoxColumn"
        '
        'CalfFemaleDataGridViewTextBoxColumn
        '
        Me.CalfFemaleDataGridViewTextBoxColumn.DataPropertyName = "Calf_Female"
        Me.CalfFemaleDataGridViewTextBoxColumn.HeaderText = "Calf_Female"
        Me.CalfFemaleDataGridViewTextBoxColumn.Name = "CalfFemaleDataGridViewTextBoxColumn"
        '
        'CalfUnclassifiedDataGridViewTextBoxColumn
        '
        Me.CalfUnclassifiedDataGridViewTextBoxColumn.DataPropertyName = "CalfUnclassified"
        Me.CalfUnclassifiedDataGridViewTextBoxColumn.HeaderText = "CalfUnclassified"
        Me.CalfUnclassifiedDataGridViewTextBoxColumn.Name = "CalfUnclassifiedDataGridViewTextBoxColumn"
        '
        'CalfDataGridViewTextBoxColumn
        '
        Me.CalfDataGridViewTextBoxColumn.DataPropertyName = "Calf"
        Me.CalfDataGridViewTextBoxColumn.HeaderText = "Calf"
        Me.CalfDataGridViewTextBoxColumn.Name = "CalfDataGridViewTextBoxColumn"
        '
        'SmallBullDataGridViewTextBoxColumn
        '
        Me.SmallBullDataGridViewTextBoxColumn.DataPropertyName = "SmallBull"
        Me.SmallBullDataGridViewTextBoxColumn.HeaderText = "SmallBull"
        Me.SmallBullDataGridViewTextBoxColumn.Name = "SmallBullDataGridViewTextBoxColumn"
        '
        'MediumBullDataGridViewTextBoxColumn
        '
        Me.MediumBullDataGridViewTextBoxColumn.DataPropertyName = "MediumBull"
        Me.MediumBullDataGridViewTextBoxColumn.HeaderText = "MediumBull"
        Me.MediumBullDataGridViewTextBoxColumn.Name = "MediumBullDataGridViewTextBoxColumn"
        '
        'LargeBullDataGridViewTextBoxColumn
        '
        Me.LargeBullDataGridViewTextBoxColumn.DataPropertyName = "LargeBull"
        Me.LargeBullDataGridViewTextBoxColumn.HeaderText = "LargeBull"
        Me.LargeBullDataGridViewTextBoxColumn.Name = "LargeBullDataGridViewTextBoxColumn"
        '
        'BullDataGridViewTextBoxColumn
        '
        Me.BullDataGridViewTextBoxColumn.DataPropertyName = "Bull"
        Me.BullDataGridViewTextBoxColumn.HeaderText = "Bull"
        Me.BullDataGridViewTextBoxColumn.Name = "BullDataGridViewTextBoxColumn"
        '
        'AdultDataGridViewTextBoxColumn
        '
        Me.AdultDataGridViewTextBoxColumn.DataPropertyName = "Adult"
        Me.AdultDataGridViewTextBoxColumn.HeaderText = "Adult"
        Me.AdultDataGridViewTextBoxColumn.Name = "AdultDataGridViewTextBoxColumn"
        '
        'CaribouDataGridViewTextBoxColumn
        '
        Me.CaribouDataGridViewTextBoxColumn.DataPropertyName = "Caribou"
        Me.CaribouDataGridViewTextBoxColumn.HeaderText = "Caribou"
        Me.CaribouDataGridViewTextBoxColumn.Name = "CaribouDataGridViewTextBoxColumn"
        '
        'UnknownDataGridViewTextBoxColumn
        '
        Me.UnknownDataGridViewTextBoxColumn.DataPropertyName = "Unknown"
        Me.UnknownDataGridViewTextBoxColumn.HeaderText = "Unknown"
        Me.UnknownDataGridViewTextBoxColumn.Name = "UnknownDataGridViewTextBoxColumn"
        '
        'FrequenciesInGroupDataGridViewTextBoxColumn
        '
        Me.FrequenciesInGroupDataGridViewTextBoxColumn.DataPropertyName = "FrequenciesInGroup"
        Me.FrequenciesInGroupDataGridViewTextBoxColumn.HeaderText = "FrequenciesInGroup"
        Me.FrequenciesInGroupDataGridViewTextBoxColumn.Name = "FrequenciesInGroupDataGridViewTextBoxColumn"
        '
        'FrequenciesCountDataGridViewTextBoxColumn
        '
        Me.FrequenciesCountDataGridViewTextBoxColumn.DataPropertyName = "FrequenciesCount"
        Me.FrequenciesCountDataGridViewTextBoxColumn.HeaderText = "FrequenciesCount"
        Me.FrequenciesCountDataGridViewTextBoxColumn.Name = "FrequenciesCountDataGridViewTextBoxColumn"
        '
        'LatDataGridViewTextBoxColumn
        '
        Me.LatDataGridViewTextBoxColumn.DataPropertyName = "Lat"
        Me.LatDataGridViewTextBoxColumn.HeaderText = "Lat"
        Me.LatDataGridViewTextBoxColumn.Name = "LatDataGridViewTextBoxColumn"
        '
        'LonDataGridViewTextBoxColumn
        '
        Me.LonDataGridViewTextBoxColumn.DataPropertyName = "Lon"
        Me.LonDataGridViewTextBoxColumn.HeaderText = "Lon"
        Me.LonDataGridViewTextBoxColumn.Name = "LonDataGridViewTextBoxColumn"
        '
        'InDataGridViewCheckBoxColumn
        '
        Me.InDataGridViewCheckBoxColumn.DataPropertyName = "In"
        Me.InDataGridViewCheckBoxColumn.HeaderText = "In"
        Me.InDataGridViewCheckBoxColumn.Name = "InDataGridViewCheckBoxColumn"
        '
        'SeenDataGridViewCheckBoxColumn
        '
        Me.SeenDataGridViewCheckBoxColumn.DataPropertyName = "Seen"
        Me.SeenDataGridViewCheckBoxColumn.HeaderText = "Seen"
        Me.SeenDataGridViewCheckBoxColumn.Name = "SeenDataGridViewCheckBoxColumn"
        '
        'MarkedDataGridViewCheckBoxColumn
        '
        Me.MarkedDataGridViewCheckBoxColumn.DataPropertyName = "Marked"
        Me.MarkedDataGridViewCheckBoxColumn.HeaderText = "Marked"
        Me.MarkedDataGridViewCheckBoxColumn.Name = "MarkedDataGridViewCheckBoxColumn"
        '
        'WaypointNameDataGridViewTextBoxColumn
        '
        Me.WaypointNameDataGridViewTextBoxColumn.DataPropertyName = "WaypointName"
        Me.WaypointNameDataGridViewTextBoxColumn.HeaderText = "WaypointName"
        Me.WaypointNameDataGridViewTextBoxColumn.Name = "WaypointNameDataGridViewTextBoxColumn"
        '
        'SurveyCommentDataGridViewTextBoxColumn
        '
        Me.SurveyCommentDataGridViewTextBoxColumn.DataPropertyName = "SurveyComment"
        Me.SurveyCommentDataGridViewTextBoxColumn.HeaderText = "SurveyComment"
        Me.SurveyCommentDataGridViewTextBoxColumn.Name = "SurveyCommentDataGridViewTextBoxColumn"
        '
        'CrewNumberDataGridViewTextBoxColumn
        '
        Me.CrewNumberDataGridViewTextBoxColumn.DataPropertyName = "CrewNumber"
        Me.CrewNumberDataGridViewTextBoxColumn.HeaderText = "CrewNumber"
        Me.CrewNumberDataGridViewTextBoxColumn.Name = "CrewNumberDataGridViewTextBoxColumn"
        '
        'PilotDataGridViewTextBoxColumn
        '
        Me.PilotDataGridViewTextBoxColumn.DataPropertyName = "Pilot"
        Me.PilotDataGridViewTextBoxColumn.HeaderText = "Pilot"
        Me.PilotDataGridViewTextBoxColumn.Name = "PilotDataGridViewTextBoxColumn"
        '
        'Observer1DataGridViewTextBoxColumn
        '
        Me.Observer1DataGridViewTextBoxColumn.DataPropertyName = "Observer1"
        Me.Observer1DataGridViewTextBoxColumn.HeaderText = "Observer1"
        Me.Observer1DataGridViewTextBoxColumn.Name = "Observer1DataGridViewTextBoxColumn"
        '
        'Observer2DataGridViewTextBoxColumn
        '
        Me.Observer2DataGridViewTextBoxColumn.DataPropertyName = "Observer2"
        Me.Observer2DataGridViewTextBoxColumn.HeaderText = "Observer2"
        Me.Observer2DataGridViewTextBoxColumn.Name = "Observer2DataGridViewTextBoxColumn"
        '
        'AircraftTypeDataGridViewTextBoxColumn
        '
        Me.AircraftTypeDataGridViewTextBoxColumn.DataPropertyName = "AircraftType"
        Me.AircraftTypeDataGridViewTextBoxColumn.HeaderText = "AircraftType"
        Me.AircraftTypeDataGridViewTextBoxColumn.Name = "AircraftTypeDataGridViewTextBoxColumn"
        '
        'TailNoDataGridViewTextBoxColumn
        '
        Me.TailNoDataGridViewTextBoxColumn.DataPropertyName = "TailNo"
        Me.TailNoDataGridViewTextBoxColumn.HeaderText = "TailNo"
        Me.TailNoDataGridViewTextBoxColumn.Name = "TailNoDataGridViewTextBoxColumn"
        '
        'SurveyLengthhoursDataGridViewTextBoxColumn
        '
        Me.SurveyLengthhoursDataGridViewTextBoxColumn.DataPropertyName = "SurveyLength (hours)"
        Me.SurveyLengthhoursDataGridViewTextBoxColumn.HeaderText = "SurveyLength (hours)"
        Me.SurveyLengthhoursDataGridViewTextBoxColumn.Name = "SurveyLengthhoursDataGridViewTextBoxColumn"
        '
        'IsFollowUpFlightDataGridViewCheckBoxColumn
        '
        Me.IsFollowUpFlightDataGridViewCheckBoxColumn.DataPropertyName = "IsFollowUpFlight"
        Me.IsFollowUpFlightDataGridViewCheckBoxColumn.HeaderText = "IsFollowUpFlight"
        Me.IsFollowUpFlightDataGridViewCheckBoxColumn.Name = "IsFollowUpFlightDataGridViewCheckBoxColumn"
        '
        'SpotterPlaneTailNoDataGridViewTextBoxColumn
        '
        Me.SpotterPlaneTailNoDataGridViewTextBoxColumn.DataPropertyName = "SpotterPlaneTailNo"
        Me.SpotterPlaneTailNoDataGridViewTextBoxColumn.HeaderText = "SpotterPlaneTailNo"
        Me.SpotterPlaneTailNoDataGridViewTextBoxColumn.Name = "SpotterPlaneTailNoDataGridViewTextBoxColumn"
        '
        'SpotterPlaneTypeDataGridViewTextBoxColumn
        '
        Me.SpotterPlaneTypeDataGridViewTextBoxColumn.DataPropertyName = "SpotterPlaneType"
        Me.SpotterPlaneTypeDataGridViewTextBoxColumn.HeaderText = "SpotterPlaneType"
        Me.SpotterPlaneTypeDataGridViewTextBoxColumn.Name = "SpotterPlaneTypeDataGridViewTextBoxColumn"
        '
        'SpotterPlanePilotDataGridViewTextBoxColumn
        '
        Me.SpotterPlanePilotDataGridViewTextBoxColumn.DataPropertyName = "SpotterPlanePilot"
        Me.SpotterPlanePilotDataGridViewTextBoxColumn.HeaderText = "SpotterPlanePilot"
        Me.SpotterPlanePilotDataGridViewTextBoxColumn.Name = "SpotterPlanePilotDataGridViewTextBoxColumn"
        '
        'WeatherConditionsDataGridViewTextBoxColumn
        '
        Me.WeatherConditionsDataGridViewTextBoxColumn.DataPropertyName = "WeatherConditions"
        Me.WeatherConditionsDataGridViewTextBoxColumn.HeaderText = "WeatherConditions"
        Me.WeatherConditionsDataGridViewTextBoxColumn.Name = "WeatherConditionsDataGridViewTextBoxColumn"
        '
        'SnowConditionsDataGridViewTextBoxColumn
        '
        Me.SnowConditionsDataGridViewTextBoxColumn.DataPropertyName = "SnowConditions"
        Me.SnowConditionsDataGridViewTextBoxColumn.HeaderText = "SnowConditions"
        Me.SnowConditionsDataGridViewTextBoxColumn.Name = "SnowConditionsDataGridViewTextBoxColumn"
        '
        'FlightCommentDataGridViewTextBoxColumn
        '
        Me.FlightCommentDataGridViewTextBoxColumn.DataPropertyName = "FlightComment"
        Me.FlightCommentDataGridViewTextBoxColumn.HeaderText = "FlightComment"
        Me.FlightCommentDataGridViewTextBoxColumn.Name = "FlightCommentDataGridViewTextBoxColumn"
        '
        'ReportReferenceCodeDataGridViewTextBoxColumn
        '
        Me.ReportReferenceCodeDataGridViewTextBoxColumn.DataPropertyName = "ReportReferenceCode"
        Me.ReportReferenceCodeDataGridViewTextBoxColumn.HeaderText = "ReportReferenceCode"
        Me.ReportReferenceCodeDataGridViewTextBoxColumn.Name = "ReportReferenceCodeDataGridViewTextBoxColumn"
        '
        'SourceFilenameDataGridViewTextBoxColumn
        '
        Me.SourceFilenameDataGridViewTextBoxColumn.DataPropertyName = "SourceFilename"
        Me.SourceFilenameDataGridViewTextBoxColumn.HeaderText = "SourceFilename"
        Me.SourceFilenameDataGridViewTextBoxColumn.Name = "SourceFilenameDataGridViewTextBoxColumn"
        '
        'SourceFileURLDataGridViewTextBoxColumn
        '
        Me.SourceFileURLDataGridViewTextBoxColumn.DataPropertyName = "SourceFileURL"
        Me.SourceFileURLDataGridViewTextBoxColumn.HeaderText = "SourceFileURL"
        Me.SourceFileURLDataGridViewTextBoxColumn.Name = "SourceFileURLDataGridViewTextBoxColumn"
        '
        'RecordInsertedDateDataGridViewTextBoxColumn
        '
        Me.RecordInsertedDateDataGridViewTextBoxColumn.DataPropertyName = "RecordInsertedDate"
        Me.RecordInsertedDateDataGridViewTextBoxColumn.HeaderText = "RecordInsertedDate"
        Me.RecordInsertedDateDataGridViewTextBoxColumn.Name = "RecordInsertedDateDataGridViewTextBoxColumn"
        '
        'RecordInsertedByDataGridViewTextBoxColumn
        '
        Me.RecordInsertedByDataGridViewTextBoxColumn.DataPropertyName = "RecordInsertedBy"
        Me.RecordInsertedByDataGridViewTextBoxColumn.HeaderText = "RecordInsertedBy"
        Me.RecordInsertedByDataGridViewTextBoxColumn.Name = "RecordInsertedByDataGridViewTextBoxColumn"
        '
        'CertificationLevelDataGridViewTextBoxColumn
        '
        Me.CertificationLevelDataGridViewTextBoxColumn.DataPropertyName = "CertificationLevel"
        Me.CertificationLevelDataGridViewTextBoxColumn.HeaderText = "CertificationLevel"
        Me.CertificationLevelDataGridViewTextBoxColumn.Name = "CertificationLevelDataGridViewTextBoxColumn"
        '
        'CertificationDateDataGridViewTextBoxColumn
        '
        Me.CertificationDateDataGridViewTextBoxColumn.DataPropertyName = "CertificationDate"
        Me.CertificationDateDataGridViewTextBoxColumn.HeaderText = "CertificationDate"
        Me.CertificationDateDataGridViewTextBoxColumn.Name = "CertificationDateDataGridViewTextBoxColumn"
        '
        'CertifiedByDataGridViewTextBoxColumn
        '
        Me.CertifiedByDataGridViewTextBoxColumn.DataPropertyName = "CertifiedBy"
        Me.CertifiedByDataGridViewTextBoxColumn.HeaderText = "CertifiedBy"
        Me.CertifiedByDataGridViewTextBoxColumn.Name = "CertifiedByDataGridViewTextBoxColumn"
        '
        'DataQualityNotesDataGridViewTextBoxColumn
        '
        Me.DataQualityNotesDataGridViewTextBoxColumn.DataPropertyName = "DataQualityNotes"
        Me.DataQualityNotesDataGridViewTextBoxColumn.HeaderText = "DataQualityNotes"
        Me.DataQualityNotesDataGridViewTextBoxColumn.Name = "DataQualityNotesDataGridViewTextBoxColumn"
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        '
        'ParkDataGridViewTextBoxColumn
        '
        Me.ParkDataGridViewTextBoxColumn.DataPropertyName = "Park"
        Me.ParkDataGridViewTextBoxColumn.HeaderText = "Park"
        Me.ParkDataGridViewTextBoxColumn.Name = "ParkDataGridViewTextBoxColumn"
        '
        'EIDDataGridViewTextBoxColumn
        '
        Me.EIDDataGridViewTextBoxColumn.DataPropertyName = "EID"
        Me.EIDDataGridViewTextBoxColumn.HeaderText = "EID"
        Me.EIDDataGridViewTextBoxColumn.Name = "EIDDataGridViewTextBoxColumn"
        '
        'CaribouGroupContextMenuStrip
        '
        Me.CaribouGroupContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReconcileFrequenciesForThisGroupToolStripMenuItem})
        Me.CaribouGroupContextMenuStrip.Name = "CaribouGroupContextMenuStrip"
        Me.CaribouGroupContextMenuStrip.Size = New System.Drawing.Size(424, 48)
        '
        'ReconcileFrequenciesForThisGroupToolStripMenuItem
        '
        Me.ReconcileFrequenciesForThisGroupToolStripMenuItem.Name = "ReconcileFrequenciesForThisGroupToolStripMenuItem"
        Me.ReconcileFrequenciesForThisGroupToolStripMenuItem.Size = New System.Drawing.Size(423, 22)
        Me.ReconcileFrequenciesForThisGroupToolStripMenuItem.Text = "Analyze/edit frequency to animal mapping for the current group..."
        '
        'CaribouGroupsToolStrip
        '
        Me.CaribouGroupsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton, Me.ToolStripSeparator4, Me.FilterToolStripLabel, Me.FilterToolStripTextBox, Me.ApplyFilterToolStripButton, Me.ToolStripSeparator2, Me.SortToolStripLabel, Me.SortToolStripTextBox, Me.ApplySortToolStripButton, Me.ToolStripSeparator3})
        Me.CaribouGroupsToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.CaribouGroupsToolStrip.Name = "CaribouGroupsToolStrip"
        Me.CaribouGroupsToolStrip.Size = New System.Drawing.Size(1181, 25)
        Me.CaribouGroupsToolStrip.TabIndex = 1
        Me.CaribouGroupsToolStrip.Text = "ToolStrip1"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(35, 22)
        Me.SaveToolStripButton.Text = "Save"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'FilterToolStripLabel
        '
        Me.FilterToolStripLabel.Name = "FilterToolStripLabel"
        Me.FilterToolStripLabel.Size = New System.Drawing.Size(36, 22)
        Me.FilterToolStripLabel.Text = "Filter:"
        '
        'FilterToolStripTextBox
        '
        Me.FilterToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FilterToolStripTextBox.Name = "FilterToolStripTextBox"
        Me.FilterToolStripTextBox.Size = New System.Drawing.Size(300, 25)
        '
        'ApplyFilterToolStripButton
        '
        Me.ApplyFilterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ApplyFilterToolStripButton.Image = CType(resources.GetObject("ApplyFilterToolStripButton.Image"), System.Drawing.Image)
        Me.ApplyFilterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ApplyFilterToolStripButton.Name = "ApplyFilterToolStripButton"
        Me.ApplyFilterToolStripButton.Size = New System.Drawing.Size(69, 22)
        Me.ApplyFilterToolStripButton.Text = "Apply filter"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SortToolStripLabel
        '
        Me.SortToolStripLabel.Name = "SortToolStripLabel"
        Me.SortToolStripLabel.Size = New System.Drawing.Size(28, 22)
        Me.SortToolStripLabel.Text = "Sort"
        '
        'SortToolStripTextBox
        '
        Me.SortToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SortToolStripTextBox.Name = "SortToolStripTextBox"
        Me.SortToolStripTextBox.Size = New System.Drawing.Size(300, 25)
        '
        'ApplySortToolStripButton
        '
        Me.ApplySortToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ApplySortToolStripButton.Image = CType(resources.GetObject("ApplySortToolStripButton.Image"), System.Drawing.Image)
        Me.ApplySortToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ApplySortToolStripButton.Name = "ApplySortToolStripButton"
        Me.ApplySortToolStripButton.Size = New System.Drawing.Size(65, 22)
        Me.ApplySortToolStripButton.Text = "Apply sort"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'GroupMembersBindingNavigator
        '
        Me.GroupMembersBindingNavigator.AddNewItem = Nothing
        Me.GroupMembersBindingNavigator.BindingSource = Me.GroupMembersBindingSource
        Me.GroupMembersBindingNavigator.CountItem = Me.ToolStripLabel1
        Me.GroupMembersBindingNavigator.DeleteItem = Nothing
        Me.GroupMembersBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupMembersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator5, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator6})
        Me.GroupMembersBindingNavigator.Location = New System.Drawing.Point(0, 86)
        Me.GroupMembersBindingNavigator.MoveFirstItem = Me.ToolStripButton1
        Me.GroupMembersBindingNavigator.MoveLastItem = Me.ToolStripButton4
        Me.GroupMembersBindingNavigator.MoveNextItem = Me.ToolStripButton3
        Me.GroupMembersBindingNavigator.MovePreviousItem = Me.ToolStripButton2
        Me.GroupMembersBindingNavigator.Name = "GroupMembersBindingNavigator"
        Me.GroupMembersBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.GroupMembersBindingNavigator.Size = New System.Drawing.Size(1181, 25)
        Me.GroupMembersBindingNavigator.TabIndex = 3
        Me.GroupMembersBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Move first"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move next"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move last"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'EditCaribouGroupsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 586)
        Me.Controls.Add(Me.MainSplitContainer)
        Me.Name = "EditCaribouGroupsForm"
        Me.Text = "Caribou groups"
        CType(Me.WRST_CaribouDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaribouGroupsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaribouGroupsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CaribouGroupsBindingNavigator.ResumeLayout(False)
        Me.CaribouGroupsBindingNavigator.PerformLayout()
        CType(Me.GroupMembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupMembersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitContainer.Panel1.ResumeLayout(False)
        Me.MainSplitContainer.Panel1.PerformLayout()
        Me.MainSplitContainer.Panel2.ResumeLayout(False)
        Me.MainSplitContainer.Panel2.PerformLayout()
        CType(Me.MainSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitContainer.ResumeLayout(False)
        CType(Me.CaribouGroupsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CaribouGroupContextMenuStrip.ResumeLayout(False)
        Me.CaribouGroupsToolStrip.ResumeLayout(False)
        Me.CaribouGroupsToolStrip.PerformLayout()
        CType(Me.GroupMembersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupMembersBindingNavigator.ResumeLayout(False)
        Me.GroupMembersBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WRST_CaribouDataSet As WRST_CaribouDataSet
    Friend WithEvents CaribouGroupsBindingSource As BindingSource
    Friend WithEvents CaribouGroupsTableAdapter As WRST_CaribouDataSetTableAdapters.CaribouGroupsTableAdapter
    Friend WithEvents TableAdapterManager As WRST_CaribouDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CaribouGroupsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents GroupMembersTableAdapter As WRST_CaribouDataSetTableAdapters.GroupMembersTableAdapter
    Friend WithEvents GroupMembersBindingSource As BindingSource
    Friend WithEvents GroupMembersDataGridView As DataGridView
    Friend WithEvents MainSplitContainer As SplitContainer
    Friend WithEvents CaribouGroupsDataGridView As DataGridView
    Friend WithEvents SurveyNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HerdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SurveyTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SearchAreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SightingDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CowDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CalfMaleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CalfFemaleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CalfUnclassifiedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CalfDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SmallBullDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MediumBullDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LargeBullDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BullDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdultDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CaribouDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnknownDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FrequenciesInGroupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FrequenciesCountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents SeenDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents MarkedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents WaypointNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SurveyCommentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CrewNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PilotDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Observer1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Observer2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AircraftTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TailNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SurveyLengthhoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsFollowUpFlightDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents SpotterPlaneTailNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpotterPlaneTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpotterPlanePilotDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeatherConditionsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SnowConditionsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FlightCommentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportReferenceCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SourceFilenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SourceFileURLDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecordInsertedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecordInsertedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CertificationLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CertificationDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CertifiedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataQualityNotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ParkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnimalIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As DataGridViewTextBoxColumn
    Friend WithEvents CaribouGroupContextMenuStrip As ContextMenuStrip
    Friend WithEvents ReconcileFrequenciesForThisGroupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaribouGroupsToolStrip As ToolStrip
    Friend WithEvents FilterToolStripLabel As ToolStripLabel
    Friend WithEvents FilterToolStripTextBox As ToolStripTextBox
    Friend WithEvents ApplyFilterToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SortToolStripLabel As ToolStripLabel
    Friend WithEvents SortToolStripTextBox As ToolStripTextBox
    Friend WithEvents ApplySortToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents GroupMembersBindingNavigator As BindingNavigator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
End Class
