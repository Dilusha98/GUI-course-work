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
    public partial class coologin : MetroFramework.Forms.MetroForm
    {
        public coologin()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.ShowDialog();
        }

        private void btncoolg_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=dilusha;Initial Catalog=KARL111;Integrated Security=True");
                String Query = "select password from cooacc where emp_id ='" + coouserid.Text + "' ";
                SqlCommand cmd = new SqlCommand(Query, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    string password1 = rdr.GetString(0);

                    if (password1 == coopw.Text)
                    {
                        this.Hide();
                        cooacc obj = new cooacc();
                        obj.ShowDialog();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Check password again");
                        coouserid.Clear();
                        coopw.Clear();
                        coouserid.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }

        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
