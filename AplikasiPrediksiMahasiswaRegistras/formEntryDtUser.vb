Imports System.Data.Odbc
Public Class formEntryDtUser

    Private Sub formEntryDtUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each i As String In Level
            ComboBox1.Items.AddRange(i)
        Next
        ComboBox1.SelectedIndex = 1
        For Each i As String In Status_aktif
            ComboBox3.Items.AddRange(i)
        Next
        ComboBox3.SelectedIndex = 0

        If tblEdit = False Then
            Call databaru()
            Call tidaksiapisi()
        Else
            cmd = New OdbcCommand("select * from tb_user where user_id='" & userid.Text & "'", cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Call siapisi()
                username.Text = rd.Item("nama_user")
                ComboBox1.Text = rd.Item("level")
                ComboBox3.Text = rd.Item("status")
                userid.Enabled = False
            End If

        End If

    End Sub
    Sub databaru()
        username.Text = ""
        ComboBox1.SelectedIndex = 1
        ComboBox3.SelectedIndex = 0
        username.Focus()
    End Sub

    Sub siapisi()
        username.Enabled = True
        ComboBox1.Enabled = True
        ComboBox3.Enabled = True
        btnsave.Enabled = True

    End Sub

    Sub tidaksiapisi()
        username.Enabled = False
        ComboBox1.Enabled = False
        ComboBox3.Enabled = False
        btnsave.Enabled = False
    End Sub

    Private Sub formEntryDtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
End Class