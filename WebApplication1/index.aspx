<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication1.index" %>

<!DOCTYPE html>

<html lang="es-es">
<head runat="server">
<meta charset="utf-8" />
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView OnRowCommand="grdv_Usuarios_RowCommand" ID="grdv_Usuarios" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="idUsuario" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:ButtonField CommandName="editUsuario"  Text="Editar" ControlStyle-CssClass="btn btn-info" />
                    
                <asp:ButtonField CommandName="borrarUsuario"  Text="Borrar" ControlStyle-CssClass="btn btn-danger" />
       
                <asp:BoundField  DataField="idUsuario" />
            </Columns>
        </asp:GridView>
 
    </div>
    </form>
</body>
</html>
