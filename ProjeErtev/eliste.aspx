<%@ Page Title="" Language="C#" MasterPageFile="~/Ertev.Master" AutoEventWireup="true" CodeBehind="eliste.aspx.cs" Inherits="ProjeErtev.eliste" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div ID="Tablo" runat="server" ></div>
    <div class="alert alert-success" role="alert" id="basarili" runat="server" visible="false">silme işlemi Başarılı</div>
    <div class="alert alert-danger" role="alert" id="basarisiz" runat="server" visible="false">silme işlemi Başarısız</div>
</asp:Content>
