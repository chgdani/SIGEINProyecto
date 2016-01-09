<%@ Page Title="" Language="C#" MasterPageFile="~/Usuario.Master" AutoEventWireup="true" CodeBehind="ReportarAveria.aspx.cs" Inherits="SIGEIN.RepostarAveria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div><label>Departamento<br />
                </label><input type='text' value='' style="width: 181px"/></div>
            <div><label>Activo<br />
                </label><input type='text' value='' style="width: 181px"/></div>
            <div><label>Descripción:<br />
                </label>
                <textarea rows='6' style="width: 196px"></textarea></div>
            <div><input type='submit' value='Reportar Avería'/></div>


</asp:Content>
