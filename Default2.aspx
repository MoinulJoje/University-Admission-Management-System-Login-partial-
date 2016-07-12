<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default2.aspx.cs" Inherits="_Default2" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            height: 209px;
            margin-left: 303px;
            width: 480px;
        }
        .style5
        {
            width: 81px;
        }
        .style6
        {
            width: 81px;
            height: 48px;
        }
        .style7
        {
            height: 48px;
            width: 68px;
        }
        .style10
        {
            width: 56px;
        }
        .style11
        {
            width: 82px;
            height: 48px;
        }
        .style12
        {
            width: 82px;
        }
        .style14
        {
            width: 141px;
            height: 48px;
        }
        .style18
        {
            width: 94px;
        }
        .style19
        {
            width: 141px;
        }
        .style20
        {
            height: 48px;
            width: 96px;
        }
        .style21
        {
            width: 96px;
        }
        .style22
        {
            width: 68px;
        }
        .style23
        {
            width: 112px;
        }
        .style24
        {
            width: 172px;
            height: 29px;
        }
        .style25
        {
            height: 29px;
            width: 173px;
        }
        .style26
        {
            width: 172px;
        }
        .style28
        {
            width: 129px;
        }
        .style29
        {
            font-size: medium;
        }
        .style30
        {
            width: 112px;
            height: 30px;
        }
        .style31
        {
            width: 94px;
            height: 30px;
        }
        .style32
        {
            width: 173px;
        }
        .style33
        {
            font-size: x-large;
        }
        .style34
        {
            font-size: large;
        }
        .style35
        {
            width: 117px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

    <div align="center">
        <asp:Panel ID="Panel1" runat="server" Height="572px" BackColor="White">



            <table class="style1" align=center bgcolor="#CCCCFF">
                <tr>
                    <td class="style28">
                        Enter HSC Roll:</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" style="height: 22px"></asp:TextBox>
                    </td>
                    <td class="style35">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="TextBox1" ForeColor="Red" style="font-weight: 700"
                            >* Enter Roll</asp:RequiredFieldValidator>
                    </td>
                    <td><asp:RegularExpressionValidator ID="RegularExpresphoneValidator2" Display="Dynamic"
ControlToValidate="TextBox1" runat="server"
SetFocusOnError="True" ValidationExpression="^\d{6}$" ForeColor="Red" CssClass="bold">* Enter Valid Roll No.</asp:RegularExpressionValidator></td>
                
                </tr>
                <tr>
                    <td class="style28">
                        Enter Passing Year:</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" >
                            <asp:ListItem>Select Year</asp:ListItem>
                            <asp:ListItem>2013</asp:ListItem>
                            <asp:ListItem>2012</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="style35"><asp:RequiredFieldValidator ID="RequiredFieldValidator15" 
                            runat="server" display="dynamic"
	ErrorMessage="Required"  ControlToValidate="DropDownList1"
	SetFocusOnError="True" InitialValue="Select Year" ForeColor="Red" CssClass="bold">* Select Year</asp:RequiredFieldValidator></td>
                
                    
                </tr>
                <tr>
                    <td class="style28">
                        Enter HSC Board:</td>
                    <td class="style10">
                        <asp:DropDownList ID="DropDownList2" runat="server" >
                            <asp:ListItem>Select Board</asp:ListItem>
                            <asp:ListItem>Chittagong</asp:ListItem>
                            <asp:ListItem>Dhaka</asp:ListItem>
                            <asp:ListItem>Rajshahi</asp:ListItem>
                            <asp:ListItem>Jessore</asp:ListItem>
                            <asp:ListItem>Barishal</asp:ListItem>
                            <asp:ListItem>Comilla</asp:ListItem>
                            <asp:ListItem>Dinajpur</asp:ListItem>
                            <asp:ListItem>Sylhet</asp:ListItem>
                            <asp:ListItem>Madrasah</asp:ListItem>
                            <asp:ListItem>Vocational</asp:ListItem>
                            </asp:DropDownList>
                    </td>
                    <td class="style35"><asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                            runat="server" display="dynamic"
	ErrorMessage="Required"  ControlToValidate="DropDownList2"
	SetFocusOnError="True" InitialValue="Select Board" ForeColor="Red" CssClass="bold">* Select Year</asp:RequiredFieldValidator></td>
                
                    
                </tr>
                <tr>
                    <td class="style28">
                        Enter SSC Roll:</td>
                    <td class="style10">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    <td class="style35">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="TextBox3" ForeColor="Red" CssClass="bold"
                            >* Enter Roll</asp:RequiredFieldValidator>
                    </td>
                    <td><asp:RegularExpressionValidator ID="RegularExpressionValidator1" Display="Dynamic"
ControlToValidate="TextBox3" runat="server"
SetFocusOnError="True" ValidationExpression="^\d{6}$" ForeColor="Red" CssClass="bold">* Enter Valid Roll No.</asp:RegularExpressionValidator></td>
                
                </tr>
                <tr>
                    <td class="style28">
                        Enter your Quota</td>
                    <td class="style10">
                        <asp:DropDownList ID="DropDownList3" runat="server">
                            <asp:ListItem>Select Quota</asp:ListItem>
                            <asp:ListItem>None</asp:ListItem>
                            <asp:ListItem>Freedom Fighter</asp:ListItem>
                            <asp:ListItem>Culture</asp:ListItem>
                            <asp:ListItem>Tribal</asp:ListItem>
                            <asp:ListItem>Sports</asp:ListItem>
                            <asp:ListItem>Autistic</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="style35"><asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
                            runat="server" display="dynamic"
	ErrorMessage="Required"  ControlToValidate="DropDownList3"
	SetFocusOnError="True" InitialValue="Select Quota" ForeColor="Red" CssClass="bold">* Select Quota</asp:RequiredFieldValidator></td>
                
                    </tr>
                <tr>
                    <td class="style28">
                        &nbsp;</td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" 
                            Font-Bold="True" Font-Size="Small" ForeColor="Black" CssClass="login" />
                    </td>
                </tr>
            </table>
            </asp:Panel>
            <br />
            <asp:Panel ID="Panel2" runat="server" Height="909px" 
            style="margin-top: 0px; font-size: medium;" ForeColor="Gray">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong><span class="style33">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
                <span class="style34">Basic Info:</span></strong>
                <table class="style1" align=center bgcolor="#CCCCFF" frame="above" border="1" 
                    cellpadding="5">
                    <tr>
                        <td class="style23">
                            Student Name</td>
                        <td class="style18">
                            <asp:Label ID="Label1" runat="server" CssClass="bold"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style23">
                            Father&#39;s Name</td>
                        <td class="style18">
                            <asp:Label ID="Label2" runat="server" CssClass="bold"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style23">
                            Mother&#39;s Name</td>
                        <td class="style18">
                            <asp:Label ID="Label3" runat="server" CssClass="bold"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style23">
                            Date of Birth</td>
                        <td class="style18">
                            <asp:Label ID="Label4" runat="server" CssClass="bold"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style23">
                            Gender</td>
                        <td class="style18">
                            <asp:Label ID="Label12" runat="server" CssClass="bold"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style23">
                            HSC Group</td>
                        <td class="style18">
                            <asp:Label ID="Label5" runat="server" CssClass="bold"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style30">
                            Quota Selection</td>
                        <td class="style31">
                            <asp:Label ID="Label6" runat="server" CssClass="bold"></asp:Label>
                        </td>
                    </tr>
                </table>
            
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong><span class="style34">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Academic 
                Info.:</span></strong><br />
                <table class="style1" align=center bgcolor="#CCCCFF" border="1" cellpadding="5">
                    <tr>
                        <td class="style6">
                            Exam Name</td>
                        <td class="style11">
                            Year</td>
                        <td class="style14">
                            Roll</td>
                        <td class="style20">
                            GPA(with 4th subject)</td>
                        <td class="style7">
                            GPA(without 4th subject)</td>
                    </tr>
                    <tr>
                        <td class="style5">
                            <strong>HSC</strong></td>
                        <td class="style12">
                            <asp:Label ID="Label13" runat="server" CssClass="bold"></asp:Label>
                        </td>
                        <td class="style19">
                            <asp:Label ID="Label14" runat="server" CssClass="bold"></asp:Label>
                        </td>
                        <td class="style21">
                            <asp:Label ID="Label15" runat="server" CssClass="bold"></asp:Label>
                        </td>
                        <td class="style22">
                            <asp:Label ID="Label16" runat="server" CssClass="bold"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            <strong>SSC</strong></td>
                        <td class="style12">
                            <asp:Label ID="Label17" runat="server" CssClass="bold"></asp:Label>
                        </td>
                        <td class="style19">
                            <asp:Label ID="Label18" runat="server" CssClass="bold"></asp:Label>
                        </td>
                        <td class="style21">
                            <asp:Label ID="Label19" runat="server" CssClass="bold"></asp:Label>
                        </td>
                        <td class="style22">
                            <asp:Label ID="Label20" runat="server" CssClass="bold"></asp:Label>
                        </td>
                    </tr>
                </table>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><span class="style34">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; HSC 
                Subjectwise GPA:</span></strong><br />
                <table class="style1" align=center bgcolor="#CCCCFF" border="1" cellpadding="5">
                    <tr>
                        <td class="style26">
                            Subject Name</td>
                        <td class="style32">
                            GPA</td>
                    </tr>
                    <tr>
                        <td class="style24">
                            <asp:Label ID="Label21" runat="server" CssClass="bold"></asp:Label>
                        </td>
                        <td class="style25">
                            <asp:Label ID="Label27" runat="server" CssClass="bold"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style26">
                            <asp:Label ID="Label22" runat="server" CssClass="bold"></asp:Label>
                        </td>
                        <td class="style32">
                            <asp:Label ID="Label28" runat="server" CssClass="bold"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style26">
                            <asp:Label ID="Label23" runat="server" CssClass="bold"></asp:Label>
                        </td>
                        <td class="style32">
                            <asp:Label ID="Label29" runat="server" CssClass="bold"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style26">
                            <asp:Label ID="Label24" runat="server" CssClass="bold"></asp:Label>
                        </td>
                        <td class="style32">
                            <asp:Label ID="Label30" runat="server" CssClass="bold"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style26">
                            <asp:Label ID="Label25" runat="server" CssClass="bold"></asp:Label>
                        </td>
                        <td class="style32">
                            <asp:Label ID="Label31" runat="server" CssClass="bold"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style26">
                            <asp:Label ID="Label26" runat="server" CssClass="bold"></asp:Label>
                        </td>
                        <td class="style32">
                            <asp:Label ID="Label32" runat="server" CssClass="bold"></asp:Label>
                        </td>
                    </tr>
                </table>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click1" 
                    Text="Evaluate" Font-Bold="True" Font-Size="Medium" ForeColor="Black" 
                    CssClass="style29" />
                </asp:Panel>
                <asp:Panel ID="Panel3" runat="server" Height="543px" 
            style="margin-top: 41px; font-size: medium;" BackColor="#CCCCFF">
                    <em><strong>Summation of SSC &amp; HSC GPA:</strong></em>
                    <asp:Label ID="Label34" runat="server" style="font-weight: 700"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label37" runat="server" Visible="False"></asp:Label>
                    &nbsp;
                    <asp:Label ID="Label38" runat="server" Visible="False"></asp:Label>
                    <br />
                    <asp:Label ID="Label35" runat="server"></asp:Label>
                    <br />
                    <asp:Button ID="Button13" runat="server" CssClass="style29" Font-Bold="True" 
                        Font-Size="Medium" onclick="Button11_Click" style="font-size: medium" 
                        Text="Home" Width="125px" />
                    <br />
                    <br />
                    <asp:Button ID="Button3" runat="server" 
                        style="margin-left: 2px; font-size: medium;" Text="A unit" 
                        Width="90px" BackColor="#669900" onclick="Button3_Click" Visible="False" />
                    <br />
                    <br />
                    <asp:Button ID="Button4" runat="server" Text="B Unit" Width="90px" 
                        BackColor="#669900" style="font-size: medium" onclick="Button4_Click" 
                        Visible="False" />
                    <br />
                    <br />
                    <asp:Button ID="Button5" runat="server" Text="C Unit" Width="90px" 
                        BackColor="#669900" CssClass="style29" onclick="Button5_Click" 
                        Visible="False" />
                    <br />
                    <br />
                    <asp:Button ID="Button6" runat="server" Text="D Unit" 
                        Width="90px" BackColor="#669900" CssClass="style29" 
                        onclick="Button6_Click" Visible="False" />
                    <br />
                    <br />
                    <asp:Button ID="Button7" runat="server" Text="E Unit" Width="90px" 
                        BackColor="#669900" CssClass="style29" onclick="Button7_Click" 
                        Visible="False" />
                    <br />
                    <br />
                    <asp:Button ID="Button8" runat="server" Text="F Unit" Width="90px" 
                        BackColor="#669900" CssClass="style29" onclick="Button8_Click" 
                        Visible="False" />
                    <br />
                    <br />
                    <asp:Button ID="Button9" runat="server" Text="G Unit" Width="90px" 
                        BackColor="#669900" CssClass="style29" onclick="Button9_Click" 
                        Visible="False" />
                    <br />
                    <br />
                    <asp:Button ID="Button10" runat="server" Text="H Unit" Width="90px" 
                        BackColor="#669900" CssClass="style29" onclick="Button10_Click" 
                        Visible="False" />

                </asp:Panel>
            
        
    
    <asp:Panel ID="Panel4" runat="server" Height="138px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label36" runat="server" ForeColor="#FF3300" 
            style="font-size: medium">Sorry, your data not found in database.</asp:Label>
        <br />
        <br />
        &nbsp;<asp:Button ID="Button11" runat="server" onclick="Button11_Click" 
            Text="Thank you" Width="125px" Font-Bold="True" Font-Size="Medium" 
            style="font-size: medium" CssClass="style29" />
    </asp:Panel>
    <asp:panel ID="Panel5" runat="server" Height="138px" 
            style="font-size: xx-large; font-weight: 700">
        <br />
    NEXT TASK.........
        <br />
        <asp:Button ID="Button12" runat="server" CssClass="style29" Font-Bold="True" 
            Font-Size="Medium" onclick="Button11_Click" style="font-size: medium" 
            Text="Home" Width="125px" />
    </asp:panel>
    </div>
    </asp:Content>