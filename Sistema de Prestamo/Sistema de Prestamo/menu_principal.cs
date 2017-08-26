using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Prestamo
{
    public partial class menu_principal : Form
    {
        public menu_principal()
        {
            InitializeComponent();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void menu_principal_Load(object sender, EventArgs e)
        {
            panelcliente1.Visible  = false;
            panelprestamo1.Visible = false;
        }

        private void mantenimintoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelprestamo1.Visible = false;
            panelcliente1.Visible = true;
            
        }

        private void realizarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelcliente1.Visible = false;
            panelprestamo1.Visible = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion_clientes clientes = new conexion_clientes();

            if (clientes.ValidarCliente(TXBACnombre.Text,TXBACapaterno.Text, TXBACamaterno.Text) == 0)
            { 
                clientes.InsertarCliente(TXBACnombre.Text, TXBACapaterno.Text, TXBACamaterno.Text, CBXACidentificacion.Text, TXBACdireccion.Text, TXBACtelefono.Text, CBXACsexo.Text);
                TXBACnombre.Clear(); TXBACapaterno.Clear(); TXBACamaterno.Clear(); TXBACdireccion.Clear(); TXBACtelefono.Clear(); TXBACid.Clear(); TXBCbuscar.Clear();
                DGVclientes.Rows.Clear();
                DGVclientes.Refresh();
            }
            else
            {
                MessageBox.Show("Esta persona ya se encuentra registrada");
            }
            
        }

        private void BTNBcliente_Click(object sender, EventArgs e)
        {
            conexion_clientes clientes = new conexion_clientes();
            clientes.EliminarCliente(TXBACid.Text);
            TXBACnombre.Clear(); TXBACapaterno.Clear(); TXBACamaterno.Clear(); TXBACdireccion.Clear(); TXBACtelefono.Clear(); TXBACid.Clear(); TXBCbuscar.Clear();
            DGVclientes.Rows.Clear();
            DGVclientes.Refresh();
        }

        private void BTNUmodificar_Click(object sender, EventArgs e)
        {
            conexion_clientes clientes = new conexion_clientes();
            clientes.ModificarCliente(Int32.Parse(TXBACid.Text), TXBACnombre.Text, TXBACapaterno.Text, TXBACamaterno.Text, CBXACidentificacion.Text, TXBACdireccion.Text, TXBACtelefono.Text, CBXACsexo.Text, CBXstatus.Text);
            TXBACnombre.Clear(); TXBACapaterno.Clear(); TXBACamaterno.Clear(); TXBACdireccion.Clear(); TXBACtelefono.Clear(); TXBACid.Clear(); TXBCbuscar.Clear();
            DGVclientes.Rows.Clear();
            DGVclientes.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion_clientes clientes = new conexion_clientes();
            DGVclientes.DataSource = clientes.BuscarCliente(CBXCbuscar.Text, TXBCbuscar.Text);
        }

        private void DGVclientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TXBACnombre.Text = DGVclientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            TXBACapaterno.Text = DGVclientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            TXBACamaterno .Text = DGVclientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            CBXACidentificacion.Text = DGVclientes.Rows[e.RowIndex].Cells[4].Value.ToString();
            TXBACid.Text = DGVclientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            TXBACdireccion.Text = DGVclientes.Rows[e.RowIndex].Cells[5].Value.ToString();
            TXBACtelefono.Text = DGVclientes.Rows[e.RowIndex].Cells[6].Value.ToString();
            CBXACsexo.Text = DGVclientes.Rows[e.RowIndex].Cells[7].Value.ToString();
            CBXstatus.Text = DGVclientes.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
    }
}
