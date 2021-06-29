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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.Button btnUsers;
    }
}