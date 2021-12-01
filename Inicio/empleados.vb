Imports MySql.Data.MySqlClient

Public Class empleados
    Public codCargo As Integer
    Private Sub ConfigurarControles()
        btnBorrar.Enabled = False
        btnGuardar.Enabled = False
        txtCodigo.Enabled = True
        txtCodigo.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDni.Clear()
        txtCodigo.Focus()
        cargarlistado()
    End Sub
    Private Sub empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCargo()
        cargarlistado()
        ListViewEmpleados.View = View.Details
        ListViewEmpleados.GridLines = True
        ListViewEmpleados.HideSelection = False
        ListViewEmpleados.FullRowSelect = True
        ListViewEmpleados.MultiSelect = False
        Me.BackColor = Color.FromArgb(228, 227, 228)
        ConfigurarControles()
    End Sub
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        inicio.ShowDialog()
    End Sub
    Function convertir(ByVal texto As String) As String
        Dim a As String = StrConv(texto, VbStrConv.ProperCase)
        Return a
    End Function
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
        End If
    End Sub
    Private Sub limpiar()
        txtNombre.Text = ""
        txtCodigo.Text = ""
        txtApellido.Text = ""
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
                consulta = "UPDATE empleados SET nombre='" + txtNombre.Text + "', apellido='" + txtApellido.Text + "', dni=" + txtDni.Text + ", id_cargo=" + cbCargos.SelectedValue.ToString + " WHERE id=" + txtCodigo.Text
                MsgBox("Datos modificados")
                limpiar()
                cargarlistado()
            Case "delete"
                consulta = "DELETE FROM empleados WHERE id=" + txtCodigo.Text
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
    End Sub
    Private Sub cargarlistado()
        ListViewEmpleados.Items.Clear()
        Try
            Module1.conexion.Open()
            Dim cmdStock As New MySqlCommand()
            cmdStock.Connection = conexion
            cmdStock.CommandType = CommandType.Text
            cmdStock.CommandText = "SELECT E.*, C.nombre as nombre_cargo, C.id as id_cargo FROM empleados E INNER JOIN cargos C on E.id_cargo = C.id ORDER BY E.id;"
            Dim readEmpleados As MySqlDataReader
            readEmpleados = cmdStock.ExecuteReader
            Do While readEmpleados.Read()
                Dim fila As ListViewItem
                fila = ListViewEmpleados.Items.Add(readEmpleados("id"))
                fila.SubItems.Add(readEmpleados("nombre"))
                fila.SubItems.Add(readEmpleados("apellido"))
                fila.SubItems.Add(readEmpleados("nombre_cargo"))
                fila.SubItems.Add(readEmpleados("dni"))
                fila.SubItems.Add(readEmpleados("id_cargo"))
            Loop
            readEmpleados.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            conexion.Close()
            conexion.Dispose()
            Module1.conexion.Close()
        End Try
    End Sub

    Private Sub ListViewEmpleados_DoubleClick(sender As Object, e As EventArgs) Handles ListViewEmpleados.DoubleClick
        If ListViewEmpleados.Items.Count > 0 Then
            Dim i As Integer
            For Each i In ListViewEmpleados.SelectedIndices
                txtCodigo.Text = ListViewEmpleados.Items(i).SubItems(0).Text
                txtDni.Text = ListViewEmpleados.Items(i).SubItems(4).Text
                txtNombre.Text = ListViewEmpleados.Items(i).SubItems(1).Text
                txtApellido.Text = ListViewEmpleados.Items(i).SubItems(2).Text
                cbCargos.Text = ListViewEmpleados.Items(i).SubItems(3).Text
                Dim id_cargo = ListViewEmpleados.Items(i).SubItems(5).Text
                accion = "update"
                txtNombre.Focus()
            Next
            btnGuardar.Enabled = True
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtCodigo.Text = "" Then
            MsgBox("El codigo es obligatorio")
            txtCodigo.Focus()
        ElseIf txtNombre.Text = "" Then
            MsgBox("El nombre es obligatorio")
            txtNombre.Focus()
        ElseIf txtApellido.Text = "" Then
            MsgBox("El Apellido es obligatorio")
            txtNombre.Focus()
        ElseIf txtDni.Text = "" Then
            MsgBox("El DNI es obligatorio")
            txtNombre.Focus()
        ElseIf cbCargos.Text = "" Then
            MsgBox("El Cargo es obligatorio")
            cbCargos.Focus()
        Else
            accion = "update"
            verificar()
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        accion = "delete"
        crud()
    End Sub

    Private Sub ListViewEmpleados_Click(sender As Object, e As EventArgs) Handles ListViewEmpleados.Click
        btnBorrar.Enabled = True
    End Sub
End Class