<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarEstudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarEstudiante))
        Me.lblnombresestudiantes = New System.Windows.Forms.Label()
        Me.txtnombresestudiantes = New System.Windows.Forms.TextBox()
        Me.lblapellidosestudiantes = New System.Windows.Forms.Label()
        Me.txtapellidosestudiantes = New System.Windows.Forms.TextBox()
        Me.lblcedulaidentidadestudiante = New System.Windows.Forms.Label()
        Me.txtcedulaidentidadestudiante = New System.Windows.Forms.TextBox()
        Me.lblfechanacimientoestudiante = New System.Windows.Forms.Label()
        Me.txtfechanacimientoestudiantedia = New System.Windows.Forms.TextBox()
        Me.txtfechanacimientoestudiantemes = New System.Windows.Forms.TextBox()
        Me.txtfechanacimientoestudianteanio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbldireccionestudiante = New System.Windows.Forms.Label()
        Me.txtdireccionestudiante = New System.Windows.Forms.TextBox()
        Me.lbltelefonoemergencia1 = New System.Windows.Forms.Label()
        Me.txttelefonoemergencia1 = New System.Windows.Forms.TextBox()
        Me.lbltelefonoemergencia2 = New System.Windows.Forms.Label()
        Me.txttelefonoemergencia2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbcursoalquesedirige = New System.Windows.Forms.ComboBox()
        Me.lblnombresrepresentante = New System.Windows.Forms.Label()
        Me.txtnombresrepresentantes = New System.Windows.Forms.TextBox()
        Me.lblapellidosrepresentante = New System.Windows.Forms.Label()
        Me.txtapellidosrepresentante = New System.Windows.Forms.TextBox()
        Me.piciconoestudiante = New System.Windows.Forms.PictureBox()
        Me.btnguardarestudiante = New System.Windows.Forms.Button()
        Me.btncancelarregistroestudiante = New System.Windows.Forms.Button()
        Me.btnmenuprincipalestudiante = New System.Windows.Forms.Button()
        Me.lblparentesco = New System.Windows.Forms.Label()
        Me.cmbparentescoestudiante = New System.Windows.Forms.ComboBox()
        CType(Me.piciconoestudiante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblnombresestudiantes
        '
        Me.lblnombresestudiantes.AutoSize = True
        Me.lblnombresestudiantes.Location = New System.Drawing.Point(36, 82)
        Me.lblnombresestudiantes.Name = "lblnombresestudiantes"
        Me.lblnombresestudiantes.Size = New System.Drawing.Size(65, 17)
        Me.lblnombresestudiantes.TabIndex = 0
        Me.lblnombresestudiantes.Text = "Nombres"
        '
        'txtnombresestudiantes
        '
        Me.txtnombresestudiantes.Location = New System.Drawing.Point(107, 79)
        Me.txtnombresestudiantes.Name = "txtnombresestudiantes"
        Me.txtnombresestudiantes.Size = New System.Drawing.Size(358, 22)
        Me.txtnombresestudiantes.TabIndex = 1
        '
        'lblapellidosestudiantes
        '
        Me.lblapellidosestudiantes.AutoSize = True
        Me.lblapellidosestudiantes.Location = New System.Drawing.Point(36, 129)
        Me.lblapellidosestudiantes.Name = "lblapellidosestudiantes"
        Me.lblapellidosestudiantes.Size = New System.Drawing.Size(65, 17)
        Me.lblapellidosestudiantes.TabIndex = 2
        Me.lblapellidosestudiantes.Text = "Apellidos"
        '
        'txtapellidosestudiantes
        '
        Me.txtapellidosestudiantes.Location = New System.Drawing.Point(107, 129)
        Me.txtapellidosestudiantes.Name = "txtapellidosestudiantes"
        Me.txtapellidosestudiantes.Size = New System.Drawing.Size(358, 22)
        Me.txtapellidosestudiantes.TabIndex = 3
        '
        'lblcedulaidentidadestudiante
        '
        Me.lblcedulaidentidadestudiante.AutoSize = True
        Me.lblcedulaidentidadestudiante.Location = New System.Drawing.Point(36, 34)
        Me.lblcedulaidentidadestudiante.Name = "lblcedulaidentidadestudiante"
        Me.lblcedulaidentidadestudiante.Size = New System.Drawing.Size(142, 17)
        Me.lblcedulaidentidadestudiante.TabIndex = 4
        Me.lblcedulaidentidadestudiante.Text = "Cedula de Indentidad"
        '
        'txtcedulaidentidadestudiante
        '
        Me.txtcedulaidentidadestudiante.Location = New System.Drawing.Point(195, 31)
        Me.txtcedulaidentidadestudiante.Name = "txtcedulaidentidadestudiante"
        Me.txtcedulaidentidadestudiante.Size = New System.Drawing.Size(270, 22)
        Me.txtcedulaidentidadestudiante.TabIndex = 5
        '
        'lblfechanacimientoestudiante
        '
        Me.lblfechanacimientoestudiante.AutoSize = True
        Me.lblfechanacimientoestudiante.Location = New System.Drawing.Point(36, 182)
        Me.lblfechanacimientoestudiante.Name = "lblfechanacimientoestudiante"
        Me.lblfechanacimientoestudiante.Size = New System.Drawing.Size(141, 17)
        Me.lblfechanacimientoestudiante.TabIndex = 8
        Me.lblfechanacimientoestudiante.Text = "Fecha de Nacimiento"
        '
        'txtfechanacimientoestudiantedia
        '
        Me.txtfechanacimientoestudiantedia.ForeColor = System.Drawing.Color.Black
        Me.txtfechanacimientoestudiantedia.Location = New System.Drawing.Point(183, 182)
        Me.txtfechanacimientoestudiantedia.Name = "txtfechanacimientoestudiantedia"
        Me.txtfechanacimientoestudiantedia.Size = New System.Drawing.Size(69, 22)
        Me.txtfechanacimientoestudiantedia.TabIndex = 9
        Me.txtfechanacimientoestudiantedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtfechanacimientoestudiantemes
        '
        Me.txtfechanacimientoestudiantemes.ForeColor = System.Drawing.Color.Black
        Me.txtfechanacimientoestudiantemes.Location = New System.Drawing.Point(276, 182)
        Me.txtfechanacimientoestudiantemes.Name = "txtfechanacimientoestudiantemes"
        Me.txtfechanacimientoestudiantemes.Size = New System.Drawing.Size(66, 22)
        Me.txtfechanacimientoestudiantemes.TabIndex = 10
        Me.txtfechanacimientoestudiantemes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtfechanacimientoestudianteanio
        '
        Me.txtfechanacimientoestudianteanio.ForeColor = System.Drawing.Color.Black
        Me.txtfechanacimientoestudianteanio.Location = New System.Drawing.Point(366, 182)
        Me.txtfechanacimientoestudianteanio.Name = "txtfechanacimientoestudianteanio"
        Me.txtfechanacimientoestudianteanio.Size = New System.Drawing.Size(99, 22)
        Me.txtfechanacimientoestudianteanio.TabIndex = 11
        Me.txtfechanacimientoestudianteanio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(258, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "/"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(348, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "/"
        '
        'lbldireccionestudiante
        '
        Me.lbldireccionestudiante.AutoSize = True
        Me.lbldireccionestudiante.Location = New System.Drawing.Point(36, 235)
        Me.lbldireccionestudiante.Name = "lbldireccionestudiante"
        Me.lbldireccionestudiante.Size = New System.Drawing.Size(147, 17)
        Me.lbldireccionestudiante.TabIndex = 14
        Me.lbldireccionestudiante.Text = "Dirección de Domicilio"
        '
        'txtdireccionestudiante
        '
        Me.txtdireccionestudiante.Location = New System.Drawing.Point(189, 232)
        Me.txtdireccionestudiante.Name = "txtdireccionestudiante"
        Me.txtdireccionestudiante.Size = New System.Drawing.Size(276, 22)
        Me.txtdireccionestudiante.TabIndex = 15
        '
        'lbltelefonoemergencia1
        '
        Me.lbltelefonoemergencia1.AutoSize = True
        Me.lbltelefonoemergencia1.Location = New System.Drawing.Point(36, 297)
        Me.lbltelefonoemergencia1.Name = "lbltelefonoemergencia1"
        Me.lbltelefonoemergencia1.Size = New System.Drawing.Size(174, 17)
        Me.lbltelefonoemergencia1.TabIndex = 16
        Me.lbltelefonoemergencia1.Text = "Telefono de emergencia 1"
        '
        'txttelefonoemergencia1
        '
        Me.txttelefonoemergencia1.Location = New System.Drawing.Point(228, 294)
        Me.txttelefonoemergencia1.Name = "txttelefonoemergencia1"
        Me.txttelefonoemergencia1.Size = New System.Drawing.Size(237, 22)
        Me.txttelefonoemergencia1.TabIndex = 17
        '
        'lbltelefonoemergencia2
        '
        Me.lbltelefonoemergencia2.AutoSize = True
        Me.lbltelefonoemergencia2.Location = New System.Drawing.Point(36, 360)
        Me.lbltelefonoemergencia2.Name = "lbltelefonoemergencia2"
        Me.lbltelefonoemergencia2.Size = New System.Drawing.Size(179, 17)
        Me.lbltelefonoemergencia2.TabIndex = 18
        Me.lbltelefonoemergencia2.Text = "Teléfono de Emergencia 2 "
        '
        'txttelefonoemergencia2
        '
        Me.txttelefonoemergencia2.Location = New System.Drawing.Point(228, 360)
        Me.txttelefonoemergencia2.Name = "txttelefonoemergencia2"
        Me.txttelefonoemergencia2.Size = New System.Drawing.Size(237, 22)
        Me.txttelefonoemergencia2.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 415)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Curso al que se dirige"
        '
        'cmbcursoalquesedirige
        '
        Me.cmbcursoalquesedirige.FormattingEnabled = True
        Me.cmbcursoalquesedirige.Items.AddRange(New Object() {"8vo", "9no", "10mo", "1ro Bachillerato" & Global.Microsoft.VisualBasic.ChrW(9), "2do Bachillerato", "3ro Bachillerato"})
        Me.cmbcursoalquesedirige.Location = New System.Drawing.Point(228, 412)
        Me.cmbcursoalquesedirige.Name = "cmbcursoalquesedirige"
        Me.cmbcursoalquesedirige.Size = New System.Drawing.Size(185, 24)
        Me.cmbcursoalquesedirige.TabIndex = 21
        Me.cmbcursoalquesedirige.Text = "Curso"
        '
        'lblnombresrepresentante
        '
        Me.lblnombresrepresentante.AutoSize = True
        Me.lblnombresrepresentante.Location = New System.Drawing.Point(36, 515)
        Me.lblnombresrepresentante.Name = "lblnombresrepresentante"
        Me.lblnombresrepresentante.Size = New System.Drawing.Size(186, 17)
        Me.lblnombresrepresentante.TabIndex = 22
        Me.lblnombresrepresentante.Text = "Nombres del Representante"
        '
        'txtnombresrepresentantes
        '
        Me.txtnombresrepresentantes.Location = New System.Drawing.Point(230, 512)
        Me.txtnombresrepresentantes.Name = "txtnombresrepresentantes"
        Me.txtnombresrepresentantes.Size = New System.Drawing.Size(235, 22)
        Me.txtnombresrepresentantes.TabIndex = 23
        '
        'lblapellidosrepresentante
        '
        Me.lblapellidosrepresentante.AutoSize = True
        Me.lblapellidosrepresentante.Location = New System.Drawing.Point(36, 561)
        Me.lblapellidosrepresentante.Name = "lblapellidosrepresentante"
        Me.lblapellidosrepresentante.Size = New System.Drawing.Size(186, 17)
        Me.lblapellidosrepresentante.TabIndex = 24
        Me.lblapellidosrepresentante.Text = "Apellidos del Representante"
        '
        'txtapellidosrepresentante
        '
        Me.txtapellidosrepresentante.Location = New System.Drawing.Point(228, 558)
        Me.txtapellidosrepresentante.Name = "txtapellidosrepresentante"
        Me.txtapellidosrepresentante.Size = New System.Drawing.Size(237, 22)
        Me.txtapellidosrepresentante.TabIndex = 25
        '
        'piciconoestudiante
        '
        Me.piciconoestudiante.Image = CType(resources.GetObject("piciconoestudiante.Image"), System.Drawing.Image)
        Me.piciconoestudiante.Location = New System.Drawing.Point(639, 89)
        Me.piciconoestudiante.Name = "piciconoestudiante"
        Me.piciconoestudiante.Size = New System.Drawing.Size(250, 227)
        Me.piciconoestudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piciconoestudiante.TabIndex = 26
        Me.piciconoestudiante.TabStop = False
        '
        'btnguardarestudiante
        '
        Me.btnguardarestudiante.Location = New System.Drawing.Point(621, 375)
        Me.btnguardarestudiante.Name = "btnguardarestudiante"
        Me.btnguardarestudiante.Size = New System.Drawing.Size(118, 57)
        Me.btnguardarestudiante.TabIndex = 27
        Me.btnguardarestudiante.Text = "Guardar Registro"
        Me.btnguardarestudiante.UseVisualStyleBackColor = True
        '
        'btncancelarregistroestudiante
        '
        Me.btncancelarregistroestudiante.Location = New System.Drawing.Point(782, 375)
        Me.btncancelarregistroestudiante.Name = "btncancelarregistroestudiante"
        Me.btncancelarregistroestudiante.Size = New System.Drawing.Size(118, 57)
        Me.btncancelarregistroestudiante.TabIndex = 28
        Me.btncancelarregistroestudiante.Text = "Cancelar Registro"
        Me.btncancelarregistroestudiante.UseVisualStyleBackColor = True
        '
        'btnmenuprincipalestudiante
        '
        Me.btnmenuprincipalestudiante.Location = New System.Drawing.Point(626, 451)
        Me.btnmenuprincipalestudiante.Name = "btnmenuprincipalestudiante"
        Me.btnmenuprincipalestudiante.Size = New System.Drawing.Size(273, 31)
        Me.btnmenuprincipalestudiante.TabIndex = 29
        Me.btnmenuprincipalestudiante.Text = "Menú Principal"
        Me.btnmenuprincipalestudiante.UseVisualStyleBackColor = True
        '
        'lblparentesco
        '
        Me.lblparentesco.AutoSize = True
        Me.lblparentesco.Location = New System.Drawing.Point(36, 603)
        Me.lblparentesco.Name = "lblparentesco"
        Me.lblparentesco.Size = New System.Drawing.Size(80, 17)
        Me.lblparentesco.TabIndex = 30
        Me.lblparentesco.Text = "Parentesco"
        '
        'cmbparentescoestudiante
        '
        Me.cmbparentescoestudiante.FormattingEnabled = True
        Me.cmbparentescoestudiante.Items.AddRange(New Object() {"Padres", "Hermanos", "Tíos", "Primos", "Abuelos", "Sin grado de Consanguinidad"})
        Me.cmbparentescoestudiante.Location = New System.Drawing.Point(183, 596)
        Me.cmbparentescoestudiante.Name = "cmbparentescoestudiante"
        Me.cmbparentescoestudiante.Size = New System.Drawing.Size(282, 24)
        Me.cmbparentescoestudiante.TabIndex = 31
        Me.cmbparentescoestudiante.Text = "Seleccionar Grado de Parentesco"
        '
        'AgregarEstudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(994, 657)
        Me.Controls.Add(Me.cmbparentescoestudiante)
        Me.Controls.Add(Me.lblparentesco)
        Me.Controls.Add(Me.btnmenuprincipalestudiante)
        Me.Controls.Add(Me.btncancelarregistroestudiante)
        Me.Controls.Add(Me.btnguardarestudiante)
        Me.Controls.Add(Me.piciconoestudiante)
        Me.Controls.Add(Me.txtapellidosrepresentante)
        Me.Controls.Add(Me.lblapellidosrepresentante)
        Me.Controls.Add(Me.txtnombresrepresentantes)
        Me.Controls.Add(Me.lblnombresrepresentante)
        Me.Controls.Add(Me.cmbcursoalquesedirige)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttelefonoemergencia2)
        Me.Controls.Add(Me.lbltelefonoemergencia2)
        Me.Controls.Add(Me.txttelefonoemergencia1)
        Me.Controls.Add(Me.lbltelefonoemergencia1)
        Me.Controls.Add(Me.txtdireccionestudiante)
        Me.Controls.Add(Me.lbldireccionestudiante)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfechanacimientoestudianteanio)
        Me.Controls.Add(Me.txtfechanacimientoestudiantemes)
        Me.Controls.Add(Me.txtfechanacimientoestudiantedia)
        Me.Controls.Add(Me.lblfechanacimientoestudiante)
        Me.Controls.Add(Me.txtcedulaidentidadestudiante)
        Me.Controls.Add(Me.lblcedulaidentidadestudiante)
        Me.Controls.Add(Me.txtapellidosestudiantes)
        Me.Controls.Add(Me.lblapellidosestudiantes)
        Me.Controls.Add(Me.txtnombresestudiantes)
        Me.Controls.Add(Me.lblnombresestudiantes)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "AgregarEstudiante"
        Me.Text = "AgregarEstudiante"
        CType(Me.piciconoestudiante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnombresestudiantes As Label
    Friend WithEvents txtnombresestudiantes As TextBox
    Friend WithEvents lblapellidosestudiantes As Label
    Friend WithEvents txtapellidosestudiantes As TextBox
    Friend WithEvents lblcedulaidentidadestudiante As Label
    Friend WithEvents txtcedulaidentidadestudiante As TextBox
    Friend WithEvents lblfechanacimientoestudiante As Label
    Friend WithEvents txtfechanacimientoestudiantedia As TextBox
    Friend WithEvents txtfechanacimientoestudiantemes As TextBox
    Friend WithEvents txtfechanacimientoestudianteanio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbldireccionestudiante As Label
    Friend WithEvents txtdireccionestudiante As TextBox
    Friend WithEvents lbltelefonoemergencia1 As Label
    Friend WithEvents txttelefonoemergencia1 As TextBox
    Friend WithEvents lbltelefonoemergencia2 As Label
    Friend WithEvents txttelefonoemergencia2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbcursoalquesedirige As ComboBox
    Friend WithEvents lblnombresrepresentante As Label
    Friend WithEvents txtnombresrepresentantes As TextBox
    Friend WithEvents lblapellidosrepresentante As Label
    Friend WithEvents txtapellidosrepresentante As TextBox
    Friend WithEvents piciconoestudiante As PictureBox
    Friend WithEvents btnguardarestudiante As Button
    Friend WithEvents btncancelarregistroestudiante As Button
    Friend WithEvents btnmenuprincipalestudiante As Button
    Friend WithEvents lblparentesco As Label
    Friend WithEvents cmbparentescoestudiante As ComboBox
End Class
