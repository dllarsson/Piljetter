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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnBuyTicket = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gwConcert = new System.Windows.Forms.DataGridView();
            this.ConcertName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConcertDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConcertPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gwConcert)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSingUp
            // 
            this.btnSingUp.Location = new System.Drawing.Point(18, 18);
            this.btnSingUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSingUp.Name = "btnSingUp";
            this.btnSingUp.Size = new System.Drawing.Size(212, 108);
            this.btnSingUp.TabIndex = 0;
            this.btnSingUp.Text = "Sign up";
            this.btnSingUp.UseVisualStyleBackColor = true;
            this.btnSingUp.Click += new System.EventHandler(this.btnSingUp_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(238, 18);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(212, 108);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search city";
            // 
            // TbSearchCity
            // 
            this.TbSearchCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSearchCity.Location = new System.Drawing.Point(462, 44);
            this.TbSearchCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbSearchCity.Name = "TbSearchCity";
            this.TbSearchCity.Size = new System.Drawing.Size(424, 40);
            this.TbSearchCity.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(893, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(193, 179);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearchArtists
            // 
            this.tbSearchArtists.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchArtists.Location = new System.Drawing.Point(464, 112);
            this.tbSearchArtists.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearchArtists.Name = "tbSearchArtists";
            this.tbSearchArtists.Size = new System.Drawing.Size(424, 40);
            this.tbSearchArtists.TabIndex = 7;
            // 
            // TbSearchArtist
            // 
            this.TbSearchArtist.AutoSize = true;
            this.TbSearchArtist.Location = new System.Drawing.Point(460, 86);
            this.TbSearchArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TbSearchArtist.Name = "TbSearchArtist";
            this.TbSearchArtist.Size = new System.Drawing.Size(99, 20);
            this.TbSearchArtist.TabIndex = 6;
            this.TbSearchArtist.Text = "Search artist";
            // 
            // tbSearchStages
            // 
            this.tbSearchStages.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchStages.Location = new System.Drawing.Point(464, 183);
            this.tbSearchStages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearchStages.Name = "tbSearchStages";
            this.tbSearchStages.Size = new System.Drawing.Size(424, 40);
            this.tbSearchStages.TabIndex = 9;
            // 
            // tbSearchStage
            // 
            this.tbSearchStage.AutoSize = true;
            this.tbSearchStage.Location = new System.Drawing.Point(460, 157);
            this.tbSearchStage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbSearchStage.Name = "tbSearchStage";
            this.tbSearchStage.Size = new System.Drawing.Size(104, 20);
            this.tbSearchStage.TabIndex = 8;
            this.tbSearchStage.Text = "Search stage";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 313);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 370);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "To";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Location = new System.Drawing.Point(12, 225);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker3.TabIndex = 15;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Search specific date";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(219, 233);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(174, 24);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Search Specific date";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(219, 347);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(143, 24);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Search Interaval";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(219, 155);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(143, 24);
            this.radioButton3.TabIndex = 20;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Search any date";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.Location = new System.Drawing.Point(723, 534);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(163, 62);
            this.btnBuyTicket.TabIndex = 21;
            this.btnBuyTicket.Text = "Buy ticket for selected concert";
            this.btnBuyTicket.UseVisualStyleBackColor = true;
            this.btnBuyTicket.Click += new System.EventHandler(this.btnBuyTicket_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(719, 438);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 22;
            this.lblUsername.Text = "Username";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(719, 458);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(67, 20);
            this.lblBalance.TabIndex = 23;
            this.lblBalance.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Avaible concerts:";
            // 
            // gwConcert
            // 
            this.gwConcert.AllowUserToDeleteRows = false;
            this.gwConcert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwConcert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConcertName,
            this.ConcertDate,
            this.ConcertPrice});
            this.gwConcert.Location = new System.Drawing.Point(18, 438);
            this.gwConcert.MultiSelect = false;
            this.gwConcert.Name = "gwConcert";
            this.gwConcert.Size = new System.Drawing.Size(695, 242);
            this.gwConcert.TabIndex = 26;
            // 
            // ConcertName
            // 
            this.ConcertName.HeaderText = "Concert";
            this.ConcertName.Name = "ConcertName";
            // 
            // ConcertDate
            // 
            this.ConcertDate.HeaderText = "Date";
            this.ConcertDate.Name = "ConcertDate";
            // 
            // ConcertPrice
            // 
            this.ConcertPrice.HeaderText = "Pesetas";
            this.ConcertPrice.Name = "ConcertPrice";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.gwConcert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnBuyTicket);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
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
            ((System.ComponentModel.ISupportInitialize)(this.gwConcert)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnBuyTicket;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gwConcert;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConcertName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConcertDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConcertPrice;
    }
}

