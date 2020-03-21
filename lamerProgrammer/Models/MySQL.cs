using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using MySql.Data.MySqlClient;

namespace lamerProgrammer.Models
{
    static public class MySQL
    {
        static private MySqlConnection Connection;
        static MySQL()
        {
            Connection = new MySqlConnection(
                WebConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            Connection.Open();
        }
        static public DataTable Select(string MyQuery)
        {
            DataTable Table = new DataTable();
            MySqlCommand Command = new MySqlCommand(MyQuery, Connection);
            MySqlDataReader Reader = Command.ExecuteReader();
            Table.Load(Reader);
            return Table;
        }
    }
}