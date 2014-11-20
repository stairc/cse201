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

            lblDiscription.Text = app.getDescription();
        }
    }
}