using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppMap
{
    public class ReviewDataContainer
    {
        private string name;
        private double rating;
        private string comment;

        public ReviewDataContainer()
        {

        }

        public ReviewDataContainer(string name, double rating, string comment)
        {
            this.name = name;
            this.rating = rating;
            this.comment = comment;
        }

        protected double getName()
        { return name; }
        protected double getRating()
        { return rating; }
        protected double getComment()
        { return comment; }

        protected void setname(string name)
        { this.name = name; }
        protected void setRating(double rating)
        { this.rating = rating; }
        protected void setComment(string comment)
        { this.comment = comment; }
    }
}