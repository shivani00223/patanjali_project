Public Class ghi

    Private Sub ghi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet37.ghee' table. You can move, or remove it, as needed.
        Me.GheeTableAdapter.Fill(Me.PatanjaliDataSet37.ghee)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        h.Show()
        Me.Hide()

    End Sub
End Class