Public Class FrmCalculadoraB
    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        lblOperador.Text = "+"
        lblOperador.Visible = True
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        lblOperador.Text = "-"
        lblOperador.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        lblOperador.Text = "x"
        lblOperador.Visible = True
    End Sub

    Private Sub btnDivi_Click(sender As Object, e As EventArgs) Handles btnDivi.Click
        lblOperador.Text = "/"
        lblOperador.Visible = True
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        lblOperador.Text = "%"
        lblOperador.Visible = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblOperador.Text = ""
        txtOp1.Text = ""
        txtOp2.Text = ""
        txtResultado.Text = " "
        txtOp1.Focus()
    End Sub

    Private Sub btnExe_Click(sender As Object, e As EventArgs) Handles btnExe.Click
        Select Case lblOperador.Text
            Case "+"
                txtResultado.Text = Val(txtOp1.Text) + Val(txtOp2.Text)
            Case "-"
                txtResultado.Text = Val(txtOp1.Text) - Val(txtOp2.Text)
            Case "x"
                txtResultado.Text = Val(txtOp1.Text) * Val(txtOp2.Text)
            Case "/"
                txtResultado.Text = Val(txtOp1.Text) / Val(txtOp2.Text)
            Case "%"
                txtResultado.Text = Val(txtOp1.Text) Mod Val(txtOp2.Text)
        End Select
    End Sub

    Private Sub FrmCalculadoraB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOp1.Focus()
    End Sub
End Class
