<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenuPage.aspx.cs" Inherits="AppMap.MainMenuPage" %>

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
        <asp:Table runat="server">
            <asp:TableRow Height="125">
                <asp:TableCell id="FeaturedApp1" Width="150">
                    <div>
                        <asp:Image ID="FeaturedApp1Image" runat="server" Height="75" Width="75" BackColor="Black"/>
                    </div>
                    <div>
                        <asp:Label ID="FeaturedApp1Name" Text="App 1" runat="server" />
                    </div>
                </asp:TableCell>
                <asp:TableCell id="FeaturedApp2" Width="150">
                    <div>
                        <asp:Image ID="FeaturedApp2Image" runat="server" Height="75" Width="75" BackColor="Black"/>
                    </div>
                    <div>
                        <asp:Label ID="FeaturedApp2Name" Text="App 2" runat="server" />
                    </div>
                </asp:TableCell>
                <asp:TableCell id="FeaturedApp3" Width="150">
                    <div>
                        <asp:Image ID="FeaturedApp3Image" runat="server" Height="75" Width="75" BackColor="Black"/>
                    </div>
                    <div>
                        <asp:Label ID="FeaturedApp3Name" Text="App 3" runat="server" />
                    </div>
                </asp:TableCell>
                <asp:TableCell id="FeaturedApp4" Width="150">
                    <div>
                        <asp:Image ID="FeaturedApp4Image" runat="server" Height="75" Width="75" BackColor="Black"/>
                    </div>
                    <div>
                        <asp:Label ID="FeaturedApp4Name" Text="App 4" runat="server" />
                    </div>
                </asp:TableCell>
                <asp:TableCell id="FeaturedApp5" Width="150">
                    <div>
                        <asp:Image ID="FeaturedApp5Image" runat="server" Height="75" Width="75" BackColor="Black"/>
                    </div>
                    <div>
                        <asp:Label ID="FeaturedApp5Name" Text="App 5" runat="server" />
                    </div>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <h3>Highest Rated Apps</h3>
        <asp:Table runat="server">
            <asp:TableRow Height="125">
                <asp:TableCell id="RatedApp1" Width="150">
                    <div>
                        <asp:Image ID="RatedApp1Image" runat="server" Height="75" Width="75" BackColor="Black"/>
                    </div>
                    <div>
                        <asp:Label ID="RatedApp1Name" Text="App 1" runat="server" />
                    </div>
                </asp:TableCell>
                <asp:TableCell id="RatedApp2" Width="150">
                    <div>
                        <asp:Image ID="RatedApp2Image" runat="server" Height="75" Width="75" BackColor="Black"/>
                    </div>
                    <div>
                        <asp:Label ID="RatedApp2Name" Text="App 2" runat="server" />
                    </div>
                </asp:TableCell>
                <asp:TableCell id="RatedApp3" Width="150">
                    <div>
                        <asp:Image ID="RatedApp3Image" runat="server" Height="75" Width="75" BackColor="Black"/>
                    </div>
                    <div>
                        <asp:Label ID="RatedApp3Name" Text="App 3" runat="server" />
                    </div>
                </asp:TableCell>
                <asp:TableCell id="RatedApp4" Width="150">
                    <div>
                        <asp:Image ID="RatedApp4Image" runat="server" Height="75" Width="75" BackColor="Black"/>
                    </div>
                    <div>
                        <asp:Label ID="RatedApp4Name" Text="App 4" runat="server" />
                    </div>
                </asp:TableCell>
                <asp:TableCell id="RatedApp5" Width="150">
                    <div>
                        <asp:Image ID="RatedApp5Image" runat="server" Height="75" Width="75" BackColor="Black"/>
                    </div>
                    <div>
                        <asp:Label ID="RatedApp5Name" Text="App 5" runat="server" />
                    </div>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <h3>Recently Added Apps</h3>
        <asp:Table runat="server">
            <asp:TableRow Height="125">
                <asp:TableCell id="RecentApp1" Width="150">
                    <div>
                        <asp:Image ID="RecentApp1Image" runat="server" Height="75" Width="75" BackColor="Black"/>
                    </div>
                    <div>
                        <asp:Label ID="RecentApp1Name" Text="App 1" runat="server" />
                    </div>
                </asp:TableCell>
                <asp:TableCell id="RecentApp2" Width="150">
                    <div>
                        <asp:Image ID="RecentApp2Image" runat="server" Height="75" Width="75" BackColor="Black"/>
                    </div>
                    <div>
                        <asp:Label ID="RecentApp2Name" Text="App 2" runat="server" />
                    </div>
                </asp:TableCell>
                <asp:TableCell id="RecentApp3" Width="150">
                    <div>
                        <asp:Image ID="RecentApp3Image" runat="server" Height="75" Width="75" BackColor="Black"/>
                    </div>
                    <div>
                        <asp:Label ID="RecentApp3Name" Text="App 3" runat="server" />
                    </div>
                </asp:TableCell>
                <asp:TableCell id="RecentApp4" Width="150">
                    <div>
                        <asp:Image ID="RecentApp4Image" runat="server" Height="75" Width="75" BackColor="Black"/>
                    </div>
                    <div>
                        <asp:Label ID="RecentApp4Name" Text="App 4" runat="server" />
                    </div>
                </asp:TableCell>
                <asp:TableCell id="RecentApp5" Width="150">
                    <div >
                        <asp:Image ID="RecentApp5Image" runat="server" Height="75" Width="75" BackColor="Black"/>
                    </div>
                    <div>
                        <asp:Label ID="RecentApp5Name" Text="App 5" runat="server" />
                    </div>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <p>
            <asp:Button ID="btnSubmitApp" runat="server" Text="Submit An App" Width="193px" Height="24px" OnClick="btnSubmitApp_Click" />
        </p>

    </div>
    </form>
</body>
</html>
