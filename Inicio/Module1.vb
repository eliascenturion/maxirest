Imports MySql.Data.MySqlClient
Module Module1
    Public conexion As New MySqlConnection(("server=localhost;uid=root;database=maxirest;password=;SslMode=none"))
    Public consulta As String 'Variables para las consultas SQL' 
    Public accion As String 'Para determinar que tipo de consulta (insert, update, delete)'
    Public idUser As String
    Public Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub
    Public Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub
End Module