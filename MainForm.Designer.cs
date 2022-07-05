
namespace Rename
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.btSave = new XanderUI.XUIButton();
            this.lbN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btLoad = new XanderUI.XUIButton();
            this.tblRun = new System.Windows.Forms.TableLayoutPanel();
            this.btRun = new XanderUI.XUIButton();
            this.tblOption = new System.Windows.Forms.TableLayoutPanel();
            this.lbOption = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCharF = new System.Windows.Forms.TextBox();
            this.cbChapter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCharL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rdDefaut = new System.Windows.Forms.RadioButton();
            this.rdLast = new System.Windows.Forms.RadioButton();
            this.rdMid = new System.Windows.Forms.RadioButton();
            this.rdStart = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rdChar = new System.Windows.Forms.RadioButton();
            this.rdNumber = new System.Windows.Forms.RadioButton();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.tblMain.SuspendLayout();
            this.tblRun.SuspendLayout();
            this.tblOption.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.White;
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.21215F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.96341F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.82444F));
            this.tblMain.Controls.Add(this.btSave, 2, 1);
            this.tblMain.Controls.Add(this.lbN, 0, 0);
            this.tblMain.Controls.Add(this.label1, 0, 1);
            this.tblMain.Controls.Add(this.txtFile, 1, 0);
            this.tblMain.Controls.Add(this.txtSave, 1, 1);
            this.tblMain.Controls.Add(this.btLoad, 2, 0);
            this.tblMain.Controls.Add(this.tblRun, 1, 2);
            this.tblMain.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tblMain.Controls.Add(this.panel1, 2, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblMain.Size = new System.Drawing.Size(1083, 553);
            this.tblMain.TabIndex = 0;
            // 
            // btSave
            // 
            this.btSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btSave.ButtonImage = global::Rename.Properties.Resources.save_file;
            this.btSave.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btSave.ButtonText = "Save File";
            this.btSave.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btSave.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btSave.CornerRadius = 5;
            this.btSave.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btSave.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btSave.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btSave.Location = new System.Drawing.Point(883, 94);
            this.btSave.Margin = new System.Windows.Forms.Padding(27, 12, 27, 12);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(173, 58);
            this.btSave.TabIndex = 5;
            this.btSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbN
            // 
            this.lbN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbN.AutoSize = true;
            this.lbN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbN.Location = new System.Drawing.Point(50, 29);
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(176, 23);
            this.lbN.TabIndex = 0;
            this.lbN.Text = "Rename folder path";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Save folder path\r\n";
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.Location = new System.Drawing.Point(232, 27);
            this.txtFile.Margin = new System.Windows.Forms.Padding(3, 2, 8, 2);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(616, 27);
            this.txtFile.TabIndex = 2;
            this.txtFile.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
            // 
            // btLoad
            // 
            this.btLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLoad.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btLoad.ButtonImage = global::Rename.Properties.Resources.data_storage;
            this.btLoad.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btLoad.ButtonText = "Load File";
            this.btLoad.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btLoad.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btLoad.CornerRadius = 5;
            this.btLoad.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoad.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btLoad.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btLoad.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btLoad.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btLoad.Location = new System.Drawing.Point(883, 12);
            this.btLoad.Margin = new System.Windows.Forms.Padding(27, 12, 27, 12);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(173, 58);
            this.btLoad.TabIndex = 4;
            this.btLoad.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btLoad.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // tblRun
            // 
            this.tblRun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblRun.ColumnCount = 1;
            this.tblRun.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRun.Controls.Add(this.btRun, 0, 1);
            this.tblRun.Controls.Add(this.tblOption, 0, 0);
            this.tblRun.Location = new System.Drawing.Point(229, 164);
            this.tblRun.Margin = new System.Windows.Forms.Padding(0);
            this.tblRun.Name = "tblRun";
            this.tblRun.RowCount = 2;
            this.tblRun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.73016F));
            this.tblRun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.26984F));
            this.tblRun.Size = new System.Drawing.Size(627, 388);
            this.tblRun.TabIndex = 6;
            // 
            // btRun
            // 
            this.btRun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btRun.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btRun.ButtonImage = global::Rename.Properties.Resources.books;
            this.btRun.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btRun.ButtonText = "Run";
            this.btRun.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btRun.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btRun.CornerRadius = 5;
            this.btRun.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRun.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btRun.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btRun.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btRun.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btRun.Location = new System.Drawing.Point(207, 314);
            this.btRun.Margin = new System.Windows.Forms.Padding(207, 9, 207, 9);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(213, 65);
            this.btRun.TabIndex = 6;
            this.btRun.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btRun.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // tblOption
            // 
            this.tblOption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblOption.ColumnCount = 1;
            this.tblOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOption.Controls.Add(this.lbOption, 0, 0);
            this.tblOption.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tblOption.Location = new System.Drawing.Point(0, 1);
            this.tblOption.Margin = new System.Windows.Forms.Padding(0);
            this.tblOption.Name = "tblOption";
            this.tblOption.RowCount = 2;
            this.tblOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tblOption.Size = new System.Drawing.Size(627, 302);
            this.tblOption.TabIndex = 7;
            // 
            // lbOption
            // 
            this.lbOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbOption.AutoSize = true;
            this.lbOption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOption.Location = new System.Drawing.Point(236, 4);
            this.lbOption.Margin = new System.Windows.Forms.Padding(4);
            this.lbOption.Name = "lbOption";
            this.lbOption.Size = new System.Drawing.Size(155, 43);
            this.lbOption.TabIndex = 0;
            this.lbOption.Text = "Custom Name";
            this.lbOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.29787F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.70213F));
            this.tableLayoutPanel1.Controls.Add(this.txtCharF, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbChapter, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCharL, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 51);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 251);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtCharF
            // 
            this.txtCharF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCharF.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharF.Location = new System.Drawing.Point(248, 28);
            this.txtCharF.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.txtCharF.Name = "txtCharF";
            this.txtCharF.Size = new System.Drawing.Size(371, 27);
            this.txtCharF.TabIndex = 3;
            // 
            // cbChapter
            // 
            this.cbChapter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbChapter.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cbChapter.FormattingEnabled = true;
            this.cbChapter.Items.AddRange(new object[] {
            "Do not add 0 to the left",
            "<10",
            "<100",
            "<1000",
            "<10000",
            "<100000"});
            this.cbChapter.Location = new System.Drawing.Point(248, 195);
            this.cbChapter.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.cbChapter.Name = "cbChapter";
            this.cbChapter.Size = new System.Drawing.Size(371, 27);
            this.cbChapter.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "First letter";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Last letter";
            // 
            // txtCharL
            // 
            this.txtCharL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCharL.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharL.Location = new System.Drawing.Point(248, 111);
            this.txtCharL.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.txtCharL.Name = "txtCharL";
            this.txtCharL.Size = new System.Drawing.Size(371, 27);
            this.txtCharL.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of files \r\nneed to rename";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 164);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.65079F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.34921F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(229, 389);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 45);
            this.label4.TabIndex = 1;
            this.label4.Text = "Rename Option";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.rdDefaut, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.rdLast, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.rdMid, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.rdStart, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 53);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99937F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99937F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99937F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00188F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(229, 336);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // rdDefaut
            // 
            this.rdDefaut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdDefaut.AutoSize = true;
            this.rdDefaut.Location = new System.Drawing.Point(58, 282);
            this.rdDefaut.Margin = new System.Windows.Forms.Padding(4);
            this.rdDefaut.Name = "rdDefaut";
            this.rdDefaut.Size = new System.Drawing.Size(113, 21);
            this.rdDefaut.TabIndex = 3;
            this.rdDefaut.TabStop = true;
            this.rdDefaut.Text = "Default name";
            this.rdDefaut.UseVisualStyleBackColor = true;
            this.rdDefaut.CheckedChanged += new System.EventHandler(this.rdDefaut_CheckedChanged);
            // 
            // rdLast
            // 
            this.rdLast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdLast.AutoSize = true;
            this.rdLast.Location = new System.Drawing.Point(56, 188);
            this.rdLast.Margin = new System.Windows.Forms.Padding(4);
            this.rdLast.Name = "rdLast";
            this.rdLast.Size = new System.Drawing.Size(116, 38);
            this.rdLast.TabIndex = 2;
            this.rdLast.TabStop = true;
            this.rdLast.Text = "Insert number\r\nat the end";
            this.rdLast.UseVisualStyleBackColor = true;
            this.rdLast.CheckedChanged += new System.EventHandler(this.rdLast_CheckedChanged);
            // 
            // rdMid
            // 
            this.rdMid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdMid.AutoSize = true;
            this.rdMid.Location = new System.Drawing.Point(54, 105);
            this.rdMid.Margin = new System.Windows.Forms.Padding(4);
            this.rdMid.Name = "rdMid";
            this.rdMid.Size = new System.Drawing.Size(120, 38);
            this.rdMid.TabIndex = 1;
            this.rdMid.TabStop = true;
            this.rdMid.Text = "Insert number \r\nin the middle";
            this.rdMid.UseVisualStyleBackColor = true;
            this.rdMid.CheckedChanged += new System.EventHandler(this.rdMid_CheckedChanged);
            // 
            // rdStart
            // 
            this.rdStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdStart.AutoSize = true;
            this.rdStart.Location = new System.Drawing.Point(49, 22);
            this.rdStart.Margin = new System.Windows.Forms.Padding(4);
            this.rdStart.Name = "rdStart";
            this.rdStart.Size = new System.Drawing.Size(131, 38);
            this.rdStart.TabIndex = 0;
            this.rdStart.TabStop = true;
            this.rdStart.Text = "Insert number\r\nat the beginning";
            this.rdStart.UseVisualStyleBackColor = true;
            this.rdStart.CheckedChanged += new System.EventHandler(this.rdStart_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.rdAll);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rdChar);
            this.panel1.Controls.Add(this.rdNumber);
            this.panel1.Location = new System.Drawing.Point(856, 164);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 388);
            this.panel1.TabIndex = 8;
            // 
            // rdAll
            // 
            this.rdAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdAll.AutoSize = true;
            this.rdAll.Location = new System.Drawing.Point(27, 250);
            this.rdAll.Margin = new System.Windows.Forms.Padding(4);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(129, 21);
            this.rdAll.TabIndex = 3;
            this.rdAll.TabStop = true;
            this.rdAll.Text = "Rename all files";
            this.rdAll.UseVisualStyleBackColor = true;
            this.rdAll.CheckedChanged += new System.EventHandler(this.rdAll_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 52);
            this.label6.TabIndex = 2;
            this.label6.Text = "Choose folder\r\nrename type";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdChar
            // 
            this.rdChar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdChar.AutoSize = true;
            this.rdChar.Location = new System.Drawing.Point(27, 159);
            this.rdChar.Margin = new System.Windows.Forms.Padding(4);
            this.rdChar.Name = "rdChar";
            this.rdChar.Size = new System.Drawing.Size(157, 38);
            this.rdChar.TabIndex = 1;
            this.rdChar.TabStop = true;
            this.rdChar.Text = "Rename files only \r\nhave letters in name";
            this.rdChar.UseVisualStyleBackColor = true;
            this.rdChar.CheckedChanged += new System.EventHandler(this.rdChar_CheckedChanged);
            // 
            // rdNumber
            // 
            this.rdNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdNumber.AutoSize = true;
            this.rdNumber.Location = new System.Drawing.Point(27, 84);
            this.rdNumber.Margin = new System.Windows.Forms.Padding(4);
            this.rdNumber.Name = "rdNumber";
            this.rdNumber.Size = new System.Drawing.Size(156, 55);
            this.rdNumber.TabIndex = 0;
            this.rdNumber.TabStop = true;
            this.rdNumber.Text = "Rename files with \r\navailable number in \r\nfile name";
            this.rdNumber.UseVisualStyleBackColor = true;
            this.rdNumber.CheckedChanged += new System.EventHandler(this.rdNumber_CheckedChanged);
            // 
            // txtSave
            // 
            this.txtSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSave.Location = new System.Drawing.Point(232, 109);
            this.txtSave.Margin = new System.Windows.Forms.Padding(3, 2, 8, 2);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(616, 27);
            this.txtSave.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 553);
            this.Controls.Add(this.tblMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rename";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblRun.ResumeLayout(false);
            this.tblOption.ResumeLayout(false);
            this.tblOption.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Label lbN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFile;
        private XanderUI.XUIButton btSave;
        private XanderUI.XUIButton btLoad;
        private System.Windows.Forms.TableLayoutPanel tblRun;
        private XanderUI.XUIButton btRun;
        private System.Windows.Forms.TableLayoutPanel tblOption;
        private System.Windows.Forms.Label lbOption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCharF;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton rdLast;
        private System.Windows.Forms.RadioButton rdMid;
        private System.Windows.Forms.RadioButton rdStart;
        private System.Windows.Forms.RadioButton rdDefaut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbChapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCharL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdChar;
        private System.Windows.Forms.RadioButton rdNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdAll;
        private System.Windows.Forms.TextBox txtSave;
    }
}

