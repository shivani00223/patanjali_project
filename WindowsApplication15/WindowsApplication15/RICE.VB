Public Class RICE

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        groc.Show()
        Me.Hide()
    End Sub

    Private Sub RICE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet66.Rice' table. You can move, or remove it, as needed.
        Me.RiceTableAdapter.Fill(Me.PatanjaliDataSet66.Rice)

    End Sub
End Class