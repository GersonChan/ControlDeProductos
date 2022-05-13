<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ControlDeProductos._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        
        i<br />
        <h1>Ingreso de Productos Electronicos:</h1>
        <p>
            Codigo de producto
            <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
        </p>
        <p>
            Nombre del producto
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </p>
        <p>
            Descripcion del producto
            <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
        </p>
        <p>
            Precio de compra
            <asp:TextBox ID="txtCompra" runat="server"></asp:TextBox>
        </p>
        <p>
            Precio de venta
            <asp:TextBox ID="txtVenta" runat="server"></asp:TextBox>
        </p>
        <p>
            Tiempo de Garantia
            <asp:TextBox ID="txtGarantia" runat="server"></asp:TextBox>
        </p>
        <p>
            Voltaje que utiliza
            <asp:TextBox ID="txtVoltaje" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnElectronico" runat="server" OnClick="btnElectronico_Click" Text="Ingresar electrodomestico" />
        </p>
        
    </div>

</asp:Content>
