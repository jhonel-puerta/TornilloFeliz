Imports CapaNegocio

Public Class info_producto
    Public producto As cnProductos = New cnProductos
    Private Sub info_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblnameP.Text = Module1.nameP
        lblprecio.Text = Module1.precio
        lbldisponible.Text = Module1.cant
        lbldesc.Text = Module1.desc
    End Sub

    Private Sub info_producto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim form1 As Form1 = New Form1
        form1.Show()
    End Sub

    Private Sub btnvender_Click(sender As Object, e As EventArgs) Handles btnvender.Click
        Dim winVender As vender = New vender
        winVender.Show()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        editar.Show()
        Me.Hide()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        producto.eliminar(Module1.id)
        Me.Close()
    End Sub
End Class