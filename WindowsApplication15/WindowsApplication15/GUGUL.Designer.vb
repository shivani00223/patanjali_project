<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUGUL
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PatanjaliDataSet40 = New WindowsApplication15.patanjaliDataSet40()
        Me.GuguulBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuguulTableAdapter = New WindowsApplication15.patanjaliDataSet40TableAdapters.GuguulTableAdapter()
        Me.ProductnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductweightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatanjaliDataSet40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuguulBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Gokshuradi Guggul / गोशुरादि गुग्गुल" & Global.Microsoft.VisualBasic.ChrW(9), "Gokshuradi Guggul / गोशुरादि गुग्गुल" & Global.Microsoft.VisualBasic.ChrW(9), "Kaishore Guggul / कैशोर गुग्गुल" & Global.Microsoft.VisualBasic.ChrW(9), "Kaishore Guggul / कैशोर गुग्गुल" & Global.Microsoft.VisualBasic.ChrW(9), "Kanchnar Guggul / कांचनार गुग्गुल" & Global.Microsoft.VisualBasic.ChrW(9), "Kanchnar Guggul / कांचनार गुग्गुल" & Global.Microsoft.VisualBasic.ChrW(9), "Lakshadi Guggul / लकशादि गुग्गुल" & Global.Microsoft.VisualBasic.ChrW(9), "Mahayograj Guggul / महायोगराज गुग्गुल" & Global.Microsoft.VisualBasic.ChrW(9), "Mahayograj Guggul / महायोगराज गुग्गुल" & Global.Microsoft.VisualBasic.ChrW(9), "Saptvisanti Guggul / सप्तविसंति गुग्गुल" & Global.Microsoft.VisualBasic.ChrW(9), "Singhnad Guggul / सिंघनाद गुग्गुल" & Global.Microsoft.VisualBasic.ChrW(9), "Singhnad Guggul / सिंघनाद गुग्गुल" & Global.Microsoft.VisualBasic.ChrW(9), "Trayodshang Guggul / त्रयोदशांग गुग्गुल" & Global.Microsoft.VisualBasic.ChrW(9), "Triyodshang Guggul / त्रयोदशांग गुग्गुल" & Global.Microsoft.VisualBasic.ChrW(9), "Triphla Guggul / त्रिफला गुग्गुल" & Global.Microsoft.VisualBasic.ChrW(9), "Triphla Guggul / त्रिफला गुग्गुल" & Global.Microsoft.VisualBasic.ChrW(9), "Yograj Guggul / योगराज गुग्गुल" & Global.Microsoft.VisualBasic.ChrW(9), "Yograj Guggul / योगराज गुग्गुल"})
        Me.ListBox1.Location = New System.Drawing.Point(263, 178)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(190, 238)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Type / प्रकार"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(302, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & "Products / उत्पाद"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(401, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Guggul / गुग्गुल"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(113, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Guggul / गुग्गुल"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(116, 469)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(60, 13)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = ">>Previous"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductnameDataGridViewTextBoxColumn, Me.ProductweightDataGridViewTextBoxColumn, Me.ProductpriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GuguulBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(626, 178)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(344, 180)
        Me.DataGridView1.TabIndex = 18
        '
        'PatanjaliDataSet40
        '
        Me.PatanjaliDataSet40.DataSetName = "patanjaliDataSet40"
        Me.PatanjaliDataSet40.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GuguulBindingSource
        '
        Me.GuguulBindingSource.DataMember = "Guguul"
        Me.GuguulBindingSource.DataSource = Me.PatanjaliDataSet40
        '
        'GuguulTableAdapter
        '
        Me.GuguulTableAdapter.ClearBeforeFill = True
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(506, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 46)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GUGUL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 526)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "GUGUL"
        Me.Text = "GUGUL"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatanjaliDataSet40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuguulBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PatanjaliDataSet40 As WindowsApplication15.patanjaliDataSet40
    Friend WithEvents GuguulBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GuguulTableAdapter As WindowsApplication15.patanjaliDataSet40TableAdapters.GuguulTableAdapter
    Friend WithEvents ProductnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductweightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
