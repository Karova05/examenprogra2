<%@ Page Title="" Language="C#" MasterPageFile="~/menu.Master" AutoEventWireup="true" CodeBehind="equipo.aspx.cs" Inherits="examenprogra2.equipo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container text-center">
        
      <h1>  equipo </h1>
        <p>&nbsp;</p>
        </div>
        <div>
        <br />
        <br />
        <asp:GridView runat="server" ID="datagrid" PageSize="10" HorizontalAlign="Center"
            CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header"
            RowStyle-CssClass="rows" AllowPaging="True" />

        <br />
        <br />
        <br />

    </div>

    <div class="container text-center">
        id: <asp:TextBox ID="tid" class="form-control" runat="server"></asp:TextBox>
        nombre: <asp:TextBox ID="tnombre" class="form-control" runat="server"></asp:TextBox>

      </div>

    <div class="container text-center">

        <asp:Button ID="Button1" class="btn btn-outline-primary" runat="server" Text="agregar" />
        <asp:Button ID="Button2" class="btn btn-outline-secondary" runat="server" Text="borrar" />
        <asp:Button ID="Button3" runat="server" class="btn btn-outline-secondary" Text="modificar" />
        <asp:Button ID="Bconsulta" runat="server" class="btn btn-outline-primary" Text="consultar" />
        

    </div>


   
</asp:Content>
