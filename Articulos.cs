using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace splash
{
    public partial class fArticulos : Form
    {
        public fArticulos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
         //   if ( Datos.Conectar())
           //label1.Text = "Conectado";
            //else
            //label1.Text = " Desconectado";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
          //  if (Datos.Desconectar())
          //      label1.Text = " Desconectado...";
           // else
             //   label1.Text = "No se desconectado...";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                
                Articulo a = Datos.leerArticulo(tbCodigo.Text);
                if (a == null)
                {
                    //MessageBox.Show("error, no se encontro el articulo ("+tbcodigo.Text+")");
                    //tbcodigo.Focus();
                    bELiminar.Enabled = false;
                }
                else
                {
                    tbDescripcion.Text = a.Descripcion;
                    tbCosto.Text = a.Costo.ToString();
                    tbPrecio.Text = a.Precio.ToString();
                    tbTasaIVA.Text = a.Iva.ToString();
                    tbIEPS.Text = a.Ieps.ToString();
                }
                Activar(false);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Articulo a = new Articulo();
            a.Codigo = tbCodigo.Text;

            if (bELiminar.Enabled == false)
                a.Codigo = "Nuevo";

            a.Descripcion = tbDescripcion.Text;
            a.Costo = double.Parse(tbCosto.Text);
            a.Precio = double.Parse(tbPrecio.Text);
            a.Iva = int.Parse(tbTasaIVA.Text);
            a.Ieps = int.Parse(tbIEPS.Text);

            Datos.grabarArticulo(a);
            Activar(true);
            //    MessageBox.Show("si lo graboooooo");
            //else
            //    MessageBox.Show("no se hizo la machacaaaaa");
        }

        private void fArticulos_Load(object sender, EventArgs e)
        {
            Activar(true);
        }

        private void bELiminar_Click(object sender, EventArgs e)
        {
            Datos.eliminoArticulo(tbCodigo.Text);
            Activar(true);
        }
        private void Activar(bool accion)
        {
            pCodigo.Enabled = accion;
            pDatos.Enabled = !accion;
            pAction.Enabled = !accion;

            if (accion == true)
            {
                tbCodigo.Focus();
                tbCodigo.SelectAll();
                tbDescripcion.Clear();
                tbPrecio.Clear();
                tbCosto.Clear();
                tbTasaIVA.Clear();
                tbIEPS.Clear();
            }
            else
            {
                tbDescripcion.Focus();
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Activar(true);
        }

        private void bELiminar_Click_1(object sender, EventArgs e)
        {
            Datos.eliminoArticulo(tbCodigo.Text);
            Activar(true);
        }

        private void bCancelar_Click_1(object sender, EventArgs e)
        {
            
            Activar(true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Buscar f = new Buscar();
            string valor = f.Dato("articulos","Descripcion","Codigo");
            if (f.DialogResult == DialogResult.OK)
            {
              
                
            }
            else
            {
                tbCodigo.Clear();
                tbCodigo.Focus();
            }
        }

    }
}
