﻿using System;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._практика2___копияDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_практика2___копияDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this._практика2___копияDataSet.Сотрудники);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.MoveNext();
        }

      
private void button3_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.сотрудникиBindingSource.EndEdit();
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
