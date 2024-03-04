using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Coach : Form
    {
        private System.Windows.Forms.DataGridViewColumn CORT;

        public Coach()
        {
            InitializeComponent();
        }

        private void coachs1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coachs1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportDataSet);

        }

        private void Coach_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet.Coachs1". При необходимости она может быть перемещена или удалена.
            this.coachs1TableAdapter.Fill(this.sportDataSet.Coachs1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CORT = new System.Windows.Forms.DataGridViewColumn();
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    CORT = dataGridViewTextBoxColumn1;
                    break;
                case 1:
                    CORT = dataGridViewTextBoxColumn2;
                    break;
                case 2:
                    CORT = dataGridViewTextBoxColumn3;
                    break;
                case 3:
                    CORT = dataGridViewTextBoxColumn4;
                    break;
                case 4:
                    CORT = dataGridViewTextBoxColumn5;
                    break;
                case 5:
                    CORT = dataGridViewTextBoxColumn6;
                    break;


            }
            if (radioButton1.Checked)
            {
                coachs1DataGridView.Sort(CORT, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                coachs1DataGridView.Sort(CORT, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < coachs1DataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < coachs1DataGridView.RowCount - 1; j++)
                {
                    coachs1DataGridView[i, j].Style.BackColor = Color.White;
                    coachs1DataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < coachs1DataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < coachs1DataGridView.RowCount - 1; j++)
                {
                    if (coachs1DataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        coachs1DataGridView[i, j].Style.BackColor = Color.Red;
                        coachs1DataGridView[i, j].Style.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
