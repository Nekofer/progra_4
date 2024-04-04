Public Class frmIMC

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        lblResultado.Text = Val(txtPeso.Text) / (Val(txtAltura.Text) * Val(txtAltura.Text))
        lblResultado.Visible = True
        Dim Valor As Decimal
        Valor = lblResultado.Text
        lblResultado.Text = Valor.ToString("N2")
        If Valor <= 19 Then
            picSeñal.Location = New Point(387, 414)
            picSeñal.Visible = True
        End If
        If Valor > 19 And Valor < 25 Then
            picSeñal.Location = New Point(535, 414)
            picSeñal.Visible = True
        End If
        If Valor > 25 And Valor < 30 Then
            picSeñal.Location = New Point(689, 414)
            picSeñal.Visible = True
        End If
        If Valor > 30 Then
            picSeñal.Location = New Point(840, 414)
            picSeñal.Visible = True
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtAltura.Text = ""
        txtPeso.Text = ""
        lblResultado.Text = ""
        picSeñal.Visible = False
        txtPeso.Focus()
    End Sub

    Private Sub frmIMC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPeso.Focus()
    End Sub
End Class
