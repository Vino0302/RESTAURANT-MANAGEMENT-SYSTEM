using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT_MANAGEMENT_SYSTEM
{
    public partial class frmHome :MetroFramework.Forms.MetroForm
    {
        private string userRole;

        public frmHome(string userRole)
        {
            InitializeComponent();
            this.userRole = userRole;
            SetButtonVisibility();
        }

        private void SetButtonVisibility()
        {
            
            if (userRole == "Admin")
            {
                btn_AddUser.Visible = true;
                btn_FoodOrder.Visible = true;
                btn_tabelRseservation.Visible = true;
                btn_Cost.Visible = true;
                btn_bill.Visible = true;
                btn_about.Visible = true;
            }
            else if (userRole == "Cashier")
            {
                btn_AddUser.Visible = false;
                btn_FoodOrder.Visible = true;
                btn_tabelRseservation.Visible = true;
                btn_Cost.Visible = true;
                btn_bill.Visible = true;
                btn_about.Visible = true;
            }
            else if (userRole == "Waiter")
            {

                btn_AddUser.Visible = false;
                btn_FoodOrder.Visible = true;
                btn_tabelRseservation.Visible = true;
                btn_Cost.Visible = false;
                btn_bill.Visible = false;
                btn_about.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid User Role");
            }
        }

        private void btn_tabelRseservation_Click(object sender, EventArgs e)
        {
            frm_table_reservation tblReservation = new frm_table_reservation();
            tblReservation.Show();
        }
    }
}
