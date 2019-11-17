Imports System.Data.SqlClient

Public Class DAOPasajero
    Dim objCon As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter

    Public Function listadoPasajero() As DataSet
        Dim ds As DataSet
        cn = objCon.conectar
        da = New SqlDataAdapter("sp_listaClienteTodo", cn)
        da.Fill(ds, "cliente")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function
End Class
