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
    public partial class CashCustomer : Form
    {
        private SqlConnection Conn;
        private SqlCommand Cm;
        SqlDataReader dr;
        string title = "Car Wash Management";
        Cash_Form cash;
        public CashCustomer(Cash_Form cashhform)
        {
            InitializeComponent();
            cash = cashhform;
            // Use SqlConnectionStringBuilder to create  the connection string
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = "KAMAL\\MSSQLSERVER01", // Replace with your server name or IP address
                InitialCatalog = "car wash",
                IntegratedSecurity = true
            };
            Conn = new SqlConnection(builder.ConnectionString);
            loadCustomer();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadCustomer();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCustomer.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                cash.customerId = int.Parse(dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            else return;
            this.Dispose();
            cash.panelCash.Height = 1;
        }
        #region method
        // create a function for load customer
        public void loadCustomer()
        {
            try
            {
                int i = 0; // To show the number for the customer list
                dgvCustomer.Rows.Clear();
                string query = "SELECT id, fullname,phone, carno, carmodel, address FROM tbCustomer  WHERE CONCAT(fullname, carno, address) LIKE '%' + @search + '%'";
                Cm = new SqlCommand(query, Conn);
                Cm.Parameters.AddWithValue("@search", txtSearch.Text);
                Conn.Open();
                dr = Cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvCustomer.Rows.Add(i, dr["id"].ToString(), dr["fullname"].ToString(), dr["phone"].ToString(), dr["carno"].ToString(), dr["carmodel"].ToString(), dr["address"].ToString());
                }
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
        #endregion method
    }
}
