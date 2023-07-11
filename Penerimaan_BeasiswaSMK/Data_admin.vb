Public Class Data_admin
    Dim c As New clsConn
    Dim currID As Integer 'untuk menyimpan id sementara pada saat mode edit

    Private Sub bersihkan()
        id_guru.Text = ""
        Nama_guru.Text = ""
        password.Text = ""
    End Sub

    Private Sub modeEdit()

        bt_tambah.Text = "Simpan"
        bt_hapus.Visible = True
        PictureBox2.Visible = True


    End Sub

    Private Sub modeBaru()
        bt_tambah.Text = "TAMBAHKAN"
        bt_hapus.Visible = False
        PictureBox2.Visible = False

        currID = 0
    End Sub
    Private Sub muatTable()
        c.loadTable("SELECT id_guru AS 'id_guru', nama_guru AS 'nama_guru', password AS 'password' FROM tb_guru ORDER BY id_guru ASC", c.conn)

        c.myOpen()
        If c.sqlDs.Tables.Count > 0 Then
            dataGridView1.DataSource = c.sqlDs.Tables(0)
        End If
        c.myClose()

        dataGridView1.Columns(0).Width = 30
        dataGridView1.Columns(1).Width = 100
        dataGridView1.Columns(2).Width = 120

    End Sub
    Private Sub Data_kriteria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call bersihkan()
        Call muatTable()
        Call modeBaru()

    End Sub

    Private Sub bt_tambah_Click(sender As Object, e As EventArgs) Handles bt_tambah.Click
        If Nama_guru.Text = "" Or Nama_guru.Text = Nothing Then
            MsgBox("Harap isi kolom Nama !", vbInformation + vbOKOnly, c.namaProgram)
            Exit Sub
        End If

        If id_guru.Text = Nothing Or id_guru.Text <= 0 Then
            MsgBox("Harap isi kolom nomer urutan dengan benar !", vbInformation + vbOKOnly, c.namaProgram)
            Exit Sub
        End If

        If password.Text = "" Or password.Text = Nothing Then
            password.Text = "-"
        End If

        Dim lstField() As String = {"nama_guru", "id_guru", "password"}
        Dim lstData() As String = {Nama_guru.Text, id_guru.Text, password.Text}

        If bt_tambah.Text = "TAMBAHKAN" Then
            If c.insertData("tb_guru", lstField, lstData) = True Then
                MsgBox("Data Telah Ditambahkan", vbInformation + vbOKOnly, c.namaProgram)
                Call bersihkan()
                Call muatTable()
                Call modeBaru()
            End If
        Else
            If c.updateData("tb_guru", lstField, lstData, "id_guru", currID) = True Then
                MsgBox("Tersimpan", vbInformation + vbOKOnly, c.namaProgram)
                Call bersihkan()
                Call muatTable()
                Call modeBaru()
            End If
        End If


    End Sub

    Private Sub bt_hapus_Click(sender As Object, e As EventArgs) Handles bt_hapus.Click
        If currID > 0 Then
            If MsgBox("Apakah anda yakin untuk menghapus rekaman dengan ID = " & currID, vbCritical + vbYesNo, c.namaProgram) = vbYes Then
                If c.deleteData("tb_guru", "id_guru", currID) = True Then
                    If c.runSql("DELETE FROM tb_guru WHERE id_guru ='" & currID & "'", c.conn) = True Then
                        MsgBox("Data Telah dihapus", vbInformation + vbOKOnly, c.namaProgram)
                        Call bersihkan()
                        Call muatTable()
                        Call modeBaru()
                    End If
                End If
            End If
        End If


    End Sub

    Private Sub dataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dataGridView1.Rows(e.RowIndex)
            currID = row.Cells("id_guru").Value.ToString
            id_guru.Text = row.Cells("id_guru").Value.ToString
            Nama_guru.Text = row.Cells("nama_guru").Value.ToString
            password.Text = row.Cells("Password").Value.ToString

            Call modeEdit()
        End If
    End Sub

    Private Sub bt_tutup_Click(sender As Object, e As EventArgs) Handles bt_tutup.Click
        If bt_tutup.Text = "TUTUP" Then
            Dim Halaman As New Halaman_Utama
            Halaman.Show()
            Me.Close()
        Else
            Call bersihkan()
            Call modeBaru()
        End If
    End Sub
End Class