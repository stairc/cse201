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
        private int rating;
        private double cost;
        private int store; // Stores will be assigned numerical integers. 

        public AppDataContainer()
        {
            author = "Default";
            title = "Default";
            description = "Default";
            url_to_product = "Default";
            rating = 0;
            cost = 0.00;
            store = -2
           ;
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

        public void setRating(int rating)
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

        public int getRating() {
            return rating;
        }

        public double getCost() {
            return cost;
        }

        public int getStore() {
            return store;
        }
    }
}
