Public Class AgregarDocente
    Private Sub btnguardarprofesor_Click(sender As Object, e As EventArgs) Handles btnguardarprofesor.Click
        MsgBox("Registro de docente completado satisfactoriamente", vbOKOnly)
    End Sub

    Private Sub btncancelarregistrodocente_Click(sender As Object, e As EventArgs) Handles btncancelarregistrodocente.Click
        MsgBox("Registro de docente cancelado", vbOKOnly)
    End Sub

    Private Sub btnregresardocente_Click(sender As Object, e As EventArgs) Handles btnmenuprincipaldocente.Click
        PaginaPrincipal.Show()
        Me.Close()

    End Sub
End Class