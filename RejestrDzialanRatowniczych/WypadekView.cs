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
            SqlConnection con = new SqlConnection(@"Data Source=MSIGP70;Initial Catalog=werszyn0.0.1;Integrated Security=True");
            InitializeComponent();

            con.Open();
            String query = "SELECT * FROM WYPADEK WHERE ID_Zgloszenia="+"'"+parameter+"'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
