using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_итог
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form26 frm = new Form26();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form27 frm = new Form27();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form28 frm = new Form28();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form29 frm = new Form29();
            frm.Show();
        }
    }
}
