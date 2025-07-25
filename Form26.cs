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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void Form26_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_практика2___копияDataSet.Отдел_кадров". При необходимости она может быть перемещена или удалена.
            this.отдел_кадровTableAdapter.Fill(this._практика2___копияDataSet.Отдел_кадров);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.отдел_кадровBindingSource.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.отдел_кадровBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.отдел_кадровBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.отдел_кадровBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.отдел_кадровBindingSource.MoveNext();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.отдел_кадровBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.отдел_кадровBindingSource.EndEdit();
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

        private void button8_Click(object sender, EventArgs e)
        {
            Form21 frm = new Form21();
            frm.Show();
        }
    }
}
