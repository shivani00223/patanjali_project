Public Class chy

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        h.Show()
        Me.Hide()


    End Sub

    Private Sub chy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet21.chywanprash' table. You can move, or remove it, as needed.
        Me.ChywanprashTableAdapter.Fill(Me.PatanjaliDataSet21.chywanprash)

    End Sub
End Class