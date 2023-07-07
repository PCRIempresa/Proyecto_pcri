using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADODB;

namespace Calculadora
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static Principal frmPrincipal;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(frmPrincipal = new Principal());
        }

        public static ADODB.Connection cn = new ADODB.Connection();
        private static Recordset nothing;

        public static void DoyPermisos(String usuario)
        {
            String sql;
            byte rol;
            ADODB.Recordset rs = new ADODB.Recordset();
            object filasAfectadas;

            frmPrincipal.menuAplicaciones.Enabled = false;
            frmPrincipal.menuClientes.Enabled = false; //En la propiedad modifiers poner Public
            frmPrincipal.menuProveedores.Enabled = false;

            if (cn.State != 0)
            {
                // sentencia sql
                sql = "select rol from usuario_rol where usuario ='" + usuario + "'";
                try
                {
                    rs = cn.Execute(sql, out filasAfectadas);
                }
                catch
                {
                    rs = null; //destruir objeto
                    return;
                }
                if (rs.RecordCount > 0)//encontramos rol del usuario
                {
                    rol = Convert.ToByte(rs.Fields[0].Value);
                    switch (rol) 
                    {
                        case 1: //Compras
                            frmPrincipal.menuAplicaciones.Enabled = true;
                            frmPrincipal.menuProveedores.Enabled = true;
                            break;
                        case 2: //Ventas
                            frmPrincipal.menuAplicaciones.Enabled = true;
                            frmPrincipal.menuClientes.Enabled = true;
                            break;
                    }//termina switch
                }//termina if (rs.RecordCount > 0)
            }//termina if (cn.State != 0)
            rs = null;
            filasAfectadas = null;
        }//termina DoyPermisos
    }
}
