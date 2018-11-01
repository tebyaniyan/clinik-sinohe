<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="list_p.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Image ID="Image5" runat="server" ImageUrl="~/images/menus/menu-listkala.jpg" 
    Width="157px" />
<asp:DataGrid ID="GridView1" Runat="Server" AllowSorting="True" 
    CellPadding="4" ForeColor="#333333" ShowFooter="True" Width="827px" 
        GridLines="Horizontal" UseAccessibleHeader="True" BorderWidth="1px" 
    BorderStyle="None">
    <FooterStyle BackColor="#CCCC99" BorderColor="White" ForeColor="Black" />
    <HeaderStyle BackColor="#333333" BorderColor="#FF8080" 
        Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="White" ForeColor="Black" 
        HorizontalAlign="Right" />
    <SelectedItemStyle BackColor="#CC3333" ForeColor="White" Font-Bold="True" />
</asp:DataGrid>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
روزهای حضور پزشکان<br />
<asp:DataGrid ID="GridView2" Runat="Server" AllowSorting="True" 
    CellPadding="4" ForeColor="#333333" ShowFooter="True" Width="827px" 
        UseAccessibleHeader="True" BorderWidth="1px" 
    BorderStyle="None">
    <FooterStyle BackColor="#99CCCC" BorderColor="White" ForeColor="#003399" />
    <HeaderStyle BackColor="#003399" BorderColor="#FF8080" 
        Font-Bold="True" ForeColor="#CCCCFF" />
    <ItemStyle BackColor="White" ForeColor="#003399" />
    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" 
        HorizontalAlign="Left" Mode="NumericPages" />
    <SelectedItemStyle BackColor="#009999" ForeColor="#CCFF99" Font-Bold="True" />
</asp:DataGrid>
</asp:Content>

