Sub ujidata()
        Call koneksi()
        query = "select * from Tbsiswa where nis='" & t1.Text & "'"
        cmd = New SqlCommand(query, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            MsgBox("data barang sudah ada sebelumnya?? ")
            Exit Sub
            Call aktif(True)
            t1.Focus()
        Else
            cmd.Dispose()
            conn.Close()
            Call simpan()
        End If
        cmd.Dispose()
        conn.Close()
    End Sub