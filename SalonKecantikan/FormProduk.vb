Imports MySql.Data.MySqlClient
Public Class FormProduk
    Sub ReloadData()
        TxtHarga.Text = ""
        TxtStok.Text = ""
        TxtKode.Text = ""
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
    Private Sub FormProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ReloadData()
    End Sub
    Sub OpenGrid()
        Call OpenConn()
        Da = New MySqlDataAdapter("select * from tblproduk", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblproduk")
        DgvProduk.DataSource = Ds.Tables("tblproduk")
        DgvProduk.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click

        Call OpenConn()
        Dim InputData As String = "insert into tblproduk (Kode_Produk, Nama_Produk, Satuan_Produk, Harga_produk, Stok_produk) values ('" & TxtKode.Text & "','" & TxtNama.Text & "','" & CmbSatuan.Text & "','" & TxtHarga.Text & "','" & TxtStok.Text & "')"
        Cmd = New MySqlCommand(InputData, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Input Data Berhasil !")
        Call ReloadData()

    End Sub



    Private Sub TxtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("Select * from tblproduk where Kode_Produk='" & TxtKode.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data Tidak Ada")
            Else
                TxtKode.Text = Rd.Item("Kode_Produk")
                TxtNama.Text = Rd.Item("Nama_Produk")
                TxtHarga.Text = Rd.Item("Harga_Produk")
                CmbSatuan.Text = Rd.Item("Satuan_Produk")
                TxtStok.Text = Rd.Item("Stok_Produk")
            End If
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Call OpenConn()
        Dim Hapus As String = "Delete From tblproduk Where Kode_Produk='" & TxtKode.Text & "'"
        Cmd = New MySqlCommand(Hapus, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("DATA BERHASIL DI HAPUS", MsgBoxStyle.Information, "INFORMATION")
        Call ReloadData()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Call OpenConn()
        Dim Edit As String = "Update tblproduk set Nama_Produk='" & TxtNama.Text & "', Harga_Produk = '" & TxtHarga.Text & "',Satuan_Produk = '" & CmbSatuan.Text & "',Stok_Produk = '" & TxtStok.Text & "'where Kode_Produk ='" & TxtKode.Text & "'"
        Cmd = New MySqlCommand(Edit, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("EDIT DATA BERHASIL !")
        Call ReloadData()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        Call OpenConn()
        Cmd = New MySqlCommand("Select * From tblproduk Where Nama_Produk like'%" & TxtCari.Text & "%'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call OpenConn()
            Da = New MySqlDataAdapter("Select * From tblproduk Where Nama_Produk like'%" & TxtCari.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "KetemuData")
            DgvProduk.DataSource = Ds.Tables("KetemuData")
            DgvProduk.ReadOnly = True


        End If
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        Call OpenConn()
        Cmd = New MySqlCommand("Select * From tblproduk Where Nama_Produk like'%" & TxtCari.Text & "%'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call OpenConn()
            Da = New MySqlDataAdapter("Select * From tblproduk Where Nama_Produk like'%" & TxtCari.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "KetemuData")
            DgvProduk.DataSource = Ds.Tables("KetemuData")
            DgvProduk.ReadOnly = True


        End If
    End Sub
End Class