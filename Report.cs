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
using K4os.Compression.LZ4.Encoders;

namespace Car_Wash_Management
{
    public partial class Report : Form
    {
        private SqlConnection Conn;
        private SqlCommand Cm;
        private SqlDataReader dr;
        private string title = "Car Wash Management";

        public Report()
        {
            InitializeComponent();
            // Use SqlConnectionStringBuilder to create the connection string
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = "KAMAL\\MSSQLSERVER01", // Replace with your server name or IP address
                InitialCatalog = "car wash",
                IntegratedSecurity = true
            };
            Conn = new SqlConnection(builder.ConnectionString);
            loadRevenus();
            loadCostofGood();
            loadGP();

        }
        

        #region Revenus
        private void dtFromRevenus_ValueChanged(object sender, EventArgs e)
        {
            loadRevenus();
        }

        private void dtToRevenus_ValueChanged(object sender, EventArgs e)
        {
            loadRevenus();
        }
        public void loadRevenus()
        {
            try
            {
                int i = 0;
                double total = 0;
                dgvRevenus.Rows.Clear();
                Cm = new SqlCommand("SELECT date,ISNULL(SUM(PRICE),0) AS total FROM tbCash WHERE date BETWEEN '" + dtFromRevenus.Value.ToString() + "'" +
                    "AND '" + dtToRevenus.Value.ToString() + "' AND status LIKE 'Sold' GROUP BY date", Conn);
                Conn.Open();
                dr = Cm.ExecuteReader();
                if (!dr.HasRows)
                {
                    MessageBox.Show("No results found for the given date range and status.");
                }
                while (dr.Read())
                {
                    i++;
                    dgvRevenus.Rows.Add(i,DateTime.Parse( dr[0].ToString()).ToShortDateString(), dr[1].ToString());
                    total += double.Parse(dr[1].ToString());
                }
                lblRevenus.Text = total.ToString("#,##0.00");
                dr.Close();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
        }

        #endregion Revenus

        #region CoG
        private void dtFromCostofGood_ValueChanged(object sender, EventArgs e)
        {
            loadCostofGood();
        }

        private void dtToCostofGood_ValueChanged(object sender, EventArgs e)
        {
            loadCostofGood();
        }
        public void loadCostofGood()
        {
            try
            {
                int i = 0;
                double total = 0;
                dgvCostofGood.Rows.Clear();

                string query = "SELECT costname, cost, date FROM tbCostofGoodSold WHERE date BETWEEN @dtFrom AND @dtTo";
                Cm = new SqlCommand(query, Conn);
                Cm.Parameters.AddWithValue("@dtFrom", dtFromCostofGood.Value.ToString());
                Cm.Parameters.AddWithValue("@dtTo", dtToCostofGood.Value.ToString());

                Conn.Open();
                dr = Cm.ExecuteReader();
                if (!dr.HasRows)
                {
                    MessageBox.Show("No results found for the given date range and status.");
                }
                while (dr.Read())
                {
                    i++;
                    dgvCostofGood.Rows.Add(i, dr["costname"].ToString(), dr["cost"].ToString(), DateTime.Parse(dr["date"].ToString()).ToShortDateString());
                    total += double.Parse(dr["cost"].ToString());
                }
                lblCoG.Text = total.ToString("#,##0.00");
                dr.Close();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
        }

        #endregion CoG


        #region GP

        private void dtFormGP_ValueChanged(object sender, EventArgs e)
        {
            loadGP();
        }

        private void dtToGP_ValueChanged(object sender, EventArgs e)
        {
            loadGP();
        }
        public void loadGP()
        {
            try
            {
                string fromDate = dtFormGP.Value.ToString();
                string toDate = dtToGP.Value.ToString();

                string revenueQuery = "SELECT ISNULL(SUM(price), 0) AS total FROM tbCash WHERE date BETWEEN @dtFrom AND @dtTo";
                txtRevenus.Text = extractData(revenueQuery, fromDate, toDate).ToString("#,##0.00");

                string cogsQuery = "SELECT ISNULL(SUM(cost), 0) AS Cost FROM tbCostofGoodSold WHERE date BETWEEN @dtFrom AND @dtTo";
                txtCOGS.Text = extractData(cogsQuery, fromDate, toDate).ToString("#,##0.00");

                txtGP.Text = (double.Parse(txtRevenus.Text) - double.Parse(txtCOGS.Text)).ToString("#,##0.00");
                if(double.Parse(txtGP.Text)<0)
                {
                    txtGP.ForeColor = Color.Red;
                }
                else
                {
                    txtGP.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // now to create a function to extract data from database
        public double extractData(string sql, string fromDate, string toDate)
        {
            double data = 0;
            try
            {
                Conn.Open();
                Cm = new SqlCommand(sql, Conn);
                Cm.Parameters.AddWithValue("@dtFrom", fromDate);
                Cm.Parameters.AddWithValue("@dtTo", toDate);
                object result = Cm.ExecuteScalar();

                if (result != null)
                {
                    data = Convert.ToDouble(result);
                }
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return data;
        }



        #endregion GP
    }


}


