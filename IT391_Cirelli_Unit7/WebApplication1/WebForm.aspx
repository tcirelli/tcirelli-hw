<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="WebApplication1.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p><br /> Course: Math 100 </p>
    <p> Thitapron Cirelli </p>

    <form id="form1" runat="server">
        <p> 
            Average Final Grade: <asp:TextBox ID ="txtAverageGrade" runat = "server"></asp:TextBox>
        </p>

         <p> 
            Highest Grade: <asp:TextBox ID ="txtHighestGrade" runat = "server"></asp:TextBox>
        </p>

         <p> 
            Lowest Grade: <asp:TextBox ID ="txtLowestGrade" runat = "server"></asp:TextBox>
        </p>

        <div>
        </div>
    </form>
</body>
</html>
