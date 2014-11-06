using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppMap
{
    public partial class SubmissionPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmitApp_Click(object sender, EventArgs e)
        {
            // Check for errors in data fields
            if (tbxAppName.Text == "")
            {
                lblErrorText.Text = "App Name Must Not Be Blank";
            }
            else if (tbxAppLink.Text == "" || tbxAppLink.Text.IndexOf('.') != -1)
            {
                lblErrorText.Text = "App Must Have a Valid Link";
            }
            else if (tbxPublisherName.Text == "")
            {
                lblErrorText.Text = "Publisher Name Must Not Be Blank";
            }
            else if (tbxAppDescription.Text == "")
            {
                lblErrorText.Text = "Decription Must Not Be Blank";
            }
            else
            {
                lblErrorText.Text = "";

                string name = tbxAppName.Text;
                int store = -1;
                if (drpAppStore.SelectedIndex == 0)
                {
                    store = 0;
                }
                else if (drpAppStore.SelectedIndex == 1)
                {
                    store = 1;
                }
                else
                {
                    store = 2;
                }
                string link = tbxAppLink.Text;
                string publisher = tbxPublisherName.Text;
                string discrip = tbxAppDescription.Text;
                double price = 0;
                if (tbxAppPrice.Text != "")
	            {
                    double.TryParse(tbxAppPrice.Text, out price);
	            }

                AppDataContainer app = new AppDataContainer(name, publisher, discrip, link, 5, price, store);
            }
        }

    }
}