Public Class Juego


    Private Sub btnAdelante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdelante.Click
        tmrAdelante.Start()
        tmrAbajo.Start()
        tmrArriba.Stop()
        tmrAtras.Stop()

    End Sub

    Private Sub tmrAdelante_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAdelante.Tick
        If pctImagenGif.Location.X >= 713 Then
            tmrAdelante.Stop()
        Else
            pctImagenGif.Left = pctImagenGif.Location.X + 2

        End If
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        tmrAtras.Start()
        tmrAdelante.Stop()
        tmrArriba.Stop()
        tmrAbajo.Stop()

    End Sub

    Private Sub tmrAtras_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAtras.Tick
        If pctImagenGif.Location.X = 0 Then
            tmrAtras.Stop()
        Else
            pctImagenGif.Left = pctImagenGif.Location.X - 2

        End If
    End Sub

    Private Sub btnArriba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArriba.Click
        tmrArriba.Start()
        tmrAbajo.Stop()
        tmrAdelante.Stop()
        tmrAtras.Stop()

    End Sub

    Private Sub tmrArriba_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrArriba.Tick
        If pctImagenGif.Location.Y = 144 Then
            tmrArriba.Stop()
        Else
            pctImagenGif.Top = pctImagenGif.Location.Y - 2

        End If
    End Sub

    Private Sub btnAbajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbajo.Click
        tmrAbajo.Start()
        tmrArriba.Stop()
        tmrAdelante.Stop()
        tmrAtras.Stop()

    End Sub

    Private Sub tmrAbajo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAbajo.Tick
        If pctImagenGif.Location.Y = 470 Then
            tmrArriba.Stop()
        Else
            pctImagenGif.Top = pctImagenGif.Location.Y + 2
        End If

    End Sub

    Private Sub btnDetente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetente.Click
        tmrAdelante.Stop()
        tmrAtras.Stop()
        tmrArriba.Stop()
        tmrAbajo.Stop()


    End Sub


    
    Private Sub pctArriba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctArriba.Click
        tmrArriba.Start()
        tmrAbajo.Stop()
        tmrAdelante.Stop()
        tmrAtras.Stop()

    End Sub

    Private Sub pctAbajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctAbajo.Click
        tmrAbajo.Start()
        tmrArriba.Stop()
        tmrAdelante.Stop()
        tmrAtras.Stop()
    End Sub

    Private Sub pctAdelante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctAdelante.Click
        tmrAdelante.Start()
        tmrAbajo.Stop()
        tmrArriba.Stop()
        tmrAtras.Stop()

    End Sub

    Private Sub pctAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctAtras.Click
        tmrAtras.Start()
        tmrAdelante.Stop()
        tmrArriba.Stop()
        tmrAbajo.Stop()
    End Sub

    Private Sub pctDetente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctDetente.Click
        tmrAdelante.Stop()
        tmrAtras.Stop()
        tmrArriba.Stop()
        tmrAbajo.Stop()
        tmrTurbo.Stop()
    End Sub


    Private Sub pctTurbo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctTurbo.Click
        tmrTurbo.Start()
        tmrAdelante.Start()
        tmrAtras.Stop()
        tmrArriba.Stop()
        tmrAbajo.Stop()


    End Sub

    Private Sub tmrTurbo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTurbo.Tick
        tmrAdelante.Stop()
        If pctImagenGif.Location.X >= 713 Then
            tmrTurbo.Stop()
        Else
            pctImagenGif.Left = pctImagenGif.Location.X + 8

        End If
    End Sub

    Private Sub Juego_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pctImagenGif.Visible = False
        pctArriba.Visible = False
        pctAbajo.Visible = False
        pctAdelante.Visible = False
        pctAtras.Visible = False
        pctDetente.Visible = False
        pctTurbo.Visible = False

    End Sub

    Private Sub btnJugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJugar.Click
        pctImagenGif.Visible = True
        pctArriba.Visible = True
        pctAbajo.Visible = True
        pctAdelante.Visible = True
        pctAtras.Visible = True
        pctDetente.Visible = True
        pctTurbo.Visible = True
        btnJugar.Visible = False

        My.Computer.Audio.Play(Application.StartupPath + "\Imagenes\Simpsons.WAV", AudioPlayMode.BackgroundLoop)
    End Sub
End Class