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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void группы_клиентовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.группы_клиентовBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._практика2___копияDataSet);

        }

        private void Form20_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_практика2___копияDataSet.Группы_клиентов". При необходимости она может быть перемещена или удалена.
            this.группы_клиентовTableAdapter.Fill(this._практика2___копияDataSet.Группы_клиентов);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn
               Col = default(System.Windows.Forms.DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col =
                    dataGridViewTextBoxColumn3;
                    break;
                


            }
            if (radioButton1.Checked)
            {
                группы_клиентовDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                группы_клиентовDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            группы_клиентовBindingSource.Filter = "[Наимменование]='" + comboBox1.Text + "'";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int i = 0;
            int j = 0;

            for (i = 0; i < группы_клиентовDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < группы_клиентовDataGridView.RowCount; j++)
                {
                    группы_клиентовDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    группы_клиентовDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < группы_клиентовDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < группы_клиентовDataGridView.RowCount; j++)
                {
                    var value = группы_клиентовDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            группы_клиентовDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            группы_клиентовDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;


                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            группы_клиентовBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
