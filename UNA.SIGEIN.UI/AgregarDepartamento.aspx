<%@ Page Title="" Language="C#" MasterPageFile="~/Encargado.Master" AutoEventWireup="true" CodeBehind="AgregarDepartamento.aspx.cs" Inherits="SIGEIN.AgregarDepartamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 162px;
        }
        .auto-style2 {
            width: 162px;
            height: 37px;
        }
        .auto-style3 {
            height: 37px;
        }
        .auto-style4 {
            width: 162px;
            height: 35px;
        }
        .auto-style5 {
            height: 35px;
        }
        .auto-style6 {
            width: 100%;
            height: 116px;
        }
        .auto-style7 {
            height: 37px;
            width: 225px;
        }
        .auto-style8 {
            height: 35px;
            width: 225px;
        }
        .auto-style9 {
            width: 225px;
        }
        .auto-style10 {
            width: 162px;
            height: 55px;
        }
        .auto-style11 {
            height: 55px;
            width: 225px;
        }
        .auto-style12 {
            height: 55px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div>
            <table class="auto-style6">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="Codigo Departamento:"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtCodigoDepar" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label2" runat="server" Text="Nombre Departamento:"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtNombreDepar" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="Descripción:"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click1" Text="Agregar" />
                    </td>
                    <td class="auto-style11">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click1" Text="Modificar" />
                    </td>
                    <td class="auto-style12">&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click1" Text="Eliminar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click1" Text="Limpiar" />
                    </td>
                </tr>
            </table>


            <br />


         
            <br />
            <br />

           





</asp:Content>
