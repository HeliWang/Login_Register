<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Default2" MasterPageFile="~/MasterPage.master" %>
<asp:Content ID="login" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <div class="auto-style5">
    
        <div class="auto-style6">
            <span class="auto-style1">Login Page</span><br class="auto-style1" />
        </div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Username：</td>
                <td class="auto-style7">
                    <asp:TextBox ID="lusername" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="lusername" ErrorMessage="Userame Required"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Password：</td>
                <td class="auto-style7">
                    <asp:TextBox ID="lpassword" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lpassword" ErrorMessage="Password Required"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Height="25px" OnClick="Button1_Click" Text="Login" Width="90px" />
&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx">New User</asp:HyperLink>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
</asp:Content>