<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="SIGEIN.Principal1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css.tryLogin.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
</asp:Login>
<br />
 
   
    
    <br />
  

</asp:Content>
