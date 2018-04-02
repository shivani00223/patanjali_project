<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eye
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.Items.AddRange(New Object() {"Eye Care / आंख की देखभाल" & Global.Microsoft.VisualBasic.ChrW(9) & "Drishti Eye Drop / दृष्टि ऑय ड्राप" & Global.Microsoft.VisualBasic.ChrW(9) & "15 ml" & Global.Microsoft.VisualBasic.ChrW(9) & "25 Rs", "Herbal Kajal / हर्बल काजल" & Global.Microsoft.VisualBasic.ChrW(9) & "3 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "90 Rs", "Mahatrifala Ghrit / महात्रिफला घृत" & Global.Microsoft.VisualBasic.ChrW(9) & "200 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "380 Rs"})
        Me.ListBox5.Location = New System.Drawing.Point(82, 83)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(120, 95)
        Me.ListBox5.TabIndex = 5
        '
        'eye
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ListBox5)
        Me.Name = "eye"
        Me.Text = "eye"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox5 As System.Windows.Forms.ListBox
End Class
