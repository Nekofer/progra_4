Public Class frmPromedio
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim pparcial As Decimal
        Dim pfinal As Decimal
        pparcial = Val(txtParcialP.Text) / 100
        pfinal = Val(txtFinalP.Text) / 100
        lblPromedioFF.Text = Val(txtParcial1.Text) * pparcial + Val(txtParcial2.Text) * pparcial + Val(txtParcial3.Text) * pparcial + Val(txtFinal.Text) * pfinal
        lblPromedioFF.Visible = True
        If Val(lblPromedioFF.Text) < 6 Then
            lblPromedioFF.ForeColor = Color.Red
        End If
        If Val(lblPromedioFF.Text) > 8 And Val(lblPromedioFF.Text) >= 9 Then
            lblDescuento.Text = "20%"
            lblDescuento.Visible = True
        Else
            lblDescuento.Text = "10%"
            lblDescuento.Visible = True
        End If
        If Val(lblPromedioFF.Text) < 8 And Val(lblPromedioFF.Text) >= 7 Then
            lblDescuento.Text = "5%"
            lblDescuento.Visible = True
        Else
            lblDescuento.Text = "NO"
            lblDescuento.Visible = True
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtParcial1.Text = ""
        txtParcial2.Text = ""
        txtParcial3.Text = ""
        txtFinal.Text = ""
        txtParcialP.Text = ""
        txtFinalP.Text = ""
        lblPromedioFF.Text = ""
        lblDescuento.Text = ""
        txtParcial1.Focus()
    End Sub
End Class
