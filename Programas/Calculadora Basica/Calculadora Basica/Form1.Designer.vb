<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalculadoraB
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
        Me.txtOp2 = New System.Windows.Forms.TextBox()
        Me.lblResul = New System.Windows.Forms.Label()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.btnDivi = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnExe = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblOperador = New System.Windows.Forms.Label()
        Me.txtOp1 = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtOp2
        '
        Me.txtOp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOp2.Location = New System.Drawing.Point(151, 37)
        Me.txtOp2.Name = "txtOp2"
        Me.txtOp2.Size = New System.Drawing.Size(75, 31)
        Me.txtOp2.TabIndex = 1
        '
        'lblResul
        '
        Me.lblResul.AutoSize = True
        Me.lblResul.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblResul.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResul.Location = New System.Drawing.Point(226, 38)
        Me.lblResul.Name = "lblResul"
        Me.lblResul.Size = New System.Drawing.Size(30, 31)
        Me.lblResul.TabIndex = 2
        Me.lblResul.Text = "="
        '
        'btnSuma
        '
        Me.btnSuma.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSuma.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnSuma.Location = New System.Drawing.Point(39, 111)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(32, 36)
        Me.btnSuma.TabIndex = 3
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = False
        '
        'btnResta
        '
        Me.btnResta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnResta.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnResta.Location = New System.Drawing.Point(77, 111)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(32, 36)
        Me.btnResta.TabIndex = 3
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = False
        '
        'btnMulti
        '
        Me.btnMulti.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMulti.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnMulti.Location = New System.Drawing.Point(115, 111)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(32, 36)
        Me.btnMulti.TabIndex = 3
        Me.btnMulti.Text = "x"
        Me.btnMulti.UseVisualStyleBackColor = False
        '
        'btnDivi
        '
        Me.btnDivi.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnDivi.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnDivi.Location = New System.Drawing.Point(39, 149)
        Me.btnDivi.Name = "btnDivi"
        Me.btnDivi.Size = New System.Drawing.Size(32, 36)
        Me.btnDivi.TabIndex = 3
        Me.btnDivi.Text = "/"
        Me.btnDivi.UseVisualStyleBackColor = False
        '
        'btnMod
        '
        Me.btnMod.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMod.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnMod.Location = New System.Drawing.Point(77, 149)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(32, 36)
        Me.btnMod.TabIndex = 3
        Me.btnMod.Text = "%"
        Me.btnMod.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Location = New System.Drawing.Point(321, 139)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 46)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnExe
        '
        Me.btnExe.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnExe.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnExe.Location = New System.Drawing.Point(164, 111)
        Me.btnExe.Name = "btnExe"
        Me.btnExe.Size = New System.Drawing.Size(45, 36)
        Me.btnExe.TabIndex = 3
        Me.btnExe.Text = "exe"
        Me.btnExe.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnClear.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnClear.Location = New System.Drawing.Point(164, 149)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(45, 36)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "clr"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblOperador
        '
        Me.lblOperador.AutoSize = True
        Me.lblOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperador.Location = New System.Drawing.Point(115, 39)
        Me.lblOperador.Name = "lblOperador"
        Me.lblOperador.Size = New System.Drawing.Size(33, 29)
        Me.lblOperador.TabIndex = 4
        Me.lblOperador.Text = " o"
        Me.lblOperador.Visible = False
        '
        'txtOp1
        '
        Me.txtOp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOp1.Location = New System.Drawing.Point(39, 37)
        Me.txtOp1.Name = "txtOp1"
        Me.txtOp1.Size = New System.Drawing.Size(75, 31)
        Me.txtOp1.TabIndex = 1
        '
        'txtResultado
        '
        Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.Location = New System.Drawing.Point(258, 38)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(106, 31)
        Me.txtResultado.TabIndex = 1
        '
        'FrmCalculadoraB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(418, 197)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblOperador)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnDivi)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExe)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.lblResul)
        Me.Controls.Add(Me.txtOp1)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtOp2)
        Me.Name = "FrmCalculadoraB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora Basica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOp2 As TextBox
    Friend WithEvents lblResul As Label
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnMulti As Button
    Friend WithEvents btnDivi As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnExe As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblOperador As Label
    Friend WithEvents txtOp1 As TextBox
    Friend WithEvents txtResultado As TextBox
End Class
