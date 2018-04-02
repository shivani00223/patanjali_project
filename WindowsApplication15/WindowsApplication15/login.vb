Imports System.Data.SqlClient

Imports System.Data.SqlClient.SqlDataReader

Public Class login

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mainpage.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        reg.Show()
        Me.Hide()
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = ("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\vb.net\Visual Studio 2010\WindowsApplication15\WindowsApplication15\patanjali.mdf;Integrated Security=True;User Instance=True")
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select userid, password from login where userid='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'"
        If (TextBox1.Text = "" Or TextBox2.Text = "") Then
            MessageBox.Show("enter name and password")
        Else
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                mainpage.Show()
                Me.Hide()
            End If
            If (TextBox1.Text = "" Or TextBox2.Text = "") Then
                MessageBox.Show("user name and password incorrect")
            End If
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        reg.Show()
        Me.Hide()
    End Sub
End Class
