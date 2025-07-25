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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void полисыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.полисыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._практика2___копияDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_практика2___копияDataSet.Полисы". При необходимости она может быть перемещена или удалена.
            this.полисыTableAdapter.Fill(this._практика2___копияDataSet.Полисы);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.полисыBindingSource.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.полисыBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.полисыBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.полисыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.полисыBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.полисыBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.полисыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this._практика2___копияDataSet);

                MessageBox.Show("Update Successful");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
