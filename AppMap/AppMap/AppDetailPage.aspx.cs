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
            lblRating.Text = "Rating: " + String.Format("{0:0.0}", rating) + "/5";

            lblPurblisher.Text = "Publisher: " + app.getAuthor();

            lblDiscription.Text = app.getDescription();

            linkToStore.NavigateUrl = app.getURL();

            AppImage.ImageUrl = app.getImage();

            string shareURL = "mailto:someone@example.com?subject=Check out this app from The App Map!&body=";
            shareURL += "http://localhost:53797/AppDetailPage.aspx?name=";
            shareURL += app.getTitle().Replace(" ", "_") + "\r\n";

            shareLink.NavigateUrl = shareURL;

            LoadReviews();
        }

        private void LoadReviews()
        {
            // get reviews
            List<ReviewDataContainer> rlist = DBInteraction.getAllReviews();
            List<ReviewDataContainer> reviewList = new List<ReviewDataContainer>();

            foreach (ReviewDataContainer item in rlist)
            {
                if (item.getName() == app.getTitle())
                {
                    reviewList.Add(item);
                }
            }

            if (reviewList.Count == 0)
            {
                noReviewsLbl.Visible = true;
            }
            else
            {
                ShowReviews(reviewList);
            }
        }

        private void ShowReviews(List<ReviewDataContainer> reviewList)
        {
            foreach (ReviewDataContainer item in reviewList)
            {
                TableRow row = new TableRow();
                row.Height = 60;

                TableCell ratingCell = new TableCell();
                ratingCell.Width = 120;
                TableCell commentCell = new TableCell();
                commentCell.Width = 350;
                row.Cells.Add(ratingCell);
                row.Cells.Add(commentCell);

                Label ratingLbl = new Label();
                ratingLbl.Text = "Rating: " + item.getRating().ToString() + "/5";
                ratingCell.Controls.Add(ratingLbl);

                Label commentLbl = new Label();
                commentLbl.Width = 350;
                if (item.getComment() == "")
                {
                    commentLbl.Text = "No comment provided.";
                }
                else
                {
                    commentLbl.Text = item.getComment();
                }

                commentCell.Controls.Add(commentLbl);

                reviewsTable.Rows.Add(row);
            }
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            ReviewDataContainer review = new ReviewDataContainer();

            switch (ratingSelection.SelectedIndex)
            {
                case 0:
                    review.setRating(5);
                    break;
                case 1:
                    review.setRating(4);
                    break;
                case 2:
                    review.setRating(3);
                    break;
                case 3:
                    review.setRating(2);
                    break;
                case 4:
                    review.setRating(1);
                    break;
                default:
                    break;
            }

            review.setName(app.getTitle());
            review.setComment(reviewComment.Text);

            DBInteraction.addReview(review);

            ratingSelection.SelectedIndex = 0;
            reviewComment.Text = "";

            reviewsTable.Rows.Clear();
            LoadReviews();
        }
    }
}