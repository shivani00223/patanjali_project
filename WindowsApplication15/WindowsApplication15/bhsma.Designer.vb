<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bhsma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bhsma))
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.PatanjaliDataSet11 = New WindowsApplication15.patanjaliDataSet11()
        Me.BhasmaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BhasmaTableAdapter = New WindowsApplication15.patanjaliDataSet11TableAdapters.BhasmaTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductweightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BhasmaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatanjaliDataSet12 = New WindowsApplication15.patanjaliDataSet12()
        Me.BhasmaTableAdapter1 = New WindowsApplication15.patanjaliDataSet12TableAdapters.BhasmaTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PatanjaliDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BhasmaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BhasmaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatanjaliDataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Items.AddRange(New Object() {"Abhrak Bhasm / अभ्रक भस्म" & Global.Microsoft.VisualBasic.ChrW(9), "Godanti Bhasm / गोदन्ति भस्म" & Global.Microsoft.VisualBasic.ChrW(9), "Godanti Bhasm / गोदन्ति भस्म", "Hajrul Yahud Bhasm / हजरुल यहूद  भस्म" & Global.Microsoft.VisualBasic.ChrW(9), "Hirak Bhasm / हीरक भस्म" & Global.Microsoft.VisualBasic.ChrW(9), "Kapardhak Bhasm / कपरधक भस्म" & Global.Microsoft.VisualBasic.ChrW(9), "Kapardhak Bhasm / कपरधक भस्म" & Global.Microsoft.VisualBasic.ChrW(9), "Kasis Bhasm / कसीस भस्म" & Global.Microsoft.VisualBasic.ChrW(9), "Kulya Mishran / कुल्या मिश्रण" & Global.Microsoft.VisualBasic.ChrW(9), "Lauh Bhasm / लौह भस्म" & Global.Microsoft.VisualBasic.ChrW(9), "Makar Dhwaj / मकर ध्वज" & Global.Microsoft.VisualBasic.ChrW(9), "Mandur Bhasm / मण्डूर भस्म" & Global.Microsoft.VisualBasic.ChrW(9), "Mukta Sukti Bhasm / मुक्त सकती भस्म" & Global.Microsoft.VisualBasic.ChrW(9), "Mukta Sukti Bhasm / मुक्त सकती भस्म" & Global.Microsoft.VisualBasic.ChrW(9), "Rajat Bhasm / रजत भस्म" & Global.Microsoft.VisualBasic.ChrW(9), "Saptamrit Lauh / सप्तमृत लौह" & Global.Microsoft.VisualBasic.ChrW(9), "Shankh Bhasm / शंख भस्म" & Global.Microsoft.VisualBasic.ChrW(9), "Shankh Bhasm / शंख भस्म" & Global.Microsoft.VisualBasic.ChrW(9), "Sphatik Bhasm / स्फाटिक भस्म" & Global.Microsoft.VisualBasic.ChrW(9), "Tamra Bhasm / तमरा भस्म" & Global.Microsoft.VisualBasic.ChrW(9), "Tamra Sindoor / तमरा सिन्दूर" & Global.Microsoft.VisualBasic.ChrW(9), "Tankan Bhasm / टंकण भस्म" & Global.Microsoft.VisualBasic.ChrW(9), "Trivang Bhasm / त्रिवांग भस्म" & Global.Microsoft.VisualBasic.ChrW(9), "Vang Bhasm / वांग भस्म"})
        Me.ListBox2.Location = New System.Drawing.Point(155, 174)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(248, 388)
        Me.ListBox2.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(28, 74)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Type / प्रकार"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(175, 124)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & "Products / उत्पाद"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(58, 751)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(86, 20)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = ">>previous"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(28, 113)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Bhasm/भस्म"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(592, 40)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 38)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Bhasm/भस्म"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Location = New System.Drawing.Point(58, 646)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(108, 32)
        Me.LinkLabel2.TabIndex = 19
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Previous"
        '
        'PatanjaliDataSet11
        '
        Me.PatanjaliDataSet11.DataSetName = "patanjaliDataSet11"
        Me.PatanjaliDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BhasmaBindingSource
        '
        Me.BhasmaBindingSource.DataMember = "Bhasma"
        Me.BhasmaBindingSource.DataSource = Me.PatanjaliDataSet11
        '
        'BhasmaTableAdapter
        '
        Me.BhasmaTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductnameDataGridViewTextBoxColumn, Me.ProductweightDataGridViewTextBoxColumn, Me.ProductpriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BhasmaBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(724, 195)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(351, 150)
        Me.DataGridView1.TabIndex = 20
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
        'BhasmaBindingSource1
        '
        Me.BhasmaBindingSource1.DataMember = "Bhasma"
        Me.BhasmaBindingSource1.DataSource = Me.PatanjaliDataSet12
        '
        'PatanjaliDataSet12
        '
        Me.PatanjaliDataSet12.DataSetName = "patanjaliDataSet12"
        Me.PatanjaliDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BhasmaTableAdapter1
        '
        Me.BhasmaTableAdapter1.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(610, 568)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 46)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bhsma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1226, 741)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "bhsma"
        Me.Text = "BHasma"
        CType(Me.PatanjaliDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BhasmaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BhasmaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatanjaliDataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents PatanjaliDataSet11 As WindowsApplication15.patanjaliDataSet11
    Friend WithEvents BhasmaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BhasmaTableAdapter As WindowsApplication15.patanjaliDataSet11TableAdapters.BhasmaTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PatanjaliDataSet12 As WindowsApplication15.patanjaliDataSet12
    Friend WithEvents BhasmaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BhasmaTableAdapter1 As WindowsApplication15.patanjaliDataSet12TableAdapters.BhasmaTableAdapter
    Friend WithEvents ProductnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductweightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
