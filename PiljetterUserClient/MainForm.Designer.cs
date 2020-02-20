namespace PiljetterUserClient
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
            this.btnSingUp = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbSearchCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchArtists = new System.Windows.Forms.TextBox();
            this.TbSearchArtist = new System.Windows.Forms.Label();
            this.tbSearchStages = new System.Windows.Forms.TextBox();
            this.tbSearchStage = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnBuyTicket = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colConcertName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAvaibleTickets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbConcertId = new System.Windows.Forms.TextBox();
            this.tabTicketsAndCoupons = new System.Windows.Forms.TabControl();
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.listBoxTickets = new System.Windows.Forms.ListBox();
            this.tabCoupons = new System.Windows.Forms.TabPage();
            this.listBoxCoupons = new System.Windows.Forms.ListBox();
            this.btnRefreshBalance = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.cbCoupon = new System.Windows.Forms.CheckBox();
            this.btnBuyPesetas = new System.Windows.Forms.Button();
            this.tbBuyPesetas = new System.Windows.Forms.TextBox();
            this.tabTicketsAndCoupons.SuspendLayout();
            this.tabTickets.SuspendLayout();
            this.tabCoupons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSingUp
            // 
            this.btnSingUp.Location = new System.Drawing.Point(18, 18);
            this.btnSingUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSingUp.Name = "btnSingUp";
            this.btnSingUp.Size = new System.Drawing.Size(212, 37);
            this.btnSingUp.TabIndex = 0;
            this.btnSingUp.Text = "Sign up";
            this.btnSingUp.UseVisualStyleBackColor = true;
            this.btnSingUp.Click += new System.EventHandler(this.btnSingUp_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(18, 65);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(212, 37);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 374);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search city";
            // 
            // TbSearchCity
            // 
            this.TbSearchCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSearchCity.Location = new System.Drawing.Point(432, 399);
            this.TbSearchCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbSearchCity.Name = "TbSearchCity";
            this.TbSearchCity.Size = new System.Drawing.Size(337, 35);
            this.TbSearchCity.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(776, 399);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 170);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearchArtists
            // 
            this.tbSearchArtists.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchArtists.Location = new System.Drawing.Point(432, 466);
            this.tbSearchArtists.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearchArtists.Name = "tbSearchArtists";
            this.tbSearchArtists.Size = new System.Drawing.Size(337, 35);
            this.tbSearchArtists.TabIndex = 7;
            // 
            // TbSearchArtist
            // 
            this.TbSearchArtist.AutoSize = true;
            this.TbSearchArtist.Location = new System.Drawing.Point(428, 440);
            this.TbSearchArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TbSearchArtist.Name = "TbSearchArtist";
            this.TbSearchArtist.Size = new System.Drawing.Size(99, 20);
            this.TbSearchArtist.TabIndex = 6;
            this.TbSearchArtist.Text = "Search artist";
            // 
            // tbSearchStages
            // 
            this.tbSearchStages.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchStages.Location = new System.Drawing.Point(432, 534);
            this.tbSearchStages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearchStages.Name = "tbSearchStages";
            this.tbSearchStages.Size = new System.Drawing.Size(337, 35);
            this.tbSearchStages.TabIndex = 9;
            // 
            // tbSearchStage
            // 
            this.tbSearchStage.AutoSize = true;
            this.tbSearchStage.Location = new System.Drawing.Point(428, 508);
            this.tbSearchStage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbSearchStage.Name = "tbSearchStage";
            this.tbSearchStage.Size = new System.Drawing.Size(104, 20);
            this.tbSearchStage.TabIndex = 8;
            this.tbSearchStage.Text = "Search stage";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(7, 161);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Location = new System.Drawing.Point(7, 77);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker3.TabIndex = 15;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(212, 80);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(167, 24);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Search on one date";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(212, 148);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(187, 24);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Search between dates";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(212, 17);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(141, 24);
            this.radioButton3.TabIndex = 20;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Search all dates";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.Location = new System.Drawing.Point(1076, 492);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(108, 62);
            this.btnBuyTicket.TabIndex = 21;
            this.btnBuyTicket.Text = "Buy ticket with ID";
            this.btnBuyTicket.UseVisualStyleBackColor = true;
            this.btnBuyTicket.Click += new System.EventHandler(this.btnBuyTicket_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(15, 121);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 31);
            this.lblUsername.TabIndex = 22;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblBalance.Location = new System.Drawing.Point(15, 171);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 31);
            this.lblBalance.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Avaible concerts:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colConcertName,
            this.colArtist,
            this.colCity,
            this.colStage,
            this.colDate,
            this.colPrice,
            this.colAvaibleTickets,
            this.colId});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 596);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1176, 231);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colConcertName
            // 
            this.colConcertName.Text = "Concert name";
            // 
            // colArtist
            // 
            this.colArtist.Text = "Artist";
            // 
            // colCity
            // 
            this.colCity.Text = "City";
            // 
            // colStage
            // 
            this.colStage.Text = "Stage";
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            // 
            // colAvaibleTickets
            // 
            this.colAvaibleTickets.Text = "Tickets left";
            // 
            // colId
            // 
            this.colId.Text = "Concert ID";
            // 
            // tbConcertId
            // 
            this.tbConcertId.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConcertId.Location = new System.Drawing.Point(997, 492);
            this.tbConcertId.Name = "tbConcertId";
            this.tbConcertId.Size = new System.Drawing.Size(73, 62);
            this.tbConcertId.TabIndex = 27;
            // 
            // tabTicketsAndCoupons
            // 
            this.tabTicketsAndCoupons.Controls.Add(this.tabTickets);
            this.tabTicketsAndCoupons.Controls.Add(this.tabCoupons);
            this.tabTicketsAndCoupons.Location = new System.Drawing.Point(422, 18);
            this.tabTicketsAndCoupons.Name = "tabTicketsAndCoupons";
            this.tabTicketsAndCoupons.SelectedIndex = 0;
            this.tabTicketsAndCoupons.Size = new System.Drawing.Size(673, 201);
            this.tabTicketsAndCoupons.TabIndex = 28;
            // 
            // tabTickets
            // 
            this.tabTickets.Controls.Add(this.listBoxTickets);
            this.tabTickets.Location = new System.Drawing.Point(4, 29);
            this.tabTickets.Name = "tabTickets";
            this.tabTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tabTickets.Size = new System.Drawing.Size(665, 168);
            this.tabTickets.TabIndex = 0;
            this.tabTickets.Text = "My tickets";
            this.tabTickets.UseVisualStyleBackColor = true;
            // 
            // listBoxTickets
            // 
            this.listBoxTickets.FormattingEnabled = true;
            this.listBoxTickets.ItemHeight = 20;
            this.listBoxTickets.Location = new System.Drawing.Point(3, 3);
            this.listBoxTickets.Name = "listBoxTickets";
            this.listBoxTickets.Size = new System.Drawing.Size(659, 164);
            this.listBoxTickets.TabIndex = 0;
            // 
            // tabCoupons
            // 
            this.tabCoupons.Controls.Add(this.listBoxCoupons);
            this.tabCoupons.Location = new System.Drawing.Point(4, 29);
            this.tabCoupons.Name = "tabCoupons";
            this.tabCoupons.Padding = new System.Windows.Forms.Padding(3);
            this.tabCoupons.Size = new System.Drawing.Size(665, 168);
            this.tabCoupons.TabIndex = 1;
            this.tabCoupons.Text = "My coupons";
            this.tabCoupons.UseVisualStyleBackColor = true;
            // 
            // listBoxCoupons
            // 
            this.listBoxCoupons.FormattingEnabled = true;
            this.listBoxCoupons.ItemHeight = 20;
            this.listBoxCoupons.Location = new System.Drawing.Point(3, 1);
            this.listBoxCoupons.Name = "listBoxCoupons";
            this.listBoxCoupons.Size = new System.Drawing.Size(662, 164);
            this.listBoxCoupons.TabIndex = 29;
            // 
            // btnRefreshBalance
            // 
            this.btnRefreshBalance.Location = new System.Drawing.Point(1101, 50);
            this.btnRefreshBalance.Name = "btnRefreshBalance";
            this.btnRefreshBalance.Size = new System.Drawing.Size(83, 162);
            this.btnRefreshBalance.TabIndex = 29;
            this.btnRefreshBalance.Text = "Refresh";
            this.btnRefreshBalance.UseVisualStyleBackColor = true;
            this.btnRefreshBalance.Click += new System.EventHandler(this.btnRefreshBalance_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(18, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 212);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Seach";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(237, 65);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(179, 37);
            this.btnLogOut.TabIndex = 31;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // cbCoupon
            // 
            this.cbCoupon.AutoSize = true;
            this.cbCoupon.Location = new System.Drawing.Point(997, 556);
            this.cbCoupon.Name = "cbCoupon";
            this.cbCoupon.Size = new System.Drawing.Size(196, 24);
            this.cbCoupon.TabIndex = 32;
            this.cbCoupon.Text = "Buy ticket using coupon";
            this.cbCoupon.UseVisualStyleBackColor = true;
            // 
            // btnBuyPesetas
            // 
            this.btnBuyPesetas.Location = new System.Drawing.Point(131, 271);
            this.btnBuyPesetas.Name = "btnBuyPesetas";
            this.btnBuyPesetas.Size = new System.Drawing.Size(179, 37);
            this.btnBuyPesetas.TabIndex = 33;
            this.btnBuyPesetas.Text = "Buy pesetas";
            this.btnBuyPesetas.UseVisualStyleBackColor = true;
            this.btnBuyPesetas.Click += new System.EventHandler(this.btnBuyPesetas_Click);
            // 
            // tbBuyPesetas
            // 
            this.tbBuyPesetas.Location = new System.Drawing.Point(18, 276);
            this.tbBuyPesetas.Name = "tbBuyPesetas";
            this.tbBuyPesetas.Size = new System.Drawing.Size(100, 26);
            this.tbBuyPesetas.TabIndex = 34;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 839);
            this.Controls.Add(this.tbBuyPesetas);
            this.Controls.Add(this.btnBuyPesetas);
            this.Controls.Add(this.cbCoupon);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefreshBalance);
            this.Controls.Add(this.tabTicketsAndCoupons);
            this.Controls.Add(this.tbConcertId);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnBuyTicket);
            this.Controls.Add(this.tbSearchStages);
            this.Controls.Add(this.tbSearchStage);
            this.Controls.Add(this.tbSearchArtists);
            this.Controls.Add(this.TbSearchArtist);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TbSearchCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSingUp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabTicketsAndCoupons.ResumeLayout(false);
            this.tabTickets.ResumeLayout(false);
            this.tabCoupons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSingUp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbSearchCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearchArtists;
        private System.Windows.Forms.Label TbSearchArtist;
        private System.Windows.Forms.TextBox tbSearchStages;
        private System.Windows.Forms.Label tbSearchStage;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnBuyTicket;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colConcertName;
        private System.Windows.Forms.ColumnHeader colArtist;
        private System.Windows.Forms.ColumnHeader colCity;
        private System.Windows.Forms.ColumnHeader colStage;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.TextBox tbConcertId;
        private System.Windows.Forms.TabControl tabTicketsAndCoupons;
        private System.Windows.Forms.TabPage tabTickets;
        private System.Windows.Forms.TabPage tabCoupons;
        private System.Windows.Forms.ListBox listBoxTickets;
        private System.Windows.Forms.ListBox listBoxCoupons;
        private System.Windows.Forms.Button btnRefreshBalance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.CheckBox cbCoupon;
        private System.Windows.Forms.ColumnHeader colAvaibleTickets;
        private System.Windows.Forms.Button btnBuyPesetas;
        private System.Windows.Forms.TextBox tbBuyPesetas;
    }
}

