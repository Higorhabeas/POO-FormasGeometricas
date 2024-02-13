using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormasGeometricas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void quadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm1 = new Form1();
            frm1.MdiParent = this;
            frm1.Show();

        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm2 =new Form2();
            frm2.MdiParent = this;
            frm2.Show();
        }
    }
}
