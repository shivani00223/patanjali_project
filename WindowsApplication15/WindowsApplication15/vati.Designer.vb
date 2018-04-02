<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vati
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
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PatanjaliDataSet81 = New WindowsApplication15.patanjaliDataSet81()
        Me.VatiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VatiTableAdapter = New WindowsApplication15.patanjaliDataSet81TableAdapters.vatiTableAdapter()
        Me.PnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PweightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatanjaliDataSet81, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VatiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Items.AddRange(New Object() {"Arogya Vati / आरोग्य वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Arogyavardhani Vati / आरोग्यवर्धिनी वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Arogyavardhani Vati / आरोग्यवर्धिनी वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Arshkalp Vati / अर्शकल्प वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Arshkalp Vati / अर्शकल्प वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Chandraprabha Vati / चन्द्रप्रभा वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Chandraprabha Vati / चन्द्रप्रभा वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Chandraprabha Vati / चन्द्रप्रभा वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Chitrakadi Vati / चित्रकादि वटी", "Giloy Ghanvati / गिलोय घनवटी" & Global.Microsoft.VisualBasic.ChrW(9), "Hridyamrit Vati / हृदयमृत वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Hridyamrit Vati / हृदयमृत वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Jwarnashak Vati / ज्वरनाशक वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Kayakalp Vati / कायाकल्प वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Kayakalp Vati / कायाकल्प वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Khadiradi Vati / खदिरादी वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Kutajghan Vati / कुटजघन वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Lavangadi Vati / लवंगादि वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Madhukalp Vati / मधुकल्प  वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Maha Sudarshan Vati / महा  सुदर्शन  वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Medha Vati / मेधा वटी" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9), "Medha Vati / मेधा वटी" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9), "Medohar Vati / मेदोहर वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Madhunashini / मधुनाशिनी" & Global.Microsoft.VisualBasic.ChrW(9), "Madhu Kalp Vati / मधु कल्प वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Mukta Vati / मुक्ता वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Neem Ghan Vati / नीम घनवटी" & Global.Microsoft.VisualBasic.ChrW(9), "Peedantak Vati / पीड़ान्तक वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Peedantak Vati / पीड़ान्तक वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Punarnavadi Mandur / पुनर्नवादि  मण्डूर" & Global.Microsoft.VisualBasic.ChrW(9), "Punarnavadi Mandur / पुनर्नवादि  मण्डूर" & Global.Microsoft.VisualBasic.ChrW(9), "Putrajeevak Beej / पुत्रजीवक बीज" & Global.Microsoft.VisualBasic.ChrW(9), "Raj Pravartani Vati / रज:  प्रवर्तनी  वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Sanjivani Vati / संजीवनी  वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Sanjivani Vati / संजीवनी  वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Sarivadi Vati / सारिवादि  वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Stri Rasayan Vati / स्त्री  रसायन  वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Stri Rasayan Vati / स्त्री  रसायन  वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Tulsi Ghanvati / तुलसी घनवटी" & Global.Microsoft.VisualBasic.ChrW(9), "Udramrit Vati / उद्रमृत  वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Udramrit Vati / उद्रमृत  वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Vistindukadi Vati / विषतिन्दुकादि वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Vriddhivadhika Vati / वृद्धि वाधिका  वटी", "Vriddhivadhika Vati / वृद्धि वाधिका  वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Vrikkdoshhar Vati / वृककदोषहर  वटी" & Global.Microsoft.VisualBasic.ChrW(9), "Younamrit Vati / यौनअमृत वटी"})
        Me.ListBox2.Location = New System.Drawing.Point(225, 204)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(244, 433)
        Me.ListBox2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & "Products / उत्पाद"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(764, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & "Price / मूल्य"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(534, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Weight /वजन" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(374, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Patanjali Vati / वटी"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Patanjali Vati / वटी"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(288, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Type / प्रकार"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(112, 592)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(60, 13)
        Me.LinkLabel1.TabIndex = 19
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = ">>Previous"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(565, 632)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PnameDataGridViewTextBoxColumn, Me.PweightDataGridViewTextBoxColumn, Me.PpriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VatiBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(515, 204)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(344, 150)
        Me.DataGridView1.TabIndex = 81
        '
        'PatanjaliDataSet81
        '
        Me.PatanjaliDataSet81.DataSetName = "patanjaliDataSet81"
        Me.PatanjaliDataSet81.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VatiBindingSource
        '
        Me.VatiBindingSource.DataMember = "vati"
        Me.VatiBindingSource.DataSource = Me.PatanjaliDataSet81
        '
        'VatiTableAdapter
        '
        Me.VatiTableAdapter.ClearBeforeFill = True
        '
        'PnameDataGridViewTextBoxColumn
        '
        Me.PnameDataGridViewTextBoxColumn.DataPropertyName = "p_name"
        Me.PnameDataGridViewTextBoxColumn.HeaderText = "p_name"
        Me.PnameDataGridViewTextBoxColumn.Name = "PnameDataGridViewTextBoxColumn"
        '
        'PweightDataGridViewTextBoxColumn
        '
        Me.PweightDataGridViewTextBoxColumn.DataPropertyName = "p_weight"
        Me.PweightDataGridViewTextBoxColumn.HeaderText = "p_weight"
        Me.PweightDataGridViewTextBoxColumn.Name = "PweightDataGridViewTextBoxColumn"
        '
        'PpriceDataGridViewTextBoxColumn
        '
        Me.PpriceDataGridViewTextBoxColumn.DataPropertyName = "p_price"
        Me.PpriceDataGridViewTextBoxColumn.HeaderText = "p_price"
        Me.PpriceDataGridViewTextBoxColumn.Name = "PpriceDataGridViewTextBoxColumn"
        '
        'vati
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 741)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox2)
        Me.Name = "vati"
        Me.Text = "vati"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatanjaliDataSet81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VatiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PatanjaliDataSet81 As WindowsApplication15.patanjaliDataSet81
    Friend WithEvents VatiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VatiTableAdapter As WindowsApplication15.patanjaliDataSet81TableAdapters.vatiTableAdapter
    Friend WithEvents PnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PweightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
