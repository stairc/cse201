using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppMap
{
    public partial class SearchPage : System.Web.UI.Page
    {

        string searchString = "";
        List<AppDataContainer> appList;

        protected void Page_Load(object sender, EventArgs e)
        {
            searchString = Request.QueryString["s"].Replace("_", " ");
            searchText.Text = searchString;

            appList = SearchApps();
            if (appList.Count == 0)
            {
                lblNoResults.Visible = true;
            }
            else
            {
                ShowResults();
            }
        }

        private void ShowResults()
        {
            foreach (AppDataContainer item in appList)
            {
                TableRow appRow = new TableRow();
                appRow.Height = 175;
                resultsTbl.Rows.Add(appRow);
                ImageButton img = new ImageButton()
                {
                    BackColor = System.Drawing.Color.Black,
                    ImageUrl = "",
                    Width = 150,
                    Height = 150
                };
                TableCell imgCell = new TableCell()
                {
                    Height = 150,
                    Width = 175
                };
                imgCell.Controls.Add(img);
                appRow.Cells.Add(imgCell);

                TableCell discriptionCell = new TableCell()
                {
                    Height = 170,
                    VerticalAlign = VerticalAlign.Top
                };


                Table discriptionTable = new Table();
                discriptionCell.Controls.Add(discriptionTable);
                TableRow nameRow = new TableRow()
                {
                    Height = 75
                };
                discriptionTable.Rows.Add(nameRow);
                TableCell nameCell = new TableCell()
                {
                    Height = 75
                };
                nameRow.Cells.Add(nameCell);
                TableRow ratingRow = new TableRow()
                {
                    Height = 20
                };
                discriptionTable.Rows.Add(ratingRow);
                TableCell ratingCell = new TableCell()
                {
                    Height = 20
                };
                ratingRow.Cells.Add(ratingCell);
                TableRow publisherRow = new TableRow()
                {
                    Height = 20
                };
                discriptionTable.Rows.Add(publisherRow);
                TableCell publisherCell = new TableCell()
                {
                    Height = 20
                };
                publisherRow.Cells.Add(publisherCell);
              
                Label appName = new Label()
                {
                    Text = item.getTitle()
                };
                appName.Font.Bold = true;
                appName.Font.Size = 28;

                Label appRating = new Label()
                {
                    Text = "Rating: " + item.getRating().ToString() + "/5"
                };
                Label appPublisher = new Label()
                {
                    Text = "Publisher: " + item.getAuthor()
                };

                nameCell.Controls.Add(appName);
                ratingCell.Controls.Add(appRating);
                publisherCell.Controls.Add(appPublisher);

                appRow.Cells.Add(discriptionCell);
                img.Click += App_Click;
            }
        }

        private void App_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            TableCell imgCell = (TableCell)btn.Parent;
            TableRow row = (TableRow)imgCell.Parent;
            TableCell discriptionCell = row.Cells[1];
            Table discriptionTable = (Table)discriptionCell.Controls[0];
            TableRow disRow = discriptionTable.Rows[0];
            TableCell nameCell = disRow.Cells[0];
            Label nameLbl = (Label)nameCell.Controls[0];

            string name = nameLbl.Text;
            string navigationString = "AppDetailPage.aspx?name=";
            navigationString += name.Replace(" ", "_");

            Response.Redirect(navigationString);
        }

        private List<AppDataContainer> SearchApps()
        {
            List<AppDataContainer> list = DBInteraction.getAllApps();
            List<AppDataContainer> returnList = new List<AppDataContainer>();

            string[] searchWords = searchString.Split(' ');
            int highestNumberOfMatches = 0;



            foreach (AppDataContainer app in list)
            {
                int numberOfMatches = 0;

                foreach (string str in searchWords)
                {
                    int index = app.getTitle().ToUpper().IndexOf(str.ToUpper());

                    if (index != -1)
                    {
                        numberOfMatches++;
                    }
                }

                if (numberOfMatches != 0)
                {
                    if (numberOfMatches > highestNumberOfMatches)
                    {
                        highestNumberOfMatches = numberOfMatches;
                        returnList.Insert(0, app);
                    }
                    else
                    {
                        returnList.Add(app);
                    }
                }
            }

            return returnList;
        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchPage.aspx?s=" + searchText.Text.Replace(" ", "_"));
        }


    }
}