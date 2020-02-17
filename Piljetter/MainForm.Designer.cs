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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancelConcert = new System.Windows.Forms.Button();
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
            this.listViewUsers.Location = new System.Drawing.Point(12, 141);
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
            this.btnAddConcert.Location = new System.Drawing.Point(25, 360);
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
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(412, 84);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 51);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Refresh";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancelConcert
            // 
            this.btnCancelConcert.Location = new System.Drawing.Point(25, 389);
            this.btnCancelConcert.Name = "btnCancelConcert";
            this.btnCancelConcert.Size = new System.Drawing.Size(131, 23);
            this.btnCancelConcert.TabIndex = 9;
            this.btnCancelConcert.Text = "Cancel Concert";
            this.btnCancelConcert.UseVisualStyleBackColor = true;
            this.btnCancelConcert.Click += new System.EventHandler(this.btnCancelConcert_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 467);
            this.Controls.Add(this.listViewUsers);
            this.Controls.Add(this.btnCancelConcert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddConcert);
            this.Name = "MainForm";
            this.Text = "PILJETTER";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancelConcert;
        private System.Windows.Forms.ColumnHeader isCanceled;
    }
}

