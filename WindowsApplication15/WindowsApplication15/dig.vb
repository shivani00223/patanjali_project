Public Class dig_vb

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        h.Show()
        Me.Hide()

    End Sub

    Private Sub dig_vb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet29.Digestives' table. You can move, or remove it, as needed.
        Me.DigestivesTableAdapter.Fill(Me.PatanjaliDataSet29.Digestives)

    End Sub
End Class