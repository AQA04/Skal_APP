using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatBotApp;
using Skal_APP;

namespace Skal_APP
{
    public partial class Bienvenido : Form
    {
        public Bienvenido()
        {
            InitializeComponent();

        }

        private void Bienvenido_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login interfaz_login = new Login();

            interfaz_login.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar interfaz_registrar = new Registrar();

            interfaz_registrar.Show();
            this.Hide();
        }
    }
}
