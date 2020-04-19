using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    class Weapon: Attack
    {
        public Weapon(string name, double damage): base(name, damage) { }

        public static List<Weapon> GetAllWeaponsFromDatabase()
        {
            MySqlConnection conn = Utils.GetConnection();

            List<Weapon> weapons = new List<Weapon>();
            try
            {
                string sql = "SELECT name, damage FROM weapons;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    string name = !String.IsNullOrWhiteSpace(row[0].ToString()) ? row[0].ToString() : "-";
                    double damage = Convert.ToDouble(row[1]);
                    Weapon w = new Weapon(name, damage);
                    weapons.Add(w);
                }
            }
            catch (Exception)
            {
                // TODO: add it to error log in the future
            }
            finally
            {
                conn.Close();
            }
            return weapons;

        }

        public void SaveObjectToDb()
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string sql = "INSERT INTO weapons(name, damage) VALUES (@name, @damage);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@damage", Damage);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                // TODO: add it to error log in the future
            }
            finally
            {
                conn.Close();
            }

        }

        public override string ToString()
        {
            return $"This weapon ({Name}) has damage {Damage}";
        }
    }
}
