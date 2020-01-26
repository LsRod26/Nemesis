Public Class AgregarRepresentante
    Private Sub AgregarRepresentante_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGuardarRegistroRepresentante_Click(sender As Object, e As EventArgs) Handles btnGuardarRegistroRepresentante.Click
        MsgBox("Registro de representante legal cancelado", vbOKOnly)
    End Sub

    Private Sub btnCancearRegistroRepresentante_Click(sender As Object, e As EventArgs) Handles btnCancearRegistroRepresentante.Click
        MsgBox("Registro de representante legal cancelado", vbOKOnly)
    End Sub

    Private Sub btnmenuprincipalRepresentante_Click(sender As Object, e As EventArgs) Handles btnmenuprincipalRepresentante.Click
        PaginaPrincipal.Show()
        Me.Close()
    End Sub
End Class