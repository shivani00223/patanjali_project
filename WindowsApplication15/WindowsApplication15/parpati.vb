Public Class parpati

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        medic.Show()
        Me.Hide()
    End Sub

    Private Sub parpati_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet59.ParpatiRas' table. You can move, or remove it, as needed.
        Me.ParpatiRasTableAdapter.Fill(Me.PatanjaliDataSet59.ParpatiRas)

    End Sub
End Class