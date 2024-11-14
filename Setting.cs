using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Car_Wash_Management
{
    public partial class Setting : Form
    {
        private SqlConnection Conn;
        SqlDataReader dr;
        private SqlCommand Cm;
        string title = "Car Wash Management";
        bool hasdetail = false;
        private string oldCompanyName;

        public Setting()
        {
            InitializeComponent();
            // Use SqlConnectionStringBuilder to create the connection string
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = "KAMAL\\MSSQLSERVER01",
                InitialCatalog = "car wash",
                IntegratedSecurity = true
            };
            Conn = new SqlConnection(builder.ConnectionString);
            loadCostofGoodSold();
            loadcompany();
        }

    
      

        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        #region CostofGoodSold
        private void btnAddCog_Click(object sender, EventArgs e)
        {
            ManageofGoodSold module = new ManageofGoodSold(this);
            module.btnUPDATE.Enabled = false;
            module.Show();
        }

        private void txtSearchCG_TextChanged(object sender, EventArgs e)
        {
            loadCostofGoodSold();
        }

        private void dgvCostofGoodSold_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           string colName = dgvCostofGoodSold.Columns[e.ColumnIndex].Name;
            if (colName == "EditCog")
            {
                ManageofGoodSold module = new ManageofGoodSold(this);
                if (dgvCostofGoodSold.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    module.lblCid.Text = dgvCostofGoodSold.Rows[e.RowIndex].Cells[1].Value.ToString();
                }

                if (dgvCostofGoodSold.Rows[e.RowIndex].Cells[2].Value != null)
                {
                    module.txtCostName.Text = dgvCostofGoodSold.Rows[e.RowIndex].Cells[2].Value.ToString();
                }

                if (dgvCostofGoodSold.Rows[e.RowIndex].Cells[3].Value != null)
                {
                    module.txtCost.Text = dgvCostofGoodSold.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
                // Parse the DateTime value safely
                if (DateTime.TryParse(dgvCostofGoodSold.Rows[e.RowIndex].Cells[4].Value.ToString(), out DateTime Date))
                {
                    module.dtDate.Value = Date;
                }
                else
                {
                    MessageBox.Show("The date value is not valid.");
                }

                module.btnSAVE.Enabled = false;
                module.ShowDialog();
            }
            else if (colName == "DeleteCog")
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Cm = new SqlCommand("DELETE FROM tbCostofGoodSold WHERE id = @id", Conn);
                        Cm.Parameters.AddWithValue("@id", dgvCostofGoodSold.Rows[e.RowIndex].Cells[1].Value.ToString());
                        Conn.Open();
                        Cm.ExecuteNonQuery();
                        Conn.Close();
                        MessageBox.Show("Cost of good sold data has been successfully removed!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadCostofGoodSold();
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
            loadCostofGoodSold();//to reload the cost of good sold list after update the record 

        }
        public void loadCostofGoodSold()
        {
            try
            {
                int i = 0; // To show the number for the vehicle list
                dgvCostofGoodSold.Rows.Clear();
                string query = "SELECT id, costname, cost,date FROM tbCostofGoodSold WHERE CONCAT(costname,cost,date) LIKE '%' + @search + '%'";
                Cm = new SqlCommand(query, Conn);
                Cm.Parameters.AddWithValue("@search", txtSearchCG.Text);
                Conn.Open();
                dr = Cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    // Ensure the indices match the columns in your query
                    dgvCostofGoodSold.Rows.Add(i, dr["id"].ToString(), dr["CostName"].ToString(), dr["Cost"].ToString(), dr["Date"].ToString());
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
        #endregion CostofGoodSold
        #region Company
        //  first we need yo load the data from the database
        public void loadcompany()
        {
            try
            {
                Conn.Open();
                Cm = new SqlCommand("SELECT * FROM tbCompany", Conn);
                dr = Cm.ExecuteReader();
                if (dr.Read())
                {
                    if (dr.HasRows)
                    {
                        hasdetail = true;
                        oldCompanyName = dr["name"].ToString(); // Store the old company name
                        txtCompanyName.Text = oldCompanyName;
                        txtComaddress.Text = dr["address"].ToString();
                    }
                    else
                    {
                        txtCompanyName.Clear();
                        txtComaddress.Clear();
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            
                try
                {
                   if (MessageBox.Show("Save company detail?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string query;
                        Dictionary<string, object> parameters = new Dictionary<string, object>
              {
                {"@name", txtCompanyName.Text},
                {"@address", txtComaddress.Text}
               };

                        if (hasdetail)
                        {
                            query = "UPDATE tbCompany SET name = @name, address = @address WHERE name = @oldName";
                            parameters.Add("@oldName", oldCompanyName); // Use the stored old company name
                        }
                        else
                        {
                            query = "INSERT INTO tbCompany (name, address) VALUES (@name, @address)";
                        }

                        ExecuteQuery(query, parameters);
                        MessageBox.Show("Company details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            txtCompanyName.Clear();
            txtComaddress.Clear();
        }
        private void ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            try
            {
                Conn.Open();
                SqlCommand cmd = new SqlCommand(query, Conn);
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }
                cmd.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
        }

        #endregion Company
    }
}
