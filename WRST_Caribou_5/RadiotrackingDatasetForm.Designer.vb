<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadiotrackingDatasetForm
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
        Me.RadiotrackingGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RadiotrackingDatasetFormDockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        CType(Me.RadiotrackingGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadiotrackingDatasetFormDockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadiotrackingGridControl
        '
        Me.RadiotrackingGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadiotrackingGridControl.Location = New System.Drawing.Point(0, 0)
        Me.RadiotrackingGridControl.MainView = Me.GridView1
        Me.RadiotrackingGridControl.Name = "RadiotrackingGridControl"
        Me.RadiotrackingGridControl.Size = New System.Drawing.Size(800, 450)
        Me.RadiotrackingGridControl.TabIndex = 0
        Me.RadiotrackingGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.RadiotrackingGridControl
        Me.GridView1.Name = "GridView1"
        '
        'RadiotrackingDatasetFormDockManager
        '
        Me.RadiotrackingDatasetFormDockManager.Form = Me
        Me.RadiotrackingDatasetFormDockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'RadiotrackingDatasetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RadiotrackingGridControl)
        Me.Name = "RadiotrackingDatasetForm"
        Me.Text = "RadiotrackingDatasetForm"
        CType(Me.RadiotrackingGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadiotrackingDatasetFormDockManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadiotrackingGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RadiotrackingDatasetFormDockManager As DevExpress.XtraBars.Docking.DockManager
End Class
