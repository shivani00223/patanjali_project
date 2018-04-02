Public Class spice

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        groc.Show()
        Me.Hide()
    End Sub

    Private Sub spice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet74.spices' table. You can move, or remove it, as needed.
        Me.SpicesTableAdapter.Fill(Me.PatanjaliDataSet74.spices)

    End Sub
End Class