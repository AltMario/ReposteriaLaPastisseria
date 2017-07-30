
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebInformes.aspx.cs" Inherits="WebInformes" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<!-- #include file ="Template/cabecera.html" -->
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class='row'>
            <div class='col-lg-12'>
                <h1 class='page-header'>
                    <small>&nbsp;Cantidad de Productos</small>
                </h1>
                <ol class='breadcrumb'>
                    <li>
                        <i class='fa fa-dashboard'></i> <a href='../../controlador/administrador/c-panel.php'>panel</a>
                    </li>
                    <li class='active'>
                        Estadistica
                    </li>
                </ol>
            </div>
        </div>
    <div>
       
        <asp:Chart ID="Chart2" runat="server" Width="765px">
            <series>
                <asp:Series Name="Series1">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
    
    </div>
    </form>
</body>
</html>
