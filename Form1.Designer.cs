
namespace inventory
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.searchName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.searchMadein = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.searchMadeyear = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.searchLeaf = new MetroFramework.Controls.MetroTextBox();
            this.searchButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.productName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.productMaker = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.productMakeYear = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.productPrice = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productEct = new MetroFramework.Controls.MetroTextBox();
            this.productLeaf = new MetroFramework.Controls.MetroTextBox();
            this.productSANG = new MetroFramework.Controls.MetroRadioButton();
            this.productSUC = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.newButton = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(751, 565);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "제품명";
            // 
            // searchName
            // 
            // 
            // 
            // 
            this.searchName.CustomButton.Image = null;
            this.searchName.CustomButton.Location = new System.Drawing.Point(77, 1);
            this.searchName.CustomButton.Name = "";
            this.searchName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchName.CustomButton.TabIndex = 1;
            this.searchName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchName.CustomButton.UseSelectable = true;
            this.searchName.CustomButton.Visible = false;
            this.searchName.Lines = new string[0];
            this.searchName.Location = new System.Drawing.Point(81, 82);
            this.searchName.MaxLength = 32767;
            this.searchName.Name = "searchName";
            this.searchName.PasswordChar = '\0';
            this.searchName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchName.SelectedText = "";
            this.searchName.SelectionLength = 0;
            this.searchName.SelectionStart = 0;
            this.searchName.ShortcutsEnabled = true;
            this.searchName.Size = new System.Drawing.Size(99, 23);
            this.searchName.TabIndex = 2;
            this.searchName.UseSelectable = true;
            this.searchName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(186, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "차창";
            // 
            // searchMadein
            // 
            // 
            // 
            // 
            this.searchMadein.CustomButton.Image = null;
            this.searchMadein.CustomButton.Location = new System.Drawing.Point(77, 1);
            this.searchMadein.CustomButton.Name = "";
            this.searchMadein.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchMadein.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchMadein.CustomButton.TabIndex = 1;
            this.searchMadein.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchMadein.CustomButton.UseSelectable = true;
            this.searchMadein.CustomButton.Visible = false;
            this.searchMadein.Lines = new string[0];
            this.searchMadein.Location = new System.Drawing.Point(229, 82);
            this.searchMadein.MaxLength = 32767;
            this.searchMadein.Name = "searchMadein";
            this.searchMadein.PasswordChar = '\0';
            this.searchMadein.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchMadein.SelectedText = "";
            this.searchMadein.SelectionLength = 0;
            this.searchMadein.SelectionStart = 0;
            this.searchMadein.ShortcutsEnabled = true;
            this.searchMadein.Size = new System.Drawing.Size(99, 23);
            this.searchMadein.TabIndex = 2;
            this.searchMadein.UseSelectable = true;
            this.searchMadein.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchMadein.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(334, 82);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "생산년도";
            // 
            // searchMadeyear
            // 
            // 
            // 
            // 
            this.searchMadeyear.CustomButton.Image = null;
            this.searchMadeyear.CustomButton.Location = new System.Drawing.Point(77, 1);
            this.searchMadeyear.CustomButton.Name = "";
            this.searchMadeyear.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchMadeyear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchMadeyear.CustomButton.TabIndex = 1;
            this.searchMadeyear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchMadeyear.CustomButton.UseSelectable = true;
            this.searchMadeyear.CustomButton.Visible = false;
            this.searchMadeyear.Lines = new string[0];
            this.searchMadeyear.Location = new System.Drawing.Point(405, 82);
            this.searchMadeyear.MaxLength = 32767;
            this.searchMadeyear.Name = "searchMadeyear";
            this.searchMadeyear.PasswordChar = '\0';
            this.searchMadeyear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchMadeyear.SelectedText = "";
            this.searchMadeyear.SelectionLength = 0;
            this.searchMadeyear.SelectionStart = 0;
            this.searchMadeyear.ShortcutsEnabled = true;
            this.searchMadeyear.Size = new System.Drawing.Size(99, 23);
            this.searchMadeyear.TabIndex = 2;
            this.searchMadeyear.UseSelectable = true;
            this.searchMadeyear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchMadeyear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(510, 82);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "찻잎산지";
            // 
            // searchLeaf
            // 
            // 
            // 
            // 
            this.searchLeaf.CustomButton.Image = null;
            this.searchLeaf.CustomButton.Location = new System.Drawing.Point(77, 1);
            this.searchLeaf.CustomButton.Name = "";
            this.searchLeaf.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchLeaf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchLeaf.CustomButton.TabIndex = 1;
            this.searchLeaf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchLeaf.CustomButton.UseSelectable = true;
            this.searchLeaf.CustomButton.Visible = false;
            this.searchLeaf.Lines = new string[0];
            this.searchLeaf.Location = new System.Drawing.Point(581, 82);
            this.searchLeaf.MaxLength = 32767;
            this.searchLeaf.Name = "searchLeaf";
            this.searchLeaf.PasswordChar = '\0';
            this.searchLeaf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchLeaf.SelectedText = "";
            this.searchLeaf.SelectionLength = 0;
            this.searchLeaf.SelectionStart = 0;
            this.searchLeaf.ShortcutsEnabled = true;
            this.searchLeaf.Size = new System.Drawing.Size(99, 23);
            this.searchLeaf.TabIndex = 2;
            this.searchLeaf.UseSelectable = true;
            this.searchLeaf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchLeaf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(690, 82);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(84, 31);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "검색";
            this.searchButton.UseSelectable = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 219);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(75, 17);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "제품명";
            // 
            // productName
            // 
            // 
            // 
            // 
            this.productName.CustomButton.Image = null;
            this.productName.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.productName.CustomButton.Name = "";
            this.productName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.productName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.productName.CustomButton.TabIndex = 1;
            this.productName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.productName.CustomButton.UseSelectable = true;
            this.productName.CustomButton.Visible = false;
            this.productName.Lines = new string[0];
            this.productName.Location = new System.Drawing.Point(14, 39);
            this.productName.MaxLength = 32767;
            this.productName.Name = "productName";
            this.productName.PasswordChar = '\0';
            this.productName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.productName.SelectedText = "";
            this.productName.SelectionLength = 0;
            this.productName.SelectionStart = 0;
            this.productName.ShortcutsEnabled = true;
            this.productName.Size = new System.Drawing.Size(176, 23);
            this.productName.TabIndex = 2;
            this.productName.UseSelectable = true;
            this.productName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.productName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(71, 77);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(69, 19);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "제조 차창";
            // 
            // productMaker
            // 
            // 
            // 
            // 
            this.productMaker.CustomButton.Image = null;
            this.productMaker.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.productMaker.CustomButton.Name = "";
            this.productMaker.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.productMaker.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.productMaker.CustomButton.TabIndex = 1;
            this.productMaker.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.productMaker.CustomButton.UseSelectable = true;
            this.productMaker.CustomButton.Visible = false;
            this.productMaker.Lines = new string[0];
            this.productMaker.Location = new System.Drawing.Point(14, 99);
            this.productMaker.MaxLength = 32767;
            this.productMaker.Name = "productMaker";
            this.productMaker.PasswordChar = '\0';
            this.productMaker.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.productMaker.SelectedText = "";
            this.productMaker.SelectionLength = 0;
            this.productMaker.SelectionStart = 0;
            this.productMaker.ShortcutsEnabled = true;
            this.productMaker.Size = new System.Drawing.Size(176, 23);
            this.productMaker.TabIndex = 3;
            this.productMaker.UseSelectable = true;
            this.productMaker.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.productMaker.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(71, 139);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(65, 19);
            this.metroLabel7.TabIndex = 1;
            this.metroLabel7.Text = "생산년도";
            // 
            // productMakeYear
            // 
            // 
            // 
            // 
            this.productMakeYear.CustomButton.Image = null;
            this.productMakeYear.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.productMakeYear.CustomButton.Name = "";
            this.productMakeYear.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.productMakeYear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.productMakeYear.CustomButton.TabIndex = 1;
            this.productMakeYear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.productMakeYear.CustomButton.UseSelectable = true;
            this.productMakeYear.CustomButton.Visible = false;
            this.productMakeYear.Lines = new string[0];
            this.productMakeYear.Location = new System.Drawing.Point(14, 161);
            this.productMakeYear.MaxLength = 32767;
            this.productMakeYear.Name = "productMakeYear";
            this.productMakeYear.PasswordChar = '\0';
            this.productMakeYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.productMakeYear.SelectedText = "";
            this.productMakeYear.SelectionLength = 0;
            this.productMakeYear.SelectionStart = 0;
            this.productMakeYear.ShortcutsEnabled = true;
            this.productMakeYear.Size = new System.Drawing.Size(176, 23);
            this.productMakeYear.TabIndex = 4;
            this.productMakeYear.UseSelectable = true;
            this.productMakeYear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.productMakeYear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(67, 203);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(73, 19);
            this.metroLabel8.TabIndex = 1;
            this.metroLabel8.Text = "단가(소매)";
            // 
            // productPrice
            // 
            // 
            // 
            // 
            this.productPrice.CustomButton.Image = null;
            this.productPrice.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.productPrice.CustomButton.Name = "";
            this.productPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.productPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.productPrice.CustomButton.TabIndex = 1;
            this.productPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.productPrice.CustomButton.UseSelectable = true;
            this.productPrice.CustomButton.Visible = false;
            this.productPrice.Lines = new string[0];
            this.productPrice.Location = new System.Drawing.Point(14, 225);
            this.productPrice.MaxLength = 32767;
            this.productPrice.Name = "productPrice";
            this.productPrice.PasswordChar = '\0';
            this.productPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.productPrice.SelectedText = "";
            this.productPrice.SelectionLength = 0;
            this.productPrice.SelectionStart = 0;
            this.productPrice.ShortcutsEnabled = true;
            this.productPrice.Size = new System.Drawing.Size(176, 23);
            this.productPrice.TabIndex = 5;
            this.productPrice.UseSelectable = true;
            this.productPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.productPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.productName);
            this.groupBox1.Controls.Add(this.productPrice);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.productMakeYear);
            this.groupBox1.Controls.Add(this.productMaker);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Location = new System.Drawing.Point(1059, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 269);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "기본정보";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.productEct);
            this.groupBox2.Controls.Add(this.productLeaf);
            this.groupBox2.Controls.Add(this.productSANG);
            this.groupBox2.Controls.Add(this.productSUC);
            this.groupBox2.Controls.Add(this.metroLabel12);
            this.groupBox2.Controls.Add(this.metroLabel11);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Location = new System.Drawing.Point(809, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 290);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "상세정보";
            // 
            // productEct
            // 
            // 
            // 
            // 
            this.productEct.CustomButton.Image = null;
            this.productEct.CustomButton.Location = new System.Drawing.Point(343, 1);
            this.productEct.CustomButton.Name = "";
            this.productEct.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.productEct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.productEct.CustomButton.TabIndex = 1;
            this.productEct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.productEct.CustomButton.UseSelectable = true;
            this.productEct.CustomButton.Visible = false;
            this.productEct.Lines = new string[0];
            this.productEct.Location = new System.Drawing.Point(75, 61);
            this.productEct.MaxLength = 32767;
            this.productEct.Name = "productEct";
            this.productEct.PasswordChar = '\0';
            this.productEct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.productEct.SelectedText = "";
            this.productEct.SelectionLength = 0;
            this.productEct.SelectionStart = 0;
            this.productEct.ShortcutsEnabled = true;
            this.productEct.Size = new System.Drawing.Size(365, 23);
            this.productEct.TabIndex = 8;
            this.productEct.UseSelectable = true;
            this.productEct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.productEct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // productLeaf
            // 
            // 
            // 
            // 
            this.productLeaf.CustomButton.Image = null;
            this.productLeaf.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.productLeaf.CustomButton.Name = "";
            this.productLeaf.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.productLeaf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.productLeaf.CustomButton.TabIndex = 1;
            this.productLeaf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.productLeaf.CustomButton.UseSelectable = true;
            this.productLeaf.CustomButton.Visible = false;
            this.productLeaf.Lines = new string[0];
            this.productLeaf.Location = new System.Drawing.Point(283, 26);
            this.productLeaf.MaxLength = 32767;
            this.productLeaf.Name = "productLeaf";
            this.productLeaf.PasswordChar = '\0';
            this.productLeaf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.productLeaf.SelectedText = "";
            this.productLeaf.SelectionLength = 0;
            this.productLeaf.SelectionStart = 0;
            this.productLeaf.ShortcutsEnabled = true;
            this.productLeaf.Size = new System.Drawing.Size(157, 23);
            this.productLeaf.TabIndex = 7;
            this.productLeaf.UseSelectable = true;
            this.productLeaf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.productLeaf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // productSANG
            // 
            this.productSANG.AutoSize = true;
            this.productSANG.Location = new System.Drawing.Point(143, 29);
            this.productSANG.Name = "productSANG";
            this.productSANG.Size = new System.Drawing.Size(47, 15);
            this.productSANG.TabIndex = 3;
            this.productSANG.Text = "생차";
            this.productSANG.UseSelectable = true;
            // 
            // productSUC
            // 
            this.productSUC.AutoSize = true;
            this.productSUC.Location = new System.Drawing.Point(90, 29);
            this.productSUC.Name = "productSUC";
            this.productSUC.Size = new System.Drawing.Size(47, 15);
            this.productSUC.TabIndex = 6;
            this.productSUC.Text = "숙차";
            this.productSUC.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(195, 99);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(65, 19);
            this.metroLabel12.TabIndex = 1;
            this.metroLabel12.Text = "보관장소";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(18, 61);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(37, 19);
            this.metroLabel11.TabIndex = 1;
            this.metroLabel11.Text = "비고";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(208, 25);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(69, 19);
            this.metroLabel10.TabIndex = 1;
            this.metroLabel10.Text = "찻잎 산지";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(18, 26);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(65, 19);
            this.metroLabel9.TabIndex = 1;
            this.metroLabel9.Text = "발효방식";
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(809, 82);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(84, 31);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "신규";
            this.newButton.UseSelectable = true;
            this.newButton.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(1175, 82);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(84, 31);
            this.metroButton3.TabIndex = 3;
            this.metroButton3.Text = "저장";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.metroButton4);
            this.groupBox3.Location = new System.Drawing.Point(809, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 269);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "사진";
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(90, 245);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(145, 18);
            this.metroButton4.TabIndex = 3;
            this.metroButton4.Text = "이미지 경로";
            this.metroButton4.UseSelectable = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(915, 82);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(84, 31);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "삭제";
            this.deleteButton.UseSelectable = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 707);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchLeaf);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.searchMadeyear);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.searchMadein);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "산중명월 보이차 재고관리 프로그램";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox searchName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox searchMadein;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox searchMadeyear;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox searchLeaf;
        private MetroFramework.Controls.MetroButton searchButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox productName;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox productMaker;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox productMakeYear;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox productPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox productEct;
        private MetroFramework.Controls.MetroTextBox productLeaf;
        private MetroFramework.Controls.MetroRadioButton productSANG;
        private MetroFramework.Controls.MetroRadioButton productSUC;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton newButton;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton deleteButton;
    }
}

