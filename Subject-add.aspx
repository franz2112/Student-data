<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Subject-add.aspx.vb" Inherits="Student_data.Subject_add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Subject</title>
    <link rel="stylesheet" href="Add-design.css" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="su-design">
                <asp:Label ID="SubjCode" runat="server" Text="Subject Code"></asp:Label>
                <br />
                <asp:TextBox ID="SubjectCode" runat="server" Width="150px" CssClass="input-container"></asp:TextBox>
                <asp:Label ID="DesCode" runat="server" Text="Description"></asp:Label>
                <br />
                <asp:TextBox ID="DescriptionCode" runat="server" Height="49px" TextMode="MultiLine" Width="150px" CssClass="input-container"></asp:TextBox>
                <asp:Label ID="UnCode" runat="server" Text="Unit"></asp:Label>
                <br />
                <asp:TextBox ID="UnitCode" runat="server" Width="150px" CssClass="input-container"></asp:TextBox>
                <asp:Label ID="TeaCode" runat="server" Text="Teacher"></asp:Label>
                <br />
                <asp:TextBox ID="TeacherCode" runat="server" Width="150px" CssClass="input-container"></asp:TextBox>
                <asp:Label ID="DaCode" runat="server" Text="Day"></asp:Label>
                <br />
                <asp:TextBox ID="DayCode" runat="server" Width="150px" CssClass="input-container"></asp:TextBox>
                <asp:Label ID="TiCode" runat="server" Text="Time"></asp:Label>
                <br />
                <asp:TextBox ID="TimeCode" runat="server" Width="150px" CssClass="input-container"></asp:TextBox>
            <table>
                <tr>
                    <td><asp:Button ID="SubjSubmit" runat="server" CssClass="SubContainer" Text="Submit" /></td>
                    <td><asp:Button ID="SubjCancel" runat="server" CssClass="SubContainer" Text="Cancel" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
