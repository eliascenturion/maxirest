Public Class salon
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBarra.Click
        pedido.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMesa1.Click
        pedido.ShowDialog()
    End Sub

    Private Sub salon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class