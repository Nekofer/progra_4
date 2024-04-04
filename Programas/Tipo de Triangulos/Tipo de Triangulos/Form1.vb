Public Class frmTriangulo
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim l1, l2, l3 As Integer
        l1 = Val(txtLado1.Text)
        l2 = Val(txtLado2.Text)
        l3 = Val(txtLado3.Text)
        If l1 = l2 And l2 = l3 Then
            picTriangulo.Image = Image.FromFile(Application.StartupPath + "\tEquilatero.png")
            lblResultado.Text = "Triangulo Equilatero"
            lblResultado.Visible = True
        End If
        If l1 = l2 And l2 <> l3 Or l3 = l1 And l1 <> l3 Or l3 = l2 And l2 <> l1 Or l1 = l3 And l3 <> l2 Then
            lblResultado.Text = "Triangulo Isoceles"
            lblResultado.Visible = True
            picTriangulo.Image = Image.FromFile(Application.StartupPath + "\tIsoceles.png")
        End If
        If l1 <> l2 And l2 <> l3 And l1 <> l3 Then
            lblResultado.Text = "Triangulo Escaleno"
            lblResultado.Visible = True
            picTriangulo.Image = Image.FromFile(Application.StartupPath + "\tEscaleno.png")
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Application.Restart()
    End Sub

    Private Sub frmTriangulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLado1.Focus()
    End Sub
End Class
