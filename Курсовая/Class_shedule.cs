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
    public partial class Class_shedule : Form
    {
        private System.Windows.Forms.DataGridViewColumn CORT;

        public Class_shedule()
        {
            InitializeComponent();
        }

        private void class_scheduleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.class_scheduleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportDataSet);

        }

        private void Class_shedule_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet.Class_schedule". При необходимости она может быть перемещена или удалена.
            this.class_scheduleTableAdapter.Fill(this.sportDataSet.Class_schedule);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CORT = new System.Windows.Forms.DataGridViewColumn();
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    CORT = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    CORT = dataGridViewTextBoxColumn3;
                    break;
              


            }
            if (radioButton1.Checked)
            {
                class_scheduleDataGridView.Sort(CORT, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                class_scheduleDataGridView.Sort(CORT, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < class_scheduleDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < class_scheduleDataGridView.RowCount - 1; j++)
                {
                    class_scheduleDataGridView[i, j].Style.BackColor = Color.White;
                    class_scheduleDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < class_scheduleDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < class_scheduleDataGridView.RowCount - 1; j++)
                {
                    if (class_scheduleDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        class_scheduleDataGridView[i, j].Style.BackColor = Color.Red;
                        class_scheduleDataGridView[i, j].Style.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void class_scheduleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
