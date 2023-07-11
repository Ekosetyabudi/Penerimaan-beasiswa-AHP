Public Class Data_subkriteria
    Dim c As New clsConn
    Dim myIDkriteria() As String

    Dim currID As Integer

    Private Sub bersihkan()
        cb_pilihkriteria.Text = "-- Pilih --"
        noUrutan.Value = 1
        Nama_sub.Text = ""
        Keterangan.Text = ""
    End Sub

    Private Sub modeEdit()
        bt_tambah.Text = "Simpan"
        bt_hapus.Text = "Hapus"
        bt_tutup.Visible = True
        PictureBox2.Visible = True
    End Sub

    Private Sub modeBaru()
        bt_tambah.Text = "Tambahkan"
        bt_tutup.Text = "TUTUP"
        bt_hapus.Visible = False
        PictureBox2.Visible = False
        currID = 0
    End Sub
    Private Sub loadCMB()
        Dim lstKriteria() As String = c.getList("tb_kriteria", "nama_kriteria", "urutan")
        cb_kriteria.Items.Clear()
        cb_pilihkriteria.Items.Clear()
        cb_kriteria.Items.Clear()
        cb_kriteria.Items.Add("All")
        For Each item As Object In lstKriteria
            cb_kriteria.Items.Add(item)
            cb_pilihkriteria.Items.Add(item)
        Next
        cb_kriteria.Text = "All"

        'get id
        myIDkriteria = c.getList("tb_kriteria", "id_kriteria", "urutan")
    End Sub
    Private Sub muatTable()
        If cb_kriteria.Text = "All" Then
            c.loadTable("SELECT tb_subkriteria.id_subkriteria AS 'id', tb_kriteria.nama_kriteria AS 'Kriteria', tb_subkriteria.urutan AS 'Nomer urut', tb_subkriteria.nama_subkriteria AS 'Nama Sub Kriteria', tb_subkriteria.keterangan AS 'Keterangan' FROM tb_subkriteria INNER JOIN tb_kriteria ON tb_kriteria.id_kriteria = tb_subkriteria.id_kriteria ORDER BY tb_kriteria.nama_kriteria ASC", c.conn)
        Else
            c.loadTable("SELECT tb_subkriteria.id_subkriteria AS 'id', tb_kriteria.nama_kriteria AS 'Kriteria', tb_subkriteria.urutan AS 'Nomer urut', tb_subkriteria.nama_subkriteria AS 'Nama Sub Kriteria', tb_subkriteria.keterangan AS 'Keterangan' FROM tb_subkriteria INNER JOIN tb_kriteria on tb_kriteria.id_kriteria = tb_subkriteria.id_kriteria AND tb_kriteria.nama_kriteria = '" & cb_kriteria.Text & "' ORDER BY tb_subkriteria.urutan", c.conn)
        End If

        If c.sqlDs.Tables.Count > 0 Then
            dataGridView1.DataSource = c.sqlDs.Tables(0)
        Else
            MsgBox("Data Kosong !", vbInformation + vbOKOnly, "SPK - Beasiswa")
        End If
    End Sub
    Private Sub Data_subkriteria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call bersihkan()
        Call loadCMB()
        Call muatTable()
        Call modeBaru()
    End Sub

    Private Sub bt_tambah_Click(sender As Object, e As EventArgs) Handles bt_tambah.Click
        If cb_pilihkriteria.Text = "-- Pilih --" Or cb_pilihkriteria.Text = "" Then
            MsgBox("Harap pilih kriteria !", vbInformation + vbOKOnly, c.namaProgram)
            Exit Sub
        End If

        If Nama_sub.Text = "" Or Nama_sub.Text = Nothing Then
            MsgBox("Harap isi kolom Nama !", vbInformation + vbOKOnly, c.namaProgram)
            Exit Sub
        End If

        If noUrutan.Value = Nothing Or noUrutan.Value <= 0 Then
            MsgBox("Harap isi kolom nomer urutan dengan benar !", vbInformation + vbOKOnly, c.namaProgram)
            Exit Sub
        End If

        If Keterangan.Text = "" Or Keterangan.Text = Nothing Then
            Keterangan.Text = "-"
        End If

        Dim fields() As String = {"id_kriteria", "nama_subkriteria", "urutan", "keterangan"}
        Dim datas() As String = {myIDkriteria(cb_pilihkriteria.SelectedIndex), Nama_sub.Text, noUrutan.Value, Keterangan.Text}

        If bt_tambah.Text = "Simpan" Then
            If c.updateData("tb_subkriteria", fields, datas, "id_subkriteria", currID) = True Then
                MsgBox("Data Telah Tersimpan", vbInformation + vbOKOnly, c.namaProgram)
                Call modeBaru()
                Call bersihkan()
                Call muatTable()
            End If
        Else
            If c.insertData("tb_subkriteria", fields, datas) = True Then
                MsgBox("Data Telah Ditambahkan", vbInformation + vbOKOnly, c.namaProgram)
                Call modeBaru()
                Call bersihkan()
                Call muatTable()
            End If
        End If
    End Sub

    Private Sub cb_kriteria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_kriteria.SelectedIndexChanged
        Call muatTable()
    End Sub

    Private Sub dataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dataGridView1.Rows(e.RowIndex)
            currID = row.Cells("id").Value.ToString
            cb_pilihkriteria.Text = row.Cells("Kriteria").Value.ToString
            noUrutan.Value = row.Cells("Nomer urut").Value.ToString
            Nama_sub.Text = row.Cells("Nama Sub Kriteria").Value.ToString
            Keterangan.Text = row.Cells("Keterangan").Value.ToString
            Call modeEdit()
        End If
    End Sub

    Private Sub bt_hapus_Click(sender As Object, e As EventArgs) Handles bt_hapus.Click
        If currID > 0 Then
            If MsgBox("Apakah anda yakin untuk menghapus data dengan ID = " & currID, vbCritical + vbYesNo, c.namaProgram) = vbYes Then
                If c.deleteData("tb_subkriteria", "id_subkriteria", currID) Then
                    'hapus semua relasi
                    If c.runSql("DELETE FROM tb_pb WHERE tb_kriteria ='" & myIDkriteria(cb_pilihkriteria.SelectedIndex) & "' AND (rowindex ='" & currID & "' OR colindex = '" & currID & "')", c.conn) = True Then
                        If c.runSql("DELETE FROM tb_nilai_alternatif WHERE id_kriteria = '" & myIDkriteria(cb_pilihkriteria.SelectedIndex) & "' AND id_subkriteria ='" & currID & "'", c.conn) = True Then
                            If c.runSql("DELETE FROM tb_hasil WHERE id_kriteria ='" & myIDkriteria(cb_pilihkriteria.SelectedIndex) & "' AND id_subkriteria ='" & currID & "'", c.conn) Then
                                MsgBox("Data Terhapus", vbInformation + vbOKOnly, c.namaProgram)
                                Call modeBaru()
                                Call bersihkan()
                                Call muatTable()
                            End If
                        End If
                    End If
                End If
            End If
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