Imports System.Data
Imports System.Data.SqlClient

Public Class conexion
    Public cadena As SqlConnection = New SqlConnection(My.Settings.conexion)
    Public ds As DataSet = New DataSet()
    Dim cmb As SqlCommandBuilder
    Dim da As SqlDataAdapter = New SqlDataAdapter()

    Public Sub conectar()
        Try
            cadena.Open()
        Catch ex As Exception
            Console.WriteLine("error al conectar -> " & ex.Message)
        End Try
    End Sub

    Public Sub cerrarConexion()
        cadena.Close()
    End Sub

    Public Sub listar()
        Dim sql As String = "select * from prod"
        Dim tabla As String = "prod"
        da = New SqlDataAdapter(sql, cadena)
        cmb = New SqlCommandBuilder(da)
        ds.Clear()
        da.Fill(ds, tabla)
    End Sub

    ''en la variable cant recibe la resta de la cantidad de productos que se vendiero
    Public Function vender(cant As String, id As String)
        Dim sql As String = "update prod set cantidad=" & cant & " where id=" & id
        conectar()
        Dim sqlcommand As SqlCommand = New SqlCommand(sql, cadena)
        If (sqlcommand.ExecuteNonQuery() >= 1) Then
            Return True
        Else
            Return False
        End If
        cerrarConexion()
    End Function

    Public Function getCantById(id As String)
        Dim sql As String = "select cantidad from prod where id=" & id
        Dim tabla As String = "prod"
        da = New SqlDataAdapter(sql, cadena)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
        Return ds.Tables(tabla).Rows(0).Item(0).ToString
    End Function

    Public Function crear(nom As String, precio As String, cant As String, desc As String)
        Dim sql As String = "insert into prod (nombreP,precio,cantidad,descripcion) values ('" & nom & "'," & precio & "," & cant & ",'" & desc & "');"
        conectar()
        Dim command As SqlCommand = New SqlCommand(sql, cadena)
        command.ExecuteNonQuery()
        Return True
        cerrarConexion()
    End Function

    Public Function eliminar(id As String)
        conectar()
        Dim sql As String = "delete prod where id=" & id
        Dim sqlcmd As SqlCommand = New SqlCommand(sql, cadena)
        If (sqlcmd.ExecuteNonQuery() >= 1) Then
            Return True
        Else
            Return False
        End If
        cerrarConexion()
    End Function

    Public Function actualizar(id As String, nom As String, precio As String, cant As String, desc As String)
        conectar()
        Dim sql As String = "update prod set nombreP='" & nom & "',precio='" & precio & "',cantidad='" & cant & "',descripcion='" & desc & "' where id=" & id
        Dim cmd As SqlCommand = New SqlCommand(sql, cadena)
        If (cmd.ExecuteNonQuery() >= 1) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub buscar(busqueda As String)
        Dim sql As String = "select * from prod where nombreP like '" & busqueda & "%'"
        Dim tabla As String = "prod"
        conectar()
        da = New SqlDataAdapter(sql, cadena)
        Dim cmb As SqlCommandBuilder = New SqlCommandBuilder(da)
        ds.Clear()
        da.Fill(ds, tabla)
        cerrarConexion()
    End Sub
End Class


