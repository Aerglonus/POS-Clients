using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace splash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread tiempo = new Thread( new ThreadStart(screen1));
            tiempo.Start();
            Thread.Sleep(7000); // con esto se retrasa el form2, se debe de poner en milisegundos
            InitializeComponent();
            tiempo.Abort(); // aqui termina y se ejecuta form2
        }
        public void screen1()
        {
            Application.Run(new inicio());
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {

        }

        private void emisorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void catalogoDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "fArticulos").SingleOrDefault<Form>();
            if (f == null)
            {
                f = new fArticulos();
                f.MdiParent = this; // para poner formularios hijos
            }

            f.Show();
            f.BringToFront();
        }
        
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void catalagoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Form c = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "fClientes").SingleOrDefault<Form>(); // para que no se abra otro formulario
             if (c == null)
             {
                  c = new fClientes();
                  c.MdiParent = this; // formulario hijo
             }
            c.Show();
            c.BringToFront();
        }
    }
}
