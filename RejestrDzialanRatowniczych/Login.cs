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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static bool IsAvailable(SqlConnection conn)
        {
            try
            {
                conn.Open();
                conn.Close();
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //main.datasource = textBox1.Text;
            //main.initialcatalog = textBox2.Text;
            if (main.datasource.Length != 0 || main.initialcatalog.Length != 0)
            {
                main.con = new SqlConnection(@"Data Source=" + main.datasource + ";Initial Catalog=" + main.initialcatalog + ";Integrated Security=True");
            }
            else
            {
                MessageBox.Show("Niepoprawne dane");
            }
            if(IsAvailable(main.con))
            {
                main.conStatus = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Niepoprawne dane");
                main.conStatus = false;
            }

        }
    }
}
