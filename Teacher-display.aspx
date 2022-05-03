<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Teacher-display.aspx.vb" Inherits="Student_data.Teacher_display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Teacher Display</title>
    <link rel="stylesheet" href="Display-style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="Teacher-main-container">
            <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" AutoGenerateSelectButton="True">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" ForeColor="White" Font-Bold="True" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C"  ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
        </div>
         <div class="info">
            <div class="combine-input-teacher">
                <asp:Label ID="Label1" runat="server" Text="Teacher ID"></asp:Label>
                <asp:TextBox ID="Teacher_id__delete" runat="server" CssClass="input-container" Width="150px" Enabled="False"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="Teacher Name"></asp:Label>
                <asp:TextBox ID="Teacher_name_delete" runat="server" CssClass="input-container" Width="150px"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="Department"></asp:Label>
                <asp:TextBox ID="Department_delete" runat="server" CssClass="input-container" Width="150px"></asp:TextBox>
                <asp:Button ID="Teacher_delete_button" runat="server" Text="DELETE" CssClass="btn-style" />
                <asp:Button ID="Teacher_update_button" runat="server" CssClass="btn-style" Text="UPDATE" />   
                <asp:Button ID="Teacher_cancel_button" runat="server" CssClass="btn-style-cancel" Text="CANCEL"  />
            </div>
        </div>
    </form>
</body>
</html>
