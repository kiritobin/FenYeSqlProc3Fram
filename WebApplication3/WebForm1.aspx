<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript"> 
　　function integer() { 
　　　　var num = document.getElementById("TextBox1").value; 
　　　　if (num=="") { 
　　　　　　alert('请输入内容'); 
　　　　　　return false; 
　　　　} 
　　　　if (!(/(^[1-9]\d*$)/.test(num))) { 
　　　　　　alert('输入的不是正整数'); 
　　　　　　return false; 
    } else {
        return true;
　　　　} 
　　} 
</script> 
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="stuNO" HeaderText="学号" />
                <asp:BoundField DataField="stuName" HeaderText="姓名" />
            </Columns>
        </asp:GridView>
        <div>
            <asp:Button ID="btnFirst" runat="server" OnClick="btnFirst_Click" Text="首页" style="height: 21px" />
            <asp:Button ID="btnPre" runat="server" OnClick="btnPre_Click" Text="上一页" />
            <asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="下一页" style="height: 21px" />
            <asp:Button ID="btnLast" runat="server" OnClick="btnLast_Click" Text="最后一页" />
            <asp:TextBox ID="TextBox1" runat="server" Width="83px"></asp:TextBox>
            <asp:Button ID="btnGO" runat="server" OnClientClick="integer()" OnClick="btnGO_Click" Text="跳转" />
            <span id="lbArea" runat='server'></span>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="每页显示条数"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem Selected="True">2</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="确认" />
        </p>
    </form>
</body>
</html>
