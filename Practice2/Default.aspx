<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Practice2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="btnRedirect" runat="server" OnClick="btnRedirect_Click" Text="Redirect" />

    <div runat="server" id="divMessage" class="message">Welcome to the ThunderDome</div>

    <br>
    <br>

    <div>
        <label>Name</label>
        <asp:TextBox ID="txtName" runat="server" />
        <asp:RequiredFieldValidator runat="server" ID="rfvName" ControlToValidate="txtName" ViewStateMode="Disabled" ErrorMessage="Required." />
    </div>
    <div>
        <label>Phone</label>
        <asp:TextBox ID="txtNumber" runat="server" />
    </div>
    <div>
        <label>Age</label>
        <asp:TextBox ID="txtAge" runat="server" />
    </div>
    <div>
       <label>Fav Color</label>
        <asp:DropDownList ID="ddColor" runat="server">
            <asp:ListItem Text="Please Choose Color" Value="" />
            <asp:ListItem Text="Blue" Value="Blue" />
            <asp:ListItem Text="Green" Value="Green" />
            <asp:ListItem Text="Purple" Value="Purple" />
            <asp:ListItem Text="Yellow" Value="Yellow" />
        </asp:DropDownList>
    </div>
    <div>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit Info" OnClick="btnSubmit_Click"/>
    </div>
    <div class="messageBox">
        <asp:Literal ID="ltMessage" runat="server" />
    </div>
    
    <br />
    <br />

    <h1>ToDo List App</h1>
    <div class="form-group">
        <label>ToDo</label>
        <asp:TextBox ID="txtToDo" runat="server" />
    </div>
    <div class="form-group">
        <label>Todo Created:</label>
        <asp:Calendar runat="server" ID="calendarToDo" />
    </div>
    <div class="form-group">
        <label>ToDo</label>
        <asp:Button ID="btnToDo" runat="server" Text="Add Event" OnClick="btnToDo_Click" />
    </div>
    <h2>ToDo's</h2>
    <div>
        <asp:Repeater ID="rptToDO" runat="server">
            <ItemTemplate>
                <h3><%# DataBinder.Eval(Container.DataItem, "ToDoDate")%> <%# DataBinder.Eval(Container.DataItem, "ToDoName")%></h3>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
