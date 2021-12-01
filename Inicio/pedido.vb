Imports MySql.Data.MySqlClient
Public Class pedido
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim sql = "SELECT P.* FROM productos P INNER JOIN categorias C on P.id_categoria=C.id WHERE C.id = 1; "
        cargarlistado(sql)
    End Sub
    Private Sub crud()
        Select Case accion
            'Case "insert"
            '    consulta = "INSERT INTO empleados VALUES (" + txtCodigo.Text + ",'" + txtNombre.Text + "', '" + txtApellido.Text + "', " + cbCargos.SelectedValue.ToString + ", " + txtDni.Text + " )"
            '    limpiar()
            '    cargarlistado()
            '    MsgBox("Datos agregados")
            'Case "update"
            '    consulta = "UPDATE empleados SET nombre='" + txtNombre.Text + "', apellido='" + txtApellido.Text + "', dni=" + txtDni.Text + ", id_cargo=" + cbCargos.SelectedValue.ToString + " WHERE id=" + txtCodigo.Text
            '    MsgBox("Datos modificados")
            '    limpiar()
            '    cargarlistado()
            'Case "delete"
            '    consulta = "DELETE FROM empleados WHERE id=" + txtCodigo.Text
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
    Private Sub cargarlistado(ByVal sql As String)
        ListViewMenu.Items.Clear()
        Try
            Module1.conexion.Open()
            Dim cmdStock As New MySqlCommand()
            cmdStock.Connection = conexion
            cmdStock.CommandType = CommandType.Text
            cmdStock.CommandText = sql
            Dim readEmpleados As MySqlDataReader
            readEmpleados = cmdStock.ExecuteReader
            Do While readEmpleados.Read()
                Dim fila As ListViewItem
                fila = ListViewMenu.Items.Add(readEmpleados("id"))
                fila.SubItems.Add(readEmpleados("nombre"))
                fila.SubItems.Add(readEmpleados("precio"))
            Loop
            readEmpleados.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            conexion.Close()
        End Try
    End Sub
End Class