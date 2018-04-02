Public Class patanjlioil

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        medic.Show()
        Me.Hide()


    End Sub

    Private Sub patanjlioil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet61.medicoil' table. You can move, or remove it, as needed.
        Me.MedicoilTableAdapter.Fill(Me.PatanjaliDataSet61.medicoil)

    End Sub
End Class