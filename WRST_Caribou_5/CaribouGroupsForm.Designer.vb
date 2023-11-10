<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaribouGroupsForm
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
        Me.CaribouGroupsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CaribouGroupsDockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.PivotGridDockPanel = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ExportPivotGridToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.CaribouGroupsPivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.CaribouGroupsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ExportGridContentsToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        CType(Me.CaribouGroupsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaribouGroupsDockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PivotGridDockPanel.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.CaribouGroupsPivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CaribouGroupsToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'CaribouGroupsGridControl
        '
        Me.CaribouGroupsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CaribouGroupsGridControl.Location = New System.Drawing.Point(0, 25)
        Me.CaribouGroupsGridControl.MainView = Me.GridView1
        Me.CaribouGroupsGridControl.Name = "CaribouGroupsGridControl"
        Me.CaribouGroupsGridControl.Size = New System.Drawing.Size(800, 237)
        Me.CaribouGroupsGridControl.TabIndex = 0
        Me.CaribouGroupsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.CaribouGroupsGridControl
        Me.GridView1.Name = "GridView1"
        '
        'CaribouGroupsDockManager
        '
        Me.CaribouGroupsDockManager.Form = Me
        Me.CaribouGroupsDockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.PivotGridDockPanel})
        Me.CaribouGroupsDockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'PivotGridDockPanel
        '
        Me.PivotGridDockPanel.Controls.Add(Me.DockPanel1_Container)
        Me.PivotGridDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
        Me.PivotGridDockPanel.ID = New System.Guid("dcce6c99-fbda-45b9-acbf-097fe5855aa6")
        Me.PivotGridDockPanel.Location = New System.Drawing.Point(0, 262)
        Me.PivotGridDockPanel.Name = "PivotGridDockPanel"
        Me.PivotGridDockPanel.OriginalSize = New System.Drawing.Size(200, 188)
        Me.PivotGridDockPanel.Size = New System.Drawing.Size(800, 188)
        Me.PivotGridDockPanel.Text = "Pivot grid"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.CaribouGroupsPivotGridControl)
        Me.DockPanel1_Container.Controls.Add(Me.ToolStrip1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 27)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(794, 158)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ExportPivotGridToolStripComboBox})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(794, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(84, 22)
        Me.ToolStripLabel2.Text = "Export data to:"
        '
        'ExportPivotGridToolStripComboBox
        '
        Me.ExportPivotGridToolStripComboBox.Items.AddRange(New Object() {"", "Excel", "CSV"})
        Me.ExportPivotGridToolStripComboBox.Name = "ExportPivotGridToolStripComboBox"
        Me.ExportPivotGridToolStripComboBox.Size = New System.Drawing.Size(121, 25)
        '
        'CaribouGroupsPivotGridControl
        '
        Me.CaribouGroupsPivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CaribouGroupsPivotGridControl.Location = New System.Drawing.Point(0, 25)
        Me.CaribouGroupsPivotGridControl.Name = "CaribouGroupsPivotGridControl"
        Me.CaribouGroupsPivotGridControl.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
        Me.CaribouGroupsPivotGridControl.Size = New System.Drawing.Size(794, 133)
        Me.CaribouGroupsPivotGridControl.TabIndex = 0
        '
        'CaribouGroupsToolStrip
        '
        Me.CaribouGroupsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ExportGridContentsToolStripComboBox})
        Me.CaribouGroupsToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.CaribouGroupsToolStrip.Name = "CaribouGroupsToolStrip"
        Me.CaribouGroupsToolStrip.Size = New System.Drawing.Size(800, 25)
        Me.CaribouGroupsToolStrip.TabIndex = 2
        Me.CaribouGroupsToolStrip.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(84, 22)
        Me.ToolStripLabel1.Text = "Export data to:"
        '
        'ExportGridContentsToolStripComboBox
        '
        Me.ExportGridContentsToolStripComboBox.Items.AddRange(New Object() {"", "Excel", "CSV"})
        Me.ExportGridContentsToolStripComboBox.Name = "ExportGridContentsToolStripComboBox"
        Me.ExportGridContentsToolStripComboBox.Size = New System.Drawing.Size(121, 25)
        '
        'CaribouGroupsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CaribouGroupsGridControl)
        Me.Controls.Add(Me.CaribouGroupsToolStrip)
        Me.Controls.Add(Me.PivotGridDockPanel)
        Me.Name = "CaribouGroupsForm"
        Me.Text = "CaribouGroupsForm"
        CType(Me.CaribouGroupsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaribouGroupsDockManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PivotGridDockPanel.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.CaribouGroupsPivotGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CaribouGroupsToolStrip.ResumeLayout(False)
        Me.CaribouGroupsToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CaribouGroupsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CaribouGroupsDockManager As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents PivotGridDockPanel As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents CaribouGroupsPivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents CaribouGroupsToolStrip As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ExportGridContentsToolStripComboBox As ToolStripComboBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ExportPivotGridToolStripComboBox As ToolStripComboBox
End Class
