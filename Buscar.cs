using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace splash
{
    public partial class Buscar : Form
    {
        string miTabla, miCampoOrdenar, miCampoRegresar,valorRegresar;
        public Buscar()
        {
            InitializeComponent();
        }
        public string Dato(string tabla, string campoOrdenar, string campoRegresar)
        {
            miTabla = tabla;
            miCampoOrdenar = campoOrdenar;
            miCampoRegresar = campoRegresar;

            Consulta();
            this.ShowDialog();
            return valorRegresar;
        }
        private void Consulta()
        {
            string consulta = "select * from " + miTabla + " where " + miCampoOrdenar + " like '%" + textBox1.Text + "%' order by " + miCampoOrdenar;
            dataGridView1.DataSource = Datos.misDatos(consulta);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Consulta();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            valorRegresar = dataGridView1.CurrentRow.Cells[miCampoRegresar].Value.ToString().Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
