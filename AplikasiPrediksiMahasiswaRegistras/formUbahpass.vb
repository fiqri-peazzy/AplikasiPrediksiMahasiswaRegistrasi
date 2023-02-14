Imports System.Data.Odbc
Public Class formUbahpass
    Private Sub formUbahpass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnpass.Visible = False
        btnconfirm.Enabled = False
        txtpass.UseSystemPasswordChar = True
        txtcpass.UseSystemPasswordChar = True
        userid.Text = ""
        username.Text = ""
        txtpass.Text = ""
        txtcpass.Text = ""

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        registrasi.Show()
    End Sub

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        Dim cPassLogin As String
        cPassLogin = SHA256(txtpass.Text)
        Call koneksi()
        cmd = New OdbcCommand("select * from tb_user where nama_user='" & username.Text & "' and user_id='" & userid.Text & "'", cn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Call koneksi()
            cPassLogin = SHA256(txtpass.Text)
            cmd = New OdbcCommand("select * from tb_user where user_id='" & userid.Text & "'", cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If txtpass.Text = txtcpass.Text Then
                    Dim sql As String
                    sql = "update tb_user set password='" & cPassLogin & "' where user_id='" & userid.Text & "'"
                    cmd = New OdbcCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Password berhasil di ubah", MsgBoxStyle.Information, "Sukses ubah password")
                    Me.Visible = False
                    Me.Close()
                    Form1.Show()
                Else
                    MsgBox("Password tidak cocok", MsgBoxStyle.Critical, "perhatian")

                End If
            Else
                MsgBox("User id atau username tidak dikenali", MsgBoxStyle.Information, "perhatian")

            End If
        End If
    End Sub

    Private Sub formUbahpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SendKeys.Send("(Tab)")
        End If
    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged
        If txtpass.TextLength > 0 Then
            btnpass.Visible = True
            btnconfirm.Enabled = True
        Else
            btnpass.Visible = False
            btnconfirm.Enabled = False
        End If
    End Sub

    Private Sub btnpass_Click(sender As Object, e As EventArgs) Handles btnpass.Click
        If txtpass.UseSystemPasswordChar = False Then
            txtpass.UseSystemPasswordChar = True
            txtcpass.UseSystemPasswordChar = True
            btnpass.Image = AplikasiPrediksiMahasiswaRegistras.My.Resources.icons8_eye_24__1_
        Else
            txtpass.UseSystemPasswordChar = False
            txtcpass.UseSystemPasswordChar = False
            btnpass.Image = AplikasiPrediksiMahasiswaRegistras.My.Resources.icons8_closed_eye_24

        End If
    End Sub
End Class