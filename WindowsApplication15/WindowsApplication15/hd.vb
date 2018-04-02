Public Class hd

    Private Sub hd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet44.healthdrink' table. You can move, or remove it, as needed.
        Me.HealthdrinkTableAdapter.Fill(Me.PatanjaliDataSet44.healthdrink)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        h.Show()
        Me.Hide()

    End Sub
End Class