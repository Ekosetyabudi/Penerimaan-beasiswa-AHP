<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_subkriteria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_subkriteria))
        Me.Nama_sub = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cb_pilihkriteria = New System.Windows.Forms.ComboBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Keterangan = New System.Windows.Forms.TextBox()
        Me.bt_hapus = New System.Windows.Forms.Button()
        Me.bt_tutup = New System.Windows.Forms.Button()
        Me.bt_tambah = New System.Windows.Forms.Button()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.noUrutan = New System.Windows.Forms.NumericUpDown()
        Me.cb_kriteria = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel1.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.noUrutan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nama_sub
        '
        Me.Nama_sub.Location = New System.Drawing.Point(121, 136)
        Me.Nama_sub.Name = "Nama_sub"
        Me.Nama_sub.Size = New System.Drawing.Size(210, 20)
        Me.Nama_sub.TabIndex = 43
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(16, 139)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(106, 13)
        Me.label3.TabIndex = 41
        Me.label3.Text = "Nama sub kriteria"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(16, 110)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(85, 13)
        Me.label2.TabIndex = 40
        Me.label2.Text = "Id sub kriteria"
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(1, 6)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(895, 59)
        Me.panel1.TabIndex = 39
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(13, 24)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(192, 25)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Data Sub Kriteria"
        '
        'cb_pilihkriteria
        '
        Me.cb_pilihkriteria.FormattingEnabled = True
        Me.cb_pilihkriteria.Location = New System.Drawing.Point(121, 84)
        Me.cb_pilihkriteria.Name = "cb_pilihkriteria"
        Me.cb_pilihkriteria.Size = New System.Drawing.Size(210, 21)
        Me.cb_pilihkriteria.TabIndex = 51
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(16, 87)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(47, 13)
        Me.label5.TabIndex = 50
        Me.label5.Text = "Kriteria"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(16, 167)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(72, 13)
        Me.label4.TabIndex = 48
        Me.label4.Text = "Keterangan"
        '
        'Keterangan
        '
        Me.Keterangan.Location = New System.Drawing.Point(121, 162)
        Me.Keterangan.Multiline = True
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Size = New System.Drawing.Size(210, 38)
        Me.Keterangan.TabIndex = 49
        '
        'bt_hapus
        '
        Me.bt_hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_hapus.Location = New System.Drawing.Point(145, 206)
        Me.bt_hapus.Name = "bt_hapus"
        Me.bt_hapus.Size = New System.Drawing.Size(113, 50)
        Me.bt_hapus.TabIndex = 47
        Me.bt_hapus.Text = "HAPUS"
        Me.bt_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_hapus.UseVisualStyleBackColor = True
        '
        'bt_tutup
        '
        Me.bt_tutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_tutup.Location = New System.Drawing.Point(264, 206)
        Me.bt_tutup.Name = "bt_tutup"
        Me.bt_tutup.Size = New System.Drawing.Size(113, 50)
        Me.bt_tutup.TabIndex = 46
        Me.bt_tutup.Text = "TUTUP"
        Me.bt_tutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_tutup.UseVisualStyleBackColor = True
        '
        'bt_tambah
        '
        Me.bt_tambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_tambah.Location = New System.Drawing.Point(26, 206)
        Me.bt_tambah.Name = "bt_tambah"
        Me.bt_tambah.Size = New System.Drawing.Size(113, 50)
        Me.bt_tambah.TabIndex = 45
        Me.bt_tambah.Text = "TAMBAH"
        Me.bt_tambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_tambah.UseVisualStyleBackColor = True
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(6, 47)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(852, 150)
        Me.dataGridView1.TabIndex = 44
        '
        'noUrutan
        '
        Me.noUrutan.Location = New System.Drawing.Point(121, 108)
        Me.noUrutan.Name = "noUrutan"
        Me.noUrutan.Size = New System.Drawing.Size(210, 20)
        Me.noUrutan.TabIndex = 52
        Me.noUrutan.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cb_kriteria
        '
        Me.cb_kriteria.FormattingEnabled = True
        Me.cb_kriteria.Location = New System.Drawing.Point(6, 20)
        Me.cb_kriteria.Name = "cb_kriteria"
        Me.cb_kriteria.Size = New System.Drawing.Size(846, 21)
        Me.cb_kriteria.TabIndex = 53
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dataGridView1)
        Me.GroupBox1.Controls.Add(Me.cb_kriteria)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 262)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(858, 203)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tabel Sub Kriteria"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(271, 212)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 62
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(152, 211)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 61
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(31, 211)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'Data_subkriteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(896, 477)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.noUrutan)
        Me.Controls.Add(Me.Nama_sub)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.cb_pilihkriteria)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.Keterangan)
        Me.Controls.Add(Me.bt_hapus)
        Me.Controls.Add(Me.bt_tutup)
        Me.Controls.Add(Me.bt_tambah)
        Me.Name = "Data_subkriteria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data_subkriteria"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.noUrutan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Nama_sub As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents cb_pilihkriteria As System.Windows.Forms.ComboBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents Keterangan As System.Windows.Forms.TextBox
    Private WithEvents bt_hapus As System.Windows.Forms.Button
    Private WithEvents bt_tutup As System.Windows.Forms.Button
    Private WithEvents bt_tambah As System.Windows.Forms.Button
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents noUrutan As System.Windows.Forms.NumericUpDown
    Private WithEvents cb_kriteria As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
