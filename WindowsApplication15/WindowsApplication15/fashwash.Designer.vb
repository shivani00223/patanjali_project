<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fashwash
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
        Me.ListBox8 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PatanjaliDataSet33 = New WindowsApplication15.patanjaliDataSet33()
        Me.FacewashBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacewashTableAdapter = New WindowsApplication15.patanjaliDataSet33TableAdapters.facewashTableAdapter()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductWeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatanjaliDataSet33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacewashBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox8
        '
        Me.ListBox8.FormattingEnabled = True
        Me.ListBox8.Items.AddRange(New Object() {"Honey Orange Face Wash / हनी ऑरेंज फेस वॉश" & Global.Microsoft.VisualBasic.ChrW(9), "Neem Tulsi Face Wash / नीम तुलसी फेस वॉश" & Global.Microsoft.VisualBasic.ChrW(9), "Orange Aloevera Face Wash / ऑरेंज एलो वेरा फेस वॉश" & Global.Microsoft.VisualBasic.ChrW(9), "Lemon Honey Face Wash / लेमन हनी फेस वॉश" & Global.Microsoft.VisualBasic.ChrW(9), "Rose Face Wash / रोज़ फेस वॉश", "Saundraya Face Wash / सौंदर्य फेस वॉश" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.ListBox8.Location = New System.Drawing.Point(234, 214)
        Me.ListBox8.Name = "ListBox8"
        Me.ListBox8.Size = New System.Drawing.Size(266, 108)
        Me.ListBox8.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 132)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 20)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Type / प्रकार"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(249, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 20)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & "Products / उत्पाद"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(387, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 31)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "-Face wash / फेस वॉश" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 15)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "-Face wash / फेस वॉश" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(16, 660)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(150, 35)
        Me.LinkLabel1.TabIndex = 46
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = ">>Previous"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(455, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 46)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductNameDataGridViewTextBoxColumn, Me.ProductWeightDataGridViewTextBoxColumn, Me.ProductPriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FacewashBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(632, 193)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(344, 150)
        Me.DataGridView1.TabIndex = 48
        '
        'PatanjaliDataSet33
        '
        Me.PatanjaliDataSet33.DataSetName = "patanjaliDataSet33"
        Me.PatanjaliDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacewashBindingSource
        '
        Me.FacewashBindingSource.DataMember = "facewash"
        Me.FacewashBindingSource.DataSource = Me.PatanjaliDataSet33
        '
        'FacewashTableAdapter
        '
        Me.FacewashTableAdapter.ClearBeforeFill = True
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        '
        'ProductWeightDataGridViewTextBoxColumn
        '
        Me.ProductWeightDataGridViewTextBoxColumn.DataPropertyName = "ProductWeight"
        Me.ProductWeightDataGridViewTextBoxColumn.HeaderText = "ProductWeight"
        Me.ProductWeightDataGridViewTextBoxColumn.Name = "ProductWeightDataGridViewTextBoxColumn"
        '
        'ProductPriceDataGridViewTextBoxColumn
        '
        Me.ProductPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice"
        Me.ProductPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice"
        Me.ProductPriceDataGridViewTextBoxColumn.Name = "ProductPriceDataGridViewTextBoxColumn"
        '
        'fashwash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 741)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox8)
        Me.Name = "fashwash"
        Me.Text = "fashwash"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatanjaliDataSet33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacewashBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox8 As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PatanjaliDataSet33 As WindowsApplication15.patanjaliDataSet33
    Friend WithEvents FacewashBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacewashTableAdapter As WindowsApplication15.patanjaliDataSet33TableAdapters.facewashTableAdapter
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductWeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
