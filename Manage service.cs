using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Data.SqlClient;

namespace Car_Wash_Management
{
    public partial class Manage_service : Form
    {
        private SqlConnection Conn;
        bool check = false;
        Services service;
        public Manage_service(Services ser)
        {
            InitializeComponent();
            service = ser;
            // Use SqlConnectionStringBuilder to create the connection string
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = "KAMAL\\MSSQLSERVER01", // Replace with your server name or IP address
                InitialCatalog = "car wash",
                IntegratedSecurity = true
            };
            Conn = new SqlConnection(builder.ConnectionString);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow digit number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            //only allow one digit
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        #region method 
        public void Clear()
        {
            txtServiceName.Clear(); // Assuming you have a TextBox for cost name
            txtPrice.Clear(); // Assuming you have a TextBox for cost 
            btnSAVE.Enabled = true;
            btnUPDATE.Enabled = false;
        }
        public void checkField()
        {
            if (txtServiceName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Required data Field!", "Warning");
                return; // To return to the data field and form
            }
            check = true;
        }
        #endregion method

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                checkField();
                if (check)
                {
                    if (MessageBox.Show("Are you sure you want to register this service?", "Service Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Conn.Open();
                        string query = "INSERT INTO tbService (servicename, price) VALUES (@servicename, @price)";
                        SqlCommand cmd = new SqlCommand(query, Conn);
                        cmd.Parameters.AddWithValue("@servicename", txtServiceName.Text);

                        // Ensure price is numeric
                        if (decimal.TryParse(txtPrice.Text, out decimal price))
                        {
                            cmd.Parameters.AddWithValue("@price", price);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid numeric value for Cost.");
                            return;
                        }

                        cmd.ExecuteNonQuery();
                        Conn.Close();
                        MessageBox.Show("Service has been successfully registered!");
                        Clear();
                        this.Dispose();
                        // Reload the service list after the update (uncomment if needed)
                        service.loadService();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                checkField();
                if (check)
                {
                    if (MessageBox.Show("Are you sure you want to edit this record?", "Service Editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Conn.Open();
                        string query = "UPDATE tbService SET servicename=@servicename, price=@price WHERE id=@id";
                        SqlCommand cmd = new SqlCommand(query, Conn);
                        cmd.Parameters.AddWithValue("@id", lblSid.Text); // Ensure lblEld contains the ID
                        cmd.Parameters.AddWithValue("@servicename", txtServiceName.Text);
                        cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                        cmd.ExecuteNonQuery();
                        Conn.Close();
                        MessageBox.Show("Employer has been successfully updated!");
                        Clear();
                        this.Dispose();
                        service.loadService();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Conn.State == System.Data.ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
        }



        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            Clear();
            btnUPDATE.Enabled = false;
            btnSAVE.Enabled = true;
        }
    }
}
