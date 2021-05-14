Imports CapaNegocio

Public Class vender

    Public objProd As cnProductos = New cnProductos
    Public cantInicial As Integer = 1
    Private Sub vender_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblnameP.Text = Module1.nameP
        lblcant.Text = cantInicial
        lblPrecio.Text = Module1.precio
        lblDesc.Text = Module1.desc
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        cantInicial += 1
        lblcant.Text = cantInicial
        ''en una proxima actualizacion se agregará una valdiacion para controlar que el usuario tenga un limite de acuerdo a la info de la db

    End Sub

    Private Sub bntVender_Click(sender As Object, e As EventArgs) Handles bntVender.Click
        If (objProd.vender(lblcant.Text, id)) Then
            MsgBox("producto vendido!")
        Else
            MsgBox("ocurrio un error!")
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
