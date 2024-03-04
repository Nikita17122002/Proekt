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
    public partial class List_of_section : Form
    {
        public List_of_section()
        {
            InitializeComponent();
        }

        private void list_of_sectionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.list_of_sectionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportDataSet);

        }

        private void List_of_section_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet.List_of_sections". При необходимости она может быть перемещена или удалена.
            this.list_of_sectionsTableAdapter.Fill(this.sportDataSet.List_of_sections);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list_of_sectionsDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < list_of_sectionsDataGridView.RowCount - 1; j++)
                {
                    list_of_sectionsDataGridView[i, j].Style.BackColor = Color.White;
                    list_of_sectionsDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < list_of_sectionsDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < list_of_sectionsDataGridView.RowCount - 1; j++)
                {
                    if (list_of_sectionsDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        list_of_sectionsDataGridView[i, j].Style.BackColor = Color.Red;
                        list_of_sectionsDataGridView[i, j].Style.ForeColor = Color.Black;
                    }
                }
            }
        }
    }
}
