<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editar
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
        Me.lblnombresapellidosbuscar = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtapellidosabuscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnombresresultantes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtapellidosresultantes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtfechanacimientoresultante = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdireccionresultante = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttelefonoresultante = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblnombresapellidosbuscar
        '
        Me.lblnombresapellidosbuscar.AutoSize = True
        Me.lblnombresapellidosbuscar.Location = New System.Drawing.Point(26, 35)
        Me.lblnombresapellidosbuscar.Name = "lblnombresapellidosbuscar"
        Me.lblnombresapellidosbuscar.Size = New System.Drawing.Size(73, 17)
        Me.lblnombresapellidosbuscar.TabIndex = 0
        Me.lblnombresapellidosbuscar.Text = " Nombres "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(95, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(326, 22)
        Me.TextBox1.TabIndex = 1
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(889, 31)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(106, 24)
        Me.btnbuscar.TabIndex = 2
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(446, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Apeliidos"
        '
        'txtapellidosabuscar
        '
        Me.txtapellidosabuscar.Location = New System.Drawing.Point(517, 33)
        Me.txtapellidosabuscar.Name = "txtapellidosabuscar"
        Me.txtapellidosabuscar.Size = New System.Drawing.Size(339, 22)
        Me.txtapellidosabuscar.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "RESULTADO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombres"
        '
        'txtnombresresultantes
        '
        Me.txtnombresresultantes.Location = New System.Drawing.Point(109, 141)
        Me.txtnombresresultantes.Name = "txtnombresresultantes"
        Me.txtnombresresultantes.Size = New System.Drawing.Size(312, 22)
        Me.txtnombresresultantes.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(446, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Apellidos"
        '
        'txtapellidosresultantes
        '
        Me.txtapellidosresultantes.Location = New System.Drawing.Point(517, 141)
        Me.txtapellidosresultantes.Name = "txtapellidosresultantes"
        Me.txtapellidosresultantes.Size = New System.Drawing.Size(339, 22)
        Me.txtapellidosresultantes.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fecha de Nacimiento"
        '
        'txtfechanacimientoresultante
        '
        Me.txtfechanacimientoresultante.Location = New System.Drawing.Point(185, 205)
        Me.txtfechanacimientoresultante.Name = "txtfechanacimientoresultante"
        Me.txtfechanacimientoresultante.Size = New System.Drawing.Size(236, 22)
        Me.txtfechanacimientoresultante.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(446, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Dirección de Domicilio"
        '
        'txtdireccionresultante
        '
        Me.txtdireccionresultante.Location = New System.Drawing.Point(599, 205)
        Me.txtdireccionresultante.Name = "txtdireccionresultante"
        Me.txtdireccionresultante.Size = New System.Drawing.Size(257, 22)
        Me.txtdireccionresultante.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Teléfono de Contacto"
        '
        'txttelefonoresultante
        '
        Me.txttelefonoresultante.Location = New System.Drawing.Point(213, 271)
        Me.txttelefonoresultante.Name = "txttelefonoresultante"
        Me.txttelefonoresultante.Size = New System.Drawing.Size(208, 22)
        Me.txttelefonoresultante.TabIndex = 15
        '
        'Editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 331)
        Me.Controls.Add(Me.txttelefonoresultante)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtdireccionresultante)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtfechanacimientoresultante)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtapellidosresultantes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnombresresultantes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtapellidosabuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblnombresapellidosbuscar)
        Me.Name = "Editar"
        Me.Text = "Editar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnombresapellidosbuscar As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtapellidosabuscar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnombresresultantes As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtapellidosresultantes As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtfechanacimientoresultante As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdireccionresultante As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txttelefonoresultante As TextBox
End Class
