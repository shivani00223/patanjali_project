Public Class agervati

    Private Sub agervati_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet6.agervati' table. You can move, or remove it, as needed.
        Me.AgervatiTableAdapter.Fill(Me.PatanjaliDataSet6.agervati)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        hm.Show()
        Me.Hide()


    End Sub
End Class