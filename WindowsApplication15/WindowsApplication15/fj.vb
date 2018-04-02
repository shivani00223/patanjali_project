Public Class fj

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        h.Show()
        Me.Hide()
    End Sub

    Private Sub fj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet34.fruitjuice' table. You can move, or remove it, as needed.
        Me.FruitjuiceTableAdapter.Fill(Me.PatanjaliDataSet34.fruitjuice)

    End Sub
End Class