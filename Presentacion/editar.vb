Imports CapaNegocio
Public Class editar
    Public objproduct As cnProductos = New cnProductos
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        objproduct.actualizar(Module1.id, txtname.Text, txtprecio.Text, txtcantidad.Text, txtdesc.Text)
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNameHeader.Text = Module1.nameP
        txtname.Text = Module1.nameP
        txtdesc.Text = Module1.desc
        txtcantidad.Text = Module1.cant
        txtprecio.Text = Module1.precio
    End Sub
End Class