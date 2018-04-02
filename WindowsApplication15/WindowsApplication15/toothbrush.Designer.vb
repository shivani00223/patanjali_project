<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class toothbrush
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
        Me.ListBox15 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBox15
        '
        Me.ListBox15.FormattingEnabled = True
        Me.ListBox15.Items.AddRange(New Object() {"Tooth brush / टूथ ब्रश" & Global.Microsoft.VisualBasic.ChrW(9) & "Active Care Tooth Brush / एक्टिव केयर टूथ ब्रश" & Global.Microsoft.VisualBasic.ChrW(9) & "70 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "20 Rs" & _
                        "", "Curvy Tooth Brush / कर्वी  टूथ ब्रश" & Global.Microsoft.VisualBasic.ChrW(9) & "50 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "15 Rs", "Junior Tooth Brush / जूनियर टूथ ब्रश" & Global.Microsoft.VisualBasic.ChrW(9) & "20 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "15 Rs", "Sensitive Tooth Brush /  टूथ ब्रश" & Global.Microsoft.VisualBasic.ChrW(9) & "22 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "30 Rs", "Soft Tooth Brush / सॉफ्ट टूथ ब्रश" & Global.Microsoft.VisualBasic.ChrW(9) & "30 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "10 Rs", "Tooth Brush / टूथ ब्रश" & Global.Microsoft.VisualBasic.ChrW(9) & "10 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "8 Rs", "Triple Action Tooth Brush / ट्रिपल एक्शन टूथ ब्रश" & Global.Microsoft.VisualBasic.ChrW(9) & "90 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "25 Rs"})
        Me.ListBox15.Location = New System.Drawing.Point(82, 83)
        Me.ListBox15.Name = "ListBox15"
        Me.ListBox15.Size = New System.Drawing.Size(120, 95)
        Me.ListBox15.TabIndex = 15
        '
        'toothbrush
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ListBox15)
        Me.Name = "toothbrush"
        Me.Text = "toothbrush"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox15 As System.Windows.Forms.ListBox
End Class
