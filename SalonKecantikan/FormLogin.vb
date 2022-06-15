Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Textuser.Text = "ADMIN"
        Textpass.Text = "ADMIN"
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        If Textuser.Text = "ADMIN" And Textpass.Text = "ADMIN" Then
            MessageBox.Show("LOGIN Berhasil :)!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FormMenuUtamaSalon.ShowDialog()
            Me.Close()
        Else MessageBox.Show("LOGIN GAGAL! username/password salah", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Textuser.Text = ""
            Textpass.Text = ""
        End If
    End Sub


End Class
