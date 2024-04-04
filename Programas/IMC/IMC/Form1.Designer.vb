<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIMC
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIMC))
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.lblOp2 = New System.Windows.Forms.Label()
        Me.lblOp1 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.picSeñal = New System.Windows.Forms.PictureBox()
        Me.picIMC = New System.Windows.Forms.PictureBox()
        Me.lblFirma = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picSeñal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIMC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.BackColor = System.Drawing.Color.Transparent
        Me.lblPeso.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeso.Location = New System.Drawing.Point(52, 83)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(107, 25)
        Me.lblPeso.TabIndex = 0
        Me.lblPeso.Text = "Peso (Kg)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Altura (m)"
        '
        'txtPeso
        '
        Me.txtPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.Location = New System.Drawing.Point(190, 80)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(126, 31)
        Me.txtPeso.TabIndex = 2
        '
        'txtAltura
        '
        Me.txtAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAltura.Location = New System.Drawing.Point(190, 127)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(126, 31)
        Me.txtAltura.TabIndex = 3
        '
        'lblOp2
        '
        Me.lblOp2.AutoSize = True
        Me.lblOp2.BackColor = System.Drawing.Color.Transparent
        Me.lblOp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOp2.Location = New System.Drawing.Point(163, 131)
        Me.lblOp2.Name = "lblOp2"
        Me.lblOp2.Size = New System.Drawing.Size(21, 24)
        Me.lblOp2.TabIndex = 4
        Me.lblOp2.Text = "="
        '
        'lblOp1
        '
        Me.lblOp1.AutoSize = True
        Me.lblOp1.BackColor = System.Drawing.Color.Transparent
        Me.lblOp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOp1.Location = New System.Drawing.Point(163, 84)
        Me.lblOp1.Name = "lblOp1"
        Me.lblOp1.Size = New System.Drawing.Size(21, 24)
        Me.lblOp1.TabIndex = 4
        Me.lblOp1.Text = "="
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCalcular.Location = New System.Drawing.Point(91, 209)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(112, 44)
        Me.btnCalcular.TabIndex = 5
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(91, 279)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(112, 44)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.BackColor = System.Drawing.Color.Transparent
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(106, 414)
        Me.lblResultado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(53, 37)
        Me.lblResultado.TabIndex = 9
        Me.lblResultado.Text = "##"
        Me.lblResultado.Visible = False
        '
        'picSeñal
        '
        Me.picSeñal.BackColor = System.Drawing.Color.Transparent
        Me.picSeñal.ErrorImage = CType(resources.GetObject("picSeñal.ErrorImage"), System.Drawing.Image)
        Me.picSeñal.Image = CType(resources.GetObject("picSeñal.Image"), System.Drawing.Image)
        Me.picSeñal.InitialImage = CType(resources.GetObject("picSeñal.InitialImage"), System.Drawing.Image)
        Me.picSeñal.Location = New System.Drawing.Point(260, 414)
        Me.picSeñal.Margin = New System.Windows.Forms.Padding(2)
        Me.picSeñal.Name = "picSeñal"
        Me.picSeñal.Size = New System.Drawing.Size(109, 109)
        Me.picSeñal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSeñal.TabIndex = 8
        Me.picSeñal.TabStop = False
        Me.picSeñal.Visible = False
        '
        'picIMC
        '
        Me.picIMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picIMC.ErrorImage = CType(resources.GetObject("picIMC.ErrorImage"), System.Drawing.Image)
        Me.picIMC.Image = CType(resources.GetObject("picIMC.Image"), System.Drawing.Image)
        Me.picIMC.InitialImage = CType(resources.GetObject("picIMC.InitialImage"), System.Drawing.Image)
        Me.picIMC.Location = New System.Drawing.Point(369, 10)
        Me.picIMC.Margin = New System.Windows.Forms.Padding(2)
        Me.picIMC.Name = "picIMC"
        Me.picIMC.Size = New System.Drawing.Size(592, 399)
        Me.picIMC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIMC.TabIndex = 7
        Me.picIMC.TabStop = False
        '
        'lblFirma
        '
        Me.lblFirma.AutoSize = True
        Me.lblFirma.BackColor = System.Drawing.Color.Transparent
        Me.lblFirma.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirma.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFirma.Location = New System.Drawing.Point(789, 483)
        Me.lblFirma.Name = "lblFirma"
        Me.lblFirma.Size = New System.Drawing.Size(126, 50)
        Me.lblFirma.TabIndex = 10
        Me.lblFirma.Text = "09/03/2020" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "By: Ferlock_"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(911, 483)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'frmIMC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.BackgroundImage = Global.IMC.My.Resources.Resources.fondo_mamalon
        Me.ClientSize = New System.Drawing.Size(975, 542)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblFirma)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.picSeñal)
        Me.Controls.Add(Me.picIMC)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblOp1)
        Me.Controls.Add(Me.lblOp2)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPeso)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmIMC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMC"
        CType(Me.picSeñal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIMC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPeso As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents lblOp2 As Label
    Friend WithEvents lblOp1 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents picIMC As PictureBox
    Friend WithEvents picSeñal As PictureBox
    Friend WithEvents lblResultado As Label
    Friend WithEvents lblFirma As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
