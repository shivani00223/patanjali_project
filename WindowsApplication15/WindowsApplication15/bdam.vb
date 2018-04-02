Imports System.Data.SqlClient

Public Class bdam

    Private Sub bdam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet84.badampak' table. You can move, or remove it, as needed.
        Me.BadampakTableAdapter.Fill(Me.PatanjaliDataSet84.badampak)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        h.Show()
        Me.Hide()
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\vb.net\Visual Studio 2010\WindowsApplication15\WindowsApplication15\patanjali.mdf;Integrated Security=True;User Instance=True ")

        Dim cmd As String
        cmd = "select * from badampak where Product_Name='" & ListBox1.SelectedItem & "' "
        con.Open()
        'Dim command As New SqlCommand(cmd, con)
        'Dim dt As New DataTable
        Dim dt As New DataTable
        Dim dr As New SqlDataAdapter(cmd, con)

        dr.Fill(dt)



        'Dim da As New SqlDataAdapter(cmd, con)

        'da.Fill(dt)

        'datar = command.ExecuteReader()
        'If (datar.HasRows) Then
        'While (datar.Read())
        'ListBox1.Items.Add(datar(0))
        DataGridView1.DataSource = dt

        'End While
        'End If

        con.Close()        ' Command.ExecuteNonQuery()



    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet3.vati' table. You can move, or remove it, as needed.
        'Me.bdaamTableAdapter.Fill(Me.PatanjaliDataSet3.vati)



    End Sub
End Class