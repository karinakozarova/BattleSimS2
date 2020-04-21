using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class Utils
    {
        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi425926;Database=dbi425926;Pwd=testtest321;");
            return conn;
        }

        public static DateTime GetDateTime()
        {
            return DateTime.Now;
        }
    }

}
