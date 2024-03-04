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
    public partial class Sportsman : Form
    {
        private System.Windows.Forms.DataGridViewColumn CORT;

        public Sportsman()
        {
            InitializeComponent();
        }

        private void athletesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.athletesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportDataSet);

        }

        private void Sportsman_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet.Athletes". При необходимости она может быть перемещена или удалена.
            this.athletesTableAdapter.Fill(this.sportDataSet.Athletes);

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
                athletesDataGridView.Sort(CORT, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                athletesDataGridView.Sort(CORT, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < athletesDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < athletesDataGridView.RowCount - 1; j++)
                {
                    athletesDataGridView[i, j].Style.BackColor = Color.White;
                    athletesDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < athletesDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < athletesDataGridView.RowCount - 1; j++)
                {
                    if (athletesDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        athletesDataGridView[i, j].Style.BackColor = Color.Red;
                        athletesDataGridView[i, j].Style.ForeColor = Color.Black;
                    }
                }
            }
        }
    }
}
