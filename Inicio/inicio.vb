Imports MySql.Data.MySqlClient
Public Class inicio

    Public Sub AbrirFormulario(ByRef formhijo As Object)
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

    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        AbrirFormulario(New stock)
    End Sub

    Private Sub btnCargos_Click_1(sender As Object, e As EventArgs) Handles btnCargos.Click
        AbrirFormulario(New empleados)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormulario(New salon)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormulario(New factura)
    End Sub
End Class