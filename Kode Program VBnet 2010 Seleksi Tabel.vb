Sub tampil()
        Call koneksi()
        da = New SqlDataAdapter("select * from TbBarang", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "TbBarang")
        DataGridView1.DataSource = ds.Tables("TbBarang")
        DataGridView1.ReadOnly = True
    End Sub
