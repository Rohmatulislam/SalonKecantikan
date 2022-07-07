<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembayaran
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TCariProduk = New System.Windows.Forms.TextBox()
        Me.cmbStylist = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TKembali = New System.Windows.Forms.TextBox()
        Me.TTLBiayaProduk = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBarisBarang = New System.Windows.Forms.TextBox()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.TCariLayanan = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TTLBiayaLayanan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBarisJasa = New System.Windows.Forms.TextBox()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.DGVBarang = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVJasa = New System.Windows.Forms.DataGridView()
        Me.Kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jasa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TDibayar = New System.Windows.Forms.TextBox()
        Me.LHargaAkhir = New System.Windows.Forms.TextBox()
        Me.TxtDiskon = New System.Windows.Forms.TextBox()
        Me.LHargaAwal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbPendaftaran = New System.Windows.Forms.ComboBox()
        Me.TNamaCustomer = New System.Windows.Forms.TextBox()
        Me.LStatusMember = New System.Windows.Forms.TextBox()
        Me.TTanggal = New System.Windows.Forms.TextBox()
        Me.TNomor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVJasa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(877, 581)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(137, 20)
        Me.Label14.TabIndex = 75
        Me.Label14.Text = "Cari Nama Produk"
        '
        'TCariProduk
        '
        Me.TCariProduk.Location = New System.Drawing.Point(1020, 578)
        Me.TCariProduk.Name = "TCariProduk"
        Me.TCariProduk.Size = New System.Drawing.Size(200, 26)
        Me.TCariProduk.TabIndex = 74
        '
        'cmbStylist
        '
        Me.cmbStylist.FormattingEnabled = True
        Me.cmbStylist.Location = New System.Drawing.Point(650, 604)
        Me.cmbStylist.Name = "cmbStylist"
        Me.cmbStylist.Size = New System.Drawing.Size(129, 28)
        Me.cmbStylist.TabIndex = 73
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(659, 578)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 20)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Stylist"
        '
        'TKembali
        '
        Me.TKembali.Location = New System.Drawing.Point(470, 604)
        Me.TKembali.Name = "TKembali"
        Me.TKembali.Size = New System.Drawing.Size(123, 26)
        Me.TKembali.TabIndex = 71
        '
        'TTLBiayaProduk
        '
        Me.TTLBiayaProduk.Location = New System.Drawing.Point(470, 572)
        Me.TTLBiayaProduk.Name = "TTLBiayaProduk"
        Me.TTLBiayaProduk.Size = New System.Drawing.Size(123, 26)
        Me.TTLBiayaProduk.TabIndex = 70
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(360, 602)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 20)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Kembali"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(360, 572)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 20)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Biaya Barang"
        '
        'TBarisBarang
        '
        Me.TBarisBarang.Location = New System.Drawing.Point(23, 628)
        Me.TBarisBarang.Name = "TBarisBarang"
        Me.TBarisBarang.Size = New System.Drawing.Size(169, 26)
        Me.TBarisBarang.TabIndex = 67
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(192, 572)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 50)
        Me.BtnTutup.TabIndex = 66
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(104, 572)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(75, 50)
        Me.BtnBatal.TabIndex = 65
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(23, 572)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 50)
        Me.BtnSimpan.TabIndex = 64
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'TCariLayanan
        '
        Me.TCariLayanan.Location = New System.Drawing.Point(1067, 331)
        Me.TCariLayanan.Name = "TCariLayanan"
        Me.TCariLayanan.Size = New System.Drawing.Size(153, 26)
        Me.TCariLayanan.TabIndex = 63
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(913, 337)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 20)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Cari Nama Layanan"
        '
        'TTLBiayaLayanan
        '
        Me.TTLBiayaLayanan.Location = New System.Drawing.Point(452, 340)
        Me.TTLBiayaLayanan.Name = "TTLBiayaLayanan"
        Me.TTLBiayaLayanan.Size = New System.Drawing.Size(141, 26)
        Me.TTLBiayaLayanan.TabIndex = 61
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(339, 340)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 20)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Biaya layanan"
        '
        'TBarisJasa
        '
        Me.TBarisJasa.Location = New System.Drawing.Point(23, 334)
        Me.TBarisJasa.Name = "TBarisJasa"
        Me.TBarisJasa.Size = New System.Drawing.Size(169, 26)
        Me.TBarisJasa.TabIndex = 59
        '
        'DGV2
        '
        Me.DGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Location = New System.Drawing.Point(650, 372)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.RowHeadersWidth = 62
        Me.DGV2.RowTemplate.Height = 28
        Me.DGV2.Size = New System.Drawing.Size(570, 194)
        Me.DGV2.TabIndex = 58
        '
        'DGV1
        '
        Me.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(650, 134)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowHeadersWidth = 62
        Me.DGV1.RowTemplate.Height = 28
        Me.DGV1.Size = New System.Drawing.Size(570, 194)
        Me.DGV1.TabIndex = 57
        '
        'DGVBarang
        '
        Me.DGVBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Nama, Me.DataGridViewTextBoxColumn2, Me.Jumlah, Me.Total})
        Me.DGVBarang.Location = New System.Drawing.Point(23, 372)
        Me.DGVBarang.Name = "DGVBarang"
        Me.DGVBarang.RowHeadersWidth = 62
        Me.DGVBarang.RowTemplate.Height = 28
        Me.DGVBarang.Size = New System.Drawing.Size(570, 194)
        Me.DGVBarang.TabIndex = 56
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Kode"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'Nama
        '
        Me.Nama.HeaderText = "Nama Produk"
        Me.Nama.MinimumWidth = 8
        Me.Nama.Name = "Nama"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Harga"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.MinimumWidth = 8
        Me.Jumlah.Name = "Jumlah"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 8
        Me.Total.Name = "Total"
        '
        'DGVJasa
        '
        Me.DGVJasa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVJasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVJasa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kode, Me.Jasa, Me.Harga})
        Me.DGVJasa.Location = New System.Drawing.Point(23, 134)
        Me.DGVJasa.Name = "DGVJasa"
        Me.DGVJasa.RowHeadersWidth = 62
        Me.DGVJasa.RowTemplate.Height = 28
        Me.DGVJasa.Size = New System.Drawing.Size(570, 194)
        Me.DGVJasa.TabIndex = 55
        '
        'Kode
        '
        Me.Kode.HeaderText = "Kode"
        Me.Kode.MinimumWidth = 8
        Me.Kode.Name = "Kode"
        '
        'Jasa
        '
        Me.Jasa.HeaderText = "Jasa"
        Me.Jasa.MinimumWidth = 8
        Me.Jasa.Name = "Jasa"
        '
        'Harga
        '
        Me.Harga.HeaderText = "Harga"
        Me.Harga.MinimumWidth = 8
        Me.Harga.Name = "Harga"
        '
        'TDibayar
        '
        Me.TDibayar.Location = New System.Drawing.Point(999, 65)
        Me.TDibayar.Name = "TDibayar"
        Me.TDibayar.Size = New System.Drawing.Size(200, 26)
        Me.TDibayar.TabIndex = 54
        '
        'LHargaAkhir
        '
        Me.LHargaAkhir.Location = New System.Drawing.Point(999, 28)
        Me.LHargaAkhir.Name = "LHargaAkhir"
        Me.LHargaAkhir.Size = New System.Drawing.Size(200, 26)
        Me.LHargaAkhir.TabIndex = 53
        '
        'TxtDiskon
        '
        Me.TxtDiskon.Location = New System.Drawing.Point(746, 68)
        Me.TxtDiskon.Name = "TxtDiskon"
        Me.TxtDiskon.Size = New System.Drawing.Size(154, 26)
        Me.TxtDiskon.TabIndex = 52
        '
        'LHargaAwal
        '
        Me.LHargaAwal.Location = New System.Drawing.Point(746, 25)
        Me.LHargaAwal.Name = "LHargaAwal"
        Me.LHargaAwal.Size = New System.Drawing.Size(154, 26)
        Me.LHargaAwal.TabIndex = 51
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(906, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 20)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Dibayar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(906, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 20)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Harga akhir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(646, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Diskon%"
        '
        'cmbPendaftaran
        '
        Me.cmbPendaftaran.FormattingEnabled = True
        Me.cmbPendaftaran.Location = New System.Drawing.Point(426, 32)
        Me.cmbPendaftaran.Name = "cmbPendaftaran"
        Me.cmbPendaftaran.Size = New System.Drawing.Size(108, 28)
        Me.cmbPendaftaran.TabIndex = 47
        '
        'TNamaCustomer
        '
        Me.TNamaCustomer.Location = New System.Drawing.Point(426, 71)
        Me.TNamaCustomer.Name = "TNamaCustomer"
        Me.TNamaCustomer.Size = New System.Drawing.Size(167, 26)
        Me.TNamaCustomer.TabIndex = 46
        '
        'LStatusMember
        '
        Me.LStatusMember.Location = New System.Drawing.Point(540, 34)
        Me.LStatusMember.Name = "LStatusMember"
        Me.LStatusMember.Size = New System.Drawing.Size(100, 26)
        Me.LStatusMember.TabIndex = 45
        '
        'TTanggal
        '
        Me.TTanggal.Location = New System.Drawing.Point(98, 65)
        Me.TTanggal.Name = "TTanggal"
        Me.TTanggal.Size = New System.Drawing.Size(169, 26)
        Me.TTanggal.TabIndex = 44
        '
        'TNomor
        '
        Me.TNomor.Location = New System.Drawing.Point(98, 32)
        Me.TNomor.Name = "TNomor"
        Me.TNomor.Size = New System.Drawing.Size(169, 26)
        Me.TNomor.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(646, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 20)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Harga awal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(273, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 20)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Nama customer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(273, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 20)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Nomor pendaftaran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Nomor"
        '
        'FormPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SalonKecantikan.My.Resources.Resources._03_image_1580686013_5e375abdda143
        Me.ClientSize = New System.Drawing.Size(1238, 659)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TCariProduk)
        Me.Controls.Add(Me.cmbStylist)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TKembali)
        Me.Controls.Add(Me.TTLBiayaProduk)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TBarisBarang)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.TCariLayanan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TTLBiayaLayanan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBarisJasa)
        Me.Controls.Add(Me.DGV2)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.DGVBarang)
        Me.Controls.Add(Me.DGVJasa)
        Me.Controls.Add(Me.TDibayar)
        Me.Controls.Add(Me.LHargaAkhir)
        Me.Controls.Add(Me.TxtDiskon)
        Me.Controls.Add(Me.LHargaAwal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbPendaftaran)
        Me.Controls.Add(Me.TNamaCustomer)
        Me.Controls.Add(Me.LStatusMember)
        Me.Controls.Add(Me.TTanggal)
        Me.Controls.Add(Me.TNomor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPembayaran"
        Me.Text = "FormPembayaran"
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVJasa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label14 As Label
    Friend WithEvents TCariProduk As TextBox
    Friend WithEvents cmbStylist As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TKembali As TextBox
    Friend WithEvents TTLBiayaProduk As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TBarisBarang As TextBox
    Friend WithEvents BtnTutup As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents TCariLayanan As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TTLBiayaLayanan As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TBarisJasa As TextBox
    Friend WithEvents DGV2 As DataGridView
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents DGVBarang As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents DGVJasa As DataGridView
    Friend WithEvents Kode As DataGridViewTextBoxColumn
    Friend WithEvents Jasa As DataGridViewTextBoxColumn
    Friend WithEvents Harga As DataGridViewTextBoxColumn
    Friend WithEvents TDibayar As TextBox
    Friend WithEvents LHargaAkhir As TextBox
    Friend WithEvents TxtDiskon As TextBox
    Friend WithEvents LHargaAwal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbPendaftaran As ComboBox
    Friend WithEvents TNamaCustomer As TextBox
    Friend WithEvents LStatusMember As TextBox
    Friend WithEvents TTanggal As TextBox
    Friend WithEvents TNomor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
