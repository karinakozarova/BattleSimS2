using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    class Utils
    {
        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi425113;Database=dbi425113;Pwd=bropro12;");
            return conn;
        }

        public static DateTime GetDateTime()
        {
            return DateTime.Now;
        }
    }

}
