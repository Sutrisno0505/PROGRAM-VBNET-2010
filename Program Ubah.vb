 If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        query = "Update Tbsiswa set nama='" & t2.Text & "',alamat='" & t3.Text & "', jenkel='" & t4.Text & "',tlahir='" & t5.Text & "',tgllahir='" & (Format(t6.Value, "yyyy-MM-dd")) & "',nohp='" & t7.Text & "',kelas='" & t8.Text & "',tajaran='" & t9.Text & "',namaorli='" & t10.Text & "',pekerjaan='" & t11.Text & "',nohportu='" & t12.Text & "' where nis='" & t1.Text & "'"
        cmd = New SqlCommand(query, conn)
        cmd.Connection = conn
        cmd.ExecuteReader()
        cmd.Dispose()
        conn.Close()