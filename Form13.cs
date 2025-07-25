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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void группы_клиентовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.группы_клиентовBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._практика2___копияDataSet);

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_практика2___копияDataSet.Группы_клиентов". При необходимости она может быть перемещена или удалена.
            this.группы_клиентовTableAdapter.Fill(this._практика2___копияDataSet.Группы_клиентов);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.группы_клиентовBindingSource.MoveFirst();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.группы_клиентовBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.группы_клиентовBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.группы_клиентовBindingSource.MoveLast();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.группы_клиентовBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.группы_клиентовBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.группы_клиентовBindingSource.EndEdit();
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
