<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yeteneklerim.aspx.cs" Inherits="CvEntityProje.Hakkimda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <div style="margin-left:20px; margin-right:20px">
        <table class="table table-bordered "  >
            <tr>
                <th>Id</th>
                <th>Yetenek</th>
                <th>Sil</th>
                <th>Güncelle</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Id") %></td>
                        <td><%#Eval("Yetenek") %></td>
            
                        <td><a href="YetenekSil.aspx?id=<%#Eval("Id") %>" class="btn btn-danger">Sil</a></td>
                        
                        <td><a href="YetenekGüncelle.aspx?id=<%#Eval("Id") %>"  class="btn btn-success">Güncelle</a></td>
                    
                    </tr>
                </ItemTemplate>
            </asp:Repeater>

            
        </table>
        
        <a href="yeniYetenekEkle.aspx" class="btn btn-primary" >Yeni Yetenek Ekle</a>
    </div>
</asp:Content>
