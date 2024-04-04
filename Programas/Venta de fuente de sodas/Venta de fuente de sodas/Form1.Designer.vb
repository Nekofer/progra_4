<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuenteSodas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFuenteSodas))
        Me.lblNombreLocal = New System.Windows.Forms.Label()
        Me.lblPizzaSelection = New System.Windows.Forms.Label()
        Me.chkPizza1 = New System.Windows.Forms.CheckBox()
        Me.chkPizza2 = New System.Windows.Forms.CheckBox()
        Me.chkPizza3 = New System.Windows.Forms.CheckBox()
        Me.chkPizza4 = New System.Windows.Forms.CheckBox()
        Me.lblPrecioPizza = New System.Windows.Forms.Label()
        Me.lblPizza2 = New System.Windows.Forms.Label()
        Me.lblPizza1 = New System.Windows.Forms.Label()
        Me.lblPizza3 = New System.Windows.Forms.Label()
        Me.lblPizza4 = New System.Windows.Forms.Label()
        Me.chkBebida1 = New System.Windows.Forms.CheckBox()
        Me.lblBebidas = New System.Windows.Forms.Label()
        Me.chkBebida2 = New System.Windows.Forms.CheckBox()
        Me.chkBebida3 = New System.Windows.Forms.CheckBox()
        Me.lblPrecioBebida = New System.Windows.Forms.Label()
        Me.lblBebida1 = New System.Windows.Forms.Label()
        Me.lblBebida2 = New System.Windows.Forms.Label()
        Me.lblBedida3 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lblTotalFake = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNombreLocal
        '
        Me.lblNombreLocal.AutoSize = True
        Me.lblNombreLocal.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreLocal.Font = New System.Drawing.Font("Brush Script MT", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreLocal.ForeColor = System.Drawing.Color.Gold
        Me.lblNombreLocal.Location = New System.Drawing.Point(368, 34)
        Me.lblNombreLocal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreLocal.Name = "lblNombreLocal"
        Me.lblNombreLocal.Size = New System.Drawing.Size(377, 73)
        Me.lblNombreLocal.TabIndex = 0
        Me.lblNombreLocal.Text = "- il vento d'oro -"
        '
        'lblPizzaSelection
        '
        Me.lblPizzaSelection.AutoSize = True
        Me.lblPizzaSelection.BackColor = System.Drawing.Color.Transparent
        Me.lblPizzaSelection.Font = New System.Drawing.Font("Brush Script MT", 28.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPizzaSelection.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lblPizzaSelection.Location = New System.Drawing.Point(12, 116)
        Me.lblPizzaSelection.Name = "lblPizzaSelection"
        Me.lblPizzaSelection.Size = New System.Drawing.Size(181, 59)
        Me.lblPizzaSelection.TabIndex = 2
        Me.lblPizzaSelection.Text = "- Pizzas:"
        '
        'chkPizza1
        '
        Me.chkPizza1.AutoSize = True
        Me.chkPizza1.BackColor = System.Drawing.Color.Transparent
        Me.chkPizza1.Font = New System.Drawing.Font("Brush Script MT", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPizza1.ForeColor = System.Drawing.Color.Red
        Me.chkPizza1.Location = New System.Drawing.Point(55, 195)
        Me.chkPizza1.Name = "chkPizza1"
        Me.chkPizza1.Size = New System.Drawing.Size(174, 54)
        Me.chkPizza1.TabIndex = 3
        Me.chkPizza1.Text = "Pepperoni"
        Me.chkPizza1.UseVisualStyleBackColor = False
        '
        'chkPizza2
        '
        Me.chkPizza2.AutoSize = True
        Me.chkPizza2.BackColor = System.Drawing.Color.Transparent
        Me.chkPizza2.Font = New System.Drawing.Font("Brush Script MT", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPizza2.ForeColor = System.Drawing.Color.Red
        Me.chkPizza2.Location = New System.Drawing.Point(55, 255)
        Me.chkPizza2.Name = "chkPizza2"
        Me.chkPizza2.Size = New System.Drawing.Size(183, 54)
        Me.chkPizza2.TabIndex = 4
        Me.chkPizza2.Text = "Margarita"
        Me.chkPizza2.UseVisualStyleBackColor = False
        '
        'chkPizza3
        '
        Me.chkPizza3.AutoSize = True
        Me.chkPizza3.BackColor = System.Drawing.Color.Transparent
        Me.chkPizza3.Font = New System.Drawing.Font("Brush Script MT", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPizza3.ForeColor = System.Drawing.Color.Red
        Me.chkPizza3.Location = New System.Drawing.Point(55, 315)
        Me.chkPizza3.Name = "chkPizza3"
        Me.chkPizza3.Size = New System.Drawing.Size(153, 54)
        Me.chkPizza3.TabIndex = 5
        Me.chkPizza3.Text = "Italiana"
        Me.chkPizza3.UseVisualStyleBackColor = False
        '
        'chkPizza4
        '
        Me.chkPizza4.AutoSize = True
        Me.chkPizza4.BackColor = System.Drawing.Color.Transparent
        Me.chkPizza4.Font = New System.Drawing.Font("Brush Script MT", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPizza4.ForeColor = System.Drawing.Color.Red
        Me.chkPizza4.Location = New System.Drawing.Point(55, 375)
        Me.chkPizza4.Name = "chkPizza4"
        Me.chkPizza4.Size = New System.Drawing.Size(189, 54)
        Me.chkPizza4.TabIndex = 6
        Me.chkPizza4.Text = "Franchesca"
        Me.chkPizza4.UseVisualStyleBackColor = False
        '
        'lblPrecioPizza
        '
        Me.lblPrecioPizza.AutoSize = True
        Me.lblPrecioPizza.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecioPizza.Font = New System.Drawing.Font("Brush Script MT", 28.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioPizza.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lblPrecioPizza.Location = New System.Drawing.Point(259, 116)
        Me.lblPrecioPizza.Name = "lblPrecioPizza"
        Me.lblPrecioPizza.Size = New System.Drawing.Size(191, 59)
        Me.lblPrecioPizza.TabIndex = 7
        Me.lblPrecioPizza.Text = "- Precios:"
        '
        'lblPizza2
        '
        Me.lblPizza2.AutoSize = True
        Me.lblPizza2.BackColor = System.Drawing.Color.Transparent
        Me.lblPizza2.Font = New System.Drawing.Font("Brush Script MT", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPizza2.ForeColor = System.Drawing.Color.Red
        Me.lblPizza2.Location = New System.Drawing.Point(325, 255)
        Me.lblPizza2.Name = "lblPizza2"
        Me.lblPizza2.Size = New System.Drawing.Size(87, 50)
        Me.lblPizza2.TabIndex = 8
        Me.lblPizza2.Text = "$ 49"
        '
        'lblPizza1
        '
        Me.lblPizza1.AutoSize = True
        Me.lblPizza1.BackColor = System.Drawing.Color.Transparent
        Me.lblPizza1.Font = New System.Drawing.Font("Brush Script MT", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPizza1.ForeColor = System.Drawing.Color.Red
        Me.lblPizza1.Location = New System.Drawing.Point(325, 195)
        Me.lblPizza1.Name = "lblPizza1"
        Me.lblPizza1.Size = New System.Drawing.Size(87, 50)
        Me.lblPizza1.TabIndex = 9
        Me.lblPizza1.Text = "$ 59"
        '
        'lblPizza3
        '
        Me.lblPizza3.AutoSize = True
        Me.lblPizza3.BackColor = System.Drawing.Color.Transparent
        Me.lblPizza3.Font = New System.Drawing.Font("Brush Script MT", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPizza3.ForeColor = System.Drawing.Color.Red
        Me.lblPizza3.Location = New System.Drawing.Point(325, 319)
        Me.lblPizza3.Name = "lblPizza3"
        Me.lblPizza3.Size = New System.Drawing.Size(87, 50)
        Me.lblPizza3.TabIndex = 10
        Me.lblPizza3.Text = "$ 69"
        '
        'lblPizza4
        '
        Me.lblPizza4.AutoSize = True
        Me.lblPizza4.BackColor = System.Drawing.Color.Transparent
        Me.lblPizza4.Font = New System.Drawing.Font("Brush Script MT", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPizza4.ForeColor = System.Drawing.Color.Red
        Me.lblPizza4.Location = New System.Drawing.Point(325, 379)
        Me.lblPizza4.Name = "lblPizza4"
        Me.lblPizza4.Size = New System.Drawing.Size(87, 50)
        Me.lblPizza4.TabIndex = 11
        Me.lblPizza4.Text = "$ 79"
        '
        'chkBebida1
        '
        Me.chkBebida1.AutoSize = True
        Me.chkBebida1.BackColor = System.Drawing.Color.Transparent
        Me.chkBebida1.Font = New System.Drawing.Font("Brush Script MT", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBebida1.ForeColor = System.Drawing.Color.Red
        Me.chkBebida1.Location = New System.Drawing.Point(537, 195)
        Me.chkBebida1.Name = "chkBebida1"
        Me.chkBebida1.Size = New System.Drawing.Size(191, 54)
        Me.chkBebida1.TabIndex = 12
        Me.chkBebida1.Text = "Coca-Cola"
        Me.chkBebida1.UseVisualStyleBackColor = False
        '
        'lblBebidas
        '
        Me.lblBebidas.AutoSize = True
        Me.lblBebidas.BackColor = System.Drawing.Color.Transparent
        Me.lblBebidas.Font = New System.Drawing.Font("Brush Script MT", 28.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBebidas.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lblBebidas.Location = New System.Drawing.Point(494, 116)
        Me.lblBebidas.Name = "lblBebidas"
        Me.lblBebidas.Size = New System.Drawing.Size(199, 59)
        Me.lblBebidas.TabIndex = 13
        Me.lblBebidas.Text = "- Bebidas:"
        '
        'chkBebida2
        '
        Me.chkBebida2.AutoSize = True
        Me.chkBebida2.BackColor = System.Drawing.Color.Transparent
        Me.chkBebida2.Font = New System.Drawing.Font("Brush Script MT", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBebida2.ForeColor = System.Drawing.Color.Red
        Me.chkBebida2.Location = New System.Drawing.Point(537, 255)
        Me.chkBebida2.Name = "chkBebida2"
        Me.chkBebida2.Size = New System.Drawing.Size(236, 54)
        Me.chkBebida2.TabIndex = 14
        Me.chkBebida2.Text = "Soda Italiana"
        Me.chkBebida2.UseVisualStyleBackColor = False
        '
        'chkBebida3
        '
        Me.chkBebida3.AutoSize = True
        Me.chkBebida3.BackColor = System.Drawing.Color.Transparent
        Me.chkBebida3.Font = New System.Drawing.Font("Brush Script MT", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBebida3.ForeColor = System.Drawing.Color.Red
        Me.chkBebida3.Location = New System.Drawing.Point(537, 315)
        Me.chkBebida3.Name = "chkBebida3"
        Me.chkBebida3.Size = New System.Drawing.Size(115, 54)
        Me.chkBebida3.TabIndex = 15
        Me.chkBebida3.Text = "Agua"
        Me.chkBebida3.UseVisualStyleBackColor = False
        '
        'lblPrecioBebida
        '
        Me.lblPrecioBebida.AutoSize = True
        Me.lblPrecioBebida.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecioBebida.Font = New System.Drawing.Font("Brush Script MT", 28.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioBebida.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lblPrecioBebida.Location = New System.Drawing.Point(790, 116)
        Me.lblPrecioBebida.Name = "lblPrecioBebida"
        Me.lblPrecioBebida.Size = New System.Drawing.Size(191, 59)
        Me.lblPrecioBebida.TabIndex = 7
        Me.lblPrecioBebida.Text = "- Precios:"
        '
        'lblBebida1
        '
        Me.lblBebida1.AutoSize = True
        Me.lblBebida1.BackColor = System.Drawing.Color.Transparent
        Me.lblBebida1.Font = New System.Drawing.Font("Brush Script MT", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBebida1.ForeColor = System.Drawing.Color.Red
        Me.lblBebida1.Location = New System.Drawing.Point(864, 195)
        Me.lblBebida1.Name = "lblBebida1"
        Me.lblBebida1.Size = New System.Drawing.Size(80, 50)
        Me.lblBebida1.TabIndex = 9
        Me.lblBebida1.Text = "$ 17"
        '
        'lblBebida2
        '
        Me.lblBebida2.AutoSize = True
        Me.lblBebida2.BackColor = System.Drawing.Color.Transparent
        Me.lblBebida2.Font = New System.Drawing.Font("Brush Script MT", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBebida2.ForeColor = System.Drawing.Color.Red
        Me.lblBebida2.Location = New System.Drawing.Point(864, 255)
        Me.lblBebida2.Name = "lblBebida2"
        Me.lblBebida2.Size = New System.Drawing.Size(88, 50)
        Me.lblBebida2.TabIndex = 8
        Me.lblBebida2.Text = "$ 20"
        '
        'lblBedida3
        '
        Me.lblBedida3.AutoSize = True
        Me.lblBedida3.BackColor = System.Drawing.Color.Transparent
        Me.lblBedida3.Font = New System.Drawing.Font("Brush Script MT", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBedida3.ForeColor = System.Drawing.Color.Red
        Me.lblBedida3.Location = New System.Drawing.Point(864, 319)
        Me.lblBedida3.Name = "lblBedida3"
        Me.lblBedida3.Size = New System.Drawing.Size(81, 50)
        Me.lblBedida3.TabIndex = 10
        Me.lblBedida3.Text = "$ 10"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptar.Font = New System.Drawing.Font("Brush Script MT", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(186, 464)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(155, 58)
        Me.btnAceptar.TabIndex = 16
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Brush Script MT", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(398, 464)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(155, 58)
        Me.btnLimpiar.TabIndex = 17
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'lblTotalFake
        '
        Me.lblTotalFake.AutoSize = True
        Me.lblTotalFake.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalFake.Font = New System.Drawing.Font("Brush Script MT", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFake.ForeColor = System.Drawing.Color.Gold
        Me.lblTotalFake.Location = New System.Drawing.Point(639, 404)
        Me.lblTotalFake.Name = "lblTotalFake"
        Me.lblTotalFake.Size = New System.Drawing.Size(106, 50)
        Me.lblTotalFake.TabIndex = 18
        Me.lblTotalFake.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Brush Script MT", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Gold
        Me.lblTotal.Location = New System.Drawing.Point(768, 404)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(70, 50)
        Me.lblTotal.TabIndex = 19
        Me.lblTotal.Text = "##"
        Me.lblTotal.Visible = False
        '
        'frmFuenteSodas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Venta_de_fuente_de_sodas.My.Resources.Resources._367143_landscape
        Me.ClientSize = New System.Drawing.Size(1023, 552)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTotalFake)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.chkBebida3)
        Me.Controls.Add(Me.chkBebida2)
        Me.Controls.Add(Me.lblBebidas)
        Me.Controls.Add(Me.chkBebida1)
        Me.Controls.Add(Me.lblPizza4)
        Me.Controls.Add(Me.lblBedida3)
        Me.Controls.Add(Me.lblPizza3)
        Me.Controls.Add(Me.lblBebida1)
        Me.Controls.Add(Me.lblPizza1)
        Me.Controls.Add(Me.lblBebida2)
        Me.Controls.Add(Me.lblPizza2)
        Me.Controls.Add(Me.lblPrecioBebida)
        Me.Controls.Add(Me.lblPrecioPizza)
        Me.Controls.Add(Me.chkPizza4)
        Me.Controls.Add(Me.chkPizza3)
        Me.Controls.Add(Me.chkPizza2)
        Me.Controls.Add(Me.chkPizza1)
        Me.Controls.Add(Me.lblPizzaSelection)
        Me.Controls.Add(Me.lblNombreLocal)
        Me.Font = New System.Drawing.Font("Brush Script MT", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmFuenteSodas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pizzeria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombreLocal As Label
    Friend WithEvents lblPizzaSelection As Label
    Friend WithEvents chkPizza1 As CheckBox
    Friend WithEvents chkPizza2 As CheckBox
    Friend WithEvents chkPizza3 As CheckBox
    Friend WithEvents chkPizza4 As CheckBox
    Friend WithEvents lblPrecioPizza As Label
    Friend WithEvents lblPizza2 As Label
    Friend WithEvents lblPizza1 As Label
    Friend WithEvents lblPizza3 As Label
    Friend WithEvents lblPizza4 As Label
    Friend WithEvents chkBebida1 As CheckBox
    Friend WithEvents lblBebidas As Label
    Friend WithEvents chkBebida2 As CheckBox
    Friend WithEvents chkBebida3 As CheckBox
    Friend WithEvents lblPrecioBebida As Label
    Friend WithEvents lblBebida1 As Label
    Friend WithEvents lblBebida2 As Label
    Friend WithEvents lblBedida3 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lblTotalFake As Label
    Friend WithEvents lblTotal As Label
End Class
