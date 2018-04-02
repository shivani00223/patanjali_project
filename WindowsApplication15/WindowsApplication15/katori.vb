Public Class katori

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        lt.Show()
        Me.Hide()
    End Sub

    Private Sub katori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet73.soyavitastick' table. You can move, or remove it, as needed.
        Me.SoyavitastickTableAdapter.Fill(Me.PatanjaliDataSet73.soyavitastick)

    End Sub
End Class