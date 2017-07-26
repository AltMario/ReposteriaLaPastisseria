<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebUsuarios.aspx.cs" Inherits="WebUsuarios" %>
<!-- #include file ="Template/cabecera.html" -->
<style>
    td,th{
        padding:5px;

    }
.col-centrada{
    float: none;
    margin: 0 auto;
}
</style>
    <form id="form1" runat="server">
         <div class='row'>
            <div class='col-lg-12'>
                <h1 class='page-header'>
                    <small>Lista de Usuarios</small>
                </h1>
                <ol class='breadcrumb'>
                    <li>
                        <i class='fa fa-dashboard'></i> <a href='../../controlador/administrador/c-panel.php'>panel</a>
                    </li>
                    <li class='active'>
                        Usuarios
                    </li>
                </ol>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <div class="form-inline form-padding">
                        <asp:TextBox ID="txtbuscar" runat="server" class="form-control" placeholder="Buscar Usuarios..." ></asp:TextBox>
                        <asp:LinkButton ID="btnBuscar" runat="server" class="btn btn-success" OnClick="btnBuscar_Click"><i class="fa fa-search"></i> Buscar</asp:LinkButton>
                        <asp:LinkButton ID="btnRegistrar" runat="server" class="btn btn-primary" OnClick="btnRegistrar_Click"><i class="fa fa-user"></i> Agregar Usuario</asp:LinkButton>
                        <asp:LinkButton ID="btnactualizar" runat="server" class="btn btn-primary" OnClick="btnactualizar_Click"><i class="fa fa-pencil-square-o" ></i> Actualizar</asp:LinkButton>
                        <asp:LinkButton ID="btneliminar" runat="server" class="btn btn-primary" OnClick="btneliminar_Click"><i class="fa fa-trash" ></i> Eliminar</asp:LinkButton>         
                </div>
            </div>
        </div>
        <br />

    <div class="row">
		<div class="col-md-6">
			<div class="panel panel-default">
                <div class="panel-body">
                    <br />
                    <table style="width:100%;">
                        <tr>
                            <th>Usuario :</th>
                            <td>
                                <asp:TextBox ID="txtusuario" runat="server" class="form-control"></asp:TextBox>
                            </td>
                        </tr>
                        <tr> 
                            <th>Contraseña :</th>
                            <td>
                                <asp:TextBox ID="txtcontraseña" runat="server" class="form-control" type="password"></asp:TextBox>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <th>Rol :</th>
                            <td>
                                <asp:DropDownList ID="DropRol" runat="server" class="form-control">
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>    
                </div>
            </div>
		</div>
		<div class="col-md-6 ">
			<div class="panel panel-default">
                <div class="panel-body  ">

                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                        <asp:GridView class="col-centrada" ID="dg_usuario" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="dg_usuario_SelectedIndexChanged" OnRowDeleting="dg_usuario_RowDeleting" OnDataBound="dg_usuario_DataBound" OnRowDataBound="dg_usuario_RowDataBound" >
                             <AlternatingRowStyle BackColor="White" />
                             <Columns>
                                 <asp:CommandField  ButtonType="Button" DeleteText="Selecionar" ShowDeleteButton="True" />
                             </Columns>
                             <EditRowStyle BackColor="#2461BF" />
                             <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                             <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                             <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                             <RowStyle BackColor="#EFF3FB" />
                             <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                             <SortedAscendingCellStyle BackColor="#F5F7FB" />
                             <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                             <SortedDescendingCellStyle BackColor="#E9EBEF" />
                             <SortedDescendingHeaderStyle BackColor="#4870BE" />
                         </asp:GridView>
                </div>
            </div>
		</div>
	</div>
    </form>