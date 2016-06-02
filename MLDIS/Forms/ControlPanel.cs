using System;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MLDIS.Properties;

namespace MLDIS
{
    public partial class ControlPanel : Form
    {
        private readonly string _username;
        private Users.Designation _designation;

        public ControlPanel(string username)
        {
            _username = username;
            InitializeComponent();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            try
            {
                if (_username == "Patient")
                {
                    _designation = Users.Designation.Patient;
                }
                else
                {
                    using (var connection = new OleDbConnection(Resources.ConnectionString))
                    {
                        var command = "SELECT * FROM Users WHERE Username = @user";
                        connection.Open();

                        using (var fetchDataCommand = new OleDbCommand(command, connection))
                        {
                            fetchDataCommand.Parameters.AddWithValue("@user", _username);
                            using (var reader = fetchDataCommand.ExecuteReader())
                            {
                                reader.Read();
                                UsernameLabel.Text = reader["Username"].ToString();
                                FullNameLabel.Text = reader["FullName"].ToString();
                                DesignationLabel.Text = reader["Designation"].ToString();
                                _designation = Users.GetUserDesignation(reader["Designation"].ToString());
                            }
                        }
                    }
                }

                LoggedinSinceLabel.Text = DateTime.Now.ToString("G");

                switch (_designation)
                {
                    case Users.Designation.Administrator:
                        ModulesComboBox.Items.Add("Bill Generation");
                        ModulesComboBox.Items.Add("User Registration");
                        ModulesComboBox.Items.Add("Patient Registration");
                        ModulesComboBox.Items.Add("Drugs Stock");
                        break;
                    case Users.Designation.Doctor:
                        ModulesComboBox.Items.Add("Test Reports");
                        ModulesComboBox.Items.Add("Create Prescriptions");
                        break;
                    case Users.Designation.Technician:
                        ModulesComboBox.Items.Add("Create Test Reports");
                        break;
                    case Users.Designation.Dispensary:
                        ModulesComboBox.Items.Add("Dispensary");
                        ModulesComboBox.Items.Add("Drugs Stock");
                        break;
                    case Users.Designation.Store:
                        ModulesComboBox.Items.Add("Process Requisition");
                        ModulesComboBox.Items.Add("Drugs Stock");
                        break;
                    case Users.Designation.Patient:
                        ModulesComboBox.Items.Add("Patient Bills");
                        break;
                }

                ModulesComboBox.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            var selectedItem = ModulesComboBox.SelectedItem.ToString().Replace(" ", string.Empty);

            TryGetFormByName(selectedItem).Show();
        }

        public Form TryGetFormByName(string formName)
        {
            var formType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(a => a.BaseType == typeof (Form) && a.Name == formName);

            if (formType == null) // If there is no form with the given frmname
                return null;

            return (Form) Activator.CreateInstance(formType);
        }
    }
}
