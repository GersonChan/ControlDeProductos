<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="ControlDeProductos.Delete" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
            <h1>Eliminar</h1>
            <p>&nbsp;</p>
            <p>codigo del producto
                <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btnbuscar" runat="server" OnClick="btnbuscar_Click" Text="Buscar Electrodomestico" />
            </p>
            <p>&nbsp;</p>
            <p>Nombre del producto:
                <asp:TextBox ID="txtNombre" runat="server" Enabled="False"></asp:TextBox>
            </p>
            <p>Descripcion
                <asp:TextBox ID="txtDescripcion" runat="server" Enabled="False"></asp:TextBox>
            </p>
            <p>Precio de compra
                <asp:TextBox ID="txtCompra" runat="server" Enabled="False"></asp:TextBox>
            </p>
            <p>Precio de Venta
                <asp:TextBox ID="txtVenta" runat="server" Enabled="False"></asp:TextBox>
            </p>
            <p>Tempo de Garantia
                <asp:TextBox ID="txtGarantia" runat="server" Enabled="False"></asp:TextBox>
            </p>
            <p>&nbsp;</p>
            <p>
                <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar Electrodomestico" />
            </p>
            <p>&nbsp;</p>
        </div>
        </asp:Content>