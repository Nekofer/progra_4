<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnAlto = New System.Windows.Forms.Button()
        Me.btnIzquierda = New System.Windows.Forms.Button()
        Me.btnAbajo = New System.Windows.Forms.Button()
        Me.btnDerecha = New System.Windows.Forms.Button()
        Me.btnArriba = New System.Windows.Forms.Button()
        Me.picPelota = New System.Windows.Forms.PictureBox()
        Me.tmrArriba = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAbajo = New System.Windows.Forms.Timer(Me.components)
        Me.tmrIzquierda = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDerecha = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picPelota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAlto
        '
        Me.btnAlto.BackColor = System.Drawing.Color.OrangeRed
        Me.btnAlto.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAlto.Location = New System.Drawing.Point(12, 22)
        Me.btnAlto.Name = "btnAlto"
        Me.btnAlto.Size = New System.Drawing.Size(112, 40)
        Me.btnAlto.TabIndex = 0
        Me.btnAlto.Text = "ALTO"
        Me.btnAlto.UseVisualStyleBackColor = False
        '
        'btnIzquierda
        '
        Me.btnIzquierda.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnIzquierda.Font = New System.Drawing.Font("Showcard Gothic", 12.0!)
        Me.btnIzquierda.Location = New System.Drawing.Point(26, 133)
        Me.btnIzquierda.Name = "btnIzquierda"
        Me.btnIzquierda.Size = New System.Drawing.Size(112, 40)
        Me.btnIzquierda.TabIndex = 1
        Me.btnIzquierda.Text = "IZQUIERDA"
        Me.btnIzquierda.UseVisualStyleBackColor = False
        '
        'btnAbajo
        '
        Me.btnAbajo.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnAbajo.Font = New System.Drawing.Font("Showcard Gothic", 12.0!)
        Me.btnAbajo.Location = New System.Drawing.Point(255, 245)
        Me.btnAbajo.Name = "btnAbajo"
        Me.btnAbajo.Size = New System.Drawing.Size(112, 40)
        Me.btnAbajo.TabIndex = 2
        Me.btnAbajo.Text = "ABAJO"
        Me.btnAbajo.UseVisualStyleBackColor = False
        '
        'btnDerecha
        '
        Me.btnDerecha.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnDerecha.Font = New System.Drawing.Font("Showcard Gothic", 12.0!)
        Me.btnDerecha.Location = New System.Drawing.Point(484, 133)
        Me.btnDerecha.Name = "btnDerecha"
        Me.btnDerecha.Size = New System.Drawing.Size(112, 40)
        Me.btnDerecha.TabIndex = 3
        Me.btnDerecha.Text = "DERECHA"
        Me.btnDerecha.UseVisualStyleBackColor = False
        '
        'btnArriba
        '
        Me.btnArriba.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnArriba.Font = New System.Drawing.Font("Showcard Gothic", 12.0!)
        Me.btnArriba.Location = New System.Drawing.Point(255, 22)
        Me.btnArriba.Name = "btnArriba"
        Me.btnArriba.Size = New System.Drawing.Size(112, 40)
        Me.btnArriba.TabIndex = 4
        Me.btnArriba.Text = "ARRIBA"
        Me.btnArriba.UseVisualStyleBackColor = False
        '
        'picPelota
        '
        Me.picPelota.BackColor = System.Drawing.Color.Transparent
        Me.picPelota.Image = CType(resources.GetObject("picPelota.Image"), System.Drawing.Image)
        Me.picPelota.Location = New System.Drawing.Point(267, 115)
        Me.picPelota.Name = "picPelota"
        Me.picPelota.Size = New System.Drawing.Size(84, 83)
        Me.picPelota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPelota.TabIndex = 5
        Me.picPelota.TabStop = False
        '
        'tmrArriba
        '
        Me.tmrArriba.Interval = 1
        '
        'tmrAbajo
        '
        Me.tmrAbajo.Interval = 1
        '
        'tmrIzquierda
        '
        Me.tmrIzquierda.Interval = 1
        '
        'tmrDerecha
        '
        Me.tmrDerecha.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(622, 308)
        Me.Controls.Add(Me.picPelota)
        Me.Controls.Add(Me.btnArriba)
        Me.Controls.Add(Me.btnDerecha)
        Me.Controls.Add(Me.btnAbajo)
        Me.Controls.Add(Me.btnIzquierda)
        Me.Controls.Add(Me.btnAlto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Basquetball"
        CType(Me.picPelota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAlto As Button
    Friend WithEvents btnIzquierda As Button
    Friend WithEvents btnAbajo As Button
    Friend WithEvents btnDerecha As Button
    Friend WithEvents btnArriba As Button
    Friend WithEvents picPelota As PictureBox
    Friend WithEvents tmrArriba As Timer
    Friend WithEvents tmrAbajo As Timer
    Friend WithEvents tmrIzquierda As Timer
    Friend WithEvents tmrDerecha As Timer
End Class
