<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Subject-display.aspx.vb" Inherits="Student_data.Subject_display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Display-style.css" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: relative;
            margin-left: 5pt;
            top: -60px;
            line-height: 50px;
            padding: 0 10px;
            background: #fb966d;
            letter-spacing: 2px;
            transition: .2s all ease-in-out;
            outline: none;
            box-shadow: 3px 3px 1px #95a4ff, 3px 3px 1px 1px rgba(0,0,0,1);
            left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div class="Subject-main-container">
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
         <div class="info-subject">
            <div class="combine-input">
                <asp:Label ID="Label1" runat="server" Text="Subjectcode"></asp:Label>
                <asp:TextBox ID="Subject_code" runat="server" CssClass="input-container" Width="150px" Enabled="False"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
                <asp:TextBox ID="Subject_description" runat="server" CssClass="input-container" Width="150px"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="Units"></asp:Label>
                <asp:TextBox ID="Subject_units" runat="server" CssClass="input-container" Width="150px"></asp:TextBox>
                <br />
                <div class="combine-input-2">
                    <asp:Label ID="Label4" runat="server" Text="Teacher"></asp:Label>
                    <asp:TextBox ID="Subject_teacher" runat="server" Width="150px" CssClass="input-container-teacher"></asp:TextBox>
                    <asp:Label ID="Label5" runat="server" Text="Day"></asp:Label>
                    <asp:TextBox ID="Subject_day" runat="server" CssClass="input-container-day" Width="150px"></asp:TextBox>
                    <asp:Label ID="Label6" runat="server" Text="Time"></asp:Label>
                    <asp:TextBox ID="Subject_time" runat="server" CssClass="input-container-time" Width="150px"></asp:TextBox>
                    <br />
                </div>
            </div>  
             <div class="buttons-3">
                <asp:Button ID="Subject_delete" runat="server" Text="DELETE" CssClass="btn-style-subject" />
                <asp:Button ID="Subject_update" runat="server" CssClass="btn-style-subject" Text="UPDATE" />   
                <asp:Button ID="Subject_cancel" runat="server" CssClass="buttons-subject-cancel" Text="CANCEL"  />
            </div>     
        </div>
       
    </form>
</body>
</html>
