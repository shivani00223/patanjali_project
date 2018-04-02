<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Footcream
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
        Me.ListBox19 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBox19
        '
        Me.ListBox19.FormattingEnabled = True
        Me.ListBox19.Items.AddRange(New Object() {"Hand Wash  / हैंड वाश " & Global.Microsoft.VisualBasic.ChrW(9) & "Hand Wash / हैंड वाश" & Global.Microsoft.VisualBasic.ChrW(9) & "250 ml" & Global.Microsoft.VisualBasic.ChrW(9) & "55 Rs", "Hand Wash Almond Kesar / हैंड वाश आलमंड केसर" & Global.Microsoft.VisualBasic.ChrW(9) & "175ml" & Global.Microsoft.VisualBasic.ChrW(9) & "90 Rs", "Hand Wash Refil Pack / हैंड वाश रिफिल पैक" & Global.Microsoft.VisualBasic.ChrW(9) & "200 ml" & Global.Microsoft.VisualBasic.ChrW(9) & "40 Rs", "Olive Hand Wash / ओलिव हैंड वाश" & Global.Microsoft.VisualBasic.ChrW(9) & "175ml" & Global.Microsoft.VisualBasic.ChrW(9) & "90 Rs"})
        Me.ListBox19.Location = New System.Drawing.Point(82, 83)
        Me.ListBox19.Name = "ListBox19"
        Me.ListBox19.Size = New System.Drawing.Size(120, 95)
        Me.ListBox19.TabIndex = 19
        '
        'Footcream
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ListBox19)
        Me.Name = "Footcream"
        Me.Text = "Footcream"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox19 As System.Windows.Forms.ListBox
End Class
