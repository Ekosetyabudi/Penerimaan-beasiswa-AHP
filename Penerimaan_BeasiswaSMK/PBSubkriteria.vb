Imports MySql.Data.MySqlClient

Public Class PBSubkriteria
    Dim c As New clsConn
    Dim namaKriteria() As String
    Dim idKriteria() As String

    Dim namaSubKriteria() As String
    Dim idSubKriteria() As String

    Dim jlhBulat As Integer = 3

    Private Sub kosongkan()
        Call dataGridViewPB.Rows.Clear()
        Call dataGridViewPB.Columns.Clear()

        Call dataGridViewPrioritas.Rows.Clear()
        Call dataGridViewPrioritas.Columns.Clear()

        Call dataGridViewPenjumlahan.Rows.Clear()
        Call dataGridViewPenjumlahan.Columns.Clear()

        Call dataGridViewRasio.Rows.Clear()
        Call dataGridViewRasio.Columns.Clear()

        Call dataGridViewHasil.Rows.Clear()
        Call dataGridViewHasil.Columns.Clear()
    End Sub
    Private Sub loadData()
        Call kosongkan()
        If cb_kriteria.Text = "--Pilih--" Then
            Call kosongkan()
        Else
            namaSubKriteria = c.getList("tb_subkriteria", "nama_subkriteria", "id_kriteria", idKriteria(Array.IndexOf(namaKriteria, cb_kriteria.Text.ToString)), "urutan")
            idSubKriteria = c.getList("tb_subkriteria", "id_subkriteria", "id_kriteria", idKriteria(Array.IndexOf(namaKriteria, cb_kriteria.Text.ToString)), "urutan")

            If namaSubKriteria.Any = False Then
                Call kosongkan()
            Else
                Call setheader()
                Call bersihkan()
                Call setColorForEditAbleCell()
                Call loadRecord()
                Call proses()
            End If
        End If
    End Sub
    Private Sub setheader()
        dataGridViewPB.Columns.Clear()
        For Each item As Object In namaSubKriteria
            dataGridViewPB.Columns.Add(item, item)
            dataGridViewPrioritas.Columns.Add(item, item)
            dataGridViewPenjumlahan.Columns.Add(item, item)
        Next
        dataGridViewPB.Rows.Add(namaSubKriteria.Length)
        dataGridViewPrioritas.Rows.Add(namaSubKriteria.Length)
        dataGridViewPenjumlahan.Rows.Add(namaSubKriteria.Length)

        dataGridViewRasio.Columns.Add("", "Jumlah per baris")
        dataGridViewRasio.Columns.Add("", "Prioritas")
        dataGridViewRasio.Columns.Add("", "Hasil")

        dataGridViewRasio.Rows.Add(namaSubKriteria.Length)
        For i As Integer = 0 To (namaSubKriteria.Length - 1)
            dataGridViewPB.Rows(i).HeaderCell.Value = namaSubKriteria(i)
            dataGridViewPrioritas.Rows(i).HeaderCell.Value = namaSubKriteria(i)
            dataGridViewPenjumlahan.Rows(i).HeaderCell.Value = namaSubKriteria(i)
            dataGridViewRasio.Rows(i).HeaderCell.Value = namaSubKriteria(i)
        Next

        For Each col As DataGridViewColumn In dataGridViewPB.Columns
            col.SortMode = DataGridViewColumnSortMode.Programmatic
        Next
        For Each col As DataGridViewColumn In dataGridViewPrioritas.Columns
            col.SortMode = DataGridViewColumnSortMode.Programmatic
        Next
        For Each col As DataGridViewColumn In dataGridViewPenjumlahan.Columns
            col.SortMode = DataGridViewColumnSortMode.Programmatic
        Next
        For Each col As DataGridViewColumn In dataGridViewRasio.Columns
            col.SortMode = DataGridViewColumnSortMode.Programmatic
        Next
        For Each col As DataGridViewColumn In dataGridViewHasil.Columns
            col.SortMode = DataGridViewColumnSortMode.Programmatic
        Next

        dataGridViewPB.Rows(namaSubKriteria.Length).HeaderCell.Value = "Jumlah"
        dataGridViewPrioritas.Rows(namaSubKriteria.Length).HeaderCell.Value = "Jumlah"
        dataGridViewPenjumlahan.Columns.Add("", "Jumlah")
        dataGridViewRasio.Rows(namaSubKriteria.Length).HeaderCell.Value = "Jumlah"

        dataGridViewPrioritas.Columns.Add("", "Jumlah per baris")
        dataGridViewPrioritas.Columns.Add("", "Prioritas")
        dataGridViewPrioritas.Columns.Add("", "Prioritas Subkriteria")

        dataGridViewHasil.Columns.Add("", "Hasil")
        dataGridViewHasil.Rows.Add(4)
        dataGridViewHasil.Rows(0).HeaderCell.Value = "λ maks"
        dataGridViewHasil.Rows(1).HeaderCell.Value = "Index Konsistensi"
        dataGridViewHasil.Rows(2).HeaderCell.Value = "Rasio Konsistensi"
        dataGridViewHasil.Rows(3).HeaderCell.Value = "Konsistensi"
    End Sub
    Private Sub loadRecord()
        Dim sqlcmd As MySqlCommand
        Dim sqlrd As MySqlDataReader

        Try
            Call c.myOpen()
            sqlcmd = New MySqlCommand("SELECT * FROM tb_pb WHERE kriteria='" & idKriteria(Array.IndexOf(namaKriteria, cb_kriteria.Text.ToString)) & "'", c.conn)
            sqlrd = sqlcmd.ExecuteReader
            If sqlrd.HasRows = True Then
                While sqlrd.Read = True
                    dataGridViewPB.Item(Array.IndexOf(idSubKriteria, sqlrd("colindex").ToString), Array.IndexOf(idSubKriteria, sqlrd("rowindex").ToString)).Value = Val(Format(sqlrd("nilai"), "0.000"))
                End While
                c.myClose()
            Else
                c.myClose()
                Call bersihkan()
            End If
        Catch ex As Exception
            MsgBox("[ERROR:SPB1] " & ex.Message, vbCritical + vbOKOnly, c.namaProgram)
        Finally
            c.myClose()
        End Try
    End Sub
    Private Sub setColorForEditAbleCell()
        For i = 0 To namaSubKriteria.Length - 1
            For j = 0 To namaSubKriteria.Length - 1
                If i < j Then
                    dataGridViewPB.Rows(i).Cells(j).Style.BackColor = Color.Gray
                End If
            Next
        Next
    End Sub

    Private Sub bersihkan()
        For i = 0 To namaSubKriteria.Length - 1
            For j = 0 To namaSubKriteria.Length - 1
                dataGridViewPB.Item(j, i).Value = 1
            Next
        Next

        For i = 0 To namaSubKriteria.Length - 1
            dataGridViewPB.Item(i, i).Value = 1
        Next
    End Sub

    'Buat Matrik
    Private Sub hitungPB()
        For i = 0 To namaSubKriteria.Length - 1
            For j = 0 To namaSubKriteria.Length - 1
                If i > j Then
                    dataGridViewPB.Item(j, i).Value = Format(Math.Round(1 / Val(dataGridViewPB.Item(i, j).Value), jlhBulat), "0.000")
                End If
            Next
        Next

        For i = 0 To namaSubKriteria.Length - 1
            Dim jumlah As Double = 0
            For j = 0 To namaSubKriteria.Length - 1
                jumlah += Val(dataGridViewPB.Item(i, j).Value)
            Next
            dataGridViewPB.Item(i, namaSubKriteria.Length).Value = Format(Math.Round(jumlah, jlhBulat), "0.000")
        Next
    End Sub

    Private Sub hitungMatriksPrioritas()
        'menyamakan penyebut
        For i = 0 To namaSubKriteria.Length - 1
            For j = 0 To namaSubKriteria.Length - 1
                dataGridViewPrioritas.Item(i, j).Value = Format(Math.Round(Val(dataGridViewPB.Item(i, j).Value) / Val(dataGridViewPB.Item(i, namaSubKriteria.Length).Value), jlhBulat), "0.000")
            Next
        Next

        'Penyebut
        For i = 0 To namaSubKriteria.Length - 1
            Dim jumlah As Double = 0
            For j = 0 To namaSubKriteria.Length - 1
                jumlah += dataGridViewPrioritas.Item(i, j).Value
            Next
            dataGridViewPrioritas.Item(i, namaSubKriteria.Length).Value = Format(Math.Round(jumlah, jlhBulat), "0.000")
        Next

        For i = 0 To namaSubKriteria.Length - 1
            Dim jumlah As Double = 0
            For j = 0 To namaSubKriteria.Length - 1
                jumlah += Val(dataGridViewPrioritas.Item(j, i).Value)
            Next
            dataGridViewPrioritas.Item(namaSubKriteria.Length, i).Value = Format(Math.Round(jumlah, jlhBulat), "0.000")
        Next

        Dim getMax As Double = 0
        For i = 0 To namaSubKriteria.Length - 1
            dataGridViewPrioritas.Item(namaSubKriteria.Length + 1, i).Value = Format(Math.Round(Val(dataGridViewPrioritas.Item(namaSubKriteria.Length, i).Value) / namaSubKriteria.Length, jlhBulat), "0.000")
            If Val(getMax) < Val(dataGridViewPrioritas.Item(namaSubKriteria.Length + 1, i).Value) Then
                getMax = Format(Math.Round(Val(dataGridViewPrioritas.Item(namaSubKriteria.Length + 1, i).Value), jlhBulat), "0.000")
            End If
        Next

        For i = 0 To namaSubKriteria.Length - 1
            dataGridViewPrioritas.Item(namaSubKriteria.Length + 2, i).Value = Format(Math.Round(Val(dataGridViewPrioritas.Item(namaSubKriteria.Length + 1, i).Value / getMax), jlhBulat), "0.000")
        Next
    End Sub
    Private Sub hitungJumlahPerbaris()
        For i = 0 To namaSubKriteria.Length - 1
            Dim jumlah As Double = 0
            For j = 0 To namaSubKriteria.Length - 1
                dataGridViewPenjumlahan.Item(j, i).Value = Format(Math.Round(Val(dataGridViewPrioritas.Item(namaSubKriteria.Length + 1, j).Value) * Val(dataGridViewPB.Item(j, i).Value), jlhBulat), "0.000")
                jumlah += Val(dataGridViewPenjumlahan.Item(j, i).Value)
            Next
            dataGridViewPenjumlahan.Item(namaSubKriteria.Length, i).Value = Format(Math.Round(jumlah, jlhBulat), "0.000")
        Next
    End Sub

    Private Sub hitungRasio()
        For i = 0 To namaSubKriteria.Length - 1
            dataGridViewRasio.Item(0, i).Value = Val(dataGridViewPenjumlahan.Item(namaSubKriteria.Length, i).Value)
        Next

        For i = 0 To namaSubKriteria.Length - 1
            dataGridViewRasio.Item(1, i).Value = Val(dataGridViewPrioritas.Item(namaSubKriteria.Length + 1, i).Value)
        Next

        For i = 0 To namaSubKriteria.Length - 1
            Dim jumlah As Double = 0
            For j = 0 To 1
                jumlah += Val(dataGridViewRasio.Item(j, i).Value)
            Next
            dataGridViewRasio.Item(2, i).Value = Format(Math.Round(Val(dataGridViewPenjumlahan.Item(namaSubKriteria.Length, i).Value) / Val(dataGridViewPrioritas.Item(namaSubKriteria.Length + 1, i).Value), jlhBulat), "0.000")

        Next

        Dim ajumlah As Double = 0
        For i = 0 To namaSubKriteria.Length - 1
            ajumlah += Val(dataGridViewRasio.Item(2, 1).Value)
        Next
        dataGridViewRasio.Item(2, namaSubKriteria.Length).Value = Format(Math.Round(ajumlah, jlhBulat), "0.000")
    End Sub

    Private Sub hitungHasil()
        dataGridViewHasil.Item(0, 0).Value = Format(Math.Round(Val(dataGridViewRasio.Item(2, namaSubKriteria.Length).Value / Val(namaSubKriteria.Length)), jlhBulat), "0.000")

        dataGridViewHasil.Item(0, 1).Value = Format(Math.Round(Val(dataGridViewHasil.Item(0, 0).Value) - Val(namaSubKriteria.Length), jlhBulat), "0.000")
        dataGridViewHasil.Item(0, 1).Value = Format(Math.Round(Val(dataGridViewHasil.Item(0, 1).Value) / (Val(namaSubKriteria.Length) - 1), jlhBulat), "0.000")

        dataGridViewHasil.Item(0, 2).Value = Format(Math.Round(Val(dataGridViewHasil.Item(0, 1).Value) / Val(NilaiIndeksRandom(namaKriteria.Length)), jlhBulat), "0.000")

        If Val(dataGridViewHasil.Item(0, 2).Value) < 0.1 Then
            dataGridViewHasil.Item(0, 3).Value = "Konsisten"
        Else
            dataGridViewHasil.Item(0, 3).Value = "Tidak Konsisten"
        End If
    End Sub

    Private Sub proses()
        Call hitungPB()
        Call hitungMatriksPrioritas()
        Call hitungJumlahPerbaris()
        Call hitungRasio()
        Call hitungHasil()
    End Sub

    Private Sub bt_proses_Click(sender As Object, e As EventArgs) Handles bt_proses.Click
        If dataGridViewPB.ColumnCount > 0 Then
            Call proses()
        End If
    End Sub

    Private Sub PBSubkriteria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        namaKriteria = c.getList("tb_kriteria", "nama_kriteria", "urutan")
        cb_kriteria.Items.Clear()
        If namaKriteria.Any = True Then
            For Each item As Object In namaKriteria
                cb_kriteria.Items.Add(item)
            Next
            cb_kriteria.Text = "--Pilih--"
            idKriteria = c.getList("tb_kriteria", "id_kriteria", "urutan")
            Call loadData()
        Else
            MsgBox("Kriteria tidak ditemukan", vbInformation + vbOKOnly, c.namaProgram)
        End If
    End Sub

    Private Sub dataGridViewPB_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dataGridViewPB.CellBeginEdit
        If e.ColumnIndex > e.RowIndex Then
            If e.ColumnIndex >= 0 Then
                If e.RowIndex >= 0 Then
                    Dim cmbSaaty As New DataGridViewComboBoxCell
                    cmbSaaty.Items.Clear()
                    cmbSaaty.Items.Add("0.111")
                    cmbSaaty.Items.Add("0.125")
                    cmbSaaty.Items.Add("0.143")
                    cmbSaaty.Items.Add("0.167")
                    cmbSaaty.Items.Add("0.200")
                    cmbSaaty.Items.Add("0.250")
                    cmbSaaty.Items.Add("0.333")
                    cmbSaaty.Items.Add("0.500")
                    cmbSaaty.Items.Add("1.000")
                    cmbSaaty.Items.Add("2.000")
                    cmbSaaty.Items.Add("3.000")
                    cmbSaaty.Items.Add("4.000")
                    cmbSaaty.Items.Add("5.000")
                    cmbSaaty.Items.Add("6.000")
                    cmbSaaty.Items.Add("7.000")
                    cmbSaaty.Items.Add("8.000")
                    cmbSaaty.Items.Add("9.000")
                    dataGridViewPB.Item(e.ColumnIndex, e.RowIndex) = cmbSaaty
                End If
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub bt_tutup_Click(sender As Object, e As EventArgs) Handles bt_tutup.Click
        If bt_tutup.Text = "TUTUP" Then
            Dim Halaman As New Halaman_Utama
            Halaman.Show()
            Me.Close()
        End If
    End Sub

    Private Sub cb_kriteria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_kriteria.SelectedIndexChanged
        Call loadData()
    End Sub

    Private Sub dataGridViewPrioritas_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dataGridViewPrioritas.CellBeginEdit
        e.Cancel = True
    End Sub

    Private Sub dataGridViewPenjumlahan_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dataGridViewPenjumlahan.CellBeginEdit
        e.Cancel = True
    End Sub

    Private Sub dataGridViewRasio_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dataGridViewRasio.CellBeginEdit
        e.Cancel = True
    End Sub

    Private Sub dataGridViewHasil_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dataGridViewHasil.CellBeginEdit
        e.Cancel = True
    End Sub

    Private Sub bt_sismpan_Click(sender As Object, e As EventArgs) Handles bt_sismpan.Click
        If dataGridViewPB.ColumnCount > 0 Then
            Call proses()

            'update pb
            If c.deleteData("tb_pb", "kriteria", idKriteria(Array.IndexOf(namaKriteria, cb_kriteria.Text.ToString))) = True Then
                'nothing
            End If
            For i = 0 To namaSubKriteria.Length - 1
                For j = 0 To namaSubKriteria.Length - 1
                    Dim fields() As String = {"kriteria", "colindex", "rowindex", "nilai"}
                    Dim datas() As String = {idKriteria(Array.IndexOf(namaKriteria, cb_kriteria.Text.ToString)), idSubKriteria(Array.IndexOf(namaSubKriteria, dataGridViewPB.Columns(i).HeaderText.ToString)), idSubKriteria(Array.IndexOf(namaSubKriteria, dataGridViewPB.Rows(j).HeaderCell.Value.ToString)), dataGridViewPB.Item(i, j).Value.ToString}
                    If c.insertData("tb_pb", fields, datas) Then
                        'nothing
                    End If
                Next
            Next

            'update nilai
            If c.deleteData("tb_hasil", "id_kriteria", idKriteria(Array.IndexOf(namaKriteria, cb_kriteria.Text.ToString))) = True Then
                'nothing
            End If
            For i = 0 To namaSubKriteria.Length - 1
                Dim fields() As String = {"id_kriteria", "id_subkriteria", "hasil"}
                Dim datas() As String = {idKriteria(Array.IndexOf(namaKriteria, cb_kriteria.Text.ToString)), idSubKriteria(Array.IndexOf(namaSubKriteria, dataGridViewRasio.Rows(i).HeaderCell.Value.ToString)), dataGridViewPrioritas.Item(namaSubKriteria.Length + 2, i).Value.ToString}
                If c.insertData("tb_hasil", fields, datas) Then
                    'nothing
                End If
            Next
            MsgBox("Tersimpan", vbInformation + vbOKOnly, c.namaProgram)
        End If
    End Sub
End Class