Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'collegeDataSet1.student' table. You can move, or remove it, as needed.
        Me.studentTableAdapter.Fill(Me.collegeDataSet1.student)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
