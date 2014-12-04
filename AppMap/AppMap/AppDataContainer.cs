using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppMap
{
    public class AppDataContainer
    {
        private string author;
        private string title;
        private string description;
        private string url_to_product;
        private double rating;
        private double cost;
        private int store; // Stores will be assigned numerical integers. 

        public AppDataContainer()
        {
            author = "Default";
            title = "Default";
            description = "Default";
            url_to_product = "Default";
            rating = 0.00;
            cost = 0.00;
            store = -1;
        }
        public AppDataContainer(string title, string author, string description, 
                string url, int rating, double cost, int store)
        {
            this.author = author;
            this.title = title;
            this.description = description;
            this.url_to_product = url;
            this.rating = rating;
            this.cost = cost;
            this.store = store; 
        }

        public void setAuthor(string author)
        {
            this.author = author;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public void setURL(string url) 
        {
            this.url_to_product = url;
        }

        public void setRating(double rating)
        {
            this.rating = rating;
        }

        public void setCost(double cost)
        {
            this.cost = cost;
        }

        public void setStore(int store)
        {
            this.store = store;
        }
        public string getAuthor()
        {
            return author;
        }

        public string getTitle()
        {
            return title;
        }

        public string getDescription()
        {
            return description;
        }

        public string getURL() {
            return url_to_product;
        }

        public double getRating() {
            return DBInteraction.getAvgRating(title);
        }

        public double getCost() {
            return cost;
        }

        public int getStore() {
            return store;
        }

        public string getImage()
        {
            string HTML = ImageHelper.GetWebsiteHTML(url_to_product);
            string url = "";

            switch (store)
            {
                case 0: //app store
                    url = ImageHelper.GetAppleImage(HTML);
                    break;
                case 1: //android store
                    url = ImageHelper.GetAndroidImage(HTML);
                    break;
                case 2: //windows phone store
                    url = ImageHelper.GetWindowsPhoneImage(HTML);
                    break;
                default:
                    break;
            }

            return url;
        }
    }
}
