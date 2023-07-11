<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Halaman_Penilaianalternatif
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Halaman_Penilaianalternatif))
        Me.DataGridView_PA = New System.Windows.Forms.DataGridView()
        Me.bt_simpan = New System.Windows.Forms.Button()
        Me.bt_tutup = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView_PA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_PA
        '
        Me.DataGridView_PA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_PA.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView_PA.Name = "DataGridView_PA"
        Me.DataGridView_PA.Size = New System.Drawing.Size(664, 376)
        Me.DataGridView_PA.TabIndex = 0
        '
        'bt_simpan
        '
        Me.bt_simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_simpan.Location = New System.Drawing.Point(705, 35)
        Me.bt_simpan.Name = "bt_simpan"
        Me.bt_simpan.Size = New System.Drawing.Size(123, 50)
        Me.bt_simpan.TabIndex = 1
        Me.bt_simpan.Text = "SIMPAN"
        Me.bt_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_simpan.UseVisualStyleBackColor = True
        '
        'bt_tutup
        '
        Me.bt_tutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_tutup.Location = New System.Drawing.Point(705, 91)
        Me.bt_tutup.Name = "bt_tutup"
        Me.bt_tutup.Size = New System.Drawing.Size(123, 50)
        Me.bt_tutup.TabIndex = 2
        Me.bt_tutup.Text = "TUTUP"
        Me.bt_tutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_tutup.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(711, 96)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 62
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(711, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'Halaman_Penilaianalternatif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(840, 400)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bt_tutup)
        Me.Controls.Add(Me.bt_simpan)
        Me.Controls.Add(Me.DataGridView_PA)
        Me.Name = "Halaman_Penilaianalternatif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Halaman_Penilaianalternatif"
        CType(Me.DataGridView_PA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView_PA As System.Windows.Forms.DataGridView
    Friend WithEvents bt_simpan As System.Windows.Forms.Button
    Friend WithEvents bt_tutup As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
