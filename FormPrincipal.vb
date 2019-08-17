Public Class FormPrincipal
    Dim Conn As New SqlClient.SqlConnection

    Private Sub ProdutosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem1.Click
        FormProdutos.MdiParent = Me
        FormProdutos.Show()
    End Sub

    Public Function Connect()

        If (Conn.State = ConnectionState.Open) Then
            Conn.Close()
        End If

        Conn.ConnectionString = "Data Source=" & My.Settings.ConnServer & "; Database=" & My.Settings.ConnDatabase & "; User ID=" & My.Settings.ConnUser & "; Password=" & My.Settings.ConnPassword & ";"

        Try
            Conn.Open()

            If Conn.State <> ConnectionState.Open Then
                Throw New Exception("Erro ao conectar no banco de dados")
            End If
        Catch ex As Exception
            MsgBox("Erro ao conectar no banco de dados", MsgBoxStyle.Critical)
        End Try

        Return Conn
    End Function

    Public Function dataAdapterCategorias()
        Dim sql As String

        sql = "SELECT * FROM categorias ORDER BY cat_nome ASC"

        Dim ds As New DataSet
        Dim da As New SqlClient.SqlDataAdapter(sql, Conn)

        da.Fill(ds, "categorias")

        Return ds
    End Function

    Public Function dataAdapterMarcas()
        Dim sql As String

        sql = "SELECT * FROM marcas ORDER BY mar_nome ASC"

        Dim ds As New DataSet
        Dim da As New SqlClient.SqlDataAdapter(sql, Conn)

        da.Fill(ds, "marcas")

        Return ds
    End Function

    Private Sub load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = Connect()
    End Sub
End Class
