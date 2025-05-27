KODE PROGRAM CARI Double Klik Tombol CARI Ketik Kode Berikut Dibawah Private Sub Bcari……………
Dim cari As String
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cari = InputBox("masukkan kode barang yang akan dicari!!", "pencarian data barang")
        query = "select * from TbBarang where Kobar='" & cari & "'"
        cmd = New SqlCommand(query, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            t1.Text = dr.GetString(0)
            t2.Text = dr.GetString(1)
            t3.Text = dr.GetString(2)
            t4.Text = dr.GetValue(3)
            t5.Text = dr.GetValue(4)
                  Else
            MsgBox("data tidak di temukan")
            cmd.Dispose()
            conn.Close()
            Exit Sub
        End If
        cmd.Dispose()
        conn.Close()
        t1.Focus()