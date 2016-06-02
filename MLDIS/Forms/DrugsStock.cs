using System;
using System.Data.OleDb;
using System.Windows.Forms;
using MLDIS.Properties;

namespace MLDIS
{
    public partial class DrugsStock : Form
    {
        public DrugsStock()
        {
            InitializeComponent();
        }

        private void StockCheckerTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                var currentStock = Stock.GetCurrentStock();

                SynthroidLabel.Text = currentStock["Synthroid"].ToString();
                CrestorLabel.Text = currentStock["Crestor"].ToString();
                NexiumLabel.Text = currentStock["Nexium"].ToString();
                VentolinHFALabel.Text = currentStock["VentolinHFA"].ToString();
                AdvairDiskusLabel.Text = currentStock["AdvairDiskus"].ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured." + Environment.NewLine + Environment.NewLine + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
