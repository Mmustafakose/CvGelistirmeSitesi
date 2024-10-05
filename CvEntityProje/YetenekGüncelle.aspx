<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YetenekGüncelle.aspx.cs" Inherits="CvEntityProje.YetenekGüncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="margin-left: 20px; margin-right: 20px">
    <h4>Yetenek Güncelleme Sayfası</h4>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Yetenek: "></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form form-control"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-primary"  OnClick="btnGuncelle_Click"/>
</div>

</asp:Content>
