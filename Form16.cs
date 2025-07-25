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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void полисыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.полисыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._практика2___копияDataSet);

        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_практика2___копияDataSet.Полисы". При необходимости она может быть перемещена или удалена.
            this.полисыTableAdapter.Fill(this._практика2___копияDataSet.Полисы);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            полисыBindingSource.Filter = "[Стоимость]='" + comboBox1.Text + "'";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int i = 0;
            int j = 0;

            for (i = 0; i < полисыDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < полисыDataGridView.RowCount; j++)
                {
                    полисыDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    полисыDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < полисыDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < полисыDataGridView.RowCount; j++)
                {
                    var value = полисыDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            полисыDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            полисыDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;


                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            полисыBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn
                Col = default(System.Windows.Forms.DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col =
                    dataGridViewTextBoxColumn2;
                    break;

                case 1:
                    Col =
                    dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    Col =
                    dataGridViewTextBoxColumn4;
                    break;

                case 3:
                    Col =
                    dataGridViewTextBoxColumn5;
                    break;
            }
            if (radioButton1.Checked)
            {
                полисыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                полисыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
            }



        }

        private void полисыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
