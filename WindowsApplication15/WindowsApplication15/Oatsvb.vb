Public Class Oatsvb

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        groc.Show()
        Me.Hide()
    End Sub

    Private Sub Oatsvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet56.oats' table. You can move, or remove it, as needed.
        Me.OatsTableAdapter.Fill(Me.PatanjaliDataSet56.oats)

    End Sub
End Class