using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Prestamo
{
    class conexion_clientes
    {
        SqlConnection con = new SqlConnection("Data Source = usuario-pc\\sqlexpress; Initial Catalog = prestamo; Integrated Security = True");

        //Validar Cliente
        public int ValidarCliente(string nombre, string Apaterno, string Amaterno)
        {
            int contador = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from clientes where nombre = " + "'" + nombre + "'" + " and apellido_paterno = " + "'" + Apaterno + "'" + " and  apellido_materno =  " + "'" + Amaterno + "'" + "", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;

                }
                dr.Close();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("El usuario ya existe " + e.ToString());
                throw;
            }
            return contador;
        }

        //Insertar Cliente
        public void InsertarCliente(string nombre, string Apaterno, string Amaterno,string identificacion, string direccion, string telefono, string sexo)
        {
            string status = "Activo";
            DateTime thisDay = DateTime.Today;
            string fecha = thisDay.ToString();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into clientes (nombre,apellido_paterno,apellido_materno,identificacion,direccion,telefono,sexo,status,ingreso) values ('" + nombre + "','" + Apaterno + "','" + Amaterno + "','" + identificacion + "','" + direccion+ "','" + telefono  + "','" + sexo + "','" + status + "','" + fecha + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("El cliente fue ingresado correctamente");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }

            finally
            {
                con.Close();
            }

        }

        //Buscar cliente
        public DataTable BuscarCliente(string filtro, string buscar)
        {
            DataTable dtbuscar = new DataTable();

            //Buscar por apellido paterno

            if (filtro == "Apellido Paterno")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select id_cliente,nombre,apellido_paterno,apellido_materno,identificacion,direccion,telefono,sexo,status from clientes where apellido_paterno = " + "'" + buscar + "'" + "", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtbuscar);
                    con.Close();
                }

                catch (Exception e)
                {
                    MessageBox.Show("El prestamo no se encuentra " + e.ToString());
                    throw;
                }

                finally
                {
                    con.Close();
                }
            }

            //Buscar por Autor
            if (filtro == "Identificador")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select id_cliente,nombre,apellido_paterno,apellido_materno,identificacion,direccion,telefono,sexo,status, from clientes where codigo_usuario = " + "'" + buscar + "'" + "", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtbuscar);
                    con.Close();
                }

                catch (Exception e)
                {
                    MessageBox.Show("El prestamo no se encuentra " + e.ToString());
                    throw;
                }

                finally
                {
                    con.Close();
                }
            }

            return dtbuscar;
        }


        //Modificar Cliente
        public void ModificarCliente(int id, string nombre, string Apaterno, string Amaterno,string identificacion, string direccion, string telefono, string sexo, string status)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update clientes set nombre = '" + nombre + "',apellido_paterno = '" + Apaterno + "', apellido_materno = '" + Amaterno + "', Identificacion= '" + identificacion + "', direccion = '" + direccion + "', telefono = '" + telefono  + "', sexo = '" + sexo + "' , status = '" + status  + "' where id_cliente ='" + id + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("El usuario ha sido modificado correctamente");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }

            finally
            {
                con.Close();
            }

        }

        //Eliminar Cliente
        public void EliminarCliente(string id)
        {
            
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from clientes where id_cliente = ('" + id + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("El cliente ha sido eliminado correctamente");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }

            finally
            {
                con.Close();
            }

        }



    }
}
