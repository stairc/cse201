<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubmissionPage.aspx.cs" Inherits="AppMap.SubmissionPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div aria-atomic="False">
    
        <h1>Submit Application</h1>
        <br />
        App Name:<br />
        <asp:TextBox ID="tbxAppName" runat="server" Width="280px"></asp:TextBox>
        <br />
        <br />
        App Store:<asp:RadioButtonList ID="rdoAppStore" runat="server">
            <asp:ListItem>Apple App Store</asp:ListItem>
            <asp:ListItem>Google Play Store</asp:ListItem>
            <asp:ListItem>Windows Phone Store</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        Discription:<br />
        <asp:TextBox ID="tbxAppDescription" runat="server" Height="125px" TextMode="MultiLine" Width="280px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSubmitApp" runat="server" Text="Submit App" Width="284px" Height="26px" OnClick="btnSubmitApp_Click" />
        <br />
        <asp:Label ID="lblErrorText" runat="server" BorderColor="White" BorderWidth="0px" ForeColor="Red" Height="0px"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
