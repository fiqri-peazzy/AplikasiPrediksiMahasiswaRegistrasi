Imports System.Data.Odbc
Public Class formListDtUser
    Private Sub formListDtUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampildt()

    End Sub
    Sub tampildt()
        Dim btnReset As New DataGridViewButtonColumn()
        Dim btnEdit As New DataGridViewButtonColumn()
        Dim btnHapus As New DataGridViewButtonColumn()
        dgv.Columns.Clear()
        If txtcrinama.Text <> "" Then
            Call koneksi()
            da = New OdbcDataAdapter("select user_id,nama_user,level,status from tb_user where nama_user like %'" & txtcrinama.Text & "'% order by _user_id", cn)
        Else
            da = New OdbcDataAdapter("select user_id, nama_user, level, status from tb_user order by user_id", cn)

        End If

        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_user")
        dgv.DataSource = (ds.Tables("tb_user"))
        dgv.ReadOnly = True
        dgv.AllowUserToAddRows = False
        dgv.Columns(0).Width = 100
        dgv.Columns(1).Width = 200
        dgv.Columns(2).Width = 60
        dgv.Columns(3).Width = 60
        dgv.RowTemplate.Height = 25

        dgv.DefaultCellStyle.ForeColor = Color.Blue
        dgv.RowHeadersDefaultCellStyle.BackColor = Color.LightYellow
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgv.Columns(0).HeaderText = "User Id"
        dgv.Columns(1).HeaderText = "Nama User"
        dgv.Columns(2).HeaderText = "Level"
        dgv.Columns(3).HeaderText = "Status"

        dgv.Columns().Add(btnReset)
        btnReset.HeaderText = ""
        btnReset.Name = "btnReset"
        btnReset.DefaultCellStyle.ForeColor = Color.Black
        btnReset.UseColumnTextForButtonValue = True

        dgv.Columns().Add(btnEdit)
        btnEdit.HeaderText = ""
        btnEdit.Name = "btnEdit"
        btnEdit.DefaultCellStyle.ForeColor = Color.Green
        btnEdit.UseColumnTextForButtonValue = True

        dgv.Columns().Add(btnHapus)
        btnHapus.HeaderText = ""
        btnHapus.Name = "btnHapus"
        btnHapus.DefaultCellStyle.ForeColor = Color.Green
        btnHapus.UseColumnTextForButtonValue = True

        dgv.Columns(4).Width = 60
        dgv.Columns(5).Width = 60
        dgv.Columns(6).Width = 60

    End Sub

    Private Sub formListDtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SendKeys.Send("(Tab)")
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        tblEdit = False
        formEntryDtUser.Show(Me)
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim cUser_id, cPassSHA256 As String
        If e.ColumnIndex = 4 Then
            tblEdit = True
            cUserld = dgv.SelectedRows.Item(0).Cells(0).Value()
            cPassSHA256 = SHA256(cUser_id)
            If MessageBox.Show("Yakin akan direset ?", "Reset password", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                cmd = New OdbcCommand("select * from tb_user where user_id='" & cUser_id & "'", cn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    Dim sql As String
                    sql = "update tb_user set password='" & cPassSHA256 & "' where user_id='" & cUser_id & "'"
                    cmd = New OdbcCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                    MsgBox("password berhasi di reset", MsgBoxStyle.Critical, "sukses!")
                    Exit Sub

                End If
            End If
        End If
        If e.ColumnIndex = 5 Then
            tblEdit = True
            formEntryDtUser.userid.Text = dgv.SelectedRows.Item(0).Cells(0).Value(0)
            formEntryDtUser.Show()

        End If

        If e.ColumnIndex = 6 Then
            cUserld = dgv.SelectedRows.Item(0).Cells(0).Value()
            cmd = New OdbcCommand("select count(*) as jml from tb_user", cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.Item(0) = 1 Then
                MsgBox("Maaf Data User tidak bisa dihapus", MsgBoxStyle.Critical, "Perhatian")
                Exit Sub
            Else
                If MessageBox.Show("Yakin Akan Menghapus?", "Hapus data", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Call koneksi()
                    cmd = New OdbcCommand("delete from tb_user where user_id='" & cUser_id & "'", cn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Berhasil Hapus", MsgBoxStyle.Information)
                    Call tampildt()
                End If

            End If

        End If
    End Sub

    Private Sub txtcrinama_TextChanged(sender As Object, e As EventArgs) Handles txtcrinama.TextChanged
        tampildt()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
End Class