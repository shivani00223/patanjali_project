<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class condi
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
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Items.AddRange(New Object() {"Conditioner / कंडीशनर" & Global.Microsoft.VisualBasic.ChrW(9) & "Coconut Hair Wash / कोकोनट हेयर वाश" & Global.Microsoft.VisualBasic.ChrW(9) & "150 ml" & Global.Microsoft.VisualBasic.ChrW(9) & "95 Rs", "Conditioner Damage Control / कंडीशनर डैमेज कंट्रोल" & Global.Microsoft.VisualBasic.ChrW(9) & "100 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "60 Rs", "Hair Conditioner Colour Protection / हेयर कंडीशनर कलर प्रोटेक्शन" & Global.Microsoft.VisualBasic.ChrW(9) & "120 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "60 Rs", "Hair Conditioner Olive Almond / हेयर कंडीशनर ओलिव आलमंड" & Global.Microsoft.VisualBasic.ChrW(9) & "100 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "60 Rs", "Herbal Mehandi / हर्बल मेहंदी" & Global.Microsoft.VisualBasic.ChrW(9) & "100 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "35 Rs"})
        Me.ListBox3.Location = New System.Drawing.Point(82, 83)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 95)
        Me.ListBox3.TabIndex = 3
        '
        'condi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ListBox3)
        Me.Name = "condi"
        Me.Text = "condi"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
End Class
