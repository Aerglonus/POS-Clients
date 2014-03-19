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
    public partial class fClientes : Form
    {
        public fClientes()
        {
            InitializeComponent();
        }

        private void fClientes_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        private void cargarDatos()
        {
            DataTable t = Datos.misDatos("Select * from Cleintes");
            dataGridView1.DataSource = t;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Datos.misDatos("select id,nombre,rfc,domicilio from clientes");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Datos.misDatos("select rfc,nombre,domicilio,localidad from clientes");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Datos.misDatos("select * from articulos");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
