<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="nobat.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
    <div style="z-index: 102; left: 443px; width: 312px; position: absolute; top: 8px; height: 194px">
        <table style="width: 301px; text-align: right">
            <tr>
                <td align="center" colspan="2">
                    &nbsp; &nbsp; ثبت نوبت بیمار&nbsp; &nbsp;
                    <img alt="" src="images/header.png" style="width: 289px; height: 5px" /></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Label ID="lblmsg0" runat="server" Font-Size="Small" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 199px">
                    <asp:TextBox ID="name" runat="server" Width="170px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;<asp:Label ID="Label1" runat="server" Font-Size="Small" Text=": نام"></asp:Label>
                &nbsp;
                </td>
            </tr>
            <tr>
                <td style="width: 199px">
                    <asp:TextBox ID="lastname" runat="server" Width="170px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Font-Size="Small" Text=" : نام خانوادگی"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 199px">
                    <asp:TextBox ID="tell" runat="server" Width="170px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label3" runat="server" Font-Size="Small" Text=": تلفن ثابت"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 199px; height: 32px;">
                    <asp:TextBox ID="mob" runat="server" Width="170px"></asp:TextBox>
                </td>
                <td style="height: 32px">
                    <asp:Label ID="Label4" runat="server" Font-Size="Small" Text=": تلفن همراه "></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 199px">
                    <asp:Label ID="lblmsg" runat="server" Font-Size="Small" ForeColor="Red"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Font-Size="Small" Text="ثبت نوبت" 
                        onclick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td style="width: 199px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 199px; height: 19px">
                    &nbsp;</td>
                <td style="height: 19px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 199px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 199px">
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
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
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
&nbsp;
</asp:Content>

