using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Antroji_Programavimo_Praktika
{
    class DESTYTOJO_KLASE
    {
        A_DUOMENU_BAZE db = new A_DUOMENU_BAZE();

        public bool insertdestytojas(string First_Name, string Last_Name, string User_Name, string Password, string Destomas_Dalykas)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `destytojas`(`username`, `password`, `vardas`, `pavarde`, `dalykas`) VALUES (@name,@pas,@fn,@ln,@dl)", db.GetConnection);

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = User_Name;
            command.Parameters.Add("@pas", MySqlDbType.VarChar).Value = Password;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = First_Name;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = Last_Name;
            command.Parameters.Add("@dl", MySqlDbType.VarChar).Value = Destomas_Dalykas;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public DataTable Destytojo_Informacija(MySqlCommand command)
        {
            command.Connection = db.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public bool Destytojo_Info_salinimas(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `destytojas` WHERE `id`=@studentID", db.GetConnection);
            command.Parameters.Add("@studentID", MySqlDbType.Int32).Value = id;
            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}
