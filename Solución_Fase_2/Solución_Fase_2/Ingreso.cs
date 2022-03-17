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
    public partial class Ingreso : Form
    {
        Estadia estadia = new Estadia();
        public Ingreso()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //Validacion del Contador validar
            if(validar() == 1)
            {
                //Intancia del Objeto Estadia
                
                estadia.identificación = txtident.Text;
                estadia.nombre = txtnombreu.Text;
                if (rbtfem.Checked == true)
                {
                    estadia.genero = rbtfem.Text;
                }
                else
                {
                    estadia.genero = rbtmas.Text;
                }
                estadia.tipohab = cmbhabitacion.Text;
                estadia.dias = txthab.Text;
                estadia.costo = Convert.ToInt32(txtcosto.Text);
                //Bloqueo de Espacios
                txtnombreu.Enabled = false;
                txtident.Enabled = false;
                txthab.Enabled = false;
                cmbhabitacion.Enabled = false;
                groupBox1.Enabled = false;
                btnguardar.Enabled = false;
            }
        }
        
        public int validar()
        {
            //Metodo validar/Solicitud de datos,si el usuario no los ha ingresado
            //Contador a = 0 "Si alguna de las estructuras da verdadero" 
            //Contador a = 1 "Si alguna de las estructuras da falso"
            int a = 0;
            if (txtnombreu.Text == "")
            {
                MessageBox.Show("Por Favor Ingrese el Nombre del Huesped");
                txtnombreu.Focus();
            }
            else if (txtident.Text == "")
            {
                MessageBox.Show("Por favor Ingrese el Numero de Identificaccíon");
                txtident.Focus();
            }
            else if (txthab.Text == "")
            {
                MessageBox.Show("Por favor Ingrese Los Dias de Estadia en el Hotel");
            }
            else if (txtcosto.Text == "")
            {
                MessageBox.Show("Por favor Indique el tipo de Habitacíon del Huesped");
                cmbhabitacion.Focus();

            }
            else if (rbtfem.Checked == false && rbtmas.Checked==false)
            {
                MessageBox.Show("Por Favor Indique su Genero");
                groupBox1.Focus();
            }
            else
                a = 1;
            return a;
        }

        private void cmbhabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Estructura para conocer la habitacion en la cual se hospedo el usuario
            if (cmbhabitacion.Text == "Hab.Sencilla")
                txtcosto.Text = "70000";
            else if (cmbhabitacion.Text == "Hab.Doble")
                txtcosto.Text = "90000";
            else if (cmbhabitacion.Text == "Hab.Especial")
                txtcosto.Text = "120000";
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            
            //Instancia del Formulario Reporte
            Reporte reporte = new Reporte();
            reporte.Show();
            reporte.lblrnombre.Text = reporte.lblrnombre.Text + ":" + estadia.nombre;
            reporte.lblrident.Text = reporte.lblrident.Text + ":" + estadia.identificación;
            reporte.lblrgenero.Text = reporte.lblrgenero.Text + ":" + estadia.genero;
            reporte.lblrdias.Text = reporte.lblrdias.Text + ":" + estadia.dias;
            reporte.lblrtiphab.Text = reporte.lblrtiphab.Text + ":" + estadia.tipohab;
            reporte.lblrcosto.Text = reporte.lblrcosto.Text + ":" + estadia.costo.ToString();
            reporte.lblrcosto.Text = reporte.lblrcosto.Text + ":" + estadia.cacularhospedaje(Convert.ToInt32(estadia.dias), Convert.ToDecimal(estadia.costo)).ToString();
            reporte.lblrcosto.Text = reporte.lblrcosto.Text + ":" + estadia.cacularhospedaje(Convert.ToInt32(estadia.dias), Convert.ToDecimal(estadia.costo)).ToString();

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
