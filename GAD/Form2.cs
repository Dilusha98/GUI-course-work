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
    public partial class Adminlogin : MetroFramework.Forms.MetroForm
    {
        public Adminlogin()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.ShowDialog();
        }

        private void btnadminlg_Click(object sender, EventArgs e)
        {
            if(adminuserid.Text == "user" && Adminpw.Text == "KARL1234")
            {
                this.Hide();
                Adminplatform obj = new Adminplatform();
                obj.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "Wrong User Name or Password");
                adminuserid.Clear();
                Adminpw.Clear();
                adminuserid.Focus();
            }
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
