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
using ChatBotApp;
using Skal_APP;

namespace Skal_APP
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            MiniSkal interfaz_miniSkal = new MiniSkal();
            interfaz_miniSkal.Show();
            this.Hide();
        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            Login interfaz_Login = new Login();

            interfaz_Login.Show();
            this.Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            miniskal interfaz_miniskal = new miniskal();

            

            monthCalendar1.BoldedDates = new DateTime[] { new DateTime(DateTime.Now.Year, DateTime.Now.Month, 15) };
            monthCalendar1.SelectionStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 15);
            monthCalendar1.SelectionEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 15);
        }
    }
}
