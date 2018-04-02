Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class reg

    Dim PhoneValid As Boolean

    Private Property Namevalid As Boolean

    Private Property passwordvalid As Boolean

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub reg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox1.Text = "" Or MaskedTextBox1.Text = "" Or TextBox7.Text = "" Or TextBox6.Text = "") Then
            MessageBox.Show("enter somthing in textbox")
        End If


        Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\vb.net\Visual Studio 2010\WindowsApplication15\WindowsApplication15\patanjali.mdf;Integrated Security=True;User Instance=True ")

        Dim cmd As String
        cmd = "insert into reg(u_name,f_name,m_name,u_id,u_pass,u_aadhar,u_address,mobile)values('" & TextBox2.Text & "','" & TextBox3.Text & " ', '" & TextBox4.Text & "','" & TextBox5.Text & "','" & MaskedTextBox1.Text & "','" & TextBox7.Text & "''" & TextBox6.Text & "',)"
        Dim cmd1 As String = "insert into login(userid,password)values('" & TextBox5.Text & "','" & TextBox1.Text & "')"
        Dim command As New SqlCommand(cmd, con)
        Dim command1 As New SqlCommand(cmd1, con)
        con.Open()
        'Check Data Insertion
        If (command1.ExecuteNonQuery = 1) Then
            MsgBox("data inserted successfully")

        Else
            MsgBox("error")
        End If





        ' If TextBox6.Text.Length <> 10 Then
        'MsgBox("phone number must be 10 character long")
        ' Else
        ' MsgBox("valid phonenumber")
        ' End If

    End Sub


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



        'If Not A Matching Format Entered
        If Not Regex.Match(TextBox2.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then 'Only Letters

            MessageBox.Show("Please Enter Alphabetic Characters Only!") 'Inform User

            TextBox2.Focus() 'Return Focus
            TextBox2.Clear() 'Clear TextBox

            Namevalid = False 'Boolean = False
        Else

            Namevalid = True 'Everything Fine

        End If


    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        '  If (TextBox3.Text = "") Then
        'MessageBox.Show("Enter Some Text in TextBox1")

        'If Not A Matching Format Entered
        If Not Regex.Match(TextBox3.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then 'Only Letters



            MessageBox.Show("Please Enter Alphabetic Characters Only!") 'Inform User

            TextBox3.Focus() 'Return Focus
            TextBox3.Clear() 'Clear TextBox

            Namevalid = False 'Boolean = False
        Else

            Namevalid = True 'Everything Fine

        End If



    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        'If Not A Matching Format Entered
        If Not Regex.Match(TextBox4.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then 'Only Letters

            MessageBox.Show("Please Enter Alphabetic Characters Only!") 'Inform User

            TextBox4.Focus() 'Return Focus
            TextBox4.Clear() 'Clear TextBox

            Namevalid = False 'Boolean = False
        Else

            Namevalid = True 'Everything Fine
        End If



    End Sub
    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress



        Dim disallowedChars As String = ",<.>/?;:'][}{=+-_)(*&^%$#@!~'"


        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
            MsgBox("Phone number mus be nu(mber only")
            TextBox6.BackColor = Color.Red
            TextBox6.ForeColor = Color.White
        ElseIf disallowedChars.Contains(e.KeyChar.ToString.ToLower) Then
            e.KeyChar = ChrW(0)
            e.Handled = True
            MsgBox("PHONENUMBER MUST BE NUMBER ONLY")
            TextBox6.BackColor = Color.Red
            TextBox6.ForeColor = Color.White

            TextBox6.BackColor = Color.Red
            TextBox6.ForeColor = Color.White
            'If TextBox6.Text.Length <> 10 Then
            ' MsgBox("phone number must be 10 character long")
            ' Else
            ' MsgBox("valid phonenumber")
            'End If

        End If





        '
    End Sub




    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Function Nullable() As Object
        Throw New NotImplementedException
    End Function

    Private Sub reg_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If Not Regex.Match(TextBox2.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then 'Only Letters



            MessageBox.Show("Please Enter Alphabetic Characters Only!") 'Inform User

            TextBox2.Focus() 'Return Focus
            TextBox2.Clear() 'Clear TextBox

            Namevalid = False 'Boolean = False
        Else

            Namevalid = True 'Everything Fine

        End If



    End Sub

End Class
