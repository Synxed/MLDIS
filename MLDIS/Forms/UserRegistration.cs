using System;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MLDIS.Properties;

namespace MLDIS
{
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {
            DesignationComboBox.SelectedIndex = 0;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (LoginCredentialGroupBox.Controls.Cast<Control>()
                    .Where(control => control.GetType() == typeof (TextBox))
                    .Any(control => ((TextBox) control).Text == string.Empty) ||
                DetailsGroupBox.Controls.Cast<Control>()
                    .Where(control => control.GetType() == typeof (TextBox))
                    .Any(control => ((TextBox) control).Text == string.Empty) ||
                !IsAvalaible(UsernameTextBox.Text) ||
                UsernameTextBox.Text.Length < 4)
            {
                MessageBox.Show("Please fill all fields with valid data.", "An Error Occurred",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var connection = new OleDbConnection(Resources.ConnectionString))
                {
                    connection.Open();
                    var commandString = "INSERT INTO Users (Username, [Password], Designation, FullName, Sex, BloodType, Address, Email, Mobile, Schedule, Discount, Tax)" +
                        "Values (@Username, @Password, @Designation, @FullName, @Sex, @BloodType, @Address, @Email, @Mobile, @Schedule, @Discount, @Tax)";

                    using (var command = new OleDbCommand(commandString, connection))
                    {
                        command.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
                        command.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
                        command.Parameters.AddWithValue("@Designation", DesignationComboBox.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@FullName", FullNameTextBox.Text);
                        command.Parameters.AddWithValue("@Sex", SexTextBox.Text);
                        command.Parameters.AddWithValue("@BloodType", BloodTypeTextBox.Text);
                        command.Parameters.AddWithValue("@Address", AddressTextBox.Text);
                        command.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                        command.Parameters.AddWithValue("@Mobile", MobileTextBox.Text);
                        command.Parameters.AddWithValue("@Schedule", ScheduleTextBox.Text);
                        command.Parameters.AddWithValue("@Discount", DiscountNumericBox.Value);
                        command.Parameters.AddWithValue("@Tax", TaxNumericBox.Value);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("The user has been successfully registered.", "Registration Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured." + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Length < 4)
            {
                UsernameAvailabilityLabel.Text = "Invalid";
                UsernameAvailabilityLabel.ForeColor = ColorTranslator.FromHtml("#ee1111");
                return;
            }
            try
            {
                if (IsAvalaible(UsernameTextBox.Text))
                {
                    UsernameAvailabilityLabel.Text = "Avalaible";
                    UsernameAvailabilityLabel.ForeColor = ColorTranslator.FromHtml("#00a300");
                }
                else
                {
                    UsernameAvailabilityLabel.Text = "Unavalaible";
                    UsernameAvailabilityLabel.ForeColor = ColorTranslator.FromHtml("#ee1111");           
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured." + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            foreach (var control in LoginCredentialGroupBox.Controls.Cast<Control>().Where(control => control.GetType() == typeof(TextBox)))
            {
                ((TextBox)control).Clear();
            }
            foreach (var control in LoginCredentialGroupBox.Controls.Cast<Control>().Where(control => control.GetType() == typeof(TextBox)))
            {
                ((TextBox)control).Clear();
            }

            DesignationComboBox.SelectedIndex = 0;
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = ShowPasswordCheckBox.Checked ? '\0' : '•';
        }

        private static bool IsAvalaible(string username)
        {
            using (var connection = new OleDbConnection(Resources.ConnectionString))
            using (var command = new OleDbCommand("SELECT COUNT(*) FROM Users WHERE Username = @username", connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@username", username);
                return (int)command.ExecuteScalar() == 0;
            }
        }
    }
}
