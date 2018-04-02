<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bodycare
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
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Items.AddRange(New Object() {"Body Care / शरीर की देखभाल" & Global.Microsoft.VisualBasic.ChrW(9) & "Body Ubtan / बॉडी उबटन" & Global.Microsoft.VisualBasic.ChrW(9) & "100 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "60 Rs", "Lip Balm Strawberry / लिप बाम स्ट्रॉबेरी" & Global.Microsoft.VisualBasic.ChrW(9) & "10 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "25 Rs", "Gulab Jal / गुलाब जल" & Global.Microsoft.VisualBasic.ChrW(9) & "120 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "30 Rs", "Herbal Suhag Teeka / हर्बल सुहाग टीका" & Global.Microsoft.VisualBasic.ChrW(9) & " 3 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "75 Rs", "Peedantak Oil / पीड़ान्तक आयल" & Global.Microsoft.VisualBasic.ChrW(9) & "100 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "60 Rs", "Switraghan Lep / स्विटरघन लेप" & Global.Microsoft.VisualBasic.ChrW(9) & "100 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "40 Rs", " -Soaps / साबुन" & Global.Microsoft.VisualBasic.ChrW(9) & "Aquafresh Body Cleanser / अक्वाफ्रेश बॉडी कलींज़र" & Global.Microsoft.VisualBasic.ChrW(9) & "75 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "24 Rs"})
        Me.ListBox2.Location = New System.Drawing.Point(203, 126)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(193, 95)
        Me.ListBox2.TabIndex = 2
        '
        'bodycare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 587)
        Me.Controls.Add(Me.ListBox2)
        Me.Name = "bodycare"
        Me.Text = "bodycare"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
End Class
