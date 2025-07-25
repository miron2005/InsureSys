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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void виды_полисовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.виды_полисовBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._практика2___копияDataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_практика2___копияDataSet.Виды_полисов". При необходимости она может быть перемещена или удалена.
            this.виды_полисовTableAdapter.Fill(this._практика2___копияDataSet.Виды_полисов);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.виды_полисовBindingSource.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.виды_полисовBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.виды_полисовBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.виды_полисовBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.виды_полисовBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.виды_полисовBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.виды_полисовBindingSource.EndEdit();
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
