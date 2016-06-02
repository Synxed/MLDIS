using System;
using System.Data.OleDb;
using System.Security.Authentication;
using System.Windows.Forms;
using MLDIS.Properties;

namespace MLDIS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsernameTextBox.Text.ToLower() == "patient")
                {
                    new ControlPanel("Patient").Show();
                    return;
                }

                using (var connection = new OleDbConnection(Resources.ConnectionString))
                {
                    connection.Open();
                    var command = "SELECT * FROM Users WHERE Username = @user";

                    using (var fetchUserCommand = new OleDbCommand(command, connection))
                    {
                        fetchUserCommand.Parameters.AddWithValue("@user", UsernameTextBox.Text);
                        using (var reader = fetchUserCommand.ExecuteReader())
                        {
                            reader.Read();
                            if (reader["Password"].ToString() == PasswordTextBox.Text)
                            {
                                new ControlPanel(reader["Username"].ToString()).Show();
                            }
                            else
                            {
                                throw new InvalidCredentialException("Username/Password is incorrect.");
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured." + Environment.NewLine + Environment.NewLine + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            LoginButton.Enabled = !(UsernameTextBox.Text == string.Empty || PasswordTextBox.Text == string.Empty);
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = ShowPasswordCheckBox.Checked ? '\0' : '•';
        }
    }
}
