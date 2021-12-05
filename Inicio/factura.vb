Imports MySql.Data.MySqlClient
Public Class factura
    Dim nombreEmpleado As String
    Private Sub factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListViewFacturas.View = View.Details
        ListViewFacturas.GridLines = True
        ListViewFacturas.HideSelection = False
        ListViewFacturas.FullRowSelect = True
        ListViewFacturas.MultiSelect = False
        Me.BackColor = Color.FromArgb(228, 227, 228)

        cargarEmlpeados()
        cargarMesas()
        cargarFiltro()
    End Sub
    Private Sub cargarEmlpeados()
        Try
            Dim adaAlumno As New MySqlDataAdapter("SELECT * FROM empleados", conexion)
            Dim tablaEmpleados As New DataTable("empleados")
            adaAlumno.Fill(tablaEmpleados)
            cbEmpleado.DataSource = tablaEmpleados
            cbEmpleado.DisplayMember = "nombre"
            cbEmpleado.ValueMember = "id"
            cbEmpleado.SelectedValue = 0
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub cargarMesas()
        Try
            For i = 1 To 3
                cbMesas.Items.Add(i)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub cargarFiltro()
        Try
            cbFiltro.Items.Add("Ninguna")
            cbFiltro.Items.Add("ambas")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub sumarTotal()
        Dim ultimo As Integer
        ultimo = ListViewFacturas.Items.Count - 1
        Label4.Text += CInt(ListViewFacturas.Items(ultimo).SubItems(3).Text)
    End Sub

    Public Function cargarlistado(idEmpleado, idMesa, filtro, v)
        ListViewFacturas.Items.Clear()
        Try
            Module1.conexion.Open()
            Dim cmdStock As New MySqlCommand()
            cmdStock.Connection = conexion
            cmdStock.CommandType = CommandType.Text
            If filtro = "ambas" Then
                cmdStock.CommandText = "SELECT * FROM pedidos WHERE id_mesa =" + idMesa + " AND id_empleado =" + idEmpleado
            Else
                If v = 0 Then
                    cmdStock.CommandText = "SELECT * FROM pedidos WHERE id_empleado =" + idEmpleado
                ElseIf v = 1
                    cmdStock.CommandText = "SELECT * FROM pedidos WHERE id_mesa =" + idMesa
                End If
            End If
            Dim readEmpleados As MySqlDataReader
            readEmpleados = cmdStock.ExecuteReader
            Do While readEmpleados.Read()
                Dim fila As ListViewItem
                fila = ListViewFacturas.Items.Add(readEmpleados("nro_pedido"))
                fila.SubItems.Add(readEmpleados("id_mesa"))
                fila.SubItems.Add(readEmpleados("detalle"))
                fila.SubItems.Add(readEmpleados("precio"))
                sumarTotal()
            Loop

            readEmpleados.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            conexion.Close()
            conexion.Dispose()
            Module1.conexion.Close()
        End Try
    End Function

    Private Sub cbEmpleado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbEmpleado.SelectionChangeCommitted
        Label4.Text = 0
        Dim idMesas As Integer = 0
        Dim idEmpleado = cbEmpleado.SelectedValue.ToString
        Dim filtro = cbFiltro.SelectedText.ToString
        If cbEmpleado.SelectedIndex > -1 Then
            cargarlistado(idEmpleado, idMesas, filtro, 0)
        End If
    End Sub

    Private Sub cbMesas_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbMesas.SelectionChangeCommitted
        Label4.Text = 0
        Dim idMesas = cbMesas.SelectedItem.ToString
        MsgBox(cbMesas.SelectedItem.ToString)
        Dim filtro = cbFiltro.SelectedText.ToString
        Dim idEmpleado As Integer = 0
        If cbMesas.SelectedIndex > -1 Then
            cargarlistado(idEmpleado, idMesas, filtro, 1)
        End If
    End Sub

    Private Sub cbFiltro_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbFiltro.SelectionChangeCommitted
        If cbFiltro.SelectedIndex > -1 Then
            If cbEmpleado.SelectedIndex > -1 Then
                If cbMesas.SelectedIndex > -1 Then
                    Dim idMesas = cbMesas.SelectedItem.ToString
                    Dim idEmpleado = cbEmpleado.SelectedValue.ToString
                    Dim filtro = cbFiltro.SelectedItem.ToString
                    cargarlistado(idEmpleado, idMesas, filtro, 1)
                Else
                    MsgBox("Seleccione una mesa")
                End If
            Else
                MsgBox("Seleccione un empleado")
            End If
        End If
    End Sub
End Class