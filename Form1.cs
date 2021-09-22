using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace inventory
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection db = new MySqlConnection(@"Server=database-1.chaokiahnhcd.us-east-2.rds.amazonaws.com;Database=inventory;Uid=root;Pwd=123456789;");

            db.Open();

            string dbQuery = "SELECT * FROM inventoryTB;";
            MySqlCommand cmd = new MySqlCommand(dbQuery, db);
            MySqlDataAdapter dbAdapt = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dbAdapt.Fill(dt);
            dataGridView1.DataSource = dt;
            db.Close();

        }
    }
}
