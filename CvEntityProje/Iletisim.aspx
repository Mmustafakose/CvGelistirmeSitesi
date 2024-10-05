<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="CvEntityProje.Iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div style="margin-left: 20px; margin-right: 20px">
        <table class="table table-bordered ">
            <tr>
                <th>Id</th>
                <th>Ad Soyad</th>
                <th>Mail</th>
                <th>Konu</th>
                <th>Mesajı Gör</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Id") %></td>
                        <td><%#Eval("adSoyad") %></td>
                        <td><%#Eval("mail") %></td>
                        <td><%#Eval("konu") %></td>
                        <td><a href="mesajDetay.aspx?id=<%#Eval("Id") %>" class="btn btn-warning" style="background-color:#CC6699">Mesajı Gör</a></td>

                        

                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
</asp:Content>
