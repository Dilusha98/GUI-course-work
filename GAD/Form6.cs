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
    public partial class supervisoracc : MetroFramework.Forms.MetroForm
    {
        public supervisoracc()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Splogin obj = new Splogin();
            obj.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=dilusha;Initial Catalog=KARL111;Integrated Security=True");
                string sql = "delete from production where unit ='" + cmbdlunit.Text + "'and date='" + this.dltdate.Value.ToString("yyyyMMdd") + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MetroMessageBox.Show(this, "Data deleted");
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }

        }

        private void btnsvunit_Click(object sender, EventArgs e)
        {
            if (cmbunit.Text == "" || date.Text == "" || unitempid.Text == "" || prsntemp.Text == "" || absenceemp.Text == "" || totalpro.Text == "" || damage.Text == "")
            {
                MetroMessageBox.Show(this, "Missing informations");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=dilusha;Initial Catalog=KARL111;Integrated Security=True");
                    string sql = "insert into production values('" + date.Value.ToString("yyyyMMdd") + "','" + unitempid.Text + "','" + cmbunit.Text + "','" + prsntemp.Text + "','" + absenceemp.Text + "','" + totalpro.Text + "','" + damage.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MetroMessageBox.Show(this, "Data inserted");
                    unitempid.Clear();
                    prsntemp.Clear();
                    absenceemp.Clear();
                    totalpro.Clear();
                    damage.Clear();
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message);
                }
            }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=dilusha;Initial Catalog=KARL111;Integrated Security=True");
            string sql = "select*from production";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable tb = new DataTable();

            adp.Fill(tb);
            con.Close();
            metroGrid1.DataSource = tb;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (cmbunit.Text == "" || date.Text == "" || unitempid.Text == "" || prsntemp.Text == "" || absenceemp.Text == "" || totalpro.Text == "" || damage.Text == "")
            {
                MetroMessageBox.Show(this, "Missing informations");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=dilusha;Initial Catalog=KARL111;Integrated Security=True");
                    string sql = "update production set supervisor_id='" + unitempid.Text + "',present_employee=" + prsntemp.Text + ",absence_employee=" + absenceemp.Text + ",total_production_count=" + totalpro.Text + ",damage_count=" + damage.Text + "where unit ='" + cmbunit.SelectedItem + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MetroMessageBox.Show(this, "update successful");
                    unitempid.Clear();
                    prsntemp.Clear();
                    absenceemp.Clear();
                    totalpro.Clear();
                    damage.Clear();
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message);
                }
            }
        }

        private void supervisoracc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kARL111DataSet.production' table. You can move, or remove it, as needed.
            this.productionTableAdapter.Fill(this.kARL111DataSet.production);

        }
    }
}
