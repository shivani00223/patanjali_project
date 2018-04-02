<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class parpati
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
        Me.PatanjaliDataSet59 = New WindowsApplication15.patanjaliDataSet59()
        Me.ParpatiRasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParpatiRasTableAdapter = New WindowsApplication15.patanjaliDataSet59TableAdapters.ParpatiRasTableAdapter()
        Me.ProductnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductweighDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatanjaliDataSet59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParpatiRasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Ekangveer Ras / एकंगवीर रस" & Global.Microsoft.VisualBasic.ChrW(9), "Kamdudha Ras / कामदुधा रस" & Global.Microsoft.VisualBasic.ChrW(9), "Kamdudha Ras / कामदुधा रस", "Kumar Kalyan Ras / कुमार कल्याण रस" & Global.Microsoft.VisualBasic.ChrW(9), "Laxmi Vilas Ras / लष्मी  विलास  रस" & Global.Microsoft.VisualBasic.ChrW(9), "Laxmi Vilas Ras / लष्मी  विलास  रस" & Global.Microsoft.VisualBasic.ChrW(9), "Mahawat Vidhwansan / महावत विध्वंसन", "Ras Manikya / रस माणिक्य" & Global.Microsoft.VisualBasic.ChrW(9), "Ras Raj Ras / रस राज रस", "Ras Sindoor / रस सिन्दूर" & Global.Microsoft.VisualBasic.ChrW(9), "Shila Sindoor / शीला सिन्दूर" & Global.Microsoft.VisualBasic.ChrW(9), "Swarna Vasant Malti / स्वर्ण वसंत मल्टी" & Global.Microsoft.VisualBasic.ChrW(9), "Swasari Ras / श्वासारि रास" & Global.Microsoft.VisualBasic.ChrW(9), "Swarna Makshik / स्वर्ण माक्षिक" & Global.Microsoft.VisualBasic.ChrW(9), "Tal Sindoor / ताल सिन्दूर" & Global.Microsoft.VisualBasic.ChrW(9), "Swet Parpati / स्वेत परपति" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9), "Tribhuvankirti Ras / त्रिभुवनकीर्ति रस", "V.V.Chintamani Ras / वि. वि. चिंतामणि रस" & Global.Microsoft.VisualBasic.ChrW(9), "Vasant Kusmakar Ras / वसंत कुसमाकर रस" & Global.Microsoft.VisualBasic.ChrW(9), "Yogender Ras / योगेंदर रस"})
        Me.ListBox1.Location = New System.Drawing.Point(257, 177)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(212, 290)
        Me.ListBox1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(108, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Type / प्रकार"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(305, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & "Products / उत्पाद"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Patanjali Parpati / Ras / रस"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(370, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Patanjali Parpati / Ras / रस"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(95, 506)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(60, 13)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = ">>Previous"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(537, 485)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductnameDataGridViewTextBoxColumn, Me.ProductweighDataGridViewTextBoxColumn, Me.ProductpriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ParpatiRasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(598, 177)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(345, 150)
        Me.DataGridView1.TabIndex = 81
        '
        'PatanjaliDataSet59
        '
        Me.PatanjaliDataSet59.DataSetName = "patanjaliDataSet59"
        Me.PatanjaliDataSet59.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ParpatiRasBindingSource
        '
        Me.ParpatiRasBindingSource.DataMember = "ParpatiRas"
        Me.ParpatiRasBindingSource.DataSource = Me.PatanjaliDataSet59
        '
        'ParpatiRasTableAdapter
        '
        Me.ParpatiRasTableAdapter.ClearBeforeFill = True
        '
        'ProductnameDataGridViewTextBoxColumn
        '
        Me.ProductnameDataGridViewTextBoxColumn.DataPropertyName = "productname"
        Me.ProductnameDataGridViewTextBoxColumn.HeaderText = "productname"
        Me.ProductnameDataGridViewTextBoxColumn.Name = "ProductnameDataGridViewTextBoxColumn"
        '
        'ProductweighDataGridViewTextBoxColumn
        '
        Me.ProductweighDataGridViewTextBoxColumn.DataPropertyName = "productweigh"
        Me.ProductweighDataGridViewTextBoxColumn.HeaderText = "productweigh"
        Me.ProductweighDataGridViewTextBoxColumn.Name = "ProductweighDataGridViewTextBoxColumn"
        '
        'ProductpriceDataGridViewTextBoxColumn
        '
        Me.ProductpriceDataGridViewTextBoxColumn.DataPropertyName = "productprice"
        Me.ProductpriceDataGridViewTextBoxColumn.HeaderText = "productprice"
        Me.ProductpriceDataGridViewTextBoxColumn.Name = "ProductpriceDataGridViewTextBoxColumn"
        '
        'parpati
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 582)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "parpati"
        Me.Text = "parpati"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatanjaliDataSet59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParpatiRasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PatanjaliDataSet59 As WindowsApplication15.patanjaliDataSet59
    Friend WithEvents ParpatiRasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ParpatiRasTableAdapter As WindowsApplication15.patanjaliDataSet59TableAdapters.ParpatiRasTableAdapter
    Friend WithEvents ProductnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductweighDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
