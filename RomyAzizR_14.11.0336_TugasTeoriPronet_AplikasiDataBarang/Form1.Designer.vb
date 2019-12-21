<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formbarang
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
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbjenis_barang = New System.Windows.Forms.ComboBox()
        Me.txtharga_barang = New System.Windows.Forms.TextBox()
        Me.txtstock_barang = New System.Windows.Forms.TextBox()
        Me.txtnama_barang = New System.Windows.Forms.TextBox()
        Me.txtkode_barang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btclose = New System.Windows.Forms.Button()
        Me.btcancel = New System.Windows.Forms.Button()
        Me.btsave = New System.Windows.Forms.Button()
        Me.btnew = New System.Windows.Forms.Button()
        Me.dgvbarang = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangDataSet = New RomyAzizR_14._11._0336_TugasTeoriPronet_AplikasiDataBarang.BarangDataSet()
        Me.DataBarangTableAdapter = New RomyAzizR_14._11._0336_TugasTeoriPronet_AplikasiDataBarang.BarangDataSetTableAdapters.DataBarangTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbjenis_barang)
        Me.GroupBox1.Controls.Add(Me.txtharga_barang)
        Me.GroupBox1.Controls.Add(Me.txtstock_barang)
        Me.GroupBox1.Controls.Add(Me.txtnama_barang)
        Me.GroupBox1.Controls.Add(Me.txtkode_barang)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(65, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 258)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data"
        '
        'cbjenis_barang
        '
        Me.cbjenis_barang.BackColor = System.Drawing.Color.White
        Me.cbjenis_barang.FormattingEnabled = True
        Me.cbjenis_barang.Items.AddRange(New Object() {"Elektronik", "Buku", "Pakaian"})
        Me.cbjenis_barang.Location = New System.Drawing.Point(167, 103)
        Me.cbjenis_barang.Name = "cbjenis_barang"
        Me.cbjenis_barang.Size = New System.Drawing.Size(152, 21)
        Me.cbjenis_barang.TabIndex = 9
        '
        'txtharga_barang
        '
        Me.txtharga_barang.BackColor = System.Drawing.Color.White
        Me.txtharga_barang.Location = New System.Drawing.Point(167, 178)
        Me.txtharga_barang.Name = "txtharga_barang"
        Me.txtharga_barang.Size = New System.Drawing.Size(152, 20)
        Me.txtharga_barang.TabIndex = 8
        '
        'txtstock_barang
        '
        Me.txtstock_barang.BackColor = System.Drawing.Color.White
        Me.txtstock_barang.Location = New System.Drawing.Point(167, 142)
        Me.txtstock_barang.Name = "txtstock_barang"
        Me.txtstock_barang.Size = New System.Drawing.Size(152, 20)
        Me.txtstock_barang.TabIndex = 7
        '
        'txtnama_barang
        '
        Me.txtnama_barang.BackColor = System.Drawing.Color.White
        Me.txtnama_barang.Location = New System.Drawing.Point(167, 65)
        Me.txtnama_barang.Name = "txtnama_barang"
        Me.txtnama_barang.Size = New System.Drawing.Size(152, 20)
        Me.txtnama_barang.TabIndex = 6
        '
        'txtkode_barang
        '
        Me.txtkode_barang.BackColor = System.Drawing.Color.White
        Me.txtkode_barang.Location = New System.Drawing.Point(167, 33)
        Me.txtkode_barang.Name = "txtkode_barang"
        Me.txtkode_barang.Size = New System.Drawing.Size(152, 20)
        Me.txtkode_barang.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Harga Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Stock Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Jenis Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Barang"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btclose)
        Me.GroupBox2.Controls.Add(Me.btcancel)
        Me.GroupBox2.Controls.Add(Me.btsave)
        Me.GroupBox2.Controls.Add(Me.btnew)
        Me.GroupBox2.Location = New System.Drawing.Point(562, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 258)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proses"
        '
        'btclose
        '
        Me.btclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btclose.Location = New System.Drawing.Point(60, 203)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(75, 33)
        Me.btclose.TabIndex = 3
        Me.btclose.Text = "Close"
        Me.btclose.UseVisualStyleBackColor = True
        '
        'btcancel
        '
        Me.btcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btcancel.Location = New System.Drawing.Point(60, 145)
        Me.btcancel.Name = "btcancel"
        Me.btcancel.Size = New System.Drawing.Size(75, 33)
        Me.btcancel.TabIndex = 2
        Me.btcancel.Text = "Cancel"
        Me.btcancel.UseVisualStyleBackColor = True
        '
        'btsave
        '
        Me.btsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btsave.Location = New System.Drawing.Point(60, 86)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(75, 33)
        Me.btsave.TabIndex = 1
        Me.btsave.Text = "Save"
        Me.btsave.UseVisualStyleBackColor = True
        '
        'btnew
        '
        Me.btnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnew.Location = New System.Drawing.Point(60, 36)
        Me.btnew.Name = "btnew"
        Me.btnew.Size = New System.Drawing.Size(75, 33)
        Me.btnew.TabIndex = 0
        Me.btnew.Text = "New"
        Me.btnew.UseVisualStyleBackColor = True
        '
        'dgvbarang
        '
        Me.dgvbarang.AutoGenerateColumns = False
        Me.dgvbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.KodeBarangDataGridViewTextBoxColumn, Me.NamaBarangDataGridViewTextBoxColumn, Me.JenisBarangDataGridViewTextBoxColumn, Me.StockBarangDataGridViewTextBoxColumn, Me.HargaBarangDataGridViewTextBoxColumn})
        Me.dgvbarang.DataSource = Me.DataBarangBindingSource
        Me.dgvbarang.Location = New System.Drawing.Point(76, 392)
        Me.dgvbarang.Name = "dgvbarang"
        Me.dgvbarang.Size = New System.Drawing.Size(642, 203)
        Me.dgvbarang.TabIndex = 2
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KodeBarangDataGridViewTextBoxColumn
        '
        Me.KodeBarangDataGridViewTextBoxColumn.DataPropertyName = "Kode_Barang"
        Me.KodeBarangDataGridViewTextBoxColumn.HeaderText = "Kode_Barang"
        Me.KodeBarangDataGridViewTextBoxColumn.Name = "KodeBarangDataGridViewTextBoxColumn"
        '
        'NamaBarangDataGridViewTextBoxColumn
        '
        Me.NamaBarangDataGridViewTextBoxColumn.DataPropertyName = "Nama_Barang"
        Me.NamaBarangDataGridViewTextBoxColumn.HeaderText = "Nama_Barang"
        Me.NamaBarangDataGridViewTextBoxColumn.Name = "NamaBarangDataGridViewTextBoxColumn"
        '
        'JenisBarangDataGridViewTextBoxColumn
        '
        Me.JenisBarangDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Barang"
        Me.JenisBarangDataGridViewTextBoxColumn.HeaderText = "Jenis_Barang"
        Me.JenisBarangDataGridViewTextBoxColumn.Name = "JenisBarangDataGridViewTextBoxColumn"
        '
        'StockBarangDataGridViewTextBoxColumn
        '
        Me.StockBarangDataGridViewTextBoxColumn.DataPropertyName = "Stock_Barang"
        Me.StockBarangDataGridViewTextBoxColumn.HeaderText = "Stock_Barang"
        Me.StockBarangDataGridViewTextBoxColumn.Name = "StockBarangDataGridViewTextBoxColumn"
        '
        'HargaBarangDataGridViewTextBoxColumn
        '
        Me.HargaBarangDataGridViewTextBoxColumn.DataPropertyName = "Harga_Barang"
        Me.HargaBarangDataGridViewTextBoxColumn.HeaderText = "Harga_Barang"
        Me.HargaBarangDataGridViewTextBoxColumn.Name = "HargaBarangDataGridViewTextBoxColumn"
        '
        'DataBarangBindingSource
        '
        Me.DataBarangBindingSource.DataMember = "DataBarang"
        Me.DataBarangBindingSource.DataSource = Me.BarangDataSet
        '
        'BarangDataSet
        '
        Me.BarangDataSet.DataSetName = "BarangDataSet"
        Me.BarangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataBarangTableAdapter
        '
        Me.DataBarangTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(664, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "@Romy Aziz R"
        '
        'formbarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(800, 607)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvbarang)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "formbarang"
        Me.Text = "Aplikasi Data Barang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btclose As Button
    Friend WithEvents btcancel As Button
    Friend WithEvents btsave As Button
    Friend WithEvents btnew As Button
    Friend WithEvents dgvbarang As DataGridView
    Friend WithEvents txtnama_barang As TextBox
    Friend WithEvents txtkode_barang As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtharga_barang As TextBox
    Friend WithEvents txtstock_barang As TextBox
    Friend WithEvents cbjenis_barang As ComboBox
    Friend WithEvents BarangDataSet As BarangDataSet
    Friend WithEvents DataBarangBindingSource As BindingSource
    Friend WithEvents DataBarangTableAdapter As BarangDataSetTableAdapters.DataBarangTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JenisBarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockBarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaBarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
