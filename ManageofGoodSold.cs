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

namespace Car_Wash_Management
{
    public partial class ManageofGoodSold : Form
    {
        private SqlConnection Conn;
        Setting setting;
        bool check = false;
        public ManageofGoodSold(Setting sett)
        {
            InitializeComponent();
            setting = sett;
            // Use SqlConnectionStringBuilder to create the connection string
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


                    if (MessageBox.Show("Are you sure you want to register this Cost of Good Sold type?", "Cost of Good Sold Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                    {
                        Conn.Open();
                        string query = "INSERT INTO tbCostofGoodSold (CostName, Cost,Date) VALUES (@Name, @Cost, @Date)";
                        SqlCommand cmd = new SqlCommand(query, Conn);
                        cmd.Parameters.AddWithValue("@Name", txtCostName.Text);
                        // Ensure Salary is numeric
                        if (decimal.TryParse(txtCost.Text, out decimal salary))
                        {
                            cmd.Parameters.AddWithValue("@Cost", salary);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid numeric value for Cost.");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@Date", dtDate.Value);
                        cmd.ExecuteNonQuery();
                        Conn.Close();
                        MessageBox.Show("Cost of Good SOld has been successfully registeresd!");
                        Clear();
                        this.Dispose();
                        setting.loadCostofGoodSold();//to reload the vehicle list after update the record
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

                    if (MessageBox.Show("Are you sure you want to edit this  cost of gold sold?", "Cost of Good Sold Editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Conn.Open();
                        string query = "UPDATE tbCostofGoodSold SET CostName = @CostName, Cost = @Cost,Date=@Date WHERE id=@id";
                        SqlCommand cmd = new SqlCommand(query, Conn);
                        cmd.Parameters.AddWithValue("@Id", lblCid.Text);
                        cmd.Parameters.AddWithValue("@CostName", txtCostName.Text);
                        // Ensure Salary is numeric
                        if (decimal.TryParse(txtCost.Text, out decimal salary))
                        {
                            cmd.Parameters.AddWithValue("@Cost", salary);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid numeric value for Cost.");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@date", dtDate.Value);
                        cmd.ExecuteNonQuery();
                        Conn.Close();
                        MessageBox.Show("Cost of Good Sold has been successfully Edited!");
                        Clear();
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
        #region method  
        public void Clear()
        {
            txtCostName.Clear(); // Assuming you have a TextBox for cost name
            txtCost.Clear(); // Assuming you have a TextBox for cost
            dtDate.Value = DateTime.Now; // Assuming you have a DateTimePicker for date
             btnSAVE.Enabled = true;
            btnUPDATE.Enabled = false;
        }
        public void checkField()
        {
            if (txtCostName.Text == "" || txtCost.Text == "" )
            {
                MessageBox.Show("Required data Field!", "Warning");
                return; // To return to the data field and form
            }
            check = true;
        }
            #endregion method

            private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
