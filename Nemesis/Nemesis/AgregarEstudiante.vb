Public Class AgregarEstudiante
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblcedulaidentidadestudiante.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub



    Private Sub lbltelefonoemergencia2_Click(sender As Object, e As EventArgs) Handles lbltelefonoemergencia2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblapellidosrepresentante.Click

    End Sub

    Private Sub btnguardarestudiante_Click(sender As Object, e As EventArgs) Handles btnguardarestudiante.Click
        MsgBox("Registro de estudiante completado satisfactoriamente", vbOKOnly)
        txtnombresestudiantes.Text = ""
        txtapellidosestudiantes.Text = ""
        txtcedulaidentidadestudiante.Text = ""
        txtdireccionestudiante.Text = ""
        txtfechanacimientoestudiantedia.Text = ""
        txtfechanacimientoestudiantemes.Text = ""
        txtfechanacimientoestudianteanio.Text = ""
        cmbcursoalquesedirige.Text = "Curso"
        txttelefonoemergencia1.Text = ""
        txttelefonoemergencia2.Text = ""
        txtnombresrepresentantes.Text = ""
        txtapellidosrepresentante.Text = ""
        cmbparentescoestudiante.Text = "Seleccionar Grado de Parentesco"


    End Sub

    Private Sub btncancelarregistroestudiante_Click(sender As Object, e As EventArgs) Handles btncancelarregistroestudiante.Click

        MsgBox("Registro de estudiante cancelado", vbOKOnly)

    End Sub

    Private Sub AgregarEstudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnmenuprincipalestudiante.Click
        PaginaPrincipal.Show()
        Me.Close()

    End Sub
End Class