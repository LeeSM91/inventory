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
        MySqlConnection db = new MySqlConnection(@"Server=database-1.chaokiahnhcd.us-east-2.rds.amazonaws.com;Database=inventory;Uid=root;Pwd=123456789;");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            db.Open();

            string dbQuery      = "SELECT * FROM inventoryTB;";
            MySqlCommand cmd    = new MySqlCommand(dbQuery, db);
            MySqlDataAdapter dbAdapt = new MySqlDataAdapter(cmd);
            DataTable dt        = new DataTable();
            dbAdapt.Fill(dt);
            dataGridView1.DataSource = dt;
            db.Close();

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            db.Open();
            string  name        = productName.Text;
            string  madein      = productMaker.Text;
            string  makeyear    = productMakeYear.Text;
            string  price       = productPrice.Text;
            string  leaf        = productLeaf.Text;
            string  ect         = productEct.Text;
            string  ferment     = "생차";
            if (productSUC.Checked)
            {
                ferment = "숙차";

            }
            else if (productSANG.Checked)
            {
                ferment = "생차";

            }


            string dbQuery =    $"INSERT INTO `inventory`.`inventoryTB` (`name`, `madein`, `makeyear`, `price`, `leafmade`, `fermente`, `ect`) " +
                                $"VALUES ('{name}', '{madein}', '{makeyear}', '{price}', '{leaf}', '{ferment}', '{ect}');" +
                                "SELECT * FROM inventoryTB;";

            MySqlCommand cmd            = new MySqlCommand(dbQuery, db);
            MySqlDataAdapter dbAdapt    = new MySqlDataAdapter(cmd);
            DataTable dt                = new DataTable(); 
            dbAdapt.Fill(dt);
            dataGridView1.DataSource    = null;
            dataGridView1.DataSource    = dt;
            db.Close();

        }

        private void metroButton2_Click(object sender, EventArgs e)//신규 생성을 위한 빈 row 이동
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount-1].Cells[0];
            productName.Text = null;
            productMaker.Text = null;
            productMakeYear.Text = null;
            productPrice.Text = null;
            productLeaf.Text = null;
            productEct.Text = null;
            productSUC.Checked = false;
            productSANG.Checked = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex == dataGridView1.RowCount - 1)
            {
                productName.Text = null;
                productMaker.Text = null;
                productMakeYear.Text = null;
                productPrice.Text = null;
                productLeaf.Text = null;
                productEct.Text = null;
                productSUC.Checked = false;
                productSANG.Checked = false;
            }

            productName.Text        = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            productMaker.Text       = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            productMakeYear.Text    = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            productPrice.Text       = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            productLeaf.Text        = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();    
            productEct.Text         = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()=="숙차")
            {
                productSUC.Checked = true;
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() == "생차")
            {
                productSANG.Checked = true;

            }



        }
    }
}
