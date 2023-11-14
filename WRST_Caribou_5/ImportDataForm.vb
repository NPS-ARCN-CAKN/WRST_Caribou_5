Imports System.IO

Public Class ImportDataForm

    Private SourceFileInfoValue As FileInfo
    Public Property SourceFileInfo() As FileInfo
        Get
            Return SourceFileInfoValue
        End Get
        Set(ByVal value As FileInfo)
            SourceFileInfoValue = value
        End Set
    End Property

    Private SourceDataTableValue As DataTable
    Public Property SourceDataTable() As DataTable
        Get
            Return SourceDataTableValue
        End Get
        Set(ByVal value As DataTable)
            SourceDataTableValue = value
        End Set
    End Property

    Private Sub SelectSourceFileWelcomeWizardPage_PageCommit(sender As Object, e As EventArgs) Handles SelectSourceFileWelcomeWizardPage.PageCommit


    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        Me.SourceFileLabel.Text = ""
        Try
            Dim Filter As String = "Comma separated values text files (*.csv)|*.csv"
            'Filter = "Spatial data file|*.poz;*.csv;*.shp" 'Filter to multiple file types
            Dim OFD As New OpenFileDialog
            With OFD
                '.ShowHelp = True
                '.AddExtension = True
                '.CheckFileExists = True
                .Filter = Filter
                '.Multiselect = False
                .Title = "Select a file"
                .InitialDirectory = "C:\Work\VitalSigns\CAKN Caribou\WRST\Data"
            End With

            'show the ofd and get the filename and path
            If OFD.ShowDialog = DialogResult.OK Then
                Dim SourceFile As String = OFD.FileName
                Me.SourceFileLabel.Text = SourceFile
                Me.SourceFileInfo = New FileInfo(SourceFile)
                Dim DT As DataTable = GetDataTableFromCSV(Me.SourceFileInfo)
                Me.SourceDataTable = DT
                Me.SourceDataGridView.DataSource = DT
            End If

        Catch ex As Exception
            Me.SourceFileLabel.Text = ex.Message
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try


    End Sub


End Class