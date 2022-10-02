<%@ Page Title="" Language="C#" MasterPageFile="~/Ertev.Master" AutoEventWireup="true" CodeBehind="eguncelle.aspx.cs" Inherits="ProjeErtev.eguncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="alert alert-success" role="alert" id="basarili" runat="server" visible="false">Güncelle işlemi Başarılı</div>
    <div class="alert alert-danger" role="alert" id="basarisiz" runat="server" visible="false">Güncelle işlemi Başarısız</div>

        <table class="w-100 table table-dark table-bordered table-hover">
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Eğitim Türü"></asp:Label>
        </td>
        <td class="auto-style2">:</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label2" runat="server" Text="Eğitim Adi"></asp:Label>
        </td>
        <td class="auto-style2">:</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label3" runat="server" Text="Tarih"></asp:Label>
        </td>
        <td class="auto-style2">:</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Date"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label4" runat="server" Text="Öğrenci Sayısı"></asp:Label>
        </td>
        <td class="auto-style2">:</td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server" TextMode="Number"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label5" runat="server" Text="İçerik"></asp:Label>
        </td>
        <td class="auto-style2">:</td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label7" runat="server" Text="Eğitim kodu"></asp:Label>
        </td>
        <td class="auto-style2">:</td>
        <td>
            <asp:TextBox ID="TextBox6" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Güncelle" class="btn btn-warning" />
            <asp:Label ID="Label6" runat="server"></asp:Label>
        </td>
    </tr>
</table>

    
</asp:Content>
