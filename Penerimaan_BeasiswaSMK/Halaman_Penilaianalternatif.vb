Imports MySql.Data.MySqlClient
Public Class Halaman_Penilaianalternatif
    Dim c As New clsConn
    Dim namaAlternatif() As String
    Dim idAlternatif() As String

    Dim namaKriteria() As String
    Dim idKriteria() As String

    Dim namaSubKriteria() As String
    Dim idSubkriteria() As String

    Private Sub setHeader()
        DataGridView_PA.Columns.Add("NIS", "NIS")
        DataGridView_PA.Columns.Add("Nama", "Nama")
        'Load Kriteria
        For Each item As Object In namaKriteria
            DataGridView_PA.Columns.Add(item, item)
        Next

        For Each col As DataGridViewColumn In DataGridView_PA.Columns
            col.SortMode = DataGridViewColumnSortMode.Programmatic
        Next
    End Sub

    Private Sub loadRecord()
        'load data siswa 
        namaAlternatif = c.getList("tb_siswa", "nama_siswa", "NIS")
        idAlternatif = c.getList("tb_siswa", "NIS", "NIS")

        If namaAlternatif.Any = True Then
            DataGridView_PA.Rows.Add(namaAlternatif.Length)
            For i = 0 To namaAlternatif.Length - 1
                DataGridView_PA.Item(0, i).Value = idAlternatif(i)
                DataGridView_PA.Item(1, i).Value = namaAlternatif(i)
            Next
        End If

        Dim sqlcmd As MySqlCommand
        Dim sqlrd As MySqlDataReader
        Try
            c.myOpen()
            sqlcmd = New MySqlCommand("SELECT tb_nilai_alternatif.NIS, tb_nilai_alternatif.id_kriteria, tb_nilai_alternatif.id_subkriteria, tb_subkriteria.keterangan FROM tb_nilai_alternatif INNER JOIN tb_subkriteria ON tb_subkriteria.id_subkriteria = tb_nilai_alternatif.id_subkriteria", c.conn)
            sqlrd = sqlcmd.ExecuteReader
            If sqlrd.HasRows = True Then
                While sqlrd.Read = True
                    DataGridView_PA.Item(Array.IndexOf(idKriteria, sqlrd("id_kriteria").ToString) + 2, Array.IndexOf(idAlternatif, sqlrd("NIS").ToString)).Value = sqlrd("keterangan")
                End While
            Else
                MsgBox("Tidak ditemukan nilai", vbCritical + vbOKOnly, c.namaProgram)
            End If
        Catch ex As Exception
            MsgBox("[ERROR:PA01] " & ex.Message, vbCritical + vbOKOnly, c.namaProgram)
        Finally
            sqlrd.Close()
            c.myClose()
        End Try
    End Sub

    Private Sub bersihkan()
        For i = 0 To DataGridView_PA.Columns.Count - 1
            For j = 0 To DataGridView_PA.Rows.Count - 1
                DataGridView_PA.Item(i, j).Value = ""
            Next
        Next
    End Sub
    Private Sub Halaman_Penilaianalternatif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        namaAlternatif = c.getList("tb_siswa", "nama_siswa", "NIS")
        idAlternatif = c.getList("tb_siswa", "NIS", "NIS")

        If namaAlternatif.Any = False Then
            MsgBox("Siswa tidak ditemukan", vbOKOnly + vbInformation, c.namaProgram)
        Else
            namaKriteria = c.getList("tb_kriteria", "nama_kriteria", "urutan")
            idKriteria = c.getList("tb_kriteria", "id_kriteria", "urutan")

            If namaKriteria.Any = False Then
                MsgBox("Kriteria tidak ditemukan", vbOKOnly + vbInformation, c.namaProgram)
            Else
                Call setHeader()
                Call bersihkan()
                Call loadRecord()
            End If
        End If
    End Sub

    Private Sub bt_tutup_Click(sender As Object, e As EventArgs) Handles bt_tutup.Click
        If bt_tutup.Text = "TUTUP" Then
            Dim Halaman As New Halaman_Utama
            Halaman.Show()
            Me.Close()
        End If
    End Sub

    Private Sub bt_simpan_Click(sender As Object, e As EventArgs) Handles bt_simpan.Click
        Dim terisi As Boolean = True
        For i = 2 To DataGridView_PA.ColumnCount - 1
            For j = 0 To namaAlternatif.Length - 1
                If DataGridView_PA.Item(i, j).Value = "" Then
                    terisi = False
                End If
            Next
        Next

        If terisi = True Then
            Dim sqlcmd As MySqlCommand
            Dim sqlrd As MySqlDataReader

            c.myOpen()
            sqlcmd = New MySqlCommand("DELETE FROM tb_nilai_alternatif", c.conn)
            sqlcmd.ExecuteNonQuery()

            For i = 2 To DataGridView_PA.ColumnCount - 1
                For j = 0 To namaAlternatif.Length - 1
                    c.myOpen()
                    Dim fields() As String = {"NIS", "id_kriteria", "id_subkriteria"}
                    sqlcmd = New MySqlCommand("SELECT id_subkriteria FROM tb_subkriteria WHERE keterangan ='" & DataGridView_PA.Item(i, j).Value.ToString & "' AND id_kriteria ='" & idKriteria(Array.IndexOf(namaKriteria, DataGridView_PA.Columns(i).HeaderText.ToString)) & "'", c.conn)
                    sqlrd = sqlcmd.ExecuteReader
                    sqlrd.Read()
                    Dim datas() As String = {DataGridView_PA.Item(0, j).Value.ToString, idKriteria(Array.IndexOf(namaKriteria, DataGridView_PA.Columns(i).HeaderText.ToString)), sqlrd("id_subkriteria")}
                    sqlrd.Close()
                    c.myClose()
                    c.insertData("tb_nilai_alternatif", fields, datas)
                Next
            Next
            c.myOpen()
            MsgBox("Tersimpan", vbInformation + vbOKOnly, c.namaProgram)
        Else
            MsgBox("Mohon isi dengan benar", vbInformation + vbOKOnly, c.namaProgram)
        End If
    End Sub

    Private Sub DataGridView_PA_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView_PA.CellBeginEdit
        If e.ColumnIndex > 1 Then
            If e.RowIndex >= 0 Then
                If e.RowIndex < namaAlternatif.Length Then
                    Dim cmbsub As New DataGridViewComboBoxCell
                    Dim sqlcmd As MySqlCommand
                    Dim sqlrd As MySqlDataReader
                    Try
                        c.myOpen()
                        sqlcmd = New MySqlCommand("SELECT keterangan FROM tb_subkriteria WHERE id_kriteria ='" & idKriteria(Array.IndexOf(namaKriteria, DataGridView_PA.Columns(e.ColumnIndex).HeaderText.ToString)) & "'", c.conn)
                        sqlrd = sqlcmd.ExecuteReader
                        cmbsub.Items.Clear()
                        While sqlrd.Read = True
                            cmbsub.Items.Add(sqlrd("keterangan"))
                        End While
                        DataGridView_PA.Item(e.ColumnIndex, e.RowIndex) = cmbsub
                    Catch ex As Exception
                        MsgBox("[ERROR:PA02] " & ex.Message, vbCritical + vbOKOnly, c.namaProgram)
                    Finally
                        sqlrd.Close()
                        c.myClose()
                    End Try
                Else
                    e.Cancel = True
                End If
            Else
                e.Cancel = True
            End If
        Else
            e.Cancel = True
        End If
    End Sub
End Class