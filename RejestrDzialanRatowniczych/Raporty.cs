using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RejestrDzialanRatowniczych
{
    public partial class Raporty : Form
    {
        public Raporty()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void dataGridView1_CellBlick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void osobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var osoba = new Osoba();
            osoba.Closed += (s, args) => this.Close();
            osoba.Show();
        }
        private void wypadekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var wypadek = new Wypadek();
            wypadek.Closed += (s, args) => this.Close();
            wypadek.Show();
        }

        private void raportyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var raporty = new Raporty();
            raporty.Closed += (s, args) => this.Close();
            raporty.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Raport o ilości akcji ratowników.";
            label1.Visible = true;
            main.con.Open();
            String query = "select R.ID_Ratownik, R.Imie, R.Nazwisko, count(R.ID_Ratownik) as Akcje from Ratownik R inner join Grupa_Rat gt on R.ID_Grupy = gt.ID_Grupy inner join ZespolRatowniczy zr on gt.ID_Grupy = zr.ID_Grupy_Rat inner join Wypadek w on zr.ID_Grupy_Rat = w.ID_ZespolRatowniczy Group by R.ID_Ratownik, R.Imie, R.Nazwisko";
            SqlDataAdapter SDA = new SqlDataAdapter(query, main.con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            main.con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Ilość akcji ratowniczych, urazy.";
            label1.Visible = true;
            main.con.Open();
            String query = "select Uraz, count(Uraz) as Ilosc from Osoba group by Uraz";
            SqlDataAdapter SDA = new SqlDataAdapter(query, main.con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            main.con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Ilość wyjazdów karetek.";
            label1.Visible = true;
            main.con.Open();
            String query = "select k.Typ, k.ID_Karetka, count(k.ID_Karetka) as wyjazdy from Karetka k inner join Wypadek w on k.ID_Karetka = w.ID_Karetka group by k.Typ, k.ID_Karetka";
            SqlDataAdapter SDA = new SqlDataAdapter(query, main.con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            main.con.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Zestawienie o zgłaszających.";
            label1.Visible = true;
            main.con.Open();
            String query = "select z.Imie, z.Nazwisko, z.Wiek, count(z.ID_Zglaszajacy) as Ilosc from Zglaszajacy z inner join Wypadek w on z.ID_Zglaszajacy = w.ID_Zglaszajacy group by z.ID_Zglaszajacy, z.Imie, z.Nazwisko, z.Wiek";
            SqlDataAdapter SDA = new SqlDataAdapter(query, main.con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            main.con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Zestawienie wypadków według godziny.";
            label1.Visible = true;
            main.con.Open();
            String query = "select CONVERT(TIME(0), [Godzina]) AS time, count(Godzina) as Ilosc from Wypadek group by Godzina";
            SqlDataAdapter SDA = new SqlDataAdapter(query, main.con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            main.con.Close();
        }
    }
}
