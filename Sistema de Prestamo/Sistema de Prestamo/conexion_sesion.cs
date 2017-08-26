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
    class conexion_sesion
    {

        SqlConnection con = new SqlConnection("Data Source = usuario-pc\\sqlexpress; Initial Catalog = prestamo; Integrated Security = True");

        //Login
        public void logear(string usuario, string contrasena)
        {


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select usuario,tipo from login where usuario = @usuario AND pass = @pass", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pass", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        //new inicioAdmin(dt.Rows[0][0].ToString()).Show();
                        


                    }
                    else if (dt.Rows[0][1].ToString() == "usuario")
                    {
                        new menu_principal().Show();

                    }

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                    new inicio_sesion().Show();

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                con.Close();
            }

        }
    }
}
