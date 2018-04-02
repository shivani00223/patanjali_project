Public Class CF

    Private Sub ListBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        groc.Show()
        Me.Hide()
    End Sub

    Private Sub CF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet17.Corn_Flakes' table. You can move, or remove it, as needed.
        Me.Corn_FlakesTableAdapter.Fill(Me.PatanjaliDataSet17.Corn_Flakes)

    End Sub
End Class