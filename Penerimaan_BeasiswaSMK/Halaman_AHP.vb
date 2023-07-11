Imports MySql.Data.MySqlClient
Public Class Halaman_AHP
    Dim c As New clsConn

    Private Sub setHeader()
        'membuat colom
        Dim sqlcmd As MySqlCommand
        Dim sqlrd As MySqlDataReader
        Try
            c.myOpen()
            sqlcmd = New MySqlCommand("SELECT id_kriteria, nama_kriteria FROM tb_kriteria ORDER BY urutan ASC", c.conn)
            sqlrd = sqlcmd.ExecuteReader

            If sqlrd.HasRows = True Then
                While sqlrd.Read = True
                    dataGridViewAHP.Columns.Add(sqlrd("id_kriteria"), sqlrd("nama_kriteria"))
                End While
            End If

            dataGridViewAHP.Columns.Add("Total", "Total")
        Catch ex As Exception
            MsgBox("[ERROR:FAHP1] " & ex.Message, vbCritical + vbOKOnly, c.namaProgram)
        Finally
            c.myClose()
        End Try
        'Membuat row
        Try
            c.myOpen()
            sqlcmd = New MySqlCommand("SELECT nama_siswa FROM tb_siswa ORDER BY NIS ASC", c.conn)
            sqlrd = sqlcmd.ExecuteReader

            If sqlrd.HasRows = True Then
                Dim myi As Integer = 0
                While sqlrd.Read = True
                    dataGridViewAHP.Rows.Add(1)
                    dataGridViewAHP.Rows(myi).HeaderCell.Value = sqlrd("nama_siswa")
                    myi += 1
                End While
            End If
        Catch ex As Exception
            MsgBox("[ERROR:FAHP2] " & ex.Message, vbCritical + vbOKOnly, c.namaProgram)
        Finally
            c.myClose()
        End Try
    End Sub

    Private Sub setAHPCells()
        Dim sqlcmd As MySqlCommand
        Dim sqlrd As MySqlDataReader

        Try
            For i = 0 To dataGridViewAHP.RowCount - 2
                For j = 0 To dataGridViewAHP.Columns.Count - 2
                    Dim idAlternatif As Double
                    Dim idKriteria As Double
                    Dim idSubKriteria As Double

                    Dim nilaiKriteria As Double
                    'Dim nilaiSubKriteria As Double

                    c.myOpen()
                    'mencari nilai dari kriteria
                    sqlcmd = New MySqlCommand("SELECT tb_hasil.hasil FROM tb_hasil INNER JOIN tb_kriteria ON tb_hasil.id_subkriteria = tb_kriteria.id_kriteria WHERE tb_hasil.id_kriteria = 'all' AND tb_kriteria.nama_kriteria = '" & dataGridViewAHP.Columns(j).HeaderText & "'", c.conn)
                    sqlrd = sqlcmd.ExecuteReader
                    If sqlrd.HasRows = True Then
                        While sqlrd.Read = True
                            nilaiKriteria = sqlrd("hasil")
                        End While
                        sqlrd.Close()

                        'mencari id kriteria dan id subkriteria
                        c.myOpen()
                        sqlcmd = New MySqlCommand("SELECT tb_kriteria.id_kriteria, tb_siswa.NIS FROM tb_kriteria, tb_siswa WHERE tb_kriteria.nama_kriteria = '" & dataGridViewAHP.Columns(j).HeaderText & "' AND tb_siswa.nama_siswa = '" & dataGridViewAHP.Rows(i).HeaderCell.Value & "'", c.conn)
                        sqlrd = sqlcmd.ExecuteReader
                        If sqlrd.HasRows = True Then
                            While sqlrd.Read = True
                                idKriteria = sqlrd("id_kriteria")
                                idAlternatif = sqlrd("NIS")
                            End While
                            sqlrd.Close()

                            'mencari id_subkriteria pada nilai alternatif
                            c.myOpen()
                            sqlcmd = New MySqlCommand("SELECT id_subkriteria FROM tb_nilai_alternatif WHERE id_kriteria ='" & idKriteria & "' AND NIS = '" & idAlternatif & "'", c.conn)
                            sqlrd = sqlcmd.ExecuteReader
                            If sqlrd.HasRows = True Then
                                While sqlrd.Read = True
                                    idSubKriteria = sqlrd("id_subkriteria")
                                End While
                                sqlrd.Close()

                                'mendapatkan nilai dari subkriteria
                                c.myOpen()
                                sqlcmd = New MySqlCommand("SELECT hasil FROM tb_hasil WHERE id_kriteria = '" & idKriteria & "' AND id_subkriteria = '" & idSubKriteria & "'", c.conn)
                                sqlrd = sqlcmd.ExecuteReader
                                If sqlrd.HasRows = True Then
                                    While sqlrd.Read = True
                                        'rumus ahp
                                        dataGridViewAHP.Item(j, i).Value = Format(Math.Round(Val(sqlrd("hasil")) * Val(nilaiKriteria), 3), "0.000")
                                    End While
                                Else
                                    MsgBox("Nilai dari subkriteria tidak ditemukan", vbInformation + vbOKOnly, c.namaProgram)
                                End If
                                sqlrd.Close()
                                c.myClose()
                            Else
                                MsgBox("Penilaian Alternatif " & dataGridViewAHP.Rows(i).HeaderCell.Value & " tidak ditemukan", vbInformation + vbOKOnly, c.namaProgram)
                            End If
                            sqlrd.Close()
                            c.myClose()
                        Else
                            MsgBox("kriteria atau siswa tidak ditemukan", vbInformation + vbOKOnly, c.namaProgram)
                        End If
                        sqlrd.Close()
                        c.myClose()
                    Else
                        MsgBox("Nilai dari kriteria " & dataGridViewAHP.Columns(j).HeaderText & "tidak ditemukan", vbInformation + vbOKOnly, c.namaProgram)
                    End If
                    sqlrd.Close()
                    c.myClose()
                Next
            Next
        Catch ex As Exception
            MsgBox("[ERROR:LOAD1] " & ex.Message, vbInformation + vbOKOnly, c.namaProgram)
        Finally
            sqlrd.Close()
            c.myClose()
        End Try

        'Hitung total
        For i = 0 To dataGridViewAHP.RowCount - 2
            Dim jumlah As Double = 0
            For j = 0 To dataGridViewAHP.ColumnCount - 2
                jumlah += Val(dataGridViewAHP.Item(j, i).Value)
            Next
            dataGridViewAHP.Item(dataGridViewAHP.ColumnCount - 1, i).Value = jumlah
        Next
    End Sub

    Private Sub bersihkan()
        For i = 0 To dataGridViewAHP.RowCount - 2
            For j = 0 To dataGridViewAHP.ColumnCount - 1
                dataGridViewAHP.Item(j, i).Value = 0
            Next
        Next
    End Sub

    Private Sub simpan()
        c.runSql("DELETE FROM tb_ahp", c.conn)

        For i = 0 To dataGridViewAHP.RowCount - 2
            If Not dataGridViewAHP.Rows(i).HeaderCell.Value = "" Then
                Dim sqlcmd As MySqlCommand
                Dim sqlrd As MySqlDataReader

                Try
                    c.myOpen()
                    sqlcmd = New MySqlCommand("SELECT NIS FROm tb_siswa WHERE nama_siswa ='" & dataGridViewAHP.Rows(i).HeaderCell.Value & "'", c.conn)
                    sqlrd = sqlcmd.ExecuteReader
                    Dim idAlter As String
                    While sqlrd.Read = True
                        idAlter = sqlrd("NIS").ToString
                    End While
                    sqlrd.Close()
                    c.myClose()
                    Dim fields() As String = {"NIS", "ahp"}
                    Dim datas() As String = {idAlter, dataGridViewAHP.Item(dataGridViewAHP.ColumnCount - 1, i).Value.ToString}
                    c.insertData("tb_ahp", fields, datas)
                Catch ex As Exception
                    MsgBox("[ERROR:LOAD2] " & ex.Message, vbInformation + vbOKOnly, c.namaProgram)
                Finally
                    c.myClose()
                End Try
            End If
        Next
    End Sub

    Private Sub loadRanking()
        dataGridViewHasil.Columns.Add("Nama_siswa", "Nama_siswa")
        dataGridViewHasil.Columns.Add("Nilai AHP", "Nilai AHP")

        Dim sqlcmd As MySqlCommand
        Dim sqlrd As MySqlDataReader
        Try
            c.myOpen()
            sqlcmd = New MySqlCommand("SELECT tb_siswa.nama_siswa, tb_ahp.ahp FROM tb_ahp INNER JOIN tb_siswa ON tb_siswa.NIS = tb_ahp.NIS ORDER BY tb_ahp.ahp DESC", c.conn)
            sqlrd = sqlcmd.ExecuteReader

            If sqlrd.HasRows = True Then
                Dim i As Integer = 0
                While sqlrd.Read = True
                    dataGridViewHasil.Rows.Add(1)
                    dataGridViewHasil.Rows(i).HeaderCell.Value = (i + 1).ToString
                    dataGridViewHasil.Item(0, i).Value = sqlrd("nama_siswa")
                    dataGridViewHasil.Item(1, i).Value = sqlrd("ahp")
                    i += 1
                End While
            End If
            sqlrd.Close()
            c.myClose()
        Catch ex As Exception
            MsgBox("[ERROR:LOAD3] " & ex.Message, vbInformation + vbOKOnly, c.namaProgram)
        End Try
    End Sub
    Private Sub bt_simpan_Click(sender As Object, e As EventArgs) Handles bt_simpan.Click
        Call simpan()
        MsgBox("Tersimpan", vbInformation + vbOKOnly, c.namaProgram)
    End Sub

    Private Sub Halaman_AHP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setHeader()
        bersihkan()
        setAHPCells()
        simpan()
        loadRanking()
    End Sub

    Private Sub bt_tutup_Click(sender As Object, e As EventArgs) Handles bt_tutup.Click
        If bt_tutup.Text = "TUTUP" Then
            Dim Halaman As New Halaman_Utama
            Halaman.Show()
            Me.Close()
        Else
            Call bersihkan()
        End If
    End Sub

    Private Sub dataGridViewAHP_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dataGridViewAHP.CellBeginEdit
        e.Cancel = True
    End Sub

    Private Sub dataGridViewHasil_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dataGridViewHasil.CellBeginEdit
        e.Cancel = True
    End Sub

    Private Sub bt_cetak_Click(sender As Object, e As EventArgs) Handles bt_cetak.Click
        Dim Halaman As New Laporan_Rekomendasi
        Halaman.Show()
        Me.Hide()
    End Sub
End Class