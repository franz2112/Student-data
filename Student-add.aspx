<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Student-add.aspx.vb" Inherits="Student_data.Student_add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student</title>
    <link rel="stylesheet" href="Add-design.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="su-design">
                <asp:Label ID="StuCode" runat="server" Text="Student ID"></asp:Label>
                <br />
                <asp:TextBox ID="StudentIDCode" runat="server" Width="150px" CssClass="input-container"></asp:TextBox>
                <asp:Label ID="NaCode" runat="server" Text="Student Name"></asp:Label>
                <br />
                <asp:TextBox ID="StudNameCode" runat="server" Width="150px" CssClass="input-container"></asp:TextBox>
                <asp:Label ID="YeCode" runat="server" Text="Year"></asp:Label>
                <br />
                <asp:TextBox ID="YearCode" runat="server" Width="150px" CssClass="input-container"></asp:TextBox>
            <table>
                <tr>
                    <td><asp:Button ID="StudSubmit" runat="server" CssClass="StudContainer" Text="Submit" /></td>
                    <td><asp:Button ID="StudCancel" runat="server" CssClass="StudContainer" Text="Cancel" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
