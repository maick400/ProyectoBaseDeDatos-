using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerminalesProyecto.Cooperativa.Clases;

namespace TerminalesProyecto.Cooperativa.Forms
{
    public partial class frmClientes : Form
    {

        Cliente cliente = new Cliente();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = cliente.Listar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmBoleto().Show();
            this.Hide();

        }
    }
}
