<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Week 15.aspx.vb" Inherits="Student_data.Week_15" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
</title>
    <link rel="stylesheet" href="Week 15 design.css" />
</head>
<body>   
    <form id="form1" runat="server">
        <div class="main-furniture">
            <div class="display-design">
               
                <div class="container">
                    <asp:Label ID="Label1" runat="server" Text="Item No." ></asp:Label>
                    <asp:TextBox ID="Item_text" runat="server" CssClass="input-furniture"></asp:TextBox>
                    <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
                    <asp:TextBox ID="Desc_text" runat="server" CssClass="input-furniture"></asp:TextBox>
                    <asp:Label ID="Label3" runat="server" Text="Unit Price"></asp:Label>
                    <asp:TextBox ID="Unit_text" runat="server" CssClass="input-furniture"></asp:TextBox>
                    <asp:Label ID="Label4" runat="server" Text="Quantity"></asp:Label>
                    <asp:TextBox ID="Quan_text" runat="server" CssClass="input-furniture"></asp:TextBox>
                    <br />
                </div>
                <hr />
                <div class="buttonsii-furniture-container">
                   <asp:Button ID="Button1Add" runat="server" Text="Add" CssClass="buttons-furniture" Width="138px" />
                   <asp:Button ID="Button3Update" runat="server" Text="Update"  CssClass="buttons-furniture" Width="138px" />
                   <asp:Button ID="Button2Delete" runat="server" Text="Delete" CssClass="buttons-furniture" Width="138px" />
                   <asp:Button ID="Button4clear" runat="server" Text="Refresh"  CssClass="buttons-furniture" Width="138px" />
                   <asp:DropDownList ID="DropDownList1" runat="server" CssClass="buttons-furniture" Width="294px" AutoPostBack="True" OnSelectedIndexChanged="OnSelectedIndexChange" DataSourceID="SqlDataSource1" DataTextField="Customername" DataValueField="Customername" Height="30px"></asp:DropDownList>
                   <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:solmayorConnectionString %>" ProviderName="<%$ ConnectionStrings:solmayorConnectionString.ProviderName %>" SelectCommand="getCustomerName" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                </div>   
            </div>
            <div class="grid-design">
                
                <asp:GridView ID="GridView1" runat="server" CssClass="table-furniture" CellPadding="10" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" CellSpacing="1" ShowFooter="True">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#fffcdc" Font-Bold="True" ForeColor="Black" />
                <HeaderStyle BackColor="#e6e1bc" Font-Bold="True" ForeColor="Black" />
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
