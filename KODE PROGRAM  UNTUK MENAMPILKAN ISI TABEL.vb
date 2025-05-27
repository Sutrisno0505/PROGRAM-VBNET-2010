KODE PROGRAM  UNTUK MENAMPILKAN ISI TABEL SUPPLIER PADA OBJEK TEXTBOX double Klik objek kode supplier  Ketik Kode Berikut Dibawah Private Sub t3 selectedchange…
	
	Call koneksi()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        cmd = New SqlCommand("select * from Tbsupplier where kosup='" & t3.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            t4.Text = dr.GetString(1)
			 t5.Focus()
        End If
        cmd.Dispose()
        conn.Close()