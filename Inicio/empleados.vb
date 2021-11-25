Imports MySql.Data.MySqlClient

Public Class empleados
    Public codCargo As Integer
    Private Sub empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCargo()
        cargarlistado()
    End Sub
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        inicio.ShowDialog()
    End Sub

    Private Sub CargarCargo()
        Try
            Dim adaCargo As New MySqlDataAdapter("SELECT * FROM cargos", conexion)
            Dim tablaCategorias As New DataTable("cargos")
            adaCargo.Fill(tablaCategorias)
            cbCargos.DataSource = tablaCategorias
            cbCargos.DisplayMember = "nombre"
            cbCargos.ValueMember = "id"
            cbCargos.SelectedValue = codCargo
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        accion = "insert"
        verificar()
    End Sub
    Private Sub verificar()
        If txtNombre.Text = "" Or txtDni.Text = "" Or cbCargos.Text = "" Then
            MsgBox("Verifique los datos", MsgBoxStyle.Exclamation, "ERROR")
            txtNombre.Focus()
        Else
            crud()
            'configurarControles()
        End If
    End Sub
    Private Sub limpiar()
        txtNombre.Text = ""
        cbCargos.Text = ""
        txtDni.Text = ""
    End Sub
    Private Sub crud()
        Select Case accion
            Case "insert"
                consulta = "INSERT INTO empleados VALUES (" + txtCodigo.Text + ",'" + txtNombre.Text + "', '" + txtApellido.Text + "', " + cbCargos.SelectedValue.ToString + ", " + txtDni.Text + " )"
                limpiar()
                cargarlistado()
                MsgBox("Datos agregados")
            Case "update"
                consulta = "UPDATE Set productos Set "
                MsgBox("Datos modificados")
                'Case "delete"
                '    consulta = "delete from cursa where idmateria=" + cbMateria.SelectedValue.ToString + "And idalumno=" + cbAlumno.SelectedValue.ToString + " And ciclo=" + txtCiclo.Text + ""
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
    Private Sub cargarlistado()
        ListViewEmpleados.Items.Clear()
        Try
            Module1.conexion.Open()
            Dim cmdStock As New MySqlCommand()
            cmdStock.Connection = conexion
            cmdStock.CommandType = CommandType.Text
            cmdStock.CommandText = "Select E.id As codigo_usu, E.nombre As nombre_usu, E.dni, C.nombre As nombre_cargo, E.apellido, E.id As id_usu FROM empleados E INNER JOIN cargos C On C.id = E.id_cargo"
            Dim readCursada As MySqlDataReader
            readCursada = cmdStock.ExecuteReader
            Do While readCursada.Read()
                Dim fila As ListViewItem
                fila = ListViewEmpleados.Items.Add(readCursada("id_usu"))
                ListViewEmpleados.Items.Add(readCursada("nombre_usu"))
                ListViewEmpleados.Items.Add(readCursada("apellido"))
                ListViewEmpleados.Items.Add(readCursada("nombre_cargo"))
                ListViewEmpleados.Items.Add(readCursada("dni"))
            Loop
            readCursada.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            Module1.conexion.Close()
        End Try
    End Sub

    Private Sub ListViewEmpleados_DoubleClick(sender As Object, e As EventArgs) Handles ListViewEmpleados.DoubleClick
        If ListViewEmpleados.Items.Count > 0 Then
            Dim i As Integer
            For Each i In ListViewEmpleados.SelectedIndices
                txtCodigo.Text = ListViewEmpleados.Items(i).SubItems(0).Text
                txtDni.Text = ListViewEmpleados.Items(i).SubItems(3).Text
                txtNombre.Text = ListViewEmpleados.Items(i).SubItems(1).Text
                txtApellido.Text = ListViewEmpleados.Items(i).SubItems(2).Text
                accion = "update"
                txtNombre.Focus()
            Next
        End If
    End Sub

End Class