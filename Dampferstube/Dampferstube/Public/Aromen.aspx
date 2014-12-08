<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Aromen.aspx.cs" Inherits="Dampferstube.Public.Aromen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>

   <thead><tr><th>Nachname</th><th>Vorname</th><th>Aroma</th></tr></thead>
    <asp:Repeater ID="Repeater1" runat="server" >
        <ItemTemplate>
            <tr> <td>
                     <%# Eval("Besitzer1.Nachname") %>
                </td>
                <td>
                     <%# Eval("Besitzer1.Vorname") %>
                </td>
                <td>
                    <%# Eval("Aroma_name") %>
                </td>
            </tr>
        </ItemTemplate>
    </asp:Repeater>
    </table>

    </asp:Content>
