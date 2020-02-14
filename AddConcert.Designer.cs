namespace Piljetter
{
    partial class AddConcert
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
            this.listBoxCity = new System.Windows.Forms.ListBox();
            this.listBoxStage = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddConcert = new System.Windows.Forms.Button();
            this.listBoxArtist = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbTicketPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbConcertName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxCity
            // 
            this.listBoxCity.FormattingEnabled = true;
            this.listBoxCity.Location = new System.Drawing.Point(12, 64);
            this.listBoxCity.Name = "listBoxCity";
            this.listBoxCity.Size = new System.Drawing.Size(145, 173);
            this.listBoxCity.TabIndex = 0;
            this.listBoxCity.SelectedIndexChanged += new System.EventHandler(this.listBoxCity_SelectedIndexChanged);
            // 
            // listBoxStage
            // 
            this.listBoxStage.FormattingEnabled = true;
            this.listBoxStage.Location = new System.Drawing.Point(164, 64);
            this.listBoxStage.Name = "listBoxStage";
            this.listBoxStage.Size = new System.Drawing.Size(150, 173);
            this.listBoxStage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select city and stage";
            // 
            // btnAddConcert
            // 
            this.btnAddConcert.Location = new System.Drawing.Point(477, 190);
            this.btnAddConcert.Name = "btnAddConcert";
            this.btnAddConcert.Size = new System.Drawing.Size(169, 47);
            this.btnAddConcert.TabIndex = 3;
            this.btnAddConcert.Text = "Add Concert";
            this.btnAddConcert.UseVisualStyleBackColor = true;
            this.btnAddConcert.Click += new System.EventHandler(this.btnAddConcert_Click);
            // 
            // listBoxArtist
            // 
            this.listBoxArtist.FormattingEnabled = true;
            this.listBoxArtist.Location = new System.Drawing.Point(321, 64);
            this.listBoxArtist.Name = "listBoxArtist";
            this.listBoxArtist.Size = new System.Drawing.Size(150, 173);
            this.listBoxArtist.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(477, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // tbTicketPrice
            // 
            this.tbTicketPrice.Location = new System.Drawing.Point(477, 116);
            this.tbTicketPrice.Name = "tbTicketPrice";
            this.tbTicketPrice.Size = new System.Drawing.Size(168, 20);
            this.tbTicketPrice.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ticket price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Concert name:";
            // 
            // tbConcertName
            // 
            this.tbConcertName.Location = new System.Drawing.Point(479, 164);
            this.tbConcertName.Name = "tbConcertName";
            this.tbConcertName.Size = new System.Drawing.Size(168, 20);
            this.tbConcertName.TabIndex = 8;
            // 
            // AddConcert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 319);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbConcertName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTicketPrice);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBoxArtist);
            this.Controls.Add(this.btnAddConcert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxStage);
            this.Controls.Add(this.listBoxCity);
            this.Name = "AddConcert";
            this.Text = "AddConcert";
            this.Load += new System.EventHandler(this.AddConcert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCity;
        private System.Windows.Forms.ListBox listBoxStage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddConcert;
        private System.Windows.Forms.ListBox listBoxArtist;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbTicketPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbConcertName;
    }
}