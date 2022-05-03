<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Delete db.aspx.vb" Inherits="Student_data.Delete_db" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True"></asp:GridView>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Subject code"></asp:Label>
            <asp:TextBox ID="subjcode" runat="server" Width="267px" Enabled="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="Desc" runat="server" Width="265px"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Unit"></asp:Label>
            <asp:TextBox ID="un" runat="server" Width="262px"></asp:TextBox>
            <br />
            <asp:Label ID="labelteach" runat="server" Text="teacher"></asp:Label>
            <asp:TextBox ID="teach" runat="server" Width="247px"></asp:TextBox>
            <br />
            <asp:Label ID="dalabel" runat="server" Text="day"></asp:Label>
            <asp:TextBox ID="dayy" runat="server" Width="248px"></asp:TextBox>
            <br />
            <asp:Label ID="timlabel" runat="server" Text="time"></asp:Label>
            <asp:TextBox ID="tim" runat="server" Width="242px"></asp:TextBox>
            <br />
            <asp:Button ID="updatebutton" runat="server" Text="Update" />
            <asp:Button ID="DeleteButton" runat="server" Text="Delete" />
        </div>
    </form>
</body>
</html>
