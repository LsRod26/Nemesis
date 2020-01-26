<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarRepresentante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarRepresentante))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblcedulaidentidadrepresentante = New System.Windows.Forms.Label()
        Me.txtcedulaidentidadrepresentante = New System.Windows.Forms.TextBox()
        Me.lblnombresrepresentante = New System.Windows.Forms.Label()
        Me.txtnombresrepresentantes = New System.Windows.Forms.TextBox()
        Me.lblapellidosrepresentantes = New System.Windows.Forms.Label()
        Me.txtapellidorepresentantes = New System.Windows.Forms.TextBox()
        Me.lblfechanacimientorepresentante = New System.Windows.Forms.Label()
        Me.txtfechanacimientorepresentantedia = New System.Windows.Forms.TextBox()
        Me.txtfechanacimientorepresentantemes = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdirecciondomiciliorepresentante = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.lbltelefonorepresentante = New System.Windows.Forms.Label()
        Me.txttelefonorepresentante = New System.Windows.Forms.TextBox()
        Me.lblprofesióndocente = New System.Windows.Forms.Label()
        Me.txtprofesionactualrepresentante = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnGuardarRegistroRepresentante = New System.Windows.Forms.Button()
        Me.btnCancearRegistroRepresentante = New System.Windows.Forms.Button()
        Me.btnmenuprincipalRepresentante = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(646, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 224)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblcedulaidentidadrepresentante
        '
        Me.lblcedulaidentidadrepresentante.AutoSize = True
        Me.lblcedulaidentidadrepresentante.Location = New System.Drawing.Point(36, 34)
        Me.lblcedulaidentidadrepresentante.Name = "lblcedulaidentidadrepresentante"
        Me.lblcedulaidentidadrepresentante.Size = New System.Drawing.Size(134, 17)
        Me.lblcedulaidentidadrepresentante.TabIndex = 1
        Me.lblcedulaidentidadrepresentante.Text = "Cedula de Identidad"
        '
        'txtcedulaidentidadrepresentante
        '
        Me.txtcedulaidentidadrepresentante.Location = New System.Drawing.Point(206, 29)
        Me.txtcedulaidentidadrepresentante.Name = "txtcedulaidentidadrepresentante"
        Me.txtcedulaidentidadrepresentante.Size = New System.Drawing.Size(292, 22)
        Me.txtcedulaidentidadrepresentante.TabIndex = 2
        '
        'lblnombresrepresentante
        '
        Me.lblnombresrepresentante.AutoSize = True
        Me.lblnombresrepresentante.Location = New System.Drawing.Point(36, 95)
        Me.lblnombresrepresentante.Name = "lblnombresrepresentante"
        Me.lblnombresrepresentante.Size = New System.Drawing.Size(65, 17)
        Me.lblnombresrepresentante.TabIndex = 3
        Me.lblnombresrepresentante.Text = "Nombres"
        '
        'txtnombresrepresentantes
        '
        Me.txtnombresrepresentantes.Location = New System.Drawing.Point(159, 90)
        Me.txtnombresrepresentantes.Name = "txtnombresrepresentantes"
        Me.txtnombresrepresentantes.Size = New System.Drawing.Size(339, 22)
        Me.txtnombresrepresentantes.TabIndex = 4
        '
        'lblapellidosrepresentantes
        '
        Me.lblapellidosrepresentantes.AutoSize = True
        Me.lblapellidosrepresentantes.Location = New System.Drawing.Point(36, 149)
        Me.lblapellidosrepresentantes.Name = "lblapellidosrepresentantes"
        Me.lblapellidosrepresentantes.Size = New System.Drawing.Size(65, 17)
        Me.lblapellidosrepresentantes.TabIndex = 5
        Me.lblapellidosrepresentantes.Text = "Apellidos"
        '
        'txtapellidorepresentantes
        '
        Me.txtapellidorepresentantes.Location = New System.Drawing.Point(159, 146)
        Me.txtapellidorepresentantes.Name = "txtapellidorepresentantes"
        Me.txtapellidorepresentantes.Size = New System.Drawing.Size(339, 22)
        Me.txtapellidorepresentantes.TabIndex = 6
        '
        'lblfechanacimientorepresentante
        '
        Me.lblfechanacimientorepresentante.AutoSize = True
        Me.lblfechanacimientorepresentante.Location = New System.Drawing.Point(36, 203)
        Me.lblfechanacimientorepresentante.Name = "lblfechanacimientorepresentante"
        Me.lblfechanacimientorepresentante.Size = New System.Drawing.Size(141, 17)
        Me.lblfechanacimientorepresentante.TabIndex = 7
        Me.lblfechanacimientorepresentante.Text = "Fecha de Nacimiento"
        '
        'txtfechanacimientorepresentantedia
        '
        Me.txtfechanacimientorepresentantedia.Location = New System.Drawing.Point(235, 200)
        Me.txtfechanacimientorepresentantedia.Name = "txtfechanacimientorepresentantedia"
        Me.txtfechanacimientorepresentantedia.Size = New System.Drawing.Size(55, 22)
        Me.txtfechanacimientorepresentantedia.TabIndex = 8
        '
        'txtfechanacimientorepresentantemes
        '
        Me.txtfechanacimientorepresentantemes.Location = New System.Drawing.Point(314, 200)
        Me.txtfechanacimientorepresentantemes.Name = "txtfechanacimientorepresentantemes"
        Me.txtfechanacimientorepresentantemes.Size = New System.Drawing.Size(66, 22)
        Me.txtfechanacimientorepresentantemes.TabIndex = 9
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(404, 200)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(94, 22)
        Me.TextBox6.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(296, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "/"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(386, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "/"
        '
        'txtdirecciondomiciliorepresentante
        '
        Me.txtdirecciondomiciliorepresentante.AutoSize = True
        Me.txtdirecciondomiciliorepresentante.Location = New System.Drawing.Point(36, 252)
        Me.txtdirecciondomiciliorepresentante.Name = "txtdirecciondomiciliorepresentante"
        Me.txtdirecciondomiciliorepresentante.Size = New System.Drawing.Size(147, 17)
        Me.txtdirecciondomiciliorepresentante.TabIndex = 13
        Me.txtdirecciondomiciliorepresentante.Text = "Dirección de Domicilio"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(183, 249)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(315, 22)
        Me.TextBox7.TabIndex = 14
        '
        'lbltelefonorepresentante
        '
        Me.lbltelefonorepresentante.AutoSize = True
        Me.lbltelefonorepresentante.Location = New System.Drawing.Point(36, 299)
        Me.lbltelefonorepresentante.Name = "lbltelefonorepresentante"
        Me.lbltelefonorepresentante.Size = New System.Drawing.Size(124, 17)
        Me.lbltelefonorepresentante.TabIndex = 15
        Me.lbltelefonorepresentante.Text = "Teléfono Contacto"
        '
        'txttelefonorepresentante
        '
        Me.txttelefonorepresentante.Location = New System.Drawing.Point(215, 294)
        Me.txttelefonorepresentante.Name = "txttelefonorepresentante"
        Me.txttelefonorepresentante.Size = New System.Drawing.Size(283, 22)
        Me.txttelefonorepresentante.TabIndex = 16
        '
        'lblprofesióndocente
        '
        Me.lblprofesióndocente.AutoSize = True
        Me.lblprofesióndocente.Location = New System.Drawing.Point(36, 349)
        Me.lblprofesióndocente.Name = "lblprofesióndocente"
        Me.lblprofesióndocente.Size = New System.Drawing.Size(111, 17)
        Me.lblprofesióndocente.TabIndex = 17
        Me.lblprofesióndocente.Text = "Profesión Actual"
        '
        'txtprofesionactualrepresentante
        '
        Me.txtprofesionactualrepresentante.Location = New System.Drawing.Point(214, 346)
        Me.txtprofesionactualrepresentante.Name = "txtprofesionactualrepresentante"
        Me.txtprofesionactualrepresentante.Size = New System.Drawing.Size(284, 22)
        Me.txtprofesionactualrepresentante.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 349)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 402)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Remuneración"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0 - 400", "401 - 700", "700 - 100", "1000 - En adelante"})
        Me.ComboBox1.Location = New System.Drawing.Point(183, 399)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(215, 24)
        Me.ComboBox1.TabIndex = 21
        '
        'btnGuardarRegistroRepresentante
        '
        Me.btnGuardarRegistroRepresentante.Location = New System.Drawing.Point(646, 324)
        Me.btnGuardarRegistroRepresentante.Name = "btnGuardarRegistroRepresentante"
        Me.btnGuardarRegistroRepresentante.Size = New System.Drawing.Size(118, 56)
        Me.btnGuardarRegistroRepresentante.TabIndex = 22
        Me.btnGuardarRegistroRepresentante.Text = "Guardar Registro"
        Me.btnGuardarRegistroRepresentante.UseVisualStyleBackColor = True
        '
        'btnCancearRegistroRepresentante
        '
        Me.btnCancearRegistroRepresentante.Location = New System.Drawing.Point(793, 324)
        Me.btnCancearRegistroRepresentante.Name = "btnCancearRegistroRepresentante"
        Me.btnCancearRegistroRepresentante.Size = New System.Drawing.Size(113, 56)
        Me.btnCancearRegistroRepresentante.TabIndex = 23
        Me.btnCancearRegistroRepresentante.Text = "Cancelar Registro"
        Me.btnCancearRegistroRepresentante.UseVisualStyleBackColor = True
        '
        'btnmenuprincipalRepresentante
        '
        Me.btnmenuprincipalRepresentante.Location = New System.Drawing.Point(647, 397)
        Me.btnmenuprincipalRepresentante.Name = "btnmenuprincipalRepresentante"
        Me.btnmenuprincipalRepresentante.Size = New System.Drawing.Size(258, 26)
        Me.btnmenuprincipalRepresentante.TabIndex = 24
        Me.btnmenuprincipalRepresentante.Text = "Menú Principal"
        Me.btnmenuprincipalRepresentante.UseVisualStyleBackColor = True
        '
        'AgregarRepresentante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 501)
        Me.Controls.Add(Me.btnmenuprincipalRepresentante)
        Me.Controls.Add(Me.btnCancearRegistroRepresentante)
        Me.Controls.Add(Me.btnGuardarRegistroRepresentante)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtprofesionactualrepresentante)
        Me.Controls.Add(Me.lblprofesióndocente)
        Me.Controls.Add(Me.txttelefonorepresentante)
        Me.Controls.Add(Me.lbltelefonorepresentante)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.txtdirecciondomiciliorepresentante)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.txtfechanacimientorepresentantemes)
        Me.Controls.Add(Me.txtfechanacimientorepresentantedia)
        Me.Controls.Add(Me.lblfechanacimientorepresentante)
        Me.Controls.Add(Me.txtapellidorepresentantes)
        Me.Controls.Add(Me.lblapellidosrepresentantes)
        Me.Controls.Add(Me.txtnombresrepresentantes)
        Me.Controls.Add(Me.lblnombresrepresentante)
        Me.Controls.Add(Me.txtcedulaidentidadrepresentante)
        Me.Controls.Add(Me.lblcedulaidentidadrepresentante)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AgregarRepresentante"
        Me.Text = "AgregarRepresentante"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblcedulaidentidadrepresentante As Label
    Friend WithEvents txtcedulaidentidadrepresentante As TextBox
    Friend WithEvents lblnombresrepresentante As Label
    Friend WithEvents txtnombresrepresentantes As TextBox
    Friend WithEvents lblapellidosrepresentantes As Label
    Friend WithEvents txtapellidorepresentantes As TextBox
    Friend WithEvents lblfechanacimientorepresentante As Label
    Friend WithEvents txtfechanacimientorepresentantedia As TextBox
    Friend WithEvents txtfechanacimientorepresentantemes As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdirecciondomiciliorepresentante As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents lbltelefonorepresentante As Label
    Friend WithEvents txttelefonorepresentante As TextBox
    Friend WithEvents lblprofesióndocente As Label
    Friend WithEvents txtprofesionactualrepresentante As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnGuardarRegistroRepresentante As Button
    Friend WithEvents btnCancearRegistroRepresentante As Button
    Friend WithEvents btnmenuprincipalRepresentante As Button
End Class
