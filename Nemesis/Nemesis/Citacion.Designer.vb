<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Citacion
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
        Me.lblfechareporte = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpelaboracioncitacion = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechacitacion = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdetalle = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblfechareporte
        '
        Me.lblfechareporte.AutoSize = True
        Me.lblfechareporte.Location = New System.Drawing.Point(21, 27)
        Me.lblfechareporte.Name = "lblfechareporte"
        Me.lblfechareporte.Size = New System.Drawing.Size(232, 17)
        Me.lblfechareporte.TabIndex = 0
        Me.lblfechareporte.Text = "Fecha de elaboración de la citación"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Dirigido a "
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(99, 74)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(273, 22)
        Me.TextBox4.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Estudiante"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(99, 131)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(273, 22)
        Me.TextBox5.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fecha citación"
        '
        'dtpelaboracioncitacion
        '
        Me.dtpelaboracioncitacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpelaboracioncitacion.Location = New System.Drawing.Point(260, 27)
        Me.dtpelaboracioncitacion.Name = "dtpelaboracioncitacion"
        Me.dtpelaboracioncitacion.Size = New System.Drawing.Size(112, 22)
        Me.dtpelaboracioncitacion.TabIndex = 11
        Me.dtpelaboracioncitacion.Value = New Date(2020, 1, 1, 0, 0, 0, 0)
        '
        'dtpfechacitacion
        '
        Me.dtpfechacitacion.CustomFormat = "dd / mm / yyyy -  HH:mm "
        Me.dtpfechacitacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfechacitacion.Location = New System.Drawing.Point(127, 192)
        Me.dtpfechacitacion.Name = "dtpfechacitacion"
        Me.dtpfechacitacion.Size = New System.Drawing.Size(244, 22)
        Me.dtpfechacitacion.TabIndex = 12
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Bajo Rendimiento Académico", "Conducta", "Inasistencia", "Otros"})
        Me.ComboBox1.Location = New System.Drawing.Point(99, 248)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(153, 24)
        Me.ComboBox1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Razón"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Detalle"
        '
        'txtdetalle
        '
        Me.txtdetalle.Location = New System.Drawing.Point(102, 310)
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.Size = New System.Drawing.Size(269, 22)
        Me.txtdetalle.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 48)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Generar Citación"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(232, 373)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 48)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 455)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtdetalle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.dtpfechacitacion)
        Me.Controls.Add(Me.dtpelaboracioncitacion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblfechareporte)
        Me.Name = "Reporte"
        Me.Text = "Generar Citación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblfechareporte As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpelaboracioncitacion As DateTimePicker
    Friend WithEvents dtpfechacitacion As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdetalle As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
