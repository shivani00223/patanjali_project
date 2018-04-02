Public Class diet

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        lt.Show()
        Me.Hide()
    End Sub

    Private Sub diet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet28.Rosteddiet' table. You can move, or remove it, as needed.
        Me.RosteddietTableAdapter.Fill(Me.PatanjaliDataSet28.Rosteddiet)

    End Sub
End Class