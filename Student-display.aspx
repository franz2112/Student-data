<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Student-display.aspx.vb" Inherits="Student_data.Student_display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Display</title>
    <link rel="stylesheet" href="Display-style.css" />
</head>
<body>
    <form id="form1" runat="server">
         <div class="Student-main-container">
            <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" AutoGenerateSelectButton="True">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" ForeColor="White" />
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
            <div class="combine-input">
                <asp:Label ID="Label1" runat="server" Text="Student ID"></asp:Label>
                <asp:TextBox ID="Student_delete_id" runat="server" CssClass="input-container" Width="150px" Enabled="False"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="Student Name"></asp:Label>
                <asp:TextBox ID="Student_name_delete" runat="server" CssClass="input-container" Width="150px"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="Year"></asp:Label>
                <asp:TextBox ID="Year_delete" runat="server" CssClass="input-container" Width="150px"></asp:TextBox>
                <asp:Button ID="Student_delete" runat="server" Text="DELETE" CssClass="btn-style" />
                <asp:Button ID="studentUpdatebtn" runat="server" CssClass="btn-style" Text="UPDATE" />   
                <asp:Button ID="Button2" runat="server" CssClass="btn-style-cancel" Text="CANCEL"  />
            </div>
        </div>
    </form>
     
</body>
</html>
