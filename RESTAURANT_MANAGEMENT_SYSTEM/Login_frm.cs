using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT_MANAGEMENT_SYSTEM
{
    public partial class Login_frm : MetroFramework.Forms.MetroForm
    {
        public Login_frm()
        {
            InitializeComponent();
        }

        // when don't have accout can create account by click in here
        private void label_SignUp_Click(object sender, EventArgs e)
        {
            AddUser_Frm createUser = new AddUser_Frm();
            createUser.Show();
        }

        //exit from  application
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //login to form
        private void btn_login_Click(object sender, EventArgs e)
        {
            string enteredStaffId = txt_userName.Text;
            string enteredPassword = txt_PWord.Text;

            //database connect to veryfy username and password
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GBMK3I1\\SQLEXPRESS;Initial Catalog=Resturant_m_System;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT StaffId, Password FROM CreateAcc WHERE StaffId=@StaffId AND Password=@Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StaffId", enteredStaffId);
                    command.Parameters.AddWithValue("@Password", enteredPassword);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string userRole = GetUserRole(enteredStaffId);
                            frmHome homeForm = new frmHome(userRole);
                            homeForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid staff ID or password");
                        }
                    }
                }
            }
        }
        //this method use to identify user role
        private string GetUserRole(string staffId)
        {
            if (IsAdminStaff(staffId))
            {
                return "Admin";
            }
            else if (IsCashierStaff(staffId))
            {
                return "Cashier";
            }
            else if (IsWaiterStaff(staffId))
            {
                return "Waiter";
            }
            else
            {
                return "Unknown";
            }
        }

        //when StaffId have MAN- it could be admin , then show all buttons or all things in dashboard
        private bool IsAdminStaff(string staffId)
        {
            return staffId.StartsWith("MAN", StringComparison.OrdinalIgnoreCase);
        }

        private bool IsCashierStaff(string staffId)
        {
            return staffId.StartsWith("CAS", StringComparison.OrdinalIgnoreCase);
        }

        private bool IsWaiterStaff(string staffId)
        {
            return staffId.StartsWith("WAI", StringComparison.OrdinalIgnoreCase);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUser_Frm createUser = new AddUser_Frm();
            createUser.Show();
        }
    }
}

