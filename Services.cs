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
    public partial class Services : Form
    {
        private SqlConnection Conn;
        private SqlCommand Cm;
        SqlDataReader dr;
        string title = "Car Wash Management";
        public Services()
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
                Cm.Parameters.AddWithValue("@search", txtSearchSV.Text);
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

        private void txtSearchSV_TextChanged(object sender, EventArgs e)
        {
            loadService();
        }

        private void dgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvServices.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                if (dgvServices.Rows[e.RowIndex].Cells[1].Value != null && 
                    dgvServices.Rows[e.RowIndex].Cells[2].Value != null &&
                    dgvServices.Rows[e.RowIndex].Cells[3].Value != null)
                {
                    Manage_service module = new Manage_service(this);
                    module.lblSid.Text = dgvServices.Rows[e.RowIndex].Cells[1].Value.ToString(); // Assuming lblSid is a Label to show Service ID
                    module.txtServiceName.Text = dgvServices.Rows[e.RowIndex].Cells[2].Value.ToString();
                    module.txtPrice.Text = dgvServices.Rows[e.RowIndex].Cells[3].Value.ToString();
                    module.btnSAVE.Enabled = false;
                    module.ShowDialog();
                }
            }
            else if (colName == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Cm = new SqlCommand("DELETE FROM tbService WHERE id = @id", Conn);
                        Cm.Parameters.AddWithValue("@id", dgvServices.Rows[e.RowIndex].Cells[1].Value.ToString());
                        Conn.Open();
                        Cm.ExecuteNonQuery();
                        Conn.Close();
                        MessageBox.Show("Service data has been successfully removed!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadService(); // Reload the updated list
                    }
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
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Manage_service module = new Manage_service(this);
            module.btnUPDATE.Enabled = false;
            module.ShowDialog();
        }
    }
}
