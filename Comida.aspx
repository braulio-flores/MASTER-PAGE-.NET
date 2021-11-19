<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Comida.aspx.cs" Inherits="Entregable4.Comida" MasterPageFile="~/Maestra.Master" %>

<asp:Content id="mainContent2" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div>
        <p>Catalogo de comida</p>
        <asp:Label Text="Nombre" runat="server" />
        <asp:TextBox runat="server" placeholder="Nombre del Platillo" ID="platilloName"/>
        <br />
        <asp:Label Text="Pais de Origen" runat="server" />
        <asp:DropDownList runat="server" ID="dropPaisComida" >
            <asp:ListItem Text="México" />
            <asp:ListItem Text="España" />
            <asp:ListItem Text="Japón" />
            <asp:ListItem Text="EUA" />
        </asp:DropDownList>
        <asp:Button ID="btnEnv" runat="server" Text="Agregar Platillo" OnClick="agregarCom" />
        <br />
        <br />
        <br />
        <table>
            <tr>
                <td>Id</td>
                <td>Nombre</td>
                <td>Pais</td>
            </tr>
            <asp:Label id="contentPlatillos" runat="server" />
            
        </table>

    </div>
</asp:Content>