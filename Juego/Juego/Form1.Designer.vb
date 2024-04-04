<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Juego
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Juego))
        Me.btnAdelante = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnAbajo = New System.Windows.Forms.Button()
        Me.btnDetente = New System.Windows.Forms.Button()
        Me.pctImagenGif = New System.Windows.Forms.PictureBox()
        Me.tmrAdelante = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAtras = New System.Windows.Forms.Timer(Me.components)
        Me.tmrArriba = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAbajo = New System.Windows.Forms.Timer(Me.components)
        Me.btnArriba = New System.Windows.Forms.Button()
        Me.pctArriba = New System.Windows.Forms.PictureBox()
        Me.pctAbajo = New System.Windows.Forms.PictureBox()
        Me.pctAtras = New System.Windows.Forms.PictureBox()
        Me.pctAdelante = New System.Windows.Forms.PictureBox()
        Me.pctDetente = New System.Windows.Forms.PictureBox()
        Me.tmrTurbo = New System.Windows.Forms.Timer(Me.components)
        Me.pctTurbo = New System.Windows.Forms.PictureBox()
        Me.btnJugar = New System.Windows.Forms.Button()
        CType(Me.pctImagenGif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctArriba, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctAbajo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctAtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctAdelante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctDetente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctTurbo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdelante
        '
        Me.btnAdelante.Location = New System.Drawing.Point(1004, 568)
        Me.btnAdelante.Name = "btnAdelante"
        Me.btnAdelante.Size = New System.Drawing.Size(75, 23)
        Me.btnAdelante.TabIndex = 0
        Me.btnAdelante.Text = "ADELANTE"
        Me.btnAdelante.UseVisualStyleBackColor = True
        Me.btnAdelante.Visible = False
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(869, 568)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(75, 23)
        Me.btnAtras.TabIndex = 1
        Me.btnAtras.Text = "ATRÁS"
        Me.btnAtras.UseVisualStyleBackColor = True
        Me.btnAtras.Visible = False
        '
        'btnAbajo
        '
        Me.btnAbajo.Location = New System.Drawing.Point(940, 580)
        Me.btnAbajo.Name = "btnAbajo"
        Me.btnAbajo.Size = New System.Drawing.Size(75, 23)
        Me.btnAbajo.TabIndex = 3
        Me.btnAbajo.Text = "ABAJO"
        Me.btnAbajo.UseVisualStyleBackColor = True
        Me.btnAbajo.Visible = False
        '
        'btnDetente
        '
        Me.btnDetente.Location = New System.Drawing.Point(940, 568)
        Me.btnDetente.Name = "btnDetente"
        Me.btnDetente.Size = New System.Drawing.Size(75, 23)
        Me.btnDetente.TabIndex = 4
        Me.btnDetente.Text = "DETENTE"
        Me.btnDetente.UseVisualStyleBackColor = True
        Me.btnDetente.Visible = False
        '
        'pctImagenGif
        '
        Me.pctImagenGif.BackColor = System.Drawing.Color.Transparent
        Me.pctImagenGif.Image = CType(resources.GetObject("pctImagenGif.Image"), System.Drawing.Image)
        Me.pctImagenGif.Location = New System.Drawing.Point(0, 464)
        Me.pctImagenGif.Name = "pctImagenGif"
        Me.pctImagenGif.Size = New System.Drawing.Size(167, 139)
        Me.pctImagenGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctImagenGif.TabIndex = 5
        Me.pctImagenGif.TabStop = False
        '
        'tmrAdelante
        '
        Me.tmrAdelante.Interval = 1
        '
        'tmrAtras
        '
        Me.tmrAtras.Interval = 1
        '
        'tmrArriba
        '
        Me.tmrArriba.Interval = 1
        '
        'tmrAbajo
        '
        Me.tmrAbajo.Interval = 1
        '
        'btnArriba
        '
        Me.btnArriba.Location = New System.Drawing.Point(940, 551)
        Me.btnArriba.Name = "btnArriba"
        Me.btnArriba.Size = New System.Drawing.Size(75, 23)
        Me.btnArriba.TabIndex = 2
        Me.btnArriba.Text = "ARRIBA"
        Me.btnArriba.UseVisualStyleBackColor = True
        Me.btnArriba.Visible = False
        '
        'pctArriba
        '
        Me.pctArriba.BackColor = System.Drawing.Color.Transparent
        Me.pctArriba.Image = CType(resources.GetObject("pctArriba.Image"), System.Drawing.Image)
        Me.pctArriba.Location = New System.Drawing.Point(720, 4)
        Me.pctArriba.Name = "pctArriba"
        Me.pctArriba.Size = New System.Drawing.Size(51, 48)
        Me.pctArriba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctArriba.TabIndex = 6
        Me.pctArriba.TabStop = False
        '
        'pctAbajo
        '
        Me.pctAbajo.BackColor = System.Drawing.Color.Transparent
        Me.pctAbajo.Image = CType(resources.GetObject("pctAbajo.Image"), System.Drawing.Image)
        Me.pctAbajo.Location = New System.Drawing.Point(720, 58)
        Me.pctAbajo.Name = "pctAbajo"
        Me.pctAbajo.Size = New System.Drawing.Size(53, 50)
        Me.pctAbajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctAbajo.TabIndex = 7
        Me.pctAbajo.TabStop = False
        '
        'pctAtras
        '
        Me.pctAtras.BackColor = System.Drawing.Color.Transparent
        Me.pctAtras.Image = CType(resources.GetObject("pctAtras.Image"), System.Drawing.Image)
        Me.pctAtras.Location = New System.Drawing.Point(665, 29)
        Me.pctAtras.Name = "pctAtras"
        Me.pctAtras.Size = New System.Drawing.Size(49, 54)
        Me.pctAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctAtras.TabIndex = 8
        Me.pctAtras.TabStop = False
        '
        'pctAdelante
        '
        Me.pctAdelante.BackColor = System.Drawing.Color.Transparent
        Me.pctAdelante.Image = CType(resources.GetObject("pctAdelante.Image"), System.Drawing.Image)
        Me.pctAdelante.Location = New System.Drawing.Point(779, 29)
        Me.pctAdelante.Name = "pctAdelante"
        Me.pctAdelante.Size = New System.Drawing.Size(55, 54)
        Me.pctAdelante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctAdelante.TabIndex = 9
        Me.pctAdelante.TabStop = False
        '
        'pctDetente
        '
        Me.pctDetente.BackColor = System.Drawing.Color.Transparent
        Me.pctDetente.Image = CType(resources.GetObject("pctDetente.Image"), System.Drawing.Image)
        Me.pctDetente.Location = New System.Drawing.Point(780, 89)
        Me.pctDetente.Name = "pctDetente"
        Me.pctDetente.Size = New System.Drawing.Size(54, 48)
        Me.pctDetente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctDetente.TabIndex = 10
        Me.pctDetente.TabStop = False
        '
        'tmrTurbo
        '
        Me.tmrTurbo.Interval = 1
        '
        'pctTurbo
        '
        Me.pctTurbo.BackColor = System.Drawing.Color.Transparent
        Me.pctTurbo.Image = CType(resources.GetObject("pctTurbo.Image"), System.Drawing.Image)
        Me.pctTurbo.Location = New System.Drawing.Point(616, 81)
        Me.pctTurbo.Name = "pctTurbo"
        Me.pctTurbo.Size = New System.Drawing.Size(100, 50)
        Me.pctTurbo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctTurbo.TabIndex = 11
        Me.pctTurbo.TabStop = False
        '
        'btnJugar
        '
        Me.btnJugar.BackColor = System.Drawing.Color.Red
        Me.btnJugar.Font = New System.Drawing.Font("Tempus Sans ITC", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJugar.ForeColor = System.Drawing.Color.Yellow
        Me.btnJugar.Location = New System.Drawing.Point(217, 160)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(463, 280)
        Me.btnJugar.TabIndex = 12
        Me.btnJugar.Text = "Jugar"
        Me.btnJugar.UseVisualStyleBackColor = False
        '
        'Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(873, 603)
        Me.Controls.Add(Me.btnJugar)
        Me.Controls.Add(Me.pctTurbo)
        Me.Controls.Add(Me.pctDetente)
        Me.Controls.Add(Me.pctAdelante)
        Me.Controls.Add(Me.pctAtras)
        Me.Controls.Add(Me.pctAbajo)
        Me.Controls.Add(Me.pctArriba)
        Me.Controls.Add(Me.pctImagenGif)
        Me.Controls.Add(Me.btnDetente)
        Me.Controls.Add(Me.btnAbajo)
        Me.Controls.Add(Me.btnArriba)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnAdelante)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Juego"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Juego"
        CType(Me.pctImagenGif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctArriba, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctAbajo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctAtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctAdelante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctDetente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctTurbo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAdelante As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnAbajo As System.Windows.Forms.Button
    Friend WithEvents btnDetente As System.Windows.Forms.Button
    Friend WithEvents pctImagenGif As System.Windows.Forms.PictureBox
    Friend WithEvents tmrAdelante As System.Windows.Forms.Timer
    Friend WithEvents tmrAtras As System.Windows.Forms.Timer
    Friend WithEvents tmrArriba As System.Windows.Forms.Timer
    Friend WithEvents tmrAbajo As System.Windows.Forms.Timer
    Friend WithEvents btnArriba As System.Windows.Forms.Button
    Friend WithEvents pctArriba As System.Windows.Forms.PictureBox
    Friend WithEvents pctAbajo As System.Windows.Forms.PictureBox
    Friend WithEvents pctAtras As System.Windows.Forms.PictureBox
    Friend WithEvents pctAdelante As System.Windows.Forms.PictureBox
    Friend WithEvents pctDetente As System.Windows.Forms.PictureBox
    Friend WithEvents tmrTurbo As System.Windows.Forms.Timer
    Friend WithEvents pctTurbo As System.Windows.Forms.PictureBox
    Friend WithEvents btnJugar As System.Windows.Forms.Button

End Class
