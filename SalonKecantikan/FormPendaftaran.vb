
Imports MySql.Data.MySqlClient
Public Class FormPendaftaran



    Sub Notis()

        Call OpenConn()

        Cmd = New MySqlCommand("select kode_Pendaftaran from tbl_pendaftaran order by Kode_Pendaftaran desc", Conn)

        Rd = Cmd.ExecuteReader

        Rd.Read()

        If Not Rd.HasRows Then

            TxtKode.Text = "00001"

        Else

            TxtKode.Text = Format(Microsoft.VisualBasic.Right(Rd("kode_Pendaftaran"), 5) + 1, "00000")

        End If

    End Sub



    Sub Kosongkan()

        Call Notis()

        TxtKode.Enabled = False

        cmbKodeCus.Text = ""

        TxtNamaCus.Clear()

        Tanggal.Focus()

        Call tampilkodecustomer()

        Call TampilGrid()

    End Sub



    Sub DataBaru()

        TxtNamaCus.Clear()

        Tanggal.Text = ""

        TxtNamaCus.Focus()

    End Sub



    Sub Ketemu()

        TxtKode.Enabled = False

        Tanggal.Text = Rd("Tanggal_pendaftaran")

        Tanggal.Text = Rd("Kode_Customer")

        Call OpenConn()

        Cmd = New MySqlCommand("select Nama_Customer from tbl_custumer where Kode_Customer='" & TxtKode.Text & "'", Conn)

        Rd = Cmd.ExecuteReader

        Rd.Read()

        If Rd.HasRows Then

            cmbKodeCus.Text = Tanggal.Text = Rd("Nama_Customer")

        End If

        cmbKodeCus.Focus()

    End Sub



    Sub TampilGrid()

        Call OpenConn()

        Da = New MySqlDataAdapter("select * from tbl_pendaftaran", Conn)

        Ds = New DataSet

        Da.Fill(Ds)

        DataGridView1.DataSource = Ds.Tables(0)

        DataGridView1.ReadOnly = True

    End Sub



    Sub tampilkodecustomer()

        Call OpenConn()

        Cmd = New MySqlCommand("select Kode_Customer from tbl_custumer", Conn)

        Rd = Cmd.ExecuteReader

        cmbKodeCus.Items.Clear()

        Do While Rd.Read

            cmbKodeCus.Items.Add(Rd("Kode_Customer"))

        Loop

    End Sub



    Sub CariKode()

        Call OpenConn()

        Cmd = New MySqlCommand("select * from tbl_pendaftaran where Kode_Pendaftaran='" & TxtKode.Text & "'", Conn)

        Rd = Cmd.ExecuteReader

        Rd.Read()

    End Sub



    Private Sub FormPendaftaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

        Call OpenConn()

        Call Kosongkan()

    End Sub



    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click

        Call Kosongkan()

    End Sub



    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click

        Me.Close()

    End Sub



    Private Sub Tanggal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tanggal.LostFocus

        Tanggal.Text = UCase(Tanggal.Text)

    End Sub





    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click

        Call OpenConn()

        Cmd = New MySqlCommand("select * from tbl_pendaftaran where Kode_Pendaftaran='" & TxtKode.Text & "'", Conn)

        Rd = Cmd.ExecuteReader

        Rd.Read()

        Try

            If Not Rd.HasRows Then

                Call OpenConn()

                Dim simpan As String = "insert into tbl_pendaftaran values ('" & TxtKode.Text & "','" & Format(DateValue(Tanggal.Text), "yyyy/MM/dd") & "','" & UCase(cmbKodeCus.Text) & "','TERDAFTAR')"

                Cmd = New MySqlCommand(simpan, Conn)

                Cmd.ExecuteNonQuery()

            Else

                Call OpenConn()

                Dim edit As String = "update tbl_pendaftaran set Tanggal_Pendaftaran='" & Tanggal.Text & "',Kode_Customer='" & UCase(cmbKodeCus.Text) & "' where Kode_Pendaftaran='" & TxtKode.Text & "'"

                Cmd = New MySqlCommand(edit, Conn)

                Cmd.ExecuteNonQuery()

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        Call Kosongkan()

    End Sub





    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

        On Error Resume Next

        TxtKode.Enabled = False

        TxtKode.Text = DataGridView1.Rows(e.RowIndex).Cells("Kode_Pendaftaran").Value

        Tanggal.Text = DataGridView1.Rows(e.RowIndex).Cells("Tanggal_Pendaftaran").Value

        cmbKodeCus.Text = DataGridView1.Rows(e.RowIndex).Cells("Kode_Customer").Value

        Tanggal.Focus()

    End Sub



    Private Sub cmbKodeCus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbKodeCus.KeyPress

        TxtKode.MaxLength = 5

        If e.KeyChar = Chr(13) Then

            BtnSimpan.Focus()

        End If

    End Sub





    Private Sub Tanggal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tanggal.KeyDown

        If e.KeyCode = Keys.Enter Then

            Tanggal.Focus()

        End If

    End Sub





    Private Sub cmbKodeCus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKodeCus.SelectedIndexChanged

        Call OpenConn()

        Cmd = New MySqlCommand("select * from tbl_custUmer where Kode_Customer='" & cmbKodeCus.Text & "'", Conn)

        Rd = Cmd.ExecuteReader

        Rd.Read()

        If Rd.HasRows Then

            TxtNamaCus.Text = Rd("Nama_Customer")

        Else

            MsgBox("Kode Customer Tidak Terdaftar")

        End If

    End Sub

End Class