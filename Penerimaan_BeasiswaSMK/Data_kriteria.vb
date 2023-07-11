Public Class Data_kriteria
    Dim c As New clsConn
    Dim currID As Integer 'untuk menyimpan id sementara pada saat mode edit

    Private Sub bersihkan()
        no_urut.Value = 1
        Nama_kriteria.Text = ""
        Keterangan.Text = ""
    End Sub

    Private Sub modeEdit()

        bt_tambah.Text = "Simpan"
        bt_hapus.Visible = True
        PictureBox2.Visible = True
    End Sub

    Private Sub modeBaru()
        bt_tambah.Text = "Tambahkan"
        bt_hapus.Visible = False
        PictureBox2.Visible = False
        currID = 0
    End Sub
    Private Sub muatTable()
        c.loadTable("SELECT id_kriteria AS 'id_kriteria', urutan AS 'Nomer urut', nama_kriteria AS 'nama kriteria', keterangan AS 'keterangan' FROM tb_kriteria ORDER BY urutan ASC", c.conn)

        c.myOpen()
        If c.sqlDs.Tables.Count > 0 Then
            dataGridView1.DataSource = c.sqlDs.Tables(0)
        End If
        c.myClose()

        dataGridView1.Columns(0).Width = 30
        dataGridView1.Columns(1).Width = 100
        dataGridView1.Columns(2).Width = 120
        dataGridView1.Columns(3).Width = 200
    End Sub


    Private Sub Data_kriteria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call bersihkan()
        Call muatTable()
        Call modeBaru()

    End Sub

    Private Sub bt_tambah_Click(sender As Object, e As EventArgs) Handles bt_tambah.Click
        If Nama_kriteria.Text = "" Or Nama_kriteria.Text = Nothing Then
            MsgBox("Harap isi kolom Nama !", vbInformation + vbOKOnly, c.namaProgram)
            Exit Sub
        End If

        If no_urut.Value = Nothing Or no_urut.Value <= 0 Then
            MsgBox("Harap isi kolom nomer urutan dengan benar !", vbInformation + vbOKOnly, c.namaProgram)
            Exit Sub
        End If

        If Keterangan.Text = "" Or Keterangan.Text = Nothing Then
            Keterangan.Text = "-"
        End If

        Dim lstField() As String = {"nama_kriteria", "urutan", "keterangan"}
        Dim lstData() As String = {Nama_kriteria.Text, no_urut.Value, Keterangan.Text}

        If bt_tambah.Text = "Tambahkan" Then
            If c.insertData("tb_kriteria", lstField, lstData) = True Then
                MsgBox("Data Telah Ditambahkan", vbInformation + vbOKOnly, c.namaProgram)
                Call bersihkan()
                Call muatTable()
                Call modeBaru()
            End If
        Else
            If c.updateData("tb_kriteria", lstField, lstData, "id_kriteria", currID) = True Then
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
                If c.deleteData("tb_kriteria", "id_kriteria", currID) = True Then
                    If c.runSql("DELETE FROM tb_tb_subkriteria WHERE id_kriteria ='" & currID & "'", c.conn) = True Then
                        If c.runSql("DELETE FROM tb_pb WHERE tb_kriteria = '" & currID & "' OR rowindex ='" & currID & "' OR colindex ='" & currID & "'", c.conn) = True Then
                            If c.runSql("DELETE FROM tb_nilai_alternatif WHERE id_kriteria ='" & currID & "'", c.conn) = True Then
                                If c.runSql("DELETE FROM tb_hasil WHERE id_kriteria='all' AND id_subkriteria ='" & currID & "'", c.conn) = True Then
                                    MsgBox("Data Telah dihapus", vbInformation + vbOKOnly, c.namaProgram)
                                    Call bersihkan()
                                    Call muatTable()
                                    Call modeBaru()
                                End If
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
            currID = row.Cells("id_kriteria").Value.ToString
            Nama_kriteria.Text = row.Cells("Nama Kriteria").Value.ToString
            no_urut.Value = row.Cells("Nomer urut").Value.ToString
            Keterangan.Text = row.Cells("Keterangan").Value.ToString
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