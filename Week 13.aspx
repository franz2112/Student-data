<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Week 13.aspx.vb" Inherits="Student_data.Week_13" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Items</title>
    <link rel="stylesheet" href="Week 13 design.css" />
</head>
<body>   
    <form id="form1" runat="server">
        <div class="main-grocery">
            <div class="display-design">
                <img class="profile_img" src="grocery-logo-png.png"/> 
                <div class="container">
                    <asp:Label ID="Label1" runat="server" Text="Item No." ></asp:Label>
                    <asp:TextBox ID="Item_text" runat="server" CssClass="input-grocery"></asp:TextBox>
                    <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
                    <asp:TextBox ID="Desc_text" runat="server" CssClass="input-grocery"></asp:TextBox>
                    <asp:Label ID="Label3" runat="server" Text="Unit Price"></asp:Label>
                    <asp:TextBox ID="Unit_text" runat="server" CssClass="input-grocery"></asp:TextBox>
                    <asp:Label ID="Label4" runat="server" Text="Quantity"></asp:Label>
                    <asp:TextBox ID="Quan_text" runat="server" CssClass="input-grocery"></asp:TextBox>
                    <br />
                </div>
                <hr />
                <div class="buttons-grocery-container">
                   <asp:Button ID="Button1Add" runat="server" Text="Add" CssClass="buttons-grocery" Width="146px" />
                   <asp:Button ID="Button3Update" runat="server" Text="Update"  CssClass="buttons-grocery" Width="146px" />
                   <asp:Button ID="Button2Delete" runat="server" Text="Delete" CssClass="buttons-grocery" Width="146px" />
                   <asp:Button ID="Button4clear" runat="server" Text="Clear"  CssClass="buttons-grocery" Width="146px" />
                </div>   
            </div>
            <div class="grid-design">

           
                <asp:GridView ID="GridView1" runat="server" CssClass="table-grocery" CellPadding="14" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" CellSpacing="1">
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>  
             </div>
        </div>                     
    </form>
</body>
</html>
