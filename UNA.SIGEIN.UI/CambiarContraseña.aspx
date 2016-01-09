<%@ Page Title="" Language="C#" MasterPageFile="~/Usuario.Master" AutoEventWireup="true" CodeBehind="CambiarContraseña.aspx.cs" Inherits="SIGEIN.CambiarContraseña" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div><label>Contraseña Actual<br />
    </label><input type='text' value=''/></div>
            <div><label>Contraseña Nueva<br />
                </label><input type='text' value=''/></div>
            <div><label>Confirme su Contraseña<br />
                </label><input type='text' value=''/></div>      
            <div><input type='submit' value='Cambiar'/></div>
</asp:Content>
