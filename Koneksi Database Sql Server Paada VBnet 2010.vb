Sub koneksi()
        Try
            conn = New SqlConnection("Data Source=(local);Initial Catalog=DBpersediaan;Integrated Security=True")
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
End Sub