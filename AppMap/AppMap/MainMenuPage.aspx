﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenuPage.aspx.cs" Inherits="AppMap.MainMenuPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <h1>The App Map</h1>
                </asp:TableCell>
                <asp:TableCell Width="100"/>
                <asp:TableCell>
                    <asp:TextBox runat="server" Height="22"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:button text="Search" runat="server" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <h3>Featured Apps</h3>
        <br />
        <br />
        <h3>Highest Rated Apps</h3>
        <br />
        <br />
        <h3>Recently Added Apps</h3>
        <br />
        <br />
        <p>
            <asp:Button ID="btnSubmitApp" runat="server" Text="Submit An App" Width="193px" Height="24px" OnClick="btnSubmitApp_Click" />
        </p>

    </div>
    </form>
</body>
</html>
