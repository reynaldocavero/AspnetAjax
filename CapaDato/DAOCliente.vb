Imports System.Data.SqlClient
Public Class DAOCliente
    Dim objConexion As New Conexion
    Dim da As SqlDataAdapter
    Dim cn As SqlConnection

#Region "Patron Singleton"

    Private Shared oInstancia As DAOCliente = Nothing
    Dim Accion As Object

    Public Shared Function Ins() As DAOCliente
        If oInstancia Is Nothing Then
            oInstancia = New DAOCliente()
        End If
        Return oInstancia
    End Function

#End Region

    Public Function listarCliente() As DataTable
        Dim dtTmp As New DataTable
        Try
            Using cmd As New SqlCommand()
                cmd.CommandText = "sp_listaClienteTodo"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = objConexion.conectar
                cmd.CommandTimeout = 0


                objConexion.conectar.Open()
                Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                adapter.Fill(dtTmp)
            End Using
            Return dtTmp
        Catch ex1 As SqlException
            Throw ex1
        Catch ex As Exception
            Throw ex
        Finally
            'destruyeconexion(objConexion)
        End Try
    End Function

    Public Function addCliente(ByVal xml As String) As Boolean
        cn = objConexion.conectar
        Dim cmd As New SqlCommand("sp_insertarCliente", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@xml", SqlDbType.Text).Value = xml
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception

            Return False
            cn.Close()
        End Try
        cn.Close()

    End Function

    Public Sub updateCliente(ByVal xml As String)
        cn = objConexion.conectar
        Dim cmd As New SqlCommand("sp_insertarCliente", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@xml", SqlDbType.Text).Value = xml
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cn.Close()
        End Try
        cn.Close()
    End Sub
    Public Sub buscarCliente(ByVal xml As String)
        cn = objConexion.conectar
        Dim cmd As New SqlCommand("sp_insertarCliente", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@id", SqlDbType.Text).Value = xml
        Try

            cn.Open()
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()

            End If

            cmd.ExecuteNonQuery()
            dr.Close()


        Catch ex As Exception
            cn.Close()
        End Try
        cn.Close()
    End Sub
End Class
