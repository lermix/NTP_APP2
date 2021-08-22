namespace NTP_Ivo_Ojvan.Forms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProperties = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.chBoxProducts = new System.Windows.Forms.CheckBox();
            this.chBoxUsers = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chBoxSettings = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProperties);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Controls.Add(this.btnSell);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnProperties
            // 
            this.btnProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProperties.Location = new System.Drawing.Point(0, 150);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(200, 50);
            this.btnProperties.TabIndex = 1;
            this.btnProperties.Text = "Postavke";
            this.btnProperties.UseVisualStyleBackColor = true;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.Location = new System.Drawing.Point(0, 100);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(200, 50);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "Korisnici";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.Location = new System.Drawing.Point(0, 50);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(200, 50);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Proizvodi";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnSell
            // 
            this.btnSell.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSell.Location = new System.Drawing.Point(0, 0);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(200, 50);
            this.btnSell.TabIndex = 0;
            this.btnSell.Text = "Prodaja";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // chBoxProducts
            // 
            this.chBoxProducts.AutoSize = true;
            this.chBoxProducts.Enabled = false;
            this.chBoxProducts.Location = new System.Drawing.Point(427, 16);
            this.chBoxProducts.Name = "chBoxProducts";
            this.chBoxProducts.Size = new System.Drawing.Size(92, 21);
            this.chBoxProducts.TabIndex = 1;
            this.chBoxProducts.Text = "Proizvodi ";
            this.chBoxProducts.UseVisualStyleBackColor = true;
            // 
            // chBoxUsers
            // 
            this.chBoxUsers.AutoSize = true;
            this.chBoxUsers.Enabled = false;
            this.chBoxUsers.Location = new System.Drawing.Point(427, 43);
            this.chBoxUsers.Name = "chBoxUsers";
            this.chBoxUsers.Size = new System.Drawing.Size(83, 21);
            this.chBoxUsers.TabIndex = 2;
            this.chBoxUsers.Text = "Korisnici";
            this.chBoxUsers.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(427, 150);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Osvježi";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // chBoxSettings
            // 
            this.chBoxSettings.AutoSize = true;
            this.chBoxSettings.Enabled = false;
            this.chBoxSettings.Location = new System.Drawing.Point(427, 70);
            this.chBoxSettings.Name = "chBoxSettings";
            this.chBoxSettings.Size = new System.Drawing.Size(88, 21);
            this.chBoxSettings.TabIndex = 4;
            this.chBoxSettings.Text = "Postavke";
            this.chBoxSettings.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chBoxSettings);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.chBoxUsers);
            this.Controls.Add(this.chBoxProducts);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.CheckBox chBoxProducts;
        private System.Windows.Forms.CheckBox chBoxUsers;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox chBoxSettings;
    }
}