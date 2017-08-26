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
    public partial class inicio_sesion : Form
    {

        
        public inicio_sesion()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            conexion_sesion sesion = new conexion_sesion();
            sesion.logear(this.TXBSusuario.Text, this.TXTBSpass.Text);
            
        }
    }
}
