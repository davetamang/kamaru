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
using MySqlX.XDevAPI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;
using System.Drawing.Drawing2D;

namespace Car_Wash_Management
{
    public partial class Customer_Registration : Form
    {
        private SqlConnection Conn;
        string title = "Car Wash Management";
        bool check = false;
        private SqlCommand Cm;
        Customer customer;
        public Customer_Registration(Customer cust)
        {
            InitializeComponent();
            customer = cust;
            // Use SqlConnectionStringBuilder to create  the connection string
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = "KAMAL\\MSSQLSERVER01", // Replace with your server name or IP address
                InitialCatalog = "car wash",
                IntegratedSecurity = true
            };
            Conn = new SqlConnection(builder.ConnectionString);
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                checkField();
                if (check)
                {
                    if (MessageBox.Show("Are you sure you want to register this customer?", "Customer Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Conn.Open();
                        string query = "INSERT INTO tbCustomer (fullname, phone, carno, carmodel, address) VALUES (@fullname, @phone, @carno, @carmodel, @address)";
                        SqlCommand cmd = new SqlCommand(query, Conn);
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@CarNo", txtCarNo.Text);
                        cmd.Parameters.AddWithValue("@CarModel", txtCarModel.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.ExecuteNonQuery(); 
                        Conn.Close(); 
                        MessageBox.Show("Customer has been successfully registered!");
                        check = false; 
                        Clear();
                        customer.loadCustomer();
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


        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                checkField();
                if (check)
                {
                    if (MessageBox.Show("Are you sure you want to edit this record?", "Customer Editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Conn.Open();
                        string query = "UPDATE tbCustomer SET fullname=@fullname, Phone=@Phone,carno=@carno,carmodel=@carmodel,address=@address WHERE id=@id";
                        SqlCommand cmd = new SqlCommand(query, Conn);
                        cmd.Parameters.AddWithValue("@id", lblCid.Text); // Ensure lblEld contains the ID
                        cmd.Parameters.AddWithValue("@fullname", txtFullName.Text);
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@carno", txtCarNo.Text);
                        cmd.Parameters.AddWithValue("@carmodel", txtCarModel.Text);
                        cmd.Parameters.AddWithValue("@address",txtAddress.Text);
                        cmd.ExecuteNonQuery();
                        Conn.Close();
                        MessageBox.Show("Employer has been successfully updated!");
                        Clear();
                        this.Dispose();
                        customer.loadCustomer();
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
        }

        private void Customer_Registration_Load(object sender, EventArgs e)
        {
           
        }
        #region method
       
        public void Clear()
        {
            txtAddress.Clear();
            txtCarModel.Clear();
            txtCarNo.Clear();
            txtFullName.Clear();
            txtPhone.Clear();
            btnSAVE.Enabled = true;
            btnUPDATE.Enabled = false;
        }
        // To check data fields
        public void checkField()
        {
            if (txtAddress.Text == "" || txtPhone.Text == "" || txtFullName.Text == "")
            {
                MessageBox.Show("Required data Field!", "Warning");
                check = false;
                return; // To return to the data field and form
            }
            check = true;
        }
            #endregion method

            private void button1_Click(object sender, EventArgs e)
            {
              this.Dispose();
             }
    }
}
