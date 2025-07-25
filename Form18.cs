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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void рискиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.рискиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._практика2___копияDataSet);

        }

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_практика2___копияDataSet.Риски". При необходимости она может быть перемещена или удалена.
            this.рискиTableAdapter.Fill(this._практика2___копияDataSet.Риски);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            рискиBindingSource.Filter = "[Наименование]='" + comboBox1.Text + "'";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int i = 0;
            int j = 0;

            for (i = 0; i < рискиDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < рискиDataGridView.RowCount; j++)
                {
                    рискиDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    рискиDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < рискиDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < рискиDataGridView.RowCount; j++)
                {
                    var value = рискиDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            рискиDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            рискиDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;


                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            рискиBindingSource.Filter = "";
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


            }
            if (radioButton1.Checked)
            {
                рискиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                рискиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
