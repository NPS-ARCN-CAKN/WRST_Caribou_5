<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportDataForm
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
        Me.ImportCensusDataWizardControl = New DevExpress.XtraWizard.WizardControl()
        Me.SelectSourceFileWelcomeWizardPage = New DevExpress.XtraWizard.WelcomeWizardPage()
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.IsDataImportCorrectWizardPage = New DevExpress.XtraWizard.WizardPage()
        Me.SourceDataGridView = New System.Windows.Forms.DataGridView()
        Me.CompletionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
        Me.CompositionSurveyWizardPage = New DevExpress.XtraWizard.WizardPage()
        Me.SourceFileLabel = New System.Windows.Forms.Label()
        Me.MapColumnsWizardPage = New DevExpress.XtraWizard.WizardPage()
        CType(Me.ImportCensusDataWizardControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ImportCensusDataWizardControl.SuspendLayout()
        Me.SelectSourceFileWelcomeWizardPage.SuspendLayout()
        Me.IsDataImportCorrectWizardPage.SuspendLayout()
        CType(Me.SourceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImportCensusDataWizardControl
        '
        Me.ImportCensusDataWizardControl.Controls.Add(Me.SelectSourceFileWelcomeWizardPage)
        Me.ImportCensusDataWizardControl.Controls.Add(Me.IsDataImportCorrectWizardPage)
        Me.ImportCensusDataWizardControl.Controls.Add(Me.CompletionWizardPage1)
        Me.ImportCensusDataWizardControl.Controls.Add(Me.CompositionSurveyWizardPage)
        Me.ImportCensusDataWizardControl.Controls.Add(Me.MapColumnsWizardPage)
        Me.ImportCensusDataWizardControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImportCensusDataWizardControl.Name = "ImportCensusDataWizardControl"
        Me.ImportCensusDataWizardControl.NavigationMode = DevExpress.XtraWizard.NavigationMode.Stacked
        Me.ImportCensusDataWizardControl.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() {Me.SelectSourceFileWelcomeWizardPage, Me.IsDataImportCorrectWizardPage, Me.CompositionSurveyWizardPage, Me.MapColumnsWizardPage, Me.CompletionWizardPage1})
        Me.ImportCensusDataWizardControl.Size = New System.Drawing.Size(800, 450)
        Me.ImportCensusDataWizardControl.Text = "Import caribou census (composition or population survey) data"
        Me.ImportCensusDataWizardControl.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero
        '
        'SelectSourceFileWelcomeWizardPage
        '
        Me.SelectSourceFileWelcomeWizardPage.Controls.Add(Me.SourceFileLabel)
        Me.SelectSourceFileWelcomeWizardPage.Controls.Add(Me.BrowseButton)
        Me.SelectSourceFileWelcomeWizardPage.IntroductionText = "Follow the steps to import caribou population, composition or radiotracking surve" &
    "y data into the caribou monitoring database."
        Me.SelectSourceFileWelcomeWizardPage.Name = "SelectSourceFileWelcomeWizardPage"
        Me.SelectSourceFileWelcomeWizardPage.Size = New System.Drawing.Size(740, 283)
        Me.SelectSourceFileWelcomeWizardPage.Text = "Choose a data file"
        '
        'BrowseButton
        '
        Me.BrowseButton.Location = New System.Drawing.Point(51, 33)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.BrowseButton.TabIndex = 0
        Me.BrowseButton.Text = "Browse..."
        Me.BrowseButton.UseVisualStyleBackColor = True
        '
        'IsDataImportCorrectWizardPage
        '
        Me.IsDataImportCorrectWizardPage.Controls.Add(Me.SourceDataGridView)
        Me.IsDataImportCorrectWizardPage.DescriptionText = "Population, composition or radiotracking data."
        Me.IsDataImportCorrectWizardPage.Name = "IsDataImportCorrectWizardPage"
        Me.IsDataImportCorrectWizardPage.Size = New System.Drawing.Size(740, 283)
        Me.IsDataImportCorrectWizardPage.Text = "Does this look correct?"
        '
        'SourceDataGridView
        '
        Me.SourceDataGridView.AllowUserToAddRows = False
        Me.SourceDataGridView.AllowUserToDeleteRows = False
        Me.SourceDataGridView.AllowUserToOrderColumns = True
        Me.SourceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SourceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SourceDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.SourceDataGridView.Name = "SourceDataGridView"
        Me.SourceDataGridView.ReadOnly = True
        Me.SourceDataGridView.Size = New System.Drawing.Size(740, 283)
        Me.SourceDataGridView.TabIndex = 0
        '
        'CompletionWizardPage1
        '
        Me.CompletionWizardPage1.Name = "CompletionWizardPage1"
        Me.CompletionWizardPage1.Size = New System.Drawing.Size(740, 283)
        '
        'CompositionSurveyWizardPage
        '
        Me.CompositionSurveyWizardPage.Name = "CompositionSurveyWizardPage"
        Me.CompositionSurveyWizardPage.Size = New System.Drawing.Size(740, 283)
        Me.CompositionSurveyWizardPage.Text = "Import composition survey data"
        '
        'SourceFileLabel
        '
        Me.SourceFileLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SourceFileLabel.Location = New System.Drawing.Point(51, 80)
        Me.SourceFileLabel.Name = "SourceFileLabel"
        Me.SourceFileLabel.Size = New System.Drawing.Size(663, 174)
        Me.SourceFileLabel.TabIndex = 1
        '
        'MapColumnsWizardPage
        '
        Me.MapColumnsWizardPage.DescriptionText = "Map the source date file's columns to the database columns"
        Me.MapColumnsWizardPage.Name = "MapColumnsWizardPage"
        Me.MapColumnsWizardPage.Size = New System.Drawing.Size(740, 283)
        Me.MapColumnsWizardPage.Text = "Columns mapping"
        '
        'ImportDataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ImportCensusDataWizardControl)
        Me.Name = "ImportDataForm"
        Me.Text = "ImportDataForm"
        CType(Me.ImportCensusDataWizardControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ImportCensusDataWizardControl.ResumeLayout(False)
        Me.SelectSourceFileWelcomeWizardPage.ResumeLayout(False)
        Me.IsDataImportCorrectWizardPage.ResumeLayout(False)
        CType(Me.SourceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImportCensusDataWizardControl As DevExpress.XtraWizard.WizardControl
    Friend WithEvents SelectSourceFileWelcomeWizardPage As DevExpress.XtraWizard.WelcomeWizardPage
    Friend WithEvents IsDataImportCorrectWizardPage As DevExpress.XtraWizard.WizardPage
    Friend WithEvents CompletionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
    Friend WithEvents CompositionSurveyWizardPage As DevExpress.XtraWizard.WizardPage
    Friend WithEvents BrowseButton As Button
    Friend WithEvents SourceDataGridView As DataGridView
    Friend WithEvents SourceFileLabel As Label
    Friend WithEvents MapColumnsWizardPage As DevExpress.XtraWizard.WizardPage
End Class
