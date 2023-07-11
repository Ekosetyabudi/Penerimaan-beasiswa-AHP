Public Class Halaman_Utama

    Private Sub bt_datakriteria_Click(sender As Object, e As EventArgs) Handles bt_datakriteria.Click
        Dim Halaman As New Data_kriteria
        Halaman.Show()
        Me.Close()

    End Sub

    Private Sub bt_datasub_Click(sender As Object, e As EventArgs) Handles bt_datasub.Click
        Dim Halsub As New Data_subkriteria
        Halsub.Show()
        Me.Close()
    End Sub

    Private Sub bt_dataadmin_Click(sender As Object, e As EventArgs) Handles bt_dataadmin.Click
        Dim Halaman As New Data_admin
        Halaman.Show()
        Me.Close()

    End Sub

    Private Sub bt_nilaialternatif_Click(sender As Object, e As EventArgs) Handles bt_nilaialternatif.Click
        Dim Halaman As New Halaman_Penilaianalternatif
        Halaman.Show()
        Me.Close()
    End Sub

    Private Sub bt_datasiswa_Click_1(sender As Object, e As EventArgs) Handles bt_datasiswa.Click
        Dim Halaman As New Data_siswa
        Halaman.Show()
        Me.Close()
    End Sub

    Private Sub bt_kriteria_Click(sender As Object, e As EventArgs) Handles bt_kriteria.Click
        Dim Halaman As New PBKriteria
        Halaman.Show()
        Me.Close()
    End Sub

    Private Sub bt_subkriteria_Click(sender As Object, e As EventArgs) Handles bt_subkriteria.Click
        Dim Halaman As New PBSubkriteria
        Halaman.Show()
        Me.Close()
    End Sub

    Private Sub bt_infonilai_Click(sender As Object, e As EventArgs) Handles bt_infonilai.Click
        Dim Halaman As New Halaman_Nilaiprioritas
        Halaman.Show()
        Me.Close()
    End Sub

    Private Sub bt_ahp_Click(sender As Object, e As EventArgs) Handles bt_ahp.Click
        Dim Halaman As New Halaman_AHP
        Halaman.Show()
        Me.Close()
    End Sub

    Private Sub bt_alternatif_Click(sender As Object, e As EventArgs)
        Dim Halaman As New Data_siswa
        Halaman.Show()
        Me.Close()
    End Sub

    Private Sub bt_pb_Click(sender As Object, e As EventArgs) Handles bt_pb.Click
        Timer_pb.Start()
        If Panel_pb.Height <> 0 Then
            Panel_pb.Height = 0
            Timer_pb.Enabled = False
        End If
    End Sub

    Private Sub Timer_pb_Tick(sender As Object, e As EventArgs) Handles Timer_pb.Tick
        Panel_pb.Height = 119
        Timer_pb.Stop()
    End Sub

    Private Sub bt_input_Click(sender As Object, e As EventArgs) Handles bt_input.Click
        Timer_input.Start()
        If panel_input.Height <> 0 Then
            panel_input.Height = 0
            Timer_input.Enabled = False
        End If
    End Sub

    Private Sub Timer_input_Tick(sender As Object, e As EventArgs) Handles Timer_input.Tick
        panel_input.Height = 270
        Timer_input.Stop()
    End Sub

    Private Sub bt_laporan_Click(sender As Object, e As EventArgs) Handles bt_laporan.Click
        Timer_laporan.Start()
        If Panel_laporan.Height <> 0 Then
            Panel_laporan.Height = 0
            Timer_laporan.Enabled = False
        End If
    End Sub

    Private Sub Timer_laporan_Tick(sender As Object, e As EventArgs) Handles Timer_laporan.Tick
        Panel_laporan.Height = 119
        Timer_laporan.Stop()
    End Sub

    Private Sub Halaman_Utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim Halaman As New Form_Login
        Halaman.Show()
        Me.Close()
    End Sub
End Class