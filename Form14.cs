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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._практика2___копияDataSet);

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_практика2___копияDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this._практика2___копияDataSet.Сотрудники);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.Filter = "[Пол]='" + comboBox1.Text + "'";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;

            for (i = 0; i < сотрудникиDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < сотрудникиDataGridView.RowCount; j++)
                {
                    сотрудникиDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    сотрудникиDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < сотрудникиDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < сотрудникиDataGridView.RowCount; j++)
                {
                    var value = сотрудникиDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            сотрудникиDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            сотрудникиDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;


                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
                        dataGridViewTextBoxColumn4;
                        break;
                    case 2:
                        Col =
                        dataGridViewTextBoxColumn6;
                        break;
                }
                if (radioButton1.Checked)
                {
                    сотрудникиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
                }
                else
                {
                    сотрудникиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
                }
            }
        }
    }
}
