<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Practice2.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <h1>State Fee Info</h1>
    
    <div class="form-group">
        <label>
            Your State
        </label>
        <asp:DropDownList ID="ddStates" OnSelectedIndexChanged="ddStates_SelectedIndexChanged" AutoPostBack="true" runat="server">
            <asp:ListItem Value="FL">Florida</asp:ListItem>
            <asp:ListItem Value="AL">Alabama</asp:ListItem>
            <asp:ListItem Value="NY">New York</asp:ListItem>
            <asp:ListItem Value="WA">Washington</asp:ListItem>
            <asp:ListItem Value="OR">Oregon</asp:ListItem>
            <asp:ListItem Value="CA">California</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="jumbotron">
        <h3>Your Custom Price <asp:Literal ID="ltCustomPrice" runat="server" Text="(select your price)"/></h3>
    </div>
</asp:Content>
