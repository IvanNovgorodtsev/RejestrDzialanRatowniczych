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
    public partial class WypadekView : Form
    {
        public WypadekView(string parameter)
        {
            InitializeComponent();

            main.con.Open();
            String query = "SELECT * FROM WYPADEK WHERE ID_Zgloszenia="+"'"+parameter+"'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, main.con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            main.con.Close();
        }
    }
}
