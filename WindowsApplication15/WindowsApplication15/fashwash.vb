Public Class fashwash

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        pers.Show()
        Me.Hide()
    End Sub

    Private Sub fashwash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet33.facewash' table. You can move, or remove it, as needed.
        Me.FacewashTableAdapter.Fill(Me.PatanjaliDataSet33.facewash)

    End Sub
End Class