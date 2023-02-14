Imports System.Data.Odbc
Public Class registrasi
    Dim cPassSHA256 As String
    Private Sub registrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnpass.Visible = False
        btndaftar.Enabled = False
        username.Enabled = False
        txtpass.Enabled = False
        txtcpass.Enabled = False
        txtpass.UseSystemPasswordChar = True
        txtcpass.UseSystemPasswordChar = True
        userid.Text = ""
        username.Text = ""
        txtpass.Text = ""
        txtcpass.Text = ""
    End Sub

    Private Sub registrasi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SendKeys.Send("(Tab)")
        End If
    End Sub

    Private Sub userid_Validated(sender As Object, e As EventArgs) Handles userid.Validated
        If userid.TextLength > 0 Then
            Call koneksi()
            cmd = New OdbcCommand("select * from tb_user where user_id ='" & userid.Text & "'", cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                MsgBox("user id telah di gunakan " & Environment.NewLine & "" & "Isikan yang lain...", MsgBoxStyle.Critical, "Perhatian")
                userid.Clear()
                userid.Focus()
                Exit Sub
            Else
                username.Enabled = True
                txtpass.Enabled = True
                txtcpass.Enabled = True
                username.Focus()

            End If
        End If
    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged
        If txtpass.TextLength > 0 Then
            btnpass.Visible = True
            btndaftar.Enabled = True
        Else
            btnpass.Visible = False
            btndaftar.Enabled = False
        End If
    End Sub

    Private Sub btndaftar_Click(sender As Object, e As EventArgs) Handles btndaftar.Click
        cPassSHA256 = SHA256(txtpass.Text)
        Dim xLevel As String
        If username.TextLength < 5 Then
            MsgBox("User id minimal 5 huruf", MsgBoxStyle.Information, "konfirmasi")
            username.Focus()
            Exit Sub
        End If

        If txtpass.TextLength < 5 Then
            MsgBox("Password minimal 5 huruf", MsgBoxStyle.Information, "Konfirmasi")
            txtpass.Focus()
            Exit Sub
        End If
        Call koneksi()
        cmd = New OdbcCommand("select count(*) from tb_user", cn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.Item(0) = 0 Then
            xLevel = "admin"
        Else
            xLevel = "user"
        End If

        cmd = New OdbcCommand("select * from tb_user where user_id='" & userid.Text & "'", cn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            If txtpass.Text = txtcpass.Text Then
                Dim sql As String
                Call koneksi()
                sql = "insert into tb_user values('" & userid.Text & "', '" & username.Text & "', '" & cPassSHA256 & "','" & xLevel & "','aktif')"
                cmd = New OdbcCommand(sql, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Pendaftaran Berhasil", MsgBoxStyle.Information, "daftar user")
                Me.Close()
                Me.Visible = False
                Form1.Show()
            Else
                MsgBox("password tidak cocok", MsgBoxStyle.Information, "daftar user")
                txtcpass.Focus()
            End If
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btnpass_Click(sender As Object, e As EventArgs) Handles btnpass.Click
        If txtpass.UseSystemPasswordChar = False Then
            txtpass.UseSystemPasswordChar = True
            btnpass.Image = AplikasiPrediksiMahasiswaRegistras.My.Resources.icons8_eye_24__1_
        Else
            txtpass.UseSystemPasswordChar = False
            btnpass.Image = AplikasiPrediksiMahasiswaRegistras.My.Resources.icons8_closed_eye_24
        End If
    End Sub
End Class