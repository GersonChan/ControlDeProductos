<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="ControlDeProductos.Update" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h1>Actualizar</h1>
            <p>codigo del producto
                <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar Producto" />
            </p>
            <p>&nbsp;</p>
            <p>Nombre del producto:
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </p>
            <p>Descripcion
                <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
            </p>
            <p>Precio de compra
                <asp:TextBox ID="txtCompra" runat="server"></asp:TextBox>
            </p>
            <p>Precio de Venta
                <asp:TextBox ID="txtVenta" runat="server"></asp:TextBox>
            </p>
            <p>Tempo de Garantia
                <asp:TextBox ID="txtGarantia" runat="server"></asp:TextBox>
            </p>
            <p>&nbsp;</p>
            <p>
                <asp:Button ID="btnAcutualizar" runat="server" OnClick="btnAcutualizar_Click" Text="Actualizar Electrodomestico" />
            </p>
        </div>
        
</asp:Content>