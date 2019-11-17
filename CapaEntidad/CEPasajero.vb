Public Class CEPasajero
    Private _idPasajero As String
    Private _nombres As String
    Private _idPais As String
    Public Property idPasajero As String
        Get
            Return _idPasajero
        End Get
        Set(value As String)
            _idPasajero = value
        End Set
    End Property
    Public Property nombres As String
        Get
            Return _nombres
        End Get
        Set(value As String)
            _nombres = value

        End Set
    End Property
    Public Property idPais As String
        Get
            Return _idPais
        End Get
        Set(value As String)
            _idPais = value
        End Set
    End Property
End Class
