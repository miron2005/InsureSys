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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void Form24_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_практика2___копияDataSet.Список_полисов". При необходимости она может быть перемещена или удалена.
            this.список_полисовTableAdapter.Fill(this._практика2___копияDataSet.Список_полисов);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            список_полисовBindingSource.Filter = "[Отметка о выплате]='" + comboBox1.Text + "'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            список_полисовBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
