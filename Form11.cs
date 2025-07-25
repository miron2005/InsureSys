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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void рискиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.рискиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._практика2___копияDataSet);

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_практика2___копияDataSet.Риски". При необходимости она может быть перемещена или удалена.
            this.рискиTableAdapter.Fill(this._практика2___копияDataSet.Риски);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.рискиBindingSource.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.рискиBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.рискиBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.рискиBindingSource.MoveLast();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.рискиBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.рискиBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.рискиBindingSource.EndEdit();
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
