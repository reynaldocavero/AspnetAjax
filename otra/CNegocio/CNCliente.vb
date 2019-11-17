
Imports CDatos

Public Class CNCliente

    Public Shared Function listarCliente() As DataTable
        Dim objCD As New CDCliente
        Return objCD.Ins.listarCliente()
    End Function
    Public Shared Function buscaCliente(ByVal xml As String) As DataTable
        Dim objCD As New CDCliente
        Return objCD.Ins.buscaCliente(xml)
    End Function
End Class
