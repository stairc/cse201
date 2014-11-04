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

        public AppDataContainer()
        {
            author = "Default";
            title = "Default";
            description = "Default";
        }
        public AppDataContainer(string title, string author, string description)
        {
            this.author = author;
            this.title = title;
            this.description = description;
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
    }
}
