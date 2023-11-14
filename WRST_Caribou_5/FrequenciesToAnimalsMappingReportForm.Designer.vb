<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrequenciesToAnimalsMappingReportForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrequenciesToAnimalsMappingReportForm))
        Me.ReportDataGridView = New System.Windows.Forms.DataGridView()
        Me.ReportPanel = New System.Windows.Forms.Panel()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.InsertTheGroupsButton = New System.Windows.Forms.Button()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.FrequenciesTabPage = New System.Windows.Forms.TabPage()
        Me.SQLScriptTabPage = New System.Windows.Forms.TabPage()
        Me.SqlTextBox = New System.Windows.Forms.TextBox()
        CType(Me.ReportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReportPanel.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.FrequenciesTabPage.SuspendLayout()
        Me.SQLScriptTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportDataGridView
        '
        Me.ReportDataGridView.AllowUserToAddRows = False
        Me.ReportDataGridView.AllowUserToDeleteRows = False
        Me.ReportDataGridView.AllowUserToOrderColumns = True
        Me.ReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ReportDataGridView.Name = "ReportDataGridView"
        Me.ReportDataGridView.ReadOnly = True
        Me.ReportDataGridView.Size = New System.Drawing.Size(786, 316)
        Me.ReportDataGridView.TabIndex = 0
        '
        'ReportPanel
        '
        Me.ReportPanel.Controls.Add(Me.InsertTheGroupsButton)
        Me.ReportPanel.Controls.Add(Me.CloseButton)
        Me.ReportPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ReportPanel.Location = New System.Drawing.Point(0, 408)
        Me.ReportPanel.Name = "ReportPanel"
        Me.ReportPanel.Size = New System.Drawing.Size(800, 42)
        Me.ReportPanel.TabIndex = 1
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(713, 6)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'InsertTheGroupsButton
        '
        Me.InsertTheGroupsButton.Location = New System.Drawing.Point(12, 6)
        Me.InsertTheGroupsButton.Name = "InsertTheGroupsButton"
        Me.InsertTheGroupsButton.Size = New System.Drawing.Size(307, 23)
        Me.InsertTheGroupsButton.TabIndex = 1
        Me.InsertTheGroupsButton.Text = "Associate the caribou above with the group"
        Me.InsertTheGroupsButton.UseVisualStyleBackColor = True
        '
        'HeaderPanel
        '
        Me.HeaderPanel.Controls.Add(Me.HeaderLabel)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(800, 60)
        Me.HeaderPanel.TabIndex = 2
        '
        'HeaderLabel
        '
        Me.HeaderLabel.Location = New System.Drawing.Point(12, 9)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(776, 44)
        Me.HeaderLabel.TabIndex = 0
        Me.HeaderLabel.Text = resources.GetString("HeaderLabel.Text")
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.FrequenciesTabPage)
        Me.TabControl1.Controls.Add(Me.SQLScriptTabPage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 60)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 348)
        Me.TabControl1.TabIndex = 3
        '
        'FrequenciesTabPage
        '
        Me.FrequenciesTabPage.Controls.Add(Me.ReportDataGridView)
        Me.FrequenciesTabPage.Location = New System.Drawing.Point(4, 22)
        Me.FrequenciesTabPage.Name = "FrequenciesTabPage"
        Me.FrequenciesTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.FrequenciesTabPage.Size = New System.Drawing.Size(792, 322)
        Me.FrequenciesTabPage.TabIndex = 0
        Me.FrequenciesTabPage.Text = "Frequencies to animals mapping"
        Me.FrequenciesTabPage.UseVisualStyleBackColor = True
        '
        'SQLScriptTabPage
        '
        Me.SQLScriptTabPage.Controls.Add(Me.SqlTextBox)
        Me.SQLScriptTabPage.Location = New System.Drawing.Point(4, 22)
        Me.SQLScriptTabPage.Name = "SQLScriptTabPage"
        Me.SQLScriptTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SQLScriptTabPage.Size = New System.Drawing.Size(792, 322)
        Me.SQLScriptTabPage.TabIndex = 1
        Me.SQLScriptTabPage.Text = "Database modification script"
        Me.SQLScriptTabPage.UseVisualStyleBackColor = True
        '
        'SqlTextBox
        '
        Me.SqlTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SqlTextBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SqlTextBox.Location = New System.Drawing.Point(3, 3)
        Me.SqlTextBox.Multiline = True
        Me.SqlTextBox.Name = "SqlTextBox"
        Me.SqlTextBox.ReadOnly = True
        Me.SqlTextBox.Size = New System.Drawing.Size(786, 316)
        Me.SqlTextBox.TabIndex = 0
        '
        'FrequenciesToAnimalsMappingReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.ReportPanel)
        Me.Name = "FrequenciesToAnimalsMappingReportForm"
        Me.Text = "Frequencies to Animals mapping report"
        CType(Me.ReportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReportPanel.ResumeLayout(False)
        Me.HeaderPanel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.FrequenciesTabPage.ResumeLayout(False)
        Me.SQLScriptTabPage.ResumeLayout(False)
        Me.SQLScriptTabPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportDataGridView As DataGridView
    Friend WithEvents ReportPanel As Panel
    Friend WithEvents InsertTheGroupsButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents FrequenciesTabPage As TabPage
    Friend WithEvents SQLScriptTabPage As TabPage
    Friend WithEvents SqlTextBox As TextBox
End Class
