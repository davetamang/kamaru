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
    public partial class Customer : Form
    {
        private SqlConnection Conn;
        private SqlCommand Cm;
        SqlDataReader dr;
        string title = "Car Wash Management";
        public Customer()
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
            loadCustomer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer_Registration module = new Customer_Registration(this);
            module.btnUPDATE.Enabled = false;
            module.ShowDialog();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCustomer.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                Customer_Registration module = new Customer_Registration(this);
                module.lblCid.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString(); // Assuming lblEld is a Label to show Employer ID
                module.txtFullName.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txtPhone.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txtCarNo.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                module.txtCarModel.Text = dgvCustomer.Rows[e.RowIndex].Cells[5].Value.ToString(); // Role
                module.txtAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells[6].Value.ToString();
                module.btnSAVE.Enabled = false;
                module.ShowDialog();
            }
            else if (colName == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Cm = new SqlCommand("DELETE FROM tbCustomer WHERE id = @id", Conn);
                        Cm.Parameters.AddWithValue("@id", dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString());
                        Conn.Open();
                        Cm.ExecuteNonQuery();
                        Conn.Close();
                        MessageBox.Show("Customer data has been successfully removed!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadCustomer(); // Reload the updated list
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadCustomer();
        }
        #region method
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
