using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11
{
    public partial class frmGrafic : Form
    {
        public frmGrafic()
        {
            InitializeComponent();
        }

        private void frmGrafic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSGrafic.Doctori' table. You can move, or remove it, as needed.
            this.doctoriTableAdapter.Fill(this.dSGrafic.Doctori);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Meniu f = new Meniu();
            f.Show();
        }
    }
}
