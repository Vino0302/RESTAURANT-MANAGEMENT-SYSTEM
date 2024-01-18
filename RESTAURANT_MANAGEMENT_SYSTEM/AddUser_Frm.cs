using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RESTAURANT_MANAGEMENT_SYSTEM
{
    public partial class AddUser_Frm : MetroFramework.Forms.MetroForm // class
    {
        public AddUser_Frm()
        {
            InitializeComponent();
        }
        // database connect
        string connectionString = "Data Source=DESKTOP-GBMK3I1\\SQLEXPRESS;Initial Catalog=Resturant_m_System;Integrated Security=True";
        private string connection; //instance variable
        private object erroProvider1;

        private void AddUser_Frm_Load(object sender, EventArgs e) // method
        {
            
            this.createAccTableAdapter.Fill(this.resturant_m_SystemDataSet.CreateAcc);

        }

        private void txt_first_name_Click(object sender, EventArgs e)
        {

        }

      // Generate StaffID
        private void GenerateStaffID()
        {
            if (ComboBox_Position.SelectedItem != null)
            {
                string positionCode = GetPositionCode(ComboBox_Position.SelectedItem.ToString());

                string nicNumber = textBox_NIC.Text;


                string staffID = $"{positionCode}{nicNumber}";


                textBox_staffId.Text = staffID;

            }
        }

        private string GetPositionCode(string position)
        {
           
            return position.Substring(0, 3).ToUpper();
        }
        //clear data
       void reset()
        {
            txtboxFirstName.Clear();
            txt_lastname.Clear();   
            textBox_Email.Clear();
            bday_datetimepicker.Value = DateTime.Now;
            textBox_NIC.Clear();
            ComboBox_gender.SelectedIndex = -1;
            ComboBox_Position.SelectedIndex = -1;
            textBox_staffId.Clear();
            textBox_contact.Clear();
            textBox_pw.Clear();
            textBox_conPw.Clear();
            DateTime_JoinedDate.Value = DateTime.Now;


        }
        //Display data using view button
        void display()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GBMK3I1\\SQLEXPRESS;Initial Catalog=Resturant_m_System;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT FirstName,LastName,Email,BirthDate,Gender,Position,StaffId,Contact,JoinedDate FROM CreateAcc";
                using(SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                }
        }
 
         
        }
        // use reset method to clrar
        private void clear_btn_Click(object sender, EventArgs e)
        {
            reset();
        }
        // use display method to view
        private void button_view_Click(object sender, EventArgs e)
        {

            display();
        }
        //generated id view place
        private void ComboBox_Position_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            GenerateStaffID();
        }
        //use method to check verification pw== con pw
        private bool ArePasswordsEqual()
        {
            return textBox_pw.Text == textBox_conPw.Text;
        }
        //add data to form
        private void add_btn_Click_1(object sender, EventArgs e)
        {
            if (!ArePasswordsEqual())
            {
                MessageBox.Show("Password and Confirm Password do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtboxFirstName.Text) == true)
            {
                textBox_NIC.Focus();
                MessageBox.Show("Please Enter First Name");
            }
            else if (string.IsNullOrEmpty(txt_lastname.Text) == true)
            {
                textBox_NIC.Focus();
                MessageBox.Show("Please Enter Last Name");
            }
            else if (string.IsNullOrEmpty(textBox_NIC.Text) == true)
            {
                textBox_NIC.Focus();
                MessageBox.Show("Please Enter NIC");
            }
            else { 

            string firstName = txtboxFirstName.Text;
            string lastName = txt_lastname.Text;
            string Email = textBox_Email.Text;
            DateTime birthDate = bday_datetimepicker.Value;
            string nic = textBox_NIC.Text;
            string gender = ComboBox_gender.SelectedItem.ToString();
            string position = ComboBox_Position.SelectedItem.ToString();
            string staffId = textBox_staffId.Text;
            string contact = textBox_contact.Text;
            string password = textBox_pw.Text;
            string confirmPassword = textBox_conPw.Text;
            DateTime joinedDate = DateTime_JoinedDate.Value;

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GBMK3I1\\SQLEXPRESS;Initial Catalog=Resturant_m_System;Integrated Security=True"))

            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("INSERT INTO CreateAcc (FirstName, LastName,Email, BirthDate, NIC, Gender, Position, StaffId,Contact, Password,ConfirmPw, JoinedDate) VALUES (@FirstName, @LastName,@Email, @BirthDate, @NIC, @Gender, @Position, @StaffId, @Contact, @Password,@ConfirmPw, @JoinedDate)", connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@BirthDate", birthDate);
                        command.Parameters.AddWithValue("@NIC", nic);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Position", position);
                        command.Parameters.AddWithValue("@StaffId", staffId);
                        command.Parameters.AddWithValue("@Contact", contact);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@ConfirmPw", confirmPassword);
                        command.Parameters.AddWithValue("@JoinedDate", joinedDate);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Registration successful!");
                        display();
                        reset();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
           }

        }
        // back to get data to fillup document
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtboxFirstName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_lastname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox_Email.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            bday_datetimepicker.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value);
            ComboBox_gender.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            ComboBox_Position.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox_staffId.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox_contact.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            DateTime_JoinedDate.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[8].Value);




        }
        //update data 
        private void update_btn_Click(object sender, EventArgs e)
        {
            if (!ArePasswordsEqual())
            {
                MessageBox.Show("Password and Confirm Password do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string firstName = txtboxFirstName.Text;
            string lastName = txt_lastname.Text;
            string Email = textBox_Email.Text;
            DateTime birthDate = bday_datetimepicker.Value;
            string nic = textBox_NIC.Text;
            string gender = ComboBox_gender.SelectedItem.ToString();
            string position = ComboBox_Position.SelectedItem.ToString();
            string staffId = textBox_staffId.Text;
            string contact = textBox_contact.Text;
            string password = textBox_pw.Text;
            string confirmPassword = textBox_conPw.Text;
            DateTime joinedDate = DateTime_JoinedDate.Value;

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GBMK3I1\\SQLEXPRESS;Initial Catalog=Resturant_m_System;Integrated Security=True"))

            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UPDATE CreateAcc SET FirstName=@FirstName, LastName=@LastName, Email=@Email, BirthDate=@BirthDate, NIC=@NIC, Gender=@Gender, Position=@Position, Contact=@Contact, Password=@Password, ConfirmPw=@ConfirmPw, JoinedDate=@JoinedDate WHERE StaffId=@StaffId", connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@BirthDate", birthDate);
                        command.Parameters.AddWithValue("@NIC", nic);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Position", position);
                        command.Parameters.AddWithValue("@StaffId", staffId);
                        command.Parameters.AddWithValue("@Contact", contact);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@ConfirmPw", confirmPassword);
                        command.Parameters.AddWithValue("@JoinedDate", joinedDate);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Update successful!");
                        display();
                        reset();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
        //delete data
        private void delete_btn_Click(object sender, EventArgs e)
        {
            string firstName = txtboxFirstName.Text;
            string lastName = txt_lastname.Text;
            string Email = textBox_Email.Text;
            DateTime birthDate = bday_datetimepicker.Value;
            string nic = textBox_NIC.Text;
            string gender = ComboBox_gender.SelectedItem.ToString();
            string position = ComboBox_Position.SelectedItem.ToString();
            string staffId = textBox_staffId.Text;
            string contact = textBox_contact.Text;
            string password = textBox_pw.Text;
            string confirmPassword = textBox_conPw.Text;
            DateTime joinedDate = DateTime_JoinedDate.Value;

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GBMK3I1\\SQLEXPRESS;Initial Catalog=Resturant_m_System;Integrated Security=True"))

            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM CreateAcc Where StaffId=@StaffId", connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@BirthDate", birthDate);
                        command.Parameters.AddWithValue("@NIC", nic);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Position", position);
                        command.Parameters.AddWithValue("@StaffId", staffId);
                        command.Parameters.AddWithValue("@Contact", contact);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@ConfirmPw", confirmPassword);
                        command.Parameters.AddWithValue("@JoinedDate", joinedDate);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Deleted successful!");
                        display();
                        reset();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        //search data
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GBMK3I1\\SQLEXPRESS;Initial Catalog=Resturant_m_System;Integrated Security=True");
            connection.Open();
            string query = "SELECT FirstName,LastName,Email,Position,StaffId,Contact FROM CreateAcc Where StaffId like @StaffId + '%' ";
            SqlDataAdapter adapter = new SqlDataAdapter( query,connection);
            adapter.SelectCommand.Parameters.AddWithValue("@StaffId", textBoxSearch.Text);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Data Not Found");
                dataGridView1.DataSource = null;
            }
  
        }
        //exit application
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_NIC_TextChanged(object sender, EventArgs e)
        {
            string nicText = textBox_NIC.Text;

           
            if (nicText.Contains("V") || nicText.Contains("X"))
            {
                lbl_nicMsg.Text = "Invalid NIC. Do not enter 'V' or 'X'.";
            }
            else
            {
                lbl_nicMsg.Text = "Enter your NIC numbers only. Do not enter 'V' or 'X'. Ex: 623567892 or 200156789012";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
    }

