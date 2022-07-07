Imports MySql.Data.MySqlClient
Public Class FormLayanan
    Sub ReloadData()
        TxtHarga.Text = ""
        TxtNama.Text = ""
        TxtKode.Text = ""

        BtnSimpan.Text = "Input"
        BtnEdit.Text = "Edit"
        BtnHapus.Text = "Hapus"
        BtnTutup.Text = "Tutup"

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
        Da = New MySqlDataAdapter("select * from tbl_layanan", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_layanan")
        DGVLayanan.DataSource = Ds.Tables("tbl_layanan")
        DGVLayanan.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click

        Call OpenConn()
        Dim InputData As String = "insert into tbl_layanan (Kode_Layanan, Nama_Layanan, Harga_Layanan, Status_Layanan)  values ('" & TxtKode.Text & "','" & TxtNama.Text & "','" & TxtHarga.Text & "','AKTIF')"
        Cmd = New MySqlCommand(InputData, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Input Data Berhasil !")
        Call ReloadData()

    End Sub



    Private Sub TxtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("Select * from tbl_layanan where Kode_layanan='" & TxtKode.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data Tidak Ada")
            Else
                TxtKode.Text = Rd.Item("Kode_Layanan")
                TxtNama.Text = Rd.Item("Nama_Layanan")
                TxtHarga.Text = Rd.Item("Harga_Layanan")

            End If
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Call OpenConn()
        Dim Hapus As String = "Delete From tbl_layanan Where Kode_Layanan='" & TxtKode.Text & "'"
        Cmd = New MySqlCommand(Hapus, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("DATA BERHASIL DI HAPUS", MsgBoxStyle.Information, "INFORMATION")
        Call ReloadData()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Call OpenConn()
        Dim Edit As String = "Update tbl_layanan set Nama_Layanan='" & TxtNama.Text & "', Harga_Layanan = '" & TxtHarga.Text & "'where Kode_Layanan ='" & TxtKode.Text & "'"
        Cmd = New MySqlCommand(Edit, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("EDIT DATA BERHASIL !")
        Call ReloadData()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub TxtCariNamaLay_TextChanged(sender As Object, e As EventArgs) Handles TxtCariNamaLay.TextChanged
        Call OpenConn()
        Cmd = New MySqlCommand("Select * From tbl_produk Where Nama_Produk like'%" & TxtCariNamaLay.Text & "%'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call OpenConn()
            Da = New MySqlDataAdapter("Select * From tbl_produk Where Nama_Produk like'%" & TxtCariNamaLay.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "KetemuData")
            DGVLayanan.DataSource = Ds.Tables("KetemuData")
            DGVLayanan.ReadOnly = True


        End If
    End Sub
End Class

