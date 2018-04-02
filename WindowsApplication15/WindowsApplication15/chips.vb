Public Class chips

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        lt.Show()
        Me.Hide()
    End Sub

    Private Sub chips_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet20.soyavitachups' table. You can move, or remove it, as needed.
        Me.SoyavitachupsTableAdapter.Fill(Me.PatanjaliDataSet20.soyavitachups)

    End Sub
End Class