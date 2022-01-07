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
    public partial class B_Administratoriaus_Langas : Form
    {
        public B_Administratoriaus_Langas()
        {
            InitializeComponent();
        }

        STUDENTU_KLASE student = new STUDENTU_KLASE();
        DESTYTOJO_KLASE destytojas = new DESTYTOJO_KLASE();
        PAZYMIU_KLASE pazymiai = new PAZYMIU_KLASE();

        private void MainAdmino_Load(object sender, EventArgs e)
        {

        }

        private void Perziureti_Studentus_button_Click(object sender, EventArgs e)
        {
            Studentu_Grupiu_Sarasas grup = new Studentu_Grupiu_Sarasas();
            grup.ShowDialog();
        }

        private void Perziureti_sarasa_button_Click(object sender, EventArgs e)
        {
            
            Studentu_Sarasas st = new Studentu_Sarasas();
            st.ShowDialog();
        }

        private void Perziureti_Destytoja_button_Click(object sender, EventArgs e)
        {
            Destytoju_Sarasas dst = new Destytoju_Sarasas();
            dst.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            STUDENTU_KLASE student = new STUDENTU_KLASE();
            string First_Name = RegVardas.Text;
            string lname = RegPavarde.Text;
            string user = RegNaudotojas.Text;
            string pass = RegSlaptazodis.Text;
            string sgrupe = textBoxGrupe.Text;


            if (verif())
            {
                if (student.Ikelti_Studenta(First_Name, lname, user, pass, sgrupe))
                {
                    MessageBox.Show("Studentas pridetas!");
                }
                else
                {
                    MessageBox.Show("Netinkamai ivesti duomenys");
                }
            }
            else
            {
                MessageBox.Show("Tusti laukai");
            }

            RegVardas.Text = "";
            RegPavarde.Text = "";
            RegNaudotojas.Text = "";
            RegSlaptazodis.Text = "";
            textBoxGrupe.Text = "";



        }
        bool verif()
        {
            if ((RegVardas.Text.Trim() == "") ||
              (RegPavarde.Text.Trim() == "") ||
              (RegNaudotojas.Text.Trim() == "") ||
              (textBoxGrupe.Text.Trim() == "") ||
              (RegSlaptazodis.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DESTYTOJO_KLASE dest = new DESTYTOJO_KLASE();
            string First_Name = TdestVardas.Text;
            string Last_Name = TdestPavarde.Text;
            string User_Name = TdestUsern.Text;
            string Password = TdestSlaptazod.Text;
            string Destomas_Dalykas = TdestDestomas_Dalykasas.Text;

            if (verif1())
            {
                if (dest.insertdestytojas(First_Name, Last_Name, User_Name, Password, Destomas_Dalykas))
                {
                    MessageBox.Show("Naujas destytojas pridetas sekmingai!");
                }
                else
                {
                    MessageBox.Show("Netinkamai ivesti duomenys");
                }
            }
            else
            {
                MessageBox.Show("Tusti laukai");
            }

            TdestVardas.Text = "";
            TdestPavarde.Text = "";
            TdestUsern.Text = "";
            TdestSlaptazod.Text = "";
            TdestDestomas_Dalykasas.Text = "";



        }
        bool verif1()
        {
            if ((TdestVardas.Text.Trim() == "") ||
              (TdestPavarde.Text.Trim() == "") ||
              (TdestUsern.Text.Trim() == "") ||
              (TdestSlaptazod.Text.Trim() == "") ||
              (TdestDestomas_Dalykasas.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
