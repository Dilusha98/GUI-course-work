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
    public partial class cooacc : MetroFramework.Forms.MetroForm
    {
        public cooacc()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            coologin obj = new coologin();
            obj.ShowDialog();
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            try
            {


                SqlConnection con = new SqlConnection("Data Source=dilusha;Initial Catalog=KARL111;Integrated Security=True");
                string sql = "select present_employee from production where unit ='" + coounit.SelectedItem + "'and date='" + this.coodate.Value.ToString("yyyyMMdd") + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    int present_employee = Convert.ToInt32(rdr.GetValue(0));
                    float total = (present_employee * 100) + (present_employee * 150) + (present_employee * 50 * 2);
                    coomeal.Text = total.ToString() + " /= ";
                    txt32.Text = total.ToString();
                }
            }
            catch (SqlException ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }

            try
            {


                SqlConnection con = new SqlConnection("Data Source=dilusha;Initial Catalog=KARL111;Integrated Security=True");
                string sql = "select total_production_count from production where unit ='" + coounit.SelectedItem + "'and date='" + this.coodate.Value.ToString("yyyyMMdd") + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    double production_count = Convert.ToInt32(rdr.GetValue(0));
                    double production_efficiency;






                    if (coounit.Text == "Print unit")
                    {
                        production_efficiency = Convert.ToDouble((production_count * 100) / 2000);
                        this.cooefficiency.Text = production_efficiency.ToString() + " % ";
                        txt33.Text = production_efficiency.ToString();

                    }
                    else if (coounit.Text == "Handle unit")
                    {
                        production_efficiency = Convert.ToDouble((production_count * 100) / 2000);
                        this.cooefficiency.Text = production_efficiency.ToString() + " % ";
                        txt33.Text = production_efficiency.ToString();
                    }
                    else if (coounit.Text == "Cutting unit")
                    {
                        production_efficiency = Convert.ToDouble((production_count * 100) / 3000);
                        this.cooefficiency.Text = production_efficiency.ToString() + " % ";
                        txt33.Text = production_efficiency.ToString();
                    }
                    else if (coounit.Text == "Bordering unit")
                    {
                        production_efficiency = Convert.ToDouble((production_count * 100) / 1500);
                        this.cooefficiency.Text = production_efficiency.ToString() + " % ";
                        txt33.Text = production_efficiency.ToString();
                    }
                    else if (coounit.Text == "tailoring unit")
                    {
                        production_efficiency = Convert.ToDouble((production_count * 100) / 1500);
                        this.cooefficiency.Text = production_efficiency.ToString() + " % ";
                        txt33.Text = production_efficiency.ToString();
                    }
                    else if (coounit.Text == "Complete unit")
                    {
                        production_efficiency = Convert.ToDouble((production_count * 100) / 1500);
                        this.cooefficiency.Text = production_efficiency.ToString() + " % ";
                        txt33.Text = production_efficiency.ToString();
                    }
                    else
                    {
                        production_efficiency = Convert.ToDouble((production_count * 100) / 2000);
                        this.cooefficiency.Text = production_efficiency.ToString() + " % ";
                        txt33.Text = production_efficiency.ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
            try
            {
                SqlConnection con = new SqlConnection("Data Source=dilusha;Initial Catalog=KARL111;Integrated Security=True");
                string sql = "select total_production_count,damage_count from production where unit ='" + coounit.SelectedItem + "'and date='" + this.coodate.Value.ToString("yyyyMMdd") + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    double total_production_cont = Convert.ToInt32(rdr.GetValue(0));
                    double damage_count = Convert.ToInt32(rdr.GetValue(1));
                    double damage_precentage;
                    damage_precentage = Convert.ToDouble(damage_count * 100) / total_production_cont;
                    this.coodamage.Text = damage_precentage.ToString() + " % ";
                    txt_34.Text = damage_precentage.ToString();
                           
                }
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
            double pe = double.Parse(txt33.Text);
            double dp = double.Parse(txt_34.Text);

            try
            {



                if (pe >= 85 && dp <= 20)
                {
                    lbl_final_analystic_.Text = "Great";
                    txt35.Text = "Great";



                }
                else if (pe >= 75 && pe < 85 && dp < 30 && dp > 20)
                {
                    lbl_final_analystic_.Text = "Good";
                    txt35.Text = "Good";



                }
                else if (pe > 55 && pe < 75 && dp > 30 && dp < 35)
                {
                    lbl_final_analystic_.Text = "Poor";
                    txt35.Text = "Poor";
                }
                else
                {
                    lbl_final_analystic_.Text = "Very Poor";
                    txt35.Text = "Very Poor";



                    MessageBox.Show("අඩෝ වයි බං මදිනෙ", "!!!WARNING!!!");



                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void cooacc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kARL111DataSet1.production' table. You can move, or remove it, as needed.
            this.productionTableAdapter.Fill(this.kARL111DataSet1.production);

        }

        private void btnfinal_Click(object sender, EventArgs e)
        {

        }
    }
}
