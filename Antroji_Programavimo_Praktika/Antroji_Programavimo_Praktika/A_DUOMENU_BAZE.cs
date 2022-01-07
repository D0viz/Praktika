﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Antroji_Programavimo_Praktika
{
    class A_DUOMENU_BAZE
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=antroji_praktika");

        public MySqlConnection GetConnection
        {
            get
            {
                return con;
            }
        }

        public void openConnection ()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();

            }
        }

        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();

            }
        }
    }
}
