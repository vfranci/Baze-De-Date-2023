using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace trialbd0


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost;database=studio;uid=root;pwd=Castraveteroz01#;";

        private void test_bts_Click(object sender, EventArgs e)
        {

            MySqlConnection cnn;
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                MessageBox.Show("V-ati conectat cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexiune esuata!");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            orderComboBox.DataSource = new List<string>() { "ascending", "descending" };
            orderComboBox.SelectedIndex = 0;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
      
            string tableName = tableNameTextBox.Text;
            string order = orderComboBox.SelectedValue.ToString();
            string orderByColumn = orderByColumnTextBox.Text;
            string sql = "SELECT * FROM " + tableName + " ORDER BY " + orderByColumn + " " + (order == "ascending" ? "ASC" : "DESC");
            

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);
                        dataGridView1.DataSource = table;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }

}
