Public Class candy

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        groc.Show()
        Me.Hide()

    End Sub

    Private Sub candy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet16.candy' table. You can move, or remove it, as needed.
        Me.CandyTableAdapter.Fill(Me.PatanjaliDataSet16.candy)

    End Sub
End Class