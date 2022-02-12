using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNonmina
{
    public partial class Menu : Form
    {
        Home pantalla;
        FACTURAR pantallas;
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pantalla = new Home();
            pantalla.Show();
            this.Hide();
        }

        private void Facturar_Click(object sender, EventArgs e)
        {
            pantallas = new FACTURAR();
            pantallas.Show();
            this.Hide();
        }
    }
}
