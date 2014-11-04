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
            lblErrorText.Text = "";
        }

        protected void btnSubmitApp_Click(object sender, EventArgs e)
        {
            // Check for errors in data fields
            if (tbxAppName.Text == "")
            {
                lblErrorText.Text = "App Name Must Not Be Blank";
            }
            else if (rdoAppStore.SelectedItem == null)
            {
                lblErrorText.Text = "Must Select App Store";
            }
            else if (tbxAppDescription.Text == "")
            {
                lblErrorText.Text = "Decription Must Not Be Blank";
            }
            else
            {
                lblErrorText.Text = "";
            }
        }

    }
}