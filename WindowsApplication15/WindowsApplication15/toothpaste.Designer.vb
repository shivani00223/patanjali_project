<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class toothpaste
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
        Me.ListBox14 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBox14
        '
        Me.ListBox14.FormattingEnabled = True
        Me.ListBox14.Items.AddRange(New Object() {"Dental Care / दाँतों की देखभाल" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9), " -Toothpaste / टूथपेस्ट" & Global.Microsoft.VisualBasic.ChrW(9) & "Dant Kanti / दन्त कांति" & Global.Microsoft.VisualBasic.ChrW(9) & "25 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "10 Rs", "Dant Kanti / दन्त कांति" & Global.Microsoft.VisualBasic.ChrW(9) & "100 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "40 Rs", "Dant Kanti / दन्त कांति" & Global.Microsoft.VisualBasic.ChrW(9) & "200 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "75 Rs", "Dant Kanti Junior / दन्त कांति जूनियर" & Global.Microsoft.VisualBasic.ChrW(9) & "100 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "35 Rs", "Dant Kanti Medicated / दन्त कांति मेडिकेटेड" & Global.Microsoft.VisualBasic.ChrW(9) & "100 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "45 Rs", "Dant Kanti Advanced / दन्त कांति एडवांस्ड" & Global.Microsoft.VisualBasic.ChrW(9) & "100 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "90 Rs"})
        Me.ListBox14.Location = New System.Drawing.Point(51, 49)
        Me.ListBox14.Name = "ListBox14"
        Me.ListBox14.Size = New System.Drawing.Size(120, 95)
        Me.ListBox14.TabIndex = 14
        '
        'toothpaste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ListBox14)
        Me.Name = "toothpaste"
        Me.Text = "toothpaste"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox14 As System.Windows.Forms.ListBox
End Class
