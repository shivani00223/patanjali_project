Public Class Rewari

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        lt.Show()
        Me.Hide()

    End Sub

    Private Sub Rewari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet65.Rewari' table. You can move, or remove it, as needed.
        Me.RewariTableAdapter.Fill(Me.PatanjaliDataSet65.Rewari)

    End Sub
End Class