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
    public partial class Wypadek : Form
    {
        public Wypadek()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(50, 50);
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


        SqlConnection con = new SqlConnection(@"Data Source=MSIGP70;Initial Catalog=werszyn0.0.1;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand scCommand = new SqlCommand("Wypadek_insert", con);
            scCommand.CommandType = CommandType.StoredProcedure;
            scCommand.Parameters.Add("@Miejsce", SqlDbType.VarChar, 50).Value = textBox1.Text;
            scCommand.Parameters.Add("@Godzina", SqlDbType.Time).Value = textBox2.Text;
            scCommand.Parameters.Add("@Data", SqlDbType.Date).Value = textBox3.Text;
            scCommand.Parameters.Add("@Opis", SqlDbType.VarChar, 100).Value = textBox4.Text;
            scCommand.Parameters.Add("@ID_ZespolRatowniczy", SqlDbType.Int).Value = textBox6.Text;
            scCommand.Parameters.Add("@ID_Karetka", SqlDbType.Int).Value = textBox7.Text;
            scCommand.Parameters.Add("@ID_Dyspozytor", SqlDbType.Int).Value = textBox8.Text;
            scCommand.Parameters.Add("@ID_Zglaszajacy", SqlDbType.Int).Value = textBox9.Text;
            try
            {
                scCommand.ExecuteNonQuery();
                MessageBox.Show("Insertion Succesfull");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand scCommand = new SqlCommand("Wypadek_update", con);
            scCommand.CommandType = CommandType.StoredProcedure;
            scCommand.Parameters.Add("@Miejsce", SqlDbType.VarChar, 50).Value = textBox1.Text;
            if (String.IsNullOrEmpty(textBox2.Text)) scCommand.Parameters.Add("@Godzina", SqlDbType.Time).Value = Convert.DBNull;
            else scCommand.Parameters.Add("@Godzina", SqlDbType.Time).Value = textBox2.Text;
            if (String.IsNullOrEmpty(textBox3.Text)) scCommand.Parameters.Add("@Data", SqlDbType.Date).Value = Convert.DBNull;
            else scCommand.Parameters.Add("@Data", SqlDbType.Date).Value = textBox3.Text;
            scCommand.Parameters.Add("@Opis", SqlDbType.VarChar, 100).Value = textBox4.Text;
            scCommand.Parameters.Add("@ID_Zgloszenia", SqlDbType.Int).Value = textBox5.Text;
            try
            {
                scCommand.ExecuteNonQuery();
                MessageBox.Show("Update Succesfull");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand scCommand = new SqlCommand("Wypadek_delete", con);
            scCommand.CommandType = CommandType.StoredProcedure;
            scCommand.Parameters.Add("@ID_Zgloszenia", SqlDbType.Int).Value = textBox5.Text;
            try
            {
                scCommand.ExecuteNonQuery();
                MessageBox.Show("Delete Succesfull");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Brak rekordu dla wypadku o podanym ID!");
            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT * FROM WYPADEK";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
