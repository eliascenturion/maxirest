Imports MySql.Data.MySqlClient
Public Class Form1
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim usuario = TextBox1.Text
        Dim password = TextBox2.Text
        consulta = "SELECT * FROM administradores WHERE usuario ='" + usuario + "' AND password='" + password + "'"
        Try
            Module1.conexion.Open()
            Dim cmd As New MySqlCommand(consulta, conexion)
            cmd.ExecuteNonQuery()
            Dim lector = cmd.ExecuteReader
            If lector.Read() Then
                idUser = lector("id")
                If (idUser <> "") Then
                    AbrirFormulario(New inicio)
                End If
            Else
                MsgBox("Usuario incorrecto")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            Module1.conexion.Close()
        End Try


    End Sub
    Private Sub AbrirFormulario(ByRef formhijo As Object)
        If PanelMains.Controls.Count > 0 Then
            PanelMains.Controls.RemoveAt(0)
        End If
        Dim formulario As Form = TryCast(formhijo, Form)
        formulario.TopLevel = False
        formulario.FormBorderStyle = FormBorderStyle.None
        formulario.Dock = DockStyle.Fill
        PanelMains.Controls.Add(formulario)
        PanelMains.Tag = formulario
        formulario.Show()

    End Sub

    Private Sub PanelMain_Paint(sender As Object, e As PaintEventArgs) Handles PanelMains.Paint

    End Sub
End Class
