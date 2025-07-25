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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_практика2___копияDataSet.Список_клиентов". При необходимости она может быть перемещена или удалена.
            this.список_клиентовTableAdapter.Fill(this._практика2___копияDataSet.Список_клиентов);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            список_клиентовBindingSource.Filter = "[Наименование]='" + comboBox1.Text + "'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            список_клиентовBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
