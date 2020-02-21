namespace Piljetter
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
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.HName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Concert_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pesetasCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isCanceled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddConcert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelConcert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbConcertId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPesetasFromTickets = new System.Windows.Forms.TextBox();
            this.tbSoldTickets = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoldTickets = new System.Windows.Forms.Label();
            this.btnGetSoldTickets = new System.Windows.Forms.Button();
            this.timeTo = new System.Windows.Forms.DateTimePicker();
            this.timeFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbTicketsToMakeProfits = new System.Windows.Forms.TextBox();
            this.tbProfits = new System.Windows.Forms.TextBox();
            this.tbIncome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbConcertId2 = new System.Windows.Forms.TextBox();
            this.tbVenuecost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HName,
            this.Concert_Id,
            this.price,
            this.pesetasCol,
            this.isCanceled});
            this.listViewUsers.HideSelection = false;
            this.listViewUsers.Location = new System.Drawing.Point(12, 54);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(559, 200);
            this.listViewUsers.TabIndex = 4;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // HName
            // 
            this.HName.Text = "Name";
            this.HName.Width = 111;
            // 
            // Concert_Id
            // 
            this.Concert_Id.Text = "Concert ID";
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.Width = 98;
            // 
            // pesetasCol
            // 
            this.pesetasCol.Text = "Date";
            this.pesetasCol.Width = 172;
            // 
            // isCanceled
            // 
            this.isCanceled.Text = "IsCanceled?";
            // 
            // btnAddConcert
            // 
            this.btnAddConcert.Location = new System.Drawing.Point(12, 265);
            this.btnAddConcert.Name = "btnAddConcert";
            this.btnAddConcert.Size = new System.Drawing.Size(131, 23);
            this.btnAddConcert.TabIndex = 4;
            this.btnAddConcert.Text = "Add new concert";
            this.btnAddConcert.UseVisualStyleBackColor = true;
            this.btnAddConcert.Click += new System.EventHandler(this.btnAddConcert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Admin contol panel";
            // 
            // btnCancelConcert
            // 
            this.btnCancelConcert.Location = new System.Drawing.Point(440, 260);
            this.btnCancelConcert.Name = "btnCancelConcert";
            this.btnCancelConcert.Size = new System.Drawing.Size(131, 23);
            this.btnCancelConcert.TabIndex = 9;
            this.btnCancelConcert.Text = "Cancel Concert";
            this.btnCancelConcert.UseVisualStyleBackColor = true;
            this.btnCancelConcert.Click += new System.EventHandler(this.btnCancelConcert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Concert id";
            // 
            // tbConcertId
            // 
            this.tbConcertId.Location = new System.Drawing.Point(390, 262);
            this.tbConcertId.Name = "tbConcertId";
            this.tbConcertId.Size = new System.Drawing.Size(44, 20);
            this.tbConcertId.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPesetasFromTickets);
            this.groupBox1.Controls.Add(this.tbSoldTickets);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblSoldTickets);
            this.groupBox1.Controls.Add(this.btnGetSoldTickets);
            this.groupBox1.Controls.Add(this.timeTo);
            this.groupBox1.Controls.Add(this.timeFrom);
            this.groupBox1.Location = new System.Drawing.Point(12, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 76);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get number of sold tickets for all concerts between dates";
            // 
            // tbPesetasFromTickets
            // 
            this.tbPesetasFromTickets.Location = new System.Drawing.Point(428, 45);
            this.tbPesetasFromTickets.Name = "tbPesetasFromTickets";
            this.tbPesetasFromTickets.ReadOnly = true;
            this.tbPesetasFromTickets.Size = new System.Drawing.Size(108, 20);
            this.tbPesetasFromTickets.TabIndex = 6;
            // 
            // tbSoldTickets
            // 
            this.tbSoldTickets.Location = new System.Drawing.Point(428, 19);
            this.tbSoldTickets.Name = "tbSoldTickets";
            this.tbSoldTickets.ReadOnly = true;
            this.tbSoldTickets.Size = new System.Drawing.Size(108, 20);
            this.tbSoldTickets.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pesetas from all tickets:";
            // 
            // lblSoldTickets
            // 
            this.lblSoldTickets.AutoSize = true;
            this.lblSoldTickets.Location = new System.Drawing.Point(353, 22);
            this.lblSoldTickets.Name = "lblSoldTickets";
            this.lblSoldTickets.Size = new System.Drawing.Size(69, 13);
            this.lblSoldTickets.TabIndex = 3;
            this.lblSoldTickets.Text = "Sold Tickets:";
            // 
            // btnGetSoldTickets
            // 
            this.btnGetSoldTickets.Location = new System.Drawing.Point(215, 19);
            this.btnGetSoldTickets.Name = "btnGetSoldTickets";
            this.btnGetSoldTickets.Size = new System.Drawing.Size(75, 46);
            this.btnGetSoldTickets.TabIndex = 0;
            this.btnGetSoldTickets.Text = "Go";
            this.btnGetSoldTickets.UseVisualStyleBackColor = true;
            this.btnGetSoldTickets.Click += new System.EventHandler(this.btnGetSoldTickets_Click);
            // 
            // timeTo
            // 
            this.timeTo.Location = new System.Drawing.Point(9, 45);
            this.timeTo.Name = "timeTo";
            this.timeTo.Size = new System.Drawing.Size(200, 20);
            this.timeTo.TabIndex = 2;
            // 
            // timeFrom
            // 
            this.timeFrom.Location = new System.Drawing.Point(9, 19);
            this.timeFrom.Name = "timeFrom";
            this.timeFrom.Size = new System.Drawing.Size(200, 20);
            this.timeFrom.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbVenuecost);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tbTicketsToMakeProfits);
            this.groupBox2.Controls.Add(this.tbProfits);
            this.groupBox2.Controls.Add(this.tbIncome);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbConcertId2);
            this.groupBox2.Location = new System.Drawing.Point(12, 405);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 126);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a concert";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Concert id";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbTicketsToMakeProfits
            // 
            this.tbTicketsToMakeProfits.Location = new System.Drawing.Point(428, 68);
            this.tbTicketsToMakeProfits.Name = "tbTicketsToMakeProfits";
            this.tbTicketsToMakeProfits.ReadOnly = true;
            this.tbTicketsToMakeProfits.Size = new System.Drawing.Size(108, 20);
            this.tbTicketsToMakeProfits.TabIndex = 7;
            // 
            // tbProfits
            // 
            this.tbProfits.Location = new System.Drawing.Point(428, 94);
            this.tbProfits.Name = "tbProfits";
            this.tbProfits.ReadOnly = true;
            this.tbProfits.Size = new System.Drawing.Size(108, 20);
            this.tbProfits.TabIndex = 6;
            // 
            // tbIncome
            // 
            this.tbIncome.Location = new System.Drawing.Point(428, 16);
            this.tbIncome.Name = "tbIncome";
            this.tbIncome.ReadOnly = true;
            this.tbIncome.Size = new System.Drawing.Size(108, 20);
            this.tbIncome.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tickets needed to make profit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Current profit of concert";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Income if all tickets are sold";
            // 
            // tbConcertId2
            // 
            this.tbConcertId2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConcertId2.Location = new System.Drawing.Point(50, 30);
            this.tbConcertId2.Name = "tbConcertId2";
            this.tbConcertId2.Size = new System.Drawing.Size(53, 35);
            this.tbConcertId2.TabIndex = 1;
            // 
            // tbVenuecost
            // 
            this.tbVenuecost.Location = new System.Drawing.Point(428, 42);
            this.tbVenuecost.Name = "tbVenuecost";
            this.tbVenuecost.ReadOnly = true;
            this.tbVenuecost.Size = new System.Drawing.Size(108, 20);
            this.tbVenuecost.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Concert Cost";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 658);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbConcertId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewUsers);
            this.Controls.Add(this.btnCancelConcert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddConcert);
            this.Name = "MainForm";
            this.Text = "PILJETTER";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader HName;
        private System.Windows.Forms.ColumnHeader Concert_Id;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader pesetasCol;
        private System.Windows.Forms.Button btnAddConcert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelConcert;
        private System.Windows.Forms.ColumnHeader isCanceled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbConcertId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPesetasFromTickets;
        private System.Windows.Forms.TextBox tbSoldTickets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSoldTickets;
        private System.Windows.Forms.Button btnGetSoldTickets;
        private System.Windows.Forms.DateTimePicker timeTo;
        private System.Windows.Forms.DateTimePicker timeFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbTicketsToMakeProfits;
        private System.Windows.Forms.TextBox tbProfits;
        private System.Windows.Forms.TextBox tbIncome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbConcertId2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbVenuecost;
    }
}

