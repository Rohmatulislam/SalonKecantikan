Imports MySql.Data.MySqlClient
Public Class FormBarang
    Sub ReloadData()
        TxtHarga.Text = ""
        TxtStok.Text = ""
        TxtNama.Text = ""
        TxtKode.Text = ""
        TxtStok.Text = ""
        CmbSatuan.Text = ""
        BtnSimpan.Text = "Input"
        BtnEdit.Text = "Edit"
        BtnHapus.Text = "Hapus"
        BtnTutup.Text = "Tutup"
        CmbSatuan.Items.Clear()
        CmbSatuan.Items.Add("PCS")
        CmbSatuan.Items.Add("BTL")
        Call OpenGrid()
        BtnSimpan.Enabled = True
        BtnEdit.Enabled = True
        BtnHapus.Enabled = True
        BtnTutup.Enabled = True
    End Sub
    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ReloadData()
    End Sub
    Sub OpenGrid()
        Call OpenConn()
        Da = New MySqlDataAdapter("select * from tbl_barang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_barang")
        DgvBarang.DataSource = Ds.Tables("tbl_barang")
        DgvBarang.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click


        Call OpenConn()
        Dim InputData As String = "insert into tbl_barang (Kode_Barang, Nama_Barang, Satuan_Barang, Harga_Barang, Stok_Barang) values ('" & TxtKode.Text & "','" & TxtNama.Text & "','" & CmbSatuan.Text & "','" & TxtHarga.Text & "','" & TxtStok.Text & "')"
        Cmd = New MySqlCommand(InputData, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Input Data Berhasil !")
        Call ReloadData()


    End Sub



    Private Sub TxtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("Select * from tbl_barang where Kode_Barang='" & TxtKode.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data Tidak Ada")
            Else
                TxtKode.Text = Rd.Item("Kode_Barang")
                TxtNama.Text = Rd.Item("Nama_Barang")
                TxtHarga.Text = Rd.Item("Harga_Barang")
                CmbSatuan.Text = Rd.Item("Satuan_Barang")
                TxtStok.Text = Rd.Item("Stok_Barang")
            End If
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Call OpenConn()
        Dim Hapus As String = "Delete From tbl_barang Where Kode_Barang='" & TxtKode.Text & "'"
        Cmd = New MySqlCommand(Hapus, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("DATA BERHASIL DI HAPUS", MsgBoxStyle.Information, "INFORMATION")
        Call ReloadData()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Call OpenConn()
        Dim Edit As String = "Update tbl_barang set Nama_Barang='" & TxtNama.Text & "', Harga_Barang = '" & TxtHarga.Text & "',Satuan_Barang = '" & CmbSatuan.Text & "',Stok_Barang = '" & TxtStok.Text & "'where Kode_Barang ='" & TxtKode.Text & "'"
        Cmd = New MySqlCommand(Edit, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("EDIT DATA BERHASIL !")
        Call ReloadData()
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        Call OpenConn()
        Cmd = New MySqlCommand("Select * From tbl_barang Where Nama_Barang like'%" & Txtcari.Text & "%'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call OpenConn()
            Da = New MySqlDataAdapter("Select * From tbl_barang Where Nama_Barang like'%" & Txtcari.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "KetemuData")
            DgvBarang.DataSource = Ds.Tables("KetemuData")
            DgvBarang.ReadOnly = True


        End If
    End Sub

    Private Sub Txtcari_TextChanged(sender As Object, e As EventArgs) Handles Txtcari.TextChanged
        Call OpenConn()
        Cmd = New MySqlCommand("Select * From tbl_barang Where Nama_Barang like'%" & Txtcari.Text & "%'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call OpenConn()
            Da = New MySqlDataAdapter("Select * From tbl_barang Where Nama_Barang like'%" & Txtcari.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "KetemuData")
            DgvBarang.DataSource = Ds.Tables("KetemuData")
            DgvBarang.ReadOnly = True


        End If
    End Sub


End Class