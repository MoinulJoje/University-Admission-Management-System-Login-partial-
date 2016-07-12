<%@ Page Title="Admin Login" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="login.aspx.cs" Inherits="_Default3" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            height: 209px;
            margin-left: 304px;
            width: 480px;
        }
        .style10
        {
            width: 56px;
        }
        .style28
        {
            width: 129px;
        }
        .style35
        {
            width: 117px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
        <asp:Panel ID="Panel1" runat="server" Height="572px" BackColor="White">

    <table class="style1" align=center bgcolor="#CCCCFF" >
        <tr >
            <td class="style28" >
                Userid:</td>
            <td >
                <asp:TextBox ID="userid" runat="server" style="height: 22px"></asp:TextBox>
            </td>
            <td class="style35" >
                <asp:RequiredFieldValidator ID="useridvalidator" runat="server" 
                    ErrorMessage="Enter userid" ControlToValidate="userid"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr >
            <td class="style28">
                        Password:</td>
            <td class="style10">
                <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td class="style35" >
                <asp:RequiredFieldValidator ID="passvalidator" runat="server" 
                    ErrorMessage="Enter password" ControlToValidate="password"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr >
            <td class="style28" >
                &nbsp;</td>
            <td >
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        <asp:Button ID="login" runat="server" onclick="login_Click" Text="log in" 
                            Font-Bold="True" Font-Size="Small" ForeColor="Black" 
                    CssClass="login" />
            </td>
        </tr>
    </table></asp:Panel>

        <asp:Panel ID="Panel2" runat="server" Height="572px" BackColor="White">
<table class="style1" align=center bgcolor="#CCCCFF" >
        <tr >
            <td class="style28" >
                Enter csv file location:</td>
            <td >
                <asp:TextBox ID="TextBox1" runat="server" style="height: 22px"></asp:TextBox>
            </td>
            <td class="style35" >
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ErrorMessage="Enter valid location" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr >
            <td class="style28">
                        Enter table name:</td>
            <td class="style10">
                <asp:TextBox ID="TextBox2" runat="server" style="height: 22px"></asp:TextBox>
            </td>
            <td class="style35" >
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ErrorMessage="Enter table" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr >
            <td class="style28" >
                &nbsp;</td>
            <td >
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="attach" 
                            Font-Bold="True" Font-Size="Small" ForeColor="Black" 
                    CssClass="login" />
            </td>
        </tr>
    </table>

</asp:panel>    

        <asp:Panel ID="Panel3" runat="server" Height="572px" BackColor="White">
            Your file has been attached....<br />

            <br />
            <asp:Button ID="Button4" runat="server" onclick="Button4_Click" 
                Text="Thank u" />

</asp:panel>
<asp:Panel ID="Panel4" runat="server" Height="572px" BackColor="White">
            Sorry, you are not valid admin.......
            <br />

            <br />
            <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
                Text="Thank u" />

</asp:panel>
</asp:Content>