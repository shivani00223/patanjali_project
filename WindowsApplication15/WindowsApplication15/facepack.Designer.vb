<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class facepack
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
        Me.ListBox8 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBox8
        '
        Me.ListBox8.FormattingEnabled = True
        Me.ListBox8.Items.AddRange(New Object() {"-Face wash / फेस वॉश" & Global.Microsoft.VisualBasic.ChrW(9) & "Honey Orange Face Wash / हनी ऑरेंज फेस वॉश" & Global.Microsoft.VisualBasic.ChrW(9) & "60 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "45 Rs", "Neem Tulsi Face Wash / नीम तुलसी फेस वॉश" & Global.Microsoft.VisualBasic.ChrW(9) & "60 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "45 Rs", "Orange Aloevera Face Wash / ऑरेंज एलो वेरा फेस वॉश" & Global.Microsoft.VisualBasic.ChrW(9) & "60 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "45 Rs", "Lemon Honey Face Wash / लेमन हनी फेस वॉश" & Global.Microsoft.VisualBasic.ChrW(9) & "60 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "45 Rs", "Rose Face Wash / रोज़ फेस वॉश" & Global.Microsoft.VisualBasic.ChrW(9) & "60 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "45 Rs", "Saundraya Face Wash / सौंदर्य फेस वॉश" & Global.Microsoft.VisualBasic.ChrW(9) & "60 gm" & Global.Microsoft.VisualBasic.ChrW(9) & "60 Rs"})
        Me.ListBox8.Location = New System.Drawing.Point(82, 83)
        Me.ListBox8.Name = "ListBox8"
        Me.ListBox8.Size = New System.Drawing.Size(120, 95)
        Me.ListBox8.TabIndex = 8
        '
        'facepack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ListBox8)
        Me.Name = "facepack"
        Me.Text = "facepack"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox8 As System.Windows.Forms.ListBox
End Class
