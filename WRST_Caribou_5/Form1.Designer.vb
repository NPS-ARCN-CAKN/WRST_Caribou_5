<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.AccessRadiotrackingDatasetButton = New System.Windows.Forms.Button()
        Me.OpenAnimalObservationsFormButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MainFormBottomToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.UserToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ConnectionStringToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.OpenCensusDatasetFormButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenCaribouDetailsFormButton = New System.Windows.Forms.Button()
        Me.ImportDataButton = New System.Windows.Forms.Button()
        Me.MainFormBottomToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'AccessRadiotrackingDatasetButton
        '
        Me.AccessRadiotrackingDatasetButton.Location = New System.Drawing.Point(12, 31)
        Me.AccessRadiotrackingDatasetButton.Name = "AccessRadiotrackingDatasetButton"
        Me.AccessRadiotrackingDatasetButton.Size = New System.Drawing.Size(322, 23)
        Me.AccessRadiotrackingDatasetButton.TabIndex = 0
        Me.AccessRadiotrackingDatasetButton.Text = "Radiotracking dataset..."
        Me.AccessRadiotrackingDatasetButton.UseVisualStyleBackColor = True
        '
        'OpenAnimalObservationsFormButton
        '
        Me.OpenAnimalObservationsFormButton.Location = New System.Drawing.Point(12, 60)
        Me.OpenAnimalObservationsFormButton.Name = "OpenAnimalObservationsFormButton"
        Me.OpenAnimalObservationsFormButton.Size = New System.Drawing.Size(322, 23)
        Me.OpenAnimalObservationsFormButton.TabIndex = 1
        Me.OpenAnimalObservationsFormButton.Text = "Animal observations dataset..."
        Me.OpenAnimalObservationsFormButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data access:"
        '
        'MainFormBottomToolStrip
        '
        Me.MainFormBottomToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MainFormBottomToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.UserToolStripLabel, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.ConnectionStringToolStripLabel})
        Me.MainFormBottomToolStrip.Location = New System.Drawing.Point(0, 318)
        Me.MainFormBottomToolStrip.Name = "MainFormBottomToolStrip"
        Me.MainFormBottomToolStrip.Size = New System.Drawing.Size(349, 25)
        Me.MainFormBottomToolStrip.TabIndex = 3
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(33, 22)
        Me.ToolStripLabel1.Text = "User:"
        '
        'UserToolStripLabel
        '
        Me.UserToolStripLabel.Name = "UserToolStripLabel"
        Me.UserToolStripLabel.Size = New System.Drawing.Size(60, 22)
        Me.UserToolStripLabel.Text = "Username"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripLabel2.Text = "Database:"
        '
        'ConnectionStringToolStripLabel
        '
        Me.ConnectionStringToolStripLabel.Name = "ConnectionStringToolStripLabel"
        Me.ConnectionStringToolStripLabel.Size = New System.Drawing.Size(100, 22)
        Me.ConnectionStringToolStripLabel.Text = "ConnectionString"
        '
        'OpenCensusDatasetFormButton
        '
        Me.OpenCensusDatasetFormButton.Location = New System.Drawing.Point(12, 89)
        Me.OpenCensusDatasetFormButton.Name = "OpenCensusDatasetFormButton"
        Me.OpenCensusDatasetFormButton.Size = New System.Drawing.Size(322, 23)
        Me.OpenCensusDatasetFormButton.TabIndex = 4
        Me.OpenCensusDatasetFormButton.Text = "Census dataset..."
        Me.OpenCensusDatasetFormButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Quality control:"
        '
        'OpenCaribouDetailsFormButton
        '
        Me.OpenCaribouDetailsFormButton.Location = New System.Drawing.Point(15, 142)
        Me.OpenCaribouDetailsFormButton.Name = "OpenCaribouDetailsFormButton"
        Me.OpenCaribouDetailsFormButton.Size = New System.Drawing.Size(322, 23)
        Me.OpenCaribouDetailsFormButton.TabIndex = 5
        Me.OpenCaribouDetailsFormButton.Text = "View a caribou's details..."
        Me.OpenCaribouDetailsFormButton.UseVisualStyleBackColor = True
        '
        'ImportDataButton
        '
        Me.ImportDataButton.Location = New System.Drawing.Point(16, 182)
        Me.ImportDataButton.Name = "ImportDataButton"
        Me.ImportDataButton.Size = New System.Drawing.Size(322, 23)
        Me.ImportDataButton.TabIndex = 7
        Me.ImportDataButton.Text = "Import data..."
        Me.ImportDataButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 343)
        Me.Controls.Add(Me.ImportDataButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OpenCaribouDetailsFormButton)
        Me.Controls.Add(Me.OpenCensusDatasetFormButton)
        Me.Controls.Add(Me.MainFormBottomToolStrip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OpenAnimalObservationsFormButton)
        Me.Controls.Add(Me.AccessRadiotrackingDatasetButton)
        Me.Name = "Form1"
        Me.Text = "Caribou monitoring database for Wrangell - St. Elias National Park and Preserve"
        Me.MainFormBottomToolStrip.ResumeLayout(False)
        Me.MainFormBottomToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AccessRadiotrackingDatasetButton As Button
    Friend WithEvents OpenAnimalObservationsFormButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MainFormBottomToolStrip As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents UserToolStripLabel As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ConnectionStringToolStripLabel As ToolStripLabel
    Friend WithEvents OpenCensusDatasetFormButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenCaribouDetailsFormButton As Button
    Friend WithEvents ImportDataButton As Button
End Class
