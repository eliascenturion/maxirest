Imports MySql.Data.MySqlClient
Public Class stock
    Public codigoCategoria As Integer
    Private Sub stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarlistado()
        cargarCategorias()
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
            cmdStock.CommandText = "SELECT P.id as id_producto, P.nombre as nombre_producto, p.stock, P.precio, P.id_categoria as id_categoria_p, C.id as id_categoria, C.nombre as nombre_categoria FROM productos P inner join categorias C on P.id_categoria= C.id;"
            Dim readCursada As MySqlDataReader
            readCursada = cmdStock.ExecuteReader
            Do While readCursada.Read()
                Dim fila As ListViewItem
                fila = ListView1.Items.Add(readCursada("id_producto"))
                ListView1.Items.Add(readCursada("nombre_producto"))
                ListView1.Items.Add(readCursada("stock"))
                ListView1.Items.Add(readCursada("precio"))
                ListView1.Items.Add(readCursada("id_categoria_p"))
            Loop
            readCursada.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            Module1.conexion.Close()
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
            'configurarControles()
        End If
    End Sub
    Private Sub limpiar()
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtPrecio.Text = ""
        txtCantidad.Text = ""
        cbCategoria.Text = ""
    End Sub
    Private Sub crud()
        Select Case accion
            Case "insert"
                consulta = "INSERT INTO productos VALUES (" + txtCodigo.Text + ",'" + txtNombre.Text + "'," + txtPrecio.Text + "," + txtCantidad.Text + "," + cbCategoria.SelectedValue.ToString + ")"
                limpiar()
                cargarlistado()
                MsgBox("Datos agregados")
            Case "update"
                consulta = "UPDATE SET productos SET "
                MsgBox("Datos modificados")
                'Case "delete"
                '    consulta = "delete from cursa where idmateria=" + cbMateria.SelectedValue.ToString + "AND idalumno=" + cbAlumno.SelectedValue.ToString + " AND ciclo=" + txtCiclo.Text + ""
                '    MsgBox("Datos eliminados")
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
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Me.Hide()
    End Sub

End Class