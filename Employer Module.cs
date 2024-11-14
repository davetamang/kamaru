using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Mysqlx.Notice;

namespace Car_Wash_Management
{
    public partial class Employer_Registration : Form
    {
        private SqlConnection Conn;
        bool check = false;
        Employer employer;


        public Employer_Registration(Employer emp)

        {
            InitializeComponent();
            employer = emp;
            cbRole.SelectedIndex = 3;
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

        private void Employer_Registration_Load(object sender, EventArgs e)
        {

        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {

            try
            {
                checkField();
                if (check)
                {
                    if (MessageBox.Show("Are you sure you want to register this employer?", "Employer Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                    {
                        Conn.Open();
                        string query = "INSERT INTO tbEmployer (Name, Phone, Address, Role, Salary, Gender, dob, password) VALUES (@Name, @Phone, @Address, @Role, @Salary, @Gender, @dob ,@password)";
                        SqlCommand cmd = new SqlCommand(query, Conn);
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@Address", TxtAddress.Text);
                        cmd.Parameters.AddWithValue("@Role", cbRole.Text);
                        cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);
                        cmd.Parameters.AddWithValue("@Gender", rdMale.Checked ? "Male" : "Female");
                        cmd.Parameters.AddWithValue("@dob", dtDob.Value);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                        cmd.ExecuteNonQuery();
                        Conn.Close();
                        MessageBox.Show("Employer has been successfully registeresd!");
                        check = false;
                        Clear();
                        employer.loadEmployer();// refresh the employer list after insert the data
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
        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow digit number
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar)&&(e.KeyChar!='.'))
            {
                e.Handled = true;
            }
            //only allow one digit
            if((e.KeyChar=='.')&&(sender as TextBox).Text.IndexOf('.')>-1)
           {
                e.Handled = true;
            }
               
        }
        #region method
        public void Clear()
        {
            txtName.Clear();
            txtPhone.Clear();
            TxtAddress.Clear();
            txtSalary.Clear();
            cbRole.SelectedIndex = 3;
            dtDob.Value = DateTime.Now;
        }
        // To check data fields
        public void checkField()
        {
            if (TxtAddress.Text == "" || txtPhone.Text == "" || txtSalary.Text == "")
            {
                MessageBox.Show("Required data Field!", "Warning");
                return; // To return to the data field and form
            }
            if (checkAge(dtDob.Value) < 18)
            {
                MessageBox.Show("Employer is under 18!", "Warning");
                return;
            }
            check = true;
        }

        // To check the age and calculate for under 18
        private static int checkAge(DateTime Dateofbirth)
        {
            int age = DateTime.Now.Year - Dateofbirth.Year;
            if (DateTime.Now.DayOfYear < Dateofbirth.DayOfYear)
                age -= 1;
            return age;
        }



        #endregion method

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                checkField();
                if (check)
                {
                    if (MessageBox.Show("Are you sure you want to edit this record?", "Employer Editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Conn.Open();
                        string query = "UPDATE tbEmployer SET Name=@Name, Phone=@Phone, Address=@Address, Role=@Role, Salary=@Salary, Gender=@Gender, dob=@dob , Password=@Password WHERE id=@id";
                        SqlCommand cmd = new SqlCommand(query, Conn);
                        cmd.Parameters.AddWithValue("@id", lblEld.Text); // Ensure lblEld contains the ID
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@Address", TxtAddress.Text);
                        cmd.Parameters.AddWithValue("@Role", cbRole.Text);

                        // Ensure Salary is numeric
                        if (decimal.TryParse(txtSalary.Text, out decimal salary))
                        {
                            cmd.Parameters.AddWithValue("@Salary", salary);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid numeric value for Salary.");
                            return;
                        }

                        cmd.Parameters.AddWithValue("@Gender", rdMale.Checked ? "Male" : "Female");
                        cmd.Parameters.AddWithValue("@dob", dtDob.Value);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.ExecuteNonQuery();
                        Conn.Close();
                        MessageBox.Show("Employer has been successfully updated!");
                        Clear();
                        this.Dispose();
                        employer.loadEmployer();
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

       
    }
}

