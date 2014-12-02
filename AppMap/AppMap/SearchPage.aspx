<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchPage.aspx.cs" Inherits="AppMap.SearchPage" %>

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
                    <h1>Find App</h1>
                </asp:TableCell>
                <asp:TableCell Width="317"/>
                <asp:TableCell>
                    <asp:TextBox id="searchText" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                   <asp:button id="searchBtn" text="Search" runat="server" OnClick="searchBtn_Click"/>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
        <br />
        <div>
            <h3>Results:</h3>
            <asp:Label id="lblNoResults" Text="No Apps Found" Visible="false" runat="server" />
            <div >
                <asp:Table runat="server" ID="resultsTbl">
                    
                </asp:Table>
            </div>
        </div>
    </form>
</body>
</html>
