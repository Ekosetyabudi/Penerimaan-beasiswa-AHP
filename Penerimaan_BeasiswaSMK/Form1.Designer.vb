<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Login))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.bt_batal = New System.Windows.Forms.Button()
        Me.bt_login = New System.Windows.Forms.Button()
        Me.password = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(-1, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(841, 67)
        Me.panel1.TabIndex = 3
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(3, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(457, 25)
        Me.label1.TabIndex = 0
        Me.label1.Text = "PENERIMAAN BEASISWA SMK Dr.Sutomo"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panel2.Controls.Add(Me.bt_batal)
        Me.panel2.Controls.Add(Me.bt_login)
        Me.panel2.Controls.Add(Me.password)
        Me.panel2.Controls.Add(Me.username)
        Me.panel2.Controls.Add(Me.label4)
        Me.panel2.Controls.Add(Me.label3)
        Me.panel2.Controls.Add(Me.label2)
        Me.panel2.Location = New System.Drawing.Point(559, 67)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(280, 301)
        Me.panel2.TabIndex = 4
        '
        'bt_batal
        '
        Me.bt_batal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_batal.Location = New System.Drawing.Point(151, 240)
        Me.bt_batal.Name = "bt_batal"
        Me.bt_batal.Size = New System.Drawing.Size(115, 30)
        Me.bt_batal.TabIndex = 6
        Me.bt_batal.Text = "Batal"
        Me.bt_batal.UseVisualStyleBackColor = True
        '
        'bt_login
        '
        Me.bt_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_login.Location = New System.Drawing.Point(32, 240)
        Me.bt_login.Name = "bt_login"
        Me.bt_login.Size = New System.Drawing.Size(115, 30)
        Me.bt_login.TabIndex = 5
        Me.bt_login.Text = "Login"
        Me.bt_login.UseVisualStyleBackColor = True
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(34, 184)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(211, 20)
        Me.password.TabIndex = 4
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(32, 133)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(211, 20)
        Me.username.TabIndex = 3
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(30, 161)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(86, 20)
        Me.label4.TabIndex = 2
        Me.label4.Text = "Password"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(30, 104)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(100, 20)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Nama Guru"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(101, 38)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(72, 24)
        Me.label2.TabIndex = 0
        Me.label2.Text = "LOGIN"
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(-1, 67)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(564, 301)
        Me.pictureBox1.TabIndex = 5
        Me.pictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2, 67)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(561, 298)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 368)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.pictureBox1)
        Me.Name = "Form_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Login"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents bt_batal As System.Windows.Forms.Button
    Private WithEvents bt_login As System.Windows.Forms.Button
    Private WithEvents password As System.Windows.Forms.TextBox
    Private WithEvents username As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
