using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace AppMap
{
    public static class DBInteraction
    {
        //static string connectionString = @"Data Source = C:\Users\Craig\Source\Repos\cse201\db.sqlite3; Version = 3;";

        //Extra connection string for Cameron's Testing purposes
        static string connectionString = @"Data Source = C:\Users\Cameron\OneDrive\Miami_University\2014_Fall\CSE 201\cse201\db.sqlite3; Version = 3;";
        static SQLiteConnection dbConnection = new SQLiteConnection(connectionString);

        static public void addApp(AppDataContainer app)
        {
            dbConnection.Open();
            string query = "INSERT INTO APP VALUES(" + "\"" + app.getAuthor() + "\"" + "," + "\"" + app.getTitle() + "\"" + "," + "\"" + app.getDescription() + "\"" + "," + "\"" + app.getURL() + "\"" + "," + app.getRating() + "," + app.getCost() + "," + app.getStore() + ");";
            SQLiteCommand queryCommand = new SQLiteCommand(query, dbConnection);
            queryCommand.ExecuteNonQuery();
            dbConnection.Close();
        }

        static public List<AppDataContainer> getAllApps()
        {
            dbConnection.Open();
            List<AppDataContainer> apps = new List<AppDataContainer>();

            String query = "SELECT * FROM APP;";
            SQLiteCommand queryCommand = new SQLiteCommand(query, dbConnection);
            SQLiteDataReader queryReader = queryCommand.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(queryReader);

            //for each row create a new datacontainer and parse out the values and put them in the new appdata object, then add to the apps list
            StringBuilder output = new StringBuilder();
            foreach (DataRow row in data.Rows)
            {
                string op = "";
                foreach (DataColumn col in data.Columns)
                {
                    //output.AppendFormat("{0},", row[col]);
                    op += row[col].ToString() + "|";
                }
                AppDataContainer adc = new AppDataContainer();
                //string[] elements = output.ToString().Split(null);
                string[] elements = op.Split('|');

                try
                {
                    adc.setAuthor(elements[0]);
                    adc.setTitle(elements[1]);
                    adc.setDescription(elements[2]);
                    adc.setURL(elements[3]);
                    adc.setRating(Double.Parse(elements[4]));
                    adc.setCost(Double.Parse(elements[5]));
                    adc.setStore(Int32.Parse(elements[6]));
                }
                catch (Exception ex)
                {
                    adc.setAuthor("Cameron Stair");
                    adc.setTitle("WashOut");
                    adc.setDescription("Washout is a fun and challenging puzzle game.");
                    adc.setURL("http://www.something.com");
                    adc.setRating(10.0);
                    adc.setCost(0);
                    adc.setStore(3);
                }

                apps.Add(adc);
                output.Clear(); //clear for next data item
            }
            dbConnection.Close();
            return apps;
        }

        static public void RemoveApp(String name)   {

        }
		
		static public double getAvgRating(String name)    {
            dbConnection.Open();
            Double avgRating;
            String query = "SELECT AVG(Rating) FROM Review WHERE App = " + "\"" + name + "\";";
            SQLiteCommand queryCommand = new SQLiteCommand(query, dbConnection);
            SQLiteDataReader queryReader = queryCommand.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(queryReader);
            
            StringBuilder output = new StringBuilder();
            foreach (DataRow row in data.Rows)
            {
                foreach (DataColumn col in data.Columns)
                {
                    output.AppendFormat("{0} ", row[col]);
                }
            }

            dbConnection.Close();

            if (output.ToString() == " ")
            {
                return 5;
            }
            else
            {
                return Convert.ToDouble(output.ToString());
            }
        }
		
		static public void addReview(ReviewDataContainer review){
            dbConnection.Open();
            string query = "INSERT INTO Review VALUES(" + "\"" + review.getName() + "\"" + "," + "\"" + review.getRating() + "\"" + "," + "\"" + review.getComment() + "\");";
            SQLiteCommand queryCommand = new SQLiteCommand(query, dbConnection);
            queryCommand.ExecuteNonQuery();
            dbConnection.Close();
        }
		
		static public List<ReviewDataContainer> getAllReviews()
        {
            dbConnection.Open();
            List<ReviewDataContainer> reviews = new List<ReviewDataContainer>();

            String query = "SELECT * FROM Review;";
            SQLiteCommand queryCommand = new SQLiteCommand(query, dbConnection);
            SQLiteDataReader queryReader = queryCommand.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(queryReader);

            //for each row create a new datacontainer and parse out the values and put them in the new appdata object, then add to the apps list
            StringBuilder output = new StringBuilder();
            foreach (DataRow row in data.Rows)
            {
                string op = "";
                foreach (DataColumn col in data.Columns)
                {
                    //output.AppendFormat("{0},", row[col]);
                    op += row[col].ToString() + "|";
                }
                ReviewDataContainer rdc = new ReviewDataContainer();
                //string[] elements = output.ToString().Split(null);
                string[] elements = op.Split('|');

                try
                {
                    rdc.setName(elements[0]);
                    rdc.setRating(Convert.ToDouble(elements[1]));
                    rdc.setComment(elements[2]);              
                }
                catch (Exception ex)
                {    
                    rdc.setName("WashOut");
                    rdc.setComment("Washout is a fun and challenging puzzle game.");                   
                    rdc.setRating(5.0);           
                }

                reviews.Add(rdc);
                output.Clear(); //clear for next data item
            }
            dbConnection.Close();
            return reviews;
        }
		
    }
}
