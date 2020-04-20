
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    class Spell: Attack
    {
        public double ManaCost
        {
            get;
            private set;
        }

        public Spell(string name, double damage, double manaCost) : base(name, damage) {
            this.ManaCost = manaCost;
        }

        public static List<Spell> GetAllSpellsFromDatabase()
        {
            MySqlConnection conn = Utils.GetConnection();

            List<Spell> spells = new List<Spell>();
            try
            {
                string sql = "SELECT name, damage, manaCost FROM spells;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    string name = !String.IsNullOrWhiteSpace(row[0].ToString()) ? row[0].ToString() : "-";
                    double damage = Convert.ToDouble(row[1]);
                    double manaCost = Convert.ToDouble(row[2]);
                    Spell s = new Spell(name, damage, manaCost);
                    spells.Add(s);
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
            return spells;
        }

        public void SaveObjectToDb()
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string sql = "INSERT INTO spells(name, damage, manaCost) VALUES (@name, @damage, @manaCost);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@damage", Damage);
                cmd.Parameters.AddWithValue("@manaCost", ManaCost);
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
            return $"This spell ({Name}) has damage {Damage} and costs {ManaCost} mana";
        }
    }
}
