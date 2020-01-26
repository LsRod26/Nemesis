<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaginaPrincipal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnagregarestudiantes = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnagregardocentes = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(363, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 0
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.Location = New System.Drawing.Point(150, 273)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(100, 46)
        Me.lblhora.TabIndex = 2
        Me.lblhora.Text = "hora"
        Me.lblhora.UseMnemonic = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.Enabled = False
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(27, 531)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1015, 25)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Nemesis V.1.0"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnagregarestudiantes
        '
        Me.btnagregarestudiantes.BackColor = System.Drawing.SystemColors.Control
        Me.btnagregarestudiantes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnagregarestudiantes.Location = New System.Drawing.Point(445, 68)
        Me.btnagregarestudiantes.Name = "btnagregarestudiantes"
        Me.btnagregarestudiantes.Size = New System.Drawing.Size(160, 130)
        Me.btnagregarestudiantes.TabIndex = 4
        Me.btnagregarestudiantes.Text = "AGREGAR ESTUDIANTES"
        Me.btnagregarestudiantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnagregarestudiantes.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.SystemColors.Control
        Me.btneditar.Location = New System.Drawing.Point(445, 220)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(253, 191)
        Me.btneditar.TabIndex = 5
        Me.btneditar.Text = "EDITAR"
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(750, 220)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(262, 191)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "CITACIÓN"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnagregardocentes
        '
        Me.btnagregardocentes.BackColor = System.Drawing.SystemColors.Control
        Me.btnagregardocentes.Location = New System.Drawing.Point(647, 68)
        Me.btnagregardocentes.Name = "btnagregardocentes"
        Me.btnagregardocentes.Size = New System.Drawing.Size(160, 130)
        Me.btnagregardocentes.TabIndex = 7
        Me.btnagregardocentes.Text = "AGREGAR DOCENTES"
        Me.btnagregardocentes.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(852, 68)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 130)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "AGREGAR REPRESENTANTE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.Location = New System.Drawing.Point(112, 206)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(168, 51)
        Me.lblfecha.TabIndex = 9
        Me.lblfecha.Text = "FECHA"
        '
        'PaginaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1068, 567)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnagregardocentes)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.btnagregarestudiantes)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PaginaPrincipal"
        Me.Text = "Nemesis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblhora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents btnagregarestudiantes As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnagregardocentes As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblfecha As Label
End Class
