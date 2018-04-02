Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter

Public Class arishta






    'Private Sub arishta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'PatanjaliDataSet5.arishta' table. You can move, or remove it, as needed.
    ' Me.ArishtaTableAdapter.Fill(Me.PatanjaliDataSet5.arishta)

    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\vb.net\Visual Studio 2010\WindowsApplication15\WindowsApplication15\patanjali.mdf;Integrated Security=True;User Instance=True ")

        Dim cmd As String
        cmd = "select * from arishta where productname='" & CheckedListBox1.SelectedItem & "' "
        con.Open()

        'Dim dr As SqlDataReader

        Dim command As New SqlCommand(cmd, con)

        'dr = command.ExecuteReader
        'Dim dr A commandNaexecu , con)
        Dim dt As New DataTable

        'dr.Fill(dt)

        Dim da As New SqlDataAdapter(cmd, con)

        da.Fill(dt)

        'datar = command.ExecuteReader()
        'If (datar.HasRows) Then
        'While (datar.Read())
        'ListBox1.Items.Add(datar(0))
        DataGridView2.DataSource = dt

        'End While
        'End If
        'con.Close()        ' Command.ExecuteNonQuery()



    End Sub



    Private Sub test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet3.vati' table. You can move, or remove it, as needed.
        'Me.ArishtaTableAdapter.Fill(Me.PatanjaliDataSet3.vati)

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        medic.Show()
        Me.Hide()
    End Sub
End Class