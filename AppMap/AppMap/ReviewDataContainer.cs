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

        public string getName()
        { return name; }
        public double getRating()
        { return rating; }
        public string getComment()
        { return comment; }

        public void setName(string name)
        { this.name = name; }
        public void setRating(double rating)
        { this.rating = rating; }
        public void setComment(string comment)
        { this.comment = comment; }
    }
}