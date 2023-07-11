<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_admin))
        Me.Nama_guru = New System.Windows.Forms.TextBox()
        Me.id_guru = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.bt_hapus = New System.Windows.Forms.Button()
        Me.bt_tutup = New System.Windows.Forms.Button()
        Me.bt_tambah = New System.Windows.Forms.Button()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.password = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.panel1.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nama_guru
        '
        Me.Nama_guru.Location = New System.Drawing.Point(145, 106)
        Me.Nama_guru.Name = "Nama_guru"
        Me.Nama_guru.Size = New System.Drawing.Size(244, 20)
        Me.Nama_guru.TabIndex = 51
        '
        'id_guru
        '
        Me.id_guru.Location = New System.Drawing.Point(145, 80)
        Me.id_guru.Name = "id_guru"
        Me.id_guru.Size = New System.Drawing.Size(244, 20)
        Me.id_guru.TabIndex = 50
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(22, 139)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(69, 15)
        Me.label5.TabIndex = 49
        Me.label5.Text = "Password"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(22, 109)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(80, 15)
        Me.label3.TabIndex = 48
        Me.label3.Text = "Nama Guru"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(22, 80)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(54, 15)
        Me.label2.TabIndex = 47
        Me.label2.Text = "Id Guru"
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(5, 4)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1044, 59)
        Me.panel1.TabIndex = 46
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(15, 24)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(119, 25)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Data Guru"
        '
        'bt_hapus
        '
        Me.bt_hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_hapus.Location = New System.Drawing.Point(173, 162)
        Me.bt_hapus.Name = "bt_hapus"
        Me.bt_hapus.Size = New System.Drawing.Size(132, 49)
        Me.bt_hapus.TabIndex = 56
        Me.bt_hapus.Text = "HAPUS"
        Me.bt_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_hapus.UseVisualStyleBackColor = True
        '
        'bt_tutup
        '
        Me.bt_tutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_tutup.Location = New System.Drawing.Point(311, 162)
        Me.bt_tutup.Name = "bt_tutup"
        Me.bt_tutup.Size = New System.Drawing.Size(132, 49)
        Me.bt_tutup.TabIndex = 55
        Me.bt_tutup.Text = "TUTUP"
        Me.bt_tutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_tutup.UseVisualStyleBackColor = True
        '
        'bt_tambah
        '
        Me.bt_tambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_tambah.Location = New System.Drawing.Point(34, 162)
        Me.bt_tambah.Name = "bt_tambah"
        Me.bt_tambah.Size = New System.Drawing.Size(132, 49)
        Me.bt_tambah.TabIndex = 54
        Me.bt_tambah.Text = "TAMBAH"
        Me.bt_tambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_tambah.UseVisualStyleBackColor = True
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(26, 227)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(994, 150)
        Me.dataGridView1.TabIndex = 53
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(145, 136)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(244, 20)
        Me.password.TabIndex = 52
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(38, 166)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(182, 166)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(315, 166)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 59
        Me.PictureBox3.TabStop = False
        '
        'Data_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1052, 380)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Nama_guru)
        Me.Controls.Add(Me.id_guru)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.bt_hapus)
        Me.Controls.Add(Me.bt_tutup)
        Me.Controls.Add(Me.bt_tambah)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.password)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Data_admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data_Guru"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Nama_guru As System.Windows.Forms.TextBox
    Private WithEvents id_guru As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents bt_hapus As System.Windows.Forms.Button
    Private WithEvents bt_tutup As System.Windows.Forms.Button
    Private WithEvents bt_tambah As System.Windows.Forms.Button
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
