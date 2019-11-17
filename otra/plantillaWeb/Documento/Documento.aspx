<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Documento.aspx.vb" Inherits="plantillaWeb.Documento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Documento</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                  <div class="form-group">
                    <label for="txtRuc">RUC</label>
                    <input type="text" class="form-control" id="txtRuc" />
                    <label for="txtCliente">Cliente</label>
                    <input type="text" class="form-control" id="txtCliente" />
                  </div>
            </div>
            <div class="col-md-6">

            </div>
        </div>
    </div>
    <script src="../Scripts/jquery-3.4.1.js"></script>
    <script src="../Scripts/bootstrap.js"></script>
    <script>
        $("#txtRuc").on('blur', function () {
            var ruc = $("#txtRuc").val();

            /*var cliente = $("#txtCliente").val();
            var xml = '<Clientes>';
            xml += '<Cliente>'+
                '<nombre>'+cliente+'</nombre>'+
                '<numero>'+ruc+'</numero>'+
                '<activo>' + 1 + '</activo>' +
                '</Cliente>' +
                 '</Clientes>';*/
            $.ajax({
            type: "POST",
            url: "Documento.aspx/buscaCliente",
            data: JSON.stringify({xml: ruc}),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                alert(response.d);
                var obj = JSON.parse(response.d);
                console.log(obj.length);
                if (obj.length>0) {
                    $.each(obj, function (key, val) {
                        $("#txtCliente").val(val.cliente);

                    });
                } else {
                    $("#txtCliente").val('');
                }

            },
            error: function (result) {
                alert('ERROR: ' + result.status + ' ' + result.statusText);
            }
        });
        });
    </script>
</body>
</html>
