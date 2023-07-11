Public Class Data_siswa
    Dim currID As Integer ' akan menyimpan nis dari siswa  untuk sementara di saat mode edit
    Dim c As New clsConn
    Dim sqlcmd As MySqlCommand
    Dim sqlrd As MySqlDataReader
    Private Sub bersihkan()
        nama.Text = ""
        nis.Text = ""

    End Sub

    Private Sub modeEdit()
        bt_tambah.Text = "SIMPAN"
        bt_tutup.Text = "BATAL"
        bt_hapus.Visible = True
        PictureBox2.Visible = True
    End Sub

    Private Sub modeBaru()
        bt_tambah.Text = "TAMBAHKAN"
        bt_tutup.Text = "TUTUP"
        bt_hapus.Visible = False
        PictureBox2.Visible = False
        currID = 0
    End Sub

    Private Sub muatTable()
        c.loadTable("SELECT NIS AS 'NIS', nama_siswa AS 'Nama' FROM tb_siswa ORDER BY NIS ASC", c.conn)

        If c.sqlDs.Tables.Count > 0 Then
            dataGridView1.DataSource = c.sqlDs.Tables(0)
        Else
            MsgBox("Data tidak ditemukan !", vbInformation + vbOKOnly, c.namaProgram)
        End If
    End Sub
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles bt_tambah.Click
        If nis.Text = "" Or nis.Text = Nothing Then
            MsgBox("Harap isi kolom Nama !", vbInformation + vbOKOnly, c.namaProgram)
            Exit Sub
        End If




        Dim fields() As String = {"NIS", "nama_siswa"}
        Dim datas() As String = {nis.Text, nama.Text}

        If bt_tambah.Text = "SIMPAN" Then
            If c.updateData("tb_siswa", fields, datas, "NIS", currID) = True Then
                MsgBox("Tersimpan", vbInformation + vbOKOnly, c.namaProgram)
                Call bersihkan()
                Call modeBaru()
                Call muatTable()
            End If
        Else
            If c.insertData("tb_siswa", fields, datas) = True Then
                MsgBox("data telah ditambah", vbInformation + vbOKOnly, c.namaProgram)
                Call bersihkan()
                Call modeBaru()
                Call muatTable()
            End If
        End If
    End Sub

    Private Sub Halaman_Alternatif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call bersihkan()
        Call modeBaru()
        Call muatTable()
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

    Private Sub bt_hapus_Click(sender As Object, e As EventArgs) Handles bt_hapus.Click
        If currID > 0 Then
            If MsgBox("Anda yakin untuk menghapus data dengan NIS = " & currID, vbCritical + vbYesNo, c.namaProgram) = vbYes Then
                If c.deleteData("tb_siswa", "NIS", currID) = True Then
                    If c.runSql("DELETE FROM tb_siswa WHERE NIS ='" & currID & "'", c.conn) = True Then
                        If c.runSql("DELETE FROM tb_nilai_alternatif WHERE NIS ='" & currID & "'", c.conn) = True Then
                            If c.runSql("DELETE FROM tb_ahp WHERE NIS ='" & currID & "'", c.conn) = True Then
                                MsgBox("Data terhapus", vbInformation + vbOKOnly, c.namaProgram)
                                Call bersihkan()
                                Call modeBaru()
                                Call muatTable()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dataGridView1.Rows(e.RowIndex)

            currID = row.Cells("NIS").Value.ToString
            nis.Text = row.Cells("NIS").Value.ToString
            nama.Text = row.Cells("nama").Value.ToString

            Call modeEdit()
        End If
    End Sub

    Private Sub nis_TextChanged(sender As Object, e As EventArgs) Handles nama.TextChanged


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class