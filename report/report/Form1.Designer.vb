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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.collegeDataSet1 = New report.collegeDataSet1()
        Me.studentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.studentTableAdapter = New report.collegeDataSet1TableAdapters.studentTableAdapter()
        CType(Me.collegeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.studentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.studentBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "report.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(627, 349)
        Me.ReportViewer1.TabIndex = 0
        '
        'collegeDataSet1
        '
        Me.collegeDataSet1.DataSetName = "collegeDataSet1"
        Me.collegeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'studentBindingSource
        '
        Me.studentBindingSource.DataMember = "student"
        Me.studentBindingSource.DataSource = Me.collegeDataSet1
        '
        'studentTableAdapter
        '
        Me.studentTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 386)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.collegeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.studentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents studentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents collegeDataSet1 As report.collegeDataSet1
    Friend WithEvents studentTableAdapter As report.collegeDataSet1TableAdapters.studentTableAdapter

End Class
