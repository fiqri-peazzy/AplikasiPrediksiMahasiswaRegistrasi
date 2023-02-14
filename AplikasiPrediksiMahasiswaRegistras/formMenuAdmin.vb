Public Class formMenuAdmin
    Private Sub formMenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Aplikasi Prediksi Mahasiswa Registrasi Dengan Metode Last Square"
    End Sub

    Private Sub mnkeluar_Click(sender As Object, e As EventArgs) Handles mnkeluar.Click
        If MessageBox.Show("Yakin Ingin keluar dari sistem ?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cn.Close()
        End If
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        mnkeluar_Click(sender, e)
    End Sub
End Class