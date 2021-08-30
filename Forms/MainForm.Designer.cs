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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.btnProperties);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Controls.Add(this.btnSell);
            this.panel1.Name = "panel1";
            // 
            // btnProperties
            // 
            resources.ApplyResources(this.btnProperties, "btnProperties");
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.UseVisualStyleBackColor = true;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // btnUsers
            // 
            resources.ApplyResources(this.btnUsers, "btnUsers");
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnProducts
            // 
            resources.ApplyResources(this.btnProducts, "btnProducts");
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnSell
            // 
            resources.ApplyResources(this.btnSell, "btnSell");
            this.btnSell.Name = "btnSell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // chBoxProducts
            // 
            resources.ApplyResources(this.chBoxProducts, "chBoxProducts");
            this.chBoxProducts.Name = "chBoxProducts";
            this.chBoxProducts.UseVisualStyleBackColor = true;
            // 
            // chBoxUsers
            // 
            resources.ApplyResources(this.chBoxUsers, "chBoxUsers");
            this.chBoxUsers.Name = "chBoxUsers";
            this.chBoxUsers.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // chBoxSettings
            // 
            resources.ApplyResources(this.chBoxSettings, "chBoxSettings");
            this.chBoxSettings.Name = "chBoxSettings";
            this.chBoxSettings.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chBoxSettings);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.chBoxUsers);
            this.Controls.Add(this.chBoxProducts);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
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