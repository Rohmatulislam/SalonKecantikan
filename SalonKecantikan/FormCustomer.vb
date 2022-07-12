Imports MySql.Data.MySqlClient
Public Class FormCustomer
    Sub ReloadData()
        TxtNama.Text = ""
        TxtKode.Text = ""
        TxtAlamat.Text = ""
        No_HP.Text = ""
        CmbStatusmember.Text = ""
        BtnSimpan.Text = "Input"
        BtnHapus.Text = "Hapus"
        BtnBatal.Text = "Edit"
        BtnTutup.Text = "Tutup"
        CmbStatusmember.Items.Clear()
        CmbStatusmember.Items.Add("MEMBER")
        CmbStatusmember.Items.Add("BUKAN")
        Call OpenGrid()
        BtnSimpan.Enabled = True
        BtnBatal.Enabled = True
        BtnHapus.Enabled = True
        BtnTutup.Enabled = True
    End Sub
    Private Sub FormCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ReloadData()

    End Sub
    Sub OpenGrid()
        Call OpenConn()
        Da = New MySqlDataAdapter("select * from tbl_custumer", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_custumer")
        DataGridView1.DataSource = Ds.Tables("tbl_custumer")
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Call OpenConn()
        Dim InputData As String = "insert into tbl_custumer  values ('" & TxtKode.Text & "','" & TxtNama.Text & "','" & CmbStatusmember.Text & "','" & TxtAlamat.Text & "','" & No_HP.Text & "','AKTIF')"
        Cmd = New MySqlCommand(InputData, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Input Data Berhasil !")
        Call ReloadData()
    End Sub
    Private Sub TxtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("Select * from tbl_custumer where Kode_customer='" & TxtKode.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data Tidak Ada")
            Else
                TxtKode.Text = Rd.Item("Kode_Customer")
                TxtNama.Text = Rd.Item("Nama_Customer")
                TxtAlamat.Text = Rd.Item("Alamat_Customer")
                CmbStatusmember.Text = Rd.Item("Status_Member")
                No_HP.Text = Rd.Item("Hp_Customer")
            End If
        End If
    End Sub



    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Call OpenConn()
        Dim Hapus As String = "Delete From tbl_custumer Where Kode_Customer='" & TxtKode.Text & "'"
        Cmd = New MySqlCommand(Hapus, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("DATA BERHASIL DI HAPUS", MsgBoxStyle.Information, "INFORMATION")
        Call ReloadData()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Call OpenConn()
        Dim Edit As String = "Update tbl_custumer set Nama_Customer='" & TxtNama.Text & "', Status_Member = '" & CmbStatusmember.Text & "',Alamat_Customer = '" & TxtAlamat.Text & "',Hp_Customer = '" & No_HP.Text & "'where Kode_Customer ='" & TxtKode.Text & "'"
        Cmd = New MySqlCommand(Edit, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("EDIT DATA BERHASIL !")
        Call ReloadData()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub
End Class