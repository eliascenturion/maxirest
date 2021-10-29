Imports MySql.Data.MySqlClient
Public Class inicio
    Private Sub AbrirFormulario(ByRef formhijo As Object)
        If PanelMain.Controls.Count > 0 Then
            PanelMain.Controls.RemoveAt(0)
        End If
        Dim formulario As Form = TryCast(formhijo, Form)
        formulario.TopLevel = False
        formulario.FormBorderStyle = FormBorderStyle.None
        formulario.Dock = DockStyle.Fill
        PanelMain.Controls.Add(formulario)
        PanelMain.Tag = formulario
        formulario.Show()

    End Sub

    Private Sub btnAbrirTurno_Click(sender As Object, e As EventArgs) Handles btnAbrirTurno.Click
        consulta = "INSERT INTO turnos (id_admin) VALUES (" + idUser + ")"
        Try
            Module1.conexion.Open()
            Dim cmd As New MySqlCommand(consulta, conexion)
            cmd.ExecuteNonQuery()
            AbrirFormulario(New salon)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            Module1.conexion.Close()
        End Try

    End Sub
    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        AbrirFormulario(New stock)
    End Sub
End Class