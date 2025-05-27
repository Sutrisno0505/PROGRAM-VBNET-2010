 	Call koneksi()
        da = New SqlDataAdapter("select * from Tbnilai where nis like '%" & tnis.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True