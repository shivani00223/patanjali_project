Public Class herbalTea

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        groc.Show()
        Me.Hide()
    End Sub

    Private Sub herbalTea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet45.herbaltea' table. You can move, or remove it, as needed.
        Me.HerbalteaTableAdapter.Fill(Me.PatanjaliDataSet45.herbaltea)

    End Sub
End Class