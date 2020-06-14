<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListadodeSupervisor.aspx.cs" Inherits="TPC_RodriguezLeandro.ListadodeSupervisor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView CssClass="table" ID="dgvSupervisor" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="ID" DataField="ID" />
            <asp:BoundField HeaderText="Usuario" DataField="Usuario" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombres" />
            <asp:BoundField HeaderText="Apellidos" DataField="Apellidos" />
            <asp:BoundField HeaderText="Tipo de usuario" DataField="Tipodeusuario.Nombre" />
        </Columns>
    </asp:GridView>
</asp:Content>
