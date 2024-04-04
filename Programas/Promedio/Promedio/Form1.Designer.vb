<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPromedio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblParcial1 = New System.Windows.Forms.Label()
        Me.lblParcial2 = New System.Windows.Forms.Label()
        Me.lblParcial3 = New System.Windows.Forms.Label()
        Me.txtParcial1 = New System.Windows.Forms.TextBox()
        Me.txtParcial2 = New System.Windows.Forms.TextBox()
        Me.txtParcial3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.lblParcialP = New System.Windows.Forms.Label()
        Me.lblFinalP = New System.Windows.Forms.Label()
        Me.txtParcialP = New System.Windows.Forms.TextBox()
        Me.txtFinalP = New System.Windows.Forms.TextBox()
        Me.lblCalificaciones = New System.Windows.Forms.Label()
        Me.lblPonderacion = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lblPromedio = New System.Windows.Forms.Label()
        Me.lblPromedioFF = New System.Windows.Forms.Label()
        Me.lblDescu = New System.Windows.Forms.Label()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblParcial1
        '
        Me.lblParcial1.AutoSize = True
        Me.lblParcial1.BackColor = System.Drawing.Color.Transparent
        Me.lblParcial1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParcial1.Location = New System.Drawing.Point(57, 79)
        Me.lblParcial1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblParcial1.Name = "lblParcial1"
        Me.lblParcial1.Size = New System.Drawing.Size(119, 31)
        Me.lblParcial1.TabIndex = 0
        Me.lblParcial1.Text = "Parcial 1"
        '
        'lblParcial2
        '
        Me.lblParcial2.AutoSize = True
        Me.lblParcial2.BackColor = System.Drawing.Color.Transparent
        Me.lblParcial2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParcial2.Location = New System.Drawing.Point(57, 126)
        Me.lblParcial2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblParcial2.Name = "lblParcial2"
        Me.lblParcial2.Size = New System.Drawing.Size(119, 31)
        Me.lblParcial2.TabIndex = 1
        Me.lblParcial2.Text = "Parcial 2"
        '
        'lblParcial3
        '
        Me.lblParcial3.AutoSize = True
        Me.lblParcial3.BackColor = System.Drawing.Color.Transparent
        Me.lblParcial3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParcial3.Location = New System.Drawing.Point(57, 174)
        Me.lblParcial3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblParcial3.Name = "lblParcial3"
        Me.lblParcial3.Size = New System.Drawing.Size(119, 31)
        Me.lblParcial3.TabIndex = 2
        Me.lblParcial3.Text = "Parcial 3"
        '
        'txtParcial1
        '
        Me.txtParcial1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParcial1.Location = New System.Drawing.Point(193, 75)
        Me.txtParcial1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtParcial1.Name = "txtParcial1"
        Me.txtParcial1.Size = New System.Drawing.Size(132, 37)
        Me.txtParcial1.TabIndex = 3
        '
        'txtParcial2
        '
        Me.txtParcial2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParcial2.Location = New System.Drawing.Point(193, 122)
        Me.txtParcial2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtParcial2.Name = "txtParcial2"
        Me.txtParcial2.Size = New System.Drawing.Size(132, 37)
        Me.txtParcial2.TabIndex = 4
        '
        'txtParcial3
        '
        Me.txtParcial3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParcial3.Location = New System.Drawing.Point(193, 170)
        Me.txtParcial3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtParcial3.Name = "txtParcial3"
        Me.txtParcial3.Size = New System.Drawing.Size(132, 37)
        Me.txtParcial3.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 219)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Final"
        '
        'txtFinal
        '
        Me.txtFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinal.Location = New System.Drawing.Point(193, 215)
        Me.txtFinal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(132, 37)
        Me.txtFinal.TabIndex = 7
        '
        'lblParcialP
        '
        Me.lblParcialP.AutoSize = True
        Me.lblParcialP.BackColor = System.Drawing.Color.Transparent
        Me.lblParcialP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParcialP.Location = New System.Drawing.Point(448, 79)
        Me.lblParcialP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblParcialP.Name = "lblParcialP"
        Me.lblParcialP.Size = New System.Drawing.Size(97, 31)
        Me.lblParcialP.TabIndex = 8
        Me.lblParcialP.Text = "Parcial"
        '
        'lblFinalP
        '
        Me.lblFinalP.AutoSize = True
        Me.lblFinalP.BackColor = System.Drawing.Color.Transparent
        Me.lblFinalP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalP.Location = New System.Drawing.Point(448, 126)
        Me.lblFinalP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFinalP.Name = "lblFinalP"
        Me.lblFinalP.Size = New System.Drawing.Size(73, 31)
        Me.lblFinalP.TabIndex = 9
        Me.lblFinalP.Text = "Final"
        '
        'txtParcialP
        '
        Me.txtParcialP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParcialP.Location = New System.Drawing.Point(560, 75)
        Me.txtParcialP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtParcialP.Name = "txtParcialP"
        Me.txtParcialP.Size = New System.Drawing.Size(132, 37)
        Me.txtParcialP.TabIndex = 10
        '
        'txtFinalP
        '
        Me.txtFinalP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalP.Location = New System.Drawing.Point(560, 122)
        Me.txtFinalP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFinalP.Name = "txtFinalP"
        Me.txtFinalP.Size = New System.Drawing.Size(132, 37)
        Me.txtFinalP.TabIndex = 11
        '
        'lblCalificaciones
        '
        Me.lblCalificaciones.AutoSize = True
        Me.lblCalificaciones.BackColor = System.Drawing.Color.Transparent
        Me.lblCalificaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalificaciones.Location = New System.Drawing.Point(15, 20)
        Me.lblCalificaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCalificaciones.Name = "lblCalificaciones"
        Me.lblCalificaciones.Size = New System.Drawing.Size(183, 31)
        Me.lblCalificaciones.TabIndex = 12
        Me.lblCalificaciones.Text = "Calificaciones"
        '
        'lblPonderacion
        '
        Me.lblPonderacion.AutoSize = True
        Me.lblPonderacion.BackColor = System.Drawing.Color.Transparent
        Me.lblPonderacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPonderacion.Location = New System.Drawing.Point(391, 20)
        Me.lblPonderacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPonderacion.Name = "lblPonderacion"
        Me.lblPonderacion.Size = New System.Drawing.Size(166, 31)
        Me.lblPonderacion.TabIndex = 13
        Me.lblPonderacion.Text = "Ponderacion"
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(64, 304)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(169, 48)
        Me.btnCalcular.TabIndex = 14
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(253, 304)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(169, 48)
        Me.btnLimpiar.TabIndex = 14
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'lblPromedio
        '
        Me.lblPromedio.AutoSize = True
        Me.lblPromedio.BackColor = System.Drawing.Color.Transparent
        Me.lblPromedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromedio.Location = New System.Drawing.Point(539, 261)
        Me.lblPromedio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPromedio.Name = "lblPromedio"
        Me.lblPromedio.Size = New System.Drawing.Size(227, 31)
        Me.lblPromedio.TabIndex = 15
        Me.lblPromedio.Text = "- Promedio Final -" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblPromedioFF
        '
        Me.lblPromedioFF.AutoSize = True
        Me.lblPromedioFF.BackColor = System.Drawing.Color.Transparent
        Me.lblPromedioFF.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromedioFF.Location = New System.Drawing.Point(631, 311)
        Me.lblPromedioFF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPromedioFF.Name = "lblPromedioFF"
        Me.lblPromedioFF.Size = New System.Drawing.Size(60, 42)
        Me.lblPromedioFF.TabIndex = 16
        Me.lblPromedioFF.Text = "##"
        Me.lblPromedioFF.Visible = False
        '
        'lblDescu
        '
        Me.lblDescu.AutoSize = True
        Me.lblDescu.BackColor = System.Drawing.Color.Transparent
        Me.lblDescu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescu.Location = New System.Drawing.Point(522, 375)
        Me.lblDescu.Name = "lblDescu"
        Me.lblDescu.Size = New System.Drawing.Size(268, 29)
        Me.lblDescu.TabIndex = 17
        Me.lblDescu.Text = "- Descuento obtenido -"
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.BackColor = System.Drawing.Color.Transparent
        Me.lblDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuento.Location = New System.Drawing.Point(630, 419)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(62, 44)
        Me.lblDescuento.TabIndex = 18
        Me.lblDescuento.Text = "##"
        Me.lblDescuento.Visible = False
        '
        'frmPromedio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.BackgroundImage = Global.Promedio.My.Resources.Resources.fondo_gris
        Me.ClientSize = New System.Drawing.Size(829, 493)
        Me.Controls.Add(Me.lblDescuento)
        Me.Controls.Add(Me.lblDescu)
        Me.Controls.Add(Me.lblPromedioFF)
        Me.Controls.Add(Me.lblPromedio)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblPonderacion)
        Me.Controls.Add(Me.lblCalificaciones)
        Me.Controls.Add(Me.txtFinalP)
        Me.Controls.Add(Me.txtParcialP)
        Me.Controls.Add(Me.lblFinalP)
        Me.Controls.Add(Me.lblParcialP)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtParcial3)
        Me.Controls.Add(Me.txtParcial2)
        Me.Controls.Add(Me.txtParcial1)
        Me.Controls.Add(Me.lblParcial3)
        Me.Controls.Add(Me.lblParcial2)
        Me.Controls.Add(Me.lblParcial1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmPromedio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Promedio de Calificaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblParcial1 As Label
    Friend WithEvents lblParcial2 As Label
    Friend WithEvents lblParcial3 As Label
    Friend WithEvents txtParcial1 As TextBox
    Friend WithEvents txtParcial2 As TextBox
    Friend WithEvents txtParcial3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFinal As TextBox
    Friend WithEvents lblParcialP As Label
    Friend WithEvents lblFinalP As Label
    Friend WithEvents txtParcialP As TextBox
    Friend WithEvents txtFinalP As TextBox
    Friend WithEvents lblCalificaciones As Label
    Friend WithEvents lblPonderacion As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lblPromedio As Label
    Friend WithEvents lblPromedioFF As Label
    Friend WithEvents lblDescu As Label
    Friend WithEvents lblDescuento As Label
End Class
