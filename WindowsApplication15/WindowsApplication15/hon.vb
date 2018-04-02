Public Class hon

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        h.Show()
        Me.Hide()
    End Sub

    Private Sub hon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet46.honey' table. You can move, or remove it, as needed.
        Me.HoneyTableAdapter.Fill(Me.PatanjaliDataSet46.honey)

    End Sub
End Class