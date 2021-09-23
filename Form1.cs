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
        MySqlConnection db = new MySqlConnection(@"Server=database-1.chaokiahnhcd.us-east-2.rds.amazonaws.com;Database=inventory;Uid=tea;Pwd=123456789;");
        bool blankCell = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            db.Open();//db 오픈
            //datagrideview1에 inventoryTB 정보를 띄우기 위한 쿼리 전송 및 datatable load 과정
            string dbQuery = "SELECT * FROM inventoryTB;";
            MySqlCommand cmd = new MySqlCommand(dbQuery, db);
            MySqlDataAdapter dbAdapt = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dbAdapt.Fill(dt);
            dataGridView1.DataSource = dt;
            db.Close();
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0];    //datagrideview 제일 밑칸으로 커서 이동

        }
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


        }

        public void wareColorChange()//셀 선택에서 보관창고 값을 읽어 보관창고 label의 fontcolor 변환, 창고보관장소를 표기함
        {
            switch (wareNumber.Text)
            {
                case "1":
                    label1.ForeColor = Color.Red;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label6.ForeColor = Color.Black;
                    break;
                case "2":
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Red;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label6.ForeColor = Color.Black;
                    break;
                case "3":
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Red;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label6.ForeColor = Color.Black;
                    break;
                case "4":
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Red;
                    label5.ForeColor = Color.Black;
                    label6.ForeColor = Color.Black;
                    break;
                case "5":
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Red;
                    label6.ForeColor = Color.Black;
                    break;
                case "6":
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label6.ForeColor = Color.Red;
                    break;

                default:
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label6.ForeColor = Color.Black;
                    break;
            }
        }

        private void metroButton3_Click(object sender, EventArgs e) //저장버튼
        {



            db.Open();
            //쿼리전송 전 textbox에 기입한 내용들 변수로 저장
            string name         = productName.Text;
            string  madein      = productMaker.Text;
            string  makeyear    = productMakeYear.Text;
            string  price       = productPrice.Text;
            string  leaf        = productLeaf.Text;
            string  ect         = productEct.Text;
            string  ferment     = "생차";
            string imgsrc       = @imgsrcSave.Text;
            string dbQuery      =   "";
            string ware = wareNumber.Text;
            if (productSUC.Checked)
            {
                ferment = "숙차"; //라디오박스 체크에 따른 변수값 설정

            }
            else if (productSANG.Checked)
            {
                ferment = "생차";

            }
            if (true)
            {

            }
            int currentRow = dataGridView1.CurrentCell.RowIndex;        //현재 선택된 grideview 위치 확인
            string num = dataGridView1.Rows[currentRow].Cells[0].Value.ToString();  //선택된 gridview의 num 확인(table의 primery 키 값)

            if (!blankCell)
            {   //선택된 datagridview에 기존 값이 존재할 경우 update로 값 수정
                dbQuery = $@"UPDATE `inventory`.`inventoryTB` " +
                            $@"SET `name`= '{name}', `madein`='{madein}',`makeyear`='{makeyear}',`price`='{price}', `leafmade`='{leaf}', `fermente` ='{ferment}', `ect`='{ect}',`imgsrc`='{imgsrc.Replace(@"\", @"\\")}',`ware`='{ware}' " +
                            $@"WHERE  `num`= {num}; "+
                            @"SELECT * FROM inventoryTB;";
            }
            else if (blankCell)
            {   //선택된 datagridview에 기존 값이 없을 경우 값 삽입(insert)
                dbQuery =           $@"INSERT INTO `inventory`.`inventoryTB` (`name`, `madein`, `makeyear`, `price`, `leafmade`, `fermente`, `ect`, `imgsrc`, `ware`) " +
                                    $@"VALUES ('{name}', '{madein}', '{makeyear}', '{price}', '{leaf}', '{ferment}', '{ect}', '{imgsrc.Replace(@"\", @"\\")}', {ware}); " +
                                    @"SELECT * FROM inventoryTB;";
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(dbQuery, db);
                MySqlDataAdapter dbAdapt = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dbAdapt.Fill(dt);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("기입이 완료되지 않은 정보가 있습니다");
            }


            db.Close();
            wareColorChange();

            //수행 완료 후 textbox를 비우고 셀 제일 아래칸으로 이동
            blankCell = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0];
            productName.Text        = null;
            productMaker.Text       = null;
            productMakeYear.Text    = null;
            productPrice.Text       = null;
            productLeaf.Text        = null;
            productEct.Text         = null;
            productSUC.Checked      = false;
            productSANG.Checked     = false;
            imgsrcSave.Text         = null;
            pictureBox1.Image       = null;
            wareNumber.Text = null;



        }

        private void metroButton2_Click(object sender, EventArgs e)//신규 생성을 위한 빈 row 이동
        {   //textbox를 비우고 셀 제일 아래칸으로 이동
            blankCell = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount-1].Cells[0];
            productName.Text        = null;
            productMaker.Text       = null;
            productMakeYear.Text    = null;
            productPrice.Text       = null;
            productLeaf.Text        = null;
            productEct.Text         = null;
            productSUC.Checked      = false;
            productSANG.Checked     = false;
            imgsrcSave.Text         = null;
            pictureBox1.Image       = null;
            wareNumber.Text = null;
            wareColorChange();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridView1.RowCount - 1)
            {   //textbox를 비움
                blankCell = true;

                productName.Text        = null;
                productMaker.Text       = null;
                productMakeYear.Text    = null;
                productPrice.Text       = null;
                productLeaf.Text        = null;
                productEct.Text         = null;
                productSUC.Checked      = false;
                productSANG.Checked     = false;
                imgsrcSave.Text         = null;
                pictureBox1.Image       = null;
                wareNumber.Text = null;
                wareColorChange();



            }
            if ((e.RowIndex != -1) && (e.RowIndex != dataGridView1.RowCount - 1))
            {   //선택된 셀 값을 textbox와 picturebox에 적용시켜 보여줌
                blankCell = false;

                productName.Text        = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                productMaker.Text       = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                productMakeYear.Text    = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                productPrice.Text       = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                productLeaf.Text        = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                productEct.Text         = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                imgsrcSave.Text         = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                wareNumber.Text         = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                string imgsrc = @dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                try
                {
                    if (imgsrc.Substring(0, 1) != "h")
                    {
                        Image img = Image.FromFile(@imgsrc);
                        pictureBox1.Image = img.GetThumbnailImage(200, 200, null, IntPtr.Zero);
                    }
                    else
                    {
                        pictureBox1.ImageLocation = imgsrc;//웹이미지용

                    }
                }
                catch (Exception)
                {
                    pictureBox1.Image = null;
                }




                //셀값에서 읽어와 라디오버튼 선택
                if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()=="숙차")
                {
                    productSUC.Checked = true;
                }
                else if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() == "생차")
                {
                    productSANG.Checked = true;
                }
                wareColorChange();


            }




        }

        private void deleteButton_Click(object sender, EventArgs e) //선택된 셀 삭제를위한 delete 버튼 작동
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;

            if (dataGridView1.Rows[currentRow].Cells[0].Value!=null)
            {
                string deleteCellnum    = dataGridView1.Rows[currentRow].Cells[0].Value.ToString();
                string dbQuery          = $"DELETE FROM `inventory`.`inventoryTB` WHERE  `num`= {deleteCellnum};"+ 
                                          "SELECT * FROM inventoryTB;";
                
                db.Open();
                MySqlCommand cmd            = new MySqlCommand(dbQuery, db);
                MySqlDataAdapter dbAdapt    = new MySqlDataAdapter(cmd);
                DataTable dt                = new DataTable();
                dbAdapt.Fill(dt);
                dataGridView1.DataSource    = null;
                dataGridView1.DataSource = dt;
                db.Close();
                wareColorChange();


            }


        }

        private void searchButton_Click(object sender, EventArgs e) //검색칸에 입력된 정보를 바탕으로 select구문 시행
        {
            string name     = searchName.Text;
            string madein   = searchMadein.Text;
            string makeyear = searchMadeyear.Text;
            string leaf     = searchLeaf.Text;

            db.Open();

            string dbQuery = "SELECT * FROM `inventory`.`inventoryTB` " +
                              $"WHERE name  LIKE '%{name}%' "+
                              "AND "+
                              $"madein      LIKE '%{madein}%' "+
                              "AND "+
                              $"makeyear    LIKE '%{makeyear}%' "+
                              "AND "+
                              $"leafmade    LIKE '%{leaf}%'; ";
            MySqlCommand cmd            = new MySqlCommand(dbQuery, db);
            MySqlDataAdapter dbAdapt    = new MySqlDataAdapter(cmd);
            DataTable dt                = new DataTable();
            dbAdapt.Fill(dt);
            dataGridView1.DataSource    = null;
            dataGridView1.DataSource    = dt;
            db.Close();
            wareColorChange();

        }

        private void metroButton4_Click(object sender, EventArgs e) //picturebox에 이미지경로를 탐색하여 바인딩
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title       = "이미지 파일 경로 설정";
            ofd.FileName    = "";
            ofd.Filter      = "그림 파일 (*.jpg, *.gif, *.png) | *.jpg; *.gif; *.png; | 모든 파일 (*.*) | *.*";

            //파일 오픈창 로드
            DialogResult dr = ofd.ShowDialog();

            //OK버튼 클릭시
            if (dr == DialogResult.OK)
            {

                //File경로와 File명
                string fileFullName = ofd.FileName;


                //출력 예제용 로직
                imgsrcSave.Text     = fileFullName;
                //File경로 + 파일명 리턴
                Image img           = Image.FromFile(@imgsrcSave.Text);
                pictureBox1.Image   = img.GetThumbnailImage(200, 200, null, IntPtr.Zero);

            }
            //취소버튼 클릭시 또는 ESC키로 파일창을 종료 했을경우
            else if (dr == DialogResult.Cancel)
            {
                
            }

            

        }
    }
}
