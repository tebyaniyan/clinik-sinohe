<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="select type nobat.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
    <div style="z-index: 102; left: 380px; width: 375px; position: absolute; top: 8px; height: 194px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <table style="width: 387px; text-align: right; margin-right: 71px;">
            <tr>
                <td align="center" colspan="2">
                    &nbsp; &nbsp; انتخاب نوع نوبت دهی&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <img alt="" src="images/header.png" style="width: 381px; height: 5px" /></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Label ID="lblmsg" runat="server" Font-Size="Small" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 106px">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="18px" Width="171px">
                    </asp:DropDownList>
                </td>
                <td style="width: 132px">
                    <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" 
                        oncheckedchanged="RadioButton1_CheckedChanged" Text="تخصص" TextAlign="Left" />
                </td>
            </tr>
            <tr>
                <td style="width: 106px">
                    <asp:TextBox ID="lastname" runat="server" Width="170px"></asp:TextBox>
                </td>
                <td style="width: 132px">
                    <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" 
                        oncheckedchanged="RadioButton2_CheckedChanged" Text="شماره نظام پزشکی" 
                        TextAlign="Left" />
                </td>
            </tr>
            <tr>
                <td style="width: 106px">
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="18px" Width="171px">
                    </asp:DropDownList>
                </td>
                <td style="width: 132px">
                    <asp:RadioButton ID="RadioButton3" runat="server" AutoPostBack="True" 
                        oncheckedchanged="RadioButton3_CheckedChanged" Text="نام پزشک" 
                        TextAlign="Left" />
                </td>
            </tr>
            <tr>
                <td style="width: 106px; height: 32px;">
                    &nbsp;</td>
                <td style="height: 32px; width: 132px;">
                    <asp:Button ID="Button1" runat="server" Font-Size="Small" Text="نمایش نوبت" 
                        onclick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td style="width: 106px">
                    &nbsp;</td>
                <td style="width: 132px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 106px">
                    &nbsp;</td>
                <td style="width: 132px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 106px; height: 19px">
                    &nbsp;</td>
                <td style="height: 19px; width: 132px;">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 106px">
                    &nbsp;</td>
                <td style="width: 132px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 106px">
                </td>
                <td style="width: 132px">
                    &nbsp;</td>
            </tr>
        </table>
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

