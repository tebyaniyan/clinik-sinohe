<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    &nbsp;<br />
<br />
<asp:Image ID="Image2" runat="server" ImageUrl="~/images/header.png" 
            Width="217px" Height="16px" />
<br />
<asp:Image ID="Image3" runat="server" ImageUrl="~/images/panel.jpg" 
            Width="222px" Height="116px" />
        <asp:Image ID="Image4" runat="server" ImageUrl="~/images/header2.png" 
            Width="215px" Height="16px" />
        <div style="z-index: 102; left: 14px; width: 192px; position: absolute; top: 383px; height: 241px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="lblmsg" runat="server" Font-Names="Tahoma" Font-Size="X-Small" 
                ForeColor="Red" Height="16px" Width="170px"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Font-Names="Tahoma" 
                Font-Size="X-Small" Width="119px"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Font-Names="Tahoma" Font-Size="X-Small" 
                ForeColor="Red" Text="نام کاربری"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Font-Names="Tahoma" 
                Font-Size="X-Small" TextMode="Password" Width="119px"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Font-Names="Tahoma" Font-Size="X-Small" 
                ForeColor="Red" Text="رمز عبور"></asp:Label>
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="25px" 
                ImageUrl="~/images/go.png" onclick="ImageButton1_Click" ToolTip="ورود" 
                Width="63px" />
            <br />
            <br />
            &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
            <br />
            &nbsp; &nbsp; &nbsp;
            <br />
            &nbsp; &nbsp; &nbsp;&nbsp;<br />
            &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;
            <asp:Label ID="Label7" runat="server" Font-Names="Tahoma" Font-Size="Medium" 
                ForeColor="White" Text="Label"></asp:Label>
</div>
<br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Image ID="Image5" runat="server" ImageUrl="~/images/menus/menu-news.jpg" 
    Width="157px" />
<asp:DataGrid ID="GridView1" Runat="Server" AllowSorting="True" 
    CellPadding="4" ForeColor="#333333" ShowFooter="True" Width="847px" 
        GridLines="None" UseAccessibleHeader="True">
    <AlternatingItemStyle BackColor="White" />
    <FooterStyle BackColor="#990000" BorderColor="White" ForeColor="White" 
        Font-Bold="True" />
    <HeaderStyle BackColor="#990000" BorderColor="#FF8080" ForeColor="White" 
        Font-Bold="True" />
    <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
    <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
</asp:DataGrid>
<br />
<br />
</asp:Content>

