Imports System.Data.Odbc
Public Class Form1
    Dim cPassLogin, cStatusUser As String
    Sub cekPassword()
        cPassLogin = SHA256(txtPass.Text)
        cmd = New OdbcCommand("select * from tb_user where nama_user='" & txtUser.Text & "' and password='" & cPassLogin & "'", cn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            cLevelUser = rd.Item("level")
            cUserld = rd.Item("user_id")
            cNamaUser = rd.Item("nama_user")
            cStatusUser = rd.Item("status")

            If cStatusUser = "aktif" Then
                Me.Visible = False
                If cLevelUser = "admin" Then
                    formMenuAdmin.Show()
                    formMenuAdmin.tssCopyright.Text = "CopyRight By Fiqri28 @2023"
                    formMenuAdmin.tssUser.Text = "User : " + cNamaUser
                    formMenuAdmin.tssLevel.Text = "level : " + cLevelUser
                    formMenuAdmin.tssWaktu.Text = Format(Now, "dddd, dd-MM-yyyy")
                    formMenuAdmin.tssUser.Width = 200
                    formMenuAdmin.tssLevel.Width = 75
                Else
                    formMenuUser.Show()
                    formMenuUser.tssCopyright.Text = "CopyRight By Fiqri28 @2023"
                    formMenuUser.tssUser.Text = "User : " + cNamaUser
                    formMenuUser.tssLevel.Text = "level : " + cLevelUser
                    formMenuUser.tssWaktu.Text = Format(Now, "dddd, dd-MM-yyyy")
                    formMenuUser.tssUser.Width = 200
                    formMenuUser.tssLevel.Width = 75
                End If
            Else
                MsgBox("Maaf....Akun anda belum aktif hubungi admin", MsgBoxStyle.Critical, "Perhatian !!")
            End If
        Else
            MsgBox("Maaf...Username atau password salah", MsgBoxStyle.Critical + vbOKOnly, "perhatian")
            txtUser.Focus()
            Exit Sub
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        txtUser.Text = GetSetting("AplikasiPrediksi", "Data", "User", "")
        txtPass.UseSystemPasswordChar = True
        btnpass.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cekPassword()
        If CheckBox1.Checked = True Then
            SaveSetting("AplikasiPrediksi", "Data", "User", Trim(txtUser.Text))
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        registrasi.Show()
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged
        txtUser.Text = StripNonAlphaNum(txtUser.Text)

    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SendKeys.Send("(Tab)")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Visible = False

        formUbahpass.Show()
    End Sub

    Private Sub btnpass_Click(sender As Object, e As EventArgs) Handles btnpass.Click
        If txtPass.UseSystemPasswordChar = False Then
            txtPass.UseSystemPasswordChar = True
            btnpass.Image = AplikasiPrediksiMahasiswaRegistras.My.Resources.icons8_eye_24__1_
        Else
            txtPass.UseSystemPasswordChar = False
            btnpass.Image = AplikasiPrediksiMahasiswaRegistras.My.Resources.icons8_closed_eye_24
        End If

    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        If txtPass.TextLength > 0 Then
            btnpass.Visible = True
        Else
            btnpass.Visible = False
        End If
    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = Chr(13) Then
            If Len(txtUser.Text) <= 1 Then
                txtUser.Focus()
                Exit Sub
            End If
        End If

        If Char.IsLetterOrDigit(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
End Class
