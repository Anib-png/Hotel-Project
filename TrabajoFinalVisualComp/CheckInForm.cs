using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrabajoFinalVisualComp
{
    public partial class CheckInForm : Form
    {
        private string connectionString = "Server=DESKTOP-G9J9UCN\\SQLEXPRESS02;Database=HotelDatabase;Integrated Security=True;";

        public CheckInForm()
        {
            InitializeComponent();
            InitializeRoomNumbers();
        }

        private void InitializeRoomNumbers()
        {
           
            for (int i = 1; i <= 10; i++)
            {
                cmbRoomNo.Items.Add(i);
            }
        }

        private void btnAddCheckIn_Click(object sender, EventArgs e)
        {
            string guestName = txtGName.Text;
            int roomNumber = Convert.ToInt32(cmbRoomNo.SelectedItem);
            DateTime dateFrom = dtpFrom.Value.Date;
            DateTime dateTo = dtpTo.Value.Date;
            decimal cost = Convert.ToDecimal(txtCost.Text);

           
            if (IsRoomBooked(roomNumber, dateFrom, dateTo))
            {
                MessageBox.Show("This room is already booked for the selected dates. Please choose another room or adjust the dates.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO CheckIn (GuestName, GuestNumber, RoomNumber, DateFrom, DateTo, Cost) " +
                                   "VALUES (@GuestName, @GuestNumber, @RoomNumber, @DateFrom, @DateTo, @Cost)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GuestName", guestName);
                        command.Parameters.AddWithValue("@GuestNumber", GenerateGuestNumber());
                        command.Parameters.AddWithValue("@RoomNumber", roomNumber);
                        command.Parameters.AddWithValue("@DateFrom", dateFrom);
                        command.Parameters.AddWithValue("@DateTo", dateTo);
                        command.Parameters.AddWithValue("@Cost", cost);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Check-in added successfully!");
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add check-in.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private string GenerateGuestNumber()
        {
            
            Random random = new Random();
            return random.Next(10000, 99999).ToString();
        }

        private bool IsRoomBooked(int roomNumber, DateTime dateFrom, DateTime dateTo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM CheckIn " +
                                   "WHERE RoomNumber = @RoomNumber " +
                                   "AND ((@DateFrom BETWEEN DateFrom AND DateTo) OR (@DateTo BETWEEN DateFrom AND DateTo))";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomNumber", roomNumber);
                        command.Parameters.AddWithValue("@DateFrom", dateFrom);
                        command.Parameters.AddWithValue("@DateTo", dateTo);

                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking room availability: " + ex.Message);
                return true; // Assume room is booked in case of an error
            }
        }

        private void ClearFields()
        {
            txtGName.Text = "";
            cmbRoomNo.SelectedIndex = -1;
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;
            txtCost.Text = "";
        }

		private void txtCost_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
            CheckInDatabase checkInDatabaseForm = new CheckInDatabase();
            checkInDatabaseForm.Show();
            this.Hide();
        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
            this.Hide();
        }

        private void signOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}



