﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CF
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PatanjaliDataSet17 = New WindowsApplication15.patanjaliDataSet17()
        Me.CornFlakesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Corn_FlakesTableAdapter = New WindowsApplication15.patanjaliDataSet17TableAdapters.Corn_FlakesTableAdapter()
        Me.ProductnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdectweightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatanjaliDataSet17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CornFlakesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(328, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Corn Flakes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "product Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "type"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(15, 349)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = ">>previous"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Corn FLakes", "COrn FLakes"})
        Me.ListBox1.Location = New System.Drawing.Point(186, 198)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(374, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 46)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductnameDataGridViewTextBoxColumn, Me.ProdectweightDataGridViewTextBoxColumn, Me.ProductpriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CornFlakesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(465, 175)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 16
        '
        'PatanjaliDataSet17
        '
        Me.PatanjaliDataSet17.DataSetName = "patanjaliDataSet17"
        Me.PatanjaliDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CornFlakesBindingSource
        '
        Me.CornFlakesBindingSource.DataMember = "Corn Flakes"
        Me.CornFlakesBindingSource.DataSource = Me.PatanjaliDataSet17
        '
        'Corn_FlakesTableAdapter
        '
        Me.Corn_FlakesTableAdapter.ClearBeforeFill = True
        '
        'ProductnameDataGridViewTextBoxColumn
        '
        Me.ProductnameDataGridViewTextBoxColumn.DataPropertyName = "productname"
        Me.ProductnameDataGridViewTextBoxColumn.HeaderText = "productname"
        Me.ProductnameDataGridViewTextBoxColumn.Name = "ProductnameDataGridViewTextBoxColumn"
        '
        'ProdectweightDataGridViewTextBoxColumn
        '
        Me.ProdectweightDataGridViewTextBoxColumn.DataPropertyName = "prodectweight"
        Me.ProdectweightDataGridViewTextBoxColumn.HeaderText = "prodectweight"
        Me.ProdectweightDataGridViewTextBoxColumn.Name = "ProdectweightDataGridViewTextBoxColumn"
        '
        'ProductpriceDataGridViewTextBoxColumn
        '
        Me.ProductpriceDataGridViewTextBoxColumn.DataPropertyName = "productprice"
        Me.ProductpriceDataGridViewTextBoxColumn.HeaderText = "productprice"
        Me.ProductpriceDataGridViewTextBoxColumn.Name = "ProductpriceDataGridViewTextBoxColumn"
        '
        'CF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 423)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CF"
        Me.Text = "CF"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatanjaliDataSet17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CornFlakesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PatanjaliDataSet17 As WindowsApplication15.patanjaliDataSet17
    Friend WithEvents CornFlakesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Corn_FlakesTableAdapter As WindowsApplication15.patanjaliDataSet17TableAdapters.Corn_FlakesTableAdapter
    Friend WithEvents ProductnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdectweightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
