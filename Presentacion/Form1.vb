Imports CapaNegocio
Public Class Form1
    Dim productos As cnProductos = New cnProductos

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''hola por el momento estamos teniendo problemas al actualizar los datos del gridview cuando se actualiza, estamos trabajando en ello pronto saldrá una actualizacion
        productos.mostrarProductos.Clear()
        dgv1.DataSource = productos.mostrarProductos.Tables("prod").DefaultView

    End Sub

    Private Sub salit_Click(sender As Object, e As EventArgs) Handles salit.Click
        Close()
    End Sub

    Private Sub editar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick

        Dim info As info_producto = New info_producto
        Dim id As String = dgv1.CurrentRow.Cells(0).Value.ToString
        Dim name As String = dgv1.CurrentRow.Cells(1).Value.ToString
        Dim precio As String = dgv1.CurrentRow.Cells(2).Value.ToString
        Dim cant As String = dgv1.CurrentRow.Cells(3).Value.ToString
        Dim desc As String = dgv1.CurrentRow.Cells(4).Value.ToString

        Module1.id = id
        Module1.nameP = name
        Module1.precio = precio
        Module1.cant = cant
        Module1.desc = desc

        info.Show()
        Hide()
    End Sub

    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        Dim winCrear As crear = New crear
        winCrear.Show()
        Me.Hide()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        productos.buscar(txtbuscar.Text).Clear()
        dgv1.DataSource = productos.buscar(txtbuscar.Text).Tables("prod").DefaultView
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("https://youtu.be/OMOGaugKpzs")
        ''un poco de buena musica :)
    End Sub
End Class
