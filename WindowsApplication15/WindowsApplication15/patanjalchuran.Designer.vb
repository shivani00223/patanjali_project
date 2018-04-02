<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class patanjalchuran
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
        Me.components = New System.ComponentModel.Container()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PatanjaliDataSet60 = New WindowsApplication15.patanjaliDataSet60()
        Me.ChurnaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChurnaTableAdapter = New WindowsApplication15.patanjaliDataSet60TableAdapters.ChurnaTableAdapter()
        Me.ProductnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductweightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatanjaliDataSet60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChurnaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Ajmodadi Churna / अजमोददी चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Amla Churna / आंवला चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Ashwagandha Churna / अश्वगंधा चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Avipattikar Churna / अविपत्तिकर चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Baheda Churna / बहेड़ा चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Bakuchi Churna / बकुची चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Bilwadi Churna / बीलवाड़ी चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Brahmi Churna / ब्राह्मी चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Divya Churna / दिव्या चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Gashar Churna / गशर चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Haridrakhand / हरिद्राखंड" & Global.Microsoft.VisualBasic.ChrW(9), "Haritki Churna / हरीतकी चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Kutki Churna / कुटकी चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Lavan Bhaskar Churna / लवण भास्कर चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Mulethi Churna / मुलेठी चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Naag Kesar Churna / नाग केसर चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Panchkol Churna / पंचकोल चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Pushyanug Churna / पुष्यनुग चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Sitopaladi Churna / सितोपलादि चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Sitopaladi Churna / सितोपलादि चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Shatavar Churna / शतावर चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Swet Mushli / स्वेत मुश्ली" & Global.Microsoft.VisualBasic.ChrW(9), "Shuddh Konch Beej Churan / शुद्ध कोंच बीज चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Trikatu Churna / त्रिकटु चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Trikatu Churna / त्रिकटु चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Triphala Churna / त्रिफला चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Udarkalp Churna / उदरकलप चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Vatari Churna / वतरि चूर्ण" & Global.Microsoft.VisualBasic.ChrW(9), "Youvan Churna /"})
        Me.ListBox1.Location = New System.Drawing.Point(172, 212)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(251, 394)
        Me.ListBox1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Type / प्रकार"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & "Products / उत्पाद"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(387, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Patanjali Churna / चूर्ण"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Patanjali Churna / चूर्ण"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(55, 646)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(60, 13)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = ">>Previous"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(513, 625)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 34)
        Me.Button1.TabIndex = 80
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductnameDataGridViewTextBoxColumn, Me.ProductweightDataGridViewTextBoxColumn, Me.ProductpriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ChurnaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(544, 212)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(346, 150)
        Me.DataGridView1.TabIndex = 81
        '
        'PatanjaliDataSet60
        '
        Me.PatanjaliDataSet60.DataSetName = "patanjaliDataSet60"
        Me.PatanjaliDataSet60.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChurnaBindingSource
        '
        Me.ChurnaBindingSource.DataMember = "Churna"
        Me.ChurnaBindingSource.DataSource = Me.PatanjaliDataSet60
        '
        'ChurnaTableAdapter
        '
        Me.ChurnaTableAdapter.ClearBeforeFill = True
        '
        'ProductnameDataGridViewTextBoxColumn
        '
        Me.ProductnameDataGridViewTextBoxColumn.DataPropertyName = "productname"
        Me.ProductnameDataGridViewTextBoxColumn.HeaderText = "productname"
        Me.ProductnameDataGridViewTextBoxColumn.Name = "ProductnameDataGridViewTextBoxColumn"
        '
        'ProductweightDataGridViewTextBoxColumn
        '
        Me.ProductweightDataGridViewTextBoxColumn.DataPropertyName = "productweight"
        Me.ProductweightDataGridViewTextBoxColumn.HeaderText = "productweight"
        Me.ProductweightDataGridViewTextBoxColumn.Name = "ProductweightDataGridViewTextBoxColumn"
        '
        'ProductpriceDataGridViewTextBoxColumn
        '
        Me.ProductpriceDataGridViewTextBoxColumn.DataPropertyName = "productprice"
        Me.ProductpriceDataGridViewTextBoxColumn.HeaderText = "productprice"
        Me.ProductpriceDataGridViewTextBoxColumn.Name = "ProductpriceDataGridViewTextBoxColumn"
        '
        'patanjalchuran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 700)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "patanjalchuran"
        Me.Text = "patanjalchuran"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatanjaliDataSet60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChurnaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PatanjaliDataSet60 As WindowsApplication15.patanjaliDataSet60
    Friend WithEvents ChurnaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChurnaTableAdapter As WindowsApplication15.patanjaliDataSet60TableAdapters.ChurnaTableAdapter
    Friend WithEvents ProductnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductweightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
