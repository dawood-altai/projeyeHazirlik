<%@ Page Title="" Language="C#" MasterPageFile="~/Ertev.Master" AutoEventWireup="true" CodeBehind="eekle.aspx.cs" Inherits="ProjeErtev.eekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 302px;
    }
    .auto-style2 {
        width: 75px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="alert alert-success" role="alert" id="basarili" runat="server" visible="false">Kayıt işlemi Başarılı</div>
    <div class="alert alert-danger" role="alert" id="basarisiz" runat="server" visible="false">Kayıt işlemi Başarısız</div>

    <table class="w-100 table table-bordered table-dark table-hover">
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Eğitim Türü"></asp:Label>
        </td>
        <td class="auto-style2">:</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Boş geçirilmez" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label2" runat="server" Text="Eğitim Adi"></asp:Label>
        </td>
        <td class="auto-style2">:</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Boş geçirilmez" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label3" runat="server" Text="Tarih"></asp:Label>
        </td>
        <td class="auto-style2">:</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Date"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Boş geçirilmez" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label4" runat="server" Text="Öğrenci Sayısı"></asp:Label>
        </td>
        <td class="auto-style2">:</td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Boş geçirilmez" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label5" runat="server" Text="İçerik"></asp:Label>
        </td>
        <td class="auto-style2">:</td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="Boş geçirilmez" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label7" runat="server" Text="Eğitim kodu"></asp:Label>
        </td>
        <td class="auto-style2">:</td>
        <td>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" ErrorMessage="Boş geçirilmez" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Kaydet" class="btn btn-warning" />
            <asp:Label ID="Label6" runat="server"></asp:Label>
        </td>
    </tr>
</table>
    
&nbsp;
</asp:Content>
