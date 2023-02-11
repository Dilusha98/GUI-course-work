using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;


namespace GAD
{
    public partial class form0 : MetroFramework.Forms.MetroForm
    {
        public form0()
        {
            InitializeComponent();
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroProgressBar1.Increment(1);
            if (metroProgressBar1.Value == 75) 
            {
                timer1.Stop();
                Home frm = new Home();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void form8_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
