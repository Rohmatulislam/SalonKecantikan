Imports MySql.Data.MySqlClient
Public Class FormStylist
    Sub ReloadData()
        TxtKodeSty.Text = ""
        TxtNamaSty.Text = ""
        Call OpenGrid()

    End Sub
    Private Sub FormStylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadData()

    End Sub
    Sub OpenGrid()
        Call OpenConn()
        Da = New MySqlDataAdapter("select * from tbl_stylist", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_stylist")
        DataGridView1.DataSource = Ds.Tables("tbl_stylist")
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Call OpenConn()
        Dim InputData As String = "insert into tbl_stylist  values ('" & TxtKodeSty.Text & "','" & TxtNamaSty.Text & "','AKTIF')"
        Cmd = New MySqlCommand(InputData, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Input Data Berhasil !")
        Call ReloadData()
    End Sub


    Private Sub TxtKodeSty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKodeSty.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("Select * from tbl_stylist where Kode_Stylist='" & TxtKodeSty.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data Tidak Ada")
            Else
                TxtKodeSty.Text = Rd.Item("Kode_Stylist")
                TxtNamaSty.Text = Rd.Item("Nama_Stylist")

            End If
        End If
    End Sub


    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Call OpenConn()
        Dim Hapus As String = "Delete From tbl_stylist Where Kode_Stylist='" & TxtKodeSty.Text & "'"
        Cmd = New MySqlCommand(Hapus, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("DATA BERHASIL DI HAPUS", MsgBoxStyle.Information, "INFORMATION")
        Call ReloadData()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Call OpenConn()
        Dim Edit As String = "Update tbl_stylist set Nama_Stylist='" & TxtNamaSty.Text & "'where Kode_Stylist ='" & TxtKodeSty.Text & "'"
        Cmd = New MySqlCommand(Edit, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("EDIT DATA BERHASIL !")
        Call ReloadData()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()

    End Sub
End Class