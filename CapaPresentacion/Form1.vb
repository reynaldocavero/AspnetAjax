

Imports CapaLogica

Public Class dgCliente
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargaPasajero()
    End Sub

    Private Sub cargaPasajero()
        Dim obj As New CLCliente
        'DataGridView1.DataSource = obj.listarCliente.Tables("Cliente")
    End Sub
End Class
