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
using System.Transactions;
using System.Collections;


namespace Car_Wash_Management
{
    public partial class Cash_Form : Form
    {
        private SqlConnection Conn;
        private SqlCommand Cm;
        SqlDataReader dr;
        string title = "Car Wash Management";
        public int customerId = 0;
        Mainform main;
        public Cash_Form(Mainform mainform)
        {
            InitializeComponent();
            main = mainform;
            // Use SqlConnectionStringBuilder to create  the connection string
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = "KAMAL\\MSSQLSERVER01", // Replace with your server name or IP address
                InitialCatalog = "car wash",
                IntegratedSecurity = true
            };
            Conn = new SqlConnection(builder.ConnectionString);
            getTransno();
            loadcash();
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            openchildform(new CashCustomer(this));
            btnAddServices.Enabled = true;
        }

        private void btnAddServices_Click(object sender, EventArgs e)
        {
            openchildform(new CashService(this));
            btnAddServices.Enabled = false;
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            SettlePayment module = new SettlePayment(this);
            module.txtSale.Text = lblTotal.Text;
            module.ShowDialog();
            Mainform main = new Mainform();
            main.loadGP();
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
            panelCash.Height = 200;
            panelCash.Controls.Add(childform);
            panelCash.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        // Create a function a transatoin generator depend on date
        public void getTransno()
        {
            try { string sdate = DateTime.Now.ToString("yyyyMMdd");
                int count; 
                string transno; 
                Conn.Open(); 
                Cm = new SqlCommand("SELECT TOP 1 transno FROM tbCash WHERE transno LIKE '" + sdate + "%' ORDER BY id DESC", Conn);
                dr = Cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                { 
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lblTransno.Text = sdate + (count + 1);
                }
                else
                {
                    transno = sdate + "1001"; lblTransno.Text = transno;
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
        public void loadcash()
        {
            try
            {
                int i = 0; // To show the number for the cash list
                double total = 0; // To store the total price
                dgvCash.Rows.Clear();
                string query = "SELECT ca.id, ca.transno, cu.fullname, cu.carno, cu.carmodel, s.servicename, ca.price, ca.date " +
                               "FROM tbCash AS Ca " +
                               "LEFT JOIN tbCustomer AS Cu ON Ca.cid = Cu.id " +
                               "LEFT JOIN tbService AS s ON Ca.sid = s.id " +
                               "WHERE Ca.status LIKE 'PENDING' AND Ca.transno='" + lblTransno.Text + "'";
                Cm = new SqlCommand(query, Conn); // Associate the command with the connection
                Conn.Open();
                dr = Cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    double price = Convert.ToDouble(dr["price"]); // Convert price to double
                    total += price; // Accumulate total price
                    dgvCash.Rows.Add(i, dr["id"].ToString(), dr["transno"].ToString(), dr["fullname"].ToString(),
                                     dr["carno"].ToString(), dr["carmodel"].ToString(), dr["servicename"].ToString(),
                                     price.ToString("F2"), dr["date"].ToString());
                }
                dr.Close();
                lblTotal.Text = total.ToString("F2"); // Display the total price in lblTotal
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

        private void dgvCash_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCash.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to cancel this service?", "Cancel Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Cm = new SqlCommand("DELETE FROM tbCash WHERE id = @id", Conn);
                        Cm.Parameters.AddWithValue("@id", dgvCash.Rows[e.RowIndex].Cells[1].Value.ToString());
                        Conn.Open();
                        Cm.ExecuteNonQuery();
                        Conn.Close();
                        MessageBox.Show("Services has been successfully removed!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadcash(); // Reload the updated list
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
    }
}
