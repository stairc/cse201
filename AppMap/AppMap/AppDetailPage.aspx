<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AppDetailPage.aspx.cs" Inherits="AppMap.AppDetailPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <br />
        <div>
            <asp:Label ID="lblTitle" Font-Size="XX-Large" Font-Bold="true" runat="server" />
        </div>
        <br />
        <div>
            <asp:Image id="AppImage" Height="150" Width="150" BackColor="White" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblPrice" Font-Size="Larger" Font-Bold="false" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblRating" Font-Size="Larger" Font-Bold="false" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblPurblisher" Font-Size="Larger" Font-Bold="false" runat="server" />
        </div>
        <div>
            <h3>Discription:</h3>
            <asp:Label Width="500" ID="lblDiscription" runat="server" />
        </div>
        <br />
        <div>
            <asp:HyperLink id="linkToStore" Text="Click here to get the app." runat="server" />
        </div>
        <div>
            <asp:HyperLink id="shareLink" Text="Click here to share this app with a friend." runat="server" />
        </div>

    </form>
</body>
</html>
