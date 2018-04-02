Public Class BROKEN

    Private Sub BROKEN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet14.Broken_Cereals' table. You can move, or remove it, as needed.
        Me.Broken_CerealsTableAdapter.Fill(Me.PatanjaliDataSet14.Broken_Cereals)

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        groc.Show()
        Me.Hide()
    End Sub
End Class