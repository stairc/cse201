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
        static string connectionString = @"Data Source = C:\Users\Craig\Source\Repos\cse201\db.sqlite3; Version = 3;";
        static SQLiteConnection dbConnection = new SQLiteConnection(connectionString);

        static public void addApp(AppDataContainer app)
        {
            dbConnection.Open();
            string query = "INSERT INTO APP VALUES(" + "\"" + app.getAuthor() + "\"" + "," + "\"" + app.getTitle() + "\"" + "," + "\"" + app.getDescription() + "\"" + "," + "\"" + app.getURL() + "\"" + "," + app.getRating() + "," + app.getCost() + "," + app.getStore() + ");";
            SQLiteCommand queryCommand = new SQLiteCommand(query, dbConnection);
            queryCommand.ExecuteNonQuery();
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
                foreach (DataColumn col in data.Columns)
                {
                    output.AppendFormat("{0} ", row[col]);
                }
                AppDataContainer adc = new AppDataContainer();
                string[] elements = output.ToString().Split(null);
                
                adc.setAuthor(elements[0]);
                adc.setTitle(elements[1]);
                adc.setDescription(elements[2]);
                adc.setURL(elements[3]);
                adc.setRating(Double.Parse(elements[4]));
                adc.setCost(Double.Parse(elements[5]));
                adc.setStore(Int32.Parse(elements[6]));

                apps.Add(adc);
                output.Clear(); //clear for next data item
            }
            return apps;
        }

        static public void RemoveApp(String name)   {

        }
    }
}
