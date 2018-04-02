Public Class toothpowder

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        pers.Show()
        Me.Hide()
    End Sub

    Private Sub toothpowder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet80.toothPowder' table. You can move, or remove it, as needed.
        Me.ToothPowderTableAdapter.Fill(Me.PatanjaliDataSet80.toothPowder)

    End Sub
End Class