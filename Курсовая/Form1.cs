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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void информацияОГруппеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_shedule adw= new Class_shedule();
            adw.Show();
        }

        private void тренерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Coach awdwd=new Coach();
            awdwd.Show();
        }

        private void названиеСекцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_of_section awldlwadl=new List_of_section();
            awldlwadl.Show();
        }

        private void спортсменToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sportsman awdawd=new Sportsman();
            awdawd.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
