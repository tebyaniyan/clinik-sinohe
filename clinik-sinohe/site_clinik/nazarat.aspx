<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="nazarat.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="z-index: 102; left: 273px; width: 565px; position: absolute; top: 8px; height: 194px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
    <table style="width: 441px; text-align: right; margin-right: 71px;">
        <tr>
            <td align="center" colspan="2">
                    &nbsp; &nbsp;ارسال نظرات &nbsp;&nbsp;&nbsp;
                    <img alt="" src="images/header.png" style="width: 452px; height: 9px" /></td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Label ID="lblmsg" runat="server" Font-Size="Small" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 95px">
                &nbsp;</td>
            <td style="width: 193px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 95px">
                <asp:TextBox ID="c_r" runat="server" Width="251px" Height="210px" 
                    TextMode="MultiLine"></asp:TextBox>
            </td>
            <td style="width: 193px">
                <asp:Label ID="Label8" runat="server" Text=": متن پیشنهاد یا انتقاد"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 95px">
                    &nbsp;</td>
            <td style="width: 193px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 95px; height: 32px;">
                    &nbsp;</td>
            <td style="height: 32px; width: 193px;">
                <asp:Button ID="Button1" runat="server" Font-Size="Small" Text="ارسال" 
                        onclick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 95px">
                    &nbsp;</td>
            <td style="width: 193px">
                    &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 95px">
                    &nbsp;</td>
            <td style="width: 193px">
                    &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 95px; height: 19px">
                    &nbsp;</td>
            <td style="height: 19px; width: 193px;">
                    &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 95px">
                    &nbsp;</td>
            <td style="width: 193px">
                    &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 95px">
            </td>
            <td style="width: 193px">
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

