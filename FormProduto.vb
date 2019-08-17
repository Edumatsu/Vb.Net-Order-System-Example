Public Class FormProduto
    Dim Conn As SqlClient.SqlConnection

    Private Sub salvar_Click(sender As Object, e As EventArgs) Handles salvar.Click
        Dim sql As String

        sql = "INSERT INTO produtos "
        sql = sql & " (pro_nome, cat_id, mar_id) VALUES "
        sql = sql & " (@pro_nome, @cat_id, @mar_id) "

        Dim cmd As New SqlClient.SqlCommand(sql, Conn)
        cmd.Parameters.AddWithValue("pro_nome", txtProNome.Text)
        cmd.Parameters.AddWithValue("cat_id", cmbCategorias.SelectedItem("cat_id"))

        Console.WriteLine("teste" & cmbMarcas.SelectedItem)

        If (cmbMarcas.SelectedItem <> "" And cmbMarcas.SelectedItem <> -1) Then
            cmd.Parameters.AddWithValue("mar_id", cmbMarcas.SelectedItem("mar_id"))
        Else
            cmd.Parameters.AddWithValue("mar_id", "")
        End If

        If (cmd.ExecuteNonQuery()) Then
            MsgBox("Produto cadastrado com sucesso!", MsgBoxStyle.Information)
            limpaCampos()
            Me.Hide()
        Else
            MsgBox("Erro ao cadastrar produto", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = FormPrincipal.Connect()

        loadCategoriasCombo()
        loadMarcasCombo()
    End Sub

    Private Sub loadMarcasCombo()
        Dim marcasData = FormPrincipal.dataAdapterMarcas()

        With cmbMarcas
            .DataSource = marcasData.Tables("marcas")
            .DisplayMember = "mar_nome"
            .ValueMember = "mar_id"
        End With
    End Sub

    Private Sub loadCategoriasCombo()
        Dim categoriasData = FormPrincipal.dataAdapterCategorias()

        With cmbCategorias
            .DataSource = categoriasData.Tables("categorias")
            .DisplayMember = "cat_nome"
            .ValueMember = "cat_id"
        End With
    End Sub

    Private Sub limpaCampos()
        txtProNome.Text = ""
        cmbCategorias.SelectedIndex = -1
        cmbMarcas.SelectedIndex = -1
    End Sub

    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        limpaCampos()
        Me.Hide()
    End Sub

    Private Sub addCategoria_Click(sender As Object, e As EventArgs) Handles addCategoria.Click
        FormCategorias.Show()
    End Sub
End Class