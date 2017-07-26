<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebLogin.aspx.cs" Inherits="WebLogin" %>

<style>
    a{
        text-decoration:none !important;
    }
</style>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width , initial-scale=1">
    <title>Login</title>
    <link rel="stylesheet" href="css/login.css">
    <link rel="stylesheet" href="css/font-awesome.css">
    
</head>
<body>
    <form id="form1" runat="server">
        <H2><i class="fa fa-expeditedssl" aria-hidden="true"></i> login</H2>
        <label><i class="fa fa-user" aria-hidden="true"></i> Usuario</label>
        <asp:TextBox ID="txtuser" runat="server"  placeholder="Ingrese su Usuario" required="required"></asp:TextBox>
        
        <label><i class="fa fa-key" aria-hidden="true"></i>Contrase&ntilde;a
            <asp:TextBox ID="txtpass" runat="server" type="password"  placeholder="Ingrese su Contrase&ntilde;a"></asp:TextBox>
        </label>
        &nbsp;
        <asp:LinkButton ID="btnlogin" runat="server" class="btn-login" OnClick="btnlogin_Click"><i class="fa fa-power-off""></i> Ingresar</asp:LinkButton>
  
       
    </form>

</body>
</html>
