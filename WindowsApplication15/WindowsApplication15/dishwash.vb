Public Class dishwash

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        hm.Show()
        Me.Hide()

    End Sub

    Private Sub dishwash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet30.dishwash' table. You can move, or remove it, as needed.
        Me.DishwashTableAdapter.Fill(Me.PatanjaliDataSet30.dishwash)

    End Sub
End Class