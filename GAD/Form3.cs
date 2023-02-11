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
using System.Data.SqlClient;

namespace GAD
{
    public partial class Splogin : MetroFramework.Forms.MetroForm
    {
        public Splogin()
        {
            InitializeComponent();
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.ShowDialog();
        }

        private void btnsplg_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=dilusha;Initial Catalog=KARL111;Integrated Security=True");
                String Query = "select password from supervisoracc where epm_id ='" + spuserid.Text + "' ";
                SqlCommand cmd = new SqlCommand(Query, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    string password = rdr.GetString(0);

                    if (password == sppw.Text)
                    {
                        this.Hide();
                        supervisoracc obj = new supervisoracc();
                        obj.ShowDialog();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Check password again");
                        spuserid.Clear();
                        sppw.Clear();
                        spuserid.Focus();
                    }
                }
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
