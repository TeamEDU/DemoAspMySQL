<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formMain" runat="server">
    <div>
    
        <asp:Button ID="btnAdd" runat="server" Text="Add name" OnClick="btnAdd_Click" />
        <br />
        <asp:Label ID="LabelName" runat="server" Text=" Enter your name:  "></asp:Label>
        <asp:TextBox ID="txtBoxName" runat="server" MaxLength="256"></asp:TextBox>
    
    </div>
        <asp:GridView ID="GridViewName" runat="server" Caption="Names table" Width="234px">
        </asp:GridView>
    </form>
</body>
</html>
