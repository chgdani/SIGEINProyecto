<%@ Page Title="" Language="C#" MasterPageFile="~/Encargado.Master" AutoEventWireup="true" CodeBehind="CrearCuenta.aspx.cs" Inherits="SIGEIN.CrearCuenta4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 48px;
        }
        .auto-style2 {
            height: 57px;
        }
        .auto-style3 {
            height: 56px;
        }
        .auto-style4 {
            height: 48px;
            width: 136px;
        }
        .auto-style5 {
            height: 57px;
            width: 136px;
        }
        .auto-style6 {
            height: 56px;
            width: 136px;
        }
        .auto-style7 {
            height: 48px;
            width: 305px;
        }
        .auto-style8 {
            height: 57px;
            width: 305px;
        }
        .auto-style9 {
            height: 56px;
            width: 305px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="Cedula:"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label3" runat="server" Text="Apellido 1:"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtApellido1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label4" runat="server" Text="Apellido 2:"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtApellido2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label5" runat="server" Text="Departamento:"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtDepartamento" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label6" runat="server" Text="Ocupación:"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtOcupacion" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label7" runat="server" Text="Contraseña:"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtContraseña" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label8" runat="server" Text="Correo:"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        </table>
        <label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
       
</asp:Content>
