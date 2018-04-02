Public Class oil

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        pers.Show()
        Me.Hide()
    End Sub

    Private Sub oil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet57.hairoil' table. You can move, or remove it, as needed.
        Me.HairoilTableAdapter.Fill(Me.PatanjaliDataSet57.hairoil)

    End Sub
End Class