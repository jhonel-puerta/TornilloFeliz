Imports CapaDatos
Public Class cnProductos
    Dim objProd As conexion = New conexion()

    Public Function mostrarProductos() As DataSet
        objProd.conectar()
        Try
            objProd.listar()
        Catch ex As Exception

            Console.WriteLine("error en la capa negocio.mostrarP --> " & ex.Message)
        End Try
        Return objProd.ds
    End Function

    ''vender
    Public Function vender(cant As String, id As String)
        If (Convert.ToInt32(objProd.getCantById(id)) > Convert.ToInt32(cant)) Then
            Dim resta As Integer = objProd.getCantById(id) - cant
            objProd.vender(Convert.ToString(resta), id)
            Return True
        Else
            Return False
            Console.WriteLine("No hay productos suficientes solo quedan ->" & objProd.getCantById(id))
        End If
    End Function

    Public Function crear(nom As String, precio As String, cant As String, desc As String)
        ''crear un filtro para no poder agregar productos repetidos
        ''----------> aqui en una proxima actualizacion <---------
        If (objProd.crear(nom, precio, cant, desc)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function eliminar(id As String)
        If (objProd.eliminar(id)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function actualizar(id As String, nom As String, precio As String, cant As String, desc As String)
        If (objProd.actualizar(id, nom, precio, cant, desc)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function buscar(busqueda As String) As DataSet
        objProd.buscar(busqueda)
        Return objProd.ds
    End Function
End Class
