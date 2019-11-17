Public Class CECliente
    Private _cliente As String
    Private _numero As String
    Private _activo As String
    Public Property cliente As String
        Get
            Return _cliente
        End Get
        Set(value As String)
            _cliente = value
        End Set
    End Property
    Public Property numero As String
        Get
            Return _numero
        End Get
        Set(value As String)
            _numero = value
        End Set
    End Property
    Public Property activo As String
        Get
            Return _activo
        End Get
        Set(value As String)
            _activo = value
        End Set
    End Property
End Class
