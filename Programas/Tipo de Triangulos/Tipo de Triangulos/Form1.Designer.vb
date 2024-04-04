<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTriangulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTriangulo))
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtLado1 = New System.Windows.Forms.TextBox()
        Me.lblLado1 = New System.Windows.Forms.Label()
        Me.lblLado2 = New System.Windows.Forms.Label()
        Me.lblLado3 = New System.Windows.Forms.Label()
        Me.txtLado2 = New System.Windows.Forms.TextBox()
        Me.txtLado3 = New System.Windows.Forms.TextBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lblFirma = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.picTriangulo = New System.Windows.Forms.PictureBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTriangulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(84, 292)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(160, 44)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtLado1
        '
        Me.txtLado1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLado1.Location = New System.Drawing.Point(192, 49)
        Me.txtLado1.Name = "txtLado1"
        Me.txtLado1.Size = New System.Drawing.Size(151, 38)
        Me.txtLado1.TabIndex = 1
        '
        'lblLado1
        '
        Me.lblLado1.AutoSize = True
        Me.lblLado1.BackColor = System.Drawing.Color.Transparent
        Me.lblLado1.Font = New System.Drawing.Font("Consolas", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLado1.Location = New System.Drawing.Point(64, 53)
        Me.lblLado1.Name = "lblLado1"
        Me.lblLado1.Size = New System.Drawing.Size(120, 33)
        Me.lblLado1.TabIndex = 2
        Me.lblLado1.Text = "Lado 1:"
        '
        'lblLado2
        '
        Me.lblLado2.AutoSize = True
        Me.lblLado2.BackColor = System.Drawing.Color.Transparent
        Me.lblLado2.Font = New System.Drawing.Font("Consolas", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLado2.Location = New System.Drawing.Point(64, 123)
        Me.lblLado2.Name = "lblLado2"
        Me.lblLado2.Size = New System.Drawing.Size(120, 33)
        Me.lblLado2.TabIndex = 2
        Me.lblLado2.Text = "Lado 2:"
        '
        'lblLado3
        '
        Me.lblLado3.AutoSize = True
        Me.lblLado3.BackColor = System.Drawing.Color.Transparent
        Me.lblLado3.Font = New System.Drawing.Font("Consolas", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLado3.Location = New System.Drawing.Point(64, 191)
        Me.lblLado3.Name = "lblLado3"
        Me.lblLado3.Size = New System.Drawing.Size(120, 33)
        Me.lblLado3.TabIndex = 2
        Me.lblLado3.Text = "Lado 3:"
        '
        'txtLado2
        '
        Me.txtLado2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLado2.Location = New System.Drawing.Point(192, 119)
        Me.txtLado2.Name = "txtLado2"
        Me.txtLado2.Size = New System.Drawing.Size(151, 38)
        Me.txtLado2.TabIndex = 1
        '
        'txtLado3
        '
        Me.txtLado3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLado3.Location = New System.Drawing.Point(192, 187)
        Me.txtLado3.Name = "txtLado3"
        Me.txtLado3.Size = New System.Drawing.Size(151, 38)
        Me.txtLado3.TabIndex = 1
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.BackColor = System.Drawing.Color.Transparent
        Me.lblResultado.Font = New System.Drawing.Font("Consolas", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(413, 337)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(45, 33)
        Me.lblResultado.TabIndex = 3
        Me.lblResultado.Text = "##"
        Me.lblResultado.Visible = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(84, 371)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(160, 44)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'lblFirma
        '
        Me.lblFirma.AutoSize = True
        Me.lblFirma.BackColor = System.Drawing.Color.Transparent
        Me.lblFirma.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirma.Location = New System.Drawing.Point(608, 420)
        Me.lblFirma.Name = "lblFirma"
        Me.lblFirma.Size = New System.Drawing.Size(128, 62)
        Me.lblFirma.TabIndex = 5
        Me.lblFirma.Text = "20/03/2020" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "By: Ferlock_"
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = Global.Tipo_de_Triangulos.My.Resources.Resources.KyubiF
        Me.picLogo.Location = New System.Drawing.Point(742, 418)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(77, 64)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 6
        Me.picLogo.TabStop = False
        '
        'picTriangulo
        '
        Me.picTriangulo.BackColor = System.Drawing.Color.Transparent
        Me.picTriangulo.Location = New System.Drawing.Point(493, 49)
        Me.picTriangulo.Name = "picTriangulo"
        Me.picTriangulo.Size = New System.Drawing.Size(243, 232)
        Me.picTriangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTriangulo.TabIndex = 7
        Me.picTriangulo.TabStop = False
        '
        'frmTriangulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tipo_de_Triangulos.My.Resources.Resources._4_min
        Me.ClientSize = New System.Drawing.Size(826, 491)
        Me.Controls.Add(Me.picTriangulo)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblFirma)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblLado3)
        Me.Controls.Add(Me.lblLado2)
        Me.Controls.Add(Me.lblLado1)
        Me.Controls.Add(Me.txtLado3)
        Me.Controls.Add(Me.txtLado2)
        Me.Controls.Add(Me.txtLado1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTriangulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Triangulo"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTriangulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtLado1 As TextBox
    Friend WithEvents lblLado1 As Label
    Friend WithEvents lblLado2 As Label
    Friend WithEvents lblLado3 As Label
    Friend WithEvents txtLado2 As TextBox
    Friend WithEvents txtLado3 As TextBox
    Friend WithEvents lblResultado As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lblFirma As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents picTriangulo As PictureBox
End Class
