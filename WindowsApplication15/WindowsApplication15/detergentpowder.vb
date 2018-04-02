Public Class detergentpowder

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        pers.Show()
        Me.Hide()
    End Sub

    Private Sub detergentpowder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet26.DetergentPowder' table. You can move, or remove it, as needed.
        Me.DetergentPowderTableAdapter.Fill(Me.PatanjaliDataSet26.DetergentPowder)

    End Sub
End Class