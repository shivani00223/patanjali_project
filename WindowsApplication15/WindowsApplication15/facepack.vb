Public Class facepack

    Private Sub facepack_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet32.Facepack' table. You can move, or remove it, as needed.
        Me.FacepackTableAdapter.Fill(Me.PatanjaliDataSet32.Facepack)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        pers.Show()
        Me.Hide()
    End Sub
End Class