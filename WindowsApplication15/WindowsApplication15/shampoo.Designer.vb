<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shampoo
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"-Shampoo / शैम्पू" & Global.Microsoft.VisualBasic.ChrW(9) & "Kesh Kanti Anti Dandruff Hair Cleanser / केश कान्ति एंटी डैंडरफ" & _
                        " हेयर कलींज़र" & Global.Microsoft.VisualBasic.ChrW(9) & "200 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "110 Rs", "Kesh Kanti Anti Dandruff Pouch / केश कान्ति एंटी डैंडरफ" & Global.Microsoft.VisualBasic.ChrW(9) & "10 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "3 Rs", "Kesh Kanti Milk Protein Hair Cleanser (Pouch) / केश कान्ति मिल्क प्रोटीन पाउच" & Global.Microsoft.VisualBasic.ChrW(9) & "10 " & _
                        "gm" & Global.Microsoft.VisualBasic.ChrW(9) & "3 Rs", "Kesh Kanti Milk Protein / केश कान्ति मिल्क प्रोटीन" & Global.Microsoft.VisualBasic.ChrW(9) & "200 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "95 Rs", "Kesh Kanti Natural  / केश कान्ति नेचुरल" & Global.Microsoft.VisualBasic.ChrW(9) & "200 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "75 Rs", "Kesh Kanti Natural Pouch  / केश कान्ति नेचुरल पाउच" & Global.Microsoft.VisualBasic.ChrW(9) & "8 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "2 Rs", "Kesh Kanti Reetha / केश कान्ति रीठा हेयर कलींज़र" & Global.Microsoft.VisualBasic.ChrW(9) & "200 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "85 Rs", "Kesh Kanti Reetha Hair Cleanser (Pouch) / केश कान्ति रीठा (पाउच)" & Global.Microsoft.VisualBasic.ChrW(9) & "10 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "3 Rs", "Kesh Kanti Shikakai / केश कान्ति शिकाकाई" & Global.Microsoft.VisualBasic.ChrW(9) & "200 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "95 Rs", "Kesh Kanti Aloe Vera Hair Cleanser / केश कान्ति" & Global.Microsoft.VisualBasic.ChrW(9) & "200 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "75 Rs"})
        Me.ListBox1.Location = New System.Drawing.Point(0, 143)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(249, 95)
        Me.ListBox1.TabIndex = 0
        '
        'shampoo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "shampoo"
        Me.Text = "shampoo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
