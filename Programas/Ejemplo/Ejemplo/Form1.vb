Public Class frmEjemplo
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim edad As Integer
        edad = 2020 - Val(txtEdad.Text)

        lblResultado.Visible = True
        If edad >= 18 Then
            lblResultado.Text = "Cumpliras" + Str(edad) + " años. Eres mayor de edad"
        Else
            lblResultado.Text = "Cumpliras" + Str(edad) + " años."
        End If
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtEdad.Text = ""
        lblResultado.Visible = False
        txtEdad.Focus()
    End Sub
End Class
