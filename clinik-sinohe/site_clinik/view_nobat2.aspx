<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="view_nobat2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="z-index: 102; left: 380px; width: 375px; position: absolute; top: 8px; height: 194px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
    <table style="width: 387px; text-align: right; margin-right: 71px;">
        <tr>
            <td align="center" colspan="2">
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;نمایش نوبت&nbsp; &nbsp; &nbsp;
                    <img alt="" src="images/header.png" style="width: 381px; height: 5px" /></td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Label ID="lblmsg" runat="server" Font-Size="Small" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 224px">
                &nbsp;</td>
            <td style="width: 132px">
                <asp:Label ID="Label14" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 224px">
                <asp:Label ID="Label13" runat="server"></asp:Label>
            </td>
            <td style="width: 132px">
                <asp:Label ID="Label11" runat="server" Text=": تخصص"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 224px">
                <asp:Label ID="Label12" runat="server"></asp:Label>
            </td>
            <td style="width: 132px">
                <asp:Label ID="Label10" runat="server" Text=": نام پزشک"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 224px; height: 32px;">
                <asp:Label ID="Label9" runat="server"></asp:Label>
            </td>
            <td style="height: 32px; width: 132px;">
                <asp:Label ID="Label8" runat="server" Text=": نوبت شما "></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 224px">
                &nbsp;</td>
            <td style="width: 132px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 224px">
                <asp:Button ID="Button3" runat="server" Font-Size="Small" Text="انصراف" 
                    onclick="Button3_Click" />
            </td>
            <td style="width: 132px">
                <asp:Button ID="Button2" runat="server" Font-Size="Small" Text="لغو نوبت" 
                    onclick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 224px; height: 19px">
                &nbsp;</td>
            <td style="height: 19px; width: 132px;">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 224px">
                &nbsp;</td>
            <td style="width: 132px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 224px">
            </td>
            <td style="width: 132px">
                &nbsp;</td>
        </tr>
    </table>
    <br />&nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <br />&nbsp; &nbsp; &nbsp;
        <br />&nbsp; &nbsp; &nbsp;&nbsp;<br />&nbsp; &nbsp; &nbsp;&nbsp; &nbsp;
        <asp:Label ID="Label7" runat="server" Font-Names="Tahoma" Font-Size="Medium" 
            ForeColor="White" Text="Label"></asp:Label>
</div>
</asp:Content>

