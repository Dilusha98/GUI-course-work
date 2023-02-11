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
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            metroLink1.Focus();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminlogin obj = new Adminlogin();
            obj.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Splogin obj = new Splogin();
            obj.ShowDialog();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            coologin obj = new coologin();
            obj.ShowDialog();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
