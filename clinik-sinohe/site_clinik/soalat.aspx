<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="soalat.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="z-index: 102; left: 218px; width: 452px; position: absolute; top: -11px; height: 657px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
    <table style="width: 427px; text-align: right; margin-right: 71px;">
        <tr>
            <td align="center" colspan="2">
                    &nbsp; ارسال سوالات&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <img alt="" src="images/header.png" style="width: 423px; height: 9px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Label ID="lblmsg" runat="server" Font-Size="Small" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">
                &nbsp;</td>
            <td style="width: 193px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 155px">
                <asp:TextBox ID="c_r" runat="server" Width="282px" Height="181px" 
                    TextMode="MultiLine"></asp:TextBox>
            </td>
            <td style="width: 193px">
                <asp:Label ID="Label8" runat="server" Text=": متن سوال"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 155px">
                    &nbsp;</td>
            <td style="width: 193px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        </tr>
        <tr>
            <td style="width: 155px; height: 32px;">
                    <asp:Label ID="lblmsg0" runat="server" Font-Size="Small" ForeColor="Red"></asp:Label>
            </td>
            <td style="height: 32px; width: 193px;">
                <asp:Button ID="Button1" runat="server" Font-Size="Small" Text="ارسال" 
                        onclick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
       
    </table>
    <table style="width: 427px; text-align: right; margin-right: 71px;">
        <tr>
            <td align="center" colspan="2">
                    <br />
                    <br />
                    <br />
                    &nbsp; پیگیری سوالات&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
                    <img alt="" src="images/header.png" style="width: 423px; height: 9px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Label ID="lblmsg1" runat="server" Font-Size="Small" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 128px">
                <asp:TextBox ID="c_" runat="server" Width="275px"></asp:TextBox>
            </td>
            <td style="width: 193px">
                <asp:Label ID="Label10" runat="server" Text=": کد رهگیری "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        </tr>
        <tr>
            <td style="width: 128px">
                <asp:TextBox ID="soal" runat="server" Width="282px" Height="210px" 
                    TextMode="MultiLine" Enabled="False"></asp:TextBox>
            </td>
            <td style="width: 193px">
                <asp:Label ID="Label9" runat="server" Text=": متن سوال"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 128px">
                    <asp:TextBox ID="javab" runat="server" Height="190px" TextMode="MultiLine" 
                        Width="282px" Enabled="False"></asp:TextBox>
            </td>
            <td style="width: 193px">
                <asp:Label ID="Label11" runat="server" Text=": جواب"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        </tr>
        <tr>
            <td style="width: 128px; height: 32px;">
                    &nbsp;</td>
            <td style="height: 32px; width: 193px;">
                <asp:Button ID="Button2" runat="server" Font-Size="Small" Text="نمایش" 
                        onclick="Button2_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 128px">
                    &nbsp;</td>
            <td style="width: 193px">
                    &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 128px">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td style="width: 193px">
                    &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 128px; height: 19px">
                    &nbsp;</td>
            <td style="height: 19px; width: 193px;">
                    &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 128px">
                    &nbsp;</td>
            <td style="width: 193px">
                    &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 128px">
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

