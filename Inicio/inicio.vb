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
        AbrirFormulario(New salon)
    End Sub
End Class