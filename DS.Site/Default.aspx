<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">

</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
<h3>Cart</h3>

    Cart ID: <asp:Label ID="lblCartID" runat="server" /> <br />
    Create Date: <asp:Label ID="lblCreateDate" runat="server" /> <br />
    Modify Date: <asp:Label ID="lblModifyDate" runat="server" /> <br />
    Total: $<asp:Label ID="lblTotal" runat="server" /> <br />

    <asp:GridView ID="gvCart" runat="server" AutoGenerateColumns="false" DataKeyNames="ProductID">
    <Columns>
        <asp:BoundField DataField="ProductID" HeaderText="ID" />
        <asp:BoundField DataField="ProductNumber" HeaderText="Product Number" />
        <asp:BoundField DataField="Name" HeaderText="Name" />
        <asp:BoundField DataField="Description" HeaderText="Description" />
        <asp:BoundField DataField="Price" HeaderText="Price" />
        <asp:TemplateField>
            <ItemTemplate>
                <a href="Default.aspx?action=RemoveProduct&productID=<%# Eval("ProductID") %>">Remove</a>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>

    <asp:Button ID="btnCreateCart" Text="Create Cart" OnClick="btnCreateCart_Click1" runat="server" />
<h3>Products</h3>
<asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="false" DataKeyNames="ProductID">
    <Columns>
        <asp:BoundField DataField="ProductID" HeaderText="ID" />
        <asp:BoundField DataField="ProductNumber" HeaderText="Product Number" />
        <asp:BoundField DataField="Name" HeaderText="Name" />
        <asp:BoundField DataField="Description" HeaderText="Description" />
        <asp:BoundField DataField="Price" HeaderText="Price" />
        <asp:TemplateField>
            <ItemTemplate>
                <a href="Default.aspx?action=AddProduct&productID=<%# Eval("ProductID") %>">Add</a>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
</asp:Content>