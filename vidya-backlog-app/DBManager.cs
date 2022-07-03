using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace vidya_backlog_app
{
    internal class DBManager
    {
        public static void ConnectAndRead(MyList list)
        {
            // Don't need security measures for sensitive information
            // since this is a simple application that is meant for only me
            string server = "localhost";
            string database = "vidya_backlog";
            string uid = "user";
            string pass = "vidya";

            string connString =
                "Server=" + server + ";" +
                "Database=" + database + ";" +
                "UID=" + uid + ";" + 
                "Password=" + pass + ";"
            ;

            try
            {
                MySqlConnection con = new(connString);
                con.Open();
                // Now read data..
                try
                {
                    MySqlDataAdapter adapter = new("SELECT Title FROM my_backlog;", con);
                    DataTable dtbl = new();
                    adapter.Fill(dtbl);
                    list.dgv.DataSource = dtbl;

                } catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
