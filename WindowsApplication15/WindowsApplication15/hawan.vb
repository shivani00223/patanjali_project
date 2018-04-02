Public Class hawan

    Private Sub hawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet43.hawan' table. You can move, or remove it, as needed.
        Me.HawanTableAdapter.Fill(Me.PatanjaliDataSet43.hawan)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        hm.Show()
        Me.Hide()
    End Sub
End Class