<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class skincare
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
        Me.ListBox7 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBox7
        '
        Me.ListBox7.FormattingEnabled = True
        Me.ListBox7.Items.AddRange(New Object() {"Skin Care / त्वचा की देखभाल" & Global.Microsoft.VisualBasic.ChrW(9) & "Aloevera Gel / एलो वेरा ज़ैल" & Global.Microsoft.VisualBasic.ChrW(9) & "60 ml" & Global.Microsoft.VisualBasic.ChrW(9) & "40 Rs", " -Face cream / फेस क्रीम " & Global.Microsoft.VisualBasic.ChrW(9) & "Aloevera Gel / एलो वेरा ज़ैल" & Global.Microsoft.VisualBasic.ChrW(9) & "150 ml" & Global.Microsoft.VisualBasic.ChrW(9) & "80 Rs", "Aloevera Moisturizing Cream / एलो वेरा मॉइस्चराइजिंग क्रीम" & Global.Microsoft.VisualBasic.ChrW(9) & "50 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "75 Rs", "Anti Wrinkle Cream / एंटी रिंकल क्रीम" & Global.Microsoft.VisualBasic.ChrW(9) & "50 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "150 Rs", "Beauty Cream / ब्यूटी क्रीम" & Global.Microsoft.VisualBasic.ChrW(9) & "50 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "70 Rs", "Boro Safe / बोरो सेफ" & Global.Microsoft.VisualBasic.ChrW(9) & "50 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "40 Rs", "Moisturizer Cream / मॉइस्चराइजर क्रीम" & Global.Microsoft.VisualBasic.ChrW(9) & "50 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "75 Rs", "Kanti Lep / कान्ति लेप" & Global.Microsoft.VisualBasic.ChrW(9) & "50 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "70 Rs", "Saundarya Anti Aging Cream / सौंदर्य क्रीम" & Global.Microsoft.VisualBasic.ChrW(9) & "15 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "300 Rs", "Saundarya Swarn Kanti Fairness Cream / सौंदर्य स्वर्ण" & Global.Microsoft.VisualBasic.ChrW(9) & "15 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "399 Rs", "Sun Screen Cream / सुन स्क्रीन क्रीम" & Global.Microsoft.VisualBasic.ChrW(9) & "50 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "100 Rs"})
        Me.ListBox7.Location = New System.Drawing.Point(33, 53)
        Me.ListBox7.Name = "ListBox7"
        Me.ListBox7.Size = New System.Drawing.Size(205, 134)
        Me.ListBox7.TabIndex = 7
        '
        'skincare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ListBox7)
        Me.Name = "skincare"
        Me.Text = "skincare"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox7 As System.Windows.Forms.ListBox
End Class
