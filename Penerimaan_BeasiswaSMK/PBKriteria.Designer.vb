<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PBKriteria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PBKriteria))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.dataGridViewPB = New System.Windows.Forms.DataGridView()
        Me.dataGridViewPenjumlahan = New System.Windows.Forms.DataGridView()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.dataGridViewRasio = New System.Windows.Forms.DataGridView()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.dataGridViewPrioritas = New System.Windows.Forms.DataGridView()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.dataGridViewHasil = New System.Windows.Forms.DataGridView()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.bt_tutup = New System.Windows.Forms.Button()
        Me.bt_sismpan = New System.Windows.Forms.Button()
        Me.bt_proses = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupBox1.SuspendLayout()
        CType(Me.dataGridViewPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridViewPenjumlahan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        CType(Me.dataGridViewRasio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.SuspendLayout()
        CType(Me.dataGridViewPrioritas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox5.SuspendLayout()
        CType(Me.dataGridViewHasil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.dataGridViewPB)
        Me.groupBox1.Location = New System.Drawing.Point(6, 2)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(532, 280)
        Me.groupBox1.TabIndex = 8
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Matrik Perbandingan Berpasngan"
        '
        'dataGridViewPB
        '
        Me.dataGridViewPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewPB.Location = New System.Drawing.Point(6, 19)
        Me.dataGridViewPB.Name = "dataGridViewPB"
        Me.dataGridViewPB.Size = New System.Drawing.Size(520, 255)
        Me.dataGridViewPB.TabIndex = 0
        '
        'dataGridViewPenjumlahan
        '
        Me.dataGridViewPenjumlahan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewPenjumlahan.Location = New System.Drawing.Point(6, 19)
        Me.dataGridViewPenjumlahan.Name = "dataGridViewPenjumlahan"
        Me.dataGridViewPenjumlahan.Size = New System.Drawing.Size(520, 255)
        Me.dataGridViewPenjumlahan.TabIndex = 0
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.dataGridViewPenjumlahan)
        Me.groupBox2.Location = New System.Drawing.Point(6, 288)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(532, 280)
        Me.groupBox2.TabIndex = 9
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Penjumlahan Setiap Baris"
        '
        'dataGridViewRasio
        '
        Me.dataGridViewRasio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewRasio.Location = New System.Drawing.Point(6, 19)
        Me.dataGridViewRasio.Name = "dataGridViewRasio"
        Me.dataGridViewRasio.Size = New System.Drawing.Size(520, 255)
        Me.dataGridViewRasio.TabIndex = 0
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.dataGridViewRasio)
        Me.groupBox3.Location = New System.Drawing.Point(544, 288)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(532, 280)
        Me.groupBox3.TabIndex = 10
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Rasio Konsistensi"
        '
        'dataGridViewPrioritas
        '
        Me.dataGridViewPrioritas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewPrioritas.Location = New System.Drawing.Point(6, 19)
        Me.dataGridViewPrioritas.Name = "dataGridViewPrioritas"
        Me.dataGridViewPrioritas.Size = New System.Drawing.Size(520, 255)
        Me.dataGridViewPrioritas.TabIndex = 0
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.dataGridViewHasil)
        Me.groupBox5.Location = New System.Drawing.Point(1093, 3)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(244, 359)
        Me.groupBox5.TabIndex = 12
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Hasil"
        '
        'dataGridViewHasil
        '
        Me.dataGridViewHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewHasil.Location = New System.Drawing.Point(5, 17)
        Me.dataGridViewHasil.Name = "dataGridViewHasil"
        Me.dataGridViewHasil.Size = New System.Drawing.Size(233, 336)
        Me.dataGridViewHasil.TabIndex = 0
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.dataGridViewPrioritas)
        Me.groupBox4.Location = New System.Drawing.Point(550, 2)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(532, 280)
        Me.groupBox4.TabIndex = 11
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Priority Vactor Matrix Normalitaion "
        '
        'bt_tutup
        '
        Me.bt_tutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_tutup.Location = New System.Drawing.Point(1098, 490)
        Me.bt_tutup.Name = "bt_tutup"
        Me.bt_tutup.Size = New System.Drawing.Size(239, 55)
        Me.bt_tutup.TabIndex = 15
        Me.bt_tutup.Text = "TUTUP"
        Me.bt_tutup.UseVisualStyleBackColor = True
        '
        'bt_sismpan
        '
        Me.bt_sismpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_sismpan.Location = New System.Drawing.Point(1098, 429)
        Me.bt_sismpan.Name = "bt_sismpan"
        Me.bt_sismpan.Size = New System.Drawing.Size(239, 55)
        Me.bt_sismpan.TabIndex = 14
        Me.bt_sismpan.Text = "SIMPAN"
        Me.bt_sismpan.UseVisualStyleBackColor = True
        '
        'bt_proses
        '
        Me.bt_proses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_proses.Location = New System.Drawing.Point(1098, 368)
        Me.bt_proses.Name = "bt_proses"
        Me.bt_proses.Size = New System.Drawing.Size(239, 55)
        Me.bt_proses.TabIndex = 13
        Me.bt_proses.Text = "PROSES"
        Me.bt_proses.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1109, 494)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 62
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1107, 374)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 61
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1108, 436)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'PBKriteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1343, 570)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox5)
        Me.Controls.Add(Me.groupBox4)
        Me.Controls.Add(Me.bt_tutup)
        Me.Controls.Add(Me.bt_sismpan)
        Me.Controls.Add(Me.bt_proses)
        Me.Name = "PBKriteria"
        Me.Text = "PBKriteria"
        Me.groupBox1.ResumeLayout(False)
        CType(Me.dataGridViewPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridViewPenjumlahan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        CType(Me.dataGridViewRasio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        CType(Me.dataGridViewPrioritas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox5.ResumeLayout(False)
        CType(Me.dataGridViewHasil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox4.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents dataGridViewPB As System.Windows.Forms.DataGridView
    Private WithEvents dataGridViewPenjumlahan As System.Windows.Forms.DataGridView
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents dataGridViewRasio As System.Windows.Forms.DataGridView
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents dataGridViewPrioritas As System.Windows.Forms.DataGridView
    Private WithEvents groupBox5 As System.Windows.Forms.GroupBox
    Private WithEvents dataGridViewHasil As System.Windows.Forms.DataGridView
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents bt_tutup As System.Windows.Forms.Button
    Private WithEvents bt_sismpan As System.Windows.Forms.Button
    Private WithEvents bt_proses As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
