KODE PROGRAM HAPUS Double Klik Tombol HAPUS Ketik Kode Berikut Dibawah Private Sub BHAPUS……………
If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        query = "Delete From TbPembelian where nobeli='" & t1.Text & "'"
        cmd = New SqlCommand(query, conn)
        cmd.ExecuteNonQuery()
        MsgBox("data sudah terhapus")
        cmd.Dispose()
        conn.Close()
		 call tampil()
		 call kosong()
        call aktif(false)
