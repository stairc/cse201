using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AppMap
{
    public class DBInteraction
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source = C:\Users\Craig\Desktop\201\cse201\AppMap\AppMap; Version = 3;";
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            string query = "SELECT * FROM App";
            SqlCommand queryCommand = new SqlCommand(query, dbConnection);
            SqlDataReader queryReader = queryCommand.ExecuteReader();
            DataTable data = new DataTable();

            data.Load(queryReader);

            int firstCoupleRows = 3;

            for (int i = 0; i < firstCoupleRows; i++)
            {
                String rowText = string.Empty;
                foreach (DataColumn column in data.Columns)
                {
                    rowText += data.Rows[i][column.ColumnName] + " | ";
                }
                Console.WriteLine(rowText);
            }

            dbConnection.Close();


        }
    }
}