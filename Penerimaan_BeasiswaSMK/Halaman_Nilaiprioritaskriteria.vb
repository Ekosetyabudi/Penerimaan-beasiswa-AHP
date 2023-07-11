Imports MySql.Data.MySqlClient

Public Class Halaman_Nilaiprioritas
    Dim c As New clsConn
    Dim sqlcmd As MySqlCommand
    Dim sqlrd As MySqlDataReader
    Private Sub Halaman_Nilaiprioritaskriteria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.myOpen()
        Try
            sqlcmd = New MySqlCommand("SELECT tb_hasil.id_subkriteria, tb_kriteria.nama_kriteria, tb_hasil.hasil FROM tb_hasil INNER JOIN tb_kriteria ON tb_kriteria.id_kriteria = tb_hasil.id_subkriteria WHERE tb_hasil.id_kriteria = 'all' ORDER BY tb_kriteria.urutan", c.conn)
            sqlrd = sqlcmd.ExecuteReader
            Dim lstIDKriteria As New List(Of String)
            If sqlrd.HasRows = False Then
                MsgBox("Tidak ditemukan data", vbInformation + vbOKOnly, c.namaProgram)
                sqlrd.Close()
                c.myClose()
                Exit Sub
            Else
                DataGridView_NPK.Columns.Add("", "")
                DataGridView_NPK.Rows.Add(3)
                Dim myI As Integer = 0
                While sqlrd.Read = True
                    lstIDKriteria.Add(sqlrd("id_subkriteria").ToString)
                    DataGridView_NPK.Item(myI, 0).Value = sqlrd("nama_kriteria")
                    DataGridView_NPK.Item(myI, 1).Value = Format(sqlrd("hasil"), "0.000")
                    myI += 1
                    DataGridView_NPK.Columns.Add("", "")
                End While
                DataGridView_NPK.Rows(0).DefaultCellStyle.BackColor = Color.Gray
                DataGridView_NPK.Rows(0).DefaultCellStyle.ForeColor = Color.White

                sqlrd.Close()
                c.myClose()

                For i = 0 To lstIDKriteria.Count - 1
                    c.myOpen()
                    sqlcmd = New MySqlCommand("SELECT tb_subkriteria.nama_subkriteria, tb_hasil.hasil FROM tb_hasil INNER JOIN tb_subkriteria ON tb_subkriteria.id_subkriteria = tb_hasil.id_subkriteria WHERE tb_hasil.id_kriteria ='" & lstIDKriteria(i) & "' ORDER BY tb_hasil.hasil DESC", c.conn)
                    sqlrd = sqlcmd.ExecuteReader
                    If sqlrd.HasRows = True Then
                        Dim row As Integer = 3
                        While sqlrd.Read = True
                            If DataGridView_NPK.RowCount < row + 2 Then
                                DataGridView_NPK.Rows.Add(2)
                            End If

                            DataGridView_NPK.Item(i, row).Value = sqlrd("nama_subkriteria")
                            DataGridView_NPK.Item(i, row + 1).Value = Format(sqlrd("hasil"), "0.000")

                            DataGridView_NPK.Rows(row).DefaultCellStyle.BackColor = Color.Gray
                            DataGridView_NPK.Rows(row).DefaultCellStyle.ForeColor = Color.White
                            row += 2
                        End While
                    End If
                    sqlrd.Close()
                    c.myClose()
                Next
            End If
        Catch ex As Exception
            MsgBox("[ERROR:NPK1] " & ex.Message, vbInformation + vbOKOnly, c.namaProgram)
        Finally
            c.myClose()
        End Try

        For Each col As DataGridViewColumn In DataGridView_NPK.Columns
            col.SortMode = DataGridViewColumnSortMode.Programmatic
        Next
    End Sub

    Private Sub bt_tutup_Click(sender As Object, e As EventArgs) Handles bt_tutup.Click
        If bt_tutup.Text = "TUTUP" Then
            Dim Halaman As New Halaman_Utama
            Halaman.Show()
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView_NPK_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView_NPK.CellBeginEdit
        e.Cancel = True
    End Sub
End Class