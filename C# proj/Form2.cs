using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trialbd0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost;database=studio;uid=root;pwd=Castraveteroz01#;";

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tableName = tableNameTextBox.Text;
            string columnName = columnNameTextBox.Text;
            string newValue = newValueTextBox.Text;
            string primaryKeyColumn = primaryKeyColumnTextBox.Text;
            string primaryKeyValue = primaryKeyValueTextBox.Text;

          
            string sql = "UPDATE " + tableName + " SET " + columnName + " = @newValue WHERE " + primaryKeyColumn + " = @primaryKeyValue";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@newValue", newValue);
                    command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);
                    int rowsAffected = command.ExecuteNonQuery();
                    outputTextBox.Text = rowsAffected + " rows affected.";
                }
            }


        }
    

        private void tableNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void columnNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TEST_Click(object sender, EventArgs e)
        {

        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            string tableName = tableNameTextBox1.Text;
            string primaryKeyColumn = primaryKeyColumnTextBox1.Text;
            string primaryKeyValue = primaryKeyValueTextBox1.Text;
            string sql = "DELETE FROM " + tableName + " WHERE " + primaryKeyColumn + " = @primaryKeyValue";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);
                    int rowsAffected = command.ExecuteNonQuery();
                    outputTextBox1.Text = rowsAffected + " rows affected.";
                }
            }
        }
    }
}
