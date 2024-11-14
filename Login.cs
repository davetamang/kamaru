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
    public partial class Login : Form
    {
        private SqlConnection Conn;
        private SqlCommand Cm;
        SqlDataReader dr;
        string title = "Car Wash Management";
        public Login()
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
            loadCompany();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void loadCompany()
        {
            Cm = new SqlCommand("SELECT * FROM tbCompany", Conn);
            Conn.Open();
            dr = Cm.ExecuteReader();
            dr.Read();
            if(dr.HasRows)
            {
                lblCompany.Text = dr["name"].ToString();
                lblAddress.Text = dr["address"].ToString();
            }
            dr.Close();
            Conn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPassword.Clear();
            txtName.Focus();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            try
            {
                Cm = new SqlCommand("SELECT Name FROM tbEmployer WHERE Name='" + txtName.Text + "' AND Password = '" + txtPassword.Text + "'", Conn);
                Conn.Open();
                dr = Cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show(" WELCOME " +  dr[0].ToString()  +  "|" , "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Mainform main = new Mainform();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("INVALID username or password" , "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                dr.Close();
                Conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }

    }
}
