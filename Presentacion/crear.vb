Imports CapaNegocio
Public Class crear
    Public objproducto As cnProductos = New cnProductos
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged, txtdesc.TextChanged, txtcantidad.TextChanged, txtprecio.TextChanged

    End Sub

    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        If (objproducto.crear(txtname.Text, txtprecio.Text, txtcantidad.Text, txtdesc.Text)) Then
            MsgBox("creado correctamente!")
        Else
            MsgBox("error al crear!")
        End If
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Close()
    End Sub

    Private Sub crear_FormClosing() Handles MyBase.FormClosing
        Form1.Show()
    End Sub
End Class