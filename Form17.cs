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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void виды_полисовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.виды_полисовBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._практика2___копияDataSet);

        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_практика2___копияDataSet.Виды_полисов". При необходимости она может быть перемещена или удалена.
            this.виды_полисовTableAdapter.Fill(this._практика2___копияDataSet.Виды_полисов);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            виды_полисовBindingSource.Filter = "[Наименование]='" + comboBox1.Text + "'";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int i = 0;
            int j = 0;

            for (i = 0; i < виды_полисовDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < виды_полисовDataGridView.RowCount; j++)
                {
                    виды_полисовDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    виды_полисовDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < виды_полисовDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < виды_полисовDataGridView.RowCount; j++)
                {
                    var value = виды_полисовDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            виды_полисовDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            виды_полисовDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;


                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            виды_полисовBindingSource.Filter = "";
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
                виды_полисовDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                виды_полисовDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
