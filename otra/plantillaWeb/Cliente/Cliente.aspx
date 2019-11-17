<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Cliente.aspx.vb" Inherits="plantillaWeb.Cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

<form id="form1" runat="server">
<div>
    Your Name : 
    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
    <input id="btnGetTime" type="button" value="Show Current Time" onclick = "ShowCurrentTime()" />
</div>
</form>
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
        <script>
    function ShowCurrentTime() {
        $.ajax({
            type: "POST",
            url: "Cliente.aspx/GetCurrentTime",
            data: '{name: "' + $("#<%=txtUserName.ClientID%>")[0].value + '" }',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: OnSuccess,
            failure: function(response) {
                alert(response.d);
            }
        });
    }
    function OnSuccess(response) {
        alert(response.d);
    }
    </script>
    </body>
</html>