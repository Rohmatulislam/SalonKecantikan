Imports MySql.Data.MySqlClient
Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Textuser.Text = ""
        Textpass.Text = ""
        Textpass.PasswordChar = "*"
    End Sub

    Private Sub Textuser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textuser.KeyPress
        If e.KeyChar = Chr(13) Then
            Textpass.Focus()

        End If
    End Sub

    Private Sub Textpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textpass.KeyPress
        If e.KeyChar = Chr(13) Then
            BtnLogin.Focus()

        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Call OpenConn()
        Cmd = New MySqlCommand("Select* from tbl_user where Kode_User='" & Textuser.Text & "'and Password_User='" & Textpass.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            MsgBox("Login Gagal!")
            Textuser.Clear()
            Textpass.Clear()
            Textuser.Focus()
            Exit Sub
        Else

            FormMenuUtamaSalon.Show()
            FormMenuUtamaSalon.Panel1.Text = Rd.Item("Kode_User")
            FormMenuUtamaSalon.Panel2.Text = Rd.Item("Nama_User")
            FormMenuUtamaSalon.Panel3.Text = Rd.Item("Status_User")
        End If
    End Sub

End Class
