Imports CapaDato

Public Class CLPasajero
    Dim objPas As DAOPasajero
    Public Function listadoPasajero() As DataSet
        Return objPas.listadoPasajero
    End Function
End Class
