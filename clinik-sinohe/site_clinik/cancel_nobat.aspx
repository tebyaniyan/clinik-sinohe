<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="cancel_nobat.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="z-index: 102; left: 291px; width: 375px; position: absolute; top: 8px; height: 194px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
    <table style="width: 387px; text-align: right; margin-right: 71px;">
        <tr>
            <td align="center" colspan="2">
                    نمایش و لغو نوبت&nbsp; &nbsp;
                    <img alt="" src="images/header.png" style="width: 381px; height: 5px" /></td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Label ID="lblmsg" runat="server" Font-Size="Small" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 57px">
                &nbsp;</td>
            <td style="width: 132px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 57px">
                <asp:TextBox ID="c_r" runat="server" Width="251px"></asp:TextBox>
            </td>
            <td style="width: 132px">
                <asp:Label ID="Label8" runat="server" Text=": کد رهگیری "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 57px">
                    &nbsp;</td>
            <td style="width: 132px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 57px; height: 32px;">
                    &nbsp;</td>
            <td style="height: 32px; width: 132px;">
                <asp:Button ID="Button1" runat="server" Font-Size="Small" Text="نمایش نوبت" 
                        onclick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 57px">
                    &nbsp;</td>
            <td style="width: 132px">
                    &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 57px">
                    &nbsp;</td>
            <td style="width: 132px">
                    &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 57px; height: 19px">
                    &nbsp;</td>
            <td style="height: 19px; width: 132px;">
                    &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 57px">
                    &nbsp;</td>
            <td style="width: 132px">
                    &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 57px">
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

