using MetroFramework.Controls;
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
    public partial class frm_table_reservation : MetroFramework.Forms.MetroForm
    {
        //list use to update table data like id,name,count and description
        private List<Table> tables;
        private List<Button> tableButtons;
        private ListViewItem currentBookingItem;

        public frm_table_reservation()
        {
            InitializeComponent();
            InitializeTables();
            InitializeButtons();
            DisplayTables();



        }
        // this method used to 
        private void DisplayTables()
        {
            groupBox3.Controls.Clear();//This line clears all existing controls within the 

            foreach (var table in tables)
            {
                Button tableButton = tableButtons[table.TableID - 1];
                groupBox3.Controls.Add(tableButton);
                tableButton.Click += TableButton_Click;
            }
        }

        private void InitializeButtons()
        {
            tableButtons = new List<Button>();


            int[,] buttonLocations = {
                {50, 79}, {130, 79}, {210, 79}, {290, 79}, {370, 79},
                {50, 169}, {130, 169}, {210, 169}, {290, 169}, {370, 169},
                {50, 259}, {130, 259}, {210, 259}, {290, 259}, {370, 259},
                {50, 349}, {130, 349}, {210, 349}, {290, 349}, {370, 349}
            };

            int buttonWidth = 63;
            int buttonHeight = 69;

            for (int i = 0; i < 20; i++)
            {
                Button btn = new Button
                {
                    Width = buttonWidth,
                    Height = buttonHeight,
                    Text = "Table " + (i + 1),
                    TextAlign = ContentAlignment.BottomCenter,
                    ImageAlign = ContentAlignment.TopCenter,
                    Tag = tables[i],
                    Image = Properties.Resources.BlackTable,
                    Location = new Point(buttonLocations[i, 0], buttonLocations[i, 1]),
                    BackColor = Color.White
                };

                btn.Click += TableButton_Click;

                tableButtons.Add(btn);
            }
        }
        private void InitializeTables()
        {
            tables = new List<Table>
            {
                new Table(1, "Table 1", 2, 300.00, "Outdoor private Area"),
                new Table(2, "Table 2", 4, 450.00, "Outdoor four people"),
                new Table(3, "Table 3", 6, 750.00, "Outdoor large peoplre area"),
                new Table(4, "Table 4", 2, 300.00, "Outdoor private Area"),
                new Table(5, "Table 6", 4, 0.00, "Indoor four people"),
                new Table(6, "Table 5", 2, 150.00, "Indoor private Area"),
                new Table(7, "Table 7", 6, 700.00, "Indoor large peoplre area"),
                new Table(8, "Table 8", 2, 150.00, "Indoor private Area"),
                new Table(9, "Table 9", 2, 150.00, "Indoor private Area"),
                new Table(10, "Table 10", 2, 150.00, "Indoor private Area"),
                new Table(11, "Table 11", 6, 700.00, "Indoor large peoplre area"),
                new Table(12, "Table 12", 4, 0.00, "Indoor four people"),
                new Table(13, "Table 13", 4, 0.00, "Indoor four people"),
                new Table(14, "Table 14", 2, 150.00, "Indoor private Area"),
                new Table(15, "Table 15", 6, 700.00, "Indoor large peoplre area"),
                new Table(16, "Table 16", 2, 150.00, "Indoor private Area"),
                new Table(17, "Table 17", 2, 300.00, "Outdoor private Area"),
                new Table(18, "Table 18", 4, 450.00, "Outdoor four people"),
                new Table(19, "Table 19", 6, 750.00, "Outdoor large peoplre area"),
                new Table(20, "Table 20", 4, 450.00, "Outdoor four people"),
            };
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton && clickedButton.Tag is Table clickedTable)
            {

                UpdateTableInfo(clickedTable);

                clickedButton.BackColor = Color.LightBlue;

                foreach (var button in tableButtons)
                {
                    button.BackColor = Color.White;

                    

                }
               
                clickedButton.BackColor = Color.LightBlue;
            }
        }

        private void UpdateTableInfo(Table table)
        {
            Lbl_TableId.Text = $"Table ID: {table.TableID}";
            Lbl_count.Text = $"Count of People: {table.CountOfPeople}";
            Lbl_Description.Text = $"Description: {table.Description}";
        }

        private void UpdateButtonAvailability(Table table)
        {
            Btn_Booking.Enabled = !table.IsBooked;
            btn_cancellation.Enabled = table.IsBooked;
        }


        private void Btn_Booking_Click(object sender, EventArgs e)
        {
            Table selectedTable = GetSelectedTable();

            if (selectedTable != null)
            {
                if (!selectedTable.IsBooked)
                {
                    string customerName = Txt_custName.Text.Trim();
                    string contactNumber = Txt_cus_contact.Text.Trim();

                    if (string.IsNullOrWhiteSpace(textBox1.Text))
                    {
                        MessageBox.Show("Please enter a valid booking time.", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Customer information is not empty
                    if (!string.IsNullOrEmpty(customerName) && !string.IsNullOrEmpty(contactNumber))
                    {
                        // Check contact number includes 10 digits
                        if (IsNumeric(contactNumber) && contactNumber.Length == 10)
                        {
                            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GBMK3I1\\SQLEXPRESS;Initial Catalog=Resturant_m_System;Integrated Security=True"))
                            {
                                try
                                {
                                    connection.Open();

                                    // Insert into the database
                                    string insertQuery = "INSERT INTO TBL_R (CustomerName, CustomerContact, TableID, Date, Time) VALUES (@CustomerName, @ContactNumber, @TableID, @BookingDate, @BookingTime)";

                                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                                    {
                                        cmd.Parameters.AddWithValue("@CustomerName", customerName);
                                        cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                                        cmd.Parameters.AddWithValue("@TableID", selectedTable.TableID);
                                        cmd.Parameters.AddWithValue("@BookingDate", datePick.Value);
                                        cmd.Parameters.AddWithValue("@BookingTime", textBox1.Text);

                                        cmd.ExecuteNonQuery();
                                    }

                                    // Clear the DataTable
                                    bookingDataTable.Clear();

                                    // Retrieve all previous bookings from the database
                                    string selectQuery = "SELECT CustomerName, CustomerContact, TableID, Date, Time FROM TBL_R";
                                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, connection))
                                    {
                                        using (SqlDataReader reader = selectCmd.ExecuteReader())
                                        {
                                            while (reader.Read())
                                            {
                                                bookingDataTable.Rows.Add(
                                                    reader["CustomerName"],
                                                    reader["CustomerContact"],
                                                    reader["TableID"],
                                                    reader["Date"],
                                                    reader["Time"]
                                                );
                                            }
                                        }
                                    }

                                    // Update DataGridView
                                    dataGridView1.DataSource = null;
                                    dataGridView1.DataSource = bookingDataTable;

                                    UpdateTableBookingStatus(true);

                                    MessageBox.Show($"Table is booked for {customerName}. Contact Number: {contactNumber}", "Booking Successful");

                                    Txt_custName.Clear();
                                    Txt_cus_contact.Clear();
                                    textBox1.Clear();
                                    datePick.Value = DateTime.Now.Date;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid contact number. Please enter a valid 10-digit number.", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Customer name and contact number are required for booking.", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    UpdateTableBookingStatus(false);
                    MessageBox.Show("Table booking is canceled.");
                }
            }
        }


        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }


        private void btn_cancellation_Click(object sender, EventArgs e)
{
    Table selectedTable = GetSelectedTable();

    if (selectedTable != null)
    {
        if (selectedTable.IsBooked)
        {
            // Assuming "connectionString" is your SQL Server connection string
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GBMK3I1\\SQLEXPRESS;Initial Catalog=Resturant_m_System;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    Console.WriteLine($"Cancelling booking for Table ID: {selectedTable.TableID}");

                    // Delete from the database
                    string deleteQuery = "DELETE FROM TBL_R WHERE TableID = @TableID";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@TableID", selectedTable.TableID);

                        cmd.ExecuteNonQuery();
                    }

                    // Remove from DataTable and DataGridView
                    RemoveBookingFromDataTable(selectedTable.TableID);
                    UpdateTableBookingStatus(false);
                    MessageBox.Show("Table booking is cancelled.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        else
        {
            MessageBox.Show("Table is not booked.", "Cancellation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    else
    {
        Console.WriteLine("Selected table is null");
    }
}


        private void RemoveBookingFromDataTable(int tableID)
        {
            // Find and remove the row from the DataTable
            DataRow rowToRemove = bookingDataTable.Rows.Cast<DataRow>().FirstOrDefault(row => (int)row["TableID"] == tableID);

            if (rowToRemove != null)
            {
                bookingDataTable.Rows.Remove(rowToRemove);
            }

            // Remove the row from the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Check if the cell and its value are not null before attempting to cast to int
                if (row.Cells["TableID"] != null && row.Cells["TableID"].Value != null)
                {
                    if (int.TryParse(row.Cells["TableID"].Value.ToString(), out int rowTableID))
                    {
                        if (rowTableID == tableID)
                        {
                            dataGridView1.Rows.Remove(row);
                            break; // Break after removing the first matching row
                        }
                    }
                    else
                    {
                        // Handle the case where the value cannot be parsed to an int
                        MessageBox.Show("TableID value is not an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }


        private Table GetSelectedTable()
        {
            if (int.TryParse(Lbl_TableId.Text.Split(':')[1].Trim().Replace("Table", ""), out int tableID))
            {
                return tables.Find(t => t.TableID == tableID);
            }

            return null;
        }

        private void UpdateTableBookingStatus(bool isBooked)
        {
            if (groupBox3.Controls.Count > 0 && Lbl_TableId.Text.StartsWith("Table ID"))
            {
                if (int.TryParse(Lbl_TableId.Text.Split(':')[1].Trim(), out int tableID))
                {
                    Table selectedTable = tables.Find(t => t.TableID == tableID);
                    if (selectedTable != null)
                    {
                        selectedTable.IsBooked = isBooked;
                        UpdateButtonImage(selectedTable);
                    }
                }
            }
        }



        private void UpdateButtonImage(Table table)
        {
            int tableIndex = table.TableID - 1;
            Button button = tableButtons[tableIndex];

            if (table.IsBooked)
            {
                button.Image = Properties.Resources.RedTable__1_;
            }
            else
            {
                button.Image = Properties.Resources.BlackTable;
            }

        }

        public class Table
        {
            public int TableID { get; set; }
            public string Name { get; set; }
            public int CountOfPeople { get; set; }
            public double Price { get; set; }
            public string Description { get; set; }
            public bool IsBooked { get; set; }

            public Table(int tableID, string name, int countOfPeople, double price, string description)
            {
                TableID = tableID;
                Name = name;
                CountOfPeople = countOfPeople;
                Price = price;
                Description = description;
                IsBooked = false;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private DataTable bookingDataTable; // Add this as a class-level variable

        private void frm_table_reservation_Load(object sender, EventArgs e)
        {
            bookingDataTable = new DataTable();
            bookingDataTable.Columns.Add("CustomerName", typeof(string));
            bookingDataTable.Columns.Add("ContactNumber", typeof(string));
            bookingDataTable.Columns.Add("TableID", typeof(int));
            bookingDataTable.Columns.Add("BookingDate", typeof(DateTime));
            bookingDataTable.Columns.Add("BookingTime", typeof(string));

            // Set the DataTable as the DataSource for the DataGridView
            dataGridView1.DataSource = bookingDataTable;
        }
    }
}

