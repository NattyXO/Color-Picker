namespace color_picker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.picGithub = new System.Windows.Forms.PictureBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.picSearchButton = new System.Windows.Forms.PictureBox();
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHexaCode = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor1 = new System.Windows.Forms.TextBox();
            this.txtColor2 = new System.Windows.Forms.TextBox();
            this.txtColor3 = new System.Windows.Forms.TextBox();
            this.txtColor4 = new System.Windows.Forms.TextBox();
            this.txtColor5 = new System.Windows.Forms.TextBox();
            this.txtColor6 = new System.Windows.Forms.TextBox();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.lblColor2 = new System.Windows.Forms.Label();
            this.lblColor3 = new System.Windows.Forms.Label();
            this.lblColor4 = new System.Windows.Forms.Label();
            this.lblColor5 = new System.Windows.Forms.Label();
            this.lblColor6 = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangetoBalck = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(37, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Developed \r\nBy Ahadu Tech";
            this.toolTip1.SetToolTip(this.label4, "Visit our website");
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(223, 2);
            this.txtSearch.MaxLength = 32;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(153, 21);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Text = "    Search color\'s..";
            this.toolTip1.SetToolTip(this.txtSearch, "Insert The Name");
            this.txtSearch.WordWrap = false;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDown);
            // 
            // picGithub
            // 
            this.picGithub.BackColor = System.Drawing.Color.DarkGray;
            this.picGithub.Image = global::color_picker.Properties.Resources.icons8_github_250;
            this.picGithub.Location = new System.Drawing.Point(334, 487);
            this.picGithub.Name = "picGithub";
            this.picGithub.Size = new System.Drawing.Size(32, 26);
            this.picGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGithub.TabIndex = 8;
            this.picGithub.TabStop = false;
            this.toolTip1.SetToolTip(this.picGithub, "Contact with pinterest");
            this.picGithub.Click += new System.EventHandler(this.picGithub_Click);
            // 
            // picRefresh
            // 
            this.picRefresh.BackColor = System.Drawing.Color.White;
            this.picRefresh.Image = ((System.Drawing.Image)(resources.GetObject("picRefresh.Image")));
            this.picRefresh.Location = new System.Drawing.Point(94, 0);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(26, 24);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRefresh.TabIndex = 7;
            this.picRefresh.TabStop = false;
            this.toolTip1.SetToolTip(this.picRefresh, "Refresh");
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // picSearchButton
            // 
            this.picSearchButton.BackColor = System.Drawing.Color.White;
            this.picSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("picSearchButton.Image")));
            this.picSearchButton.Location = new System.Drawing.Point(379, -1);
            this.picSearchButton.Name = "picSearchButton";
            this.picSearchButton.Size = new System.Drawing.Size(26, 24);
            this.picSearchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearchButton.TabIndex = 7;
            this.picSearchButton.TabStop = false;
            this.toolTip1.SetToolTip(this.picSearchButton, "Find color\'s");
            this.picSearchButton.Click += new System.EventHandler(this.picSearchButton_Click);
            // 
            // picAbout
            // 
            this.picAbout.BackColor = System.Drawing.Color.DarkGray;
            this.picAbout.Image = ((System.Drawing.Image)(resources.GetObject("picAbout.Image")));
            this.picAbout.Location = new System.Drawing.Point(376, 487);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(32, 26);
            this.picAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAbout.TabIndex = 8;
            this.picAbout.TabStop = false;
            this.toolTip1.SetToolTip(this.picAbout, "Help");
            this.picAbout.Click += new System.EventHandler(this.picAbout_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.White;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(58, 0);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(26, 23);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 7;
            this.pictureBox11.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox11, "Setting");
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.04933F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.95067F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.Controls.Add(this.pnl6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.pnl5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.pnl4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pnl3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pnl2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHexaCode, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblColor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtColor1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtColor2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtColor3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtColor4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtColor5, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtColor6, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblColor1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblColor2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblColor3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblColor4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblColor5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblColor6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.pnl1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(411, 453);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pnl6
            // 
            this.pnl6.Location = new System.Drawing.Point(4, 398);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(87, 51);
            this.pnl6.TabIndex = 8;
            // 
            // pnl5
            // 
            this.pnl5.Location = new System.Drawing.Point(4, 336);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(87, 55);
            this.pnl5.TabIndex = 7;
            // 
            // pnl4
            // 
            this.pnl4.Location = new System.Drawing.Point(4, 265);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(87, 64);
            this.pnl4.TabIndex = 8;
            // 
            // pnl3
            // 
            this.pnl3.Location = new System.Drawing.Point(4, 195);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(87, 63);
            this.pnl3.TabIndex = 7;
            // 
            // pnl2
            // 
            this.pnl2.Location = new System.Drawing.Point(4, 122);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(87, 66);
            this.pnl2.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Gray;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(98, 1);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 24);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHexaCode
            // 
            this.lblHexaCode.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblHexaCode.AutoSize = true;
            this.lblHexaCode.BackColor = System.Drawing.Color.Gray;
            this.lblHexaCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHexaCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHexaCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHexaCode.Location = new System.Drawing.Point(223, 1);
            this.lblHexaCode.Name = "lblHexaCode";
            this.lblHexaCode.Size = new System.Drawing.Size(115, 24);
            this.lblHexaCode.TabIndex = 3;
            this.lblHexaCode.Text = "Hexa Code";
            this.lblHexaCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColor
            // 
            this.lblColor.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Gray;
            this.lblColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblColor.Location = new System.Drawing.Point(4, 1);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(60, 24);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Color";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtColor1
            // 
            this.txtColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor1.Location = new System.Drawing.Point(223, 42);
            this.txtColor1.MaxLength = 7;
            this.txtColor1.Name = "txtColor1";
            this.txtColor1.Size = new System.Drawing.Size(132, 26);
            this.txtColor1.TabIndex = 4;
            this.txtColor1.Text = "#CB4335";
            this.txtColor1.WordWrap = false;
            this.txtColor1.TextChanged += new System.EventHandler(this.txtColor1_TextChanged);
            // 
            // txtColor2
            // 
            this.txtColor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor2.Location = new System.Drawing.Point(223, 122);
            this.txtColor2.MaxLength = 7;
            this.txtColor2.Name = "txtColor2";
            this.txtColor2.Size = new System.Drawing.Size(132, 26);
            this.txtColor2.TabIndex = 4;
            this.txtColor2.Text = "#9B59B6";
            this.txtColor2.WordWrap = false;
            this.txtColor2.TextChanged += new System.EventHandler(this.txtColor2_TextChanged);
            // 
            // txtColor3
            // 
            this.txtColor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor3.Location = new System.Drawing.Point(223, 195);
            this.txtColor3.MaxLength = 7;
            this.txtColor3.Name = "txtColor3";
            this.txtColor3.Size = new System.Drawing.Size(132, 26);
            this.txtColor3.TabIndex = 4;
            this.txtColor3.Text = "#28B463";
            this.txtColor3.WordWrap = false;
            this.txtColor3.TextChanged += new System.EventHandler(this.txtColor3_TextChanged);
            // 
            // txtColor4
            // 
            this.txtColor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor4.Location = new System.Drawing.Point(223, 265);
            this.txtColor4.MaxLength = 7;
            this.txtColor4.Name = "txtColor4";
            this.txtColor4.Size = new System.Drawing.Size(132, 26);
            this.txtColor4.TabIndex = 4;
            this.txtColor4.Text = "#F4D03F";
            this.txtColor4.WordWrap = false;
            this.txtColor4.TextChanged += new System.EventHandler(this.txtColor4_TextChanged);
            // 
            // txtColor5
            // 
            this.txtColor5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor5.Location = new System.Drawing.Point(223, 336);
            this.txtColor5.MaxLength = 7;
            this.txtColor5.Name = "txtColor5";
            this.txtColor5.Size = new System.Drawing.Size(132, 26);
            this.txtColor5.TabIndex = 4;
            this.txtColor5.Text = "#D35400";
            this.txtColor5.WordWrap = false;
            this.txtColor5.TextChanged += new System.EventHandler(this.txtColor5_TextChanged);
            // 
            // txtColor6
            // 
            this.txtColor6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor6.Location = new System.Drawing.Point(223, 398);
            this.txtColor6.MaxLength = 7;
            this.txtColor6.Name = "txtColor6";
            this.txtColor6.Size = new System.Drawing.Size(132, 26);
            this.txtColor6.TabIndex = 4;
            this.txtColor6.Text = "#2C3E50";
            this.txtColor6.WordWrap = false;
            this.txtColor6.TextChanged += new System.EventHandler(this.txtColor6_TextChanged);
            // 
            // lblColor1
            // 
            this.lblColor1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblColor1.AutoSize = true;
            this.lblColor1.BackColor = System.Drawing.Color.Gray;
            this.lblColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblColor1.Location = new System.Drawing.Point(98, 39);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(65, 24);
            this.lblColor1.TabIndex = 3;
            this.lblColor1.Text = "Name";
            this.lblColor1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColor2
            // 
            this.lblColor2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblColor2.AutoSize = true;
            this.lblColor2.BackColor = System.Drawing.Color.Gray;
            this.lblColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblColor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblColor2.Location = new System.Drawing.Point(98, 119);
            this.lblColor2.Name = "lblColor2";
            this.lblColor2.Size = new System.Drawing.Size(65, 24);
            this.lblColor2.TabIndex = 3;
            this.lblColor2.Text = "Name";
            this.lblColor2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColor3
            // 
            this.lblColor3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblColor3.AutoSize = true;
            this.lblColor3.BackColor = System.Drawing.Color.Gray;
            this.lblColor3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblColor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblColor3.Location = new System.Drawing.Point(98, 192);
            this.lblColor3.Name = "lblColor3";
            this.lblColor3.Size = new System.Drawing.Size(65, 24);
            this.lblColor3.TabIndex = 3;
            this.lblColor3.Text = "Name";
            this.lblColor3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColor4
            // 
            this.lblColor4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblColor4.AutoSize = true;
            this.lblColor4.BackColor = System.Drawing.Color.Gray;
            this.lblColor4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblColor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblColor4.Location = new System.Drawing.Point(98, 262);
            this.lblColor4.Name = "lblColor4";
            this.lblColor4.Size = new System.Drawing.Size(65, 24);
            this.lblColor4.TabIndex = 3;
            this.lblColor4.Text = "Name";
            this.lblColor4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColor5
            // 
            this.lblColor5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblColor5.AutoSize = true;
            this.lblColor5.BackColor = System.Drawing.Color.Gray;
            this.lblColor5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblColor5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblColor5.Location = new System.Drawing.Point(98, 333);
            this.lblColor5.Name = "lblColor5";
            this.lblColor5.Size = new System.Drawing.Size(65, 24);
            this.lblColor5.TabIndex = 3;
            this.lblColor5.Text = "Name";
            this.lblColor5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColor6
            // 
            this.lblColor6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblColor6.AutoSize = true;
            this.lblColor6.BackColor = System.Drawing.Color.Gray;
            this.lblColor6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblColor6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblColor6.Location = new System.Drawing.Point(98, 395);
            this.lblColor6.Name = "lblColor6";
            this.lblColor6.Size = new System.Drawing.Size(65, 24);
            this.lblColor6.TabIndex = 3;
            this.lblColor6.Text = "Name";
            this.lblColor6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl1
            // 
            this.pnl1.Location = new System.Drawing.Point(4, 42);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(87, 73);
            this.pnl1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 484);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(409, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangetoBalck,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // ChangetoBalck
            // 
            this.ChangetoBalck.Name = "ChangetoBalck";
            this.ChangetoBalck.Size = new System.Drawing.Size(180, 22);
            this.ChangetoBalck.Text = "Change to Balck";
            this.ChangetoBalck.Click += new System.EventHandler(this.ChangetoBalck_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(409, 516);
            this.Controls.Add(this.picGithub);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.picSearchButton);
            this.Controls.Add(this.picAbout);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHexaCode;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor1;
        private System.Windows.Forms.TextBox txtColor3;
        private System.Windows.Forms.TextBox txtColor4;
        private System.Windows.Forms.TextBox txtColor5;
        private System.Windows.Forms.TextBox txtColor6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picAbout;
        private System.Windows.Forms.PictureBox picGithub;
        private System.Windows.Forms.Label lblColor1;
        private System.Windows.Forms.Label lblColor2;
        private System.Windows.Forms.Label lblColor3;
        private System.Windows.Forms.Label lblColor4;
        private System.Windows.Forms.Label lblColor5;
        private System.Windows.Forms.Label lblColor6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox picSearchButton;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.TextBox txtColor2;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangetoBalck;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}

