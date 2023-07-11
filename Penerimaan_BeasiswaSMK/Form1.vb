Imports MySql.Data.MySqlClient
Public Class Form_Login
    Dim c As New clsConn
    Dim sqlcmd As MySqlCommand
    Dim sqlrd As MySqlDataReader
   
  


    Private Sub bt_login_Click(sender As Object, e As EventArgs) Handles bt_login.Click
        If username.Text = "" And password.Text = "" Then
            MsgBox("Nama Guru dan password harap diisi")
        Else

            Try
                c.myOpen()
                sqlcmd = New MySqlCommand("select * FROM tb_guru WHERE nama_guru='" & username.Text & "' and password='" & password.Text & "'", c.conn)
                sqlrd = sqlcmd.ExecuteReader
                If sqlrd.HasRows = True Then
                    While sqlrd.Read = True
                        Dim Halaman As New Halaman_Utama
                        Halaman.Show()
                        Me.Hide()

                    End While
                End If
            Catch ex As Exception
                MsgBox("[ERROR:FAHP1] " & ex.Message, vbCritical + vbOKOnly, c.namaProgram)
            Finally
                c.myClose()

            End Try
           
        End If
       
    End Sub

    Private Sub bt_batal_Click(sender As Object, e As EventArgs) Handles bt_batal.Click
        If bt_batal.Text = "Batal" Then
            Me.Close()
        End If
    End Sub
End Class
