Public Class SOAN

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        groc.Show()
        Me.Hide()
    End Sub

    Private Sub SOAN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet70.Soan_Papdi' table. You can move, or remove it, as needed.
        Me.Soan_PapdiTableAdapter.Fill(Me.PatanjaliDataSet70.Soan_Papdi)

    End Sub
End Class