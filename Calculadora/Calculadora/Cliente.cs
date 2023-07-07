using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Cliente
    {
        /*public ADODB.Connection conexion { set; get; }
        public Int32 ci { set; get; }
        public byte Buscar()
        {
            return (0);
        }
        public string Nombre { set; get; }
        public List < string > Telefonos { set; get; }*/
        protected Int32 _ci;
        protected string _nombre;
        protected List<string> _telefonos;
        protected ADODB.Connection _conexion;
        public Int32 ci
        {
            set { _ci = value; }
            get { return (_ci); }
        }
        public string nombre
        {
            set { _nombre = value; }
            get { return (_nombre); }
        }
        public ADODB.Connection conexion
        {
            set { _conexion = value; }
            get { return (_conexion); }
        }
        public List<string> telefonos
        {
            set { _telefonos = value; }
            get { return (_telefonos); }
        }
        public Cliente()
        {
            _ci = 0;
            _nombre = "";
            _telefonos = new List<string>();
            _conexion = new ADODB.Connection();
        }
        public byte Buscar()
        {
            string sql;
            ADODB.Recordset rs;
            object filasAfectadas;
            byte resultado = 0; //0=encontré,1=conexión cerrada,2=error al buscar clientes,3=no encontré,4=error al bucar en tabla cliente_telefonos
            if (_conexion.State == 0)
            {
                resultado = 1; //conexión cerrrada
            }
            else
            {
                sql = "Select nombreCliente from clientes where ci=" + _ci;
                try
                {
                    rs = _conexion.Execute(sql, out filasAfectadas);
                }
                catch
                {
                    return (2);
                }
                if (rs.RecordCount == 0)
                {
                    resultado = 3;
                }
                else
                {
                    _nombre = Convert.ToString(rs.Fields[0].Value);
                    sql = "Select telefono from cliente_telefonos where cliente="+_ci;
                    try
                    {
                        rs = _conexion.Execute(sql, out filasAfectadas);
                    }
                    catch
                    {
                        return (4);
                    }
                    _telefonos.Clear();
                    while (!rs.EOF)
                    {
                        _telefonos.Add(Convert.ToString(rs.Fields[0].Value));
                        rs.MoveNext();
                    }
                }
                rs = null;
                filasAfectadas = null;
            }
            return (resultado);
        }
        public byte Guardar(Boolean modificacion)
        {
            string sql;
            object filasAfectadas;
            byte resultado = 0;
            if (_conexion.State == 0)
            {
                resultado = 1;
            }
            else
            {//start transaction
                if (modificacion)
                {
                    sql = "update clientes set nombreCliente='" + _nombre + "' where ci=" + _ci;
                }
                else
                {
                    sql = "insert into clientes (ci,nombreCliente) values(" + _ci + ",'" + _nombre + "')";
                }
                try
                {
                    _conexion.Execute(sql, out filasAfectadas);
                }
                catch
                {
                    return (2);
                }
                if (modificacion)
                {
                    sql = "delete from cliente_telefonos where cliente =" + _ci;
                    try
                    {
                        _conexion.Execute(sql, out filasAfectadas);
                    }
                    catch
                    {//_conexion.execute("rollback", out filasAfectadas); Ejecutar un rollback solo si hicimos un start transaction al principio
                        return (3);
                    }
                }
                foreach(string tel in _telefonos)
                {
                    sql = "insert into cliente_telefonos(cliente,telefono) values("+_ci+",'"+tel+"')";
                    try
                    {
                        _conexion.Execute(sql, out filasAfectadas);
                    }
                    catch
                    {
                        return (4);
                    }
                }//commit;
                filasAfectadas = null;
            }
            return (resultado);
        }
        public byte Eliminar()
        {
            byte resultado = 0;
            string sql;
            object filasAfectadas;
            if (_conexion.State == 0)
            {
                resultado = 1;
            }
            else
            {
                sql = "delete from cliente_telefonos where cliente=" + _ci;
                try
                {
                    _conexion.Execute(sql, out filasAfectadas);
                }
                catch
                {
                    return (2);
                }
                sql = "delete from clientes where ci=" + _ci;
                try
                {
                    _conexion.Execute(sql, out filasAfectadas);
                }
                catch
                {
                    return (3);
                }
                filasAfectadas = null;
            }
            return (resultado);
        }
    }
}
