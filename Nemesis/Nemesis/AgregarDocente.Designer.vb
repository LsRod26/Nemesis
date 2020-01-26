<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarDocente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarDocente))
        Me.lblcedulaidentidaddocente = New System.Windows.Forms.Label()
        Me.txtcedulaidentidaddocente = New System.Windows.Forms.TextBox()
        Me.lblnombresdocentes = New System.Windows.Forms.Label()
        Me.txtnombresdocente = New System.Windows.Forms.TextBox()
        Me.lblapellidosdocentes = New System.Windows.Forms.Label()
        Me.txtapellidosdocentes = New System.Windows.Forms.TextBox()
        Me.lblfechanacimientodocente = New System.Windows.Forms.Label()
        Me.txtfechanacimientodocentedia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfechanacimientodocentemes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtfechanacimientodocenteanio = New System.Windows.Forms.TextBox()
        Me.lbldirecciondocente = New System.Windows.Forms.Label()
        Me.txtdirecciondocente = New System.Windows.Forms.TextBox()
        Me.lbltelefonodocente1 = New System.Windows.Forms.Label()
        Me.txttelefonodocente = New System.Windows.Forms.TextBox()
        Me.lblespecialidaddocente = New System.Windows.Forms.Label()
        Me.txtespecialidaddocente = New System.Windows.Forms.TextBox()
        Me.lbltelefonodocente2 = New System.Windows.Forms.Label()
        Me.txttelefonodocente2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnguardarprofesor = New System.Windows.Forms.Button()
        Me.btncancelarregistrodocente = New System.Windows.Forms.Button()
        Me.btnmenuprincipaldocente = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcedulaidentidaddocente
        '
        Me.lblcedulaidentidaddocente.AutoSize = True
        Me.lblcedulaidentidaddocente.Location = New System.Drawing.Point(36, 34)
        Me.lblcedulaidentidaddocente.Name = "lblcedulaidentidaddocente"
        Me.lblcedulaidentidaddocente.Size = New System.Drawing.Size(142, 17)
        Me.lblcedulaidentidaddocente.TabIndex = 0
        Me.lblcedulaidentidaddocente.Text = "Cedula de Indentidad"
        '
        'txtcedulaidentidaddocente
        '
        Me.txtcedulaidentidaddocente.Location = New System.Drawing.Point(195, 31)
        Me.txtcedulaidentidaddocente.Name = "txtcedulaidentidaddocente"
        Me.txtcedulaidentidaddocente.Size = New System.Drawing.Size(270, 22)
        Me.txtcedulaidentidaddocente.TabIndex = 1
        '
        'lblnombresdocentes
        '
        Me.lblnombresdocentes.AutoSize = True
        Me.lblnombresdocentes.Location = New System.Drawing.Point(36, 77)
        Me.lblnombresdocentes.Name = "lblnombresdocentes"
        Me.lblnombresdocentes.Size = New System.Drawing.Size(65, 17)
        Me.lblnombresdocentes.TabIndex = 2
        Me.lblnombresdocentes.Text = "Nombres"
        '
        'txtnombresdocente
        '
        Me.txtnombresdocente.Location = New System.Drawing.Point(120, 74)
        Me.txtnombresdocente.Name = "txtnombresdocente"
        Me.txtnombresdocente.Size = New System.Drawing.Size(345, 22)
        Me.txtnombresdocente.TabIndex = 3
        '
        'lblapellidosdocentes
        '
        Me.lblapellidosdocentes.AutoSize = True
        Me.lblapellidosdocentes.Location = New System.Drawing.Point(36, 126)
        Me.lblapellidosdocentes.Name = "lblapellidosdocentes"
        Me.lblapellidosdocentes.Size = New System.Drawing.Size(65, 17)
        Me.lblapellidosdocentes.TabIndex = 4
        Me.lblapellidosdocentes.Text = "Apellidos"
        '
        'txtapellidosdocentes
        '
        Me.txtapellidosdocentes.Location = New System.Drawing.Point(120, 123)
        Me.txtapellidosdocentes.Name = "txtapellidosdocentes"
        Me.txtapellidosdocentes.Size = New System.Drawing.Size(345, 22)
        Me.txtapellidosdocentes.TabIndex = 5
        '
        'lblfechanacimientodocente
        '
        Me.lblfechanacimientodocente.AutoSize = True
        Me.lblfechanacimientodocente.Location = New System.Drawing.Point(36, 176)
        Me.lblfechanacimientodocente.Name = "lblfechanacimientodocente"
        Me.lblfechanacimientodocente.Size = New System.Drawing.Size(141, 17)
        Me.lblfechanacimientodocente.TabIndex = 6
        Me.lblfechanacimientodocente.Text = "Fecha de Nacimiento"
        '
        'txtfechanacimientodocentedia
        '
        Me.txtfechanacimientodocentedia.Location = New System.Drawing.Point(195, 173)
        Me.txtfechanacimientodocentedia.Name = "txtfechanacimientodocentedia"
        Me.txtfechanacimientodocentedia.Size = New System.Drawing.Size(66, 22)
        Me.txtfechanacimientodocentedia.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(267, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "/"
        '
        'txtfechanacimientodocentemes
        '
        Me.txtfechanacimientodocentemes.Location = New System.Drawing.Point(285, 173)
        Me.txtfechanacimientodocentemes.Name = "txtfechanacimientodocentemes"
        Me.txtfechanacimientodocentemes.Size = New System.Drawing.Size(62, 22)
        Me.txtfechanacimientodocentemes.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(353, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "/"
        '
        'txtfechanacimientodocenteanio
        '
        Me.txtfechanacimientodocenteanio.Location = New System.Drawing.Point(371, 171)
        Me.txtfechanacimientodocenteanio.Name = "txtfechanacimientodocenteanio"
        Me.txtfechanacimientodocenteanio.Size = New System.Drawing.Size(94, 22)
        Me.txtfechanacimientodocenteanio.TabIndex = 11
        '
        'lbldirecciondocente
        '
        Me.lbldirecciondocente.AutoSize = True
        Me.lbldirecciondocente.Location = New System.Drawing.Point(36, 234)
        Me.lbldirecciondocente.Name = "lbldirecciondocente"
        Me.lbldirecciondocente.Size = New System.Drawing.Size(147, 17)
        Me.lbldirecciondocente.TabIndex = 12
        Me.lbldirecciondocente.Text = "Dirección de Domicilio"
        '
        'txtdirecciondocente
        '
        Me.txtdirecciondocente.Location = New System.Drawing.Point(189, 231)
        Me.txtdirecciondocente.Name = "txtdirecciondocente"
        Me.txtdirecciondocente.Size = New System.Drawing.Size(276, 22)
        Me.txtdirecciondocente.TabIndex = 13
        '
        'lbltelefonodocente1
        '
        Me.lbltelefonodocente1.AutoSize = True
        Me.lbltelefonodocente1.Location = New System.Drawing.Point(36, 291)
        Me.lbltelefonodocente1.Name = "lbltelefonodocente1"
        Me.lbltelefonodocente1.Size = New System.Drawing.Size(136, 17)
        Me.lbltelefonodocente1.TabIndex = 14
        Me.lbltelefonodocente1.Text = "Teléfono Contacto 1"
        '
        'txttelefonodocente
        '
        Me.txttelefonodocente.Location = New System.Drawing.Point(178, 287)
        Me.txttelefonodocente.Name = "txttelefonodocente"
        Me.txttelefonodocente.Size = New System.Drawing.Size(286, 22)
        Me.txttelefonodocente.TabIndex = 15
        '
        'lblespecialidaddocente
        '
        Me.lblespecialidaddocente.AutoSize = True
        Me.lblespecialidaddocente.Location = New System.Drawing.Point(36, 399)
        Me.lblespecialidaddocente.Name = "lblespecialidaddocente"
        Me.lblespecialidaddocente.Size = New System.Drawing.Size(88, 17)
        Me.lblespecialidaddocente.TabIndex = 16
        Me.lblespecialidaddocente.Text = "Especialidad"
        '
        'txtespecialidaddocente
        '
        Me.txtespecialidaddocente.Location = New System.Drawing.Point(134, 394)
        Me.txtespecialidaddocente.Name = "txtespecialidaddocente"
        Me.txtespecialidaddocente.Size = New System.Drawing.Size(331, 22)
        Me.txtespecialidaddocente.TabIndex = 17
        '
        'lbltelefonodocente2
        '
        Me.lbltelefonodocente2.AutoSize = True
        Me.lbltelefonodocente2.Location = New System.Drawing.Point(36, 340)
        Me.lbltelefonodocente2.Name = "lbltelefonodocente2"
        Me.lbltelefonodocente2.Size = New System.Drawing.Size(140, 17)
        Me.lbltelefonodocente2.TabIndex = 18
        Me.lbltelefonodocente2.Text = "Teléfono Contacto 2 "
        '
        'txttelefonodocente2
        '
        Me.txttelefonodocente2.Location = New System.Drawing.Point(178, 337)
        Me.txttelefonodocente2.Name = "txttelefonodocente2"
        Me.txttelefonodocente2.Size = New System.Drawing.Size(287, 22)
        Me.txttelefonodocente2.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(664, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 198)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'btnguardarprofesor
        '
        Me.btnguardarprofesor.Location = New System.Drawing.Point(652, 330)
        Me.btnguardarprofesor.Name = "btnguardarprofesor"
        Me.btnguardarprofesor.Size = New System.Drawing.Size(116, 54)
        Me.btnguardarprofesor.TabIndex = 21
        Me.btnguardarprofesor.Text = "Guardar Registro"
        Me.btnguardarprofesor.UseVisualStyleBackColor = True
        '
        'btncancelarregistrodocente
        '
        Me.btncancelarregistrodocente.Location = New System.Drawing.Point(793, 330)
        Me.btncancelarregistrodocente.Name = "btncancelarregistrodocente"
        Me.btncancelarregistrodocente.Size = New System.Drawing.Size(120, 54)
        Me.btncancelarregistrodocente.TabIndex = 22
        Me.btncancelarregistrodocente.Text = "Cancelar Registro"
        Me.btncancelarregistrodocente.UseVisualStyleBackColor = True
        '
        'btnmenuprincipaldocente
        '
        Me.btnmenuprincipaldocente.Location = New System.Drawing.Point(652, 405)
        Me.btnmenuprincipaldocente.Name = "btnmenuprincipaldocente"
        Me.btnmenuprincipaldocente.Size = New System.Drawing.Size(260, 28)
        Me.btnmenuprincipaldocente.TabIndex = 23
        Me.btnmenuprincipaldocente.Text = "Menú Principal"
        Me.btnmenuprincipaldocente.UseVisualStyleBackColor = True
        '
        'AgregarDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 505)
        Me.Controls.Add(Me.btnmenuprincipaldocente)
        Me.Controls.Add(Me.btncancelarregistrodocente)
        Me.Controls.Add(Me.btnguardarprofesor)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txttelefonodocente2)
        Me.Controls.Add(Me.lbltelefonodocente2)
        Me.Controls.Add(Me.txtespecialidaddocente)
        Me.Controls.Add(Me.lblespecialidaddocente)
        Me.Controls.Add(Me.txttelefonodocente)
        Me.Controls.Add(Me.lbltelefonodocente1)
        Me.Controls.Add(Me.txtdirecciondocente)
        Me.Controls.Add(Me.lbldirecciondocente)
        Me.Controls.Add(Me.txtfechanacimientodocenteanio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtfechanacimientodocentemes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfechanacimientodocentedia)
        Me.Controls.Add(Me.lblfechanacimientodocente)
        Me.Controls.Add(Me.txtapellidosdocentes)
        Me.Controls.Add(Me.lblapellidosdocentes)
        Me.Controls.Add(Me.txtnombresdocente)
        Me.Controls.Add(Me.lblnombresdocentes)
        Me.Controls.Add(Me.txtcedulaidentidaddocente)
        Me.Controls.Add(Me.lblcedulaidentidaddocente)
        Me.Name = "AgregarDocente"
        Me.Text = "Agregar Docente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblcedulaidentidaddocente As Label
    Friend WithEvents txtcedulaidentidaddocente As TextBox
    Friend WithEvents lblnombresdocentes As Label
    Friend WithEvents txtnombresdocente As TextBox
    Friend WithEvents lblapellidosdocentes As Label
    Friend WithEvents txtapellidosdocentes As TextBox
    Friend WithEvents lblfechanacimientodocente As Label
    Friend WithEvents txtfechanacimientodocentedia As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtfechanacimientodocentemes As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtfechanacimientodocenteanio As TextBox
    Friend WithEvents lbldirecciondocente As Label
    Friend WithEvents txtdirecciondocente As TextBox
    Friend WithEvents lbltelefonodocente1 As Label
    Friend WithEvents txttelefonodocente As TextBox
    Friend WithEvents lblespecialidaddocente As Label
    Friend WithEvents txtespecialidaddocente As TextBox
    Friend WithEvents lbltelefonodocente2 As Label
    Friend WithEvents txttelefonodocente2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnguardarprofesor As Button
    Friend WithEvents btncancelarregistrodocente As Button
    Friend WithEvents btnmenuprincipaldocente As Button
End Class
