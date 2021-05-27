using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMahasiswa
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void materBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterBarang025 masterBarang = new MasterBarang025();
            masterBarang.Show();
        }

        private void reportBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportBarang027 reportBarang = new ReportBarang027();
            reportBarang.Show();
        }
    }
}
