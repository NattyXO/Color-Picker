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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHexaCode = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor1 = new System.Windows.Forms.TextBox();
            this.txtColor2 = new System.Windows.Forms.TextBox();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.lblColor2 = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangetoBalck = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlColorRealTime = new System.Windows.Forms.Panel();
            this.lblHexaRealTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.picGithub = new System.Windows.Forms.PictureBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.picSearchButton = new System.Windows.Forms.PictureBox();
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(37, 464);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.04933F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.95067F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tableLayoutPanel1.Controls.Add(this.pnl2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHexaCode, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblColor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtColor1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtColor2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblColor1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblColor2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnl1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(411, 186);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pnl2
            // 
            this.pnl2.Location = new System.Drawing.Point(4, 115);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(85, 66);
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
            this.lblName.Location = new System.Drawing.Point(96, 1);
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
            this.lblHexaCode.Location = new System.Drawing.Point(217, 1);
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
            this.txtColor1.Location = new System.Drawing.Point(217, 40);
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
            this.txtColor2.Location = new System.Drawing.Point(217, 115);
            this.txtColor2.MaxLength = 7;
            this.txtColor2.Name = "txtColor2";
            this.txtColor2.Size = new System.Drawing.Size(132, 26);
            this.txtColor2.TabIndex = 4;
            this.txtColor2.Text = "#FFFF00";
            this.txtColor2.WordWrap = false;
            this.txtColor2.TextChanged += new System.EventHandler(this.txtColor2_TextChanged);
            // 
            // lblColor1
            // 
            this.lblColor1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblColor1.AutoSize = true;
            this.lblColor1.BackColor = System.Drawing.Color.Gray;
            this.lblColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblColor1.Location = new System.Drawing.Point(96, 37);
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
            this.lblColor2.Location = new System.Drawing.Point(96, 112);
            this.lblColor2.Name = "lblColor2";
            this.lblColor2.Size = new System.Drawing.Size(65, 24);
            this.lblColor2.TabIndex = 3;
            this.lblColor2.Text = "Name";
            this.lblColor2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl1
            // 
            this.pnl1.Location = new System.Drawing.Point(4, 40);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(85, 68);
            this.pnl1.TabIndex = 5;
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
            this.ChangetoBalck.Size = new System.Drawing.Size(160, 22);
            this.ChangetoBalck.Text = "Change to Balck";
            this.ChangetoBalck.Click += new System.EventHandler(this.ChangetoBalck_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // pnlColorRealTime
            // 
            this.pnlColorRealTime.Location = new System.Drawing.Point(0, 215);
            this.pnlColorRealTime.Name = "pnlColorRealTime";
            this.pnlColorRealTime.Size = new System.Drawing.Size(409, 201);
            this.pnlColorRealTime.TabIndex = 25;
            // 
            // lblHexaRealTime
            // 
            this.lblHexaRealTime.AutoSize = true;
            this.lblHexaRealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHexaRealTime.Location = new System.Drawing.Point(12, 424);
            this.lblHexaRealTime.Name = "lblHexaRealTime";
            this.lblHexaRealTime.Size = new System.Drawing.Size(43, 20);
            this.lblHexaRealTime.TabIndex = 26;
            this.lblHexaRealTime.Text = "hexa";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 39);
            this.label1.TabIndex = 27;
            this.label1.Text = "Click Ctrl + C at any time\r\nyou want to copy the value\r\nof the hexa color.";
            // 
            // picGithub
            // 
            this.picGithub.BackColor = System.Drawing.Color.DarkGray;
            this.picGithub.Image = global::color_picker.Properties.Resources.icons8_github_250;
            this.picGithub.Location = new System.Drawing.Point(334, 471);
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
            this.picAbout.Location = new System.Drawing.Point(376, 471);
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 468);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(409, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHexaRealTime);
            this.Controls.Add(this.pnlColorRealTime);
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
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picAbout;
        private System.Windows.Forms.PictureBox picGithub;
        private System.Windows.Forms.Label lblColor1;
        private System.Windows.Forms.Label lblColor2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox picSearchButton;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.TextBox txtColor2;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangetoBalck;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlColorRealTime;
        private System.Windows.Forms.Label lblHexaRealTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

