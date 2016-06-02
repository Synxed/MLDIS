using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using MLDIS.Properties;

namespace MLDIS
{
    public partial class PatientRegistration : Form
    {
        public PatientRegistration()
        {
            InitializeComponent();
        }

        private void PatientRegistration_Load(object sender, System.EventArgs e)
        {
            BloodTypeComboBox.SelectedIndex = 0;
            SexComboBox.SelectedIndex = 0;
            DateOfBirthDateTimePicker.MaxDate = DateTime.Today;
        }

        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            foreach (var control in Controls.Cast<Control>().Where(control => control.GetType() == typeof (TextBox)))
            {
                ((TextBox) control).Clear();
            }
            foreach (var control in TestsRequiredGroupBox.Controls.Cast<Control>() .Where(control => control.GetType() == typeof (CheckBox)))
            {
                ((CheckBox) control).Checked = false;
            }

            AddressRichTextBox.Clear();
            BloodTypeComboBox.SelectedIndex = 0;
            SexComboBox.SelectedIndex = 0;
            DateOfBirthDateTimePicker.Value = DateTime.Parse("1/1/1990 12:00 PM");
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (Controls.Cast<Control>()
                .Where(control => control.GetType() == typeof (TextBox))
                .Any(control => ((TextBox) control).Text == string.Empty))
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
                    var commandString =
                        "INSERT INTO Patients (PatientID, FullName, Mobile, Address, Sex, BloodType, DateOfBirth, ReportingDoctor, TestsRequired, RegisteredOn)" +
                        "Values (@PatientID, @FullName, @Mobile, @Address, @Sex, @BloodType, @DateOfBirth, @ReportingDoctor, @TestsRequired, @RegisteredOn)";

                    using (var command = new OleDbCommand(commandString, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", GetUniquePatientID());
                        command.Parameters.AddWithValue("@FullName", FullNameTextBox.Text);
                        command.Parameters.AddWithValue("@Mobile", MobileTextBox.Text);
                        command.Parameters.AddWithValue("@Address", AddressRichTextBox.Text);
                        command.Parameters.AddWithValue("@Sex", SexComboBox.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@BloodType", BloodTypeComboBox.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirthDateTimePicker.Value.ToString("d"));
                        command.Parameters.AddWithValue("@ReportingDoctor", ReportingDoctorTextBox.Text);
                        command.Parameters.AddWithValue("@TestsRequired", GetTestsRequiredString());
                        command.Parameters.AddWithValue("@RegisteredOn", DateTime.Today.ToString("d"));

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("The patient has been successfully registered.", "Registration Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured." + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetUniquePatientID()
        {
            const string alphaNumericChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var id = "PTN - " + new string(Enumerable.Repeat(alphaNumericChars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            using (var connection = new OleDbConnection(Resources.ConnectionString))
            using (var command = new OleDbCommand("SELECT COUNT(*) FROM Patients WHERE PatientID = @id", connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", id);

                return (int) command.ExecuteScalar() == 0 ? id : GetUniquePatientID();
            }           
        }

        private string GetTestsRequiredString()
        {
            var testsRequired = new List<string>();

            if(BTCheckBox.Checked) testsRequired.Add("BT");
            if(RTCheckBox.Checked) testsRequired.Add("RT");
            if(ECGTCheckBox.Checked) testsRequired.Add("ECG");
            if(UrinalysisCheckBox.Checked) testsRequired.Add("Urinalysis");

            return String.Join(", ", testsRequired.ToArray());
        }
    }
}