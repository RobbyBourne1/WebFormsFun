<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Practice2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Page Life Cycle</h2>
    <p>
        <asp:Label ID="labeInit" runat="server" />
    </p>
    <p>
        <asp:Label ID="lblPageLoad" runat="server" />
    </p>
    <p>
        <asp:Label ID="lblPostBack" runat="server" />
    </p>
    <p>
        <asp:Label ID="lblButtonEvent" runat="server" />
    </p>
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
</asp:Content>
