Public Class gulcose

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        lt.Show()
        Me.Hide()
    End Sub

    Private Sub gulcose_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet41.gulcoseshakti' table. You can move, or remove it, as needed.
        Me.GulcoseshaktiTableAdapter.Fill(Me.PatanjaliDataSet41.gulcoseshakti)

    End Sub
End Class