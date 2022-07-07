Imports MySql.Data.MySqlClient
Public Class FormPembayaran
    Sub Bersihkan()

        LStatusMember.Text = ""

        LHargaAkhir.Text = ""

        TBarisBarang.Text = ""

        TBarisJasa.Text = ""

        cmbPendaftaran.Text = ""

        TNamaCustomer.Text = "-"

        TTLBiayaProduk.Text = 0

        TTLBiayaLayanan.Text = 0

        LHargaAwal.Text = 0

        TDibayar.Text = 0

        TKembali.Text = 0

        TCariProduk.Clear()

        TCariLayanan.Clear()

        DGVJasa.Rows.Clear()

        DGVBarang.Rows.Clear()

        Call TampilPendaftaran()

        cmbStylist.Text = ""

        DGV1.Enabled = False

        DGV2.Enabled = False

    End Sub
    Sub Otomatis()

        Call OpenConn()

        Cmd = New MySqlCommand("select Kode_Pembayaran from tbl_pembayaran order by Kode_Pembayaran desc", Conn)

        Rd = Cmd.ExecuteReader

        Rd.Read()

        If Not Rd.HasRows Then

            TNomor.Text = "00001"

        Else

            TNomor.Text = Format(Microsoft.VisualBasic.Right(Rd.Item("Kode_Pembayaran"), 5) + 1, "00000")

        End If

    End Sub
    Sub TampilPendaftaran()

        Call OpenConn()

        Cmd = New MySqlCommand("select Kode_Pendaftaran from tbl_pendaftaran where Status_Pendaftaran='TERDAFTAR'", Conn)

        Rd = Cmd.ExecuteReader

        cmbPendaftaran.Items.Clear()

        Do While Rd.Read

            cmbPendaftaran.Items.Add(Rd(0))

        Loop

    End Sub
    Sub TampilLayanan()

        Call OpenConn()

        Da = New MySqlDataAdapter("select * from tbl_layanan where Status_Layanan='AKTIF'", Conn)

        Ds = New DataSet

        Da.Fill(Ds)

        DGV1.DataSource = Ds.Tables(0)

        DGV1.ReadOnly = True

    End Sub
    Sub tampilProduk()

        Call OpenConn()

        Da = New MySqlDataAdapter("select * from tbl_produk where Stok_Produk>0 AND Status_Produk='AKTIF'", Conn)

        Ds = New DataSet

        Da.Fill(Ds)

        DGV2.DataSource = Ds.Tables(0)

        DGV2.ReadOnly = True

    End Sub
    Sub TampilStylist()

        Call OpenConn()

        Cmd = New MySqlCommand("select * from tbl_stylist where Status_Stylist='AKTIF'", Conn)

        Rd = Cmd.ExecuteReader

        cmbStylist.Items.Clear()

        Do While Rd.Read

            cmbStylist.Items.Add(Rd(0) & Space(2) & Rd(1))

        Loop

    End Sub
    Private Sub FormPembayaran_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Call OpenConn()

        Call Bersihkan()

        Call Otomatis()

        TTanggal.Text = Today

        Call tampilProduk()

        Call TampilLayanan()

        Call TampilStylist()

    End Sub

    Private Sub BtnBatal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Call Bersihkan()
    End Sub
    Sub TotalBiayaLayanan()

        Dim hitung As Integer = 0

        For baris As Integer = 0 To DGVJasa.RowCount - 1

            hitung = hitung + DGVJasa.Rows(baris).Cells(2).Value

            TTLBiayaLayanan.Text = FormatNumber(hitung, 0)

        Next

        TBarisJasa.Text = DGVJasa.RowCount - 1

    End Sub
    Sub TotalBiayaProduk()

        Dim hitung As Integer = 0

        For baris As Integer = 0 To DGVBarang.RowCount - 1

            hitung = hitung + DGVBarang.Rows(baris).Cells(4).Value

            TTLBiayaProduk.Text = FormatNumber(hitung, 0)

        Next

        TBarisBarang.Text = DGVBarang.RowCount - 1

    End Sub
    Sub HitungTotal()

        LHargaAwal.Text = Val(Microsoft.VisualBasic.Str(TTLBiayaLayanan.Text)) + Val(Microsoft.VisualBasic.Str(TTLBiayaProduk.Text))

        LHargaAwal.Text = FormatNumber(LHargaAwal.Text, 0)

    End Sub
    Sub HitungHargaAkhir()

        On Error Resume Next

        Dim hasildiskon As Double

        hasildiskon = Val(Microsoft.VisualBasic.Str(LHargaAwal.Text)) * Val(TxtDiskon.Text) / 100

        LHargaAkhir.Text = Val(Microsoft.VisualBasic.Str(LHargaAwal.Text)) - Val(hasildiskon)

        LHargaAkhir.Text = FormatNumber(LHargaAkhir.Text, 0)

        TDibayar.Text = 0

        If TxtDiskon.Text = 0 Then

            LHargaAkhir.Text = LHargaAwal.Text

        End If

    End Sub

    Private Sub BtnTutup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub TCariLayanan_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TCariLayanan.TextChanged
        Call OpenConn()

        Da = New MySqlDataAdapter("select * from tbl_layanan where Nama_Layanan like '%" & TCariLayanan.Text & "%' AND Status_Layanan='AKTIF'", Conn)

        Ds = New DataSet

        Da.Fill(Ds)

        DGV1.DataSource = Ds.Tables(0)

        DGV1.ReadOnly = True
    End Sub

    Private Sub TCariProduk_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TCariProduk.TextChanged
        Call OpenConn()

        Da = New MySqlDataAdapter("select * from tbl_produk where Nama_Produk like '%" & TCariProduk.Text & "%' AND Status_Produk='AKTIF'", Conn)

        Ds = New DataSet

        Da.Fill(Ds)

        DGV2.DataSource = Ds.Tables(0)

        DGV2.ReadOnly = True

    End Sub


    Private Sub TDibayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TDibayar.KeyPress
        If e.KeyChar = Chr(13) Then

            TDibayar.Text = FormatNumber(TDibayar.Text, 0)

            If Val(Microsoft.VisualBasic.Str(TDibayar.Text)) < Val(Microsoft.VisualBasic.Str(LHargaAkhir.Text)) Then

                MsgBox("Pembayaran kurang")

                Exit Sub

            ElseIf Val(Microsoft.VisualBasic.Str(TDibayar.Text)) >= Val(Microsoft.VisualBasic.Str(LHargaAkhir.Text)) Then

                TKembali.Text = Val(Microsoft.VisualBasic.Str(TDibayar.Text)) - Val(Microsoft.VisualBasic.Str(LHargaAkhir.Text))

                TKembali.Text = FormatNumber(TKembali.Text, 0)

                BtnSimpan.Enabled = True

            End If

            cmbStylist.Focus()

        End If



        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack) Then

            e.Handled = True

        End If

    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If cmbPendaftaran.Text = "" Or TDibayar.Text = "" Or TDibayar.Text = 0 Or cmbStylist.Text = "" Then

            MsgBox("data belum lengkap")

            Exit Sub

        End If



        If Val(Microsoft.VisualBasic.Str(TDibayar.Text)) < Val(Microsoft.VisualBasic.Str(LHargaAkhir.Text)) Then

            MsgBox("Pembayaran kurang")

            Exit Sub

        End If





        Call OpenConn()

        Cmd = New MySqlCommand("insert into tbl_pembayaran values ('" & TNomor.Text & "','" & TTanggal.Text & "','" & cmbPendaftaran.Text & "','" & Val(Microsoft.VisualBasic.Str(TTLBiayaLayanan.Text)) & "','" & Val(Microsoft.VisualBasic.Str(TTLBiayaProduk.Text)) & "','" & Val(Microsoft.VisualBasic.Str(LHargaAwal.Text)) & "','" & TxtDiskon.Text & "','" & Val(Microsoft.VisualBasic.Str(LHargaAkhir.Text)) & "','" & Val(Microsoft.VisualBasic.Str(TDibayar.Text)) & "','" & Val(Microsoft.VisualBasic.Str(TKembali.Text)) & "','" & FormMenuUtamaSalon.Panel1.Text & "','" & Microsoft.VisualBasic.Left(cmbStylist.Text, 3) & "')", Conn)

        Cmd.ExecuteNonQuery()

        Call OpenConn()

        Cmd = New MySqlCommand("select * from tbl_pendaftaran where Kode_Pendaftaran='" & cmbPendaftaran.Text & "'", Conn)

        Rd = Cmd.ExecuteReader

        Rd.Read()

        If Rd.HasRows Then

            Call OpenConn()

            Cmd = New MySqlCommand("update tbl_pendaftaran set Status_Pendaftaran='SELESAI' where Kode_Pendaftaran='" & cmbPendaftaran.Text & "'", Conn)

            Cmd.ExecuteNonQuery()
        End If
        If MessageBox.Show("TERIMAKASIH TELAH BERKUNJUNG KE SALON KAMI...", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then



            End If

            Call Otomatis()

        Call Bersihkan()

        Call TampilPendaftaran()

    End Sub

    Private Sub cmbPendaftaran_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPendaftaran.SelectedIndexChanged
        If cmbPendaftaran.Text = "" Then

            DGV1.Enabled = False

            DGV2.Enabled = False

        Else

            DGV1.Enabled = True

            DGV2.Enabled = True

        End If



        Call OpenConn()

        Cmd = New MySqlCommand("select Nama_Customer,Status_Member from tbl_custumer,tbl_pendaftaran where tbl_custumer.Kode_Customer=tbl_pendaftaran.Kode_Customer and tbl_pendaftaran.Kode_Pendaftaran='" & cmbPendaftaran.Text & "'", Conn)

        Rd = Cmd.ExecuteReader

        Rd.Read()

        If Rd.HasRows Then

            TNamaCustomer.Text = Rd(0)

            LStatusMember.Text = Rd(1)

        End If



        If LStatusMember.Text = "MEMBER" Then

            TxtDiskon.Enabled = True

        Else

            TxtDiskon.Enabled = False

            TxtDiskon.Text = 0

            Call HitungHargaAkhir()

        End If

    End Sub

    Private Sub cmbPendaftaran_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPendaftaran.KeyPress
        If e.KeyChar = Chr(13) Then

            cmbPendaftaran.Text = UCase(cmbPendaftaran.Text)

            TNamaCustomer.Focus()

        End If

    End Sub


    Private Sub DGV1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGVJasa.KeyPress
        On Error Resume Next

        If e.KeyChar = Chr(27) Then

            DGVJasa.Rows.RemoveAt(DGVJasa.CurrentCell.RowIndex)

            Call TotalBiayaLayanan()

            Call HitungTotal()

        End If

    End Sub



    Private Sub DGV2_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVBarang.CellEndEdit
        If e.ColumnIndex = 3 Then

            Try

                DGVBarang.Rows(e.RowIndex).Cells(4).Value = DGVBarang.Rows(e.RowIndex).Cells(3).Value * DGVBarang.Rows(e.RowIndex).Cells(2).Value

            Catch ex As Exception

                MsgBox("harus angka")

                SendKeys.Send("{UP}")

                DGVBarang.Rows(e.RowIndex).Cells(3).Value = 1

                DGVBarang.Rows(e.RowIndex).Cells(4).Value = DGVBarang.Rows(e.RowIndex).Cells(3).Value * DGVBarang.Rows(e.RowIndex).Cells(2).Value

            End Try

        End If

        Call TotalBiayaProduk()

        Call HitungTotal()

        Call HitungHargaAkhir()

    End Sub

    Private Sub DGV2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGVBarang.KeyPress
        On Error Resume Next

        If e.KeyChar = Chr(27) Then

            DGVBarang.Rows.RemoveAt(DGVBarang.CurrentCell.RowIndex)

            Call TotalBiayaProduk()

            Call HitungTotal()

        End If

    End Sub

    Private Sub DGV1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV1.CellMouseClick
        On Error Resume Next

        Dim baris As Integer = DGVJasa.RowCount - 1

        DGVJasa.Rows.Add(DGV1.Rows(e.RowIndex).Cells(0).Value)



        For i As Integer = 0 To DGVJasa.RowCount - 1

            For j As Integer = i + 1 To DGVJasa.RowCount - 1

                If DGVJasa.Rows(j).Cells(0).Value = DGVJasa.Rows(i).Cells(0).Value Then

                    MsgBox("data sudah dientri")

                    DGVJasa.Rows.RemoveAt(j)

                    Exit Sub

                End If

            Next

        Next



        Call OpenConn()

        Cmd = New MySqlCommand("select * from tbl_layanan where Kode_Layanan='" & DGVJasa.Rows(baris).Cells(0).Value & "'", Conn)

        Rd = Cmd.ExecuteReader

        Rd.Read()

        If Rd.HasRows Then

            DGVJasa.Rows(baris).Cells(1).Value = Rd.Item("Nama_Layanan")

            DGVJasa.Rows(baris).Cells(2).Value = Rd.Item("Harga_Layanan")

            DGVJasa.Columns(2).DefaultCellStyle.Format = "###,###,###"

            DGVJasa.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        End If

        Call TotalBiayaLayanan()

        Call HitungTotal()

        Call HitungHargaAkhir()

        TCariLayanan.Clear()

    End Sub

    Private Sub DGV2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV2.CellMouseClick
        Dim baris As Integer = DGVBarang.RowCount - 1

        DGVBarang.Rows.Add(DGV2.Rows(e.RowIndex).Cells(0).Value)



        For i As Integer = 0 To DGVBarang.RowCount - 1

            For j As Integer = i + 1 To DGVBarang.RowCount - 1

                If DGVBarang.Rows(j).Cells(0).Value = DGVBarang.Rows(i).Cells(0).Value Then

                    MsgBox("data sudah dientri")

                    DGVBarang.Rows.RemoveAt(j)

                    Exit Sub

                End If

            Next

        Next



        Call OpenConn()

        Cmd = New MySqlCommand("select * from tbl_produk where Kode_Produk='" & DGVBarang.Rows(baris).Cells(0).Value & "'", Conn)

        Rd = Cmd.ExecuteReader

        Rd.Read()

        If Rd.HasRows Then

            DGVBarang.Rows(baris).Cells(1).Value = Rd.Item("Nama_Produk")

            DGVBarang.Rows(baris).Cells(2).Value = Rd.Item("Harga_Produk")

            DGVBarang.Columns(2).DefaultCellStyle.Format = "###,###,###"

            DGVBarang.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            DGVBarang.Rows(baris).Cells(3).Value = 1

            DGVBarang.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            DGVBarang.Rows(baris).Cells(4).Value = DGVBarang.Rows(baris).Cells(2).Value * DGVBarang.Rows(baris).Cells(3).Value

            DGVBarang.Columns(4).DefaultCellStyle.Format = "###,###,###"

            DGVBarang.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        End If

        Call TotalBiayaProduk()

        Call HitungTotal()

        Call HitungHargaAkhir()

        TCariProduk.Clear()

    End Sub

    Private Sub TxtDiskon_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDiskon.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim hasildiskon As Double

            TxtDiskon.Text = FormatNumber(TxtDiskon.Text, 0)

            hasildiskon = Val(Microsoft.VisualBasic.Str(LHargaAwal.Text)) - Val(Microsoft.VisualBasic.Str(TxtDiskon.Text))

            LHargaAkhir.Text = Val(Microsoft.VisualBasic.Str(LHargaAwal.Text)) - Val(Microsoft.VisualBasic.Str(TxtDiskon.Text))

            LHargaAkhir.Text = FormatNumber(LHargaAkhir.Text, 0)

            TDibayar.Focus()

        End If
    End Sub

    Private Sub TxtDiskon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDiskon.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack) Then

            e.Handled = True

        End If

    End Sub

    Private Sub cmbStylist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStylist.SelectedIndexChanged
        BtnSimpan.Focus()
    End Sub

    Private Sub cmbStylist_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbStylist.KeyDown
        If e.KeyCode = Keys.Enter Then

            BtnSimpan.Focus()

        End If
    End Sub


End Class