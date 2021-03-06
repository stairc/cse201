﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AppDetailPage.aspx.cs" Inherits="AppMap.AppDetailPage" %>

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
            <asp:Image id="AppImage" Height="175" Width="175" BackColor="White" runat="server" />
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
        <div>
            <h3>Reviews:</h3>
            <asp:Label ID="noReviewsLbl" Text="No Reviews Yet" Visible="false" runat="server" />
            <asp:Table ID="reviewsTable" runat="server">

            </asp:Table>
        </div>
        <div>
            <h3>Write a Review</h3>
            <asp:Table runat="server">
                <asp:TableRow>
                    <asp:TableCell Width="65">
                        Rating:
                    </asp:TableCell>
                    <asp:TableCell>
                        Comment (optional):
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell width="65">
                        <asp:RadioButtonList ID="ratingSelection" runat="server">
                            <asp:listitem text="5" Selected="True"/>
                            <asp:listitem text="4" />
                            <asp:listitem text="3" />
                            <asp:listitem text="2" />
                            <asp:listitem text="1" />
                        </asp:RadioButtonList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="reviewComment" runat="server" Width="300" Height="110" TextMode="MultiLine"/>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell Width="80" />
                    <asp:TableCell Height="60">
                        <asp:button ID="submitButton" text="Submit Review" runat="server" onclick="submitButton_Click"/>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell Width="80" />
                    <asp:TableCell >
                        <asp:Label ID="submitErrorText" ForeColor="Red" Text="error text" runat="server" Visible="false" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>

    </form>
</body>
</html>
