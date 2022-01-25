using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminalesProyecto.Cooperativa.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void bolerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        void abrirFrom (Form frm)
        {
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.Show();
            
        }

        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFrom(new frmBoleto());
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void generarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirFrom(new frmEncomiendas());
        }
    }
}
