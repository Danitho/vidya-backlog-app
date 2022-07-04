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
                    MySqlDataAdapter adapter = new("SELECT * FROM my_backlog;", con);
                    DataTable dtbl = new();
                    adapter.Fill(dtbl);
                    list.dgv.DataSource = dtbl;
                    con.Close();

                } catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Write(string title, string genre, string platform, string status, int rating, string notes)
        {
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
                // Now write data..
                try
                {
                    // ugh, what a mess
                    string query = "INSERT INTO my_backlog(Title, Genre, Platform, GameStatus, Rating, Notes) " +
                        "VALUES('" + title + "','" + genre + "','" + platform + "','" + status + "'," + rating + ",'" + notes + "')";


                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
