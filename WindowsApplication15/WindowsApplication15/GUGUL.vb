Public Class GUGUL

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        medic.Show()
        Me.Hide()


    End Sub

    Private Sub GUGUL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet40.Guguul' table. You can move, or remove it, as needed.
        Me.GuguulTableAdapter.Fill(Me.PatanjaliDataSet40.Guguul)

    End Sub
End Class