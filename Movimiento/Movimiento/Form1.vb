Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnIzquierda.Click
        tmrIzquierda.Start()
        tmrDerecha.Stop()
        tmrArriba.Stop()
        tmrAbajo.Stop()
    End Sub

    Private Sub btnArriba_Click(sender As Object, e As EventArgs) Handles btnArriba.Click
        tmrArriba.Start()
        tmrAbajo.Stop()
        tmrIzquierda.Stop()
        tmrDerecha.Stop()
    End Sub

    Private Sub btnDerecha_Click(sender As Object, e As EventArgs) Handles btnDerecha.Click
        tmrDerecha.Start()
        tmrAbajo.Stop()
        tmrArriba.Stop()
        tmrIzquierda.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAbajo.Click
        tmrAbajo.Start()
        tmrArriba.Stop()
        tmrIzquierda.Stop()
        tmrDerecha.Stop()
    End Sub

    Private Sub btnAlto_Click(sender As Object, e As EventArgs) Handles btnAlto.Click
        tmrDerecha.Stop()
        tmrAbajo.Stop()
        tmrArriba.Stop()
        tmrIzquierda.Stop()
    End Sub

    Private Sub tmrIzquierda_Tick(sender As Object, e As EventArgs) Handles tmrIzquierda.Tick
        picPelota.Left = picPelota.Location.X - 2
    End Sub

    Private Sub tmrAbajo_Tick(sender As Object, e As EventArgs) Handles tmrAbajo.Tick
        picPelota.Top = picPelota.Location.Y + 2
    End Sub

    Private Sub tmrArriba_Tick(sender As Object, e As EventArgs) Handles tmrArriba.Tick
        picPelota.Top = picPelota.Location.Y - 2
    End Sub

    Private Sub tmrDerecha_Tick(sender As Object, e As EventArgs) Handles tmrDerecha.Tick
        picPelota.Left = picPelota.Location.X + 2
    End Sub
End Class
