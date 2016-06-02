using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using MLDIS.Properties;

namespace MLDIS
{
    internal class Stock
    {
        public static Dictionary<string, int> GetCurrentStock()
        {
            try
            {
                using (var connection = new OleDbConnection(Resources.ConnectionString))
                {
                    connection.Open();

                    using (var command = new OleDbCommand("SELECT * FROM Stock", connection))
                    {
                        var reader = command.ExecuteReader();
                        var currentStock = new Dictionary<string, int>();

                        reader.Read();

                        currentStock.Add("Synthroid", int.Parse(reader["Synthroid"].ToString()));
                        currentStock.Add("Crestor", int.Parse(reader["Crestor"].ToString()));
                        currentStock.Add("Nexium", int.Parse(reader["Nexium"].ToString()));
                        currentStock.Add("VentolinHFA", int.Parse(reader["VentolinHFA"].ToString()));
                        currentStock.Add("AdvairDiskus", int.Parse(reader["AdvairDiskus"].ToString()));

                        return currentStock;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        public static void AddToStock(int[] drugs)
        {
            try
            {
                var currentStock = new int[5];

                using (var connection = new OleDbConnection(Resources.ConnectionString))
                {
                    connection.Open();

                    using (var command = new OleDbCommand("SELECT * FROM Stock", connection))
                    {
                        var reader = command.ExecuteReader();

                        while (reader != null && reader.Read())
                        {
                            currentStock[0] = int.Parse(reader[0].ToString());
                            currentStock[1] = int.Parse(reader[1].ToString());
                            currentStock[2] = int.Parse(reader[2].ToString());
                            currentStock[3] = int.Parse(reader[3].ToString());
                            currentStock[4] = int.Parse(reader[4].ToString());
                        }
                    }

                    currentStock = currentStock.Zip(drugs, (a, b) => a + b).ToArray();

                    using (var command = new OleDbCommand("UPDATE Stock SET Synthroid = ?, Crestor = ?, Nexium = ?, VentolinHFA = ?, AdvairDiskus = ?", connection))
                    {
                        command.Parameters.AddWithValue("@Synthroid", currentStock[0]);
                        command.Parameters.AddWithValue("@Crestor", currentStock[1]);
                        command.Parameters.AddWithValue("@Nexium", currentStock[2]);
                        command.Parameters.AddWithValue("@VentolinHFA", currentStock[3]);
                        command.Parameters.AddWithValue("@AdvairDiskus", currentStock[4]);

                        command.ExecuteNonQuery();
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
