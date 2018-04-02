Public Class soap

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        pers.Show()
        Me.Hide()
    End Sub

    Private Sub soap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet71.soap' table. You can move, or remove it, as needed.
        Me.SoapTableAdapter.Fill(Me.PatanjaliDataSet71.soap)

    End Sub
End Class