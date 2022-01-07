using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Antroji_Programavimo_Praktika
{
    public partial class B_Studento_Langas : Form
    {
        public static string istatimas;

        public B_Studento_Langas()
        {
            InitializeComponent();
        } 

        STUDENTU_KLASE student = new STUDENTU_KLASE();
        DESTYTOJO_KLASE destytojas = new DESTYTOJO_KLASE();
        PAZYMIU_KLASE pazymiai = new PAZYMIU_KLASE();
        private void MainStudento_Load(object sender, EventArgs e)
        {

            // fillGrid1(new MySqlCommand("SELECT `Destomas_Dalykasas` FROM `destytojas`"));
            fillGrid(new MySqlCommand("SELECT `pazimys`, `dalykas` FROM `pazymiai`")); 
            textBoxPazimys55.Text = PrisijungimoLangas.Tekstas;

            string query = "SELECT DISTINCT `pazimys`, `dalykas` FROM `pazymiai` WHERE CONCAT (`username`) LIKE'%" + textBoxPazimys55.Text + "%'";
            MySqlCommand command = new MySqlCommand(query);
            fillGrid(command);
        }
       
        public void fillGrid(MySqlCommand command)
        {
            dataGridViewPazimys.ReadOnly = true;
            dataGridViewPazimys.RowTemplate.Height = 40;
            //dataGridViewPazimys.Width = 200;
            dataGridViewPazimys.DataSource = pazymiai.Destytojo_Informacija(command);

        }
    }
}
