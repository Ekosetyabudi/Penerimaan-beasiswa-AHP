<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Halaman_AHP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Halaman_AHP))
        Me.groupAHP = New System.Windows.Forms.GroupBox()
        Me.dataGridViewAHP = New System.Windows.Forms.DataGridView()
        Me.groupBoxHAsil = New System.Windows.Forms.GroupBox()
        Me.dataGridViewHasil = New System.Windows.Forms.DataGridView()
        Me.bt_tutup = New System.Windows.Forms.Button()
        Me.bt_simpan = New System.Windows.Forms.Button()
        Me.bt_cetak = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupAHP.SuspendLayout()
        CType(Me.dataGridViewAHP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxHAsil.SuspendLayout()
        CType(Me.dataGridViewHasil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupAHP
        '
        Me.groupAHP.Controls.Add(Me.dataGridViewAHP)
        Me.groupAHP.Location = New System.Drawing.Point(4, 8)
        Me.groupAHP.Name = "groupAHP"
        Me.groupAHP.Size = New System.Drawing.Size(590, 454)
        Me.groupAHP.TabIndex = 4
        Me.groupAHP.TabStop = False
        Me.groupAHP.Text = "AHP"
        '
        'dataGridViewAHP
        '
        Me.dataGridViewAHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewAHP.Location = New System.Drawing.Point(0, 19)
        Me.dataGridViewAHP.Name = "dataGridViewAHP"
        Me.dataGridViewAHP.Size = New System.Drawing.Size(584, 429)
        Me.dataGridViewAHP.TabIndex = 0
        '
        'groupBoxHAsil
        '
        Me.groupBoxHAsil.Controls.Add(Me.dataGridViewHasil)
        Me.groupBoxHAsil.Location = New System.Drawing.Point(599, 8)
        Me.groupBoxHAsil.Name = "groupBoxHAsil"
        Me.groupBoxHAsil.Size = New System.Drawing.Size(343, 362)
        Me.groupBoxHAsil.TabIndex = 5
        Me.groupBoxHAsil.TabStop = False
        Me.groupBoxHAsil.Text = "Rangking"
        '
        'dataGridViewHasil
        '
        Me.dataGridViewHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewHasil.Location = New System.Drawing.Point(1, 19)
        Me.dataGridViewHasil.Name = "dataGridViewHasil"
        Me.dataGridViewHasil.Size = New System.Drawing.Size(336, 337)
        Me.dataGridViewHasil.TabIndex = 0
        '
        'bt_tutup
        '
        Me.bt_tutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_tutup.Location = New System.Drawing.Point(811, 392)
        Me.bt_tutup.Name = "bt_tutup"
        Me.bt_tutup.Size = New System.Drawing.Size(100, 52)
        Me.bt_tutup.TabIndex = 7
        Me.bt_tutup.Text = "TUTUP"
        Me.bt_tutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_tutup.UseVisualStyleBackColor = True
        '
        'bt_simpan
        '
        Me.bt_simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_simpan.Location = New System.Drawing.Point(600, 392)
        Me.bt_simpan.Name = "bt_simpan"
        Me.bt_simpan.Size = New System.Drawing.Size(100, 52)
        Me.bt_simpan.TabIndex = 6
        Me.bt_simpan.Text = "SIMPAN"
        Me.bt_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_simpan.UseVisualStyleBackColor = True
        '
        'bt_cetak
        '
        Me.bt_cetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cetak.Location = New System.Drawing.Point(705, 392)
        Me.bt_cetak.Name = "bt_cetak"
        Me.bt_cetak.Size = New System.Drawing.Size(100, 52)
        Me.bt_cetak.TabIndex = 8
        Me.bt_cetak.Text = "CETAK"
        Me.bt_cetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cetak.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(820, 398)
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
        Me.PictureBox2.Location = New System.Drawing.Point(714, 397)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 61
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(604, 398)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'Halaman_AHP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(954, 471)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.groupAHP)
        Me.Controls.Add(Me.bt_cetak)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.groupBoxHAsil)
        Me.Controls.Add(Me.bt_tutup)
        Me.Controls.Add(Me.bt_simpan)
        Me.Name = "Halaman_AHP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Halaman_AHP"
        Me.groupAHP.ResumeLayout(False)
        CType(Me.dataGridViewAHP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxHAsil.ResumeLayout(False)
        CType(Me.dataGridViewHasil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupAHP As System.Windows.Forms.GroupBox
    Private WithEvents dataGridViewAHP As System.Windows.Forms.DataGridView
    Private WithEvents groupBoxHAsil As System.Windows.Forms.GroupBox
    Private WithEvents dataGridViewHasil As System.Windows.Forms.DataGridView
    Private WithEvents bt_tutup As System.Windows.Forms.Button
    Private WithEvents bt_simpan As System.Windows.Forms.Button
    Private WithEvents bt_cetak As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
