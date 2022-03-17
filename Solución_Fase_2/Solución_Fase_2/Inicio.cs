using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solución_Fase_2
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (txtcontraseña.Text != "")
            {
                if(txtcontraseña.Text == "123")
                {
                    Ingreso i = new Ingreso();
                    i.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("La Contraseña no es valida");
                    txtcontraseña.Text = "";
                    txtcontraseña.Focus();
                }
            }
            else
            {
                MessageBox.Show("Por Favor Ingrese una Contraseña");
            }
        }
    }
}
