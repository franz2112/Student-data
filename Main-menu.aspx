<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Main-menu.aspx.vb" Inherits="Student_data.Main_menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title>Student</title>
    <link rel="stylesheet" href="Student-style.css" />
</head>
<body>
   
    <form id="form1" runat="server">
        <div>
            <div class="main-container">
                <div class="std-container">
                    <asp:Label ID="StudentLabel" runat="server" Text="Student"></asp:Label>                
                    <asp:Button class="btn-style" ID="AddBtnSt" runat="server" Text="Add Student" />             
                    <asp:Button class="btn-style" ID="DisBtnSt" runat="server" Text="Display Student" />
                    <br />
                </div>
                <div class="sub-container">
                    <asp:Label ID="SubjectLabel" runat="server" Text="Subject"></asp:Label>
                    <br />
                    <asp:Button class="btn-style" ID="AddBtnSu" runat="server" Text="Add Subject" />                   
                    <asp:Button class="btn-style" ID="DisBtnSu" runat="server" Text="Display Subject" />
                    <br />
                </div>
                <div class="tea-container">
                    <asp:Label ID="TeacherLabel" runat="server" Text="Teacher"></asp:Label>
                    <br />
                    <asp:Button class="btn-style" ID="AddBtnTe" runat="server" Text="Add Teacher" />                   
                    <asp:Button class="btn-style" ID="DisBtnTe" runat="server" Text="Display Teacher" />
                </div>
                
            </div>
        </div>
    </form>
    <div class="info">
        <h1>Student Profile</h1>
    </div>
    <div class="card-header">
        <img class="profile_img" src="20171230_140211.jpg"/> 
    </div>
</body>
</html>
