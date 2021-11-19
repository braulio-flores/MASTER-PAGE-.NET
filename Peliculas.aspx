<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Peliculas.aspx.cs" Inherits="Entregable4.Peliculas" MasterPageFile="~/Maestra.Master" %>

<asp:Content id="mainContent2" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div >
        <p>Catalogo de Peliculas</p>
        <asp:Label Text="Nombre" runat="server" />
        <asp:TextBox runat="server" placeholder="Nombre de la pelicula" ID="lblNewPeli"/>
        <br />
        <asp:Label Text="Pais de origen" runat="server"/>
        <asp:DropDownList runat="server" id="dropPais" >
            <asp:ListItem Text="México" />
            <asp:ListItem Text="Japón" />
            <asp:ListItem Text="EUA" />
            <asp:ListItem Text="España" />
        </asp:DropDownList>
        <asp:Button ID="btnEnv" runat="server" Text="Agregar Pelicula" OnClick="agregarPeli" />
        <br />
        <br />
        <br />
        <table>
            <tr>
                <td>Id</td>
                <td>Nombre</td>
                <td>País</td>
            </tr>
            <asp:Label id="contPeliculas" runat="server" />
        </table>

    </div>
</asp:Content>