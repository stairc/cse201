using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapApp
{
    public class Application
    {
        private String author;
        private String title;
        private String description;

        public Application(){
            author = "Default";
            title = "Default";
            description = "Default";
    }
        public Application(String title, String author, String description) {
            this.author = author;
            this.title = title;
            this.description = description;
        }

        public void setAuthor(String author) {
            this.author = author;
        }

        public void setTitle(String title) {
            this.title = title;
        }

        public void setDescription(String description) {
            this.description = description;
        }

        public String getAuthor() {
            return author;
        }

        public String getTitle() {
            return title;
        }

        public String getDescription() {
            return description;
        }
    }
}
