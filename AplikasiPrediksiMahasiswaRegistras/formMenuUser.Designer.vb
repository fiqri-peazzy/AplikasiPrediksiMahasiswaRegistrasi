<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMenuUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssCopyright = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssLevel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssWaktu = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LapDatasetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapHasilPrediksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssCopyright, Me.tssUser, Me.tssLevel, Me.tssWaktu})
        Me.StatusStrip1.Location = New System.Drawing.Point(168, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssCopyright
        '
        Me.tssCopyright.Name = "tssCopyright"
        Me.tssCopyright.Size = New System.Drawing.Size(68, 17)
        Me.tssCopyright.Text = "Copyright"
        '
        'tssUser
        '
        Me.tssUser.Margin = New System.Windows.Forms.Padding(7, 3, 0, 2)
        Me.tssUser.Name = "tssUser"
        Me.tssUser.Size = New System.Drawing.Size(35, 17)
        Me.tssUser.Text = "User"
        Me.tssUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tssLevel
        '
        Me.tssLevel.Name = "tssLevel"
        Me.tssLevel.Size = New System.Drawing.Size(436, 17)
        Me.tssLevel.Spring = True
        Me.tssLevel.Text = "Level"
        '
        'tssWaktu
        '
        Me.tssWaktu.Name = "tssWaktu"
        Me.tssWaktu.Size = New System.Drawing.Size(47, 17)
        Me.tssWaktu.Text = "Waktu"
        Me.tssWaktu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LapDatasetToolStripMenuItem, Me.LapHasilPrediksiToolStripMenuItem, Me.UbahPasswordToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(168, 450)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LapDatasetToolStripMenuItem
        '
        Me.LapDatasetToolStripMenuItem.Image = Global.AplikasiPrediksiMahasiswaRegistras.My.Resources.Resources.icons8_terms_and_conditions_48
        Me.LapDatasetToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LapDatasetToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LapDatasetToolStripMenuItem.Name = "LapDatasetToolStripMenuItem"
        Me.LapDatasetToolStripMenuItem.Size = New System.Drawing.Size(155, 52)
        Me.LapDatasetToolStripMenuItem.Text = "Lap. Dataset"
        '
        'LapHasilPrediksiToolStripMenuItem
        '
        Me.LapHasilPrediksiToolStripMenuItem.Image = Global.AplikasiPrediksiMahasiswaRegistras.My.Resources.Resources.icons8_print_from_cloud_48
        Me.LapHasilPrediksiToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LapHasilPrediksiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LapHasilPrediksiToolStripMenuItem.Name = "LapHasilPrediksiToolStripMenuItem"
        Me.LapHasilPrediksiToolStripMenuItem.Size = New System.Drawing.Size(155, 52)
        Me.LapHasilPrediksiToolStripMenuItem.Text = "Lap. Hasil Prediksi"
        '
        'UbahPasswordToolStripMenuItem
        '
        Me.UbahPasswordToolStripMenuItem.Image = Global.AplikasiPrediksiMahasiswaRegistras.My.Resources.Resources.icons8_password_reset_48
        Me.UbahPasswordToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UbahPasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UbahPasswordToolStripMenuItem.Name = "UbahPasswordToolStripMenuItem"
        Me.UbahPasswordToolStripMenuItem.Size = New System.Drawing.Size(155, 52)
        Me.UbahPasswordToolStripMenuItem.Text = "Ubah Password"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Image = Global.AplikasiPrediksiMahasiswaRegistras.My.Resources.Resources.icons8_shutdown_48
        Me.KeluarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.KeluarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(155, 52)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(168, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 428)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(629, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Aplikasi Prediksi Jumlah Mahasiswa Registrasi"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AplikasiPrediksiMahasiswaRegistras.My.Resources.Resources.mayang
        Me.PictureBox1.Location = New System.Drawing.Point(238, 121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(629, 44)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Universitas Ichsan Gorontalo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'formMenuUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formMenuUser"
        Me.Text = "formMenuUser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tssCopyright As ToolStripStatusLabel
    Friend WithEvents tssUser As ToolStripStatusLabel
    Friend WithEvents tssLevel As ToolStripStatusLabel
    Friend WithEvents tssWaktu As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LapDatasetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LapHasilPrediksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbahPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
