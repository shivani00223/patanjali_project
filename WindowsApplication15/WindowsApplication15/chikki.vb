Public Class chikki

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        lt.Show()
        Me.Hide()
    End Sub

    Private Sub chikki_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet18.chikki' table. You can move, or remove it, as needed.
        Me.ChikkiTableAdapter.Fill(Me.PatanjaliDataSet18.chikki)

    End Sub
End Class