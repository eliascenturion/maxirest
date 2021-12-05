Public Class salon
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBarra.Click
        pedido.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMesa1.Click
        pedido2.ShowDialog()
    End Sub

    Private Sub btnMesa2_Click(sender As Object, e As EventArgs) Handles btnMesa2.Click
        pedido3.ShowDialog()
    End Sub

    Private Sub btnMesa3_Click(sender As Object, e As EventArgs) Handles btnMesa3.Click
        pedido4.ShowDialog()
    End Sub
End Class