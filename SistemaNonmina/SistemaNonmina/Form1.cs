using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNonmina
{
    public partial class Form1 : Form
    {
        Menu pantalla;
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection coneccion = new SqlConnection("server=DESKTOP-2TMBJAF ; database = PERSONAS2 ; INTEGRATED SECURITY = true");
        
        private void button1_Click(object sender, EventArgs e)
        {

            if ((txtusuario.Text != "") && (txtcontrasena.Text != ""))
            {
                coneccion.Open();
                SqlCommand comando = new SqlCommand("SELECT USUARIO, CONTRASENA FROM PERSONA WHERE USUARIO = @vusuario AND CONTRASENA = @vcontrasena", coneccion);

                comando.Parameters.AddWithValue("@vusuario", txtusuario.Text);
                comando.Parameters.AddWithValue("@vcontrasena", txtcontrasena.Text);

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {

                    coneccion.Close();
                    pantalla = new Menu();
                    pantalla.Show();
                    this.Hide();


                }
                else
                {
                    coneccion.Close();
                    MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTOS");
                }

            }
            else
            {
                MessageBox.Show("NO DEJES CAMPOS VACIOS");
            }
        }
    }
}
