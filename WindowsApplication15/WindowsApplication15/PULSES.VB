Public Class PULSES

    Private Sub PULSES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet64.Pulses' table. You can move, or remove it, as needed.
        Me.PulsesTableAdapter.Fill(Me.PatanjaliDataSet64.Pulses)

    End Sub

    Private Sub ListBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class