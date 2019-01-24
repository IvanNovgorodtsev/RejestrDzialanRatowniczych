using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }
        private void button4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
    }
}
