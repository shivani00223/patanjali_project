Public Class suger

    Private Sub suger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet75.Sugar' table. You can move, or remove it, as needed.
        Me.SugarTableAdapter.Fill(Me.PatanjaliDataSet75.Sugar)

    End Sub
End Class