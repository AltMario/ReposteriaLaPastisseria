<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebProductos.aspx.cs" Inherits="WebProductos" %>
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
    <div>
        <div class='row'>
            <div class='col-lg-12'>
                <h1 class='page-header'>
                    <small>Lista de Productos</small>
                </h1>
                <ol class='breadcrumb'>
                    <li>
                        <i class='fa fa-dashboard'></i> <a href='#'>panel</a>
                    </li>
                    <li class='active'>
                        Productos
                    </li>
                </ol>
            </div>
        </div>

          <div class="row">
            <div class="col-lg-12">
                <div class="form-inline form-padding">
                    <asp:TextBox ID="txtbuscar" runat="server" class="form-control" placeholder="Buscar Productos..." ></asp:TextBox>
                    <asp:LinkButton ID="btnsearch" runat="server" OnClick="btnsearch_Click" class="btn btn-success"><i class="fa fa-search"></i> Buscar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="btnadd" runat="server" OnClick="btnadd_Click" class="btn btn-primary" ><i class="fa fa-birthday-cake"></i> Agregar Producto</asp:LinkButton>
                    <asp:LinkButton ID="btnUpdate" runat="server" OnClick="btnUpdate_Click " class="btn btn-primary" ><i class="fa fa-pencil-square-o" ></i> Modificar</asp:LinkButton>
                    <asp:LinkButton ID="btndelete" runat="server" OnClick="btndelete_Click" class="btn btn-primary" ><i class="fa fa-trash" ></i> Eliminar</asp:LinkButton>
                   <a href="InformeProducto.aspx"> <button type="button" class="btn btn-primary"> <i class="fa fa-file-text" aria-hidden="true"></i> Reporte</button></a>
                </div>
               </div>
          </div>
          <br />
        <br />
        	  <div class="row">
		            <div class="col-md-12">
			            <div class="panel panel-default">
                            <div class="panel-body">


                     <table style="width:100%;">
            <tr>
                <th>Nombre :</th>
                <td class="auto-style2">
                    <asp:TextBox ID="txtNombre" runat="server" class="form-control"></asp:TextBox>
                </td>
                <th>Descripcion :</th>
                <td>
                    <asp:TextBox ID="txtDescripcion" runat="server"  class="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th>Tamaño :</th>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropTamaño" runat="server" OnSelectedIndexChanged="DropTamaño_SelectedIndexChanged" class="form-control">
                        <asp:ListItem>Item</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <th>Categoria :</td>
                <td>
                    <asp:DropDownList ID="DropCategoria" runat="server" class="form-control">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <th>Cantidad :</th>
                <td class="auto-style2">
                    <asp:TextBox ID="txtCantidad" runat="server" class="form-control"></asp:TextBox>
                </td>
                <th>Precio :</th>
                <td>
                    <asp:TextBox ID="txtPrecio" runat="server" class="form-control"></asp:TextBox>
                </td>
            </tr>
        </table>
				</div>
			</div>
    	</div>
    </div>
        <br />
         	  <div class="row">
		            <div class="col-md-12">
			            <div class="panel panel-default">
                            <div class="panel-body">
       
        <asp:GridView class="col-centrada" ID="g_Producto" runat="server" OnRowDeleting="g_Producto_RowDeleting" OnSelectedIndexChanged="g_Producto_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="g_Producto_RowDataBound" PageSize="5">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ButtonType="Button" DeleteText="Selecionar" ShowDeleteButton="True" />
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
    </div>
    </form>

