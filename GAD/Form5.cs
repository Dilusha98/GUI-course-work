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
    public partial class Adminplatform : MetroFramework.Forms.MetroForm
    {
        public Adminplatform()
        {
            InitializeComponent();
        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnsavesp_Click(object sender, EventArgs e)
        {
            if (txtempidsp.Text == "" || txtnamesp.Text == "" || txtpwsp.Text == "" || txtcpwsp.Text == "")
            {
                MetroMessageBox.Show(this,"Missing informations");
            }
            else
            {
                if (txtcpwsp.Text == txtpwsp.Text)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection("Data Source=dilusha;Initial Catalog=KARL111;Integrated Security=True");
                        string query = "insert into supervisoracc (epm_id,emp_nam,password)values('" + txtempidsp.Text + "','" + txtnamesp.Text + "','" + txtpwsp.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MetroMessageBox.Show(this, "data inserted");
                        txtempidsp.Clear();
                        txtnamesp.Clear();
                        txtpwsp.Clear();
                        txtcpwsp.Clear();

                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, ex.Message);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Check Password again");
                }
            }
        }

        private void btnsavecoo_Click(object sender, EventArgs e)
        {
            {
                if (txtempidcoo.Text == "" || txtnamecoo.Text == "" || txtpwcoo.Text == "" || txtcpwcoo.Text == "")
                {
                    MetroMessageBox.Show(this, "Missing informations");
                }
                else
                {
                    if (txtcpwcoo.Text == txtpwcoo.Text)
                    {
                        try
                        {
                            SqlConnection con = new SqlConnection("Data Source=dilusha;Initial Catalog=KARL111;Integrated Security=True");
                            string query = "insert into cooacc(emp_id,emp_name,password)values('" + txtempidcoo.Text + "','" + txtnamecoo.Text + "','" + txtpwcoo.Text + "')";
                            SqlCommand cmd = new SqlCommand(query, con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MetroMessageBox.Show(this, "data inserted");
                            txtempidcoo.Clear();
                            txtnamecoo.Clear();
                            txtpwcoo.Clear();
                            txtcpwcoo.Clear();
                        }
                        catch (Exception ex)
                        {
                            MetroMessageBox.Show(this, ex.Message);
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Check Password again");
                    }
                }
            }
        }

        private void btndlsp_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=dilusha;Initial Catalog=KARL111;Integrated Security=True");
                string query = "delete from supervisoracc where epm_id = '" + txtdlsp.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MetroMessageBox.Show(this, "Deleted");
                txtdlsp.Clear();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btndlcoo_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=dilusha;Initial Catalog=KARL111;Integrated Security=True");
                string query = "delete from cooacc where emp_id = '" + txtdlsp.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MetroMessageBox.Show(this, "Deleted");
                txtdlcoo.Clear();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void adminaback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminlogin obj = new Adminlogin();
            obj.ShowDialog();
        }
    }
    
}
