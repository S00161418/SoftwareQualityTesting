<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    
        <asp:Label ID="Label2" runat="server" Text="Gender"></asp:Label>

    
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />

    
        <br />
        <asp:Label  ID="Label1" runat="server" Text="Age"></asp:Label>
        <br />
        <asp:TextBox ID="tbxAge" runat="server"  style="margin-bottom: 0px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Premium"></asp:Label>
        <br />
        <asp:TextBox ID="tbxPremium" runat="server" Width="128px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" />
        <br />
        <br />

    
    </div>
    </form>
</body>
</html>
