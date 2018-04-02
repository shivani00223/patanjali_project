Public Class jm

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        groc.Show()
        Me.Hide()


    End Sub

    Private Sub jm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet49.jam' table. You can move, or remove it, as needed.
        Me.JamTableAdapter.Fill(Me.PatanjaliDataSet49.jam)

    End Sub
End Class