using System;
using System.Data.OleDb;
using System.Windows.Forms;
using MLDIS.Properties;

namespace MLDIS
{
    public partial class TestReports : Form
    {
        public TestReports()
        {
            InitializeComponent();
        }

        private void TestReports_Load(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new OleDbConnection(Resources.ConnectionString))
                {
                    connection.Open();

                    using (var command = new OleDbCommand("SELECT * FROM Tests", connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader != null && reader.Read())
                            {
                                ReportsComboBox.Items.Add(String.Format("{0} - {1}: {2} | {3}", reader["PatientID"],
                                    reader["FullName"], reader["TestName"], DateTime.Parse(reader["TestDate"].ToString()).ToLongDateString()));
                            }
                        }
                    }
                }

                ReportsComboBox.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReportsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var currentID = ReportsComboBox.SelectedItem.ToString().Split(' ')[0];

                using (var connection = new OleDbConnection(Resources.ConnectionString))
                {
                    connection.Open();

                    using (var command = new OleDbCommand("SELECT * FROM Tests WHERE PatientID = @id", connection))
                    {
                        command.Parameters.AddWithValue("@id", currentID);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader != null && reader.Read())
                            {
                                DetailsRichTextBox.Text = reader["TestReport"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
