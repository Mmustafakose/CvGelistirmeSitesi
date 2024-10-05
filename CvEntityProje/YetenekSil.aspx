<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YetenekSil.aspx.cs" Inherits="CvEntityProje.YetenekSil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div style="margin-left: 20px; margin-right: 20px">
        <h4>Silme işlemi başarısız. Geçerli bir yetenek bulunamadı.</h4>
        <br />


        <br />
        <asp:Button ID="Button1" runat="server" Text="Geri Dön" CssClass="btn btn-info" OnClick="btn_GeriDon_Click" />
    </div>


</asp:Content>
