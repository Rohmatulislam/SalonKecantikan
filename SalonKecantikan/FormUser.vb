Imports MySql.Data.MySqlClient
Public Class FormUser
    Sub RelodData()
        TxtCode.Text = ""
        TxtNama.Text = ""
        TxtPass.Text = ""
        CmbStatus.Text = ""
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        CmbStatus.Items.Clear()
        CmbStatus.Items.Add("AKTIF")
        CmbStatus.Items.Add("TIDAK AKTIF")
        Call OpenGrid()
        TxtPass.PasswordChar = "*"
    End Sub

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RelodData()
        DataGridView1.DataSource = (Ds.Tables("tbl_use"))
        DataGridView1.Columns(1).Width = 180
        DataGridView1.Columns(2).Width = 120


    End Sub
    Sub OpenGrid()
        Call OpenConn()
        Da = New MySqlDataAdapter("select * from tbl_use", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_use")
        DataGridView1.DataSource = Ds.Tables("tbl_use")
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call OpenConn()
        Dim InputData As String = "insert into tbl_use (Kode_User, Nama_User, Password_User, Setatus_User) values ('" & TxtCode.Text & "','" & TxtNama.Text & "','" & TxtPass.Text & "','" & CmbStatus.Text & "')"
        Cmd = New MySqlCommand(InputData, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Input Data Berhasil !")
        Call RelodData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call OpenConn()
        Dim Edit As String = "Update tbl_use set Nama_User='" & TxtNama.Text & "',Password_User  = '" & TxtPass.Text & "',Setatus_User = '" & CmbStatus.Text & "'where Kode_User ='" & TxtCode.Text & "'"
        Cmd = New MySqlCommand(Edit, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("EDIT DATA BERHASIL !")
        Call RelodData()

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call OpenConn()
        Dim Hapus As String = "Delete From tbl_use Where Kode_User='" & TxtCode.Text & "'"
        Cmd = New MySqlCommand(Hapus, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("DATA BERHASIL DI HAPUS", MsgBoxStyle.Information, "INFORMATION")
        Call RelodData()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub



    Private Sub TxtCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("Select * from tbl_use where Kode_User='" & TxtCode.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data Tidak Ada")
            Else
                TxtCode.Text = Rd.Item("Kode_User")
                TxtNama.Text = Rd.Item("Nama_User")
                TxtPass.Text = Rd.Item("Password_User")
                CmbStatus.Text = Rd.Item("Setatus_User")
            End If
        End If
    End Sub
End Class
