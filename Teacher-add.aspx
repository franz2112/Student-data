<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Teacher-add.aspx.vb" Inherits="Student_data.Teacher_add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Teacher</title>
    <link rel="stylesheet" href="Add-design.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="su-design">
                <asp:Label ID="TeaCode" runat="server" Text="Teacher ID"></asp:Label>
                <br />
                <asp:TextBox ID="TeacherIDCode" runat="server" Width="150px" CssClass="input-container"></asp:TextBox>
                
                <asp:Label ID="NamCode" runat="server" Text="Teacher Name"></asp:Label>
                <br />
                <asp:TextBox ID="TeacherNameCode" runat="server" Width="150px" CssClass="input-container"></asp:TextBox>
                
                <asp:Label ID="DeptCode" runat="server" Text="Department"></asp:Label>
                <br />
                <asp:TextBox ID="DepartmentCode" runat="server" Width="150px" CssClass="input-container"></asp:TextBox>
                <table>
                <tr>
                    <td><asp:Button ID="TeaSubmit" runat="server" CssClass="TeachContainer" Text="Submit" /></td>
                    <td><asp:Button ID="TeaCancel" runat="server" CssClass="TeachContainer" Text="Cancel" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
