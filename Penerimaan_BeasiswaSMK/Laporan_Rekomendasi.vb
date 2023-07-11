Public Class Laporan_Rekomendasi

    Private Sub bt_tutup_Click(sender As Object, e As EventArgs) Handles bt_tutup.Click
        Dim Halaman As New Halaman_AHP
        Halaman.Show()
        Me.Close()
    End Sub
End Class