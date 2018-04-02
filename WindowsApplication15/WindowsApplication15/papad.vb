Public Class papad

    Private Sub papad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet58.Papad' table. You can move, or remove it, as needed.
        Me.PapadTableAdapter.Fill(Me.PatanjaliDataSet58.Papad)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        groc.Show()
        Me.Hide()

    End Sub
End Class