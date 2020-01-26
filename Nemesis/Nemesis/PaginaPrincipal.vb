Public Class PaginaPrincipal
    Private Sub Label2_Click(sender As Object, e As EventArgs)


    End Sub


    Private Sub PaginaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblhora.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblhora.Text = DateTime.Now.ToLongTimeString
        lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Timer1.Start()

    End Sub

    Private Sub btnagregarestudiantes_Click(sender As Object, e As EventArgs) Handles btnagregarestudiantes.Click
        Dim AgregarEstudiante As New AgregarEstudiante
        AgregarEstudiante.Show()
        Me.Hide()



    End Sub

    Private Sub lblfecha_Click(sender As Object, e As EventArgs) Handles lblfecha.Click

    End Sub

    Private Sub btnagregardocentes_Click(sender As Object, e As EventArgs) Handles btnagregardocentes.Click
        Dim AgregarDocente As New AgregarDocente
        AgregarDocente.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim AgregarRepresentante As New AgregarRepresentante
        AgregarRepresentante.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Citacion As New Citacion
        Citacion.Show()
        Me.Close()

    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim Editar As New Editar
        Editar.Show()
        Me.Close()


    End Sub
End Class