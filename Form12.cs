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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._практика2___копияDataSet);

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_практика2___копияDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this._практика2___копияDataSet.Клиенты);

        }

        private void паспортные_данныеLabel_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.клиентыBindingSource.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.клиентыBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.клиентыBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.клиентыBindingSource.MoveLast();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.клиентыBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.клиентыBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.клиентыBindingSource.EndEdit();
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
