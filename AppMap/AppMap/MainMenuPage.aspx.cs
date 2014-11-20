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

            RegisterEvents();
        }

        private void RegisterEvents()
        {
            FeaturedApp1Image.Click += FeaturedApp_Click;
            FeaturedApp2Image.Click += FeaturedApp_Click;
            FeaturedApp3Image.Click += FeaturedApp_Click;
            FeaturedApp4Image.Click += FeaturedApp_Click;
            FeaturedApp5Image.Click += FeaturedApp_Click;

            RatedApp1Image.Click += RatedApp_Click;
            RatedApp2Image.Click += RatedApp_Click;
            RatedApp3Image.Click += RatedApp_Click;
            RatedApp4Image.Click += RatedApp_Click;
            RatedApp5Image.Click += RatedApp_Click;

            RecentApp1Image.Click += RecentApp_Click;
            RecentApp2Image.Click += RecentApp_Click;
            RecentApp3Image.Click += RecentApp_Click;
            RecentApp4Image.Click += RecentApp_Click;
            RecentApp5Image.Click += RecentApp_Click;
        }

        private void RecentApp_Click(object sender, ImageClickEventArgs e)
        {
            string navigationString = "AppDetailPage.aspx?name=";

            ImageButton img = (ImageButton)sender;
            string name = img.ID.Replace("RecentApp", "");
            name = name.Replace("Image", "");
            int appNum = int.Parse(name);

            switch (appNum)
            {
                case 1:
                    navigationString += RecentApp1Name.Text.Replace(" ", "_");
                    break;
                case 2:
                    navigationString += RecentApp2Name.Text.Replace(" ", "_");
                    break;
                case 3:
                    navigationString += RecentApp3Name.Text.Replace(" ", "_");
                    break;
                case 4:
                    navigationString += RecentApp4Name.Text.Replace(" ", "_");
                    break;
                case 5:
                    navigationString += RecentApp5Name.Text.Replace(" ", "_");
                    break;
                default:
                    break;
            }

            Response.Redirect(navigationString);
        }

        private void RatedApp_Click(object sender, ImageClickEventArgs e)
        {
            string navigationString = "AppDetailPage.aspx?name=";

            ImageButton img = (ImageButton)sender;
            string name = img.ID.Replace("RatedApp", "");
            name = name.Replace("Image", "");
            int appNum = int.Parse(name);

            switch (appNum)
            {
                case 1:
                    navigationString += RatedApp1Name.Text.Replace(" ", "_");
                    break;
                case 2:
                    navigationString += RatedApp2Name.Text.Replace(" ", "_");
                    break;
                case 3:
                    navigationString += RatedApp3Name.Text.Replace(" ", "_");
                    break;
                case 4:
                    navigationString += RatedApp4Name.Text.Replace(" ", "_");
                    break;
                case 5:
                    navigationString += RatedApp5Name.Text.Replace(" ", "_");
                    break;
                default:
                    break;
            }

            Response.Redirect(navigationString);
        }

        private void FeaturedApp_Click(object sender, ImageClickEventArgs e)
        {
            string navigationString = "AppDetailPage.aspx?name=";

            ImageButton img = (ImageButton)sender;
            string name = img.ID.Replace("FeaturedApp", "");
            name = name.Replace("Image", "");
            int appNum = int.Parse(name);

            switch (appNum)
            {
                case 1:
                    navigationString += FeaturedApp1Name.Text.Replace(" ", "_");
                    break;
                case 2:
                    navigationString += FeaturedApp2Name.Text.Replace(" ", "_");
                    break;
                case 3:
                    navigationString += FeaturedApp3Name.Text.Replace(" ", "_");
                    break;
                case 4:
                    navigationString += FeaturedApp4Name.Text.Replace(" ", "_");
                    break;
                case 5:
                    navigationString += FeaturedApp5Name.Text.Replace(" ", "_");
                    break;
                default:
                    break;
            }

            Response.Redirect(navigationString);
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
            List<AppDataContainer> appList = DBInteraction.getAllApps();
            List<AppDataContainer> highestList = new List<AppDataContainer>();

            foreach (AppDataContainer item in appList)
            {
                if (highestList.Count < 5)
                {
                    highestList.Add(item);
                }
                else
                {
                    double lowestAmount = 10.0;
                    foreach (AppDataContainer app in highestList)
                    {
                        if (app.getRating() < lowestAmount)
                        {
                            lowestAmount = app.getRating();
                        }
                    }

                    if (item.getRating() > lowestAmount)
                    {
                        int index = 0;
                        for (int i = 0; i < 5; i++)
                        {
                            if (highestList[i].getRating() == lowestAmount)
                            {
                                index = i;
                            }
                        }

                        highestList[index] = item;
                    }
                }

                switch (highestList.Count)
                {
                    case 1:
                        //RatedApp1Image.ImageUrl = highestList[0].getImage();
                        RatedApp1Name.Text = highestList[0].getTitle();
                        break;
                    case 2:
                        //RatedApp1Image.ImageUrl = highestList[0].getImage();
                        //RatedApp2Image.ImageUrl = highestList[1].getImage();
                        RatedApp1Name.Text = highestList[0].getTitle();
                        RatedApp2Name.Text = highestList[1].getTitle();
                        break;
                    case 3:
                        //RatedApp1Image.ImageUrl = highestList[0].getImage();
                        //RatedApp2Image.ImageUrl = highestList[1].getImage();
                        //RatedApp3Image.ImageUrl = highestList[2].getImage();
                        RatedApp1Name.Text = highestList[0].getTitle();
                        RatedApp2Name.Text = highestList[1].getTitle();
                        RatedApp3Name.Text = highestList[2].getTitle();
                        break;
                    case 4:
                        //RatedApp1Image.ImageUrl = highestList[0].getImage();
                        //RatedApp2Image.ImageUrl = highestList[1].getImage();
                        //RatedApp3Image.ImageUrl = highestList[2].getImage();
                        //RatedApp4Image.ImageUrl = highestList[3].getImage();
                        RatedApp1Name.Text = highestList[0].getTitle();
                        RatedApp2Name.Text = highestList[1].getTitle();
                        RatedApp3Name.Text = highestList[2].getTitle();
                        RatedApp4Name.Text = highestList[3].getTitle();
                        break;
                    default:
                        //RatedApp1Image.ImageUrl = highestList[0].getImage();
                        //RatedApp2Image.ImageUrl = highestList[1].getImage();
                        //RatedApp3Image.ImageUrl = highestList[2].getImage();
                        //RatedApp4Image.ImageUrl = highestList[3].getImage();
                        //RatedApp5Image.ImageUrl = highestList[4].getImage();
                        RatedApp1Name.Text = highestList[0].getTitle();
                        RatedApp2Name.Text = highestList[1].getTitle();
                        RatedApp3Name.Text = highestList[2].getTitle();
                        RatedApp4Name.Text = highestList[3].getTitle();
                        RatedApp5Name.Text = highestList[4].getTitle();
                        break;
                }

            }
        }

        public void LoadRecentlyAddedApps()
        {
            List<AppDataContainer> appList = DBInteraction.getAllApps();
            appList.Reverse();

            switch (appList.Count)
            {
                case 1:
                    //RecentApp1Image.ImageUrl = appList[0].getImage();
                    RecentApp1Name.Text = appList[0].getTitle();
                    break;
                case 2:
                    //RecentApp1Image.ImageUrl = appList[0].getImage();
                    RecentApp1Name.Text = appList[0].getTitle();
                    //RecentApp2Image.ImageUrl = appList[1].getImage();
                    RecentApp2Name.Text = appList[1].getTitle();
                    break;
                case 3:
                    //RecentApp1Image.ImageUrl = appList[0].getImage();
                    RecentApp1Name.Text = appList[0].getTitle();
                    //RecentApp2Image.ImageUrl = appList[1].getImage();
                    RecentApp2Name.Text = appList[1].getTitle();
                    //RecentApp3Image.ImageUrl = appList[2].getImage();
                    RecentApp3Name.Text = appList[2].getTitle();
                    break;
                case 4:
                    //RecentApp1Image.ImageUrl = appList[0].getImage();
                    RecentApp1Name.Text = appList[0].getTitle();
                    //RecentApp2Image.ImageUrl = appList[1].getImage();
                    RecentApp2Name.Text = appList[1].getTitle();
                    //RecentApp3Image.ImageUrl = appList[2].getImage();
                    RecentApp3Name.Text = appList[2].getTitle();
                    //RecentApp4Image.ImageUrl = appList[3].getImage();
                    RecentApp4Name.Text = appList[3].getTitle();
                    break;
                default:
                    //RecentApp1Image.ImageUrl = appList[0].getImage();
                    RecentApp1Name.Text = appList[0].getTitle();
                    //RecentApp2Image.ImageUrl = appList[1].getImage();
                    RecentApp2Name.Text = appList[1].getTitle();
                    //RecentApp3Image.ImageUrl = appList[2].getImage();
                    RecentApp3Name.Text = appList[2].getTitle();
                    //RecentApp4Image.ImageUrl = appList[3].getImage();
                    RecentApp4Name.Text = appList[3].getTitle();
                    //RecentApp5Image.ImageUrl = appList[4].getImage();
                    RecentApp5Name.Text = appList[4].getTitle();
                    break;
            }
        }

        protected void btnSubmitApp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SubmissionPage.aspx", false);
        }

    }
}