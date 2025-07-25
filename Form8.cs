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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void должностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.должностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._практика2___копияDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_практика2___копияDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this._практика2___копияDataSet.Должности);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.должностиBindingSource.EndEdit();
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
