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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._практика2___копияDataSet);

        }

        private void Form19_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_практика2___копияDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this._практика2___копияDataSet.Клиенты);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.Filter = "[Пол]='" + comboBox1.Text + "'";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int i = 0;
            int j = 0;

            for (i = 0; i < клиентыDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < клиентыDataGridView.RowCount; j++)
                {
                    клиентыDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    клиентыDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < клиентыDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < клиентыDataGridView.RowCount; j++)
                {
                    var value = клиентыDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            клиентыDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            клиентыDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;


                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.Filter = "";
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
                case 1:
                    Col =
                    dataGridViewTextBoxColumn7;
                    break;
                case 2:
                    Col =
                    dataGridViewTextBoxColumn8;
                    break;



            }
            if (radioButton1.Checked)
            {
                клиентыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                клиентыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
