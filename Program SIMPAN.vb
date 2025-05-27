 If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        query = "insert into  Tbsiswa values('" & t1.Text & "','" & t2.Text & "','" & t3.Text & "','" & t4.Text & "','" & t5.Text & "','" & (Format(t6.Value, "yyyy-MM-dd")) & "','" & t7.Text & "','" & t8.Text & "','" & t9.Text & "','" & t10.Text & "','" & t11.Text & "','" & t12.Text & "')"
        cmd = New SqlCommand(query, conn)
        cmd.ExecuteNonQuery()
        MsgBox("data barang baru sudah tersimpan")
        cmd.Dispose()
        conn.Close()