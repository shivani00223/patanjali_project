<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class toothpowder
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
        Me.ListBox16 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBox16
        '
        Me.ListBox16.FormattingEnabled = True
        Me.ListBox16.Items.AddRange(New Object() {" -Tooth powder / दंत-मंजन" & Global.Microsoft.VisualBasic.ChrW(9) & "Divya Dant Manjan / दिव्य दन्त मंजन" & Global.Microsoft.VisualBasic.ChrW(9) & "100 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "65 Rs"})
        Me.ListBox16.Location = New System.Drawing.Point(82, 83)
        Me.ListBox16.Name = "ListBox16"
        Me.ListBox16.Size = New System.Drawing.Size(120, 95)
        Me.ListBox16.TabIndex = 16
        '
        'toothpowder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ListBox16)
        Me.Name = "toothpowder"
        Me.Text = "toothpowder"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox16 As System.Windows.Forms.ListBox
End Class
