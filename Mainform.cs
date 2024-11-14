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

namespace Car_Wash_Management
{
    public partial class Mainform : Form
    {

        private SqlConnection Conn;
        SqlDataReader dr;
        private SqlCommand Cm;
        string title = "Car Wash Management";
        public Mainform()
        {
            InitializeComponent();
            // Use SqlConnectionStringBuilder to create  the connection string
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = "KAMAL\\MSSQLSERVER01", // Replace with your server name or IP address
                InitialCatalog = "car wash",
                IntegratedSecurity = true
            };
            Conn = new SqlConnection(builder.ConnectionString);
            loadGP();
            openchildform(new DashBoard());
        }

        private void btnEmployer_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnEmployer.Height;
            panelSlide.Top = btnEmployer.Top;

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnDashboard.Height;
            panelSlide.Top = btnDashboard.Top;
            openchildform(new DashBoard());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnCustomer.Height;
            panelSlide.Top = btnCustomer.Top;
            openchildform(new Customer());
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnServices.Height;
            panelSlide.Top = btnServices.Top;
            openchildform(new Services());
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnCash.Height;
            panelSlide.Top = btnCash.Top;
            openchildform(new Cash_Form(this));
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnSetting.Height;
            panelSlide.Top = btnSetting.Top;
            openchildform(new Setting());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnReport.Height;
            panelSlide.Top = btnReport.Top;
            openchildform(new Report());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnLogout.Height;
            panelSlide.Top = btnLogout.Top;
            Application.Exit();
        }

        private void btnEmployer_Click_1(object sender, EventArgs e)
        {
            panelSlide.Height = btnEmployer.Height;
            panelSlide.Top = btnEmployer.Top;
            openchildform(new Employer());

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        #region method
        // create a function any form to the panelchild on the mainform
        private Form activeform = null;
        public void openchildform(Form childform)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel5.Controls.Add(childform);
            panel5.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        // to extract data for dashboard
        public double extractData(string sql, string date)
        {
            double data = 0;
            try
            {
                Conn.Open();
                Cm = new SqlCommand(sql, Conn);
                Cm.Parameters.AddWithValue("@date", date);
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
        public void loadGP()
        {
            try
            {
                Report module = new Report();
                string fromDate = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");
                string toDate = DateTime.Now.ToString("yyyy-MM-dd");

                string revenueQuery = "SELECT ISNULL(SUM(price), 0) AS total FROM tbCash WHERE date BETWEEN @dtFrom AND @dtTo";
                lblRevenus.Text = module.extractData(revenueQuery, fromDate, toDate).ToString("#,##0.00");

                string costQuery = "SELECT ISNULL(SUM(cost), 0) AS Cost FROM tbCostofGoodSold WHERE date BETWEEN @dtFrom AND @dtTo";
                lblCostofGood.Text = module.extractData(costQuery, fromDate, toDate).ToString("#,##0.00");

                lblGrossProfit.Text = (double.Parse(lblRevenus.Text) - double.Parse(lblCostofGood.Text)).ToString("#,##0.00");

                // Get data for the previous 7 days
                string previousFromDate = DateTime.Now.AddDays(-14).ToString("yyyy-MM-dd");
                string previousToDate = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");

                double revLast7 = module.extractData("SELECT ISNULL(SUM(price), 0) AS total FROM tbCash WHERE date BETWEEN @dtFrom AND @dtTo", previousFromDate, previousToDate);
                double cogLast7 = module.extractData("SELECT ISNULL(SUM(cost), 0) AS Cost FROM tbCostofGoodSold WHERE date BETWEEN @dtFrom AND @dtTo", previousFromDate, previousToDate);
                double gpLast7 = revLast7 - cogLast7;

                // Set arrows and color for Revenue
                if (revLast7 > double.Parse(lblRevenus.Text))
                {
                    picRevenus.Image = Properties.Resources.down_25px;
                }
                else
                {
                    picRevenus.Image = Properties.Resources.up_25px;
                }

                // Set arrows and color for Gross Profit
                if (gpLast7 > double.Parse(lblGrossProfit.Text))
                {
                    picGP.Image = Properties.Resources.down_25px;
                    lblGrossProfit.ForeColor = Color.Red;
                }
                else
                {
                    picGP.Image = Properties.Resources.up_25px;
                    lblGrossProfit.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #endregion method


    }
}
