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
using Google.Protobuf.WellKnownTypes;

namespace Car_Wash_Management
{
    public partial class Employer : Form
    {
        private SqlConnection Conn;
        SqlDataReader dr;
        private SqlCommand Cm;
        string title = "Car Wash Management";
        public Employer()

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
            loadEmployer(); // to call this function, this form starting
            // Attach the event handler
            this.dgvEmployer.CellContentClick += new DataGridViewCellEventHandler(this.dgvEmployer_CellContentClick);


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employer_Registration module = new Employer_Registration(this);
            module.btnUPDATE.Enabled = false;//this is for save not update
            module.ShowDialog(); // Show the EmployerModule form as a dialog
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadEmployer();// Reload the employer list as the search text changes
        }

        private void dgvEmployer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvEmployer.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                Employer_Registration module = new Employer_Registration(this);
                module.lblEld.Text = dgvEmployer.Rows[e.RowIndex].Cells[1].Value.ToString(); // Assuming lblEld is a Label to show Employer ID
                module.txtName.Text = dgvEmployer.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txtPhone.Text = dgvEmployer.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.TxtAddress.Text = dgvEmployer.Rows[e.RowIndex].Cells[4].Value.ToString();

                // Parse the DateTime value safely
                if (DateTime.TryParse(dgvEmployer.Rows[e.RowIndex].Cells[5].Value.ToString(), out DateTime dob))
                {
                    module.dtDob.Value = dob;
                }
                else
                {
                    MessageBox.Show("The date value is not valid.");
                }

                module.cbRole.Text = dgvEmployer.Rows[e.RowIndex].Cells[6].Value.ToString(); // Role
                module.rdMale.Checked = dgvEmployer.Rows[e.RowIndex].Cells[6].Value.ToString() == "Male";
                module.rdFemale.Checked = dgvEmployer.Rows[e.RowIndex].Cells[6].Value.ToString() == "Female";
                module.txtSalary.Text = dgvEmployer.Rows[e.RowIndex].Cells[8].Value.ToString();
                module.txtPassword.Text = dgvEmployer.Rows[e.RowIndex].Cells[9].Value.ToString();
                module.btnSAVE.Enabled = false;
                module.ShowDialog();
            }
            else if (colName == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Cm = new SqlCommand("DELETE FROM tbEmployer WHERE id = @id", Conn);
                        Cm.Parameters.AddWithValue("@id", dgvEmployer.Rows[e.RowIndex].Cells[1].Value.ToString());
                        Conn.Open();
                        Cm.ExecuteNonQuery();
                        Conn.Close();
                        MessageBox.Show("Employer data has been successfully removed!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadEmployer(); // Reload the updated list
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


        #region method
        public void loadEmployer()
        {
            try
            {
                int i = 0; // To show the number for the employer list
                dgvEmployer.Rows.Clear();
                string query = "SELECT id, name, phone, address, [dob], role, gender, salary , password FROM tbEmployer WHERE CONCAT(name, address, role) LIKE '%' + @search + '%'";
                Cm = new SqlCommand(query, Conn);
                Cm.Parameters.AddWithValue("@search", txtSearch.Text);
                Conn.Open();
                dr = Cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvEmployer.Rows.Add(i, dr["id"].ToString(), dr["name"].ToString(), dr["phone"].ToString(), dr["address"].ToString(), dr["dob"].ToString(), dr["gender"].ToString(), dr["role"].ToString(), dr["salary"].ToString(), dr["password"].ToString());
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Employer_Registration module = new Employer_Registration(this);
            module.btnUPDATE.Enabled = false;//this is for save not update
            module.ShowDialog(); // Show the EmployerModule form as a dialog
        }
    }
}


