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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }
        private void inicio_Load(object sender, EventArgs e)
        {
           

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);  // aumentara en 1

            if (progressBar1.Value == 100) // esto indica cuando el timer llega a 100 se para
            {
                this.timer1.Stop();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
         
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
