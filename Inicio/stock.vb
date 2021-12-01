Imports MySql.Data.MySqlClient
Public Class stock
    Public codigoCategoria As Integer
    Public codigo
    Private Sub ConfigurarControles()
        btnBorrar.Enabled = False
        btnGuardar.Enabled = False
        txtCodigo.Enabled = True
        txtCodigo.Clear()
        txtProducto.Clear()
        txtCodigo.Focus()
        cargarlistado()
    End Sub
    Private Sub stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarlistado()
        cargarCategorias()
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.HideSelection = False
        ListView1.FullRowSelect = True
        ListView1.MultiSelect = False
        Me.BackColor = Color.FromArgb(228, 227, 228)
        ConfigurarControles()
    End Sub
    Private Sub cargarCategorias()
        Try
            Dim adaAlumno As New MySqlDataAdapter("SELECT * FROM categorias", conexion)
            Dim tablaCategorias As New DataTable("categorias")
            adaAlumno.Fill(tablaCategorias)
            cbCategoria.DataSource = tablaCategorias
            cbCategoria.DisplayMember = "nombre"
            cbCategoria.ValueMember = "id"
            cbCategoria.SelectedValue = codigoCategoria
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub cargarlistado()
        ListView1.Items.Clear()
        Try
            Module1.conexion.Open()
            Dim cmdStock As New MySqlCommand()
            cmdStock.Connection = conexion
            cmdStock.CommandType = CommandType.Text
            cmdStock.CommandText = "SELECT P.*, C.nombre as categoria_nombre FROM productos P INNER JOIN categorias C ON c.id = P.id_categoria;"
            Dim readproductos As MySqlDataReader
            readproductos = cmdStock.ExecuteReader
            Do While readproductos.Read()
                Dim fila As ListViewItem
                fila = ListView1.Items.Add(readproductos("id"))
                fila.SubItems.Add(readproductos("nombre"))
                fila.SubItems.Add(readproductos("precio"))
                fila.SubItems.Add(readproductos("stock"))
                fila.SubItems.Add(readproductos("id_categoria"))
                fila.SubItems.Add(readproductos("categoria_nombre"))
            Loop
            readproductos.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            conexion.Close()
        End Try
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        accion = "insert"
        verificar()
    End Sub
    Private Sub verificar()
        If txtCantidad.Text = "" Or txtPrecio.Text = "" Or cbCategoria.Text = "" Or txtPrecio.Text = "" Or txtCodigo.Text = "" Then
            MsgBox("Verifique los datos", MsgBoxStyle.Exclamation, "ERROR")
            txtCantidad.Focus()
        Else
            crud()
            ConfigurarControles()
        End If
    End Sub
    Private Sub limpiar()
        txtCodigo.Text = ""
        txtProducto.Text = ""
        txtPrecio.Text = ""
        txtCantidad.Text = ""
        cbCategoria.Text = ""
    End Sub
    Private Sub crud()
        Select Case accion
            Case "insert"
                consulta = "INSERT INTO productos VALUES (" + txtCodigo.Text + ",'" + txtProducto.Text + "'," + txtPrecio.Text + "," + txtCantidad.Text + "," + cbCategoria.SelectedValue.ToString + ")"
                limpiar()
                cargarlistado()
                MsgBox("Datos agregados")
            Case "update"
                consulta = "UPDATE productos SET nombre='" + txtProducto.Text + "' , precio=" + txtPrecio.Text + " , stock=" + txtCantidad.Text + " WHERE id= " + txtCodigo.Text
                limpiar()
                cargarlistado()
                MsgBox("Datos modificados")
            Case "delete"
                consulta = "DELETE FROM productos WHERE id=" + Label8.Text
                limpiar()

                MsgBox("Datos eliminados")
        End Select
        Try
            Module1.conexion.Open()
            Dim cmd As New MySqlCommand(consulta, conexion)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            Module1.conexion.Close()
        End Try
        cargarlistado()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Me.Hide()
    End Sub
    Function convertir(ByVal texto As String) As String
        Dim a As String = StrConv(texto, VbStrConv.ProperCase)
        Return a
    End Function
    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If ListView1.Items.Count > 0 Then
            Dim i As Integer
            For Each i In ListView1.SelectedIndices
                txtCodigo.Text = ListView1.Items(i).SubItems(0).Text
                cbCategoria.Text = ListView1.Items(i).SubItems(5).Text
                txtProducto.Text = ListView1.Items(i).SubItems(1).Text
                txtPrecio.Text = ListView1.Items(i).SubItems(2).Text
                txtCantidad.Text = ListView1.Items(i).SubItems(3).Text
                accion = "update"
                txtCodigo.Focus()
                btnGuardar.Enabled = True
                btnBorrar.Enabled = True
                txtCodigo.Enabled = False
                cbCategoria.Enabled = True
            Next
            'cargarCategorias()
        Else
            MsgBox("asdad")
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtCodigo.Text = "" Then
            MsgBox("El codigo es obligatorio")
            txtCodigo.Focus()
        ElseIf txtCantidad.Text = "" Then
            MsgBox("Debe poner la cantidad del producto, es obligatorio")
            txtCantidad.Focus()
        ElseIf txtPrecio.Text = "" Then
            MsgBox("El precio es obligatorio")
            txtPrecio.Focus()
        ElseIf txtProducto.Text = "" Then
            MsgBox("Debe poner que producto es")
            txtProducto.Focus()
        ElseIf cbCategoria.Text = "" Then
            MsgBox("La categoria es obligatoria")
            cbCategoria.Focus()
        Else
            accion = "update"
            verificar()
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        accion = "delete"
        crud()
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        For Each i In ListView1.SelectedIndices
            Label8.Text = ListView1.Items(i).SubItems(0).Text
        Next
        btnBorrar.Enabled = True
    End Sub
End Class