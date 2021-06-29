namespace NTP_Ivo_Ojvan.Forms
{
    partial class UsersForm
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
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.btnGetFromDatabase = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tboxUsername
            // 
            this.tboxUsername.Location = new System.Drawing.Point(104, 47);
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(224, 22);
            this.tboxUsername.TabIndex = 0;
            // 
            // tboxPassword
            // 
            this.tboxPassword.Location = new System.Drawing.Point(104, 75);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(224, 22);
            this.tboxPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.DisplayMember = "name";
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 16;
            this.listBoxUsers.Location = new System.Drawing.Point(563, 60);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(225, 372);
            this.listBoxUsers.TabIndex = 4;
            this.listBoxUsers.Visible = false;
            this.listBoxUsers.SelectedValueChanged += new System.EventHandler(this.listBoxUsers_SelectedValueChanged);
            // 
            // btnGetFromDatabase
            // 
            this.btnGetFromDatabase.Location = new System.Drawing.Point(563, 24);
            this.btnGetFromDatabase.Name = "btnGetFromDatabase";
            this.btnGetFromDatabase.Size = new System.Drawing.Size(144, 23);
            this.btnGetFromDatabase.TabIndex = 5;
            this.btnGetFromDatabase.Text = "Odaberi postoječi";
            this.btnGetFromDatabase.UseVisualStyleBackColor = true;
            this.btnGetFromDatabase.Click += new System.EventHandler(this.btnGetFromDatabase_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(253, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(253, 249);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(253, 188);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Zamjeni";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Id:";
            // 
            // tboxId
            // 
            this.tboxId.Enabled = false;
            this.tboxId.Location = new System.Drawing.Point(104, 13);
            this.tboxId.Name = "tboxId";
            this.tboxId.Size = new System.Drawing.Size(100, 22);
            this.tboxId.TabIndex = 10;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tboxId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGetFromDatabase);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.tboxUsername);
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Button btnGetFromDatabase;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxId;
    }
}