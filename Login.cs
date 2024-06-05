using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Skal_APP
{
    public partial class Login : Form
    {

        List<string> usuarios = new List<string>()
        {
            "b",
            "Alejandro",
            "Juanita",
            "Santiago",
            "aaa",
            "Cristian",

        };

        List<string> contraseña = new List<string>()
        {
            "1",
            "a111",
            "j222",
            "s333",
            "111",
            "c444",
        };

        List<int> rol = new List<int>()
        {
            1,
            0,
            0,
            1,
            0,
            0,

        };



        public Login()
        {
            InitializeComponent();
            
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            Bienvenido interfaz_bienvenido = new Bienvenido();

            interfaz_bienvenido.Show();
            this.Hide();

        }

        public void Ingresar_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < usuarios.Count(); i++)
            {
                
                if (usuarios[i] == User.Text.ToString() && contraseña[i] == Password.Text)
                {
                    MessageBox.Show($"Bienvenido {usuarios[i]}");

                    if (rol[i] == 0)
                    {
                        Cliente interfaz_cliente = new Cliente();
                        interfaz_cliente.Show();
                        this.Hide();

                    } else
                    {

                        Medico interfaz_Medico = new Medico();

                        interfaz_Medico.Show();
                        this.Hide();
                    }
                    

                    break;
                }

                if (i == usuarios.Count() - 1)
                {
                    MessageBox.Show("Usuario o contraseña equivocada");
                }
                
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
