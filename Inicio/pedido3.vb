Imports MySql.Data.MySqlClient
Public Class pedido3
    Public NombreEmpleado As Integer
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim sql = "SELECT P.* FROM productos P INNER JOIN categorias C on P.id_categoria=C.id WHERE C.id = 1; "
        cargarlistado(sql)
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
        cargarEmlpeados()
        TextBoxTotal.Text = 0
        TextBoxTotal.Enabled = False
    End Sub
    Private Sub ListViewMenu_DoubleClick(sender As Object, e As EventArgs) Handles ListViewMenu.DoubleClick
        If ListViewMenu.Items.Count > 0 Then
            Dim i As Integer
            Dim fila As ListViewItem
            Dim primero As String
            Dim segundo As String
            Dim tercero As String

            For Each i In ListViewMenu.SelectedIndices
                primero = ListViewMenu.Items(i).SubItems(0).Text
                segundo = ListViewMenu.Items(i).SubItems(1).Text
                tercero = ListViewMenu.Items(i).SubItems(2).Text
            Next
            If (CbNomEpleado.Text = "") Then
                MsgBox("Por favor seleccione un empleado")
            Else
                fila = ListViewPedido.Items.Add(segundo)
                fila.SubItems.Add(tercero)
                CbNomEpleado.Enabled = False
                sumarTotal()
            End If

        End If
    End Sub
    Private Sub sumarTotal()
        Dim ultimo As Integer
        ultimo = ListViewPedido.Items.Count - 1
        TextBoxTotal.Text += CInt(ListViewPedido.Items(ultimo).SubItems(1).Text)
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

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If ListViewMenu.Items.Count > 0 Then
            If ListViewMenu.SelectedIndices.Count > 0 Then
                Dim i As Integer
                Dim fila As ListViewItem
                Dim primero As String
                Dim segundo As String
                Dim tercero As String

                For Each i In ListViewMenu.SelectedIndices
                    primero = ListViewMenu.Items(i).SubItems(0).Text
                    segundo = ListViewMenu.Items(i).SubItems(1).Text
                    tercero = ListViewMenu.Items(i).SubItems(2).Text
                Next
                If (CbNomEpleado.Text = "") Then
                    MsgBox("Por favor seleccione un empleado")
                Else
                    If (segundo <> "" And tercero <> "") Then
                        fila = ListViewPedido.Items.Add(segundo)
                        fila.SubItems.Add(tercero)
                        CbNomEpleado.Enabled = False
                        sumarTotal()
                    End If
                End If
            Else
                MsgBox("Seleccione algo del menu")
            End If
        Else
            MsgBox("Seleccione una categoria")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListViewMenu.SelectedIndices.Count > 0 Then
            For Each i In ListViewPedido.SelectedIndices
                ListViewPedido.Items.RemoveAt(i)
            Next
        Else
            MsgBox("Seleccione un elemento para borrar")
        End If

    End Sub
    Public Function numero_pedido()
        Try
            Module1.conexion.Open()
            Dim cmdStock As New MySqlCommand()
            cmdStock.Connection = conexion
            cmdStock.CommandType = CommandType.Text
            cmdStock.CommandText = "SELECT COUNT(*) as cantidad FROM pedidos;"
            Dim readEmpleados As MySqlDataReader
            readEmpleados = cmdStock.ExecuteReader
            Do While readEmpleados.Read()
                Return readEmpleados("cantidad")
            Loop
            readEmpleados.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            conexion.Close()
        End Try
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CbNomEpleado.SelectedIndex.Equals(-1) Then
            MsgBox("Debe seleccionar un empleado.")
        Else
            If ListViewPedido.Items.Count > 0 Then
                Dim idEmpleado = CbNomEpleado.SelectedValue
                Dim idMesa = 1
                Dim numeroPedido As Integer = numero_pedido() + 1
                Module1.conexion.Open()
                Dim cmdStock As New MySqlCommand()
                cmdStock.Connection = conexion
                Try
                    For i = 0 To ListViewPedido.Items.Count - 1
                        Dim detalle = ListViewPedido.Items(i).SubItems(0).Text
                        Dim precio = ListViewPedido.Items(i).SubItems(1).Text
                        cmdStock.CommandType = CommandType.Text
                        cmdStock.CommandText = "INSERT INTO pedidos (nro_pedido, id_mesa, detalle, precio, id_empleado) VALUES (" + numeroPedido.ToString + "," + idMesa.ToString + ",'" + detalle.ToString + "'," + precio.ToString + "," + idEmpleado.ToString + ")"
                        Dim readEmpleados As MySqlDataReader
                        readEmpleados = cmdStock.ExecuteReader
                        readEmpleados.Close()
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                Finally
                    conexion.Close()
                End Try
                ListViewPedido.Items.Clear()
                ListViewMenu.Items.Clear()
                CbNomEpleado.Enabled = True
                TextBoxTotal.Text = 0
                MsgBox("Factura creada con exito")
            Else
                MsgBox("Debe agregar algun producto a pedido")
            End If


        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim sql = "SELECT P.* FROM productos P INNER JOIN categorias C on P.id_categoria=C.id WHERE C.id = 2; "
        cargarlistado(sql)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim sql = "SELECT P.* FROM productos P INNER JOIN categorias C on P.id_categoria=C.id WHERE C.id = 3; "
        cargarlistado(sql)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim sql = "SELECT P.* FROM productos P INNER JOIN categorias C on P.id_categoria=C.id WHERE C.id = 4; "
        cargarlistado(sql)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim sql = "SELECT P.* FROM productos P INNER JOIN categorias C on P.id_categoria=C.id WHERE C.id = 5; "
        cargarlistado(sql)
    End Sub
    Private Sub CbNomEpleado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbNomEpleado.SelectionChangeCommitted
        CbNomEpleado.Enabled = False
    End Sub
End Class