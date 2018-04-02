Public Class condi

    Private Sub condi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet23.conditioner' table. You can move, or remove it, as needed.
        Me.ConditionerTableAdapter.Fill(Me.PatanjaliDataSet23.conditioner)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        pers.Show()
        Me.Hide()
    End Sub
End Class