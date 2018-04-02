<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class patanjlioil
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PatanjaliDataSet61 = New WindowsApplication15.patanjaliDataSet61()
        Me.MedicoilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicoilTableAdapter = New WindowsApplication15.patanjaliDataSet61TableAdapters.medicoilTableAdapter()
        Me.ProductnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductweightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatanjaliDataSet61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicoilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"", "Oil / तेल" & Global.Microsoft.VisualBasic.ChrW(9) & "Anu Taila / अनु तेल" & Global.Microsoft.VisualBasic.ChrW(9), "Bala Taila / बाल तेल" & Global.Microsoft.VisualBasic.ChrW(9), "Kayakalp Taila / कायाकल्प तेल" & Global.Microsoft.VisualBasic.ChrW(9), "Ksirbala Taila / क्षीरबला तेल" & Global.Microsoft.VisualBasic.ChrW(9), "Mahamash Taila /महामाष तेल" & Global.Microsoft.VisualBasic.ChrW(9), "Prasarini Taila / प्रसारिणी तेल" & Global.Microsoft.VisualBasic.ChrW(9), "Saindhavadi Taila / सैन्धवाड़ी तेल" & Global.Microsoft.VisualBasic.ChrW(9), "Sahacharadi Taila /  सहचरादि तेल", "Somraaji Taila / सोमराजी तेल" & Global.Microsoft.VisualBasic.ChrW(9), "Triphaladi Taila / त्रिफलादि तेल" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.ListBox1.Location = New System.Drawing.Point(155, 195)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(215, 160)
        Me.ListBox1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & "Products / उत्पाद"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(378, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Oil / तेल"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Oil / तेल"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Type / प्रकार"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(55, 385)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(60, 13)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = ">>Previous"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(536, 374)
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
        Me.DataGridView1.DataSource = Me.MedicoilBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(549, 195)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(346, 150)
        Me.DataGridView1.TabIndex = 81
        '
        'PatanjaliDataSet61
        '
        Me.PatanjaliDataSet61.DataSetName = "patanjaliDataSet61"
        Me.PatanjaliDataSet61.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicoilBindingSource
        '
        Me.MedicoilBindingSource.DataMember = "medicoil"
        Me.MedicoilBindingSource.DataSource = Me.PatanjaliDataSet61
        '
        'MedicoilTableAdapter
        '
        Me.MedicoilTableAdapter.ClearBeforeFill = True
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
        'patanjlioil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 451)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "patanjlioil"
        Me.Text = "patanjlioil"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatanjaliDataSet61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicoilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PatanjaliDataSet61 As WindowsApplication15.patanjaliDataSet61
    Friend WithEvents MedicoilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicoilTableAdapter As WindowsApplication15.patanjaliDataSet61TableAdapters.medicoilTableAdapter
    Friend WithEvents ProductnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductweightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
