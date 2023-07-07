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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            gbDatos.Visible = false;
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            Int32 ci;
            c.conexion = Program.cn;
            DialogResult respuesta;
            if(!Int32.TryParse(txtCi.Text,out ci))
            {
                MessageBox.Show("La CI debe ser solo numérica");
            }
            else
            {
                c.ci = ci;
                switch (c.Buscar())
                {
                    case 0: //Encontró
                        gbBuscar.Enabled = false;
                        gbDatos.Visible = true;
                        btnEliminar.Enabled = true;
                        txtNombre.Text = c.nombre;
                        cboTelefonos.Items.Clear();
                        foreach(string tel in c.telefonos)
                        {
                            cboTelefonos.Items.Add(tel);
                        }
                        break;
                    case 1: //Conexión cerrada
                        MessageBox.Show("Debe loguearse manualmente");
                        break;
                    case 2: //Error al buscar cliente
                        MessageBox.Show("Error al buscar datos en la tabla Clientes");
                        break;
                    case 3: //No encontré
                        respuesta = MessageBox.Show("¿Desea efectuar el alta?", "Alta de Cliente", MessageBoxButtons.YesNo);
                        if (respuesta == DialogResult.Yes)
                        {
                            gbDatos.Visible = true;
                            gbBuscar.Enabled = false;
                            btnEliminar.Enabled = false;
                            txtNombre.Clear();
                            cboTelefonos.Items.Clear();
                        }
                        break;
                    case 4: //Error al buscar teléfonos
                        MessageBox.Show("Error al buscar teléfonos");
                        break;
                }//switch
            }//else
            c = null; //Destruyo el objeto de la clase cliente
        }//btnBuscar_click

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            Int32 ci;
            if (!Int32.TryParse(txtCi.Text, out ci))
            {
                MessageBox.Show("La CI debe ser solo numérica");
            }
            else
            {
                c.conexion = Program.cn;
                c.ci = ci;
                c.nombre = txtNombre.Text;
                foreach(string tel in cboTelefonos.Items)
                {
                    c.telefonos.Add(tel);
                }
                switch (c.Guardar(btnEliminar.Enabled)) // Está habilitando en la modificación e inhabilitando en el alta
                {
                    case 0: gbBuscar.Enabled = true;
                        gbDatos.Visible = false;
                        break;
                    case 1: MessageBox.Show("Debe loguearse nuevamente");
                        break;
                    case 2: MessageBox.Show("Error 1");
                        break;
                    case 3: MessageBox.Show("Error 2");
                        break;
                    case 4: MessageBox.Show("Hubo errores al efectuar la operación. Reintente y/o avise al admin.");
                        break;
                }
            }
            c = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 ci;
            DialogResult respuesta;
            Cliente c = new Cliente();
            if(!Int32.TryParse(txtCi.Text, out ci))
            {
                MessageBox.Show("CI debe ser numérica");
            }
            else
            {
                c.conexion = Program.cn;
                c.ci = ci;
                respuesta = MessageBox.Show("¿Está seguro?", "Eliminar Cliente", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    switch (c.Eliminar())
                    {
                        case 0: gbBuscar.Enabled = true;
                            gbDatos.Visible = false;
                            break;
                        case 1: MessageBox.Show("Debe loguearse nuevamente");
                            break;
                        default:MessageBox.Show("Hubo errores al efectuar la operación, reintente.");
                            break;
                    }
                }
                c = null;
            }
        }

        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            if (cboTelefonos.Items.IndexOf(cboTelefonos.Text) < 0) //Para buscar en una lista se usa IndexOf
            {
                cboTelefonos.Items.Add(cboTelefonos.Text);
            }
            else
            {
                MessageBox.Show("El teléfono ya existe en la lista");
            }
        }

        private void btnQuitarTelefono_Click(object sender, EventArgs e)
        {
            if (cboTelefonos.Items.IndexOf(cboTelefonos.Text) < 0) //Para buscar en una lista se usa IndexOf
            {
                MessageBox.Show("El teléfono no existe en la lista");
            }
            else
            {
                cboTelefonos.Items.Remove(cboTelefonos.Text);
            }
        }
    }
}
