<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shaving
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
        Me.ListBox11 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBox11
        '
        Me.ListBox11.FormattingEnabled = True
        Me.ListBox11.Items.AddRange(New Object() {"-Shaving Cream / शेविंग क्रीम" & Global.Microsoft.VisualBasic.ChrW(9) & "Herbal Shaving Cream / हर्बल शेविंग क्रीम" & Global.Microsoft.VisualBasic.ChrW(9) & "100 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "55" & _
                        " Rs", "Shave Gel / शेव ज़ैल" & Global.Microsoft.VisualBasic.ChrW(9) & "50 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "40 Rs", "Patanjali Activated Carbon Facial Foam / एक्टिवेटिड कार्बन फेसिअल फोम" & Global.Microsoft.VisualBasic.ChrW(9) & "60 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "60 Rs" & _
                        "", "Hair Care / बालों की देखभाल" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.ListBox11.Location = New System.Drawing.Point(82, 50)
        Me.ListBox11.Name = "ListBox11"
        Me.ListBox11.Size = New System.Drawing.Size(120, 160)
        Me.ListBox11.TabIndex = 11
        '
        'shaving
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ListBox11)
        Me.Name = "shaving"
        Me.Text = "shaving"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox11 As System.Windows.Forms.ListBox
End Class
