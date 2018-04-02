Public Class Bdaampista

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        lt.Show()
        Me.Hide()
    End Sub

    Private Sub Bdaampista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet83.Bdaampista' table. You can move, or remove it, as needed.
        Me.BdaampistaTableAdapter.Fill(Me.PatanjaliDataSet83.Bdaampista)

    End Sub
End Class