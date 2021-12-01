Imports MySql.Data.MySqlClient
Public Class pedido
    Public NombreEmpleado As Integer
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

    Private Sub pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListViewPedido.View = View.Details
        ListViewPedido.GridLines = True
        ListViewPedido.HideSelection = False
        ListViewPedido.FullRowSelect = True
        ListViewPedido.MultiSelect = False
        Me.BackColor = Color.FromArgb(228, 227, 228)
        ListViewMenu.View = View.Details
        ListViewMenu.GridLines = True
        ListViewMenu.HideSelection = False
        ListViewMenu.FullRowSelect = True
        ListViewMenu.MultiSelect = False
        Me.BackColor = Color.FromArgb(228, 227, 228)
    End Sub
    Private Sub ListViewMenu_DoubleClick(sender As Object, e As EventArgs) Handles ListViewMenu.DoubleClick
        If ListViewMenu.Items.Count > 0 Then
            Dim i As Integer
            For Each i In ListViewPedido.SelectedIndices
                txtnombre.Text = ListViewMenu.Items(i).SubItems(0).Text
                txtDni.Text = ListViewMenu.Items(i).SubItems(4).Text
                txtNombre.Text = ListViewMenu.Items(i).SubItems(1).Text
                txtApellido.Text = ListViewMenu.Items(i).SubItems(2).Text
                cbCargos.Text = ListViewMenu.Items(i).SubItems(3).Text
                Dim id_cargo = ListViewMenu.Items(i).SubItems(5).Text
                accion = "update"
                txtNombre.Focus()
            Next
            btnGuardar.Enabled = True
        End If
    End Sub

    Private Sub CbNomEpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNomEpleado.SelectedIndexChanged

    End Sub
    Private Sub cargarEmlpeados()
        Try
            Dim adaAlumno As New MySqlDataAdapter("SELECT * FROM empleados", conexion)
            Dim tablaEmpleados As New DataTable("empleados")
            adaAlumno.Fill(tablaEmpleados)
            CbNomEpleado.DataSource = tablaEmpleados
            CbNomEpleado.DisplayMember = "nombre"
            CbNomEpleado.ValueMember = "id"
            CbNomEpleado.SelectedValue = NombreEmpleado
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Class