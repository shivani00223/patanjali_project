<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class suger
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PatanjaliDataSet75 = New WindowsApplication15.patanjaliDataSet75()
        Me.SugarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SugarTableAdapter = New WindowsApplication15.patanjaliDataSet75TableAdapters.SugarTableAdapter()
        Me.ProductnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProuctweightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdutcpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatanjaliDataSet75, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SugarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"" & Global.Microsoft.VisualBasic.ChrW(9) & "Madhuram Sugar Jaggery Powder / मधुरं शुगर" & Global.Microsoft.VisualBasic.ChrW(9) & "1 kg" & Global.Microsoft.VisualBasic.ChrW(9) & "60 Rs"})
        Me.ListBox1.Location = New System.Drawing.Point(95, 78)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(262, 95)
        Me.ListBox1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductnameDataGridViewTextBoxColumn, Me.ProuctweightDataGridViewTextBoxColumn, Me.ProdutcpriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SugarBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(449, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(351, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'PatanjaliDataSet75
        '
        Me.PatanjaliDataSet75.DataSetName = "patanjaliDataSet75"
        Me.PatanjaliDataSet75.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SugarBindingSource
        '
        Me.SugarBindingSource.DataMember = "Sugar"
        Me.SugarBindingSource.DataSource = Me.PatanjaliDataSet75
        '
        'SugarTableAdapter
        '
        Me.SugarTableAdapter.ClearBeforeFill = True
        '
        'ProductnameDataGridViewTextBoxColumn
        '
        Me.ProductnameDataGridViewTextBoxColumn.DataPropertyName = "productname"
        Me.ProductnameDataGridViewTextBoxColumn.HeaderText = "productname"
        Me.ProductnameDataGridViewTextBoxColumn.Name = "ProductnameDataGridViewTextBoxColumn"
        '
        'ProuctweightDataGridViewTextBoxColumn
        '
        Me.ProuctweightDataGridViewTextBoxColumn.DataPropertyName = "prouctweight"
        Me.ProuctweightDataGridViewTextBoxColumn.HeaderText = "prouctweight"
        Me.ProuctweightDataGridViewTextBoxColumn.Name = "ProuctweightDataGridViewTextBoxColumn"
        '
        'ProdutcpriceDataGridViewTextBoxColumn
        '
        Me.ProdutcpriceDataGridViewTextBoxColumn.DataPropertyName = "produtcprice"
        Me.ProdutcpriceDataGridViewTextBoxColumn.HeaderText = "produtcprice"
        Me.ProdutcpriceDataGridViewTextBoxColumn.Name = "ProdutcpriceDataGridViewTextBoxColumn"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(335, 368)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 34)
        Me.Button1.TabIndex = 80
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'suger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 442)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "suger"
        Me.Text = "suger"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatanjaliDataSet75, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SugarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PatanjaliDataSet75 As WindowsApplication15.patanjaliDataSet75
    Friend WithEvents SugarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SugarTableAdapter As WindowsApplication15.patanjaliDataSet75TableAdapters.SugarTableAdapter
    Friend WithEvents ProductnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProuctweightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdutcpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
