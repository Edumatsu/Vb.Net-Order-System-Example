Public Class FormProdutos
    Dim Conn As SqlClient.SqlConnection

    Private Sub Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = FormPrincipal.Connect()

        loadProdutos(Nothing)
        loadCmbCategorias()
        loadCmbMarcas()
    End Sub

    Private Sub loadCmbCategorias()
        Dim dsCategorias = FormPrincipal.dataAdapterCategorias()

        With cmbCategorias
            .DataSource = dsCategorias.Tables("categorias")
            .DisplayMember = "cat_nome"
            .ValueMember = "cat_id"
        End With
    End Sub

    Private Sub loadCmbMarcas()
        Dim dsMarcas = FormPrincipal.dataAdapterMarcas()

        With cmbMarcas
            .DataSource = dsMarcas.Tables("marcas")
            .DisplayMember = "mar_nome"
            .ValueMember = "mar_id"
        End With
    End Sub

    Private Function loadProdutos(ByVal filter As String)
        Dim sql As String

        sql = "SELECT "
        sql = sql & "   a.pro_id as ID, "
        sql = sql & "   a.pro_nome as Produto, "
        sql = sql & "   a.pro_nome as Produto, "
        sql = sql & "   b.cat_nome as Categoria, "
        sql = sql & "   c.mar_nome as Marca "
        sql = sql & " FROM produtos AS a "
        sql = sql & " INNER JOIN categorias AS b ON a.cat_id = b.cat_id "
        sql = sql & " LEFT JOIN marcas AS c ON a.mar_id = c.mar_id "
        sql = sql & " WHERE 1 = 1 "
        sql = sql & filter
        sql = sql & " ORDER BY a.pro_nome ASC "

        Dim DS As New DataSet
        Dim DA As New SqlClient.SqlDataAdapter(sql, Conn)
        DA.Fill(DS, "produtos")

        gridProdutos.DataSource = DS.Tables("produtos")

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormProduto.MdiParent = FormPrincipal
        FormProduto.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filter As String = ""

        If (txtNome.Text <> "") Then
            filter = "AND a.pro_nome LIKE '%" & txtNome.Text & "%' "
        End If


        If (cmbCategorias.SelectedIndex <> -1) Then
            filter = filter & " AND a.cat_id = " & cmbCategorias.SelectedItem("cat_id")
        End If

        If (cmbMarcas.SelectedIndex <> -1) Then
            filter = filter & " AND a.mar_id = " & cmbMarcas.SelectedItem("mar_id")
        End If

        loadProdutos(filter)
    End Sub
End Class