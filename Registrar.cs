using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skal_APP
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
                if (TYC.Checked)
                {
                    Login interfaz_login = new Login();

                    MessageBox.Show("Usuario Agregado Existosamente");
                    interfaz_login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Favor aceptar terminos y condiciones");
                }
        }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }
    }
}
