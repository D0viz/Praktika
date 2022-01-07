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
    public partial class B_Destytojo_Langas : Form
    {
        public static string istatimas;
        public B_Destytojo_Langas()
        {
            InitializeComponent();
        }

        STUDENTU_KLASE student = new STUDENTU_KLASE();
        DESTYTOJO_KLASE destytojas = new DESTYTOJO_KLASE();
        PAZYMIU_KLASE pazymiai = new PAZYMIU_KLASE();

        private void MainDestytojo_Load(object sender, EventArgs e)
        {
            fillGrid(new MySqlCommand("SELECT `id`, `vardas`, `pavarde`, `grupe`, `username` FROM `studentas`"));
            fillGrid1(new MySqlCommand("SELECT DISTINCT `pazimys`, `pavarde`, `vardas`, `grupe`, `username` FROM `pazymiai`"));
            textBoxdestytojupaste.Text = PrisijungimoLangas.Tekstas;

            string query = "SELECT DISTINCT `pazimys`, `pavarde`, `vardas`, `grupe`, `username` FROM `pazymiai` WHERE CONCAT (`dalykas`) LIKE'%" + textBoxdestytojupaste.Text + "%'";
            MySqlCommand command = new MySqlCommand(query);
            fillGrid1(command);

        }
        public void fillGrid(MySqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DataSource = student.Studento_Informacija(command); 

        }
        public void fillGrid1(MySqlCommand command)
        {
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 40;
            dataGridView2.DataSource = pazymiai.Destytojo_Informacija(command);

        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Pazymio_Irasymas forma = new Pazymio_Irasymas();
            forma.textBoxIDa.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            forma.textBoxPazVardas.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            forma.textBoxPazPavarde.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            forma.textBoxPazGrupe.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            forma.textBoxStudentoUsername.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //forma.textBoxPazimys.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            forma.Show();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)        {  }




        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT DISTINCT `pazimys`, `pavarde`, `vardas`, `grupe`, `username` FROM `pazymiai` WHERE CONCAT (`dalykas`) LIKE'%" + textBoxdestytojupaste.Text + "%'");
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 40;
            dataGridView2.DataSource = pazymiai.Destytojo_Informacija(command);
            dataGridView2.AllowUserToAddRows = false;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void dataGridView2_DoubleClick_1(object sender, EventArgs e)
        {
            Pazymio_Atnaujinimas forma2 = new Pazymio_Atnaujinimas();
            // forma.textBoxIDa.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            forma2.textBoxPazVardasUPD.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            forma2.textBoxPazPavardeUPD.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            forma2.textBoxPazGrupeUPD.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            forma2.textBoxPazimysUPD.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            forma2.textBoxUpdateStudentas.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();

            forma2.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
