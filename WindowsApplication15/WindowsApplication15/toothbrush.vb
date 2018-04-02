Public Class toothbrush

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        pers.Show()
        Me.Hide()
    End Sub

    Private Sub toothbrush_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet78.toothbrush' table. You can move, or remove it, as needed.
        Me.ToothbrushTableAdapter.Fill(Me.PatanjaliDataSet78.toothbrush)

    End Sub
End Class