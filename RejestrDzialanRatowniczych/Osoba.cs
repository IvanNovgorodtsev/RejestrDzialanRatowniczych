using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace RejestrDzialanRatowniczych
{
    public partial class Osoba : Form
    {
        bool button_szczegoly = true;
        public Osoba()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(50, 50);
        }
        
        private void button1_Click(object sender, EventArgs e) // Procedura dodawania nowej osoby Osoba_insert
        {
            main.con.Open();
            SqlCommand scCommand = new SqlCommand("Osoba_insert", main.con);
            scCommand.CommandType = CommandType.StoredProcedure;
            scCommand.Parameters.Add("@Imie", SqlDbType.VarChar, 25).Value = textBox1.Text;
            scCommand.Parameters.Add("@Nazwisko", SqlDbType.VarChar, 50).Value = textBox2.Text;
            scCommand.Parameters.Add("@Wiek", SqlDbType.Int).Value = textBox3.Text;
            scCommand.Parameters.Add("@Uraz", SqlDbType.VarChar, 100).Value = textBox4.Text;
            scCommand.Parameters.Add("@ID_Zgloszenia", SqlDbType.Int).Value = textBox6.Text;
            try
            {
                scCommand.ExecuteNonQuery();
                MessageBox.Show("Insertion Succesfull");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            main.con.Close();
        }

        private void button2_Click(object sender, EventArgs e) // Procedura edytowania osoby Osoba_update
        {
            main.con.Open();
            String origin = ExecuteQuery(textBox5);
            String check;

           SqlCommand scCommand = new SqlCommand("Osoba_update", main.con);
           scCommand.CommandType = CommandType.StoredProcedure;
           scCommand.Parameters.Add("@Imie", SqlDbType.VarChar, 25).Value = textBox1.Text;
           scCommand.Parameters.Add("@Nazwisko", SqlDbType.VarChar, 50).Value = textBox2.Text;
           scCommand.Parameters.Add("@Wiek", SqlDbType.Int).Value = textBox3.Text;
           scCommand.Parameters.Add("@Uraz", SqlDbType.VarChar, 100).Value = textBox4.Text;
           scCommand.Parameters.Add("@ID_Osoba", SqlDbType.VarChar, 100).Value = textBox5.Text;
            System.Threading.Thread.Sleep(5000);
            check = ExecuteQuery(textBox5);
           if (origin.Equals(check))
            {
                scCommand.ExecuteNonQuery();
                MessageBox.Show("Update Succesfull");
                main.con.Close();
                button4_Click(sender, e);
            }
           else
            {
                MessageBox.Show("Wartosc jest aktualnie zmieniana, sprobuj ponownie!");
                main.con.Close();
                button4_Click(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e) // Procedura usuwania osoby Osoba_delete
        {

            main.con.Open();
            SqlCommand scCommand = new SqlCommand("Osoba_delete", main.con);
            scCommand.CommandType = CommandType.StoredProcedure;
            scCommand.Parameters.Add("@ID_Osoba", SqlDbType.Int).Value = textBox5.Text;
            try
            {
                scCommand.ExecuteNonQuery();
                MessageBox.Show("Delete Succesfull");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Brak rekordu dla osoby o podanym ID!");
            }
            main.con.Close();
        }
        private void button4_Click(object sender, EventArgs e) // Wyswietlanie zawartosci tabela Osoba
        {
            main.con.Open();
            String query = "SELECT * FROM OSOBA";
            SqlDataAdapter SDA = new SqlDataAdapter(query, main.con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["RowVersion"].Visible = false;
            if (button_szczegoly)
            {
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                button.HeaderText = "Szczegoly";
                button.Name = "myButton";
                button.Text = "Szczegoly";
                button.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(button);
                button_szczegoly = false;
            }
            main.con.Close();
        }

        private void dataGridView1_CellBlick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.ColumnIndex == 7)
                {
                    var val = this.dataGridView1[e.ColumnIndex-2, e.RowIndex].Value.ToString();
                    var wypadekView = new WypadekView(val);
                    wypadekView.Show();
                }
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

        private String ExecuteQuery(TextBox textBox)
        {
            SqlCommand command = new SqlCommand("SELECT RowVersion from Osoba where ID_Osoba = @ID_Osoba", main.con);
            command.Parameters.AddWithValue("@ID_Osoba", int.Parse(textBox.Text));
            String result = null;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    result = Convert.ToBase64String(reader["RowVersion"] as byte[]);
                }
            }
            return result;
        }
    }
}
