using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hakaton.Classes
{
    internal class DataBase
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S21HR1A;Initial Catalog=bd;Integrated Security=True");

        static public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        static public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }

        static public SqlConnection getConnection()
        {
            return con;
        }

        static public void LoadKatalogSaller(ComboBox typeComboBox)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataBase.con.ConnectionString))
                {
                    connection.Open();
                    string queryType = "SELECT * FROM Saller";
                    using (SqlCommand commandType = new SqlCommand(queryType, connection))
                    {
                        using (SqlDataReader readerType = commandType.ExecuteReader())
                        {
                            if (readerType.HasRows)
                            {
                                while (readerType.Read())
                                {
                                    typeComboBox.Items.Add(readerType["Saller"]);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке списка типов товара: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public void LoadKatalogName(ComboBox typeComboBox)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataBase.con.ConnectionString))
                {
                    connection.Open();
                    string queryType = "SELECT * FROM Name";
                    using (SqlCommand commandType = new SqlCommand(queryType, connection))
                    {
                        using (SqlDataReader readerType = commandType.ExecuteReader())
                        {
                            if (readerType.HasRows)
                            {
                                while (readerType.Read())
                                {
                                    typeComboBox.Items.Add(readerType["Name"]);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке списка типов товара: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
