<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Halaman_Utama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Halaman_Utama))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.bt_laporan = New System.Windows.Forms.Button()
        Me.bt_input = New System.Windows.Forms.Button()
        Me.bt_nilaialternatif = New System.Windows.Forms.Button()
        Me.bt_pb = New System.Windows.Forms.Button()
        Me.panel_input = New System.Windows.Forms.Panel()
        Me.bt_datasiswa = New System.Windows.Forms.Button()
        Me.bt_datasub = New System.Windows.Forms.Button()
        Me.bt_datakriteria = New System.Windows.Forms.Button()
        Me.bt_dataadmin = New System.Windows.Forms.Button()
        Me.Panel_pb = New System.Windows.Forms.Panel()
        Me.bt_subkriteria = New System.Windows.Forms.Button()
        Me.bt_kriteria = New System.Windows.Forms.Button()
        Me.bt_ahp = New System.Windows.Forms.Button()
        Me.bt_infonilai = New System.Windows.Forms.Button()
        Me.Panel_laporan = New System.Windows.Forms.Panel()
        Me.Timer_pb = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_input = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_laporan = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel1.SuspendLayout()
        Me.panel_input.SuspendLayout()
        Me.Panel_pb.SuspendLayout()
        Me.Panel_laporan.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 1)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(898, 80)
        Me.panel1.TabIndex = 7
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(93, 27)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(680, 24)
        Me.label1.TabIndex = 0
        Me.label1.Text = "HALAMAN UTAMA SISTEM PENERIMAAN BEASISWA SMK Dr. Sutomo"
        '
        'bt_laporan
        '
        Me.bt_laporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_laporan.Location = New System.Drawing.Point(574, 309)
        Me.bt_laporan.Name = "bt_laporan"
        Me.bt_laporan.Size = New System.Drawing.Size(265, 77)
        Me.bt_laporan.TabIndex = 11
        Me.bt_laporan.Text = "LAPORAN OUTPUT"
        Me.bt_laporan.UseVisualStyleBackColor = True
        '
        'bt_input
        '
        Me.bt_input.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_input.Location = New System.Drawing.Point(30, 310)
        Me.bt_input.Name = "bt_input"
        Me.bt_input.Size = New System.Drawing.Size(265, 77)
        Me.bt_input.TabIndex = 10
        Me.bt_input.Text = "INPUT"
        Me.bt_input.UseVisualStyleBackColor = True
        '
        'bt_nilaialternatif
        '
        Me.bt_nilaialternatif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_nilaialternatif.Location = New System.Drawing.Point(574, 87)
        Me.bt_nilaialternatif.Name = "bt_nilaialternatif"
        Me.bt_nilaialternatif.Size = New System.Drawing.Size(265, 77)
        Me.bt_nilaialternatif.TabIndex = 9
        Me.bt_nilaialternatif.Text = "NILAI ALTERNATIF"
        Me.bt_nilaialternatif.UseVisualStyleBackColor = True
        '
        'bt_pb
        '
        Me.bt_pb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_pb.Location = New System.Drawing.Point(30, 87)
        Me.bt_pb.Name = "bt_pb"
        Me.bt_pb.Size = New System.Drawing.Size(265, 77)
        Me.bt_pb.TabIndex = 8
        Me.bt_pb.Text = "PERBANDINGAN BERPASANGAN"
        Me.bt_pb.UseVisualStyleBackColor = True
        '
        'panel_input
        '
        Me.panel_input.Controls.Add(Me.bt_datasiswa)
        Me.panel_input.Controls.Add(Me.bt_datasub)
        Me.panel_input.Controls.Add(Me.bt_datakriteria)
        Me.panel_input.Controls.Add(Me.bt_dataadmin)
        Me.panel_input.Location = New System.Drawing.Point(30, 393)
        Me.panel_input.Name = "panel_input"
        Me.panel_input.Size = New System.Drawing.Size(265, 0)
        Me.panel_input.TabIndex = 13
        '
        'bt_datasiswa
        '
        Me.bt_datasiswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_datasiswa.Location = New System.Drawing.Point(0, 160)
        Me.bt_datasiswa.Name = "bt_datasiswa"
        Me.bt_datasiswa.Size = New System.Drawing.Size(262, 47)
        Me.bt_datasiswa.TabIndex = 10
        Me.bt_datasiswa.Text = "DATA SISWA"
        Me.bt_datasiswa.UseVisualStyleBackColor = True
        '
        'bt_datasub
        '
        Me.bt_datasub.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_datasub.Location = New System.Drawing.Point(0, 107)
        Me.bt_datasub.Name = "bt_datasub"
        Me.bt_datasub.Size = New System.Drawing.Size(262, 47)
        Me.bt_datasub.TabIndex = 9
        Me.bt_datasub.Text = "DATA SUB KRITERIA"
        Me.bt_datasub.UseVisualStyleBackColor = True
        '
        'bt_datakriteria
        '
        Me.bt_datakriteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_datakriteria.Location = New System.Drawing.Point(0, 54)
        Me.bt_datakriteria.Name = "bt_datakriteria"
        Me.bt_datakriteria.Size = New System.Drawing.Size(262, 47)
        Me.bt_datakriteria.TabIndex = 8
        Me.bt_datakriteria.Text = "DATA KRIERIA"
        Me.bt_datakriteria.UseVisualStyleBackColor = True
        '
        'bt_dataadmin
        '
        Me.bt_dataadmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_dataadmin.Location = New System.Drawing.Point(0, 1)
        Me.bt_dataadmin.Name = "bt_dataadmin"
        Me.bt_dataadmin.Size = New System.Drawing.Size(262, 47)
        Me.bt_dataadmin.TabIndex = 7
        Me.bt_dataadmin.Text = "DATA GURU"
        Me.bt_dataadmin.UseVisualStyleBackColor = True
        '
        'Panel_pb
        '
        Me.Panel_pb.Controls.Add(Me.bt_subkriteria)
        Me.Panel_pb.Controls.Add(Me.bt_kriteria)
        Me.Panel_pb.Location = New System.Drawing.Point(30, 160)
        Me.Panel_pb.Name = "Panel_pb"
        Me.Panel_pb.Size = New System.Drawing.Size(262, 0)
        Me.Panel_pb.TabIndex = 14
        '
        'bt_subkriteria
        '
        Me.bt_subkriteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_subkriteria.Location = New System.Drawing.Point(0, 63)
        Me.bt_subkriteria.Name = "bt_subkriteria"
        Me.bt_subkriteria.Size = New System.Drawing.Size(262, 47)
        Me.bt_subkriteria.TabIndex = 13
        Me.bt_subkriteria.Text = "SUB KRITERIA"
        Me.bt_subkriteria.UseVisualStyleBackColor = True
        '
        'bt_kriteria
        '
        Me.bt_kriteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_kriteria.Location = New System.Drawing.Point(0, 10)
        Me.bt_kriteria.Name = "bt_kriteria"
        Me.bt_kriteria.Size = New System.Drawing.Size(262, 47)
        Me.bt_kriteria.TabIndex = 12
        Me.bt_kriteria.Text = "KRITERIA"
        Me.bt_kriteria.UseVisualStyleBackColor = True
        '
        'bt_ahp
        '
        Me.bt_ahp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ahp.Location = New System.Drawing.Point(0, 63)
        Me.bt_ahp.Name = "bt_ahp"
        Me.bt_ahp.Size = New System.Drawing.Size(262, 47)
        Me.bt_ahp.TabIndex = 13
        Me.bt_ahp.Text = "AHP"
        Me.bt_ahp.UseVisualStyleBackColor = True
        '
        'bt_infonilai
        '
        Me.bt_infonilai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_infonilai.Location = New System.Drawing.Point(0, 10)
        Me.bt_infonilai.Name = "bt_infonilai"
        Me.bt_infonilai.Size = New System.Drawing.Size(262, 47)
        Me.bt_infonilai.TabIndex = 12
        Me.bt_infonilai.Text = "INFORMASI NILAI PRIORITAS"
        Me.bt_infonilai.UseVisualStyleBackColor = True
        '
        'Panel_laporan
        '
        Me.Panel_laporan.Controls.Add(Me.bt_ahp)
        Me.Panel_laporan.Controls.Add(Me.bt_infonilai)
        Me.Panel_laporan.Location = New System.Drawing.Point(577, 383)
        Me.Panel_laporan.Name = "Panel_laporan"
        Me.Panel_laporan.Size = New System.Drawing.Size(262, 0)
        Me.Panel_laporan.TabIndex = 15
        '
        'Timer_pb
        '
        '
        'Timer_input
        '
        '
        'Timer_laporan
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(829, 627)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Halaman_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(897, 689)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel_laporan)
        Me.Controls.Add(Me.Panel_pb)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.bt_laporan)
        Me.Controls.Add(Me.bt_input)
        Me.Controls.Add(Me.bt_nilaialternatif)
        Me.Controls.Add(Me.bt_pb)
        Me.Controls.Add(Me.panel_input)
        Me.Name = "Halaman_Utama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Halaman_Utama"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel_input.ResumeLayout(False)
        Me.Panel_pb.ResumeLayout(False)
        Me.Panel_laporan.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents bt_laporan As System.Windows.Forms.Button
    Private WithEvents bt_input As System.Windows.Forms.Button
    Private WithEvents bt_nilaialternatif As System.Windows.Forms.Button
    Private WithEvents bt_pb As System.Windows.Forms.Button
    Private WithEvents panel_input As System.Windows.Forms.Panel
    Private WithEvents bt_datasub As System.Windows.Forms.Button
    Private WithEvents bt_datakriteria As System.Windows.Forms.Button
    Private WithEvents bt_dataadmin As System.Windows.Forms.Button
    Private WithEvents bt_datasiswa As System.Windows.Forms.Button
    Friend WithEvents Panel_pb As System.Windows.Forms.Panel
    Private WithEvents bt_subkriteria As System.Windows.Forms.Button
    Private WithEvents bt_kriteria As System.Windows.Forms.Button
    Private WithEvents bt_ahp As System.Windows.Forms.Button
    Private WithEvents bt_infonilai As System.Windows.Forms.Button
    Friend WithEvents Panel_laporan As System.Windows.Forms.Panel
    Friend WithEvents Timer_pb As System.Windows.Forms.Timer
    Friend WithEvents Timer_input As System.Windows.Forms.Timer
    Friend WithEvents Timer_laporan As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
