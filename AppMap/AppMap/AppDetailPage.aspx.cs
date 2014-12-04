using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppMap
{
    public partial class AppDetailPage : System.Web.UI.Page
    {

        AppDataContainer app;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblTitle.Text = Request.QueryString["name"].Replace("_", " ");

            List<AppDataContainer> list = DBInteraction.getAllApps();

            foreach (AppDataContainer item in list)
            {
                if (item.getTitle() == lblTitle.Text)
                {
                    app = item;
                }
            }

            double price = app.getCost();
            if (price == 0)
            {
                lblPrice.Text = "Free";
            }
            else
            {
                lblPrice.Text = "$" + price.ToString();
            }

            double rating = app.getRating();
            lblRating.Text = "Rating: " + rating.ToString() + "/5";

            lblPurblisher.Text = "Publisher: " + app.getAuthor();

            lblDiscription.Text = app.getDescription();

            linkToStore.NavigateUrl = app.getURL();

            AppImage.ImageUrl = app.getImage();

            string shareURL = "mailto:someone@example.com?subject=Check out this app from The App Map!&body=";
            shareURL += "http://localhost:53797/AppDetailPage.aspx?name=";
            shareURL += app.getTitle().Replace(" ", "_") + "\r\n";

            shareLink.NavigateUrl = shareURL;

        }
    }
}