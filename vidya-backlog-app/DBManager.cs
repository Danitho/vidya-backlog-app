using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace vidya_backlog_app
{
    internal static class DBManager
    {
        public static MySqlConnection? conn;

        public static void Connect()
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
                conn = new(connString);
                conn.Open();
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static void Read(MyList list)
        {
            try
            {
                Connect();
                try
                {
                    MySqlDataAdapter adapter = new("SELECT Title, Genre, Platform, GameStatus, Rating, Notes FROM my_backlog;", conn);
                    DataTable dtbl = new();
                    adapter.Fill(dtbl);
                    list.dgv.DataSource = dtbl;
                    conn.Close();

                } catch (Exception ex) { Console.WriteLine(ex.Message); }
            } catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public static void Write(string title, string genre, string platform, string status, int rating, string notes)
        {
            try
            {
                Connect();
                try
                {
                    // ugh, what a mess
                    string query = "INSERT INTO my_backlog(Title, Genre, Platform, GameStatus, Rating, Notes) " +
                        "VALUES('" + title + "','" + genre + "','" + platform + "','" + status + "'," + rating + ",'" + notes + "')";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                } catch (Exception ex) { Console.WriteLine(ex.Message); }
            } catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
