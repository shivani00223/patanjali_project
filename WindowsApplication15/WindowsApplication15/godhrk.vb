Public Class godhrk

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        medic.Show()
        Me.Hide()

    End Sub

    Private Sub godhrk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet38.GodhanArk' table. You can move, or remove it, as needed.
        Me.GodhanArkTableAdapter.Fill(Me.PatanjaliDataSet38.GodhanArk)

    End Sub
End Class