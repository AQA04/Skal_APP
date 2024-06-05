using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skal_APP
{
    public partial class Medico : Form
    {
        public Medico()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Llamada interaz_llamada = new Llamada();

            interaz_llamada.Show();
            this.Hide();

            Thread.Sleep(5000);

            interaz_llamada.Hide();
            this.Show();
        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            Login interfaz_Login = new Login();

            interfaz_Login.Show();
            this.Hide();
        }
    }
}
