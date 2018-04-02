Public Class childcare

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        pers.Show()
        Me.Hide()
    End Sub

    Private Sub childcare_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet19.ChildCare' table. You can move, or remove it, as needed.
        Me.ChildCareTableAdapter.Fill(Me.PatanjaliDataSet19.ChildCare)

    End Sub
End Class