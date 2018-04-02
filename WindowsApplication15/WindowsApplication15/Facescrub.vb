Public Class Facescrub

    Private Sub Facescrub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet82.facesrub' table. You can move, or remove it, as needed.
        Me.FacesrubTableAdapter.Fill(Me.PatanjaliDataSet82.facesrub)

    End Sub
End Class