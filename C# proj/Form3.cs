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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        string connectionString = "server=localhost;database=studio;uid=root;pwd=Castraveteroz01#;";
        private void test_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "SELECT * FROM studio.elevi JOIN studio.inscrieri USING(id_elev) JOIN studio.cursuri using(id_curs) WHERE elevi.id_elev > 102 AND cursuri.cost_curs = 800";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                 

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable result = new DataTable();
                        adapter.Fill(result);
                        outputTextBox.DataSource = result;
                        outputTextBox.Text = result.Rows.Count + " rows found.";
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string sql = "SELECT id_locatie, COUNT(id_curs) as count FROM studio.cursuri GROUP BY id_locatie HAVING id_locatie = 200;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable result = new DataTable();
                        adapter.Fill(result);
                        dataGridView1.DataSource = result;
                    }
                }
            }
        }
    }
}
