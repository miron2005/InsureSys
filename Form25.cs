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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void Form25_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_практика2___копияDataSet.Список_полисов". При необходимости она может быть перемещена или удалена.
            this.список_полисовTableAdapter.Fill(this._практика2___копияDataSet.Список_полисов);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            список_полисовBindingSource.Filter = "[Отметка об окончании]='" + comboBox1.Text + "'";
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
