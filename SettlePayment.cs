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
    public partial class SettlePayment : Form
    {
        private SqlConnection Conn;
        private SqlCommand Cm;
        SqlDataReader dr;
        string title = "Car Wash Management";
        Cash_Form cash;
        public SettlePayment(Cash_Form cashhform)
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
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn00.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn0.Text;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnPoint.Text;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            { // Check for insufficient amount or empty cash input
             if (double.Parse(txtChange.Text) < 0 || string.IsNullOrEmpty(txtCash.Text)) 
                { 
                    MessageBox.Show("Insufficient amount, please enter the correct amount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                { 
                    for (int i = 0; i < cash.dgvCash.Rows.Count; i++)
                    { 
                        if (Conn.State == ConnectionState.Open)
                        {
                            Conn.Close();
                        } 
                        // Update tbCash
                        Conn.Open();
                         Cm = new SqlCommand("UPDATE tbCash SET status = 'Sold', price = @price WHERE id = @id", Conn);
                        Cm.Parameters.AddWithValue("@price", Convert.ToDouble(cash.dgvCash.Rows[i].Cells[7].Value)); 
                        Cm.Parameters.AddWithValue("@id", Convert.ToInt64(cash.dgvCash.Rows[i].Cells[1].Value));
                        Cm.ExecuteNonQuery();
                        Conn.Close(); 
                    } 
                    MessageBox.Show("Payment successfully saved!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    cash.loadcash();
                    this.Dispose();
                    cash.btnAddCustomer.Enabled = true; 
                    cash.btnAddServices.Enabled = false;
                    cash.getTransno();
                } 
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


                private void btn1_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn1.Text;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtCash.Clear();
            txtCash.Focus();
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double charge = double.Parse(txtCash.Text) - double.Parse(txtSale.Text);
                
                txtChange.Text = charge.ToString("#,##0.00");
            }
            catch(Exception)
            {
                txtChange.Text = "0.00";
            }
        }

        private void SettlePayment_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnEnter.PerformClick();// action click ente button
            }
            else if(e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
