Imports CNegocio
Imports Utilitario

Public Class Documento
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    <System.Web.Services.WebMethod()>
    Public Shared Function buscaCliente(ByVal xml As String) As String
        Try
            Dim dt As DataTable = CNCliente.buscaCliente(xml)
            Return GetJson.GetJson(dt)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class