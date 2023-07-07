using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuCalculadora_Click(object sender, EventArgs e)
        {
            Calculadora frmCalculadora = new Calculadora();
            frmCalculadora.MdiParent = this;
            frmCalculadora.Show();
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            Clientes frmClientes = new Clientes();
            frmClientes.MdiParent = this;
            frmClientes.Show();
        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.MdiParent = this;
            frmLogin.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            menuAplicaciones.Enabled = false;
            Login frmLogin = new Login();
            frmLogin.MdiParent = this;
            frmLogin.Show();
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuAplicaciones_Click(object sender, EventArgs e)
        {

        }
    }
}
