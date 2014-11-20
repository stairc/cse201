using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppMap
{
    public partial class MainMenuPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadFeaturedApps();
            LoadHighestRatedApps();
            LoadRecentlyAddedApps();
        }        

        public void LoadFeaturedApps()
        {
            int seed = DateTime.Now.DayOfYear;
            Random rand = new Random(seed); // randomly select featured apps based on day

            List<AppDataContainer> appList = DBInteraction.getAllApps();

            if (appList.Count >= 5)
            {
                List<int> indexList = new List<int>(); // keep track of previous featured apps

                // Add first featured app
                int index = rand.Next() % appList.Count;
                indexList.Add(index);

                AppDataContainer app = appList[index];
                //FeaturedApp1Image.ImageUrl = app.getImage(); 
                FeaturedApp1Name.Text = app.getTitle();

                // Add Second Featured App
                do
                {
                    index = rand.Next() % appList.Count;
                } while (indexList.Contains(index));
                indexList.Add(index);

                app = appList[index];
                //FeaturedApp2Image.ImageUrl = app.getImage(); 
                FeaturedApp2Name.Text = app.getTitle();

                // Add Third Featured App
                do
                {
                    index = rand.Next() % appList.Count;
                } while (indexList.Contains(index));
                indexList.Add(index);

                app = appList[index];
                //FeaturedApp3Image.ImageUrl = app.getImage(); 
                FeaturedApp3Name.Text = app.getTitle();

                // Add Fourth Featured App
                do
                {
                    index = rand.Next() % appList.Count;
                } while (indexList.Contains(index));
                indexList.Add(index);

                app = appList[index];
                //FeaturedApp4Image.ImageUrl = app.getImage(); 
                FeaturedApp4Name.Text = app.getTitle();


                // Add Fifth Featured App
                do
                {
                    index = rand.Next() % appList.Count;
                } while (indexList.Contains(index));
                indexList.Add(index);

                app = appList[index];
                //FeaturedApp5Image.ImageUrl = app.getImage(); 
                FeaturedApp5Name.Text = app.getTitle();
            }
            else
            {
                switch (appList.Count)
                {
                    case 1:

                        //FeaturedApp1Image.ImageUrl = appList[0].getImage();
                        FeaturedApp1Name.Text = appList[0].getTitle();
                        break;
                    case 2:

                        //FeaturedApp1Image.ImageUrl = appList[0].getImage();
                        FeaturedApp1Name.Text = appList[0].getTitle();
                        //FeaturedApp2Image.ImageUrl = appList[1].getImage();
                        FeaturedApp2Name.Text = appList[1].getTitle();
                        break;
                    case 3:

                        //FeaturedApp1Image.ImageUrl = appList[0].getImage();
                        FeaturedApp1Name.Text = appList[0].getTitle();
                        //FeaturedApp2Image.ImageUrl = appList[1].getImage();
                        FeaturedApp2Name.Text = appList[1].getTitle();
                        //FeaturedApp3Image.ImageUrl = appList[2].getImage();
                        FeaturedApp3Name.Text = appList[2].getTitle();
                        break;
                    case 4:

                        //FeaturedApp1Image.ImageUrl = appList[0].getImage();
                        FeaturedApp1Name.Text = appList[0].getTitle();
                        //FeaturedApp2Image.ImageUrl = appList[1].getImage();
                        FeaturedApp2Name.Text = appList[1].getTitle();
                        //FeaturedApp3Image.ImageUrl = appList[2].getImage();
                        FeaturedApp3Name.Text = appList[2].getTitle();
                        //FeaturedApp4Image.ImageUrl = appList[3].getImage();
                        FeaturedApp4Name.Text = appList[3].getTitle();
                        break;
                    case 5:

                        //FeaturedApp1Image.ImageUrl = appList[0].getImage();
                        FeaturedApp1Name.Text = appList[0].getTitle();
                        //FeaturedApp2Image.ImageUrl = appList[1].getImage();
                        FeaturedApp2Name.Text = appList[1].getTitle();
                        //FeaturedApp3Image.ImageUrl = appList[2].getImage();
                        FeaturedApp3Name.Text = appList[2].getTitle();
                        //FeaturedApp4Image.ImageUrl = appList[3].getImage();
                        FeaturedApp4Name.Text = appList[3].getTitle();
                        //FeaturedApp5Image.ImageUrl = appList[4].getImage();
                        FeaturedApp5Name.Text = appList[4].getTitle();
                        break;
                    default:
                        break;
                }
            }
        }

        public void LoadHighestRatedApps()
        {

        }

        public void LoadRecentlyAddedApps()
        {

        }

        protected void btnSubmitApp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SubmissionPage.aspx", false);
        }

    }
}