Public Class lotion

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        lt.Show()
        Me.Hide()
    End Sub

    Private Sub lotion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet52.bodylotion' table. You can move, or remove it, as needed.
        Me.BodylotionTableAdapter.Fill(Me.PatanjaliDataSet52.bodylotion)

    End Sub
End Class