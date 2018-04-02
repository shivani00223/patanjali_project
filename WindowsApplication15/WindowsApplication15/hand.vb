Public Class hand

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        pers.Show()
        Me.Hide()
    End Sub

    Private Sub hand_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet42.handwash' table. You can move, or remove it, as needed.
        Me.HandwashTableAdapter.Fill(Me.PatanjaliDataSet42.handwash)

    End Sub
End Class