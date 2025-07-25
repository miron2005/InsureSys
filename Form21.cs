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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_практика2___копияDataSet.Отдел_кадров". При необходимости она может быть перемещена или удалена.
            this.отдел_кадровTableAdapter.Fill(this._практика2___копияDataSet.Отдел_кадров);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            отдел_кадровBindingSource.Filter = "[Наименование должности]='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            отдел_кадровBindingSource.Filter = "";
        }
    }
}
