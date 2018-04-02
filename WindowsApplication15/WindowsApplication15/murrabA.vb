Public Class murrabA

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        groc.Show()
        Me.Hide()


    End Sub

    Private Sub murrabA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet54.Murraba' table. You can move, or remove it, as needed.
        Me.MurrabaTableAdapter.Fill(Me.PatanjaliDataSet54.Murraba)

    End Sub
End Class