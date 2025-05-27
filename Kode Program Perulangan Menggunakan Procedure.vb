KODE PROGRAM PERULANGAN UNTUK MENAMPILKAN ISI TABEL SUPPLIER PADA COMBOBOX (Menggunakan Procedure)
 Ketik Kode Berikut Dibawah end sub
Sub tampilsupplier()
T3.items.clear()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd = New SqlCommand("select * from Tbsupplier", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            t3.Items.Add(dr.GetString(0))
        Loop
        cmd.Dispose()
        conn.Close()
    End Sub
