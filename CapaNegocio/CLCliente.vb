Imports CapaDato

Public Class CLCliente

    Public Shared Function listarCliente() As DataTable
        Dim objCD As New DAOCliente
        Return objCD.Ins.listarCliente()
    End Function
End Class
