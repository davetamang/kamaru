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
using System.Management;


namespace Car_Wash_Management
{
    public partial class CashService : Form
    {
        private SqlConnection Conn;
        private SqlCommand Cm;
        SqlDataReader dr;
        string title = "Car Wash Management";
        Cash_Form cash;
        public CashService(Cash_Form cashhform)
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
            loadService();
        }
        #region method
        public void loadService()
        {
            try
            {
                int i = 0; // To show the number for the service list
                dgvServices.Rows.Clear();
                string query = "SELECT id, servicename, price FROM tbService WHERE CONCAT(id, servicename, price) LIKE '%' + @search + '%'";
                Cm = new SqlCommand(query, Conn);
                Cm.Parameters.AddWithValue("@search", txtSearch.Text);
                Conn.Open();
                dr = Cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvServices.Rows.Add(i, dr["id"].ToString(), dr["servicename"].ToString(), dr["price"].ToString());
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
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvServices.Rows)
            {
                bool chkbox = Convert.ToBoolean(dr.Cells["Select"].Value);
                if (chkbox)
                {
                    try
                    {
                        if (Conn.State == ConnectionState.Open)
                        {
                            Conn.Close();
                        }

                        Cm = new SqlCommand("IF NOT EXISTS (SELECT * FROM tbCash WHERE sid = @sid AND transno = @transno) " +
                                            "INSERT INTO tbCash (transno, cid, sid, price, date) VALUES (@transno, @cid, @sid, @price, @date)", Conn);

                        Cm.Parameters.AddWithValue("@transno", cash.lblTransno.Text);
                        Cm.Parameters.AddWithValue("@cid", cash.customerId);
                        Cm.Parameters.AddWithValue("@sid", dr.Cells[1].Value.ToString());
                        Cm.Parameters.AddWithValue("@price", Convert.ToDecimal(dr.Cells[3].Value));
                        Cm.Parameters.AddWithValue("@date", DateTime.Now);

                        Conn.Open();
                        Cm.ExecuteNonQuery();
                        Conn.Close();

                        cash.btnCash.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, title);
                        if (Conn.State == ConnectionState.Open)
                        {
                            Conn.Close();
                        }
                    }
                }
            }
            this.Dispose();
            cash.panelCash.Height = 1;
            cash.loadcash();
        }




        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadService();
        }

        private void dgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
